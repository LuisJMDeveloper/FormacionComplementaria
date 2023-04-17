create table LUGAR(
	lu_id numeric identity(1,1) primary key not null,
	lu_code int,
	lu_name varchar(200)
)

create table AMBIENTE(
	am_id numeric identity(1,1) primary key not null,
	am_code int,
	am_name varchar(200),
    
	lu_id numeric references LUGAR
)

create table PROGRAMA_FORMACION(
	pf_id numeric identity(1,1) primary key not null,
	pf_code numeric,
	pf_name varchar(200),
	pf_version float
)

create table PROGRAMA_ESPECIAL(
	pe_id numeric identity(1,1) primary key not null,
	pe_code numeric,
	pe_name varchar(200),
)

create table CURSO(
	cu_id numeric identity(1,1) primary key not null,
	cu_code int,
	cu_name	varchar(200),
	cu_duration varchar(200),
	cu_startdate datetime default getdate(),
	cu_enddate datetime,
	cu_note varchar(200), 
	cu_days varchar(200),
	
	am_id numeric references AMBIENTE,
	pf_id numeric references PROGRAMA_FORMACION,
	pe_id numeric
)

create table ACTIVIDAD(
	ac_id numeric identity(1,1) primary key not null,
	ac_code numeric,
	ac_name varchar(200),
	ac_daytotal int,
	ac_timetable varchar(200),

	cu_id numeric references CURSO
)


create table USUARIO(
	us_id numeric identity(1,1) primary key not null,
    us_nid numeric, 
	us_password varchar(200),
    us_typeuser varchar(20) default 'a',
    us_name varchar(100),
    us_lastname varchar(100),
    us_email varchar(100),
    us_phone numeric,
    us_reestablecer bit default 0,
    us_date datetime default getdate()
) 

create table SOLICITUD(
	so_id numeric identity(1,1) primary key not null,
    so_status varchar(20),
    so_type	bit default 0,
    so_ente	varchar (200),
    so_date	datetime default getdate(),

	us_id numeric references USUARIO
)
GO

create proc getUser
	@usuario numeric,
	@clave varchar(200)
as
	begin
		select *
		from USUARIO
		where USUARIO.us_nid = @usuario and USUARIO.us_password = @clave
	end
go
