using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Operacion ingreso;
        public Form1()
        {
            InitializeComponent();
        }

        private void frmOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtValA.Text);
            ingreso.V2 = double.Parse(txtValB.Text);

            lblResul.Text = ingreso.CalcularSuma().ToString();

        }

        private void resta_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtValA.Text);
            ingreso.V2 = double.Parse(txtValB.Text);

            lblResul.Text = ingreso.CalcularResta().ToString();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtValA.Text);
            ingreso.V2 = double.Parse(txtValB.Text);

            lblResul.Text = ingreso.CalcularMulti().ToString();

        }

        private void div_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtValA.Text);
            ingreso.V2 = double.Parse(txtValB.Text);

            if (ingreso.V2 == 0)
            {
                lblResul.Text ="No se puede dividir";
            }
            else
            {
                lblResul.Text = ingreso.CalcularDiv().ToString();
            }
        }
    }
}
