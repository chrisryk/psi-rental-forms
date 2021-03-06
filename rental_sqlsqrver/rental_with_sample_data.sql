USE [master]
GO
/****** Object:  Database [Rental]    Script Date: 01.06.2022 22:27:12 ******/
CREATE DATABASE [Rental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Rental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Rental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Rental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Rental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Rental] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Rental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Rental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Rental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Rental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Rental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Rental] SET ARITHABORT OFF 
GO
ALTER DATABASE [Rental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Rental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Rental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Rental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Rental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Rental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Rental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Rental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Rental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Rental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Rental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Rental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Rental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Rental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Rental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Rental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Rental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Rental] SET RECOVERY FULL 
GO
ALTER DATABASE [Rental] SET  MULTI_USER 
GO
ALTER DATABASE [Rental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Rental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Rental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Rental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Rental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Rental] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Rental', N'ON'
GO
ALTER DATABASE [Rental] SET QUERY_STORE = OFF
GO
USE [Rental]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 01.06.2022 22:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[manufacturer] [varchar](50) NOT NULL,
	[model] [varchar](50) NOT NULL,
	[year] [numeric](4, 0) NOT NULL,
	[insurance] [datetime] NOT NULL,
	[vin] [varchar](17) NOT NULL,
	[daily_rate] [numeric](6, 2) NOT NULL,
	[rented] [bit] NOT NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 01.06.2022 22:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[surname] [varchar](50) NOT NULL,
	[phone] [varchar](9) NULL,
	[email] [varchar](50) NULL,
	[licence] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 01.06.2022 22:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[rent_id] [numeric](18, 0) NOT NULL,
	[price] [numeric](8, 2) NOT NULL,
	[date] [datetime] NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rents]    Script Date: 01.06.2022 22:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rents](
	[id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[customer_id] [numeric](18, 0) NOT NULL,
	[car_id] [numeric](18, 0) NOT NULL,
	[date_start] [datetime] NULL,
	[date_back] [datetime] NULL,
 CONSTRAINT [PK_Rent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 01.06.2022 22:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[role] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01.06.2022 22:27:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[role_id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([id], [manufacturer], [model], [year], [insurance], [vin], [daily_rate], [rented]) VALUES (CAST(1 AS Numeric(18, 0)), N'HONDA', N'CIVIC', CAST(2018 AS Numeric(4, 0)), CAST(N'2023-02-05T00:00:00.000' AS DateTime), N'JN8AZ2NE5C9016953', CAST(350.00 AS Numeric(6, 2)), 0)
INSERT [dbo].[Cars] ([id], [manufacturer], [model], [year], [insurance], [vin], [daily_rate], [rented]) VALUES (CAST(2 AS Numeric(18, 0)), N'HONDA', N'CIVIC', CAST(2017 AS Numeric(4, 0)), CAST(N'2022-11-09T00:00:00.000' AS DateTime), N'JN8AZ1MU4CW113789', CAST(350.00 AS Numeric(6, 2)), 0)
INSERT [dbo].[Cars] ([id], [manufacturer], [model], [year], [insurance], [vin], [daily_rate], [rented]) VALUES (CAST(3 AS Numeric(18, 0)), N'NISSAN', N'LEAF', CAST(2019 AS Numeric(4, 0)), CAST(N'2022-11-16T00:00:00.000' AS DateTime), N'SCBCR63W55C024793', CAST(400.00 AS Numeric(6, 2)), 0)
INSERT [dbo].[Cars] ([id], [manufacturer], [model], [year], [insurance], [vin], [daily_rate], [rented]) VALUES (CAST(4 AS Numeric(18, 0)), N'NISSAN', N'LEAF', CAST(2018 AS Numeric(4, 0)), CAST(N'2022-09-15T00:00:00.000' AS DateTime), N'WMWZN3C51BT133317', CAST(400.00 AS Numeric(6, 2)), 0)
INSERT [dbo].[Cars] ([id], [manufacturer], [model], [year], [insurance], [vin], [daily_rate], [rented]) VALUES (CAST(5 AS Numeric(18, 0)), N'TOYOTA', N'COROLLA', CAST(2020 AS Numeric(4, 0)), CAST(N'2023-02-14T00:00:00.000' AS DateTime), N'JN8AS1MU0CM120061', CAST(320.00 AS Numeric(6, 2)), 1)
INSERT [dbo].[Cars] ([id], [manufacturer], [model], [year], [insurance], [vin], [daily_rate], [rented]) VALUES (CAST(6 AS Numeric(18, 0)), N'BMW', N'M5', CAST(2021 AS Numeric(4, 0)), CAST(N'2023-04-05T00:00:00.000' AS DateTime), N'2S3TD52V3Y6103456', CAST(800.00 AS Numeric(6, 2)), 0)
INSERT [dbo].[Cars] ([id], [manufacturer], [model], [year], [insurance], [vin], [daily_rate], [rented]) VALUES (CAST(7 AS Numeric(18, 0)), N'BMW', N'X3', CAST(2018 AS Numeric(4, 0)), CAST(N'2022-09-16T00:00:00.000' AS DateTime), N'JH4DA9460LS000685', CAST(490.00 AS Numeric(6, 2)), 0)
INSERT [dbo].[Cars] ([id], [manufacturer], [model], [year], [insurance], [vin], [daily_rate], [rented]) VALUES (CAST(8 AS Numeric(18, 0)), N'MERCEDES-BENZ', N'GLA200', CAST(2020 AS Numeric(4, 0)), CAST(N'2022-10-23T00:00:00.000' AS DateTime), N'2P4GH2535SR296546', CAST(400.00 AS Numeric(6, 2)), 0)
INSERT [dbo].[Cars] ([id], [manufacturer], [model], [year], [insurance], [vin], [daily_rate], [rented]) VALUES (CAST(9 AS Numeric(18, 0)), N'MERCEDES-BENZ', N'GLE300', CAST(2022 AS Numeric(4, 0)), CAST(N'2022-12-18T00:00:00.000' AS DateTime), N'JM3ER29L070133282', CAST(740.00 AS Numeric(6, 2)), 0)
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([id], [name], [surname], [phone], [email], [licence]) VALUES (CAST(1 AS Numeric(18, 0)), N'JAN', N'KOWALSKI', N'847382325', N'jkowalski@mail.com', N'35492/64/4453')
INSERT [dbo].[Customers] ([id], [name], [surname], [phone], [email], [licence]) VALUES (CAST(2 AS Numeric(18, 0)), N'MARIAN', N'NOWAK', N'675345824', N'mnowak@mail.com', N'65386/46/7245')
INSERT [dbo].[Customers] ([id], [name], [surname], [phone], [email], [licence]) VALUES (CAST(3 AS Numeric(18, 0)), N'LECH', N'PAWLAK', N'908734235', N'lpawlak@mail.com', N'34657/34/7257')
INSERT [dbo].[Customers] ([id], [name], [surname], [phone], [email], [licence]) VALUES (CAST(4 AS Numeric(18, 0)), N'TOMASZ', N'KOSIOREK', N'764352234', N'tkosiorek@mail.com', N'57344/26/5347')
INSERT [dbo].[Customers] ([id], [name], [surname], [phone], [email], [licence]) VALUES (CAST(5 AS Numeric(18, 0)), N'WIKTOR', N'BOCZEK', N'584927546', N'wboczek@mail.pl', N'86567/31/5578')
INSERT [dbo].[Customers] ([id], [name], [surname], [phone], [email], [licence]) VALUES (CAST(6 AS Numeric(18, 0)), N'PIOTR', N'DOLINSKI', N'896346345', N'pdolinski@mail.pl', N'45334/78/2346')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoices] ON 

INSERT [dbo].[Invoices] ([id], [rent_id], [price], [date]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(1050.00 AS Numeric(8, 2)), CAST(N'2022-06-01T21:51:55.387' AS DateTime))
INSERT [dbo].[Invoices] ([id], [rent_id], [price], [date]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(1960.00 AS Numeric(8, 2)), CAST(N'2022-06-01T22:07:03.970' AS DateTime))
INSERT [dbo].[Invoices] ([id], [rent_id], [price], [date]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(1600.00 AS Numeric(8, 2)), CAST(N'2022-06-01T22:14:23.803' AS DateTime))
SET IDENTITY_INSERT [dbo].[Invoices] OFF
GO
SET IDENTITY_INSERT [dbo].[Rents] ON 

INSERT [dbo].[Rents] ([id], [customer_id], [car_id], [date_start], [date_back]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(N'2022-05-09T13:25:16.000' AS DateTime), CAST(N'2022-05-12T21:51:43.000' AS DateTime))
INSERT [dbo].[Rents] ([id], [customer_id], [car_id], [date_start], [date_back]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(N'2022-05-11T08:13:00.000' AS DateTime), NULL)
INSERT [dbo].[Rents] ([id], [customer_id], [car_id], [date_start], [date_back]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), CAST(N'2022-05-12T15:04:59.000' AS DateTime), CAST(N'2022-05-16T22:06:41.000' AS DateTime))
INSERT [dbo].[Rents] ([id], [customer_id], [car_id], [date_start], [date_back]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(N'2022-05-16T12:57:56.000' AS DateTime), CAST(N'2022-05-20T22:09:27.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Rents] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([id], [role]) VALUES (CAST(1 AS Numeric(18, 0)), N'admin')
INSERT [dbo].[Roles] ([id], [role]) VALUES (CAST(2 AS Numeric(18, 0)), N'manager')
INSERT [dbo].[Roles] ([id], [role]) VALUES (CAST(3 AS Numeric(18, 0)), N'customer advisor')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [name], [password], [role_id]) VALUES (CAST(1 AS Numeric(18, 0)), N'admin', N'admin', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([id], [name], [password], [role_id]) VALUES (CAST(2 AS Numeric(18, 0)), N'john_doe', N'man', CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Users] ([id], [name], [password], [role_id]) VALUES (CAST(3 AS Numeric(18, 0)), N'mark_smith', N'adv', CAST(3 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Rent] FOREIGN KEY([rent_id])
REFERENCES [dbo].[Rents] ([id])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoice_Rent]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[Roles] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [Rental] SET  READ_WRITE 
GO
