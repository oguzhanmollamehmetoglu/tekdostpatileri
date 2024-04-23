using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using tekdostpatileri.Models;

namespace tekdostpatileri.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        TekDostPatileriDbContext db = new TekDostPatileriDbContext();

		public IActionResult Index()
        {
            ViewModel model = new ViewModel();
            model.iletişims = db.iletişims.ToList();
			return View(model);
        }

        public IActionResult hakkında()
        {
            return View();
        }

		public IActionResult hizmetler()
		{
			return View();
		}

		public IActionResult galeri()
		{
			var galeris = db.galeris.ToList();
			return View(galeris);
		}

		public IActionResult iletişim()
		{
			return View();
		}
		public IActionResult bağış()
		{
			return View();
		}
		[HttpPost]
		public IActionResult iletişim(Mail m)  //Mail sınıfından m diye bir değişken tanımlarız
		{
			if(m.Adi != null && m.Soyadi != null && m.Email != null && m.Konu != null && m.Mesaj != null) { 
			try
			{
				SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Burası aynı kalacak
				client.UseDefaultCredentials = false;
				client.Credentials = new NetworkCredential("tekdostpatileri@gmail.com", "szbaaplxrirkhlda");
				client.EnableSsl = true;
				MailMessage msj = new MailMessage(); //Yeni bir MailMesajı oluşturuyoruz
				msj.From = new MailAddress(m.Email, m.Adi + " " + m.Soyadi); //iletişim kısmında girilecek mail buaraya gelecektir
				msj.To.Add("tekdostpatileri@gmail.com"); //Buraya kendi mail adresimizi yazıyoruz
				msj.Subject = m.Konu + "" + m.Email; //Buraya iletişim sayfasında gelecek konu ve mail adresini mail içeriğine yazacaktır
				msj.Body = m.Mesaj; //Mail içeriği burada aktarılacakır
				client.Send(msj); //Clien sent kısmında gönderme işlemi gerçeklecektir.
								  //Bu kısımdan itibaren sizden kullanıcıya gidecek mail bilgisidir 
				MailMessage msj1 = new MailMessage();
				msj1.From = new MailAddress("tekdostpatileri@gmail.com", "Admin");
				msj1.To.Add(m.Email); //Buraua iletişim sayfasında gelecek mail adresi gelecktir.
				msj1.Subject = "Mail'inize Cevap";
				msj1.Body = "Size en kısa zamanda döneceğiz. Teşekkür ederiz bizimle iletişime geçtiğiniz için.";
				client.Send(msj1);
				db.mails.Add(m);
				db.SaveChanges();
				TempData["h1"] = "Teşekkürler mailniz başarılı bir şekilde gönderildi."; //Bu kısımlarda ise kullanıcıya bilgi vermek amacı ile olur
				return Redirect("/Home/Index");
			}
			catch
			{
				TempData["h2"] = "Mesaj gönderilirken bir hata oluştu!"; //Bu kısımlarda ise kullanıcıya bilgi vermek amacı ile olur
				return Redirect("/Home/iletişim");
			}
			}
			else
			{
				TempData["h2"] = "Mesaj gönderilirken bir hata oluştu!"; //Bu kısımlarda ise kullanıcıya bilgi vermek amacı ile olur
				return View();
			}
		}

		public IActionResult siteharitası()
		{
		    var yuvamızs = db.yuvamızs.ToList();
			return View(yuvamızs);
		}

		public IActionResult yuvamız()
		{
			var yuvamızs = db.yuvamızs.ToList();
			return View(yuvamızs);
		}

        public IActionResult yuva1(int id)
        {
            var yuvamız = db.yuvamızs.FirstOrDefault(x => x.Id == id);
            if (yuvamız != null)
            {
                return View("Yuva/yuva1", yuvamız);
            }
            else
            {
                return View("Error"); // Eşleşme bulunamazsa hata sayfasına yönlendirme yapabilirsiniz.
            }
        }

		public IActionResult yapımcı()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}