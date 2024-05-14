using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AnimalAdoption
{
    public class DbService
    {
        private string _connectionString;
        public DbService()
        {
            _connectionString = "User ID=postgres;Password=12345;Server=localhost;Port=5432;Database=AnimalAdoption;Pooling=true;";
        }

        public int Register(string username, string password, string firstName, string lastName, DateTime birthDate, string city, string address)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO public.\"User\" (\"Username\", \"Password\", \"Firstname\", \"Lastname\", \"BirthDate\", \"City\", \"Address\", \"UserTypeId\") VALUES (@username, @password, @firstName, @lastName, @birthDate, @city, @address, @userTypeId)";
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@birthDate", birthDate);
                        cmd.Parameters.AddWithValue("@city", city);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@userTypeId", 2);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public Dictionary<int, int> Login(string username, string password)
        {
            Dictionary<int, int> data = new Dictionary<int, int>();
            int userId = 0;
            int userTypeId = 0;
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT \"Id\", \"UserTypeId\" FROM \"User\" WHERE \"Username\" = @username AND \"Password\" = @password";
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // ExecuteScalar kullanarak UserTypeId'yi döndür
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userId = reader.GetInt32(0);
                                userTypeId = reader.GetInt32(1);
                            }
                        }
                        data.Add(userTypeId, userId);
                        return data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                data.Add(0, 0);
                return data;
            }
        }

        public DataTable GetUserDetails(int userId)
        {
            DataTable data = new DataTable();
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM \"User\" WHERE \"Id\" = @id";
                        cmd.Parameters.AddWithValue("@id", userId);

                        // ExecuteScalar kullanarak UserTypeId'yi döndür
                        using (var reader = cmd.ExecuteReader())
                        {
                            data.Load(reader);

                        }
                        return data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return data;
            }
        }

        public DataTable GetAnimalTypes()
        {
            DataTable data = new DataTable();
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM \"AnimalType\"";

                        // ExecuteScalar kullanarak UserTypeId'yi döndür
                        using (var reader = cmd.ExecuteReader())
                        {
                            data.Load(reader);

                        }
                        return data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return data;
            }
        }

        public int AddAnimalType(string code, string description)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO public.\"AnimalType\" (\"Code\", \"Description\") VALUES (@code, @description)";
                        cmd.Parameters.AddWithValue("@code", code);
                        cmd.Parameters.AddWithValue("@description", description);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int AddAnimal(string name, int age, string species, int typeId, string gender, bool isInfertile, bool isVaccinated, bool isAdopted)
        {
            // Veritabanı bağlantısını oluştur
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open(); // Bağlantıyı aç

                   // CREATE OR REPLACE FUNCTION public."InsertAnimal"(name character varying, age integer, species character varying, typeid character varying, gender character varying, isinfertile boolean, isvaccinated boolean, isadopted boolean)

                    // SQL komutunu oluştur
                    using (var cmd = new NpgsqlCommand("SELECT public.\"InsertAnimal\"(@Name, @Age, @Species, @TypeId, @Gender, @IsInfertile, @IsVaccinated, @IsAdopted)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Species", species);
                        cmd.Parameters.AddWithValue("@TypeId", typeId);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@IsInfertile", isInfertile);
                        cmd.Parameters.AddWithValue("@IsVaccinated", isVaccinated);
                        cmd.Parameters.AddWithValue("@IsAdopted", isAdopted);

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable GetAnimalsForAdmin(int? animalTypeId)
        {
            DataTable data = new DataTable();
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM \"Animal\" where  \"AnimalTypeId\" = @animalTypeId ";
                        cmd.Parameters.AddWithValue("@animalTypeId", animalTypeId);

                        // ExecuteScalar kullanarak UserTypeId'yi döndür
                        using (var reader = cmd.ExecuteReader())
                        {
                            data.Load(reader);

                        }
                        return data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return data;
            }
        }

        public int DeleteAnimal(int id)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "delete from \"Animal\" where \"Id\" = @id";
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla Silindi");
                        return rowsAffected;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }


}
