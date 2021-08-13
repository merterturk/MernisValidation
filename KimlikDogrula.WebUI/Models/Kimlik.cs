using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KimlikDogrula.WebUI.Models
{
    public class Kimlik
    {
        [Required(ErrorMessage = "TC Boş Bırakılamaz...")]
        [MaxLength(11, ErrorMessage = "TC Kimlik Numarası 11 Haneli Olmalıdır..."), MinLength(11, ErrorMessage = "TC Kimlik Numarası 11 Haneli Olmalıdır...")]
        public string TC { get; set; }

        [Required(ErrorMessage ="Ad Boş Bırakılamaz...")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Soyad Boş Bırakılamaz...")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Doğum Yılı Boş Bırakılamaz...")]
        [MaxLength(4,ErrorMessage ="Doğum Yılı 4 Haneli Olmalıdır..."),MinLength(4,ErrorMessage = "Doğum Yılı 4 Haneli Olmalıdır...")]
        public string DogumYili { get; set; }
    }
}