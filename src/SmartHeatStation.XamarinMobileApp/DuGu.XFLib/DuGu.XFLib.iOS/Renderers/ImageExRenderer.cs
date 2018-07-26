
using System;
using System.ComponentModel;

using CoreGraphics;
using UIKit;
using Foundation;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using DuGu.XFLib.Controls;
using DuGu.XFLib.iOS.Renderers;

[assembly: ExportRenderer(typeof(ImageEx), typeof(ImageExRenderer))]
namespace DuGu.XFLib.iOS.Renderers
{

    public class ImageExRenderer : ImageRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);
            UpdateColorFilter();
            if(e.NewElement != null)
            {
                Control.UserInteractionEnabled = true;
            }
        }

        //public override void TouchesBegan(NSSet touches, UIEvent evt)
        //{
        //    base.TouchesBegan(touches, evt);
        //    var uiTouch = touches.AnyObject as UITouch;
        //    Control.Alpha = 0.6f;
        //}

        //public override void TouchesEnded(NSSet touches, UIEvent evt)
        //{
        //    base.TouchesEnded(touches, evt);
        //    Control.Alpha = 1.0f;
        //}

        //public override UIView HitTest(CGPoint point, UIEvent uievent)
        //{
        //    if (this.UserInteractionEnabled == false || Alpha <= 0.01 ||
        //        this.Hidden == true)
        //        return null;
        //    if (this.PointInside(point, uievent) == false)
        //        return null;
        //    for(int i = Subviews.Length - 1;i>=0 ;i--)
        //    {
        //        var lastView = Subviews[i];
        //        var subPoint = this.ConvertPointToView(point, lastView);
        //        var nextView = lastView.HitTest(subPoint, uievent);
        //        if (nextView != null)
        //            return nextView;
        //    }
        //    return this;
        //}

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == ImageEx.ColorFilterProperty.PropertyName)
            {
                UpdateColorFilter();
            }

        }

        private void UpdateColorFilter()
        {
            var imageEx = Element as ImageEx;
            if (imageEx.ColorFilter != Color.Default)
            {
                UpdateImageViewColorFilter(imageEx.ColorFilter.ToUIColor());
            }
            else
            {
                UpdateImageViewColorFilter(UIColor.Gray);
            }
        }

        private void UpdateImageViewColorFilter(UIColor color)
        {
            var image = Control.Image;
            UIGraphics.BeginImageContextWithOptions(image.Size, false, image.CurrentScale);
            var context = UIGraphics.GetCurrentContext();
            context.TranslateCTM(0, image.Size.Height);
            context.ScaleCTM(1.0f, -1.0f);
            context.SetBlendMode(CGBlendMode.Normal);
            var rect = new CGRect(0, 0, image.Size.Width, image.Size.Height);
            context.ClipToMask(rect, image.CGImage);
            context.SetFillColor(color.CGColor);
            context.FillRect(rect);
            var newImage = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            Control.Image = newImage;
        }
    }
}
