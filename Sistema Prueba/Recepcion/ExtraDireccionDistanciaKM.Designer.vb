<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtraDireccionDistanciaKM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExtraDireccionDistanciaKM))
        Me.txtDistanciaKM = New System.Windows.Forms.TextBox()
        Me.lblDistanciaKM = New System.Windows.Forms.Label()
        Me.txtDireccionEntrega = New System.Windows.Forms.TextBox()
        Me.lblDireccionEntrega = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblExplic = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDistanciaKM
        '
        Me.txtDistanciaKM.Location = New System.Drawing.Point(133, 84)
        Me.txtDistanciaKM.MaxLength = 8
        Me.txtDistanciaKM.Name = "txtDistanciaKM"
        Me.txtDistanciaKM.Size = New System.Drawing.Size(170, 20)
        Me.txtDistanciaKM.TabIndex = 18
        '
        'lblDistanciaKM
        '
        Me.lblDistanciaKM.AutoSize = True
        Me.lblDistanciaKM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistanciaKM.Location = New System.Drawing.Point(18, 83)
        Me.lblDistanciaKM.Name = "lblDistanciaKM"
        Me.lblDistanciaKM.Size = New System.Drawing.Size(108, 36)
        Me.lblDistanciaKM.TabIndex = 17
        Me.lblDistanciaKM.Text = "         Distancia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(en kilómetros)"
        '
        'txtDireccionEntrega
        '
        Me.txtDireccionEntrega.Location = New System.Drawing.Point(133, 41)
        Me.txtDireccionEntrega.MaxLength = 40
        Me.txtDireccionEntrega.Name = "txtDireccionEntrega"
        Me.txtDireccionEntrega.Size = New System.Drawing.Size(170, 20)
        Me.txtDireccionEntrega.TabIndex = 15
        '
        'lblDireccionEntrega
        '
        Me.lblDireccionEntrega.AutoSize = True
        Me.lblDireccionEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionEntrega.Location = New System.Drawing.Point(46, 40)
        Me.lblDireccionEntrega.Name = "lblDireccionEntrega"
        Me.lblDireccionEntrega.Size = New System.Drawing.Size(81, 36)
        Me.lblDireccionEntrega.TabIndex = 14
        Me.lblDireccionEntrega.Text = "  Direccion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de entrega"
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(333, 192)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(102, 36)
        Me.btnAceptar.TabIndex = 19
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(12, 192)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 36)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Atrás"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblExplic
        '
        Me.lblExplic.AutoSize = True
        Me.lblExplic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplic.Location = New System.Drawing.Point(132, 114)
        Me.lblExplic.Name = "lblExplic"
        Me.lblExplic.Size = New System.Drawing.Size(164, 45)
        Me.lblExplic.TabIndex = 21
        Me.lblExplic.Text = "La dirección de entrega no" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "puede cambiarse dentro del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mismo pedido"
        Me.lblExplic.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(319, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'frmExtraDireccionDistanciaKM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(447, 240)
        Me.Controls.Add(Me.lblExplic)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtDistanciaKM)
        Me.Controls.Add(Me.lblDistanciaKM)
        Me.Controls.Add(Me.txtDireccionEntrega)
        Me.Controls.Add(Me.lblDireccionEntrega)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmExtraDireccionDistanciaKM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Direccion de Entrega"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDistanciaKM As System.Windows.Forms.TextBox
    Friend WithEvents lblDistanciaKM As System.Windows.Forms.Label
    Friend WithEvents txtDireccionEntrega As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccionEntrega As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblExplic As Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
