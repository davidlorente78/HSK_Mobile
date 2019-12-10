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
	public partial class Index : ContentPage
	{
		//https://docs.microsoft.com/es-es/xamarin/
		public Index()
		{
			InitializeComponent();
		}

		void HSKLevel1_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new LevelListView(1));
		}

		void HSKLevel2_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new LevelListView(2));
		}
		void HSKLevel3_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new LevelListView(3));
		}
		void HSKLevel4_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new LevelListView(4));
		}
		void HSKLevel5_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new LevelListView(5));
		}
		void HSKLevel6_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new LevelListView(6));
		}





	}
}