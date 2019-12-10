using HSKMobile.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HSKMobile.ViewModel
{
	public class LevelListViewModel
	{
		public ObservableCollection<Word> Items { get; set; }
		public LevelListViewModel(int level)
		{
			//Load Here ¿?
		}
	}
}
