<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarTecnico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarTecnico))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxAgregarTecnico = New System.Windows.Forms.GroupBox()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnAgregarTecnico = New System.Windows.Forms.Button()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.gbxAgregarTecnico.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(53, 290)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(244, 31)
        Me.btnVolverMenuABM.TabIndex = 5
        Me.btnVolverMenuABM.Text = "Volver al menu de abm"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxAgregarTecnico
        '
        Me.gbxAgregarTecnico.Controls.Add(Me.btnLista)
        Me.gbxAgregarTecnico.Controls.Add(Me.txtID)
        Me.gbxAgregarTecnico.Controls.Add(Me.btnAgregarTecnico)
        Me.gbxAgregarTecnico.Controls.Add(Me.lblDNI)
        Me.gbxAgregarTecnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAgregarTecnico.Location = New System.Drawing.Point(31, 30)
        Me.gbxAgregarTecnico.Name = "gbxAgregarTecnico"
        Me.gbxAgregarTecnico.Size = New System.Drawing.Size(279, 226)
        Me.gbxAgregarTecnico.TabIndex = 4
        Me.gbxAgregarTecnico.TabStop = False
        Me.gbxAgregarTecnico.Text = "Tecnico"
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(87, 119)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(120, 29)
        Me.btnLista.TabIndex = 12
        Me.btnLista.Text = "Ver Lista"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(39, 72)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(211, 20)
        Me.txtID.TabIndex = 3
        '
        'btnAgregarTecnico
        '
        Me.btnAgregarTecnico.Location = New System.Drawing.Point(61, 172)
        Me.btnAgregarTecnico.Name = "btnAgregarTecnico"
        Me.btnAgregarTecnico.Size = New System.Drawing.Size(159, 31)
        Me.btnAgregarTecnico.TabIndex = 2
        Me.btnAgregarTecnico.Text = "Agregar"
        Me.btnAgregarTecnico.UseVisualStyleBackColor = True
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(61, 40)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(189, 20)
        Me.lblDNI.TabIndex = 0
        Me.lblDNI.Text = "Ingresar ID de la persona"
        '
        'frmAgregarTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(348, 361)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxAgregarTecnico)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarTecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Agregar tecnico"
        Me.gbxAgregarTecnico.ResumeLayout(False)
        Me.gbxAgregarTecnico.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxAgregarTecnico As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarTecnico As System.Windows.Forms.Button
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents btnLista As System.Windows.Forms.Button
End Class
