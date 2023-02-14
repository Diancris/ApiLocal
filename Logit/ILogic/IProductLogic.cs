using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{   
    public interface IProductLogic
    {
        List<ProductItem> GetAllProducts();
        int InsertProductItem(ProductItem productItem);
        void DeleteProductItem(int productId);
        
        void UpdateProductItem(ProductItem productItem);
    }
}

   
  