
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/01/2016 11:57:07
-- Generated from EDMX file: C:\Users\Lukasz\documents\visual studio 2013\Projects\Biblioteka\Biblioteka\LibraryDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Biblioteka.LibraryDBModel];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_GenreBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Books] DROP CONSTRAINT [FK_GenreBook];
GO
IF OBJECT_ID(N'[dbo].[FK_AuthorshipAuthor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Authorships] DROP CONSTRAINT [FK_AuthorshipAuthor];
GO
IF OBJECT_ID(N'[dbo].[FK_AuthorshipBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Authorships] DROP CONSTRAINT [FK_AuthorshipBook];
GO
IF OBJECT_ID(N'[dbo].[FK_BookEditionBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Positions_BookEdition] DROP CONSTRAINT [FK_BookEditionBook];
GO
IF OBJECT_ID(N'[dbo].[FK_BookEditionPublisher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Positions_BookEdition] DROP CONSTRAINT [FK_BookEditionPublisher];
GO
IF OBJECT_ID(N'[dbo].[FK_MagazineGenre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Magazines] DROP CONSTRAINT [FK_MagazineGenre];
GO
IF OBJECT_ID(N'[dbo].[FK_MagazinePublisher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Magazines] DROP CONSTRAINT [FK_MagazinePublisher];
GO
IF OBJECT_ID(N'[dbo].[FK_MagazineNumberMagazine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Positions_MagazineNumber] DROP CONSTRAINT [FK_MagazineNumberMagazine];
GO
IF OBJECT_ID(N'[dbo].[FK_GameGenre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Positions_Game] DROP CONSTRAINT [FK_GameGenre];
GO
IF OBJECT_ID(N'[dbo].[FK_BorrowingResource]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Borrowings] DROP CONSTRAINT [FK_BorrowingResource];
GO
IF OBJECT_ID(N'[dbo].[FK_BorrowingReader]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Borrowings] DROP CONSTRAINT [FK_BorrowingReader];
GO
IF OBJECT_ID(N'[dbo].[FK_BorrowingUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Borrowings] DROP CONSTRAINT [FK_BorrowingUser];
GO
IF OBJECT_ID(N'[dbo].[FK_ReservationResource]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservations] DROP CONSTRAINT [FK_ReservationResource];
GO
IF OBJECT_ID(N'[dbo].[FK_ReservationReader]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservations] DROP CONSTRAINT [FK_ReservationReader];
GO
IF OBJECT_ID(N'[dbo].[FK_ApplicationReader]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReaderApplications] DROP CONSTRAINT [FK_ApplicationReader];
GO
IF OBJECT_ID(N'[dbo].[FK_ApplicationDataApplication]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReaderApplicationsDatas] DROP CONSTRAINT [FK_ApplicationDataApplication];
GO
IF OBJECT_ID(N'[dbo].[FK_ResourcePosition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Resources] DROP CONSTRAINT [FK_ResourcePosition];
GO
IF OBJECT_ID(N'[dbo].[FK_ReaderUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Readers] DROP CONSTRAINT [FK_ReaderUser];
GO
IF OBJECT_ID(N'[dbo].[FK_BookEdition_inherits_Position]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Positions_BookEdition] DROP CONSTRAINT [FK_BookEdition_inherits_Position];
GO
IF OBJECT_ID(N'[dbo].[FK_MagazineNumber_inherits_Position]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Positions_MagazineNumber] DROP CONSTRAINT [FK_MagazineNumber_inherits_Position];
GO
IF OBJECT_ID(N'[dbo].[FK_Game_inherits_Position]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Positions_Game] DROP CONSTRAINT [FK_Game_inherits_Position];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Readers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Readers];
GO
IF OBJECT_ID(N'[dbo].[Authors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Authors];
GO
IF OBJECT_ID(N'[dbo].[Publishers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Publishers];
GO
IF OBJECT_ID(N'[dbo].[Genres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Genres];
GO
IF OBJECT_ID(N'[dbo].[Books]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Books];
GO
IF OBJECT_ID(N'[dbo].[Authorships]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Authorships];
GO
IF OBJECT_ID(N'[dbo].[Magazines]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Magazines];
GO
IF OBJECT_ID(N'[dbo].[Resources]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Resources];
GO
IF OBJECT_ID(N'[dbo].[Borrowings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Borrowings];
GO
IF OBJECT_ID(N'[dbo].[Reservations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reservations];
GO
IF OBJECT_ID(N'[dbo].[ReaderApplications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReaderApplications];
GO
IF OBJECT_ID(N'[dbo].[ReaderApplicationsDatas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReaderApplicationsDatas];
GO
IF OBJECT_ID(N'[dbo].[Positions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Positions];
GO
IF OBJECT_ID(N'[dbo].[Positions_BookEdition]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Positions_BookEdition];
GO
IF OBJECT_ID(N'[dbo].[Positions_MagazineNumber]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Positions_MagazineNumber];
GO
IF OBJECT_ID(N'[dbo].[Positions_Game]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Positions_Game];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nchar(32)  NOT NULL,
    [E_Mail] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [Type] nchar(1)  NOT NULL
);
GO

-- Creating table 'Readers'
CREATE TABLE [dbo].[Readers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PhoneNumber] nvarchar(12)  NULL,
    [Street] nvarchar(max)  NULL,
    [HouseNumber] nvarchar(5)  NULL,
    [ApartmentNumber] nvarchar(10)  NULL,
    [City] nvarchar(max)  NULL,
    [PostalCode] nchar(6)  NULL,
    [Debt] decimal(6,2)  NOT NULL,
    [User_Id] int  NOT NULL
);
GO

-- Creating table 'Authors'
CREATE TABLE [dbo].[Authors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NULL
);
GO

-- Creating table 'Publishers'
CREATE TABLE [dbo].[Publishers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Genres'
CREATE TABLE [dbo].[Genres] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [GenreId] int  NOT NULL
);
GO

-- Creating table 'Authorships'
CREATE TABLE [dbo].[Authorships] (
    [AuthorId] int  NOT NULL,
    [BookId] int  NOT NULL
);
GO

-- Creating table 'Magazines'
CREATE TABLE [dbo].[Magazines] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [GenreId] int  NOT NULL,
    [PublisherId] int  NOT NULL
);
GO

-- Creating table 'Resources'
CREATE TABLE [dbo].[Resources] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Amount] int  NOT NULL,
    [Category] nchar(1)  NOT NULL,
    [PositionId] int  NOT NULL
);
GO

-- Creating table 'Borrowings'
CREATE TABLE [dbo].[Borrowings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BorrowingDate] datetime  NOT NULL,
    [ReturnDate] datetime  NULL,
    [ReturnTerm] datetime  NOT NULL,
    [ResourceId] int  NOT NULL,
    [ReaderId] int  NOT NULL,
    [LibrarianId] int  NOT NULL
);
GO

-- Creating table 'Reservations'
CREATE TABLE [dbo].[Reservations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RealizationDate] datetime  NOT NULL,
    [ResourceId] int  NOT NULL,
    [ReaderId] int  NOT NULL
);
GO

-- Creating table 'ReaderApplications'
CREATE TABLE [dbo].[ReaderApplications] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ApplicationDate] datetime  NOT NULL,
    [Status] nchar(1)  NOT NULL,
    [ReaderId] int  NOT NULL
);
GO

-- Creating table 'ReaderApplicationsDatas'
CREATE TABLE [dbo].[ReaderApplicationsDatas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Surname] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(12)  NULL,
    [Street] nvarchar(max)  NULL,
    [HouseNumber] nvarchar(5)  NULL,
    [ApartmentNumber] nvarchar(10)  NULL,
    [City] nvarchar(max)  NULL,
    [PostalCode] nchar(6)  NULL,
    [ReaderApplicationId] int  NOT NULL
);
GO

-- Creating table 'Positions'
CREATE TABLE [dbo].[Positions] (
    [PositionId] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Positions_BookEdition'
CREATE TABLE [dbo].[Positions_BookEdition] (
    [ISBN] nvarchar(13)  NULL,
    [PublicationDate] datetime  NULL,
    [Number] int  NULL,
    [BookId] int  NOT NULL,
    [PublisherId] int  NOT NULL,
    [PositionId] int  NOT NULL
);
GO

-- Creating table 'Positions_MagazineNumber'
CREATE TABLE [dbo].[Positions_MagazineNumber] (
    [PublicationDate] datetime  NULL,
    [Number] int  NOT NULL,
    [MagazineId] int  NOT NULL,
    [PositionId] int  NOT NULL
);
GO

-- Creating table 'Positions_Game'
CREATE TABLE [dbo].[Positions_Game] (
    [Name] nvarchar(max)  NOT NULL,
    [Producer] nvarchar(max)  NULL,
    [Edition] nvarchar(max)  NULL,
    [GenreId] int  NOT NULL,
    [PositionId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Readers'
ALTER TABLE [dbo].[Readers]
ADD CONSTRAINT [PK_Readers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Authors'
ALTER TABLE [dbo].[Authors]
ADD CONSTRAINT [PK_Authors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Publishers'
ALTER TABLE [dbo].[Publishers]
ADD CONSTRAINT [PK_Publishers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Genres'
ALTER TABLE [dbo].[Genres]
ADD CONSTRAINT [PK_Genres]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [AuthorId], [BookId] in table 'Authorships'
ALTER TABLE [dbo].[Authorships]
ADD CONSTRAINT [PK_Authorships]
    PRIMARY KEY CLUSTERED ([AuthorId], [BookId] ASC);
GO

-- Creating primary key on [Id] in table 'Magazines'
ALTER TABLE [dbo].[Magazines]
ADD CONSTRAINT [PK_Magazines]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Resources'
ALTER TABLE [dbo].[Resources]
ADD CONSTRAINT [PK_Resources]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Borrowings'
ALTER TABLE [dbo].[Borrowings]
ADD CONSTRAINT [PK_Borrowings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [PK_Reservations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReaderApplications'
ALTER TABLE [dbo].[ReaderApplications]
ADD CONSTRAINT [PK_ReaderApplications]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReaderApplicationsDatas'
ALTER TABLE [dbo].[ReaderApplicationsDatas]
ADD CONSTRAINT [PK_ReaderApplicationsDatas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [PositionId] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [PK_Positions]
    PRIMARY KEY CLUSTERED ([PositionId] ASC);
GO

-- Creating primary key on [PositionId] in table 'Positions_BookEdition'
ALTER TABLE [dbo].[Positions_BookEdition]
ADD CONSTRAINT [PK_Positions_BookEdition]
    PRIMARY KEY CLUSTERED ([PositionId] ASC);
GO

-- Creating primary key on [PositionId] in table 'Positions_MagazineNumber'
ALTER TABLE [dbo].[Positions_MagazineNumber]
ADD CONSTRAINT [PK_Positions_MagazineNumber]
    PRIMARY KEY CLUSTERED ([PositionId] ASC);
GO

-- Creating primary key on [PositionId] in table 'Positions_Game'
ALTER TABLE [dbo].[Positions_Game]
ADD CONSTRAINT [PK_Positions_Game]
    PRIMARY KEY CLUSTERED ([PositionId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [GenreId] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [FK_GenreBook]
    FOREIGN KEY ([GenreId])
    REFERENCES [dbo].[Genres]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GenreBook'
CREATE INDEX [IX_FK_GenreBook]
ON [dbo].[Books]
    ([GenreId]);
GO

-- Creating foreign key on [AuthorId] in table 'Authorships'
ALTER TABLE [dbo].[Authorships]
ADD CONSTRAINT [FK_AuthorshipAuthor]
    FOREIGN KEY ([AuthorId])
    REFERENCES [dbo].[Authors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [BookId] in table 'Authorships'
ALTER TABLE [dbo].[Authorships]
ADD CONSTRAINT [FK_AuthorshipBook]
    FOREIGN KEY ([BookId])
    REFERENCES [dbo].[Books]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AuthorshipBook'
CREATE INDEX [IX_FK_AuthorshipBook]
ON [dbo].[Authorships]
    ([BookId]);
GO

-- Creating foreign key on [BookId] in table 'Positions_BookEdition'
ALTER TABLE [dbo].[Positions_BookEdition]
ADD CONSTRAINT [FK_BookEditionBook]
    FOREIGN KEY ([BookId])
    REFERENCES [dbo].[Books]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BookEditionBook'
CREATE INDEX [IX_FK_BookEditionBook]
ON [dbo].[Positions_BookEdition]
    ([BookId]);
GO

-- Creating foreign key on [PublisherId] in table 'Positions_BookEdition'
ALTER TABLE [dbo].[Positions_BookEdition]
ADD CONSTRAINT [FK_BookEditionPublisher]
    FOREIGN KEY ([PublisherId])
    REFERENCES [dbo].[Publishers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BookEditionPublisher'
CREATE INDEX [IX_FK_BookEditionPublisher]
ON [dbo].[Positions_BookEdition]
    ([PublisherId]);
GO

-- Creating foreign key on [GenreId] in table 'Magazines'
ALTER TABLE [dbo].[Magazines]
ADD CONSTRAINT [FK_MagazineGenre]
    FOREIGN KEY ([GenreId])
    REFERENCES [dbo].[Genres]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MagazineGenre'
CREATE INDEX [IX_FK_MagazineGenre]
ON [dbo].[Magazines]
    ([GenreId]);
GO

-- Creating foreign key on [PublisherId] in table 'Magazines'
ALTER TABLE [dbo].[Magazines]
ADD CONSTRAINT [FK_MagazinePublisher]
    FOREIGN KEY ([PublisherId])
    REFERENCES [dbo].[Publishers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MagazinePublisher'
CREATE INDEX [IX_FK_MagazinePublisher]
ON [dbo].[Magazines]
    ([PublisherId]);
GO

-- Creating foreign key on [MagazineId] in table 'Positions_MagazineNumber'
ALTER TABLE [dbo].[Positions_MagazineNumber]
ADD CONSTRAINT [FK_MagazineNumberMagazine]
    FOREIGN KEY ([MagazineId])
    REFERENCES [dbo].[Magazines]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MagazineNumberMagazine'
CREATE INDEX [IX_FK_MagazineNumberMagazine]
ON [dbo].[Positions_MagazineNumber]
    ([MagazineId]);
GO

-- Creating foreign key on [GenreId] in table 'Positions_Game'
ALTER TABLE [dbo].[Positions_Game]
ADD CONSTRAINT [FK_GameGenre]
    FOREIGN KEY ([GenreId])
    REFERENCES [dbo].[Genres]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GameGenre'
CREATE INDEX [IX_FK_GameGenre]
ON [dbo].[Positions_Game]
    ([GenreId]);
GO

-- Creating foreign key on [ResourceId] in table 'Borrowings'
ALTER TABLE [dbo].[Borrowings]
ADD CONSTRAINT [FK_BorrowingResource]
    FOREIGN KEY ([ResourceId])
    REFERENCES [dbo].[Resources]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BorrowingResource'
CREATE INDEX [IX_FK_BorrowingResource]
ON [dbo].[Borrowings]
    ([ResourceId]);
GO

-- Creating foreign key on [ReaderId] in table 'Borrowings'
ALTER TABLE [dbo].[Borrowings]
ADD CONSTRAINT [FK_BorrowingReader]
    FOREIGN KEY ([ReaderId])
    REFERENCES [dbo].[Readers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BorrowingReader'
CREATE INDEX [IX_FK_BorrowingReader]
ON [dbo].[Borrowings]
    ([ReaderId]);
GO

-- Creating foreign key on [LibrarianId] in table 'Borrowings'
ALTER TABLE [dbo].[Borrowings]
ADD CONSTRAINT [FK_BorrowingUser]
    FOREIGN KEY ([LibrarianId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BorrowingUser'
CREATE INDEX [IX_FK_BorrowingUser]
ON [dbo].[Borrowings]
    ([LibrarianId]);
GO

-- Creating foreign key on [ResourceId] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_ReservationResource]
    FOREIGN KEY ([ResourceId])
    REFERENCES [dbo].[Resources]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ReservationResource'
CREATE INDEX [IX_FK_ReservationResource]
ON [dbo].[Reservations]
    ([ResourceId]);
GO

-- Creating foreign key on [ReaderId] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_ReservationReader]
    FOREIGN KEY ([ReaderId])
    REFERENCES [dbo].[Readers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ReservationReader'
CREATE INDEX [IX_FK_ReservationReader]
ON [dbo].[Reservations]
    ([ReaderId]);
GO

-- Creating foreign key on [ReaderId] in table 'ReaderApplications'
ALTER TABLE [dbo].[ReaderApplications]
ADD CONSTRAINT [FK_ApplicationReader]
    FOREIGN KEY ([ReaderId])
    REFERENCES [dbo].[Readers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationReader'
CREATE INDEX [IX_FK_ApplicationReader]
ON [dbo].[ReaderApplications]
    ([ReaderId]);
GO

-- Creating foreign key on [ReaderApplicationId] in table 'ReaderApplicationsDatas'
ALTER TABLE [dbo].[ReaderApplicationsDatas]
ADD CONSTRAINT [FK_ApplicationDataApplication]
    FOREIGN KEY ([ReaderApplicationId])
    REFERENCES [dbo].[ReaderApplications]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationDataApplication'
CREATE INDEX [IX_FK_ApplicationDataApplication]
ON [dbo].[ReaderApplicationsDatas]
    ([ReaderApplicationId]);
GO

-- Creating foreign key on [PositionId] in table 'Resources'
ALTER TABLE [dbo].[Resources]
ADD CONSTRAINT [FK_ResourcePosition]
    FOREIGN KEY ([PositionId])
    REFERENCES [dbo].[Positions]
        ([PositionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ResourcePosition'
CREATE INDEX [IX_FK_ResourcePosition]
ON [dbo].[Resources]
    ([PositionId]);
GO

-- Creating foreign key on [User_Id] in table 'Readers'
ALTER TABLE [dbo].[Readers]
ADD CONSTRAINT [FK_ReaderUser]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ReaderUser'
CREATE INDEX [IX_FK_ReaderUser]
ON [dbo].[Readers]
    ([User_Id]);
GO

-- Creating foreign key on [PositionId] in table 'Positions_BookEdition'
ALTER TABLE [dbo].[Positions_BookEdition]
ADD CONSTRAINT [FK_BookEdition_inherits_Position]
    FOREIGN KEY ([PositionId])
    REFERENCES [dbo].[Positions]
        ([PositionId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PositionId] in table 'Positions_MagazineNumber'
ALTER TABLE [dbo].[Positions_MagazineNumber]
ADD CONSTRAINT [FK_MagazineNumber_inherits_Position]
    FOREIGN KEY ([PositionId])
    REFERENCES [dbo].[Positions]
        ([PositionId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PositionId] in table 'Positions_Game'
ALTER TABLE [dbo].[Positions_Game]
ADD CONSTRAINT [FK_Game_inherits_Position]
    FOREIGN KEY ([PositionId])
    REFERENCES [dbo].[Positions]
        ([PositionId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------