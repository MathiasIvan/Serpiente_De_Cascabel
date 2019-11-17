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
    public class Registrador: Persona
    {
        public string ID_Registrador { get; set; }
        public string Observacion { get; set; }



        public override string ToString()
        {
            return ID_Registrador.ToString();
        }



        public static List<Registrador> listaRegistradores = new List<Registrador>();



        public static List<Registrador> ObtenerRegistradores()
        {
            Registrador registrador;

            listaRegistradores.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from Registrador";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    registrador = new Registrador();
                    registrador.ID_Registrador = Convert.ToString(elLectorDeDatos.GetInt32(0));
                    registrador.Nombre = elLectorDeDatos.GetString(1);
                    registrador.Direccion = elLectorDeDatos.GetString(2);
                    registrador.NroDocumento = elLectorDeDatos.GetString(3);
                    registrador.Telefono = elLectorDeDatos.GetString(4);
                    registrador.Observacion = elLectorDeDatos.GetString(5);

                    listaRegistradores.Add(registrador);

                }
            }

            return listaRegistradores;
        }



        public static Registrador ObtenerRegistrador(int id)
        {
            Registrador regsitrador = null;

            if (listaRegistradores.Count == 0)
            {
                Registrador.ObtenerRegistradores();
            }

            foreach (Registrador r in listaRegistradores)
            {
                if (r.ID_Registrador == id.ToString())
                {
                    regsitrador = r;
                    break;
                }
            }
            return regsitrador;
        }


        public static void AgregarRegistrador(Registrador r)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "insert into Registrador (Nombre, Direccion, Nro_Documento, Telefono, Observacion) values (@Nombre, @Direccion, @Nro_Documento, @Telefono, @Observacion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = r.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }



        public static void ActualizarRegistrador(Registrador r, int indice)
        {
            using(SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "update Registrador set Nombre = @Nombre, Direccion = @Direccion, Nro_Documento = @Nro_Documento, Telefono = @Telefono, Observacion = @Observacion where Id_Registrador = @Id_Registrador";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = r.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }



        public static void EliminarRegistrador(Registrador r)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Registrador where Id_Registrador = @Id_Registrador";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id_Registrador", r.ID_Registrador);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            SqlParameter p6 = new SqlParameter("@Id_Registrador", this.ID_Registrador);
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
            SqlParameter p5 = new SqlParameter("@Observacion", this.Observacion);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.VarChar;
            p4.SqlDbType = SqlDbType.VarChar;
            p5.SqlDbType = SqlDbType.VarChar;

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

