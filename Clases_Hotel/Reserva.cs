using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Clases_Hotel
{
    public class Reserva
    {
        public int ID_Reserva { get; set; }
        public DateTime FechaHoraEntrada { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public Habitacion Id_Habitacion { get; set; }
        public Cliente Id_Cliente { get; set; }
        public Registrador Id_Registrador { get; set; }
        public double CostoTotal { get; set; }
        public string Observacion { get; set; }


        public override string ToString()
        {
            return ID_Reserva.ToString();
        }


        public static List<Reserva> listareserva = new List<Reserva>();


        public static List<Reserva> ObtenerReservas()
        {
            Reserva reserva;
            listareserva.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Reserva";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    reserva = new Reserva();
                    reserva.ID_Reserva = elLectorDeDatos.GetInt32(0);
                    reserva.FechaHoraEntrada =  elLectorDeDatos.GetDateTime(1);
                    reserva.FechaHoraSalida = elLectorDeDatos.GetDateTime(2);
                    reserva.Id_Habitacion = Habitacion.ObtenerHabitacion(elLectorDeDatos.GetInt32(3));
                    reserva.Id_Cliente = Cliente.ObtenerCliente(elLectorDeDatos.GetInt32(4));
                    reserva.Id_Registrador = Registrador.ObtenerRegistrador(elLectorDeDatos.GetInt32(5));
                    reserva.CostoTotal = elLectorDeDatos.GetDouble(6);
                    reserva.Observacion = elLectorDeDatos.GetString(7);

                   listareserva.Add(reserva);
                }

                return listareserva;
            }
        }
  

        public static Reserva ObtenerReserva(int id)
        {
            Reserva reserva = null;

            if (listareserva.Count == 0)
            {
                Reserva.ObtenerReservas();
            }

            foreach (Reserva r in listareserva)
            {
                if (r.ID_Reserva == id)
                {
                    reserva = r;
                    break;
                }
            }

            return reserva;
        }


        public static void AgregarReserva(Reserva rs)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "insert into Reserva (FechaHoraEntrada, FechaHoraSalida, Id_Habitacion, Id_Cliente, Id_Registrador, Costo_Total, Observacion)values (@FechaHoraEntrada, @FechaHoraSalida, @Id_Habitacion, @Id_Cliente, @Id_Registrador, @Costo_Total, @Observacion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = rs.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }


        public static void ActualizarReserva(Reserva rs, int indice)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "update Reserva set FechaHoraEntrada = @FechaHoraEntrada, FechaHoraSalida = @FechaHoraSalida, Id_Habitacion = @Id_Habitacion, Id_Cliente = @Id_Cliente, Id_Registrador = @Id_Registrador, Costo_Total = @Costo_Total, Observacion = @Observacion where Id_Reserva = @Id_Reserva";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = rs.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }


        public static void EliminarReserva(Reserva rs)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Reserva where Id_Reserva = @Id_Reserva";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id_Reserva", rs.ID_Reserva);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {

            SqlParameter p9 = new SqlParameter("@Id_Reserva", this.ID_Reserva);
            p9.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p9);
            return cmd;
        }


        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)

        {
            SqlParameter p1 = new SqlParameter("@FechaHoraEntrada", this.FechaHoraEntrada);
            SqlParameter p2 = new SqlParameter("@FechaHoraSalida", this.FechaHoraSalida);
            SqlParameter p3 = new SqlParameter("@Id_Habitacion", this.Id_Habitacion.ID_Habitacion.ToString());
            SqlParameter p4 = new SqlParameter("@Id_Cliente", this.Id_Cliente.ID_Cliente.ToString());
            SqlParameter p5 = new SqlParameter("@Id_Registrador", this.Id_Registrador.ID_Registrador.ToString());
            SqlParameter p6 = new SqlParameter("@Costo_Total", this.CostoTotal);
            SqlParameter p7 = new SqlParameter("@Observacion", this.Observacion);

            p1.SqlDbType = SqlDbType.DateTime;
            p2.SqlDbType = SqlDbType.DateTime;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.Int;
            p5.SqlDbType = SqlDbType.Int;
            p6.SqlDbType = SqlDbType.Float;
            p7.SqlDbType = SqlDbType.VarChar;
      
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
           
            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;

        }

    }
}

