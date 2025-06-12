<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHojaDeRuta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHojaDeRuta))
        Me.lblCamion = New System.Windows.Forms.Label()
        Me.lblIdHoja = New System.Windows.Forms.Label()
        Me.lblPedido = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblFechaSalida = New System.Windows.Forms.Label()
        Me.lblApellidoCliente = New System.Windows.Forms.Label()
        Me.lblPedido2 = New System.Windows.Forms.Label()
        Me.lblNombreCliente2 = New System.Windows.Forms.Label()
        Me.lblApellidoCliente2 = New System.Windows.Forms.Label()
        Me.lblDireccion2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCamion
        '
        Me.lblCamion.AutoSize = True
        Me.lblCamion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCamion.Location = New System.Drawing.Point(64, 103)
        Me.lblCamion.Name = "lblCamion"
        Me.lblCamion.Size = New System.Drawing.Size(42, 13)
        Me.lblCamion.TabIndex = 0
        Me.lblCamion.Text = "Camion"
        '
        'lblIdHoja
        '
        Me.lblIdHoja.AutoSize = True
        Me.lblIdHoja.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIdHoja.Location = New System.Drawing.Point(272, 84)
        Me.lblIdHoja.Name = "lblIdHoja"
        Me.lblIdHoja.Size = New System.Drawing.Size(46, 13)
        Me.lblIdHoja.TabIndex = 0
        Me.lblIdHoja.Text = "NroHoja"
        '
        'lblPedido
        '
        Me.lblPedido.AutoSize = True
        Me.lblPedido.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPedido.Location = New System.Drawing.Point(21, 234)
        Me.lblPedido.Name = "lblPedido"
        Me.lblPedido.Size = New System.Drawing.Size(57, 13)
        Me.lblPedido.TabIndex = 0
        Me.lblPedido.Text = "NroPedido"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCliente.Location = New System.Drawing.Point(116, 210)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(76, 13)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "NombreCliente"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDireccion.Location = New System.Drawing.Point(328, 234)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(89, 13)
        Me.lblDireccion.TabIndex = 0
        Me.lblDireccion.Text = "DireccionEntrega"
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.AutoSize = True
        Me.lblFechaSalida.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFechaSalida.Location = New System.Drawing.Point(436, 84)
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Size = New System.Drawing.Size(66, 13)
        Me.lblFechaSalida.TabIndex = 0
        Me.lblFechaSalida.Text = "FechaSalida"
        '
        'lblApellidoCliente
        '
        Me.lblApellidoCliente.AutoSize = True
        Me.lblApellidoCliente.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblApellidoCliente.Location = New System.Drawing.Point(116, 253)
        Me.lblApellidoCliente.Name = "lblApellidoCliente"
        Me.lblApellidoCliente.Size = New System.Drawing.Size(76, 13)
        Me.lblApellidoCliente.TabIndex = 0
        Me.lblApellidoCliente.Text = "ApellidoCliente"
        '
        'lblPedido2
        '
        Me.lblPedido2.AutoSize = True
        Me.lblPedido2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPedido2.Location = New System.Drawing.Point(21, 327)
        Me.lblPedido2.Name = "lblPedido2"
        Me.lblPedido2.Size = New System.Drawing.Size(0, 13)
        Me.lblPedido2.TabIndex = 0
        '
        'lblNombreCliente2
        '
        Me.lblNombreCliente2.AutoSize = True
        Me.lblNombreCliente2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombreCliente2.Location = New System.Drawing.Point(116, 312)
        Me.lblNombreCliente2.Name = "lblNombreCliente2"
        Me.lblNombreCliente2.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreCliente2.TabIndex = 0
        '
        'lblApellidoCliente2
        '
        Me.lblApellidoCliente2.AutoSize = True
        Me.lblApellidoCliente2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblApellidoCliente2.Location = New System.Drawing.Point(116, 343)
        Me.lblApellidoCliente2.Name = "lblApellidoCliente2"
        Me.lblApellidoCliente2.Size = New System.Drawing.Size(0, 13)
        Me.lblApellidoCliente2.TabIndex = 0
        '
        'lblDireccion2
        '
        Me.lblDireccion2.AutoSize = True
        Me.lblDireccion2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDireccion2.Location = New System.Drawing.Point(328, 327)
        Me.lblDireccion2.Name = "lblDireccion2"
        Me.lblDireccion2.Size = New System.Drawing.Size(0, 13)
        Me.lblDireccion2.TabIndex = 0
        '
        'frmHojaDeRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(530, 671)
        Me.Controls.Add(Me.lblIdHoja)
        Me.Controls.Add(Me.lblDireccion2)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblApellidoCliente2)
        Me.Controls.Add(Me.lblApellidoCliente)
        Me.Controls.Add(Me.lblNombreCliente2)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblPedido2)
        Me.Controls.Add(Me.lblPedido)
        Me.Controls.Add(Me.lblFechaSalida)
        Me.Controls.Add(Me.lblCamion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHojaDeRuta"
        Me.Text = "Le Pine - Hoja de Ruta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCamion As System.Windows.Forms.Label
    Friend WithEvents lblIdHoja As System.Windows.Forms.Label
    Friend WithEvents lblPedido As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblFechaSalida As System.Windows.Forms.Label
    Friend WithEvents lblApellidoCliente As System.Windows.Forms.Label
    Friend WithEvents lblPedido2 As System.Windows.Forms.Label
    Friend WithEvents lblNombreCliente2 As System.Windows.Forms.Label
    Friend WithEvents lblApellidoCliente2 As System.Windows.Forms.Label
    Friend WithEvents lblDireccion2 As System.Windows.Forms.Label
End Class
