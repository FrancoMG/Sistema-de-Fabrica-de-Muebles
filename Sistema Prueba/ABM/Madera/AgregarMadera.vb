Public Class frmAgregarMadera

    Private Sub btnAgregarMadera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarMadera.Click

        If txtDescripcion.Text = "" Or txtStock.Text = "" Or txtPrecioxCM2.Text = "" Or txtPP.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from madera where nombre = '" & txtDescripcion.Text & "'")

            Call Ejecutar(sql)

            rs.Read()

            If rs(0) > 0 Then

                MsgBox("La madera ya existe")

                txtDescripcion.Text = ""

            Else

                If txtPrecioxCM2.Text = 0 Or txtPrecioxCM2.Text < 0 Then

                    MsgBox("El precio x cm2 no puede ser 0 o menor que 0")

                Else

                    If txtStock.Text < 0 Then

                        MsgBox("El stock no puede ser menor que 0")

                    Else

                        If txtPP.Text = 0 Or txtPP.Text < 0 Then

                            MsgBox("El punto de pedido no puede ser menor o igual a 0")

                        Else

                            If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                                txtDescripcion.Text = ""
                                txtStock.Text = ""
                                txtPrecioxCM2.Text = ""
                                txtPP.Text = ""

                            Else

                                sql = ("insert into producto values ('', '" & txtDescripcion.Text & "', '" & CInt(txtStock.Text) & "', '" & CInt(txtPP.Text) & "', 1)")

                                Call Ejecutar(sql)

                                Dim idprod As Integer

                                sql = ("select max(idproducto) from producto")

                                Call Ejecutar(sql)

                                rs.Read()

                                idprod = rs(0)

                                sql = ("insert into madera values ('', " & idprod & ", '" & txtDescripcion.Text & "', '" & txtPrecioxCM2.Text & "', 1)")

                                Call Ejecutar(sql)

                                MsgBox("Madera agregada con exito")

                                txtDescripcion.Text = ""
                                txtStock.Text = ""
                                txtPrecioxCM2.Text = ""
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

    Private Sub txtPrecioxCM2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioxCM2.KeyPress
        onlynum(e)
    End Sub


    Private Sub txtPP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStock.KeyPress
        onlynum(e)
    End Sub

    Private Sub txtStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStock.KeyPress

        onlynum(e)

    End Sub


    Private Sub txtPP_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPP.KeyPress
        onlynum(e)
    End Sub
End Class