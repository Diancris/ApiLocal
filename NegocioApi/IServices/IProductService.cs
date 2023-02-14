using Entities.Entities;

namespace NegocioApi.IServices
{
    public interface IProductService
    {
        List<ProductItem> GetAllProducts();
        int InsertProduct(ProductItem productItem);

        void DeleteProductItem(int productId);
        void UpdateProduct(ProductItem productItem);
    }
}

