using Microsoft.Build.Framework;

namespace tekdostpatileri.Models
{
    public class Logo
    {
        public int Id { get; set; }
        [Required]
        public string LogoUrl { get; set; }
    }
}
