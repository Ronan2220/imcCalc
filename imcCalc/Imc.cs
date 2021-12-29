using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imcCalc
{
    class Imc
    {

        private float _altura;
        private float _peso;
        private String _classificacao;
        private Color _corClassificacao;
        private float _resul;



        public float altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public float peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public String classificacao
        {
            get { return _classificacao; }
            set { _classificacao = value; }
        }

        public Color corClassificacao
        {
            get
            {
                return _corClassificacao;
            }
        }
        public float resul
        {
            set { _resul = value; }
            get { return _resul; }
        }






        //Método

        public float calcularIMC()
        {
            float imc = (altura*altura)/peso;

           
            geraClassificacao(imc);
            return imc;
            
        }





        private void geraClassificacao(float imc)

        {

            if (imc == null)
            {
                MessageBox.Show("Não é possivel iniciar sem os valores");

            }
            else if (imc <= 16.0)
            {
                classificacao = "Magreza grau III";
                _corClassificacao = Color.Red;
            }
            else if (imc > 16.0 && imc <= 16.9)

            {

                classificacao = "Magreza grau II";
                _corClassificacao = Color.Red;

            }
            else if (imc > 17.0 && imc <= 18.4)
            {
                classificacao = "magreza grau I";
                _corClassificacao = Color.Red;
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                classificacao = "Adequado";
                _corClassificacao = Color.Blue;
            }
            else if (imc > 25.0 && imc <= 29.9)
            {
                classificacao = "pré-obeso";
                _corClassificacao = Color.Red;
            }
            else if (imc > 30.0 && imc <= 34.9)
            {
                classificacao = "obesidade grau I";
                _corClassificacao = Color.Red;
            }
            else if (imc > 35.0 && imc <= 39.9)
            {
                classificacao = "Obesidade grau II";
                _corClassificacao = Color.Red;
            }
            else if(imc > 40.0)
            {
                classificacao = "Obesidade grau III";
                _corClassificacao = Color.Red;
            }

              

            }
             
        
        }
    }


    
       


        

    
    

