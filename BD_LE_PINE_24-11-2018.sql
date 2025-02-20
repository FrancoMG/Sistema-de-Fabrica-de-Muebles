drop database Le_Pine;
create database Le_Pine;
use Le_Pine;


create table Persona(
IdPersona int auto_increment,
Nombre varchar(40),
Apellido varchar(40),
DNI int,
Telefono varchar(15),
Direccion varchar(40),
constraint PK_IdPersona primary key(IdPersona)
)Engine=InnoDB;






/*Registro del Cliente*/
create table Cliente(
IdCliente int auto_increment,
IdPersona int,
constraint PK_Cliente primary key(IdCliente),
constraint FK_Cliente_ foreign key(IdPersona) references Persona(IdPersona)
)Engine=InnoDB;







create table Tecnico(
IdTecnico int auto_increment,
IdPersona int,
Disponible boolean,
constraint PK_IdTecnico primary key(IdTecnico),
constraint FK_IdTecnico foreign key(IdPersona) references Persona(IdPersona)
)Engine=InnoDB;






create table Recepcionista(
IdRecepcionista int auto_increment,
IdPersona int,
constraint PK_Recepcionista primary key(IdRecepcionista)
)Engine=InnoDB;






create table RecepcionistaDia(
IdRecepcionistaDia int auto_increment,
IdRecepcionista int,
Dia varchar(15),
HoraIngreso time,
HoraEgreso time,
constraint PK_RecepcionistaDia primary key(IdRecepcionistaDia),
constraint FK_RecepcionistaDia foreign key(IdRecepcionista) references Recepcionista(IdRecepcionista) 
)Engine=InnoDB;






/*Tipos de muebles*/
create table TipoMueble(
IdTipoMueble int auto_increment,
Descripcion varchar(40),
TiempoProduccion int,
constraint PK_TipoMuble primary key(IdTipoMueble)
)Engine=InnoDB;



create table Producto(
IdProducto int auto_increment,
Nombre_Comercial varchar(30),
Stock int,
PP int,
Estado boolean,
constraint PK_Productos primary key(IdProducto)
)Engine=InnoDB;


/*Tipos de maderas*/
create table Madera(
IdMadera int auto_increment,
IdProducto int,
Nombre varchar(40),
PrecioVentaPorCM2 float,
Estado boolean,
constraint PK_Madera primary key(IdMadera),
constraint FK_Madera foreign key(IdProducto) references producto(idproducto)
)Engine=InnoDB;





create table MaterialDeMontaje(
IdMaterialM int auto_increment,
IdProducto int,
Nombre varchar(20),
Estado boolean,
constraint PK_MaterialesDeMontaje primary key(IdMaterialM),
constraint FK_MaterialesDeMontaje foreign key(IdProducto) references producto(idproducto)
)Engine=InnoDB;





create table Camion(
IdCamion int auto_increment,
Marca varchar(20),
Modelo varchar(20),
Disponible boolean,
constraint PK_Camion primary key (IdCamion)
)Engine=InnoDB;





/*Materiales adicionales*/
create table Extra(
IdExtra int auto_increment,
IdProducto int,
Descripcion varchar(40),
PrecioUnidad float,
Estado boolean,
constraint PK_Extra primary key(IdExtra),
constraint FK_Extra foreign key(IdProducto) references producto(idproducto)
)Engine=InnoDB;





/*Registro del pedido*/
create table Pedido(
IdPedido int auto_increment,
IdCliente int,
DirEntrega varchar(40),
DistanciaKM int,
Aceptado boolean,
FechaSolicitado date,
constraint PK_Pedido primary key(IdPedido),
constraint FK_Pedido_ foreign key (idCliente) references Cliente (IdCliente)
)Engine=InnoDB;




create table HojaDeRuta(
IdHoja int auto_increment,
IdCamion int,
FechaSalida date,
constraint PK_HojaDeRuta primary key(IdHoja),
constraint FK_HojaDeRuta_ foreign key (IdCamion) references Camion(IdCamion)
)Engine=InnoDB;





/*Mueble terminado. Sus estados varian entre: ENTREGADO,NO ENTREGADO, DESMANTELADO Y PARA PRESUPUESTAR*/
create table Mueble(
IdMueble int auto_increment,
IdTipoMueble int,
Estado varchar(20),
ProduccionAceptada boolean,
ProduccionFinalizada boolean,
constraint PK_Mueble primary key(IdMueble),
constraint FK_Mueble_ foreign key(IdTipoMueble) references TipoMueble(IdTipoMueble)
)Engine=InnoDB;





create table PedidoMueble(
IdPedido int,
IdMueble int,
Cantidad int,
constraint PK_PedidoMueble primary key(IdPedido,IdMueble),
constraint FK_PedidoMueble_ foreign key(IdPedido) references Pedido(IdPedido),
constraint FK_PedidoMueble__ foreign key(IdMueble) references Mueble(IdMueble)
)Engine=InnoDB;




create table DetalleHojaDeRuta(
IdHoja int,
IdPedido int,
constraint PK_DetalleHojaDeRuta primary key(IdHoja,IdPedido),
constraint FK_DetalleHojaDeRuta_ foreign key(IdHoja) references HojaDeRuta(IdHoja),
constraint FK_DetalleHojaDeRuta__ foreign key(IdPedido) references PedidoMueble(IdPedido)
)Engine=InnoDB;






create table MuebleMadera(
IdMueble int,
IdMadera int,
CM2 int,
constraint PK_MuebleMadera primary key(IdMueble,IdMadera),
constraint FK_MuebleMadera_ foreign key(IdMueble) references Mueble(IdMueble),
constraint FK_MuebleMadera__ foreign key(IdMadera) references Madera(IdMadera)
)Engine=InnoDB;





