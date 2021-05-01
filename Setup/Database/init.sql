IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'WhatTheBug')
BEGIN
CREATE DATABASE [WhatTheBug]
END
GO

USE [WhatTheBug]
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='SchemaVersion')
BEGIN
  CREATE TABLE SchemaVersion (
    [Version] INT PRIMARY KEY,
    [Description] VARCHAR(100),
    Migrated DATETIME DEFAULT CURRENT_TIMESTAMP
  )
END

IF EXISTS (SELECT *FROM sysobjects WHERE name='SchemaVersion_Migrate')
BEGIN
  DROP PROCEDURE SchemaVersion_Migrate
END
GO

CREATE PROCEDURE SchemaVersion_Migrate @Version int, @Description VARCHAR(100)
  AS
  BEGIN
    SET NOCOUNT ON
    INSERT INTO SchemaVersion ([Version], [Description]) VALUES (@Version, @Description)
  END
GO

EXEC SchemaVersion_Migrate @Version = 1, @Description = 'Initial schema'