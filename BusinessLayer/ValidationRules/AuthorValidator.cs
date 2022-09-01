using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.AuthorName).NotEmpty().WithMessage("Yazar ismi boş geçilemez");
            RuleFor(x => x.AuthorSurname).NotEmpty().WithMessage("Yazar ismi boş geçilemez");
            RuleFor(x => x.AuthorMail).NotEmpty().WithMessage("Yazar maili boş geçilemez");
            RuleFor(x => x.AuthorMail).Matches(@"[@,.]+").WithMessage("Yazar maili @ ve . içermelidir");
            RuleFor(x => x.AuthorPassword).NotEmpty().WithMessage("Yazar şifresi boş geçilemez");
            RuleFor(x => x.AuthorConfirmPassword).NotEmpty().WithMessage("Lütfen şifrenizi onaylayınız");
            RuleFor(x => x.AuthorConfirmPassword).Equal(x => x.AuthorPassword).WithMessage("Şifreleriniz uyuşması gerekir");
            RuleFor(x => x.AuthorPassword).Matches(@"[A-Z]+").WithMessage("Şifre en az 1 adet büyük harf içermelidir");
            RuleFor(x => x.AuthorPassword).Matches(@"[A-Z]+").WithMessage("Şifre en az 1 adet büyük harf içermelidir");
            RuleFor(x => x.AuthorPassword).Matches(@"[0-9]+").WithMessage("Şifre en az 1 adet rakam içermelidir");
            

        }
    }
}
