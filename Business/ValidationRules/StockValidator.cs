using Entities;
using FluentValidation;

namespace Business.ValidationRules
{
    public class StockValidator : AbstractValidator<Stock>
    {
        public StockValidator()
        {
            RuleFor(x => x.Quantity).NotEmpty().WithMessage("Quantity cannot be Empty");
            RuleFor(x => x.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than 0");
        }
    }
}
