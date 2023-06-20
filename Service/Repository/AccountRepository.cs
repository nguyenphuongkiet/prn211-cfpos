using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class AccountRepository : RepositoryBase<Account>
    {
        public AccountRepository() { }

        public Account getAccountById(int id)
        {
            Account account = new Account();
            account = this.getAll().FirstOrDefault(a => a.Id == id, null);
            return account;
        }

        public void createAccount(string name, string description, int? salary, string user, int? RoleId, string password, DateTime? DOB)
        {
            Account account = new Account
            {
                Fullname = name,
                Description = description,
                Salary = salary,
                Username = user,
                RoleId = RoleId,
                Password = password,
                DateOfBirth = DOB
            };

            this.create(account);
        }
    }
}
