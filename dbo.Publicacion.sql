CREATE TABLE [dbo].[Publicacion] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Usuario]         NVARCHAR (MAX) NOT NULL,
    [Descripcion]     NVARCHAR (MAX) NOT NULL,
    [FechaPubliacion] DATETIME       NOT NULL,
    [MeGusta]         INT            NOT NULL,
    [MeDisgusta]      INT            NOT NULL,
    [VecesCompartido] INT            NOT NULL,
    [EsPrivado]       BIT            NOT NULL,
    CONSTRAINT [PK_dbo.Publicacion] PRIMARY KEY CLUSTERED ([Id] ASC)
);

