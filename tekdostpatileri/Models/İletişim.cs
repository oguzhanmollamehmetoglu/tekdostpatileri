using Microsoft.Build.Framework;

namespace tekdostpatileri.Models
{
    public class İletişim
    {
        public int Id { get; set; }
        [Required]
        public string Adres { get; set; }
        public string Email { get; set; }

        public string Facebook { get; set; }
        public string İnstagram { get; set; }
        public string Tweater { get; set; }
        public string Youtube { get; set; }
    }
}
