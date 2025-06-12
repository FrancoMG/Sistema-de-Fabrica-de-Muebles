Imports System.Data.Odbc

Public Class frmSectores

    Private Sub frmSectores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If boleano = 1 Then

            btnABM.Enabled = False
            btnPedido.Enabled = False
            btnRE.Enabled = False

        ElseIf boleano = 3 Then

            btnABM.Enabled = False
            btnUsuario.Enabled = False
            btnRE.Enabled = False
            btnLaboresAdm.Enabled = False

        ElseIf boleano = 4 Then

            btnABM.Enabled = False
            btnUsuario.Enabled = False
            btnPedido.Enabled = False
            btnLaboresAdm.Enabled = False

        End If

        lblUsuario.Text = "Usuario: " + nombreUsuario
        lblDia.Text = Date.Today
    
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        frmInicio.Show()

    End Sub

    Private Sub btnUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuario.Click

        If boleano = 1 Or boleano = 2 Then

            Me.Close()
            frmUsuarios.Show()

        Else

            MsgBox("No tiene los permisos para acceder a esta sección")

        End If


    End Sub

    Private Sub btnABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnABM.Click

        Me.Close()
        frmABM.Show()

    End Sub

    Private Sub btnPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedido.Click
        Me.Close()
        frmDNICliente.Show()
    End Sub

    Private Sub btnLaboresAdm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaboresAdm.Click

        Me.Close()
        frmAdministracion.Show()

    End Sub

    Private Sub lblUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUsuario.Click

    End Sub

    Private Sub btnRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRE.Click

        Me.Close()
        RelacionesExternas.Show()

    End Sub
End Class