using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class CustomerDAO
    {
        public static List<Customer> GetCustomerList()
        {
            List<Customer> custommerList = new List<Customer>();
            try
            {
                using var db = new FUCarRentingManagementContext();
                custommerList = db.Customers.ToList();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return custommerList;
        }

        public static Customer CheckLogin(string email, string password)
        {
            using var db = new FUCarRentingManagementContext();
            return db.Customers.SingleOrDefault<Customer>(m => m.Email.Equals(email) && m.Password.Equals(password));
        }
        public static Customer GetCustomerByEmail(string email)
        {
            Customer product = new Customer();
            try
            {
                using var db = new FUCarRentingManagementContext();
                product = db.Customers.SingleOrDefault(m => m.Email == email); //Include(f => f.Category)
                    //.SingleOrDefault(m => m.ProductId == email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public static void Register(Customer c)
        {
            try
            {
                using var db = new FUCarRentingManagementContext();
                db.Customers.Add(c); // thêm p vào trong DbSet
                db.SaveChanges(); // cập dữ liệu vào CSDL
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Update(Customer c)
        {
            try
            {
                using (var db = new FUCarRentingManagementContext())
                {
                    db.Entry<Customer>(c).State = EntityState.Modified; //gán trạng thái
                    db.SaveChanges(); // cập nhật CSDL
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
