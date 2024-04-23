using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net.Mail;
using System.Net;
using tekdostpatileri.Migrations;
using tekdostpatileri.Models;
using Microsoft.AspNetCore.Authorization;

namespace tekdostpatileri.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdminPaneliController : Controller
    {
        private IWebHostEnvironment _hostingEnvironment;
        private readonly IWebHostEnvironment _iweb;

        public AdminPaneliController(IWebHostEnvironment hostEnvironment, IWebHostEnvironment iweb)
        {
            _hostingEnvironment = hostEnvironment;
            _iweb = iweb;
        }

        TekDostPatileriDbContext db = new TekDostPatileriDbContext();

        public IActionResult Index()
        {
            ViewModel model = new ViewModel();
            model.logos = db.logos.ToList();
            var l = db.logos.FirstOrDefault();
            TempData["boş1"] = l;
            model.anasayfas = db.anasayfas.ToList();
            var A = db.anasayfas.FirstOrDefault();
            TempData["boş2"] = A;
            model.hakkındas = db.hakkındas.ToList();
            var H = db.hakkındas.FirstOrDefault();
            TempData["boş3"] = H;
			model.hizmetlers = db.hizmetlers.ToList();
			var Hİ = db.hizmetlers.FirstOrDefault();
			TempData["boş4"] = Hİ;
            model.mails = db.mails.ToList();
            var m = db.mails.FirstOrDefault();
            TempData["boş5"] = m;
            model.iletişims = db.iletişims.ToList();
            var i = db.iletişims.FirstOrDefault();
            TempData["boş6"] = i;
            model.ödemes = db.ödemes.ToList();
            var ö = db.ödemes.FirstOrDefault();
            TempData["boş7"] = ö;
            model.galeris = db.galeris.ToList();
            var g = db.galeris.FirstOrDefault();
            TempData["boş8"] = g;
            model.yuvamızs = db.yuvamızs.ToList();
            var y = db.yuvamızs.FirstOrDefault();
            TempData["boş9"] = y;
            return View(model);
        }

        /*Logo ************************************************/
        public IActionResult logo()
        {
            var logoVarmi1 = db.logos.FirstOrDefault();
            if (logoVarmi1 == null)
            {
                return View();
            }
            else
            {
                return Redirect("Index");
            }
        }
        [HttpPost]
        public async Task<IActionResult> logo(IFormFile LogoUrl, Logo logo)
        {
            if (LogoUrl != null)
            {
                string imageExtension = Path.GetExtension(LogoUrl.FileName);
                string imageName = Guid.NewGuid() + imageExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/icon/{imageName}");
                using var stream = new FileStream(path, FileMode.Create);
                logo.LogoUrl = imageName;
                db.logos.Add(logo);
                db.SaveChanges();
                await LogoUrl.CopyToAsync(stream);
            }
            TempData["Hatal"] = "Boş değer eklenmez!";
            return RedirectToAction();
        }
        public IActionResult Sil1(int id)
        {
            var sil = db.logos.Where(x => x.Id == id).FirstOrDefault();
            db.logos.Remove(sil);
            sil.LogoUrl = Path.Combine(_iweb.WebRootPath, "icon", sil.LogoUrl.ToString());
            FileInfo fi1 = new FileInfo(sil.LogoUrl.ToString());
            if (fi1 != null)
            {
                System.IO.File.Delete(sil.LogoUrl);
                fi1.Delete();
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        /**********************************************************/
        /*Anasayfa ************************************************/
        public IActionResult Anasayfa()
        {
            var anasayfa = db.anasayfas.FirstOrDefault();
            if (anasayfa == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("güncelle1");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Anasayfa(IFormFile slider1img, IFormFile slider2img, IFormFile slider3img, IFormFile slider4img, IFormFile slider5img, Anasayfa A)
        {
            if (slider1img != null && slider2img != null && slider3img != null && slider4img != null && slider5img != null && A.slider1başlık != null && A.slider2başlık != null && A.slider3başlık != null && A.slider4başlık != null && A.slider5başlık != null && A.slider1yazı != null && A.slider2yazı != null && A.slider3yazı != null && A.slider4yazı != null && A.slider5yazı != null && A.önsözsesleniş != null && A.önsöz != null)
            {
                string imageExtension1 = Path.GetExtension(slider1img.FileName);
                string imageExtension2 = Path.GetExtension(slider2img.FileName);
                string imageExtension3 = Path.GetExtension(slider3img.FileName);
                string imageExtension4 = Path.GetExtension(slider4img.FileName);
                string imageExtension5 = Path.GetExtension(slider5img.FileName);
                string imageName1 = Guid.NewGuid() + imageExtension1;
                string imageName2 = Guid.NewGuid() + imageExtension2;
                string imageName3 = Guid.NewGuid() + imageExtension3;
                string imageName4 = Guid.NewGuid() + imageExtension4;
                string imageName5 = Guid.NewGuid() + imageExtension5;
                string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Slider/{imageName1}");
                string path2 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Slider/{imageName2}");
                string path3 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Slider/{imageName3}");
                string path4 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Slider/{imageName4}");
                string path5 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Slider/{imageName5}");
                using var stream1 = new FileStream(path1, FileMode.Create);
                using var stream2 = new FileStream(path2, FileMode.Create);
                using var stream3 = new FileStream(path3, FileMode.Create);
                using var stream4 = new FileStream(path4, FileMode.Create);
                using var stream5 = new FileStream(path5, FileMode.Create);
                    A.slider1img = imageName1;
                    A.slider2img = imageName2;
                    A.slider3img = imageName3;
                    A.slider4img = imageName4;
                    A.slider5img = imageName5;
                    db.anasayfas.Add(A);
                    db.SaveChanges();
                await slider1img.CopyToAsync(stream1); slider2img.CopyToAsync(stream2); slider3img.CopyToAsync(stream3); slider4img.CopyToAsync(stream4); slider5img.CopyToAsync(stream5);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["HataA"] = "Boş bir değer eklenemez!";
                return View();
            }
        }
        public IActionResult Sil2(int id)
        {
            var sil2 = db.anasayfas.Where(x => x.Id == id).FirstOrDefault();
            db.anasayfas.Remove(sil2);
            sil2.slider1img = Path.Combine(_iweb.WebRootPath, "img/Slider/", sil2.slider1img.ToString());
            sil2.slider2img = Path.Combine(_iweb.WebRootPath, "img/Slider/", sil2.slider2img.ToString());
            sil2.slider3img = Path.Combine(_iweb.WebRootPath, "img/Slider/", sil2.slider3img.ToString());
            sil2.slider4img = Path.Combine(_iweb.WebRootPath, "img/Slider/", sil2.slider4img.ToString());
            sil2.slider5img = Path.Combine(_iweb.WebRootPath, "img/Slider/", sil2.slider5img.ToString());
            FileInfo fi1 = new FileInfo(sil2.slider1img.ToString());
            FileInfo fi2 = new FileInfo(sil2.slider2img.ToString());
            FileInfo fi3 = new FileInfo(sil2.slider3img.ToString()); 
            FileInfo fi4 = new FileInfo(sil2.slider4img.ToString()); 
            FileInfo fi5 = new FileInfo(sil2.slider5img.ToString());
            if (fi1 != null && fi2 != null && fi3 != null && fi4 != null && fi5 != null)
            {
                System.IO.File.Delete(sil2.slider1img);
                System.IO.File.Delete(sil2.slider2img);
                System.IO.File.Delete(sil2.slider3img);
                System.IO.File.Delete(sil2.slider4img);
                System.IO.File.Delete(sil2.slider5img);
                fi1.Delete();
                fi2.Delete();
                fi3.Delete();
                fi4.Delete();
                fi5.Delete();
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult güncelle1()
        {
            var anasayfa = db.anasayfas.FirstOrDefault();
            var güncellenecekData = db.anasayfas.Find(anasayfa.Id);
            return View(güncellenecekData);
        }
		[HttpPost]
		public async Task<IActionResult> güncelle1(IFormFile slider1img, IFormFile slider2img, IFormFile slider3img, IFormFile slider4img, IFormFile slider5img, Anasayfa model,string eskislider1, string eskislider2, string eskislider3, string eskislider4, string eskislider5)
        {
            if (model.slider1başlık != null && model.slider2başlık != null && model.slider3başlık != null && model.slider4başlık != null && model.slider5başlık != null && model.slider1yazı != null && model.slider2yazı != null && model.slider3yazı != null && model.slider4yazı != null && model.slider5yazı != null && model.önsözsesleniş != null && model.önsöz != null)
            {
                var güncelenecekData = db.anasayfas.Where(x => x.Id == model.Id).FirstOrDefault();

                if (slider1img != null)
                {
                    //eski resmi silme
                    var sil = db.anasayfas.Where(x => x.slider1img == eskislider1).FirstOrDefault();
                    sil.slider1img = Path.Combine(_iweb.WebRootPath, "img/Slider/", sil.slider1img.ToString());
                    FileInfo fi1 = new FileInfo(sil.slider1img.ToString());
                    if (fi1 != null)
                    {
                        System.IO.File.Delete(sil.slider1img);
                        fi1.Delete();
                    }
                    sil.slider1img = "";
                    db.SaveChanges();
                    //yeni resim ekleme
                    string imageExtension1 = Path.GetExtension(slider1img.FileName);
                    string imageName1 = Guid.NewGuid() + imageExtension1;
                    string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Slider/{imageName1}");
                    using var stream1 = new FileStream(path1, FileMode.Create);
                    sil.slider1img = imageName1;
                    db.SaveChanges();
                    await slider1img.CopyToAsync(stream1);
                }
                if (slider2img != null)
                {
                    //eski resmi silme
                    var sil2 = db.anasayfas.Where(x => x.slider2img == eskislider2).FirstOrDefault();
                    sil2.slider2img = Path.Combine(_iweb.WebRootPath, "img/Slider/", sil2.slider2img.ToString());
                    FileInfo fi2 = new FileInfo(sil2.slider2img.ToString());
                    if (fi2 != null)
                    {
                        System.IO.File.Delete(sil2.slider2img);
                        fi2.Delete();
                    }
                    sil2.slider2img = "";
                    db.SaveChanges();
                    //yeni resim ekleme
                    string imageExtension2 = Path.GetExtension(slider2img.FileName);
                    string imageName2 = Guid.NewGuid() + imageExtension2;
                    string path2 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Slider/{imageName2}");
                    using var stream2 = new FileStream(path2, FileMode.Create);
                    sil2.slider2img = imageName2;
                    db.SaveChanges();
                    await slider2img.CopyToAsync(stream2);
                }
                if (slider3img != null)
                {
                    //eski resmi silme
                    var sil3 = db.anasayfas.Where(x => x.slider3img == eskislider3).FirstOrDefault();
                    sil3.slider3img = Path.Combine(_iweb.WebRootPath, "img/Slider/", sil3.slider3img.ToString());
                    FileInfo fi3 = new FileInfo(sil3.slider3img.ToString());
                    if (fi3 != null)
                    {
                        System.IO.File.Delete(sil3.slider3img);
                        fi3.Delete();
                    }
                    sil3.slider3img = "";
                    db.SaveChanges();
                    //yeni resim ekleme
                    string imageExtension3 = Path.GetExtension(slider3img.FileName);
                    string imageName3 = Guid.NewGuid() + imageExtension3;
                    string path3 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Slider/{imageName3}");
                    using var stream3 = new FileStream(path3, FileMode.Create);
                    sil3.slider3img = imageName3;
                    db.SaveChanges();
                    await slider3img.CopyToAsync(stream3);
                }
                if (slider4img != null)
                {
                    //eski resmi silme
                    var sil4 = db.anasayfas.Where(x => x.slider4img == eskislider4).FirstOrDefault();
                    sil4.slider4img = Path.Combine(_iweb.WebRootPath, "img/Slider/", sil4.slider4img.ToString());
                    FileInfo fi4 = new FileInfo(sil4.slider4img.ToString());
                    if (fi4 != null)
                    {
                        System.IO.File.Delete(sil4.slider4img);
                        fi4.Delete();
                    }
                    sil4.slider4img = "";
                    db.SaveChanges();
                    //yeni resim ekleme
                    string imageExtension4 = Path.GetExtension(slider4img.FileName);
                    string imageName4 = Guid.NewGuid() + imageExtension4;
                    string path4 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Slider/{imageName4}");
                    using var stream4 = new FileStream(path4, FileMode.Create);
                    sil4.slider4img = imageName4;
                    db.SaveChanges();
                    await slider4img.CopyToAsync(stream4);
                }
                if (slider5img != null)
                {
                    //eski resmi silme
                    var sil5 = db.anasayfas.Where(x => x.slider5img == eskislider5).FirstOrDefault();
                    sil5.slider5img = Path.Combine(_iweb.WebRootPath, "img/Slider/", sil5.slider5img.ToString());
                    FileInfo fi5 = new FileInfo(sil5.slider5img.ToString());
                    if (fi5 != null)
                    {
                        System.IO.File.Delete(sil5.slider5img);
                        fi5.Delete();
                    }
                    sil5.slider5img = "";
                    db.SaveChanges();
                    //yeni resim ekleme
                    string imageExtension5 = Path.GetExtension(slider5img.FileName);
                    string imageName5 = Guid.NewGuid() + imageExtension5;
                    string path5 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Slider/{imageName5}");
                    using var stream5 = new FileStream(path5, FileMode.Create);
                    sil5.slider5img = imageName5;
                    db.SaveChanges();
                    await slider5img.CopyToAsync(stream5);
                }

                güncelenecekData.slider1başlık = model.slider1başlık;
                güncelenecekData.slider2başlık = model.slider2başlık;
                güncelenecekData.slider3başlık = model.slider3başlık;
                güncelenecekData.slider4başlık = model.slider4başlık;
                güncelenecekData.slider5başlık = model.slider5başlık;
                güncelenecekData.slider1yazı = model.slider1yazı;
                güncelenecekData.slider2yazı = model.slider2yazı;
                güncelenecekData.slider3yazı = model.slider3yazı;
                güncelenecekData.slider4yazı = model.slider4yazı;
                güncelenecekData.slider5yazı = model.slider5yazı;
                güncelenecekData.önsözsesleniş = model.önsözsesleniş;
                güncelenecekData.önsöz = model.önsöz;
              
                    db.anasayfas.Update(güncelenecekData);
                    db.SaveChanges();
                    return RedirectToAction("Index");
            }
            else
            {
                TempData["HataA"] = "Boş bir değer güncellenmez!";
                return View();
            }
        }
        /**********************************************************/
        /*Hakkımızda ************************************************/
        public IActionResult Hakkımızda()
        {
            var hakkında = db.hakkındas.FirstOrDefault();
            if (hakkında == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("güncelle2");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Hakkımızda(IFormFile kurucuresmi, IFormFile kuruluşimg, Hakkında h)
        {
            if (kurucuresmi != null && kuruluşimg != null && h.yazı1 != null && h.yazı2 != null && h.yazı3 != null && h.yazı4 != null && h.kuruluşunadı != null && h.kuruluşyazı1 != null && h.kuruluşyazı2 != null && h.kuruluşyazı3 != null && h.kuruluşamacıp1 != null && h.kuruluşamacıp2 != null && h.kuruluşamacıyazı1 != null && h.kuruluşamacıyazı2 != null && h.kuruluşamacıyazı3 != null && h.kuruluşamacıyazı4 != null && h.kuruluşamacıyazı5 != null && h.kuruluşamacıyazı6 != null && h.kuruluşamacıyazı7 != null && h.kuruluşamacıyazı8 != null && h.kuruluşamacıyazı9 != null && h.kuruluşamacıyazı10 != null && h.kuruluşamacıyazı11 != null)
            {
                string imageExtension1 = Path.GetExtension(kurucuresmi.FileName);
                string imageExtension2 = Path.GetExtension(kuruluşimg.FileName);
                string imageName1 = Guid.NewGuid() + imageExtension1;
                string imageName2 = Guid.NewGuid() + imageExtension2;
                string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName1}");
                string path2 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName2}");
                using var stream1 = new FileStream(path1, FileMode.Create);
                using var stream2 = new FileStream(path2, FileMode.Create);
                h.kurucuresmi = imageName1;
                h.kuruluşimg = imageName2;
                db.hakkındas.Add(h);
                db.SaveChanges();
                await kurucuresmi.CopyToAsync(stream1); kuruluşimg.CopyToAsync(stream2);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["HataH"] = "Boş bir değer eklenemez!";
                return View();
            }
        }
        public IActionResult Sil3(int id)
        {
            var sil3 = db.hakkındas.Where(x => x.Id == id).FirstOrDefault();
            db.hakkındas.Remove(sil3);

            sil3.kurucuresmi = Path.Combine(_iweb.WebRootPath, "img", sil3.kurucuresmi.ToString());
            sil3.kuruluşimg = Path.Combine(_iweb.WebRootPath, "img", sil3.kuruluşimg.ToString());
           
            FileInfo fi1 = new FileInfo(sil3.kurucuresmi.ToString());
            FileInfo fi2 = new FileInfo(sil3.kuruluşimg.ToString());
           
            if (fi1 != null && fi2 != null)
            {
                System.IO.File.Delete(sil3.kurucuresmi);
                System.IO.File.Delete(sil3.kuruluşimg);
                fi1.Delete();
                fi2.Delete();
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult güncelle2()
        {
            var hakkımızda = db.hakkındas.FirstOrDefault();
            var güncellenecekData = db.hakkındas.Find(hakkımızda.Id);
            return View(güncellenecekData);
        }
        [HttpPost]
        public async Task<IActionResult> güncelle2(IFormFile kurucuresmi, IFormFile kuruluşimg, Hakkında model,string eskihakkındafoto,string eskihakkındafoto2)
        {
            if (model.kuruluşunadı != null && model.kuruluşyazı1 != null && model.kuruluşyazı2 != null && model.kuruluşyazı3 != null && model.yazı1 != null && model.yazı2 != null && model.yazı3 != null && model.yazı4 != null  && model.kuruluşamacıp1 != null && model.kuruluşamacıp2 != null && model.kuruluşamacıyazı1 != null && model.kuruluşamacıyazı2 != null && model.kuruluşamacıyazı3 != null && model.kuruluşamacıyazı4 != null && model.kuruluşamacıyazı5 != null && model.kuruluşamacıyazı6 != null && model.kuruluşamacıyazı7 != null && model.kuruluşamacıyazı8 != null && model.kuruluşamacıyazı9 != null && model.kuruluşamacıyazı10 != null && model.kuruluşamacıyazı11 != null)
            {
                var güncelenecekData = db.hakkındas.Where(x => x.Id == model.Id).FirstOrDefault();
                if (kurucuresmi != null)
                {
                    //eski resmi silme
                    var sil = db.hakkındas.Where(x => x.kurucuresmi == eskihakkındafoto).FirstOrDefault();
                    sil.kurucuresmi = Path.Combine(_iweb.WebRootPath, "img", sil.kurucuresmi.ToString());
                    FileInfo fi1 = new FileInfo(sil.kurucuresmi.ToString());
                    if (fi1 != null)
                    {
                        System.IO.File.Delete(sil.kurucuresmi);
                        fi1.Delete();
                    }
                    sil.kurucuresmi = "";
                    db.SaveChanges();
                    //yeni resim ekleme
                    string imageExtension1 = Path.GetExtension(kurucuresmi.FileName);
                    string imageName1 = Guid.NewGuid() + imageExtension1;
                    string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName1}");
                    using var stream1 = new FileStream(path1, FileMode.Create);
                    sil.kurucuresmi = imageName1;
                    db.SaveChanges();
                    await kurucuresmi.CopyToAsync(stream1);
                }
                if (kuruluşimg != null)
                {
                    //eski resmi silme
                    var sil = db.hakkındas.Where(x => x.kuruluşimg == eskihakkındafoto2).FirstOrDefault();
                    sil.kuruluşimg = Path.Combine(_iweb.WebRootPath, "img/", sil.kuruluşimg.ToString());
                    FileInfo fi1 = new FileInfo(sil.kuruluşimg.ToString());
                    if (fi1 != null)
                    {
                        System.IO.File.Delete(sil.kuruluşimg);
                        fi1.Delete();
                    }
                    sil.kuruluşimg = "";
                    db.SaveChanges();
                    //yeni resim ekleme
                    string imageExtension1 = Path.GetExtension(kuruluşimg.FileName);
                    string imageName1 = Guid.NewGuid() + imageExtension1;
                    string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName1}");
                    using var stream1 = new FileStream(path1, FileMode.Create);
                    sil.kuruluşimg = imageName1;
                    db.SaveChanges();
                    await kuruluşimg.CopyToAsync(stream1);
                }
                güncelenecekData.kuruluşunadı = model.kuruluşunadı;
                güncelenecekData.kuruluşyazı1 = model.kuruluşyazı1;
                güncelenecekData.kuruluşyazı2 = model.kuruluşyazı2;
                güncelenecekData.kuruluşyazı3 = model.kuruluşyazı3;
                güncelenecekData.yazı1 = model.yazı1;
                güncelenecekData.yazı2 = model.yazı2;
                güncelenecekData.yazı3 = model.yazı3;
                güncelenecekData.yazı4 = model.yazı4;
                güncelenecekData.kuruluşamacıp1 = model.kuruluşamacıp1;
                güncelenecekData.kuruluşamacıp2 = model.kuruluşamacıp2;
                güncelenecekData.kuruluşamacıyazı1 = model.kuruluşamacıyazı1;
                güncelenecekData.kuruluşamacıyazı2 = model.kuruluşamacıyazı2;
                güncelenecekData.kuruluşamacıyazı3 = model.kuruluşamacıyazı3;
                güncelenecekData.kuruluşamacıyazı4 = model.kuruluşamacıyazı4;
                güncelenecekData.kuruluşamacıyazı5 = model.kuruluşamacıyazı5;
                güncelenecekData.kuruluşamacıyazı6 = model.kuruluşamacıyazı6;
                güncelenecekData.kuruluşamacıyazı7 = model.kuruluşamacıyazı7;
                güncelenecekData.kuruluşamacıyazı8 = model.kuruluşamacıyazı8;
                güncelenecekData.kuruluşamacıyazı9 = model.kuruluşamacıyazı9;
                güncelenecekData.kuruluşamacıyazı10 = model.kuruluşamacıyazı10;
                güncelenecekData.kuruluşamacıyazı11 = model.kuruluşamacıyazı11;

                db.hakkındas.Update(güncelenecekData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["HataH"] = "Boş bir değer güncellenmez!";
                return View();
            }
        }
		/**********************************************************/
		/*Hizmetler ************************************************/
		public IActionResult Hizmetler()
		{
			var hizmetler = db.hizmetlers.FirstOrDefault();
			if (hizmetler == null)
			{
				return View();
			}
			else
			{
				return RedirectToAction("güncelle3");
			}
		}
		[HttpPost]
		public async Task<IActionResult> Hizmetler(IFormFile sağlıkimg1, IFormFile sağlıkimg2, IFormFile kısırlaştırmaimg1, IFormFile kısırlaştırmaimg2, IFormFile donörimg1, IFormFile sponsorimg1, Hizmetler hi)
		{
			if (sağlıkimg1 != null && sağlıkimg2 != null && kısırlaştırmaimg1 != null && kısırlaştırmaimg2 != null && donörimg1 != null && sponsorimg1 != null && hi.ihbarp1 != null && hi.ihbarp2 != null && hi.sağlıkp1 != null && hi.sağlıkp2 != null && hi.sağlıkp3 != null && hi.kısırlaştırmap1 != null && hi.kısırlaştırmap2 != null && hi.kısırlaştırmap3 != null && hi.kısırlaştırmap4 != null && hi.kısırlaştırmap5 != null && hi.kısırlaştırmap6 != null && hi.kısırlaştırmap7 != null && hi.şiddetp1 != null && hi.şiddetp2 != null && hi.şiddetp3 != null && hi.şiddetp4 != null && hi.eğitimp1 != null && hi.donörp1 != null && hi.sponsorp1 != null)
			{
				string imageExtension1 = Path.GetExtension(sağlıkimg1.FileName);
				string imageExtension2 = Path.GetExtension(sağlıkimg2.FileName);
				string imageExtension3 = Path.GetExtension(kısırlaştırmaimg1.FileName);
				string imageExtension4 = Path.GetExtension(kısırlaştırmaimg2.FileName);
                string imageExtension5 = Path.GetExtension(donörimg1.FileName);
                string imageExtension6 = Path.GetExtension(sponsorimg1.FileName);
                string imageName1 = Guid.NewGuid() + imageExtension1;
				string imageName2 = Guid.NewGuid() + imageExtension2;
				string imageName3 = Guid.NewGuid() + imageExtension3;
				string imageName4 = Guid.NewGuid() + imageExtension4;
                string imageName5 = Guid.NewGuid() + imageExtension5;
                string imageName6 = Guid.NewGuid() + imageExtension6;
                string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName1}");
				string path2 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName2}");
				string path3 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName3}");
				string path4 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName4}");
                string path5 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName5}");
                string path6 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName6}");
                using var stream1 = new FileStream(path1, FileMode.Create);
				using var stream2 = new FileStream(path2, FileMode.Create);
				using var stream3 = new FileStream(path3, FileMode.Create);
				using var stream4 = new FileStream(path4, FileMode.Create);
                using var stream5 = new FileStream(path5, FileMode.Create);
                using var stream6 = new FileStream(path6, FileMode.Create);
                hi.sağlıkimg1 = imageName1;
				hi.sağlıkimg2 = imageName2;
				hi.kısırlaştırmaimg1 = imageName3;
				hi.kısırlaştırmaimg2 = imageName4;
                hi.donörimg1 = imageName5;
                hi.sponsorimg1 = imageName6;
                db.hizmetlers.Add(hi);
				db.SaveChanges();
				await sağlıkimg1.CopyToAsync(stream1); sağlıkimg2.CopyToAsync(stream2); kısırlaştırmaimg1.CopyToAsync(stream3); kısırlaştırmaimg2.CopyToAsync(stream4); donörimg1.CopyToAsync(stream5); sponsorimg1.CopyToAsync(stream6);
                return RedirectToAction("Index");
			}
			else
			{
				TempData["HataHİ"] = "Boş bir değer eklenemez!";
				return View();
			}
		}
		public IActionResult Sil4(int id)
		{
			var sil4 = db.hizmetlers.Where(x => x.Id == id).FirstOrDefault();
			db.hizmetlers.Remove(sil4);

			sil4.sağlıkimg1 = Path.Combine(_iweb.WebRootPath, "img", sil4.sağlıkimg1.ToString());
			sil4.sağlıkimg2 = Path.Combine(_iweb.WebRootPath, "img", sil4.sağlıkimg2.ToString());
			sil4.kısırlaştırmaimg1 = Path.Combine(_iweb.WebRootPath, "img", sil4.kısırlaştırmaimg1.ToString());
			sil4.kısırlaştırmaimg2 = Path.Combine(_iweb.WebRootPath, "img", sil4.kısırlaştırmaimg2.ToString());
            sil4.donörimg1 = Path.Combine(_iweb.WebRootPath, "img", sil4.donörimg1.ToString());
            sil4.sponsorimg1 = Path.Combine(_iweb.WebRootPath, "img", sil4.sponsorimg1.ToString());

            FileInfo fi1 = new FileInfo(sil4.sağlıkimg1.ToString());
			FileInfo fi2 = new FileInfo(sil4.sağlıkimg2.ToString());
			FileInfo fi3 = new FileInfo(sil4.kısırlaştırmaimg1.ToString());
			FileInfo fi4 = new FileInfo(sil4.kısırlaştırmaimg2.ToString());
            FileInfo fi5 = new FileInfo(sil4.donörimg1.ToString());
            FileInfo fi6 = new FileInfo(sil4.sponsorimg1.ToString());

            if (fi1 != null && fi2 != null && fi3 != null && fi4 != null && fi5 != null && fi6 != null)
			{
				System.IO.File.Delete(sil4.sağlıkimg1);
				System.IO.File.Delete(sil4.sağlıkimg2);
				System.IO.File.Delete(sil4.kısırlaştırmaimg1);
				System.IO.File.Delete(sil4.kısırlaştırmaimg2);
                System.IO.File.Delete(sil4.donörimg1);
                System.IO.File.Delete(sil4.sponsorimg1);
                fi1.Delete();
				fi2.Delete();
				fi3.Delete();
				fi4.Delete();
                fi5.Delete();
                fi6.Delete();
            }
			db.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult güncelle3()
		{
            var hizmetler = db.hizmetlers.FirstOrDefault();
            var güncellenecekData = db.hizmetlers.Find(hizmetler.Id);
            return View(güncellenecekData);
        }
		[HttpPost]
		public async Task<IActionResult> güncelle3(IFormFile sağlıkimg1, IFormFile sağlıkimg2, IFormFile kısırlaştırmaimg1, IFormFile kısırlaştırmaimg2, IFormFile donörimg1, IFormFile sponsorimg1, Hizmetler model,string eskihizmetfotoğraf, string eskihizmetfotoğraf2, string eskihizmetfotoğraf3, string eskihizmetfotoğraf4, string eskidonörimg1, string eskisponsorimg1)
		{
			if (model.ihbarp1 != null && model.ihbarp2 != null && model.sağlıkp1 != null && model.sağlıkp2 != null && model.sağlıkp3 != null &&  model.kısırlaştırmap1 != null && model.kısırlaştırmap2 != null && model.kısırlaştırmap3 != null && model.kısırlaştırmap4 != null && model.kısırlaştırmap5 != null && model.kısırlaştırmap6 != null && model.kısırlaştırmap7 != null && model.şiddetp1 != null && model.şiddetp2 != null && model.şiddetp3 != null && model.şiddetp4 != null && model.eğitimp1 != null && model.donörp1 != null && model.sponsorp1 != null)
			{
				var güncelenecekData = db.hizmetlers.Where(x => x.Id == model.Id).FirstOrDefault();          
                    if(sağlıkimg1 != null)
                    {
                        //eski resmi silme
                        var sil = db.hizmetlers.Where(x => x.sağlıkimg1 == eskihizmetfotoğraf).FirstOrDefault();

                        sil.sağlıkimg1 = Path.Combine(_iweb.WebRootPath, "img", sil.sağlıkimg1.ToString());
                        FileInfo fi1 = new FileInfo(sil.sağlıkimg1.ToString());
                        if (fi1 != null)
                        {
                            System.IO.File.Delete(sil.sağlıkimg1);
                            fi1.Delete();
                        }
                        sil.sağlıkimg1 = "";
                        db.SaveChanges();
                        //yeni resim ekleme
                        string imageExtension1 = Path.GetExtension(sağlıkimg1.FileName);
                        string imageName1 = Guid.NewGuid() + imageExtension1;
                        string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName1}");
                        using var stream1 = new FileStream(path1, FileMode.Create);
                        sil.sağlıkimg1 = imageName1;
                        db.SaveChanges();
                        await sağlıkimg1.CopyToAsync(stream1);
                    }
                    if (sağlıkimg2 != null)
                    {
                        //eski resmi silme
                        var sil = db.hizmetlers.Where(x => x.sağlıkimg2 == eskihizmetfotoğraf2).FirstOrDefault();
                        sil.sağlıkimg2 = Path.Combine(_iweb.WebRootPath, "img", sil.sağlıkimg2.ToString());
                        FileInfo fi1 = new FileInfo(sil.sağlıkimg2.ToString());
                        if (fi1 != null)
                        {
                            System.IO.File.Delete(sil.sağlıkimg2);
                            fi1.Delete();
                        }
                        sil.sağlıkimg2 = "";
                        db.SaveChanges();
                        //yeni resim ekleme
                        string imageExtension1 = Path.GetExtension(sağlıkimg2.FileName);
                        string imageName1 = Guid.NewGuid() + imageExtension1;
                        string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName1}");
                        using var stream1 = new FileStream(path1, FileMode.Create);
                        sil.sağlıkimg2 = imageName1;
                        db.SaveChanges();
                        await sağlıkimg2.CopyToAsync(stream1);
                    }
                    if (kısırlaştırmaimg1 != null)
                    {
                        //eski resmi silme
                        var sil = db.hizmetlers.Where(x => x.kısırlaştırmaimg1 == eskihizmetfotoğraf3).FirstOrDefault();
                        sil.kısırlaştırmaimg1 = Path.Combine(_iweb.WebRootPath, "img", sil.kısırlaştırmaimg1.ToString());
                        FileInfo fi1 = new FileInfo(sil.kısırlaştırmaimg1.ToString());
                        if (fi1 != null)
                        {
                            System.IO.File.Delete(sil.kısırlaştırmaimg1);
                            fi1.Delete();
                        }
                        sil.kısırlaştırmaimg1 = "";
                        db.SaveChanges();
                        //yeni resim ekleme
                        string imageExtension1 = Path.GetExtension(kısırlaştırmaimg1.FileName);
                        string imageName1 = Guid.NewGuid() + imageExtension1;
                        string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName1}");
                        using var stream1 = new FileStream(path1, FileMode.Create);
                        sil.kısırlaştırmaimg1 = imageName1;
                        db.SaveChanges();
                        await kısırlaştırmaimg1.CopyToAsync(stream1);
                    }
                    if (kısırlaştırmaimg2 != null)
                    {
                        //eski resmi silme
                        var sil = db.hizmetlers.Where(x => x.kısırlaştırmaimg2 == eskihizmetfotoğraf4).FirstOrDefault();
                        sil.kısırlaştırmaimg2 = Path.Combine(_iweb.WebRootPath, "img", sil.kısırlaştırmaimg2.ToString());
                        FileInfo fi1 = new FileInfo(sil.kısırlaştırmaimg2.ToString());
                        if (fi1 != null)
                        {
                            System.IO.File.Delete(sil.kısırlaştırmaimg2);
                            fi1.Delete();
                        }
                        sil.kısırlaştırmaimg2 = "";
                        db.SaveChanges();
                        //yeni resim ekleme
                        string imageExtension1 = Path.GetExtension(kısırlaştırmaimg2.FileName);
                        string imageName1 = Guid.NewGuid() + imageExtension1;
                        string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName1}");
                        using var stream1 = new FileStream(path1, FileMode.Create);
                        sil.kısırlaştırmaimg2 = imageName1;
                        db.SaveChanges();
                        await kısırlaştırmaimg2.CopyToAsync(stream1);
                    }
                     if (donörimg1 != null)
                    {
                        //eski resmi silme
                        var sil = db.hizmetlers.Where(x => x.donörimg1 == eskidonörimg1).FirstOrDefault();
                        sil.donörimg1 = Path.Combine(_iweb.WebRootPath, "img", sil.donörimg1.ToString());
                        FileInfo fi1 = new FileInfo(sil.donörimg1.ToString());
                        if (fi1 != null)
                        {
                            System.IO.File.Delete(sil.donörimg1);
                            fi1.Delete();
                        }
                        sil.donörimg1 = "";
                        db.SaveChanges();
                        //yeni resim ekleme
                        string imageExtension1 = Path.GetExtension(donörimg1.FileName);
                        string imageName1 = Guid.NewGuid() + imageExtension1;
                        string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName1}");
                        using var stream1 = new FileStream(path1, FileMode.Create);
                        sil.donörimg1 = imageName1;
                        db.SaveChanges();
                        await donörimg1.CopyToAsync(stream1);
                    }
                     if (sponsorimg1 != null)
                    {
                        //eski resmi silme
                        var sil = db.hizmetlers.Where(x => x.sponsorimg1 == eskisponsorimg1).FirstOrDefault();
                        sil.sponsorimg1 = Path.Combine(_iweb.WebRootPath, "img", sil.sponsorimg1.ToString());
                        FileInfo fi1 = new FileInfo(sil.sponsorimg1.ToString());
                        if (fi1 != null)
                        {
                            System.IO.File.Delete(sil.sponsorimg1);
                            fi1.Delete();
                        }
                        sil.sponsorimg1 = "";
                        db.SaveChanges();
                        //yeni resim ekleme
                        string imageExtension1 = Path.GetExtension(sponsorimg1.FileName);
                        string imageName1 = Guid.NewGuid() + imageExtension1;
                        string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/{imageName1}");
                        using var stream1 = new FileStream(path1, FileMode.Create);
                        sil.sponsorimg1 = imageName1;
                        db.SaveChanges();
                        await sponsorimg1.CopyToAsync(stream1);
                    }

                güncelenecekData.ihbarp1 = model.ihbarp1;
				güncelenecekData.ihbarp2 = model.ihbarp2;
				güncelenecekData.sağlıkp1 = model.sağlıkp1;
				güncelenecekData.sağlıkp2 = model.sağlıkp2;
				güncelenecekData.sağlıkp3 = model.sağlıkp3;
				güncelenecekData.kısırlaştırmap1 = model.kısırlaştırmap1;
				güncelenecekData.kısırlaştırmap2 = model.kısırlaştırmap2;
				güncelenecekData.kısırlaştırmap3 = model.kısırlaştırmap3;
				güncelenecekData.kısırlaştırmap4 = model.kısırlaştırmap4;
				güncelenecekData.kısırlaştırmap5 = model.kısırlaştırmap5;
				güncelenecekData.kısırlaştırmap6 = model.kısırlaştırmap6;
				güncelenecekData.kısırlaştırmap7 = model.kısırlaştırmap7;
				güncelenecekData.şiddetp1 = model.şiddetp1;
				güncelenecekData.şiddetp2 = model.şiddetp2;
				güncelenecekData.şiddetp3 = model.şiddetp3;
				güncelenecekData.şiddetp4 = model.şiddetp4;
                güncelenecekData.eğitimp1 = model.eğitimp1;
                güncelenecekData.donörp1 = model.donörp1;
                güncelenecekData.sponsorp1 = model.sponsorp1;
                db.hizmetlers.Update(güncelenecekData);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			else
			{
				TempData["HataHİ"] = "Boş bir değer güncellenmez!";
				return View();
			}
		}
		/**********************************************************/
		//mesajlar*******************************
		public IActionResult Mesajlar(int id)
		{
			var mail = db.mails.ToList();
			ViewBag.Mail = mail;
			var email = db.mails.Find(id);
			db.SaveChanges();
			return View("Mesajlar", email);
		}
		[HttpPost]
		public IActionResult Mesajlar(Mail m, Cevap c)
		{
			try
			{
				var data = db.mails.Where(x => x.Id == m.Id).FirstOrDefault();
				db.SaveChanges();
				SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Burası aynı kalacak
				client.UseDefaultCredentials = false;
				client.Credentials = new NetworkCredential("tekdostpatileri@gmail.com", "szbaaplxrirkhlda");
				client.EnableSsl = true;
				//Bu kısımdan itibaren sizden kullanıcıya gidecek mail bilgisidir 
				MailMessage msj1 = new MailMessage();
				msj1.From = new MailAddress("tekdostpatileri@gmail.com", "Admin");
				msj1.To.Add(data.Email); //Buraua iletişim sayfasında gelecek mail adresi gelecktir.
				msj1.Subject = "Mail'inize Cevap";
				msj1.Body = $"{c.Cevaplar}";//cevaplar
				client.Send(msj1);
				db.mails.Remove(data);
				db.SaveChanges();
				TempData["HataM1"] = "Cevabınız başarıyla gönderilmiştir."; //Bu kısımlarda ise kullanıcıya bilgi vermek amacı ile olur
				return RedirectToAction("Index");
			}
			catch
			{
				TempData["HataM2"] = "Cevabınız gönderilirken bir hata olıuştu."; //Bu kısımlarda ise kullanıcıya bilgi vermek amacı ile olur
				return RedirectToAction("Index");
			}
		}
		public IActionResult Sil5(int id)
		{
			var sil = db.mails.Where(x => x.Id == id).FirstOrDefault();
			db.mails.Remove(sil);
			db.SaveChanges();
			return RedirectToAction("Index");

		}
        //****************************************
        // İletişim ****************************************
        public IActionResult İletişim()
        {
            var iletişim = db.iletişims.FirstOrDefault();
            if (iletişim == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("güncelle4");
            }
        }
        [HttpPost]
        public IActionResult İletişim(İletişim model)
        {
            if (model.Adres != null && model.Email != null && model.Facebook != null && model.İnstagram != null && model.Tweater != null && model.Youtube != null)
            {
                db.iletişims.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Hataİ"] = "Boş bir değer eklenemez!";
                return View();
            }
        }
        public IActionResult Sil6(int id)
        {
            var sil = db.iletişims.Where(x => x.Id == id).FirstOrDefault();
            db.iletişims.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult güncelle4(int id)
        {
            var iletişim = db.iletişims.FirstOrDefault();
            var güncellenecekData = db.iletişims.Find(iletişim.Id);
            return View(güncellenecekData);
        }
        [HttpPost]
        public IActionResult güncelle4(İletişim model)
        {
            if (model.Adres != null && model.Email != null && model.Facebook != null && model.İnstagram != null && model.Tweater != null && model.Youtube != null)
            {
                var güncelenecekData = db.iletişims.Where(x => x.Id == model.Id).FirstOrDefault();
                güncelenecekData.Adres = model.Adres;
                güncelenecekData.Email = model.Email;
                güncelenecekData.Facebook = model.Facebook;
                güncelenecekData.İnstagram = model.İnstagram;
                güncelenecekData.Tweater = model.Tweater;
                güncelenecekData.Youtube = model.Youtube;
                db.iletişims.Update(güncelenecekData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Hataİ"] = "Boş bir değer güncellenmez!";
                return View();
            }
        }
        //*************************************************************
        // Ödeme ****************************************
        public IActionResult Ödeme()
        {
            var ödeme = db.ödemes.FirstOrDefault();
            if (ödeme == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("güncelle5");
            }
        }
        [HttpPost]
        public IActionResult Ödeme(Ödeme model)
        {
            if (model.BankaAd != null && model.BankaŞube != null && model.BankaŞehir != null && model.TL != null && model.USD != null && model.EURO != null )
            {
                db.ödemes.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["HataÖ"] = "Boş bir değer eklenemez!";
                return View();
            }
        }
        public IActionResult Sil7(int id)
        {
            var sil = db.ödemes.Where(x => x.Id == id).FirstOrDefault();
            db.ödemes.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult güncelle5(int id)
        {
            var ödeme = db.ödemes.FirstOrDefault();
            var güncellenecekData = db.ödemes.Find(ödeme.Id);
            return View(güncellenecekData);
        }
        [HttpPost]
        public IActionResult güncelle5(Ödeme model)
        {
            if (model.BankaAd != null && model.BankaŞube != null && model.BankaŞehir != null && model.TL != null && model.USD != null && model.EURO != null)
            {
                var güncelenecekData = db.ödemes.Where(x => x.Id == model.Id).FirstOrDefault();
                güncelenecekData.BankaAd = model.BankaAd;
                güncelenecekData.BankaŞube = model.BankaŞube;
                güncelenecekData.BankaŞehir = model.BankaŞehir;
                güncelenecekData.TL = model.TL;
                güncelenecekData.USD = model.USD;
                güncelenecekData.EURO = model.EURO;
                db.ödemes.Update(güncelenecekData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["HataÖ"] = "Boş bir değer güncellenmez!";
                return View();
            }
        }
        //*************************************************************
        // Galeri ****************************************
        public IActionResult Galeri()
        {
		     return View();
		}
        [HttpPost]
        public async Task<IActionResult> Galeri(IFormFile Resimler,Galeri model)
        {
            if (Resimler != null)
            {
                string imageExtension = Path.GetExtension(Resimler.FileName);
                string imageName = Guid.NewGuid() + imageExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Galeri/{imageName}");
                using var stream = new FileStream(path, FileMode.Create);
                model.Resimler = imageName;
                db.galeris.Add(model);
                db.SaveChanges();
                await Resimler.CopyToAsync(stream);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["HataG"] = "Boş bir değer eklenemez!";
                return View();
            }
        }
        public IActionResult Sil8(int id)
        {
            var sil = db.galeris.Where(x => x.Id == id).FirstOrDefault();
            db.galeris.Remove(sil);
            sil.Resimler = Path.Combine(_iweb.WebRootPath, "img/Galeri/", sil.Resimler.ToString());
            FileInfo fi1 = new FileInfo(sil.Resimler.ToString());
            if (fi1 != null)
            {
                System.IO.File.Delete(sil.Resimler);
                fi1.Delete();
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //*************************************************************
        //**Yuvamız *******************************************************
        public IActionResult Yuvamız()
        {
                return View();
        }
        [HttpPost]
        public async Task<IActionResult> Yuvamız(IFormFile YuvaResim, Yuvamız model)
        {
            if (YuvaResim != null && model.Yuvaİsim != null && model.YuvaCinsi != null && model.YuvaYaşı != null && model.YuvaCinsiyeti != null && model.YuvaRengi != null && model.YuvaHikaye != null)
            {
                string imageExtension1 = Path.GetExtension(YuvaResim.FileName);
                string imageName1 = Guid.NewGuid() + imageExtension1;
                string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Yuvamız/{imageName1}");
                using var stream1 = new FileStream(path1, FileMode.Create);
                model.YuvaResim = imageName1;
                db.yuvamızs.Add(model);
                db.SaveChanges();
                await YuvaResim.CopyToAsync(stream1);
                return RedirectToAction("Index");
            }
            else
            {
                TempData["HataY"] = "Boş bir değer eklenemez!";
                return View();
            }
        }
        public IActionResult Sil9(int id)
        {
            var sil = db.yuvamızs.Where(x => x.Id == id).FirstOrDefault();
            db.yuvamızs.Remove(sil);
            sil.YuvaResim = Path.Combine(_iweb.WebRootPath, "img/Yuvamız/", sil.YuvaResim.ToString());
            FileInfo fi1 = new FileInfo(sil.YuvaResim.ToString());
            if (fi1 != null)
            {
                System.IO.File.Delete(sil.YuvaResim);
                fi1.Delete();
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult güncelle6(int id)
        {
            var güncellenecekData = db.yuvamızs.Find(id);
            db.SaveChanges();
            return View("güncelle6", güncellenecekData);
        }
        [HttpPost]
        public async Task<IActionResult> güncelle6(IFormFile YuvaResim, Yuvamız model,string eskiyuvaresim)
        {
            if (model.Yuvaİsim != null && model.YuvaCinsi != null && model.YuvaYaşı != null && model.YuvaCinsiyeti != null && model.YuvaRengi != null && model.YuvaHikaye != null)
            {
                var güncelenecekData = db.yuvamızs.Where(x => x.Id == model.Id).FirstOrDefault();
                if(YuvaResim != null)
                {
                    //eski resmi silme
                    var sil = db.yuvamızs.Where(x => x.YuvaResim == eskiyuvaresim).FirstOrDefault();
                    sil.YuvaResim = Path.Combine(_iweb.WebRootPath, "img/Yuvamız/", sil.YuvaResim.ToString());
                    FileInfo fi1 = new FileInfo(sil.YuvaResim.ToString());
                    if (fi1 != null)
                    {
                        System.IO.File.Delete(sil.YuvaResim);
                        fi1.Delete();
                    }
                    sil.YuvaResim = "";
                    db.SaveChanges();

                    //yeni resim ekleme
                    string imageExtension1 = Path.GetExtension(YuvaResim.FileName);
                    string imageName1 = Guid.NewGuid() + imageExtension1;
                    string path1 = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/img/Yuvamız/{imageName1}");
                    using var stream1 = new FileStream(path1, FileMode.Create);
                    sil.YuvaResim = imageName1;
                    db.SaveChanges();
                    await YuvaResim.CopyToAsync(stream1);
                }
                güncelenecekData.YuvaCinsi = model.YuvaCinsi;
                güncelenecekData.YuvaYaşı = model.YuvaYaşı;
                güncelenecekData.Yuvaİsim = model.Yuvaİsim;
                güncelenecekData.YuvaRengi = model.YuvaRengi;
                güncelenecekData.YuvaCinsiyeti = model.YuvaCinsiyeti;
                güncelenecekData.YuvaHikaye = model.YuvaHikaye;

                db.yuvamızs.Update(güncelenecekData);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                TempData["HataY"] = "Boş bir değer güncellenmez!";
                return View();
            }
        }
        /**********************************************************/
        public async Task<IActionResult> çıkış()
		{
			await HttpContext.SignOutAsync();
			return Redirect("/Home/Index");
		}
	}
}
