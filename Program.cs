using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daniel_Proyecto
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Datos_Load(object sender, EventArgs e)
        {
        
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = NombreText.Text;
            string Apellido = ApellidoText.Text;
            string Cedula = CedulaText.Text;
            Cedula = Convert.ToString(Cedula);
            string Dirección = DireccionText.Text;
            string Lugar = LugarText.Text;
            string Codigo = CodigoText.Text;
            string Tarjeta = TarjetaDe.Text;
            string Codi = CodigoDe.Text;
            int Cantidad, Dolares; 
            Cantidad = int.Parse(CantidadEn.Text);
            Dolares = Cantidad/45;

            if (Dol.Checked)
            { Dolar.Text = Dolares.ToString();
                Peso.Text = "0" ;
            }

            if (Pes.Checked)
            { Peso.Text = Cantidad.ToString();
                Dolar.Text = "0";
            }

            if (Efectivo.Checked)
            {
                TarjetaDe.Text = "Innecesario";
                CodigoDe.Text = "Innecesario";
            }

            if (Tarjetas.Checked)
            {
                TarjetaDe.Text = "";
                CodigoDe.Text = "";
            }


            string lines = "Nombre: " + Nombre + "\r\n" + "Apellido: " + Apellido + "\r\n" + "Cedula: " + Cedula + "\r\n" + "Dirección: " + Dirección+ "\r\n" + "Lugar: " + Lugar + "\r\n" + "Servicio: " + "\r\n" + "Cantidad en Dolares: " + Dolares + "\r\n" + "Cantidad en Pesos: " + Cantidad + "\r\n" + "Tarjeta " + Tarjeta + "\r\n" + "Codigo de Tarjeta " + Codi + "\r\n";

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Formulario.txt";

            System.IO.StreamWriter file = new System.IO.StreamWriter(path, true);
            file.WriteLine(lines);
            file.Close();


            if (System.IO.File.Exists(path))
            {
                MessageBox.Show("Los Datos han sido guardados exitasamente");
            }

            NombreText.Text = "";
            ApellidoText.Text = "";
            CedulaText.Text = "";
            DireccionText.Text = "";
            LugarText.Text = "";
            CodigoText.Text = "";
            TarjetaDe.Text = "";
            CodigoDe.Text = "";
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void CantidadEnviar_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Dolar_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TarjetaDe_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

