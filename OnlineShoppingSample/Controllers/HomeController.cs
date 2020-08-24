using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShoppingSample.Models;
using WebApplication4;
using WebApplication4.DomainModels;
using WebApplication4.Services;

namespace OnlineShoppingSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAgentContract _agentContract;
        private readonly IEMail _email;

        public HomeController(ILogger<HomeController> logger, IAgentContract agentContract, IEMail email)
        {
            _logger = logger;
            _agentContract = agentContract;
            _email = email;
        }


        public IActionResult Assignment()
        {
            ConcreteProduct concreteProduct = new ConcreteProduct(_agentContract);
            ViewBag.concreteProductGenerateSlip = concreteProduct.GenerateSlip();
            ViewBag.agentContractProductCommission = _agentContract.Commission();

            Book book = new Book(_agentContract);
            ViewBag.bookGenerateDulpicateSlip = book.GenerateDulpicateSlip();
            ViewBag.agentContractBookCommission = _agentContract.Commission();

            ConcreteMember concreteMember = new ConcreteMember(_email);
            ViewBag.concreteMemberActivateMember = concreteMember.ActivateMember();
            ViewBag.emailSendEmail = _email.SendEmail();

            ConcreteVideo concreteVideo = new ConcreteVideo();
            concreteVideo.IsLearningVideo = true;
            ViewBag.concreteVideoGeneratePackagingSlip = concreteVideo.GeneratePackagingSlip();

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
