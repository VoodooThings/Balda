using System.Net.NetworkInformation;

namespace Balda
{
	class Game
	{
		private char[,] Board;
		private SpellChecker SpellChecker;
		private GameState GameState;
		private bool[,] ChosenLetters;


		public Game()
		{
			Board = new char[5, 5];
			SpellChecker = new SpellChecker(@"words.txt");
			for (int i = 0; i < 5; i++)
				for (int j = 0; j < 5; j++)
				{
					Board[i, j] = ' ';
				}
			var balda = "балда";
			for (int i = 0; i < 5; i++)
			{
				Board[2, i] = balda[i];
			}
			GameState = GameState.Initial;
			ChosenLetters = new bool[5, 5];
		}

		public char GetSymbolAt(int i, int j)
		{
			if (i >= 5 || j >= 5 || i < 0 || j < 0)
			{
				return ' ';
			}
			return Board[i, j];
		}

		public bool IsChosenAt(int i, int j)
		{
			if (i >= 5 || j >= 5 || i < 0 || j < 0)
			{
				return false;
			}
			return ChosenLetters[i, j];

		}

		public bool TryAddLetter(int i, int j, char c)
		{
			if (Board[i, j] == ' ')
			{
				Board[i, j] = c;
				GameState = GameState.WaitingForAFirstLetterOfWord;
				return true;
			}
			return false;
		}

		public bool TryChooseLetter(int i, int j)
		{
			if (GameState == GameState.Initial)
			{
				return false;
			}
			if (GameState == GameState.WaitingForAFirstLetterOfWord)
			{
				ChosenLetters[i, j] = true;
				GameState = GameState.WaitingForLetters;
				return true;
			}

			if (!IsChosenAt(i - 1, j) && !IsChosenAt(i + 1, j) &&
				!IsChosenAt(i, j - 1) && !IsChosenAt(i, j + 1))
				return false;
			ChosenLetters[i, j] = true;
			return true;
		}
	}
}
