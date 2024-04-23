using System.ComponentModel.DataAnnotations;

namespace tekdostpatileri.Models
{
	public class Mail
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Adi { get; set; }
		public string Soyadi { get; set; }
		public string Email { get; set; }
		public string Konu { get; set; }
		public string Mesaj { get; set; }
	}
}
