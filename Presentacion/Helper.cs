using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using Dominio;
using Negocio;
using Presentacion;

namespace Helpers
{
    public static class Helper
    {
        public static List<Articulo> CargarDatosArticulos(List<Articulo> listaProductos)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaProductos = negocio.LeerDatos();

                return listaProductos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Marca> CargarDatosMarca()
        {
            MarcaNegocio negocio = new MarcaNegocio();

            List<Marca> listaMarcas;

            try
            {
                listaMarcas = negocio.LeerDatosMarca();

                return listaMarcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Categoria> CargarDatosCategoria()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            List<Categoria> listaCategorias;

            try
            {
                listaCategorias = negocio.LeerDatosCategoria();

                return listaCategorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BotonArticulo> CrearBotones(List<Articulo> articulos)
        {
            List<BotonArticulo> botones = new List<BotonArticulo>();

            foreach (Articulo articulo in articulos)
            {
                BotonArticulo btn = new BotonArticulo()
                {
                    IdArticulo = articulo.Id,
                    Name = articulo.Nombre,
                    CodigoBoton = articulo.Codigo,
                    NombreBoton = articulo.Nombre,
                    UrlImagenBoton = articulo.UrlImagen,
                    PrecioBoton = articulo.Precio,
                    DescripcionBoton = articulo.Descripcion,
                    MarcaBoton = new Marca
                    {
                        IdMarca = articulo.Marca.IdMarca,
                        DescripcionMarca = articulo.Marca.DescripcionMarca
                    },
                    CategoriaBoton = new Categoria()
                    {
                        IdCategoria = articulo.Categoria.IdCategoria,
                        DescripcionCategoria = articulo.Categoria.DescripcionCategoria
                    }
                };
                botones.Add(btn);
            }

            return botones;
        }
        public static void ModificarArticulo(BotonArticulo boton)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                Articulo modificado = new Articulo()
                {
                    Id = boton.IdArticulo,
                    Codigo = boton.CodigoBoton,
                    Nombre = boton.NombreBoton,
                    Descripcion = boton.DescripcionBoton,
                    UrlImagen = boton.UrlImagenBoton,
                    Precio = boton.PrecioBoton,
                    Marca = new Marca()
                    {
                        IdMarca = boton.MarcaBoton.IdMarca,
                        DescripcionMarca = boton.MarcaBoton.DescripcionMarca,
                    },
                    Categoria = new Categoria()
                    {
                        IdCategoria = boton.CategoriaBoton.IdCategoria,
                        DescripcionCategoria = boton.CategoriaBoton.DescripcionCategoria
                    }
                };
                negocio.ModificarArticulo(modificado);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void EliminarArticulo(int id)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("Estas seguro que quieres eliminar el artículo?", "Eliminar Artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.EliminarArticulo(id);
                    MessageBox.Show("El artículo fue eliminado", "Artículo Eliminado", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void CargarImagen(PictureBox imagen, string texto)
        {
            try
            {
                imagen.Load(texto);
            }
            catch (Exception )
            {
                imagen.Load("https://cdn-icons-png.freepik.com/512/8787/8787075.png");   
            }
        }
        public static decimal StringToDecimal (string valor)
        {
            decimal numero = Convert.ToDecimal(valor.Trim(), CultureInfo.CreateSpecificCulture("es-AR"));
            return numero;
        }
        
    }
}
