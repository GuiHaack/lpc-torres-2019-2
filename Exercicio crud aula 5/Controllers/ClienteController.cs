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
    public class ClienteController : Controller
    {
        private static Cliente _clientes = new Cliente(); 

        public IActionResult Index()
        {
            return View(_clientes.listaClientes);
        }

        public IActionResult CreateCliente()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult CreateCliente(ClienteModel _clienteModel)
        {
            _clientes.CreateCliente(_clienteModel);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCliente(int id)
        {
            return View(_clientes.GetCliente(id));
        }

        [HttpPost]
        public RedirectToActionResult UpdateCliente(ClienteModel _clienteModel)
        {
            _clientes.UpdateCliente(_clienteModel);
            return RedirectToAction("Index");
        }

        public IActionResult ViewCliente(int id)
        {
            return View(_clientes.GetCliente(id));
        }

        public RedirectToActionResult DeleteCliente(int id)
        {
            _clientes.DeleteCliente(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
