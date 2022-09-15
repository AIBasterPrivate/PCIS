CREATE TABLE [Person] (
  id integer NOT NULL UNIQUE IDENTITY (1, 1),
  firstname varchar(15) NOT NULL,
  lastname varchar(15) NOT NULL,
  middlename varchar(15),
  adress varchar(50),
  birthday date NOT NULL,
  phone_number varchar(14),
  PRIMARY KEY (id)
)
GO
CREATE TABLE [Book] (
  id integer NOT NULL IDENTITY (1, 1),
  book_name varchar(20) NOT NULL,
  author_id integer NOT NULL,
  price float NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (author_id) REFERENCES Author(id)
)
GO
CREATE TABLE [Author] (
  id integer NOT NULL IDENTITY (1, 1),
  firstname varchar(15) NOT NULL,
  lastname varchar(15) NOT NULL,
  PRIMARY KEY (id)
)
GO
CREATE TABLE [BooksOutOfStorage] (
  book_id integer NOT NULL,
  library_user_id integer NOT NULL,
  take_away_time datetime NOT NULL,
  give_away_time datetime NOT NULL,
  is_returned bit NOT NULL DEFAULT 0,
  FOREIGN KEY (book_id) REFERENCES Book(id),
  FOREIGN KEY (library_user_id) REFERENCES LibraryUser(id)
)
GO
CREATE TABLE [Storage] (
  book_id integer NOT NULL,
  absolute_amount integer NOT NULL,
  current_amount integer NOT NULL,
  FOREIGN KEY (book_id) REFERENCES Book(id),
)
GO
CREATE TABLE [LibraryUser] (
  id integer NOT NULL IDENTITY (1, 1),
  person_id integer NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (person_id) REFERENCES Person(id),
)

