namespace Inicio_Fin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int inicio, fin;

            if (int.TryParse(txtInicio.Text, out inicio) &&
                int.TryParse(txtFin.Text, out fin))
            {
                lstPrimos.Items.Clear();

                for (int num = inicio; num <= fin; num++)
                {
                    if (num > 1)
                    {
                        bool esPrimo = true;

                        for (int i = 2; i < num; i++)
                        {
                            if (num % i == 0)
                            {
                                esPrimo = false;
                                break;
                            }
                        }
                        if (esPrimo)
                        {
                            lstPrimos.Items.Add(num);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }
    }
}