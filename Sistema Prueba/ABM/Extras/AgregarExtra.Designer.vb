<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarExtra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarExtra))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxAgregarExtra = New System.Windows.Forms.GroupBox()
        Me.txtPP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnAgregarExtra = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.gbxAgregarExtra.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(42, 494)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(248, 31)
        Me.btnVolverMenuABM.TabIndex = 13
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxAgregarExtra
        '
        Me.gbxAgregarExtra.Controls.Add(Me.txtPP)
        Me.gbxAgregarExtra.Controls.Add(Me.Label1)
        Me.gbxAgregarExtra.Controls.Add(Me.txtStock)
        Me.gbxAgregarExtra.Controls.Add(Me.lblStock)
        Me.gbxAgregarExtra.Controls.Add(Me.txtPrecio)
        Me.gbxAgregarExtra.Controls.Add(Me.lblPrecio)
        Me.gbxAgregarExtra.Controls.Add(Me.txtDescripcion)
        Me.gbxAgregarExtra.Controls.Add(Me.btnAgregarExtra)
        Me.gbxAgregarExtra.Controls.Add(Me.lblDescripcion)
        Me.gbxAgregarExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAgregarExtra.Location = New System.Drawing.Point(31, 34)
        Me.gbxAgregarExtra.Name = "gbxAgregarExtra"
        Me.gbxAgregarExtra.Size = New System.Drawing.Size(277, 429)
        Me.gbxAgregarExtra.TabIndex = 12
        Me.gbxAgregarExtra.TabStop = False
        Me.gbxAgregarExtra.Text = "Extra"
        '
        'txtPP
        '
        Me.txtPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPP.Location = New System.Drawing.Point(36, 312)
        Me.txtPP.Name = "txtPP"
        Me.txtPP.Size = New System.Drawing.Size(211, 20)
        Me.txtPP.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ingresar Punto de Pedido"
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(36, 232)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(211, 20)
        Me.txtStock.TabIndex = 7
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(83, 200)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(113, 20)
        Me.lblStock.TabIndex = 6
        Me.lblStock.Text = "Ingresar Stock"
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(36, 155)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(211, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(53, 123)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(182, 20)
        Me.lblPrecio.TabIndex = 4
        Me.lblPrecio.Text = "Ingresar Precio x Unidad"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(36, 81)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(211, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'btnAgregarExtra
        '
        Me.btnAgregarExtra.Location = New System.Drawing.Point(62, 368)
        Me.btnAgregarExtra.Name = "btnAgregarExtra"
        Me.btnAgregarExtra.Size = New System.Drawing.Size(159, 31)
        Me.btnAgregarExtra.TabIndex = 2
        Me.btnAgregarExtra.Text = "Agregar"
        Me.btnAgregarExtra.UseVisualStyleBackColor = True
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(66, 49)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(155, 20)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Ingresar Descripcion"
        '
        'frmAgregarExtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(337, 553)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxAgregarExtra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarExtra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine- Agregar extra"
        Me.gbxAgregarExtra.ResumeLayout(False)
        Me.gbxAgregarExtra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxAgregarExtra As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarExtra As System.Windows.Forms.Button
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents txtPP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
