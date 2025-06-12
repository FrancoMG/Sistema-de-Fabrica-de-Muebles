<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearUsuario))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTU = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfirmarContraseña = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnVolverUsuario = New System.Windows.Forms.Button()
        Me.cmbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.gbxUsuario = New System.Windows.Forms.GroupBox()
        Me.dniUsuario = New System.Windows.Forms.Label()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxUsuario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(60, 59)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(121, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre usuario"
        '
        'lblTU
        '
        Me.lblTU.AutoSize = True
        Me.lblTU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTU.Location = New System.Drawing.Point(86, 88)
        Me.lblTU.Name = "lblTU"
        Me.lblTU.Size = New System.Drawing.Size(95, 20)
        Me.lblTU.TabIndex = 1
        Me.lblTU.Text = "Tipo usuario"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(187, 59)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(170, 20)
        Me.txtNombre.TabIndex = 2
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.Location = New System.Drawing.Point(89, 115)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(92, 20)
        Me.lblContraseña.TabIndex = 4
        Me.lblContraseña.Text = "Contraseña"
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(187, 115)
        Me.txtContraseña.MaxLength = 40
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(170, 20)
        Me.txtContraseña.TabIndex = 5
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Confirmar contraseña"
        '
        'txtConfirmarContraseña
        '
        Me.txtConfirmarContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmarContraseña.Location = New System.Drawing.Point(187, 146)
        Me.txtConfirmarContraseña.MaxLength = 40
        Me.txtConfirmarContraseña.Name = "txtConfirmarContraseña"
        Me.txtConfirmarContraseña.Size = New System.Drawing.Size(170, 20)
        Me.txtConfirmarContraseña.TabIndex = 7
        Me.txtConfirmarContraseña.UseSystemPasswordChar = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegistrar.Location = New System.Drawing.Point(138, 183)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(125, 28)
        Me.btnRegistrar.TabIndex = 8
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnVolverUsuario
        '
        Me.btnVolverUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVolverUsuario.Location = New System.Drawing.Point(68, 400)
        Me.btnVolverUsuario.Name = "btnVolverUsuario"
        Me.btnVolverUsuario.Size = New System.Drawing.Size(202, 28)
        Me.btnVolverUsuario.TabIndex = 9
        Me.btnVolverUsuario.Text = "Volver al menu de usuario"
        Me.btnVolverUsuario.UseVisualStyleBackColor = True
        '
        'cmbTipoUsuario
        '
        Me.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoUsuario.FormattingEnabled = True
        Me.cmbTipoUsuario.Location = New System.Drawing.Point(187, 88)
        Me.cmbTipoUsuario.Name = "cmbTipoUsuario"
        Me.cmbTipoUsuario.Size = New System.Drawing.Size(170, 21)
        Me.cmbTipoUsuario.TabIndex = 11
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(81, 32)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(89, 20)
        Me.lblID.TabIndex = 12
        Me.lblID.Text = "ID Persona"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(176, 33)
        Me.txtID.MaxLength = 30
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(170, 20)
        Me.txtID.TabIndex = 13
        '
        'btnVerificar
        '
        Me.btnVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVerificar.Location = New System.Drawing.Point(176, 69)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(125, 28)
        Me.btnVerificar.TabIndex = 14
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'gbxUsuario
        '
        Me.gbxUsuario.Controls.Add(Me.dniUsuario)
        Me.gbxUsuario.Controls.Add(Me.btnRegistrar)
        Me.gbxUsuario.Controls.Add(Me.Label1)
        Me.gbxUsuario.Controls.Add(Me.txtConfirmarContraseña)
        Me.gbxUsuario.Controls.Add(Me.cmbTipoUsuario)
        Me.gbxUsuario.Controls.Add(Me.txtNombre)
        Me.gbxUsuario.Controls.Add(Me.txtContraseña)
        Me.gbxUsuario.Controls.Add(Me.lblNombre)
        Me.gbxUsuario.Controls.Add(Me.lblContraseña)
        Me.gbxUsuario.Controls.Add(Me.lblTU)
        Me.gbxUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxUsuario.Location = New System.Drawing.Point(45, 115)
        Me.gbxUsuario.Name = "gbxUsuario"
        Me.gbxUsuario.Size = New System.Drawing.Size(385, 252)
        Me.gbxUsuario.TabIndex = 15
        Me.gbxUsuario.TabStop = False
        Me.gbxUsuario.Text = "Datos Usuario"
        '
        'dniUsuario
        '
        Me.dniUsuario.AutoSize = True
        Me.dniUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dniUsuario.Location = New System.Drawing.Point(187, 36)
        Me.dniUsuario.Name = "dniUsuario"
        Me.dniUsuario.Size = New System.Drawing.Size(0, 20)
        Me.dniUsuario.TabIndex = 13
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(367, 33)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(84, 20)
        Me.btnLista.TabIndex = 16
        Me.btnLista.Text = "Ver Lista"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(290, 382)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmCrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(473, 462)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLista)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnVolverUsuario)
        Me.Controls.Add(Me.gbxUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCrearUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Crear usuario"
        Me.gbxUsuario.ResumeLayout(False)
        Me.gbxUsuario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblTU As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmarContraseña As System.Windows.Forms.TextBox
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnVolverUsuario As System.Windows.Forms.Button
    Friend WithEvents cmbTipoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents gbxUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents dniUsuario As System.Windows.Forms.Label
    Friend WithEvents btnLista As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
