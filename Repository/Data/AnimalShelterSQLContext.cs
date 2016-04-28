using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;

namespace Repository.Data
{
    public class AnimalShelterSQLContext : IAnimalShelterContext
    {
        private static string connectionString =
            "server=localhost;uid=fontys;" +
            "pwd=fontys;database=se2;";

        private MySqlCommand NewCommand(string query)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            return cmd;
        }

        public List<Animal> GetAllAnimals()
        {
            string query = "SELECT A.*, R.Name AS ReservorName, R.ReservedAt" +
                           " FROM Animal A LEFT JOIN Reservor R ON A.Reservor = R.Id";

            List<Animal> animals = new List<Animal>();

            using (MySqlCommand cmd = this.NewCommand(query))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Animal animal = this.CreateAnimalFromReader(reader);
                    if (animal != null)
                    {
                        Reservor reservor = null;
                        if (reader["Reservor"] != DBNull.Value)
                        {
                            reservor = new Reservor(
                                Convert.ToInt32(reader["Reservor"]),
                                Convert.ToString(reader["ReservorName"]),
                                Convert.ToDateTime(reader["ReservedAt"]));
                        }

                        animal.Reserve(reservor);
                        animals.Add(animal);
                    }
                }
            }

            return animals;
        }

        public void SaveAnimal(Animal animal)
        {
            string query = animal.Id == -1
                ? "INSERT INTO Animal (Type, Name, Gender, BadHabits, LastWalk, Reservor)" +
                  " VALUES (@type, @name, @gender, @badhabits, @lastwalk, @reservor)"
                : "UPDATE Animal SET Type=@type, Name=@name, Gender=@gender," +
                  " BadHabits=@badhabits, LastWalk=@lastwalk, Reservor=@reservor" +
                  " WHERE Id=@id";

            using (MySqlCommand cmd = this.NewCommand(query))
            {
                if (animal.ReservedBy != null)
                {
                    this.SaveReservor(animal.ReservedBy);
                    cmd.Parameters.AddWithValue("reservor", animal.ReservedBy.Id);
                }
                else
                {
                    cmd.Parameters.AddWithValue("reservor", DBNull.Value);
                }

                if (animal.Id != -1)
                {
                    cmd.Parameters.AddWithValue("id", animal.Id);
                }
                cmd.Parameters.AddWithValue("name", animal.Name);
                cmd.Parameters.AddWithValue("type", animal is Cat ? "Cat" : "Dog");
                cmd.Parameters.AddWithValue("gender", Convert.ToString(animal.Gender));
                if (animal is Cat)
                {
                    cmd.Parameters.AddWithValue("badhabits", (animal as Cat).BadHabits);
                    cmd.Parameters.AddWithValue("lastwalk", DBNull.Value);
                }
                else if (animal is Dog)
                {
                    cmd.Parameters.AddWithValue("badhabits", DBNull.Value);
                    cmd.Parameters.AddWithValue("lastwalk", (animal as Dog).LastWalk);
                }

                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (animal.Id == -1)
                {
                    string idQuery = "SELECT LAST_INSERT_ID();";
                    using (MySqlCommand idCmd = NewCommand(idQuery))
                    {
                        int idResult = Convert.ToInt32(idCmd.ExecuteScalar());
                        animal.Id = idResult;
                    }
                }
            }
        }

        public void SaveReservor(Reservor reservor)
        {
            string query = reservor.Id == -1
                ? "INSERT INTO Reservor (Name, ReservedAt)" +
                  " VALUES (@name, @reservedAt)"
                : "UPDATE Reservor SET Name=@name, ReservedAt=@reservedAt WHERE Id=@id";

            using (MySqlCommand cmd = this.NewCommand(query))
            {
                if (reservor.Id != -1)
                {
                    cmd.Parameters.AddWithValue("id", reservor.Id);
                }
                cmd.Parameters.AddWithValue("name", reservor.Name);
                cmd.Parameters.AddWithValue("reservedAt", reservor.ReservedAt);

                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (reservor.Id == -1)
                {
                    string idQuery = "SELECT LAST_INSERT_ID();";
                    using (MySqlCommand idCmd = NewCommand(idQuery))
                    {
                        int idResult = Convert.ToInt32(idCmd.ExecuteScalar());
                        reservor.Id = idResult;
                    }
                }
            }
        }

        private Animal CreateAnimalFromReader(MySqlDataReader reader)
        {
            switch (Convert.ToString(reader["Type"]))
            {
                case "Cat":
                    return new Cat(
                        Convert.ToInt32(reader["Id"]),
                        Convert.ToString(reader["Name"]),
                        (Gender) Enum.Parse(typeof(Gender), Convert.ToString(reader["Gender"])),
                        Convert.ToString(reader["BadHabits"]));

                case "Dog":
                    return new Dog(
                        Convert.ToInt32(reader["Id"]),
                        Convert.ToString(reader["Name"]),
                        (Gender) Enum.Parse(typeof(Gender), Convert.ToString(reader["Gender"])),
                        Convert.ToDateTime(reader["LastWalk"]));
            }

            return null;
        }
    }
}