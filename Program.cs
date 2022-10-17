// See https://aka.ms/new-console-template for more information
using PCIS;
using PCIS.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Text;




internal class Program
{
    private static async Task Main(string[] args)
    {
        using (SqlConnection connection = LibraryDBSingleton.GetSingleton.SqlConnection)
        {
            connection.OpenAsync();

            while (true)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Select Users with books");               
                int key;
                int.TryParse(Console.ReadLine(), out key);

                switch (key)
                {
                    case 0:
                        connection.Close();
                        return;
                    case 1:
                        command.CommandText = "SELECT Person.id,Person.firstname,Person.middlename,Person.lastname,Person.adress,Person.birthday,Person.phone_number,Book.book_name,Book.price,Author.firstname as AuthorFirstName,Author.lastname as AuthorLastName,BooksOutOfStorage.give_away_time,BooksOutOfStorage.take_away_time,BooksOutOfStorage.is_returned FROM Book INNER JOIN BooksOutOfStorage ON Book.id = BooksOutOfStorage.book_id INNER JOIN LibraryUser ON LibraryUser.id = BooksOutOfStorage.library_user_id INNER JOIN Person ON Person.id = LibraryUser.person_id INNER JOIN Author ON Author.id = Book.author_id ORDER BY Person.firstname,Person.middlename,Person.lastname";
                        SqlDataReader reader = await command.ExecuteReaderAsync();

                        Console.WriteLine("\tFirstName\tMiddleName\tLastName\tAdress\tBirthday\tPhoneNumber\tBookName\tBookPrice\tAuthorFirstName\tAuthorLastName\tGiveTime\tGetTime\tIsReturned");

                        while(await reader.ReadAsync())
                        {
                            Console.WriteLine($"" +
                                $"\t{reader["firstname"]}" +
                                $"\t{reader["middlename"]}" +
                                $"\t{reader["lastname"]}" +
                                $"\t{reader["adress"]}" +
                                $"\t{reader["birthday"]}" +
                                $"\t{reader["phone_number"]}" +
                                $"\t{reader["book_name"]}" +
                                $"\t{reader["price"]}" +
                                $"\t{reader["AuthorFirstName"]}" +
                                $"\t{reader["AuthorLastName"]}" +
                                $"\t{reader["give_away_time"]}" +
                                $"\t{reader["take_away_time"]}" +
                                $"\t{reader["is_returned"]}");
                        }
                        break;
                    default:
                        break;
                }
            }

            connection.Close();
        }

        
    }
}