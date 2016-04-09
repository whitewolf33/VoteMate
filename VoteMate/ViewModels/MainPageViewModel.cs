using System;
using Prism.Navigation;
using Prism.Commands;
using System.Collections.Generic;
using Xamarin.Forms;

namespace VoteMate
{
	public class MainPageViewModel :BaseViewModel
	{
		public DelegateCommand<MasterMenuItem> CmdShowDetail{ get; set; }



		private List<MasterMenuItem> _pages;

		public List<MasterMenuItem> Pages {
			get { return _pages; } 
			set {
				_pages = value;
				OnPropertyChanged ("Pages");
			}
		}


		public MainPageViewModel (INavigationService navigationService) : base (navigationService)
		{
			CmdShowDetail = new DelegateCommand<MasterMenuItem> ((selectedItem) => {			
				System.Diagnostics.Debug.WriteLine (selectedItem);
				MessagingCenter.Send<MainPageViewModel> (this, "HideMaster");
			});

			var masterPageItems = new List<MasterMenuItem> ();
			masterPageItems.Add (new MasterMenuItem {
				Title = "Contacts",
				IconSource = "contacts.png",
				TargetType = typeof(LetsVotePage)
			});
			masterPageItems.Add (new MasterMenuItem {
				Title = "TodoList",
				IconSource = "todo.png",
				TargetType = typeof(LetsVotePage)
			});
			masterPageItems.Add (new MasterMenuItem {
				Title = "Reminders",
				IconSource = "reminders.png",
				TargetType = typeof(LetsVotePage)
			});

			Pages = masterPageItems;
		}
	}
}

