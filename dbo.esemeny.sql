CREATE TABLE [dbo].[esemeny] (
    [esemenyid]     INT           IDENTITY (1, 1) NOT NULL,
    [felhasznaloid] VARCHAR (50)  NOT NULL,
    [cim]           VARCHAR (100) NOT NULL,
    [kategoria]     TEXT          NOT NULL,
    [kezdet]        DATE          NOT NULL,
    [kora]          VARCHAR (2)   NOT NULL,
    [kperc]         VARCHAR (2)   NOT NULL,
    [veg]           DATE          NOT NULL,
    [vora]          VARCHAR (2)   NOT NULL,
    [vperc]         VARCHAR (2)   NOT NULL,
    CONSTRAINT [PK_esemeny] PRIMARY KEY CLUSTERED ([esemenyid] ASC),
    FOREIGN KEY ([felhasznaloid]) REFERENCES [dbo].[felhasznalo] ([felhasznalonev])
);

