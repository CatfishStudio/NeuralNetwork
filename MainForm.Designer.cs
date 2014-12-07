/*
 * Сделано в SharpDevelop.
 * Пользователь: Catfish
 * Дата: 07.12.2014
 * Время: 9:13
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
namespace Neural_network
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.нейронныеСетиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сатьХопфилдаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сетьХеммингаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.файлToolStripMenuItem,
									this.нейронныеСетиToolStripMenuItem,
									this.справкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.выходToolStripMenuItem.Text = "Выход.";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItemClick);
			// 
			// нейронныеСетиToolStripMenuItem
			// 
			this.нейронныеСетиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.сатьХопфилдаToolStripMenuItem,
									this.сетьХеммингаToolStripMenuItem});
			this.нейронныеСетиToolStripMenuItem.Name = "нейронныеСетиToolStripMenuItem";
			this.нейронныеСетиToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
			this.нейронныеСетиToolStripMenuItem.Text = "Нейронные сети";
			// 
			// сатьХопфилдаToolStripMenuItem
			// 
			this.сатьХопфилдаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сатьХопфилдаToolStripMenuItem.Image")));
			this.сатьХопфилдаToolStripMenuItem.Name = "сатьХопфилдаToolStripMenuItem";
			this.сатьХопфилдаToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.сатьХопфилдаToolStripMenuItem.Text = "Сать Хопфилда.";
			this.сатьХопфилдаToolStripMenuItem.Click += new System.EventHandler(this.СатьХопфилдаToolStripMenuItemClick);
			// 
			// сетьХеммингаToolStripMenuItem
			// 
			this.сетьХеммингаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сетьХеммингаToolStripMenuItem.Image")));
			this.сетьХеммингаToolStripMenuItem.Name = "сетьХеммингаToolStripMenuItem";
			this.сетьХеммингаToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.сетьХеммингаToolStripMenuItem.Text = "Сеть Хемминга.";
			this.сетьХеммингаToolStripMenuItem.Click += new System.EventHandler(this.СетьХеммингаToolStripMenuItemClick);
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.оПрограммеToolStripMenuItem});
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.справкаToolStripMenuItem.Text = "Справка";
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.оПрограммеToolStripMenuItem.Text = "О программе.";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItemClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 395);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(784, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(163, 17);
			this.toolStripStatusLabel1.Text = "© Сомов Евгений Павлович";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 371);
			this.panel1.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 371);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Задание:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(6, 98);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(183, 265);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(158, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "изображение по вариантам:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "распознавала следующие";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(175, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "таким образом, чтобы она ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(191, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "пикселей запрограммировать сеть";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Для соответствующей системы";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 417);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Нейронная сеть";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem сетьХеммингаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сатьХопфилдаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem нейронныеСетиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
