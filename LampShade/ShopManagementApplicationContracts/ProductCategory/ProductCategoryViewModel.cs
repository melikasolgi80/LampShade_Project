﻿namespace ShopManagement.Application.Contracts.ProductCategory
{   //پنل ادمین 
    public class ProductCategoryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }

        public string CreationDate { get; set; }
        public long  ProductsCount { get; set; }    //نعداد محصولات
    }
}
