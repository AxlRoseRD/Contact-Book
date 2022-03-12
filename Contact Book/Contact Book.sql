CREATE DATABASE Contact_Book

drop TABLE Contact
(
id int not null IDENTITY(1,1),
nombre varchar(30)not null,
apellido varchar(40)not null,
fecha_de_nacimiento varchar(10)not null,
direccion varchar(50)not null,
genero varchar(10),
estado_civil varchar(11),
movil varchar(16),
telefono varchar(15),
correo_electronico varchar(125)
 primary key(id)
)

select * From Contact