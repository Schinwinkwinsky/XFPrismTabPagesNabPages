using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace SuperBarato.ViewModels
{
    public class BaseViewModel : BindableBase, INavigatedAware, IDestructible
    {
        private string title;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        protected INavigationService _navigationService;
        protected IPageDialogService _pageDialogService;

        public BaseViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters) { }
        public virtual void OnNavigatedTo(INavigationParameters parameters) { }

        public virtual void Destroy() { }
    }
}
