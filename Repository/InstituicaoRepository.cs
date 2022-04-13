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

        public Instituicao Read(long id)
        {
            return _context.Instituicoes.Where(i => i.InstituicaoID == id).First();
        }

        public Instituicao Edit(Instituicao instituicao)
        {
           Instituicao inst =  _context.Instituicoes.FirstOrDefault(i => i.InstituicaoID == instituicao.InstituicaoID);

            if(inst == null)
            {
                throw new System.Exception("Falha ao Alterar instituição!");
            }
            else
            {
                inst.Nome = instituicao.Nome;
                inst.Endereco = instituicao.Endereco;
            }

            _context.Instituicoes.Update(inst);
            _context.SaveChanges();

            return inst;
        }

        public Instituicao Delete(Instituicao instituicao)
        {

            _context.Instituicoes.Remove(_context.Instituicoes.Where(i => i.InstituicaoID == instituicao.InstituicaoID).First());
            _context.SaveChanges();
            return instituicao;
        }
    }
}
