Public Class frmModificarPermisos

    Private Sub btnVolverUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverUsuario.Click

        Me.Close()
        frmUsuarios.Show()

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        If cmbPermisos.Text = "" Or cmbUsuario.Text = "" Then

            MsgBox("Llene todos los campos", MsgBoxStyle.Exclamation)

        Else

            sql = ("select count(*) from usuario where idtipousuario = (select idtipousuario from tipousuario where claseusuario = '" & cmbPermisos.Text & "') and nombre = '" & cmbUsuario.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) > 0 Then

                MsgBox("El usuario '" + cmbUsuario.Text + "' ya es '" + cmbPermisos.Text + "'")

            Else

                If MsgBox("Estas seguro de realizar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then



                Else

                    sql = ("select idtipousuario from tipousuario where claseusuario = '" & cmbPermisos.Text & "'")

                    Call ejecutar(sql)

                    rs.Read()

                    idtipousuario = rs(0)

                    sql = ("update usuario set idtipousuario = '" & idtipousuario & "' where nombre = '" & cmbUsuario.Text & "'")

                    Call ejecutar(sql)

                    MsgBox("Permisos modificados con exito")

                End If

            End If

        End If

    End Sub

    Private Sub frmModificarPermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        sql = ("select claseusuario from tipousuario where claseusuario != 'administrador general'")

            Call ejecutar(sql)

            While rs.Read()

                cmbPermisos.Items.Add(rs(0))

            End While



    End Sub

End Class