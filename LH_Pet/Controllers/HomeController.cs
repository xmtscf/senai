using Microsoft.AspNetCore.Mvc;
using LH_Pet.Models;
using System.Collections.Generic;

namespace LH_Pet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Criando objetos Cliente e Fornecedor de exemplo
            var clientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nome = "Cliente 1", Email = "cliente1@example.com", Telefone = "123-456-7890" },
                new Cliente { Id = 2, Nome = "Cliente 2", Email = "cliente2@example.com", Telefone = "987-654-3210" }
            };

            var fornecedores = new List<Fornecedor>
            {
                new Fornecedor { Id = 1, Nome = "Fornecedor 1", Email = "fornecedor1@example.com", Telefone = "555-555-5555" },
                new Fornecedor { Id = 2, Nome = "Fornecedor 2", Email = "fornecedor2@example.com", Telefone = "666-666-6666" }
            };

            // Passando os objetos para a view
            ViewData["Clientes"] = clientes;
            ViewData["Fornecedores"] = fornecedores;

            return View();
        }
    }
}
