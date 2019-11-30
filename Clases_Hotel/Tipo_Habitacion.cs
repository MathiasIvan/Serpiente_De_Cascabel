using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Clases_Hotel
{
    public class Tipo_Habitacion
    {
        public int ID_TipoHabitacion { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return ID_TipoHabitacion.ToString() + " " + Descripcion;
        }



        public static List<Tipo_Habitacion> listaTipoHabitaciones = new List<Tipo_Habitacion>();

        

        public static List<Tipo_Habitacion> ObtenerTipoHabitaciones()
        {
            Tipo_Habitacion tipo_habitacion;

            listaTipoHabitaciones.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from Tipo_Habitacion";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    tipo_habitacion = new Tipo_Habitacion();
                    tipo_habitacion.ID_TipoHabitacion = elLectorDeDatos.GetInt32(0);
                    tipo_habitacion.Descripcion = elLectorDeDatos.GetString(1);

                    listaTipoHabitaciones.Add(tipo_habitacion);
                }
            }

            return listaTipoHabitaciones;
        }



        public static Tipo_Habitacion ObtenerThabitacion(int id)
        {
            Tipo_Habitacion tipo_habitacion = null;

            if (listaTipoHabitaciones.Count == 0)
            {
                Tipo_Habitacion.ObtenerTipoHabitaciones();
            }

            foreach (Tipo_Habitacion th in listaTipoHabitaciones)
            {
                if (th.ID_TipoHabitacion == id)
                {
                    tipo_habitacion = th;
                    break;
                }
            }
            return tipo_habitacion;
        }



        public static void AgregarTipoHabitacion(Tipo_Habitacion th)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "insert into Tipo_Habitacion (Descripcion) values (@Descripcion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = th.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }



        public static void ActualizarTipoHabitacion(Tipo_Habitacion th, int indice)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "update Tipo_Habitacion set Descripcion = @Descripcion  where Id_Tipo_Habitacion = @Id_Tipo_Habitacion";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = th.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }



        public static void EliminarTipoHabitacion(Tipo_Habitacion th)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Tipo_Habitacion where Id_Tipo_Habitacion = @Id_Tipo_Habitacion";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id_Tipo_Habitacion", th.ID_TipoHabitacion);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

   

        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {

            SqlParameter p2 = new SqlParameter("@Id_Tipo_Habitacion", this.ID_TipoHabitacion);
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
