using System;
using System.Windows.Forms;
using System.Drawing;

using System;
using System.Windows.Forms;
using System.Drawing;

using System;
using System.Windows.Forms;
using System.Drawing;

namespace convertir_unidades
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
            Valor = new Label();
            txtValor = new TextBox();
            label2 = new Label();
            this.comboBox1 = new ComboBox();
            label3 = new Label();
            this.comboBox2 = new ComboBox();
            this.button1 = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // Valor
            // 
            Valor.AutoSize = true;
            Valor.Location = new Point(124, 53);
            Valor.Name = "Valor";
            Valor.Size = new Size(36, 15);
            Valor.TabIndex = 0;
            Valor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(319, 45);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 106);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 2;
            label2.Text = "De:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new Point(319, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(121, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 156);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 4;
            label3.Text = "A:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new Point(319, 153);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new Size(121, 23);
            this.comboBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new Point(344, 210);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(124, 218);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(this.button1);
            Controls.Add(this.comboBox2);
            Controls.Add(label3);
            Controls.Add(this.comboBox1);
            Controls.Add(label2);
            Controls.Add(txtValor);
            Controls.Add(Valor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Valor;
        private TextBox txtValor;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Button button1;
        private Label lblResultado;
    }
}
