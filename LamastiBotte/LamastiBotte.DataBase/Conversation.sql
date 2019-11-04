CREATE TABLE [dbo].[Message]
(
	[IdQuestionIdReponse] INT NOT NULL PRIMARY KEY

    CONSTRAINT [FK_Conversation_Question] FOREIGN KEY ([IdQuestionIdReponse]) REFERENCES [Question]([IdQuestion]),
    CONSTRAINT [FK_Conversation_Reponse] FOREIGN KEY ([IdQuestionIdReponse]) REFERENCES [Reponse]([IdReponse])
)
