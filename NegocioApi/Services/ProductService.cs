using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using NegocioApi.IServices;

namespace NegocioApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }
        public int InsertProduct(ProductItem productItem)
        {
            _productLogic.InsertProductItem(productItem);
            return productItem.Id;

        }
           public List<ProductItem> GetAllProducts()
        {
            return _productLogic.GetAllProducts();
        }
        public void DeleteProductItem(int productId)
        {
            _productLogic.DeleteProductItem(productId);
        }
               
        public void UpdateProduct(ProductItem productItem)
        {
            _productLogic.UpdateProductItem(productItem);
        }
    }
}