using TestApplication.iOS.Common;
using UIKit;

namespace Bsuir.iOS.Infrastructure.Helpers
{
    public static class ViewControllerHelper
    {
        public static void InitTab(this UITabBar tabs, int index, string iconName, string title, UIImageRenderingMode mode = UIImageRenderingMode.Automatic)
        {
            if (tabs.Items.Length <= index)
            {
                return;
            }

            var tab = tabs.Items[index];
            tab.Title = title;
            tab.Image = UIImage.FromBundle(iconName).ImageWithRenderingMode(mode);
            tab.SetTabBarItemStyle();
        }

        public static void SetNavigationBarColor(this UINavigationController controller, UIColor color)
        {
            if (controller != null)
            {
                controller.NavigationBar.BarTintColor = color;
            }
        }

        public static void SetTitle(this UINavigationItem navigationItem, string title)
        {
            var titleItem = new UILabel(new CoreGraphics.CGRect(0, 0, 200, 20));
            titleItem.Text = title;
            titleItem.TextAlignment = UITextAlignment.Center;
            titleItem.SetScreenTitleStyle();

            var container = new UIView(new CoreGraphics.CGRect(0, 0, 200, 20));
            container.ContentMode = UIViewContentMode.Center;
            container.AddSubview(titleItem);

            navigationItem.TitleView = container;
        }
    }
}
