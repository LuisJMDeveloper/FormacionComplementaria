USE [FC_CIP_prueba]
GO
/****** Object:  Table [dbo].[ACTIVIDAD]    Script Date: 18/04/2023 16:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ACTIVIDAD](
	[ac_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ac_code] [numeric](18, 0) NULL,
	[ac_name] [varchar](200) NULL,
	[ac_daytotal] [int] NULL,
	[ac_timetable] [varchar](200) NULL,
	[cu_id] [numeric](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ac_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AMBIENTE]    Script Date: 18/04/2023 16:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AMBIENTE](
	[am_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[am_code] [int] NULL,
	[am_name] [varchar](200) NULL,
	[lu_id] [numeric](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[am_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CURSO]    Script Date: 18/04/2023 16:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CURSO](
	[cu_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[cu_code] [int] NULL,
	[cu_name] [varchar](200) NULL,
	[cu_duration] [varchar](200) NULL,
	[cu_startdate] [datetime] NULL,
	[cu_enddate] [datetime] NULL,
	[cu_note] [varchar](200) NULL,
	[cu_days] [varchar](200) NULL,
	[am_id] [numeric](18, 0) NULL,
	[pf_id] [numeric](18, 0) NULL,
	[pe_id] [numeric](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[cu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LUGAR]    Script Date: 18/04/2023 16:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LUGAR](
	[lu_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[lu_code] [int] NULL,
	[lu_name] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[lu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PROGRAMA_ESPECIAL]    Script Date: 18/04/2023 16:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROGRAMA_ESPECIAL](
	[pe_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[pe_code] [numeric](18, 0) NULL,
	[pe_name] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[pe_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PROGRAMA_FORMACION]    Script Date: 18/04/2023 16:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROGRAMA_FORMACION](
	[pf_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[pf_code] [numeric](18, 0) NULL,
	[pf_name] [varchar](200) NULL,
	[pf_version] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[pf_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SOLICITUD]    Script Date: 18/04/2023 16:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SOLICITUD](
	[so_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[so_status] [varchar](20) NULL,
	[so_type] [bit] NULL,
	[so_ente] [varchar](200) NULL,
	[so_date] [datetime] NULL,
	[us_id] [numeric](18, 0) NULL,
	[cu_id] [numeric](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[so_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 18/04/2023 16:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USUARIO](
	[us_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[us_nid] [numeric](18, 0) NULL,
	[us_password] [varchar](200) NULL,
	[us_typeuser] [varchar](20) NULL,
	[us_name] [varchar](100) NULL,
	[us_lastname] [varchar](100) NULL,
	[us_email] [varchar](100) NULL,
	[us_phone] [numeric](18, 0) NULL,
	[us_reestablecer] [bit] NULL,
	[us_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[us_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CURSO] ADD  DEFAULT (getdate()) FOR [cu_startdate]
GO
ALTER TABLE [dbo].[SOLICITUD] ADD  DEFAULT ((0)) FOR [so_type]
GO
ALTER TABLE [dbo].[SOLICITUD] ADD  DEFAULT (getdate()) FOR [so_date]
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT ('a') FOR [us_typeuser]
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT ((0)) FOR [us_reestablecer]
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT (getdate()) FOR [us_date]
GO
ALTER TABLE [dbo].[ACTIVIDAD]  WITH CHECK ADD FOREIGN KEY([cu_id])
REFERENCES [dbo].[CURSO] ([cu_id])
GO
ALTER TABLE [dbo].[AMBIENTE]  WITH CHECK ADD FOREIGN KEY([lu_id])
REFERENCES [dbo].[LUGAR] ([lu_id])
GO
ALTER TABLE [dbo].[CURSO]  WITH CHECK ADD FOREIGN KEY([am_id])
REFERENCES [dbo].[AMBIENTE] ([am_id])
GO
ALTER TABLE [dbo].[CURSO]  WITH CHECK ADD FOREIGN KEY([pf_id])
REFERENCES [dbo].[PROGRAMA_FORMACION] ([pf_id])
GO
ALTER TABLE [dbo].[SOLICITUD]  WITH CHECK ADD FOREIGN KEY([us_id])
REFERENCES [dbo].[USUARIO] ([us_id])
GO
ALTER TABLE [dbo].[SOLICITUD]  WITH CHECK ADD  CONSTRAINT [FK_SOLICITUD_CURSO] FOREIGN KEY([cu_id])
REFERENCES [dbo].[CURSO] ([cu_id])
GO
ALTER TABLE [dbo].[SOLICITUD] CHECK CONSTRAINT [FK_SOLICITUD_CURSO]
GO
/****** Object:  StoredProcedure [dbo].[getUser]    Script Date: 18/04/2023 16:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getUser]
	@usuario numeric,
	@clave varchar(200)
as
	begin
		select *
		from USUARIO
		where USUARIO.us_nid = @usuario and USUARIO.us_password = @clave
	end

GO
