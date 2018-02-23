using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public int direccionMov(int n)
        {
            int numero = (n >> 1) & 7;
            txtNumero.Text = numero.ToString();
            switch (numero)
            {
                case 0:
                    pBoxDireccion.Image = Properties.Resources.Norte;
                    break;
                case 1:
                    pBoxDireccion.Image = Properties.Resources.NE;
                    break;
                case 2:
                    pBoxDireccion.Image = Properties.Resources.Este;
                    break;
                case 3:
                    pBoxDireccion.Image = Properties.Resources.SE;
                    break;
                case 4:
                    pBoxDireccion.Image = Properties.Resources.Sur;
                    break;
                case 5:
                    pBoxDireccion.Image = Properties.Resources.SO;
                    break;
                case 6:
                    pBoxDireccion.Image = Properties.Resources.Oeste;
                    break;
                case 7:
                    pBoxDireccion.Image = Properties.Resources.NO;
                    break;
            }
            
            return numero;
        }
        
        public int nivelTanque(int n)
        {
            int numero = (n >> 4) & 3;
            txtNumero.Text = numero.ToString();
            switch (numero)
            {
                case 0:
                    pBoxNivel.Image = Properties.Resources.vacio;
                    break;
                case 1:
                    pBoxNivel.Image = Properties.Resources.nivel_medio;
                    break;
                case 2:
                    pBoxNivel.Image = Properties.Resources.lleno;
                    break;
                case 3:
                    pBoxNivel.Image = Properties.Resources.llenando;
                    break;

            }
         
            return numero;
        }
        
        public int sensor2(int n)
        {
            int numero = (n >> 6) & 1;
            txtNumero.Text = numero.ToString();
            switch (numero)
            {
                case 0:
                    pBoxSensores2.Image = Properties.Resources.sensor1A;
                   // Console.WriteLine("0");
                    break;
                case 1:
                    pBoxSensores2.Image = Properties.Resources.sensor1E;
                   // Console.WriteLine("1");
                    break;
          
       }
            return numero;
        }

        public int sensor1(int n)
        {
            int numero = (n >> 7) & 1;
            txtNumero.Text = numero.ToString();
            switch (numero)
            {
                case 0:
                    pBoxSensores.Image = Properties.Resources.sensor2a;
                    break;
                // Console.WriteLine("0");
                case 1:
                    pBoxSensores.Image = Properties.Resources.sensor2;
                    break;
                // Console.WriteLine("1");
            }

            return numero;
        }

        public void fecha(int n)
        {
            int dia = (n >>= 1) & 31;
            int mes = (n >>= 5) & 12;
            int year = ((n >>= 4) & 127) + 1900;
            lblFecha.Text = year.ToString() + "/" + mes.ToString() + "/" + dia.ToString();
        }

        public int regresarFecha(string fecha)
        {
            int numero = Convert.ToInt32(txtFecha.Text);
            return numero;
        }

        public int obtenerFecha(string fecha)
        {
            String[] partes = fecha.Split('/');

            int dia = Convert.ToInt32(partes[0]);
            int mes = Convert.ToInt32(partes[1]) << 5;
            int year = (Convert.ToInt32(partes[2]) - 1900) << 9;

            return dia + mes + year;
        }

        private void btnProcesar_Click_1(object sender, EventArgs e)
        {
            Int32 numero = Convert.ToInt32(txtNumero.Text);
            direccionMov(numero);
            nivelTanque(numero);
            sensor1(numero);
            sensor2(numero);
            fecha(numero);
            lblx.Text = numero.ToString();
        }

        private void btnNuevaFecha_Click_1(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            txtFechaNew.Text = obtenerFecha(fecha).ToString();
        }
    }
}
