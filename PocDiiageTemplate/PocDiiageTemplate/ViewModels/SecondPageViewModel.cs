using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocDiiageTemplate.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public SecondPageViewModel(INavigationService navigationService)
           : base(navigationService)
        {
            Title = "Second Page";
        }
    }
}
