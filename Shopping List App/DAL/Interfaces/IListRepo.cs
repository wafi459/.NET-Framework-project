using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IListRepo
    {
        Item Add(Item item);
        List<Item> GetAll();
        bool Delete(int id);
    }
}
