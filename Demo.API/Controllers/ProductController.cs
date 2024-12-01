using Demo.Application.Common.Dto.Product;
using Demo.Application.Common.Interfaces;
using Demo.Application.Common.Mappers;
using Demo.Application.Products.Commands;
using Demo.Application.Products.Quries;
using Demo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.API.Controllers;

[ApiController]
[Route("product")]
public class ProductController(IDemoDbContext dbContext) : ApiBaseController
{
    [HttpGet]
    public async Task<IActionResult> Details([FromQuery]ProductDetailsQuery query)
    {
        return Ok(await Mediator.Send(query));
       
     
    }
    [HttpPost("create")]
    public async Task<IActionResult> Create(ProductCreateCommand product)
    {
       return Ok(await Mediator.Send(product));
       
    }

}