// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TestApplication.iOS.Presentation.ViewControllers.Login
{
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		UIKit.UIButton LoginButton { get; set; }

		[Outlet]
		UIKit.UITextField LoginTextField { get; set; }

		[Outlet]
		UIKit.UITextField PasswordTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LoginTextField != null) {
				LoginTextField.Dispose ();
				LoginTextField = null;
			}

			if (PasswordTextField != null) {
				PasswordTextField.Dispose ();
				PasswordTextField = null;
			}

			if (LoginButton != null) {
				LoginButton.Dispose ();
				LoginButton = null;
			}
		}
	}
}
