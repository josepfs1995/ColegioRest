IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015221156_Initial')
BEGIN
    CREATE TABLE [Alumno] (
        [Id] uniqueidentifier NOT NULL,
        [Nombre] Varchar(20) NULL,
        [Apellido] Varchar(40) NULL,
        [FechaNacimiento] datetime2 NOT NULL,
        CONSTRAINT [PK_Alumno] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015221156_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Apellido', N'FechaNacimiento', N'Nombre') AND [object_id] = OBJECT_ID(N'[Alumno]'))
        SET IDENTITY_INSERT [Alumno] ON;
    INSERT INTO [Alumno] ([Id], [Apellido], [FechaNacimiento], [Nombre])
    VALUES ('2396bc71-fc3b-4204-ac8d-d1df35cf904c', 'Fuentes', '1995-08-23T00:00:00.0000000', 'Josep');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Apellido', N'FechaNacimiento', N'Nombre') AND [object_id] = OBJECT_ID(N'[Alumno]'))
        SET IDENTITY_INSERT [Alumno] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201015221156_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201015221156_Initial', N'3.1.9');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201016210755_Second')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Alumno]') AND [c].[name] = N'FechaNacimiento');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Alumno] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Alumno] ALTER COLUMN [FechaNacimiento] Date NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201016210755_Second')
BEGIN
    CREATE TABLE [Curso] (
        [Id] uniqueidentifier NOT NULL,
        [Nombre] Varchar(40) NULL,
        CONSTRAINT [PK_Curso] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201016210755_Second')
BEGIN
    CREATE TABLE [Matricula] (
        [Id] uniqueidentifier NOT NULL,
        [Id_Alumno] uniqueidentifier NOT NULL,
        [FechaMatricula] datetime2 NOT NULL,
        CONSTRAINT [PK_Matricula] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Matricula_Alumno_Id_Alumno] FOREIGN KEY ([Id_Alumno]) REFERENCES [Alumno] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201016210755_Second')
BEGIN
    CREATE TABLE [Matricula_Detalle] (
        [Id] uniqueidentifier NOT NULL,
        [Id_Matricula] uniqueidentifier NOT NULL,
        [Id_Curso] uniqueidentifier NOT NULL,
        CONSTRAINT [PK_Matricula_Detalle] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Matricula_Detalle_Curso_Id_Curso] FOREIGN KEY ([Id_Curso]) REFERENCES [Curso] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Matricula_Detalle_Matricula_Id_Matricula] FOREIGN KEY ([Id_Matricula]) REFERENCES [Matricula] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201016210755_Second')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nombre') AND [object_id] = OBJECT_ID(N'[Curso]'))
        SET IDENTITY_INSERT [Curso] ON;
    INSERT INTO [Curso] ([Id], [Nombre])
    VALUES ('af4d5521-cfc1-4517-8763-f998269d1139', 'Lenguaje'),
    ('a3476a67-e06f-4e40-a15c-78f9f616e363', 'Matematica'),
    ('d07eec5b-c559-46a2-bab5-bda9cac1767c', 'Ciencias'),
    ('4436f676-07c0-4fac-994f-ed7a8e7dd7d7', 'RR.HH');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Nombre') AND [object_id] = OBJECT_ID(N'[Curso]'))
        SET IDENTITY_INSERT [Curso] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201016210755_Second')
BEGIN
    CREATE INDEX [IX_Matricula_Id_Alumno] ON [Matricula] ([Id_Alumno]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201016210755_Second')
BEGIN
    CREATE INDEX [IX_Matricula_Detalle_Id_Curso] ON [Matricula_Detalle] ([Id_Curso]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201016210755_Second')
BEGIN
    CREATE INDEX [IX_Matricula_Detalle_Id_Matricula] ON [Matricula_Detalle] ([Id_Matricula]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201016210755_Second')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201016210755_Second', N'3.1.9');
END;

GO

