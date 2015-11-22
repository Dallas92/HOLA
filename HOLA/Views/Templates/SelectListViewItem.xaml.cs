using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HOLA
{
	public partial class SelectListViewItem_odd : ContentView
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

		public SelectListViewItem_odd ()
		{
			InitializeComponent ();

			var tgr = new TapGestureRecognizer ();
			tgr.Tapped += (object sender, EventArgs e) =>  {
				OnItemTaped(sender, e);
				return;
			};
			Image im = new Image ();


			Item.GestureRecognizers.Add (tgr);

		}
	}
}

