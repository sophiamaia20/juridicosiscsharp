using AdvocaciaCliente.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvocaciaCliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            ClienteDao dados = new ClienteDao();
            ViewBag.listaClientes = dados.getTodosClientes(); 
            return View();
        }
    }
}
