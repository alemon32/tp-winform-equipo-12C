
namespace TPWinForm_Equipo12C
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.labelCampo = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificiar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            this.dataGridViewArticuloBD = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticuloBD)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.BackgroundImage")));
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscar.Location = new System.Drawing.Point(452, 2);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(28, 24);
            this.buttonBuscar.TabIndex = 21;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(216, 4);
            this.comboBoxCriterio.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(105, 21);
            this.comboBoxCriterio.TabIndex = 20;
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(60, 5);
            this.comboBoxCampo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(105, 21);
            this.comboBoxCampo.TabIndex = 19;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(344, 5);
            this.textBoxFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(95, 20);
            this.textBoxFiltro.TabIndex = 18;
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(169, 7);
            this.labelCriterio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(42, 13);
            this.labelCriterio.TabIndex = 17;
            this.labelCriterio.Text = "Criterio:";
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(14, 7);
            this.labelCampo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(43, 13);
            this.labelCampo.TabIndex = 16;
            this.labelCampo.Text = "Campo:";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(60, 362);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(194, 32);
            this.buttonEliminar.TabIndex = 15;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificiar
            // 
            this.buttonModificiar.Location = new System.Drawing.Point(60, 324);
            this.buttonModificiar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModificiar.Name = "buttonModificiar";
            this.buttonModificiar.Size = new System.Drawing.Size(194, 32);
            this.buttonModificiar.TabIndex = 14;
            this.buttonModificiar.Text = "Modificar";
            this.buttonModificiar.UseVisualStyleBackColor = true;
            this.buttonModificiar.Click += new System.EventHandler(this.buttonModificiar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(60, 287);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(194, 32);
            this.buttonAgregar.TabIndex = 13;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Location = new System.Drawing.Point(344, 247);
            this.pictureBoxArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(362, 193);
            this.pictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArticulo.TabIndex = 12;
            this.pictureBoxArticulo.TabStop = false;
            // 
            // dataGridViewArticuloBD
            // 
            this.dataGridViewArticuloBD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArticuloBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticuloBD.Location = new System.Drawing.Point(9, 44);
            this.dataGridViewArticuloBD.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewArticuloBD.Name = "dataGridViewArticuloBD";
            this.dataGridViewArticuloBD.RowHeadersWidth = 51;
            this.dataGridViewArticuloBD.RowTemplate.Height = 24;
            this.dataGridViewArticuloBD.Size = new System.Drawing.Size(721, 198);
            this.dataGridViewArticuloBD.TabIndex = 11;
            this.dataGridViewArticuloBD.SelectionChanged += new System.EventHandler(this.dataGridViewArticuloBD_SelectionChanged);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(496, 2);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(33, 23);
            this.buttonLimpiar.TabIndex = 22;
            this.buttonLimpiar.Text = "\r\n";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 456);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificiar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.pictureBoxArticulo);
            this.Controls.Add(this.dataGridViewArticuloBD);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInicio";
            this.Text = "Administracion de Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticuloBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificiar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
        private System.Windows.Forms.DataGridView dataGridViewArticuloBD;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

