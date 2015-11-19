using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using System.Text;

namespace HOLA.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();


//			UITableView.appearance().layoutMargins = UIEdgeInsetsZero
//			UITableViewCell.appearance().preservesSuperviewLayoutMargins = false
//			UISearchBar.appearance().barTintColor = AppDelegate.colorWithHexString("49B198")
//			UISearchBar.appearance().tintColor = UIColor.blackColor()
//			UIBarButtonItem.appearance().setTitleTextAttributes([ NSFontAttributeName: UIFont(name: "SegoeUI-Light", size: 16)!], forState: UIControlState.Normal)

			UIApplication.SharedApplication.SetStatusBarStyle (UIStatusBarStyle.LightContent, false);

			UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes() {
				TextColor = UIColor.Black,
				Font = UIFont.FromName ("GothamPro-Bold", 18)
			});

			UINavigationBar.Appearance.TintColor = UIColor.Black;


			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}

		private void EnumerateFonts(){
			var fontList = new StringBuilder();
			var familyNames = UIFont.FamilyNames;
			foreach (var familyName in familyNames ){
				fontList.Append(String.Format("Family: {0}\n", familyName));
				Console.WriteLine("Family: {0}\n", familyName);
				var fontNames = UIFont.FontNamesForFamilyName(familyName);
				foreach (var fontName in fontNames ){
					Console.WriteLine("\tFont: {0}\n", fontName);
					fontList.Append(String.Format("\tFont: {0}\n", fontName));
				}
			};
		}
	}
}

