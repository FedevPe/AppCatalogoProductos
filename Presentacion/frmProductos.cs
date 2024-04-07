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
        private IconButton botonSeleccionado;

        private List<Articulo> listaProductos = new List<Articulo>();
        private List<BotonArticulo> listaBotones = new List<BotonArticulo>();
        private List<BotonArticulo> btnCategoria = new List<BotonArticulo>();

        private BotonArticulo nuevoBoton = null;
        public frmProductos()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            listaProductos = Helper.CargarDatosArticulos(listaProductos);
            listaBotones = Helper.CrearBotones(listaProductos);
            ActivarBoton(btnTodos);
            FiltrarBotonesCategoria();
        }

        private void FiltrarBotonesCategoria(string filtro = "")
        {
            pnlContenedorProductos.Controls.Clear();
            btnCategoria.Clear();

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
            else
            {
                foreach (BotonArticulo boton in listaBotones)
                {
                    pnlContenedorProductos.Controls.Add(boton);
                }
            }
        }
        private void FiltroPrecioUp()
        {
            List<BotonArticulo> botonesFiltrados = new List<BotonArticulo>();

            foreach (BotonArticulo boton in pnlContenedorProductos.Controls)
            {
                botonesFiltrados.Add(boton);
            }

            pnlContenedorProductos.Controls.Clear();

            botonesFiltrados.Sort((x, y) => x.PrecioBoton.CompareTo(y.PrecioBoton));

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

        private void BtnAgregar_Click (object sender, EventArgs e)
        {
            frmAgregarRegistro agregar = new frmAgregarRegistro();
            agregar.ShowDialog();

            nuevoBoton = agregar.CrearBoton();

            if( nuevoBoton != null)
            {
                listaBotones.Add(nuevoBoton);
                FiltrarBotonesCategoria();
                ActivarBoton(btnTodos);
            }

        }
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
        private void btnPrecioUp_Click(object sender, EventArgs e)
        {
            FiltroPrecioUp();
        }
        private void btnPrecioDown_Click(object sender, EventArgs e)
        {
            FiltroPrecioDown();
        }
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
        private void BotonesPnlTop_MouseLeave (object sender, EventArgs e)
        {
            IconButton boton = (IconButton)sender;
            boton.IconColor = Color.White;
        }
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
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<BotonArticulo> listaFiltrada = new List<BotonArticulo>();

            foreach (BotonArticulo boton in pnlContenedorProductos.Controls)
            {
                listaFiltrada.Add(boton);
            }

            pnlContenedorProductos.Controls.Clear();

            if (txtBusqueda.Text != "" && botonSeleccionado != btnTodos)
            {
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
            else
            {
                foreach (BotonArticulo articulo in btnCategoria)
                {
                    pnlContenedorProductos.Controls.Add(articulo);
                }
            }
        }
    }
}
