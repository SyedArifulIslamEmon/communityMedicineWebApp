USE [master]
GO
/****** Object:  Database [CommunityMedicineDB]    Script Date: 7/3/2015 2:46:09 AM ******/
CREATE DATABASE [CommunityMedicineDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CommunityMedicineDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CommunityMedicineDB.mdf' , SIZE = 2560KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CommunityMedicineDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CommunityMedicineDB_log.ldf' , SIZE = 528KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CommunityMedicineDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CommunityMedicineDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CommunityMedicineDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CommunityMedicineDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [CommunityMedicineDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CommunityMedicineDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CommunityMedicineDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CommunityMedicineDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CommunityMedicineDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CommunityMedicineDB] SET  MULTI_USER 
GO
ALTER DATABASE [CommunityMedicineDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CommunityMedicineDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CommunityMedicineDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CommunityMedicineDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [CommunityMedicineDB]
GO
/****** Object:  Table [dbo].[Center_Medicine_Relation_tbl]    Script Date: 7/3/2015 2:46:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Center_Medicine_Relation_tbl](
	[center_medicine_id] [int] IDENTITY(1,1) NOT NULL,
	[center_id] [int] NOT NULL,
	[medicine_id] [int] NOT NULL,
	[medicine_quantity] [int] NOT NULL,
	[date] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Center_Medicine_Relation_tbl] PRIMARY KEY CLUSTERED 
(
	[center_medicine_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Center_tbl]    Script Date: 7/3/2015 2:46:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Center_tbl](
	[center_id] [int] IDENTITY(1,1) NOT NULL,
	[center_name] [varchar](50) NOT NULL,
	[center_code] [varchar](50) NOT NULL,
	[center_password] [varchar](50) NOT NULL,
	[thana_id] [int] NOT NULL,
 CONSTRAINT [PK_Center_tbl] PRIMARY KEY CLUSTERED 
(
	[center_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Disease_tbl]    Script Date: 7/3/2015 2:46:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Disease_tbl](
	[disease_id] [int] IDENTITY(1,1) NOT NULL,
	[disease_name] [varchar](50) NOT NULL,
	[disease_description] [text] NOT NULL,
	[treatement_procedure] [text] NOT NULL,
 CONSTRAINT [PK_Disease_tbl] PRIMARY KEY CLUSTERED 
(
	[disease_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[District_tbl]    Script Date: 7/3/2015 2:46:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[District_tbl](
	[district_id] [int] IDENTITY(1,1) NOT NULL,
	[district_name] [varchar](50) NULL,
	[district_population] [int] NULL,
 CONSTRAINT [PK_District_tbl] PRIMARY KEY CLUSTERED 
(
	[district_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Doctor_tbl]    Script Date: 7/3/2015 2:46:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doctor_tbl](
	[doctor_id] [int] IDENTITY(1,1) NOT NULL,
	[doctor_name] [varchar](50) NOT NULL,
	[doctor_degree] [varchar](50) NOT NULL,
	[doctor_specialization] [varchar](50) NOT NULL,
	[center_id] [int] NULL,
 CONSTRAINT [PK_Docter_tbl] PRIMARY KEY CLUSTERED 
(
	[doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Medicine_tbl]    Script Date: 7/3/2015 2:46:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medicine_tbl](
	[medicine_id] [int] IDENTITY(1,1) NOT NULL,
	[medicine_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Medicine_tbl] PRIMARY KEY CLUSTERED 
(
	[medicine_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patient_tbl]    Script Date: 7/3/2015 2:46:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patient_tbl](
	[patient_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_voter_id] [varchar](50) NOT NULL,
	[patient__name] [varchar](50) NOT NULL,
	[patient_address] [varchar](50) NOT NULL,
	[patient_age] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Patient_tbl] PRIMARY KEY CLUSTERED 
(
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Thana_tbl]    Script Date: 7/3/2015 2:46:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Thana_tbl](
	[thana_id] [int] IDENTITY(1,1) NOT NULL,
	[thana_name] [varchar](50) NOT NULL,
	[district_id] [int] NOT NULL,
 CONSTRAINT [PK_Thana_tbl] PRIMARY KEY CLUSTERED 
(
	[thana_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Treatment_tbl]    Script Date: 7/3/2015 2:46:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Treatment_tbl](
	[treatment_id] [int] IDENTITY(1,1) NOT NULL,
	[disease_id] [int] NOT NULL,
	[patient_id] [varchar](50) NOT NULL,
	[medicine_id] [int] NOT NULL,
	[dose] [varchar](50) NOT NULL,
	[beforeOrAfter] [varchar](50) NOT NULL,
	[medicine_quantity] [int] NOT NULL,
	[note] [varchar](500) NOT NULL,
	[treatment_date] [varchar](50) NOT NULL,
	[treatment_count] [int] NOT NULL,
	[center_id] [int] NOT NULL,
 CONSTRAINT [PK_Treatment_tbl] PRIMARY KEY CLUSTERED 
(
	[treatment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [CommunityMedicineDB] SET  READ_WRITE 
GO
