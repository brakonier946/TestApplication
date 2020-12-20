using UIKit;

namespace TestApplication.iOS.Common
{
    public static class Constants
    {
        public static class Icons
        {
            public const string BackIcon = "ic_back";
            public const string TasksIcon = "ic_tasks";
            public const string LoginIcon = "ic_profile";
        }

        public static class Colors
        {
            public static UIColor Accent => UIColor.FromRGB(58, 84, 127);
            public static UIColor Inactive => UIColor.FromRGBA(0.129f, 0.129f, 0.129f, 1);
        }
    }
}
