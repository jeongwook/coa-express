using System;
using System.Collections.Generic;
using SignaturePad;

using Xamarin.Forms;

namespace COAExpress2
{
	public partial class TrainingReviewed : ContentPage
	{
		public TrainingReviewed()
		{
			InitializeComponent();

			listView.ItemsSource = new List<string>
			{
					"Select All / Deselect", "Triangle", "Defense", "Etc"
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
			await Navigation.PushAsync(new TrainingDate());
		}

		async void OnPreviousPageClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
	}
}
