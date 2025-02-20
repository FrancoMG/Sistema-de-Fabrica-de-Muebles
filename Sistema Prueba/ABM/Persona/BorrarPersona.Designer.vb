<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarPersona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrarPersona))
        Me.gbxPersona = New System.Windows.Forms.GroupBox()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.btnBorrarPersona = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.frmVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxPersona.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxPersona
        '
        Me.gbxPersona.Controls.Add(Me.btnLista)
        Me.gbxPersona.Controls.Add(Me.btnBorrarPersona)
        Me.gbxPersona.Controls.Add(Me.lblID)
        Me.gbxPersona.Controls.Add(Me.txtID)
        Me.gbxPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPersona.Location = New System.Drawing.Point(56, 30)
        Me.gbxPersona.Name = "gbxPersona"
        Me.gbxPersona.Size = New System.Drawing.Size(301, 199)
        Me.gbxPersona.TabIndex = 0
        Me.gbxPersona.TabStop = False
        Me.gbxPersona.Text = "Persona"
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(111, 98)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(92, 25)
        Me.btnLista.TabIndex = 24
        Me.btnLista.Text = "Ver Lista"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'btnBorrarPersona
        '
        Me.btnBorrarPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarPersona.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBorrarPersona.Location = New System.Drawing.Point(92, 152)
        Me.btnBorrarPersona.Name = "btnBorrarPersona"
        Me.btnBorrarPersona.Size = New System.Drawing.Size(125, 28)
        Me.btnBorrarPersona.TabIndex = 23
        Me.btnBorrarPersona.Text = "Borrar"
        Me.btnBorrarPersona.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(60, 47)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(26, 20)
        Me.lblID.TabIndex = 21
        Me.lblID.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(92, 47)
        Me.txtID.MaxLength = 40
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(170, 20)
        Me.txtID.TabIndex = 22
        '
        'frmVolverMenuABM
        '
        Me.frmVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmVolverMenuABM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.frmVolverMenuABM.Location = New System.Drawing.Point(99, 255)
        Me.frmVolverMenuABM.Name = "frmVolverMenuABM"
        Me.frmVolverMenuABM.Size = New System.Drawing.Size(232, 28)
        Me.frmVolverMenuABM.TabIndex = 29
        Me.frmVolverMenuABM.Text = "Volver al menu de ABM"
        Me.frmVolverMenuABM.UseVisualStyleBackColor = True
        '
        'frmBorrarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(425, 315)
        Me.Controls.Add(Me.frmVolverMenuABM)
        Me.Controls.Add(Me.gbxPersona)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBorrarPersona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Borrar persona"
        Me.gbxPersona.ResumeLayout(False)
        Me.gbxPersona.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPersona As System.Windows.Forms.GroupBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrarPersona As System.Windows.Forms.Button
    Friend WithEvents frmVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents btnLista As System.Windows.Forms.Button
End Class
