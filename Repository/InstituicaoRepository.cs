using Projeto_IES_ASPNET_CORE_MVC.Data;
using Projeto_IES_ASPNET_CORE_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_IES_ASPNET_CORE_MVC.Repository
{
    public class InstituicaoRepository : IInstituicaoRepository
    {
        private readonly IESContext _context;

        public InstituicaoRepository(IESContext context)
        {
            _context = context;
        }
        public Instituicao Create(Instituicao instituicao)
        {
            _context.Instituicoes.Add(instituicao);
            _context.SaveChanges();
            return instituicao;
        }

        public List<Instituicao> GetAll()
        {
            return _context.Instituicoes.ToList();
        }
    }
}
