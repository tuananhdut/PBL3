using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL
    {
        AppStore db;
        private static ProductDAL _intance;
        public static ProductDAL Intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new ProductDAL();
                }
                return _intance;
            }
            private set { }
        }
        private ProductDAL()
        {
            db = new AppStore();
        }

        public List<Product> getALLProduct()
        {
           
                return db.Products.ToList();  
  
        }
        public Product getProductByID(int id)
        {
               return db.Products.Where(p => p.ProductID == id).FirstOrDefault();
        }
        
        public void updateAndAddProduct(Product p)
        {
            db.Products.AddOrUpdate(p);
            db.SaveChanges();
        }
        public void deleteProduct(Product p)
        {
            db.Products.Remove(p);
            db.SaveChanges();
        }
        
    }
}
