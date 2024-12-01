﻿using Demo.Application.Common.Dto.Product;
using Demo.Application.Common.Interfaces;
using Demo.Application.Common.Mappers;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Demo.Application.Products.Quries;

public record ProductDetailsQuery(string Id):IRequest<ProductDetailsDto>;

public class ProductDetailsQueryHandler(IDemoDbContext dbContext) : IRequestHandler<ProductDetailsQuery, ProductDetailsDto?>
{

    public async Task<ProductDetailsDto?> Handle(ProductDetailsQuery request, CancellationToken cancellationToken)
    {
        var result = await dbContext.Products.Include(x => x.Company).
            Where(x => x.Id == Guid.Parse(request.Id))
            .FirstOrDefaultAsync(cancellationToken: cancellationToken);

        var dto = result?.ToDto();
        return dto;
    }
}