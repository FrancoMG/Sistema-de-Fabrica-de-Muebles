Imports System.Data.Odbc
Public Class frmAdministracion
    Dim camion As Integer
    Dim idhoja As Integer
    Dim HORASHOY As Integer = 16
    Dim conta As Integer
    Dim varidcamion As Integer
    Dim tubi5 As Integer
    Dim varidpedido As Integer
    Dim varrs3 As Integer
    Dim varcantmuebles As Integer
    Dim cantidadusada As Integer
    Dim cantidaddisponible As Integer
    Dim i As Integer
    Dim hoy As Date
    Dim varfechaantes As Date
    Dim varfechadesp As Date
    Dim diferencia As String
    Dim aux As String
    '-------------------
    Dim madera As Integer
    Dim materialmontaje As Integer
    Dim extra As Integer
    Dim varcantpp As Integer
    Dim varid As Integer
    Dim varnombre As String
    Dim cant As Integer
    Dim cantpp As Integer
    Dim acum As Integer
    Dim flag As Boolean = True


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub


    Private Sub ControlarStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlarStock.Click



        switch = 2
        sql = "select idproducto from producto"
        Call Ejecutar(sql)


        While rs2.Read

            switch = 1
            sql = "select count(idproducto) from producto where Nombre_Comercial in(select nombre from madera) and idproducto = '" & rs2(0) & "';"
            Call Ejecutar(sql)
            rs.Read()

            madera = rs(0)


            sql = "select count(idproducto) from producto where Nombre_Comercial in(select descripcion from extra) and idproducto = '" & rs2(0) & "';"
            Call Ejecutar(sql)
            rs.Read()

            extra = rs(0)


            sql = "select count(idproducto) from producto where Nombre_Comercial in(select nombre from materialdemontaje) and idproducto = '" & rs2(0) & "';"
            Call Ejecutar(sql)
            rs.Read()

            materialmontaje = rs(0)





            If madera > 0 Then


                sql = "select pp from producto where idproducto = " & rs2(0) & ";"
                Call Ejecutar(sql)
                rs.Read()
                varcantpp = rs(0)



                sql = "select Nombre_Comercial from producto where idproducto=" & rs2(0) & ";"
                Call Ejecutar(sql)
                rs.Read()
                varnombre = rs(0)



                sql = "select stock from producto where idproducto=" & rs2(0) & ";"
                Call Ejecutar(sql)
                rs.Read()
                cant = rs(0)


                If varcantpp > cant Then

                    sql = "select count(idproducto) from detallesolicitudordendecompra ds, solicitudordendecompra s where ds.idsolicitudordendecompra=s.idsolicitudordendecompra and ds.idproducto=" & rs2(0) & " and valida=1"
                    Call Ejecutar(sql)
                    rs.Read()

                    If rs(0) = 0 Then


                        sql = "insert into solicitudordendecompra values('', curdate(), 1)"
                        Call Ejecutar(sql)

                        sql = "select max(IdSolicitudOrdenDeCompra) from solicitudordendecompra;"
                        Call Ejecutar(sql)
                        rs.Read()

                        sql = "insert into detallesolicitudordendecompra values(" & rs(0) & "," & rs2(0) & ");"
                        Call Ejecutar(sql)

                        acum = acum + 1

                    End If

                End If

                '-------------------------------------------------------------------------------------

            End If

            If extra > 0 Then





                sql = "select pp from producto where idproducto = " & rs2(0) & ";"
                Call Ejecutar(sql)
                rs.Read()
                varcantpp = rs(0)

                sql = "select Nombre_Comercial from producto where idproducto = " & rs2(0) & ";"
                Call Ejecutar(sql)
                rs.Read()
                varnombre = rs(0)

                sql = "select stock from producto where idproducto = " & rs2(0) & ";"
                Call Ejecutar(sql)
                rs.Read()
                cant = rs(0)




                If varcantpp > cant Then

                    sql = "select count(idproducto) from detallesolicitudordendecompra ds, solicitudordendecompra s where ds.idsolicitudordendecompra=s.idsolicitudordendecompra and ds.idproducto=" & rs2(0) & " and valida=1"
                    Call Ejecutar(sql)
                    rs.Read()

                    If rs(0) = 0 Then


                        sql = "insert into solicitudordendecompra values('', curdate(), 1)"
                        Call Ejecutar(sql)

                        sql = "select max(IdSolicitudOrdenDeCompra) from solicitudordendecompra;"
                        Call Ejecutar(sql)
                        rs.Read()

                        sql = "insert into detallesolicitudordendecompra values(" & rs(0) & "," & rs2(0) & ");"
                        Call Ejecutar(sql)

                        acum = acum + 1

                    End If

                End If




            End If

            If materialmontaje > 0 Then


                sql = "select pp from producto where idproducto = " & rs2(0) & ";"
                Call Ejecutar(sql)
                rs.Read()
                varcantpp = rs(0)

                sql = "select Nombre_Comercial from producto where idproducto = " & rs2(0) & ";"
                Call Ejecutar(sql)
                rs.Read()
                varnombre = rs(0)

                sql = "select stock from producto where idproducto = " & rs2(0) & ";"
                Call Ejecutar(sql)
                rs.Read()
                cant = rs(0)




                If varcantpp > cant Then

                    sql = "select count(idproducto) from detallesolicitudordendecompra ds, solicitudordendecompra s where ds.idsolicitudordendecompra=s.idsolicitudordendecompra and ds.idproducto=" & rs2(0) & " and valida=1"
                    Call Ejecutar(sql)
                    rs.Read()

                    If rs(0) = 0 Then


                        sql = "insert into solicitudordendecompra values('', curdate(), 1)"
                        Call Ejecutar(sql)

                        sql = "select max(IdSolicitudOrdenDeCompra) from solicitudordendecompra;"
                        Call Ejecutar(sql)
                        rs.Read()

                        sql = "insert into detallesolicitudordendecompra values(" & rs(0) & "," & rs2(0) & ");"
                        Call Ejecutar(sql)

                        acum = acum + 1

                    End If

                End If






            End If




        End While


        switch = 1

        If acum = 0 Then

            MsgBox("Le informamos que no posee productos que requieran reposición de stock. Por este mismo motivo, no se generó ninguna SolicitudDeOrdenDeCompra nueva.", MsgBoxStyle.Information, "¡Cuidado!")

        Else

            MsgBox("Se han generado las SolicitudesDeOrdenDeCompra del día con éxito.", MsgBoxStyle.Information, "Solicitudes generadas")

        End If











        acum = 0






        

    End Sub

    Private Sub btnGstionarHojasDeRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionarHojasDeRuta.Click

        sql = "select count(*) from camion where disponible = 1;"
        Call Ejecutar(sql)
        rs.Read()

        tubi5 = rs(0)




        If tubi5 > 0 Then









            switch = 2

            sql = "select p.idpedido from pedido p, pedidomueble pm, mueble m where p.idpedido=pm.idpedido and pm.idmueble = m.idmueble and m.produccionfinalizada= 1 and p.aceptado=1 and Estado='NO ENTREGADO';"
            Call Ejecutar(sql)


            While rs2.Read And flag = True

                switch = 3

                sql = "select count(idpedido) from detallehojaderuta dh, hojaderuta h where dh.idhoja=h.idhoja and idpedido=" & rs2(0) & " and FechaSalida=(select date_add(curdate(), interval 1 day))"
                Call Ejecutar(sql)
                rs3.Read()

                If rs3(0) = 0 Then

                    acum = acum + 1

                    sql = "select count(idmueble) from pedidomueble where idpedido =" & rs2(0) & ";"
                    Call Ejecutar(sql)
                    rs3.Read()

                    varcantmuebles = rs3(0)


                    switch = 4
                    sql = "select count(pm.idmueble) from pedidomueble pm, mueble m where pm.idmueble=m.idmueble and pm.idpedido=" & rs2(0) & " and produccionfinalizada = 1"
                    Call Ejecutar(sql)
                    rs4.Read()

                    If rs4(0) = varcantmuebles Then







                        switch = 3


                        If varcantmuebles < 11 Then

                            switch = 1

                            sql = "select count(idcamion) from camion where disponible=1"
                            Call Ejecutar(sql)
                            rs.Read()

                            If rs(0) <> 0 Then

                                sql = "select idcamion from camion where disponible = 1;"
                                Call Ejecutar(sql)
                                rs.Read()


                                varidcamion = rs(0)

                                switch = 3

                                sql = "select date_add(curdate(), interval 1 day);"
                                Call Ejecutar(sql)
                                rs3.Read()

                                frmHojaDeRuta.lblFechaSalida.Text = rs3(0)

                                sql = "Insert into hojaderuta values('', " & varidcamion & ", '" & Format(rs3(0), "yyyy/MM/dd") & "');"
                                Call Ejecutar(sql)

                                sql = "select DirEntrega from pedido where idpedido=" & rs2(0) & ""
                                Call Ejecutar(sql)
                                rs3.Read()

                                frmHojaDeRuta.lblDireccion.Text = rs3(0)
                                frmHojaDeRuta.lblCamion.Text = varidcamion

                                sql = "select max(idhoja) from hojaderuta"
                                Call Ejecutar(sql)
                                rs3.Read()

                                varrs3 = rs3(0)

                                frmHojaDeRuta.lblIdHoja.Text = rs3(0)
                                frmHojaDeRuta.lblPedido.Text = rs2(0)

                                sql = "select Nombre,Apellido from persona p, cliente c, pedido ped where p.idpersona=c.idpersona and c.idcliente=ped.idcliente and idpedido=" & rs2(0) & ""
                                Call Ejecutar(sql)
                                rs3.Read()

                                frmHojaDeRuta.lblCliente.Text = rs3(0)
                                frmHojaDeRuta.lblApellidoCliente.Text = rs3(1)

                                sql = "insert into detallehojaderuta values(" & varrs3 & ", " & rs2(0) & ");"
                                Call Ejecutar(sql)

                                sql = "update camion set disponible = 0 where idcamion = " & varidcamion & ";"
                                Call Ejecutar(sql)

                                flag = True


                                frmHojaDeRuta.Show()
                                MsgBox("Presione aceptar cuando desee pasar a la siguiente Hoja de Ruta", MsgBoxStyle.Information, "Hoja de Ruta generada con éxito")
                                frmHojaDeRuta.Hide()
                            Else

                                MsgBox("Operación interrumpida. No hay camiones disponibles a los que asignarles una HojaDeRuta. Sin embargo, se han generado el máximo de HojasDeRuta posibles.", MsgBoxStyle.Exclamation, "¡Cuidado!")

                                flag = False

                            End If




                        Else


                            While varcantmuebles > 10 And varcantmuebles > 0 And flag = True

                                cantidaddisponible = 10

                                switch = 1

                                sql = "select count(idcamion) from camion where disponible=1"
                                Call Ejecutar(sql)
                                rs.Read()

                                If rs(0) <> 0 Then

                                    sql = "select idcamion from camion where disponible = 1;"
                                    Call Ejecutar(sql)
                                    rs.Read()

                                    switch = 3


                                    sql = "select date_add(curdate(), interval 1 day);"
                                    Call Ejecutar(sql)
                                    rs3.Read()

                                    sql = "Insert into hojaderuta values('', " & varidcamion & ", '" & Format(rs3(0), "yyyy/MM/dd") & "');"
                                    Call Ejecutar(sql)


                                    sql = "select max(idhoja) from hojaderuta"
                                    Call Ejecutar(sql)
                                    rs3.Read()

                                    varrs3 = rs3(0)


                                    sql = "insert into detallehojaderuta values(" & varrs3 & ", " & rs2(0) & ");"
                                    Call Ejecutar(sql)

                                    sql = "update camion set disponible = 0 where idcamion = " & varidcamion & ";"
                                    Call Ejecutar(sql)


                                    varcantmuebles = varcantmuebles - cantidaddisponible


                                    flag = True

                                Else

                                    MsgBox("Operación interrumpida. No hay camiones disponibles a los que asignarles una HojaDeRuta. Sin embargo, se han generado el máximo de HojasDeRuta posibles.", MsgBoxStyle.Exclamation, "¡Cuidado!")

                                    flag = False

                                End If


                            End While

                        End If

                    End If

                End If

                

            End While
            switch = 1



            If acum = 0 Then

                MsgBox("Le informamos que no hay pedidos finalizados y sin entregar que no tengan una HojaDeRuta activa. Por lo tanto no se generó ninguna HojaDeRuta.", MsgBoxStyle.Information, "¡Cuidado!")

                flag = False

            End If




        Else

            MsgBox("Operación abortada. No hay camiones disponibles a los que asignarles una HojaDeRuta.", MsgBoxStyle.Information, "¡Cuidado!")

            flag = False

        End If

        If flag = True Then

            MsgBox("Operación finalizada con éxito, se han generado las HojasDeRuta del día asignando a ellas todos los pedidos finalizados sin entregar que no poseían una HojaDeRuta activa.", MsgBoxStyle.Information, "Hojas de Ruta generadas")

        End If

        flag = True
        '------------------------------------------------------------------------------------------------------------------
        acum = 0

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        frmSectores.Show()

    End Sub
End Class
