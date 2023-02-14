using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using NegocioApi.IServices;

namespace NegocioApi.Controllers
{
    [ApiController]
    [Route("[controller] /[action]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserServices _userService;

        public UserController(ILogger<UserController> logger, IUserServices userService)
        
        {
            _logger = logger;
            _userService = userService;
            
        }

        [HttpPost(Name = "InsertUser")]
        public int Post([FromHeader] string userName, [FromHeader] string userPassword, [FromBody] UserItem userItem)
        {
            //     _userService.ValidateCredentials(userItem);
            return _userService.InsertUser(userItem);
            
        }


        [HttpGet(Name = "GetAllUser")]
        public List<UserItem> GetAll()
        {
            //     _userService.ValidateCredentials(userItem);

            return _userService.GetAllUsers();          
        }

        [HttpDelete(Name = "DeleteUser")]
        public void DeleteUserItem([FromQuery] int Id)
        {
            _userService.DeleteUserItem(Id);
          
        }

        [HttpPatch(Name = "ModifyUser")]
        public void Patch([FromBody] UserItem userItem)
        {
            _userService.UpdateUser(userItem);           
        }

    }
}
