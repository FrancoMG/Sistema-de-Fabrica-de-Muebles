Public Class frmBorrarProveedor

    Private Sub btnBorrarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarProveedor.Click

        If txtID.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from proveedor where idproveedor = " & CInt(txtID.Text) & "")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("El proveedor ingresado no existe")

                txtID.Text = ""

            Else

                sql = ("select estado, nombre from proveedor where idproveedor = " & CInt(txtID.Text) & "")

                Call ejecutar(sql)

                rs.Read()

                If rs(0) = 0 Then

                    MsgBox("El proveedor ingresado ya esta deshabilitado")

                Else

                    If MsgBox("Se deshabilitara de proveedor '" & rs(1) & "', desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                    Else

                        sql = ("update proveedor set estado = 0 where idproveedor = " & CInt(txtID.Text) & "")

                        Call Ejecutar(sql)

                        sql = ("select nombre from proveedor where idproveedor = '" & txtID.Text & "'")

                        Call Ejecutar(sql)

                        rs.Read()

                        MsgBox("Se deshabilito '" & rs(0) & "' de proveedor")

                        frmLista.DataGridView1.DataSource = llenarGrilla("select * from proveedor where estado = 1")

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
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from proveedor where estado = 1")

    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress
        onlynum(e)
    End Sub
End Class