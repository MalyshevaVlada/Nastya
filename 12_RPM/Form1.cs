using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPM_12
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				uint value_n = Convert.ToUInt32(textBox1.Text);
				int  value_x = Convert.ToInt32(textBox2.Text);

				textBox3.Text = "Для угла x = " + value_x + " сумма синусов: " + sin_summa(value_x, value_n);
			}
			catch (FormatException)
			{
				textBox3.Clear();
				MessageBox.Show("Отсутствует или ошибочные значения целых чисел!!!", "Ошибка");
				return;
			}
			catch (OverflowException)
			{
				textBox3.Clear();
				MessageBox.Show("Количество слагаемых должно быть положительным!!!", "Ошибка");
				return;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				uint value_n = Convert.ToUInt32(textBox4.Text);
				double value_x = Convert.ToDouble(textBox5.Text);

				textBox6.Text = "Для угла x = " + value_x + " сумма синусов: " + sin_summa(value_x, value_n);
			}
			catch (FormatException)
			{
				textBox6.Clear();
				MessageBox.Show("Отсутствует или ошибочные значения вещественных чисел!!!", "Ошибка");
				return;
			}
			catch (OverflowException)
			{
				textBox6.Clear();
				MessageBox.Show("Количество слагаемых должно быть положительным!!!", "Ошибка");
				return;
			}
		}


		static int sin_summa(int x1, uint x2)
		{
			double summa = 0; int i = 0;
			for (i = 0; i <= x2; i++)
				summa += Math.Sin(i * x1);
			return Convert.ToInt32(summa);
		}

		static double sin_summa(double x1, uint x2)
		{
			double summa = 0; int i = 0;
			for (i = 0; i <= x2; i++)
				summa += Math.Sin(i * x1);
			return summa;
		}
	}
}
