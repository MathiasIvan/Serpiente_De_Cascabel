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
    public class Habitacion
    {
        public int ID_Habitacion { get; set; }
        public int Numero { get; set; }
        public Estado_Habitacion Id_EstadoHabitacion { get; set; }
        public Tipo_Habitacion Id_TipoHabitacion { get; set; }
        public double Costo { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return ID_Habitacion.ToString();
        }


        public static List<Habitacion> listaHabitaciones = new List<Habitacion>();


        public static List<Habitacion> ObtenerHabitaciones()
        {
            Habitacion habitacion;

            listaHabitaciones.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from Habitacion";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    habitacion = new Habitacion();
                    habitacion.ID_Habitacion = elLectorDeDatos.GetInt32(0);
                    habitacion.Numero = elLectorDeDatos.GetInt32(1);
                    habitacion.Id_EstadoHabitacion = Estado_Habitacion.ObtenerEsHabitacion(elLectorDeDatos.GetInt32(2));
                    habitacion.Id_TipoHabitacion = Tipo_Habitacion.ObtenerThabitacion(elLectorDeDatos.GetInt32(3));
                    habitacion.Costo = Convert.ToDouble(elLectorDeDatos.GetDouble(4));
                    habitacion.Descripcion = elLectorDeDatos.GetString(5);

                    listaHabitaciones.Add(habitacion);

                }
            }

            return listaHabitaciones;
        }


        public static Habitacion ObtenerHabitacion(int id)
        {
            Habitacion habitacion = null;

            if (listaHabitaciones.Count == 0)
            {
                Habitacion.ObtenerHabitaciones();
            }

            foreach (Habitacion h in listaHabitaciones)
            {
                if (h.ID_Habitacion == id)
                {
                    habitacion = h;
                    break;
                }
            }
            return habitacion;
        }


        public static void AgregarHabitacion(Habitacion h)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "insert into Habitacion (Numero, Id_Estado_Habitacion, Id_Tipo_Habitacion, Costo, Descripcion) values (@Numero, @Id_Estado_Habitacion, @Id_Tipo_Habitacion, @Costo, @Descripcion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = h.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }


        public static void ActualizarHabitacion(Habitacion h, int indice)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "update Habitacion set Numero = @Numero, Id_Estado_Habitacion = @Id_Estado_Habitacion, Id_Tipo_Habitacion = @Id_Tipo_Habitacion, Costo = @Costo, Descripcion = @Descripcion where Id_Habitacion = @Id_Habitacion";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = h.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }


        public static void EliminarHabitacion(Habitacion h)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Habitacion where Id_Habitacion = @Id_Habitacion";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id_Habitacion", h.ID_Habitacion);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {

            SqlParameter p6 = new SqlParameter("@Id_Habitacion", this.ID_Habitacion);
            p6.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p6);
            return cmd;
        }


        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)

        {
            SqlParameter p1 = new SqlParameter("@Numero", this.Numero);
            SqlParameter p2 = new SqlParameter("@Id_Estado_Habitacion", this.Id_EstadoHabitacion.ID_EstadoHabitacion);
            SqlParameter p3 = new SqlParameter("@Id_Tipo_Habitacion", this.Id_TipoHabitacion.ID_TipoHabitacion);
            SqlParameter p4 = new SqlParameter("@Costo", this.Costo);
            SqlParameter p5 = new SqlParameter("@Descripcion", this.Descripcion);

            p1.SqlDbType = SqlDbType.Int;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.Float;
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

