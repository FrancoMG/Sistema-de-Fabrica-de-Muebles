Public Class frmBorrarMadera

    Private Sub btnBorrarMadera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarMadera.Click

        If txtID.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from madera where idmadera = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe la madera ingresada")

                txtID.Text = ""

            Else

                sql = ("select estado from madera where idmadera = '" & txtID.Text & "'")

                Call ejecutar(sql)

                rs.Read()

                If rs(0) = 0 Then

                    MsgBox("La madera ingresada ya esta deshabilitada")

                Else

                    If MsgBox("Desea confirmar operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                        txtID.Text = ""

                    Else

                        sql = ("update madera set estado = 0 where idmadera = '" & txtID.Text & "'")

                        Call Ejecutar(sql)

                        Dim idprod As Integer

                        sql = ("select idproducto from madera where idmadera = '" & txtID.Text & "'")

                        Call Ejecutar(sql)

                        rs.Read()

                        idprod = rs(0)

                        sql = ("update producto set estado = 0 where idproducto = " & idprod & "")

                        Call Ejecutar(sql)

                        sql = ("select nombre from madera where idmadera = '" & txtID.Text & "'")

                        Call Ejecutar(sql)

                        rs.Read()

                        MsgBox("Se deshabilito '" & rs(0) & "' de madera")

                        frmLista.DataGridView1.DataSource = llenarGrilla("select * from madera where estado = 1")

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
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from madera where estado = 1")

    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress
        onlynum(e)
    End Sub
End Class