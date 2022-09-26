using Application.Core.Application.Interfaces;
using Application.Core.Entities;
using Application.Core.Repository.Interfaces;
using Application.Core.Validation.Funcionarios;
using System;

namespace Application.Core.Application
{
    public class FuncionariosApplicationService : IFuncionariosApplicationService
    {
        private readonly IFuncionariosRepository _repository;
        private readonly CommandFuncionariosValidation _commandValidation;

        public FuncionariosApplicationService(IFuncionariosRepository repository, CommandFuncionariosValidation commandValidation)
        {
            _repository = repository;
            _commandValidation = commandValidation;
        }

        public Funcionario Insert(Funcionario funcionario)
        {
            _commandValidation.ValidateAsync(funcionario);

            var response = _repository.Insert(funcionario);
            return response.Result;
        }

        public void Update(Guid codigo, Funcionario funcionario)
        {
            _commandValidation.ValidateAsync(funcionario);

            _repository.Update(codigo, funcionario);
        }

        public void Delete(Guid codigo)
        {
            _repository.Delete(codigo);
        }

        public Funcionario Get(Guid codigo)
        {
            var response = _repository.Get(codigo);
            return response.Result;
        }
        public Funcionario GetAll()
        {
            var response = _repository.GetAll();
            return response.Result;
        }
    }
}
