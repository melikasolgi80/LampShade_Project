using _0_FrameWork.Application;
using _0_FrameWork.Domain;


namespace ShopManagement.Application.Contracts.ProductCategory
{
    public interface IProductCategoryApplication 
    {
        OperationResult Create(CreateProductCategory command);
        OperationResult Edit(EditProductCategory command);
       EditProductCategory GetDetails(long id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);

    }
}
