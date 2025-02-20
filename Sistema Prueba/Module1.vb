Imports System.Data.Odbc

Module Module1

    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs, rs2, rs3, rs4 As OdbcDataReader
    Public boleano As Integer
    Public tipousuario As String
    Public sql As String
    Public usuario As String
    Public idtipousuario As Integer
    Public nombreUsuario As String
    Public permisos As String
    Public codpersona As Integer
    Public switch As Integer = 1
    Public DireccionEntrega As String
    Public contTec As Integer
    Public contRecep As Integer
    Public contCliente As Integer
    Public contUsuario As Integer
    Public bandera As Boolean = True


    Public Sub connection()

        Try

            cnn = New OdbcConnection("DSN=Le_Pine")

            cnn.Open()

        Catch ex As Exception

            MsgBox("No hay coneccion", MsgBoxStyle.Exclamation, "Error")

        End Try

    End Sub


    Public Function llenarGrilla(ByVal sql As String) As DataTable

        Dim ds As DataSet
        Dim adp As OdbcDataAdapter

        ds = New DataSet("Tabla")
        ds.Tables.Add("Tabla")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("Tabla"))

        Return ds.Tables("Tabla")

    End Function

    Public Sub onlynum(ByVal e)

        If Char.IsDigit(e.keychar) Then

            e.handled = False

        ElseIf Char.IsControl(e.keychar) Then

            e.handled = False

        Else

            e.handled = True

        End If

    End Sub

    Public Sub Ejecutar(ByVal consulta As String)

        cmd = New OdbcCommand(consulta, cnn)
        cmd.CommandType = CommandType.Text

        If switch = 1 Then

            rs = cmd.ExecuteReader


        ElseIf switch = 2 Then

            rs2 = cmd.ExecuteReader


        ElseIf switch = 3 Then

            rs3 = cmd.ExecuteReader


        ElseIf switch = 4 Then
            rs4 = cmd.ExecuteReader

        End If
        cmd.Dispose()

    End Sub

End Module
