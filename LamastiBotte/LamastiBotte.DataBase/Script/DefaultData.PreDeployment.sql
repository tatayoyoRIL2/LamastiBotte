/*
 Modèle de script de pré-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront exécutées avant le script de compilation.	
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de pré-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de pré-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
USE [LamastiBotte]
GO

DROP TABLE [dbo].[Message]
DROP TABLE [dbo].[Reponse]
DROP TABLE [dbo].[Question]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[Reponse](
	[IdReponse] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdReponse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Question](
	[IdQuestion] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdQuestion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Message](
	[IdQuestionIdReponse] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdQuestionIdReponse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Conversation_Question] FOREIGN KEY([IdQuestionIdReponse])
REFERENCES [dbo].[Question] ([IdQuestion])
GO

ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Conversation_Question]
GO

ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Conversation_Reponse] FOREIGN KEY([IdQuestionIdReponse])
REFERENCES [dbo].[Reponse] ([IdReponse])
GO

ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Conversation_Reponse]
GO


INSERT INTO [dbo].[Question]
           ([Message])
     VALUES
           ('bonjour'),
		   ('je vous écoute'),
		   ('que voulez-vous dire ?')
		   
INSERT INTO [dbo].[Reponse]
           ([Message])
     VALUES
           (''),
		   (''),
		   ('')