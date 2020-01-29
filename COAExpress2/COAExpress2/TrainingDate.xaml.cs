using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace COAExpress2
{
	public partial class TrainingDate : ContentPage
	{
		public TrainingDate()
		{
			InitializeComponent();

			listView.ItemsSource = new List<string>
			{
				"Send Coa PDF(s) to your email", "Capture signatures with phone"
			};
		}

		async void OnLogoutButtonClicked(object sender, EventArgs e)
		{
			App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore(new LoginPage(),Navigation.NavigationStack[0]);
			await Navigation.PopToRootAsync();
		}

		async void OnNextPageClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SignaturePage());
		}

		async void OnPreviousPageClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}
