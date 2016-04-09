using Prism.Navigation;
using Prism.Commands;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VoteMate
{
	public class LoginPageViewModel :BaseViewModel
	{
		public DelegateCommand CmdLogin { get; set; }

		public DelegateCommand CmdRegister { get; set; }

		public LoginPageViewModel (INavigationService navigationService) : base (navigationService)
		{
			CmdLogin = new DelegateCommand (() => {
				IsBusy = true;
				Task.Delay (0).ContinueWith (t => {
					IsBusy = false;
					Device.BeginInvokeOnMainThread (() => NavigationService.Navigate ("MainPage"));
				});
			});

			CmdRegister = new DelegateCommand (() => NavigationService.Navigate ("RegistrationPage", useModalNavigation: false));
		}
	}
}

