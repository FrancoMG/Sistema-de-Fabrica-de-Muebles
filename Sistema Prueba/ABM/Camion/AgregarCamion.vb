Public Class frmAgregarCamion

    Private Sub btnAgregarCamion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCamion.Click

        If txtMarca.Text = "" Or txtModelo.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            If MsgBox("Se ingresara '" + txtMarca.Text + "''" + txtModelo.Text + "' como un nuevo camion, desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then



            Else

                sql = ("insert into camion values ('', '" & txtMarca.Text & "', '" & txtModelo.Text & "', 1)")

                Call ejecutar(sql)

                MsgBox("Camion ingresado con exito")

                txtMarca.Text = ""
                txtModelo.Text = ""

            End If

        End If

    End Sub

    Private Sub btnVolverMenuABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMenuABM.Click

        Me.Close()
        frmABM.Show()

    End Sub

End Class