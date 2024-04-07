using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;
using System.Globalization;

namespace Presentacion
{
    public partial class BotonArticulo : UserControl
    {
        private int _id;
        private string _nombre;
        private string _codigo;
        private decimal _precio;
        public int IdArticulo { get { return _id; } set { _id = value; } }
        public string CodigoBoton { get { return _codigo; } set { _codigo = value; } }
        public string NombreBoton { get { return _nombre; } set { _nombre = value; lblNombreProducto.Text = value; } }
        public string UrlImagenBoton { get { return imgProducto.ImageLocation; } set { Helper.CargarImagen(this.imgProducto, value); } }
        public decimal PrecioBoton { get { return _precio; } set { _precio = value; lblPrecio.Text = value.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")); } }
        public string DescripcionBoton { get; set; }
        public Marca MarcaBoton { get; set; }
        public Categoria CategoriaBoton { get; set; }

        public BotonArticulo()
        {
            InitializeComponent();
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            frmDetalles detalles = new frmDetalles(this);
            detalles.ShowDialog();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Helper.EliminarArticulo(this.IdArticulo);
            this.Dispose();
        }
    }
}
