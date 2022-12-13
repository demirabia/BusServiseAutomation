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
    public class FacadeStaff
    {
        public static int ADD(EntityStaff data)
        {
            int process = 0;
            try
            {
                SqlCommand staffCon = new SqlCommand("StaffAdd", OtherConnection.con);
                staffCon.CommandType = CommandType.StoredProcedure;

                if (staffCon.Connection.State != ConnectionState.Open)
                {
                    staffCon.Connection.Open();
                }
                staffCon.Parameters.AddWithValue("StaffName", data.StaffName);
                staffCon.Parameters.AddWithValue("StaffMail", data.StaffMail);
                staffCon.Parameters.AddWithValue("StaffPhone", data.StaffPhone);
                staffCon.Parameters.AddWithValue("StaffPassword", data.StaffPassword);
                staffCon.Parameters.AddWithValue("UserID", data.UserID);
                process = staffCon.ExecuteNonQuery();
            }
            catch
            {

                process = -1;
            }
            return process;
        }
        public static DataTable ListIt()
        {
            SqlDataAdapter adp = new SqlDataAdapter("StaffList", OtherConnection.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Update(EntityStaff process)
        {
            SqlCommand staffCon = new SqlCommand("StaffUpdate", OtherConnection.con);
            staffCon.CommandType = CommandType.StoredProcedure;
            staffCon.Parameters.AddWithValue("StaffID", process.StaffID);
            staffCon.Parameters.AddWithValue("StaffName", process.StaffName);
            staffCon.Parameters.AddWithValue("StaffMail", process.StaffMail);
            staffCon.Parameters.AddWithValue("StaffPhone", process.StaffPhone);
            staffCon.Parameters.AddWithValue("StaffPassword", process.StaffPassword);
            staffCon.Parameters.AddWithValue("UserID", process.UserID);
            return OtherConnection.ExecuteNonQuery(staffCon);
        }
        public static bool Delete(EntityStaff process)
        {
            SqlCommand staffCon = new SqlCommand("StaffDelete", OtherConnection.con);
            staffCon.CommandType = CommandType.StoredProcedure;
            staffCon.Parameters.AddWithValue("@StaffID", process.StaffID);
            return OtherConnection.ExecuteNonQuery(staffCon);
        }
    }
}
