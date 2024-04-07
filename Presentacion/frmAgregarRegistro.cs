using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using System.Globalization;
using System.Windows.Media;
using Helpers;
using Guna.UI2.WinForms;
using FontAwesome.Sharp;

namespace Presentacion
{
    public partial class frmAgregarRegistro : Form
    {
        Articulo nuevo = null;
        BotonArticulo boton = null;
        public frmAgregarRegistro()
        {
            InitializeComponent();
            CargarDatosComboBox();
            Helper.CargarImagen(imgProducto, "");
        }
        private void CargarDatosComboBox()
        {
            cboAddCategoria.DataSource = Helper.CargarDatosCategoria();
            cboAddCategoria.ValueMember = "IdCategoria";
            cboAddCategoria.DisplayMember = "DescripcionCategoria";
            cboAddCategoria.SelectedIndex = -1;

            cboAddMarca.DataSource = Helper.CargarDatosMarca();
            cboAddMarca.ValueMember = "IdMarca";
            cboAddMarca.DisplayMember = "DescripcionMarca";
            cboAddMarca.SelectedIndex = -1;
        }
        private void AgregarNuevoArticulo()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                nuevo = new Articulo()
                {
                    Codigo = txtAddCodigo.Text,
                    Nombre = txtAddNombre.Text,
                    Descripcion = txtAddDescripcion.Text,
                    UrlImagen = txtAddUrlImagen.Text,
                    Marca = new Marca()
                    {
                        IdMarca = cboAddMarca.SelectedIndex + 1,
                        DescripcionMarca = cboAddMarca.SelectedItem.ToString()
                    },
                    Categoria = new Categoria()
                    {
                        IdCategoria = cboAddCategoria.SelectedIndex + 1,
                        DescripcionCategoria = cboAddCategoria.SelectedItem.ToString()
                    },
                    Precio = Helper.StringToDecimal(txtAddPrecio.Text)
                };

