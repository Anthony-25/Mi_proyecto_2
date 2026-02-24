namespace palabras_contienes_oracion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string texto = txtOracion.Text.Trim();

            if (texto == "")
            {
                lblResultado.Text = "Cantidad de palabras: 0 ";
                return;
            }

            string[] palabras = texto.Split(' ');
            int contador = 0; 

            foreach (string palabra in palabras)
            {
                if (palabra != "")
                {
                    contador++;
                }
            }

            lblResultado.Text = "Cantidad de palabras; " + contador; 


        }

    }
}
