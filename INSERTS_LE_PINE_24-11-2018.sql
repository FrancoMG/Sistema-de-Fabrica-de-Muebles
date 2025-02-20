insert into Persona values
("", "Jose", "Ramirez", 23851764, 46824397, "Av. Independencia 5824"), /*.*/
("", "Sofia", "Sosa", 34827496, 42719435, "Franklin D.Roosevelt 3719"), /*.*/
("", "Martina", "Palacios", 29457618, 42973182, "Cabrera 9273"), /*.*/
("", "Daniel", "Rodriguez", 25819467, 43946718, "Carlos Pellegrini 1942"),
("", "Juan Manuel", "Diaz", 36819427, 40819372, "Suipacha 7293"), /*.*/
("", "Franco", "Molina", 42819276, 46396197, "Tinogasta 5386"), /*.*/
("", "Alejo", "Cardozo", 42819374, 46372915, "Roberto Lage 4261"), 
("", "Leonel", "Fuentes", 42937182, 40829367, "Jose Bonifacio 7275"),
("", "Kevin", "Oreste", 42617394, 39428472, "Federico Garcia Lorca 1542"),
("", "Camila", "Reyes", 38469215, 38271964, "Roque Saenz Peña 8457"),
("", "Gonzalo", "Martinez", 26394712, 42815976, "O'Higgins 6428"),
("", "Alberto", "Diaz", 21875413, 46589124, "Gral. Mosconi 9276"),
("", "Romina", "Corbera", 36429564, 42631597, "Av. Marabotto 1325"),
("", "Lucia", "Cumiano", 36627185, 42936157, "Comandante Yacas 415");



insert into Cliente values
("", 3),
("", 5),
("", 11),
("", 4),
("", 7),
("", 12),
("", 8),
("", 9),
("", 10),
("", 13),
("", 14);



insert into Tecnico values
("", 1, 0),
("", 4, 1);



insert into Recepcionista values
("", 2),
("", 6);



insert into RecepcionistaDia values
("", 2, "Lunes", "10:00", "14:00"),
("", 1, "Martes", "14:00", "17:00"),
("", 2, "Miercoles", "12:00", "15:00"),
("", 1, "Jueves", "11:00", "14:00"),
("", 2, "Viernes", "15:00", "18:00"),
("", 1, "Sabado", "09:00", "13:00");



insert into TipoMueble values
("", "Silla", 2),
("", "Cama", 4),
("", "Mesa", 3),
("", "Sillon (sin tapizar)", 3),
("", "Alacena", 2),
("", "Biblioteca", 3),
("", "Cuna", 2),
("", "Armario", 4),
("", "Estante", 2),
("", "Bahiut", 2),
("", "Escritorio", 4),
("", "Vanitorio", 3);


insert into Producto values
("", "Rueditas", 180, 200, 1),
("", "Cazoleta", 180, 180, 1),
("", "Roble", 50, 30, 1),
("", "Pino", 0, 48, 1),
("", "Clavos", 250, 500, 1),
("", "Caoba", 50, 40, 1),
("", "Bisagras", 180, 180, 1),
("", "Cedro", 30, 38, 1),
("", "Tope", 120, 150, 1),
("", "Remaches", 180, 250, 1),
("", "Abeto", 0, 45, 1),
("", "Nogal", 15, 25, 1),
("", "Teca", 0, 50, 1),
("", "Cerezo", 45, 55, 1),
("", "Olmo", 50, 52, 1),
("", "Fresno", 50, 35, 1),
("", "Alamo", 50, 22, 1),
("", "Cipres", 50, 25, 1),
("", "Olivo", 50, 20, 1),
("", "Tuercas", 210, 200, 1),
("", "Tornillos", 230, 500, 1);


insert into Madera values
('',8, "Cedro", 2.35, 1),
('',11, "Abeto", 2, 1),
('',6, "Caoba", 2.25, 1),
('',3, "Roble", 2.75, 1),
('',12, "Nogal", 3, 1),
('',13, "Teca", 1.75, 1),
('',14, "Cerezo", 1.50, 1),
('',15, "Olmo", 1.60, 1),
('',4, "Pino", 1.70, 1),
('',17, "Alamo", 3.10, 1),
('',18, "Cipres", 3.05, 1),
('',19, "Olivo", 3.10, 1),
('',16, "Fresno", 2.80, 1);



insert into MaterialDeMontaje values
('',5, "Clavos", 1),
('',20, "Tuercas", 1),
('',7, "Bisagras", 1),
('',10, "Remaches", 1),
('',21, "Tornillos", 1);



