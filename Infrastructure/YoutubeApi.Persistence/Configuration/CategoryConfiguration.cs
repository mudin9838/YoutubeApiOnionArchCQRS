using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configuration;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        Category category1 = new()
        {
            Id = 1,
            Name = "Electronics",
            Priority = 1,
            ParentId = 0,
            isDeleted = false,
            CreatedDate = DateTime.Now,
        };

        Category category2 = new()
        {
            Id = 2,
            Name = "Mobile",
            Priority = 2,
            ParentId = 0,
            isDeleted = false,
            CreatedDate = DateTime.Now,
        };


        Category parent1 = new()
        {
            Id = 3,
            Name = "Computer",
            Priority = 1,
            ParentId = 1,
            isDeleted = false,
            CreatedDate = DateTime.Now,
        };
        Category parent2 = new()
        {
            Id = 4,
            Name = "Computer",
            Priority = 1,
            ParentId = 2,
            isDeleted = false,
            CreatedDate = DateTime.Now,
        };

        builder.HasData(category1, category2, parent1, parent2);
    }
}
