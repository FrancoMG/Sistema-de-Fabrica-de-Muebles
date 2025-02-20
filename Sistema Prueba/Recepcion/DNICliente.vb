Imports System.Data.Odbc
Public Class frmDNICliente

    Public DNI As Integer
    Public FORMULARIODNI As Integer
    Public dniex As Integer

    Private Sub frmDNICliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub




    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        frmPedidoMueble.btnAtras.Enabled = True
        If txtDNI.Text = "" Then
            MsgBox("Complete los campos: DNI", MsgBoxStyle.Exclamation, "Error")
        Else


            sql = "select count(c.idcliente) from Persona p, Cliente c where DNI=" & txtDNI.Text & " and p.IdPersona=c.IdPersona;"
            Call Ejecutar(sql)
            rs.Read()
            DNI = CInt(txtDNI.Text)

            If rs(0) = 0 Then

                dniex = txtDNI.Text

                MsgBox("El DNI ingresado no pertenece a ningun cliente", MsgBoxStyle.Exclamation, "DNI")


                Me.Hide()
                frmPedidoCliente.Show()


            Else

                sql = "select apellido, nombre from persona where DNI=" & DNI & ";"
                Call Ejecutar(sql)
                rs.Read()

                If MsgBox("El DNI ingresado coincide con el de un Cliente: " & rs(0) & ", " & rs(1) & "", MsgBoxStyle.OkOnly, "DNI") = MsgBoxResult.No Then

                    'NO PASA NADA ACA
                    FORMULARIODNI = FORMULARIODNI + 1
                Else
                    FORMULARIODNI = FORMULARIODNI + 1
                    Me.Hide()
                    frmPedidoMueble.Show()

                End If

            End If

        End If




    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        txtDNI.Text = ""

        Me.Close()
        frmSectores.Show()

    End Sub

    Private Sub txtDNI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNI.KeyPress
        onlynum(e)
    End Sub



    Private Sub btnRevisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevisar.Click

        frmRevisarPresupuesto.Show()
        Me.Hide()

    End Sub




End Class
