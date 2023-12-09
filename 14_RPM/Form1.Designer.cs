namespace _14_RPM
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.textBox8);
			this.groupBox3.Controls.Add(this.textBox9);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox3.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(631, 409);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Чтение файлов";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.ForeColor = System.Drawing.SystemColors.Info;
			this.button3.Location = new System.Drawing.Point(222, 33);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(393, 34);
			this.button3.TabIndex = 5;
			this.button3.Text = "Прочитать первый файл";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox8.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.textBox8.Location = new System.Drawing.Point(11, 272);
			this.textBox8.Multiline = true;
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(604, 131);
			this.textBox8.TabIndex = 3;
			// 
			// textBox9
			// 
			this.textBox9.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox9.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.textBox9.Location = new System.Drawing.Point(10, 76);
			this.textBox9.Multiline = true;
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(605, 117);
			this.textBox9.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label5.Location = new System.Drawing.Point(7, 219);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(209, 21);
			this.label5.TabIndex = 1;
			this.label5.Text = "Информация из файла:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label6.Location = new System.Drawing.Point(6, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(209, 21);
			this.label6.TabIndex = 0;
			this.label6.Text = "Информация из файла:";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.ForeColor = System.Drawing.SystemColors.Info;
			this.button4.Location = new System.Drawing.Point(222, 212);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(393, 34);
			this.button4.TabIndex = 6;
			this.button4.Text = "Прочитать второй файл";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button1);
			this.groupBox4.Controls.Add(this.button6);
			this.groupBox4.Controls.Add(this.textBox10);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox4.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.groupBox4.Location = new System.Drawing.Point(12, 457);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(631, 208);
			this.groupBox4.TabIndex = 9;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Обработка информации";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.ForeColor = System.Drawing.SystemColors.Info;
			this.button6.Location = new System.Drawing.Point(309, 33);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(121, 34);
			this.button6.TabIndex = 5;
			this.button6.Text = "Обработать";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// textBox10
			// 
			this.textBox10.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox10.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.textBox10.Location = new System.Drawing.Point(10, 76);
			this.textBox10.Multiline = true;
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(605, 117);
			this.textBox10.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label8.Location = new System.Drawing.Point(6, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(297, 21);
			this.label8.TabIndex = 0;
			this.label8.Text = "Результат обработки информации:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = System.Drawing.SystemColors.Info;
			this.button1.Location = new System.Drawing.Point(436, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(179, 34);
			this.button1.TabIndex = 6;
			this.button1.Text = "Сохранить в файл";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(717, 681);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Name = "Form1";
			this.Text = "Поиск в файлах первого несоответствия чисел (строки и позиции)";
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
	}
}

