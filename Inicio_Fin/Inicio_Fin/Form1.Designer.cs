namespace Inicio_Fin
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
            lblInico = new Label();
            txtInicio = new TextBox();
            lblFin = new Label();
            txtFin = new TextBox();
            btnGenerar = new Button();
            lstPrimos = new ListBox();
            SuspendLayout();
            // 
            // lblInico
            // 
            lblInico.AutoSize = true;
            lblInico.Location = new Point(139, 70);
            lblInico.Name = "lblInico";
            lblInico.Size = new Size(42, 15);
            lblInico.TabIndex = 0;
            lblInico.Text = " Inicio:";
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(211, 62);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(100, 23);
            txtInicio.TabIndex = 1;
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Location = new Point(139, 127);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(26, 15);
            lblFin.TabIndex = 2;
            lblFin.Text = "Fin:";
            // 
            // txtFin
            // 
            txtFin.Location = new Point(211, 124);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(100, 23);
            txtFin.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(334, 98);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(145, 23);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = " Generar Primos";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lstPrimos
            // 
            lstPrimos.FormattingEnabled = true;
            lstPrimos.Location = new Point(211, 180);
            lstPrimos.Name = "lstPrimos";
            lstPrimos.Size = new Size(120, 94);
            lstPrimos.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPrimos);
            Controls.Add(btnGenerar);
            Controls.Add(txtFin);
            Controls.Add(lblFin);
            Controls.Add(txtInicio);
            Controls.Add(lblInico);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInico;
        private TextBox txtInicio;
        private Label lblFin;
        private TextBox txtFin;
        private Button btnGenerar;
        private ListBox lstPrimos;
    }
}
