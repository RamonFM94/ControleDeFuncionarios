using FluentValidation;
using ProjetoAula04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Validations
{
    /// <summary>
    /// Classe para validação dos dados do funcionário.
    /// </summary>
    public class FuncionarioValidator : AbstractValidator<Funcionario>
    {

      /// <summary>
      /// Método construtor para implementar as
      /// validações de funcionario
      /// </summary>
        public FuncionarioValidator() { 

            //validações do campo ID
            RuleFor(f => f.Id)
                .NotEmpty().WithMessage("Por favor, informe o ID do funcionário.");

            //validações do campo 'Nome'
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("Por favor, informe o nome do funcionario.")
                .Length(8, 150).WithMessage("Por favor, informe o nome do funcionário de 8 a 150 caracteres");

            //validação do campo CPF
            RuleFor(f => f.Cpf)
                .NotEmpty().WithMessage("Por favor, informe o CPF do funcionário.")
                .Matches(@"^\d{11}$").WithMessage("Por favor, informe o CPF com exatamente 11 números.");

            //validação do campo Salário
            RuleFor(f => f.Salario)
                .GreaterThan(0).WithMessage("Por favor, informe o salário com valor maior que zero");
            //validação do campo 'Tipo'(enum)
            RuleFor(f => f.Tipo)
                .IsInEnum().WithMessage("Por favor, informe um tipo de contração válido (1 ,2 ou 3)");
        }
    }
}
