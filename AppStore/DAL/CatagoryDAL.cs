using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CatagoryDAL
    {
        AppStore db;
        private static CatagoryDAL _intance;
        public static CatagoryDAL Intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new CatagoryDAL();

                }
                return _intance;
            }
            private set { }
        }
        private CatagoryDAL()
        {
            db = new AppStore();
        }
        public List<Category> getALLCatagory()
        {
            return db.Categories.ToList();
        }
        public Category GetCategory(int ID)
        {
            return db.Categories.Find(ID);
        }
        public void AddorUpdate(Category add)
        {
            db.Categories.AddOrUpdate(add);
            db.SaveChanges();
        }
        public void DeleteCategory(Category del)
        {
            db.Categories.Remove(del);
            db.SaveChanges();
        }

    }
}
