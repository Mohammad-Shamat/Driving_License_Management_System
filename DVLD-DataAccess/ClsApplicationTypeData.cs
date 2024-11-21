using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class ClsApplicationTypeData
    {
        public static bool GetApplicationTypeInfoByID(int AppTypeID, ref string AppTypeTitle, ref float AppFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"Select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";
            SqlCommand sqlCommand = new SqlCommand(Query, connection);
            sqlCommand.Parameters.AddWithValue("@ApplicationTypeID", AppTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    AppTypeTitle = (string)reader["ApplicationTypeTitle"];
                    AppFees = Convert.ToSingle(reader["ApplicationFees"]);

                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                IsFound = false;
            }
            finally { connection.Close(); }

            return IsFound;
        }
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"Select * from ApplicationTypes order by ApplicationTypeTitle";
            SqlCommand sqlCommand = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)

                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                // Console.WriteLine("Error: " + ex.Message);
            }
            finally { connection.Close(); }

            return dt;
        }

        public static int AddNewApplicationType(string Title, float Fees)
        {
            int AppID = -1;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"Insert Into ApplicationTypes (ApplicationTypeTitle,ApplicationFees)
                            Values (@Title,@Fees)
                            
                            SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Fees", Fees);
            try
            {
                connection.Open();
                object result= cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out int AppTypeID))
                {
                    AppID = AppTypeID;
                }
            }
            catch (Exception ex)
            {
                AppID = -1;


            }finally { connection.Close(); }

            return AppID;
        }
        public static bool UpdateApplictionType(int ApplicationTypeID, string Title, float Fees)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"Update  ApplicationTypes  
                            set ApplicationTypeTitle = @Title,
                                ApplicationFees = @Fees
                                where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fees", Fees);
            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery() ;

            }
            catch (Exception ex)
            {

                rowAffected = 0;
            }
            finally { connection.Close(); }
            return (rowAffected>0);
        }

    }
}
