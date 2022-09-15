// See https://aka.ms/new-console-template for more information
using PCIS;
using PCIS.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Text;




internal class Program
{
    private static void Main(string[] args)
    {
        using (SqlConnection connection = LibraryDBSingleton.GetSingleton.SqlConnection)
        {
            connection.Open();
            Init(true);

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            while (true)
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("0 - Exit");
                builder.AppendLine("1 - Select Person table");
                builder.AppendLine("2 - Select LibraryUser table");
                builder.AppendLine("3 - Select Author table");
                builder.AppendLine("4 - Select Book table");
                builder.AppendLine("5 - Select BookOutStorage table");
                builder.AppendLine("6 - Select Storage table");
                Console.WriteLine(builder);
                int key = -1;
                int.TryParse(Console.ReadLine(), out key);

                switch (key)
                {
                    case 0:
                        connection.Close();
                        return;
                    case 1:
                        command.CommandText = "SELECT * FROM Person";
                        SqlDataReader reader = command.ExecuteReader();

                        Console.WriteLine($"{reader.GetName(0)}\t{reader.GetName(1)}\t{reader.GetName(2)}\t " +
                            $" {reader.GetName(3)}\t{reader.GetName(4)}\t{reader.GetName(5)}\t{reader.GetName(6)}\t");

                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader.GetValue(0)}\t{reader.GetValue(1)}\t{reader.GetValue(2)}\t{reader.GetValue(3)}\t " +
                                $" {reader.GetValue(4)}\t{reader.GetValue(5)}\t{reader.GetValue(6)}\t");
                        }
                        reader.Close();
                        break;
                    case 2:
                        command.CommandText = "SELECT * FROM LibraryUser";
                        SqlDataReader reader1 = command.ExecuteReader();

                        Console.WriteLine($"{reader1.GetName(0)}\t{reader1.GetName(1)}");

                        while (reader1.Read())
                        {
                            Console.WriteLine($"{reader1.GetValue(0)}\t{reader1.GetValue(1)}");
                        }
                        reader1.Close();
                        break;
                    case 3:
                        command.CommandText = "SELECT * FROM Author";
                        SqlDataReader reader2 = command.ExecuteReader();

                        Console.WriteLine($"{reader2.GetName(0)}\t{reader2.GetName(1)}\t{reader2.GetName(2)}");

                        while (reader2.Read())
                        {
                            Console.WriteLine($"{reader2.GetValue(0)}\t{reader2.GetValue(1)}\t{reader2.GetValue(2)}");
                        }
                        reader2.Close();
                        break;
                    case 4:
                        command.CommandText = "SELECT * FROM Book";
                        SqlDataReader reader3 = command.ExecuteReader();

                        Console.WriteLine($"{reader3.GetName(0)}\t{reader3.GetName(1)}\t{reader3.GetName(2)}\t{reader3.GetName(3)}");

                        while (reader3.Read())
                        {
                            Console.WriteLine($"{reader3.GetValue(0)}\t{reader3.GetValue(1)}\t{reader3.GetValue(2)}\t{reader3.GetValue(3)}");
                        }
                        reader3.Close();
                        break;
                    case 5:
                        command.CommandText = "SELECT * FROM BooksOutOfStorage";
                        SqlDataReader reader4 = command.ExecuteReader();

                        Console.WriteLine($"{reader4.GetName(0)}\t{reader4.GetName(1)}\t{reader4.GetName(2)}\t{reader4.GetName(3)}\t{reader4.GetName(4)}");

                        while (reader4.Read())
                        {
                            Console.WriteLine($"{reader4.GetValue(0)}\t{reader4.GetValue(1)}\t{reader4.GetValue(2)}\t{reader4.GetValue(3)}\t{reader4.GetValue(4)}");
                        }
                        reader4.Close();
                        break;
                    case 6:
                        command.CommandText = "SELECT * FROM Storage";
                        SqlDataReader reader5 = command.ExecuteReader();

                        Console.WriteLine($"{reader5.GetName(0)}\t{reader5.GetName(1)}\t{reader5.GetName(2)}");

