using System;
using System.Windows.Forms;

namespace Arreglos_winforms
{
    public partial class Form1 : Form
    {
        int[]? numeros;
        int indice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
            {
                numeros = new int[cantidad];
                indice = 0;
                lstNumeros.Items.Clear();

                lblPromedio.Text = "";
                lblMayor.Text = "";
                lblMenor.Text = "";

                MessageBox.Show($"Arreglo de {cantidad} creado. Ahora puedes agregar números.");
            }
            else
            {
                MessageBox.Show("Ingresa un número entero positivo válido.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (numeros == null)
            {
                MessageBox.Show("Primero debes crear el arreglo.");
                return;
            }

            if (indice >= numeros.Length)
            {
                MessageBox.Show("El arreglo está lleno.");
                return;
            }

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                numeros[indice] = numero;
                indice++;

                txtNumero.Clear();
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (numeros == null || indice == 0)
            {
                MessageBox.Show("No hay números para mostrar.");
                return;
            }

            lstNumeros.Items.Clear();

            int suma = 0;
            int mayor = numeros[0];
            int menor = numeros[0];

            for (int i = 0; i < indice; i++)
            {
                lstNumeros.Items.Add($"Posición {i}: {numeros[i]}");

                suma += numeros[i];

                if (numeros[i] > mayor)
                    mayor = numeros[i];

                if (numeros[i] < menor)
                    menor = numeros[i];
            }

            double promedio = (double)suma / indice;

            lblPromedio.Text = $"Promedio: {promedio:0.00}";
            lblMayor.Text = $"Mayor: {mayor}";
            lblMenor.Text = $"Menor: {menor}";
        }
    }
}
