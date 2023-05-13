using AppStore.BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CatagoryBLL
    {   
        private static CatagoryBLL _intance;

        public static CatagoryBLL Intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance= new CatagoryBLL();
                }
                return _intance;
            }
            private set { }
        }
         
        public List<Category> GetCategoriesBLL()

        {
            List<Category> list = new List<Category>();
            list = CatagoryDAL.Intance.getALLCatagory();
            return list;
        }
        private CBBItem getCBBCatagory(Category a)
        {
            return new CBBItem()
            {
                ID = a.CategoryID,
                Text = a.CategoryName
            };
        }
        public List<CBBItem> getAllCBBCatagory()
        {
            List<CBBItem> res = new List<CBBItem>();
            foreach (Category i in GetCategoriesBLL())
            {
                res.Add(getCBBCatagory(i));
            }
            return res;
        }
        public Category getCategoryBLL(int ID)
        {
            return CatagoryDAL.Intance.GetCategory(ID);
        }
        public void AddorUpdateBLL(Category add)
        {
            CatagoryDAL.Intance.AddorUpdate(add);
        }
        public void DeleteBLL(int ID)
        {
            Category del = CatagoryDAL.Intance.GetCategory(ID);
            CatagoryDAL.Intance.DeleteCategory(del);
        }
    }
}
