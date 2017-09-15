using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01
{
    public partial class Calculadora_Form : Form
    {
        public Calculadora_Form()
        {
            InitializeComponent();
        }

        private void Calculadora_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        // Se llama al método operar con el botón.
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;

            Numero numero1 = new Numero(txtNumero1.Text);
            Numero numero2 = new Numero(txtNumero2.Text);

            resultado = Calculadora.operar(numero1, numero2, cmbOperacion.Text);

            lblResultado.Text = resultado.ToString();

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        // Vacía el contenido de la calculadora.
        private void limpiar()
        {
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperacion.SelectedIndex = 0;
        }

    }
}
