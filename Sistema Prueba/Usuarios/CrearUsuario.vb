Public Class frmCrearUsuario

    Dim idtipou As Integer

    Dim id As Integer

    Private Sub frmRegistrarUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Shown

        sql = ("select claseusuario from tipousuario where claseusuario <> 'administrador general'")

        Call ejecutar(sql)

        While rs.Read()

            cmbTipoUsuario.Items.Add(rs(0))

        End While

        gbxUsuario.Enabled = False

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverUsuario.Click

        frmLista.Close()
        Me.Close()
        frmUsuarios.Show()

    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click


        If txtNombre.Text = "" Or txtContraseña.Text = "" Or txtConfirmarContraseña.Text = "" Or cmbTipoUsuario.Text = "" Then

            MsgBox("Llene todos los campos", MsgBoxStyle.Exclamation)

        Else

            sql = ("select count(*) from usuario where nombre = '" & txtNombre.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) > 0 Then

                MsgBox("Nombre de usuario existente", MsgBoxStyle.Exclamation)

                txtNombre.Text = ""
                txtContraseña.Text = ""
                txtConfirmarContraseña.Text = ""

            Else

                If txtConfirmarContraseña.Text <> txtContraseña.Text Then

                    MsgBox("Las contraseñas no coinciden", MsgBoxStyle.Exclamation)

                    txtContraseña.Text = ""
                    txtConfirmarContraseña.Text = ""

                Else

                    If MsgBox("Estas seguro de realizar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                        txtNombre.Text = ""
                        txtContraseña.Text = ""
                        txtConfirmarContraseña.Text = ""

                    Else

                        sql = ("select idtipousuario from tipousuario where claseusuario = '" & cmbTipoUsuario.Text & "'")

                        Call ejecutar(sql)

                        rs.Read()

                        idtipou = CInt(rs(0))

                        sql = ("select idpersona from persona where idpersona = '" & id & "'")

                        Call ejecutar(sql)

                        rs.Read()

                        Dim idPersona As Integer = CInt(rs(0))

                        sql = ("insert into usuario values ('', " & idtipou & ", " & idPersona & ",'" & txtNombre.Text & "', '" & txtContraseña.Text & "')")

                        Call ejecutar(sql)

                        MsgBox("Usuario '" & txtNombre.Text & "' registrado con exito")

                        txtContraseña.Text = ""
                        txtConfirmarContraseña.Text = ""
                        txtNombre.Text = ""
                        dniUsuario.Text = ""

                        gbxUsuario.Enabled = False

                        txtID.Enabled = True
                        btnVerificar.Enabled = True

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub btnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificar.Click

        If txtID.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from persona where idpersona = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("Error. No existe ninguna persona asociada a este ID")

            Else

                sql = ("select count(*) from usuario where idpersona = (select idpersona from recepcionista where idpersona = '" & txtID.Text & "')")

                Call ejecutar(sql)

                rs.Read()

                If rs(0) > 0 Then

                    MsgBox("La persona YA dispone de un usuario")

                Else

                    If MsgBox("Desea seguir?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then



                    Else

                        gbxUsuario.Enabled = True

                        id = txtID.Text

                        txtID.Text = ""

                        MsgBox("Prosiga")

                        txtID.Enabled = False
                        btnVerificar.Enabled = False

                    End If

                End If

            End If

        End If


    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from persona")

    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress

        onlynum(e)

    End Sub

    Private Sub cmbTipoUsuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoUsuario.SelectedIndexChanged

    End Sub
End Class