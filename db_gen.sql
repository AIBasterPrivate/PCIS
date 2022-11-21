CREATE TABLE [Person] (
  Id integer NOT NULL IDENTITY (1, 1),
  Firstname varchar(30) NOT NULL,
  MIddlename varchar(30),
  Lastname varchar(30) NOT NULL,
  Adress varchar(50),
  Birthday date NOT NULL,
  PhoneNumber varchar(20) NOT NULL,
  PRIMARY KEY (Id)
)
GO
CREATE TABLE [LibraryUser] (
  Id integer NOT NULL IdENTITY (1, 1),
  PersonId integer NOT NULL,
  PRIMARY KEY (Id),
  FOREIGN KEY (PersonId) REFERENCES Person(Id),
)
GO
CREATE TABLE [Author] (
  Id integer NOT NULL IDENTITY (1, 1),
  Firstname varchar(15) NOT NULL,
  Lastname varchar(15) NOT NULL,
  PRIMARY KEY (Id)
)
GO
CREATE TABLE [Book] (
  Id integer NOT NULL IDENTITY (1, 1),
  BookName varchar(20) NOT NULL,
  AuthorId integer NOT NULL,
  Price float NOT NULL,
  PRIMARY KEY (Id),
  FOREIGN KEY (AuthorId) REFERENCES Author(Id)
)
GO
CREATE TABLE [BookOutOfStorage] (
  BookId integer NOT NULL,
  LibraryUserId integer NOT NULL,
  TakeAwayTime datetime NOT NULL,
  GiveAwayTime datetime NOT NULL,
  IsReturned bit NOT NULL DEFAULT 0,
  FOREIGN KEY (BookId) REFERENCES Book(Id),
  FOREIGN KEY (LibraryUserId) REFERENCES LibraryUser(Id)
)
GO
CREATE TABLE [Storage] (
  BookId integer NOT NULL,
  AbsoluteAmount integer NOT NULL,
  CurrentAmount integer NOT NULL,
  FOREIGN KEY (BookId) REFERENCES Book(Id),
)

