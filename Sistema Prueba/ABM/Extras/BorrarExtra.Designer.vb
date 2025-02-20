<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarExtra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrarExtra))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxBorrarExtra = New System.Windows.Forms.GroupBox()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnBorrarExtra = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.gbxBorrarExtra.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(44, 300)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(248, 31)
        Me.btnVolverMenuABM.TabIndex = 15
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxBorrarExtra
        '
        Me.gbxBorrarExtra.Controls.Add(Me.btnLista)
        Me.gbxBorrarExtra.Controls.Add(Me.txtID)
        Me.gbxBorrarExtra.Controls.Add(Me.btnBorrarExtra)
        Me.gbxBorrarExtra.Controls.Add(Me.lblID)
        Me.gbxBorrarExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBorrarExtra.Location = New System.Drawing.Point(27, 30)
        Me.gbxBorrarExtra.Name = "gbxBorrarExtra"
        Me.gbxBorrarExtra.Size = New System.Drawing.Size(277, 231)
        Me.gbxBorrarExtra.TabIndex = 14
        Me.gbxBorrarExtra.TabStop = False
        Me.gbxBorrarExtra.Text = "Extra"
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(80, 116)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(120, 29)
        Me.btnLista.TabIndex = 6
        Me.btnLista.Text = "Ver Lista"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(36, 81)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(211, 20)
        Me.txtID.TabIndex = 3
        '
        'btnBorrarExtra
        '
        Me.btnBorrarExtra.Location = New System.Drawing.Point(62, 165)
        Me.btnBorrarExtra.Name = "btnBorrarExtra"
        Me.btnBorrarExtra.Size = New System.Drawing.Size(159, 31)
        Me.btnBorrarExtra.TabIndex = 2
        Me.btnBorrarExtra.Text = "Borrar"
        Me.btnBorrarExtra.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(98, 49)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(89, 20)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ingresar ID"
        '
        'frmBorrarExtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(330, 369)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxBorrarExtra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBorrarExtra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Borrar extra"
        Me.gbxBorrarExtra.ResumeLayout(False)
        Me.gbxBorrarExtra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxBorrarExtra As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrarExtra As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnLista As System.Windows.Forms.Button
End Class
