IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Alumno] (
    [Id] uniqueidentifier NOT NULL,
    [Nombre] Varchar(20) NULL,
    [Apellido] Varchar(40) NULL,
    [FechaNacimiento] datetime2 NOT NULL,
    CONSTRAINT [PK_Alumno] PRIMARY KEY ([Id])
);

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Apellido', N'FechaNacimiento', N'Nombre') AND [object_id] = OBJECT_ID(N'[Alumno]'))
    SET IDENTITY_INSERT [Alumno] ON;
INSERT INTO [Alumno] ([Id], [Apellido], [FechaNacimiento], [Nombre])
VALUES ('2396bc71-fc3b-4204-ac8d-d1df35cf904c', 'Fuentes', '1995-08-23T00:00:00.0000000', 'Josep');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Apellido', N'FechaNacimiento', N'Nombre') AND [object_id] = OBJECT_ID(N'[Alumno]'))
    SET IDENTITY_INSERT [Alumno] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201015221156_Initial', N'3.1.9');

GO

