using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using Dominio;
using FontAwesome.Sharp;
using Negocio;
using Presentacion;
using Helpers;

namespace Presentacion
{
    public partial class frmProductos : Form
    {
        #region CAMPOS
        //CAMPOS

        //Este campo me permite almacenar el boton que se selecciona
        private IconButton botonSeleccionado;

        //Lista donde se almacenan objetos de la clase Articulos, con en relación a los datos que obtengo de la DB.
        private List<Articulo> listaProductos = new List<Articulo>();

        //Lista que contiene los botones, por cada articulo que se encuentre en la DB se crea un boton
        private List<BotonArticulo> listaBotones = new List<BotonArticulo>();

        //Lista que contiene los botones correspondientes de cada articulo y categoria,
        //la lista almacena los botones segun el boton que se activa, que sirven como filtro de categorias.
        private List<BotonArticulo> btnCategoria = new List<BotonArticulo>();

        //Este campo me permite contener un nuevo boton y añadirlo al panel que contiene los botones de cada articulo y
        //filtrarlo por segun su categoria.
        private BotonArticulo nuevoBoton = null;

        #endregion

        //CONSTRUCTOR DE LA CLASE
        public frmProductos()
        {
            InitializeComponent();

            //Esta instrucción sirve para que el formulario se adapte a la zona de trabajo de la pantalla,
            //por defecto al cargar el formulario y se maximiza abarca toda la pantalla, cubriendo la barra de tareas.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            listaProductos = Helper.CargarDatosArticulos(listaProductos);
            listaBotones = Helper.CrearBotones(listaProductos);
            ActivarBoton(btnTodos);
            FiltrarBotonesCategoria();
        }

        #region MÉTODOS
        //Metodo que filtra los artículos segun lo que se ingrese en el textBox y segun el boton que este activado.
        private void FiltroNameBusqueda()
        {
            //Lista que almacena los botones que contiene el pnlContenedor para luego ser filtrada.
            List<BotonArticulo> listaFiltrada = new List<BotonArticulo>();

            foreach (BotonArticulo boton in pnlContenedorProductos.Controls)
            {
                listaFiltrada.Add(boton);
            }

            //Elimina todos los controles del panel.
            pnlContenedorProductos.Controls.Clear();

            //Compara lo que el usuario ingresa en el textBox de busqueda y segun el boton que este seleccionado se muestran los 
            //botones que contengo en su Name lo que en el textBox se ingresa.
            if (txtBusqueda.Text != "" && botonSeleccionado != btnTodos)
            {
                                                    //Se buscan los botones que contengan en su Name lo que en el TextBox se ingresa y además que coincida la categoria del boton con el boton que esta activado
                foreach (BotonArticulo articulo in listaFiltrada.FindAll(x => x.Name.ToUpper().Contains(txtBusqueda.Text.ToUpper()) && x.CategoriaBoton.DescripcionCategoria == botonSeleccionado.Text))
                {
                    pnlContenedorProductos.Controls.Add(articulo);
                }
            }
            else if (txtBusqueda.Text != "" && botonSeleccionado == btnTodos)
            {
                foreach (BotonArticulo articulo in listaBotones.FindAll(x => x.Name.ToUpper().Contains(txtBusqueda.Text.ToUpper())))
                {
                    pnlContenedorProductos.Controls.Add(articulo);
                }
            }
            else if (txtBusqueda.Text == "" && botonSeleccionado == btnTodos)
            {
                foreach (BotonArticulo articulo in listaBotones)
                {
                    pnlContenedorProductos.Controls.Add(articulo);
                }
            }
            else //En el caso de que el textbox este vacio y el boton seleccionado sea distinto a btnTodos, se muestra en el contenedor los botones que estan en la lista btnCategoria.
            {
                foreach (BotonArticulo articulo in btnCategoria)
                {
                    pnlContenedorProductos.Controls.Add(articulo);
                }
            }
        }

