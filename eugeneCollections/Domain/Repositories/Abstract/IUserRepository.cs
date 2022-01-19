using eugeneCollections.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.Abstract
{
    public interface IUserRepository
    {
        public User GetUserById(string id);
        public IQueryable<User> GetAllUsers();
        public void DeleteUserById(string id);
        public void BlockUserById(string id);
        public void UnblockUserById(string id);
        public void SetAdmin(string id);
    }
}
