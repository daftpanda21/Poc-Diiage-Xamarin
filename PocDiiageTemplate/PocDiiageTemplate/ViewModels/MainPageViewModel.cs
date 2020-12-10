using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PocDiiageTemplate.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Main Page";
        }
        INavigationService _navigationService;
        private DelegateCommand _buttonClick;
        public DelegateCommand buttonClick => _buttonClick = new DelegateCommand(Button_Clicked);
        async void Button_Clicked()
        {
            await _navigationService.NavigateAsync("SecondPage");
        }
    }
}
