<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarProveedor))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.cmbTP = New System.Windows.Forms.ComboBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTP = New System.Windows.Forms.Label()
        Me.lblContacto = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
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
        Me.btnSalir.Location = New System.Drawing.Point(151, 500)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(192, 28)
        Me.btnSalir.TabIndex = 21
        Me.btnSalir.Text = "Volver al menu de ABM"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.cmbTP)
        Me.gbxDatos.Controls.Add(Me.btnModificar)
        Me.gbxDatos.Controls.Add(Me.lblEstado)
        Me.gbxDatos.Controls.Add(Me.lblDireccion)
        Me.gbxDatos.Controls.Add(Me.lblTP)
        Me.gbxDatos.Controls.Add(Me.lblContacto)
        Me.gbxDatos.Controls.Add(Me.lblNombre)
        Me.gbxDatos.Controls.Add(Me.cmbEstado)
        Me.gbxDatos.Controls.Add(Me.txtDireccion)
        Me.gbxDatos.Controls.Add(Me.txtContacto)
        Me.gbxDatos.Controls.Add(Me.txtNombre)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatos.Location = New System.Drawing.Point(29, 161)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(425, 311)
        Me.gbxDatos.TabIndex = 22
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "Datos"
        '
        'cmbTP
        '
        Me.cmbTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTP.FormattingEnabled = True
        Me.cmbTP.Location = New System.Drawing.Point(20, 136)
        Me.cmbTP.Name = "cmbTP"
        Me.cmbTP.Size = New System.Drawing.Size(171, 21)
        Me.cmbTP.TabIndex = 15
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(132, 262)
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
        Me.lblEstado.Location = New System.Drawing.Point(187, 181)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(60, 20)
        Me.lblEstado.TabIndex = 13
        Me.lblEstado.Text = "Estado"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(283, 102)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(75, 20)
        Me.lblDireccion.TabIndex = 12
        Me.lblDireccion.Text = "Direccion"
        '
        'lblTP
        '
        Me.lblTP.AutoSize = True
        Me.lblTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTP.Location = New System.Drawing.Point(38, 102)
        Me.lblTP.Name = "lblTP"
        Me.lblTP.Size = New System.Drawing.Size(137, 20)
        Me.lblTP.TabIndex = 11
        Me.lblTP.Text = "Tipo de Proveedor"
        '
        'lblContacto
        '
        Me.lblContacto.AutoSize = True
        Me.lblContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContacto.Location = New System.Drawing.Point(283, 24)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(74, 20)
        Me.lblContacto.TabIndex = 10
        Me.lblContacto.Text = "Contacto"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(72, 24)
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
        Me.cmbEstado.Location = New System.Drawing.Point(153, 213)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(126, 21)
        Me.cmbEstado.TabIndex = 8
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(233, 134)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(171, 22)
        Me.txtDireccion.TabIndex = 7
        '
        'txtContacto
        '
        Me.txtContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.Location = New System.Drawing.Point(233, 56)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(171, 22)
        Me.txtContacto.TabIndex = 5
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
        Me.btnCargarDatos.Location = New System.Drawing.Point(178, 100)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(126, 27)
        Me.btnCargarDatos.TabIndex = 20
        Me.btnCargarDatos.Text = "Cargar datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = True
        '
        'btnLista
        '
        Me.btnLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLista.Location = New System.Drawing.Point(306, 52)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(112, 23)
        Me.btnLista.TabIndex = 19
        Me.btnLista.Text = "Ver lista"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(203, 55)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(85, 20)
        Me.txtID.TabIndex = 18
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(67, 54)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(127, 20)
        Me.lblID.TabIndex = 17
        Me.lblID.Text = "ID del Proveedor"
        '
        'frmModificarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(480, 562)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.btnCargarDatos)
        Me.Controls.Add(Me.btnLista)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModificarProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Modificar proveedor"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblTP As System.Windows.Forms.Label
    Friend WithEvents lblContacto As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnCargarDatos As System.Windows.Forms.Button
    Friend WithEvents btnLista As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cmbTP As System.Windows.Forms.ComboBox
End Class
