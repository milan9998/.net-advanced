using Demo.Application.Common.Dto.Product;
using Demo.Application.Common.Exceptions;
using Demo.Application.Common.Interfaces;
using Demo.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Demo.Application.Common.Mappers;
namespace Demo.Application.Products.Commands;

public record ProductCreateCommand(ProductCreateDto Product): IRequest<ProductDetailsDto?>;

public class ProductDetailsCommandHandler(IDemoDbContext dbContext) : IRequestHandler<ProductCreateCommand, ProductDetailsDto?>
{
    public async Task<ProductDetailsDto?> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
    {
        
        var company = await dbContext.Companies.
            Where(x=>x.Id == request.Product.CompanyId)
            .FirstOrDefaultAsync(cancellationToken : cancellationToken);
        
        if (company == null)
        {
            throw new NotFoundException("Company does not exist");
        }


        var product = request.Product.FromCreateDtoToEntity().AddCompany(company);
        
        dbContext.Products.Add(product);
        await dbContext.SaveChangesAsync(cancellationToken);
        return product.ToDto();
    }
}













