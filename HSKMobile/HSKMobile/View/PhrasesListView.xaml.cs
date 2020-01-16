using HSKMobile.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HSKMobile.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhrasesListView : ContentPage
	{
		public ObservableCollection<string> Items { get; set; }
		PhrasesListViewModel viewModel;
		public PhrasesListView(string character)
		{			
			//TODO Prism
			viewModel = new PhrasesListViewModel("好");
			BindingContext = viewModel;			
		}

		async void OnItemSelected(object sender, ItemTappedEventArgs e)
		{
			if (e.Item == null)
				return;

			await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

			string action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");

			//Deselect Item
			((ListView)sender).SelectedItem = null;
		}
	}
}
