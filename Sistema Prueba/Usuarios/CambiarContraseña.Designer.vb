<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambiarContraseña))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblViejaContraseña = New System.Windows.Forms.Label()
        Me.lblNuevaContraseña = New System.Windows.Forms.Label()
        Me.lblConfirmarNuevaContraseña = New System.Windows.Forms.Label()
        Me.cmbNombreUsuario = New System.Windows.Forms.ComboBox()
        Me.txtVC = New System.Windows.Forms.TextBox()
        Me.txtNC = New System.Windows.Forms.TextBox()
        Me.txtCNC = New System.Windows.Forms.TextBox()
        Me.btnCambiarContraseña = New System.Windows.Forms.Button()
        Me.btnVolverUsuario = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(111, 123)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(121, 20)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Nombre usuario"
        '
        'lblViejaContraseña
        '
        Me.lblViejaContraseña.AutoSize = True
        Me.lblViejaContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViejaContraseña.Location = New System.Drawing.Point(104, 152)
        Me.lblViejaContraseña.Name = "lblViejaContraseña"
        Me.lblViejaContraseña.Size = New System.Drawing.Size(128, 20)
        Me.lblViejaContraseña.TabIndex = 1
        Me.lblViejaContraseña.Text = "Vieja contraseña"
        '
        'lblNuevaContraseña
        '
        Me.lblNuevaContraseña.AutoSize = True
        Me.lblNuevaContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevaContraseña.Location = New System.Drawing.Point(94, 181)
        Me.lblNuevaContraseña.Name = "lblNuevaContraseña"
        Me.lblNuevaContraseña.Size = New System.Drawing.Size(138, 20)
        Me.lblNuevaContraseña.TabIndex = 2
        Me.lblNuevaContraseña.Text = "Nueva contraseña"
        '
        'lblConfirmarNuevaContraseña
        '
        Me.lblConfirmarNuevaContraseña.AutoSize = True
        Me.lblConfirmarNuevaContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmarNuevaContraseña.Location = New System.Drawing.Point(23, 210)
        Me.lblConfirmarNuevaContraseña.Name = "lblConfirmarNuevaContraseña"
        Me.lblConfirmarNuevaContraseña.Size = New System.Drawing.Size(209, 20)
        Me.lblConfirmarNuevaContraseña.TabIndex = 3
        Me.lblConfirmarNuevaContraseña.Text = "Confirmar nueva contraseña"
        '
        'cmbNombreUsuario
        '
        Me.cmbNombreUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNombreUsuario.FormattingEnabled = True
        Me.cmbNombreUsuario.Location = New System.Drawing.Point(238, 125)
        Me.cmbNombreUsuario.Name = "cmbNombreUsuario"
        Me.cmbNombreUsuario.Size = New System.Drawing.Size(183, 21)
        Me.cmbNombreUsuario.TabIndex = 4
        '
        'txtVC
        '
        Me.txtVC.Location = New System.Drawing.Point(238, 154)
        Me.txtVC.Name = "txtVC"
        Me.txtVC.Size = New System.Drawing.Size(183, 20)
        Me.txtVC.TabIndex = 5
        Me.txtVC.UseSystemPasswordChar = True
        '
        'txtNC
        '
        Me.txtNC.Location = New System.Drawing.Point(238, 183)
        Me.txtNC.Name = "txtNC"
        Me.txtNC.Size = New System.Drawing.Size(183, 20)
        Me.txtNC.TabIndex = 6
        Me.txtNC.UseSystemPasswordChar = True
        '
        'txtCNC
        '
        Me.txtCNC.Location = New System.Drawing.Point(238, 212)
        Me.txtCNC.Name = "txtCNC"
        Me.txtCNC.Size = New System.Drawing.Size(183, 20)
        Me.txtCNC.TabIndex = 7
        Me.txtCNC.UseSystemPasswordChar = True
        '
        'btnCambiarContraseña
        '
        Me.btnCambiarContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarContraseña.Location = New System.Drawing.Point(150, 254)
        Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
        Me.btnCambiarContraseña.Size = New System.Drawing.Size(173, 31)
        Me.btnCambiarContraseña.TabIndex = 8
        Me.btnCambiarContraseña.Text = "Cambiar contraseña"
        Me.btnCambiarContraseña.UseVisualStyleBackColor = True
        '
        'btnVolverUsuario
        '
        Me.btnVolverUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverUsuario.Location = New System.Drawing.Point(127, 291)
        Me.btnVolverUsuario.Name = "btnVolverUsuario"
        Me.btnVolverUsuario.Size = New System.Drawing.Size(212, 31)
        Me.btnVolverUsuario.TabIndex = 9
        Me.btnVolverUsuario.Text = "Volver al menu de usuario"
        Me.btnVolverUsuario.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(137, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmCambiarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(451, 348)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVolverUsuario)
        Me.Controls.Add(Me.btnCambiarContraseña)
        Me.Controls.Add(Me.txtCNC)
        Me.Controls.Add(Me.txtNC)
        Me.Controls.Add(Me.txtVC)
        Me.Controls.Add(Me.cmbNombreUsuario)
        Me.Controls.Add(Me.lblConfirmarNuevaContraseña)
        Me.Controls.Add(Me.lblNuevaContraseña)
        Me.Controls.Add(Me.lblViejaContraseña)
        Me.Controls.Add(Me.lblUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCambiarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Cambiar contraseña"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblViejaContraseña As System.Windows.Forms.Label
    Friend WithEvents lblNuevaContraseña As System.Windows.Forms.Label
    Friend WithEvents lblConfirmarNuevaContraseña As System.Windows.Forms.Label
    Friend WithEvents cmbNombreUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents txtVC As System.Windows.Forms.TextBox
    Friend WithEvents txtNC As System.Windows.Forms.TextBox
    Friend WithEvents txtCNC As System.Windows.Forms.TextBox
    Friend WithEvents btnCambiarContraseña As System.Windows.Forms.Button
    Friend WithEvents btnVolverUsuario As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
