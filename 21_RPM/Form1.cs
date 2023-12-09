using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _20_RPM
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Colleges colleges;
		int count = 4;
		public static int n;
		public static int sel = -1;
		public static string key = null;

		private void button1_Click(object sender, EventArgs e)
		{
			Изменение изменение = new Изменение(ref colleges);
			изменение.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (n > 0)
			{
				n--;
				listBox2.SelectedIndex = n;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{

			if (n < count - 1)
			{
				n++;
				listBox2.SelectedIndex = n;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (key != null)
			{
				if (key.ToString() == "Название" || key.ToString() == "3-ая перемена")
				{
					MessageBox.Show("Нельзя удалить указанную характеристику!!!"); return;
				}
				colleges[n].Remove(key);
				key = null;
				listBox1.Items.Clear();
				colleges[n].parametersAdd(listBox1);
			}
			else
			{
				MessageBox.Show("Не указана удаляемая характеристика!!!"); return;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			colleges = new Colleges(count);
			colleges[0] = new College();
			colleges[0]["Название"] = "ДГТУ";
			colleges[0]["1-ая перемена"] = "9:00  - 10:30";
			colleges[0]["2-ая перемена"] = "10:40 - 12:10";
			colleges[0]["3-ая перемена"] = "12:20 - 13:50";
			colleges[0]["4-ая перемена"] = "14:50 - 16:20";
			colleges[0]["5-ая перемена"] = "17:50 - 19:20";
			colleges[0]["6-ая перемена"] = "19:30 - 21:00";

			colleges[1] = new College();
			colleges[1]["Название"] = "ИУБИП";
			colleges[1]["1-ая перемена"] = "7:00 - 8:30";
			colleges[1]["2-ая перемена"] = "8:40 - 9:10";
			colleges[1]["3-ая перемена"] = "10:20 - 11:50";
			colleges[1]["4-ая перемена"] = "11:50 - 12:20";
			colleges[1]["5-ая перемена"] = "13:50 - 14:20";
			colleges[1]["6-ая перемена"] = "15:30 - 16:00";

			colleges[2] = new College
			{
					{ "Название", "ЮФУ" }, { "1-ая перемена", "11:00 - 11:30" },
					{ "2-ая перемена", "12:00 - 12:30" }, { "3-ая перемена", "13:00 - 13:30" },
					{ "4-ая перемена", "14:00 - 14:30" }, { "5-ая перемена", "15:00 - 15:30" },
					{ "6-ая перемена", "16:00 - 16:30" }
			};

			colleges[3] = new College
			{
					{ "Название", "РИНХ" }, { "1-ая перемена", "15:00 - 15:40" },
					{ "2-ая перемена", "16:00 - 16:40" }, { "3-ая перемена", "17:00 - 17:40" },
					{ "4-ая перемена", "18:00 - 18:40" }, { "5-ая перемена", "19:00 - 19:40" },
					{ "6-ая перемена", "20:00 - 20:40" }
			};
			n = 0;
		}

		private void Form1_Activated(object sender, EventArgs e)
		{
			listBox2.Items.Clear();
			foreach (College c in colleges)
				listBox2.Items.Add(c["Название"] + "\t" + c["3-ая перемена"]);
			listBox2.SelectedIndex = n;
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			int i = 0;
			while (i < count && colleges[i]["Название"].ToString().ToLower().StartsWith(textBox1.Text.ToLower()))
				i++;
			if (i < count) n = i;
			else n = 0;
			listBox2.SelectedIndex = n;
		}

		private void textBox2_KeyUp(object sender, KeyEventArgs e)
		{
			int i = 0;
			while (i < count && colleges[i]["3-ая перемена"].ToString().ToLower().StartsWith(textBox1.Text.ToLower()))
				i++;

			if (i < count) n = i;
			else n = 0;
			listBox2.SelectedIndex = n;
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex >= 0)
			{
				string[] dictionary = listBox1.Items[listBox1.SelectedIndex].ToString().Split('\t');
				key = dictionary[0].TrimEnd();
			}
		}

		private void listBox2_Click(object sender, EventArgs e)
		{
			n = listBox2.SelectedIndex;
		}

		private void listBox2_SelectedValueChanged(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			colleges[n].parametersAdd(listBox1);
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			Array.Sort(colleges.colleges);

			listBox2.Items.Clear();
			foreach (College c in colleges)
				listBox2.Items.Add(c["Название"] + "\t" + c["3-ая перемена"]);
			n = 0;
			listBox2.SelectedIndex = n;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			Array.Sort(colleges.colleges); Array.Reverse(colleges.colleges);

			listBox2.Items.Clear();
			foreach (College c in colleges)
				listBox2.Items.Add(c["Название"] + "\t" + c["3-ая перемена"]);
			n = 0;
			listBox2.SelectedIndex = n;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			Array.Sort(colleges.colleges, new Time());
			listBox2.Items.Clear();
			foreach (College c in colleges)
				listBox2.Items.Add(c["Название"] + "\t" + c["3-ая перемена"]);
			n = 0;
			listBox2.SelectedIndex = n;
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			Array.Sort(colleges.colleges, new Time()); Array.Reverse(colleges.colleges);

			listBox2.Items.Clear();
			foreach (College c in colleges)
				listBox2.Items.Add(c["Название"] + "\t" + c["3-ая перемена"]);
			n = 0;
			listBox2.SelectedIndex = n;
		}

		
	}






	class Time : IComparer<College>
	{
		public int Compare(College obj1, College obj2)
		{
			return obj1["3-ая перемена"].ToString().CompareTo(obj2["3-ая перемена"].ToString());
		}
	}

	public class Colleges : IEnumerable, IEnumerator
	{
		public College[] colleges;
		int index = -1;

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
					if (college["Название"].ToString() == name)
					{
						college = c;
						break;
					}
				}
				return college;
			}
		}

		public IEnumerator GetEnumerator()
		{
			return this;
		}

		public object Current
		{
			get { return colleges[index]; }
		}

		public bool MoveNext()
		{
			if (index == colleges.Length - 1)
			{ Reset(); return false; }
			index++; return true;
		}

		public void Reset()
		{
			index = -1;
		}
	}

	public class College : Hashtable, IComparable<College>
	{
		public Hashtable parameters;

		public College()
		{
			parameters = new Hashtable { { "Название", null }, { "1-ая перемена", null }, { "2-ая перемена", null },
				{ "3-ая перемена", null }, { "4-ая перемена", null }, { "5-ая перемена", null }, { "6-ая перемена", null }
			};
		}

		public void parametersAdd(ListBox listbox)
		{
			listbox.Items.Add("Название\t" + this["Название"]);
			listbox.Items.Add("1-ая перемена\t" + this["1-ая перемена"]);
			listbox.Items.Add("2-ая перемена\t" + this["2-ая перемена"]);
			listbox.Items.Add("3-ая перемена\t" + this["3-ая перемена"]);
			listbox.Items.Add("4-ая перемена\t" + this["4-ая перемена"]);
			listbox.Items.Add("5-ая перемена\t" + this["5-ая перемена"]);
			listbox.Items.Add("6-ая перемена\t" + this["6-ая перемена"]);
		}

		public int CompareTo(College obj)
		{
			return this["Название"].ToString().CompareTo(obj["Название"].ToString());
		}
	}
}
