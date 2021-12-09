using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Boş Bırakamazsın");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Boş Bırakamazsın");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Boş Bırakamazsın");
            RuleFor(x => x.BlogTitle).MinimumLength(2).WithMessage("En az 2 karakater");
            RuleFor(x => x.BlogContent).MinimumLength(2).WithMessage("En az 2 karakater");
            RuleFor(x => x.BlogContent).MaximumLength(50).WithMessage("En az 50 karakater");
            RuleFor(x => x.BlogTitle).MaximumLength(50).WithMessage("En az 500 karakater");
        }
    

    }
}
