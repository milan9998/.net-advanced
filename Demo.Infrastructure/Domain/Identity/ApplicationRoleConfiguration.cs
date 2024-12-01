﻿using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Infrastructure.Domain.Identity;

public class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
{
    private const string AdminId = "40FEB7B4-B530-4EA2-B96F-582D88277E4B";
    private const string StudentServiceId = "891E6770-C605-4D45-B959-8906C5728935";
    private const string TeacherId = "3B690889-501F-4A19-B2F7-3C55F6D8BAC9";
    
    public void Configure(EntityTypeBuilder<ApplicationRole> builder)
    {
        builder.ToTable("Roles");
        builder.HasData(
            new ApplicationRole
            {
                Id = AdminId,
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
                ConcurrencyStamp = Guid.NewGuid().ToString()

            },
            new ApplicationRole
            {
                Id = StudentServiceId,
                Name = "StudentService",
                NormalizedName = "STUDENTSERVICE",
                ConcurrencyStamp = Guid.NewGuid().ToString()

            },
            new ApplicationRole
            {
                Id = TeacherId,
                Name = "Teacher",
                NormalizedName = "TEACHER",
                ConcurrencyStamp = Guid.NewGuid().ToString()

            }
        );
    }
}