Public Class frmModificarCliente

    Dim idcliente As Integer

    Private Sub ModificarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbEstado.Items.Add("0")
        cmbEstado.Items.Add("1")

    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress

        onlynum(e)

    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select c.idcliente, p.dni from cliente c, persona p where p.idpersona = c.idpersona")

    End Sub

    Private Sub btnCargarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarDatos.Click

        If txtID.Text = "" Then

            MsgBox("Llene el campo 'ID'")

        Else

            sql = ("select count(*) from cliente where idcliente = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe ningun cliente con el ID ingresado")

            Else

                sql = ("select * from cliente where idcliente = '" & txtID.Text & "'")

                Call ejecutar(sql)

                rs.Read()

                gbxDatos.Enabled = True

                idcliente = CInt(txtID.Text)

            End If

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If cmbEstado.Text = "" Then

            MsgBox("Llene el campo 'estado'")

        Else

            If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

            Else

                sql = ("update cliente set estado = '" & cmbEstado.Text & "' where idcliente = " & idcliente & "")

                Call ejecutar(sql)

                MsgBox("Datos modificados con exito")

                frmLista.DataGridView1.DataSource = llenarGrilla("select c.idcliente, p.dni from cliente c, persona p where p.idpersona = c.idpersona")

                txtID.Text = ""

                gbxDatos.Enabled = False

            End If

        End If

    End Sub
End Class