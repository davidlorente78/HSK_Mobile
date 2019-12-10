using HSK;
using HSKMobile.Model;
using HSKMobile.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HSKMobile.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WordView : ContentPage
	{
		WordViewModel viewModel;
		Word_HSK word;

		//http://jesseliberty.com/2017/07/06/learning-xamarin-forms-part-2-mvvm/
		public WordView()
		{
			InitializeComponent();
			word = new Word_HSK();
			word.Character = "好";

			viewModel = new WordViewModel(word);
			BindingContext = viewModel;
		}

	
	}
}