using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class ClsCountryData
    {
        public static bool GetCountryInfoByID(int Id, ref string CountryName)

        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);

            string Quary = "SELECT Countries.* FROM Countries WHERE Countries.CountryID = @CountryID";
            SqlCommand command = new SqlCommand(Quary, connection);
            command.Parameters.AddWithValue("@CountryID", Id);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    CountryName = (string)reader["CountryName"];
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
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool GetCountryInfoByName(string CountryName, ref int Id)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);

            string Query = "SELECT Countries.* FROM Countries WHERE Countries.CountryName= @CountryName";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    Id = (int)reader["CountryID"];
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
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static DataTable GetAllCountries()
        {
            DataTable Dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = "SELECT Countries.* FROM Countries order by CountryName";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    Dt.Load(reader);
                }
                reader.Close();
            }

            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return Dt;
        }
    }
}
