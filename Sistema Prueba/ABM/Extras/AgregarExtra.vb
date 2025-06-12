Public Class frmAgregarExtra

    Private Sub btnAgregarExtra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarExtra.Click

        If txtDescripcion.Text = "" Or txtPrecio.Text = "" Or txtStock.Text = "" Or txtPP.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from extra where descripcion = '" & txtDescripcion.Text & "'")

            Call Ejecutar(sql)

            rs.Read()

            If rs(0) > 0 Then

                MsgBox("Ya existe un extra con la descripcion ingresada")

            Else

                If txtPrecio.Text = 0 Or txtPrecio.Text < 0 Then

                    MsgBox("El precio no puede ser 0 o menor que 0")

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

                                sql = ("insert into extra values ('', " & idprod & ", '" & txtDescripcion.Text & "', '" & txtPrecio.Text & "', 1)")

                                Call Ejecutar(sql)

                                MsgBox("Extra ingresado con exito")

                                txtDescripcion.Text = ""
                                txtPrecio.Text = ""
                                txtStock.Text = ""
                                txtPP.Text = ""

                            End If

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

    Private Sub txtPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecio.KeyPress

        onlynum(e)

    End Sub

    Private Sub txtStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStock.KeyPress

        onlynum(e)

    End Sub

    Private Sub txtPP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPP.KeyPress

        onlynum(e)

    End Sub
End Class