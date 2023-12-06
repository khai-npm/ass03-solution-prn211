using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICustomerRepository
    {
        Customer CheckLogin(string email, string password);
        void Register(Customer c);
        Customer GetCustomerByEmail(string email);
        void Update(Customer c);
    }
}
