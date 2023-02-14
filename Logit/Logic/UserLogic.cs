using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class UserLogic : BaseContextLogic, IUserLogic
    {
        public UserLogic(ServiceContext serviceContext) : base(serviceContext) { }

        public List<UserItem> GetAlLUser()
        {
            return _serviceContext.Set<UserItem>().ToList();
        }
        public int InsertUserItem(UserItem userItem)
        {
            _serviceContext.Users.Add(userItem);
             _serviceContext.SaveChanges();
             return userItem.Id;
        }
        
        public void DeleteUserItem(int id)
        {
        var userToDelete = _serviceContext.Set<UserItem>()
            .Where(u => u.Id == id).First();             
             userToDelete.IsActive = false;
            _serviceContext.SaveChanges();
        }
        public void UpdataUserItem(UserItem userItem)
        {
            _serviceContext.Users.Update(userItem);
            _serviceContext.SaveChanges();
        }

       

       
    }
    
} 

   
       


