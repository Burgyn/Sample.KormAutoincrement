﻿SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT 1 FROM sysobjects WHERE NAME='Users' and xtype='U')
BEGIN

    CREATE TABLE [dbo].[Users](
        [Id] [bigint] IDENTITY(1,1) NOT NULL,
        [Name] [nvarchar](255) NOT NULL,

        CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
        WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]

END
GO
