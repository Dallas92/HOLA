using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HOLA
{
	public partial class SelectListViewItem_even : ContentView
	{

		public string Title{
			get{
				return TitleLabel.Text;
			}
			set{
				TitleLabel.Text = value;
			}
		}

		public event EventHandler OnItemTaped;


		public SelectListViewItem_even ()
		{
			InitializeComponent ();

			var tgr = new TapGestureRecognizer ();

			tgr.Tapped += (object sender, EventArgs e) =>  {
				OnItemTaped(sender, e);
				return;
			};

			Item.GestureRecognizers.Add (tgr);

		

		}
	}
}

