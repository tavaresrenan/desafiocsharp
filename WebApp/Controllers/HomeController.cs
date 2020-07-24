using Domain;
using Service;
using Service.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sobre Mim.";

            return View();
        }

        public ActionResult Challenge()
        {
            ViewBag.Message = "Desafio 4.";
            QuestionFactory<IQuestion>.Register(4, () => new FourthQuestion(TreeDomain.GenerateTree(), 9));
            IQuestion question = QuestionFactory<IQuestion>.Create(4);
            var result = question.Execute();
            var model = new DesafioModel();
            model.Resultado = result.ListResultsInt.ToArray();
            return View(model);
        }
    }
}