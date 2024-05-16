﻿namespace CapaVista
{
    partial class RegistroVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroVenta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxNombreProd = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxNombreEmple = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencias:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "ProductoId", true));
            this.txtCodigo.Location = new System.Drawing.Point(176, 81);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 30);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CapaEntidades.Producto);
            // 
            // cbxNombreProd
            // 
            this.cbxNombreProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxNombreProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNombreProd.DataSource = this.productoBindingSource;
            this.cbxNombreProd.DisplayMember = "Nombre";
            this.cbxNombreProd.FormattingEnabled = true;
            this.cbxNombreProd.Location = new System.Drawing.Point(467, 79);
            this.cbxNombreProd.Name = "cbxNombreProd";
            this.cbxNombreProd.Size = new System.Drawing.Size(312, 32);
            this.cbxNombreProd.TabIndex = 5;
            this.cbxNombreProd.ValueMember = "ProductoId";
            this.cbxNombreProd.SelectedIndexChanged += new System.EventHandler(this.cbxNombreProd_SelectedIndexChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(176, 142);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 30);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtExistencias
            // 
            this.txtExistencias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Existencias", true));
            this.txtExistencias.Location = new System.Drawing.Point(467, 142);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.ReadOnly = true;
            this.txtExistencias.Size = new System.Drawing.Size(124, 30);
            this.txtExistencias.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(704, 145);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 34);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(36, 200);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.RowHeadersWidth = 51;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(743, 193);
            this.dgvDetalleVenta.TabIndex = 9;
            this.dgvDetalleVenta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVenta_CellValueChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 275;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto Total:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(679, 430);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(100, 30);
            this.txtMonto.TabIndex = 11;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(17, 486);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 31);
            this.btnProcesar.TabIndex = 12;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(704, 486);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 31);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "EmpleadoId", true));
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(176, 24);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(100, 30);
            this.txtCodigoEmpleado.TabIndex = 14;
            this.txtCodigoEmpleado.TextChanged += new System.EventHandler(this.txtCodigoEmple_TextChanged);
            this.txtCodigoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoEmpre_KeyPress);
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(CapaEntidades.Empleado);
            // 
            // cbxNombreEmple
            // 
            this.cbxNombreEmple.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxNombreEmple.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNombreEmple.DataSource = this.empleadoBindingSource;
            this.cbxNombreEmple.DisplayMember = "Nombre";
            this.cbxNombreEmple.FormattingEnabled = true;
            this.cbxNombreEmple.Location = new System.Drawing.Point(467, 24);
            this.cbxNombreEmple.Name = "cbxNombreEmple";
            this.cbxNombreEmple.Size = new System.Drawing.Size(312, 32);
            this.cbxNombreEmple.TabIndex = 15;
            this.cbxNombreEmple.ValueMember = "ProductoId";
            // 
            // RegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.cbxNombreEmple);
            this.Controls.Add(this.txtCodigoEmpleado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbxNombreProd);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistroVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | Registro Venta";
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbxNombreProd;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.ComboBox cbxNombreEmple;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
    }
}