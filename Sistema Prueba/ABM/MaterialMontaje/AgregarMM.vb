Public Class frmAgregarMM

    Private Sub btnAgregarMM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarMM.Click

        If txtDescripcion.Text = "" Or txtStock.Text = "" Or txtPP.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from materialdemontaje where nombre = '" & txtDescripcion.Text & "'")

            Call Ejecutar(sql)

            rs.Read()

            If rs(0) > 0 Then

                MsgBox("El material de montaje ingresado ya existe")

                txtDescripcion.Text = ""

            Else

                If txtStock.Text < 0 Then

                    MsgBox("El stock no puede ser menor a 0")

                Else

                    If txtPP.Text = 0 Or txtPP.Text < 0 Then

                        MsgBox("El punto de pedido no puede ser menor o igual a 0")

                    Else

                        If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then



                        Else

                            sql = ("insert into producto values ('', '" & txtDescripcion.Text & "', '" & CInt(txtStock.Text) & "', '" & CInt(txtPP.Text) & "', 1)")

                            Call Ejecutar(sql)

                            Dim idprod As Integer

                            sql = ("select max(idproducto) from producto")

                            Call Ejecutar(sql)

                            rs.Read()

                            idprod = rs(0)

                            sql = ("insert into materialdemontaje values ('', " & idprod & ", '" & txtDescripcion.Text & "', 1)")

                            Call Ejecutar(sql)

                            MsgBox("Material de montaje ingresado con exito")

                            txtDescripcion.Text = ""
                            txtStock.Text = ""
                            txtPP.Text = ""

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub btnVolverMenuABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMenuABM.Click

        Me.Close()
        frmABM.Show()

    End Sub

    Private Sub txtStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStock.KeyPress
        onlynum(e)
    End Sub

    Private Sub txtPP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPP.KeyPress
        onlynum(e)
    End Sub


End Class