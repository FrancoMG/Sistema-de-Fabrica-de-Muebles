<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarMM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarMM))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxAgregarMM = New System.Windows.Forms.GroupBox()
        Me.txtPP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnAgregarMM = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.gbxAgregarMM.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(44, 441)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(244, 31)
        Me.btnVolverMenuABM.TabIndex = 13
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxAgregarMM
        '
        Me.gbxAgregarMM.Controls.Add(Me.txtPP)
        Me.gbxAgregarMM.Controls.Add(Me.Label2)
        Me.gbxAgregarMM.Controls.Add(Me.txtStock)
        Me.gbxAgregarMM.Controls.Add(Me.Label1)
        Me.gbxAgregarMM.Controls.Add(Me.txtDescripcion)
        Me.gbxAgregarMM.Controls.Add(Me.btnAgregarMM)
        Me.gbxAgregarMM.Controls.Add(Me.lblDescripcion)
        Me.gbxAgregarMM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAgregarMM.Location = New System.Drawing.Point(26, 29)
        Me.gbxAgregarMM.Name = "gbxAgregarMM"
        Me.gbxAgregarMM.Size = New System.Drawing.Size(279, 380)
        Me.gbxAgregarMM.TabIndex = 12
        Me.gbxAgregarMM.TabStop = False
        Me.gbxAgregarMM.Text = "Material de Montaje"
        '
        'txtPP
        '
        Me.txtPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPP.Location = New System.Drawing.Point(39, 258)
        Me.txtPP.Name = "txtPP"
        Me.txtPP.Size = New System.Drawing.Size(211, 20)
        Me.txtPP.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ingresar Punto de Pedido"
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(39, 167)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(211, 20)
        Me.txtStock.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingresar Stock"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(39, 84)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(211, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'btnAgregarMM
        '
        Me.btnAgregarMM.Location = New System.Drawing.Point(61, 319)
        Me.btnAgregarMM.Name = "btnAgregarMM"
        Me.btnAgregarMM.Size = New System.Drawing.Size(159, 31)
        Me.btnAgregarMM.TabIndex = 2
        Me.btnAgregarMM.Text = "Agregar"
        Me.btnAgregarMM.UseVisualStyleBackColor = True
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(65, 52)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(155, 20)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Ingresar Descripcion"
        '
        'frmAgregarMM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(334, 510)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxAgregarMM)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarMM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Agregar Material de Montaje"
        Me.gbxAgregarMM.ResumeLayout(False)
        Me.gbxAgregarMM.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxAgregarMM As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarMM As System.Windows.Forms.Button
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
