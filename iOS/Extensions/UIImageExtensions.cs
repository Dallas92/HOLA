using System;
using UIKit;
using System.Drawing;

namespace HOLA.iOS
{
	public static class UIImageExtensions
	{
		public static UIImage ResizeImage(this UIImage sourceImage, float width, float height)
		{
			UIGraphics.BeginImageContext(new SizeF(width, height));
			sourceImage.Draw(new RectangleF(0, 0, width, height));
			var resultImage = UIGraphics.GetImageFromCurrentImageContext();
			UIGraphics.EndImageContext();
			return resultImage;
		}
	}
}

