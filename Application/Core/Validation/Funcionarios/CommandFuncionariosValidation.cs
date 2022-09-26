using Application.Core.Entities;
using Application.Core.Validation.Base;
using FluentValidation;
using FluentValidation.Results;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Core.Validation.Funcionarios
{
    public class CommandFuncionariosValidation : AbstractValidatorBase<Funcionario>
    {
        public override Task<ValidationResult> ValidateAsync(ValidationContext<Funcionario> context, CancellationToken cancellation = default)
        {
            RuleFor(x => x.DocFederal)
                .NotNull()
                .NotEmpty()
                    .WithMessage("Documento Federal é obrigatório.");

            RuleFor(x => x.Idade)
                .NotNull()
                .Must(idade => idade > 18)
                    .WithMessage("Funcionario precisa ser maior de idade.");

            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                     .WithMessage("Nome é obrigatório.");

            return Validator(context, cancellation);
        }
    }
}
