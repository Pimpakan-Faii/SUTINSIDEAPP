using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SUTINSIDEAPP.ViewModel
{
    class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
      
       
        public Command Cupong { get; }
        public Command protect { get; }
        public Command nearyou { get; }
        public Command rest { get; }
        public Command setting { get; }

        public HomeViewModel()
        {
            Cupong = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new View.Coupong());
            });

            protect = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new View.Protected());
            });

           /* nearyou = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new View.Coupong());
            });*/

            rest = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new View.Rest());
            });

            setting = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new View.Setting());
            });

            // RegisterCommand = new Command(async () =>
            //  {
            //      await Application.Current.MainPage.Navigation.PushAsync(new View.Register());
            //  });
        }
    }
}