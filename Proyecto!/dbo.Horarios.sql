CREATE TABLE [dbo].[Horarios] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Clase]      VARCHAR (20)  NOT NULL,
    [Motivo]     VARCHAR (200) NOT NULL,
    [HoraInicio] SMALLDATETIME NOT NULL,
    [HoraFinal]  SMALLDATETIME NOT NULL,
    [Dia]        VARCHAR (100) NOT NULL,
    [NombreUsuario] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

