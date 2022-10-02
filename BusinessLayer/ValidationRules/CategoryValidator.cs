using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage("Kategori adı en az 5 karakter olabilir");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori adı en fazla 50 karakter olabilir");
            //Content
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Blog içeriği boş geçilemez");
            RuleFor(x => x.CategoryDescription).MinimumLength(5).WithMessage("Kategori açıklaması en az 5 karakter olabilir");
            RuleFor(x => x.CategoryDescription).MaximumLength(50).WithMessage("Kategori açıklaması en fazla 50 karakter olabilir");
            //Image
            RuleFor(x => x.CategoryColor).NotEmpty().WithMessage("Kategori rengi boş geçilemez");
        }
    }
}
