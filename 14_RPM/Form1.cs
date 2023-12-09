using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _14_RPM
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			StreamReader streamReader;
			try
			{
				streamReader = new StreamReader("file1.txt");
			}
			catch (FileNotFoundException)
			{
				MessageBox.Show("Нет первого открываемого файла!!!", "Ошибка");
				return;
			}
			textBox9.Clear();
			while (!streamReader.EndOfStream)
			{
				string s = streamReader.ReadLine();
				textBox9.Text += s + "\r\n";
			}
			streamReader.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			StreamReader streamReader;
			try
			{
				streamReader = new StreamReader("file2.txt");
			}
			catch (FileNotFoundException)
			{
				MessageBox.Show("Нет второго открываемого файла!!!", "Ошибка");
				return;
			}
			textBox8.Clear();
			while (!streamReader.EndOfStream)
			{
				string s = streamReader.ReadLine();
				textBox8.Text += s + "\r\n";
			}
			streamReader.Close();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			textBox10.Clear();
			string[] data_one = File.ReadAllLines("file1.txt");
			string[] data_two = File.ReadAllLines("file2.txt");

			int data_number = 0;

			for (int i = 0; i < Math.Min(data_one.Length, data_two.Length); i++)
			{
				string[] values_one = data_one[i].Split(' ');
				string[] values_two = data_two[i].Split(' ');
				data_number++;
				int value_number = 0;

				for (int j = 0; j < Math.Min(values_one.Length, values_two.Length); j++)
				{
					int value_one;
					int value_two;
					value_number++;

					if (int.TryParse(values_one[j], out value_one) && int.TryParse(values_two[j], out value_two))
					{
						if (value_one != value_two)
						{
							StringBuilder sb = new StringBuilder();
							sb.AppendLine($"Первое несовпадение в файлах происходит в {data_number}-й строке в {value_number}-м числе");
							textBox10.Text += sb.ToString();
						}
					}
					else
					{
						MessageBox.Show($"Недопустимая информация в строке файла {data_number}!!!", "Ошибка");
					}
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FileInfo file = new FileInfo("D:\\CODE\\acode_rksi\\petrova\\14_RPM\\bin\\Debug\\save.txt");
			StreamWriter write_text = file.CreateText();
			write_text.WriteLine(textBox10.Text);
			write_text.Close();
		}
	}
}
