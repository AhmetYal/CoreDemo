using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Boş bırakma")]
        public string NameSurname { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Boş bırakma")]
        public string Password { get; set; }
        [Display(Name = "Şifre Tekrarla")]
        [Compare("Password",ErrorMessage = "Boş bırakma")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Boş bırakma")]
        public string Mail { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Boş bırakma")]
        public string UserName { get; set; }
    }
}
