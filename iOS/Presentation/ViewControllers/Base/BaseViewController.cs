using System.Collections.Generic;
using System.Linq;
using Bsuir.iOS.Infrastructure.Helpers;
using MvvmCross.Platforms.Ios.Views;
using TestApplication.Core.Presentation.ViewModels.Base;
using TestApplication.iOS.Common;
using UIKit;

namespace TestApplication.iOS.Presentation.ViewControllers.Base
{
    public abstract class BaseViewController<TMvxViewModel> : MvxViewController<TMvxViewModel>
        where TMvxViewModel : BasePageViewModel
    {
        private List<UIView> _viewForKeyboardDismiss = new List<UIView>();

        public new string Title { get; set; }

        protected bool IsTabbedView { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            InitializeKeyboardDismiss();

            SetCommonStyles();
            SetupControls();
            SetCommonControlStyles();
            SetupBinding();
            Subscription();
        }

        public override void ViewDidUnload()
        {
            Unsubscription();
            base.ViewDidUnload();
        }

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.BlackOpaque;
        }

        protected virtual void SetupBinding()
        {
            // nothing do
        }

        protected virtual void SetupControls()
        {
            // nothing do
        }

        protected virtual void Subscription()
        {
            // nothing do
        }

        protected virtual void Unsubscription()
        {
            // nothing do
        }

        protected virtual void SetCommonStyles()
        {
            SetNeedsStatusBarAppearanceUpdate();

            if (NavigationItem.HidesBackButton == false && !IsTabbedView)
            {
                var backButton = NavigationItemHelper.CreateBarButton(Constants.Icons.BackIcon, ViewModel.GoBackCommand);
                NavigationItem.LeftBarButtonItem = backButton;
            }

            NavigationController.SetNavigationBarColor(Constants.Colors.Accent);
        }

        protected virtual void RegisterKeyboardDismissResponders(List<UIView> views)
        {
            View.AddGestureRecognizer(new UITapGestureRecognizer(DismissKeyboard));
            foreach (var view in views)
            {
                view.AddGestureRecognizer(new UITapGestureRecognizer(DismissKeyboard));
            }
        }

        protected virtual void RegisterKeyboardDismissTextFields(List<UIView> viewList)
        {
            _viewForKeyboardDismiss = viewList;
            _viewForKeyboardDismiss
                .OfType<UIScrollView>()
                .ToList()
                .ForEach(c => c.KeyboardDismissMode = UIScrollViewKeyboardDismissMode.OnDrag | UIScrollViewKeyboardDismissMode.Interactive);
        }

        private void SetCommonControlStyles()
        {
            if (!string.IsNullOrWhiteSpace(Title))
            {
                NavigationItem.SetTitle(Title);
            }
        }

        private void InitializeKeyboardDismiss()
        {
            RegisterKeyboardDismissResponders(new List<UIView> { });
            RegisterKeyboardDismissTextFields(_viewForKeyboardDismiss);
        }

        private void DismissKeyboard()
        {
            foreach (var view in _viewForKeyboardDismiss)
            {
                if (view is UIScrollView)
                    continue;

                view.ResignFirstResponder();
            }
        }
    }
}
