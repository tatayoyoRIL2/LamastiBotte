CREATE TABLE [dbo].[Message]
(
	[IdQuestionIdReponse] INT NOT NULL PRIMARY KEY, 
	[Message] NVARCHAR(MAX) NOT NULL,

    CONSTRAINT [FK_Message_Question] FOREIGN KEY ([IdQuestionIdReponse]) REFERENCES [Question]([IdQuestion]),
    CONSTRAINT [FK_Message_Reponse] FOREIGN KEY ([IdQuestionIdReponse]) REFERENCES [Reponse]([IdReponse])
)
