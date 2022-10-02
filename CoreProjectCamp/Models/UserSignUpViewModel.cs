using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Models
{
    public class UserSignUpViewModel
    {
        [Display( Name="Ad")]
        [Required(ErrorMessage ="Lütfen adınızı boş geçmeyiniz")]
        public string Name { get; set; }
        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Lütfen Soyadınızı boş geçmeyiniz")]
        public string Surname { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre kısmını boş geçmeyiniz")]
        public string Password { get; set; }
        [Display(Name = "Şifre Tekrar")]
        [Compare("Password",ErrorMessage = "Şifrelerin uyuştuğundan emin olunuz")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lütfen Mail Adresi kısmını boş geçmeyiniz")]
        public string Mail { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı kısmını boş geçmeyiniz")]
        public string UserName { get; set; }
       
        public bool IsCheckBoxActive{ get; set; }
    }
}