        //Este método filtra los botones segun su categoria, recibe un parámetro del tipo string que corresponde al .Text
        //del boton que esta activado.
        private void FiltrarBotonesCategoria(string filtro = "")
        {
            //Limpia (elimina los elementos que contiene la lista) la lista categoria y el panel que contiene los botones
            //de cada articulo para que no se vean duplicados.
            pnlContenedorProductos.Controls.Clear();
            btnCategoria.Clear();


            //Según el valor del parámetro filtro, se recorre la lista que contiene todos los botones y se agregan a la lista
            //bntCategoria y se muestran en el panelContenerdosProductos.
            if (filtro == "Celulares")
            {
                foreach (BotonArticulo boton in listaBotones.FindAll(x => x.CategoriaBoton.DescripcionCategoria == filtro))
                {
                    pnlContenedorProductos.Controls.Add(boton);
                    btnCategoria.Add(boton);
                }
            }
            else if (filtro == "Televisores")
            {
                foreach (BotonArticulo boton in listaBotones.FindAll(x => x.CategoriaBoton.DescripcionCategoria == filtro))
                {
                    pnlContenedorProductos.Controls.Add(boton);
                    btnCategoria.Add(boton);
                }
            }
            else if (filtro == "Media")
            {
                foreach (BotonArticulo boton in listaBotones.FindAll(x => x.CategoriaBoton.DescripcionCategoria == filtro))
                {
                    pnlContenedorProductos.Controls.Add(boton);
                    btnCategoria.Add(boton);
                }
            }
            else if (filtro == "Audio")
            {
                foreach (BotonArticulo boton in listaBotones.FindAll(x => x.CategoriaBoton.DescripcionCategoria == filtro))
                {
                    pnlContenedorProductos.Controls.Add(boton);
                    btnCategoria.Add(boton);
                }
            }
            else //Si el boton que se activa es el que muestra todos los productos, se agregan al panel todos los botones, que
            {     //estan en la listaBotones.
            
                foreach (BotonArticulo boton in listaBotones)
                {
                    pnlContenedorProductos.Controls.Add(boton);
                }
            }
        }

        //Este método ordena la lista que correspanda segun el precio de cada articulo, comparando su propiedad Precio.
        private void FiltroPrecioUp()
        {
            //Lista que sirve para almacenar los botones ordenados segun el precio, de menor a mayor, es decir ascendente.
            List<BotonArticulo> botonesFiltrados = new List<BotonArticulo>();

            //Lo primero que se hace es recorrer a agregar cada boton que este presente en el panel a la lista de 
            //botones filtrado. En el caso de que este activo un boton que sirve de filtro de categoria, solo se almacenan
            //en esta lista los botones que correspondan a esa categoria, en caso contrario se almacenarian todos lo botones.
            foreach (BotonArticulo boton in pnlContenedorProductos.Controls)
            {
                botonesFiltrados.Add(boton);
            }

            //Se eliminarn todos los controles que contiene el panel, para que no se muestren duplicados y cuando se vuelvan a mostrar
            //se vean de forma ordenada.
            pnlContenedorProductos.Controls.Clear();

            //Se utiliza el metodo Sort (funcion lambda) que compara la propiedad precio de dos botones y los va ordenando de forma creciente.
            botonesFiltrados.Sort((x, y) => x.PrecioBoton.CompareTo(y.PrecioBoton));

            //En caso de el usuario ingrese algo en el textbox se van a filtrar y mostrar los elementos ordenados y los que cotengan en su Name lo que se ingresa en el TextBox.
            if (txtBusqueda.Text != "")
            {                                      //El método FindAll busca entre todos los elementos de la lista aquellos que contengan
                                                   //en su propiedad Name lo que en el textBox se ingresó.
                foreach (BotonArticulo articulo in botonesFiltrados.FindAll(x => x.Name.ToUpper().Contains(txtBusqueda.Text.ToUpper())))
                {
                    pnlContenedorProductos.Controls.Add(articulo);
                }
            }
            else //Si el textBox está vacío se muestran todos los productos.
            {
                foreach (BotonArticulo articulo in botonesFiltrados)
                {
                    pnlContenedorProductos.Controls.Add(articulo);
                }
            }

        }

        //Este método ordena la lista que correspanda segun el precio de cada articulo, comparando su propiedad Precio.
        //funciona de la misma manera que el método anterios, solo que ordena los elementos segun el precio de forma decreciente.
        private void FiltroPrecioDown()
        {
            List<BotonArticulo> botonesFiltrados = new List<BotonArticulo>();

            foreach (BotonArticulo boton in pnlContenedorProductos.Controls)
            {
                botonesFiltrados.Add(boton);
            }

            pnlContenedorProductos.Controls.Clear();

            botonesFiltrados.Sort((x, y) => y.PrecioBoton.CompareTo(x.PrecioBoton));

            if (txtBusqueda.Text != "")
            {
                foreach (BotonArticulo articulo in botonesFiltrados.FindAll(x => x.Name.ToUpper().Contains(txtBusqueda.Text.ToUpper())))
                {
                    pnlContenedorProductos.Controls.Add(articulo);
                }
            }
            else
            {
                foreach (BotonArticulo articulo in botonesFiltrados)
                {
                    pnlContenedorProductos.Controls.Add(articulo);
                }
            }
        }

