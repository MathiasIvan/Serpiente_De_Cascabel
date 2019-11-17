using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Clases_Hotel
{
    public enum Servicios
    {
        Bebidas,
        Desayuno,
        Almuerzo,
        Cena
    }


    public class Gastos
    {
            public string ID_Gasto { get; set; }
            public Reserva ID_Reserva_Gasto { get; set; }
            public Servicios Servicio { get; set; }
            public DateTime FechaGasto { get; set; }
            public string Cantidad { get; set; }
            public double CostoTotalGasto { get; set; }


            public override string ToString()
            {
                return ID_Gasto;
            }

            public static List<Gastos> listagastos = new List<Gastos>();


            public static List<Gastos> ObtenerGastos()
            {
            Gastos gastos;

            listagastos.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from Gastos";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    gastos = new Gastos();
                    gastos.ID_Gasto = Convert.ToString(elLectorDeDatos.GetInt32(0));
                    gastos.ID_Reserva_Gasto = Reserva.ObtenerReserva(elLectorDeDatos.GetInt32(1));
                    gastos.Servicio = (Servicios)elLectorDeDatos.GetInt32(2);
                    gastos.FechaGasto = elLectorDeDatos.GetDateTime(3);
                    gastos.Cantidad = Convert.ToString(elLectorDeDatos.GetInt32(4));
                    gastos.CostoTotalGasto = Convert.ToDouble(elLectorDeDatos.GetDouble(5));

                    listagastos.Add(gastos);
                }
            }

            return listagastos;
        }


            public static void AgregarGasto(Gastos g)
            {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "insert into Gastos (Id_Reserva, Servicio, Fecha, Cantidad, Costo) values (@Id_Reserva, @Servicio, @Fecha, @Cantidad, @Costo)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = g.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }


            public static void ActualizarGasto(Gastos g, int indice)
            {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "update Gastos set Id_Reserva = @Id_Reserva, Servicio = @Servicio, Fecha = @Fecha, Cantidad = @Cantidad, Costo = @Costo  where Id_Gasto = @Id_Gasto";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = g.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }


            public static void EliminarGasto(Gastos g)
            {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Gastos where Id_Gasto = @Id_Gasto";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p6 = new SqlParameter("@Id_Gasto", g.ID_Gasto);
                p6.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p6);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {

            SqlParameter p7 = new SqlParameter("@Id_Gasto", this.ID_Gasto);
            p7.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p7);
            return cmd;
        }


        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)

        {
            SqlParameter p1 = new SqlParameter("@Id_Reserva", this.ID_Reserva_Gasto.ID_Reserva);
            SqlParameter p2 = new SqlParameter("@Servicio", this.Servicio);
            SqlParameter p3 = new SqlParameter("@Fecha", this.FechaGasto);
            SqlParameter p4 = new SqlParameter("@Cantidad", this.Cantidad);
            SqlParameter p5 = new SqlParameter("@Costo", this.CostoTotalGasto);
         
            p1.SqlDbType = SqlDbType.Int;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.DateTime;
            p4.SqlDbType = SqlDbType.Int;
            p5.SqlDbType = SqlDbType.Float;
    
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

