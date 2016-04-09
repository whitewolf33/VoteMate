using Prism.Unity;
using Xamarin.Forms;
using Microsoft.Practices.Unity;

namespace VoteMate
{
	public class Bootstrapper : UnityBootstrapper
	{
		public IUnityContainer UnityContainer;

		public Bootstrapper ()
		{
			UnityContainer = Container;
		}

		protected override Page CreateMainPage ()
		{	
			Color barBackgroundColor = (Color)Application.Current.Resources ["AppSecondaryColor"];
			Color textColor = (Color)Application.Current.Resources ["AppTextColor"];

			var splashPage = Container.Resolve<SplashPage> ("SplashPage");
			// The root page of your application
			return new NavigationPage (splashPage) {
				BarBackgroundColor = barBackgroundColor,
				BarTextColor = textColor
			};
		}

		protected override void RegisterTypes ()
		{	
			// Assign this here for us to resolve later on
			UnityContainer = Container;

			// Register the Page and the corresponding ViewModels here
			Container.RegisterTypeForNavigation<SplashPage> ("SplashPage");
			Container.RegisterType<SplashPageViewModel> ("SplashPageViewModel");

			Container.RegisterTypeForNavigation<LoginPage> ("LoginPage");
			Container.RegisterType<LoginPageViewModel> ("LoginPageViewModel");

			Container.RegisterTypeForNavigation<RegistrationPage> ("RegistrationPage");
			Container.RegisterType<RegistrationPageViewModel> ("RegistrationPageViewModel");

			Container.RegisterTypeForNavigation<LetsVotePage> ("LetsVotePage");
			Container.RegisterType<LetsVotePageViewModel> ("LetsVotePageViewModel");

			Container.RegisterTypeForNavigation<MainPage> ("MainPage");
			Container.RegisterType<MainPageViewModel> ("MainPageViewModel");

		}
	}
}

