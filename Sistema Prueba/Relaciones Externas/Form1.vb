Imports System.Data.Odbc
Public Class RelacionesExternas

    Dim cantidad As Integer
    Dim Madera As Integer
    Dim MaterialMontaje As Integer
    Dim Extras As Integer
    Dim maxidorden As Integer
    Dim precio As Integer
    Dim IdSolicitudOrdenDeCompra As Integer
    Dim aux As Integer
    Dim acum As Integer

    Private Sub GenerarOrdenDeCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarOrdenDeCompra.Click
        switch = 1
        sql = "select count(idsolicitudordendecompra) from solicitudordendecompra where valida=1"
        Call Ejecutar(sql)
        rs.Read()
        If rs(0) > 0 Then
            sql = "select idproducto from detallesolicitudordendecompra ds, solicitudordendecompra s where s.idsolicitudordendecompra=ds.idsolicitudordendecompra and valida=1"
            Call Ejecutar(sql)
            While rs.Read
                switch = 2
                sql = "select idproveedor from listadeprecios where idproducto='" & rs(0) & "' and precio=(select min(precio) from listadeprecios where idproducto='" & rs(0) & "') limit 1 "
                Call Ejecutar(sql)
                rs2.Read()

                aux = rs2(0)

                sql = "insert into ordendecompra values('','" & rs2(0) & "',curdate())"
                Call Ejecutar(sql)

                sql = "select nombre, direccion, contacto from proveedor where idproveedor='" & aux & "'"
                Call Ejecutar(sql)
                rs2.Read()

                OrdenDeCompra.lblFechaPedido.Text = Date.Today
                OrdenDeCompra.lblNumProveedor.Text = aux
                OrdenDeCompra.lblNombreProveedor.Text = rs2(0)
                OrdenDeCompra.lblDomicilio.Text = rs2(1)
                OrdenDeCompra.lblTelefono.Text = rs2(2)





                sql = "select count(idproducto) from producto where Nombre_Comercial in(select nombre from madera) and idproducto='" & rs(0) & "'"
                Call Ejecutar(sql)
                rs2.Read()

                Madera = rs2(0)

                'MsgBox(rs2(0))

                sql = "select count(idproducto) from producto where Nombre_Comercial in(select descripcion from extra) and idproducto='" & rs(0) & "'"
                Call Ejecutar(sql)
                rs2.Read()

                Extras = rs2(0)


                sql = "select count(idproducto) from producto where Nombre_Comercial in(select nombre from materialdemontaje) and idproducto='" & rs(0) & "'"
                Call Ejecutar(sql)
                rs2.Read()

                MaterialMontaje = rs2(0)


                'POR FAVOR YO DEL FUTURO TE CONFUNDAS, HAY 1 IF POR SI EL PRODUCTO ES MADERA, OTRO PARA EXTRAS Y OTRO PARA MATERIALES DE MONTAJE
                If Madera > 0 Then
                    'MsgBox("Madera")
                    sql = "select stock from producto where idproducto='" & rs(0) & "'"
                    Call Ejecutar(sql)
                    rs2.Read()

                    cantidad = rs2(0)

                    sql = "select pp-'" & cantidad & "' from producto where idproducto='" & rs(0) & "'"
                    Call Ejecutar(sql)
                    rs2.Read()

                    cantidad = rs2(0) * 2

                    'MsgBox(cantidad)

                    sql = "select max(idordendecompra) from ordendecompra"
                    Call Ejecutar(sql)
                    rs2.Read()

                    maxidorden = rs2(0)

                    sql = "select precio*'" & cantidad & "' from listadeprecios where idproducto='" & rs(0) & "' and idproveedor=(select idproveedor from ordendecompra where idordendecompra=(select max(idordendecompra) from ordendecompra))"
                    Call Ejecutar(sql)
                    rs2.Read()

                    precio = rs2(0)

                    sql = "insert into detalleordendecompra values('" & maxidorden & "','" & rs(0) & "','" & cantidad & "','" & precio & "')"
                    Call Ejecutar(sql)

                    sql = "select Nombre_Comercial from producto where idproducto='" & rs(0) & "'"
                    Call Ejecutar(sql)
                    rs2.Read()

                    OrdenDeCompra.lblDescripcion1.Text = rs2(0)
                    OrdenDeCompra.lblCantidad1.Text = cantidad

                    sql = "select precio from listadeprecios where idproducto='" & rs(0) & "' and idproveedor='" & aux & "'"
                    Call Ejecutar(sql)
                    rs2.Read()

                    acum = acum + (rs2(0) * cantidad)

                    OrdenDeCompra.lblPrecio1.Text = rs2(0)
                    OrdenDeCompra.lblTotal.Text = acum

                    Me.Hide()
                    OrdenDeCompra.Show()
                    MsgBox("Presione 'Aceptar' para pasar a la siguiente orden de compra", vbInformation)

                ElseIf Extras > 0 Then

                    'MsgBox("Extra")

                    sql = "select stock from producto where idproducto='" & rs(0) & "'"
                    Call Ejecutar(sql)
                    rs2.Read()

                    cantidad = rs2(0)

                    sql = "select pp-'" & cantidad & "' from producto where idproducto='" & rs(0) & "'"
                    Call Ejecutar(sql)
                    rs2.Read()

                    cantidad = rs2(0)

                    sql = "select max(idordendecompra) from ordendecompra"
                    Call Ejecutar(sql)
                    rs2.Read()

                    maxidorden = rs2(0)

                    sql = "select precio*'" & cantidad & "' from listadeprecios where idproducto='" & rs(0) & "' and idproveedor=(select idproveedor from ordendecompra where idordendecompra=(select max(idordendecompra) from ordendecompra))"
                    Call Ejecutar(sql)
                    rs2.Read()

                    precio = rs2(0)

                    sql = "insert into detalleordendecompra values('" & maxidorden & "','" & rs(0) & "','" & cantidad & "','" & precio & "')"
                    Call Ejecutar(sql)

                    sql = "select Nombre_Comercial from producto where idproducto='" & rs(0) & "'"
                    Call Ejecutar(sql)
                    rs2.Read()

                    OrdenDeCompra.lblDescripcion1.Text = rs2(0)
                    OrdenDeCompra.lblCantidad1.Text = cantidad

                    sql = "select precio from listadeprecios where idproducto='" & rs(0) & "' and idproveedor='" & aux & "'"
                    Call Ejecutar(sql)
                    rs2.Read()

                    acum = acum + (rs2(0) * cantidad)

                    OrdenDeCompra.lblPrecio1.Text = rs2(0)
                    OrdenDeCompra.lblTotal.Text = acum

                    Me.Hide()
                    OrdenDeCompra.Show()
                    MsgBox("Presione 'Aceptar' para pasar a la siguiente orden de compra", vbInformation)

                ElseIf MaterialMontaje > 0 Then

                    'MsgBox("MaterialMontaje")

                    sql = "select stock from producto where idproducto='" & rs(0) & "'"
                    Call Ejecutar(sql)
                    rs2.Read()

                    cantidad = rs2(0)

                    sql = "select pp-'" & cantidad & "' from producto where idproducto='" & rs(0) & "'"
                    Call Ejecutar(sql)
                    rs2.Read()

                    cantidad = rs2(0)

                    sql = "select max(idordendecompra) from ordendecompra"
                    Call Ejecutar(sql)
                    rs2.Read()

                    maxidorden = rs2(0)

                    sql = "select precio*'" & cantidad & "' from listadeprecios where idproducto='" & rs(0) & "' and idproveedor=(select idproveedor from ordendecompra where idordendecompra=(select max(idordendecompra) from ordendecompra))"
                    Call Ejecutar(sql)
                    rs2.Read()

                    precio = rs2(0)

                    sql = "insert into detalleordendecompra values('" & maxidorden & "','" & rs(0) & "','" & cantidad & "','" & precio & "')"
                    Call Ejecutar(sql)

                    sql = "select Nombre_Comercial from producto where idproducto='" & rs(0) & "'"
                    Call Ejecutar(sql)
                    rs2.Read()

                    OrdenDeCompra.lblDescripcion1.Text = rs2(0)
                    OrdenDeCompra.lblCantidad1.Text = cantidad

                    sql = "select precio from listadeprecios where idproducto='" & rs(0) & "' and idproveedor='" & aux & "'"
                    Call Ejecutar(sql)
                    rs2.Read()

                    acum = acum + (rs2(0) * cantidad)

                    OrdenDeCompra.lblPrecio1.Text = rs2(0)
                    OrdenDeCompra.lblTotal.Text = acum

                    Me.Hide()
                    OrdenDeCompra.Show()
                    MsgBox("Presione 'Aceptar' para pasar a la siguiente orden de compra", vbInformation)

                End If

                sql = "select idsolicitudordendecompra from detallesolicitudordendecompra where idproducto='" & rs(0) & "'"
                Call Ejecutar(sql)
                rs2.Read()

                IdSolicitudOrdenDeCompra = rs2(0)

                sql = "update solicitudordendecompra set valida=0 where idsolicitudordendecompra='" & IdSolicitudOrdenDeCompra & "'"
                Call Ejecutar(sql)

                'MsgBox("Siguiente")
                'MsgBox(rs(0))

                acum = 0
            End While
            MsgBox("Una vez haya terminado de revisar la ultima orden de compra, clickee la misma para volver al menu de principal", vbInformation)
            switch = 1

        Else

            MsgBox("No hay ninguna Solicitud de Orden de Compra pendiente para gestionar su Orden de Compra", vbInformation)

        End If



    End Sub

    Private Sub RelacionesExternas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnListaDePrecios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaDePrecios.Click
        Me.Hide()
        frmGrilla.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        frmSectores.Show()

    End Sub
End Class
