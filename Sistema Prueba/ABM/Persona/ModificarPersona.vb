Public Class frmModificarPersona

    Dim idp As Integer

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from persona")

    End Sub

    Private Sub btnCargarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarDatos.Click

        If txtID.Text = "" Then

            MsgBox("Llene el campo 'ID'")

        Else

            sql = ("select count(*) from persona where idpersona = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe ninguna persona con el ID ingresado")

            Else

                sql = ("select * from persona where idpersona = '" & txtID.Text & "'")

                Call ejecutar(sql)

                rs.Read()

                txtNombre.Text = rs(1)
                txtApellido.Text = rs(2)
                txtTelefono.Text = rs(4)
                txtDireccion.Text = rs(5)

                gbxDatos.Enabled = True

                idp = CInt(txtID.Text)

            End If

        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        frmABM.Show()
        Me.Close()
        frmLista.Close()

    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtDireccion.Text = "" Or txtTelefono.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

            Else

                sql = ("update persona set nombre = '" & txtNombre.Text & "', apellido = '" & txtApellido.Text & "', telefono = '" & txtTelefono.Text & "', direccion = '" & txtDireccion.Text & "' where idpersona = '" & idp & "'")

                Call ejecutar(sql)

                MsgBox("Datos modificados con exito")

                gbxDatos.Enabled = False

                txtNombre.Text = ""
                txtApellido.Text = ""
                txtTelefono.Text = ""
                txtDireccion.Text = ""
                txtID.Text = ""

                frmLista.DataGridView1.DataSource = llenarGrilla("select * from persona")

            End If

        End If

    End Sub

    Private Sub txtTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.KeyPress
        onlynum(e)
    End Sub
End Class