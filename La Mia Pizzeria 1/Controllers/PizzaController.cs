using La_Mia_Pizzeria_1.Models;
using La_Mia_Pizzeria_1.Models.Utils;
using Microsoft.AspNetCore.Mvc;

namespace La_Mia_Pizzeria_1.Controllers
{
    public class PizzaController : Controller
    {

        public IActionResult Index()
        {
            List<Pizza> listaDellePizza = PizzaData.GetPizzas();

            return View("Index", listaDellePizza);
        }

        public IActionResult Details(int id)
        {
            List<Pizza> listaDellePizza = PizzaData.GetPizzas();

            foreach (Pizza pizza in listaDellePizza)
            {
                if (pizza.Id == id)
                {
                    return View(pizza);
                }
            }

            return NotFound("la pizza con l'id cercato non esiste!");
        }

        public IActionResult Esempio(string nome, string cognome, int eta)
        {
            return Ok("Hai inserito parametro nome: " + nome + " parametro cognome: " + cognome + " parametro eta: " + eta);
        }
    }
}
