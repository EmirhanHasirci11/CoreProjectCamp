using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Author
    {
        [Key]
        public int AuthorID{ get; set; }
        public string AuthorName{ get; set; }
        public string AuthorSurname{ get; set; }
        public string AuthorImage{ get; set; }
        public string AuthorMail{ get; set; }
        public string AuthorPassword{ get; set; }
        [Required(ErrorMessage ="Şifrenizi tekrar girerek onaylamanız zorunludur")]
        [Compare("AuthorPassword",ErrorMessage ="Şifrelerin eşleştiğinden emin olun")]
        public string AuthorConfirmPassword{ get; set; }
        public bool AuthorStatus{ get; set; }
        public ICollection<Blog> Blogs{ get; set; }
    }
}
