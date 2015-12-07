using System.Collections.Generic;
using System.IO;

namespace Balda
{
	class SpellChecker
	{
		private readonly HashSet<string> Words;

		public SpellChecker(string path)
		{
			Words = new HashSet<string>(File.ReadAllLines(path));
		}

		public bool CheckWord(string wordToCheck)
		{
			return Words.Contains(wordToCheck);
		}
	}
}
