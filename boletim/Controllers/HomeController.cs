using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using boletim.Models; 

namespace boletim.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return RedirectToAction("Boletim");
        }

        // Action obrigatória solicitada pelo exercício
        public IActionResult boletim()
        {
            // Criando a lista de disciplinas
            List<string> disciplinas = new List<string> { "Desenvolvimento Web", "Estrutura de Dados", "Banco de Dados", "Engenharia de Software" };
            
            // Criando a lista de notas correspondentes
            List<double> notas = new List<double> { 9.5, 4.2, 7.8, 4.8 };

            // Passando as listas para a View através da ViewBag
            ViewBag.Disciplinas = disciplinas;
            ViewBag.Notas = notas;

            return View();
        }
    }
}