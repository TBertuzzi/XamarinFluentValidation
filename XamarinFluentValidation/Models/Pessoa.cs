using System;
using MvvmHelpers;

namespace XamarinFluentValidation.Models
{
    public class Pessoa : ObservableObject
    {
        private string _nome;
        public string Nome
        {
            get => _nome;
            set => SetProperty(ref _nome, value);
        }

        private string _email;
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        private string _estado;
        public string Estado
        {
            get => _estado;
            set => SetProperty(ref _estado, value);
        }
    }
}
