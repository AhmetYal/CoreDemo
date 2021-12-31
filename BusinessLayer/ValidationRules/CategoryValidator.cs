using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public  class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Boş Bırakamazsın");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Boş Bırakamazsın");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("En az 2 karakater");
            RuleFor(x => x.CategoryDescription).MinimumLength(2).WithMessage("En az 2 karakater");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("En az 50 karakater");
            RuleFor(x => x.CategoryDescription).MaximumLength(50).WithMessage("En az 500 karakater");
        }
    }
}
