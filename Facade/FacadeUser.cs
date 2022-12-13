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
    public class FacadeUser
    {
        public static int ADD(EntityUser data)
        {
            int process = 0;
            try
            {
                SqlCommand userCon = new SqlCommand("UserAdd", OtherConnection.con);
                userCon.CommandType = CommandType.StoredProcedure;

                if (userCon.Connection.State != ConnectionState.Open)
                {
                    userCon.Connection.Open();
                }
                userCon.Parameters.AddWithValue("UserName", data.UserName);
                userCon.Parameters.AddWithValue("UserMail", data.UserMail);
                userCon.Parameters.AddWithValue("UserPhone", data.UserPhone);
                userCon.Parameters.AddWithValue("UserYear", data.UserYear);
                userCon.Parameters.AddWithValue("TicketID", data.TicketID);
                process=userCon.ExecuteNonQuery();
            }
            catch
            {

                process = -1;
            }
            return process;
        }
        public static DataTable ListIt()
        {
            SqlDataAdapter adp = new SqlDataAdapter("UserList", OtherConnection.con);
            adp.SelectCommand.CommandType=CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Update(EntityUser process)
        {
            SqlCommand userCon = new SqlCommand("UserUpdate",OtherConnection.con);
            userCon.CommandType = CommandType.StoredProcedure;
            userCon.Parameters.AddWithValue("UserID", process.UserID);
            userCon.Parameters.AddWithValue("UserName", process.UserName);
            userCon.Parameters.AddWithValue("UserMail", process.UserMail);
            userCon.Parameters.AddWithValue("UserPhone", process.UserPhone);
            userCon.Parameters.AddWithValue("UserYear", process.UserYear);
            userCon.Parameters.AddWithValue("TicketID", process.TicketID);
            return OtherConnection.ExecuteNonQuery(userCon);
        }
        public static bool Delete(EntityUser process)
        {
            SqlCommand userCon = new SqlCommand("UserDelete",OtherConnection.con);
            userCon.CommandType = CommandType.StoredProcedure;
            userCon.Parameters.AddWithValue("@UserID", process.UserID);
            return OtherConnection.ExecuteNonQuery(userCon);
        }
    }
}
