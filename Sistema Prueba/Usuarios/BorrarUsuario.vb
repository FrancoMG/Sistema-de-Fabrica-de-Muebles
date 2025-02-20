Public Class frmBorrarUsuario

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        If cmbUsuario.Text = "" Then

            MsgBox("Llene todos los campos", MsgBoxStyle.Exclamation)

        Else

            usuario = (cmbUsuario.Text)

            sql = ("select nombre from usuario where nombre = '" & (cmbUsuario.Text) & "'")

            Call ejecutar(sql)

            rs.Read()

            If MsgBox("Estas seguro de realizar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

            Else

                MsgBox("Usuario '" + cmbUsuario.Text + "' borrado correctamente")

                sql = ("delete from usuario where nombre = '" & (cmbUsuario.Text) & "'")

                Call Ejecutar(sql)

                cmbUsuario.Items.Remove(usuario)

            End If

        End If

    End Sub

    Private Sub btnVolverMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverUsuario.Click

        Me.Close()
        frmUsuarios.Show()

    End Sub

    Private Sub frmBorrarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If boleano = 1 Then

            sql = ("select nombre from usuario where idtipousuario != 1 and idtipousuario != 2")

            Call ejecutar(sql)

            While rs.Read()

                cmbUsuario.Items.Add(rs(0))

            End While

        Else

            sql = ("select nombre from usuario where idtipousuario != 2")

            Call ejecutar(sql)

            While rs.Read()

                cmbUsuario.Items.Add(rs(0))

            End While

        End If

    End Sub

End Class