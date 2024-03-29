USE [master]
GO
/****** Object:  Database [PSI20L_JoaoValente_2220071]    Script Date: 28/06/2022 16:55:07 ******/
CREATE DATABASE [PSI20L_JoaoValente_2220071]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PSI20L_JoaoValente_2220071', FILENAME = N'/var/opt/mssql/data/PSI20L_JoaoValente_2220071.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PSI20L_JoaoValente_2220071_log', FILENAME = N'/var/opt/mssql/data/PSI20L_JoaoValente_2220071_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PSI20L_JoaoValente_2220071].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET ARITHABORT OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET RECOVERY FULL 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET  MULTI_USER 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PSI20L_JoaoValente_2220071', N'ON'
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET QUERY_STORE = OFF
GO
USE [PSI20L_JoaoValente_2220071]
GO
/****** Object:  Table [dbo].[carrinho]    Script Date: 28/06/2022 16:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carrinho](
	[nome] [varchar](50) NULL,
	[preco] [varchar](20) NULL,
	[pessoa] [varchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_carrinho] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[carrinhoo]    Script Date: 28/06/2022 16:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carrinhoo](
	[nome] [varchar](50) NULL,
	[preco] [varchar](30) NULL,
	[pessoa] [varchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_carrinhoo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 28/06/2022 16:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[nome] [varchar](50) NOT NULL,
	[senha] [varchar](15) NULL,
	[id_montar] [int] NULL,
	[id_reparar] [int] NULL,
	[id_computadores] [nchar](10) NULL,
	[id_perifericos] [int] NULL,
 CONSTRAINT [PK_cliente_1] PRIMARY KEY CLUSTERED 
(
	[nome] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[computadores]    Script Date: 28/06/2022 16:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[computadores](
	[ID] [nchar](10) NOT NULL,
	[nome] [varchar](50) NULL,
	[preco] [int] NULL,
 CONSTRAINT [PK_computadores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[funcionario]    Script Date: 28/06/2022 16:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[funcionario](
	[ID] [int] NOT NULL,
	[senha] [varchar](20) NULL,
	[nome] [varchar](20) NULL,
 CONSTRAINT [PK_funcionario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[montar]    Script Date: 28/06/2022 16:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[montar](
	[PLACA_GRAFICA] [varchar](500) NOT NULL,
	[PLACA_MAE] [varchar](500) NOT NULL,
	[PROCESSADOR] [varchar](500) NOT NULL,
	[FONTE] [varchar](500) NOT NULL,
	[RAM] [varchar](500) NOT NULL,
	[VENTOINHA] [varchar](500) NOT NULL,
	[DISCO] [varchar](500) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[pessoa] [varchar](50) NULL,
 CONSTRAINT [PK_montar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perifericos]    Script Date: 28/06/2022 16:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perifericos](
	[ID] [int] NOT NULL,
	[nome] [varchar](50) NULL,
	[preco] [int] NULL,
 CONSTRAINT [PK_perifericos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reparar]    Script Date: 28/06/2022 16:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reparar](
	[NSERIE] [varchar](500) NOT NULL,
	[MARCA] [varchar](500) NOT NULL,
	[NOME] [varchar](500) NOT NULL,
	[PECA_AVARIADA] [varchar](500) NOT NULL,
	[TIPO_DE_PROBLEMA] [varchar](500) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[pessoa] [varchar](50) NULL,
 CONSTRAINT [PK_reparar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[cliente] ([nome], [senha], [id_montar], [id_reparar], [id_computadores], [id_perifericos]) VALUES (N'1', N'1', NULL, NULL, NULL, NULL)
INSERT [dbo].[cliente] ([nome], [senha], [id_montar], [id_reparar], [id_computadores], [id_perifericos]) VALUES (N'2', N'2', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[computadores] ([ID], [nome], [preco]) VALUES (N'1         ', N'ASUS R5 16GB 512GB GTX 1660 TI', 1400)
INSERT [dbo].[computadores] ([ID], [nome], [preco]) VALUES (N'2         ', N'MSI i3 8GB 500GB GTX 1650', 1700)
INSERT [dbo].[computadores] ([ID], [nome], [preco]) VALUES (N'3         ', N'Gigabyte R5 16GB 512GB GTX', 3000)
INSERT [dbo].[computadores] ([ID], [nome], [preco]) VALUES (N'4         ', N'MSI i5 16GB 500GB RTX 3060 TI', 1200)
GO
INSERT [dbo].[funcionario] ([ID], [senha], [nome]) VALUES (2, N'1234', N'funcionario')
GO
INSERT [dbo].[perifericos] ([ID], [nome], [preco]) VALUES (1, N'3080 RTX', 900)
INSERT [dbo].[perifericos] ([ID], [nome], [preco]) VALUES (2, N'I9-9900K', 650)
INSERT [dbo].[perifericos] ([ID], [nome], [preco]) VALUES (3, N'Logitech G PRO X', 120)
INSERT [dbo].[perifericos] ([ID], [nome], [preco]) VALUES (4, N'Logitech G502 HERO', 80)
INSERT [dbo].[perifericos] ([ID], [nome], [preco]) VALUES (5, N'ATX MSI MPG B550', 170)
INSERT [dbo].[perifericos] ([ID], [nome], [preco]) VALUES (6, N'ROG SWIFT PG259QN IPS', 700)
INSERT [dbo].[perifericos] ([ID], [nome], [preco]) VALUES (7, N'Logitech G915', 140)
INSERT [dbo].[perifericos] ([ID], [nome], [preco]) VALUES (8, N'Seagate IronWolf 4TB', 120)
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK__cliente__id_comp__66603565] FOREIGN KEY([id_computadores])
REFERENCES [dbo].[computadores] ([ID])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK__cliente__id_comp__66603565]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK__cliente__id_mont__6477ECF3] FOREIGN KEY([id_montar])
REFERENCES [dbo].[montar] ([ID])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK__cliente__id_mont__6477ECF3]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK__cliente__id_peri__6754599E] FOREIGN KEY([id_perifericos])
REFERENCES [dbo].[perifericos] ([ID])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK__cliente__id_peri__6754599E]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK__cliente__id_repa__656C112C] FOREIGN KEY([id_reparar])
REFERENCES [dbo].[reparar] ([ID])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK__cliente__id_repa__656C112C]
GO
USE [master]
GO
ALTER DATABASE [PSI20L_JoaoValente_2220071] SET  READ_WRITE 
GO
