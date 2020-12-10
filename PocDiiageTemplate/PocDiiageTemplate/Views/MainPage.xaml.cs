

using Prism.Navigation;

namespace PocDiiageTemplate.Views
{
    public partial class MainPage
    {
        public MainPage(INavigationService navigationService)
        {
            
            InitializeComponent();
        }
        INavigationService _navigationService;

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await _navigationService.NavigateAsync("SecondPage");
        }
    }
}
