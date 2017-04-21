CREATE TABLE [dbo].[Roles]
(
        [Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Name] VARCHAR(25) NOT NULL,
    [Description] VARCHAR(50) NOT NULL
)


CREATE TABLE [dbo].[Users] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (20) NOT NULL,
    [Password] VARCHAR (20) NOT NULL,
    [Id_Role]  INT          NOT NULL,
    [Name]     VARCHAR (50) DEFAULT ('') NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [fk_user_role] FOREIGN KEY ([Id_Role]) REFERENCES [dbo].[Roles] ([Id])
);