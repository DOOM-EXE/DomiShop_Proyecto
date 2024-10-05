use Domishop

select * from productos


create table productos(
ID_PRODUCTO int identity(1001,1) PRIMARY KEY,
nombre varchar(50),
DESCRIPCION varchar(150),
CANTIDAD int
PRECIO numeric
)