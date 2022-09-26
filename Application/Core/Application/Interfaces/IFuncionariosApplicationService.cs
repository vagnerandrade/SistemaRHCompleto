using Application.Core.Entities;
using System;

namespace Application.Core.Application.Interfaces
{
    public interface IFuncionariosApplicationService
    {
        Funcionario Insert(Funcionario funcionario);
        void Update(Guid codigo, Funcionario funcionario);
        void Delete(Guid codigo);
        Funcionario Get(Guid codigo);
        Funcionario GetAll();
    }
}
