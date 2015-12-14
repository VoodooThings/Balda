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
			BoardLabels =new [] {
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
	}
}
