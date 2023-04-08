using EskhataOnlineSimulation.Interfases;
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

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Client(int? IdClient)
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel()
            {
                Client = _clientRepository.GetClient(IdClient ?? 1)


            };
            return View(viewModel);

        
        }

        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel viewModel = new HomeDetailsViewModel()
            {
                Card = _cardRepository.GetCardId(id??1)

            };
          

            return View(viewModel);
        
        }
    }
}
