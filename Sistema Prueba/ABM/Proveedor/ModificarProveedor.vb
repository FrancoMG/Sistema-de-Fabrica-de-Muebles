Public Class frmModificarProveedor

    Dim idp As Integer

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress

        onlynum(e)

    End Sub

    Private Sub btnCargarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarDatos.Click

        If txtID.Text = "" Then

            MsgBox("Llene el campo 'ID'")

        Else

            sql = ("select count(*) from proveedor where idproveedor = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe ningun proveedor con el ID ingresado")

            Else

                sql = ("select * from proveedor where idproveedor = '" & txtID.Text & "'")

                Call ejecutar(sql)

                rs.Read()

                txtNombre.Text = rs(1)
                txtDireccion.Text = rs(2)
                txtContacto.Text = rs(3)

                gbxDatos.Enabled = True

                idp = CInt(txtID.Text)

            End If

        End If

    End Sub

    Private Sub frmModificarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbTP.Items.Add("Madera")
        cmbTP.Items.Add("Extras")

        cmbEstado.Items.Add("0")
        cmbEstado.Items.Add("1")

    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from proveedor")

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        frmLista.Close()
        frmABM.Show()

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If txtContacto.Text = "" Or txtDireccion.Text = "" Or txtNombre.Text = "" Or cmbEstado.Text = "" Or cmbTP.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

            Else

                sql = ("update proveedor set nombre = '" & txtNombre.Text & "', contacto = '" & txtContacto.Text & "', direccion = '" & txtDireccion.Text & "', tipoproveedor = '" & cmbTP.Text & "', estado = '" & cmbEstado.Text & "' where idproveedor = " & idp & "")

                Call ejecutar(sql)

                MsgBox("Datos modificados con exito")

                txtNombre.Text = ""
                txtDireccion.Text = ""
                txtContacto.Text = ""
                txtID.Text = ""

                gbxDatos.Enabled = False

                frmLista.DataGridView1.DataSource = llenarGrilla("select * from proveedor")

            End If

        End If

    End Sub

End Class