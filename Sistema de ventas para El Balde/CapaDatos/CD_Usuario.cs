using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad; //Se llama la referencia CapaEntidad que fue agregada al proyecto previamente
                   //CapaEntidad contiene las clases que representan las entidades del negocio, como Usuario, Producto, Cliente, etc.
                   //por lo tanto CapaEntidad se utilizara como referencia en todas las capas de la aplicación.

namespace CapaDatos
{
   public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT IdUsuario, DocumentoUsuario, NombreCompletoUsuario, correoUsuario, Clave, Estado FROM Usuario";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    //Se crea un objeto SqlCommand que representa una instrucción SQL que se va a ejecutar en la base de datos.

                    oconexion.Open();

                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            lista.Add(new Usuario()

                            {
                            IdUsuario = Convert.ToInt32(datareader["IdUsuario"]),
                                DocumentoUsuario = datareader["DocumentoUsuario"].ToString(),
                                NombreCompletoUsuario = datareader["NombreCompletoUsuario"].ToString(),
                                correoUsuario = datareader["correoUsuario"].ToString(),
                                Clave = datareader["Clave"].ToString(),
                                Estado = Convert.ToBoolean(datareader["Estado"])
                            }  );

                            
                        }

                    }

                     
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }


    }
}