insert into Camion values
("", "Renault", "Master", 1),
("", "Renault", "Trafic", 1),
("", "Chevrolet", "Express", 1),
("", "Ford", "Transit", 1),
("", "Mercedes-Benz", "Citan", 1),
("", "Volkswagen", "Transporter", 1),
("", "Mercedes-Benz", "Sprinter", 1),
("", "Volkswagen", "Crafter", 1);



insert into Extra values
('',1, "Rueditas", 170, 1),
('',9, "Tope", 180, 1),
('',2, "Cazoleta", 190, 1);



insert into Pedido values
("", 2, "Av.Lisandro de la Torre 3718", 9.3, 1 ,"2018/09/10"),
("", 1, "Cabrera 9273", 9.6, 1, "2016/10/02"),
("", 9, "Roque Saenz Peña 8457", 8.4, 1, "2018/04/18"),
("", 9,  "Roque Saenz Peña 8457", 8.4 , 1, "2018/04/18"),
("", 7, "Jose Bonifacio 7275", 3.9, 1, "2018/05/08"),
("", 10, null, null, 0, "2016/02/12"),
("", 8, null, null, 0, "2018/01/28"),
("", 4,  null, null, 0, "2015/11/17"),
("", 5,  "Independencia 5920", 14 , 1, "2017/06/24"),
("", 11, "Comandante Yacas 415", 26, 1, "2018/07/05"),
("", 3, "O'Higgins 6428", 12, 1, "2018/02/28");



insert into HojaDeRuta values
("", 3, "2016/10/29"),
("", 6, "2018/09/25");



insert into Mueble values
("", 8, "PARA PRESUPUESTAR", 1, 1),
("", 3, "ENTREGADO", 1, 1),
("", 5, "PARA PRESUPUESTAR", 0, 0),
("", 10, "PARA PRESUPUESTAR",1, 1),
("", 1, "PARA PRESUPUESTAR", 0, 0),
("", 4, "PARA PRESUPUESTAR", 1, 1),
("", 2, "PARA PRESUPUESTAR", 1, 1),
("", 6, "NO ENTREGADO", 1, 1),
("", 7, "DESMANTELADO", 1, 1),
("", 11, "PARA PRESUPUESTAR", 0, 0),
("", 9, "ENTREGADO", 1, 1),
("", 1, "NO ENTREGADO", 1, 1); 



insert into PedidoMueble values
(1, 4, 1),
(2, 8, 1),
(3, 6, 1),
(4, 7, 1),
(5, 2, 1),
(6, 10, 1),
(7, 3, 1),
(8, 5, 1),
(9, 1, 1),
(10, 9, 1),
(11, 11, 1),
(11,12, 1);



insert into MuebleMontaje values
(1, 1, 20),
(5, 1, 18),
(1, 2, 5),
(5, 3, 10),
(3, 3, 6),
(3, 4, 6),
(5, 4, 15),
(1, 5, 10),
(1, 6, 12),
(5, 6, 8),
(2, 7, 8),
(5, 7, 10),
(3, 8, 4),
(5, 8, 15),
(1, 9, 10),
(5, 9, 15),
(2, 10, 4),
(5, 10, 12),
(5, 11, 4),
(3, 12, 4);



insert into MuebleExtra values
(6, 3, 4),
(5, 1, 4),
(5, 3, 2),
(7, 2, 2),
(9, 2, 2),
(9, 1, 4);




insert into DetalleHojaDeRuta values
(1, 5),
(1, 3),
(1, 4),
(1, 1),
(1, 10),
(2, 2),
(2, 11),
(2, 9),
(2, 10);



insert into MuebleMadera values
(1, 13, 15),
(2, 1, 27),
(3, 12, 12),
(4, 11, 16),
(5, 2, 11),
(6, 3, 19),
(7, 3, 10),
(7, 4, 10),
(8, 8, 30),
(9, 12, 10),
(10, 5, 15),
(10, 6, 13),
(11, 13, 17),
(12, 4, 12),
(6, 6, 18),
(10, 7, 16);



insert into Factura values
("", 5, 1, 48000),
("", 1, 0, 60000),
("", 2, 1, 84000),
("", 10, 1, 33000),
("", 11, 1, 35000);



insert into DetalleFactura values
(1, 6, 57000, 1),
(2, 4, 48000, 1),
(3, 8, 90000, 1),
(4, 7, 60000, 1),
(5, 2, 81000, 1),
(5, 10, 84000, 1);



insert into Remanente values
("", 4, 3000),
("", 11, 3000),
("", 13, 3000),
("", 1, 3000),
("", 3, 3000),
("", 2, 3000),
("", 8, 3000),
("", 12, 3000),
("", 3, 3000),
("", 6, 3000),
("", 4, 3000);



