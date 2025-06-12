Public Class frmMaterialDeMontaje

    Public IdMuebleGlobal As Integer
    Public Hernan As Integer
    Public hernansino As Integer
    Public sqlmm As String
    Public sqlmm2 As String
    Public cantidadM As Integer
    Public cantidadM2 As Integer
    Public materialM As String
    Public materialM2 As String
    Public varidiva As Integer
    Public varcontador As Integer
    Public nomasmontaje As Integer
    Public conta As Integer



    Private Sub frmMaterialDeMontaje_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        btnAceptarM.Enabled = False


        sql = "select Nombre from materialdemontaje;"
        Call Ejecutar(sql)
        While rs.Read

            cmbMaterialM.Items.Add(rs(0))

        End While
    End Sub

    Private Sub btnAceptarM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptarM.Click





        sql = "select idmaterialM from materialdemontaje where nombre= '" & cmbMaterialM.Text & "';"
        Call Ejecutar(sql)
        rs.Read()

        IdMuebleGlobal = IdMuebleGlobal

        '----------------------update stock extra; en producto-----------------------------------

        If frmPedidoMueble.cmbExtra.Text <> "" And frmPedidoMueble.chkAgregarExtra.Checked = True Then





            sql = "select idproducto from producto where nombre_comercial='" & frmPedidoMueble.cmbExtra.Text & "';"
            Call Ejecutar(sql)
            rs.Read()



            sql = "update producto set stock=stock - " & frmPedidoMueble.txtCantidad2.Text & " where idproducto = " & rs(0) & ";"
            Call Ejecutar(sql)

        End If

        


        '-------------------------------------------------------------------------------------------



        '-----------------------update stock materialdemontaje; en "producto"-----------------------------------
        sql = "select idproducto from producto where nombre_comercial='" & cmbMaterialM.Text & "';"
        Call Ejecutar(sql)
        rs.Read()


        sql = "update producto set stock=stock - " & txtCantidadM.Text & " where idproducto = " & rs(0) & ";"
        Call Ejecutar(sql)

        '-------------------------------------------------------------------------------------------------------


        If Hernan < 3 Then



            If MsgBox("¿Debe ingresar otro material de montaje?", MsgBoxStyle.YesNo, "Material de montaje") = MsgBoxResult.Yes Then


                nomasmontaje = 1


                Hernan = Hernan + 1
                If Hernan = 1 Then
                    cantidadM = txtCantidadM.Text
                    materialM = cmbMaterialM.Text
                ElseIf Hernan = 2 Then
                    cantidadM2 = txtCantidadM.Text
                    materialM2 = cmbMaterialM.Text



                End If

                cmbMaterialM.Text = ""
                txtCantidadM.Text = ""
                cmbMaterialM.Items.Remove(cmbMaterialM.Text)
            Else



                Hernan = Hernan + 1
                If Hernan = 1 Then
                    cantidadM = txtCantidadM.Text
                    materialM = cmbMaterialM.Text
                ElseIf Hernan = 2 Then
                    cantidadM2 = txtCantidadM.Text
                    materialM2 = cmbMaterialM.Text
                End If

                cmbMaterialM.Text = ""
                txtCantidadM.Text = ""
                cmbMaterialM.Items.Remove(cmbMaterialM.Text)

                Me.Close()
                frmPedidoMueble.Show()

                hernansino = 1

            End If



        End If



        If Hernan = 3 Then

            MsgBox("Se alcanzó la cantidad máxima de Materiales de Montaje por mueble. No se ingresará el último material de montaje", MsgBoxStyle.Exclamation, "Error")
            hernansino = 1
        End If





        If hernansino = 1 Then



            If frmPedidoMueble.acum <= 5 Then


                If frmDocumento_Presupuesto_.lblconecepto1.Text = "" Then

                    frmDocumento_Presupuesto_.lblconecepto1.Text = frmPedidoMueble.cmbTipoMueble.Text

                    frmDocumento_Presupuesto_.lblCantidad1.Text = frmPedidoMueble.txtCantidad.Text

                    frmDocumento_Presupuesto_.lblprecio1.Text = "$" & CInt(frmPedidoMueble.montosemi) & ""

                    frmDocumento_Presupuesto_.lbltotal1.Text = "$" & CInt(frmPedidoMueble.montototal) & ""

                ElseIf frmDocumento_Presupuesto_.lblconecepto2.Text = "" Then

                    frmDocumento_Presupuesto_.lblconecepto2.Text = frmPedidoMueble.cmbTipoMueble.Text

                    frmDocumento_Presupuesto_.lblCantidad2.Text = frmPedidoMueble.txtCantidad.Text

                    frmDocumento_Presupuesto_.lblprecio2.Text = "$" & CInt(frmPedidoMueble.montosemi) & ""

                    frmDocumento_Presupuesto_.lbltotal2.Text = "$" & CInt(frmPedidoMueble.montototal) & ""

                ElseIf frmDocumento_Presupuesto_.lblconecepto3.Text = "" Then

                    frmDocumento_Presupuesto_.lblconecepto3.Text = frmPedidoMueble.cmbTipoMueble.Text

                    frmDocumento_Presupuesto_.lblCantidad3.Text = frmPedidoMueble.txtCantidad.Text

                    frmDocumento_Presupuesto_.lblprecio3.Text = "$" & CInt(frmPedidoMueble.montosemi) & ""

                    frmDocumento_Presupuesto_.lbltotal3.Text = "$" & CInt(frmPedidoMueble.montototal) & ""

                ElseIf frmDocumento_Presupuesto_.lblconecepto4.Text = "" Then

                    frmDocumento_Presupuesto_.lblconecepto4.Text = frmPedidoMueble.cmbTipoMueble.Text

                    frmDocumento_Presupuesto_.lblCantidad4.Text = frmPedidoMueble.txtCantidad.Text

                    frmDocumento_Presupuesto_.lblprecio4.Text = "$" & CInt(frmPedidoMueble.montosemi) & ""

                    frmDocumento_Presupuesto_.lbltotal4.Text = "$" & CInt(frmPedidoMueble.montototal) & ""

                ElseIf frmDocumento_Presupuesto_.lblconecepto5.Text = "" Then

                    frmDocumento_Presupuesto_.lblconecepto5.Text = frmPedidoMueble.cmbTipoMueble.Text

                    frmDocumento_Presupuesto_.lblCantidad5.Text = frmPedidoMueble.txtCantidad.Text

                    frmDocumento_Presupuesto_.lblprecio5.Text = "$" & CInt(frmPedidoMueble.montosemi) & ""

                    frmDocumento_Presupuesto_.lbltotal5.Text = "$" & CInt(frmPedidoMueble.montototal) & ""

                ElseIf frmDocumento_Presupuesto_.lblConcepto6.Text = "" Then

                    frmDocumento_Presupuesto_.lblConcepto6.Text = frmPedidoMueble.cmbTipoMueble.Text

                    frmDocumento_Presupuesto_.lblCantidad6.Text = frmPedidoMueble.txtCantidad.Text

                    frmDocumento_Presupuesto_.lblPrecio6.Text = "$" & CInt(frmPedidoMueble.montosemi) & ""

                    frmDocumento_Presupuesto_.lblTotal6.Text = "$" & CInt(frmPedidoMueble.montototal) & ""


                ElseIf frmDocumento_Presupuesto_.lblconcepto7.Text = "" Then

                    frmDocumento_Presupuesto_.lblconcepto7.Text = frmPedidoMueble.cmbTipoMueble.Text

                    frmDocumento_Presupuesto_.lblcantidad7.Text = frmPedidoMueble.txtCantidad.Text

                    frmDocumento_Presupuesto_.lblprecio7.Text = "$" & CInt(frmPedidoMueble.montosemi) & ""

                    frmDocumento_Presupuesto_.lbltotal7.Text = "$" & CInt(frmPedidoMueble.montototal) & ""

                ElseIf frmDocumento_Presupuesto_.lblconcepto8.Text = "" Then




                    frmDocumento_Presupuesto_.lblconcepto8.Text = frmPedidoMueble.cmbTipoMueble.Text

                    frmDocumento_Presupuesto_.lblcantidad8.Text = frmPedidoMueble.txtCantidad.Text

                    frmDocumento_Presupuesto_.lblprecio8.Text = "$" & CInt(frmPedidoMueble.montosemi) & ""

                    frmDocumento_Presupuesto_.lbltotal8.Text = "$" & CInt(frmPedidoMueble.montototal) & ""

                ElseIf frmDocumento_Presupuesto_.lblconcepto9.Text = "" Then

                    frmDocumento_Presupuesto_.lblconcepto9.Text = frmPedidoMueble.cmbTipoMueble.Text

                    frmDocumento_Presupuesto_.lblcantidad9.Text = frmPedidoMueble.txtCantidad.Text

                    frmDocumento_Presupuesto_.lblprecio9.Text = "$" & CInt(frmPedidoMueble.montosemi) & ""

                    frmDocumento_Presupuesto_.lbltotal9.Text = "$" & CInt(frmPedidoMueble.montototal) & ""

                End If


                If frmPedidoMueble.chkAgregarExtra.Checked = True Then
                    sql = "select preciounidad from extra where descripcion='" & frmPedidoMueble.cmbExtra.Text & "';"
                    Call Ejecutar(sql)
                    rs.Read()

                    frmPedidoMueble.extratotal = frmPedidoMueble.extratotal + (frmPedidoMueble.txtCantidad2.Text * rs(0))
                End If
                If frmPedidoMueble.chkAgregarExtra.Checked = True Then

                    sql = "select preciounidad from extra where descripcion='" & frmPedidoMueble.cmbExtra.Text & "';"
                    Call Ejecutar(sql)
                    rs.Read()

                    frmPedidoMueble.extra = rs(0) * frmPedidoMueble.txtCantidad2.Text

                    If frmDocumento_Presupuesto_.lblconecepto2.Text = "" Then

                        sql = "select preciounidad from extra where descripcion='" & frmPedidoMueble.cmbExtra.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()

                        frmDocumento_Presupuesto_.lblconecepto2.Text = frmPedidoMueble.cmbExtra.Text
                        frmDocumento_Presupuesto_.lblCantidad2.Text = frmPedidoMueble.txtCantidad2.Text
                        frmDocumento_Presupuesto_.lblprecio2.Text = rs(0)
                        frmDocumento_Presupuesto_.lbltotal2.Text = CInt(frmPedidoMueble.extra)

                        'frmPedidoMueble.valido = 1


                    ElseIf frmDocumento_Presupuesto_.lblconecepto3.Text = "" Then

                        sql = "select preciounidad from extra where descripcion='" & frmPedidoMueble.cmbExtra.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()

                        frmDocumento_Presupuesto_.lblconecepto3.Text = frmPedidoMueble.cmbExtra.Text
                        frmDocumento_Presupuesto_.lblCantidad3.Text = frmPedidoMueble.txtCantidad2.Text
                        frmDocumento_Presupuesto_.lblprecio3.Text = rs(0)
                        frmDocumento_Presupuesto_.lbltotal3.Text = "$" & CInt(frmPedidoMueble.extra) & ""
                        'frmPedidoMueble.valido = 1

                    ElseIf frmDocumento_Presupuesto_.lblconecepto4.Text = "" Then

                        sql = "select preciounidad from extra where descripcion='" & frmPedidoMueble.cmbExtra.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()

                        frmDocumento_Presupuesto_.lblconecepto4.Text = frmPedidoMueble.cmbExtra.Text
                        frmDocumento_Presupuesto_.lblCantidad4.Text = frmPedidoMueble.txtCantidad2.Text
                        frmDocumento_Presupuesto_.lblprecio4.Text = rs(0)
                        frmDocumento_Presupuesto_.lbltotal4.Text = "$" & CInt(frmPedidoMueble.extra) & ""
                        ' frmPedidoMueble.valido = 1

                    ElseIf frmDocumento_Presupuesto_.lblconecepto5.Text = "" Then

                        sql = "select preciounidad from extra where descripcion='" & frmPedidoMueble.cmbExtra.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()

                        frmDocumento_Presupuesto_.lblconecepto5.Text = frmPedidoMueble.cmbExtra.Text
                        frmDocumento_Presupuesto_.lblCantidad5.Text = frmPedidoMueble.txtCantidad2.Text
                        frmDocumento_Presupuesto_.lblprecio5.Text = rs(0)
                        frmDocumento_Presupuesto_.lbltotal5.Text = "$" & CInt(frmPedidoMueble.extra) & ""
                        'frmPedidoMueble.valido = 1

                    ElseIf frmDocumento_Presupuesto_.lblConcepto6.Text = "" Then

                        sql = "select preciounidad from extra where descripcion='" & frmPedidoMueble.cmbExtra.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()

                        frmDocumento_Presupuesto_.lblConcepto6.Text = frmPedidoMueble.cmbExtra.Text
                        frmDocumento_Presupuesto_.lblCantidad6.Text = frmPedidoMueble.txtCantidad2.Text
                        frmDocumento_Presupuesto_.lblPrecio6.Text = rs(0)
                        frmDocumento_Presupuesto_.lblTotal6.Text = "$" & CInt(frmPedidoMueble.extra) & ""
                        ' frmPedidoMueble.valido = 1

                        '-------------------A PARTIR DE ACA CAMBIAMOS ESTO (mal) -----------------

                    ElseIf frmDocumento_Presupuesto_.lblconcepto7.Text = "" Then

                        sql = "select preciounidad from extra where descripcion='" & frmPedidoMueble.cmbExtra.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()

                        frmDocumento_Presupuesto_.lblconcepto7.Text = frmPedidoMueble.cmbExtra.Text
                        frmDocumento_Presupuesto_.lblcantidad7.Text = frmPedidoMueble.txtCantidad2.Text
                        frmDocumento_Presupuesto_.lblprecio7.Text = rs(0)
                        frmDocumento_Presupuesto_.lbltotal7.Text = "$" & CInt(frmPedidoMueble.extra) & ""
                        '  frmPedidoMueble.valido = 1



                    ElseIf frmDocumento_Presupuesto_.lblconcepto8.Text = "" Then

                        sql = "select preciounidad from extra where descripcion='" & frmPedidoMueble.cmbExtra.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()

                        frmDocumento_Presupuesto_.lblconcepto8.Text = frmPedidoMueble.cmbExtra.Text
                        frmDocumento_Presupuesto_.lblcantidad8.Text = frmPedidoMueble.txtCantidad2.Text
                        frmDocumento_Presupuesto_.lblprecio8.Text = rs(0)
                        frmDocumento_Presupuesto_.lbltotal8.Text = "$" & CInt(frmPedidoMueble.extra) & ""
                        ' frmPedidoMueble.valido = 1




                    ElseIf frmDocumento_Presupuesto_.lblconcepto9.Text = "" Then

                        sql = "select preciounidad from extra where descripcion='" & frmPedidoMueble.cmbExtra.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()

                        frmDocumento_Presupuesto_.lblconcepto9.Text = frmPedidoMueble.cmbExtra.Text
                        frmDocumento_Presupuesto_.lblcantidad9.Text = frmPedidoMueble.txtCantidad2.Text
                        frmDocumento_Presupuesto_.lblprecio9.Text = rs(0)
                        frmDocumento_Presupuesto_.lbltotal9.Text = "$" & CInt(frmPedidoMueble.extra) & ""
                        'frmPedidoMueble.valido = 1



                    ElseIf frmDocumento_Presupuesto_.lblconcepto10.Text = "" Then

                        sql = "select preciounidad from extra where descripcion='" & frmPedidoMueble.cmbExtra.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()

                        frmDocumento_Presupuesto_.lblconcepto10.Text = frmPedidoMueble.cmbExtra.Text
                        frmDocumento_Presupuesto_.lblcantidad10.Text = frmPedidoMueble.txtCantidad2.Text
                        frmDocumento_Presupuesto_.lblprecio10.Text = rs(0)
                        frmDocumento_Presupuesto_.lbltotal10.Text = "$" & CInt(frmPedidoMueble.extra) & ""
                        'frmPedidoMueble.valido = 1



                    End If


                    '-------------------------------------------------------------------------------------------------


                    '----------------------------ACA SE ME APAGO(no importa, esta safe)--------------------------------
                    '----------------------IGUAL PARECE QUE LO GUARDÉ(si, COPIARLO)----------------------
                    'frmDocumento_Presupuesto_.lblconecepto1.Text = ""
                    'frmDocumento_Presupuesto_.lblconecepto2.Text = ""
                    'frmDocumento_Presupuesto_.lblconecepto3.Text = ""
                    'frmDocumento_Presupuesto_.lblconecepto4.Text = ""
                    'frmDocumento_Presupuesto_.lblconecepto5.Text = ""
                    'frmDocumento_Presupuesto_.lblConcepto6.Text = ""
                    'frmDocumento_Presupuesto_.lblconcepto7.Text = ""
                    'frmDocumento_Presupuesto_.lblconcepto8.Text = ""
                    'frmDocumento_Presupuesto_.lblconcepto9.Text = ""
                    'frmDocumento_Presupuesto_.lblconcepto10.Text = ""
                    '
                    '
                    'frmDocumento_Presupuesto_.lblCantidad1.Text = ""
                    'frmDocumento_Presupuesto_.lblCantidad2.Text = ""
                    'frmDocumento_Presupuesto_.lblCantidad3.Text = ""
                    'frmDocumento_Presupuesto_.lblCantidad4.Text = ""
                    'frmDocumento_Presupuesto_.lblCantidad5.Text = ""
                    'frmDocumento_Presupuesto_.lblCantidad6.Text = ""
                    'frmDocumento_Presupuesto_.lblcantidad7.Text = ""
                    'frmDocumento_Presupuesto_.lblcantidad8.Text = ""
                    'frmDocumento_Presupuesto_.lblcantidad9.Text = ""
                    'frmDocumento_Presupuesto_.lblcantidad10.Text = ""
                    '
                    '
                    'frmDocumento_Presupuesto_.lblprecio1.Text = ""
                    'frmDocumento_Presupuesto_.lblprecio2.Text = ""
                    'frmDocumento_Presupuesto_.lblprecio3.Text = ""
                    'frmDocumento_Presupuesto_.lblprecio4.Text = ""
                    'frmDocumento_Presupuesto_.lblprecio5.Text = ""
                    'frmDocumento_Presupuesto_.lblPrecio6.Text = ""
                    'frmDocumento_Presupuesto_.lblprecio7.Text = ""
                    'frmDocumento_Presupuesto_.lblprecio8.Text = ""
                    'frmDocumento_Presupuesto_.lblprecio9.Text = ""
                    'frmDocumento_Presupuesto_.lblprecio10.Text = ""
                    '
                    '
                    'frmDocumento_Presupuesto_.lbltotal1.Text = ""
                    'frmDocumento_Presupuesto_.lbltotal2.Text = ""
                    'frmDocumento_Presupuesto_.lbltotal3.Text = ""
                    'frmDocumento_Presupuesto_.lbltotal4.Text = ""
                    'frmDocumento_Presupuesto_.lbltotal5.Text = ""
                    'frmDocumento_Presupuesto_.lblTotal6.Text = ""
                    'frmDocumento_Presupuesto_.lbltotal7.Text = ""
                    'frmDocumento_Presupuesto_.lbltotal8.Text = ""
                    'frmDocumento_Presupuesto_.lbltotal9.Text = ""
                    'frmDocumento_Presupuesto_.lbltotal10.Text = ""
                    '---------------------------------------------------------------------------
                    '--------------------------------------------------------------------------------

                End If
                frmPedidoMueble.valido = 0




                sql = "select max(idmueble)+1 from mueble;"
                Call Ejecutar(sql)
                rs.Read()
                frmPedidoMueble.varidmueble = rs(0)

                IdMuebleGlobal = frmPedidoMueble.varidmueble + 1

                sql = "select idcliente from cliente c, persona p where c.idpersona = p.idpersona and DNI = " & frmDNICliente.DNI & ";"
                Call Ejecutar(sql)
                rs.Read()
                frmPedidoMueble.varidcliente = rs(0)


                sql = "select Direccion from persona p, cliente c where p.DNI =" & frmDNICliente.DNI & ";"
                Call Ejecutar(sql)
                rs.Read()
                frmPedidoMueble.vardomcliente = rs(0)



                If frmPedidoMueble.nuevomueble = 0 Then



                    sql = "Insert into pedido values('', " & frmPedidoMueble.varidcliente & ", '" & frmExtraDireccionDistanciaKM.variabledireccion & "' ," & frmExtraDireccionDistanciaKM.variabledistanciaKM & ", 1, curdate());"
                    Call Ejecutar(sql)

                    sql = "select max(idpedido) from pedido"
                    Call Ejecutar(sql)
                    rs.Read()

                    'MsgBox("hola ahora te muestro el pedido maximo")
                    'MsgBox(rs(0))
                End If


                If MsgBox("¿Desea ingresar otro mueble?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    '  MsgBox("POR FAVOR FUNCIONA")
                    ' MsgBox(frmPedidoMueble.txtCantidad.Text)

                    frmPedidoMueble.entro = 1

                    sql = "insert into mueble values('', " & frmPedidoMueble.varidtipomueble & ", 'PARA PRESUPUESTAR', 0, 0)"
                    Call Ejecutar(sql)

                    sql = "select max(idmueble) from mueble"
                    Call Ejecutar(sql)
                    rs.Read()

                    frmPedidoMueble.varidmueble = rs(0)

                    sql = "select max(idPedido) from pedido"
                    Call Ejecutar(sql)
                    rs.Read()
                    frmPedidoMueble.varidpedido = rs(0)


                    sql = "insert into pedidomueble values(" & frmPedidoMueble.varidpedido & ", " & frmPedidoMueble.varidmueble & ", " & frmPedidoMueble.txtCantidad.Text & ");"
                    Call Ejecutar(sql)



                    sql = "select max(idmueble) from mueble"
                    Call Ejecutar(sql)
                    rs.Read()

                    frmPedidoMueble.varpmueble = rs(0)
                    IdMuebleGlobal = rs(0)

                    If Hernan = 1 Then
                        ' MsgBox("Hola")
                        'MsgBox(cantidadM)
                        'MsgBox(cantidadM2)

                        sql = "select idmaterialM from materialdemontaje where nombre='" & materialM & "'"
                        Call Ejecutar(sql)
                        rs.Read()

                        sqlmm = "insert into mueblemontaje values(" & rs(0) & ", " & IdMuebleGlobal & ", " & cantidadM & ");"
                        Call Ejecutar(sqlmm)
                    ElseIf Hernan = 2 Then
                        '  MsgBox("Hola soy mas de 1 xd")
                        '  MsgBox(cantidadM)
                        '   MsgBox(cantidadM2)


                        If cantidadM <> "" Or cantidadM2 <> "" Then
                            sql = "select idmaterialM from materialdemontaje where nombre='" & materialM & "'"
                            Call Ejecutar(sql)
                            rs.Read()

                            sqlmm = "insert into mueblemontaje values(" & rs(0) & ", " & IdMuebleGlobal & ", " & cantidadM & ");"
                            Call Ejecutar(sqlmm)

                            sql = "select idmaterialM from materialdemontaje where nombre='" & materialM2 & "'"
                            Call Ejecutar(sql)
                            rs.Read()

                            sqlmm2 = "insert into mueblemontaje values(" & rs(0) & ", " & IdMuebleGlobal & ", " & cantidadM2 & ");"
                            Call Ejecutar(sqlmm2)
                        End If

                    End If

                    '-------------------MATERIALDEMONTAJE:CONDICION=OTROMUEBLEMAS-----------------------









                    '-----------------------------------------------------------------------------------

                    '  sql = "insert into mueblemontaje values(" & varidtipomueble & ", 1, 10)"
                    '  Call Ejecutar(sql)
                    '
                    '  sql = "insert into mueblemontaje values (" & varidtipomueble & ", 2, 4)"
                    '  Call Ejecutar(sql)
                    If frmPedidoMueble.chkAgregarExtra.Checked = True Then


                        sql = "select idextra from extra where descripcion = '" & frmPedidoMueble.cmbExtra.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()

                        frmPedidoMueble.varidextra = rs(0)
                    End If
                    sql = "select max(idmueble) from mueble"
                    Call Ejecutar(sql)
                    rs.Read()
                    If frmPedidoMueble.chkAgregarExtra.Checked = True Then


                        sql = "insert into MuebleExtra values(" & rs(0) & " , " & frmPedidoMueble.varidextra & "," & frmPedidoMueble.vartxtcantidad2 & ");"
                        Call Ejecutar(sql)

                    End If


                    '- acaxd




                    '---------------------------------------------------ACA---------------------------------------------------------





                    sql = "Select count(idremanente) from remanente where idmadera=" & frmPedidoMueble.varidmadera & ";"
                    Call Ejecutar(sql)
                    rs.Read()

                    If rs(0) > 0 Then



                        sql = "Select idmadera from madera where nombre = '" & frmPedidoMueble.cmbMaderaMueble.Text & "' ;"
                        Call Ejecutar(sql)
                        rs.Read()
                        frmPedidoMueble.varidmadera = rs(0)

                        sql = "select max(cm2) from remanente where idmadera = " & frmPedidoMueble.varidmadera & " limit 1;"
                        Call Ejecutar(sql)
                        rs.Read()
                        frmPedidoMueble.maxremanente = rs(0)







                        If frmPedidoMueble.maxremanente >= frmPedidoMueble.txtCM2.Text Then



                            sql = "select idremanente from remanente where cm2=(select max(cm2) from remanente where idmadera = '" & frmPedidoMueble.varidmadera & "' limit 1);"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.varidplancha = rs(0)


                            sql = "update remanente set cm2= " & frmPedidoMueble.maxremanente & "-" & frmPedidoMueble.txtCM2.Text & " where idremanente = " & frmPedidoMueble.varidplancha & ";"
                            Call Ejecutar(sql)

                            sql = "Select precioventaporCM2 from madera where idmadera = " & frmPedidoMueble.varidmadera & ";"
                            Call Ejecutar(sql)
                            rs.Read()



                            'si se usa mas de 1 madera


                        Else
                            'se verifica si hay planchas nuevas

                            'SI NO QUEDAN REMANENTES QUE CUMPLAN LA CONDICION...

                            'al insertar un nuevo remanente se le resta al numero por defecto los centímetros necesarios
                            'las planchas nuevas tienen 3k cm2 siempre


                            sql = "Select precioventaporCM2 from madera where idmadera = " & frmPedidoMueble.varidmadera & ";"
                            Call Ejecutar(sql)
                            rs.Read()



                            sql = "select idmadera from madera where nombre= '" & frmPedidoMueble.cmbMaderaMueble.Text & "';"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.varidmadera = rs(0)

                            sql = "select " & CInt(frmPedidoMueble.txtCM2.Text) & "/ 3000;"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.cantplanchas = rs(0)

                            If CInt(frmPedidoMueble.cantplanchas) <> frmPedidoMueble.cantplanchas Then

                                frmPedidoMueble.cantplanchas = CInt(frmPedidoMueble.cantplanchas) + 1

                                sql = "select p.idproducto from producto p, madera m where p.idproducto=m.idproducto and idmadera =" & frmPedidoMueble.varidmadera & ";"
                                Call Ejecutar(sql)
                                rs.Read()

                                sql = "update producto set stock = stock-" & frmPedidoMueble.cantplanchas & " where idproducto = " & rs(0) & ";"
                                Call Ejecutar(sql)


                                sql = "select 3000-(" & frmPedidoMueble.txtCM2.Text & " * " & frmPedidoMueble.txtCantidad.Text & ";"
                                Call Ejecutar(sql)
                                rs.Read()

                                While frmPedidoMueble.contador <> frmPedidoMueble.cantplanchas


                                    If rs(0) < 0 Then

                                        frmPedidoMueble.negativo = rs(0)


                                        sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera & ", 0)"
                                        Call Ejecutar(sql)

                                        sql = "select 3000 +" & frmPedidoMueble.negativo & ";"
                                        Call Ejecutar(sql)
                                        rs.Read()


                                    ElseIf rs(0) >= 0 Then


                                        frmPedidoMueble.contador = frmPedidoMueble.cantplanchas

                                        sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera & ", " & rs(0) & ");"
                                        Call Ejecutar(sql)

                                    End If



                                End While

                            End If





                            '---------------------------------------------------------------------------------------------------------------


                            '------------------------------------------------------------------------------------------------------------




                        End If

                        '.........
                    Else



                        sql = "Select precioventaporCM2 from madera where idmadera = " & frmPedidoMueble.varidmadera & ";"
                        Call Ejecutar(sql)
                        rs.Read()



                        sql = "select idmadera from madera where nombre= '" & frmPedidoMueble.cmbMaderaMueble.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()
                        frmPedidoMueble.varidmadera = rs(0)

                        sql = "select " & CInt(frmPedidoMueble.txtCM2.Text) & "/ 3000;"
                        Call Ejecutar(sql)
                        rs.Read()
                        frmPedidoMueble.cantplanchas = rs(0)

                        If CInt(frmPedidoMueble.cantplanchas) <> frmPedidoMueble.cantplanchas Then

                            frmPedidoMueble.cantplanchas = CInt(frmPedidoMueble.cantplanchas) + 1

                            sql = "select p.idproducto from producto p, madera m where p.idproducto=m.idproducto and idmadera =" & frmPedidoMueble.varidmadera & ";"
                            Call Ejecutar(sql)
                            rs.Read()

                            sql = "update producto set stock = stock-" & frmPedidoMueble.cantplanchas & " where idproducto = " & rs(0) & ";"
                            Call Ejecutar(sql)


                            sql = "select 3000-(" & frmPedidoMueble.txtCM2.Text & " * " & frmPedidoMueble.txtCantidad.Text & ");"
                            Call Ejecutar(sql)
                            rs.Read()

                            While frmPedidoMueble.contador <> frmPedidoMueble.cantplanchas


                                If rs(0) < 0 Then

                                    frmPedidoMueble.negativo = rs(0)


                                    sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera & ", 0)"
                                    Call Ejecutar(sql)

                                    sql = "select 3000 +" & frmPedidoMueble.negativo & ";"
                                    Call Ejecutar(sql)
                                    rs.Read()


                                ElseIf rs(0) >= 0 Then


                                    frmPedidoMueble.contador = frmPedidoMueble.cantplanchas

                                    sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera & ", " & rs(0) & ");"
                                    Call Ejecutar(sql)

                                End If



                            End While

                        End If








                        '..........................
                        'COPIA de resto de stock 1

                    End If








                    If frmPedidoMueble.cont = 1 Then


                        sql = "select count(idremanente) from remanente where idmadera=" & frmPedidoMueble.varidmadera2 & ";"
                        Call Ejecutar(sql)
                        rs.Read()

                        If rs(0) > 0 Then



                            sql = "select idmadera from madera where nombre = '" & frmPedidoMueble.cmbMaderaMueble2.Text & "' ;"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.varidmadera2 = rs(0)

                            sql = "select max(cm2) from remanente where idmadera = " & frmPedidoMueble.varidmadera2 & " limit 1;"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.maxremanente2 = rs(0)




                            If frmPedidoMueble.maxremanente2 >= frmPedidoMueble.txtCM2_2.Text Then



                                sql = "select idremanente from remanente where idmadera=(select idmadera from madera where nombre= '" & frmPedidoMueble.cmbMaderaMueble2.Text & "');"
                                Call Ejecutar(sql)
                                rs.Read()
                                frmPedidoMueble.varidplancha2 = rs(0)


                                sql = "update remanente set cm2 =" & frmPedidoMueble.maxremanente2 & "-" & frmPedidoMueble.txtCM2_2.Text & " where idremanente =" & frmPedidoMueble.varidplancha2 & ";"
                                Call Ejecutar(sql)


                            Else
                                'SI NO QUEDAN REMANENTES QUE CUMPLAN LA CONDICION...

                                ' ACA VA LO MISMO QUE EN EL ELSE DE ABAJO, ES COPIAR Y PEGAR BASICAMENTE, PERO REVISA ANTES DE HACER ESO POR LAS DUDAS


                                sql = "select idmadera from madera where nombre= '" & frmPedidoMueble.cmbMaderaMueble2.Text & "';"
                                Call Ejecutar(sql)
                                rs.Read()
                                frmPedidoMueble.varidmadera2 = rs(0)



                                sql = "select " & CInt(frmPedidoMueble.txtCM2_2.Text) & "/ 3000;"
                                Call Ejecutar(sql)
                                rs.Read()
                                frmPedidoMueble.cantplanchas2 = rs(0)

                                If CInt(frmPedidoMueble.cantplanchas2) <> frmPedidoMueble.cantplanchas2 Then
                                    frmPedidoMueble.cantplanchas2 = CInt(frmPedidoMueble.cantplanchas2) + 1

                                    sql = "select p.idproducto from producto p, madera m where p.idproducto=m.idproducto and idmadera =" & frmPedidoMueble.varidmadera2 & ";"
                                    Call Ejecutar(sql)
                                    rs.Read()

                                    sql = "update producto set stock = stock-" & frmPedidoMueble.cantplanchas2 & " where idproducto = " & rs(0) & ";"
                                    Call Ejecutar(sql)


                                    sql = "select 3000-(" & frmPedidoMueble.txtCM2_2.Text & " * " & frmPedidoMueble.txtCantidad.Text & ");"
                                    Call Ejecutar(sql)
                                    rs.Read()

                                    While frmPedidoMueble.contador2 <> frmPedidoMueble.cantplanchas2

                                        If rs(0) < 0 Then

                                            frmPedidoMueble.negativo2 = rs(0)


                                            sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera2 & ", 0)"
                                            Call Ejecutar(sql)

                                            sql = "select 3000 +" & frmPedidoMueble.negativo2 & ";"
                                            Call Ejecutar(sql)
                                            rs.Read()



                                        ElseIf rs(0) >= 0 Then


                                            frmPedidoMueble.contador2 = frmPedidoMueble.cantplanchas2

                                            sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera2 & ", " & rs(0) & ");"
                                            Call Ejecutar(sql)

                                        End If



                                    End While
                                End If















                            End If

                            '................

                        Else


                            sql = "select idmadera from madera where nombre= '" & frmPedidoMueble.cmbMaderaMueble2.Text & "';"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.varidmadera2 = rs(0)
                            '--------------------------------TERMINAR ESTO (CREO QUE SE ARREGLO)----------------------




                            sql = "select " & CInt(frmPedidoMueble.txtCM2_2.Text) & "/ 3000;"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.cantplanchas2 = rs(0)



                            '------------------------------------------------------------------------------
                            If CInt(frmPedidoMueble.cantplanchas2) <> frmPedidoMueble.cantplanchas2 Then

                                '-----------------------------------------------------------------------NO LLEGUE
                                frmPedidoMueble.cantplanchas2 = CInt(frmPedidoMueble.cantplanchas2) + 1

                                sql = "select p.idproducto from producto p, madera m where p.idproducto=m.idproducto and idmadera =" & frmPedidoMueble.varidmadera2 & ";"
                                Call Ejecutar(sql)
                                rs.Read()

                                sql = "update producto set stock = stock-" & frmPedidoMueble.cantplanchas2 & " where idproducto = " & rs(0) & ";"
                                Call Ejecutar(sql)



                                sql = "select 3000-(" & frmPedidoMueble.txtCM2_2.Text & " * " & frmPedidoMueble.txtCantidad.Text & ");"
                                Call Ejecutar(sql)
                                rs.Read()



                                While frmPedidoMueble.contador2 <> frmPedidoMueble.cantplanchas2



                                    If rs(0) < 0 Then

                                        frmPedidoMueble.negativo2 = rs(0)


                                        sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera2 & ", 0)"
                                        Call Ejecutar(sql)

                                        sql = "select 3000 +" & frmPedidoMueble.negativo2 & ";"
                                        Call Ejecutar(sql)
                                        rs.Read()



                                    ElseIf rs(0) >= 0 Then


                                        frmPedidoMueble.contador2 = frmPedidoMueble.cantplanchas2

                                        sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera2 & ", " & rs(0) & ");"
                                        Call Ejecutar(sql)

                                    End If



                                End While
                            End If






                            '....................
                            'COPIA DE RESTO DE MADERA 2









                        End If




                    End If


                    '-PONERMONTO1
                    frmPedidoMueble.montototaltotal = frmPedidoMueble.montototaltotal + frmPedidoMueble.montototal




                    frmPedidoMueble.cmbTipoMueble.Text = ""
                    frmPedidoMueble.cmbMaderaMueble.Text = ""
                    frmPedidoMueble.cmbMaderaMueble2.Text = ""
                    frmPedidoMueble.txtCM2.Text = ""
                    frmPedidoMueble.txtCM2_2.Text = ""
                    frmPedidoMueble.txtCantidad.Text = ""

                    frmPedidoMueble.txtCantidad2.Text = ""




                    frmPedidoMueble.btnAgregarPedido.Enabled = True
                    frmPedidoMueble.btnAgregarPedido.Visible = False
                    frmPedidoMueble.btnIngresarMueble.Enabled = False

                    frmExtraDireccionDistanciaKM.txtDireccionEntrega.Enabled = False
                    frmExtraDireccionDistanciaKM.txtDistanciaKM.Enabled = False


                    frmPedidoMueble.nuevomueble = 1
                    frmExtraDireccionDistanciaKM.lblExplic.Visible = True






                    Me.Close()
                    frmPedidoMueble.Show()


                Else
                    '---------------------------------------------------ACA EXTRA---------------------------------------------------------


                    sql = "insert into mueble values('', " & frmPedidoMueble.varidtipomueble & ", 'PARA PRESUPUESTAR', 0, 0)"
                    Call Ejecutar(sql)

                    sql = "select max(idmueble) from mueble"
                    Call Ejecutar(sql)
                    rs.Read()

                    frmPedidoMueble.varpmueble = rs(0)
                    IdMuebleGlobal = rs(0)
                    ' MsgBox(Hernan)
                    If Hernan = 1 Then
                        '  MsgBox("Hola")
                        '  MsgBox(cantidadM)
                        '   MsgBox(cantidadM2)

                        ' MsgBox("Ahora todas las variables en orden: ")
                        sql = "select idmaterialM from materialdemontaje where nombre='" & materialM & "'"
                        Call Ejecutar(sql)
                        rs.Read()

                        sqlmm = "insert into mueblemontaje values(" & rs(0) & ", " & IdMuebleGlobal & ", " & cantidadM & ");"
                        Call Ejecutar(sqlmm)
                    Else
                        ' MsgBox("Hola soy mas de 1 xd")
                        'MsgBox(cantidadM)
                        'MsgBox(cantidadM2)

                        'MsgBox(IdMuebleGlobal)


                        sql = "select idmaterialM from materialdemontaje where nombre='" & materialM & "'"
                        Call Ejecutar(sql)
                        rs.Read()

                        sqlmm = "insert into mueblemontaje values(" & rs(0) & ", " & IdMuebleGlobal & ", " & cantidadM & ");"
                        Call Ejecutar(sqlmm)

                        sql = "select idmaterialM from materialdemontaje where nombre='" & materialM2 & "'"
                        Call Ejecutar(sql)
                        rs.Read()

                        ' MsgBox(rs(0))

                        sqlmm2 = "insert into mueblemontaje values(" & rs(0) & ", " & IdMuebleGlobal & ", " & cantidadM2 & ");"
                        Call Ejecutar(sqlmm2)
                    End If
                    'MsgBox(varpmueble)
                    '------------------MATERIALDEMONTAJE:CONDICION=1SOLOMUEBLE--------------
                    ' If frmPedidoMueble.entro = 0 Then
                    '
                    '
                    '
                    '     frmPedidoMueble.Hide()
                    '     Me.Show()
                    ' End If





                    '------------------------------------------------------------------------



                    ' sql = "insert into mueblemontaje values(" & varidtipomueble & ", 1, 10)"
                    ' Call Ejecutar(sql)
                    '
                    ' sql = "insert into mueblemontaje values(" & varidtipomueble & ", 2, 4)"
                    ' Call Ejecutar(sql)

                    If frmPedidoMueble.chkAgregarExtra.Checked = True Then


                        sql = "select idextra from extra where descripcion = '" & frmPedidoMueble.cmbExtra.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()

                        frmPedidoMueble.varidextra = rs(0)
                    End If
                    sql = "select max(idmueble) from mueble"
                    Call Ejecutar(sql)
                    rs.Read()

                    If frmPedidoMueble.chkAgregarExtra.Checked = True Then


                        sql = "insert into MuebleExtra values(" & rs(0) & " , " & frmPedidoMueble.varidextra & "," & frmPedidoMueble.vartxtcantidad2 & ");"
                        Call Ejecutar(sql)
                    End If




                    ' While 

                    ' End While

                    '-----------------------------------------------------------------------------------------------------------------------


                    frmPedidoMueble.montototaltotal = frmPedidoMueble.montototaltotal + frmPedidoMueble.montototal

                    sql = "select count(idremanente) from remanente where idmadera=" & frmPedidoMueble.varidmadera & ";"
                    Call Ejecutar(sql)
                    rs.Read()

                    If rs(0) > 0 Then



                        sql = "select idmadera from madera where nombre = '" & frmPedidoMueble.cmbMaderaMueble.Text & "' ;"
                        Call Ejecutar(sql)
                        rs.Read()
                        frmPedidoMueble.varidmadera = rs(0)

                        sql = "select max(cm2) from remanente where idmadera = " & frmPedidoMueble.varidmadera & " limit 1;"
                        Call Ejecutar(sql)
                        rs.Read()
                        frmPedidoMueble.maxremanente = rs(0)







                        If frmPedidoMueble.maxremanente >= frmPedidoMueble.txtCM2.Text Then



                            sql = "select idremanente from remanente where cm2=(select max(cm2) from remanente where idmadera = '" & frmPedidoMueble.varidmadera & "' limit 1);"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.varidplancha = rs(0)


                            sql = "update remanente set cm2= " & frmPedidoMueble.maxremanente & "-(" & frmPedidoMueble.txtCM2.Text & " * " & frmPedidoMueble.txtCantidad.Text & ") where idremanente = " & frmPedidoMueble.varidplancha & ";"
                            Call Ejecutar(sql)

                            sql = "Select precioventaporCM2 from madera where idmadera = " & frmPedidoMueble.varidmadera & ";"
                            Call Ejecutar(sql)
                            rs.Read()



                            'si se usa mas de 1 madera


                        Else
                            'se verifica si hay planchas nuevas

                            'SI NO QUEDAN REMANENTES QUE CUMPLAN LA CONDICION...

                            'al insertar un nuevo remanente se le resta al numero por defecto los centímetros necesarios
                            'las planchas nuevas tienen 3k cm2 siempre


                            sql = "Select precioventaporCM2 from madera where idmadera = " & frmPedidoMueble.varidmadera & ";"
                            Call Ejecutar(sql)
                            rs.Read()



                            sql = "select idmadera from madera where nombre= '" & frmPedidoMueble.cmbMaderaMueble.Text & "';"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.varidmadera = rs(0)

                            sql = "select " & CInt(frmPedidoMueble.txtCM2.Text) & "/ 3000;"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.cantplanchas = rs(0)

                            If CInt(frmPedidoMueble.cantplanchas) <> frmPedidoMueble.cantplanchas Then

                                frmPedidoMueble.cantplanchas = CInt(frmPedidoMueble.cantplanchas) + 1

                                sql = "select p.idproducto from producto p, madera m where p.idproducto=m.idproducto and idmadera =" & frmPedidoMueble.varidmadera & ";"
                                Call Ejecutar(sql)
                                rs.Read()

                                sql = "update producto set stock = stock-" & frmPedidoMueble.cantplanchas & " where idproducto = " & rs(0) & ";"
                                Call Ejecutar(sql)


                                sql = "select 3000-(" & frmPedidoMueble.txtCM2.Text & " * " & frmPedidoMueble.txtCantidad.Text & ");"
                                Call Ejecutar(sql)
                                rs.Read()

                                While frmPedidoMueble.contador <> frmPedidoMueble.cantplanchas


                                    If rs(0) < 0 Then

                                        frmPedidoMueble.negativo = rs(0)


                                        sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera & ", 0)"
                                        Call Ejecutar(sql)

                                        sql = "select 3000 +" & frmPedidoMueble.negativo & ";"
                                        Call Ejecutar(sql)
                                        rs.Read()


                                    ElseIf rs(0) >= 0 Then


                                        frmPedidoMueble.contador = frmPedidoMueble.cantplanchas

                                        sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera & ", " & rs(0) & ");"
                                        Call Ejecutar(sql)

                                    End If



                                End While

                            End If





                            '---------------------------------------------------------------------------------------------------------------


                            '------------------------------------------------------------------------------------------------------------




                        End If

                        '.........
                    Else



                        sql = "Select precioventaporCM2 from madera where idmadera = " & frmPedidoMueble.varidmadera & ";"
                        Call Ejecutar(sql)
                        rs.Read()



                        sql = "select idmadera from madera where nombre= '" & frmPedidoMueble.cmbMaderaMueble.Text & "';"
                        Call Ejecutar(sql)
                        rs.Read()
                        frmPedidoMueble.varidmadera = rs(0)

                        sql = "select " & CInt(frmPedidoMueble.txtCM2.Text) & "/ 3000;"
                        Call Ejecutar(sql)
                        rs.Read()
                        frmPedidoMueble.cantplanchas = rs(0)
                        '--------------------------------HERNAN-----------------------
                        If CInt(frmPedidoMueble.cantplanchas) <> frmPedidoMueble.cantplanchas Then

                            frmPedidoMueble.cantplanchas = CInt(frmPedidoMueble.cantplanchas) + 1

                            sql = "select p.idproducto from producto p, madera m where p.idproducto=m.idproducto and idmadera =" & frmPedidoMueble.varidmadera & ";"
                            Call Ejecutar(sql)
                            rs.Read()

                            sql = "update producto set stock = stock-" & frmPedidoMueble.cantplanchas & " where idproducto = " & rs(0) & ";"
                            Call Ejecutar(sql)


                            sql = "select 3000-(" & frmPedidoMueble.txtCM2.Text & " * " & frmPedidoMueble.txtCantidad.Text & ");"
                            Call Ejecutar(sql)
                            rs.Read()

                            While frmPedidoMueble.contador <> frmPedidoMueble.cantplanchas


                                If rs(0) < 0 Then

                                    frmPedidoMueble.negativo = rs(0)


                                    sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera & ", 0)"
                                    Call Ejecutar(sql)

                                    sql = "select 3000 +" & frmPedidoMueble.negativo & ";"
                                    Call Ejecutar(sql)
                                    rs.Read()


                                ElseIf rs(0) >= 0 Then


                                    frmPedidoMueble.contador = frmPedidoMueble.cantplanchas

                                    sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera & ", " & rs(0) & ");"
                                    Call Ejecutar(sql)

                                End If



                            End While

                        End If
                        '-----------------------------------------------------------------------------------------------







                        '..........................
                        'COPIA de resto de stock 1

                    End If








                    If frmPedidoMueble.cont = 1 Then


                        sql = "select count(idremanente) from remanente where idmadera=" & frmPedidoMueble.varidmadera2 & ";"
                        Call Ejecutar(sql)
                        rs.Read()

                        If rs(0) > 0 Then



                            sql = "select idmadera from madera where nombre = '" & frmPedidoMueble.cmbMaderaMueble2.Text & "' ;"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.varidmadera2 = rs(0)

                            sql = "select max(cm2) from remanente where idmadera = " & frmPedidoMueble.varidmadera2 & " limit 1;"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.maxremanente2 = rs(0)




                            If frmPedidoMueble.maxremanente2 >= frmPedidoMueble.txtCM2_2.Text Then



                                sql = "select idremanente from remanente where idmadera=(select idmadera from madera where nombre= '" & frmPedidoMueble.cmbMaderaMueble2.Text & "');"
                                Call Ejecutar(sql)
                                rs.Read()
                                frmPedidoMueble.varidplancha2 = rs(0)


                                sql = "update remanente set cm2 =" & frmPedidoMueble.maxremanente2 & "-(" & frmPedidoMueble.txtCM2_2.Text & " * " & frmPedidoMueble.txtCantidad.Text & ") where idremanente =" & frmPedidoMueble.varidplancha2 & ";"
                                Call Ejecutar(sql)


                            Else
                                'SI NO QUEDAN REMANENTES QUE CUMPLAN LA CONDICION...

                                ' ACA VA LO MISMO QUE EN EL ELSE DE ABAJO, ES COPIAR Y PEGAR BASICAMENTE, PERO REVISA ANTES DE HACER ESO POR LAS DUDAS


                                sql = "select idmadera from madera where nombre= '" & frmPedidoMueble.cmbMaderaMueble2.Text & "';"
                                Call Ejecutar(sql)
                                rs.Read()
                                frmPedidoMueble.varidmadera2 = rs(0)



                                sql = "select " & CInt(frmPedidoMueble.txtCM2_2.Text) & "/ 3000;"
                                Call Ejecutar(sql)
                                rs.Read()
                                frmPedidoMueble.cantplanchas2 = rs(0)

                                If CInt(frmPedidoMueble.cantplanchas2) <> frmPedidoMueble.cantplanchas2 Then
                                    frmPedidoMueble.cantplanchas2 = CInt(frmPedidoMueble.cantplanchas2) + 1

                                    sql = "select p.idproducto from producto p, madera m where p.idproducto=m.idproducto and idmadera =" & frmPedidoMueble.varidmadera2 & ";"
                                    Call Ejecutar(sql)
                                    rs.Read()

                                    sql = "update producto set stock = stock-" & frmPedidoMueble.cantplanchas2 & " where idproducto = " & rs(0) & ";"
                                    Call Ejecutar(sql)

                                    sql = "select 3000-(" & frmPedidoMueble.txtCM2_2.Text & " * " & frmPedidoMueble.txtCantidad.Text & ";"
                                    Call Ejecutar(sql)
                                    rs.Read()

                                    While frmPedidoMueble.contador2 <> frmPedidoMueble.cantplanchas2

                                        If rs(0) < 0 Then

                                            frmPedidoMueble.negativo2 = rs(0)


                                            sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera2 & ", 0)"
                                            Call Ejecutar(sql)

                                            sql = "select 3000 +" & frmPedidoMueble.negativo2 & ";"
                                            Call Ejecutar(sql)
                                            rs.Read()



                                        ElseIf rs(0) >= 0 Then


                                            frmPedidoMueble.contador2 = frmPedidoMueble.cantplanchas2

                                            sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera2 & ", " & rs(0) & ");"
                                            Call Ejecutar(sql)

                                        End If



                                    End While
                                End If















                            End If

                            '................

                        Else


                            sql = "select idmadera from madera where nombre= '" & frmPedidoMueble.cmbMaderaMueble2.Text & "';"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.varidmadera2 = rs(0)
                            '--------------------------------TERMINAR ESTO (ESTA MAL)----------------------




                            sql = "select " & frmPedidoMueble.txtCM2_2.Text & "/ 3000;"
                            Call Ejecutar(sql)
                            rs.Read()
                            frmPedidoMueble.cantplanchas2 = rs(0)


                            '------------------------------------------------------------------------------
                            If CInt(frmPedidoMueble.cantplanchas2) <> frmPedidoMueble.cantplanchas2 Then



                                frmPedidoMueble.cantplanchas2 = CInt(frmPedidoMueble.cantplanchas2) + 1

                                sql = "select p.idproducto from producto p, madera m where p.idproducto=m.idproducto and idmadera =" & frmPedidoMueble.varidmadera2 & ";"
                                Call Ejecutar(sql)
                                rs.Read()

                                sql = "update producto set stock = stock-" & frmPedidoMueble.cantplanchas2 & " where idproducto = " & rs(0) & ";"
                                Call Ejecutar(sql)


                                sql = "select 3000-(" & frmPedidoMueble.txtCM2_2.Text & " * " & frmPedidoMueble.txtCantidad.Text & ");"
                                Call Ejecutar(sql)
                                rs.Read()



                                While frmPedidoMueble.contador2 <> frmPedidoMueble.cantplanchas2



                                    If rs(0) < 0 Then

                                        frmPedidoMueble.negativo2 = rs(0)


                                        sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera2 & ", 0)"
                                        Call Ejecutar(sql)

                                        sql = "select 3000 +" & frmPedidoMueble.negativo2 & ";"
                                        Call Ejecutar(sql)
                                        rs.Read()



                                    ElseIf rs(0) >= 0 Then


                                        frmPedidoMueble.contador2 = frmPedidoMueble.cantplanchas2

                                        sql = "insert into remanente values('', " & frmPedidoMueble.varidmadera2 & ", " & rs(0) & ");"
                                        Call Ejecutar(sql)

                                    End If



                                End While
                            End If






                            '....................
                            'COPIA DE RESTO DE MADERA 2









                        End If




                    End If





                    frmDocumento_Presupuesto_.lblTotalPresupuesto.Text = CInt(frmPedidoMueble.montototaltotal) + CInt(frmPedidoMueble.extratotal) & ""
                    frmDocumento_Presupuesto_.lblTotalPresupuesto.Text = frmDocumento_Presupuesto_.lblTotalPresupuesto.Text
                    ' frmDocumento_Presupuesto_.Show()
                    varidiva = frmDocumento_Presupuesto_.lblTotalPresupuesto.Text * 0.21
                    frmDocumento_Presupuesto_.lblTotalPresupuesto.Text = frmDocumento_Presupuesto_.lblTotalPresupuesto.Text + varidiva

                    'PEDIDO MUEBLE
                    sql = "select max(idPedido) from pedido"
                    Call Ejecutar(sql)
                    rs.Read()
                    frmPedidoMueble.varidpedido = rs(0)


                    sql = "insert into pedidomueble values(" & frmPedidoMueble.varidpedido & ", " & frmPedidoMueble.varidmueble & ", " & frmPedidoMueble.vartxtcantidad & ");"
                    Call Ejecutar(sql)
                    'MUEBLE MADEDA

                    frmPedidoMueble.montototaltotal = 0
                    frmPedidoMueble.extratotal = 0

                    Me.Close()
                    frmDocumento_Presupuesto_.Show()
                    frmPedidoMueble.Hide()

                    If MsgBox("¿El cliente acepta el presupuesto en el momento?", MsgBoxStyle.YesNo, "Presupuesto") = MsgBoxResult.Yes Then



                        sql = "select max(idpedido) from pedido"
                        Call Ejecutar(sql)
                        rs.Read()

                        sql = "insert into factura values('', " & rs(0) & ", 1, " & frmDocumento_Presupuesto_.lblTotalPresupuesto.Text & ");"
                        Call Ejecutar(sql)

                        sql = "select m.idmueble from pedidomueble pm, mueble m where pm.idmueble=m.idmueble and pm.idpedido =(select max(idpedido) from pedido)"
                        Call Ejecutar(sql)



                        While rs.Read

                            switch = 2

                            'MsgBox("Ahora el mueble del que estoy actualizando los muebles")


                            sql = "update mueble set estado = 'NO ENTREGADO' where idmueble=" & rs(0) & ";"
                            Call Ejecutar(sql)

                            'MsgBox(rs(0))

                            sql = "update mueble set ProduccionAceptada=1 where idmueble=" & rs(0) & ""
                            Call Ejecutar(sql)

                            switch = 1
                        End While
                        frmDocumento_Presupuesto_.Hide()




                        frmPedidoMueble.varpmueble = frmPedidoMueble.varidmueble
                        Me.Close()

                        ' frmSectores.Show()

                        frmDocumento_Presupuesto_.lblconecepto1.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto2.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto3.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto4.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto5.Text = ""
                        frmDocumento_Presupuesto_.lblConcepto6.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto7.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto8.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto9.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto10.Text = ""


                        frmDocumento_Presupuesto_.lblCantidad1.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad2.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad3.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad4.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad5.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad6.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad7.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad8.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad9.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad10.Text = ""


                        frmDocumento_Presupuesto_.lblprecio1.Text = ""
                        frmDocumento_Presupuesto_.lblprecio2.Text = ""
                        frmDocumento_Presupuesto_.lblprecio3.Text = ""
                        frmDocumento_Presupuesto_.lblprecio4.Text = ""
                        frmDocumento_Presupuesto_.lblprecio5.Text = ""
                        frmDocumento_Presupuesto_.lblPrecio6.Text = ""
                        frmDocumento_Presupuesto_.lblprecio7.Text = ""
                        frmDocumento_Presupuesto_.lblprecio8.Text = ""
                        frmDocumento_Presupuesto_.lblprecio9.Text = ""
                        frmDocumento_Presupuesto_.lblprecio10.Text = ""


                        frmDocumento_Presupuesto_.lbltotal1.Text = ""
                        frmDocumento_Presupuesto_.lbltotal2.Text = ""
                        frmDocumento_Presupuesto_.lbltotal3.Text = ""
                        frmDocumento_Presupuesto_.lbltotal4.Text = ""
                        frmDocumento_Presupuesto_.lbltotal5.Text = ""
                        frmDocumento_Presupuesto_.lblTotal6.Text = ""
                        frmDocumento_Presupuesto_.lbltotal7.Text = ""
                        frmDocumento_Presupuesto_.lbltotal8.Text = ""
                        frmDocumento_Presupuesto_.lbltotal9.Text = ""
                        frmDocumento_Presupuesto_.lbltotal10.Text = ""

                        frmDocumento_Presupuesto_.lblTotalPresupuesto.Text = ""

                        frmPedidoMueble.acum = 0


                        frmDNICliente.txtDNI.Text = ""
                        frmDNICliente.Show()
                        frmPedidoMueble.Hide()

                        'LO ARREGLÉ
                        frmPedidoMueble.btnAgregarPedido.Enabled = True
                        frmPedidoMueble.btnAgregarPedido.Visible = False
                        frmPedidoMueble.btnIngresarMueble.Enabled = False

                        frmExtraDireccionDistanciaKM.txtDistanciaKM.Enabled = True
                        frmExtraDireccionDistanciaKM.txtDireccionEntrega.Enabled = True
                        frmExtraDireccionDistanciaKM.txtDireccionEntrega.Text = ""
                        frmExtraDireccionDistanciaKM.txtDistanciaKM.Text = ""
                    Else


                        sql = "select max(idpedido) from pedido"
                        Call Ejecutar(sql)
                        rs.Read()

                        sql = "insert into factura values('', " & rs(0) & ", 0, " & frmDocumento_Presupuesto_.lblTotalPresupuesto.Text & ");"
                        Call Ejecutar(sql)

                        frmDocumento_Presupuesto_.Hide()

                        Me.Close()
                        'frmSectores.Show()

                        frmDocumento_Presupuesto_.lblconecepto1.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto2.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto3.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto4.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto5.Text = ""
                        frmDocumento_Presupuesto_.lblConcepto6.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto7.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto8.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto9.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto10.Text = ""


                        frmDocumento_Presupuesto_.lblCantidad1.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad2.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad3.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad4.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad5.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad6.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad7.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad8.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad9.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad10.Text = ""


                        frmDocumento_Presupuesto_.lblprecio1.Text = ""
                        frmDocumento_Presupuesto_.lblprecio2.Text = ""
                        frmDocumento_Presupuesto_.lblprecio3.Text = ""
                        frmDocumento_Presupuesto_.lblprecio4.Text = ""
                        frmDocumento_Presupuesto_.lblprecio5.Text = ""
                        frmDocumento_Presupuesto_.lblPrecio6.Text = ""
                        frmDocumento_Presupuesto_.lblprecio7.Text = ""
                        frmDocumento_Presupuesto_.lblprecio8.Text = ""
                        frmDocumento_Presupuesto_.lblprecio9.Text = ""
                        frmDocumento_Presupuesto_.lblprecio10.Text = ""


                        frmDocumento_Presupuesto_.lbltotal1.Text = ""
                        frmDocumento_Presupuesto_.lbltotal2.Text = ""
                        frmDocumento_Presupuesto_.lbltotal3.Text = ""
                        frmDocumento_Presupuesto_.lbltotal4.Text = ""
                        frmDocumento_Presupuesto_.lbltotal5.Text = ""
                        frmDocumento_Presupuesto_.lblTotal6.Text = ""
                        frmDocumento_Presupuesto_.lbltotal7.Text = ""
                        frmDocumento_Presupuesto_.lbltotal8.Text = ""
                        frmDocumento_Presupuesto_.lbltotal9.Text = ""
                        frmDocumento_Presupuesto_.lbltotal10.Text = ""

                        frmDocumento_Presupuesto_.lblTotalPresupuesto.Text = ""

                        frmPedidoMueble.acum = 0


                        frmDNICliente.txtDNI.Text = ""
                        frmDNICliente.Show()
                        frmPedidoMueble.Hide()


                        frmPedidoMueble.btnAgregarPedido.Enabled = True
                        frmPedidoMueble.btnAgregarPedido.Visible = False
                        frmPedidoMueble.btnIngresarMueble.Enabled = False

                        frmExtraDireccionDistanciaKM.txtDistanciaKM.Enabled = True
                        frmExtraDireccionDistanciaKM.txtDireccionEntrega.Enabled = True
                        frmExtraDireccionDistanciaKM.txtDireccionEntrega.Text = ""
                        frmExtraDireccionDistanciaKM.txtDistanciaKM.Text = ""

                    End If




                    '-PONERMONTO2


                End If


                'acaxdxdxd





                sql = "select idmadera from madera where nombre ='" & frmPedidoMueble.varcmbxd & "';"
                Call Ejecutar(sql)
                rs.Read()

                '------------XDAZO-----------

                '80% seguro que se blanquearon variables



                sql = "insert into mueblemadera values(" & frmPedidoMueble.varidmueble & ", " & rs(0) & ", '" & frmPedidoMueble.vartxtcm2 & "');"
                Call Ejecutar(sql)


                If frmPedidoMueble.cmbMaderaMueble2.Text <> "" Then 'EN EL CASO DE QUE PONGA MAS DE 1 MADERA
                    sql = "select idMadera from madera where Nombre='" & frmPedidoMueble.varcmbxd2 & "';"
                    Call Ejecutar(sql)
                    rs.Read()



                    sql = "Insert into mueblemadera values(" & frmPedidoMueble.varidmueble & ", " & rs(0) & ", '" & frmPedidoMueble.vartxtcm2_2 & "');"
                    Call Ejecutar(sql)

                End If











            Else
                '-------------------------------------------------------------------------------
                MsgBox("Cantidad máxima de muebles permitida: 5", MsgBoxStyle.Critical, "Error")
                If frmPedidoMueble.vartxtcantidad < 6 Then
                    frmPedidoMueble.acum = frmPedidoMueble.acum - frmPedidoMueble.vartxtcantidad

                    Me.Close()
                    frmPedidoMueble.Hide()
                    frmDocumento_Presupuesto_.Show()

                    If MsgBox("¿El cliente acepta el presupuesto en el momento?", MsgBoxStyle.YesNo, "Presupuesto") = MsgBoxResult.Yes Then

                        sql = "select m.idmueble from pedidomueble pm, mueble m where pm.idmueble=m.idmueble and pm.idpedido =(select max(idpedido) from pedido)"
                        Call Ejecutar(sql)



                        While rs.Read
                            switch = 2
                            '  MsgBox("Ahora el mueble del que estoy actualizando los muebles")
                            '  MsgBox(rs(0))

                            sql = "update mueble set estado = 'NO ENTREGADO' where idmueble=" & rs(0) & ";"
                            Call Ejecutar(sql)
                            sql = "update mueble set ProduccionAceptada=1 where idmueble=" & rs(0) & ""
                            Call Ejecutar(sql)

                            switch = 1
                        End While
                        frmDocumento_Presupuesto_.Hide()




                        frmPedidoMueble.varpmueble = frmPedidoMueble.varidmueble
                        Me.Close()

                        ' frmSectores.Show()

                        frmDocumento_Presupuesto_.lblconecepto1.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto2.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto3.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto4.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto5.Text = ""
                        frmDocumento_Presupuesto_.lblConcepto6.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto7.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto8.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto9.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto10.Text = ""


                        frmDocumento_Presupuesto_.lblCantidad1.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad2.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad3.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad4.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad5.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad6.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad7.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad8.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad9.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad10.Text = ""


                        frmDocumento_Presupuesto_.lblprecio1.Text = ""
                        frmDocumento_Presupuesto_.lblprecio2.Text = ""
                        frmDocumento_Presupuesto_.lblprecio3.Text = ""
                        frmDocumento_Presupuesto_.lblprecio4.Text = ""
                        frmDocumento_Presupuesto_.lblprecio5.Text = ""
                        frmDocumento_Presupuesto_.lblPrecio6.Text = ""
                        frmDocumento_Presupuesto_.lblprecio7.Text = ""
                        frmDocumento_Presupuesto_.lblprecio8.Text = ""
                        frmDocumento_Presupuesto_.lblprecio9.Text = ""
                        frmDocumento_Presupuesto_.lblprecio10.Text = ""


                        frmDocumento_Presupuesto_.lbltotal1.Text = ""
                        frmDocumento_Presupuesto_.lbltotal2.Text = ""
                        frmDocumento_Presupuesto_.lbltotal3.Text = ""
                        frmDocumento_Presupuesto_.lbltotal4.Text = ""
                        frmDocumento_Presupuesto_.lbltotal5.Text = ""
                        frmDocumento_Presupuesto_.lblTotal6.Text = ""
                        frmDocumento_Presupuesto_.lbltotal7.Text = ""
                        frmDocumento_Presupuesto_.lbltotal8.Text = ""
                        frmDocumento_Presupuesto_.lbltotal9.Text = ""
                        frmDocumento_Presupuesto_.lbltotal10.Text = ""

                        frmDocumento_Presupuesto_.lblTotalPresupuesto.Text = ""

                        frmPedidoMueble.acum = 0

                        frmDNICliente.txtDNI.Text = ""
                        frmDNICliente.Show()
                        frmPedidoMueble.Close()


                        frmPedidoMueble.btnAgregarPedido.Enabled = True
                        frmPedidoMueble.btnAgregarPedido.Visible = False
                        frmPedidoMueble.btnIngresarMueble.Enabled = False




                        frmExtraDireccionDistanciaKM.txtDistanciaKM.Enabled = True
                        frmExtraDireccionDistanciaKM.txtDireccionEntrega.Enabled = True
                        frmExtraDireccionDistanciaKM.txtDireccionEntrega.Text = ""
                        frmExtraDireccionDistanciaKM.txtDistanciaKM.Text = ""

                    Else
                        frmDocumento_Presupuesto_.Hide()

                        Me.Close()
                        'frmSectores.Show()

                        frmDocumento_Presupuesto_.lblconecepto1.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto2.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto3.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto4.Text = ""
                        frmDocumento_Presupuesto_.lblconecepto5.Text = ""
                        frmDocumento_Presupuesto_.lblConcepto6.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto7.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto8.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto9.Text = ""
                        frmDocumento_Presupuesto_.lblconcepto10.Text = ""


                        frmDocumento_Presupuesto_.lblCantidad1.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad2.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad3.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad4.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad5.Text = ""
                        frmDocumento_Presupuesto_.lblCantidad6.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad7.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad8.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad9.Text = ""
                        frmDocumento_Presupuesto_.lblcantidad10.Text = ""


                        frmDocumento_Presupuesto_.lblprecio1.Text = ""
                        frmDocumento_Presupuesto_.lblprecio2.Text = ""
                        frmDocumento_Presupuesto_.lblprecio3.Text = ""
                        frmDocumento_Presupuesto_.lblprecio4.Text = ""
                        frmDocumento_Presupuesto_.lblprecio5.Text = ""
                        frmDocumento_Presupuesto_.lblPrecio6.Text = ""
                        frmDocumento_Presupuesto_.lblprecio7.Text = ""
                        frmDocumento_Presupuesto_.lblprecio8.Text = ""
                        frmDocumento_Presupuesto_.lblprecio9.Text = ""
                        frmDocumento_Presupuesto_.lblprecio10.Text = ""


                        frmDocumento_Presupuesto_.lbltotal1.Text = ""
                        frmDocumento_Presupuesto_.lbltotal2.Text = ""
                        frmDocumento_Presupuesto_.lbltotal3.Text = ""
                        frmDocumento_Presupuesto_.lbltotal4.Text = ""
                        frmDocumento_Presupuesto_.lbltotal5.Text = ""
                        frmDocumento_Presupuesto_.lblTotal6.Text = ""
                        frmDocumento_Presupuesto_.lbltotal7.Text = ""
                        frmDocumento_Presupuesto_.lbltotal8.Text = ""
                        frmDocumento_Presupuesto_.lbltotal9.Text = ""
                        frmDocumento_Presupuesto_.lbltotal10.Text = ""

                        frmDocumento_Presupuesto_.lblTotalPresupuesto.Text = ""

                        frmPedidoMueble.acum = 0

                        frmDNICliente.txtDNI.Text = ""
                        frmDNICliente.Show()
                        frmPedidoMueble.Close()


                        frmPedidoMueble.btnAgregarPedido.Enabled = True
                        frmPedidoMueble.btnAgregarPedido.Visible = False
                        frmPedidoMueble.btnIngresarMueble.Enabled = False



                        frmExtraDireccionDistanciaKM.txtDistanciaKM.Enabled = True
                        frmExtraDireccionDistanciaKM.txtDireccionEntrega.Enabled = True
                        frmExtraDireccionDistanciaKM.txtDireccionEntrega.Text = ""
                        frmExtraDireccionDistanciaKM.txtDistanciaKM.Text = ""

                    End If

                End If
                ' If frmPedidoMueble.acum < 6 Then
                '
                '
                '
                '     frmDocumento_Presupuesto_.lblTotalPresupuesto.Text = CInt(frmPedidoMueble.montototaltotal) + frmPedidoMueble.extratotal
                '     frmDocumento_Presupuesto_.Show()
                '     frmPedidoMueble.btnAgregarPedido.Enabled = True
                '     frmPedidoMueble.btnAgregarPedido.Visible = False
                '     frmPedidoMueble.btnIngresarMueble.Enabled = False
                '
                '
                '
                '
                ' Else
                '
                '
                '
                '     frmPedidoMueble.cmbTipoMueble.Text = ""
                '     frmPedidoMueble.cmbMaderaMueble.Text = ""
                '     frmPedidoMueble.cmbMaderaMueble2.Text = ""
                '     frmPedidoMueble.txtCM2.Text = ""
                '     frmPedidoMueble.txtCM2_2.Text = ""
                '     frmPedidoMueble.txtCantidad.Text = ""
                '
                '
                '
                '     frmPedidoMueble.btnAgregarPedido.Enabled = True
                '     frmPedidoMueble.btnAgregarPedido.Visible = False
                '     frmPedidoMueble.btnIngresarMueble.Enabled = False
                '
                '     frmExtraDireccionDistanciaKM.txtDireccionEntrega.Text = ""
                '     frmExtraDireccionDistanciaKM.txtDistanciaKM.Text = ""
                '
                '     frmPedidoMueble.txtCantidad2.Text = ""
                '     frmPedidoMueble.acum = 0
                '
                '     MsgBox("Vuelva a ingresar los datos del pedido verificando la cantidad", MsgBoxStyle.Information, "Presupuesto")
                '
                '
                ' End If








            End If
            '-----------------------------------------------------------------------------------


            'TERMINA ULTIMO IF
            Hernan = 0

            frmPedidoMueble.cmbTipoMueble.Text = ""
            frmPedidoMueble.cmbMaderaMueble.Text = ""
            frmPedidoMueble.cmbMaderaMueble2.Text = ""
            frmPedidoMueble.txtCM2.Text = ""
            frmPedidoMueble.txtCM2_2.Text = ""
            frmPedidoMueble.txtCantidad.Text = ""

            frmPedidoMueble.txtCantidad2.Text = ""




        End If




      


    End Sub

    Private Sub txtCantidadM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadM.KeyPress
        Onlynum(e)
    End Sub

    Private Sub cmbMaterialM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMaterialM.SelectedIndexChanged
        If txtCantidadM.Text <> "" And cmbMaterialM.Text <> "" Then

            btnAceptarM.Enabled = True
        Else
            btnAceptarM.Enabled = False

        End If



    End Sub

    Private Sub txtCantidadM_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadM.TextChanged

        If txtCantidadM.Text = "0" Then

            txtCantidadM.Text = ""

        End If

        If txtCantidadM.Text <> "" And cmbMaterialM.Text <> "" Then

            btnAceptarM.Enabled = True
        Else
            btnAceptarM.Enabled = False
        End If

    End Sub
End Class