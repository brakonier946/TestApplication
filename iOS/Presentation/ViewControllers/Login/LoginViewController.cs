using MvvmCross.Platforms.Ios.Binding;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using TestApplication.Core.Presentation.ViewModels.Login;
using TestApplication.iOS.Presentation.ViewControllers.Base;

namespace TestApplication.iOS.Presentation.ViewControllers.Login
{
    [MvxRootPresentation]
    public partial class LoginViewController : BaseViewController<LoginViewModel>
    {
        protected override void SetCommonStyles()
        {
            base.SetCommonStyles();
        }

        protected override void SetupControls()
        {
            base.SetupControls();
        }

        protected override void SetupBinding()
        {
            base.SetupBinding();

            var set = CreateBindingSet();

            set.Bind(LoginTextField).For(v => v.Text).To(vm => vm.Login).TwoWay();
            set.Bind(PasswordTextField).For(v => v.Text).To(vm => vm.Password).TwoWay();
            set.Bind(LoginButton).For(v => v.BindTap()).To(vm => vm.LoginCommand);

            set.Apply();
        }
    }
}

