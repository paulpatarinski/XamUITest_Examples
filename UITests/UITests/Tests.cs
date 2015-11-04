using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITests
{
	[TestFixture (Platform.Android)]
	[TestFixture (Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests (Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
		}

		[Test]
		public void Enter_Creds_And_Tap_Ok ()
		{
			app.EnterText (c => c.Id ("username"), "PaulP");
			app.EnterText (c => c.Id ("password"), "test password");
			app.Tap (c => c.Id ("loginButton"));

			app.WaitForElement (c => c.Marked ("Logged In"), "Timed out waiting for Hello World popup");

			app.Tap (c => c.Marked ("OK"));
		}
	}
}

