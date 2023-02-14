using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using NegocioApi.IServices;


namespace NegocioApi.Services
{
    public class UserService : IUserServices
    {
        private readonly IUserLogic _userLogic;
        public UserService(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        public int InsertUser(UserItem userItem)
        {
            _userLogic.InsertUserItem(userItem);
            return userItem.Id;
        }

        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdataUserItem(userItem);
        }

        public List<UserItem> GetAllUsers()
        {
            return _userLogic.GetAlLUser();
        }

        public void DeleteUserItem(int Id)
        {
            _userLogic.DeleteUserItem(Id);
        }
    }

}


