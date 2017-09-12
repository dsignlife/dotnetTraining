using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPNETPT.Controllers.Web.Services;
using ASPNETPT.Models;
using ASPNETPT.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ASPNETPT.Controllers.Web
{
    public class AppController : Controller

    {
        private IMailService _mailService;
        private IConfigurationRoot _config;
        //private IBtcData _context;


        public AppController(IMailService mailService, IConfigurationRoot config)
       {
           _mailService = mailService;
           _config = config;
           //_context = context;
       }
        public IActionResult Index()
        {
            //var data = _context.GetBtcs();

            return View();
        }

        public IActionResult Contact()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMail(_config["MailSettings:ToAddress"], model.Email, "From Bitchart", model.Message);

                ModelState.Clear();
                ViewBag.UserMessage = "Message Sent";

            }
            
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

    }
}
