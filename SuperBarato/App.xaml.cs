using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using SuperBarato.ViewModels;
using SuperBarato.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SuperBarato
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer platformInitializer) 
            : base(platformInitializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage");

            //NavigationService.NavigateAsync("MainPage?createTab=NavigationPage|PromotionsPage" +
            //    "&createTab=NavigationPage|NewPromotionPage" +
            //    "&createTab=NavigationPage|AccountPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<AccountPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<MarketsPage>();
            containerRegistry.RegisterForNavigation<NewPromotionPage, NewPromotionViewModel>();
            containerRegistry.RegisterForNavigation<PromotionsPage>();
        }
    }
}