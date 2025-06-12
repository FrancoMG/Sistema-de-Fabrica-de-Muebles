Public Class frmGrilla
    Dim cantfilas As Integer
    Dim NProveedor As String
    Dim NProducto As String

    Private Sub frmGrilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "select idproveedor from listadeprecios group by idproveedor order by idproveedor"
        Call Ejecutar(sql)

        While rs.Read
            'MsgBox(rs(0))
            switch = 2

            sql = "select nombre from proveedor where idproveedor='" & rs(0) & "'"
            Call Ejecutar(sql)
            rs2.Read()

            NProveedor = rs2(0)

            sql = "select idproducto from listadeprecios where idproveedor='" & rs(0) & "'"
            Call Ejecutar(sql)

            While rs2.Read
                'MsgBox(rs2(0))
                switch = 3

                sql = "select Nombre_Comercial from producto where idproducto='" & rs2(0) & "'"
                Call Ejecutar(sql)
                rs3.Read()

                NProducto = rs3(0)

                sql = "select precio from listadeprecios where idproveedor='" & rs(0) & "' and idproducto='" & rs2(0) & "'"
                Call Ejecutar(sql)
                rs3.Read()
                'MsgBox(rs3(0))
                dgvListaPrecios.Rows.Add()
                cantfilas = dgvListaPrecios.Rows.Count - 1

                'MsgBox("INSERTO")

                dgvListaPrecios.Item(0, cantfilas).Value = rs(0)
                dgvListaPrecios.Item(1, cantfilas).Value = NProveedor
                dgvListaPrecios.Item(2, cantfilas).Value = rs2(0)
                dgvListaPrecios.Item(3, cantfilas).Value = NProducto
                dgvListaPrecios.Item(4, cantfilas).Value = rs3(0)


            End While
        End While

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

        Me.Hide()
        RelacionesExternas.Show()

    End Sub

    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()
        frmSectores.Show()

    End Sub

    Private Sub dgvListaPrecios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListaPrecios.CellContentClick

    End Sub
End Class