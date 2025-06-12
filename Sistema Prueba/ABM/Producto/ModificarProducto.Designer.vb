<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarProducto))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPP = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.gbxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(149, 457)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(192, 28)
        Me.btnSalir.TabIndex = 39
        Me.btnSalir.Text = "Volver al menu de ABM"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.lblStock)
        Me.gbxDatos.Controls.Add(Me.txtStock)
        Me.gbxDatos.Controls.Add(Me.Label1)
        Me.gbxDatos.Controls.Add(Me.txtPP)
        Me.gbxDatos.Controls.Add(Me.btnModificar)
        Me.gbxDatos.Controls.Add(Me.lblEstado)
        Me.gbxDatos.Controls.Add(Me.lblNombre)
        Me.gbxDatos.Controls.Add(Me.cmbEstado)
        Me.gbxDatos.Controls.Add(Me.txtNombre)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatos.Location = New System.Drawing.Point(25, 159)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(425, 267)
        Me.gbxDatos.TabIndex = 40
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "Datos"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(77, 126)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(50, 20)
        Me.lblStock.TabIndex = 18
        Me.lblStock.Text = "Stock"
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(20, 157)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(171, 22)
        Me.txtStock.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Punto de Pedido"
        '
        'txtPP
        '
        Me.txtPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPP.Location = New System.Drawing.Point(239, 56)
        Me.txtPP.Name = "txtPP"
        Me.txtPP.Size = New System.Drawing.Size(171, 22)
        Me.txtPP.TabIndex = 15
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(136, 216)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(171, 28)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(296, 125)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(60, 20)
        Me.lblEstado.TabIndex = 13
        Me.lblEstado.Text = "Estado"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(71, 24)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(263, 159)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(126, 21)
        Me.cmbEstado.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(20, 56)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(171, 22)
        Me.txtNombre.TabIndex = 4
        '
        'btnCargarDatos
        '
        Me.btnCargarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarDatos.Location = New System.Drawing.Point(174, 98)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(126, 27)
        Me.btnCargarDatos.TabIndex = 38
        Me.btnCargarDatos.Text = "Cargar datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = True
        '
        'btnLista
        '
        Me.btnLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLista.Location = New System.Drawing.Point(302, 50)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(112, 23)
        Me.btnLista.TabIndex = 37
        Me.btnLista.Text = "Ver lista"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(199, 53)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(85, 20)
        Me.txtID.TabIndex = 36
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(74, 53)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(119, 20)
        Me.lblID.TabIndex = 35
        Me.lblID.Text = "ID del Producto"
        '
        'frmModificarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(480, 523)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.btnCargarDatos)
        Me.Controls.Add(Me.btnLista)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModificarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Modificar producto"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnCargarDatos As System.Windows.Forms.Button
    Friend WithEvents btnLista As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPP As System.Windows.Forms.TextBox
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
End Class
