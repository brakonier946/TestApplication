using MvvmCross.Platforms.Ios.Presenters.Attributes;
using TestApplication.Core.Presentation.ViewModels.Tasks;
using TestApplication.iOS.Presentation.ViewControllers.Base;

namespace TestApplication.iOS.Presentation.ViewControllers.Tasks
{
    [MvxRootPresentation]
    public partial class TasksViewController : BaseViewController<TasksViewModel>
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

            set.Apply();
        }
    }
}

