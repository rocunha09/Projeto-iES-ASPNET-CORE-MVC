using Microsoft.AspNetCore.Mvc;
using Projeto_IES_ASPNET_CORE_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_IES_ASPNET_CORE_MVC.Controllers
{
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> Instituicoes = new List<Instituicao>()
        {
            new Instituicao()
            {
                InstituicaoID = 1,
                Nome = "Estacio",
                Endereco = "Rio de Janeiro"
            },
            new Instituicao()
            {
                InstituicaoID = 2,
                Nome = "Unisuam",
                Endereco = "Rio de Janeiro"
            },
            new Instituicao()
            {
                InstituicaoID = 3,
                Nome = "Anhembi Morumbi",
                Endereco = "São Paulo"
            }
        };
        public IActionResult Index()
        {
            return View(Instituicoes);
        }
    }
}
