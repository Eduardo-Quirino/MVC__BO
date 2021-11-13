using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC__BO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC__BO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        //Get
        public IActionResult Index()
        {
            AlunoBLL _aluno = new AlunoBLL();

            List<Aluno> alunos = _aluno.GetAlunos().ToList();

            return View("Lista",alunos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        //Post
        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
           
            //if (aluno.Nascimento <= DateTime.Now.AddYears(-18)) 
            //{
            //    ModelState.AddModelError("Nascimento", "data de nascimento invalida...");
            //} if (String.IsNullOrEmpty(aluno.Nome))
            //    ModelState.AddModelError("Nome", "O nome é obrigatório");

            //if (String.IsNullOrEmpty(aluno.Sexo))
            //    ModelState.AddModelError("Sexo", "O sexo é obrigatório");

            //if (String.IsNullOrEmpty(aluno.Email))
             

            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                AlunoBLL _aluno = new AlunoBLL();
                _aluno.IncluirAluno(aluno);
                return RedirectToAction("Index");
            }

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
