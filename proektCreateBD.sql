USE [master]
GO
/****** Object:  Database [proekt]    Script Date: 19.06.2022 15:56:52 ******/
CREATE DATABASE [proekt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proekt', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\proekt.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proekt_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\proekt_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proekt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proekt] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proekt] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proekt] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proekt] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proekt] SET ARITHABORT OFF 
GO
ALTER DATABASE [proekt] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [proekt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proekt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proekt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proekt] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proekt] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proekt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proekt] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proekt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proekt] SET  ENABLE_BROKER 
GO
ALTER DATABASE [proekt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proekt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proekt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proekt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proekt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proekt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proekt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proekt] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [proekt] SET  MULTI_USER 
GO
ALTER DATABASE [proekt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proekt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proekt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proekt] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proekt] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [proekt] SET QUERY_STORE = OFF
GO
USE [proekt]
GO
/****** Object:  Table [dbo].[norm]    Script Date: 19.06.2022 15:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[norm](
	[id_detail] [int] NOT NULL,
	[id_oper] [int] NOT NULL,
	[id_prof] [int] NULL,
	[razryad] [int] NULL,
	[id_work] [int] NULL,
	[time_all] [varchar](10) NULL,
	[time_one] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detail] ASC,
	[id_oper] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sostav]    Script Date: 19.06.2022 15:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sostav](
	[id_worker] [int] NOT NULL,
	[id_ceh] [int] NULL,
	[id_uch] [int] NULL,
	[id_prof] [int] NULL,
	[razryad] [int] NULL,
	[family] [varchar](20) NULL,
	[FIO] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_worker] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uchet]    Script Date: 19.06.2022 15:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uchet](
	[id_worker] [int] NOT NULL,
	[date_work] [date] NOT NULL,
	[id_detail] [int] NOT NULL,
	[id_oper] [int] NOT NULL,
	[kolvo_good] [int] NULL,
	[kolvo_bad] [int] NULL,
	[proc_brak] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_worker] ASC,
	[date_work] ASC,
	[id_detail] ASC,
	[id_oper] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[NormSosUch]    Script Date: 19.06.2022 15:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[NormSosUch] AS
	select u.id_worker as [Номер рабочего],
	u.id_detail as [Номер детали],
			u.id_oper as [Номер операции],
			u.date_work as [Дата выполнения работ],
			n.id_prof as [Номер профессии],
			n.razryad as [Разряд рабочего],
			n.time_all as [Время выполнения работы],
			s.id_ceh as [Номер цеха],
			s.id_uch as [Номер участка],
			u.kolvo_bad as [Количество брака],
			u.kolvo_good as [Количество годных деталей],
			s.FIO as [ФИО]
from uchet u
join norm n on u.id_detail = n.id_detail and u.id_oper = n.id_oper
join sostav s on s.id_worker = u.id_worker
GO
INSERT [dbo].[norm] ([id_detail], [id_oper], [id_prof], [razryad], [id_work], [time_all], [time_one]) VALUES (1, 1, 1, 1, 1, N'40 мин.', 5)
GO
INSERT [dbo].[norm] ([id_detail], [id_oper], [id_prof], [razryad], [id_work], [time_all], [time_one]) VALUES (1, 2, 3, 1, 1, N'200 мин.', 11)
GO
INSERT [dbo].[norm] ([id_detail], [id_oper], [id_prof], [razryad], [id_work], [time_all], [time_one]) VALUES (2, 2, 10, 3, 2, N'360 мин.', 10)
GO
INSERT [dbo].[norm] ([id_detail], [id_oper], [id_prof], [razryad], [id_work], [time_all], [time_one]) VALUES (3, 3, 2, 4, 5, N'45 мин.', 20)
GO
INSERT [dbo].[norm] ([id_detail], [id_oper], [id_prof], [razryad], [id_work], [time_all], [time_one]) VALUES (4, 1, 10, 3, 4, N'30 мин.', 15)
GO
INSERT [dbo].[sostav] ([id_worker], [id_ceh], [id_uch], [id_prof], [razryad], [family], [FIO]) VALUES (1, 1, 3, 1, 1, N'Не женат', N'Иванов И.И.')
GO
INSERT [dbo].[sostav] ([id_worker], [id_ceh], [id_uch], [id_prof], [razryad], [family], [FIO]) VALUES (2, 1, 2, 10, 3, N'Женат', N'Петров П.П.')
GO
INSERT [dbo].[sostav] ([id_worker], [id_ceh], [id_uch], [id_prof], [razryad], [family], [FIO]) VALUES (3, 2, 1, 2, 4, N'Замужем', N'Усманова М.А.')
GO
INSERT [dbo].[sostav] ([id_worker], [id_ceh], [id_uch], [id_prof], [razryad], [family], [FIO]) VALUES (4, 3, 5, 1, 1, N'Свободна', N'Сидорова У.П.')
GO
INSERT [dbo].[uchet] ([id_worker], [date_work], [id_detail], [id_oper], [kolvo_good], [kolvo_bad], [proc_brak]) VALUES (1, CAST(N'2019-05-09' AS Date), 1, 1, 100, 1, N'3%')
GO
INSERT [dbo].[uchet] ([id_worker], [date_work], [id_detail], [id_oper], [kolvo_good], [kolvo_bad], [proc_brak]) VALUES (1, CAST(N'2020-02-12' AS Date), 1, 2, 1000, 2, N'3%')
GO
INSERT [dbo].[uchet] ([id_worker], [date_work], [id_detail], [id_oper], [kolvo_good], [kolvo_bad], [proc_brak]) VALUES (2, CAST(N'2001-01-01' AS Date), 4, 1, 1, 20, N'2%')
GO
INSERT [dbo].[uchet] ([id_worker], [date_work], [id_detail], [id_oper], [kolvo_good], [kolvo_bad], [proc_brak]) VALUES (2, CAST(N'2016-11-08' AS Date), 2, 2, 250, 25, N'3%')
GO
INSERT [dbo].[uchet] ([id_worker], [date_work], [id_detail], [id_oper], [kolvo_good], [kolvo_bad], [proc_brak]) VALUES (3, CAST(N'2020-03-09' AS Date), 3, 3, 5, 0, N'3%')
GO
INSERT [dbo].[uchet] ([id_worker], [date_work], [id_detail], [id_oper], [kolvo_good], [kolvo_bad], [proc_brak]) VALUES (4, CAST(N'2020-03-03' AS Date), 1, 1, 100, 0, N'1%')
GO
ALTER TABLE [dbo].[norm] ADD  DEFAULT ('30 мин.') FOR [time_all]
GO
ALTER TABLE [dbo].[sostav] ADD  DEFAULT ('Свободен(на)') FOR [family]
GO
ALTER TABLE [dbo].[uchet] ADD  DEFAULT ('3%') FOR [proc_brak]
GO
ALTER TABLE [dbo].[uchet]  WITH CHECK ADD FOREIGN KEY([id_detail], [id_oper])
REFERENCES [dbo].[norm] ([id_detail], [id_oper])
GO
ALTER TABLE [dbo].[uchet]  WITH CHECK ADD FOREIGN KEY([id_worker])
REFERENCES [dbo].[sostav] ([id_worker])
GO
/****** Object:  StoredProcedure [dbo].[A_proc]    Script Date: 19.06.2022 15:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[A_proc](
@id_worker int,
@kolvo_good int output
)
as
begin
set @kolvo_good= (select SUM(uchet.kolvo_good) FROM uchet
where uchet.id_worker = @id_worker)
end
GO
/****** Object:  StoredProcedure [dbo].[C]    Script Date: 19.06.2022 15:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[C](
@code_prod int,
@money int output
)
as
begin
set @money= (select details.target_unit_price FROM details
WHERE details.product_id=@code_prod)*
(select SUM(shipment.number) FROM shipment
where shipment.code_product= @code_prod)
end
GO
/****** Object:  StoredProcedure [dbo].[kolvoDet]    Script Date: 19.06.2022 15:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[kolvoDet](
@id_detail int,
@kolvo int output
)
as
begin
set @kolvo= (select SUM(detail.kolvo) FROM detail
where detail.id_detail = @id_detail)
end
GO
/****** Object:  Trigger [dbo].[A_trigger]    Script Date: 19.06.2022 15:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[A_trigger]
ON [dbo].[norm]
INSTEAD OF DELETE AS
BEGIN
	DELETE FROM uchet
			WHERE id_detail IN (SELECT id_detail FROM DELETED) AND id_oper IN (SELECT id_oper FROM DELETED)
			DELETE FROM norm
				WHERE id_detail IN (SELECT id_detail FROM DELETED) AND id_oper IN (SELECT id_oper FROM DELETED)
			END
GO
ALTER TABLE [dbo].[norm] ENABLE TRIGGER [A_trigger]
GO
/****** Object:  Trigger [dbo].[B_trigger]    Script Date: 19.06.2022 15:56:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[B_trigger]
ON [dbo].[norm]
AFTER INSERT AS 
BEGIN
    UPDATE uchet
    SET kolvo_good=kolvo_good+1
    WHERE exists ( select * from inserted i where i.id_detail=uchet.id_detail and i.id_oper=uchet.id_oper)
END
GO
ALTER TABLE [dbo].[norm] ENABLE TRIGGER [B_trigger]
GO
USE [master]
GO
ALTER DATABASE [proekt] SET  READ_WRITE 
GO
