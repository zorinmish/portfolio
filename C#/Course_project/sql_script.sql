USE [master]
GO
/****** Object:  Database [autotp]    Script Date: 13.01.2021 9:16:07 ******/
CREATE DATABASE [autotp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'autotp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\autotp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'autotp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\autotp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [autotp] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [autotp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [autotp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [autotp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [autotp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [autotp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [autotp] SET ARITHABORT OFF 
GO
ALTER DATABASE [autotp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [autotp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [autotp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [autotp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [autotp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [autotp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [autotp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [autotp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [autotp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [autotp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [autotp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [autotp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [autotp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [autotp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [autotp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [autotp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [autotp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [autotp] SET RECOVERY FULL 
GO
ALTER DATABASE [autotp] SET  MULTI_USER 
GO
ALTER DATABASE [autotp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [autotp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [autotp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [autotp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [autotp] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'autotp', N'ON'
GO
ALTER DATABASE [autotp] SET QUERY_STORE = OFF
GO
USE [autotp]
GO
/****** Object:  Table [dbo].[cars]    Script Date: 13.01.2021 9:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cars](
	[car_number] [varchar](20) NOT NULL,
	[parking_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[car_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[drivers]    Script Date: 13.01.2021 9:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[drivers](
	[driver_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](40) NOT NULL,
	[DOB] [date] NOT NULL,
	[phone] [varchar](20) NULL,
	[driver_address] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[driver_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[itineraries]    Script Date: 13.01.2021 9:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itineraries](
	[itinerary_id] [int] IDENTITY(1,1) NOT NULL,
	[descr] [varchar](200) NULL,
	[distance] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[itinerary_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[parkings]    Script Date: 13.01.2021 9:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parkings](
	[parking_id] [int] IDENTITY(1,1) NOT NULL,
	[parking_address] [varchar](20) NULL,
	[parking_size] [decimal](12, 2) NULL,
	[phone] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[parking_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suppliers]    Script Date: 13.01.2021 9:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suppliers](
	[supplier] [varchar](20) NOT NULL,
	[phone] [varchar](20) NULL,
	[office_address] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[supplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplies]    Script Date: 13.01.2021 9:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplies](
	[supply_id] [int] IDENTITY(1,1) NOT NULL,
	[fuel_type] [varchar](20) NOT NULL,
	[volume] [decimal](12, 2) NOT NULL,
	[supply_date] [date] NULL,
	[supplier] [varchar](20) NULL,
	[tank_id] [int] NOT NULL,
	[cost] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[supply_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tanks]    Script Date: 13.01.2021 9:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tanks](
	[tank_id] [int] IDENTITY(1,1) NOT NULL,
	[fuel_type] [varchar](20) NOT NULL,
	[parking_id] [int] NOT NULL,
	[volume_now] [decimal](12, 2) NOT NULL,
	[volume_max] [decimal](12, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tank_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tech_inspections]    Script Date: 13.01.2021 9:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tech_inspections](
	[inspection_id] [int] IDENTITY(1,1) NOT NULL,
	[car_number] [varchar](20) NOT NULL,
	[condition] [varchar](200) NULL,
	[inspection_date] [date] NULL,
	[mileage] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[inspection_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tech_pass]    Script Date: 13.01.2021 9:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tech_pass](
	[car_number] [varchar](20) NOT NULL,
	[model] [varchar](20) NULL,
	[color] [varchar](10) NULL,
	[car_size] [int] NOT NULL,
	[fuel_tank_volume] [decimal](12, 2) NOT NULL,
	[fuel_type] [varchar](20) NOT NULL,
	[car_class] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[car_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[voyages]    Script Date: 13.01.2021 9:16:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[voyages](
	[voyage_id] [int] IDENTITY(1,1) NOT NULL,
	[itinerary_id] [int] NULL,
	[driver_id] [int] NULL,
	[car_number] [varchar](20) NOT NULL,
	[time_start] [datetime] NOT NULL,
	[time_end] [datetime] NULL,
	[fuel_start] [decimal](12, 2) NULL,
	[fuel_end] [decimal](12, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[voyage_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[cars] ([car_number], [parking_id]) VALUES (N'AX1234TO', 4)
INSERT [dbo].[cars] ([car_number], [parking_id]) VALUES (N'AX1234UU', 5)
INSERT [dbo].[cars] ([car_number], [parking_id]) VALUES (N'AX8182MI', 1)
INSERT [dbo].[cars] ([car_number], [parking_id]) VALUES (N'AX8811PP', 2)
INSERT [dbo].[cars] ([car_number], [parking_id]) VALUES (N'AX9212TY', 2)
INSERT [dbo].[cars] ([car_number], [parking_id]) VALUES (N'BA2137IO', 1)
GO
SET IDENTITY_INSERT [dbo].[drivers] ON 

INSERT [dbo].[drivers] ([driver_id], [name], [DOB], [phone], [driver_address]) VALUES (1, N'Захаров Александр', CAST(N'2001-09-03' AS Date), N'0661234567', N'м. Харків')
INSERT [dbo].[drivers] ([driver_id], [name], [DOB], [phone], [driver_address]) VALUES (2, N'Остап Константин', CAST(N'2001-11-08' AS Date), N'09576543', N'м. Харків')
INSERT [dbo].[drivers] ([driver_id], [name], [DOB], [phone], [driver_address]) VALUES (4, N'Ващенко Іван', CAST(N'2000-12-12' AS Date), N'0689546505', N'м. Ізюм')
INSERT [dbo].[drivers] ([driver_id], [name], [DOB], [phone], [driver_address]) VALUES (5, N'Сараєв Артем', CAST(N'1999-01-01' AS Date), N'0974352423', N'м. Лопань')
INSERT [dbo].[drivers] ([driver_id], [name], [DOB], [phone], [driver_address]) VALUES (6, N'Чернов Кирило', CAST(N'1980-03-03' AS Date), N'0651231231', N'м.Харків')
SET IDENTITY_INSERT [dbo].[drivers] OFF
GO
SET IDENTITY_INSERT [dbo].[itineraries] ON 

INSERT [dbo].[itineraries] ([itinerary_id], [descr], [distance]) VALUES (1, N'Road to Eldorado', CAST(80.00 AS Decimal(12, 2)))
INSERT [dbo].[itineraries] ([itinerary_id], [descr], [distance]) VALUES (2, N'Road to Lopan''', CAST(150.00 AS Decimal(12, 2)))
INSERT [dbo].[itineraries] ([itinerary_id], [descr], [distance]) VALUES (3, N'Kharkiv-Merefa-Kiev', CAST(110.00 AS Decimal(12, 2)))
INSERT [dbo].[itineraries] ([itinerary_id], [descr], [distance]) VALUES (4, N'Kharkiv-Poltava-Kharkiv', CAST(220.00 AS Decimal(12, 2)))
INSERT [dbo].[itineraries] ([itinerary_id], [descr], [distance]) VALUES (5, N'Kharkiv-Sumi-Kharkiv', CAST(320.00 AS Decimal(12, 2)))
INSERT [dbo].[itineraries] ([itinerary_id], [descr], [distance]) VALUES (6, N'From Lopan'' to Kharkiv', CAST(150.00 AS Decimal(12, 2)))
SET IDENTITY_INSERT [dbo].[itineraries] OFF
GO
SET IDENTITY_INSERT [dbo].[parkings] ON 

INSERT [dbo].[parkings] ([parking_id], [parking_address], [parking_size], [phone]) VALUES (1, N'Airport', CAST(125.00 AS Decimal(12, 2)), N'+380673261223')
INSERT [dbo].[parkings] ([parking_id], [parking_address], [parking_size], [phone]) VALUES (2, N'Railway station', CAST(320.00 AS Decimal(12, 2)), N'+380722323712')
INSERT [dbo].[parkings] ([parking_id], [parking_address], [parking_size], [phone]) VALUES (3, N'Mall "Karavan"', CAST(250.00 AS Decimal(12, 2)), N'+380501234312')
INSERT [dbo].[parkings] ([parking_id], [parking_address], [parking_size], [phone]) VALUES (4, N'Mall "Dafi"', CAST(120.00 AS Decimal(12, 2)), N'+380881231323')
INSERT [dbo].[parkings] ([parking_id], [parking_address], [parking_size], [phone]) VALUES (5, N'Centerum', CAST(88.00 AS Decimal(12, 2)), N'+380122312312')
SET IDENTITY_INSERT [dbo].[parkings] OFF
GO
INSERT [dbo].[suppliers] ([supplier], [phone], [office_address]) VALUES (N'OO"FreeCountry"', N'+380684244378', N'Kharkiv, Ukraine')
INSERT [dbo].[suppliers] ([supplier], [phone], [office_address]) VALUES (N'OO"Fuel-ua"', N'+380650123232', N'Kharkiv, Ukraine')
INSERT [dbo].[suppliers] ([supplier], [phone], [office_address]) VALUES (N'OO"LopanFuel"', N'+380773922382', N'Lopan'', Ukraine')
INSERT [dbo].[suppliers] ([supplier], [phone], [office_address]) VALUES (N'PP"KharkivNa"', N'+380971235367', N'Kharkiv, Ukraine')
INSERT [dbo].[suppliers] ([supplier], [phone], [office_address]) VALUES (N'PP"OpenRoad"', N'+380951233211', N'Sumi, Ukraine')
GO
SET IDENTITY_INSERT [dbo].[supplies] ON 

INSERT [dbo].[supplies] ([supply_id], [fuel_type], [volume], [supply_date], [supplier], [tank_id], [cost]) VALUES (2, N'A-95', CAST(200.00 AS Decimal(12, 2)), CAST(N'2020-01-01' AS Date), N'OO"Fuel-ua"', 1, CAST(29.50 AS Decimal(12, 2)))
INSERT [dbo].[supplies] ([supply_id], [fuel_type], [volume], [supply_date], [supplier], [tank_id], [cost]) VALUES (3, N'A-95', CAST(300.00 AS Decimal(12, 2)), CAST(N'2020-01-01' AS Date), N'OO"FreeCountry"', 2, CAST(28.50 AS Decimal(12, 2)))
INSERT [dbo].[supplies] ([supply_id], [fuel_type], [volume], [supply_date], [supplier], [tank_id], [cost]) VALUES (4, N'DF', CAST(150.00 AS Decimal(12, 2)), CAST(N'2020-01-01' AS Date), N'OO"LopanFuel"', 5, CAST(17.50 AS Decimal(12, 2)))
INSERT [dbo].[supplies] ([supply_id], [fuel_type], [volume], [supply_date], [supplier], [tank_id], [cost]) VALUES (5, N'A-92', CAST(400.00 AS Decimal(12, 2)), CAST(N'2020-01-01' AS Date), N'OO"FreeCountry"', 9, CAST(25.00 AS Decimal(12, 2)))
SET IDENTITY_INSERT [dbo].[supplies] OFF
GO
SET IDENTITY_INSERT [dbo].[tanks] ON 

INSERT [dbo].[tanks] ([tank_id], [fuel_type], [parking_id], [volume_now], [volume_max]) VALUES (1, N'A-95', 1, CAST(200.00 AS Decimal(12, 2)), CAST(300.00 AS Decimal(12, 2)))
INSERT [dbo].[tanks] ([tank_id], [fuel_type], [parking_id], [volume_now], [volume_max]) VALUES (2, N'A-95', 2, CAST(300.00 AS Decimal(12, 2)), CAST(300.00 AS Decimal(12, 2)))
INSERT [dbo].[tanks] ([tank_id], [fuel_type], [parking_id], [volume_now], [volume_max]) VALUES (3, N'A-95', 4, CAST(250.00 AS Decimal(12, 2)), CAST(500.00 AS Decimal(12, 2)))
INSERT [dbo].[tanks] ([tank_id], [fuel_type], [parking_id], [volume_now], [volume_max]) VALUES (4, N'A-95', 5, CAST(120.00 AS Decimal(12, 2)), CAST(5000.00 AS Decimal(12, 2)))
INSERT [dbo].[tanks] ([tank_id], [fuel_type], [parking_id], [volume_now], [volume_max]) VALUES (5, N'DF', 1, CAST(150.00 AS Decimal(12, 2)), CAST(250.00 AS Decimal(12, 2)))
INSERT [dbo].[tanks] ([tank_id], [fuel_type], [parking_id], [volume_now], [volume_max]) VALUES (6, N'DF', 2, CAST(250.00 AS Decimal(12, 2)), CAST(250.00 AS Decimal(12, 2)))
INSERT [dbo].[tanks] ([tank_id], [fuel_type], [parking_id], [volume_now], [volume_max]) VALUES (7, N'DF', 4, CAST(400.00 AS Decimal(12, 2)), CAST(500.00 AS Decimal(12, 2)))
INSERT [dbo].[tanks] ([tank_id], [fuel_type], [parking_id], [volume_now], [volume_max]) VALUES (8, N'DF', 5, CAST(150.00 AS Decimal(12, 2)), CAST(3400.00 AS Decimal(12, 2)))
INSERT [dbo].[tanks] ([tank_id], [fuel_type], [parking_id], [volume_now], [volume_max]) VALUES (9, N'A-92', 2, CAST(400.00 AS Decimal(12, 2)), CAST(460.00 AS Decimal(12, 2)))
SET IDENTITY_INSERT [dbo].[tanks] OFF
GO
SET IDENTITY_INSERT [dbo].[tech_inspections] ON 

INSERT [dbo].[tech_inspections] ([inspection_id], [car_number], [condition], [inspection_date], [mileage]) VALUES (1, N'AX1234TO', N'Good', CAST(N'2020-09-03' AS Date), 25000)
INSERT [dbo].[tech_inspections] ([inspection_id], [car_number], [condition], [inspection_date], [mileage]) VALUES (2, N'AX1234TO', N'Good', CAST(N'2020-09-12' AS Date), 30000)
INSERT [dbo].[tech_inspections] ([inspection_id], [car_number], [condition], [inspection_date], [mileage]) VALUES (3, N'AX1234TO', N'Good', CAST(N'2020-11-12' AS Date), 45000)
INSERT [dbo].[tech_inspections] ([inspection_id], [car_number], [condition], [inspection_date], [mileage]) VALUES (4, N'AX8182MI', N'Good', CAST(N'2020-01-01' AS Date), 12000)
INSERT [dbo].[tech_inspections] ([inspection_id], [car_number], [condition], [inspection_date], [mileage]) VALUES (5, N'AX8182MI', N'Normal', CAST(N'2020-09-09' AS Date), 24000)
INSERT [dbo].[tech_inspections] ([inspection_id], [car_number], [condition], [inspection_date], [mileage]) VALUES (6, N'AX9212TY', N'Normal', CAST(N'2018-02-05' AS Date), 120000)
SET IDENTITY_INSERT [dbo].[tech_inspections] OFF
GO
INSERT [dbo].[tech_pass] ([car_number], [model], [color], [car_size], [fuel_tank_volume], [fuel_type], [car_class]) VALUES (N'AX1234TO', N'Niva', N'White', 12, CAST(55.00 AS Decimal(12, 2)), N'A-95', N'B')
INSERT [dbo].[tech_pass] ([car_number], [model], [color], [car_size], [fuel_tank_volume], [fuel_type], [car_class]) VALUES (N'AX1234UU', N'Mercedes', N'Black', 15, CAST(61.00 AS Decimal(12, 2)), N'A-95', N'C')
INSERT [dbo].[tech_pass] ([car_number], [model], [color], [car_size], [fuel_tank_volume], [fuel_type], [car_class]) VALUES (N'AX8182MI', N'Boomer', N'Grey', 15, CAST(60.00 AS Decimal(12, 2)), N'A-95', N'B')
INSERT [dbo].[tech_pass] ([car_number], [model], [color], [car_size], [fuel_tank_volume], [fuel_type], [car_class]) VALUES (N'AX8811PP', N'Volga', N'White', 10, CAST(45.00 AS Decimal(12, 2)), N'A-92', N'C')
INSERT [dbo].[tech_pass] ([car_number], [model], [color], [car_size], [fuel_tank_volume], [fuel_type], [car_class]) VALUES (N'AX9212TY', N'Volvo', N'White', 18, CAST(70.00 AS Decimal(12, 2)), N'DF', N'C')
INSERT [dbo].[tech_pass] ([car_number], [model], [color], [car_size], [fuel_tank_volume], [fuel_type], [car_class]) VALUES (N'BA2137IO', N'Mercedes', N'Blue', 25, CAST(65.00 AS Decimal(12, 2)), N'DF', N'D')
GO
SET IDENTITY_INSERT [dbo].[voyages] ON 

INSERT [dbo].[voyages] ([voyage_id], [itinerary_id], [driver_id], [car_number], [time_start], [time_end], [fuel_start], [fuel_end]) VALUES (1, 1, 1, N'AX1234TO', CAST(N'2020-09-03T14:00:00.000' AS DateTime), CAST(N'2020-09-03T18:00:00.000' AS DateTime), CAST(50.00 AS Decimal(12, 2)), CAST(45.00 AS Decimal(12, 2)))
INSERT [dbo].[voyages] ([voyage_id], [itinerary_id], [driver_id], [car_number], [time_start], [time_end], [fuel_start], [fuel_end]) VALUES (3, 2, 2, N'AX1234UU', CAST(N'2020-06-06T12:00:00.000' AS DateTime), CAST(N'2020-06-06T16:00:00.000' AS DateTime), CAST(60.00 AS Decimal(12, 2)), CAST(50.00 AS Decimal(12, 2)))
INSERT [dbo].[voyages] ([voyage_id], [itinerary_id], [driver_id], [car_number], [time_start], [time_end], [fuel_start], [fuel_end]) VALUES (5, 3, 4, N'AX8182MI', CAST(N'2020-06-12T00:00:00.000' AS DateTime), CAST(N'2020-06-13T12:00:00.000' AS DateTime), CAST(60.00 AS Decimal(12, 2)), CAST(10.00 AS Decimal(12, 2)))
INSERT [dbo].[voyages] ([voyage_id], [itinerary_id], [driver_id], [car_number], [time_start], [time_end], [fuel_start], [fuel_end]) VALUES (7, 4, 5, N'AX9212TY', CAST(N'2020-11-18T12:00:00.000' AS DateTime), NULL, CAST(70.00 AS Decimal(12, 2)), NULL)
INSERT [dbo].[voyages] ([voyage_id], [itinerary_id], [driver_id], [car_number], [time_start], [time_end], [fuel_start], [fuel_end]) VALUES (8, 5, 6, N'BA2137IO', CAST(N'2020-11-18T07:00:00.000' AS DateTime), NULL, CAST(50.00 AS Decimal(12, 2)), NULL)
SET IDENTITY_INSERT [dbo].[voyages] OFF
GO
ALTER TABLE [dbo].[supplies] ADD  DEFAULT ((29.5)) FOR [cost]
GO
ALTER TABLE [dbo].[tech_pass] ADD  DEFAULT ('B') FOR [car_class]
GO
ALTER TABLE [dbo].[cars]  WITH CHECK ADD FOREIGN KEY([parking_id])
REFERENCES [dbo].[parkings] ([parking_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[supplies]  WITH CHECK ADD FOREIGN KEY([supplier])
REFERENCES [dbo].[suppliers] ([supplier])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[supplies]  WITH CHECK ADD FOREIGN KEY([tank_id])
REFERENCES [dbo].[tanks] ([tank_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tanks]  WITH CHECK ADD FOREIGN KEY([parking_id])
REFERENCES [dbo].[parkings] ([parking_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tech_inspections]  WITH CHECK ADD FOREIGN KEY([car_number])
REFERENCES [dbo].[tech_pass] ([car_number])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tech_pass]  WITH CHECK ADD FOREIGN KEY([car_number])
REFERENCES [dbo].[cars] ([car_number])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[voyages]  WITH CHECK ADD FOREIGN KEY([car_number])
REFERENCES [dbo].[cars] ([car_number])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[voyages]  WITH CHECK ADD FOREIGN KEY([driver_id])
REFERENCES [dbo].[drivers] ([driver_id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[voyages]  WITH CHECK ADD FOREIGN KEY([itinerary_id])
REFERENCES [dbo].[itineraries] ([itinerary_id])
ON DELETE SET NULL
GO
USE [master]
GO
ALTER DATABASE [autotp] SET  READ_WRITE 
GO
