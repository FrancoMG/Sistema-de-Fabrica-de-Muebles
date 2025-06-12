Public Class frmExtraDireccionDistanciaKM
    Public variabledireccion As String
    Public variabledistanciaKM As Integer



    Private Sub ExtraDireccionDistanciaKM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmPedidoMueble.nuevomueble = 1 Then
            lblExplic.Visible = True

        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        txtDireccionEntrega.Text = ""
        txtDistanciaKM.Text = ""
        Me.Hide()
        frmPedidoMueble.Show()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If txtDireccionEntrega.Text = "" Or txtDistanciaKM.Text = "" Then
            MsgBox("Llene todos los campos", MsgBoxStyle.Critical, "Error")

        Else
            variabledireccion = txtDireccionEntrega.Text
            variabledistanciaKM = txtDistanciaKM.Text
            Me.Hide()
            frmPedidoMueble.btnAgregarPedido.Visible = True
            frmPedidoMueble.Show()
        End If

    End Sub

    Private Sub txtDistanciaKM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDistanciaKM.KeyPress

        Onlynum(e)

    End Sub

    Private Sub txtDistanciaKM_TextChanged_1(sender As Object, e As EventArgs) Handles txtDistanciaKM.TextChanged
        If txtDistanciaKM.Text = "0" Then

            txtDistanciaKM.Text = ""

        End If
    End Sub
End Class