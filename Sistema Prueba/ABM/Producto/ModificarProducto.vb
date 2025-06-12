Public Class frmModificarProducto

    Dim idprod As Integer

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click

        frmLista.Show()
        frmLista.DataGridView1.DataSource = llenarGrilla("select * from producto")

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        frmLista.Close()
        frmABM.Show()

    End Sub

    Private Sub btnCargarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarDatos.Click

        If txtID.Text = "" Then

            MsgBox("Llene el campo 'ID'")

        Else

            sql = ("select count(*) from producto where idproducto = '" & txtID.Text & "'")

            Call ejecutar(sql)

            rs.Read()

            If rs(0) = 0 Then

                MsgBox("No existe ningun producto con el ID ingresado")

            Else

                sql = ("select * from producto where idproducto = '" & txtID.Text & "'")

                Call ejecutar(sql)

                rs.Read()

                txtNombre.Text = rs(1)
                txtStock.Text = rs(2)
                txtPP.Text = rs(3)

                gbxDatos.Enabled = True

                idprod = CInt(txtID.Text)

            End If

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If txtNombre.Text = "" Or cmbEstado.Text = "" Or txtPP.Text = "" Or txtStock.Text = "" Then

            MsgBox("Llene todos los campos")

        Else

            If txtPP.Text = 0 Or txtPP.Text < 0 Then

                MsgBox("El Punto de Pedido no puede ser 0 o menor a 0")

            Else

                If txtStock.Text < 0 Or txtStock.Text = 0 Then

                    MsgBox("El stock no pueder ser menor o igual a 0")

                Else

                    If MsgBox("Desea confirmar esta operacion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then

                    Else

                        sql = ("update producto set nombre_comercial = '" & txtNombre.Text & "', stock = '" & txtStock.Text & "', estado = '" & cmbEstado.Text & "', pp = '" & txtPP.Text & "' where idproducto = " & idprod & "")

                        Call Ejecutar(sql)

                        MsgBox("Datos modificados con exito")

                        frmLista.DataGridView1.DataSource = llenarGrilla("select * from producto")

                        txtNombre.Text = ""
                        txtID.Text = ""
                        txtStock.Text = ""

                        gbxDatos.Enabled = False

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub frmModificarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmbEstado.Items.Add("0")
        cmbEstado.Items.Add("1")

    End Sub

    Private Sub txtPP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPP.KeyPress

        onlynum(e)

    End Sub




    Private Sub txtStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStock.KeyPress
        onlynum(e)
    End Sub


    Private Sub txtID_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.KeyPress
        onlynum(e)
    End Sub
End Class