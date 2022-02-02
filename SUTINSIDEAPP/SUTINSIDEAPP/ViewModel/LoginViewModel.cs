using SUTINSIDEAPP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SUTINSIDEAPP.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Login Login { get; set; }
        string result;
        public string Result
        {

            get => result;
            set
            {
                result = value;
                var args = new PropertyChangedEventArgs(nameof(Result));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public Command LoginCommand { get; }

        public Command Cupong { get; }
        public Command RegisterCommand { get; }
        public LoginViewModel()
        {
            Login = new Login();
            LoginCommand = new Command(async () =>
            {
                if (Login.Email == "sut@g.sut.ac.th" && Login.Password == "1234")
                {
                    Result = "Success";
                    Application.Current.MainPage = new View.Home();

                }
                else
                {
                    Result = "Fail!!!";
                }
            });

           
            // RegisterCommand = new Command(async () =>
            //  {
            //      await Application.Current.MainPage.Navigation.PushAsync(new View.Register());
            //  });
        }
    }
}

