USE [VueDB]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 11/25/2020 5:44:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreEmpleado] [varchar](40) NOT NULL,
	[ApellidosEmpleado] [varchar](40) NOT NULL,
	[TipoPermiso] [int] NOT NULL,
	[FechaPermiso] [date] NOT NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPermiso]    Script Date: 11/25/2020 5:44:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPermiso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](75) NOT NULL,
 CONSTRAINT [PK_TipoPermiso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
