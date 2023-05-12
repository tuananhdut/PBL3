using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBLL
    {
        
        private static AccountBLL _intance;
        public static AccountBLL Intance
        {
            get
            {
                if (_intance == null)
                {
                    _intance = new AccountBLL();
                }
                return _intance;
            }
            private set { }
        }
        private AccountBLL()
        {
           
        }

        public string HashPassword(string password)
        {
            byte[] salt = new byte[16];
            new RNGCryptoServiceProvider().GetBytes(salt);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Buffer.BlockCopy(salt, 0, hashBytes, 0, 16);
            Buffer.BlockCopy(hash, 0, hashBytes, 16, 20);
            return Convert.ToBase64String(hashBytes);
        }

        public bool VerifyPassword(string enteredPassword, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash);
            byte[] salt = new byte[16];
            Buffer.BlockCopy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }
        public Account CheckAccount(string usename, string passwork)
        {
            Account acc= AccountDAL.Intance.getAccountByUsename(usename);
            if (acc != null && VerifyPassword(passwork,acc.Password) && acc.Username==usename) return acc;
            return null;
        }
        public List<Account> getALLAcount() => AccountDAL.Intance.getALLAccount();
        public void addOrUpdateAccount(Account account) 
        {
            Account acc = AccountDAL.Intance.getAccountByUsename(account.Username);
            if (acc != null && account.AccountID != acc.AccountID)
            {
                string UsenameExeption;
                throw new ArgumentException("Tên Đăng nhập đã được sử dụng vui lòng dùng tên khác", nameof(UsenameExeption));
            }
            foreach (char ch in account.FullName)
            {
                if (char.IsDigit(ch))
                {
                    string FullnameExeption;
                    throw new ArgumentException("Vui Lòng kiểm tra tên hiển thị", nameof(FullnameExeption));
                }
            }
            AccountDAL.Intance.addOrUpdateAccount(account);
        } 
        public void removeAccountByID(int id)
        {
            Account account = AccountDAL.Intance.GetAccountByID(id);
            if (account.Invoices.Count == 0 && account != null)
            {
                AccountDAL.Intance.removeAccount(account);
            }
            else
            if (account != null)
            {
                account.Flag = false;
                AccountDAL.Intance.addOrUpdateAccount(account);
            }

        }
        public Account GetAccountByID(int id) => AccountDAL.Intance.GetAccountByID(id);

        public void changPassWork(int id,string newPasswork)
        {
            Account account = AccountDAL.Intance.GetAccountByID(id);
            account.Password = HashPassword(newPasswork);
            AccountDAL.Intance.addOrUpdateAccount(account);
        }
    }
}
