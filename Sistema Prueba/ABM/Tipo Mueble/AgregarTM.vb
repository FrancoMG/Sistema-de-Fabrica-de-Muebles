Public Class frmAgregarTM

    Private Sub btnAgregarTM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTM.Click

        If txtDescripcion.Text = "" Or txtTP.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from tipomueble where descripcion = '" & txtDescripcion.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) > 0 Then

                MsgBox("Ya existe el Tipo de Mueble ingresado")

                txtDescripcion.Text = ""

            Else

                If txtTP.Text = 0 Or txtTP.Text < 0 Then

                    MsgBox("El tiempo de produccion no puede ser 0 o menor a 0")

                    txtTP.Text = ""

                Else

                    If MsgBox("'" + txtDescripcion.Text + "' se ingresara como un nuevo Tipo de Mueble, desea confirmar la opeacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                        txtDescripcion.Text = ""

                    Else

                        sql = ("insert into tipomueble values('', '" & txtDescripcion.Text & "', " & CInt(txtTP.Text) & ")")

                        Call ejecutar(sql)

                        MsgBox("Tipo de Mueble agregado con exito")

                        txtDescripcion.Text = ""
                        txtTP.Text = ""

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub btnVolverMenuABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMenuABM.Click

        Me.Close()
        frmABM.Show()

    End Sub

    Private Sub txtTP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTP.KeyPress
        onlynum(e)
    End Sub
End Class