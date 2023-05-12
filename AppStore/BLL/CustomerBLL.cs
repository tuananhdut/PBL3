using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBLL
    {
        private static CustomerBLL _intance;
        public static CustomerBLL Intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new CustomerBLL();
                } 
                return _intance;
            }
            private set { }
        }
        private CustomerBLL()
        {
        }

        // lấy danh sách customer 
        public List<Customer> getALLCustomer() => CustomerDAL.Intance.getALLCustomer();

        // thêm khách hàng
        public void addAndUpdateCustomer(Customer kh)
        {
             CustomerDAL.Intance.addAndUpdateCustomer(kh);
        }

        // xóa khách hàng
        public void removeCustomer(int id)
        {
            Customer customer = CustomerDAL.Intance.getCustomerByID(id);
            if (customer.Invoices.Count == 0 && customer != null)
            {
                CustomerDAL.Intance.removeCustomer(customer);
            }
            else
            if (customer != null)
            {
                customer.Flag = false;
                CustomerDAL.Intance.addAndUpdateCustomer(customer);
            }
        }

        public Customer getCustomerByID(int id) => CustomerDAL.Intance.getCustomerByID(id);

        public List<Customer> searchCustomer(string name, string address,string phone, int? id = null)
        {
            if (id == null && name == "" && address == "" && phone == "") return new List<Customer>();
            List<Customer> li = CustomerDAL.Intance.getALLCustomer();
            if (id != null)
            {
                li = li.Where(p => p.CustomerID == id).ToList();
            }
            if (name != "")
            {
                li = li.Where(p => p.FullName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }
            if (address != "")
            {
                li = li.Where(p => p.Address.IndexOf(address, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }
            if (phone != "")
            {
                li = li.Where(p => p.PhoneNumber == phone).ToList();
            }
            return li;
        }
    }
}
