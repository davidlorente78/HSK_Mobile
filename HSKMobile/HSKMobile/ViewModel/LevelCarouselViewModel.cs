using DomainServices;
using HSK;
using System.Collections.ObjectModel;

namespace HSKMobile.ViewModel
{
	public class LevelCarouselViewModel
	{
		public ObservableCollection<Word> Items { get; set; } = new ObservableCollection<Word>();
		public LevelCarouselViewModel(int level)
		{
			//TODO
			DALReaders.Reader_HSK reader_HSK = new DALReaders.Reader_HSK();
			reader_HSK.Level = level;
			ListService listservice = new ListService(reader_HSK);
			System.Collections.ArrayList words = listservice.GetAllWords(level);
						
			foreach (HSK.Word_HSK w in words)
			{
				Items.Add(w);
			}
			

		}
	}
}
