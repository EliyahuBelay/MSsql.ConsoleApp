using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office.MSsql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workerList = new List<Worker>();
            string stringConnection = "Data Source=LAPTOP-HG30JHU1;Initial Catalog=OfficeDB;Integrated Security=True;Pooling=False";

            //GetAllTableData(stringConnection);
            //AddWorkerToTable(stringConnection);
            //UpdateRowInTable(stringConnection);
            //DeleteRowInTable(stringConnection);

            ////////////////////////////////////////////////////////////
            
            List<Manager> managerList = new List<Manager>();
            //GetAllTableData2(stringConnection);
            //AddWorkerToTable2(stringConnection);
            //UpdateRowInTable2(stringConnection);
            //DeleteRowInTable2(stringConnection);
            ////////////////////////////////////////////////////////////
            
            List<ContractorWorker> ContractorWorkerList = new List<ContractorWorker>();
            //GetAllTableData3(stringConnection);
            //AddWorkerToTable3(stringConnection);
            //UpdateRowInTable3(stringConnection);
            //DeleteRowInTable3(stringConnection);

        }

        private static void GetAllTableData(string stringConnection)
        {
            try
            {

                using (SqlConnection conection = new SqlConnection(stringConnection))
                {
                    conection.Open();
                    string query = @"SELECT * FROM Worker";
                    SqlCommand command = new SqlCommand(query, conection);
                    SqlDataReader dataFromDB = command.ExecuteReader();
                    if (dataFromDB.HasRows)
                    {
                        while (dataFromDB.Read())
                        {
                            Console.WriteLine($"{dataFromDB.GetString(1)} ");
                            Console.WriteLine($"{dataFromDB.GetDateTime(2)} ");
                            Console.WriteLine(dataFromDB.GetString(3));
                            Console.WriteLine(dataFromDB.GetInt32(4));
                            Console.WriteLine("----------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("there is no rows in the data base");
                    }
                    conection.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception) { Console.WriteLine("there is some problem in the process"); }
            Console.ReadLine();
        }
        private static void AddWorkerToTable(string stringConnection)
        {
            Console.WriteLine("put name");
            string name = Console.ReadLine();
            Console.WriteLine("put birth date");
            string birthDate = Console.ReadLine();
            Console.WriteLine("put mail");
            string mail = Console.ReadLine();
            Console.WriteLine("put payment");
            int payment = int.Parse(Console.ReadLine());

            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"INSERT INTO Worker(Name,BirthDate,Mail,Payment) VALUES ('{name}','{birthDate}','{mail}',{payment})";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowEffected} row effected ");
                    connection.Close();
                }

            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            catch (Exception) { Console.WriteLine("there is some problem in the process"); }
            Console.ReadLine();
        }
        private static void UpdateRowInTable(string stringConnection)
        {
            Console.WriteLine("put name");
            string name = Console.ReadLine();
            Console.WriteLine("put birth date");
            string birthDate = Console.ReadLine();
            Console.WriteLine("put mail");
            string mail = Console.ReadLine();
            Console.WriteLine("put payment");
            int payment = int.Parse(Console.ReadLine());
            Console.WriteLine("put the exact id");
            int id = int.Parse(Console.ReadLine());
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"UPDATE Worker SET Name = '{name}',BirthDate = '{birthDate}',Mail = '{mail}',Payment = '{payment}' WHERE Id = {id}";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowEffected} row effected");
                    connection.Close();
                }
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            catch (ArgumentOutOfRangeException) { Console.WriteLine("id not found"); }
            catch (Exception) { Console.WriteLine("there is some problem in the process"); }
            Console.ReadLine();
        }
        private static void DeleteRowInTable(string stringConnection)
        {
            Console.WriteLine("put id");
            int id = int.Parse(Console.ReadLine());
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"DELETE FROM Worker WHERE Id = {id}";
                    SqlCommand command = new SqlCommand(query, connection);
                    int rowEffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowEffected} row effected");
                    connection.Close();
                }
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            catch (Exception) { Console.WriteLine("there is some problem in the process"); }
            Console.ReadLine();
        }


        /////////////////////////////////////////////////////////////////////

        private static void GetAllTableData2(string stringConnection)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Mamager";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataFromDB = command.ExecuteReader();
                    if (dataFromDB.HasRows)
                    {
                        while (dataFromDB.Read())
                        {
                            Console.WriteLine(dataFromDB.GetString(1));
                            Console.WriteLine(dataFromDB.GetString(2));
                            Console.WriteLine(dataFromDB.GetDateTime(3));
                            Console.WriteLine(dataFromDB.GetString(4));
                            Console.WriteLine(dataFromDB.GetString(5));
                            Console.WriteLine("----------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("there is no rows in the data base");
                    }
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception) { Console.WriteLine("there is some problem in the process"); }
            Console.ReadLine();
        }
        private static void AddWorkerToTable2(string stringConnection)
        {
            Console.WriteLine("put first name");
            string fname = Console.ReadLine();
            Console.WriteLine("put last name");
            string lname = Console.ReadLine();
            Console.WriteLine("put birth date");
            string birthDate = Console.ReadLine();
            Console.WriteLine("put mail");
            string mail = Console.ReadLine();
            Console.WriteLine("put section");
            string section = Console.ReadLine();
            try
            {

                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"INSERT INTO Manager(firstName,lastName,birthDate,mail,section) VALUES ('{fname}','{lname}','{birthDate}','{mail}','{section}')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowEffected} row effected ");
                    connection.Close();
                }
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            catch (Exception) { Console.WriteLine("there is some problem in the process"); }
            Console.ReadLine();
        }
        private static void UpdateRowInTable2(string stringConnection)
        {
            Console.WriteLine("put first name");
            string fname = Console.ReadLine();
            Console.WriteLine("put last name");
            string lname = Console.ReadLine();
            Console.WriteLine("put birth date");
            string birthDate = Console.ReadLine();
            Console.WriteLine("put mail");
            string mail = Console.ReadLine();
            Console.WriteLine("put section");
            string section = Console.ReadLine();
            Console.WriteLine("put exact id");
            int id = int.Parse(Console.ReadLine());
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"UPDATE Manager SET firstName = '{fname}',lastName = '{lname}',birthDate = '{birthDate}',mail='{mail}',section = '{section}' WHERE Id = {id}";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowEffected} row effected");
                    connection.Close();
                }
            }
            catch(SqlException ex) { Console.Write(ex.Message); }
            catch(Exception) { Console.WriteLine("there is some problem in the process"); }
            Console.ReadLine();
        }
        private static void DeleteRowInTable2(string stringConnection)
        {
            Console.WriteLine("put id");
            int id = int.Parse(Console.ReadLine());
            try
            {
                using(SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"DELETE FROM Manager WHERE Id = {id}";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowEffected} row effected");
                    connection.Close();
                }
            }
            catch(SqlException ex) { Console.Write(ex.Message); }
            catch (Exception) { Console.WriteLine("there is problem in the process"); }
            Console.ReadLine ();
        }


        /////////////////////////////////////////////////////////////////////


        private static void GetAllTableData3(string stringConnection)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = @"SELECT * FROM contractorWorker";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader dataFromDB = command.ExecuteReader();
                    if (dataFromDB.HasRows)
                    {
                        while (dataFromDB.Read())
                        {
                            Console.WriteLine(dataFromDB.GetString(1));
                            Console.WriteLine(dataFromDB.GetString(2));
                            Console.WriteLine(dataFromDB.GetString(3));
                            Console.WriteLine(dataFromDB.GetString(4));
                            Console.WriteLine("----------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("there is no rows in the data base");
                    }
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception) { Console.WriteLine("there is some problem in the process"); }
            Console.ReadLine();
        }
        private static void AddWorkerToTable3(string stringConnection)
        {
            Console.WriteLine("put full name");
            string fullname = Console.ReadLine();
            Console.WriteLine("put number worker");
            string numberWorker = Console.ReadLine();
            Console.WriteLine("put mail");
            string mail = Console.ReadLine();
            Console.WriteLine("put name of company");
            string companyName = Console.ReadLine();
            try
            {

                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"INSERT INTO contractorWorker(fullName,numberWorker,mail,companyName) VALUES ('{fullname}','{numberWorker}','{mail}','{companyName}')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowEffected} row effected ");
                    connection.Close();
                }
            }
            catch (SqlException ex) { Console.WriteLine(ex.Message); }
            catch (Exception) { Console.WriteLine("there is some problem in the process"); }
            Console.ReadLine();
        }
        private static void UpdateRowInTable3(string stringConnection)
        {
            Console.WriteLine("put full name");
            string fullName = Console.ReadLine();
            Console.WriteLine("put number of worker ");
            string numberWorker = Console.ReadLine();
            Console.WriteLine("put mail");
            string mail = Console.ReadLine();
            Console.WriteLine("put name of company");
            string companyName = Console.ReadLine();
            Console.WriteLine("put exact id");
            int id = int.Parse(Console.ReadLine());
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"UPDATE contractorWorker SET fullName = '{fullName}',numberWorker = '{numberWorker}',mail='{mail}',companyName = '{companyName}' WHERE Id = {id}";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowEffected} row effected");
                    connection.Close();
                }
            }
            catch (SqlException ex) { Console.Write(ex.Message); }
            catch (Exception) { Console.WriteLine("there is some problem in the process"); }
            Console.ReadLine();
        }
        private static void DeleteRowInTable3(string stringConnection)
        {
            Console.WriteLine("put id");
            int id = int.Parse(Console.ReadLine());
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"DELETE FROM contractorWorker WHERE Id = {id}";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowEffected} row effected");
                    connection.Close();
                }
            }
            catch (SqlException ex) { Console.Write(ex.Message); }
            catch (Exception) { Console.WriteLine("there is problem in the process"); }
            Console.ReadLine();
        }
    }
}
