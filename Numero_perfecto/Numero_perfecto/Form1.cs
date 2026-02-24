namespace Numero_perfecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(maskedTextBox1.Text, out numero))
            {
                int sumaDivisores = 0;
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        sumaDivisores += i;
                    }
                }
                if (sumaDivisores == numero)
                {
                    MessageBox.Show($"{numero} es un número perfecto.");
                }
                else
                {
                    MessageBox.Show($"{numero} no es un número perfecto.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }   


        }
    }
}
