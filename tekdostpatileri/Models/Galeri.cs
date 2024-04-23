using Microsoft.Build.Framework;

namespace tekdostpatileri.Models
{
    public class Galeri
    {
        public int Id { get; set; }
        [Required]
        public string Resimler { get; set; }
    }
}
