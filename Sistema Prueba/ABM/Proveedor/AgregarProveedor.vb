Public Class frmAgregarProveedor

    Private Sub btnVolverMenuABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverMenuABM.Click

        Me.Close()
        frmABM.Show()

    End Sub

    Private Sub btnAgregarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProveedor.Click

        If txtContacto.Text = "" Or txtDireccion.Text = "" Or txtNombre.Text = "" Or cmbTipoP.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            sql = ("select count(*) from proveedor where nombre = '" & txtNombre.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) > 0 Then

                MsgBox("Ya existe un proveedor con el nombre ingresado")

                txtNombre.Text = ""

            Else

                If MsgBox("Se ingresara en proveedor '" + txtNombre.Text + "', desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                Else

                    sql = ("insert into proveedor values('', '" & txtNombre.Text & "', '" & txtDireccion.Text & "', '" & txtContacto.Text & "', '" & cmbTipoP.Text & "', 1)")

                    Call ejecutar(sql)

                    MsgBox("Proveedor ingresado con exito")

                    txtContacto.Text = ""
                    txtDireccion.Text = ""
                    txtNombre.Text = ""
                    cmbTipoP.Text = ""

                End If

            End If

        End If

    End Sub

    Private Sub frmAgregarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbTipoP.Items.Add("Madera")
        cmbTipoP.Items.Add("Extras")

    End Sub

End Class