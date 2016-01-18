using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITests
{
	public class AppInitializer
	{
		public static IApp StartApp (Platform platform)
		{
			// TODO: If the iOS or Android app being tested is included in the solution 
			// then open the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			if (platform == Platform.Android) {
				return ConfigureApp
					.Android
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
				//Xamarin Android
				//					.ApkFile ("../../../../Apps/HelloWorld_Xamarin_Android.apk")
				//Xamarin Forms
					.ApkFile ("../../../../Apps/HelloWorld_XamarinForms_Android.apk")
					.StartApp ();
			}

			return ConfigureApp
				.iOS
			// TODO: Update this path to point to your iOS app and uncomment the
			// code if the app is not included in the solution.
			//ObjC
//				.AppBundle ("../../../../Apps/HelloWorld_ObjC.app")
			//SWIFT
//				.AppBundle ("../../../../Apps/HelloWorld_Swift.app")
			//CORDOVA
//				.AppBundle ("../../../../Apps/HelloWorld_Cordova.app")
			//IONIC
//				.AppBundle ("../../../../Apps/HelloWorld_Ionic.app")
			//Xamarin iOS
//				.AppBundle ("../../../../Apps/HelloWorld_Xamarin_iOS.app")
			//Telerik Appbuilder
//				.AppBundle ("../../../../Apps/HelloWorld_Appbuilder_iOS.app")
//				Xamarin Forms
				.AppBundle ("../../../../Apps/HelloWorld_XamarinForms_iOS.app")
				.StartApp ();
		}
	}
}

