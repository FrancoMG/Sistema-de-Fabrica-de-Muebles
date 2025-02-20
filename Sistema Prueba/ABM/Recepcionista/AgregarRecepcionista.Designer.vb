<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarRecepcionista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarRecepcionista))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxAgregarRecepcionista = New System.Windows.Forms.GroupBox()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnAgregarRecepcionista = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.gbxAgregarRecepcionista.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(60, 299)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(244, 31)
        Me.btnVolverMenuABM.TabIndex = 5
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxAgregarRecepcionista
        '
        Me.gbxAgregarRecepcionista.Controls.Add(Me.btnLista)
        Me.gbxAgregarRecepcionista.Controls.Add(Me.txtID)
        Me.gbxAgregarRecepcionista.Controls.Add(Me.btnAgregarRecepcionista)
        Me.gbxAgregarRecepcionista.Controls.Add(Me.lblID)
        Me.gbxAgregarRecepcionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAgregarRecepcionista.Location = New System.Drawing.Point(38, 39)
        Me.gbxAgregarRecepcionista.Name = "gbxAgregarRecepcionista"
        Me.gbxAgregarRecepcionista.Size = New System.Drawing.Size(279, 226)
        Me.gbxAgregarRecepcionista.TabIndex = 4
        Me.gbxAgregarRecepcionista.TabStop = False
        Me.gbxAgregarRecepcionista.Text = "Recepcionista"
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(86, 118)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(120, 29)
        Me.btnLista.TabIndex = 11
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
        'btnAgregarRecepcionista
        '
        Me.btnAgregarRecepcionista.Location = New System.Drawing.Point(61, 172)
        Me.btnAgregarRecepcionista.Name = "btnAgregarRecepcionista"
        Me.btnAgregarRecepcionista.Size = New System.Drawing.Size(159, 31)
        Me.btnAgregarRecepcionista.TabIndex = 2
        Me.btnAgregarRecepcionista.Text = "Agregar"
        Me.btnAgregarRecepcionista.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(61, 39)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(189, 20)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ingresar ID de la persona"
        '
        'frmAgregarRecepcionista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(355, 369)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxAgregarRecepcionista)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarRecepcionista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Agregar recepcionista"
        Me.gbxAgregarRecepcionista.ResumeLayout(False)
        Me.gbxAgregarRecepcionista.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxAgregarRecepcionista As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarRecepcionista As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnLista As System.Windows.Forms.Button
End Class
