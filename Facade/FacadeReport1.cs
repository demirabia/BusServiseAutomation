using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Facade
{
    public class FacadeReport1
    {
        public static DataTable ListIt()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Report1", OtherConnection.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static DataTable ListIt1()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Report2", OtherConnection.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
