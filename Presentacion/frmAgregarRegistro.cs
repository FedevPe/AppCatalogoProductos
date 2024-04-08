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
        #region CAMPOS
 
        Articulo nuevo = null;
        BotonArticulo boton = null;

        #endregion

        //CONSTRUCTOR DE LA CLASE
        public frmAgregarRegistro()
        {
            InitializeComponent();
            CargarDatosComboBox();
            Helper.CargarImagen(imgProducto, "");
        }

        #region MÉTODOS

        //Método que carda los datos al comboBox que permiten al usuario seleccionar la
        //categoría y marca del articulo nuevo.
        private void CargarDatosComboBox()
        {
            //Utilizo el método CargarDatosCategoria() de la Clase Helper que obtiene desde la DB
            //la categorías que se le pueden asignar a un artículo
            cboAddCategoria.DataSource = Helper.CargarDatosCategoria();
            cboAddCategoria.ValueMember = "IdCategoria"; //Clave de valor
            cboAddCategoria.DisplayMember = "DescripcionCategoria"; //Valor que se muestra
            cboAddCategoria.SelectedIndex = -1; //Indice con el que se inicia el ComboBox

            //Lo mismo para cargar las marcas de los artículos, utilizo un metodo definido en la clase Helper
            //CargarDatosMarca() para obtener los valores desde la DB
            cboAddMarca.DataSource = Helper.CargarDatosMarca(); 
            cboAddMarca.ValueMember = "IdMarca"; //Clave de valor
            cboAddMarca.DisplayMember = "DescripcionMarca"; //Valor que se muestra
            cboAddMarca.SelectedIndex = -1; //Indice con el que se inica el ComboBox
        }
        //Metodo que permite agregar un nuevo artículo a la DB
        private void AgregarNuevoArticulo()
        {
            //Instancio un objeto de la clase ArticuloNegocio para poder utilizar el metodo definido en esta
            //que permite conectarse a la DB y ejecutar una operacion del tipo NonQuery (Insert)
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                //Instancio un objeto de la clase artículo y asigno los valores a cada una de sus propiedades.
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
                                    //Método que convierte los valores del tipo string en decimal
                    Precio = Helper.StringToDecimal(txtAddPrecio.Text)
                };

                //Utilizo el metodo AgregarNuevoRegistro() de la clase ArticuloNegocio para poder agregar el 
                //nuevo registro en la DB, este recibe como parámetro el nuevo articulo almacenado en la variable "nuevo"
                negocio.AgregarNuevoRegistro(nuevo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Método que crea un boton en caso de que se agregue un nuevo articulo.
        public BotonArticulo CrearBoton()
        {
            //En caso de que se agregue un nuevo registro, la variable nuevo contiene un nuevo objeto del tipo
            //articulo, por lo tanto no es nulo y se crea un boton que corresponde al nuevo artículo.
            if (nuevo != null)
            {
                //Instancio un objeto de la clase BotonArticulo y asigno los valores del nuevo articulo a
                //las propiedades del boton.
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

            //Este metodo retorna un boton porque es utilizado por el formulario "frmProductos" para obtener y 
            //mostrar el nuevo boton en el panel que los contiene y clasificarlo segun su categoria.
            return boton;
        }
        //Método que modifica las labels cuando se ingresa texto en los texbox, le permiten al usuario ver
        //como quedarían los datos del nuevo artículo en caso de que presione el boton aceptar.
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
        //Método que resetea las labels en caso de que el txtBox correspondiente este vacío.
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
        //Metodo que elimina el texto de las etiqueta.
        private void BorrarTexto(Label etiqueta)
        {
            etiqueta.Text = string.Empty;
        }
        //Método que permite validar que los campos no esten vacios, es decir, que el usuario complete 
        //los campos que son "obligatorios".
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

            //Si se detecta que algún campo esta vacío se muestra un mensaje especificando cual es el campo que esta vacío.
            if (bError)
            {
                MessageBox.Show(mensaje, "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                //En caso de que todo sea correcto, que todos los campos esten llenos, se carga el nuevo artículo en la DB y se cierra el formulario.
                MessageBox.Show("El artículo fue agregado de forma exitosa.", "Nuevo Artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AgregarNuevoArticulo();
                Close();
            }
        }
        #endregion

        #region MÉTODOS PARA CONFIGURAR EVENTOS

        //Método que configura el evento click del boton aceptar
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            //Se validan los datos y en caso de que esten los campos completos se agrega el articulo a la DB.
            ValidarEntradasDatos();
        }
        //Si se hace click en el boton cancelar, se destruye el formulario (podria poner Close()).
        private void BtnCancel_Click(object sender, EventArgs e)
        {            
            this.Dispose();
        }
        //Al cambiar el texto de los txtBox modifica las etiquetas correspondiente.
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
        //Al hacer click en los controles que permiten ingresar los datos del nuevo artículo,
        //se elimina el texto de las labels correspondientes.
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
        //Se modifican las labals categoria y marca al seleccionar un valor de los comboBox
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
        //Al entrar el mouse en la zona de los botones se cambian los valores de algunas propiedades.
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
        //Al salir el mouse en la zona de los botones se cambian los valores de algunas propiedades.
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
        //Método que permite controlar que en el txtPrecio solo se ingresen numeros y un solo caracter igual a la coma.
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
        #endregion
    }
}
