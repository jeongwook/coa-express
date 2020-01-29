using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace COAExpress2
{
	public partial class SignaturePage : ContentPage
	{
		public SignaturePage()
		{
			InitializeComponent();
		}

		async void OnLogoutButtonClicked(object sender, EventArgs e)
		{
			App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore(new LoginPage(),Navigation.NavigationStack[0]);
			await Navigation.PopToRootAsync();
		}

		async void OnNextPageClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SummaryPage());
		}

		async void OnPreviousPageClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}
