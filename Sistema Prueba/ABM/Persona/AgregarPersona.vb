Public Class frmAgregarPersona

    Private Sub frmVolverMenuABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmVolverMenuABM.Click

        Me.Close()
        frmABM.Show()

    End Sub

    Private Sub btnRegistrarPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarPersona.Click

        If txtApellido.Text = "" Or txtDireccion.Text = "" Or txtDNI.Text = "" Or txtNombre.Text = "" Or txtTelefono.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from persona where dni = '" & txtDNI.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) > 0 Then

                MsgBox("El DNI ingresado ya pertenece a una persona")

            Else

                If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                Else

                    sql = ("insert into persona values('', '" & txtNombre.Text & "', '" & txtApellido.Text & "', '" & txtDNI.Text & "', '" & txtTelefono.Text & "', '" & txtDireccion.Text & "')")

                    Call ejecutar(sql)

                    MsgBox("Persona registrada con exito")

                    txtApellido.Text = ""
                    txtNombre.Text = ""
                    txtDNI.Text = ""
                    txtDireccion.Text = ""
                    txtTelefono.Text = ""

                End If

            End If

        End If

    End Sub

    Private Sub txtDNI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNI.KeyPress
        onlynum(e)
    End Sub

    Private Sub txtTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.KeyPress
        onlynum(e)
    End Sub

    Private Sub frmAgregarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class