using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_RPM
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			StreamReader stream_reader;
			try
			{
				stream_reader = new StreamReader("D:\\CODE\\acode_rksi\\petrova\\15_RPM\\bin\\Debug\\file.txt");
			}
			catch (FileNotFoundException)
			{
				MessageBox.Show("Отсутствует открываемый файл!!!", "Ошибка");
				return;
			}
			richTextBox1.Clear();
			while (!stream_reader.EndOfStream)
				richTextBox1.Text += stream_reader.ReadLine() + "\r\n";
			stream_reader.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			richTextBox2.Text = richTextBox1.Text;
			string pattern = textBox2.Text.ToUpper();
			Regex reg = new Regex(pattern, RegexOptions.Multiline);
			MatchCollection match = reg.Matches(richTextBox2.Text);
			foreach (Match m in match)
			{
				richTextBox2.Select(m.Index, m.Length);
				richTextBox2.SelectionColor = System.Drawing.Color.Black;
				richTextBox2.SelectionFont = new Font(richTextBox1.Font.FontFamily, this.Font.Size, FontStyle.Bold);
			}
		}
	}
}
