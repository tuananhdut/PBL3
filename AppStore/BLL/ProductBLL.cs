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
            p.Flag = false;
            ProductDAL.Intance.updateAndAddProduct(p);
        }
        public dynamic IndanhsachBLL()
        {
            return ProductDAL.Intance.Indanhsach();
        }
        public List<Product> TimKiem(string TenDT, string MaDT, string GiaMax, string GiaMin, string MaHang, string MaTL)

        {
            List<Product> result = ProductDAL.Intance.getALLProduct();
            if (TenDT != "")
            {
                result = result.Where(p => p.ProductName.IndexOf(TenDT, StringComparison.OrdinalIgnoreCase)>=0).ToList();
            }
            if (MaDT != "")
            {
                int IDDT = Convert.ToInt32(MaDT);
                result = result.Where(p => p.ProductID == IDDT).ToList();

            }
            if (MaTL != "")
            {
                int IDTL = Convert.ToInt32(MaTL);
                result = result.Where(p => p.CategoryID == IDTL).ToList();

            }
            if (MaHang != "")
            {
                int IDH = Convert.ToInt32(MaHang);
                result = result.Where(p => p.ManufacturerID == IDH).ToList();
            }
            if (Convert.ToInt32(GiaMin) >= 0)
            {
                result = result.Where(p => p.SalePrice >= Convert.ToInt32(GiaMin)).ToList();
            }
            if (GiaMax != "")
            {
                int GiaMaxDT = Convert.ToInt32(GiaMax);
                int GiaMinDT = Convert.ToInt32(GiaMin);
                result = result.Where(p => p.SalePrice >= GiaMinDT && p.SalePrice <= GiaMaxDT).ToList();
            }
            return result;
        }
        public Product getProdcutByName(string name)
        {
            return ProductDAL.Intance.getProductByName(name);
        }
        public Product getProductById(int id)
        {
            return ProductDAL.Intance.getProductByID(id);
        }
    }
}
