using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocDiiageTemplate.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        private string _pseudo;
        public string Pseudo
        {
            get { return _pseudo; }
            set { SetProperty(ref _pseudo, value); }
        }
        public SecondPageViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Second Page";
            Pseudo = "";
        }
        INavigationService _navigationService;
        private DelegateCommand _buttonClick;
        public DelegateCommand buttonClick => _buttonClick = new DelegateCommand(Button_Clicked);
        async void Button_Clicked()
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("lePseudo", Pseudo);
            await _navigationService.NavigateAsync("ThirdPage", navigationParams);
        }

    }
}
