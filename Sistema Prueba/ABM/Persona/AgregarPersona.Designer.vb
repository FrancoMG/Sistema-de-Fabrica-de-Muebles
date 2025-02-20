<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarPersona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarPersona))
        Me.gbxPersona = New System.Windows.Forms.GroupBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.dniUsuario = New System.Windows.Forms.Label()
        Me.btnRegistrarPersona = New System.Windows.Forms.Button()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.frmVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxPersona.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxPersona
        '
        Me.gbxPersona.Controls.Add(Me.lblDireccion)
        Me.gbxPersona.Controls.Add(Me.txtDireccion)
        Me.gbxPersona.Controls.Add(Me.txtTelefono)
        Me.gbxPersona.Controls.Add(Me.lblTelefono)
        Me.gbxPersona.Controls.Add(Me.dniUsuario)
        Me.gbxPersona.Controls.Add(Me.btnRegistrarPersona)
        Me.gbxPersona.Controls.Add(Me.lblDNI)
        Me.gbxPersona.Controls.Add(Me.txtDNI)
        Me.gbxPersona.Controls.Add(Me.txtNombre)
        Me.gbxPersona.Controls.Add(Me.txtApellido)
        Me.gbxPersona.Controls.Add(Me.lblNombre)
        Me.gbxPersona.Controls.Add(Me.lblApellido)
        Me.gbxPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPersona.Location = New System.Drawing.Point(63, 39)
        Me.gbxPersona.Name = "gbxPersona"
        Me.gbxPersona.Size = New System.Drawing.Size(405, 265)
        Me.gbxPersona.TabIndex = 0
        Me.gbxPersona.TabStop = False
        Me.gbxPersona.Text = "Datos persona"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(84, 157)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(75, 20)
        Me.lblDireccion.TabIndex = 27
        Me.lblDireccion.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(165, 159)
        Me.txtDireccion.MaxLength = 40
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(170, 20)
        Me.txtDireccion.TabIndex = 26
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(165, 133)
        Me.txtTelefono.MaxLength = 40
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(170, 20)
        Me.txtTelefono.TabIndex = 25
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(88, 131)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 20)
        Me.lblTelefono.TabIndex = 24
        Me.lblTelefono.Text = "Telefono"
        '
        'dniUsuario
        '
        Me.dniUsuario.AutoSize = True
        Me.dniUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dniUsuario.Location = New System.Drawing.Point(165, 32)
        Me.dniUsuario.Name = "dniUsuario"
        Me.dniUsuario.Size = New System.Drawing.Size(0, 20)
        Me.dniUsuario.TabIndex = 23
        '
        'btnRegistrarPersona
        '
        Me.btnRegistrarPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarPersona.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegistrarPersona.Location = New System.Drawing.Point(142, 207)
        Me.btnRegistrarPersona.Name = "btnRegistrarPersona"
        Me.btnRegistrarPersona.Size = New System.Drawing.Size(125, 28)
        Me.btnRegistrarPersona.TabIndex = 21
        Me.btnRegistrarPersona.Text = "Registrar"
        Me.btnRegistrarPersona.UseVisualStyleBackColor = True
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(122, 107)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(37, 20)
        Me.lblDNI.TabIndex = 19
        Me.lblDNI.Text = "DNI"
        '
        'txtDNI
        '
        Me.txtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(165, 107)
        Me.txtDNI.MaxLength = 40
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(170, 20)
        Me.txtDNI.TabIndex = 20
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(165, 55)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtNombre.TabIndex = 16
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(165, 81)
        Me.txtApellido.MaxLength = 40
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(170, 20)
        Me.txtApellido.TabIndex = 18
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(94, 55)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 14
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(94, 81)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(65, 20)
        Me.lblApellido.TabIndex = 17
        Me.lblApellido.Text = "Apellido"
        '
        'frmVolverMenuABM
        '
        Me.frmVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmVolverMenuABM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.frmVolverMenuABM.Location = New System.Drawing.Point(151, 326)
        Me.frmVolverMenuABM.Name = "frmVolverMenuABM"
        Me.frmVolverMenuABM.Size = New System.Drawing.Size(232, 28)
        Me.frmVolverMenuABM.TabIndex = 28
        Me.frmVolverMenuABM.Text = "Volver al menu de ABM"
        Me.frmVolverMenuABM.UseVisualStyleBackColor = True
        '
        'frmAgregarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(540, 378)
        Me.Controls.Add(Me.frmVolverMenuABM)
        Me.Controls.Add(Me.gbxPersona)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Agregar persona"
        Me.gbxPersona.ResumeLayout(False)
        Me.gbxPersona.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPersona As System.Windows.Forms.GroupBox
    Friend WithEvents dniUsuario As System.Windows.Forms.Label
    Friend WithEvents btnRegistrarPersona As System.Windows.Forms.Button
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents frmVolverMenuABM As System.Windows.Forms.Button
End Class
