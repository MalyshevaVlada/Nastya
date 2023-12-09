using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_RPM
{
	public partial class Изменение : Form
	{
		Colleges c;
		int j;

		public Изменение(ref Colleges c, int j)
		{
			InitializeComponent();
			this.c = c;
			this.j = j;
		}
		private void Изменение_Load(object sender, EventArgs e)
		{
			textBox1.Text = c[Form1.n][j];
			textBox1.Enabled = false;
			textBox2.Text = c[Form1.n][j];
			textBox2.Select();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			c[Form1.n][j] = textBox2.Text;
			Close();
		}

	}
}
