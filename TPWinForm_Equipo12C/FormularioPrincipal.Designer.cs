﻿
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
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrevious = new System.Windows.Forms.Button();
            this.buttonAgregarCategoria = new System.Windows.Forms.Button();
            this.buttonAgregarMarcar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticuloBD)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.BackgroundImage")));
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuscar.Location = new System.Drawing.Point(603, 2);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(37, 30);
            this.buttonBuscar.TabIndex = 21;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(288, 5);
            this.comboBoxCriterio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(139, 24);
            this.comboBoxCriterio.TabIndex = 20;
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(80, 6);
            this.comboBoxCampo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(139, 24);
            this.comboBoxCampo.TabIndex = 19;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(459, 6);
            this.textBoxFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(125, 22);
            this.textBoxFiltro.TabIndex = 18;
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(225, 9);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(57, 17);
            this.labelCriterio.TabIndex = 17;
            this.labelCriterio.Text = "Criterio:";
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(19, 9);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(56, 17);
            this.labelCampo.TabIndex = 16;
            this.labelCampo.Text = "Campo:";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(80, 446);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(259, 39);
            this.buttonEliminar.TabIndex = 15;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificiar
            // 
            this.buttonModificiar.Location = new System.Drawing.Point(80, 399);
            this.buttonModificiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModificiar.Name = "buttonModificiar";
            this.buttonModificiar.Size = new System.Drawing.Size(259, 39);
            this.buttonModificiar.TabIndex = 14;
            this.buttonModificiar.Text = "Modificar";
            this.buttonModificiar.UseVisualStyleBackColor = true;
            this.buttonModificiar.Click += new System.EventHandler(this.buttonModificiar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(80, 353);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(259, 39);
            this.buttonAgregar.TabIndex = 13;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Location = new System.Drawing.Point(459, 304);
            this.pictureBoxArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(483, 238);
            this.pictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArticulo.TabIndex = 12;
            this.pictureBoxArticulo.TabStop = false;
            // 
            // dataGridViewArticuloBD
            // 
            this.dataGridViewArticuloBD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArticuloBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticuloBD.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewArticuloBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewArticuloBD.Name = "dataGridViewArticuloBD";
            this.dataGridViewArticuloBD.RowHeadersWidth = 51;
            this.dataGridViewArticuloBD.RowTemplate.Height = 24;
            this.dataGridViewArticuloBD.Size = new System.Drawing.Size(1262, 244);
            this.dataGridViewArticuloBD.TabIndex = 11;
            this.dataGridViewArticuloBD.SelectionChanged += new System.EventHandler(this.dataGridViewArticuloBD_SelectionChanged);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.BackgroundImage")));
            this.buttonLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLimpiar.Location = new System.Drawing.Point(647, 2);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(44, 28);
            this.buttonLimpiar.TabIndex = 22;
            this.buttonLimpiar.Text = "\r\n";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(1015, 351);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(259, 41);
            this.btnAgregarImagen.TabIndex = 23;
            this.btnAgregarImagen.Text = "Agregar imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(711, 547);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 24;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrevious
            // 
            this.btPrevious.Location = new System.Drawing.Point(603, 547);
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(75, 23);
            this.btPrevious.TabIndex = 25;
            this.btPrevious.Text = "<";
            this.btPrevious.UseVisualStyleBackColor = true;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // buttonAgregarCategoria
            // 
            this.buttonAgregarCategoria.Location = new System.Drawing.Point(1015, 399);
            this.buttonAgregarCategoria.Name = "buttonAgregarCategoria";
            this.buttonAgregarCategoria.Size = new System.Drawing.Size(259, 40);
            this.buttonAgregarCategoria.TabIndex = 27;
            this.buttonAgregarCategoria.Text = "Agregar Categoria";
            this.buttonAgregarCategoria.UseVisualStyleBackColor = true;
            this.buttonAgregarCategoria.Click += new System.EventHandler(this.buttonAgregarCategoria_Click);
            // 
            // buttonAgregarMarcar
            // 
            this.buttonAgregarMarcar.Location = new System.Drawing.Point(1015, 445);
            this.buttonAgregarMarcar.Name = "buttonAgregarMarcar";
            this.buttonAgregarMarcar.Size = new System.Drawing.Size(259, 40);
            this.buttonAgregarMarcar.TabIndex = 28;
            this.buttonAgregarMarcar.Text = "Agregar Marca";
            this.buttonAgregarMarcar.UseVisualStyleBackColor = true;
            this.buttonAgregarMarcar.Click += new System.EventHandler(this.buttonAgregarMarcar_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 631);
            this.Controls.Add(this.buttonAgregarMarcar);
            this.Controls.Add(this.buttonAgregarCategoria);
            this.Controls.Add(this.btPrevious);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btnAgregarImagen);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrevious;
        private System.Windows.Forms.Button buttonAgregarCategoria;
        private System.Windows.Forms.Button buttonAgregarMarcar;
    }
}

