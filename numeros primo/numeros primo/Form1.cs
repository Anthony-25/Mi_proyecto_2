using System;
using System.Windows.Forms;

namespace numeros_primo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(mskNumero.Text, out int numero))
            {
                if (numero <= 1)
                {
                    MessageBox.Show("No es un número primo ?");
                    return;
                }

                bool esPrimo = true;
                int limite = (int)Math.Sqrt(numero);

                for (int i = 2; i <= limite; i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    MessageBox.Show("Es un número primo ?");
                }
                else
                {
                    MessageBox.Show("No es un número primo ?");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }
    }
}