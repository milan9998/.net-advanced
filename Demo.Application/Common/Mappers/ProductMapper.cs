using Demo.Application.Common.Dto.Product;
using Demo.Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace Demo.Application.Common.Mappers;

[Mapper]
public static partial class ProductMapper
{
    public static partial ProductDetailsDto ToDto(this Product entity);

    public static  Product FromCreateDtoToEntity(this ProductCreateDto dto)
    {
        var product = new Product(dto.Name,dto.Description);
        
        return product;
    }

    public static Product ToCustomDto(this ProductCreateDto dto, Company company)
    {
        var product = new Product(dto.Name,dto.Description);
        return product;
    }
}