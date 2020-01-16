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
	public partial class LevelCarouselView : ContentPage
	{
		public ObservableCollection<string> Items { get; set; }
		LevelCarouselViewModel viewModel;
		public LevelCarouselView(int i)
		{
			InitializeComponent();			
			viewModel = new LevelCarouselViewModel(i);
			BindingContext = viewModel;			
		}

		async void OnItemSelected(object sender, ItemTappedEventArgs e)
		{
			if (e.Item == null)
				return;

			await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

			string action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "See Phrases", "Search in Dictionary", "Add to Favorites");

			//Deselect Item
			((ListView)sender).SelectedItem = null;
		}

		void Phrases_Clicked(object sender, System.EventArgs e)
		{

			Navigation.PushAsync(new PhrasesListView("好"));
		}
	}
}
