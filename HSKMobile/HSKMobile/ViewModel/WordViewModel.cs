using System;
using System.Collections.Generic;
using System.Text;
using HSK;
using HSKMobile.Model;

namespace HSKMobile.ViewModel
{
	public class WordViewModel
	{
		public string Character { get; }

		public WordViewModel(Word_HSK word)
		{
			Character = word.Character;
		}
	}
}
