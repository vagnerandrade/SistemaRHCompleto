using Application.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Core.Repository.Interfaces
{
    public interface IFuncionariosRepository
    {
        Task<Funcionario> Insert(Funcionario funcionario);
        void Update(Guid codigo, Funcionario funcionario);
        void Delete(Guid codigo);
        Task<Funcionario> Get(Guid codigo);
        Task<List<Funcionario>> GetAll();
    }
}
