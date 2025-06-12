Public Class frmInicio

    Private Sub frmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblFecha.Text = Date.Today

        connection()

    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        If txtUsuario.Text = "" Or txtContra.Text = "" Then

            MsgBox("Llene todos los campos", MsgBoxStyle.Exclamation, "Error")

        Else

            sql = ("select count(*), nombre, contraseña from usuario where nombre = '" & txtUsuario.Text & "'")

            Call ejecutar(Sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe el usuario", MsgBoxStyle.Exclamation, "Error")

            Else

                If rs(2) <> txtContra.Text Then

                    MsgBox("Contraseña incorrecta", MsgBoxStyle.Exclamation, "Error")

                Else

                    MsgBox("Bienvenido '" + txtUsuario.Text + "'")

                    sql = ("select claseusuario from tipousuario where idtipousuario = (select idtipousuario from usuario where nombre = '" & txtUsuario.Text & "')")

                    Call ejecutar(sql)

                    rs.Read()

                    If rs(0) = "Administrador" Then

                        boleano = 1
                        tipousuario = rs(0)

                    ElseIf rs(0) = "Administrador General" Then

                        boleano = 2
                        tipousuario = rs(0)

                    ElseIf rs(0) = "Recepcionista" Then

                        boleano = 3
                        tipousuario = rs(0)

                    Else

                        boleano = 4
                        tipousuario = rs(0)

                    End If

                    nombreUsuario = txtUsuario.Text

                    sql = ("select claseusuario from tipousuario where idtipousuario = (select idtipousuario from usuario where nombre = '" & nombreUsuario & "')")

                    Call ejecutar(sql)

                    rs.Read()

                    permisos = rs(0)

                    txtContra.Text = ""
                    txtUsuario.Text = ""

                    Me.Hide()
                    frmSectores.Show()

                End If

            End If

        End If

    End Sub

    Private Sub chbMC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbMC.CheckedChanged

        If chbMC.Checked = True Then

            txtContra.UseSystemPasswordChar = False

        Else

            txtContra.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click

        If MsgBox("Estas seguro de que desea salir del sistema?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

        Else

            Application.Exit()

        End If

    End Sub

End Class
