using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProyectoTAP___Carreritas_de_F1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hilos para el movimiento de los carros
        Thread proceso_1;
        Thread proceso_2;
        Thread proceso_3;
        Thread proceso_4;

        // Variables para el movimiento de los carros
        public const int meta_x = 960;
        public string mx1 = "derecha";
        public string mx2 = "derecha";
        public string mx3 = "derecha";
        public string mx4 = "derecha";
        public int x1 = 14, y1 = 71;
        public int x2 = 14, y2 = 255;
        public int x3 = 14, y3 = 390;
        public int x4 = 14, y4 = 530;
        int a = 0, b = 0, c = 0, d = 0;// Variables de incremento de posición
        Random ran = new Random();// Generador de números aleatorios

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //Evita que los hilos lancen excepciones al modificar controles de la interfaz
            CheckForIllegalCrossThreadCalls = false;

            //Agegar sonido de fondo
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "..\\..\\Resources\\menu.wav";
            sp.Play();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            velocidad1();
            ptb1.Location = new Point(x1, y1); // localizacion de inicio del carro1
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            velocidad2();
            ptb2.Location = new Point(x2, y2);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            velocidad3();
            ptb3.Location = new Point(x3, y3);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            velocidad4();
            ptb4.Location = new Point(x4, y4);
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            // Inicia los timers
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;

            // Iniciar hilos de los carros
            try
            {
                proceso_1 = new Thread(new ThreadStart(Funcion1));
                proceso_1.Start();
               

                //Agegar sonido de fondo
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = "..\\..\\Resources\\aceleracion.wav";
                sp.Play();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
            try
            {
                proceso_2 = new Thread(new ThreadStart(Funcion2));
                proceso_2.Start();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
            try
            {
                proceso_3 = new Thread(new ThreadStart(Funcion3));
                proceso_3.Start();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
            try
            {
                proceso_4 = new Thread(new ThreadStart(Funcion4));
                proceso_4.Start();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void btn_Pausa_Click(object sender, EventArgs e)
        {
            // Pausa los hilos y los timers
            try
            {
                proceso_1.Suspend();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            try
            {
                proceso_2.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            try
            {
                proceso_3.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            try
            {
                proceso_4.Suspend();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
        }

        private void btn_Reanudar_Click(object sender, EventArgs e)
        {
            // Reanuda los hilos y los timers
            try
            {
                proceso_1.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            try
            {
                proceso_2.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            try
            {
                proceso_3.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            try
            {
                proceso_4.Resume();

            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            //Agegar sonido de fondo
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "..\\..\\Resources\\alospits.wav";
            sp.Play();

            // Reinicia las posiciones y los valores de los carros
            mx1 = "derecha";
            mx2 = "derecha";
            mx4 = "derecha";
            mx4 = "derecha";
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            x1 = 14;
            y1 = 71;
            x2 = 14;
            y2 = 255;
            x3 = 14;
            y3 = 390;
            x4 = 14;
            y4 = 530;
            ptb1.Location = new Point(x1, y1);
            ptb2.Location = new Point(x2, y2);
            ptb3.Location = new Point(x3, y3);
            ptb4.Location = new Point(x4, y4);
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;

            // Detiene los hilos
            proceso_1.Abort();
            proceso_2.Abort();
            proceso_3.Abort();
            proceso_4.Abort();
        }

        // Método para el hilo del carro 1
        public void Funcion1()
        {
            int v1 = ran.Next(5, 50);
            while (true)
            {
                Thread.Sleep(v1);// Simula el movimiento con pausas
                a++;
            }
        }

        public void velocidad1()
        {
            if (mx1 == "derecha")
            {
                x1 = x1 + a;
                posicion1();
            }
            else
            {
            }
        }

        public void posicion1()
        {
            if (x1 >= meta_x)
            {
                mx1 = "derecha";
                x1 = meta_x;
                timer1.Stop();
            }
        }

        // Método para el hilo del carro 2
        public void Funcion2()
        {
            int v2 = ran.Next(5, 50);
            while (true)
            {
                Thread.Sleep(v2);
                b++;
            }
        }
        public void velocidad2()
        {
            if (mx2 == "derecha")
            {
                x2 = x2 + b;
                posicion2();
            }
            else
            {
            }
        }
        public void posicion2()
        {
            if (x2 >= meta_x)
            {
                mx2 = "derecha";
                x2 = meta_x;
                timer2.Stop();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            ganador();// Verifica el ganador en cada tick
        }

        // Método para el hilo del carro 3
        public void Funcion3()
        {
            int v3 = ran.Next(5, 50);
            while (true)
            {
                Thread.Sleep(v3);
                c++;
            }
        }
        public void velocidad3()
        {
            if (mx3 == "derecha")
            {
                x3 = x3 + c;
                posicion3();
            }
            else
            {
            }
        }
        public void posicion3()
        {
            if (x3 >= meta_x)
            {
                mx3 = "derecha";
                x3 = meta_x;
                timer3.Stop();
            }
        }

        // Método para el hilo del carro 4
        public void Funcion4()
        {
            int v4 = ran.Next(5, 50);
            while (true)
            {
                Thread.Sleep(v4);
                d++;
            }
        }
        public void velocidad4()
        {
            if (mx4 == "derecha")
            {
                x4 = x4 + d;
                posicion4();
            }
            else
            {
            }
        }
        public void posicion4()
        {
            if (x4 >= meta_x)
            {
                mx4 = "derecha";
                x4 = meta_x;
                timer4.Stop();
            }
        }

        public void ganador()
        {
            int[] pos = { x1, x2, x3, x4 };

            // Determina qué carro está más adelante
            int max = 0;
            for (int i = 0; i < pos.Length; i++)
            {
                if (pos[i] >= pos[max])
                    max = i;
            }

            if (pos[max] >= meta_x)
            {
                timer5.Enabled = false;
                MessageBox.Show($"GANADOR: CARRO {max+1}");
            }
        }
    }
}
