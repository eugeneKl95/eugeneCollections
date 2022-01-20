using eugeneCollections.Domain.Entities;
using eugeneCollections.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
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
            User user = new User();
            user.Id = id;//(User)context.Users.Where(d=>d.Id==id).FirstOrDefault();
            user.State = "Blocked";
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void DeleteUserById(string id)
        {
            //User user = (User)context.Users.Where(d => d.Id == id).FirstOrDefault();
            context.Users.Remove(new User() { Id=id});
            context.SaveChanges();
        }

        public IQueryable<User> GetAllUsers()
        {
            return (IQueryable<User>)context.Users;
        }

        public User GetUserById(string id)
        {
            return context.Users.Where(o=>o.Id==id).FirstOrDefault();
        }

        public void SetAdmin(string id)
        {
            User user = context.Users.Where(t=>t.Id==id).FirstOrDefault();
            //context.Entry<IdentityUserRole<string>>()
        }

        public void UnblockUserById(string id)
        {
            User user = context.Users.Where(t => t.Id == id).FirstOrDefault();
            user.State = "Active";
            context.SaveChanges();
        }
    }
}
