using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : Repo, IUserRepo
    {
        public User Add(User user)
        {
            db.Users.Add(user);
            if (db.SaveChanges() > 0) return user;
            return null;
        }

        public User GetByEmail(string email)
        {
            return db.Users.Find(email);
        }

        public User GetByUsername(string username)
        {
            return db.Users.Find(username);
        }
    }
}
