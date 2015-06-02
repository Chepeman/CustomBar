using System;
using Xamarin.Forms.Platform.iOS;
using CustomBarExample.CustomControls;
using CoreGraphics;
using Xamarin.Forms;

[assembly: Xamarin.Forms.ExportRenderer (typeof (CustomBar), 
	typeof (CustomBarExample.iOS.CustomBarRenderer))]


namespace CustomBarExample.iOS
{
	public class CustomBarRenderer : ProgressBarRenderer
	{
		public CustomBarRenderer ()
		{
			
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.ProgressBar> e)
		{
			base.OnElementChanged (e);
			if (Element == null || Control == null) {
				return;
			}

			Control.TintColor = Color.Red.ToUIColor ();

			Control.Transform = CGAffineTransform.MakeScale (1.0f, (Element as CustomBar).BarHeight);
		}

		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);
			if (Element == null || Control == null) {
				return;
			}

			if (e.PropertyName == CustomBar.BarHeightProperty.PropertyName)
				Control.Transform = CGAffineTransform.MakeScale (1.0f, (Element as CustomBar).BarHeight);
		}
	}
}

