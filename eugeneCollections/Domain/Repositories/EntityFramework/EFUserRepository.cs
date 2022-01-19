using eugeneCollections.Domain.Entities;
using eugeneCollections.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eugeneCollections.Domain.Repositories.EntityFramework
{
    public class EFUserRepository:IUserRepository
    {
        private readonly AppDbContext context;

        public EFUserRepository(AppDbContext context)=>this.context=context;
        public void BlockUserById(string id)
        {
            User user = (User)context.Users.Where(d=>d.Id==id).FirstOrDefault();

        }

        public void DeleteUserById(string id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAllUsers()
        {
            return (IQueryable<User>)context.Users;
        }

        public User GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        public void SetAdmin(string id)
        {
            throw new NotImplementedException();
        }

        public void UnblockUserById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
