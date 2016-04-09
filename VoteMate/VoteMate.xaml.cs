using Xamarin.Forms;

namespace VoteMate
{
	public partial class VoteMate : Application
	{
		public VoteMate ()
		{
			InitializeComponent ();
			Bootstrapper bootstrapper = new Bootstrapper ();
			bootstrapper.Run (this);
		}
	}
}

