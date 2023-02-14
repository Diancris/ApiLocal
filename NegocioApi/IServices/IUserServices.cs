using Entities.Entities;

namespace NegocioApi.IServices
{
    public interface IUserServices
    {
        List<UserItem> GetAllUsers();
        int InsertUser(UserItem userItem);

        void DeleteUserItem(int userId);
        void UpdateUser(UserItem userItem);
        
    }
}

