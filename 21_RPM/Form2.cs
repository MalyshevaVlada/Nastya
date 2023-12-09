using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20_RPM
{
	public partial class Изменение : Form
	{
		Colleges c;

		public Изменение(ref Colleges c)
		{
			InitializeComponent();
			this.c = c;
		}

		private void Изменение_Load(object sender, EventArgs e)
		{
			if (Form1.key != null)
			{
				textBox1.Text = Form1.key; Form1.key = null;
				textBox1.Enabled = false;
				textBox2.Text = c[Form1.n][textBox1.Text].ToString();
				textBox2.Select();
			}
			else
			{
				textBox1.Select();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			c[Form1.n][textBox1.Text] = textBox2.Text;
			Close();
		}
	}
}
