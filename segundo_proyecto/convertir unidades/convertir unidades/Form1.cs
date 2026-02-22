using System;
using System.Windows.Forms;

namespace convertir_unidades
{
    public partial class Form1 : Form
    {
        
        private ComboBox? cmbA;
        private ComboBox? cmbDe;

        public Form1()
        {
            InitializeComponent();
            CargarUnidades();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CargarUnidades()
        {
            if (cmbDe != null)
            {
                cmbDe.Items.Clear();
                cmbDe.Items.Add("Metros");
                cmbDe.Items.Add("Centímetros");
                cmbDe.Items.Add("Pulgadas");
                cmbDe.SelectedIndex = 0;
            }

            if (cmbA != null)
            {
                cmbA.Items.Clear();
                cmbA.Items.Add("Metros");
                cmbA.Items.Add("Centímetros");
                cmbA.Items.Add("Pulgadas");
                cmbA.SelectedIndex = 1;
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (cmbDe == null || cmbA == null)
            {
                MessageBox.Show("Los combos de unidades no están inicializados.");
                return;
            }

            if (double.TryParse(txtValor.Text, out double valor))
            {
                double valorEnMetros = ConvertirAMetros(valor, cmbDe.Text);
                double resultado = ConvertirDesdeMetros(valorEnMetros, cmbA.Text);

                lblResultado.Text = $"Resultado: {resultado:0.####}";
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        private double ConvertirAMetros(double valor, string unidad)
        {
            switch (unidad)
            {
                case "Metros":
                    return valor;
                case "Centímetros":
                    return valor / 100;
                case "Pulgadas":
                    return valor * 0.0254;
                default:
                    return valor;
            }
        }

        private double ConvertirDesdeMetros(double valor, string unidad)
        {
            switch (unidad)
            {
                case "Metros":
                    return valor;
                case "Centímetros":
                    return valor * 100;
                case "Pulgadas":
                    return valor / 0.0254;
                default:
                    return valor;
            }
        }
    }
}