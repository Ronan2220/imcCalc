using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imcCalc
{

    
    public partial class frmImc : Form
    {
        private Imc imc;

        public frmImc()
        {
            
            
            InitializeComponent();
            imc = new Imc();
        
        }

        private void frmImc_Load(object sender, EventArgs e)
        {

        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void lblResul_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            


            float peso, altura;


            float.TryParse(txtPeso.Text, out peso);
            float.TryParse(txtAltura.Text,out altura);
            

            imc.altura = altura;
            imc.peso = peso;
            
           
            lbResultado.Text = "Imc: " + imc.calcularIMC().ToString();
            lbClassificacaoIMC.Text = "Classificação: " + imc.classificacao;
            lbClassificacaoIMC.ForeColor = imc.corClassificacao;
            lbResultado.Visible = true;
            lblClassificacaoImc.Visible = true;

            
             


        }

        private void lblClassificacaoImc_Click(object sender, EventArgs e)
        {

        }

        private void lbClassificacaoIMC_Click(object sender, EventArgs e)
        {

        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
