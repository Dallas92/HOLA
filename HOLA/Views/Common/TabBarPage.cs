using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace HOLA
{
	public class TabBarPage : ExtendedTabbedPage
	{
		public TabBarPage ()
		{
			this.Children.Add (new NavigationPage(new PlacesPage ()));
			this.Children.Add (new NavigationPage(new PlacesSearchPage ()));
			this.Children.Add (new NavigationPage(new PlacesNearbyPage ()));
			this.Children.Add (new NavigationPage(new NewsPage ()));
			this.Children.Add (new NavigationPage(new ProfilePage ()));

			int x = 0;
		}
	}
}