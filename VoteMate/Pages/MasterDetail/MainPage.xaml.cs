using Xamarin.Forms;

namespace VoteMate
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			masterPage.BindingContext = BindingContext;
			MessagingCenter.Subscribe<MainPageViewModel> (this, "HideMaster", sender => IsPresented = false);
		}
	}
}

