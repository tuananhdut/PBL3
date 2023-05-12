using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL
    {
        private AppStore db;
        private static AccountDAL _intance;
        public static AccountDAL Intance
        {
            get
            {
                if (_intance == null)
                {
                   _intance = new AccountDAL();
                }
                return _intance;
            }
            private set { }
        }
        private AccountDAL()
        {
            db = new AppStore();
        }
        // thêm hoặc sửa
        public void addOrUpdateAccount(Account account)
        {
            db.Accounts.AddOrUpdate(account);
            db.SaveChanges();
        }

        //R lấy account bởi usename (account chưa bị xóa)
        public Account getAccountByUsename(string usename)
        {
            return db.Accounts.Where(c => String.Compare(c.Username, usename, StringComparison.Ordinal)==0 && c.Flag ==true).FirstOrDefault();
        }

        // trả về tất cả account (chỉ lấy các account chưa xóa)
        public List<Account> getALLAccount()
        {
            return db.Accounts.Where(p=>p.Flag == true).ToList();
        }

        // lấy account bởi id (chỉ lấy các account chưa xóa)
        public Account GetAccountByID(int id)
        {
            return db.Accounts.Where(p=>p.Flag == true && p.AccountID==id).FirstOrDefault();
        }

        // xóa account
        public void removeAccount(Account acc)
        {
            db.Accounts.Remove(acc);
            db.SaveChanges();
        }
    }
}
