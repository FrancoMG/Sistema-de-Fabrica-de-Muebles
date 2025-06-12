<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarCliente))
        Me.gbxAgregarCliente = New System.Windows.Forms.GroupBox()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxAgregarCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxAgregarCliente
        '
        Me.gbxAgregarCliente.Controls.Add(Me.btnLista)
        Me.gbxAgregarCliente.Controls.Add(Me.txtID)
        Me.gbxAgregarCliente.Controls.Add(Me.btnAgregarCliente)
        Me.gbxAgregarCliente.Controls.Add(Me.lblID)
        Me.gbxAgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAgregarCliente.Location = New System.Drawing.Point(38, 40)
        Me.gbxAgregarCliente.Name = "gbxAgregarCliente"
        Me.gbxAgregarCliente.Size = New System.Drawing.Size(279, 226)
        Me.gbxAgregarCliente.TabIndex = 0
        Me.gbxAgregarCliente.TabStop = False
        Me.gbxAgregarCliente.Text = "Cliente"
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(81, 117)
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
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Location = New System.Drawing.Point(61, 172)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(159, 31)
        Me.btnAgregarCliente.TabIndex = 2
        Me.btnAgregarCliente.Text = "Agregar"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(57, 40)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(189, 20)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ingresar ID de la persona"
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(60, 300)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(244, 31)
        Me.btnVolverMenuABM.TabIndex = 3
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'frmAgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(358, 364)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxAgregarCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Agregar cliente"
        Me.gbxAgregarCliente.ResumeLayout(False)
        Me.gbxAgregarCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxAgregarCliente As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregarCliente As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnLista As System.Windows.Forms.Button

End Class
