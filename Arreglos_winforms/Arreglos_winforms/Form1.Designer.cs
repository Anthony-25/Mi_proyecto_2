namespace Arreglos_winforms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            btnCrear = new Button();
            lblNumero = new Label();
            txtNumero = new TextBox();
            btnAgregar = new Button();
            lstNumeros = new ListBox();
            btnMostrar = new Button();
            lblPromedio = new Label();
            lblMayor = new Label();
            lblMenor = new Label();
            SuspendLayout();
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(130, 63);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(203, 55);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(329, 63);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(113, 23);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear Arreglo";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(134, 102);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(203, 94);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(349, 168);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar:";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(223, 129);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(120, 94);
            lstNumeros.TabIndex = 6;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(223, 229);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(120, 23);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar Datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(134, 129);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(38, 15);
            lblPromedio.TabIndex = 8;
            lblPromedio.Text = "label1";
            // 
            // lblMayor
            // 
            lblMayor.AutoSize = true;
            lblMayor.Location = new Point(134, 157);
            lblMayor.Name = "lblMayor";
            lblMayor.Size = new Size(38, 15);
            lblMayor.TabIndex = 9;
            lblMayor.Text = "label1";
            // 
            // lblMenor
            // 
            lblMenor.AutoSize = true;
            lblMenor.Location = new Point(134, 186);
            lblMenor.Name = "lblMenor";
            lblMenor.Size = new Size(38, 15);
            lblMenor.TabIndex = 10;
            lblMenor.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMenor);
            Controls.Add(lblMayor);
            Controls.Add(lblPromedio);
            Controls.Add(btnMostrar);
            Controls.Add(lstNumeros);
            Controls.Add(btnAgregar);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(btnCrear);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCantidad;
        private TextBox txtCantidad;
        private Button btnCrear;
        private Label lblNumero;
        private TextBox txtNumero;
        private Button btnAgregar;
        private ListBox lstNumeros;
        private Button btnMostrar;
        private Label lblPromedio;
        private Label lblMayor;
        private Label lblMenor;
    }
}
