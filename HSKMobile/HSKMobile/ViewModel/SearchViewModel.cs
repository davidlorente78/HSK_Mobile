using DomainServices;
using HSK;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HSKMobile.ViewModel
{
	public class SearchViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public ICommand PerformSearch => new Command<string>((string query) =>
		{
			SearchResults.Clear();
			DictionaryService dictionaryService = new DictionaryService();
			var array = dictionaryService.GetWordsWhereDescriptionContains(query);
			//TODO
			foreach (Word w in array)
			{
				SearchResults.Add(w);
			}

		});

		private ObservableCollection<Word> searchResults = new ObservableCollection<Word>();
		public ObservableCollection<Word> SearchResults
		{
			get
			{
				return searchResults;
			}
			set
			{
				searchResults = value;
				NotifyPropertyChanged();
			}
		}
	}
}
