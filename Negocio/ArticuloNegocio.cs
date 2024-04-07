using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private List<Articulo> listaArticulos = new List<Articulo>();

        public List<Articulo> LeerDatos()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.ConfigurarConsulta("Select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, IdMarca, M.Descripcion Marca, IdCategoria, C.Descripcion Categoria, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where IdMarca = M.Id and IdCategoria = C.Id");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo()
                    {
                        Id = (int)datos.Lector["Id"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Codigo = (string)datos.Lector["Codigo"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        UrlImagen = (string)datos.Lector["ImagenUrl"],
                        Marca = new Marca()
                        {
                            IdMarca = (int)datos.Lector["IdMarca"],
                            DescripcionMarca = (string)datos.Lector["Marca"]
                        },
                        Categoria = new Categoria()
                        {
                            IdCategoria = (int)datos.Lector["IdCategoria"],
                            DescripcionCategoria = (string)datos.Lector["Categoria"]
                        },
                        Precio = (decimal)datos.Lector["Precio"]
                    };

                    listaArticulos.Add(aux);
                }

                return listaArticulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void AgregarNuevoRegistro(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.ConfigurarConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.ConfigurarParametros("@Codigo", nuevo.Codigo);
                datos.ConfigurarParametros("@Nombre", nuevo.Nombre);
                datos.ConfigurarParametros("@Descripcion", nuevo.Descripcion);
                datos.ConfigurarParametros("@IdMarca", nuevo.Marca.IdMarca);
                datos.ConfigurarParametros("@IdCategoria", nuevo.Categoria.IdCategoria);
                datos.ConfigurarParametros("@ImagenUrl", nuevo.UrlImagen);
                datos.ConfigurarParametros("@Precio", nuevo.Precio);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void ModificarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.ConfigurarConsulta($"Update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @UrlImagen, Precio = @Precio where Id = @Id");
                datos.ConfigurarParametros("@Nombre", articulo.Nombre);
                datos.ConfigurarParametros("@Codigo", articulo.Codigo);
                datos.ConfigurarParametros("@Descripcion", articulo.Descripcion);
                datos.ConfigurarParametros("@IdMarca", articulo.Marca.IdMarca);
                datos.ConfigurarParametros("@IdCategoria", articulo.Categoria.IdCategoria);
                datos.ConfigurarParametros("@UrlImagen", articulo.UrlImagen);
                datos.ConfigurarParametros("@Precio", articulo.Precio);
                datos.ConfigurarParametros("@Id", articulo.Id);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
             
        }
        public void EliminarArticulo(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.ConfigurarConsulta("Delete from ARTICULOS where Id = @id");
                datos.ConfigurarParametros("@id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
