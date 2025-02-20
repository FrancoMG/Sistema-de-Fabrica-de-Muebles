Public Class frmModificarExtra

    Dim ide As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        frmLista.Close()
        frmABM.Show()

    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress

        onlynum(e)

    End Sub

    Private Sub txtPrecioU_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioU.KeyPress

        onlynum(e)

    End Sub

    Private Sub btnCargarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarDatos.Click

        If txtID.Text = "" Then

            MsgBox("Llene el campo 'ID'")

        Else

            sql = ("select count(*) from extra where idextra = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe ningun extra con el ID ingresado")

            Else

                sql = ("select * from extra where idextra = '" & txtID.Text & "'")

                Call ejecutar(sql)

                rs.Read()

                txtDescripcion.Text = rs(2)
                txtPrecioU.Text = rs(3)

                gbxDatos.Enabled = True

                ide = CInt(txtID.Text)

            End If

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If cmbEstado.Text = "" Or txtDescripcion.Text = "" Or txtPrecioU.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            If CInt(txtPrecioU.Text) = 0 Or CInt(txtPrecioU.Text) < 0 Then

                MsgBox("El precio unitario no puede ser 0 o menor a 0")

            Else

                If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                Else

                    sql = ("update extra set descripcion = '" & txtDescripcion.Text & "', preciounidad = '" & txtPrecioU.Text & "', estado = '" & cmbEstado.Text & "' where idextra = " & ide & "")

                    Call Ejecutar(sql)

                    MsgBox("Datos modificados con exito")

                    txtDescripcion.Text = ""
                    txtPrecioU.Text = ""
                    txtID.Text = ""

                    gbxDatos.Enabled = False

                    frmLista.DataGridView1.DataSource = llenarGrilla("select * from extra")

                End If

            End If

        End If

    End Sub

    Private Sub frmModificarExtra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbEstado.Items.Add("0")
        cmbEstado.Items.Add("1")

    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from extra")

    End Sub

End Class
