﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain;
using ShopManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore.Repository;

namespace ShopManagement.Configuration
{
    public class ShopManagementBootstraper
    {

        public static void Configure(IServiceCollection services ,string connectionString)
        {
            services.AddTransient<IProductCategoryApplication,ProductCategoryApplication>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
          services.AddDbContext<shopContext>(x=>x.UseSqlServer(connectionString));
        }

    
    }
}