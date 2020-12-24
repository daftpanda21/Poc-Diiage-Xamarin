using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace PocDiiageTemplate.ViewModels
{
    public class ThirdPageViewModel : ViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        public ObservableCollection<Beer> BeersList
        {
            get { return _beers; }
            set { SetProperty(ref _beers, value); }
        }
        private ObservableCollection<Beer> _beers;
        public ThirdPageViewModel(INavigationService navigationService)
          : base(navigationService)
        {
            Title = "Third Page";
           
            // _beers = result2;
            _beers = new ObservableCollection<Beer>() { new Beer {
               id=1,
               name="Buzz",
               tagline="A Real Bitter Experience.",
               first_brewed="09/2007",
               description="A light, crisp and bitter IPA brewed with English and American hops. A small batch brewed only once.",
               image_url="https=//images.punkapi.com/v2/keg.png"
           }, new Beer {
               id=2,
               name="Buzz",
               tagline="A Real Bitter Experience.",
               first_brewed="09/2007",
               description="A light, crisp and bitter IPA brewed with English and American hops. A small batch brewed only once.",
               image_url="https=//images.punkapi.com/v2/keg.png"
           }  };
            GetMyBeers();
            //Message = "";
        }
        public async void GetMyBeers()
        {
            ClientHttp myClient = new ClientHttp();
            var result = await myClient.GetBeerAsync();
            BeersList = result;
        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            _message = "Bonjour " + parameters["lePseudo"];

        }
    }
}
