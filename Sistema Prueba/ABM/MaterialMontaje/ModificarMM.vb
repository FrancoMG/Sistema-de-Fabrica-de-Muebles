Public Class frmModificarMM

    Dim idmm As Integer

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress

        onlynum(e)

    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from materialdemontaje")

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        frmLista.Close()
        frmABM.Show()

    End Sub

    Private Sub frmModificarMM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbEstado.Items.Add("0")
        cmbEstado.Items.Add("1")

    End Sub

    Private Sub btnCargarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarDatos.Click

        If txtID.Text = "" Then

            MsgBox("Llene el campo 'ID'")

        Else

            sql = ("select count(*) from materialdemontaje where idmaterialm = '" & txtID.Text & "'")

            Call Ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe ningun material de montaje con el ID ingresado")

            Else

                sql = ("select * from materialdemontaje where idmaterialm = '" & txtID.Text & "'")

                Call Ejecutar(sql)

                rs.Read()

                txtNombre.Text = rs(2)

                gbxDatos.Enabled = True

                idmm = CInt(txtID.Text)

            End If

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If txtNombre.Text = "" Or cmbEstado.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

            Else

                sql = ("update materialdemontaje set nombre = '" & txtNombre.Text & "', estado = '" & cmbEstado.Text & "' where idmaterialm = " & idmm & "")

                Call Ejecutar(sql)

                MsgBox("Datos modificado con exito")

                frmLista.DataGridView1.DataSource = llenarGrilla("select * from materialdemontaje")

                txtNombre.Text = ""
                txtID.Text = ""

                gbxDatos.Enabled = False

            End If

        End If

    End Sub

End Class