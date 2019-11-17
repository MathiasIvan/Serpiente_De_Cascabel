using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Clases_Hotel;

namespace Clases_Hotel
{
    public enum Nacionalidades
    {
        Australia,
        España,
        Inglaterra,
        Costa_Rica,
        Portugal
    }



    public class Cliente: Persona
    {     
            public string ID_Cliente;
            public Nacionalidades Nacionalidad;
            


            public override string ToString()
            {
                return ID_Cliente.ToString();
            }



            public static List<Cliente> listaClientes = new List<Cliente>();



            public static List<Cliente> ObtenerClientes()
            {
            Cliente cliente;

            listaClientes.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from Cliente";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    cliente = new Cliente();
                    cliente.ID_Cliente = Convert.ToString(elLectorDeDatos.GetInt32(0));
                    cliente.Nombre = elLectorDeDatos.GetString(1);
                    cliente.Direccion = elLectorDeDatos.GetString(2);
                    cliente.NroDocumento = elLectorDeDatos.GetString(3);
                    cliente.Telefono = elLectorDeDatos.GetString(4);
                    cliente.Nacionalidad = (Nacionalidades)elLectorDeDatos.GetInt32(5);

                    listaClientes.Add(cliente);

                }
            }

            return listaClientes;
        }


        public static Cliente ObtenerCliente(int id)
        {
            Cliente cliente = null;

            if (listaClientes.Count == 0)
            {
                Cliente.ObtenerClientes();
            }

            foreach (Cliente c in listaClientes)
            {
                if (c.ID_Cliente == id.ToString())
                {
                    cliente = c;
                    break;
                }
            }
            return cliente;
        }


        public static void AgregarCliente(Cliente c)
            {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "insert into Cliente (Nombre, Direccion, Nro_Documento, Telefono, Nacionalidad) values (@Nombre, @Direccion, @Nro_Documento, @Telefono, @Nacionalidad)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }



            public static void ActualizarCliente(Cliente c, int indice)
            {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "update Cliente set Nombre = @Nombre, Direccion = @Direccion, Nro_Documento = @Nro_Documento, Telefono = @Telefono, Nacionalidad = @Nacionalidad where Id_Cliente = @Id_Cliente";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = c.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }



            public static void EliminarCliente(Cliente c)
            {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Cliente where Id_Cliente = @Id_Cliente";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id_Cliente", c.ID_Cliente);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            SqlParameter p6 = new SqlParameter("@Id_Cliente", this.ID_Cliente);
            p6.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p6);
            return cmd;
        }



        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)

        {
            SqlParameter p1 = new SqlParameter("@Nombre", this.Nombre);
            SqlParameter p2 = new SqlParameter("@Direccion", this.Direccion);
            SqlParameter p3 = new SqlParameter("@Nro_Documento", this.NroDocumento);
            SqlParameter p4 = new SqlParameter("@Telefono", this.Telefono);
            SqlParameter p5 = new SqlParameter("@Nacionalidad", this.Nacionalidad);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.VarChar;
            p4.SqlDbType = SqlDbType.VarChar;
            p5.SqlDbType = SqlDbType.Int;
          
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
       
            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;

        }

    }
}

