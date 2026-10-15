using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Objetos Cliente
        Cliente cliente1 = new Cliente(1, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@gmail.com", "Madalena");
        Cliente cliente2 = new Cliente(2, "Marcos C. Andrade", "024.564.380-05", "marcos.andrade@gmail.com", "Ágata");
        Cliente cliente3 = new Cliente(3, "Patrícia S. Nunes", "315.874.290-60", "patricia.nunes@hotmail.com", "Pingo");
        Cliente cliente4 = new Cliente(4, "Juliana B. Rocha", "492.110.730-82", "juliana.rocha@outlook.com", "Thor");
        Cliente cliente5 = new Cliente(5, "Ricardo L. Mendes", "638.207.150-19", "ricardo.mendes@yahoo.com", "Luna");

        List<Cliente> listaClientes = new List<Cliente>
        {
            cliente1, cliente2, cliente3, cliente4, cliente5
        };

        // Objetos Fornecedor
        Fornecedor fornecedor1 = new Fornecedor(1, "C. A. Sousa Rações", "14.182.102/0001-80", "contato@sousaracoes.com.br");
        Fornecedor fornecedor2 = new Fornecedor(2, "PetVida Medicamentos Ltda", "27.635.418/0001-55", "vendas@petvida.com.br");
        Fornecedor fornecedor3 = new Fornecedor(3, "Bicho Feliz Acessórios", "08.947.263/0001-12", "comercial@bichofeliz.com.br");
        Fornecedor fornecedor4 = new Fornecedor(4, "VetLab Equipamentos", "33.501.786/0001-40", "atendimento@vetlab.com.br");
        Fornecedor fornecedor5 = new Fornecedor(5, "Higiene Pet Distribuidora", "45.219.637/0001-03", "pedidos@higienepet.com.br");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>
        {
            fornecedor1, fornecedor2, fornecedor3, fornecedor4, fornecedor5
        };

        ViewBag.listaClientes = listaClientes;
        ViewBag.listaFornecedores = listaFornecedores;

        return View();
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
