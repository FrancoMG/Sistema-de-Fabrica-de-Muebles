Public Class frmPedidoMueble
    Public cont As Integer
    Public var1 As String
    Public var2 As String
    Public varidcliente As Integer
    Public vardomcliente As String
    Public varidpedido As Integer
    Public varidmueble As Integer
    Public varidtipomueble As Integer
    Public anterior As String
    Public varidpersona As Integer
    Public varidplancha As Integer
    Public varidplancha2 As Integer
    Public maxremanente As Integer
    Public maxremanente2 As Integer
    Public contaagregar As Integer
    Public varidmadera As Integer
    Public varidmadera2 As Integer
    Public idremanente As Integer
    Public cantplanchas As Decimal
    Public cm2 As Integer
    Public contador As Integer
    Public negativo As Integer
    Public cantplanchas2 As Decimal
    Public cm2_2 As Integer
    Public contador2 As Integer
    Public negativo2 As Integer
    Public cant As Integer
    Public varsi As Integer
    Public pedidoanterior As Integer
    Public acum As Integer
    Public apellido As String
    Public nombre As String
    Public vartxtcm2 As String
    Public vartxtcm2_2 As String
    Public vartxtcantidad As String
    Public varcmbxd As String
    Public varcmbxd2 As String
    Public varextra As Integer
    Public varidextra As Integer
    Public vartxtcantidad2 As String
    Public entro As Integer
    Public xde As Integer
    Public extratotal As Decimal
    Public valido As Integer
    Public extra As Decimal



    Public nuevomueble As Integer

    Public monto As Decimal
    Public monto2 As Decimal
    Public montototal As Decimal
    Public montototaltotal As Decimal
    Public montosemi As Decimal
    Public idmaderamonto As Integer
    Public idmaderamonto2 As Integer
    Public montoextra As Decimal



    Public contextra As Integer


    Public an As Integer
    Public insertidcliente As Integer
    Public insertDirEntrega As String
    Public insertDistanciaKM As String
    Public varpmueble As Integer

    










    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarMadera.Click








        cont = cont + 1

        If cont = 1 Then
            cmbMaderaMueble2.Visible = True
            txtCM2_2.Visible = True
            lblCM2_2.Visible = True
        End If

        If cont = 2 Then
            cmbMaderaMueble2.Visible = False
            txtCM2_2.Visible = False
            lblCM2_2.Visible = False
            cont = 0
        End If

        If cont = 1 Then
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCM2_2.Text <> "" And cmbMaderaMueble2.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else
                btnIngresarMueble.Enabled = False
            End If
        End If


        If cont = 0 Then

            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else

                btnIngresarMueble.Enabled = False
            End If


        End If

    End Sub

    Private Sub frmPedidoMueble_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnIngresarMueble.Enabled = False

        btnAgregarPedido.Enabled = True










        sql = "select descripcion from tipomueble;"

        Call Ejecutar(sql)

        While rs.Read()

            cmbTipoMueble.Items.Add(rs(0))

        End While




        sql = "select nombre from madera;"

        Call Ejecutar(sql)
        While rs.Read()

            cmbMaderaMueble.Items.Add(rs(0))

        End While





        sql = "select nombre from madera;"

        Call Ejecutar(sql)
        While rs.Read()

            cmbMaderaMueble2.Items.Add(rs(0))

        End While


        sql = "select descripcion from extra;"

        Call Ejecutar(sql)
        While rs.Read

            cmbExtra.Items.Add(rs(0))

        End While





    End Sub

    Private Sub btnAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        Me.Close()
        frmDNICliente.Show()
    End Sub

    Private Sub btnIngresarMueble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarMueble.Click
        If CInt(txtCantidad.Text) > 5 Then

            MsgBox("Ingrese una cantidad válida")

            txtCantidad.Text = ""
        Else



            If txtCantidad.Text <= 0 And chkAgregarExtra.Checked = True Then





                MsgBox("La casilla 'Cantidad' no puede tener como valor '0 ni numeros negativos'", MsgBoxStyle.Critical, "Error")

                xde = 1
            Else
                xde = 0
            End If


            If xde = 0 Then

                If cmbMaderaMueble.Text = "" Or cmbTipoMueble.Text = "" Or txtCM2.Text = "" Then
                    MsgBox("Llene todos los campos", MsgBoxStyle.Critical, "Error")
                Else


                    If cmbTipoMueble.Text = "" Then
                        var1 = "Tipo de mueble"
                    Else
                        var1 = ""
                    End If

                    If cmbMaderaMueble.Text = "" Then
                        var2 = "Madera del mueble"
                    Else
                        var2 = ""
                    End If







                    '------------------------------------------------------------------------------------------------------------------------------------------------------------








                    If cmbTipoMueble.Text = "" Or cmbMaderaMueble.Text = "" Then




                        MsgBox("Complete los siguientes campos: " + var1 + " " + var2 + " ", MsgBoxStyle.Critical, "Error")
                    Else
                        If txtCantidad.Text <= 0 Then

                            MsgBox("La casilla 'Cantidad' no puede tener como valor '0 ni numeros negativos'", MsgBoxStyle.Critical, "Error")
                        Else
                            frmExtraDireccionDistanciaKM.Show()
                            Me.Hide()

                        End If

                    End If
                End If

            End If
        End If

    End Sub

    Private Sub cmbMaderaMueble_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMaderaMueble.SelectedIndexChanged

        If cmbMaderaMueble.Text = "" Then
        Else
            btnAgregarMadera.Enabled = True

        End If
        If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCantidad.Text <> "" Then
            btnIngresarMueble.Enabled = True

        End If

        If anterior = "" Then
            anterior = cmbMaderaMueble.Text
            cmbMaderaMueble2.Items.Remove(cmbMaderaMueble.Text)
        Else
            cmbMaderaMueble2.Items.Add(anterior)
            anterior = cmbMaderaMueble.Text
            cmbMaderaMueble2.Items.Remove(cmbMaderaMueble.Text)
        End If

    End Sub

    Private Sub btnAgregarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPedido.Click


        btnAtras.Enabled = False



        '-------------------------EXTRA--------------------------
        If chkAgregarExtra.Checked = True Then


            sql = "select idextra from extra where descripcion='" & cmbExtra.Text & "';"
            Call Ejecutar(sql)
            rs.Read()

            varidextra = rs(0)



            sql = "select idmadera from madera where nombre = '" & cmbMaderaMueble.Text & "' ;"
            Call Ejecutar(sql)
            rs.Read()
            varidmadera = rs(0)

            'MsgBox(varidextra)

            sql = "select p.idproducto from producto p, extra m where p.idproducto=m.idproducto and idextra =" & varidextra & ";"
            Call Ejecutar(sql)
            rs.Read()

            sql = "update producto set stock = stock-" & cantplanchas & " where idproducto = " & rs(0) & ";"
            Call Ejecutar(sql)

            sql = "select preciounidad from extra where idextra=" & varidextra & ";"
            Call Ejecutar(sql)
            rs.Read()

            montoextra = rs(0)
        End If
        '--------------------------------------------------------

        ' If frmDNICliente.dniex = 0 Then
        btnAgregarPedido.Enabled = False

        If frmDNICliente.FORMULARIODNI = 0 Then

            If nuevomueble = 0 Then


                sql = "insert into Persona values('','" & frmPedidoCliente.nom & "', '" & frmPedidoCliente.ape & "', '" & frmDNICliente.DNI & "', '" & frmPedidoCliente.Tel & "', '" & frmPedidoCliente.Direc & "');"
                Call Ejecutar(sql)

                sql = "select idpersona from persona where DNI=" & frmDNICliente.DNI & ";"
                Call Ejecutar(sql)
                rs.Read()

                varidpersona = rs(0)


                sql = "insert into Cliente values('', " & varidpersona & ");"
                Call Ejecutar(sql)
                MsgBox("¡Cliente " & frmPedidoCliente.ape & ", " & frmPedidoCliente.nom & " ingresado!", MsgBoxStyle.Information, "Cliente")

            End If

        End If



        sql = "select idcliente from cliente c, persona p where c.idpersona=p.idpersona and p.DNI=" & frmDNICliente.DNI & ";"
        Call Ejecutar(sql)
        rs.Read()

        varidcliente = rs(0)




        '  While cant < CInt(txtCantidad.Text)

        sql = "select idmadera from madera where nombre = '" & cmbMaderaMueble.Text & "' ;"
        Call Ejecutar(sql)
        rs.Read()
        varidmadera = rs(0)

        If cont = 1 Then


            sql = "select idmadera from madera where nombre = '" & cmbMaderaMueble2.Text & "' ;"
            Call Ejecutar(sql)
            rs.Read()
            varidmadera2 = rs(0)

        End If


        sql = "select idtipomueble from tipomueble where descripcion ='" & cmbTipoMueble.Text & "';"
        Call Ejecutar(sql)
        rs.Read()
        varidtipomueble = rs(0)

        If cont = 1 Then

            sql = "Select precioventaporCM2 from madera where idmadera = " & varidmadera2 & " ;"
            Call Ejecutar(sql)
            rs.Read()

            monto2 = txtCM2_2.Text * rs(0)
        End If



        sql = "Select precioventaporCM2 from madera where idmadera = " & varidmadera & " ;"
        Call Ejecutar(sql)
        rs.Read()

        monto = txtCM2.Text * rs(0)

        montosemi = monto + monto2

        montototal = (monto + monto2) * txtCantidad.Text



        ' montoextra

        '  cant = cant + 1


        'End While

        cant = 0

        ' If MsgBox("¿El cliente acepta el presupuesto en este momento? : $" & montototal & "", MsgBoxStyle.YesNo, "Presupuesto") = MsgBoxResult.Yes Then


        'End If



        '-----------




        '------------



        '-----------------------------------FINAL CODE--------------------------------------------

        acum = acum + txtCantidad.Text







        sql = "select curdate()"
        Call Ejecutar(sql)
        rs.Read()

        frmDocumento_Presupuesto_.lblfecha.Text = rs(0)

        sql = "select idcliente from cliente c, persona p where c.idpersona = p.idpersona and p.DNI=" & frmDNICliente.DNI & ";"
        Call Ejecutar(sql)
        rs.Read()

        frmDocumento_Presupuesto_.lblnumero.Text = rs(0)

        sql = "select Apellido from persona where DNI=" & frmDNICliente.DNI & ";"
        Call Ejecutar(sql)
        rs.Read()

        apellido = rs(0)

        sql = "select Nombre from persona where DNI=" & frmDNICliente.DNI & ";"
        Call Ejecutar(sql)
        rs.Read()

        nombre = rs(0)

        frmDocumento_Presupuesto_.lblCliente.Text = "" & apellido & ", " & nombre & ""











        '------------------------------------------------------------------------------------------

        '--------------------------------------ACA2-----------------------------------------

        vartxtcm2 = txtCM2.Text
        vartxtcm2_2 = txtCM2_2.Text
        vartxtcantidad = txtCantidad.Text
        varcmbxd = cmbMaderaMueble.Text
        varcmbxd2 = cmbMaderaMueble2.Text
        vartxtcantidad2 = txtCantidad2.Text



        Me.Hide()
        frmMaterialDeMontaje.Show()





    End Sub

    Private Sub cmbTipoMueble_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoMueble.SelectedIndexChanged

        If cont = 0 Then
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else

                btnIngresarMueble.Enabled = False
            End If
        Else
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCM2_2.Text <> "" And cmbMaderaMueble2.Text <> "" And txtCantidad.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else

                btnIngresarMueble.Enabled = False
            End If
        End If

    End Sub

    Private Sub txtCM2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCM2.TextChanged

        If txtCM2.Text = "0" Then
            txtCM2.Text = ""
        End If

        If cont = 0 Then
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCantidad.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else

                btnIngresarMueble.Enabled = False
            End If
        Else
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCM2_2.Text <> "" And cmbMaderaMueble2.Text <> "" And txtCantidad.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else

                btnIngresarMueble.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtCM2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCM2.KeyPress
        Onlynum(e)
    End Sub


    Private Sub txtCM2_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCM2_2.TextChanged

        If txtCM2_2.Text = "0" Then

            txtCM2_2.Text = ""

        End If

        If cont = 0 Then
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else

                btnIngresarMueble.Enabled = False
            End If
        Else
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCM2_2.Text <> "" And cmbMaderaMueble2.Text <> "" And txtCantidad.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else

                btnIngresarMueble.Enabled = False
            End If
        End If
        '..........
        If chkAgregarExtra.Checked = True Then
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCM2_2.Text <> "" And cmbMaderaMueble2.Text <> "" And txtCantidad.Text <> "" And cmbExtra.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else
                btnIngresarMueble.Enabled = False
            End If
        End If
        '..........

    End Sub

    Private Sub txtCM2_2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCM2_2.KeyPress

        Onlynum(e)

    End Sub
    Private Sub txtCantidad_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCantidad.TextChanged
        If txtCantidad.Text = "0" Then

            txtCantidad.Text = ""

        End If





        If cont = 0 Then
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCantidad.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else

                btnIngresarMueble.Enabled = False
            End If



        Else
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCM2_2.Text <> "" And cmbMaderaMueble2.Text <> "" And txtCantidad.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else

                btnIngresarMueble.Enabled = False
            End If

        End If

        If chkAgregarExtra.Checked = True Then
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCM2_2.Text <> "" And cmbMaderaMueble2.Text <> "" And txtCantidad.Text <> "" And cmbExtra.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else
                btnIngresarMueble.Enabled = False
            End If
        End If


    End Sub
    Private Sub txtCantidad_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles txtCantidad.KeyPress
        Onlynum(e)

    End Sub


    Private Sub chkAgregarExtra_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkAgregarExtra.CheckedChanged

        If chkAgregarExtra.Checked = True Then
            cmbExtra.Visible = True
            lblCantidad2.Visible = True
            txtCantidad2.Visible = True

            varextra = 1
        Else
            cmbExtra.Visible = False
            lblCantidad2.Visible = False
            txtCantidad2.Visible = False

            varextra = 0
        End If
        '..................................................................xdd------------------------------------------------------

        If cont = 0 Then
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCantidad.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else

                btnIngresarMueble.Enabled = False
            End If



        Else
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCM2_2.Text <> "" And cmbMaderaMueble2.Text <> "" And txtCantidad.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else

                btnIngresarMueble.Enabled = False
            End If

        End If


        '------------------------------------------------------------------------------------------------------------------------------

        If chkAgregarExtra.Checked = True Then
            If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCM2_2.Text <> "" And cmbMaderaMueble2.Text <> "" And txtCantidad.Text <> "" And cmbExtra.Text <> "" And txtCantidad2.Text <> "" Then
                btnIngresarMueble.Enabled = True
            Else
                btnIngresarMueble.Enabled = False
            End If
        End If

    End Sub

    Private Sub txtCantidad2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCantidad2.TextChanged

        If txtCantidad2.Text = "0" Then

            txtCantidad2.Text = ""

        End If

        If chkAgregarExtra.Checked = True Then
            If cont = 1 Then

                If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCM2_2.Text <> "" And cmbMaderaMueble2.Text <> "" And txtCantidad.Text <> "" And cmbExtra.Text <> "" And txtCantidad2.Text <> "" Then
                    btnIngresarMueble.Enabled = True
                Else
                    btnIngresarMueble.Enabled = False
                End If
            Else
                If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCantidad.Text <> "" And cmbExtra.Text <> "" And txtCantidad2.Text <> "" Then
                    btnIngresarMueble.Enabled = True
                Else
                    btnIngresarMueble.Enabled = False
                End If


            End If
        End If
    End Sub

    Private Sub txtCantidad2_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles txtCantidad2.KeyPress
        Onlynum(e)
    End Sub

    Private Sub cmbExtra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExtra.SelectedIndexChanged

        If chkAgregarExtra.Checked = True Then
            If cont = 1 Then

                If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCM2_2.Text <> "" And cmbMaderaMueble2.Text <> "" And txtCantidad.Text <> "" And cmbExtra.Text <> "" And txtCantidad2.Text <> "" Then
                    btnIngresarMueble.Enabled = True
                Else
                    btnIngresarMueble.Enabled = False
                End If
            Else
                If cmbMaderaMueble.Text <> "" And cmbTipoMueble.Text <> "" And txtCM2.Text <> "" And txtCantidad.Text <> "" And cmbExtra.Text <> "" And txtCantidad2.Text <> "" Then
                    btnIngresarMueble.Enabled = True
                Else
                    btnIngresarMueble.Enabled = False
                End If


            End If


        End If

    End Sub
End Class