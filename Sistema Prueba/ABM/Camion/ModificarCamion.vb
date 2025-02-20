Public Class frmModificarCamion

    Dim idcamion As Integer

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress

        onlynum(e)

    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from camion")

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        frmLista.Close()
        frmABM.Show()

    End Sub

    Private Sub frmModificarCamion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbEstado.Items.Add("0")
        cmbEstado.Items.Add("1")

    End Sub

    Private Sub btnCargarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarDatos.Click

        If txtID.Text = "" Then

            MsgBox("Llene el campo 'ID'")

        Else

            sql = ("select count(*) from camion where idcamion = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe ningun camion con el ID ingresado")

            Else

                sql = ("select * from camion where idcamion = '" & txtID.Text & "'")

                Call ejecutar(sql)

                rs.Read()

                txtMarca.Text = rs(1)
                txtModelo.Text = rs(2)

                gbxDatos.Enabled = True

                idcamion = CInt(txtID.Text)

            End If

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If txtMarca.Text = "" Or txtModelo.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

            Else

                sql = ("update camion set marca = '" & txtMarca.Text & "', modelo = '" & txtModelo.Text & "', disponible = '" & cmbEstado.Text & "' where idcamion = " & idcamion & "")

                Call ejecutar(sql)

                MsgBox("Datos modificados correctamente")

                frmLista.DataGridView1.DataSource = llenarGrilla("select * from camion")

                txtMarca.Text = ""
                txtModelo.Text = ""

                gbxDatos.Enabled = False

            End If

        End If

    End Sub

End Class