USE [master]
GO
/****** Object:  Database [BireyselEmeklilikSistemi]    Script Date: 25.12.2017 06:59:05 ******/
CREATE DATABASE [BireyselEmeklilikSistemi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BireyselEmeklilikSistemi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\BireyselEmeklilikSistemi.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BireyselEmeklilikSistemi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\BireyselEmeklilikSistemi_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BireyselEmeklilikSistemi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET ARITHABORT OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET  MULTI_USER 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BireyselEmeklilikSistemi]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 25.12.2017 06:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Musteri](
	[TC] [varchar](11) NOT NULL,
	[Ad] [varchar](20) NULL,
	[Soyad] [varchar](50) NULL,
	[CepTelefonu] [varchar](10) NULL,
	[SabitTelefon] [varchar](10) NULL,
	[DogumTarihi] [varchar](10) NULL,
	[Eposta] [varchar](50) NULL,
	[Adres] [varchar](150) NULL,
 CONSTRAINT [pk_musteri] PRIMARY KEY CLUSTERED 
(
	[TC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OdemePlani]    Script Date: 25.12.2017 06:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OdemePlani](
	[TC] [varchar](11) NOT NULL,
	[BaslangicTarihi] [varchar](15) NULL,
	[SonOdemeTarihi] [varchar](15) NULL,
	[OdemePeriyodu] [varchar](15) NULL,
	[OdemeMiktari] [varchar](15) NULL,
	[DevletKatkisi] [varchar](15) NULL,
	[OdemeSekli] [varchar](25) NULL,
 CONSTRAINT [pk_odemeplani] PRIMARY KEY CLUSTERED 
(
	[TC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OdemeTakip]    Script Date: 25.12.2017 06:59:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OdemeTakip](
	[TC] [varchar](11) NOT NULL,
	[BirikenTutar] [int] NULL,
 CONSTRAINT [pk_odemetakip] PRIMARY KEY CLUSTERED 
(
	[TC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Musteri] ([TC], [Ad], [Soyad], [CepTelefonu], [SabitTelefon], [DogumTarihi], [Eposta], [Adres]) VALUES (N'36020202020', N'Hale', N'Yıldız', N'5321402154', N'2124523811', N'09.10.1990', N'hale90@gmail.com', N'İstanbul')
INSERT [dbo].[Musteri] ([TC], [Ad], [Soyad], [CepTelefonu], [SabitTelefon], [DogumTarihi], [Eposta], [Adres]) VALUES (N'36232323232', N'Burak', N'Kara', N'5438986541', N'2127496102', N'11.12.1978', N'burak78@gmail.com', N'İstanbul')
INSERT [dbo].[Musteri] ([TC], [Ad], [Soyad], [CepTelefonu], [SabitTelefon], [DogumTarihi], [Eposta], [Adres]) VALUES (N'39121212121', N'Emir', N'Yılmaz', N'5078964644', N'2326565262', N'06.07.1970', N'emir7@gmail.com', N'İzmir')
INSERT [dbo].[Musteri] ([TC], [Ad], [Soyad], [CepTelefonu], [SabitTelefon], [DogumTarihi], [Eposta], [Adres]) VALUES (N'39141414141', N'Metin', N'Çalışkan', N'5326946462', N'2325656464', N'18.09.1986', N'metin86@gmail.com', N'İzmir')
INSERT [dbo].[Musteri] ([TC], [Ad], [Soyad], [CepTelefonu], [SabitTelefon], [DogumTarihi], [Eposta], [Adres]) VALUES (N'39565656565', N'Ece', N'Solmaz', N'5326495694', N'2326467646', N'21.06.1979', N'ece79@gmail.com', N'İzmir')
INSERT [dbo].[Musteri] ([TC], [Ad], [Soyad], [CepTelefonu], [SabitTelefon], [DogumTarihi], [Eposta], [Adres]) VALUES (N'39898989898', N'Pınar', N'Demir', N'5329466646', N'2329565665', N'17.02.1985', N'pinar85@gmail.com', N'İzmir')
INSERT [dbo].[OdemePlani] ([TC], [BaslangicTarihi], [SonOdemeTarihi], [OdemePeriyodu], [OdemeMiktari], [DevletKatkisi], [OdemeSekli]) VALUES (N'36020202020', N'25-12-2017', N'25.02.2018', N'6', N'150', N'37,5', N'Otomatik Ödeme')
INSERT [dbo].[OdemePlani] ([TC], [BaslangicTarihi], [SonOdemeTarihi], [OdemePeriyodu], [OdemeMiktari], [DevletKatkisi], [OdemeSekli]) VALUES (N'36232323232', N'19-12-2017', N'19.05.2018', N'12', N'100', N'25', N'Havale')
INSERT [dbo].[OdemePlani] ([TC], [BaslangicTarihi], [SonOdemeTarihi], [OdemePeriyodu], [OdemeMiktari], [DevletKatkisi], [OdemeSekli]) VALUES (N'39121212121', N'07-07-2005', N'07.03.2017', N'3', N'200', N'50', N'Otomatik Ödeme')
INSERT [dbo].[OdemePlani] ([TC], [BaslangicTarihi], [SonOdemeTarihi], [OdemePeriyodu], [OdemeMiktari], [DevletKatkisi], [OdemeSekli]) VALUES (N'39141414141', N'14-05-2014', N'15-05-2014', N'3', N'300', N'75', N'Havale')
INSERT [dbo].[OdemePlani] ([TC], [BaslangicTarihi], [SonOdemeTarihi], [OdemePeriyodu], [OdemeMiktari], [DevletKatkisi], [OdemeSekli]) VALUES (N'39565656565', N'24-12-2017', N'24.12.2029', N'1', N'112', N'28', N'Otomatik Ödeme')
INSERT [dbo].[OdemePlani] ([TC], [BaslangicTarihi], [SonOdemeTarihi], [OdemePeriyodu], [OdemeMiktari], [DevletKatkisi], [OdemeSekli]) VALUES (N'39898989898', N'24-12-2017', N'24-12-2017', N'6', N'100', N'25', N'Kredi Kartı')
INSERT [dbo].[OdemeTakip] ([TC], [BirikenTutar]) VALUES (N'36020202020', 187)
INSERT [dbo].[OdemeTakip] ([TC], [BirikenTutar]) VALUES (N'36232323232', 625)
INSERT [dbo].[OdemeTakip] ([TC], [BirikenTutar]) VALUES (N'39121212121', 8750)
INSERT [dbo].[OdemeTakip] ([TC], [BirikenTutar]) VALUES (N'39141414141', 0)
INSERT [dbo].[OdemeTakip] ([TC], [BirikenTutar]) VALUES (N'39565656565', 1680)
INSERT [dbo].[OdemeTakip] ([TC], [BirikenTutar]) VALUES (N'39898989898', 0)
ALTER TABLE [dbo].[OdemePlani]  WITH CHECK ADD  CONSTRAINT [fk_odemeplani] FOREIGN KEY([TC])
REFERENCES [dbo].[Musteri] ([TC])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OdemePlani] CHECK CONSTRAINT [fk_odemeplani]
GO
ALTER TABLE [dbo].[OdemeTakip]  WITH CHECK ADD  CONSTRAINT [fk_odemetakip] FOREIGN KEY([TC])
REFERENCES [dbo].[Musteri] ([TC])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OdemeTakip] CHECK CONSTRAINT [fk_odemetakip]
GO
USE [master]
GO
ALTER DATABASE [BireyselEmeklilikSistemi] SET  READ_WRITE 
GO
