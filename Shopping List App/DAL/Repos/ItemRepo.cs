using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ItemRepo : Repo, IRepo<Item, string, Item>
    {
        public Item Add(Item obj)
        {
            db.Items.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public void Delete(string id)
        {
            var exobj= View(id);
            db.Items.Remove(exobj);
           db.SaveChanges() ;

         
        }

        public Item Update(Item obj)
        {
            var ex = View(obj.Name);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0) return obj;
            return null;
        }

        public Item View(string ctg)
        {
            return db.Items.Find(ctg);
        }

        public List<Item> View()
        {
           return db.Items.ToList();
        }
    }
}
