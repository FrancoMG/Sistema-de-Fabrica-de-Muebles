<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarTM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrarTM))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxBorrarTM = New System.Windows.Forms.GroupBox()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnBorrarTM = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.gbxBorrarTM.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(57, 297)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(244, 31)
        Me.btnVolverMenuABM.TabIndex = 9
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxBorrarTM
        '
        Me.gbxBorrarTM.Controls.Add(Me.btnLista)
        Me.gbxBorrarTM.Controls.Add(Me.txtID)
        Me.gbxBorrarTM.Controls.Add(Me.btnBorrarTM)
        Me.gbxBorrarTM.Controls.Add(Me.lblID)
        Me.gbxBorrarTM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBorrarTM.Location = New System.Drawing.Point(35, 37)
        Me.gbxBorrarTM.Name = "gbxBorrarTM"
        Me.gbxBorrarTM.Size = New System.Drawing.Size(279, 226)
        Me.gbxBorrarTM.TabIndex = 8
        Me.gbxBorrarTM.TabStop = False
        Me.gbxBorrarTM.Text = "Tipo de Mueble"
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(81, 123)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(120, 29)
        Me.btnLista.TabIndex = 13
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
        'btnBorrarTM
        '
        Me.btnBorrarTM.Location = New System.Drawing.Point(61, 172)
        Me.btnBorrarTM.Name = "btnBorrarTM"
        Me.btnBorrarTM.Size = New System.Drawing.Size(159, 31)
        Me.btnBorrarTM.TabIndex = 2
        Me.btnBorrarTM.Text = "Borrar"
        Me.btnBorrarTM.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(100, 51)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(89, 20)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ingresar ID"
        '
        'frmBorrarTM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(354, 366)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxBorrarTM)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBorrarTM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Borrar Tipo Mueble"
        Me.gbxBorrarTM.ResumeLayout(False)
        Me.gbxBorrarTM.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxBorrarTM As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrarTM As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnLista As System.Windows.Forms.Button
End Class
