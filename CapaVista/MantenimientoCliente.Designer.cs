﻿namespace CapaVista
{
    partial class MantenimientoCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoCliente));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbInactivos = new System.Windows.Forms.RadioButton();
            this.rdbActivos = new System.Windows.Forms.RadioButton();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.MantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpbxFiltro = new System.Windows.Forms.GroupBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarcas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MantenimientoBindingSource)).BeginInit();
            this.gpbxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbInactivos);
            this.groupBox2.Controls.Add(this.rdbActivos);
            this.groupBox2.Location = new System.Drawing.Point(993, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 104);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por estado";
            // 
            // rdbInactivos
            // 
            this.rdbInactivos.AutoSize = true;
            this.rdbInactivos.Location = new System.Drawing.Point(6, 65);
            this.rdbInactivos.Name = "rdbInactivos";
            this.rdbInactivos.Size = new System.Drawing.Size(81, 20);
            this.rdbInactivos.TabIndex = 1;
            this.rdbInactivos.Text = "Inactivos";
            this.rdbInactivos.UseVisualStyleBackColor = true;
            this.rdbInactivos.UseWaitCursor = true;
            // 
            // rdbActivos
            // 
            this.rdbActivos.AutoSize = true;
            this.rdbActivos.Checked = true;
            this.rdbActivos.Location = new System.Drawing.Point(6, 37);
            this.rdbActivos.Name = "rdbActivos";
            this.rdbActivos.Size = new System.Drawing.Size(72, 20);
            this.rdbActivos.TabIndex = 0;
            this.rdbActivos.TabStop = true;
            this.rdbActivos.Text = "Activos";
            this.rdbActivos.UseVisualStyleBackColor = true;
            this.rdbActivos.UseWaitCursor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1064, 620);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 37);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Atras";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 620);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 37);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteId,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.correoElectronicoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.numeroTelefonoDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.dgvClientes.DataSource = this.MantenimientoBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(12, 131);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(1127, 462);
            this.dgvClientes.TabIndex = 7;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellClick);
            // 
            // MantenimientoBindingSource
            // 
            this.MantenimientoBindingSource.DataSource = typeof(CapaEntidades.Cliente);
            // 
            // gpbxFiltro
            // 
            this.gpbxFiltro.Controls.Add(this.btnReiniciar);
            this.gpbxFiltro.Controls.Add(this.cmbCategorias);
            this.gpbxFiltro.Controls.Add(this.label7);
            this.gpbxFiltro.Controls.Add(this.txtNombre);
            this.gpbxFiltro.Controls.Add(this.label1);
            this.gpbxFiltro.Controls.Add(this.cmbMarcas);
            this.gpbxFiltro.Controls.Add(this.label6);
            this.gpbxFiltro.Location = new System.Drawing.Point(12, 10);
            this.gpbxFiltro.Name = "gpbxFiltro";
            this.gpbxFiltro.Size = new System.Drawing.Size(955, 115);
            this.gpbxFiltro.TabIndex = 6;
            this.gpbxFiltro.TabStop = false;
            this.gpbxFiltro.Text = "Filtros por Producto";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(799, 68);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(123, 28);
            this.btnReiniciar.TabIndex = 33;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DisplayMember = "Nombre";
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(233, 71);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(271, 24);
            this.cmbCategorias.TabIndex = 32;
            this.cmbCategorias.ValueMember = "idCategoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Categoria";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(233, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(271, 22);
            this.txtNombre.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre";
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMarcas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMarcas.DisplayMember = "Nombre";
            this.cmbMarcas.FormattingEnabled = true;
            this.cmbMarcas.Location = new System.Drawing.Point(681, 29);
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(241, 24);
            this.cmbMarcas.TabIndex = 28;
            this.cmbMarcas.ValueMember = "idMarca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fabricante";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CapaVista.Properties.Resources.edit_v2;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::CapaVista.Properties.Resources.delete;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // ClienteId
            // 
            this.ClienteId.DataPropertyName = "ClienteId";
            this.ClienteId.HeaderText = "Codigo";
            this.ClienteId.MinimumWidth = 6;
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            this.ClienteId.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            this.correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.HeaderText = "CorreoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            this.correoElectronicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoElectronicoDataGridViewTextBoxColumn.Width = 125;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroTelefonoDataGridViewTextBoxColumn
            // 
            this.numeroTelefonoDataGridViewTextBoxColumn.DataPropertyName = "NumeroTelefono";
            this.numeroTelefonoDataGridViewTextBoxColumn.HeaderText = "NumeroTelefono";
            this.numeroTelefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroTelefonoDataGridViewTextBoxColumn.Name = "numeroTelefonoDataGridViewTextBoxColumn";
            this.numeroTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroTelefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::CapaVista.Properties.Resources.edit_v2;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::CapaVista.Properties.Resources.delete;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 125;
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 665);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.gpbxFiltro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenimientoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | MantenimientoCliente";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MantenimientoBindingSource)).EndInit();
            this.gpbxFiltro.ResumeLayout(false);
            this.gpbxFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbInactivos;
        private System.Windows.Forms.RadioButton rdbActivos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox gpbxFiltro;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMarcas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource MantenimientoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}