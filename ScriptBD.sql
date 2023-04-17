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
	