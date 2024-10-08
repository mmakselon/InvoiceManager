using InvoiceManager.Models.Domains;
using InvoiceManager.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var invoices = new List<Invoice>
            {
                new Invoice
                {
                    Id=1,
                    Title="Fa/01/2024",
                    CreateDate=DateTime.Now,
                    PaymentDate=DateTime.Now,
                    Value=999,
                    Client=new Client {Name="Klient 1"}
                },
                new Invoice
                {
                    Id=1,
                    Title="Fa/02/2024",
                    CreateDate=DateTime.Now,
                    PaymentDate=DateTime.Now,
                    Value=12999,
                    Client=new Client {Name="Klient 2"}
                },

            };
            return View(invoices);
        }

        public ActionResult Invoice( int id = 0)
        {
            var vm = new EditInvoiceViewModel
            {
                Clients = new List<Client> { new Client { Id = 1, Name = "Klient 1" } },
                MethodOfPayments = new List<MethodOfPayment> { new MethodOfPayment { Id = 1, Name = "Przelew" } },
                Heading = "Edycja faktury",
                Invoice = new Invoice()
            };

            return View(vm);
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}