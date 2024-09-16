
namespace TPWinForm_Equipo12C
{
    partial class FormAgregarCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttontAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la nueva Categoria:";
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(242, 38);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(268, 22);
            this.textBoxCategoria.TabIndex = 2;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(244, 90);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(105, 28);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttontAgregar
            // 
            this.buttontAgregar.Location = new System.Drawing.Point(131, 90);
            this.buttontAgregar.Name = "buttontAgregar";
            this.buttontAgregar.Size = new System.Drawing.Size(105, 28);
            this.buttontAgregar.TabIndex = 4;
            this.buttontAgregar.Text = "Agregar";
            this.buttontAgregar.UseVisualStyleBackColor = true;
            this.buttontAgregar.Click += new System.EventHandler(this.buttontAgregar_Click);
            // 
            // FormAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 176);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttontAgregar);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarCategoria";
            this.Text = "Agregar Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttontAgregar;
    }
}