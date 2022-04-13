using Projeto_IES_ASPNET_CORE_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_IES_ASPNET_CORE_MVC.Repository
{
    public interface IInstituicaoRepository
    {
        Instituicao Create(Instituicao instituicao);
        List<Instituicao> GetAll();

        Instituicao Read(long id);
        Instituicao Edit(Instituicao instituicao);
        Instituicao Delete(long id);
    }
}
