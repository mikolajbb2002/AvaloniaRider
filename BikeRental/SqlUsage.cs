using System;
namespace BikeRental;
using System.Data.SQLite;

public class SqlUsage
{
    public static void AddUserToDatabase(string name, string surname, string pesel, string city, string street)
    {
        // Łączymy się z bazą danych SQLite
        string connectionString = "Data Source=BikeRental.db;Version=3;";
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            // Wstawiamy dane do tabeli
            string insertQuery =
                "INSERT INTO USer (Name, Surname, Pesel, CIty, Street) VALUES (@Name, @Surname, @PESEL, @City, @Street)";
            using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@Name", name);
                insertCommand.Parameters.AddWithValue("@Surname", surname);
                insertCommand.Parameters.AddWithValue("@PESEL", pesel);
                insertCommand.Parameters.AddWithValue("@City", city);
                insertCommand.Parameters.AddWithValue("@Street", street);

                insertCommand.ExecuteNonQuery();
            }

            Console.WriteLine(insertQuery);
            connection.Close();
        }
    }

    public static void AddRentalToDatabase(string FrameSize, string WheelSize, string Date)
    {
        string connectionString = "Data Source=BikeRental.db;Version=3;";
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string insertQuery =
                "INSERT INTO Rental (FrameSize, WheelSize, Date) VALUES (@FrameSize, @WheelSize, @Date)";
            using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@FrameSize", FrameSize);
                insertCommand.Parameters.AddWithValue("@WheelSize", WheelSize);
                insertCommand.Parameters.AddWithValue("@Date", Date);


                insertCommand.ExecuteNonQuery();
            }

            Console.WriteLine(insertQuery);
            connection.Close();
        }
    }
}
