Public Class frmRevisarPresupuesto

    Dim var As Date
    Dim var2 As Date
    Dim resta As Date



    Private Sub btnSiguiente_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSiguiente.Click
        



        '-----------TERMINAR---------




        sql = "select count(idfactura) from factura where idpedido = " & txtNumeroPedido.Text & ""
        Call Ejecutar(sql)
        rs.Read()

        If rs(0) > 0 Then



            ' sql = "select Aceptado from pedido where idpedido = " & txtNumeroPedido.Text & ""
            ' Call Ejecutar(sql)
            ' rs.Read()
            ' MsgBox(0)



            switch = 2

            sql = "select count(m.idmueble) from mueble m, pedidomueble pm where estado = 'PARA PRESUPUESTAR' and pm.idmueble=m.idmueble and pm.idpedido = " & txtNumeroPedido.Text & ";"
            Call Ejecutar(sql)
            rs2.Read()


            switch = 1

            If rs2(0) > 0 Then

                sql = "select fechasolicitado from pedido where idpedido =" & txtNumeroPedido.Text & ";"
                Call Ejecutar(sql)
                rs.Read()

                sql = "select datediff (curdate(), '" & Format(rs(0), "yyyy/MM/dd") & "')"
                Call Ejecutar(sql)
                rs.Read()
                If rs(0) <= 7 Then

                    If MsgBox("¿El cliente acepta el presupuesto?", MsgBoxStyle.YesNo, "Presupuesto") = MsgBoxResult.Yes Then


                        sql = "select idmueble from pedidomueble where idpedido=" & txtNumeroPedido.Text & ""
                        Call Ejecutar(sql)


                        While rs.Read



                            sql = "update mueble set estado = 'NO ENTREGADO' where idmueble = " & rs(0) & ";"
                            Call Ejecutar(sql)







                        End While

                        sql = "select idfactura from factura where idpedido =" & txtNumeroPedido.Text & ";"
                        Call Ejecutar(sql)
                        rs.Read()


                        sql = "update factura set paga = 1 where idfactura=" & rs(0) & ";"
                        Call Ejecutar(sql)




                        MsgBox("¡Presupuesto actualizado!", MsgBoxStyle.Information, "Presupuesto")
                        Me.Close()
                        frmDNICliente.Show()
                        frmDNICliente.txtDNI.Text = ""
                    Else

                        MsgBox("No se han realizado cambios", MsgBoxStyle.Information, "Presupuesto")
                        Me.Close()
                        frmDNICliente.Show()

                    End If
                Else


                    MsgBox("La factura ha caducado. Le recomendamos que calcule un nuevo presupuesto", MsgBoxStyle.Critical, "¡Cuidado!")


                End If
            Else
                MsgBox("No se han realizado cambios ya que el presupuesto ha sido pagado", MsgBoxStyle.Information, "Presupuesto")
                Me.Close()
                frmDNICliente.Show()
                frmDNICliente.txtDNI.Text = ""

            End If




            ' If rs2(0) = 0 Then
            '
            '     
            '     
            '
        Else

            MsgBox("El N° de pedido ingresado no existe, intente con otro valor", MsgBoxStyle.Critical, "¡Cuidado!")
            Me.Close()
            frmDNICliente.Show()
            frmDNICliente.txtDNI.Text = ""

        End If

        
    End Sub

    Private Sub frmRevisarPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        btnSiguiente.Enabled = False


    End Sub

    Private Sub txtNumeroPedido_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNumeroPedido.KeyPress
        Onlynum(e)
    End Sub

    Private Sub txtNumeroPedido_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles txtNumeroPedido.TextChanged

        If txtNumeroPedido.Text = "0" Then

            txtNumeroPedido.Text = ""

        End If

        If txtNumeroPedido.Text <> "" Then

            btnSiguiente.Enabled = True


        Else
            btnSiguiente.Enabled = False

        End If
    End Sub

    Private Sub btnAtras_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAtras.Click
        Me.Close()
        frmDNICliente.Show()
    End Sub
End Class