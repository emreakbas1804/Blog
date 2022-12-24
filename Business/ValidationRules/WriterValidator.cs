using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını ve soyadını girmeden kayıt olamaz.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("2 karakterden daha az isim olamaz.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("50 karakterden daha uzun değer giremezsiniz.");

            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez.");
            RuleFor(x => x.WriterMail).Matches(@"[@]+").WithMessage("Mail adresi @ ve . içermelidir.");

            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Parola boş geçilemez.");
            // RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Şifrede büyük harf olmalıdır.");
            // RuleFor(x => x.WriterPassword).Matches(@"[a-z]+").WithMessage("Şifrede küçük harf olmalıdır.");
            // RuleFor(x => x.WriterPassword).Matches(@"[0-9]+").WithMessage("Şifrede rakam olmalıdır.");
            // RuleFor(x => x.WriterPassword).MinimumLength(6).WithMessage("Şifre 6 karakterden az olamaz.");


        }
    }
}