using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;
using System.Globalization;

namespace Presentacion
{
    public partial class frmDetalles : Form
    {
        private bool edit = false;
        private BotonArticulo boton;

        public BotonArticulo Boton { get { return boton; } set { boton = value; } }

        public string Nombre { get { return lblNombreArticulo.Text; } set { lblNombreArticulo.Text = value; } }
        public string Descripcion { get { return lblDescripcion.Text; } set { lblDescripcion.Text = value; } }
        public string Codigo { get { return lblCodigo.Text; } set { lblCodigo.Text = value; } }
        public string UrlImagen { get { return imgProducto.ImageLocation; } set { Helper.CargarImagen(imgProducto, value); } }
        public int IdCategoria { get; set; }
        public string Categoria { get { return lblCategoria.Text; } set { lblCategoria.Text = value; } }
        public int IdMarca { get; set; }
        public string Marca { get { return lblMarca.Text; } set { lblMarca.Text = value; } }
        public decimal Precio { get { return Helper.StringToDecimal(lblPrecio.Text); } set { lblPrecio.Text = value.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")); } }

        public frmDetalles(BotonArticulo boton)
        {
            InitializeComponent();
            this.Boton = boton;

            Nombre = boton.NombreBoton;
            Descripcion = boton.DescripcionBoton;
            Codigo = boton.CodigoBoton;
            UrlImagen = boton.UrlImagenBoton;
            IdCategoria = boton.CategoriaBoton.IdCategoria;
            Categoria = boton.CategoriaBoton.DescripcionCategoria;
            IdMarca = boton.MarcaBoton.IdMarca;
            Marca = boton.MarcaBoton.DescripcionMarca;
            Precio = boton.PrecioBoton;
        }

        private void MostarControlesEdit(bool ver, bool ocultar)
        {
            btnModificar.Visible = ocultar;
            btnClose.Visible = ocultar;

            txtEditUrlImagen.Visible = ver;
            btnImagen.Visible = ver;

            btnAccept.Visible = ver;
            btnCancel.Visible = ver;

            txtEditNombre.Visible = ver;
            lblNombreArticulo.Visible = ocultar;

            cboEditCategoria.Visible = ver;
            lblCategoria.Visible = ocultar;

            cboEditMarca.Visible = ver;
            lblMarca.Visible = ocultar;

            txtEditCodigo.Visible = ver;
            lblCodigo.Visible = ocultar;

            txtEditPrecio.Visible = ver;
            lblPrecio.Visible = ocultar;

            txtEditDescripcion.Visible = ver;
            lblDescripcion.Visible = ocultar;

            MostarDatosControlesEdit();
            CargarDatosComboBox();
        }
        private void CargarDatosComboBox()
        {
            cboEditCategoria.DataSource = Helper.CargarDatosCategoria();
            cboEditCategoria.ValueMember = "IdCategoria";
            cboEditCategoria.DisplayMember = "DescripcionCategoria";
            cboEditCategoria.SelectedIndex = IdCategoria - 1;

            cboEditMarca.DataSource = Helper.CargarDatosMarca();
            cboEditMarca.ValueMember = "IdMarca";
            cboEditMarca.DisplayMember = "DescripcionMarca";
            cboEditMarca.SelectedIndex = IdMarca - 1;
        }
        private void MostarDatosControlesEdit()
        {
            txtEditNombre.PlaceholderText = boton.NombreBoton;
            txtEditCodigo.PlaceholderText = boton.CodigoBoton;
            txtEditPrecio.PlaceholderText = boton.PrecioBoton.ToString("C");
            txtEditDescripcion.PlaceholderText = boton.DescripcionBoton;
            txtEditUrlImagen.PlaceholderText = boton.UrlImagenBoton;

            cboEditCategoria.SelectedItem = boton.CategoriaBoton.DescripcionCategoria;
            cboEditMarca.SelectedItem = boton.MarcaBoton.DescripcionMarca;
        }
        private void ConfigurarIdMarca(string marca)
        {
            if(marca == "Samsung")
            {
                IdMarca = 1;
            }
            else if (marca == "Apple")
            {
                IdMarca = 2;
            }
            else if (marca == "Sony")
            {
                IdMarca = 3;
            }
            else if (marca == "Huawei")
            {
                IdMarca = 4;
            }
            else
            {
                IdMarca = 5;
            }
        }
        private void ConfigurarIdCategoria(string categoria)
        {
            if (categoria == "Celulares")
            {
                IdMarca = 1;
            }
            else if (categoria == "Televisores")
            {
                IdMarca = 2;
            }
            else if (categoria == "Media")
            {
                IdMarca = 3;
            }
            else
            {
                IdMarca = 4;
            }

        }
        private void ComprobarCambios()
        {
            try
            {
                if (txtEditNombre.Text != boton.NombreBoton && txtEditNombre.Text != "")
                {
                    boton.NombreBoton = txtEditNombre.Text;
                    this.Nombre = txtEditNombre.Text;
                    edit = true;
                }
                if (txtEditCodigo.Text != boton.CodigoBoton && txtEditCodigo.Text != "")
                {
                    boton.CodigoBoton = txtEditCodigo.Text;
                    this.Codigo = txtEditCodigo.Text;
                    edit = true;
                }
                if (txtEditDescripcion.Text != boton.DescripcionBoton && txtEditDescripcion.Text != "")
                {
                    boton.DescripcionBoton = txtEditDescripcion.Text;
                    this.Descripcion = txtEditDescripcion.Text;
                    edit = true;
                }
                if (txtEditPrecio.Text != "" && (Helper.StringToDecimal(txtEditPrecio.Text) != boton.PrecioBoton) )
                {
                    boton.PrecioBoton = Helper.StringToDecimal(txtEditPrecio.Text);
                    this.Precio = Helper.StringToDecimal(txtEditPrecio.Text);
                    edit = true;
                }
                if (Categoria != boton.CategoriaBoton.DescripcionCategoria)
                {
                    boton.CategoriaBoton.IdCategoria = IdCategoria;
                    boton.CategoriaBoton.DescripcionCategoria = Categoria;
                    edit = true;
                }
                if (Marca != boton.MarcaBoton.DescripcionMarca)
                {
                    boton.MarcaBoton.IdMarca = IdMarca;
                    boton.MarcaBoton.DescripcionMarca = Marca;
                    edit = true;
                }
                if (txtEditUrlImagen.Text != boton.UrlImagenBoton && txtEditUrlImagen.Text != "")
                {
                    boton.UrlImagenBoton = txtEditUrlImagen.Text;
                    this.UrlImagen = txtEditUrlImagen.Text;
                    edit = true;
                }
                if (edit)
                {
                    MessageBox.Show("Se han guardado los cambios.", "Artículo Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Helper.ModificarArticulo(boton);
                }
                else
                {
                    MessageBox.Show("No se han producido cambios.", "Artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            MostarControlesEdit(true, false);
        }
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            MostarControlesEdit(false, true);
            ComprobarCambios();            
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
        private void BtnAcceptCancel_MouseLeave(object sender, EventArgs e)
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
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TxtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            Helper.CargarImagen(imgProducto, txtEditUrlImagen.Text);
        }
        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 44 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && txtEditPrecio.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void cboEditCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboEditMarca.SelectedItem.ToString() != lblMarca.Text)
            {
                Marca = cboEditMarca.SelectedItem.ToString();
                ConfigurarIdMarca(Marca);
            }
            if (cboEditCategoria.SelectedItem.ToString() != lblCategoria.Text)
            {
                Categoria = cboEditCategoria.SelectedItem.ToString();
                ConfigurarIdCategoria(Categoria);
            }
        }
    }
}
