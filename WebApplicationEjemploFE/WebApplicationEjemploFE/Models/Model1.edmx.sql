
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/19/2018 10:59:00
-- Generated from EDMX file: C:\laragon\www\Sistema-Costeo-Pan\WebApplicationEjemploFE\WebApplicationEjemploFE\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[lineas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[lineas];
GO
IF OBJECT_ID(N'[dbo].[unidad_medida]', 'U') IS NOT NULL
    DROP TABLE [dbo].[unidad_medida];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'lineas'
CREATE TABLE [dbo].[lineas] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nchar(30)  NULL,
    [creado_el] datetime  NULL
);
GO

-- Creating table 'unidad_medida'
CREATE TABLE [dbo].[unidad_medida] (
    [Id] int  NOT NULL,
    [codigo] nchar(10)  NULL,
    [descripcion] nchar(100)  NULL,
    [creado_el] datetime  NULL
);
GO

-- Creating table 'familias'
CREATE TABLE [dbo].[familias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [creado_el] datetime  NOT NULL,
    [linea_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'lineas'
ALTER TABLE [dbo].[lineas]
ADD CONSTRAINT [PK_lineas]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'unidad_medida'
ALTER TABLE [dbo].[unidad_medida]
ADD CONSTRAINT [PK_unidad_medida]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'familias'
ALTER TABLE [dbo].[familias]
ADD CONSTRAINT [PK_familias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [linea_id] in table 'familias'
ALTER TABLE [dbo].[familias]
ADD CONSTRAINT [FK_lineafamilia]
    FOREIGN KEY ([linea_id])
    REFERENCES [dbo].[lineas]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_lineafamilia'
CREATE INDEX [IX_FK_lineafamilia]
ON [dbo].[familias]
    ([linea_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------