﻿using HSKMobile.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HSKMobile
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new WordView();

			MainPage = new NavigationPage(new Index());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
