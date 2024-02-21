using DataTablers_Scroll_Infinete.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataTablers_Scroll_Infinete.Controllers
{
    public class ItensController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetItens()
        {
            var random = new Random();
            var itens = new List<Item>();

            for (int i = 1; i <= 5000; i++)
            {
                itens.Add(new Item
                {
                    Id = i,
                    Nome = $"Item {i}",
                    Descrição = $"Descrição {i}",
                    Preço = random.Next(1, 1000),

                    Id2 = i,
                    Nome2 = $"Item {i}",
                    Descrição2 = $"Descrição {i}",
                    Preço2 = random.Next(1, 1000),

                    Id3 = i,
                    Nome3 = $"Item {i}",
                    Descrição3 = $"Descrição {i}",
                    Preço3 = random.Next(1, 1000),

                    Id4 = i,
                    Nome4 = $"Item {i}",
                    Descrição4 = $"Descrição {i}",
                    Preço4 = random.Next(1, 1000),
                });
            }

            return Json(itens);
        }
    }
}
