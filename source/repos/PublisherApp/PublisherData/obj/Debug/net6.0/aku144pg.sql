﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Authers] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Authers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Books] (
    [BookId] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [Publishdate] datetime2 NOT NULL,
    [BasePrice] decimal(18,2) NOT NULL,
    [AutherId] int NOT NULL,
    CONSTRAINT [PK_Books] PRIMARY KEY ([BookId]),
    CONSTRAINT [FK_Books_Authers_AutherId] FOREIGN KEY ([AutherId]) REFERENCES [Authers] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Books_AutherId] ON [Books] ([AutherId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241024113504_initial', N'6.0.1');
GO

COMMIT;
GO

