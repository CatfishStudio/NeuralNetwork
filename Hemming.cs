/*
 * Сделано в SharpDevelop.
 * Пользователь: Catfish
 * Дата: 07.12.2014
 * Время: 12:15
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Neural_network
{
	/// <summary>
	/// Description of Hemming.
	/// </summary>
	public partial class Hemming : Form
	{
		const int size = 66; // 6x11
        int[] X1 = new int[size]; 
        int[] X2 = new int[size];
        int[] X3 = new int[size];
       
 
        int[] Y = new int[size]; // зашумленный вход
        int[,] W = new int[size, size];
        int[] draws = new int[size];
        bool mode = true;
        
        System.IO.StreamReader sr = new System.IO.StreamReader("ideal.txt");
        System.IO.StreamWriter sw = new System.IO.StreamWriter("outputHemming.txt");
		
		public Hemming()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void HemmingLoad(object sender, EventArgs e)
		{
			label1.Text = "...";
			// загрузка эталонных изображений
            read(sr, X1);	// нейрон идеального образа "ноль"
            read(sr, X2);   // нейрон идеального образа "один"
            read(sr, X3);	// нейрон идеального образа "два"
            
            sr.Close();
		}
		
		/* Закрытие окна */
		void HemmingClose(object sender, EventArgs e)
		{
			sr.Close();
			sw.Close();
        }
		
		/* Показать результат */
		void view(string s)
        {
            label1.Text = s;
        }
		
		/* Чтение данных из файла */
		void read(System.IO.StreamReader reader, int[] mass)
        {
            for (int i = 0; i < size; i++)
            {
                char a = (char)reader.Read();
                if (a == '1')
                    mass[i] = 1;
                else mass[i] = -1;
            }
        }
		
		/* Очистка */
		void clear()
		{
			label1.Text = "...";
			listBox1.Items.Clear();
			for (int i = 0; i < size; i++){
            	draws[i] = -1;
            	Y[i] = 0;
            	for (int j = 0; j < size; j++){
            		W[i,j] = 0;
            	}
			}
			panel1.Refresh();
		}
		
		/* Распознать ====================================================*/
		void perform()
		{
			label1.Text = "";
            for (int i = 0; i < size; i++)
            {
                if (draws[i] == 1)
                    Y[i] = 1;
                else Y[i] = -1;
            }
            if (train())
            {
                recognize();
            }	
		}
		
		int f(int s)
        {
            if (s > 0)
                return 1;
            else return( -1);
        }
		
		int compare(int[] mas1, int[] mas2)
        {
            int err = 0;
            for (int i = 0; i < size; i++)
            {
                if (mas1[i] != mas2[i])
                    err++;
			}
            return err;
        }
		
		bool train()
        {
			// инициализация весов
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                        W[i, j] = 0;
                    else W[i, j] = X1[i] * X1[j] + X2[i] * X2[j] + X3[i] * X3[j];
                }
            }
            
            int s;
            int[] copy_Y = new int[size];
			for (int i = 0; i < size; i++){
				copy_Y[i] = Y[i];
			}
			for (int j = 0; j < size; j++)
			{
				s = 0;
				for (int i = 0; i < size; i++)
				{
					s += W[j, i] * Y[i];
				}
				Y[j] = f(s);
			}
			
			// определяем расстояние
			float r1 = compare(Y, X1);
			float r2 = compare(Y, X2);
			float r3 = compare(Y, X3);
			
			// вычисляем потенциал
			float[] p = new float[3];
			listBox1.Items.Clear();
			for(int i = 0; i < 3; i++)
			{
				if(i == 0) p[i] = 1000000/(1+r1*r1);
				if(i == 1) p[i] = 1000000/(1+r2*r2);
				if(i == 2) p[i] = 1000000/(1+r3*r3);
				listBox1.Items.Add(p[i].ToString());
			}
			
			// находим какому образу соответствует наибольший потенциал.
			int index = 0;
			float max = 0.0f;
			for(int i = 0; i < 3; i++)
			{
				if(p[i] > max){
					max = p[i];
					index = i;
				}
			}
			if (index == 0)
            {
                view("Ноль");
                return true;
            }
			if (index == 1)
            {
                view("Один");
                return true;
            }
			if (index == 2)
            {
                view("Два");
                return true;
            }
			view("не знаю");
            return false;
		}
				
		void recognize() // распознать
        {
            for (int i = 0; i < size; i++)
            {
                if (Y[i] == -1)
                    sw.Write('0');
                else sw.Write('1');
                if ((i + 1) % 6 == 0)
                    sw.WriteLine();
            }
                    
        }
		/*===========================================================*/
		
		
		void Button4Click(object sender, EventArgs e)
		{
			perform();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			mode = true;			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			mode = false;
			label1.Text = "...";			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			clear();
		}
		
		void Panel1MouseDown(object sender, MouseEventArgs e)
		{
			int i = e.X / 20; // 6
            int j = e.Y / 20; // 11
            if(mode)
                draws[j * 6 + i] = 1;
            else draws[j * 6 + i] = -1;
            panel1.Refresh();
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
            for (int i = 0; i < size; i++)
            {
                if (draws[i] == 1)
                {
                    int vert = i % 6;
                    int gor = i / 6;
                    g.FillRectangle(System.Drawing.Brushes.Black, vert * 20, gor * 20, 20, 20);
                }
            }
		}
	}
}
