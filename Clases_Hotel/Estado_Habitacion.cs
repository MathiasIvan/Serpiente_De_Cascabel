using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Clases_Hotel
{
    public class Estado_Habitacion
    {
        public string ID_EstadoHabitacion { get; set; }
        public string Descripcion { get; set; }



        public override string ToString()
        {
            return ID_EstadoHabitacion.ToString();
        }



        public static List<Estado_Habitacion> listaEstadoHabitacion = new List<Estado_Habitacion>();



        public static List<Estado_Habitacion> ObtenerEstadoHabitacion()
        {
            Estado_Habitacion estado_habitacion;

            listaEstadoHabitacion.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from Estado_Habitacion";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    estado_habitacion = new Estado_Habitacion();
                    estado_habitacion.ID_EstadoHabitacion = Convert.ToString(elLectorDeDatos.GetInt32(0));
                    estado_habitacion.Descripcion = elLectorDeDatos.GetString(1);
     
                    listaEstadoHabitacion.Add(estado_habitacion);
                }
            }

            return listaEstadoHabitacion;
        }



        public static Estado_Habitacion ObtenerEsHabitacion(int id)
        {
            Estado_Habitacion estado_habitacion = null;

            if (listaEstadoHabitacion.Count == 0)
            {
                Estado_Habitacion.ObtenerEstadoHabitacion();
            }

            foreach (Estado_Habitacion eh in listaEstadoHabitacion)
            {
                if (eh.ID_EstadoHabitacion == id.ToString())
                {
                    estado_habitacion = eh;
                    break;
                }
            }
            return estado_habitacion;
        }



        public static void AgregarEstadoHabitacion(Estado_Habitacion et)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "insert into Estado_Habitacion (Descripcion) values (@Descripcion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = et.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }



        public static void AcualizarEstadoHabitacion(Estado_Habitacion et, int indice)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "update Estado_Habitacion set Descripcion = @Descripcion  where Id_Estado_Habitacion = @Id_Estado_Habitacion";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = et.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }



        public static void EliminarEstadoHabitacion(Estado_Habitacion et)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Estado_Habitacion where Id_Estado_Habitacion = @Id_Estado_Habitacion";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id_Estado_Habitacion", et.ID_EstadoHabitacion);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }



        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {

            SqlParameter p2 = new SqlParameter("@Id_Estado_Habitacion", this.ID_EstadoHabitacion);
            p2.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p2);
            return cmd;
        }



        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)

        {
            SqlParameter p1 = new SqlParameter("@Descripcion", this.Descripcion);
          
            p1.SqlDbType = SqlDbType.VarChar;
           
            cmd.Parameters.Add(p1);
           
            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;
        }

    }
}

