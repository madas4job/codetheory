CREATE TABLE [dbo].[data] (
    [Id]      BIGINT NOT NULL,
    [glucose] INT    NULL,
    [date]    DATE   NULL,
    [userid]  BIGINT NULL,
    CONSTRAINT [PK_data] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_data_users] FOREIGN KEY ([userid]) REFERENCES [dbo].[users] ([Id])
);

