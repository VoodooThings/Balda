﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balda
{
	public partial class BaldaForm : Form
	{
		private Game Game;

		public BaldaForm()
		{
			InitializeComponent();
			Game = new Game();
		}

		private void Update()
		{
			
		}
	}
}
