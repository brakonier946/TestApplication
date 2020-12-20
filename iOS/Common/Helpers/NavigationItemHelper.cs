using System.Windows.Input;
using UIKit;

namespace Bsuir.iOS.Infrastructure.Helpers
{
    public static class NavigationItemHelper
    {
        public static UIBarButtonItem CreateBarButton(string imageName, ICommand command)
        {
            var button = new UIButton()
            {
                TintColor = UIColor.White
            };

            button.HeightAnchor.ConstraintEqualTo(25f).Active = true;
            button.WidthAnchor.ConstraintEqualTo(25f).Active = true;
            button.TouchDown += (sender, e) => command?.Execute(null);
            button.SetImage(UIImage.FromBundle(imageName).ImageWithRenderingMode(UIImageRenderingMode.Automatic).ApplyTintColor(UIColor.White), UIControlState.Normal);
            button.ImageView.TintColor = UIColor.White;
            return new UIBarButtonItem(button);
        }
    }
}
