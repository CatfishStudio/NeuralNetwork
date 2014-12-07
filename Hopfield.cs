/*
 * Сделано в SharpDevelop.
 * Пользователь: Catfish
 * Дата: 07.12.2014
 * Время: 9:30
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Neural_network
{
	/// <summary>
	/// Description of Hopfield.
	/// </summary>
	public partial class Hopfield : Form
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
        System.IO.StreamWriter sw = new System.IO.StreamWriter("outputHopfield.txt");
        
		public Hopfield()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		/* Открытие окна */
		void HopfieldLoad(object sender, EventArgs e)
		{
			label1.Text = "...";
			// загрузка эталонных изображений
            read(sr, X1);	// нейрон идеального образа "ноль"
            read(sr, X2);   // нейрон идеального образа "один"
            read(sr, X3);	// нейрон идеального образа "два"
            
            sr.Close();
		}
		
		/* Закрытие окна */
		void HopfieldClose(object sender, EventArgs e)
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
		
		int f(int s) // определение значения 1 или -1
        {
            if (s > 0)
                return 1;
            else return( -1);
        }

		/*
        void copy(int[] mas1, int[] mas2) // копирование массивов
        {
            for (int i = 0; i < size; i++)
                mas2[i] = mas1[i];
        }*/

        bool is_equal(int[] mas1, int[] mas2) // определение количества несовпадений
        {
            int err = 0;
            for (int i = 0; i < size; i++)
            {
                if (mas1[i] != mas2[i])
                    err++;
                if (err > 7)
                    return false;
            }
            return true;
        }

        bool is_equal_exact(int[] mas1, int[] mas2) // определяем изменились ли значения выходов Y
        {
            for (int i = 0; i < size; i++)
            {
                if (mas1[i] != mas2[i])
                    return false;
            }
            return true;
        }

		bool train() // состояние нейронов
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
            // рассчитываем новое состояние нейронов y
            int count_iter = 0;
            while(count_iter < 300)
            {
                
                for (int i = 0; i < size; i++)
                {
                    if (Y[i] == -1)
                        sw.Write('0');
                    else sw.Write('1');
                    if ((i + 1) % 6 == 0)
                        sw.WriteLine();
                }
                sw.WriteLine();
                int s;
                int[] copy_Y = new int[size];
                for (int i = 0; i < size; i++)
                    copy_Y[i] = Y[i];
                for (int j = 0; j < size; j++)
                {
                    s = 0;
                    for (int i = 0; i < size; i++)
                    {
                        s += W[j, i] * Y[i];
                    }
                    Y[j] = f(s);
                }
                count_iter++;
                // изменились ли значения выходов Y?
                if (is_equal_exact(Y, copy_Y))
                {
                    break;
                }
            }
            if (is_equal(Y, X1))
            {
                view("Ноль");
                return true;
            }
            if (is_equal(Y, X2))
            {
                view("Один");
                return true;
            }
            if (is_equal(Y, X3))
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
		
		/* Рисовать ========================================== */
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
		/*====================================================*/
	}
}
