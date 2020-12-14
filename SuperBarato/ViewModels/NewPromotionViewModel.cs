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
        public NewPromotionViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService) 
            : base(navigationService, pageDialogService)
        {
            Title = "New Promotion";
        }
    }
}
