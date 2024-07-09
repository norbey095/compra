using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace progreso
{
    public partial class Form1 : Form
    {
        clase total = new clase();
        int iterableImage = 0;
        public Form1()
        {
            InitializeComponent();
        }       

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            progressbar();
            total.cantidad = Convert.ToDouble(txtCantidad.Text);
            total.valor = Convert.ToDouble(txtValorProducto.Text);
            total.totalcompra += total.multiplicar(total.valor, total.cantidad);
            Lblresul.Text = Convert.ToString(total.totalcompra);
            listBox1.Items.Add("Se agrego el producto: " + txtNombre.Text + ", cantidad: " + txtCantidad.Text + " y valor unitario: " + txtValorProducto.Text);
            txtNombre.Clear();
            txtCantidad.Clear();
            txtValorProducto.Clear();
        }       

        private void progressbar()
        {
            progressBar1.Maximum = 10000;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            for (int i = progressBar1.Value; i <= progressBar1.Maximum - 1; i++)
            {
                progressBar1.Value = i;
            }
        }      

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            progressbar();
            total.cantidad = Convert.ToDouble(txtCantidad.Text);
            total.valor = Convert.ToDouble(txtValorProducto.Text);
            total.eliminar(total.multiplicar(total.valor, total.cantidad));
            Lblresul.Text = Convert.ToString(total.totalcompra);
            listBox1.Items.Add("Se elimino el producto: " + txtNombre.Text + ", cantidad: " + txtCantidad.Text + " y valor unitario: " + txtValorProducto.Text);
            txtNombre.Clear();
            txtCantidad.Clear();
            txtValorProducto.Clear();
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            pictureBox1.Image = imageList1.Images[iterableImage];
            if (iterableImage == imageList1.Images.Count - 1)
            {
                iterableImage = 0;
            }
            else
            {
                iterableImage++;
            }

        }
        private void BtnComprar_Click(object sender, EventArgs e)
        {
            double compra = total.totalcompra;
            if (ComboBox1.Text == "Medellin")
            {
                total.agregar(7000);
            } else if (ComboBox1.Text == "Bogota")
            {
                total.agregar(6000);
            } else if (ComboBox1.Text == "Cali")
            {
                total.agregar(8000);
            } else 
            {
                total.agregar(10000);
            }
            Lblresul.Text = "";            
            listBox1.ClearSelected();
            listBox1.Items.Clear();
            ComboBox1.Text = "";
            progressBar1.Value = 0;            

            MessageBox.Show("El valor de tu pedido es de: "+ compra + "\nMás el envio: " + total.totalcompra + "  " +
                "\nSu compra ha finalizado, hasta la proxima");

            total.totalcompra = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void TextBox3_TextChanged(object sender, EventArgs e){}
        private void ProgressBar1_Click(object sender, EventArgs e){}

        private void Form1_Load(object sender, EventArgs e){}

        private void Lblresul_Click(object sender, EventArgs e){ }
    }
}
