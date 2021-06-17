using Bogus;
using DbWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbWebApplication.Services
{
    public class HardCodedSampleUserDataRepo : IUserDataService
    {
        static List<UserModel> usersList = new List<UserModel>();
        public int Delete(UserModel user)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetAllUsers()
        {
            if (usersList.Count == 0)
            {
                for (int i = 0; i < 100; i++)
                {
                    usersList.Add(new Faker<UserModel>()
                        .RuleFor(u => u.Id, i)
                        .RuleFor(u => u.Name, f => f.Name.FullName())
                        .RuleFor(u => u.Birthday, f => f.Date.Past())
                        );
                }
            }
            return usersList;
        }

        public UserModel GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(UserModel user)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> SearchUsers()
        {
            throw new NotImplementedException();
        }

        public int Update(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
