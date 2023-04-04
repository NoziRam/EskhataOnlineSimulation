using EskhataOnlineSimulation.Interfases;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EskhataOnlineSimulation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClientRepository _clientRepository;

        public HomeController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string Client()
        {
          return  _clientRepository.GetClient(1)?.FirstName;
        
        }
    }
}
