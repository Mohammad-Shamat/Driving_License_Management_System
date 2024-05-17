using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class ClsPersonData
    {
        public static bool GetPersonInfoByID(int Id, ref string FirstName, ref string SecondName
            , ref string ThirdName, ref string LastName
            , ref string NationalNo, ref DateTime DateOfBrith, ref short Gendor, ref string Address,
            ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = "SELECT * FROM People WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@PersonID", Id);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];

                    if (Reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)Reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = (string)Reader["LastName"];
                    DateOfBrith = (DateTime)Reader["DateOfBirth"];
                    Gendor = (byte)Reader["Gendor"];
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];

                    if (Reader["Email"] != DBNull.Value)
                    {
                        Email = (string)Reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    NationalNo = (string)Reader["NationalNo"];
                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    if (Reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }


                }
                else
                {
                    IsFound = false;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static bool GetPersonInfoByNationalNo(ref int Id, string NationalNo, ref string FirstName
            , ref string SecondName, ref string ThirdName, ref string LastName
            , ref DateTime DateOfBrith, ref short Gendor, ref string Address,
            ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {

            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = "SELECT People.* FROM People WHERE People.NationalNo =@NationalNo";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    Id = (int)Reader["PersonID"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    if (Reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)Reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }
                    LastName = (string)Reader["LastName"];
                    DateOfBrith = (DateTime)Reader["DateOfBirth"];
                    Gendor = (byte)Reader["Gendor"];
                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];

                    if (Reader["Email"] != DBNull.Value)
                    {
                        Email = (string)Reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }
                    NationalityCountryID = (int)Reader["NationalityCountryID"];

                    if (Reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }


                }
                else
                {
                    IsFound = false;
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static int AddNewPerson(
            string NationalNo, string FirstName
            , string SecondName, string ThirdName, string LastName
            , DateTime DateOfBrith, short Gendor, string Address,
             string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int PersonId = -1;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"INSERT INTO People (FirstName, SecondName, ThirdName,LastName,NationalNo,
                             DateOfBirth,Gendor,Address,Phone, Email, NationalityCountryID,ImagePath)
                             VALUES (@FirstName, @SecondName,@ThirdName, @LastName, @NationalNo,
                                     @DateOfBirth,@Gendor,@Address,@Phone, @Email,@NationalityCountryID,@ImagePath);
                                       SELECT SCOPE_IDENTITY(); ";

            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != string.Empty && ThirdName != null)
            {
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                Command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }



            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBrith);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != string.Empty && Email != null)
            {
                Command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                Command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (ImagePath != null && ImagePath != string.Empty)
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                Command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            }

            try
            {
                connection.Open();
                object result = Command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertId))
                {
                    PersonId = InsertId;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                connection.Close();

            }
            return PersonId;
        }

        public static bool UpdatePerson(int Id, string NationalNo, string FirstName
            , string SecondName, string ThirdName, string LastName
            , DateTime DateOfBrith, short Gendor, string Address,
             string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);

            string Query = @"UPDATE People SET 
                             FirstName = @FirstName,
                                SecondName = @SecondName,
                                ThirdName = @ThirdName,
                                LastName = @LastName, 
                                NationalNo = @NationalNo,
                                DateOfBirth = @DateOfBirth,
                                Gendor=@Gendor,
                                Address = @Address,  
                                Phone = @Phone,
                                Email = @Email, 
                                NationalityCountryID = @NationalityCountryID,
                                ImagePath =@ImagePath
                                where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", Id);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "" && ThirdName != null)
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                cmd.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);


            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBrith);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

            if (Email != string.Empty && Email != null)
                cmd.Parameters.AddWithValue("@Email", Email);
            else
                cmd.Parameters.AddWithValue("@Email", System.DBNull.Value);

            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "" && ImagePath != null)
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);
        }

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);

            string Query = @"SELECT People.PersonID, People.NationalNo,
              People.FirstName, People.SecondName, People.ThirdName, People.LastName,
			  People.DateOfBirth, People.Gendor,  
				  CASE
                  WHEN People.Gendor = 0 THEN 'Male'

                  ELSE 'Female'

                  END as GendorCaption ,
			  People.Address, People.Phone, People.Email, 
              People.NationalityCountryID, Countries.CountryName, People.ImagePath
              FROM            People INNER JOIN
                         Countries ON People.NationalityCountryID = Countries.CountryID
                ORDER BY People.FirstName";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return dt;
        }

        public static bool DeleteAperson(int PersonID)
        {
            int RowsAffected = 0;

            SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"Delete People where PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                Connection.Open();
                RowsAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //RowsAffected = 0;
            }
            finally
            {
                Connection.Close();
            }
            return (RowsAffected > 0);

        }

        public static bool IsPersonExist(int PersonID)
        {
            bool IsExist = false;
            SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);
            string Query = @"SELECT Found=1 FROM People WHERE People.PersonID = @PersonId";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@PersonId", PersonID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsExist = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex)
            {
                IsExist = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsExist;
        }

        public static bool IsPersonExist(string NationalNo)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(ClsDataAccessSettings.ConnectionDataBase);

            string Query = @"SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                IsFound = Reader.HasRows;

                Reader.Close();
            }
            catch (Exception ex)
            {

                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

    }
}
