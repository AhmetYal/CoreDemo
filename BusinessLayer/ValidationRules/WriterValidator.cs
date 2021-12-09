using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public  class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Boş Bırakamazsın");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Boş Bırakamazsın");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Boş Bırakamazsın");
            RuleFor(x => x.WriterPassword).Equal(x=>x.WriterPassword).WithMessage("Şifre Eşleşmiyor");            
            RuleFor(x => x.WriterPassword).Must(IsPasswordValid).WithMessage("En az bir küçük bir büyük harf ve bir sayı içermelidir");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakater");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En az 50 karakater");
        }
        private bool IsPasswordValid(string arg)
        {
            try
            {
                Regex regex = new Regex(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]))");
                return regex.IsMatch(arg);
            }
            catch
            {
                return false;
            }
        }
    }
    
}
