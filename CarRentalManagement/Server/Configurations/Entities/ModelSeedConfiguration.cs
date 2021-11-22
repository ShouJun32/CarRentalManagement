using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id = 1,
                    Name = "A31",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Model
                {
                    Id = 2,
                    Name = "A32",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}