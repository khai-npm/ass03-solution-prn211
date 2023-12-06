using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer CheckLogin(string email, string password) => CustomerDAO.CheckLogin(email,password);

        public Customer GetCustomerByEmail(string email) => CustomerDAO.GetCustomerByEmail(email);

        public void Register(Customer c) => CustomerDAO.Register(c);

        public void Update(Customer c) => CustomerDAO.Update(c);
    }
}
