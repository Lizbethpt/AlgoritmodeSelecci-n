using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace appMetododeselecciónnuevo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int n;
        public int i;
        public void generarDatos()
        {
            int[] datos = new int[int.Parse(txttamaño.Text)];
            Random r = new Random();
            for (i = 0; i < datos.Length; i++)
            {
                datos[i] = r.Next(0, 100);
            }
            Ejecutar(datos); 
        }
        public void ordenamientoseleccion( int [] datos)
        {
            int tamaño = datos.Length;
            int minimo = 0;
            int aux = 0;
            for (int i = 0; i < tamaño; i++)
            {
                minimo = i;
                for (int j = i +1; j < tamaño; j++)
                {
                    if (datos [j]< datos [minimo])
                    {
                        minimo = j;
                    }
                }
                aux = datos[i];
                datos[i] = datos[minimo];
                datos[minimo] = aux; 
            }
            txtvector.Text += "Vector Ordenado" + Environment.NewLine;
            foreach (int dato in datos)
            {
                txtvector.Text += dato + Environment.NewLine;
            }
        }
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            generarDatos();
        }
        private void Ejecutar(int[] datos)
        {
            txtvector.Text += "Vector Desordenado" + Environment.NewLine;
            foreach (int dato in datos)
            {
                txtvector.Text += dato + Environment.NewLine;
            }
            double tiempoInicial = double.Parse(DateTime.Now.Ticks.ToString());
            ordenamientoseleccion(datos);
            double tiempoFinal = double.Parse(DateTime.Now.Ticks.ToString());
            lblod.Text = ((tiempoFinal - tiempoInicial) / 10000).ToString();
        }
        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtvector.Clear();
            txttamaño.Clear();
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
          Close();
        }
    }
}
