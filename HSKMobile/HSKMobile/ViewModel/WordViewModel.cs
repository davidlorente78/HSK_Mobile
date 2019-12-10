using HSK;

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
