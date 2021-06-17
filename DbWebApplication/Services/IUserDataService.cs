using DbWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbWebApplication.Services
{
    interface IUserDataService
    {
        //Basic CRUD App Actions
        List<UserModel> GetAllUsers();
        List<UserModel> SearchUsers();
        UserModel GetUserById(int id);
        int Insert(UserModel user);
        int Delete(UserModel user);
        int Update(UserModel user);
    }
}
