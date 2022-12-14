USE [master]
GO
/****** Object:  Database [CoronaManagementSystem]    Script Date: 10/23/2022 10:10:36 AM ******/
CREATE DATABASE [CoronaManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CoronaManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CoronaManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CoronaManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CoronaManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CoronaManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CoronaManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CoronaManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CoronaManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CoronaManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CoronaManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [CoronaManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [CoronaManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CoronaManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CoronaManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CoronaManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CoronaManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CoronaManagementSystem', N'ON'
GO
ALTER DATABASE [CoronaManagementSystem] SET QUERY_STORE = OFF
GO
USE [CoronaManagementSystem]
GO
ALTER DATABASE SCOPED CONFIGURATION SET ACCELERATED_PLAN_FORCING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET BATCH_MODE_ADAPTIVE_JOINS = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET BATCH_MODE_MEMORY_GRANT_FEEDBACK = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET BATCH_MODE_ON_ROWSTORE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET DEFERRED_COMPILATION_TV = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET ELEVATE_ONLINE = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET ELEVATE_RESUMABLE = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET GLOBAL_TEMPORARY_TABLE_AUTO_DROP = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET INTERLEAVED_EXECUTION_TVF = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET ISOLATE_SECURITY_POLICY_CARDINALITY = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LAST_QUERY_PLAN_STATS = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LIGHTWEIGHT_QUERY_PROFILING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET OPTIMIZE_FOR_AD_HOC_WORKLOADS = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET ROW_MODE_MEMORY_GRANT_FEEDBACK = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET TSQL_SCALAR_UDF_INLINING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET VERBOSE_TRUNCATION_WARNINGS = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET XTP_PROCEDURE_EXECUTION_STATISTICS = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET XTP_QUERY_EXECUTION_STATISTICS = OFF;
GO
USE [CoronaManagementSystem]
GO
/****** Object:  Table [dbo].[CoronaDetails]    Script Date: 10/23/2022 10:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoronaDetails](
	[PersonId] [varchar](9) NOT NULL,
	[CoronaVaccine] [date] NULL,
	[CoronaManufacturer] [varchar](20) NULL,
	[PositiveForCorona] [date] NULL,
	[RecoveringFromCorona] [date] NULL,
	[CoronaVaccine2] [date] NULL,
	[CoronaManufacturer2] [varchar](20) NULL,
	[CoronaVaccine3] [date] NULL,
	[CoronaManufacturer3] [varchar](20) NULL,
	[CoronaVaccine4] [date] NULL,
	[CoronaManufacturer4] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserName]    Script Date: 10/23/2022 10:10:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserName](
	[PersonId] [varchar](9) NOT NULL,
	[FullName] [varchar](50) NOT NULL,
	[city] [varchar](20) NULL,
	[Street] [varchar](30) NULL,
	[Phone] [varchar](15) NULL,
	[BirthDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CoronaDetails] ([PersonId], [CoronaVaccine], [CoronaManufacturer], [PositiveForCorona], [RecoveringFromCorona], [CoronaVaccine2], [CoronaManufacturer2], [CoronaVaccine3], [CoronaManufacturer3], [CoronaVaccine4], [CoronaManufacturer4]) VALUES (N'201548852', CAST(N'2022-10-18' AS Date), N'moderna', CAST(N'2022-05-11' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CoronaDetails] ([PersonId], [CoronaVaccine], [CoronaManufacturer], [PositiveForCorona], [RecoveringFromCorona], [CoronaVaccine2], [CoronaManufacturer2], [CoronaVaccine3], [CoronaManufacturer3], [CoronaVaccine4], [CoronaManufacturer4]) VALUES (N'203265598', CAST(N'2022-10-07' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CoronaDetails] ([PersonId], [CoronaVaccine], [CoronaManufacturer], [PositiveForCorona], [RecoveringFromCorona], [CoronaVaccine2], [CoronaManufacturer2], [CoronaVaccine3], [CoronaManufacturer3], [CoronaVaccine4], [CoronaManufacturer4]) VALUES (N'206325562', CAST(N'2022-10-15' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[CoronaDetails] ([PersonId], [CoronaVaccine], [CoronaManufacturer], [PositiveForCorona], [RecoveringFromCorona], [CoronaVaccine2], [CoronaManufacturer2], [CoronaVaccine3], [CoronaManufacturer3], [CoronaVaccine4], [CoronaManufacturer4]) VALUES (N'209225623', CAST(N'2022-10-11' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[UserName] ([PersonId], [FullName], [city], [Street], [Phone], [BirthDate]) VALUES (N'201548852', N'Ari Shunem', N'Haifa', N'Hagefen', N'0542250402', CAST(N'2022-03-02' AS Date))
INSERT [dbo].[UserName] ([PersonId], [FullName], [city], [Street], [Phone], [BirthDate]) VALUES (N'203265598', N'Miri Cohen', N'Tel Aviv', N'Harimon 5', N'058445823', CAST(N'2022-08-17' AS Date))
INSERT [dbo].[UserName] ([PersonId], [FullName], [city], [Street], [Phone], [BirthDate]) VALUES (N'206325562', N'Michal Halevy', N'Kiryat Malachi', N'Shderot Yerushalayim 155', N'0545212415', CAST(N'1990-02-15' AS Date))
INSERT [dbo].[UserName] ([PersonId], [FullName], [city], [Street], [Phone], [BirthDate]) VALUES (N'209225623', N'Chana Shunem', N'Jerusalem', N'Hateena 4', N'0548852115', CAST(N'1993-02-23' AS Date))
ALTER TABLE [dbo].[CoronaDetails]  WITH CHECK ADD FOREIGN KEY([PersonId])
REFERENCES [dbo].[UserName] ([PersonId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [CoronaManagementSystem] SET  READ_WRITE 
GO
