using Microsoft.Build.Framework;

namespace tekdostpatileri.Models
{
    public class Anasayfa
    {
        public int Id { get; set; }
        [Required]
        public string slider1başlık { get; set; }
        public string slider1yazı { get; set; }
        public string slider2başlık { get; set; }
        public string slider2yazı { get; set; }
        public string slider3başlık { get; set; }
        public string slider3yazı { get; set; }
        public string slider4başlık { get; set; }
        public string slider4yazı { get; set; }
        public string slider5başlık { get; set; }
        public string slider5yazı { get; set; }
        public string slider1img { get; set; }
        public string slider2img { get; set; }
        public string slider3img { get; set; }
        public string slider4img { get; set; }
        public string slider5img { get; set; }
        public string önsözsesleniş { get; set; }
        public string önsöz { get; set; }
    }
}