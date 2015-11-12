# Xamarin UI Test Examples
Xamarin UI Test is a cross platform UI Testing framework by Xamarin built on top of Calabash. This repository demonstrates how to get started testing with Xamarin UI Test regardless of what platform/technology you are using. 

* **Key:** :white_check_mark: = Example Available,  :wrench: = Coming Soon,  :x: = Not Supported

Platform | Technology/Language | Availability 
:---------- | :----: | :----: | 
Cross Platform (WebView) | Cordova | :white_check_mark: 
Cross Platform (WebView) | Ionic | :white_check_mark: 
Cross Platform (WebView) | Telerik Appbuilder | :wrench: 
Cross Platform (Native) | Xamarin Forms | :white_check_mark:
iOS | Swift | :white_check_mark: 
iOS | ObjC | :white_check_mark: 
iOS | Xamarin iOS | :white_check_mark:
Android | Java | :wrench: 
Android | Xamarin Android | :white_check_mark: 

#Project structure
* Apps 
  * The executables for the Apps under test
* UITests 
  * Source for the Xamarin UI Tests
* src 
  * The source for the Apps under test 

#Bootstrapping Xamarin UI Test
Steps to take in order to bootstrap Xamarin UI Test in your project :
* Xamarin
  * [iOS](https://developer.xamarin.com/guides/testcloud/uitest/quickstarts/ios/) 
    * Xam UI Test Nuget + Xamarin.Calabash.Start (); in your AppDelegate
  * [Android](https://developer.xamarin.com/guides/testcloud/uitest/quickstarts/android/) 
    * Xam UI Test Nuget / No code changes required
  * [Xamarin Forms](https://developer.xamarin.com/guides/cross-platform/xamarin-forms/uitest-and-test-cloud/)
    * Xam UI Test Nuget / Map StyleId to Native Identifiers 
* Native
  * [iOS] (https://github.com/calabash/calabash-ios/wiki/Tutorial%3A-How-to-add-Calabash-to-Xcode)
    * Linking Calabash iOS in your XCode project 
  * Android
* Cordova based Apps
