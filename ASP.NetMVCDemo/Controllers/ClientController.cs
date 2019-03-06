using ASP.NetMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NetMVCDemo.DataLibrary;
using static ASP.NetMVCDemo.DataLibrary.BusinessLogic.ClientProcessor;

namespace ASP.NetMVCDemo.Controllers
{
    public class ClientController : Controller
    {
        public ActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddClient(ClientModel model)
        {
            if (ModelState.IsValid)
            {
                CreateClient(model.FirstName, 
                    model.LastName, 
                    model.CompanyName, 
                    model.CompanyAddress, 
                    model.CompanyPostCode, 
                    model.EmailAddress, 
                    model.PhoneNumber);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        public ActionResult EditClient()
        {
            return View();
        }

        public ActionResult ViewClient()
        {
            ViewBag.Message = "Clients List";

            var data = LoadClients();
            List<ClientModel> clients = new List<ClientModel>();

            foreach (var row in data)
            {
                clients.Add(new ClientModel
                {
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    CompanyName = row.CompanyName,
                    CompanyAddress = row.CompanyAddress,
                    CompanyPostCode = row.CompanyPostCode,
                    EmailAddress = row.EmailAddress,
                    ConfirmEmailAddress = row.EmailAddress,
                    PhoneNumber = row.PhoneNumber,
                    ConfirmPhoneNumber = row.PhoneNumber
                });
            }

            return View(clients);
        }
    }
}