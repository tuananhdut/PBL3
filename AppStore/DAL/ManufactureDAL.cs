using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManufactureDAL
    {
        AppStore db;
        private static ManufactureDAL _instance;
        public static ManufactureDAL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ManufactureDAL();
                return _instance;
            }
            private set { }
        }
        private ManufactureDAL()
        {
            db = new AppStore();
        }
        public List<Manufacturer> GetAllManufacture()
        {
            return db.Manufacturers.ToList();
        }
        public Manufacturer GetManufacture(int ID)
        {
            return db.Manufacturers.Find(ID);
        }
        public void AddorUpdate(Manufacturer add)
        {
            db.Manufacturers.AddOrUpdate(add);
            db.SaveChanges();
        }
        public void Delete(Manufacturer del)
        {
            db.Manufacturers.Remove(del);
            db.SaveChanges();
        }
    }
}
