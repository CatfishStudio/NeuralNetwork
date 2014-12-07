/*
 * Сделано в SharpDevelop.
 * Пользователь: Catfish
 * Дата: 07.12.2014
 * Время: 9:13
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Neural_network
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void ОПрограммеToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Программа: Neural network" + System.Environment.NewLine + "Версия: 1.0" + System.Environment.NewLine + "Автор: Сомов Евгений Павлович" + System.Environment.NewLine + "©  Somov Evgeniy, 2014", "О программе", MessageBoxButtons.OK);						
		}
		
		void СатьХопфилдаToolStripMenuItemClick(object sender, EventArgs e)
		{
			Hopfield HNetwork = new Hopfield();
			HNetwork.MdiParent = this;
			HNetwork.Show();
		}
		
		void СетьХеммингаToolStripMenuItemClick(object sender, EventArgs e)
		{
			Hemming HNetwork = new Hemming();
			HNetwork.MdiParent = this;
			HNetwork.Show();
		}
	}
}
