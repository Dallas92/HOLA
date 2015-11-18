using System;
using UIKit;
using System.Drawing;

namespace HOLA.iOS
{
	public class UIImageHelper
	{
		public static UIImage CreateImageFromColor(float width, float height)
		{
			var imageSize = new SizeF(width, height);
			var imageSizeRectF = new RectangleF(0, 0, width, height);
			UIGraphics.BeginImageContextWithOptions(imageSize, false, 0);
			var context = UIGraphics.GetCurrentContext();

			context.SetFillColor(UIColor.Clear.FromHexString("#A2090B").CGColor);
			context.FillRect(imageSizeRectF);
			var image = UIGraphics.GetImageFromCurrentImageContext();
			UIGraphics.EndImageContext();
			return image;
		}
	}
}

