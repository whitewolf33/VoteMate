using Prism.Mvvm;
using Prism.Navigation;

namespace VoteMate
{
	public abstract class BaseViewModel : BindableBase
	{
		private bool _isBusy;

		public bool IsBusy {
			get { return _isBusy; } 
			set {
				_isBusy = value;
				OnPropertyChanged ("IsBusy");
			}
		}

		protected readonly INavigationService NavigationService;

		protected BaseViewModel (INavigationService navigationService)
		{
			NavigationService = navigationService;
		}
	}
}

