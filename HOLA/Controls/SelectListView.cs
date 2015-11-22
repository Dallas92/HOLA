using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Dynamic;

namespace HOLA
{

	public class SelectValues{

		public string Title { get; set; }

		public string Value { get; set; }

		public bool isSelected { get; set; }
	}

	public class SelectListView : StackLayout
	{
		public delegate void SelectEvent(object sender, SelectValues e);

		public event SelectEvent OnItemSelected;

		List<SelectValues> values = null;

		private void resetSelected(){



			foreach (var v in this.Children) {

				if (v is SelectListViewItem_odd) {

					SelectListViewItem_odd slv = (SelectListViewItem_odd)v;

					Grid g = slv.FindByName<Grid> ("Item");

					Image img = (Image)g.Children [1];

					img.Source = ImageSource.FromFile ("Images/Controls/ic_checkbox_big_2");

				} else {
					SelectListViewItem_even slv = (SelectListViewItem_even)v;

					Grid g = slv.FindByName<Grid> ("Item");

					Image img = (Image)g.Children [1];

					img.Source = ImageSource.FromFile ("Images/Controls/ic_checkbox_big_2");

				}


			}
		}

		public SelectListView (List<SelectValues> list)
		{

			values = list;

			bool odd = false;

			foreach (SelectValues v in list) {

				odd = !odd;

				if (odd) {

					SelectListViewItem_odd slv_odd = new SelectListViewItem_odd ();

					slv_odd.Title = v.Title;

					slv_odd.OnItemTaped += (object sender, EventArgs e) => {

						resetSelected();

						Grid g = (Grid)sender;

						Label l = (Label)g.Children[0];

						Image img = (Image)g.Children[1];

						img.Source = ImageSource.FromFile("Images/Controls/ic_checkbox_big_1");

						for (int i = 0; i < values.Count; i++){
							if (values[i].Title == l.Text){
								values[i].isSelected = true;
								OnItemSelected(this, values[i]);
							}
							else
								values[i].isSelected = false;
						}

						return;

					};

					this.Children.Add (slv_odd);

				} else {

					SelectListViewItem_even slv_even = new SelectListViewItem_even ();

					slv_even.Title = v.Title;

					slv_even.OnItemTaped += (object sender, EventArgs e) => {

						resetSelected();

						Grid g = (Grid)sender;

						Label l = (Label)g.Children[0];

						Image img = (Image)g.Children[1];

						img.Source = ImageSource.FromFile("Images/Controls/ic_checkbox_big_1");

						for (int i = 0; i < values.Count; i++){
							if (values[i].Title == l.Text){
								values[i].isSelected = true;
								OnItemSelected(this, values[i]);
							}
							else
								values[i].isSelected = false;
						}

						return;

					};

					this.Children.Add (slv_even);

				}
			}

		
		}

	}

}

