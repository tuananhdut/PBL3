using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        private AppStore db;
        private static CustomerDAL _intance;
        public static CustomerDAL Intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new CustomerDAL();
                }
                return _intance;
            }
            private set { }
        }
        private CustomerDAL()
        {
            db = new AppStore();
        }
        // thêm hoặc sửa customer 
        public void addAndUpdateCustomer(Customer KH)
        {
            db.Customers.AddOrUpdate(KH);
            db.SaveChanges();
        }
        //lấy all khách hàng (không lấy các customer bị xóa)
        public List<Customer> getALLCustomer() => db.Customers.Where(p=>p.Flag == true).ToList();
        //lấy Customer bởi id (không lấy các customer bị xóa)
        public Customer getCustomerByID(int? id)
        {
            return db.Customers.Where(p=>p.CustomerID==id && p.Flag == true).FirstOrDefault();
        }
        //Xóa customer
        public void removeCustomer(Customer customer)
        {
            db.Customers.Remove(customer);
            db.SaveChanges();
        }
    }
}
