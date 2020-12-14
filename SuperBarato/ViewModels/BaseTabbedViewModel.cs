using Prism;
using Prism.Navigation;
using Prism.Services;
using System;

namespace SuperBarato.ViewModels
{
    public class BaseTabbedViewModel : BaseViewModel, IActiveAware
    {
        private bool isActive;
        public bool IsActive
        {
            get => isActive;
            set => SetProperty(ref isActive, value, RaiseIsActiveChanged);
        }

        public event EventHandler IsActiveChanged;

        public BaseTabbedViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            IsActiveChanged += HandleIsActiveTrue;
            IsActiveChanged += HandleIsActiveFalse;
        }

        public virtual void HandleIsActiveTrue(object sender, EventArgs e) { }

        public virtual void HandleIsActiveFalse(object sender, EventArgs e) { }

        private void RaiseIsActiveChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);
        }

        public override void Destroy()
        {
            IsActiveChanged -= HandleIsActiveFalse;
            IsActiveChanged -= HandleIsActiveTrue;
        }
    }
}
