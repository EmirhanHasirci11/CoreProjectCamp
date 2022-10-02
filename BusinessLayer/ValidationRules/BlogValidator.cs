using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            //Title
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş geçilemez");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog başlığı en az 5 karakter olabilir");
            RuleFor(x => x.BlogTitle).MaximumLength(50).WithMessage("Blog başlığı en fazla 50 karakter olabilir");
            //Content
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş geçilemez");
            RuleFor(x => x.BlogContent).MinimumLength(5).WithMessage("Blog içeriği en az 5 karakter olabilir");
            RuleFor(x => x.BlogContent).MaximumLength(50).WithMessage("Blog içeriği en fazla 50 karakter olabilir");
            //Image
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog resmi boş geçilemez");
        }
    }
}
