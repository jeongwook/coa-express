using System;
using Xamarin.Forms;
using System.Collections.Generic;


namespace COAExpress2
{
	public partial class SitePersonnel : ContentPage
	{
		public SitePersonnel()
		{
			InitializeComponent();

			listView.ItemsSource = new List<string>
			{
					"Select All / Deselect", "Derek Fisher", "Shaq", "Horry"
			};
		}

		async void OnLogoutButtonClicked(object sender, EventArgs e)
		{
			App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore(new LoginPage(), this);
			await Navigation.PopAsync();
		}

		async void OnNextPageClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new TrainingReviewed());
		}

		async void OnPreviousPageClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}
