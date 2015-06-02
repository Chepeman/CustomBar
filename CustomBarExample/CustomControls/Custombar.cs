using System;
using Xamarin.Forms;

namespace CustomBarExample.CustomControls
{
	public class CustomBar : ProgressBar
	{
		public static readonly BindableProperty BarHeightProperty = 
			BindableProperty.Create<CustomBar,float> (
				p => p.BarHeight, 2.5f);

		public float BarHeight {
			get { return (float)GetValue (BarHeightProperty); }
			set { SetValue (BarHeightProperty, value); }
		}
	}
}

