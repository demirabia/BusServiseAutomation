using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Facade
{
    public class FacadeBus
    {
        public static int ADD(EntityBus data)
        {
            int process = 0;
            try
            {
                SqlCommand busCon = new SqlCommand("BusAdd", OtherConnection.con);
                busCon.CommandType = CommandType.StoredProcedure;

                if (busCon.Connection.State != ConnectionState.Open)
                {
                    busCon.Connection.Open();
                }
                busCon.Parameters.AddWithValue("BusName", data.BusName);
                busCon.Parameters.AddWithValue("BusPlate", data.BusPlate);
                busCon.Parameters.AddWithValue("BusLocation", data.BusLocation);
                busCon.Parameters.AddWithValue("BusDestination", data.BusDestination);
                busCon.Parameters.AddWithValue("StaffID", data.StaffID);
                process = busCon.ExecuteNonQuery();
            }
            catch
            {

                process = -1;
            }
            return process;
        }
        public static DataTable ListIt()
        {
            SqlDataAdapter adp = new SqlDataAdapter("BusList", OtherConnection.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Update(EntityBus process)
        {
            SqlCommand busCon = new SqlCommand("BusUpdate", OtherConnection.con);
            busCon.CommandType = CommandType.StoredProcedure;
            busCon.Parameters.AddWithValue("BusID", process.BusID);
            busCon.Parameters.AddWithValue("BusName", process.BusName);
            busCon.Parameters.AddWithValue("BusPlate", process.BusPlate);
            busCon.Parameters.AddWithValue("BusLocation", process.BusLocation);
            busCon.Parameters.AddWithValue("BusDestination", process.BusDestination);
            busCon.Parameters.AddWithValue("StaffID", process.StaffID);
            return OtherConnection.ExecuteNonQuery(busCon);
        }
        public static bool Delete(EntityBus process)
        {
            SqlCommand busCon = new SqlCommand("BusDelete", OtherConnection.con);
            busCon.CommandType = CommandType.StoredProcedure;
            busCon.Parameters.AddWithValue("@BusID", process.BusID);
            return OtherConnection.ExecuteNonQuery(busCon);
        }
    }
}
