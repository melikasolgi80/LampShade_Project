﻿using _0_FrameWork.Application;
using System.ComponentModel.DataAnnotations;

namespace ShopManagement.Application.Contracts.ProductCategory
{   //پنل ادمین 
    public class CreateProductCategory
    {
        [Required( ErrorMessage= ValidationMessage.IsRequired)]
        public string Name { get;  set; }
        public string Description { get;  set; }
        public string Picture { get;  set; }
        public string PictureAlt { get;  set; }
        public string PictureTitle { get;  set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string KeyWords { get;  set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string MetaDescription { get;  set; }

        [Required(ErrorMessage = ValidationMessage.IsRequired)]
        public string Slug { get;  set; }

        

    }
}
