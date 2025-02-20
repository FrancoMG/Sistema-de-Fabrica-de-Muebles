Public Class frmModificarTecnico

    Dim idtecnico As Integer

    Private Sub ModificarTenico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbEstado.Items.Add("0")
        cmbEstado.Items.Add("1")

    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress

        onlynum(e)

    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select t.idtecnico, t.idpersona, p.dni, t.disponible from tecnico t, persona p where p.idpersona = t.idpersona")

    End Sub

    Private Sub btnCargarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarDatos.Click

        If txtID.Text = "" Then

            MsgBox("Llene el campo 'ID'")

        Else

            sql = ("select count(*) from tecnico where idtecnico = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe ningun tecnico con el ID ingresado")

            Else

                sql = ("select * from tecnico where idtecnico = '" & txtID.Text & "'")

                Call ejecutar(sql)

                rs.Read()

                gbxDatos.Enabled = True

                idtecnico = CInt(txtID.Text)

            End If

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If cmbEstado.Text = "" Then

            MsgBox("Llene el campo 'estado'")

        Else

            If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

            Else

                sql = ("update tecnico set disponible = '" & cmbEstado.Text & "' where idtecnico = " & idtecnico & "")

                Call ejecutar(sql)

                MsgBox("Datos modificados con exito")

                frmLista.DataGridView1.DataSource = llenarGrilla("select t.idtecnico, t.idpersona, p.dni, t.disponible from tecnico t, persona p where p.idpersona = t.idpersona")

                txtID.Text = ""

                gbxDatos.Enabled = False

            End If

        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        frmLista.Close()
        frmABM.Show()

    End Sub

End Class