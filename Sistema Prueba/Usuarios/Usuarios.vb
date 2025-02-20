Public Class frmUsuarios

    Private Sub btnBorrarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarUsuario.Click

        Me.Hide()
        frmBorrarUsuario.Show()

    End Sub

    Private Sub btnCrearUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearUsuario.Click

        Me.Hide()
        frmCrearUsuario.Show()

    End Sub

    Private Sub btnVolverMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMenu.Click

        Me.Close()
        frmSectores.Show()

    End Sub

    Private Sub btnModificarContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarContraseña.Click

        Me.Hide()
        frmCambiarContraseña.show()

    End Sub

    Private Sub btnModificarPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPermisos.Click

        Me.Hide()
        frmModificarPermisos.Show()

    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If boleano = 1 Then

            btnCrearUsuario.Enabled = False

        Else

            btnCrearUsuario.Enabled = True

        End If

    End Sub
End Class