using _0_Framework.Application;
using _0_FrameWork.Application;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain;
using ShopManagement.Domain.ProductCategoryAgg;


namespace ShopManagement.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
     
        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }
        
        public OperationResult Create(CreateProductCategory command)
        {
          var operation= new OperationResult();
            if (_productCategoryRepository.Exists(x=>x.Name==command.Name))
                return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد.لطفا مجدد نلاش فرمایید");
          
            var Slug = command.Slug.Slugify();
            var productCategory = new ProductCategory(command.KeyWords,command.PictureAlt,command.Name,
                command.Description, command.MetaDescription,
                command.Picture, command.PictureTitle, Slug);

            _productCategoryRepository.Create(productCategory);
            _productCategoryRepository.SaveChanges();
            return operation.Succeded();
        
        }

        public OperationResult Edit(EditProductCategory command)
        {
            var operation= new OperationResult();
            var productCategory = _productCategoryRepository.Get(command.Id);
            if (productCategory == null)
                return operation.Failed("رکورد مطابق با اطلاعات یافت نشد .لطفا مجدد تلاش کنید");

            if (_productCategoryRepository.Exists(x => x.Name == command.Name && x.Id != command.Id))
            return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد.لطفا مجدد نلاش فرمایید");

            var Slug = command.Slug.Slugify();
            productCategory.Edit(command.KeyWords, command.PictureAlt, command.Name,
                command.Description, command.MetaDescription,
                command.Picture, command.PictureTitle, Slug);

    
            _productCategoryRepository.SaveChanges();
            return operation.Succeded();
        }

        public EditProductCategory GetDetails(long id)
        {
            return _productCategoryRepository.GetDetails(id);
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            return _productCategoryRepository.Search(searchModel);
        }
    }
}