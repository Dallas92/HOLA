using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HOLA
{
	public partial class PlacesPage : ContentPage
	{
		public PlacesPage ()
		{
			InitializeComponent ();

			//this.Title = "HOLA";

			ToolbarItems.Add(new ToolbarItem("", "Images/Icons/ic_actionbar_city.png", async () =>
				{
//					var page = new ContentPage();
//					var result = await page.DisplayAlert("Title", "Message", "Accept", "Cancel");
//					Debug.WriteLine("success: {0}", result);
				}));
		}
	}
}

