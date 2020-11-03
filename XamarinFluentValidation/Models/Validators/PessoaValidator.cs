using System;
using FluentValidation;

namespace XamarinFluentValidation.Models.Validators
{
    public class PessoaValidator : AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Nome Obrigatório").
                MaximumLength(30).WithMessage("O Nome pode ter no maximo 30 caracteres");

            RuleFor(x => x.Email).NotEmpty().WithMessage("E-mail Obrigatório").
                EmailAddress().WithMessage("E-mail Invalido");

            RuleFor(x => x.Estado).NotEmpty().WithMessage("Estado Obrigatório");
        }
    }
}
