<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrilla))
        Me.dgvListaPrecios = New System.Windows.Forms.DataGridView()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pbLePine1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvListaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLePine1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListaPrecios
        '
        Me.dgvListaPrecios.AllowUserToAddRows = False
        Me.dgvListaPrecios.AllowUserToDeleteRows = False
        Me.dgvListaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedor, Me.NombreProveedor, Me.IdProducto, Me.NombreProducto, Me.Precio})
        Me.dgvListaPrecios.Location = New System.Drawing.Point(12, 12)
        Me.dgvListaPrecios.Name = "dgvListaPrecios"
        Me.dgvListaPrecios.ReadOnly = True
        Me.dgvListaPrecios.Size = New System.Drawing.Size(548, 175)
        Me.dgvListaPrecios.TabIndex = 0
        '
        'IdProveedor
        '
        Me.IdProveedor.HeaderText = "CodigoProveedor"
        Me.IdProveedor.Name = "IdProveedor"
        Me.IdProveedor.ReadOnly = True
        '
        'NombreProveedor
        '
        Me.NombreProveedor.HeaderText = "NombreProveedor"
        Me.NombreProveedor.Name = "NombreProveedor"
        Me.NombreProveedor.ReadOnly = True
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "CodigoProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        '
        'NombreProducto
        '
        Me.NombreProducto.HeaderText = "NombreProducto"
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(79, 217)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(161, 28)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'pbLePine1
        '
        Me.pbLePine1.Image = CType(resources.GetObject("pbLePine1.Image"), System.Drawing.Image)
        Me.pbLePine1.Location = New System.Drawing.Point(335, 192)
        Me.pbLePine1.Name = "pbLePine1"
        Me.pbLePine1.Size = New System.Drawing.Size(225, 79)
        Me.pbLePine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLePine1.TabIndex = 2
        Me.pbLePine1.TabStop = False
        '
        'frmGrilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(577, 283)
        Me.Controls.Add(Me.pbLePine1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgvListaPrecios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGrilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Lista 2"
        CType(Me.dgvListaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLePine1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvListaPrecios As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents pbLePine1 As System.Windows.Forms.PictureBox
    Friend WithEvents IdProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
