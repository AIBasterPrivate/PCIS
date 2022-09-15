// See https://aka.ms/new-console-template for more information
using PCIS;
using PCIS.Entity;
using System.Data.SqlClient;
using System.Text;




using (SqlConnection connection = LibraryDBSingleton.GetSingleton.SqlConnection)
{
    connection.Open();
    Init(true);

    SqlCommand command = new SqlCommand();
    command.Connection = connection;

    while (true) {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("0 - Exit");
        builder.AppendLine("1 - Select Person table");
        builder.AppendLine("2 - Select User table");
        builder.AppendLine("3 - Select Author table");
        builder.AppendLine("4 - Select Book table");
        builder.AppendLine("5 - Select BookOutStorage table");
        builder.AppendLine("6 - Select Storage table");
        Console.WriteLine(builder);
        int key;
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
            Fathername = "Ben",
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
            Fathername = "Mark",
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
            Fathername = "Stephan",
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
            Fathername = "Bill",
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
            Fathername = "Mike",
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
            Fathername = "Fin",
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
            Fathername = "Josef",
            PhoneNumber = "+1027222760"
        });

    List<User> users = new List<User>();//
    users.Add(new User() { PersonId = 1, TicketNumber = "000001" });
    users.Add(new User() { PersonId = 2, TicketNumber = "000002" });
    users.Add(new User() { PersonId = 3, TicketNumber = "000003" });
    users.Add(new User() { PersonId = 4, TicketNumber = "000004" });
    users.Add(new User() { PersonId = 5, TicketNumber = "000005" });
    users.Add(new User() { PersonId = 6, TicketNumber = "000006" });
   users.Add(new User() { PersonId = 7, TicketNumber = "000007" });

    List<Author> authors = new List<Author>();
    authors.Add(new Author() { Id = 1, Firstname = "Ivanov", Lastname = "Ivan" });
    authors.Add(new Author() { Id = 2, Firstname = "Stepanov", Lastname = "Stepan" });
    authors.Add(new Author() { Id = 3, Firstname = "Stone", Lastname = "Bill" });
    authors.Add(new Author() { Id = 4, Firstname = "Hock", Lastname = "Ivan" });
    authors.Add(new Author() { Id = 5, Firstname = "Phines", Lastname = "Ferb" });

    List<Book> books = new List<Book>();
    books.Add(new Book() { Id = 1, AuthorId = 1, Name = "Goliaf", Price = 17.50f });
    books.Add(new Book() { Id = 2, AuthorId = 1, Name = "Goliaf 2", Price = 15f });
    books.Add(new Book() { Id = 3, AuthorId = 2, Name = "Real Life", Price = 7.50f });
    books.Add(new Book() { Id = 4, AuthorId = 3, Name = "Network", Price = 10f });
    books.Add(new Book() { Id = 5, AuthorId = 4, Name = "Goverla", Price = 6f });
    books.Add(new Book() { Id = 6, AuthorId = 3, Name = "Pineaple", Price = 20f });
    books.Add(new Book() { Id = 7, AuthorId = 5, Name = "Terra", Price = 35f });

    List<Storage> storage = new List<Storage>();
    storage.Add(new Storage() { BookId = 1, AbsoluteAmount = 5, CurrentAmount = 3 });//
    storage.Add(new Storage() { BookId = 2, AbsoluteAmount = 10, CurrentAmount = 8 });//
    storage.Add(new Storage() { BookId = 3, AbsoluteAmount = 12, CurrentAmount = 10 });//
    storage.Add(new Storage() { BookId = 4, AbsoluteAmount = 5, CurrentAmount = 3 });//
    storage.Add(new Storage() { BookId = 5, AbsoluteAmount = 4, CurrentAmount = 2 });
    storage.Add(new Storage() { BookId = 6, AbsoluteAmount = 2, CurrentAmount = 0 });
    storage.Add(new Storage() { BookId = 7, AbsoluteAmount = 20, CurrentAmount = 18 });

    List<BooksOutStorage> booksOutStorage = new List<BooksOutStorage>();
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 1,
        UserId = 1,
        GiveAwayTime = new DateTime(2022, 9, 10, 13, 20, 0),
        TakeAwayTime = new DateTime(2022, 9, 17, 13, 20, 0),
        IsReturned = false
    });//1
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 1,
        UserId = 2,
        GiveAwayTime = new DateTime(2022, 9, 10, 14, 20, 0),
        TakeAwayTime = new DateTime(2022, 9, 17, 14, 20, 0),
        IsReturned = false
    });//2
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 2,
        UserId = 1,
        GiveAwayTime = new DateTime(2022, 9, 10, 13, 20, 0),
        TakeAwayTime = new DateTime(2022, 9, 17, 13, 20, 0),
        IsReturned = false
    });//1
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 2,
        UserId = 2,
        GiveAwayTime = new DateTime(2022, 9, 10, 14, 20, 0),
        TakeAwayTime = new DateTime(2022, 9, 17, 14, 20, 0),
        IsReturned = false
    });//2
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 3,
        UserId = 3,
        GiveAwayTime = new DateTime(2022, 9, 20, 14, 20, 0),
        TakeAwayTime = new DateTime(2022, 9, 27, 14, 20, 0),
        IsReturned = false
    });//3
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 4,
        UserId = 3,
        GiveAwayTime = new DateTime(2022, 9, 20, 14, 20, 0),
        TakeAwayTime = new DateTime(2022, 9, 27, 14, 20, 0),
        IsReturned = false
    });//4
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 3,
        UserId = 4,
        GiveAwayTime = new DateTime(2022, 9, 20, 17, 20, 0),
        TakeAwayTime = new DateTime(2022, 9, 27, 17, 20, 0),
        IsReturned = false
    });//3
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 4,
        UserId = 4,
        GiveAwayTime = new DateTime(2022, 9, 20, 17, 20, 0),
        TakeAwayTime = new DateTime(2022, 9, 27, 17, 20, 0),
        IsReturned = false
    });//4
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 5,
        UserId = 5,
        GiveAwayTime = new DateTime(2022, 10, 1, 13, 20, 0),
        TakeAwayTime = new DateTime(2022, 10, 7, 13, 20, 0),
        IsReturned = false
    });//5
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 5,
        UserId = 6,
        GiveAwayTime = new DateTime(2022, 10, 1, 13, 20, 0),
        TakeAwayTime = new DateTime(2022, 10, 7, 13, 20, 0),
        IsReturned = false
    });//6
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 6,
        UserId = 6,
        GiveAwayTime = new DateTime(2022, 10, 1, 13, 20, 0),
        TakeAwayTime = new DateTime(2022, 10, 7, 13, 20, 0),
        IsReturned = false
    });//5
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 6,
        UserId = 6,
        GiveAwayTime = new DateTime(2022, 10, 1, 13, 20, 0),
        TakeAwayTime = new DateTime(2022, 10, 7, 13, 20, 0),
        IsReturned = false
    });//6
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 5,
        UserId = 7,
        GiveAwayTime = new DateTime(2022, 11, 1, 13, 20, 0),
        TakeAwayTime = new DateTime(2022, 11, 7, 13, 20, 0),
        IsReturned = false
    });//5
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 5,
        UserId = 7,
        GiveAwayTime = new DateTime(2022, 11, 1, 13, 20, 0),
        TakeAwayTime = new DateTime(2022, 11, 7, 13, 20, 0),
        IsReturned = false
    });//7
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 1,
        UserId = 7,
        GiveAwayTime = new DateTime(2022, 11, 1, 13, 20, 0),
        TakeAwayTime = new DateTime(2022, 11, 7, 13, 20, 0),
        IsReturned = false
    });//1
    booksOutStorage.Add(new BooksOutStorage()
    {
        BookId = 3,
        UserId = 7,
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
            //command.CommandText = "SET IDENTITY_INSERT LibraryUser ON";
            //command.ExecuteNonQuery();
            //command.CommandText = "SET IDENTITY_INSERT Book ON";
            //command.ExecuteNonQuery();
            //command.CommandText = "SET IDENTITY_INSERT Author ON";
            //command.ExecuteNonQuery();
            //command.CommandText = "SET IDENTITY_INSERT Person ON";
            //command.ExecuteNonQuery();

        }

        foreach (var item in persons)
        {
            command.CommandText =
                "INSERT INTO Person (id,firstname,lastname,middlename,adress,birthday,phone_number) " +
                "VALUES(@id,@firstname,@lastname,@middlename,@adress,@birthday,@phone_number)";
            command.Parameters.Clear();

            command.Parameters.AddWithValue("id", item.Id);
            command.Parameters.AddWithValue("@firstname", item.Firstname);
            command.Parameters.AddWithValue("@lastname", item.Lastname);
            command.Parameters.AddWithValue("@middlename", item.Fathername);
            command.Parameters.AddWithValue("@adress", item.Adress);
            command.Parameters.AddWithValue("@birthday", item.Birthday);
            command.Parameters.AddWithValue("@phone_number", item.PhoneNumber);

            command.ExecuteNonQuery();
        }
        /// Добавить персонов, авторов сначала. Считать их айди, потом записать эти айди в других фигнях.
        /// Либо записать в персонов авторов и поменять в класах инты на ссылки на нужные обьекты. I preffer this

        foreach (var item in users)
        {
            try
            {
                command.CommandText =
                    $"INSERT INTO LibraryUser(person_id) " +
                    $"VALUES(@person_id)";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@person_id", item.PersonId);

                command.ExecuteNonQuery();
            }catch{ }
        }

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

        foreach (var item in books)
        {
            try
            {
                command.CommandText = $"INSERT INTO Book(book_name,author_id,price) " +
                    $"VALUES(@book_name,@author_id,@price)";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@book_name", item.Name);
                command.Parameters.AddWithValue("@author_id", item.AuthorId);
                command.Parameters.AddWithValue("@price", item.Price);

                command.ExecuteNonQuery();
            }
            catch { }

        }

        foreach (var item in storage)
        {
            try
            {
                command.CommandText = $"INSERT INTO Storage(book_id,absolute_amount,current_amount) " +
                    $"VALUES(@book_id,@absolute_amount,@current_amount)";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@book_id", item.BookId);
                command.Parameters.AddWithValue("@absolute_amount", item.AbsoluteAmount);
                command.Parameters.AddWithValue("@current_amount", item.CurrentAmount);

                command.ExecuteNonQuery();
            }catch { }

        }

        foreach (var item in booksOutStorage)
        {
            try
            {
                command.CommandText = $"INSERT INTO " +
                    $"Books_out_Storage(book_id,library_user_id,take_away_time,give_away_time,is_returned) " +
                    $"VALUES(@book_id,@library_user_id,@take_away_time,@give_away_time,@is_returned)";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@book_id", item.BookId);
                command.Parameters.AddWithValue("@library_user_id", item.UserId);
                command.Parameters.AddWithValue("@take_away_time", item.TakeAwayTime);
                command.Parameters.AddWithValue("@give_away_time", item.GiveAwayTime);
                command.Parameters.AddWithValue("@is_returned", item.IsReturned ? 1 : 0);

                command.ExecuteNonQuery();
            }
            catch { }
        }
        connection.Close();
    }
}