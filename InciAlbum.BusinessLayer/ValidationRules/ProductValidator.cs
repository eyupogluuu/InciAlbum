using FluentValidation;
using InciAlbum.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InciAlbum.BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.productName).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez");
            RuleFor(x => x.descreption).NotEmpty().WithMessage("Ürün Açıklaması Boş Geçilemez");
            RuleFor(x => x.descreption).MinimumLength(10).WithMessage("10 Karakterden Az Ürün Açıklması Girilemez");
            RuleFor(x => x.imageUrl).NotEmpty().WithMessage("Ürün Görseli Boş Geçilemez");
            RuleFor(x => x.price).NotEmpty().WithMessage("Ürün Fiyatı Boş Geçilemez");
        }
    }
}
