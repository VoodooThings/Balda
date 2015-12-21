using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balda
{
	public partial class BaldaForm : Form
	{
		private Game Game;
		private Label[][] BoardLabels;

		public BaldaForm()
		{
			InitializeComponent();
			Game = new Game();
			BoardLabels = new[] {
				new[] {label1, label2, label3, label4, label5},
				new[] {label6, label7, label8, label9, label10},
				new[] {label11, label12, label13, label14, label15},
				new[] {label16, label17, label18, label19, label20},
				new[] {label21, label22, label23, label24, label25}
			};
			infoLabel.Text = "Давай сыграем в игру.";
			UpdateBoard();
		}

		private void UpdateBoard()
		{
			var lastChosen = Game.GetLastChosen();
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					BoardLabels[i][j].Text = Game.GetSymbolAt(i, j).ToString().ToUpperInvariant();
					if (Game.IsChosenAt(i, j))
					{
						if (lastChosen.Item1 == i && lastChosen.Item2 == j)
						{
							BoardLabels[i][j].BackColor = Color.Crimson;
						}
						else
						{
							BoardLabels[i][j].BackColor = Color.Aqua;
						}
					}
					else
						BoardLabels[i][j].BackColor = Color.White;

				}
			}


		}

		private void PunchBoardSquare(int i, int j)
		{
			try
			{
				var gState = Game.GetGameState();
				if (gState == GameState.Initial)
				{
					Game.TryAddLetter(i, j, letterBox.SelectedItem.ToString()[0]);
				}
				else
				{
					Game.TryChooseLetter(i, j);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			UpdateBoard();
		}

		#region Прости меня Бог
		private void label1_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(0, 0);
		}

		private void label2_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(0, 1);
		}

		private void label3_Click(object sender, EventArgs e)
		{

			PunchBoardSquare(0, 2);
		}

		private void label4_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(0, 3);

		}

		private void label5_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(0, 4);

		}

		private void label6_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(1, 0);

		}

		private void label7_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(1, 1);

		}

		private void label8_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(1, 2);

		}

		private void label9_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(1, 3);

		}

		private void label10_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(1, 4);

		}

		private void label11_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(2, 0);

		}

		private void label12_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(2, 1);

		}

		private void label13_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(2, 2);

		}

		private void label14_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(2, 3);

		}

		private void label15_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(2, 4);

		}

		private void label16_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(3, 0);

		}

		private void label17_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(3, 1);

		}

		private void label18_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(3, 2);

		}

		private void label19_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(3, 3);

		}

		private void label20_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(3, 4);

		}

		private void label21_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(4, 0);

		}

		private void label22_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(4, 1);

		}

		private void label23_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(4, 2);

		}

		private void label24_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(4, 3);

		}

		private void label25_Click(object sender, EventArgs e)
		{
			PunchBoardSquare(4, 4);

		}
		#endregion
	}
}
