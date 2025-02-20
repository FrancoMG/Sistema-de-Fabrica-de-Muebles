<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarProveedor))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxAgregarProveedor = New System.Windows.Forms.GroupBox()
        Me.cmbTipoP = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.lblContacto = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnAgregarProveedor = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.gbxAgregarProveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(53, 440)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(248, 31)
        Me.btnVolverMenuABM.TabIndex = 17
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxAgregarProveedor
        '
        Me.gbxAgregarProveedor.Controls.Add(Me.cmbTipoP)
        Me.gbxAgregarProveedor.Controls.Add(Me.lblTipo)
        Me.gbxAgregarProveedor.Controls.Add(Me.txtContacto)
        Me.gbxAgregarProveedor.Controls.Add(Me.lblContacto)
        Me.gbxAgregarProveedor.Controls.Add(Me.txtDireccion)
        Me.gbxAgregarProveedor.Controls.Add(Me.lblDireccion)
        Me.gbxAgregarProveedor.Controls.Add(Me.txtNombre)
        Me.gbxAgregarProveedor.Controls.Add(Me.btnAgregarProveedor)
        Me.gbxAgregarProveedor.Controls.Add(Me.lblNombre)
        Me.gbxAgregarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAgregarProveedor.Location = New System.Drawing.Point(35, 37)
        Me.gbxAgregarProveedor.Name = "gbxAgregarProveedor"
        Me.gbxAgregarProveedor.Size = New System.Drawing.Size(277, 375)
        Me.gbxAgregarProveedor.TabIndex = 16
        Me.gbxAgregarProveedor.TabStop = False
        Me.gbxAgregarProveedor.Text = "Proveedor"
        '
        'cmbTipoP
        '
        Me.cmbTipoP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoP.FormattingEnabled = True
        Me.cmbTipoP.Location = New System.Drawing.Point(35, 267)
        Me.cmbTipoP.Name = "cmbTipoP"
        Me.cmbTipoP.Size = New System.Drawing.Size(211, 21)
        Me.cmbTipoP.TabIndex = 10
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(92, 235)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(102, 20)
        Me.lblTipo.TabIndex = 8
        Me.lblTipo.Text = "Ingresar Tipo"
        '
        'txtContacto
        '
        Me.txtContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContacto.Location = New System.Drawing.Point(35, 201)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(211, 20)
        Me.txtContacto.TabIndex = 7
        '
        'lblContacto
        '
        Me.lblContacto.AutoSize = True
        Me.lblContacto.Location = New System.Drawing.Point(78, 169)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(137, 20)
        Me.lblContacto.TabIndex = 6
        Me.lblContacto.Text = "Ingresar Contacto"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(35, 137)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(211, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(75, 105)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(138, 20)
        Me.lblDireccion.TabIndex = 4
        Me.lblDireccion.Text = "Ingresar Direccion"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(35, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(211, 20)
        Me.txtNombre.TabIndex = 3
        '
        'btnAgregarProveedor
        '
        Me.btnAgregarProveedor.Location = New System.Drawing.Point(66, 320)
        Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
        Me.btnAgregarProveedor.Size = New System.Drawing.Size(159, 31)
        Me.btnAgregarProveedor.TabIndex = 2
        Me.btnAgregarProveedor.Text = "Agregar"
        Me.btnAgregarProveedor.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(78, 41)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(128, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Ingresar Nombre"
        '
        'frmAgregarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(353, 501)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxAgregarProveedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Agregar proveedor"
        Me.gbxAgregarProveedor.ResumeLayout(False)
        Me.gbxAgregarProveedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxAgregarProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtContacto As System.Windows.Forms.TextBox
    Friend WithEvents lblContacto As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarProveedor As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents cmbTipoP As System.Windows.Forms.ComboBox
End Class
