﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_RPM
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string name;
			UInt32 year;
			double rating;
			try
			{
				name = textBox1.Text;
				year = Convert.ToUInt32(textBox2.Text);
				rating = Convert.ToDouble(textBox3.Text);
				
			}
			catch (FormatException)
			{
				MessageBox.Show("Отсутствует или ошибочные значения полей!!!", "Ошибка");
				return;
			}
			catch (OverflowException)
			{
				MessageBox.Show("Поле не может быть отрицательным!!!", "Ошибка");
				return;
			}
			University university = new University(name, year, rating);
			university.Информация();
		}
	}

	class University
	{
		public string name = "???";
		public uint year;
		public double rating;

		public static uint YearWork(uint year)
		{
			return (year == 0 ? 0 : 2023 - year);
		}
		/*
		string Name
		{
			set { if (value != "") this.name = value; else name = "???"; }
			get { return this.name; }
		}

		uint Year
		{
			set
			{
				if (value < 2023) this.year = value;
				else MessageBox.Show("Год основания должен быть не больше текущего!!!", "ошибка");
			}
			get { return this.year; }
		}

		double Rating
		{
			set
			{
				if (value > 0.0 && value < 5.0) this.rating = value;
				else MessageBox.Show("Шкала рейтинга от 0 до 5!!!", "ошибка");
			}

			get { return this.rating; }
		}
		*/
		public University(string name, uint year, double rating)
		{
			if (name != "") this.name = name;

			if (year < 2023) this.year = year;
			else MessageBox.Show("Год основания должен быть не больше текущего!!!", "ошибка");

			if (rating > 0.0 && rating < 5.0) this.rating = rating;
			else MessageBox.Show("Шкала рейтинга от 0 до 5!!!", "ошибка");
		}

		public void Информация()
		{
			string message = $"Вуз \"{this.name}\" (рейтинг {this.rating}) основан в {this.year} году и выпускает студентов уже {YearWork(this.year)} лет";
			MessageBox.Show(message, "Информация о ВУЗе");
		}

	}
}
