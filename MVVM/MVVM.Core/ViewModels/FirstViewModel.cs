using System;
using MvvmCross.Core.ViewModels;

namespace MVVM.Core.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        private string username;
        private string password;
        private bool isCorrect;

        private IMvxCommand loginCommand;


        public IMvxCommand LoginCommand

        {

            get

            {
                return loginCommand = loginCommand ?? new MvxCommand(this.DoNavegation);
            }



        }

        private void DoNavegation()
        {
            this.ShowViewModel<LogadoViewModel>();
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                this.username = value;
                this.RaisePropertyChanged(() => this.Username);
                this.Validate();
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                this.password = value;
                this.RaisePropertyChanged(() => this.Password);
                this.Validate();
            }
        }

        public bool IsCorrect
        {
            get
            {
                return isCorrect;
            }
            set
            {
                this.isCorrect = value;
                this.RaisePropertyChanged(() => this.IsCorrect);
            }
        }

        private void Validate()
        {
            if (string.IsNullOrWhiteSpace(this.Password) || string.IsNullOrWhiteSpace(this.Username))
            {
                this.IsCorrect = false;
            }
            else
            {
                this.IsCorrect = true;
            }
        }


    }
}
