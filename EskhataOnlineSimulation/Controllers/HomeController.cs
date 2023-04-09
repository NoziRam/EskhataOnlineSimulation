using EskhataOnlineSimulation.Interfases;
using EskhataOnlineSimulation.Models;
using EskhataOnlineSimulation.ViewModels;
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
        private readonly ICardRepository _cardRepository;

        public HomeController(IClientRepository clientRepository, ICardRepository cardRepository)
        {
            _clientRepository = clientRepository;
            _cardRepository = cardRepository;
        }

               
        public ViewResult Index ()
        {
           
            return View();

        
        }

        public ViewResult MainPage()
        {
            return View();

        }

        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel viewModel = new HomeDetailsViewModel()
            {
                Card = _cardRepository.GetCardId(id??1)

            };
          

            return View(viewModel);
        
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        
        }
        [HttpPost]
        public IActionResult Create(Client client)
        {
            var newClient= _clientRepository.Create(client);
            return RedirectToAction("MainPage", new { newClient.Id });
        
        }
    }
}
