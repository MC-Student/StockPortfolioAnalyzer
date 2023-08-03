if not exists(select * from sys.databases where name = 'Banana')
create database [Banana]
GO

USE [Banana]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Historical_Data')
DROP TABLE [dbo].[Historical_Data]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Transaction_Data')
DROP TABLE [dbo].[Transaction_Data]
GO

IF EXISTS(SELECT * FROM sys.tables WHERE type = 'U' AND name = 'Net_Price')
DROP TABLE [dbo].[Net_Price]
GO

SET ANSI_NULLS ON
GO

CREATE TABLE [dbo].[Historical_Data]
(
[Historical_ID] [int] NOT NULL IDENTITY(1,1),
[Ticker] [varchar](10) NOT NULL,
[Date] [smalldatetime] NOT NULL,
[Close] [float] NOT NULL,
CONSTRAINT [PK_Historical] PRIMARY KEY CLUSTERED ([Historical_ID] ASC),
CONSTRAINT [UK_Historical] UNIQUE ([Ticker], [Date])
)
GO

CREATE TABLE [dbo].[Transaction_Data]
(
[Transaction_ID] [int] NOT NULL IDENTITY(1,1),
[Ticker] [varchar](10) NOT NULL,
[Date] [smalldatetime] NOT NULL,
[Quantity] [float] NOT NULL,
[Price] [float] NOT NULL,
CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED ([Transaction_ID] ASC),
CONSTRAINT [UK_Transaction] UNIQUE ([Transaction_ID])
)
GO

CREATE TABLE [dbo].[Net_Price]
(
[Historical_ID] [int] NOT NULL,
[Transaction_ID] [int] NOT NULL,
CONSTRAINT [PK_Net] PRIMARY KEY CLUSTERED ([Historical_ID], [Transaction_ID]),
CONSTRAINT [UK_Net] UNIQUE ([Historical_ID], [Transaction_ID]),
CONSTRAINT [FK_Historical] FOREIGN KEY (Historical_ID) REFERENCES Historical_Data([Historical_ID]),
CONSTRAINT [FK_Transaction] FOREIGN KEY (Transaction_ID) REFERENCES Transaction_Data([Transaction_ID])
)
GO