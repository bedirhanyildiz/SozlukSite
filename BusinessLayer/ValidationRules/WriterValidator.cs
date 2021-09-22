using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Olamaz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Açıklama Boş Olamaz");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Giriniz");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Lütfen En Fazla 50 Karakter Giriniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda kısmını boş geçmeyiniz.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan Kısmını Boş Geçemezsiniz.");


        }
    }
}
