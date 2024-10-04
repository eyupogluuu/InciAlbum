using FluentValidation;
using InciAlbum.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InciAlbum.BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.tittle).NotEmpty().WithMessage("Başlık Alanı Boş Geçilemez");
            RuleFor(x => x.imageUrl).NotEmpty().WithMessage("Resim Yolu Alanı Boş Geçilemez");
            RuleFor(x => x.tittle).MaximumLength(15).WithMessage("15 Karakterden Fazla Girilemez");
        }
    }
}
