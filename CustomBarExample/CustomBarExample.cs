using System;
using Xamarin.Forms;
using CustomBarExample.CustomControls;

namespace CustomBarExample
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
		
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new CustomBar {
							HorizontalOptions = LayoutOptions.FillAndExpand,
							BarHeight = 3.0f,
							Progress = .5
						}
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

