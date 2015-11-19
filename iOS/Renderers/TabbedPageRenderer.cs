using System;
using System.Linq;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using HOLA.iOS;
using System.Drawing;
using CoreGraphics;
using System.Diagnostics;
using XLabs.Forms.Controls;

[assembly: ExportRenderer(typeof(ExtendedTabbedPage), typeof(TabbedPageRenderer))]
namespace HOLA.iOS
{
	public class TabbedPageRenderer : TabbedRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			var page = (ExtendedTabbedPage)Element;

			TabBar.TintColor = UIColor.White;
			TabBar.BarTintColor =  UIColor.Clear.FromHexString("#C80A0A");
			TabBar.SelectionIndicatorImage = UIImage.FromBundle("Images/TabBar/ic_menu_shadow").ResizeImage((float)TabBar.Frame.Width / 5,(float)TabBar.Frame.Height);
			//UIImageHelper.CreateImageFromColor((float)TabBar.Frame.Width / 5,(float)TabBar.Frame.Height);


			var gesture1 = new UISwipeGestureRecognizer(sw =>
				{
					sw.ShouldReceiveTouch += (recognizer, touch) => !(touch.View is UITableView) && !(touch.View is UITableViewCell);

					if (sw.Direction == UISwipeGestureRecognizerDirection.Right)
					{
						page.InvokeSwipeLeftEvent(null, null);
					}

				}) { Direction = UISwipeGestureRecognizerDirection.Right };

			var gesture2 = new UISwipeGestureRecognizer(sw =>
				{
					sw.ShouldReceiveTouch += (recognizer, touch) => !(touch.View is UITableView) && !(touch.View is UITableViewCell);

					if (sw.Direction == UISwipeGestureRecognizerDirection.Left)
					{
						page.InvokeSwipeRightEvent(null, null);
					}

				}) { Direction = UISwipeGestureRecognizerDirection.Left };

			View.AddGestureRecognizer(gesture1);
			View.AddGestureRecognizer(gesture2);
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			var items = TabBar.Items;
			for (var i = 0; i < items.Length; i++) {
				var icon = i == 0 ? "ic_menu_home" : i == 1 ? "ic_menu_zavedeniya" : i == 2 ? "ic_menu_otziv" : i == 3 ? "ic_menu_news" : "ic_menu_user";

				items[i].ImageInsets = new UIEdgeInsets(6, 0, -6, 0);
				items[i].Image = UIImage.FromBundle("Images/TabBar/" + icon).ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
				items[i].SelectedImage = UIImage.FromBundle("Images/TabBar/" + icon + "_sel").ImageWithRenderingMode(UIImageRenderingMode.AlwaysOriginal);
			}	

//			var page = (ExtendedTabbedPage)Element;
//
//			if (!string.IsNullOrEmpty(page.TabBarSelectedImage))
//			{
//				TabBar.SelectionIndicatorImage = UIImage.FromFile(page.TabBarSelectedImage).CreateResizableImage(new UIEdgeInsets(0, 0, 0, 0), UIImageResizingMode.Stretch);
//			}
//
//			if (!string.IsNullOrEmpty(page.TabBarBackgroundImage))
//			{
//				TabBar.BackgroundImage = UIImage.FromFile(page.TabBarBackgroundImage).CreateResizableImage(new UIEdgeInsets(0, 0, 0, 0), UIImageResizingMode.Stretch);
//			}
//
//			if (page.Badges != null && page.Badges.Count != 0)
//			{
//				var items = TabBar.Items;
//
//				for (var i = 0; i < page.Badges.Count; i++)
//				{
//					if (i >= items.Count())
//					{
//						continue;
//					}
//
//					items[i].BadgeValue = page.Badges[i];
//				}
//			}
//		}		
		}
	}
}