                negocio.AgregarNuevoRegistro(nuevo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public BotonArticulo CrearBoton()
        {
            if (nuevo != null)
            {
                boton = new BotonArticulo()
                {
                    Name = nuevo.Nombre,
                    NombreBoton = nuevo.Nombre,
                    CodigoBoton = nuevo.Codigo,
                    DescripcionBoton = nuevo.Descripcion,
                    PrecioBoton = nuevo.Precio,
                    UrlImagenBoton = nuevo.UrlImagen,
                    MarcaBoton = new Marca()
                    {
                        IdMarca = nuevo.Marca.IdMarca,
                        DescripcionMarca = nuevo.Marca.DescripcionMarca
                    },
                    CategoriaBoton = new Categoria()
                    {
                        IdCategoria = nuevo.Categoria.IdCategoria,
                        DescripcionCategoria = nuevo.Categoria.DescripcionCategoria
                    }
                };
            }
            return boton;
        }
        private void ModificarLabels(Label etiqueta, string texto)
        {
            if (texto != "")
            {
                if (etiqueta == lblPrecio)
                {
                    texto = $"$ {txtAddPrecio.Text}";
                }
                etiqueta.Text = texto;
            }
            else if (string.IsNullOrEmpty(texto))
            {
                ResetearLabel(etiqueta);
            }
        }
        private void ResetearLabel(Label etiqueta)
        {
            if (etiqueta == lblNombreArticulo)
            {
                lblNombreArticulo.Text = "Nombre Artículo";
            }
            else if (etiqueta == lblCategoria)
            {
                lblCategoria.Text = "Categoría";
            }
            else if (etiqueta == lblMarca)
            {
                lblMarca.Text = "Marca";
            }
            else if (etiqueta == lblCodigo)
            {
                lblCodigo.Text = "Código";
            }
            else if (etiqueta == lblPrecio)
            {
                lblPrecio.Text = "$ 1234,56";
            }
            else
            {
                lblDescripcion.Text = "Aqui va la descripcion del artículo, detallando algundas de sus características, como color, material, marca, modelo, año de fabricacion, etc.";
            }
        }
        private void BorrarTexto(Label etiqueta)
        {
            etiqueta.Text = string.Empty;
        }
        private void ValidarEntradasDatos()
        {
            string mensaje = "Hay campos vacíos:\n\n";
            bool bError = false;

            if (string.IsNullOrWhiteSpace(txtAddNombre.Text))
            {
                mensaje += "    - No se ingresó ningún nombre\n";
                lbl.Visible = true;
                bError = true;
            }
            if (cboAddCategoria.SelectedItem == null)
            {
                mensaje += "    - Ninguna de las categorías fue seleccionada\n";
                label1.Visible = true;
                bError = true;
            }
            if (cboAddMarca.SelectedItem == null)
            {
                mensaje += "    - Ninguna de las marcas fue seleccionada\n";
                label2.Visible = true;
                bError = true;
            }
            if (string.IsNullOrWhiteSpace(txtAddCodigo.Text))
            {
                mensaje += "    - El producto no tiene código\n";
                label3.Visible = true;
                bError = true;
            }
            if (string.IsNullOrWhiteSpace(txtAddPrecio.Text))
            {
                mensaje += "    - Falta el precio del producto\n";
                label4.Visible = true;
                bError = true;
            }
            if (string.IsNullOrWhiteSpace(txtAddDescripcion.Text))
            {
                mensaje += "    - El producto no tiene descripción\n";
                label5.Visible = true;
                bError = true;
            }

            if (bError)
            {
                MessageBox.Show(mensaje, "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El artículo fue agregado de forma exitosa.", "Nuevo Artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AgregarNuevoArticulo();
                Close();
            }
        }

        
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            ValidarEntradasDatos();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void txtBox_TexChanged(object sender, EventArgs e)
        {
            if (sender == txtAddNombre)
            {
                ModificarLabels(lblNombreArticulo, txtAddNombre.Text);
            }
            if (sender == txtAddCodigo)
            {
                ModificarLabels(lblCodigo, txtAddCodigo.Text);
            }
            if (sender == txtAddPrecio)
            {
                ModificarLabels(lblPrecio, txtAddPrecio.Text);
            }
            if (sender == txtAddUrlImagen)
            {
                Helper.CargarImagen(imgProducto, txtAddUrlImagen.Text);
            }
            if (sender == txtAddDescripcion)
            {
                ModificarLabels(lblDescripcion, txtAddDescripcion.Text);
            }
        }
        private void ControlAddRegistro_Click(object sender, EventArgs e)
        {
            if (sender == txtAddNombre)
            {
                if (txtAddNombre.Text != "")
                {
                    BorrarTexto(lblNombreArticulo);
                }
            }
            else if (sender == txtAddCodigo)
            {
                if (txtAddCodigo.Text != "")
                {
                    BorrarTexto(lblCodigo);
                }
            }
            else if (sender == txtAddPrecio)
            {
                label6.Visible = true;
                label6.Text = "Utilice la coma ',' solo para separar decimales.";

                if (txtAddPrecio.Text != "")
                {
                    BorrarTexto(lblPrecio);
                }
            }
            else if (sender == txtAddDescripcion)
            {
                if (txtAddDescripcion.Text != "")
                {
                    BorrarTexto(lblDescripcion);
                }
            }
            else if (sender == cboAddCategoria)
            {
                if (cboAddCategoria.SelectedItem != null)
                {
                    BorrarTexto(lblCategoria);
                }
            }
            else if (sender == cboAddMarca)
            {
                if (cboAddMarca.SelectedItem != null)
                {
                    BorrarTexto(lblMarca);
                }
            }
        }
        private void SelectedItemChangedCbo(object sender, EventArgs e)
        {
            if (cboAddCategoria.SelectedItem != null)
            {
                lblCategoria.Text = cboAddCategoria.SelectedItem.ToString();
            }
            if (cboAddMarca.SelectedItem != null)
            {
                lblMarca.Text = cboAddMarca.SelectedItem.ToString();
            }
        }
        private void BtnAcceptCancel_MouseEnter(object sender, EventArgs e)
        {
            if (sender == btnAccept)
            {
                btnAccept.ForeColor = System.Drawing.Color.White;
                btnAccept.IconColor = System.Drawing.Color.White;
            }
            else
            {
                btnCancel.ForeColor = System.Drawing.Color.White;
                btnCancel.IconColor = System.Drawing.Color.White;
            }
        }
        private void BtnAcceptCancel_MouseLeave (object sender, EventArgs e)
        {
            if (sender == btnAccept)
            {
                btnAccept.ForeColor = System.Drawing.Color.YellowGreen;
                btnAccept.IconColor = System.Drawing.Color.YellowGreen;
            }
            else
            {
                btnCancel.ForeColor = System.Drawing.Color.FromArgb(175, 0, 0);
                btnCancel.IconColor = System.Drawing.Color.FromArgb(175, 0, 0);
            }
        }
        private void TxtPrecio_KeyPress (object sender, KeyPressEventArgs e)
        {
            label6.Visible = true;

            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 44 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && txtAddPrecio.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

    }
}
