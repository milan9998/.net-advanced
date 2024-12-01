﻿using System.Reflection;
using Demo.Application.Common.Interfaces;
using Demo.Infrastructure.Configuration;
using Demo.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
    {
        var dbConfiguration = new PostgresDbConfiguration();
        configuration.GetSection("PostgresDbConfiguration").Bind(dbConfiguration);
        
        services.AddDbContext<ConnDbcontext>(options => 
            options.UseNpgsql(dbConfiguration.ConnectionString,
                x => x.MigrationsAssembly(typeof(ConnDbcontext).Assembly.GetName().Name)));
        
        services.AddScoped<IDemoDbContext>(provider => provider.GetRequiredService<ConnDbcontext>());
        return services;
        
    }

}