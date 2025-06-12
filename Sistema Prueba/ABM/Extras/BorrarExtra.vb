Public Class frmBorrarExtra

    Private Sub btnBorrarExtra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarExtra.Click

        If txtID.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from extra where idextra = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe el extra ingresado")

                txtID.Text = ""

            Else

                sql = ("select estado from extra where idextra = '" & txtID.Text & "'")

                Call ejecutar(sql)

                rs.Read()

                If rs(0) = 0 Then

                    MsgBox("El extra ingresado ya esta deshabilitado")

                Else

                    If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                    Else

                        sql = ("update extra set estado = 0 where idextra = '" & txtID.Text & "'")

                        Call Ejecutar(sql)

                        Dim idprod As Integer

                        sql = ("select idproducto from extra where idextra = '" & txtID.Text & "'")

                        Call Ejecutar(sql)

                        rs.Read()

                        idprod = rs(0)

                        sql = ("update producto set estado = 0  where idproducto = " & idprod & "")

                        Call Ejecutar(sql)

                        sql = ("select descripcion from extra where idextra = '" & txtID.Text & "'")

                        Call Ejecutar(sql)

                        rs.Read()

                        MsgBox("Se deshabilito '" & rs(0) & "' de extras")

                        frmLista.DataGridView1.DataSource = llenarGrilla("select * from extra where estado = 1")

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
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from extra where estado = 1")

    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress
        onlynum(e)
    End Sub
End Class