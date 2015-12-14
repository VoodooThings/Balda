namespace Balda
{
	class Game
	{
		private char[,] Board;
		private SpellChecker SpellChecker;

		public Game()
		{
			Board =new char[5,5];
			SpellChecker = new SpellChecker(@"words.txt");
			var balda = "балда";
			for (int i = 0; i < 5; i++)
			{
				Board[2, i] = balda[i];
			}
		}
	}
}
