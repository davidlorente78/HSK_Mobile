using System;
using System.Collections.Generic;
using System.Text;
using HSKMobile.Model;

namespace HSKMobile.ViewModel
{
	public class WordViewModel
	{
		public string Character { get; }

		public WordViewModel(Word word)
		{
			Character = word.Character;
		}
	}
}
