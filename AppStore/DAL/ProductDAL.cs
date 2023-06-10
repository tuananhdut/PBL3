using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           
                return db.Products.Where(p=> p.Flag==true).ToList();
  
        }
        public Product getProductByID(int id)
        {
               return db.Products.Where(p => p.ProductID == id && p.Flag == true).FirstOrDefault();
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
        public List<Product> TimKiemTheoGia(int gia1, int gia2)
        {
            List<Product> result = new List<Product>();
            var a = db.Products.Where(p => p.SalePrice >= gia1 && p.SalePrice <= gia2);
            result = a.ToList();
            return result;
        }
        public List<Product> TimKiemTheoMaTL(int ID)
        {
            return db.Products.Where(p => p.CategoryID == ID).ToList();
        }
        public List<Product> TimKiemTheoMaHang(int ID)
        {
            return db.Products.Where(p => p.ManufacturerID == ID).ToList();
        }
        public dynamic Indanhsach()
        {
            return db.Products.Where(p => p.Flag == true).Select(p => new { p.ProductID, p.ProductName,p.CostPrice, p.SalePrice, p.Description,p.Quantity ,p.Manufacturer.ManufacturerName, p.Category.CategoryName }).ToList();

        }
        // duc
        public Product getProductByName(string name)
        {
            return db.Products.Where(p => p.ProductName == name).FirstOrDefault();
        }
        public Product getProductById(int id)
        {
            return db.Products.Find(id);
        }
        public void saveMe()
        {
            db.SaveChanges();
        }
    }
}
