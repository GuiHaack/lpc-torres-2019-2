using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aula05_exercicio_static.Models;
using Microsoft.AspNetCore.Http;

namespace aula05_exercicio_static.Controllers
{
    public class CorrentistaController : Controller
    {
        private static Correntista _correntistas = new Correntista();

        public IActionResult Index()
        {
            return View(_correntistas.listaCorrentistas);
        }

        public IActionResult CreateCorrentista()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult CreateCorrentista(CorrentistaModel _correntistaModel)
        {
            _correntistas.CreateCorrentista(_correntistaModel);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCorrentista(int id)
        {
            return View(_correntistas.GetCorrentista(id));
        }

        [HttpPost]
        public RedirectToActionResult UpdateCorrentista(CorrentistaModel _correntistaModel)
        {
            _correntistas.UpdateCorrentista(_correntistaModel);
            return RedirectToAction("Index");
        }

        public IActionResult ViewCorrentista(int id)
        {
            return View(_correntistas.GetCorrentista(id));
        }

        public RedirectToActionResult DeleteCorrentista(int id)
        {
            _correntistas.DeleteCorrentista(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
