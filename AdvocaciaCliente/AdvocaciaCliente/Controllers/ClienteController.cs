using AdvocaciaCliente.DAL;
using AdvocaciaCliente.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static AdvocaciaCliente.Models.Cliente;

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
        [HttpPost]
        public IActionResult Create(string idnome, string idendereco, string idnumero)
        {
            return View("Index");
        }

        //Na COntroller
        [HttpPost]
        public IActionResult create(string idnome, string idendereco, string idnumero)
        {
            Cliente novoCliente = new Cliente();
            novoCliente.CLINOME = idnome;
            novoCliente.CLIENDERECO = idendereco;
            novoCliente.CLINUMEROENDERECO = idnumero;

            ClienteDAO dados = new ClienteDAO();
            bool result = dados.inserirCliente(novoCliente);

            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
    }
}
    
    
