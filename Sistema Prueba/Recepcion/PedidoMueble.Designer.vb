<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidoMueble
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidoMueble))
        Me.lblDatosMueble = New System.Windows.Forms.Label()
        Me.lblTipoMueble = New System.Windows.Forms.Label()
        Me.lblMaderaMueble = New System.Windows.Forms.Label()
        Me.cmbTipoMueble = New System.Windows.Forms.ComboBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnIngresarMueble = New System.Windows.Forms.Button()
        Me.cmbMaderaMueble = New System.Windows.Forms.ComboBox()
        Me.cmbMaderaMueble2 = New System.Windows.Forms.ComboBox()
        Me.btnAgregarPedido = New System.Windows.Forms.Button()
        Me.lblCM2 = New System.Windows.Forms.Label()
        Me.txtCM2 = New System.Windows.Forms.TextBox()
        Me.btnAgregarMadera = New System.Windows.Forms.Button()
        Me.lblCM2_2 = New System.Windows.Forms.Label()
        Me.txtCM2_2 = New System.Windows.Forms.TextBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.chkAgregarExtra = New System.Windows.Forms.CheckBox()
        Me.cmbExtra = New System.Windows.Forms.ComboBox()
        Me.lblCantidad2 = New System.Windows.Forms.Label()
        Me.txtCantidad2 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDatosMueble
        '
        Me.lblDatosMueble.AutoSize = True
        Me.lblDatosMueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosMueble.Location = New System.Drawing.Point(83, 24)
        Me.lblDatosMueble.Name = "lblDatosMueble"
        Me.lblDatosMueble.Size = New System.Drawing.Size(257, 24)
        Me.lblDatosMueble.TabIndex = 0
        Me.lblDatosMueble.Text = "Ingresar los datos del mueble"
        '
        'lblTipoMueble
        '
        Me.lblTipoMueble.AutoSize = True
        Me.lblTipoMueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoMueble.Location = New System.Drawing.Point(55, 77)
        Me.lblTipoMueble.Name = "lblTipoMueble"
        Me.lblTipoMueble.Size = New System.Drawing.Size(109, 18)
        Me.lblTipoMueble.TabIndex = 1
        Me.lblTipoMueble.Text = "Tipo de Mueble"
        '
        'lblMaderaMueble
        '
        Me.lblMaderaMueble.AutoSize = True
        Me.lblMaderaMueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaderaMueble.Location = New System.Drawing.Point(31, 125)
        Me.lblMaderaMueble.Name = "lblMaderaMueble"
        Me.lblMaderaMueble.Size = New System.Drawing.Size(133, 18)
        Me.lblMaderaMueble.TabIndex = 2
        Me.lblMaderaMueble.Text = "Madera del Mueble"
        '
        'cmbTipoMueble
        '
        Me.cmbTipoMueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoMueble.FormattingEnabled = True
        Me.cmbTipoMueble.Location = New System.Drawing.Point(170, 78)
        Me.cmbTipoMueble.Name = "cmbTipoMueble"
        Me.cmbTipoMueble.Size = New System.Drawing.Size(170, 21)
        Me.cmbTipoMueble.TabIndex = 3
        '
        'btnAtras
        '
        Me.btnAtras.Enabled = False
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(12, 487)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(69, 30)
        Me.btnAtras.TabIndex = 4
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnIngresarMueble
        '
        Me.btnIngresarMueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarMueble.Location = New System.Drawing.Point(316, 487)
        Me.btnIngresarMueble.Name = "btnIngresarMueble"
        Me.btnIngresarMueble.Size = New System.Drawing.Size(69, 30)
        Me.btnIngresarMueble.TabIndex = 5
        Me.btnIngresarMueble.Text = "Ingresar"
        Me.btnIngresarMueble.UseVisualStyleBackColor = True
        '
        'cmbMaderaMueble
        '
        Me.cmbMaderaMueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaderaMueble.FormattingEnabled = True
        Me.cmbMaderaMueble.Location = New System.Drawing.Point(170, 125)
        Me.cmbMaderaMueble.Name = "cmbMaderaMueble"
        Me.cmbMaderaMueble.Size = New System.Drawing.Size(170, 21)
        Me.cmbMaderaMueble.TabIndex = 6
        '
        'cmbMaderaMueble2
        '
        Me.cmbMaderaMueble2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaderaMueble2.FormattingEnabled = True
        Me.cmbMaderaMueble2.Location = New System.Drawing.Point(170, 202)
        Me.cmbMaderaMueble2.Name = "cmbMaderaMueble2"
        Me.cmbMaderaMueble2.Size = New System.Drawing.Size(170, 21)
        Me.cmbMaderaMueble2.TabIndex = 8
        Me.cmbMaderaMueble2.Visible = False
        '
        'btnAgregarPedido
        '
        Me.btnAgregarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPedido.Location = New System.Drawing.Point(128, 487)
        Me.btnAgregarPedido.Name = "btnAgregarPedido"
        Me.btnAgregarPedido.Size = New System.Drawing.Size(151, 30)
        Me.btnAgregarPedido.TabIndex = 9
        Me.btnAgregarPedido.Text = "Calcular presupuesto"
        Me.btnAgregarPedido.UseVisualStyleBackColor = True
        Me.btnAgregarPedido.Visible = False
        '
        'lblCM2
        '
        Me.lblCM2.AutoSize = True
        Me.lblCM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCM2.Location = New System.Drawing.Point(9, 237)
        Me.lblCM2.Name = "lblCM2"
        Me.lblCM2.Size = New System.Drawing.Size(155, 36)
        Me.lblCM2.TabIndex = 10
        Me.lblCM2.Text = "                Centímetros" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cuadrados necesarios"
        '
        'txtCM2
        '
        Me.txtCM2.Location = New System.Drawing.Point(170, 253)
        Me.txtCM2.MaxLength = 8
        Me.txtCM2.Name = "txtCM2"
        Me.txtCM2.Size = New System.Drawing.Size(170, 20)
        Me.txtCM2.TabIndex = 11
        '
        'btnAgregarMadera
        '
        Me.btnAgregarMadera.Enabled = False
        Me.btnAgregarMadera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarMadera.Location = New System.Drawing.Point(119, 163)
        Me.btnAgregarMadera.Name = "btnAgregarMadera"
        Me.btnAgregarMadera.Size = New System.Drawing.Size(170, 27)
        Me.btnAgregarMadera.TabIndex = 7
        Me.btnAgregarMadera.Text = "Agregar madera"
        Me.btnAgregarMadera.UseVisualStyleBackColor = True
        '
        'lblCM2_2
        '
        Me.lblCM2_2.AutoSize = True
        Me.lblCM2_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCM2_2.Location = New System.Drawing.Point(0, 286)
        Me.lblCM2_2.Name = "lblCM2_2"
        Me.lblCM2_2.Size = New System.Drawing.Size(164, 48)
        Me.lblCM2_2.TabIndex = 12
        Me.lblCM2_2.Text = "Centímetros cuadrados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "necesarios de la segunda" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "madera"
        Me.lblCM2_2.Visible = False
        '
        'txtCM2_2
        '
        Me.txtCM2_2.Location = New System.Drawing.Point(170, 297)
        Me.txtCM2_2.MaxLength = 8
        Me.txtCM2_2.Name = "txtCM2_2"
        Me.txtCM2_2.Size = New System.Drawing.Size(170, 20)
        Me.txtCM2_2.TabIndex = 13
        Me.txtCM2_2.Visible = False
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantidad.Location = New System.Drawing.Point(98, 348)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(66, 18)
        Me.lblcantidad.TabIndex = 14
        Me.lblcantidad.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(170, 349)
        Me.txtCantidad.MaxLength = 4
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(170, 22)
        Me.txtCantidad.TabIndex = 15
        '
        'chkAgregarExtra
        '
        Me.chkAgregarExtra.AutoSize = True
        Me.chkAgregarExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAgregarExtra.Location = New System.Drawing.Point(34, 400)
        Me.chkAgregarExtra.Name = "chkAgregarExtra"
        Me.chkAgregarExtra.Size = New System.Drawing.Size(114, 22)
        Me.chkAgregarExtra.TabIndex = 17
        Me.chkAgregarExtra.Text = "Agregar extra"
        Me.chkAgregarExtra.UseVisualStyleBackColor = True
        '
        'cmbExtra
        '
        Me.cmbExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExtra.FormattingEnabled = True
        Me.cmbExtra.Location = New System.Drawing.Point(170, 401)
        Me.cmbExtra.Name = "cmbExtra"
        Me.cmbExtra.Size = New System.Drawing.Size(170, 21)
        Me.cmbExtra.TabIndex = 18
        Me.cmbExtra.Visible = False
        '
        'lblCantidad2
        '
        Me.lblCantidad2.AutoSize = True
        Me.lblCantidad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad2.Location = New System.Drawing.Point(98, 447)
        Me.lblCantidad2.Name = "lblCantidad2"
        Me.lblCantidad2.Size = New System.Drawing.Size(66, 18)
        Me.lblCantidad2.TabIndex = 19
        Me.lblCantidad2.Text = "Cantidad"
        Me.lblCantidad2.Visible = False
        '
        'txtCantidad2
        '
        Me.txtCantidad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad2.Location = New System.Drawing.Point(170, 446)
        Me.txtCantidad2.MaxLength = 15
        Me.txtCantidad2.Name = "txtCantidad2"
        Me.txtCantidad2.Size = New System.Drawing.Size(170, 22)
        Me.txtCantidad2.TabIndex = 20
        Me.txtCantidad2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(62, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'frmPedidoMueble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(397, 529)
        Me.Controls.Add(Me.txtCantidad2)
        Me.Controls.Add(Me.lblCantidad2)
        Me.Controls.Add(Me.cmbExtra)
        Me.Controls.Add(Me.chkAgregarExtra)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.txtCM2_2)
        Me.Controls.Add(Me.lblCM2_2)
        Me.Controls.Add(Me.txtCM2)
        Me.Controls.Add(Me.lblCM2)
        Me.Controls.Add(Me.btnAgregarPedido)
        Me.Controls.Add(Me.cmbMaderaMueble2)
        Me.Controls.Add(Me.btnAgregarMadera)
        Me.Controls.Add(Me.cmbMaderaMueble)
        Me.Controls.Add(Me.btnIngresarMueble)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.cmbTipoMueble)
        Me.Controls.Add(Me.lblMaderaMueble)
        Me.Controls.Add(Me.lblTipoMueble)
        Me.Controls.Add(Me.lblDatosMueble)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPedidoMueble"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Datos del Mueble"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDatosMueble As System.Windows.Forms.Label
    Friend WithEvents lblTipoMueble As System.Windows.Forms.Label
    Friend WithEvents lblMaderaMueble As System.Windows.Forms.Label
    Friend WithEvents cmbTipoMueble As System.Windows.Forms.ComboBox
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnIngresarMueble As System.Windows.Forms.Button
    Friend WithEvents cmbMaderaMueble As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMaderaMueble2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgregarPedido As System.Windows.Forms.Button
    Friend WithEvents lblCM2 As System.Windows.Forms.Label
    Friend WithEvents txtCM2 As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarMadera As System.Windows.Forms.Button
    Friend WithEvents lblCM2_2 As System.Windows.Forms.Label
    Friend WithEvents txtCM2_2 As System.Windows.Forms.TextBox
    Friend WithEvents lblcantidad As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkAgregarExtra As CheckBox
    Friend WithEvents cmbExtra As ComboBox
    Friend WithEvents lblCantidad2 As Label
    Friend WithEvents txtCantidad2 As TextBox
End Class
