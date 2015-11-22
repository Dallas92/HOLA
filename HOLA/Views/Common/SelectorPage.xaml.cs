using System;
using System.Collections.Generic;
using System.Collections;

using Xamarin.Forms;

namespace HOLA
{
	public partial class SelectorPage : ContentPage
	{

		public class ItemListView
		{

			public string Title {get; set;}
			public string Value { get; set; }
			public bool isChecked { get; set;}

		}

		private List<ItemListView> Values = new List<ItemListView> ();

		public SelectorPage ()
		{
			InitializeComponent ();

			List<SelectValues> sv = new List<SelectValues> ();

			sv.Add (new SelectValues () { isSelected = false, Title = "Алматы", Value = "Алматы" });
			sv.Add (new SelectValues () { isSelected = false, Title = "Астана", Value = "Астана" });
			sv.Add (new SelectValues () { isSelected = false, Title = "Актобе", Value = "Актобе" });
			sv.Add (new SelectValues () { isSelected = false, Title = "Мадагаскар", Value = "Мадагаскар" });

			SelectListView slv = new SelectListView (sv);

			slv.OnItemSelected += (object sender, SelectValues e) => {

				return;

			};

			root.Children.Add (slv);

		}
	}
}

