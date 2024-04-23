using Microsoft.Build.Framework;

namespace tekdostpatileri.Models
{
    public class Giriş
    {
        public int Id { get; set; }
        [Required]
        public string KullanıcıAdı {get; set;}
        public string Şifre {get; set;}
    }
}
