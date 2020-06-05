CREATE TABLE [dbo].[felhasznalo] (
    [felhasznaloid]  INT          IDENTITY (1, 1) NOT NULL,
    [felhasznalonev] VARCHAR (50) NOT NULL,
    [jelszo]         VARCHAR (10) NOT NULL,
    [vezetekn]       VARCHAR (50) NOT NULL,
    [keresztn]       VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_felhasznalo] PRIMARY KEY CLUSTERED ([felhasznalonev] ASC)
);

