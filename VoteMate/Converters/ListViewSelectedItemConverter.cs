using System;
using Xamarin.Forms;
using System.Globalization;

namespace VoteMate
{
	public class ListViewSelectedItemConverter : IValueConverter
	{
		public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
		{
			var eventArgs = value as SelectedItemChangedEventArgs;
			return eventArgs.SelectedItem;
		}

		public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException ();
		}
	}
}

