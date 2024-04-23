using System.ComponentModel.DataAnnotations;

namespace tekdostpatileri.Models
{
    public class Ödeme
    {
        public int Id { get; set; }
        [Required]
        public string BankaAd { get; set; }
        public string BankaŞube { get; set; }
        public string BankaŞehir { get; set; }
        public string TL { get; set; }
        public string USD { get; set; }
        public string EURO { get; set; }
    }
}
