using DomainServices;
using HSK;
using HSKMobile.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HSKMobile.ViewModel
{
	public class LevelListViewModel
	{
		public ObservableCollection<Word> Items { get; set; } = new ObservableCollection<Word>();
		public LevelListViewModel(int level)
		{
			//TODO
			DALReaders.Reader_HSK reader_HSK = new DALReaders.Reader_HSK();
			reader_HSK.Level = level;
			ListService listservice = new ListService(reader_HSK);
			System.Collections.ArrayList words = listservice.GetAllWords(1);
						
			foreach (HSK.Word_HSK w in words)
			{
				Items.Add(w);
			}
			

		}
	}
}
