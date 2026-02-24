namespace palabras_contienes_oracion
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
            lblOracion = new Label();
            txtOracion = new TextBox();
            btnContar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblOracion
            // 
            lblOracion.AutoSize = true;
            lblOracion.Location = new Point(211, 147);
            lblOracion.Name = "lblOracion";
            lblOracion.Size = new Size(113, 15);
            lblOracion.TabIndex = 0;
            lblOracion.Text = "Escriba una oración:";
            // 
            // txtOracion
            // 
            txtOracion.Location = new Point(347, 144);
            txtOracion.Multiline = true;
            txtOracion.Name = "txtOracion";
            txtOracion.Size = new Size(141, 23);
            txtOracion.TabIndex = 1;
            // 
            // btnContar
            // 
            btnContar.Location = new Point(519, 143);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(75, 23);
            btnContar.TabIndex = 2;
            btnContar.Text = "Contar Palabras";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(203, 188);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(121, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Cantidad de palabras:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnContar);
            Controls.Add(txtOracion);
            Controls.Add(lblOracion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOracion;
        private TextBox txtOracion;
        private Button btnContar;
        private Label lblResultado;
    }
}
