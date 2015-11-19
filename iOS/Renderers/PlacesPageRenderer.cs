using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using System.Drawing;

[assembly:ExportRenderer(typeof(HOLA.PlacesPage), typeof(PlacesPageRenderer))]
public class PlacesPageRenderer : PageRenderer
{
	public override void ViewDidLoad ()
	{
		base.ViewDidLoad ();

		UIImageView titleView = new UIImageView (new RectangleF (0, 0, 150, 30));
		titleView.Image = new UIImage ("Images/ic_actionbar_logo.png");

		NavigationItem.TitleView = titleView;
	}

	public override void ViewDidAppear (bool animated)
	{
		base.ViewDidAppear (animated);
	}
}