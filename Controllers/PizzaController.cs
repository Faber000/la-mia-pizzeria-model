using la_mia_pizzeria_model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_model.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Pizza> pizzaList = new List<Pizza>();
            pizzaList.Add(new Pizza("Margherita", "Mozzarella e Pomodoro","https://www.tavolartegusto.it/wp/wp-content/uploads/2020/05/Pizza-napoletana-Ricetta-della-Pizza-Napoletana-Pizza-Margherita.jpg", 5.99));
            pizzaList.Add(new Pizza("Napoli", "Mozzarella, Pomodoro e Alici", "https://www.donnamoderna.com/content/uploads/2021/08/pizza-napoli.jpg", 6.99));
            pizzaList.Add(new Pizza("Diavola", "Salame piccante", "https://www.misya.info/wp-content/uploads/2007/08/Pizza-alla-diavola.jpg", 7.99));
            pizzaList.Add(new Pizza("Ortolana", "Verdura varia", "https://www.agrodolce.it/app/uploads/2018/01/pizza-ortolana-a1742-16.jpg", 7.99));
            return View(pizzaList);
        }

        public IActionResult Details(int id)
        {
            List<Pizza> pizzaList = new List<Pizza>();
            pizzaList.Add(new Pizza("Margherita", "Mozzarella, Pomodoro e Basilico", "https://www.tavolartegusto.it/wp/wp-content/uploads/2020/05/Pizza-napoletana-Ricetta-della-Pizza-Napoletana-Pizza-Margherita.jpg", 5.99));
            pizzaList.Add(new Pizza("Napoli", "Mozzarella, Pomodoro e Alici", "https://www.donnamoderna.com/content/uploads/2021/08/pizza-napoli.jpg", 6.99));
            pizzaList.Add(new Pizza("Diavola", "Salame piccante", "https://www.misya.info/wp-content/uploads/2007/08/Pizza-alla-diavola.jpg", 7.99));
            pizzaList.Add(new Pizza("Ortolana", "Verdura varia", "https://www.agrodolce.it/app/uploads/2018/01/pizza-ortolana-a1742-16.jpg", 7.99));
            return View(pizzaList[id]);
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