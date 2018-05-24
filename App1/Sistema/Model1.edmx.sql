
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/23/2018 21:13:00
-- Generated from EDMX file: C:\laragon\www\Sistema-Costeo-Pan\App1\Sistema\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [costeo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_linea_familia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[linea] DROP CONSTRAINT [FK_linea_familia];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[familia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[familia];
GO
IF OBJECT_ID(N'[dbo].[linea]', 'U') IS NOT NULL
    DROP TABLE [dbo].[linea];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'familia'
CREATE TABLE [dbo].[familia] (
    [id] int  NOT NULL,
    [nombre] nchar(10)  NULL
);
GO

-- Creating table 'linea'
CREATE TABLE [dbo].[linea] (
    [id] nchar(10)  NOT NULL,
    [nombre] nchar(10)  NULL,
    [familia_id] int  NULL
);
GO

-- Creating table 'unidad_medidaSet'
CREATE TABLE [dbo].[unidad_medidaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'familia'
ALTER TABLE [dbo].[familia]
ADD CONSTRAINT [PK_familia]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'linea'
ALTER TABLE [dbo].[linea]
ADD CONSTRAINT [PK_linea]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'unidad_medidaSet'
ALTER TABLE [dbo].[unidad_medidaSet]
ADD CONSTRAINT [PK_unidad_medidaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [familia_id] in table 'linea'
ALTER TABLE [dbo].[linea]
ADD CONSTRAINT [FK_linea_familia]
    FOREIGN KEY ([familia_id])
    REFERENCES [dbo].[familia]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_linea_familia'
CREATE INDEX [IX_FK_linea_familia]
ON [dbo].[linea]
    ([familia_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------