using Prism.Commands;
using Prism.Navigation;
using Prism.Navigation.TabbedPages;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBarato.ViewModels
{
    public class NewPromotionViewModel : BaseTabbedViewModel
    {
        public DelegateCommand GoToMarketsCommand { get; set; }

        public NewPromotionViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService) 
            : base(navigationService, pageDialogService)
        {
            Title = "New Promotion";

            GoToMarketsCommand = new DelegateCommand(GoToMarkets);
        }

        private async void GoToMarkets()
        {
            await _navigationService.NavigateAsync("MarketsPage");
        }
    }
}
