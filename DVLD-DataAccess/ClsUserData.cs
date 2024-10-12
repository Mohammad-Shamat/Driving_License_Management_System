using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class ClsUserData
    {
        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName,
            ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection sqlConnection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = "select Users.* from Users where Users.UserID =@UserID";
            SqlCommand cmd = new SqlCommand(Query, sqlConnection);
            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];

                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isFound;
        }
        public static bool GetUserInfoByPersonID(ref int UserID, int PersonID, ref string UserName,
            ref string Password, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection sqlConnection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"select Users.* from Users where Users.PersonID = @PersonID";

            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];

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
                sqlConnection.Close();
            }

            return IsFound;
        }

        public static bool GetUserInfoByUserNameAndPassword(ref int UserID, ref int PersonID, string UserName,
             string Password, ref bool IsActive)
        {
            bool isFound = false;
            SqlConnection sqlConnection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = "select Users.* from Users where Users.UserName = @UserName and Users.Password= @Password";
            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserName", UserName);
            sqlCommand.Parameters.AddWithValue("@Password", Password);
            try
            {
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];
                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                sqlConnection.Close();
            }

            return isFound;
        }

        public static int AddNewUser(int PersonID, string UserName,
             string Password, bool IsActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"insert into Users(PersonID,UserName,Password,IsActive)
                            values
                            (@PersonID,@UserName,@Password,@IsActive);
                            SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int UserIDFromDB))
                {
                    UserID = UserIDFromDB;
                }
            }
            catch
            {
                UserID = -1;
            }
            finally
            {
                connection.Close();
            }

            return UserID;
        }
        public static bool UpdateUser(int UserID, int PersonID, string UserName,
             string Password, bool IsActive)
        {
            int rowAffected = 0;
            SqlConnection conn = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"Update Users
                           set PersonID = @PersonID, 
                               UserName = @UserName,
                               Password = @Password,
                               IsActive = @IsActive
                               where UserID = @UserID";
            SqlCommand command = new SqlCommand(Query, conn);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                conn.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return (rowAffected > 0);
        }

        public static DataTable GetAllUsers()
        {
            DataTable DTAllUsers = new DataTable();
            SqlConnection conn = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"SELECT  Users.UserID, Users.PersonID,
                            FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL( People.ThirdName,'') +' ' + People.LastName,
                             Users.UserName, Users.IsActive
                             FROM  Users INNER JOIN
                                    People ON Users.PersonID = People.PersonID";

            SqlCommand cmd = new SqlCommand(Query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(); 
                if (reader.HasRows)
                {
                    DTAllUsers.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) 
            {

            }
            finally
            { 
                conn.Close();
            }
            return DTAllUsers;
        }

        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = -1;
            SqlConnection conn = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Qurey = @"Delete Users where Users.UserID = @UserID";
            SqlCommand cmd = new SqlCommand(Qurey, conn);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
            }
            finally 
            {
                conn.Close(); 
            }
            return (rowsAffected > 0);

        }

        public static bool IsUserExistByUserID(int UserID)
        {
            bool IsFound = false;
            SqlConnection conn = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"Select found=1 from users where Users.UserID = @UserID";
            SqlCommand sqlCommand = new SqlCommand(Query, conn);
            sqlCommand.Parameters.AddWithValue("@UserID",UserID);
            try
            {
                conn.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                IsFound = sqlDataReader.HasRows;
                sqlDataReader.Close();
            }
            catch (Exception ex) 
            {
                IsFound = false;
            }
            finally
            { 
                conn.Close();
            }
            return  IsFound;
        }
        public static bool IsUserExistByUserName(string UserName)
        {
            bool IsFound = false;
            SqlConnection conn = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"Select found=1 from users where Users.UserName = @UserName";
            SqlCommand sqlCommand = new SqlCommand(Query, conn);
            sqlCommand.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                conn.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                IsFound = sqlDataReader.HasRows;
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                conn.Close();
            }
            return IsFound;
        }
        public static bool IsUserExistByPersonID(int PersonID)
        {
            bool IsFound = false;
            SqlConnection conn = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"Select found=1 from users where Users.PersonID = @PersonID";
            SqlCommand sqlCommand = new SqlCommand(Query, conn);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                conn.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                IsFound = sqlDataReader.HasRows;
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                conn.Close();
            }
            return IsFound;
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            int rowAffected = 0;
            SqlConnection conn = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"Update Users 
                             Set Users.Password = @Password 
                             where Users.UserID = @UserID";
            SqlCommand sqlCommand = new SqlCommand( Query, conn);
            sqlCommand.Parameters.AddWithValue("@Password", NewPassword);
            sqlCommand.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                conn.Open();
                rowAffected = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return (rowAffected > 0);
        }



    }

}
