Public Class frmPedidoCliente
    Dim var1 As String
    Dim var2 As String
    Dim var3 As String
    Dim var4 As String
    Dim varidpersona As Integer
    Public vardirec As String

    Public nom As String
    Public ape As String
    Public Direc As String
    Public Tel As String


    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click

        If txtNombre.Text = "" Then
            var1 = "Nombre"

        End If

        If txtApellido.Text = "" Then
            var2 = "Apellido"

        End If

        If txtTelefono.Text = "" Then
            var3 = "Telefono"

        End If

        If txtDomicilio.Text = "" Then
            var4 = "Domicilio del cliente"
        End If


        If txtApellido.Text = "" Or txtTelefono.Text = "" Or txtNombre.Text = "" Or txtDomicilio.Text = "" Then
            MsgBox("Complete los siguientes campos: " + var1 + " " + var2 + " " + var3 + " " + var4 + " ", MsgBoxStyle.Critical, "Error")

        Else
            nom = txtNombre.Text
            ape = txtApellido.Text
            Direc = txtDomicilio.Text
            Tel = txtTelefono.Text


            '    sql = "insert into Persona values('','" & txtNombre.Text & "', '" & txtApellido.Text & "', '" & frmDNICliente.DNI & "', '" & txtTelefono.Text & "', '" & txtDomicilio.Text & "');"
            '    Call Ejecutar(sql)
            '
            '    sql = "select idpersona from persona where DNI=" & frmDNICliente.DNI & ";"
            '    Call Ejecutar(sql)
            '    rs.Read()
            '
            '    varidpersona = rs(0)
            '
            '    sql = "insert into Cliente values('', " & varidpersona & ");"
            '    Call Ejecutar(sql)
            '    MsgBox("¡Cliente ingresado!", MsgBoxStyle.Information, "Cliente")
            '
            '
            '    sql = "select max(idcliente) from cliente"
            '    Call Ejecutar(sql)
            '    rs.Read()
            '
            '    frmPedidoMueble.insertidcliente = rs(0)

            Me.Hide()
            frmPedidoMueble.Show()

            txtNombre.Text = ""
            txtApellido.Text = ""
            txtDomicilio.Text = ""
            txtTelefono.Text = ""

        End If
        var1 = ""
        var2 = ""
        var3 = ""
        var4 = ""

    End Sub

    Private Sub frmPedidoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click

        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDomicilio.Text = ""
        txtTelefono.Text = ""

        Me.Hide()
        frmDNICliente.Show()
    End Sub

    Private Sub txtTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.KeyPress
        Onlynum(e)
    End Sub


End Class