using System.Data;
using System.Data.SqlClient;

namespace biblioteca_datos
{
    public static class personas
    {
        private static string cadenaCon = @"server=A-SIS-0KP\SQL EXPRESS2016; database=TI2021; Integrated Security=true";
        public static string getDatos(string dt)
        {
            string sql = "select cedula, apellidos, nombres, fechadenacimiento, peso ";
            string v = "from persona order by apellidos, nombres";

            SqlConection conexion = new SqlConection(cadenaCon);
            SqlComand comando = new SqlComand(sql, conexion);

            SqlDataAdapter ad = new SqlDataAdapter();


            ad.Fill(new DataTable());

            return null ;
        }
    }

    internal class SqlComand
    {
        public SqlComand(string sql, SqlConection conexion)
        {
        }
    }

    internal class SqlConection
    {
        public SqlConection(string cadenaCon)
        {
        }
    }
}
