using System;
using System.Windows.Input;
using FluentValidation;
using MvvmHelpers;
using Xamarin.Forms;
using XamarinFluentValidation.Models;
using XamarinFluentValidation.Models.Validators;

namespace XamarinFluentValidation.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Pessoa _pessoa;
        public Pessoa Pessoa
        {
            get { return _pessoa; }
            set { SetProperty(ref _pessoa, value); }
        }

        public ICommand ValidarCommand { get; set; }
        private PessoaValidator _validator;

        public MainViewModel()
        {
            Pessoa = new Pessoa();
            _validator = new PessoaValidator();
            ValidarCommand = new Command(ValidarCommandExecute);
        }

        void ValidarCommandExecute()
        {

            var result = _validator.Validate(Pessoa);
            if (result.IsValid)
            {
                App.Current.MainPage.DisplayAlert("Cadastro", "Cadastro Validado com Sucesso", "Ok");
            }
            else
            {
                var erros = "";
                foreach (var failure in result.Errors)
                {
                    erros += $",{failure.ErrorMessage}";
                }

                App.Current.MainPage.DisplayAlert("FluentValidation", erros.Substring(1), "Ok");
            }
        }
    }
}
