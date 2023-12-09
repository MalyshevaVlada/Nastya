namespace _15_RPM
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.textBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.textBox2.Location = new System.Drawing.Point(183, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(526, 27);
			this.textBox2.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label3.Location = new System.Drawing.Point(19, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 19);
			this.label3.TabIndex = 16;
			this.label3.Text = "Слово для поиска:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.richTextBox2);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.groupBox3.Location = new System.Drawing.Point(13, 360);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox3.Size = new System.Drawing.Size(717, 279);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Результат проверки строк текста:";
			// 
			// richTextBox2
			// 
			this.richTextBox2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox2.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.richTextBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.richTextBox2.Location = new System.Drawing.Point(13, 38);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(683, 174);
			this.richTextBox2.TabIndex = 15;
			this.richTextBox2.Text = "";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.button3.ForeColor = System.Drawing.SystemColors.Info;
			this.button3.Location = new System.Drawing.Point(459, 218);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(237, 39);
			this.button3.TabIndex = 6;
			this.button3.Text = "Найти совпадения";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Location = new System.Drawing.Point(6, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 21);
			this.label2.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.richTextBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.groupBox1.Location = new System.Drawing.Point(13, 71);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(717, 261);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Текст из файла:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.richTextBox1.Location = new System.Drawing.Point(13, 26);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(683, 172);
			this.richTextBox1.TabIndex = 14;
			this.richTextBox1.Text = "";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = System.Drawing.SystemColors.Info;
			this.button1.Location = new System.Drawing.Point(459, 204);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(237, 34);
			this.button1.TabIndex = 5;
			this.button1.Text = "Прочитать файл";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(6, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 21);
			this.label1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(747, 651);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Поиск в тексте введённого слова, написанного в нижнем регистре";
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}

