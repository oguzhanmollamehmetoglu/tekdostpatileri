using Microsoft.Build.Framework;

namespace tekdostpatileri.Models
{
    public class Yuvamız
    {
        public int Id { get; set; }
        [Required]
        public string YuvaResim { get; set; }
        public string Yuvaİsim { get; set; }
        public string YuvaHikaye { get; set; }
        public string YuvaCinsi { get; set; }
        public string YuvaYaşı { get; set; }
        public string YuvaRengi { get; set; }
        public string YuvaCinsiyeti { get; set; }
    }
}
