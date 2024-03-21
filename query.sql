CREATE DATABASE Book_Management
GO
USE Book_Management

CREATE TABLE [Admin] (
	[AdminID] INT PRIMARY KEY IDENTITY(1,1),
	[Username] VARCHAR(50) UNIQUE NOT NULL,
	[Password] VARCHAR(50) NOT NULL,
	[Email] VARCHAR(100) UNIQUE NOT NULL,
	[FullName] VARCHAR(255) NOT NULL,
	[CreatedAt] DATETIME DEFAULT GETDATE()
);

CREATE TABLE [Category] (
	[CategoryID] INT PRIMARY KEY IDENTITY(1,1),
	[CategoryName] VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE [Author] (
	[AuthorID] INT PRIMARY KEY IDENTITY(1,1),
	[AuthorName] VARCHAR(100) NOT NULL,
	[Nationality] VARCHAR(100)
);

CREATE TABLE [Book] (
	[BookID] INT PRIMARY KEY IDENTITY(1,1),
	[Title] VARCHAR(255) NOT NULL,
	[AuthorID] INT,
	[CategoryID] INT,
	[PublicationYear] INT,
	[Price] DECIMAL(10,2),
	FOREIGN KEY (AuthorID) REFERENCES Author(AuthorID),
	FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);

INSERT INTO [Admin] ([Username], [Password], [Email], [FullName])
VALUES ('admin1', 'admin123', 'admin1@example.com', 'John Cena'),
	   ('admin2', 'admin456', 'admin2@example.com', 'John Son');

INSERT INTO [Category] ([CategoryName])
VALUES ('Fiction'),
	   ('Non-Fiction'),
	   ('Science Fiction'),
	   ('Fantasy');

INSERT INTO [Author] ([AuthorName], [Nationality])
VALUES ('J.K. Rowling', 'British'),
	   ('Stephen King', 'American'),
	   ('George Orwell', 'British');

INSERT INTO [Book] ([Title], [AuthorID], [CategoryID], [PublicationYear], [Price])
VALUES ('Harry Potter and the Philosopher''s Stone', 1, 1, 1997, 19.99),
	   ('1984', 3, 1, 1949, 14.99),
	   ('The Shining', 2, 1, 1977, 12.99),
	   ('The Hobbit', 1, 4, 1937, 22.99);



