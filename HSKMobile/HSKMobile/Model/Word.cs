using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSKMobile.Model
{
	public class Word
	{
		public int Id { set; get; }
		public string Character { set; get; }
		public string TraditionalCharacter { set; get; }
		public string Description { set; get; }
		public virtual string Pinyin { set; get; }
		public string NumberPinyin { set; get; }
		public int Level { set; get; }
		public string Type { set; get; }

	}
}
