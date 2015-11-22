using System;
using System.Collections.Generic;
using System.Collections;

using Xamarin.Forms;

namespace HOLA
{
	public partial class SelectorPage : ContentPage
	{
		public SelectorPage ()
		{
			InitializeComponent ();

			SelectListView SLV = new SelectListView ();

			List<SelectListView.BinderItem> binding = new List<SelectListView.BinderItem> ();

			binding.Add (new SelectListView.BinderItem ("Test1", "val1", false));
			binding.Add (new SelectListView.BinderItem ("Test2", "val2", false));
			binding.Add (new SelectListView.BinderItem ("Test3", "val3", false));
			binding.Add (new SelectListView.BinderItem ("Test4", "val4", true));

			SLV.ItemTapped += (object sender, ItemTappedEventArgs e) => {
				var item = e.Item as SelectListView.CustomViewCell;

				return;

			};

			SLV.ItemsSource = binding;

			root.Children.Add (SLV);


		}
	}
}

