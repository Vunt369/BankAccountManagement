using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class AccountTypeService : RepositoryBase<AccountType>
    {
        public string findTypeIdByName(string name)
        {
            AccountType accountType;
            accountType = this.GetAll().FirstOrDefault(p=>p.TypeName.ToLower().Equals(name.ToLower()));
        return accountType.TypeId;
        }
    }
    
}
