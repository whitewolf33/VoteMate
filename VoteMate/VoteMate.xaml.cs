using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VoteMate
{
	public partial class VoteMate : Application
	{
		public VoteMate ()
		{
			InitializeComponent ();
			MainPage = new NavigationPage (new LoginPage ());
		}
	}
}

