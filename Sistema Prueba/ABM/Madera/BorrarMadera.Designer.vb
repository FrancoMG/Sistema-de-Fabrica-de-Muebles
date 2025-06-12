<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarMadera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrarMadera))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxBorrarMadera = New System.Windows.Forms.GroupBox()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnBorrarMadera = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.gbxBorrarMadera.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(54, 293)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(244, 31)
        Me.btnVolverMenuABM.TabIndex = 11
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxBorrarMadera
        '
        Me.gbxBorrarMadera.Controls.Add(Me.btnLista)
        Me.gbxBorrarMadera.Controls.Add(Me.txtID)
        Me.gbxBorrarMadera.Controls.Add(Me.btnBorrarMadera)
        Me.gbxBorrarMadera.Controls.Add(Me.lblID)
        Me.gbxBorrarMadera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBorrarMadera.Location = New System.Drawing.Point(32, 33)
        Me.gbxBorrarMadera.Name = "gbxBorrarMadera"
        Me.gbxBorrarMadera.Size = New System.Drawing.Size(279, 226)
        Me.gbxBorrarMadera.TabIndex = 10
        Me.gbxBorrarMadera.TabStop = False
        Me.gbxBorrarMadera.Text = "Madera"
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(82, 119)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(120, 29)
        Me.btnLista.TabIndex = 7
        Me.btnLista.Text = "Ver Lista"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(39, 84)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(211, 20)
        Me.txtID.TabIndex = 3
        '
        'btnBorrarMadera
        '
        Me.btnBorrarMadera.Location = New System.Drawing.Point(61, 172)
        Me.btnBorrarMadera.Name = "btnBorrarMadera"
        Me.btnBorrarMadera.Size = New System.Drawing.Size(159, 31)
        Me.btnBorrarMadera.TabIndex = 2
        Me.btnBorrarMadera.Text = "Borrar"
        Me.btnBorrarMadera.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(96, 52)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(89, 20)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ingresar ID"
        '
        'frmBorrarMadera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(346, 361)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxBorrarMadera)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBorrarMadera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Borrar madera"
        Me.gbxBorrarMadera.ResumeLayout(False)
        Me.gbxBorrarMadera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxBorrarMadera As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrarMadera As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnLista As System.Windows.Forms.Button
End Class
