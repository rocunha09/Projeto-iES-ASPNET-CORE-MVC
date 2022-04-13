using Microsoft.AspNetCore.Mvc;
using Projeto_IES_ASPNET_CORE_MVC.Models;
using Projeto_IES_ASPNET_CORE_MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_IES_ASPNET_CORE_MVC.Controllers
{
    public class InstituicaoController : Controller
    {
        private readonly IInstituicaoRepository _instituicaoRepository;

        public InstituicaoController(IInstituicaoRepository instituicaoRepository)
        {
            _instituicaoRepository = instituicaoRepository;
        }
        public IActionResult Index()
        {
            List<Instituicao> Instituicoes = _instituicaoRepository.GetAll();
            return View(Instituicoes.OrderBy(i => i.Nome));
        }
        //GET:Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Instituicao instituicao)
        {
            _instituicaoRepository.Create(instituicao);
            return RedirectToAction("Index");
        }
        
        public ActionResult Edit(long id)
        {
            return View(_instituicaoRepository.Read(id));
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Instituicao instituicao)
        {
            _instituicaoRepository.Edit(instituicao);
            
            return RedirectToAction("Index");
        }
        
        public ActionResult Details(long id)
        {
            return View(_instituicaoRepository.Read(id));
        }
        
        public ActionResult Delete(long id)
        {
            return View(_instituicaoRepository.Read(id));
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Instituicao instituicao)
        {
            _instituicaoRepository.Delete(instituicao);
            return RedirectToAction("Index");
        }
    }
}
