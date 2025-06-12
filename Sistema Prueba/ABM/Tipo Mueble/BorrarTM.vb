Public Class frmBorrarTM

    Private Sub btnBorrarTM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarTM.Click

        If txtID.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from tipomueble where idtipomueble = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe el Tipo de Mueble ingresado")

                txtID.Text = ""

            Else

                sql = ("select estado from tipomueble where idtipomueble = '" & txtID.Text & "'")

                Call ejecutar(sql)

                rs.Read()

                If rs(0) = 0 Then

                    MsgBox("El Tipo de Mueble ingresado ya esta deshabilitado")

                    txtID.Text = ""

                Else

                    If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                        txtID.Text = ""

                    Else

                        sql = ("update TipoMueble set estado = 0 where idtipomueble = '" & txtID.Text & "'")

                        Call Ejecutar(sql)

                        sql = ("select descripcion from tipomueble where idtipomueble = '" & txtID.Text & "'")

                        Call Ejecutar(sql)

                        rs.Read()

                        MsgBox("Se deshabilito '" & rs(0) & "' de tipos de mueble")

                        frmLista.DataGridView1.DataSource = llenarGrilla("select * from tipomueble where estado = 1")

                        txtID.Text = ""

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub btnVolverMenuABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMenuABM.Click

        Me.Close()
        frmABM.Show()
        frmLista.Close()

    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from tipomueble where estado = 1")

    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress
        onlynum(e)
    End Sub
End Class