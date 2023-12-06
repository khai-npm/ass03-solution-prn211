using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;
using Repository;
using BusinessObject;

namespace eFURentingManagement.Controllers
{
    public class LoginController : Controller
    {
        ICustomerRepository _customerRepository = new CustomerRepository();
        // GET: LoginController
        public IActionResult UserPage()
        {
            var Session = HttpContext.Session;
            String user = Session.GetString("Username");
            ViewBag.Email = user;
            return View();
        }

        public IActionResult AdminPage()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(string emailaddress, string memberpassword)
        {
            IConfiguration config = new ConfigurationBuilder()
                                     .SetBasePath(Directory.GetCurrentDirectory())
                                     .AddJsonFile("appsettings.json", true, true)
                                     .Build();
            var adminUser = config["AdminAccount:Email"];
            var adminPassword = config["AdminAccount:Password"];

            if (emailaddress == null | memberpassword == null)
            {
                ViewBag.Message = "email and password must not be blank!";
                return View(nameof(Index));

            }
            if (emailaddress==adminUser && memberpassword==adminPassword)
            {
                var Session = HttpContext.Session;
                Session.SetString("Username", "Admin");
                Session.SetString("Role", "Admin");
                return Redirect("../Admin");
            }
            if (_customerRepository.CheckLogin(emailaddress, memberpassword)!=null)
            {
                Customer c = _customerRepository.GetCustomerByEmail(emailaddress);
                if (c.CustomerStatus==1)
                {
                    ViewBag.Email = emailaddress;
                    var Session = HttpContext.Session;
                    Session.SetString("Username", c.CustomerName);
                    Session.SetString("email", c.Email);
                    Session.SetString("Role", "User");
                    return Redirect("../User");
                } else
                {
                    ViewBag.Message = "ERROR: This account has been deactivated ! if you want to " +
                        "reactivate this account please contact admin for support ";
                    return View(nameof(Index));
                }
                
            }




            ViewBag.Message = "ERROR: wrong email or password ";
            return View(nameof(Index));
        }

    }
}
