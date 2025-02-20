<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrarProveedor))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxBorrarProveedor = New System.Windows.Forms.GroupBox()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnBorrarProveedor = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.gbxBorrarProveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(46, 302)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(248, 31)
        Me.btnVolverMenuABM.TabIndex = 17
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxBorrarProveedor
        '
        Me.gbxBorrarProveedor.Controls.Add(Me.btnLista)
        Me.gbxBorrarProveedor.Controls.Add(Me.txtID)
        Me.gbxBorrarProveedor.Controls.Add(Me.btnBorrarProveedor)
        Me.gbxBorrarProveedor.Controls.Add(Me.lblID)
        Me.gbxBorrarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBorrarProveedor.Location = New System.Drawing.Point(29, 32)
        Me.gbxBorrarProveedor.Name = "gbxBorrarProveedor"
        Me.gbxBorrarProveedor.Size = New System.Drawing.Size(277, 234)
        Me.gbxBorrarProveedor.TabIndex = 16
        Me.gbxBorrarProveedor.TabStop = False
        Me.gbxBorrarProveedor.Text = "Proveedor"
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(83, 125)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(120, 29)
        Me.btnLista.TabIndex = 10
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
        'btnBorrarProveedor
        '
        Me.btnBorrarProveedor.Location = New System.Drawing.Point(63, 175)
        Me.btnBorrarProveedor.Name = "btnBorrarProveedor"
        Me.btnBorrarProveedor.Size = New System.Drawing.Size(159, 31)
        Me.btnBorrarProveedor.TabIndex = 2
        Me.btnBorrarProveedor.Text = "Borrar"
        Me.btnBorrarProveedor.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(97, 47)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(89, 20)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ingresar ID"
        '
        'frmBorrarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(336, 371)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxBorrarProveedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBorrarProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Borrar proveedor"
        Me.gbxBorrarProveedor.ResumeLayout(False)
        Me.gbxBorrarProveedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxBorrarProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrarProveedor As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnLista As System.Windows.Forms.Button
End Class
