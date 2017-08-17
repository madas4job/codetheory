CREATE TABLE [dbo].[users] (
    [Id]     BIGINT      NOT NULL,
    [Userid] NCHAR (250) NULL,
    CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

