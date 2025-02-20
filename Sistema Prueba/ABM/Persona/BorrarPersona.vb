Public Class frmBorrarPersona

    Private Sub btnBorrarPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarPersona.Click

        If txtID.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from persona where idpersona = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe ninguna persona asociada con este id")

            Else

                sql = ("select count(*) from tecnico where idpersona = " & txtID.Text & "")

                Call Ejecutar(sql)

                rs.Read()

                contTec = CInt(rs(0))

                sql = ("select count(*) from recepcionista where idpersona = " & txtID.Text & "")

                Call Ejecutar(sql)

                rs.Read()

                contRecep = CInt(rs(0))

                sql = ("select count(*) from cliente where idpersona = " & txtID.Text & "")

                Call Ejecutar(sql)

                rs.Read()

                contCliente = CInt(rs(0))

                sql = ("select count(*) from usuario where idpersona = " & txtID.Text & "")

                Call Ejecutar(sql)

                rs.Read()

                contUsuario = CInt(rs(0))

                If contTec > 0 Or contRecep > 0 Or contCliente > 0 Or contUsuario > 0 Then

                    MsgBox("No se puede borrar a la persona ya que está relacionada con otra tabla")

                Else

                    sql = ("select idpersona, nombre, apellido from persona where idpersona = '" & txtID.Text & "'")

                    Call Ejecutar(sql)

                    rs.Read()

                    codpersona = rs(0)

                    If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                        txtID.Text = ""

                    Else

                        MsgBox("Persona '" & rs(1) & " " & rs(2) & "'  borrada con exito")

                        sql = ("delete from persona where idpersona = " & codpersona & "")

                        Call Ejecutar(sql)

                        frmLista.DataGridView1.DataSource = llenarGrilla("select * from persona where idpersona not in(select idpersona from recepcionista) and idpersona not in(select idpersona from cliente) and idpersona not in(select idpersona from tecnico) and idpersona not in(select idpersona from usuario)")

                        txtID.Text = ""

                    End If

                End If

                End If

            End If

    End Sub

    Private Sub frmVolverMenuABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmVolverMenuABM.Click

        Me.Close()
        frmABM.Show()
        frmLista.Close()

    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from persona where idpersona not in(select idpersona from recepcionista) and idpersona not in(select idpersona from cliente) and idpersona not in(select idpersona from tecnico)")

    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress
        onlynum(e)
    End Sub
End Class