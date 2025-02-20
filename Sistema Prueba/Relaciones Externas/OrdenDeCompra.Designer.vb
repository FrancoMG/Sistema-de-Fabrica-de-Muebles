<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenDeCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdenDeCompra))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNumProveedor = New System.Windows.Forms.Label()
        Me.lblNombreProveedor = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblFechaPedido = New System.Windows.Forms.Label()
        Me.lblFechaEntrega = New System.Windows.Forms.Label()
        Me.lblCantidad1 = New System.Windows.Forms.Label()
        Me.lblCantidad2 = New System.Windows.Forms.Label()
        Me.lblCantidad3 = New System.Windows.Forms.Label()
        Me.lblCantidad4 = New System.Windows.Forms.Label()
        Me.lblDescripcion1 = New System.Windows.Forms.Label()
        Me.lblDepartamento2 = New System.Windows.Forms.Label()
        Me.lblDescripcion2 = New System.Windows.Forms.Label()
        Me.lblDescripcion3 = New System.Windows.Forms.Label()
        Me.lblDescripcion4 = New System.Windows.Forms.Label()
        Me.lblPrecio1 = New System.Windows.Forms.Label()
        Me.lblPrecio2 = New System.Windows.Forms.Label()
        Me.lblPrecio3 = New System.Windows.Forms.Label()
        Me.lblPrecio4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(663, 755)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblNumProveedor
        '
        Me.lblNumProveedor.AutoSize = True
        Me.lblNumProveedor.Location = New System.Drawing.Point(166, 110)
        Me.lblNumProveedor.Name = "lblNumProveedor"
        Me.lblNumProveedor.Size = New System.Drawing.Size(78, 13)
        Me.lblNumProveedor.TabIndex = 1
        Me.lblNumProveedor.Text = "NumProveedor"
        '
        'lblNombreProveedor
        '
        Me.lblNombreProveedor.AutoSize = True
        Me.lblNombreProveedor.Location = New System.Drawing.Point(428, 110)
        Me.lblNombreProveedor.Name = "lblNombreProveedor"
        Me.lblNombreProveedor.Size = New System.Drawing.Size(93, 13)
        Me.lblNombreProveedor.TabIndex = 1
        Me.lblNombreProveedor.Text = "NombreProveedor"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTelefono.Location = New System.Drawing.Point(451, 169)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 1
        Me.lblTelefono.Text = "Telefono"
        '
        'lblDomicilio
        '
        Me.lblDomicilio.AutoSize = True
        Me.lblDomicilio.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDomicilio.Location = New System.Drawing.Point(167, 169)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.lblDomicilio.TabIndex = 1
        Me.lblDomicilio.Text = "Domicilio"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDepartamento.Location = New System.Drawing.Point(226, 227)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamento.TabIndex = 1
        Me.lblDepartamento.Text = "Departamento"
        '
        'lblFechaPedido
        '
        Me.lblFechaPedido.AutoSize = True
        Me.lblFechaPedido.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFechaPedido.Location = New System.Drawing.Point(188, 284)
        Me.lblFechaPedido.Name = "lblFechaPedido"
        Me.lblFechaPedido.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaPedido.TabIndex = 1
        Me.lblFechaPedido.Text = "FechaPedido"
        '
        'lblFechaEntrega
        '
        Me.lblFechaEntrega.AutoSize = True
        Me.lblFechaEntrega.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFechaEntrega.Location = New System.Drawing.Point(461, 284)
        Me.lblFechaEntrega.Name = "lblFechaEntrega"
        Me.lblFechaEntrega.Size = New System.Drawing.Size(74, 13)
        Me.lblFechaEntrega.TabIndex = 1
        Me.lblFechaEntrega.Text = "FechaEntrega"
        '
        'lblCantidad1
        '
        Me.lblCantidad1.AutoSize = True
        Me.lblCantidad1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCantidad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad1.Location = New System.Drawing.Point(29, 450)
        Me.lblCantidad1.Name = "lblCantidad1"
        Me.lblCantidad1.Size = New System.Drawing.Size(42, 12)
        Me.lblCantidad1.TabIndex = 2
        Me.lblCantidad1.Text = "Cantidad"
        '
        'lblCantidad2
        '
        Me.lblCantidad2.AutoSize = True
        Me.lblCantidad2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCantidad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad2.Location = New System.Drawing.Point(29, 462)
        Me.lblCantidad2.Name = "lblCantidad2"
        Me.lblCantidad2.Size = New System.Drawing.Size(0, 12)
        Me.lblCantidad2.TabIndex = 3
        '
        'lblCantidad3
        '
        Me.lblCantidad3.AutoSize = True
        Me.lblCantidad3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCantidad3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad3.Location = New System.Drawing.Point(29, 479)
        Me.lblCantidad3.Name = "lblCantidad3"
        Me.lblCantidad3.Size = New System.Drawing.Size(0, 12)
        Me.lblCantidad3.TabIndex = 4
        '
        'lblCantidad4
        '
        Me.lblCantidad4.AutoSize = True
        Me.lblCantidad4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCantidad4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad4.Location = New System.Drawing.Point(29, 496)
        Me.lblCantidad4.Name = "lblCantidad4"
        Me.lblCantidad4.Size = New System.Drawing.Size(0, 12)
        Me.lblCantidad4.TabIndex = 5
        '
        'lblDescripcion1
        '
        Me.lblDescripcion1.AutoSize = True
        Me.lblDescripcion1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDescripcion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion1.Location = New System.Drawing.Point(255, 450)
        Me.lblDescripcion1.Name = "lblDescripcion1"
        Me.lblDescripcion1.Size = New System.Drawing.Size(54, 12)
        Me.lblDescripcion1.TabIndex = 6
        Me.lblDescripcion1.Text = "Descripcion"
        '
        'lblDepartamento2
        '
        Me.lblDepartamento2.AutoSize = True
        Me.lblDepartamento2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDepartamento2.Location = New System.Drawing.Point(60, 697)
        Me.lblDepartamento2.Name = "lblDepartamento2"
        Me.lblDepartamento2.Size = New System.Drawing.Size(74, 13)
        Me.lblDepartamento2.TabIndex = 1
        Me.lblDepartamento2.Text = "Departamento"
        '
        'lblDescripcion2
        '
        Me.lblDescripcion2.AutoSize = True
        Me.lblDescripcion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion2.Location = New System.Drawing.Point(205, 462)
        Me.lblDescripcion2.Name = "lblDescripcion2"
        Me.lblDescripcion2.Size = New System.Drawing.Size(0, 12)
        Me.lblDescripcion2.TabIndex = 7
        '
        'lblDescripcion3
        '
        Me.lblDescripcion3.AutoSize = True
        Me.lblDescripcion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion3.Location = New System.Drawing.Point(208, 478)
        Me.lblDescripcion3.Name = "lblDescripcion3"
        Me.lblDescripcion3.Size = New System.Drawing.Size(0, 12)
        Me.lblDescripcion3.TabIndex = 8
        '
        'lblDescripcion4
        '
        Me.lblDescripcion4.AutoSize = True
        Me.lblDescripcion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion4.Location = New System.Drawing.Point(208, 495)
        Me.lblDescripcion4.Name = "lblDescripcion4"
        Me.lblDescripcion4.Size = New System.Drawing.Size(0, 12)
        Me.lblDescripcion4.TabIndex = 9
        '
        'lblPrecio1
        '
        Me.lblPrecio1.AutoSize = True
        Me.lblPrecio1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrecio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio1.Location = New System.Drawing.Point(535, 450)
        Me.lblPrecio1.Name = "lblPrecio1"
        Me.lblPrecio1.Size = New System.Drawing.Size(36, 12)
        Me.lblPrecio1.TabIndex = 6
        Me.lblPrecio1.Text = "Precio1"
        '
        'lblPrecio2
        '
        Me.lblPrecio2.AutoSize = True
        Me.lblPrecio2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrecio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio2.Location = New System.Drawing.Point(535, 462)
        Me.lblPrecio2.Name = "lblPrecio2"
        Me.lblPrecio2.Size = New System.Drawing.Size(0, 12)
        Me.lblPrecio2.TabIndex = 6
        '
        'lblPrecio3
        '
        Me.lblPrecio3.AutoSize = True
        Me.lblPrecio3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrecio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio3.Location = New System.Drawing.Point(535, 479)
        Me.lblPrecio3.Name = "lblPrecio3"
        Me.lblPrecio3.Size = New System.Drawing.Size(0, 12)
        Me.lblPrecio3.TabIndex = 6
        '
        'lblPrecio4
        '
        Me.lblPrecio4.AutoSize = True
        Me.lblPrecio4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrecio4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio4.Location = New System.Drawing.Point(535, 496)
        Me.lblPrecio4.Name = "lblPrecio4"
        Me.lblPrecio4.Size = New System.Drawing.Size(0, 12)
        Me.lblPrecio4.TabIndex = 6
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(604, 495)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 12)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "TOTAL"
        '
        'OrdenDeCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 742)
        Me.Controls.Add(Me.lblDescripcion4)
        Me.Controls.Add(Me.lblDescripcion3)
        Me.Controls.Add(Me.lblDescripcion2)
        Me.Controls.Add(Me.lblPrecio4)
        Me.Controls.Add(Me.lblPrecio3)
        Me.Controls.Add(Me.lblPrecio2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblPrecio1)
        Me.Controls.Add(Me.lblDescripcion1)
        Me.Controls.Add(Me.lblCantidad4)
        Me.Controls.Add(Me.lblCantidad3)
        Me.Controls.Add(Me.lblCantidad2)
        Me.Controls.Add(Me.lblCantidad1)
        Me.Controls.Add(Me.lblFechaEntrega)
        Me.Controls.Add(Me.lblFechaPedido)
        Me.Controls.Add(Me.lblDepartamento2)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.lblDomicilio)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblNombreProveedor)
        Me.Controls.Add(Me.lblNumProveedor)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OrdenDeCompra"
        Me.Text = "Le Pine - Orden De Compra"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblNumProveedor As System.Windows.Forms.Label
    Friend WithEvents lblNombreProveedor As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblDomicilio As System.Windows.Forms.Label
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblFechaPedido As System.Windows.Forms.Label
    Friend WithEvents lblFechaEntrega As System.Windows.Forms.Label
    Friend WithEvents lblCantidad1 As System.Windows.Forms.Label
    Friend WithEvents lblCantidad2 As System.Windows.Forms.Label
    Friend WithEvents lblCantidad3 As System.Windows.Forms.Label
    Friend WithEvents lblCantidad4 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion1 As System.Windows.Forms.Label
    Friend WithEvents lblDepartamento2 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion2 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion3 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion4 As System.Windows.Forms.Label
    Friend WithEvents lblPrecio1 As System.Windows.Forms.Label
    Friend WithEvents lblPrecio2 As System.Windows.Forms.Label
    Friend WithEvents lblPrecio3 As System.Windows.Forms.Label
    Friend WithEvents lblPrecio4 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
