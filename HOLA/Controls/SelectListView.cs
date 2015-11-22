using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HOLA
{
	public class SelectListView : ListView
	{
	
		public class BinderItem{

			public BinderItem(string Title, string Value, bool Checked){

				this.Checked = Checked;
				this.Title = Title;
				this.Value = Value;

			}

			public bool Checked {
				get;
				set;
			}

			public string Title {
				get;
				set;
			}

			string Value {
				get;
				set;
			}

		}

		public SelectListView ()
		{
			
		}

		/*
		 * 
		 *  Настраиваем свой собственный итем для отображения. 
		 * 
		*/

		public class CustomViewCell : ViewCell{

			public BinderItem Item {
				get;
				set;
			}


			protected override void OnBindingContextChanged ()
			{
				base.OnBindingContextChanged ();

				Item = (BinderItem)this.BindingContext;

				Label Title = new Label();

				Title.HorizontalOptions = LayoutOptions.Start;
				Title.VerticalOptions = LayoutOptions.Center;

				Title.TextColor = Color.FromHex("#686868");

				Title.SetBinding (Label.TextProperty, new Binding ("Title", BindingMode.TwoWay));

				Image radio = new Image();

				radio.HorizontalOptions = LayoutOptions.End;
				radio.VerticalOptions = LayoutOptions.Center;

				radio.Source = "Images/Controls/ic_checkbox_big_2";

				Grid grid = new Grid();

				ColumnDefinition cd1 = new ColumnDefinition();

				cd1.Width = new GridLength(.1, GridUnitType.Star);

				ColumnDefinition cd2 = new ColumnDefinition();

				cd2.Width = new GridLength(100, GridUnitType.Absolute);

				grid.ColumnDefinitions.Add (cd1);
				grid.ColumnDefinitions.Add (cd2);

				grid.Children.Add(Title, 0,0);
				grid.Children.Add (radio, 0, 1);

				grid.Padding = new Thickness(10,10,10,10);

				View = grid;

			}

		}



	}

}