                        while (reader5.Read())
                        {
                            Console.WriteLine($"{reader5.GetValue(0)}\t{reader5.GetValue(1)}\t{reader5.GetValue(2)}");
                        }
                        reader5.Close();
                        break;
                    default:
                        break;
                }
            }







            connection.Close();
        }

        void Init(bool clearValuesInTables = false)
        {
            List<Person> persons = new List<Person>();//
            persons.Add(
                new Person()
                {
                    Id = 1,
                    Adress = "380 Rae Stravenue Apt. 470",
                    Birthday = new DateTime(2000, 12, 1),
                    Firstname = "Ben",
                    Lastname = "Ben",
                    Middlename = "Ben",
                    PhoneNumber = "+1055331298"
                });
            persons.Add(
                new Person()
                {
                    Id = 2,
                    Adress = "9167 Purdy Drive",
                    Birthday = new DateTime(1998, 1, 5),
                    Firstname = "Mark",
                    Lastname = "Mark",
                    Middlename = "Mark",
                    PhoneNumber = "+1056661211"
                });
            persons.Add(
                new Person()
                {
                    Id = 3,
                    Adress = "736 Bauch Court",
                    Birthday = new DateTime(1989, 5, 6),
                    Firstname = "Stephan",
                    Lastname = "Stephan",
                    Middlename = "Stephan",
                    PhoneNumber = "+1076961241"
                });
            persons.Add(
                new Person()
                {
                    Id = 4,
                    Adress = "8004 Hegmann Village Suite 638",
                    Birthday = new DateTime(1976, 2, 16),
                    Firstname = "Bill",
                    Lastname = "Bill",
                    Middlename = "Bill",
                    PhoneNumber = "+1011561266"
                });
            persons.Add(
                new Person()
                {
                    Id = 5,
                    Adress = "4632 Stanton Flats",
                    Birthday = new DateTime(1999, 5, 13),
                    Firstname = "Mike",
                    Lastname = "Mike",
                    Middlename = "Mike",
                    PhoneNumber = "+1051263366"
                });
            persons.Add(
                new Person()
                {
                    Id = 6,
                    Adress = "145 Garrison Union Suite 256",
                    Birthday = new DateTime(2005, 1, 19),
                    Firstname = "Fin",
                    Lastname = "Fin",
                    Middlename = "Fin",
                    PhoneNumber = "+1077263767"
                });
            persons.Add(
                new Person()
                {
                    Id = 7,
                    Adress = "948 Rohan Glens Apt. 636",
                    Birthday = new DateTime(1967, 5, 5),
                    Firstname = "Josef",
                    Lastname = "Josef",
                    Middlename = "Josef",
                    PhoneNumber = "+1027222760"
                });

            List<User> users = new List<User>();//
            users.Add(new User() { Person = persons[0], Id = 1 });
            users.Add(new User() { Person = persons[1], Id = 2 });
            users.Add(new User() { Person = persons[2], Id = 3 });
            users.Add(new User() { Person = persons[3], Id = 4 });
            users.Add(new User() { Person = persons[4], Id = 5 });
            users.Add(new User() { Person = persons[5], Id = 6 });
            users.Add(new User() { Person = persons[6], Id = 7 });

            List<Author> authors = new List<Author>();
            authors.Add(new Author() { Id = 1, Firstname = "Ivanov", Lastname = "Ivan" });
            authors.Add(new Author() { Id = 2, Firstname = "Stepanov", Lastname = "Stepan" });
            authors.Add(new Author() { Id = 3, Firstname = "Stone", Lastname = "Bill" });
            authors.Add(new Author() { Id = 4, Firstname = "Hock", Lastname = "Ivan" });
            authors.Add(new Author() { Id = 5, Firstname = "Phines", Lastname = "Ferb" });

            List<Book> books = new List<Book>();
            books.Add(new Book() { Id = 1, Author = authors[0], Name = "Goliaf", Price = 17.50f });
            books.Add(new Book() { Id = 2, Author = authors[0], Name = "Goliaf 2", Price = 15f });
            books.Add(new Book() { Id = 3, Author = authors[1], Name = "Real Life", Price = 7.50f });
            books.Add(new Book() { Id = 4, Author = authors[2], Name = "Network", Price = 10f });
            books.Add(new Book() { Id = 5, Author = authors[3], Name = "Goverla", Price = 6f });
            books.Add(new Book() { Id = 6, Author = authors[2], Name = "Pineaple", Price = 20f });
            books.Add(new Book() { Id = 7, Author = authors[4], Name = "Terra", Price = 35f });

            List<Storage> storage = new List<Storage>();
            storage.Add(new Storage() { Book = books[0], AbsoluteAmount = 5, CurrentAmount = 3 });//
            storage.Add(new Storage() { Book = books[1], AbsoluteAmount = 10, CurrentAmount = 8 });//
            storage.Add(new Storage() { Book = books[2], AbsoluteAmount = 12, CurrentAmount = 10 });//
            storage.Add(new Storage() { Book = books[3], AbsoluteAmount = 5, CurrentAmount = 3 });//
            storage.Add(new Storage() { Book = books[4], AbsoluteAmount = 4, CurrentAmount = 2 });
            storage.Add(new Storage() { Book = books[5], AbsoluteAmount = 2, CurrentAmount = 0 });
            storage.Add(new Storage() { Book = books[6], AbsoluteAmount = 20, CurrentAmount = 18 });

            List<BooksOutStorage> booksOutStorage = new List<BooksOutStorage>();
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[0],
                User = users[0],
                GiveAwayTime = new DateTime(2022, 9, 10, 13, 20, 0),
                TakeAwayTime = new DateTime(2022, 9, 17, 13, 20, 0),
                IsReturned = false
            });//1
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[0],
                User = users[1],
                GiveAwayTime = new DateTime(2022, 9, 10, 14, 20, 0),
                TakeAwayTime = new DateTime(2022, 9, 17, 14, 20, 0),
                IsReturned = false
            });//2
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[1],
                User = users[0],
                GiveAwayTime = new DateTime(2022, 9, 10, 13, 20, 0),
                TakeAwayTime = new DateTime(2022, 9, 17, 13, 20, 0),
                IsReturned = false
            });//1
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[1],
                User = users[1],
                GiveAwayTime = new DateTime(2022, 9, 10, 14, 20, 0),
                TakeAwayTime = new DateTime(2022, 9, 17, 14, 20, 0),
                IsReturned = false
            });//2
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[2],
                User = users[2],
                GiveAwayTime = new DateTime(2022, 9, 20, 14, 20, 0),
                TakeAwayTime = new DateTime(2022, 9, 27, 14, 20, 0),
                IsReturned = false
            });//3
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[3],
                User = users[2],
                GiveAwayTime = new DateTime(2022, 9, 20, 14, 20, 0),
                TakeAwayTime = new DateTime(2022, 9, 27, 14, 20, 0),
                IsReturned = false
            });//4
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[2],
                User = users[3],
                GiveAwayTime = new DateTime(2022, 9, 20, 17, 20, 0),
                TakeAwayTime = new DateTime(2022, 9, 27, 17, 20, 0),
                IsReturned = false
            });//3
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[3],
                User = users[3],
                GiveAwayTime = new DateTime(2022, 9, 20, 17, 20, 0),
                TakeAwayTime = new DateTime(2022, 9, 27, 17, 20, 0),
                IsReturned = false
            });//4
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[4],
                User = users[4],
                GiveAwayTime = new DateTime(2022, 10, 1, 13, 20, 0),
                TakeAwayTime = new DateTime(2022, 10, 7, 13, 20, 0),
                IsReturned = false
            });//5
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[4],
                User = users[5],
                GiveAwayTime = new DateTime(2022, 10, 1, 13, 20, 0),
                TakeAwayTime = new DateTime(2022, 10, 7, 13, 20, 0),
                IsReturned = false
            });//6
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[5],
                User = users[5],
                GiveAwayTime = new DateTime(2022, 10, 1, 13, 20, 0),
                TakeAwayTime = new DateTime(2022, 10, 7, 13, 20, 0),
                IsReturned = false
            });//5
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[5],
                User = users[5],
                GiveAwayTime = new DateTime(2022, 10, 1, 13, 20, 0),
                TakeAwayTime = new DateTime(2022, 10, 7, 13, 20, 0),
                IsReturned = false
            });//6
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[4],
                User = users[6],
                GiveAwayTime = new DateTime(2022, 11, 1, 13, 20, 0),
                TakeAwayTime = new DateTime(2022, 11, 7, 13, 20, 0),
                IsReturned = false
            });//5
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[4],
                User = users[6],
                GiveAwayTime = new DateTime(2022, 11, 1, 13, 20, 0),
                TakeAwayTime = new DateTime(2022, 11, 7, 13, 20, 0),
                IsReturned = false
            });//7
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[0],
                User = users[6],
                GiveAwayTime = new DateTime(2022, 11, 1, 13, 20, 0),
                TakeAwayTime = new DateTime(2022, 11, 7, 13, 20, 0),
                IsReturned = false
            });//1
            booksOutStorage.Add(new BooksOutStorage()
            {
                Book = books[2],
                User = users[6],
                GiveAwayTime = new DateTime(2022, 11, 1, 13, 20, 0),
                TakeAwayTime = new DateTime(2022, 11, 7, 13, 20, 0),
                IsReturned = false
            });//3

            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=Library;Trusted_Connection=True;"))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;

                if (clearValuesInTables)
                {
                    command.CommandText = "DELETE FROM BooksOutOfStorage";
                    command.ExecuteNonQuery();
                    command.CommandText = "DELETE FROM Storage";
                    command.ExecuteNonQuery();
                    command.CommandText = "DELETE FROM LibraryUser";
                    command.ExecuteNonQuery();
                    command.CommandText = "DELETE FROM Book";
                    command.ExecuteNonQuery();
                    command.CommandText = "DELETE FROM Author";
                    command.ExecuteNonQuery();
                    command.CommandText = "DELETE FROM Person";
                    command.ExecuteNonQuery();

                }

                foreach (var item in persons)
                {
                    command.CommandText =
                        "INSERT INTO Person (firstname,lastname,middlename,adress,birthday,phone_number) " +
                        "VALUES(@firstname,@lastname,@middlename,@adress,@birthday,@phone_number)";
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@firstname", item.Firstname);
                    command.Parameters.AddWithValue("@lastname", item.Lastname);
                    command.Parameters.AddWithValue("@middlename", item.Middlename);
                    command.Parameters.AddWithValue("@adress", item.Adress);
                    command.Parameters.AddWithValue("@birthday", item.Birthday);
                    command.Parameters.AddWithValue("@phone_number", item.PhoneNumber);

                    command.ExecuteNonQuery();
                }

                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM Person";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    foreach (var item in persons)
                    {
                        if (
                            item.Firstname.Equals(reader.GetValue(1))
                            && item.Lastname.Equals(reader.GetValue(2))
                            && item.Middlename.Equals(reader.GetValue(3))
                           )
                        {
                            item.Id = (int)reader.GetValue(0);
                        }
                    }

                }
                reader.Close();

                foreach (var item in users)
                {

                    command.CommandText =
                        $"INSERT INTO LibraryUser(person_id) " +
                        $"VALUES(@person_id)";
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@person_id", item.Person.Id);

                    command.ExecuteNonQuery();

                }

                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM LibraryUser";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    foreach (var item in users)
                    {
                        if (item.Person.Id.Equals(reader.GetValue(1)))
                        {
                            item.Id = (int)reader.GetValue(0);
                        }
                    }

                }
                reader.Close();



                foreach (var item in authors)
                {
                    command.CommandText =
                        $"INSERT INTO Author(firstname,lastname) " +
                        $"VALUES(@firstname,@lastname)";
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@firstname", item.Firstname);
                    command.Parameters.AddWithValue("@lastname", item.Lastname);

                    command.ExecuteNonQuery();
                }
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM Author";
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    foreach (var item in authors)
                    {
                        if (
                            item.Firstname.Equals(reader.GetValue(1))
                            && item.Lastname.Equals(reader.GetValue(2))
                           )
                        {
                            item.Id = (int)reader.GetValue(0);
                        }
                    }

                }
                reader.Close();






                foreach (var item in books)
                {

                    command.CommandText = $"INSERT INTO Book(book_name,author_id,price) " +
                        $"VALUES(@book_name,@author_id,@price)";
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@book_name", item.Name);
                    command.Parameters.AddWithValue("@author_id", item.Author.Id);
                    command.Parameters.AddWithValue("@price", item.Price);

                    command.ExecuteNonQuery();


                }
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM Book";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    foreach (var item in books)
                    {
                        if (
                            item.Name.Equals(reader.GetValue(1))
                            && item.Author.Id.Equals(reader.GetValue(2))
                           )
                        {
                            item.Id = (int)reader.GetValue(0);
                        }
                    }
                }
                reader.Close();


                foreach (var item in storage)
                {

                    command.CommandText = $"INSERT INTO Storage(book_id,absolute_amount,current_amount) " +
                        $"VALUES(@book_id,@absolute_amount,@current_amount)";
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@book_id", item.Book.Id);
                    command.Parameters.AddWithValue("@absolute_amount", item.AbsoluteAmount);
                    command.Parameters.AddWithValue("@current_amount", item.CurrentAmount);

                    command.ExecuteNonQuery();


                }

                foreach (var item in booksOutStorage)
                {

                    command.CommandText = $"INSERT INTO " +
                        $"BooksOutOfStorage(book_id,library_user_id,take_away_time,give_away_time,is_returned) " +
                        $"VALUES(@book_id,@library_user_id,@take_away_time,@give_away_time,@is_returned)";
                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("@book_id", item.Book.Id);
                    command.Parameters.AddWithValue("@library_user_id", item.User.Id);
                    command.Parameters.AddWithValue("@take_away_time", item.TakeAwayTime);
                    command.Parameters.AddWithValue("@give_away_time", item.GiveAwayTime);
                    command.Parameters.AddWithValue("@is_returned", item.IsReturned ? 1 : 0);

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }
    }
}