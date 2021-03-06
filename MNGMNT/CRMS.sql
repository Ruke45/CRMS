USE [master]
GO
/****** Object:  Database [CRMS]    Script Date: 3/17/2019 10:13:41 AM ******/
CREATE DATABASE [CRMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CRMS', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CRMS.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CRMS_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CRMS_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CRMS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CRMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CRMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CRMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CRMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CRMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CRMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [CRMS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CRMS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [CRMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CRMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CRMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CRMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CRMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CRMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CRMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CRMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CRMS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CRMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CRMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CRMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CRMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CRMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CRMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CRMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CRMS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CRMS] SET  MULTI_USER 
GO
ALTER DATABASE [CRMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CRMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CRMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CRMS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [CRMS]
GO
/****** Object:  StoredProcedure [dbo].[ViewProduct]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[ViewProduct]
as begin

Select PortfolioID, ProductOwner, NameofProduct, LaunchedDate, E.EmployeeName, S.ProductStatus, ProductDuration, CancledReason, ProductLifeCycle, Description
From tblProduct P , tblEmployee E, tblProductStatus S
Where P.AnalysisID = E.EmployeeID
And P.ProductStatus = S.StatusId

End
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[CustomerID] [bigint] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Telephone] [varchar](50) NOT NULL,
	[Address] [nchar](10) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblCustomer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[EmployeeID] [bigint] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [varchar](50) NOT NULL,
	[Designation] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEmpPerformance]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmpPerformance](
	[EmployeeId] [bigint] NOT NULL,
	[TaskId] [bigint] NOT NULL,
	[PerformanceLevel] [varchar](50) NOT NULL,
	[Notes] [varchar](150) NULL,
	[Index] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tblEmpPerformance] PRIMARY KEY CLUSTERED 
(
	[Index] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblKPIAllocations]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblKPIAllocations](
	[TaskId] [bigint] NOT NULL,
	[TaskName] [varchar](50) NOT NULL,
	[TaskLevel] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[TaskDuration] [int] NOT NULL,
	[AllocatedDate] [date] NULL,
	[FinishedDate] [date] NULL,
	[SupervisorId] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblProduct]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProduct](
	[PortfolioID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductOwner] [varchar](50) NOT NULL,
	[NameofProduct] [varchar](50) NOT NULL,
	[LaunchedDate] [datetime] NOT NULL,
	[AnalysisID] [varchar](50) NULL,
	[ProductStatus] [varchar](50) NULL,
	[ProductDuration] [varchar](50) NOT NULL,
	[CancledReason] [varchar](50) NULL,
	[ProductLifeCycle] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_tblProduct] PRIMARY KEY CLUSTERED 
(
	[PortfolioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblProductBudget]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProductBudget](
	[ProductId] [bigint] NOT NULL,
	[PlanedBudget] [varchar](10) NOT NULL,
	[PlanedBudgetDescription] [varchar](150) NOT NULL,
	[ActualBudget] [varchar](10) NULL,
	[ActualBudgetDescription] [varchar](150) NULL,
	[Index] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ProductBudget] PRIMARY KEY CLUSTERED 
(
	[Index] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblProductDelivery]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProductDelivery](
	[PortfolioID] [bigint] NOT NULL,
	[FinishedDate] [datetime] NULL,
	[Notes] [varchar](150) NULL,
 CONSTRAINT [PK_tblProductDelivery] PRIMARY KEY CLUSTERED 
(
	[PortfolioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblProductStatus]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProductStatus](
	[ProductStatus] [varchar](50) NOT NULL,
	[StatusId] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tblProductStatus] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblProjectIssues]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProjectIssues](
	[IssueId] [bigint] NOT NULL,
	[TaskId] [bigint] NULL,
	[IssueTitle] [varchar](50) NULL,
	[Description] [varchar](150) NULL,
	[IsFixed] [varchar](5) NULL,
 CONSTRAINT [PK_tblProjectIssues] PRIMARY KEY CLUSTERED 
(
	[IssueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTaskCategory]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTaskCategory](
	[TaskCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](150) NULL,
 CONSTRAINT [PK_tblTaskCategory] PRIMARY KEY CLUSTERED 
(
	[TaskCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTimeSheet]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTimeSheet](
	[EmployeeID] [bigint] NOT NULL,
	[ArrivedTime] [datetime] NOT NULL,
	[OffTime] [datetime] NOT NULL,
	[Index] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tblTimeSheet] PRIMARY KEY CLUSTERED 
(
	[Index] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUserLogin]    Script Date: 3/17/2019 10:13:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUserLogin](
	[UserID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[RefID] [bigint] NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tblUserLogin] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [CRMS] SET  READ_WRITE 
GO
