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
    public partial class MantenimientoProductos : Form
    {
        ProductoLOG _productoLOG;
        FabricanteLOG _fabricanteLOG;
        CategoriaLOG _categoriaLOG;
        private bool _esAdmin;

        public MantenimientoProductos(bool esAdmin)
        {
            InitializeComponent();
            _esAdmin = esAdmin;


            CargarProductos();
            MostrarFabricanteYCategorias();
            AjustarVisibilidadControles();
        }

        private void AjustarVisibilidadControles()
        {
            // Ajustar la visibilidad de los botones y columnas según el origen
            if (!_esAdmin)
            {
                btnNuevo.Visible = false;
                if (dgvProductos.Columns["Editar"] != null)
                    dgvProductos.Columns["Editar"].Visible = false;
                if (dgvProductos.Columns["Eliminar"] != null)
                    dgvProductos.Columns["Eliminar"].Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RegistroProducto objRegistroProducto = new RegistroProducto();
            objRegistroProducto.ShowDialog();
            CargarProductos();
        }

        private void CargarProductos()
        {
            _productoLOG = new ProductoLOG();

            if (rdbActivos.Checked)
            {
                dgvProductos.DataSource = _productoLOG.ObtenerProductos();
            }
            else if (rdbInactivos.Checked)
            {

                dgvProductos.DataSource = _productoLOG.ObtenerProductos(true);
            }

        }

        private void MostrarFabricanteYCategorias()
        {
            _categoriaLOG = new CategoriaLOG();
            cbxCategorias.DataSource = _categoriaLOG.ObtenerTodasCategorias();
            cbxCategorias.DisplayMember = "NombreCategoria";
            cbxCategorias.ValueMember = "CategoriaId";
            cbxCategorias.SelectedIndex = -1;

            _fabricanteLOG = new FabricanteLOG();
            cbxFabricante.DataSource = _fabricanteLOG.ObtenerTodosFabricantes();
            cbxFabricante.DisplayMember = "NombreFabricante";
            cbxFabricante.ValueMember = "FabricanteId";
            cbxFabricante.SelectedIndex = -1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvProductos.Rows[e.RowIndex].Cells["ProductoId"].Value.ToString());

                    if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        RegistroProducto objRegistroProducto = new RegistroProducto(id);
                        objRegistroProducto.ShowDialog();
                        CargarProductos();
                    }

                    else if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Tienda | Edicion Producto",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _productoLOG = new ProductoLOG();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("El producto no se eliminara", "Tienda | Edicion Productos",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _productoLOG.EliminarProducto(id);
                            CargarProductos();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Producto eliminado con exito.", "Tienda | Edicion de Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se logro eliminar el producto.", "Tienda | Edicion de Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _fabricanteLOG = new FabricanteLOG();
            _categoriaLOG = new CategoriaLOG();

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProductos.Columns["FabricanteId"].Index)
            {
                int idFabricante = Convert.ToInt32(e.Value);
                string NombreFabricante = _fabricanteLOG.EstraerNombreFabricante(idFabricante);
                e.Value = NombreFabricante;

                e.FormattingApplied = true;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProductos.Columns["CategoriaId"].Index)
            {
                int idCategoria = Convert.ToInt32(e.Value);
                string NombreCategoria = _categoriaLOG.ExtraerNombreCategoria(idCategoria);
                e.Value = NombreCategoria;

                e.FormattingApplied = true;
            }

        }

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                LimpiarCamposTexto();
                CargarProductos();
            }
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                LimpiarCamposTexto();
                CargarProductos();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (como Backspace)
    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
    {
        e.Handled = true;
    }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                int codigo = int.Parse(txtCodigo.Text);
                _productoLOG = new ProductoLOG();

                var producto = _productoLOG.ObtenerProductoPorId(codigo);
                var codigoFabri = _productoLOG.ExtraerCodigoFabricante(codigo);
                var codigoCate = _productoLOG.ExtraerCodigoCategoria(codigo);

                var nombreFabri = _fabricanteLOG.EstraerNombreFabricante(codigoFabri);
                var nomcreCate = _categoriaLOG.ExtraerNombreCategoria(codigoCate);

                if (producto != null)
                {
                    // Actualizar el estado del ComboBox y del DataGridView
                    if (producto.Estado == true)
                    {
                        cbxCategorias.Text = nomcreCate;
                        cbxFabricante.Text = nombreFabri;
                        txtNombre.Text = producto.Nombre;
                        dgvProductos.DataSource = new List<Producto> { producto };
                        rdbActivos.Checked = true;
                        rdbInactivos.Checked = false;
                        
                    }
                    
                    else
                    {
                        // Si el fabricante está inactivo, seleccionar el RadioButton inactivo y deseleccionar el activo
                        cbxCategorias.Text = nomcreCate;
                        cbxFabricante.Text = nombreFabri;
                        txtNombre.Text = producto.Nombre;
                        dgvProductos.DataSource = new List<Producto> { producto };
                        rdbActivos.Checked = false;
                        rdbInactivos.Checked = true;
                        
                    }
                }
                else
                {
                    cbxCategorias.Text = "-";
                    cbxCategorias.Text = "-";
                    cbxFabricante.Text = "-";
                    cbxFabricante.Text = "-";
                    txtNombre.Text = "-";
                    dgvProductos.DataSource = new List<Producto> { producto };
                }
            }
            else
            {
                // Limpiar los controles si el TextBox está vacío
                cbxCategorias.SelectedIndex = -1;
                cbxCategorias.Text = "";
                cbxFabricante.SelectedIndex = -1;
                cbxFabricante.Text = "";
                txtNombre.Text = "";
                dgvProductos.DataSource = _productoLOG.ObtenerProductos();
                rdbActivos.Checked = true;
                rdbInactivos.Checked = false;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            LimpiarCamposTexto();
            rdbActivos.Checked = true;
            rdbInactivos.Checked = false;
        }

        private void LimpiarCamposTexto()
        {
            txtCodigo.Text = "";
            cbxCategorias.SelectedIndex = -1;
            cbxCategorias.Text = "";
            cbxFabricante.SelectedIndex = -1;
            cbxFabricante.Text = "";
            txtNombre.Text = "";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text.ToLower()))
            {
                _productoLOG = new ProductoLOG();
                var productosFiltrados = _productoLOG.ObtenertodsProductos().Where(c => c.Nombre.ToLower().Contains(txtNombre.Text.ToLower())).ToList();
                dgvProductos.DataSource = productosFiltrados;
            }
            else
            {
                CargarProductos();
            }
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategorias.SelectedIndex != -1)
            {
                string nombreCategoria = cbxCategorias.Text;
                _productoLOG = new ProductoLOG();

                var productos = _productoLOG.ObtenerProductoPorCategoria(nombreCategoria);

                if (productos != null && productos.Count > 0)
                {
                    dgvProductos.DataSource = productos;
                }
                else
                {
                    // Limpiar los controles si no se encuentran productos para la categoría seleccionada
                    dgvProductos.DataSource = productos;
                }
            }
            else
            {
                // Limpiar los controles si no hay nada seleccionado en el ComboBox
                LimpiarCamposTexto();
                dgvProductos.DataSource = _productoLOG.ObtenerProductos();
            }
        }

        private void cbxFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxFabricante.SelectedIndex != -1)
            {
                string nombreFarbicante = cbxFabricante.Text;
                _productoLOG = new ProductoLOG();

                var productos = _productoLOG.ObtenerProductoPorFabricante(nombreFarbicante);

                if (productos != null && productos.Count > 0)
                {
                    dgvProductos.DataSource = productos;
                }
                else
                {
                    // Limpiar los controles si no se encuentran productos para la categoría seleccionada
                    dgvProductos.DataSource = productos;
                }
            }
            else
            {
                // Limpiar los controles si no hay nada seleccionado en el ComboBox
                LimpiarCamposTexto();
                dgvProductos.DataSource = _productoLOG.ObtenerProductos();
            }
        }

        private void cbxCategoria_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxCategorias.Text))
            {
                // Si el texto del ComboBox está vacío, limpiar el TextBox y actualizar el DataGridView
                txtCodigo.Text = "";
                dgvProductos.DataSource = _productoLOG.ObtenerProductos();
            }
        }

        private void cbxFabricante_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxCategorias.Text))
            {
                // Si el texto del ComboBox está vacío, limpiar el TextBox y actualizar el DataGridView
                txtCodigo.Text = "";
                dgvProductos.DataSource = _productoLOG.ObtenerProductos();
            }
        }
    }
}
