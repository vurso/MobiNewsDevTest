# MobiNewsDevTest

Run the following SQL script to create your DB project:

```sql
/****** Object:  User [mbnadmin]    Script Date: 22/10/2018 22:20:57 ******/
CREATE USER [mbnadmin] FOR LOGIN [mbnadmin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [mbnadmin]
GO
/****** Object:  Table [dbo].[NewStories]    Script Date: 22/10/2018 22:20:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewStories](
	[NewsStoryID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[NewsStory] [nvarchar](max) NOT NULL,
	[ImagePath] [nvarchar](255) NULL,
	[SupplierID] [int] NULL,
	[SupplierStoryRef] [nvarchar](255) NULL,
	[AddedDateTime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NewsStoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 22/10/2018 22:20:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](256) NOT NULL,
	[NotificationURL] [nvarchar](512) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NewStories]  WITH CHECK ADD  CONSTRAINT [FK_NewStories_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[NewStories] CHECK CONSTRAINT [FK_NewStories_Suppliers]
GO

```
