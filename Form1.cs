﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using authorization;

namespace MySoft
{
	public partial class SoftForm : Form
	{
		public SoftForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Form2 autorization = new Form2();
			//Hide();
			autorization.Show();
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Escape: Close(); break;//Выход на "Escape"
			}
		}
	}
}
