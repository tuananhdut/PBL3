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

        public List<Product> getALLProduct() => ProductDAL.Intance.getALLProduct();

        
    }
}
