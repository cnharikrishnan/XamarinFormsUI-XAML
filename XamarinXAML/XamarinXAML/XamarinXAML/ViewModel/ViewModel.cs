using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinXAML.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {

        private bool isValidLogin;
        private bool isBusy;

        public ViewModel()
        {
            this.Username = null;
            this.Password = null;

            this.IsBusy = false;
            this.LoginCommand = new Command(ExecuteLoginCommand);
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsValidLogin
        {
            get { return this.isValidLogin; }
            set { this.isValidLogin = value; OnPropertyChanged(); }
        }
        public bool IsBusy
        {
            get { return this.isBusy; }
            set { this.isBusy = value; OnPropertyChanged(); }
        }
        public Command LoginCommand { get; set; }

        private async void ExecuteLoginCommand(object obj)
        {
            IsBusy = true;
            await Task.Delay(2000);
            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
                IsValidLogin = true;
            else
                IsValidLogin = false;
            IsBusy = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
