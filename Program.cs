using System.Data.SqlClient;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using (SqlConnection connection = new SqlConnection("Server=localhost;Database=Library;Trusted_Connection=True;"))
        {
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "SELECT Person.Id,Person.Firstname,Person.Middlename,Person.Lastname,Person.Adress,Person.Birthday,Person.PhoneNumber,Book.BookName,Book.Price,Author.Firstname as AuthorFirstName,Author.Lastname as AuthorLastName,BookOutOfStorage.GiveAwayTime,BookOutOfStorage.TakeAwayTime,BookOutOfStorage.IsReturned FROM Book INNER JOIN BookOutOfStorage ON Book.Id = BookOutOfStorage.BookId INNER JOIN LibraryUser ON LibraryUser.Id = BookOutOfStorage.LibraryUserId INNER JOIN Person ON Person.Id = LibraryUser.PersonId INNER JOIN Author ON Author.Id = Book.AuthorId ORDER BY Person.Firstname,Person.Middlename,Person.Lastname";

            SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();

            Console.WriteLine("\tFirstName\tMiddleName\tLastName\tAdress\tBirthday\tPhoneNumber\tBookName\tBookPrice\tAuthorFirstName\tAuthorLastName\tGiveTime\tGetTime\tIsReturned");

            while (await reader.ReadAsync())
            {
                Console.WriteLine($"" +
                    $"\t{reader["Firstname"]}" +
                    $"\t{reader["Middlename"]}" +
                    $"\t{reader["Lastname"]}" +
                    $"\t{reader["Adress"]}" +
                    $"\t{reader["Birthday"]}" +
                    $"\t{reader["PhoneNumber"]}" +
                    $"\t{reader["BookName"]}" +
                    $"\t{reader["Price"]}" +
                    $"\t{reader["AuthorFirstName"]}" +
                    $"\t{reader["AuthorLastName"]}" +
                    $"\t{reader["GiveAwayTime"]}" +
                    $"\t{reader["TakeAwayTime"]}" +
                    $"\t{reader["IsReturned"]}");
            }

            connection.Close();
        }



    }
}