using FluentValidation;
using InciAlbum.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InciAlbum.BusinessLayer.ValidationRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator() 
        {
            RuleFor(x => x.mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez");
            RuleFor(x => x.name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.comment).NotEmpty().WithMessage("Müracaat Alanı Boş Geçilemez");
            RuleFor(x => x.comment).MinimumLength(10).WithMessage("Müracaat Alanı 10 Karakterden Fazla Olmalıdır");
        }
    }
}
