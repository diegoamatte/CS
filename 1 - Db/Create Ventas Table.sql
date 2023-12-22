IF DB_ID (N'CartaSur') IS NULL
CREATE DATABASE CartaSur;
GO

USE CartaSur

IF OBJECT_ID(N'dbo.Ventas', N'U') IS NULL
CREATE TABLE Ventas(
	ID_VENTA int not null PRIMARY KEY,
	Fecha_venta datetime,
	Dni_cliente varchar(10),
	Nombre_empleado varchar(100),
	Nombre_cliente varchar(100),
	Importe_total decimal(10,2),
	Direccion_envio_cliente varchar(100),
	Direccion_sucursal_venta varchar(100),
	Nombre_sucursal_venta varchar(100),
	Producto varchar(20),
	Cantidad int
);
GO

INSERT INTO Ventas VALUES (1,'20231220 10:34:09 AM','34254213','Juan Doe','Martin Perez',300.54,'Las Heras 2304', 'San Martin 5555', 'SUC 2', 'PRODUCTO 1', 56);
INSERT INTO Ventas VALUES (2,'20231220 11:34:29 AM','44224213','Juan Perez','Martin Ramirez',100.99,'Belgrano 1234', 'San Martin 5555', 'SUC 2', 'PRODUCTO 2', 2);
INSERT INTO Ventas VALUES (3,'20231221 09:11:19 AM','24254213','Juan Martinez','Lucia Gomez',500.00,'Bouchard 2304', 'San Martin 5555', 'SUC 2', 'PRODUCTO 3', 56);