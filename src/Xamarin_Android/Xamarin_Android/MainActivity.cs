using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Xamarin_Android
{
	[Activity (Label = "HelloWXamAndroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.loginButton);
			
			button.Click += delegate {
				//set alert for executing the task
				var alert = new AlertDialog.Builder (this);

				alert.SetTitle ("Login Popup");

				alert.SetPositiveButton ("OK", (senderAlert, args) => {
					
				});

				alert.SetMessage ("Logged In");

				//run the alert in UI thread to display in the screen
				RunOnUiThread (() => {
					alert.Show ();
				});
			};
		}
	}
}


