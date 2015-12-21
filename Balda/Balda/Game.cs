using System;
using System.Net.NetworkInformation;

namespace Balda
{
	class Game
	{
		private char[,] Board;
		private SpellChecker SpellChecker;
		private GameState GameState;
		private bool[,] ChosenLetters;
		private Tuple<int, int> LastChosenLetter;


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

		public Tuple<int, int> GetLastChosen()
		{
			return LastChosenLetter;
		} 

		public bool TryAddLetter(int i, int j, char c)
		{
			if (GameState != GameState.Initial)
				return false;
			if (Board[i, j] == ' ')
			{
				Board[i, j] = c;
				GameState = GameState.WaitingForNextLetter;
				LastChosenLetter = Tuple.Create(i, j);
				ChosenLetters[i, j] = true;
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
			if (GameState == GameState.WaitingForNextLetter && (Math.Abs(i - LastChosenLetter.Item1)+ Math.Abs(j - LastChosenLetter.Item2)<2))
			{
				ChosenLetters[i, j] = true;
				LastChosenLetter = Tuple.Create(i, j);
				return true;
			}
			return false;
		}
		

		public GameState GetGameState()
		{
			return GameState;
		}
	}
}
