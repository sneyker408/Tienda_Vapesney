﻿using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class RegistroVenta : Form
    {
        VentaLOG _ventaLOG;
        ProductoLOG _productoLOG;
        DataTable detalleVenta;
        EmpleadoLOG _empleadoLOG;

        public RegistroVenta()
        {
            InitializeComponent();

            CargarProductos();

            detalleVenta = new DataTable();
            detalleVenta.Columns.Add("Codigo", typeof(int));
            detalleVenta.Columns.Add("Nombre", typeof(string));
            detalleVenta.Columns.Add("Precio", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));
        }

        private void CargarProductos()
        {
            _productoLOG = new ProductoLOG();
            productoBindingSource.DataSource = _productoLOG.ObtenerProductos();
        }

        private void LimpiarCampos()
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                _productoLOG = new ProductoLOG();

                int codigo = int.Parse(txtCodigo.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                int exitencia = int.Parse(txtExistencias.Text);

                var producto = (Producto)productoBindingSource.Current;

                if (cantidad < exitencia)
                {
                    if (producto != null)
                    {
                        detalleVenta.Rows.Add(codigo, producto.Nombre, producto.PrecioUnitario,
                            cantidad, (cantidad * producto.PrecioUnitario));

                        dgvDetalleVenta.DataSource = detalleVenta;

                        CalcularMontoTotal();
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad es mayor a las existencias, seleccione una cantidad menor", "Vapeney | Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    txtCantidad.BackColor = Color.LightYellow;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un Error", "Vapeney | Venta", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                _ventaLOG = new VentaLOG();

                Venta venta = new Venta();
                 
                venta.Fecha = DateTime.Now;
                venta.Total = decimal.Parse(txtMonto.Text);
                venta.EmpleadoId = int.Parse(txtCodigoEmpleado.Text);

                foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                {
                    var detalle = new DetalleVenta()
                    {
                        ProductoId = int.Parse(row.Cells["Codigo"].Value.ToString()),
                        Precio = decimal.Parse(row.Cells["Precio"].Value.ToString()),
                        Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString())
                    };

                    venta.Detalles.Add(detalle);
                }

                int resultado = _ventaLOG.GuardarVenta(venta);

                if(resultado > 0)
                {
                    MessageBox.Show("Venta Guardada con Exito");
                }
                else
                {
                    MessageBox.Show("No se logro guardar la venta");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un Error", "Vapesney | Venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
{
    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
    {
        e.Handled = true;
    }
}

        private void txtCodigoEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool isUpdating = false;

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                _productoLOG = new ProductoLOG();

                if (int.TryParse(txtCodigo.Text, out int codigo))
                {
                    var producto = _productoLOG.ObtenerProductoPorId(codigo);

                    if (producto != null && producto.Estado == true)
                    {
                        cbxNombreProd.Text = producto.Nombre;
                        txtExistencias.Text = producto.Existencias.ToString();
                    }
                    else
                    {
                        cbxNombreProd.Text = "";
                    }
                }
                else
                {
                    cbxNombreProd.Text = "";
                }
            }
            else
            {
                cbxNombreProd.Text = "";
                txtExistencias.Text = "";
            }
        }

        private void cbxNombreProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNombreProd.SelectedIndex != -1)
            {
                isUpdating = true;

                var producto = (Producto)cbxNombreProd.SelectedItem;
                if (producto != null)
                {
                    txtCodigo.Text = producto.ProductoId.ToString();
                }

                isUpdating = false;
            }
        }

        private void txtCodigoEmple_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoEmpleado.Text))
            {
                _empleadoLOG = new EmpleadoLOG();

                int codigo = int.Parse(txtCodigoEmpleado.Text);

                var producto = _empleadoLOG.ObtenerEmpleadoPorId(codigo);

                if (producto != null)
                {
                    cbxNombreEmple.Text = producto.Nombre;
                }
                else
                {
                    cbxNombreEmple.Text = "";
                }
            }
            else
            {
                cbxNombreEmple.Text = "";
            }
        }

        private void dgvDetalleVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    bool precioValido = decimal.TryParse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Precio"].Value.ToString(), out decimal precio);
                    int cantidad = int.Parse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());

                    if (precioValido && cantidad > 0)
                    {
                        decimal SubTotal = precio * cantidad;
                        dgvDetalleVenta.Rows[e.RowIndex].Cells["SubTotal"].Value = SubTotal;

                        CalcularMontoTotal();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un precio valido");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void CalcularMontoTotal()
        {
            decimal montoTotal = 0;

            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
            }


            txtMonto.Text = montoTotal.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
