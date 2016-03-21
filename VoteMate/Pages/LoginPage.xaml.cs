
using Xamarin.Forms;
using System;

namespace VoteMate
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

		private void OnLoginClicked (object sender, EventArgs e)
		{
			Application.Current.MainPage = new MainPage ();
		}

		private void OnRegisterClicked (object sender, EventArgs e)
		{
			Navigation.PushAsync (new RegistrationPage ());
		}
	}
}

