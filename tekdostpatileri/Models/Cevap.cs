using System.ComponentModel.DataAnnotations;

namespace tekdostpatileri.Models
{
	public class Cevap
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Cevaplar { get; set; }
	}
}
