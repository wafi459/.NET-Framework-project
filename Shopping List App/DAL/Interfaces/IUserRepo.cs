using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepo
    {
        User Add(User user);
        User GetByUsername(string username);
        User GetByEmail(string email);
    }
}
