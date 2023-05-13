using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL
    {
        private static ProductBLL _intance;
        public static ProductBLL Intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new ProductBLL();
                }
                return _intance;
            }
            private set { }
        }
        private ProductBLL()
        {
           
        }

        public Product GetProductBLL(int ID)
        {
            Product results = new Product();
            results = ProductDAL.Intance.getProductByID(ID);
            return results;
        }
        public List<Product> GetProductsBLL()
        {
            List<Product> list = new List<Product>();
            list = ProductDAL.Intance.getALLProduct();
            return list;
        }
        public void AddOrUpdateBLL(Product p)
        {
            ProductDAL.Intance.updateAndAddProduct(p);
        }
        public void DeleteBLL(int del)
        {
            Product p = ProductDAL.Intance.getProductByID(del);
            ProductDAL.Intance.deleteProduct(p);
        }
        //public List <Product> TimKiemTheoGiaBLL(int gia1, int gia2)
        //{
        //    return ProductDAL.Intance.TimKiemTheoGia(gia1, gia2);
        //}
        //public List<Product> TimKiemTheoTLBLL(int ID)
        //{
        //    return ProductDAL.Intance.TimKiemTheoMaTL(ID);
        //}
        //public List<Product> TimKiemTheoHangBLL(int ID)
        //{
        //    return ProductDAL.Intance.TimKiemTheoMaHang(ID);
        //}

    }
}
