namespace TPWinForm_Equipo12C
{
    partial class FormAgregadoImagen
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
            this.pictureBoxArticulo2 = new System.Windows.Forms.PictureBox();
            this.textBoxUrlImagen2 = new System.Windows.Forms.TextBox();
            this.labelUrlImagen = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxNombre2 = new System.Windows.Forms.TextBox();
            this.textBoxCodArticulo2 = new System.Windows.Forms.TextBox();
            this.labelNombre2 = new System.Windows.Forms.Label();
            this.labelCodArticulo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxArticulo2
            // 
            this.pictureBoxArticulo2.Location = new System.Drawing.Point(249, 11);
            this.pictureBoxArticulo2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxArticulo2.Name = "pictureBoxArticulo2";
            this.pictureBoxArticulo2.Size = new System.Drawing.Size(182, 177);
            this.pictureBoxArticulo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArticulo2.TabIndex = 49;
            this.pictureBoxArticulo2.TabStop = false;
            // 
            // textBoxUrlImagen2
            // 
            this.textBoxUrlImagen2.Location = new System.Drawing.Point(103, 120);
            this.textBoxUrlImagen2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUrlImagen2.Name = "textBoxUrlImagen2";
            this.textBoxUrlImagen2.Size = new System.Drawing.Size(129, 20);
            this.textBoxUrlImagen2.TabIndex = 50;
            this.textBoxUrlImagen2.Leave += new System.EventHandler(this.textBoxUrlImagen2_Leave);
            // 
            // labelUrlImagen
            // 
            this.labelUrlImagen.AutoSize = true;
            this.labelUrlImagen.Location = new System.Drawing.Point(38, 120);
            this.labelUrlImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUrlImagen.Name = "labelUrlImagen";
            this.labelUrlImagen.Size = new System.Drawing.Size(61, 13);
            this.labelUrlImagen.TabIndex = 51;
            this.labelUrlImagen.Text = "Url Imagen:";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAceptar.Location = new System.Drawing.Point(59, 161);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(64, 27);
            this.buttonAceptar.TabIndex = 52;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(168, 161);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(64, 27);
            this.buttonCancelar.TabIndex = 53;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxNombre2
            // 
            this.textBoxNombre2.Location = new System.Drawing.Point(103, 71);
            this.textBoxNombre2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombre2.Name = "textBoxNombre2";
            this.textBoxNombre2.ReadOnly = true;
            this.textBoxNombre2.Size = new System.Drawing.Size(129, 20);
            this.textBoxNombre2.TabIndex = 56;
            // 
            // textBoxCodArticulo2
            // 
            this.textBoxCodArticulo2.Location = new System.Drawing.Point(103, 27);
            this.textBoxCodArticulo2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCodArticulo2.Name = "textBoxCodArticulo2";
            this.textBoxCodArticulo2.ReadOnly = true;
            this.textBoxCodArticulo2.Size = new System.Drawing.Size(129, 20);
            this.textBoxCodArticulo2.TabIndex = 54;
            // 
            // labelNombre2
            // 
            this.labelNombre2.AutoSize = true;
            this.labelNombre2.Location = new System.Drawing.Point(17, 71);
            this.labelNombre2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(88, 13);
            this.labelNombre2.TabIndex = 57;
            this.labelNombre2.Text = "Nombre Articulo: ";
            // 
            // labelCodArticulo2
            // 
            this.labelCodArticulo2.AutoSize = true;
            this.labelCodArticulo2.Location = new System.Drawing.Point(18, 27);
            this.labelCodArticulo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodArticulo2.Name = "labelCodArticulo2";
            this.labelCodArticulo2.Size = new System.Drawing.Size(81, 13);
            this.labelCodArticulo2.TabIndex = 55;
            this.labelCodArticulo2.Text = "Codigo Articulo:";
            // 
            // FormAgregadoImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 224);
            this.Controls.Add(this.textBoxNombre2);
            this.Controls.Add(this.textBoxCodArticulo2);
            this.Controls.Add(this.labelNombre2);
            this.Controls.Add(this.labelCodArticulo2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelUrlImagen);
            this.Controls.Add(this.textBoxUrlImagen2);
            this.Controls.Add(this.pictureBoxArticulo2);
            this.Name = "FormAgregadoImagen";
            this.Text = "Agregado Imagen";
            this.Load += new System.EventHandler(this.FormAgregadoImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxArticulo2;
        private System.Windows.Forms.TextBox textBoxUrlImagen2;
        private System.Windows.Forms.Label labelUrlImagen;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxNombre2;
        private System.Windows.Forms.TextBox textBoxCodArticulo2;
        private System.Windows.Forms.Label labelNombre2;
        private System.Windows.Forms.Label labelCodArticulo2;
    }
}