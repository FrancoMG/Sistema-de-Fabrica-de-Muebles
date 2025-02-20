<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarMM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrarMM))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxAgregarMM = New System.Windows.Forms.GroupBox()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnBorrarMM = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.gbxAgregarMM.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(50, 289)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(244, 31)
        Me.btnVolverMenuABM.TabIndex = 15
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxAgregarMM
        '
        Me.gbxAgregarMM.Controls.Add(Me.btnLista)
        Me.gbxAgregarMM.Controls.Add(Me.txtID)
        Me.gbxAgregarMM.Controls.Add(Me.btnBorrarMM)
        Me.gbxAgregarMM.Controls.Add(Me.lblID)
        Me.gbxAgregarMM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAgregarMM.Location = New System.Drawing.Point(28, 29)
        Me.gbxAgregarMM.Name = "gbxAgregarMM"
        Me.gbxAgregarMM.Size = New System.Drawing.Size(279, 226)
        Me.gbxAgregarMM.TabIndex = 14
        Me.gbxAgregarMM.TabStop = False
        Me.gbxAgregarMM.Text = "Material de Montaje"
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(83, 121)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(120, 29)
        Me.btnLista.TabIndex = 8
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
        'btnBorrarMM
        '
        Me.btnBorrarMM.Location = New System.Drawing.Point(61, 172)
        Me.btnBorrarMM.Name = "btnBorrarMM"
        Me.btnBorrarMM.Size = New System.Drawing.Size(159, 31)
        Me.btnBorrarMM.TabIndex = 2
        Me.btnBorrarMM.Text = "Borrar"
        Me.btnBorrarMM.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(99, 52)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(89, 20)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ingresar ID"
        '
        'frmBorrarMM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(335, 362)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxAgregarMM)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBorrarMM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Borrar Material de montaje"
        Me.gbxAgregarMM.ResumeLayout(False)
        Me.gbxAgregarMM.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxAgregarMM As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrarMM As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnLista As System.Windows.Forms.Button
End Class
