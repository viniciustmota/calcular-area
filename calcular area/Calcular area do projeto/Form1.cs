using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_area_do_projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblMaior_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int maior = int.Parse(txtMaior.Text);
            int menor = int.Parse(txtMenor.Text);
            int altura = int.Parse(txtAltura.Text);

            int resultado = ((maior + menor) * altura) / 2;
            lblResultado.Text = "A área do trapezio é: " + resultado;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = ""; txtMaior.Text = ""; txtMenor.Text = ""; txtAltura.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Deseja finalizar a aplicação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (mensagem == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
