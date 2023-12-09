using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_RPM
{
	delegate void IntDelegate(int x1, uint x2);
	delegate void DoubleDelegate(double x1, uint x2);
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			uint value_n;
			int  value_x;
			try
			{
				value_n = Convert.ToUInt32(textBox1.Text);
				value_x = Convert.ToInt32(textBox2.Text);
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

			IntDelegate int_delegate = new IntDelegate(sin_summa);
			int_delegate += cos_summa;

			int_delegate(value_x, value_n);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			uint value_n;
			double value_x;
			try
			{
				value_n = Convert.ToUInt32(textBox4.Text);
				value_x = Convert.ToDouble(textBox5.Text);
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

			DoubleDelegate double_delegate = new DoubleDelegate(sin_summa);
			double_delegate += cos_summa;

			double_delegate(value_x, value_n);
		}


		void sin_summa(int x1, uint x2)
		{
			double summa = 0; int i = 0;
			for (i = 0; i <= x2; i++)
				summa += Math.Sin(i * x1);
			textBox3.AppendText("Cумма sin = " + Convert.ToInt32(summa) + ". ");
		}

		void sin_summa(double x1, uint x2)
		{
			double summa = 0; int i = 0;
			for (i = 0; i <= x2; i++)
				summa += Math.Sin(i * x1);
			textBox6.AppendText("Сумма sin = " + summa + ". ");
		}
		void cos_summa(int x1, uint x2)
		{
			double summa = 0; int i = 0;
			for (i = 0; i <= x2; i++)
				summa += Math.Cos(i * x1);
			textBox3.AppendText("Сумма cos = " + Convert.ToInt32(summa) + ". ");
		}

		void cos_summa(double x1, uint x2)
		{
			double summa = 0; int i = 0;
			for (i = 0; i <= x2; i++)
				summa += Math.Cos(i * x1);
			textBox6.AppendText("Сумма cos = " + summa + ". ");
		}
	}
}
