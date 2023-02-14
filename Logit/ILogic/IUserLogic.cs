using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IUserLogic
    {
        List<UserItem> GetAlLUser();
        int  InsertUserItem(UserItem userItem);
        void DeleteUserItem(int userId);
        void UpdataUserItem(UserItem userItem);


    }            
        

   }





