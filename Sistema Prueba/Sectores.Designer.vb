<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSectores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSectores))
        Me.btnABM = New System.Windows.Forms.Button()
        Me.btnLaboresAdm = New System.Windows.Forms.Button()
        Me.btnRE = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDia = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnPedido = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnABM
        '
        Me.btnABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnABM.Location = New System.Drawing.Point(307, 110)
        Me.btnABM.Name = "btnABM"
        Me.btnABM.Size = New System.Drawing.Size(127, 69)
        Me.btnABM.TabIndex = 1
        Me.btnABM.Text = "ABM"
        Me.btnABM.UseVisualStyleBackColor = True
        '
        'btnLaboresAdm
        '
        Me.btnLaboresAdm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaboresAdm.Location = New System.Drawing.Point(163, 110)
        Me.btnLaboresAdm.Name = "btnLaboresAdm"
        Me.btnLaboresAdm.Size = New System.Drawing.Size(127, 69)
        Me.btnLaboresAdm.TabIndex = 2
        Me.btnLaboresAdm.Text = "Labores administrativas"
        Me.btnLaboresAdm.UseVisualStyleBackColor = True
        '
        'btnRE
        '
        Me.btnRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRE.Location = New System.Drawing.Point(21, 110)
        Me.btnRE.Name = "btnRE"
        Me.btnRE.Size = New System.Drawing.Size(127, 69)
        Me.btnRE.TabIndex = 3
        Me.btnRE.Text = "Relaciones externas"
        Me.btnRE.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(267, 323)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'lblDia
        '
        Me.lblDia.AutoSize = True
        Me.lblDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDia.Location = New System.Drawing.Point(107, 357)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(44, 25)
        Me.lblDia.TabIndex = 9
        Me.lblDia.Text = "Dia"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(22, 20)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(64, 20)
        Me.lblUsuario.TabIndex = 8
        Me.lblUsuario.Text = "Usuario"
        '
        'btnPedido
        '
        Me.btnPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedido.Location = New System.Drawing.Point(163, 21)
        Me.btnPedido.Name = "btnPedido"
        Me.btnPedido.Size = New System.Drawing.Size(127, 69)
        Me.btnPedido.TabIndex = 0
        Me.btnPedido.Text = "Realizar pedido"
        Me.btnPedido.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(22, 21)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(126, 69)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir del sistema"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.Location = New System.Drawing.Point(307, 21)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(127, 69)
        Me.btnUsuario.TabIndex = 7
        Me.btnUsuario.Text = "Administrar Usuarios"
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Goldenrod
        Me.GroupBox1.Controls.Add(Me.btnUsuario)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnRE)
        Me.GroupBox1.Controls.Add(Me.btnLaboresAdm)
        Me.GroupBox1.Controls.Add(Me.btnABM)
        Me.GroupBox1.Controls.Add(Me.btnPedido)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(56, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 195)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(216, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 33)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Sectores"
        '
        'frmSectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(566, 447)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblDia)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSectores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Sectores"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnABM As System.Windows.Forms.Button
    Friend WithEvents btnLaboresAdm As System.Windows.Forms.Button
    Friend WithEvents btnRE As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDia As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents btnPedido As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnUsuario As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
