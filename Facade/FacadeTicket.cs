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
    public class FacadeTicket
    {
        public static int ADD(EntityTicket data)
        {
            int process = 0;
            try
            {
                SqlCommand ticketCon = new SqlCommand("TicketAdd", OtherConnection.con);
                ticketCon.CommandType = CommandType.StoredProcedure;

                if (ticketCon.Connection.State != ConnectionState.Open)
                {
                    ticketCon.Connection.Open();
                }
                ticketCon.Parameters.AddWithValue("TicketPrice", data.TicketPrice);
                ticketCon.Parameters.AddWithValue("TicketQty", data.TicketQty);
                ticketCon.Parameters.AddWithValue("BusID", data.BusID);
                process = ticketCon.ExecuteNonQuery();
            }
            catch
            {

                process = -1;
            }
            return process;
        }
        public static DataTable ListIt()
        {
            SqlDataAdapter adp = new SqlDataAdapter("TicketList", OtherConnection.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Update(EntityTicket process)
        {
            SqlCommand ticketCon = new SqlCommand("TicketUpdate", OtherConnection.con);
            ticketCon.CommandType = CommandType.StoredProcedure;
            ticketCon.Parameters.AddWithValue("TicketID", process.TicketID);
            ticketCon.Parameters.AddWithValue("TicketPrice", process.TicketPrice);
            ticketCon.Parameters.AddWithValue("TicketQty", process.TicketQty);
            ticketCon.Parameters.AddWithValue("BusID", process.BusID);
            return OtherConnection.ExecuteNonQuery(ticketCon);
        }
        public static bool Delete(EntityTicket process)
        {
            SqlCommand ticketCon = new SqlCommand("TicketDelete", OtherConnection.con);
            ticketCon.CommandType = CommandType.StoredProcedure;
            ticketCon.Parameters.AddWithValue("@TicketID", process.TicketID);
            return OtherConnection.ExecuteNonQuery(ticketCon);
        }
    }
}