        //Este método cambia los valores de algunas propiedades de los botones filtro de categoria al hacer click en ellos,
        //da un aspecto de que el boton esta activado.
        private void ActivarBoton(IconButton boton)
        {
            DesactivarBoton();

            if (boton != null)
            {
                botonSeleccionado = boton;
                botonSeleccionado.Enabled = false;

                botonSeleccionado.BackColor = Color.White;
                botonSeleccionado.IconColor = Color.Black;
                botonSeleccionado.ForeColor = Color.Black;
            }
        }

        //Este metodo restaura los valores de las propiedades que se modificaron en el metodo anterior cuando se hace click en un boton filtro
        //diferente al que esta activado, da un aspecto de que el boton se desactiva.
        private void DesactivarBoton()
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.Enabled = true;

                botonSeleccionado.BackColor = Color.FromArgb(41, 81, 110);
                botonSeleccionado.IconColor = Color.White;
                botonSeleccionado.ForeColor = Color.White;
            }
        }
        #endregion

        #region MÉTODOS PARA CONFIGURAR EVENTOS

        //Método para configurar el evento click del boton Agregar Producto.
        //Al hacer click en este boton, se va a abrir un formualrio donde poder agregar datos que
        //corresponde al nuevo articulo.
        private void BtnAgregar_Click (object sender, EventArgs e)
        {
            frmAgregarRegistro agregar = new frmAgregarRegistro();
            agregar.ShowDialog();

            //Si se agrega un boton, este nuevo boton se almacena en el campo nuevoBoton.
            nuevoBoton = agregar.CrearBoton();

            //Si lo que contiene el campo nuevoBoton es realmente un boton, este se agrega a al lista botones
            //Se filtra por categoria y se activa el boton para mostrar todos los botones de cada artículo.
            if( nuevoBoton != null)
            {
                listaBotones.Add(nuevoBoton);
                FiltrarBotonesCategoria();
                ActivarBoton(btnTodos);
            }

        }
        //Al hacer click en los botones filtro por categoría (pnlRight), además de "activarse", se llama
        //al método FiltrarBotonesCategoria, que filtra los botones seguns su categoria y los muestra en el panel.
        private void BotonesFiltro_Click(object sender, EventArgs e)
        {
            ActivarBoton((IconButton)sender);

            if (sender == btnTodos)
            {
                FiltrarBotonesCategoria();
            }
            else if (sender == btnCelulares)
            {
                FiltrarBotonesCategoria("Celulares");
            }
            else if (sender == btnTelevisores)
            {
                FiltrarBotonesCategoria("Televisores");
            }
            else if (sender == btnMedia)
            {
                FiltrarBotonesCategoria("Media");
            }
            else if (sender == btnAudio)
            {
                FiltrarBotonesCategoria("Audio");
            }
        }
        //Al hacer click en el boton (btnPrecioUp), se ordenar los elementos que contiene el panel segun el precio
        //y de forma creciente, llamando al método FiltroPrecioUp();
        private void btnPrecioUp_Click(object sender, EventArgs e)
        {
            FiltroPrecioUp();
        }
        //Al hacer click en el boton (btnPrecioUp), se ordenar los elementos que contiene el panel segun el precio
        //y de forma decreciente, llamando al método FiltroPrecioDown();
        private void btnPrecioDown_Click(object sender, EventArgs e)
        {
            FiltroPrecioDown();
        }
        //Método que al entrar el mouse en la zona de los botones, cambia valores de ciertas propiedaes.
        private void BotonesPnlTop_MouseEnter(object sender, EventArgs e)
        {
            if (sender == btnClose)
            {
                btnClose.IconColor = Color.FromArgb(249, 81, 66);
            }
            else if (sender == btnMinimize)
            {
                btnMinimize.IconColor = Color.FromArgb(253, 229, 156);
            }
            else
            {
                btnMaximize.IconColor = Color.FromArgb(205, 216, 129);
            }
        }
        //Método que al salir el mouse de la zona de cada boton, cambia valores de ciertas propiedades.
        private void BotonesPnlTop_MouseLeave (object sender, EventArgs e)
        {
            IconButton boton = (IconButton)sender;
            boton.IconColor = Color.White;
        }
        //Método que configura el evento click de los botones del panel top, que sirven para cerrar el formulario,
        //minimizar o maximizar el formulario.
        private void BotonesPnlTop_Click (object sender , EventArgs e)
        {
            if (sender == btnClose)
            {
                Close();
            }
            else if (sender == btnMaximize)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    btnMaximize.IconChar = IconChar.WindowMaximize;
                    bordeFormulario.BorderRadius = 20;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    btnMaximize.IconChar = IconChar.WindowRestore;
                    bordeFormulario.BorderRadius = 0;
                }
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        //Al cambiar el texto que se ingresa en el textBox de busque se filtran los articulos.
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            FiltroNameBusqueda();
        }
        #endregion
    }
}
