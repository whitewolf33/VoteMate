using Prism.Navigation;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VoteMate
{
	public class SplashPageViewModel : BaseViewModel
	{
		public SplashPageViewModel (INavigationService navigationService) : base (navigationService)
		{
			Task.Delay (1000).ContinueWith (sender => 
				Device.BeginInvokeOnMainThread (() => navigationService.Navigate ("LoginPage"))
			);
		}
	}
}