create table MuebleMontaje(
IdMaterialM int,
IdMueble int,
Cantidad int,
constraint PK_MuebleMontaje primary key(IdMaterialM,IdMueble),
constraint FK_MuebleMontaje_ foreign key(IdMaterialM) references MaterialDeMontaje(IdMaterialM),
constraint FK_MuebleMontaje__ foreign key(IdMueble) references Mueble(IdMueble)
)Engine=InnoDB;



create table MuebleExtra(
IdMueble int,
IdExtra int,
Cantidad int,
constraint PK_MuebleExtra primary key(IdMueble,IdExtra),
constraint FK_MuebleExtra_ foreign key(IdMueble) references Mueble(IdMueble),
constraint FK_MuebleExtra__ foreign key(IdExtra) references Extra(IdExtra)
)Engine=InnoDB;



/*Elaboración de factura*/
create table Factura(
IdFactura int auto_increment,
IdPedido int,
Paga boolean,
Monto float,
constraint PK_Factura primary key(IdFactura),
constraint FK_Factura_ foreign key(IdPedido) references Pedido(IdPedido)
)Engine=InnoDB;




create table DetalleFactura(
IdFactura int,
IdMueble int,
Precio_Unitario int,
Cantidad int,
constraint PK_DetalleFactura primary key(IdFactura,IdMueble),
constraint FK_DetalleFactura_ foreign key(IdFactura) references Factura(IdFactura),
constraint FK_DetalleFactura__ foreign key(IdMueble) references Mueble(IdMueble)
)Engine=InnoDB;





/*Planchas disponibles*/
create table Remanente(
IdRemanente int auto_increment,
IdMadera int,
CM2 int,
/* La medida de TODAS las planchas es de 2m de altura x 1.5m de ancho */
constraint PK_Remanente primary key(IdRemanente),
constraint FK_Remanente_ foreign key(IdMadera) references Madera(IdMadera)
)Engine=InnoDB;





create table Proveedor(
IdProveedor int auto_increment,
Nombre varchar(40),
Direccion varchar(40),
Contacto varchar(40),
TipoProveedor varchar(20),    /*Vende madera o Extras*/
constraint PK_Proveedor primary key(IdProveedor)
)Engine=InnoDB;







create table ListaDePrecios(
IdProveedor int,
IdProducto int,
Precio int,
constraint PK_ListaDePrecios primary key(IdProveedor,IdProducto),
constraint FK_ListaDePrecios_ foreign key(IdProveedor) references Proveedor(IdProveedor),
constraint FK_ListaDePrecios__ foreign key(IdProducto) references Producto(IdProducto)
)Engine=InnoDB;





create table OrdenDeCompra(
IdOrdenDeCompra int auto_increment,
IdProveedor int,
FE date,
constraint PK_OrdenDeCompra primary key(IdOrdenDeCompra),
constraint FK_OrdenDeCompra_ foreign key(IdProveedor) references Proveedor(IdProveedor)
)Engine=InnoDB;





create table DetalleOrdenDeCompra(
IdOrdenDeCompra int,
IdProducto int,
Cantidad int,
Monto float,
constraint PK_DetalleOrdenDeCompra primary key(IdOrdenDeCompra,IdProducto),
constraint FK_DetalleOrdenDeCompra_ foreign key(IdOrdenDeCompra) references OrdenDeCompra(IdOrdenDeCompra),
constraint FK_DetalleOrdenDeCompra__ foreign key(IdProducto) references Producto(IdProducto)
)Engine=InnoDB;




create table SolicitudOrdenDeCompra(
IdSolicitudOrdenDeCompra int auto_increment,
FEmitido date,
Valida boolean,
constraint PK_SolicitudOrdenDeCompra primary key(IdSolicitudOrdenDeCompra)
)Engine=InnoDB;




create table DetalleSolicitudOrdenDeCompra(
IdSolicitudOrdenDeCompra int,
IdProducto int,
constraint PK_DetalleSolicitudOrdenDeCompra primary key(IdSolicitudOrdenDeCompra, IdProducto),
constraint FK_DetalleSolicitudOrdenDeCompra_ foreign key(IdProducto) references Producto(IdProducto)
)Engine=InnoDB;




create table Presupuesto(
IdPresupuesto int auto_increment,
IdPedido int,
FormaDePago varchar(30),
FE date,
FVen date,
Monto float,
constraint PK_Presupuesto primary key(IdPresupuesto),
constraint FK_Presupuesto_ foreign key(IdPedido) references Pedido(IdPedido)
)Engine=InnoDB;





create table DetallePresupuesto(
IdPresupuesto int,
IdMueble int,
PrecioUnitario int,
Cantidad int,
constraint PK_DetallePresupuesto primary key(IdPresupuesto,IdMueble),
constraint FK_DetallePresupuesto_ foreign key(IdPresupuesto) references Presupuesto(IdPresupuesto),
constraint FK_DetallePresupuesto__ foreign key(IdMueble) references Mueble(IdMueble)
)Engine=InnoDB;





create table TipoUsuario(
IdTipoUsuario int auto_increment,
ClaseUsuario varchar(40),
constraint PK_TipoUsuario primary key(IdTipoUsuario)
)Engine=InnoDB;





create table Usuario(
IdUsuario int auto_increment,
IdTipoUsuario int,
IdPersona int,
Nombre varchar(30),
Contraseña varchar(40),
constraint PK_Usuario primary key(IdUsuario),
constraint FK_Usuario_ foreign key(IdTipoUsuario) references TipoUsuario(IdTipoUsuario),
constraint FK_Usuario__ foreign key(IdPersona) references Persona(IdPersona)
)Engine=InnoDB;







