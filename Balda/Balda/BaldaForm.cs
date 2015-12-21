using System;
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
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					BoardLabels[i][j].Text = Game.GetSymbolAt(i, j).ToString().ToUpperInvariant();
				}
			}
		}

		private void AddLetter(int i, int j)
		{
			try
			{
				Game.TryAddLetter(i, j, letterBox.SelectedItem.ToString()[0]);
				UpdateBoard();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		#region Прости меня Бог
		private void label1_Click(object sender, EventArgs e)
		{
			AddLetter(0, 0);
		}

		private void label2_Click(object sender, EventArgs e)
		{
			AddLetter(0, 1);
		}

		private void label3_Click(object sender, EventArgs e)
		{

			AddLetter(0, 2);
		}

		private void label4_Click(object sender, EventArgs e)
		{
			AddLetter(0, 3);

		}

		private void label5_Click(object sender, EventArgs e)
		{
			AddLetter(0, 4);

		}

		private void label6_Click(object sender, EventArgs e)
		{
			AddLetter(1, 0);

		}

		private void label7_Click(object sender, EventArgs e)
		{
			AddLetter(1, 1);

		}

		private void label8_Click(object sender, EventArgs e)
		{
			AddLetter(1, 2);

		}

		private void label9_Click(object sender, EventArgs e)
		{
			AddLetter(1, 3);

		}

		private void label10_Click(object sender, EventArgs e)
		{
			AddLetter(1, 4);

		}

		private void label11_Click(object sender, EventArgs e)
		{
			AddLetter(2, 0);

		}

		private void label12_Click(object sender, EventArgs e)
		{
			AddLetter(2, 1);

		}

		private void label13_Click(object sender, EventArgs e)
		{
			AddLetter(2, 2);

		}

		private void label14_Click(object sender, EventArgs e)
		{
			AddLetter(2, 3);

		}

		private void label15_Click(object sender, EventArgs e)
		{
			AddLetter(2, 4);

		}

		private void label16_Click(object sender, EventArgs e)
		{
			AddLetter(3, 0);

		}

		private void label17_Click(object sender, EventArgs e)
		{
			AddLetter(3, 1);

		}

		private void label18_Click(object sender, EventArgs e)
		{
			AddLetter(3, 2);

		}

		private void label19_Click(object sender, EventArgs e)
		{
			AddLetter(3, 3);

		}

		private void label20_Click(object sender, EventArgs e)
		{
			AddLetter(3, 4);

		}

		private void label21_Click(object sender, EventArgs e)
		{
			AddLetter(4, 0);

		}

		private void label22_Click(object sender, EventArgs e)
		{
			AddLetter(4, 1);

		}

		private void label23_Click(object sender, EventArgs e)
		{
			AddLetter(4, 2);

		}

		private void label24_Click(object sender, EventArgs e)
		{
			AddLetter(4, 3);

		}

		private void label25_Click(object sender, EventArgs e)
		{
			AddLetter(4, 4);

		}
		#endregion
	}
}
