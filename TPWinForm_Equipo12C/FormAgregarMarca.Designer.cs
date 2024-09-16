
namespace TPWinForm_Equipo12C
{
    partial class FormAgregarMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.buttontSalir = new System.Windows.Forms.Button();
            this.buttontAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(28, 51);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(183, 17);
            this.labelMarca.TabIndex = 1;
            this.labelMarca.Text = "Nombre de la nueva Marca:";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(217, 48);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(271, 22);
            this.textBoxMarca.TabIndex = 2;
            // 
            // buttontSalir
            // 
            this.buttontSalir.Location = new System.Drawing.Point(231, 103);
            this.buttontSalir.Name = "buttontSalir";
            this.buttontSalir.Size = new System.Drawing.Size(124, 30);
            this.buttontSalir.TabIndex = 5;
            this.buttontSalir.Text = "Salir";
            this.buttontSalir.UseVisualStyleBackColor = true;
            this.buttontSalir.Click += new System.EventHandler(this.buttontSalir_Click);
            // 
            // buttontAceptar
            // 
            this.buttontAceptar.Location = new System.Drawing.Point(87, 103);
            this.buttontAceptar.Name = "buttontAceptar";
            this.buttontAceptar.Size = new System.Drawing.Size(124, 30);
            this.buttontAceptar.TabIndex = 4;
            this.buttontAceptar.Text = "Aceptar";
            this.buttontAceptar.UseVisualStyleBackColor = true;
            this.buttontAceptar.Click += new System.EventHandler(this.buttontAceptar_Click);
            // 
            // FormAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 162);
            this.Controls.Add(this.buttontSalir);
            this.Controls.Add(this.buttontAceptar);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelMarca);
            this.Name = "FormAgregarMarca";
            this.Text = "Agregar Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Button buttontSalir;
        private System.Windows.Forms.Button buttontAceptar;
    }
}