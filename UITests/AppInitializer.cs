using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace HOLA.UITests
{
	public class AppInitializer
	{
		public static IApp StartApp (Platform platform)
		{
			if (platform == Platform.Android) {
				return ConfigureApp.Android.StartApp ();
			}
			string itswork = "Ya bil zdes'";
			string itswork2 = "Sdes bil dallas";
			return ConfigureApp.iOS.StartApp ();
		}
	}
}

