namespace Balda
{
	class Game
	{
		private char[,] Board;
		private SpellChecker SpellChecker;

		public Game()
		{
			Board = new char[5, 5];
			SpellChecker = new SpellChecker(@"words.txt");
			var balda = "балда";
			for (int i = 0; i < 5; i++)
			{
				Board[2, i] = balda[i];
			}
		}

		public char GetSymbolAt(int i, int j)
		{
			if (i >= 5 || j >= 5 || i < 0 || j < 0)
			{
				return ' ';
			}
			return Board[i, j];
		}

		public void TryAddLetter(int i, int j, char c)
		{
			Board[i, j] = c;
		}
	}
}
