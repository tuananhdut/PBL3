using AppStore.BLL.DTO;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStore.BLL
{
    public class ManufactureBLL
    {
        private static ManufactureBLL _intance;
        public static ManufactureBLL Intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new ManufactureBLL();
                }
                return _intance;
            }
            private set { }
        }
        public List<Manufacturer> GetManufacturesBLL()

        {
            List<Manufacturer> list = new List<Manufacturer>();
            list = ManufactureDAL.Instance.GetAllManufacture();
            return list;
        }
        private CBBItem getCBBManufacture(Manufacturer a)
        {
            return new CBBItem()
            {
                ID = a.ManufacturerID,
                Text = a.ManufacturerName
            };
        }
        public List<CBBItem> getAllCBBManuFacture()
        {
            List<CBBItem> res = new List<CBBItem>();
            foreach (Manufacturer i in GetManufacturesBLL())
            {
                res.Add(getCBBManufacture(i));
            }
            return res;
        }
        public Manufacturer getManufactureBLL(int ID)
        {
            return ManufactureDAL.Instance.GetManufacture(ID);
        }
        public void AddorUpdateBLL(Manufacturer add)
        {
            ManufactureDAL.Instance.AddorUpdate(add);
        }
        public void DeleteBLL(int ID)
        {
            Manufacturer del = ManufactureDAL.Instance.GetManufacture(ID);
            ManufactureDAL.Instance.Delete(del);
        }
    }
}
