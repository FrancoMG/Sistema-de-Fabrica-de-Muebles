Public Class frmModificarMadera

    Dim idm As Integer

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from madera")

    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress
        onlynum(e)
    End Sub

    Private Sub txtTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioxCM2.KeyPress
        onlynum(e)
    End Sub

    Private Sub btnCargarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarDatos.Click

        If txtID.Text = "" Then

            MsgBox("Llene el campo 'ID'")

        Else

            sql = ("select count(*) from madera where idmadera = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe ninguna madera con el ID ingresado")

            Else

                sql = ("select * from madera where idmadera = '" & txtID.Text & "'")

                Call ejecutar(sql)

                rs.Read()

                txtNombre.Text = rs(2)
                txtPrecioxCM2.Text = rs(3)

                gbxDatos.Enabled = True

                idm = CInt(txtID.Text)

            End If

        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        frmLista.Close()
        frmABM.Show()

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If txtNombre.Text = "" Or txtPrecioxCM2.Text = "" Or cmbEstado.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            If CInt(txtPrecioxCM2.Text) < 0 Or CInt(txtPrecioxCM2.Text) = 0 Then

                MsgBox("El precio no puede ser menor o igual a 0")

            Else


                If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                Else

                    sql = ("update madera set nombre = '" & txtNombre.Text & "', precioventaporcm2 = '" & CInt(txtPrecioxCM2.Text) & "', estado = '" & cmbEstado.Text & "' where idmadera = " & idm & "")

                    Call Ejecutar(sql)

                    MsgBox("Datos modificados con exito")

                    txtNombre.Text = ""
                    txtPrecioxCM2.Text = ""
                    txtID.Text = ""

                    gbxDatos.Enabled = False

                    frmLista.DataGridView1.DataSource = llenarGrilla("select * from madera")

                End If

            End If

        End If

    End Sub

    Private Sub frmModificarMadera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbEstado.Items.Add("0")
        cmbEstado.Items.Add("1")

    End Sub

End Class