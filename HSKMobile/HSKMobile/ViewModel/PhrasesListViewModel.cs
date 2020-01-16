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
	public class PhrasesListViewModel 
	{
		public ObservableCollection<Word> Items { get; set; } = new ObservableCollection<Word>();
		public PhrasesListViewModel(string character)
		{
			
			PhrasesService service = new PhrasesService();
			System.Collections.ArrayList phrases = service.GetPhrasesContainingCharacter(character);

			foreach (HSK.Word_Phrase w in phrases)
			{
				Items.Add(w);
			}


		}
	}
}
