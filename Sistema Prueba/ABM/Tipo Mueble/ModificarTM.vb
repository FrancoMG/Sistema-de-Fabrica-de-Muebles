Public Class frmModificarTM

    Dim idtm As Integer

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress

        onlynum(e)

    End Sub

    Private Sub txtTiempoP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTiempoP.KeyPress

        onlynum(e)

    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from tipomueble")

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If txtDescripcion.Text = "" Or txtTiempoP.Text = "" Or cmbEstado.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            If CInt(txtTiempoP.Text) = 0 Or txtTiempoP.Text < 0 Then

                MsgBox("El tiempo de produccion no puede ser 0 o menor que 0")

            Else

                If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                Else

                    sql = ("update tipomueble set descripcion = '" & txtDescripcion.Text & "', tiempoproduccion = '" & txtTiempoP.Text & "', estado = '" & cmbEstado.Text & "' where idtipomueble = " & idtm & "")

                    Call ejecutar(sql)

                    MsgBox("Datos modificados correctamente")

                    frmLista.DataGridView1.DataSource = llenarGrilla("select * from tipomueble")

                    txtDescripcion.Text = ""
                    txtID.Text = ""
                    txtTiempoP.Text = ""

                    gbxDatos.Enabled = False

                End If

            End If

        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        frmLista.Close()
        frmABM.Show()

    End Sub

    Private Sub btnCargarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarDatos.Click

        If txtID.Text = "" Then

            MsgBox("Llene el campo 'ID'")

        Else

            sql = ("select count(*) from tipomueble where idtipomueble = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe ningun tipo de mueble con el ID ingresado")

            Else

                sql = ("select * from tipomueble where idtipomueble = '" & txtID.Text & "'")

                Call ejecutar(sql)

                rs.Read()

                txtDescripcion.Text = rs(1)
                txtTiempoP.Text = rs(2)

                gbxDatos.Enabled = True

                idtm = CInt(txtID.Text)

            End If

        End If

    End Sub

    Private Sub frmModificarTM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbEstado.Items.Add("0")
        cmbEstado.Items.Add("1")

    End Sub

End Class