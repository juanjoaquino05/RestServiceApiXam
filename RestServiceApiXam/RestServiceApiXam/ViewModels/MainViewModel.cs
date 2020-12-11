using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Newtonsoft.Json;
using Refit;
using RestServiceApiXam.Models;
using RestServiceApiXam.Services;
using Xamarin.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace RestServiceApiXam.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand GetCreatorsCommand { get; }
        public ObservableCollection<Creator> Creators {
            get { return _creators; }
            set { SetProperty(ref _creators, value); }
        }
        private ObservableCollection<Creator> _creators = new ObservableCollection<Creator>();

        public MainViewModel()
        {
            GetCreatorsCommand = new Command(GetCreatorsAsync);
            Creators = new ObservableCollection<Creator>();
            GetCreatorsAsync();
        }

        private async void GetCreatorsAsync()
        {
            var current = Connectivity.NetworkAccess;

            if (!(current == NetworkAccess.Internet))
            {
                await App.Current.MainPage.DisplayAlert("Alert", "There's no internet connection to load creators", "OK");
                return;
            }
            
            // Connection to internet is available
            try
            {
                var serviceApi = RestService.For<IRawgAPI>("https://api.rawg.io/api");
                var creators = await serviceApi.GetCreatorsAsync();

                //var creatorsList = JsonConvert.DeserializeObject<GetCreatorResponse>(response);

                if(creators != null)
                {
                    Creators.Clear();

                    foreach (var creator in creators.results)
                    {
                        Creators.Add(creator);
                    }
                }

            }
            catch (Exception e)
            {
                await App.Current.MainPage.DisplayAlert("Alert", e.Message, "OK");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
