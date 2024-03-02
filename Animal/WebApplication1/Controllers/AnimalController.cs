using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WebApplication1.Interface;

namespace WebApplication1.Controllers
{
    public class AnimalController : Controller
    {
        private readonly ILogger<AnimalController> _logger;
        private readonly IAnimal _animalService;
        public AnimalController(ILogger<AnimalController> logger, IAnimal animalService)
        {
            _logger = logger;
            _animalService = animalService;
        }

        public async Task<IActionResult> Index()
        {
            var animal = await _animalService.GetAnimalAsync();
            return View(animal);
        }
    }
}
