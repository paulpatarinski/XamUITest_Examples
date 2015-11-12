using System;

using Xamarin.Forms;

namespace Xamarin_Forms
{
	public class App : Application
	{
		public App ()
		{
			var loginButton = new Button { Text = "Login", StyleId = "loginButton" };



			var mainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center,
					Children = {
						new Entry { Placeholder = "Username", StyleId = "username" },
						new Entry { Placeholder = "Password", StyleId = "password" },
						loginButton
					}
				}
			};

			loginButton.Clicked += async (object sender, EventArgs e) => {
				await mainPage.DisplayAlert ("Login", "Logged in", "OK");
			};
			// The root page of your application
			MainPage = mainPage;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

