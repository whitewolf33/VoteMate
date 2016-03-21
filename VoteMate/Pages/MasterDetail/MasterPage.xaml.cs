using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace VoteMate
{
	public partial class MasterPage : ContentPage
	{
		public ListView ListView { get { return listView; } }

		public MasterPage ()
		{
			InitializeComponent ();

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

			listView.ItemsSource = masterPageItems;
		}
	}
}

