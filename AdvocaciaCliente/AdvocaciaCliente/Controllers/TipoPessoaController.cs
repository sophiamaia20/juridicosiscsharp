using AdvocaciaCliente.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvocaciaCliente.Controllers
{
    public class TipoPessoaController : Controller
    {
        public IActionResult Index()
        {
            TipoPessoaDAO dados = new TipoPessoaDAO();
            ViewBag.listaTipoPessoa = dados.getTodosTipoPessoa();
            return View();
        }
    }
}
