using FluentValidation;

namespace Demo.Application.Products.Quries;

public class ProductDetailsQueryModelValidator : AbstractValidator<ProductDetailsQuery>
{
    public ProductDetailsQueryModelValidator()
    {
        RuleFor(x=>x.Id).NotEmpty().WithMessage("Id cannot be empty").MinimumLength(3);
    }
    
}