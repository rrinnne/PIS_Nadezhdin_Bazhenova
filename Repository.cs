using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Repository
    {
        private AppDbContext dbContext;
        public User user;
        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddUser(User userToSave)
        {
            userToSave.DateOfEntry = DateTime.SpecifyKind(userToSave.DateOfEntry, DateTimeKind.Utc);
            userToSave.PatentDate = DateTime.SpecifyKind(userToSave.PatentDate, DateTimeKind.Utc);
            user = userToSave;
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            user.DateOfEntry = DateTime.SpecifyKind(user.DateOfEntry, DateTimeKind.Utc);
            user.PatentDate = DateTime.SpecifyKind(user.PatentDate, DateTimeKind.Utc);
            dbContext.Users.Update(user);
            dbContext.SaveChanges();
        }
        public void DeleteUser(User user)
        {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }
        public bool CheckUser(string phone)
        {
            return dbContext.Users.Any(u => u.Phone ==phone);
        }
        public User GetUser(string phone) 
        {
            return dbContext.Users.FirstOrDefault(u => u.Phone == phone);
        }
    }
}