insert into Proveedor values
("", "MisterWils", "España 3560", "48346719", "Extras"),
("", "Equipamiento Comercial Viana", "Bermejo 7261", "40593184", "Extras"),
("", "Agaru Mobiliario de Oficina", "Jose Maria Paz 1530", "42371954", "Madera"),
("", "20milproductos", "Mozart 5839", "39716482", "Material de Montaje"),
("", "Taquillas y Bancos", "Andonaegui 7530", "38267164", "Madera"),
("", "Carpinteria Riera Bauza", "Zapiola 862", "41924673", "Madera"),
("", "Mueble Bazar", "Carlos Calvo 9472", "39272816", "Madera"),
("", "Comume", "Alberto Larroque 2749", "38271943", "Extras"),
("", "Moldutec", "Carlos Pellegrini 3750", "42507193", "Extras"),
("", "OfficeDeco", "Entre rios 5748", "39028134", "Material de Montaje");






insert into SolicitudOrdenDeCompra values
("", "2018/09/25", 1),
("", "2018/09/26", 1),
("", "2018/09/27", 1),
("", "2018/09/28", 1),
("", "2018/09/29", 1);



insert into DetalleSolicitudOrdenDeCompra values
(1,4),
(1,8),
(2,11),
(3,12),
(4,13),
(4,14),
(5,15);



insert into ListaDePrecios values
(1, 7, 60),
(2, 3, 1500),
(3, 5, 120),
(4, 9, 130),
(5, 6, 600),
(6, 2, 170),
(7, 10, 180),
(8, 1, 150),
(9, 4, 300),
(7, 5, 100),
(10, 8, 100),
(1, 11, 110),
(2, 12, 120),
(3, 13, 140),
(4, 14, 150),
(5, 15, 145),
(6, 16, 160),
(7, 17, 150),
(8, 18, 120),
(9, 19, 125),
(10, 20, 1600),
(3, 21, 1800);



insert into OrdenDeCompra values
("", 4, "2018/05/18"),
("", 8, "2018/10/07"),
("", 2, "2017/04/27"),
("", 1, "2016/06/17"),
("", 3, "2018/02/20"),
("", 5, "2017/08/09"),
("", 7, "2018/04/13"),
("", 9, "2016/11/27"),
("", 6, "2018/07/29"),
("", 10, "2017/12/15");



insert into DetalleOrdenDeCompra values
(3, 1, 150, 18000),
(7, 4, 80, 14400),
(2, 3, 15, 22500),
(4, 7, 100, 6000),
(5, 5, 150, 18000),
(6, 6, 30, 18000),
(8, 4, 45, 13500),
(9, 2, 18, 34000),
(10, 10, 20, 2000),
(1, 9, 15, 19500);



insert into Presupuesto values
("", 1, "Efectivo", "2018/09/10", "2018/09/17", 48000),
("", 2, "Efectivo", "2016/10/02", "2016/10/09", 90000),
("", 3, "Efectivo", "2018/04/18", "2018/04/25", 57000),
("", 4, "Efectivo", "2018/04/18", "2018/04/25", 60000),
("", 5, "Efectivo", "2018/05/08", "2018/05/15", 81000),
("", 6, "Efectivo", "2016/02/12", "2018/02/19", 84000),
("", 7, "Tarjeta", "2018/01/28", "2018/02/04", 36000),
("", 8, "Tarjeta", "2015/11/17", "2018/11/24", 33000),
("", 9, "Efectivo", "2017/06/24", "2017/07/01", 45000),
("", 10, "Tarjeta", "2018/07/05", "2018/07/12", 30000),
("", 11, "Efectivo", "2018/02/28", "2018/03/07", 51000);



insert into DetallePresupuesto values
(1, 4, 60000, 1),
(2, 8, 90000, 1),
(3, 6, 57000, 1),
(4, 7, 60000, 1),
(5, 2, 81000, 1),
(6, 10, 84000, 1),
(7, 3, 36000, 1),
(8, 5, 33000, 1),
(9, 1, 45000, 1),
(10, 9, 30000, 1),
(11, 11, 51000, 1);


insert into TipoUsuario values
('', "Administrador"),
('', "Administrador General"),
('', "Recepcionista"),
('', "Relaciones Externas");



insert into Usuario values
('',2,2,"AdminGeneral",1234),
('',1,3,"admin",1234),
('',1,4,"admin1",1234),
('',4,5,"relext",1234),
('',3,6,"recepcionista",1234);


