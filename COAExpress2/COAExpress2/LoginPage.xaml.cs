using System;
using Xamarin.Forms;

namespace COAExpress2
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		async void OnLoginButtonClicked(object sender, EventArgs e)
		{
			var user = new User 
			{
				Username = usernameEntry.Text,
				Password = passwordEntry.Text
			};

			var isValid = AreCredentialsCorrect(user);
			if (isValid)
			{
				App.IsUserLoggedIn = true;
				Navigation.InsertPageBefore(new UserSelection(), this);
				await Navigation.PopAsync();
			}
			else
			{
                await DisplayAlert("Alert", "Username/Password Incorrect", "OK");
				passwordEntry.Text = string.Empty;
			}
		}

		bool AreCredentialsCorrect(User user)
		{
			return user.Username == Constants.Username && user.Password == Constants.Password;
		}
	}
}
