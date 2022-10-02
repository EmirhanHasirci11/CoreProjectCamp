using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı boş geçmeyiniz")]
        public string Username{ get; set; }
        [Required(ErrorMessage ="Lütfen şifrenizi boş geçmeyiniz")]
        public string Password{ get; set; }
    }
}
