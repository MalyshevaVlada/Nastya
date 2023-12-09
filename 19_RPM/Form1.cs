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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Colleges colleges;
		int count = 2;
		public static int n;
		public static int sel = -1;

		private void button1_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex >= 0)
			{
				Изменение изменение = new Изменение(ref colleges, listBox1.SelectedIndex);
				изменение.Show();
			}
			else
			{
				MessageBox.Show("Не указана изменяемая характеристика!!!", "Ошибка");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (n > 0)
			{
				n--;
				listBox1.Items.Clear();
				colleges[n].parametersAdd(listBox1);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (n < count - 1)
			{
				n++;
				listBox1.Items.Clear();
				colleges[n].parametersAdd(listBox1);
			}
		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			colleges[n].parametersAdd(listBox1);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			colleges = new Colleges(count);
			colleges[0] = new College();
			colleges[0][0] = "ДГТУ";
			colleges["ДГТУ"]["1-ая перемена"] = "9:00  - 10:30";
			colleges["ДГТУ"]["2-ая перемена"] = "10:40 - 12:10";
			colleges["ДГТУ"]["3-ая перемена"] = "12:20 - 13:50";
			colleges["ДГТУ"]["4-ая перемена"] = "14:50 - 16:20";
			colleges["ДГТУ"]["5-ая перемена"] = "17:50 - 19:20";
			colleges["ДГТУ"]["6-ая перемена"] = "19:30 - 21:00";
			colleges[1] = new College
			{
				parameters = new string[] { "ЮФУ", "11:00 - 11:30", "12:00 - 12:30", "13:00 - 13:30", "14:00 - 14:30", "15:00 - 15:30", "16:00 - 16:30" }
			};
			n = 0;
		}

		
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			sel = listBox1.SelectedIndex;
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			int i = 0;
			while (i < count && colleges[i][0].ToLower().StartsWith(textBox1.Text.ToLower()))
				i++;
			listBox1.Items.Clear();
			if (i < count)
			{
				n = i;
				colleges[n].parametersAdd(listBox1);
			}
		}

		private void textBox2_KeyUp(object sender, KeyEventArgs e)
		{
			int i = 0;
			while (i < count && colleges[i][3].ToLower().StartsWith(textBox1.Text.ToLower()))
				i++;
			listBox1.Items.Clear();
			if (i < count)
			{
				n = i;
				colleges[n].parametersAdd(listBox1);
			}
		}
	}


	public class Colleges
	{
		public College[] colleges;

		public Colleges(int count)
		{
			colleges = new College[count];
		}

		public College this[int index]
		{
			get { return colleges[index]; }
			set { colleges[index] = value; }
		}

		public College this[string name] 
		{
			get
			{
				College college = null;
				foreach (var c in colleges)
				{
					if (c.parameters[0] == name)
					{
						college = c;
						break;
					}
				}
				return college;
			}
		}
	}


	public class College
	{
		public string[] parameters;
		public College()
		{
			parameters = new string[7];
		}

		public string this[int index]
		{
			get { return parameters[index]; }
			set { parameters[index] = value; }
		}

		public string this[string name]
		{
			get
			{
				switch (name)
				{
					case "Название": return "название\t" + parameters[0];
					case "1-ая перемена": return "1-ая перемена\t" + parameters[1];
					case "2-ая перемена": return "2-ая перемена\t" + parameters[2];
					case "3-ая перемена": return "3-ая перемена\t" + parameters[3];
					case "4-ая перемена": return "4-ая перемена\t" + parameters[4];
					case "5-ая перемена": return "5-ая перемена\t" + parameters[5];
					case "6-ая перемена": return "6-ая перемена\t" + parameters[6];
					default: return null;
				}
			}
			set
			{
				switch (name)
				{
					case "название": parameters[0] = value; break;
					case "1-ая перемена": parameters[1] = value; break;
					case "2-ая перемена": parameters[2] = value; break;
					case "3-ая перемена": parameters[3] = value; break;
					case "4-ая перемена": parameters[4] = value; break;
					case "5-ая перемена": parameters[5] = value; break;
					case "6-ая перемена": parameters[6] = value; break;
				}
			}
		}

		public void parametersAdd(ListBox listbox)
		{
			listbox.Items.Add(this["Название"]);
			listbox.Items.Add(this["1-ая перемена"]);
			listbox.Items.Add(this["2-ая перемена"]);
			listbox.Items.Add(this["3-ая перемена"]);
			listbox.Items.Add(this["4-ая перемена"]);
			listbox.Items.Add(this["5-ая перемена"]);
			listbox.Items.Add(this["6-ая перемена"]);
		}
	}

}
