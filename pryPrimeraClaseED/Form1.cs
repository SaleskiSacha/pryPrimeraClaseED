using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPrimeraClaseED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        clsCliente clsCliente = new clsCliente();
        private void btnComprar_Click(object sender, EventArgs e)
        {
            Decimal Valor =  Convert.ToDecimal(txtImporte.Text);
            clsCliente.Comprar(Valor);
            lblDeuda.Text = clsCliente.Deuda.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Decimal Valor = Convert.ToDecimal(txtImporte.Text);
            clsCliente.Pagar(Valor);
            lblDeuda.Text = clsCliente.Deuda.ToString();
        }
    }
}
