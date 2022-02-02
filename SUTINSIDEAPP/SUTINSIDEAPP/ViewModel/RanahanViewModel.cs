using SUTINSIDEAPP.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SUTINSIDEAPP.ViewModel
{
    class RanahanViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Ranahan> Ranahans { get; set; }

        public Command SelectedCommand { get; }
        public Ranahan selectedProduct { get; set; }
        public Command Cupong { get; }
        public Command protect { get; }
        public Command nearyou { get; }
        public Command rest { get; }
        public Command setting { get; }

        public RanahanViewModel()
        {
            Ranahans = new ObservableCollection<Ranahan>();

            Ranahans.Add(new Ranahan { ID = 1, Title = "แอนบะหมี่", Time = "8-11โมง", Rate = "5 ดาว", Image = new Uri("https://cdn.siamphone.com/spec/oppo/images/a72/oppo_a72_1.jpg") });
            Ranahans.Add(new Ranahan { ID = 2, Title = "แอนบะหมี่", Time = "8-11โมง", Rate = "5 ดาว", Image = new Uri("https://cdn.siamphone.com/spec/oppo/images/a72/oppo_a72_1.jpg") });
            Ranahans.Add(new Ranahan { ID = 3, Title = "แอนบะหมี่", Time = "8-11โมง", Rate = "5 ดาว", Image = new Uri("https://cdn.siamphone.com/spec/oppo/images/a72/oppo_a72_1.jpg") });
            Ranahans.Add(new Ranahan { ID = 4, Title = "แอนบะหมี่", Time = "8-11โมง", Rate = "5 ดาว", Image = new Uri("https://cdn.siamphone.com/spec/oppo/images/a72/oppo_a72_1.jpg") });

            /*SelectedCommand = new Command(async () =>
            {
                var ProdDetail = new View.ProductDetail
                {
                    BindingContext = selectedProduct
                };
                await Application.Current.MainPage.Navigation.PushModalAsync(ProdDetail);
            });*/
           

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
        }
    }
}
