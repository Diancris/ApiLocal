using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using NegocioApi.IServices;

namespace NegocioApi.Controllers

{
    [ApiController]
    [Route("[controller] /[action]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpPost(Name = "InsertProduct")]
        public int Post([FromHeader] string userName, [FromHeader] string userPassword, [FromBody] ProductItem productItem)
        {
            //     _userService.ValidateCredentials(userItem);
            return _productService.InsertProduct(productItem);
        }


        [HttpGet(Name = "GetAllProducts")]
        public List<ProductItem> GetAll()
        {
            //     _userService.ValidateCredentials(userItem);
            return _productService.GetAllProducts();

        }
        
        [HttpDelete(Name = "DeleteProduct")]
        public void DeleteProductItem([FromQuery] int Id)
        {
             _productService.DeleteProductItem(Id);
        }

        [HttpPatch(Name = "ModifyProduct")]
        public void Patch([FromBody] ProductItem productItem)
        {
            _productService.UpdateProduct(productItem);
        }

    }




}




