using Xamarin.Forms;
using DuGu.XFLib.Controls;
using DuGu.XFLib.Droid.Renderers;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;
using Android.Widget;
using Android.Graphics;

[assembly: ExportRenderer(typeof(ImageEx), typeof(ImageExRenderer))]
namespace DuGu.XFLib.Droid.Renderers
{
    public class ImageExRenderer : ImageRenderer
    {

        float[] BackSelected = new float[] { 1, 0, 0, 0, 50, 0, 1, 0, 0, 50, 0, 0, 1, 0, 50, 0, 0, 0, 1, 0 };
        float[] BackNotSelected = new float[] { 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0 };

        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);
            UpdateColorFilter();
            //if(e.OldElement != null)
            //{
            //    Control.Touch -= Control_Touch;
            //}
            //if(e.NewElement != null)
            //{
            //    Control.Touch += Control_Touch;
            //}
        }

        //private void Control_Touch(object sender, TouchEventArgs e)
        //{
        //    if(e.Event.Action == Android.Views.MotionEventActions.Down)
        //    {
        //        if(sender is ImageView image)
        //        {
        //            image.SetColorFilter(new ColorMatrixColorFilter(BackSelected));
        //        }
        //    }
        //    else if(e.Event.Action == Android.Views.MotionEventActions.Up)
        //    {
        //        if (sender is ImageView image)
        //        {
        //            image.SetColorFilter(new ColorMatrixColorFilter(BackNotSelected));
        //        }
        //    }
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
            if (imageEx.ColorFilter != Xamarin.Forms.Color.Default)
            {
                Control.SetColorFilter(imageEx.ColorFilter.ToAndroid());
            }
            else
            {
                Control.ClearColorFilter();
            }
        }

    }
}