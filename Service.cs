using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Service
    {
        private Repository rep;

        public void addUser(User user)
        {
            rep.AddUser(user);
        }
        public User getUser(string phone)
        {

            return rep.GetUser(phone);
        }
        public void updateUser(User user)
        {
            rep.UpdateUser(user);
        }
        public void deleteUser(User user)
        {
            rep.DeleteUser(user);
        }
        public bool checkUser(string phone)
        {
            return rep.CheckUser(phone);
        }
        public Service(AppDbContext repository)
        {
            rep = new Repository(repository);
        }

    }
}
