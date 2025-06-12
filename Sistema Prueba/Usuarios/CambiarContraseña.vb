Public Class frmCambiarContraseña

    Private Sub frmCambiarContraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If boleano = 1 Then

            sql = ("select nombre from usuario where idtipousuario = 3 or idtipousuario = 4 or nombre = '" & nombreUsuario & "'")

            Call ejecutar(sql)

            While rs.Read()

                cmbNombreUsuario.Items.Add(rs(0))

            End While

        Else

            sql = ("select nombre from usuario")

            Call ejecutar(sql)

            While rs.Read()

                cmbNombreUsuario.Items.Add(rs(0))

            End While

        End If

    End Sub

    Private Sub btnCambiarContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarContraseña.Click

        If txtCNC.Text = "" Or txtVC.Text = "" Or txtNC.Text = "" Or cmbNombreUsuario.Text = "" Then

            MsgBox("Llene todos los campos", MsgBoxStyle.Exclamation)

        Else

            sql = "select count(*) from usuario where nombre = '" & cmbNombreUsuario.Text & "' and contraseña = '" & txtVC.Text & "'"

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("La vieja contraseña es incorrecta", MsgBoxStyle.Exclamation)

                txtVC.Text = ""
                txtNC.Text = ""
                txtCNC.Text = ""

            Else

                If txtNC.Text <> txtCNC.Text Then

                    MsgBox("Las contraseñas nuevas no coinciden")

                    txtVC.Text = ""
                    txtNC.Text = ""
                    txtCNC.Text = ""

                Else

                    If MsgBox("Estas seguro de realizar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                        txtVC.Text = ""
                        txtNC.Text = ""
                        txtCNC.Text = ""

                    Else

                        sql = ("update usuario set contraseña = '" & txtNC.Text & "' where nombre = '" & cmbNombreUsuario.Text & "'")

                        Call ejecutar(sql)

                        MsgBox("Contraseña actualizada correctamente")

                        txtCNC.Text = ""
                        txtNC.Text = ""
                        txtVC.Text = ""

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub btnVolverUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverUsuario.Click

        Me.Close()
        frmUsuarios.Show()

    End Sub
End Class