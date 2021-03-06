USE [master]
GO
/****** Object:  Database [School]    Script Date: 09/02/2018 00:15:02 ******/
CREATE DATABASE [School] ON  PRIMARY 
( NAME = N'School', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.PUSHPARAJ\MSSQL\DATA\School.mdf' , SIZE = 19456KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'School_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.PUSHPARAJ\MSSQL\DATA\School_log.ldf' , SIZE = 199296KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [School] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [School].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [School] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [School] SET ANSI_NULLS OFF
GO
ALTER DATABASE [School] SET ANSI_PADDING OFF
GO
ALTER DATABASE [School] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [School] SET ARITHABORT OFF
GO
ALTER DATABASE [School] SET AUTO_CLOSE ON
GO
ALTER DATABASE [School] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [School] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [School] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [School] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [School] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [School] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [School] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [School] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [School] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [School] SET  DISABLE_BROKER
GO
ALTER DATABASE [School] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [School] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [School] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [School] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [School] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [School] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [School] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [School] SET  READ_WRITE
GO
ALTER DATABASE [School] SET RECOVERY SIMPLE
GO
ALTER DATABASE [School] SET  MULTI_USER
GO
ALTER DATABASE [School] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [School] SET DB_CHAINING OFF
GO
USE [School]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09/02/2018 00:15:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](20) NULL,
	[pass] [varchar](20) NULL,
	[picture] [varchar](500) NULL,
	[username] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sub]    Script Date: 09/02/2018 00:15:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sub](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[remark]    Script Date: 09/02/2018 00:15:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[remark](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PA]    Script Date: 09/02/2018 00:15:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PA](
	[id] [smallint] NOT NULL,
	[name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[designation]    Script Date: 09/02/2018 00:15:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[designation](
	[name] [varchar](100) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dates]    Script Date: 09/02/2018 00:15:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dates](
	[value] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[class]    Script Date: 09/02/2018 00:15:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[class](
	[class] [varchar](50) NULL,
	[section] [varchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[gender]    Script Date: 09/02/2018 00:15:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[gender](
	[id] [smallint] NOT NULL,
	[name] [varchar](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[fn_id]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_id](@name varchar(30),@section varchar(30))
returns int
as
begin 
declare @id int
select @id = id from class where class =@name and section = @section 
return @id
end
GO
/****** Object:  Table [dbo].[students]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[students](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[Fname] [varchar](50) NULL,
	[Mname] [varchar](50) NULL,
	[Rnumber] [int] NULL,
	[age] [smallint] NULL,
	[address] [varchar](100) NULL,
	[Phone] [numeric](10, 0) NULL,
	[picture] [varchar](100) NULL,
	[email] [varchar](50) NULL,
	[dob] [date] NULL,
	[gender] [smallint] NOT NULL,
	[class] [int] NULL,
	[amount] [numeric](10, 3) NULL,
	[due] [numeric](10, 3) NULL,
	[leaves] [int] NULL,
 CONSTRAINT [PK_students] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[teacher]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[teacher](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[gender] [smallint] NULL,
	[age] [smallint] NULL,
	[dob] [date] NULL,
	[designation] [int] NULL,
	[qualification] [varchar](100) NULL,
	[address] [varchar](100) NULL,
	[phone] [numeric](10, 0) NULL,
	[email] [varchar](50) NULL,
	[fee] [numeric](10, 2) NULL,
	[dates] [date] NULL,
	[pic] [varchar](100) NULL,
	[leaves] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tattendance]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tattendance](
	[dates] [date] NULL,
	[attendance] [smallint] NULL,
	[id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[show_students]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_students](@name varchar(50))  
returns table    
as    
return (select S.name as [Student Name],  
S.Fname as [Father's Name],  
S.Mname as [Mother's Name],  
S.Rnumber as [Register Number],  
S.[address] as [address],  
S.Phone as [Phone Number],  
S.email as [Email],  
S.dob as [Date Of Birth],  
G.name as [Gender],  
C.class as [Class],  
C.section as [Section],  
S.picture as [pic],  
S.age as [age],  
S.amount as [amount],  
S.due as [due]  
from students S left join gender G on S.gender = g.id left join class C on S.class = C.id where S.name = @name)
GO
/****** Object:  UserDefinedFunction [dbo].[show_stud]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_stud]()  
returns table  
as  
return (select S.name as [Student Name],S.Fname as [Father's Name],S.Mname as [Mother's Name],S.Rnumber as [Register Number],S.[address] as [address],S.Phone as [Phone Number],S.email as [Email],S.dob as [Date Of Birth],G.name as [Gender],C.class as [Clas
s],S.due as [due],C.section as [Section]from students S left join gender G on S.gender = g.id left join class C on S.class = C.id)
GO
/****** Object:  UserDefinedFunction [dbo].[show_atclassname]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[show_atclassname](@class varchar(50),@section varchar(50),@name varchar(50))
returns table
as
return(select S.name,S.picture as [pic],
              G.name as [gender],C.class as [class],
              C.section as [section],S.leaves as [leaves] From  students S 
       left join class C on C.id = S.class
       left join gender G on G.id = S.gender
       where C.class = @class and C.section = @section and S.name = @name)
GO
/****** Object:  UserDefinedFunction [dbo].[show_atclass]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_atclass](@class varchar(50),@section varchar(50))
returns table
as
return(select S.name,S.picture as [pic],
              G.name as [gender],C.class as [class],
              C.section as [section],S.leaves From  students S 
       left join class C on C.id = S.class
       left join gender G on G.id = S.gender
       where C.class = @class and C.section = @section)
GO
/****** Object:  UserDefinedFunction [dbo].[show_studs]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_studs](@name varchar(50))    
returns table    
as    
return (select S.name as [Student Name],S.Fname as [Father's Name],S.Mname as [Mother's Name],S.Rnumber as [Register Number],S.age as [Age],S.[address] as [address],S.Phone as [Phone Number],S.email as [Email],S.dob as [Date Of Birth],G.name as [Gender],C.class as [Clas
  
s],C.section as [Section]from students S left join gender G on S.gender = g.id left join class C on S.class = C.id where S.name LIKE @name+'%')
GO
/****** Object:  StoredProcedure [dbo].[update_fees]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[update_fees]  
as  
begin  
declare @dates date,@get date = getdate()
select @dates = value from dates  
if (MONTH(@dates) < MONTH(@get)and YEAR(@dates)=YEAR(@get))  
begin  
declare @no smallint  
set @no = MONTH(@get) - MONTH(@dates)  
update students set due = due+(@no*amount)   
end   
else if (MONTH(@dates)<MONTH(@get) and YEAR(@dates) < year(@get))  
begin  
set @no = MONTH(@get) - MONTH(@dates)  
set @no = @no+((YEAR(@get)-YEAR(@dates))*12)  
update students set due = due+(@no*amount)   
end  
else if (MONTH(@dates)>=MONTH(@get) and YEAR(@dates) < year(@get))  
begin  
set @no = MONTH(@get) - MONTH(@dates)  
set @no = @no+((YEAR(@get)-YEAR(@dates))*12)  
update students set due = due+(@no*amount)   
end  
update dates set value = @get  
end
GO
/****** Object:  UserDefinedFunction [dbo].[teacher_shows]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[teacher_shows](@name varchar(50))  
returns table  
as  
return(select T.name as [Staff Name],  
              G.name as [Gender],  
              T.age as [age],  
              T.dob as [Birth Date],  
              D.name as [Designation],  
              T.qualification as [Qualification],  
              T.address as [Address],  
              T.phone as [Phone Number],  
              T.email as [Email ID],  
              T.fee as [Monthly Pay],  
              T.dates as [Date Of Joining]  ,
              T.pic as [Picture],
              T.leaves as [leave]
              from teacher T   
      left join gender G on G.id = T.gender  
      left join designation D on D.id=T.designation  
      where T.name = @name)
GO
/****** Object:  UserDefinedFunction [dbo].[teacher_show]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[teacher_show](@name varchar(50))
returns table
as
return(select T.name as [Staff Name],
              G.name as [Gender],
              T.age as [age],
              T.dob as [Birth Date],
              D.name as [Designation],
              T.qualification as [Qualification],
              T.address as [Address],
              T.phone as [Phone Number],
              T.email as [Email ID],
              T.fee as [Monthly Pay],
              T.dates as [Date Of Joining]
              from teacher T 
      left join gender G on G.id = T.gender
      left join designation D on D.id=T.designation
      where T.name like @name+'%')
GO
/****** Object:  Table [dbo].[fees]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fees](
	[id] [int] NOT NULL,
	[dates] [date] NULL,
	[months] [smallint] NULL,
	[years] [int] NULL,
	[amount] [numeric](7, 2) NULL
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [Ix_fees] ON [dbo].[fees] 
(
	[id] ASC,
	[years] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[attendance]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[attendance](
	[id] [int] NOT NULL,
	[dates] [date] NULL,
	[attendance] [smallint] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[insert_studing]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insert_studing]        
@id int,        
@name varchar(50),        
@gender smallint,        
@add varchar(100),        
@phone numeric(10,0),        
@class varchar(50),        
@section varchar(50),        
@fee numeric(10,3),        
@email varchar(50),        
@pic varchar(100)        
as        
begin         
declare @classid int      
select @classid = id from class where class = @class and section = @section        
if @classid is null         
insert into class values(@class,@section)           
  begin tran        
  select @classid = id from class where class = @class and section = @section           
  update students set name = @name,[address] = @add,Phone=@phone,email = @email,        
  picture = @pic,class = @classid,gender = @gender,amount = @fee where id = @id       
  commit tran         
end
GO
/****** Object:  StoredProcedure [dbo].[insert_teacher]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insert_teacher]    
@name varchar(50),    
@gender smallint,    
@dob date,    
@desig varchar(50),    
@qua varchar(50),    
@add varchar(100),    
@phone numeric(10,0),    
@email varchar(50),    
@fee numeric(8,2),    
@join date ,  
@pic varchar(100)  
as    
begin    
begin tran    
declare @desigid int    
select @desigid = id from designation where name = @desig    
if @desigid is null     
begin    
insert into designation(name) values(@desig)    
end    
select @desigid = id from designation where name = @desig    
insert into teacher(name,gender,dob,designation,    
                    qualification,[address],phone    
                    ,email,fee,dates,pic,leaves)     
                    values(@name,@gender,@dob,@desigid,    
                           @qua,@add,@phone,@email,@fee,@join,@pic,0)    
commit    
end
GO
/****** Object:  UserDefinedFunction [dbo].[getid]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getid](@name varchar(50))
returns int
as
begin
declare @id int
select @id= id from students where name = @name
return @id
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_class]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_class]            
@gender smallint,@name varchar(50),@Fname varchar(50),@Mname varchar(50),            
@Rnum int,@add varchar(100),@phone numeric(10,0),            
@pic varchar(100),@email varchar(50),@date date,            
@class varchar(30),@section varchar(30),@amount numeric(10,3)            
as            
begin            
declare @counts smallint=0;            
select @counts=COUNT(*) from class where class = @class and section = @section            
begin tran            
if @counts = 0             
begin            
insert into class(class,section) values(@class,@section)            
Insert into students(due,amount,gender,name,Fname,Mname,Rnumber,[address],Phone,picture,email,dob,class)             
values(@amount,@amount,@gender,@name,@Fname,@Mname,@Rnum,@add,@phone,@pic,@email,@date,dbo.fn_id(@class,@section))            
end            
else            
begin            
Insert into students(due,amount,gender,name,Fname,Mname,Rnumber,[address],Phone,picture,email,dob,class)             
values(@amount,@amount,@gender,@name,@Fname,@Mname,@Rnum,@add,@phone,@pic,@email,@date,dbo.fn_id(@class,@section))            
end            
commit            
end
GO
/****** Object:  Table [dbo].[marksdate]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marksdate](
	[id] [int] NOT NULL,
	[dates] [date] NULL,
	[datesid] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[datesid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[marks]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[marks](
	[id] [int] NULL,
	[sub] [int] NULL,
	[marks] [numeric](7, 2) NULL,
	[grade] [varchar](5) NULL,
	[Remark] [smallint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[make_payment]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[make_payment]
@amount numeric(7,2),
@date date,
@month smallint,
@year int,
@name varchar(50)
as
begin
begin tran
declare @id int
select @id = id from students where name = @name
insert into fees(amount,dates,months,years,id) values(@amount,@date,@month,@year,@id)
update students set due = due - @amount where id = @id
commit
end
GO
/****** Object:  StoredProcedure [dbo].[insert_at]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_at]
@name varchar(50),
@date date,
@at smallint
as
begin
begin tran
declare @id int
select @id = id from students where name = @name
insert into attendance values(@id,@date,@at) 
commit
end
GO
/****** Object:  UserDefinedFunction [dbo].[get_datess]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[get_datess](@name varchar(50),@date smallint)    
returns table    
as    
return(select A.dates as [date] from Tattendance A     
       left join teacher S on A.id = S.id    
       where S.name = @name and month(A.dates)=@date and A.attendance = 2)
GO
/****** Object:  UserDefinedFunction [dbo].[get_dates]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[get_dates](@name varchar(50),@date smallint)  
returns table  
as  
return(select A.dates from attendance A   
       left join students S on A.id = S.id  
       where S.name = @name and month(A.dates)=@date and A.attendance = 2)
GO
/****** Object:  StoredProcedure [dbo].[insert_Tat]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insert_Tat]  
@name varchar(50),  
@date date,  
@at smallint  
as  
begin  
begin tran  
declare @id int  
select @id = id from teacher where name = @name  
insert into Tattendance(id,dates,attendance) values(@id,@date,@at)   
commit  
end
GO
/****** Object:  UserDefinedFunction [dbo].[show_Tattendances]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_Tattendances](@name varchar(50))
returns table
as 
return(select T.name as [Staff Name],
      D.name as [Designation],
      P.name as [P/A],
      A.dates as [Date]
      From Tattendance A 
      left join teacher T on t.id = A.id
      left join PA P on P.id = A.attendance
      left join designation D on D.id = T.designation
      where T.name = @name)
GO
/****** Object:  UserDefinedFunction [dbo].[show_Tattendancenamedate]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_Tattendancenamedate](@name varchar(50),@date date)
returns table
as 
return(select T.name as [Staff Name],
      D.name as [Designation],
      P.name as [P/A],
      A.dates as [Date]
      From Tattendance A 
      left join teacher T on t.id = A.id
      left join PA P on P.id = A.attendance
      left join designation D on D.id = T.designation
      where A.dates = @date and T.name = @name)
GO
/****** Object:  UserDefinedFunction [dbo].[show_Tattendance]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_Tattendance](@date date)
returns table
as 
return(select T.name as [Staff Name],
      D.name as [Designation],
      P.name as [P/A],
      A.dates as [Date]
      From Tattendance A 
      left join teacher T on t.id = A.id
      left join PA P on P.id = A.attendance
      left join designation D on D.id = T.designation
      where A.dates = @date)
GO
/****** Object:  StoredProcedure [dbo].[update_leaves]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[update_leaves]    
as    
begin    
update students set leaves = (select COUNT(*) from attendance where attendance.id = students.id and attendance.attendance = 2)  
update teacher set leaves = (select COUNT(*) from Tattendance where Tattendance.id = teacher.id and Tattendance.attendance = 2)      
end
GO
/****** Object:  StoredProcedure [dbo].[insert_fee]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insert_fee]
@name varchar(50),
@date date,
@month smallint,
@year int,
@amount numeric(7,2)
as
begin
begin tran
declare @nameid int 
select @nameid = id from students where name = @name
insert into fees(id,dates,months,years,amount) values(@nameid,@date,@month,@year,@amount)
update students set due = due-@amount where name= @name
commit
end
GO
/****** Object:  UserDefinedFunction [dbo].[show_studing]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_studing](@name int)       
returns table        
as        
return (select S.name as [Student Name],      
S.Fname as [Father's Name],      
S.Mname as [Mother's Name],      
S.Rnumber as [Register Number],      
S.[address] as [address],      
S.Phone as [Phone Number],      
S.email as [Email],      
S.dob as [Date Of Birth],   
S.picture as[pic],     
G.name as [Gender],      
C.class as [Class],      
C.section as [Section],      
S.amount as [fee]      
from students S       
left join gender G on S.gender = g.id      
left join class C on S.class = C.id      
left join fees F on F.id = S.id      
where S.id = @name )
GO
/****** Object:  UserDefinedFunction [dbo].[show_fees]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[show_fees](@name varchar(50),@year int)
returns table
return (select F.months from fees F 
       left join students S on S.id = F.id
       where S.name = @name and F.years = @year)
GO
/****** Object:  UserDefinedFunction [dbo].[show_fee]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_fee](@name varchar(50))
returns table
as
return(select S.name,F.amount,F.months,F.years,F.dates,S.due from fees F 
      left join students S on S.id = F.id where S.name LIKE @name + '%' and F.amount <> 0)
GO
/****** Object:  UserDefinedFunction [dbo].[show_classsection]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_classsection](@name varchar(50)='%',@class varchar(50)='%',@section varchar(50)='%',@date date)
returns table
as
return (select S.name as [Student Name],
               C.class as [class],
               C.section as [section],
               P.name as [P/A],      
               S.leaves as [Total Leaves] ,
               A.dates as [date]     
        from attendance A 
        left join students S on S.id = A.id
        left join class C on C.id = s.class 
        left join PA P on P.id = A.attendance
        where C.class LIKE @class and C.section LIKE @section and A.dates = @date and S.name LIKE @name)
GO
/****** Object:  UserDefinedFunction [dbo].[show_classname]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_classname](@name varchar(50)='%',@class varchar(50)='%',@section varchar(50)='%')  
returns table  
as  
return (select S.name as [Student Name],  
               C.class as [class],  
               C.section as [section],  
               P.name as [P/A],        
               S.leaves as [Total Leaves],  
               A.dates as [date]        
        from attendance A   
        left join students S on S.id = A.id  
        left join class C on C.id = s.class   
        left join PA P on P.id = A.attendance  
        where C.class LIKE @class and C.section LIKE @section  and S.name LIKE @name)
GO
/****** Object:  UserDefinedFunction [dbo].[show_stuat]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_stuat](@class varchar(50),@section varchar(50),@date date)    
returns table    
as    
return(select S.name,P.name as [at],A.dates From attendance A     
       left join students S on S.id = A.id    
       left join class C on C.id = S.class
       left join PA P on P.id = A.attendance    
       where C.class = @class and C.section = @section and A.dates = @date)
GO
/****** Object:  StoredProcedure [dbo].[update_marks]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[update_marks]
@name varchar(50),
@sub varchar(50),
@date date,
@mark numeric(7,2)
as
begin 
begin tran
set @date = CAST(MONTH(@date) as varchar) + '-1-'+CAST(YEAR(@date) as varchar)
declare @dateid int,@subid int
select @dateid = datesid from marksdate M left join students S 
on S.id = M.id
where S.name = @name and M.dates = @date
select @subid = id from sub where name = @sub
update marks set  marks = @mark where  id = @dateid and sub=@subid
commit
end
GO
/****** Object:  UserDefinedFunction [dbo].[show_marks]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[show_marks](@name varchar(50) = '%',@sub varchar(50)='%',@date date)  
returns table  
return(select ST.name as [Student Name],  
       S.name as [Subject Name],  
       M.marks as [Marks],
       M.grade as [Grade],
       R.name as [Remark],
       C.class as [class],
       C.section as [section] from marks M  
      left join sub S on S.id = M.sub  
      left join marksdate Z on M.id = Z.datesid  
      left join students ST on ST.id = Z.id  
      left join class C on C.id = St.class
      left join remark R on M.remark = R.id
      where   
      ST.name like @name   
      and S.name like @sub   
      and Z.dates = CAST(MONTH(@date) as varchar)+'-1-'+CAST(YEAR(@date) as varchar))
GO
/****** Object:  StoredProcedure [dbo].[insert_marks]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insert_marks]  
@date as date,  
@marks as numeric(7,2),  
@sub varchar(50),  
@name varchar(50)  
as  
begin  
 begin try  
  begin tran  
  set @date = CAST(MONTH(@date) as varchar) + '-1-'+CAST(YEAR(@date) as varchar)
  declare @subid int,@dateid int,@studid int  
  select @subid = id from sub where name = @sub  
  select @studid = id from students where name= @name  
  select  @dateid=datesid from marksdate where id = @studid and dates = @date  
   if @subid is null   
   insert into sub(name) values(@sub)  
   if @dateid  is null   
   insert into marksdate(id,dates) values(@studid,@date)  
   select @dateid = datesid from marksdate where id = @studid and dates = @date  
   select @subid = id from sub where name = @sub   
   insert into marks(id,sub,marks) values(@dateid,@subid,@marks)  
   commit tran  
  end try  
  begin catch   
  rollback  
  print 'rolled back'  
  select ERROR_MESSAGE() as [error]  
  end catch  
end
GO
/****** Object:  StoredProcedure [dbo].[delete_marks]    Script Date: 09/02/2018 00:15:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[delete_marks]
@name varchar(50),
@sub varchar(50),
@date date
as
begin
declare @datesid int,@subid int
select @datesid = M.id,@subid = M.sub from marks M  
      left join sub S on S.id = M.sub  
      left join marksdate Z on M.id = Z.datesid  
      left join students ST on ST.id = Z.id  
      where   
      ST.name like @name   
      and S.name like @sub   
      and Z.dates = CAST(MONTH(@date) as varchar)+'-1-'+CAST(YEAR(@date) as varchar)
delete from marks where id = @datesid and sub = @subid
declare @counts int
select @counts = COUNT(*) from marks where id = @datesid
print @counts
if @counts = 0 
delete from marksdate where datesid = @datesid
end
GO
/****** Object:  ForeignKey [gender_constraint]    Script Date: 09/02/2018 00:15:04 ******/
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [gender_constraint] FOREIGN KEY([gender])
REFERENCES [dbo].[gender] ([id])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [gender_constraint]
GO
/****** Object:  ForeignKey [FK_desig]    Script Date: 09/02/2018 00:15:04 ******/
ALTER TABLE [dbo].[teacher]  WITH CHECK ADD  CONSTRAINT [FK_desig] FOREIGN KEY([designation])
REFERENCES [dbo].[designation] ([id])
GO
ALTER TABLE [dbo].[teacher] CHECK CONSTRAINT [FK_desig]
GO
/****** Object:  ForeignKey [FK_con]    Script Date: 09/02/2018 00:15:04 ******/
ALTER TABLE [dbo].[Tattendance]  WITH CHECK ADD  CONSTRAINT [FK_con] FOREIGN KEY([attendance])
REFERENCES [dbo].[PA] ([id])
GO
ALTER TABLE [dbo].[Tattendance] CHECK CONSTRAINT [FK_con]
GO
/****** Object:  ForeignKey [FK_Tid]    Script Date: 09/02/2018 00:15:04 ******/
ALTER TABLE [dbo].[Tattendance]  WITH CHECK ADD  CONSTRAINT [FK_Tid] FOREIGN KEY([id])
REFERENCES [dbo].[teacher] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tattendance] CHECK CONSTRAINT [FK_Tid]
GO
/****** Object:  ForeignKey [Fk_fees]    Script Date: 09/02/2018 00:15:04 ******/
ALTER TABLE [dbo].[fees]  WITH CHECK ADD  CONSTRAINT [Fk_fees] FOREIGN KEY([id])
REFERENCES [dbo].[students] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[fees] CHECK CONSTRAINT [Fk_fees]
GO
/****** Object:  ForeignKey [FK_att]    Script Date: 09/02/2018 00:15:04 ******/
ALTER TABLE [dbo].[attendance]  WITH CHECK ADD  CONSTRAINT [FK_att] FOREIGN KEY([id])
REFERENCES [dbo].[students] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[attendance] CHECK CONSTRAINT [FK_att]
GO
/****** Object:  ForeignKey [FK_id]    Script Date: 09/02/2018 00:15:04 ******/
ALTER TABLE [dbo].[attendance]  WITH CHECK ADD  CONSTRAINT [FK_id] FOREIGN KEY([attendance])
REFERENCES [dbo].[PA] ([id])
GO
ALTER TABLE [dbo].[attendance] CHECK CONSTRAINT [FK_id]
GO
/****** Object:  ForeignKey [FK_date]    Script Date: 09/02/2018 00:15:04 ******/
ALTER TABLE [dbo].[marksdate]  WITH CHECK ADD  CONSTRAINT [FK_date] FOREIGN KEY([id])
REFERENCES [dbo].[students] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[marksdate] CHECK CONSTRAINT [FK_date]
GO
/****** Object:  ForeignKey [FK_marks]    Script Date: 09/02/2018 00:15:04 ******/
ALTER TABLE [dbo].[marks]  WITH CHECK ADD  CONSTRAINT [FK_marks] FOREIGN KEY([id])
REFERENCES [dbo].[marksdate] ([datesid])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[marks] CHECK CONSTRAINT [FK_marks]
GO
/****** Object:  ForeignKey [FK_remark]    Script Date: 09/02/2018 00:15:04 ******/
ALTER TABLE [dbo].[marks]  WITH CHECK ADD  CONSTRAINT [FK_remark] FOREIGN KEY([Remark])
REFERENCES [dbo].[remark] ([id])
GO
ALTER TABLE [dbo].[marks] CHECK CONSTRAINT [FK_remark]
GO
/****** Object:  ForeignKey [FK_sub]    Script Date: 09/02/2018 00:15:04 ******/
ALTER TABLE [dbo].[marks]  WITH CHECK ADD  CONSTRAINT [FK_sub] FOREIGN KEY([sub])
REFERENCES [dbo].[sub] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[marks] CHECK CONSTRAINT [FK_sub]
GO
