using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SpListRepo : Repo, IListRepo
    {
        public Item Add(Item item)
        {
            db.Items.Add(item);
            if (db.SaveChanges() > 0) return item;
            return null;
        }

        public bool Delete(int id)
        {
            var ex = db.Items.Find(id);
            db.Items.Remove(ex);
           return  db.SaveChanges()>0;
        }

        public List<Item> GetAll()
        {
            return db.Items.ToList();
        }
    }
}
