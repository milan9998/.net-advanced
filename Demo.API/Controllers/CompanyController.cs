using Demo.Application.Common.Interfaces;
using Demo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.API.Controllers;

[ApiController]
[Route("company")]
public class CompanyController(IDemoDbContext dbContext):ControllerBase
{
    private readonly IDemoDbContext _dbContext = dbContext;
    
    [HttpGet("details")]
    public async Task<IActionResult> GetCompanyDetails()
    {
        var result = await dbContext.Companies.
            Include(x=>x.Products).
            ToListAsync();
        return Ok(result);
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateCompany()
    {
        Company company = new Company(Guid.NewGuid(),"Tesla", "Tesla Company");
        
        dbContext.Companies.Add(company);
        await dbContext.SaveChangesAsync(new CancellationToken());
        return Ok();
    }
}