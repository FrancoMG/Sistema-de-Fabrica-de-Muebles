Public Class frmBorrarCamion

    Private Sub btnBorrarCamion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCamion.Click

        If txtCamion.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from camion where idcamion = " & CInt(txtCamion.Text) & "")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("El camion ingresado no existe")

                txtCamion.Text = ""

            Else

                sql = ("select disponible from camion where idcamion = " & CInt(txtCamion.Text) & "")

                Call ejecutar(sql)

                rs.Read()

                If rs(0) = 0 Then

                    MsgBox("El camion ingresado ya esta deshabilitado")

                    txtCamion.Text = ""

                Else



                    If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                    Else

                        sql = ("update camion set disponible = 0 where idcamion = " & CInt(txtCamion.Text) & "")

                        Call Ejecutar(sql)

                        sql = ("select marca, modelo from camion where idcamion = " & CInt(txtCamion.Text) & "")

                        Call Ejecutar(sql)

                        rs.Read()

                        MsgBox("Camion '" & rs(0) & "' '" & rs(1) & "' deshabilitado con exito")

                        frmLista.DataGridView1.DataSource = llenarGrilla("select * from camion where disponible = 1")

                        txtCamion.Text = ""

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from camion where disponible = 1")

    End Sub


    Private Sub btnVolverMenuABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMenuABM.Click

        Me.Close()
        frmLista.Close()
        frmABM.Show()

    End Sub

    Private Sub txtCamion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCamion.KeyPress
        onlynum(e)
    End Sub

End Class