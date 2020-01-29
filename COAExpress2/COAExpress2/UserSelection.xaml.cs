using System;
using Xamarin.Forms;

namespace COAExpress2
{
	public partial class UserSelection : ContentPage
	{
		public UserSelection()
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
			await Navigation.PushAsync(new SitePersonnel());
		}

		async void OnPreviousPageClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}
