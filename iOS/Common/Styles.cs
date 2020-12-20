using Foundation;
using UIKit;

namespace TestApplication.iOS.Common
{
    public static class Styles
    {
        public static void SetTabBarStyle(this UITabBar tabBar)
        {
            tabBar.TintColor = Constants.Colors.Accent;
            tabBar.UnselectedItemTintColor = Constants.Colors.Inactive;
            tabBar.BarTintColor = UIColor.White;
        }

        public static void SetTabBarItemStyle(this UITabBarItem tabBarItem)
        {
            tabBarItem.ImageInsets = new UIEdgeInsets(0, 0, 0, 0);
            tabBarItem.TitlePositionAdjustment = new UIOffset(0, 0);
            var textAttributes = new UITextAttributes { Font = UIFont.BoldSystemFontOfSize(12) };
            tabBarItem.SetTitleTextAttributes(textAttributes, UIControlState.Normal);
        }

        public static void SetScreenTitleStyle(this UILabel label)
        {
            var attributes = new UIStringAttributes
            {
                Font = UIFont.BoldSystemFontOfSize(16f),
                ForegroundColor = UIColor.White
            };

            label.AttributedText = new NSAttributedString(label.Text, attributes);
        }
    }
}
