using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Infrastructure.EFCore.Mapping;


namespace ShopManagement.Infrastructure.EFCore
{
    public class shopContext : DbContext
    {
        public DbSet<ProductCategory> ProductCategories{get;set;}


        public shopContext(DbContextOptions<shopContext> options) :base(options) 
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ProductCategorymapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }



    }
}
