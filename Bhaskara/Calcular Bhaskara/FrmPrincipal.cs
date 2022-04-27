using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Bhaskara
{
    public partial class Bhaskara : Form
    {
        public Bhaskara()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            lbDelta.Visible = false;
            lbXP.Visible = false;
            lbXN.Visible = false;

            //1. Obteção do valores "a" "b" e "c":
            int a, b, c;
            try
            {
                a = int.Parse(textA.Text);
                b = int.Parse(textB.Text);
                c = int.Parse(textC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro nos Valores de Entrada!");
                return;
            }

            //2. Se for zero, nao pode:
            if (a == 0)
            {
                MessageBox.Show("O Valor do A não pode ser zero!");
                return;
            }

            //3. Iniciar o processo de cálculo
            double delta = (a * b) - 4 * a * c;

            //4 Se o delta for negativo, informar...
            if(delta < 0)
            {
                lbDelta.Text = "O Delta é negativo: " + delta;
                lbXP.Text = "Não é possível calcúlar as raízes";

                lbDelta.Visible = true;
                lbXP.Visible = true;

                return;
            }

            //5. Cáculo das raízes...
            double xP, xN;
            xP = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
            xN = ((-b) - Math.Sqrt(delta)) / (2 * a);

            //6. Exibição dos resultados.
            if (xP == xN)
            {
                lbXP.Text = "X' = X\" = " + xP;
                lbXP.Visible = true;

                return;
            }

            lbDelta.Text = "Delta = " + delta;
            lbXP.Text = "x = " + xP;
            lbXN.Text = "x² = " + xN;

            lbDelta.Visible = true;
            lbXP.Visible = true;
            lbXN.Visible = true;
        }

        private void lbLimpar_Click(object sender, EventArgs e)
        {
            textA.Text = "";
            textB.Text = "";
            textC.Text = "";

            lbDelta.Text = "";
            lbXP.Text = "";
            lbXN.Text = "";
            

        }

        private void Bhaskara_Load(object sender, EventArgs e)
        {

        }

        private void lbDelta_Click(object sender, EventArgs e)
        {

        }

        private void lbXP_Click(object sender, EventArgs e)
        {

        }

        private void lbXN_Click(object sender, EventArgs e)
        {

        }
    }
}
