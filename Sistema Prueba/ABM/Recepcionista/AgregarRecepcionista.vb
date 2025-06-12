Public Class frmAgregarRecepcionista

    Private Sub btnAgregarRecepcionista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRecepcionista.Click

        If txtID.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from persona where idpersona = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe ninguna persona asociada a este ID")

                txtID.Text = ""

            Else

                sql = ("select count(*) from recepcionista where idpersona = (select idpersona from persona where idpersona = '" & CInt(txtID.Text) & "')")

                Call ejecutar(sql)

                rs.Read()

                If rs(0) > 0 Then

                    MsgBox("La persona ya es un recepcionista")

                    txtID.Text = ""

                Else

                    sql = ("select estado from persona where idpersona = '" & CInt(txtID.Text) & "'")

                    Call ejecutar(sql)

                    rs.Read()

                    If rs(0) = 0 Then

                        MsgBox("La persona esta deshabilitada")

                    Else

                        sql = ("select idpersona, nombre, apellido from persona where idpersona = '" & CInt(txtID.Text) & "'")

                        Call ejecutar(sql)

                        rs.Read()

                        codpersona = rs(0)

                        If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                            txtID.Text = ""

                        Else

                            MsgBox("Recepcionista agregado con exito")

                            sql = ("insert into recepcionista values('', " & codpersona & ")")

                            Call ejecutar(sql)

                            txtID.Text = ""

                        End If

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
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from persona where estado = 1")

    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress
        onlynum(e)
    End Sub

End Class