using eugeneCollections.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.Abstract
{
    interface IUserRepository
    {
        public User GetUserById(Guid id);
        public IQueryable<User> GetAllUsers();
        public void DeleteUserById(Guid id);
        public void BlockUserById(Guid id);
        public void UnblockUserById(Guid id);
        public void SetAdmin(Guid id);
    }
}
