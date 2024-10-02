using FluentValidation;
using InciAlbum.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InciAlbum.BusinessLayer.ValidationRules
{
    public class StuffValidator:AbstractValidator<Stuff>
    {
        public StuffValidator()
        {
            RuleFor(x=>x.nameSurname).NotEmpty().WithMessage(x=>ValidatorOptions.Global.LanguageManager.GetString("Bu Alan Boş Geçilemez",new System.Globalization.CultureInfo("tr")));
            RuleFor(x=>x.tittle).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x=>x.imageUrl).NotEmpty().WithMessage("Bu Alan Boş Geçilemez");
            RuleFor(x=>x.nameSurname).MinimumLength(5).WithMessage("En Az 5 Karakter Giriniz");
        }
    }
}
