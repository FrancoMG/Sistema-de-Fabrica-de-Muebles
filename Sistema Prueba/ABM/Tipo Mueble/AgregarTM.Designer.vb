<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarTM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarTM))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxAgregarTM = New System.Windows.Forms.GroupBox()
        Me.txtTP = New System.Windows.Forms.TextBox()
        Me.lblTP = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnAgregarTM = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.gbxAgregarTM.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(53, 346)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(244, 31)
        Me.btnVolverMenuABM.TabIndex = 7
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxAgregarTM
        '
        Me.gbxAgregarTM.Controls.Add(Me.txtTP)
        Me.gbxAgregarTM.Controls.Add(Me.lblTP)
        Me.gbxAgregarTM.Controls.Add(Me.txtDescripcion)
        Me.gbxAgregarTM.Controls.Add(Me.btnAgregarTM)
        Me.gbxAgregarTM.Controls.Add(Me.lblDescripcion)
        Me.gbxAgregarTM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAgregarTM.Location = New System.Drawing.Point(31, 40)
        Me.gbxAgregarTM.Name = "gbxAgregarTM"
        Me.gbxAgregarTM.Size = New System.Drawing.Size(279, 266)
        Me.gbxAgregarTM.TabIndex = 6
        Me.gbxAgregarTM.TabStop = False
        Me.gbxAgregarTM.Text = "Tipo de Mueble"
        '
        'txtTP
        '
        Me.txtTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTP.Location = New System.Drawing.Point(39, 155)
        Me.txtTP.Name = "txtTP"
        Me.txtTP.Size = New System.Drawing.Size(211, 20)
        Me.txtTP.TabIndex = 5
        '
        'lblTP
        '
        Me.lblTP.AutoSize = True
        Me.lblTP.Location = New System.Drawing.Point(47, 123)
        Me.lblTP.Name = "lblTP"
        Me.lblTP.Size = New System.Drawing.Size(201, 20)
        Me.lblTP.TabIndex = 4
        Me.lblTP.Text = "Ingresa Tiempo produccion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(39, 84)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(211, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'btnAgregarTM
        '
        Me.btnAgregarTM.Location = New System.Drawing.Point(61, 216)
        Me.btnAgregarTM.Name = "btnAgregarTM"
        Me.btnAgregarTM.Size = New System.Drawing.Size(159, 31)
        Me.btnAgregarTM.TabIndex = 2
        Me.btnAgregarTM.Text = "Agregar"
        Me.btnAgregarTM.UseVisualStyleBackColor = True
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(65, 53)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(155, 20)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Ingresar Descripcion"
        '
        'frmAgregarTM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(345, 416)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxAgregarTM)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarTM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Agregar Tipo Mueble"
        Me.gbxAgregarTM.ResumeLayout(False)
        Me.gbxAgregarTM.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxAgregarTM As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarTM As System.Windows.Forms.Button
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtTP As System.Windows.Forms.TextBox
    Friend WithEvents lblTP As System.Windows.Forms.Label
End Class
