using System;

using UIKit;

namespace HelloWXiOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			//assing ids
			usernameTextField.AccessibilityIdentifier = "username";
			passwordTextField.AccessibilityIdentifier = "password";
			loginButton.AccessibilityIdentifier = "loginButton";

			loginButton.TouchUpInside += LoginButton_TouchUpInside;

		}

		void LoginButton_TouchUpInside (object sender, EventArgs e)
		{
			new UIAlertView ("Login Popup", "Logged In", null, "OK", null).Show ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

