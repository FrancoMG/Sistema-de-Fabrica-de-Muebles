<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarPermisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarPermisos))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.lblPermisos = New System.Windows.Forms.Label()
        Me.cmbPermisos = New System.Windows.Forms.ComboBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnVolverUsuario = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(110, 120)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(64, 20)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        '
        'cmbUsuario
        '
        Me.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(180, 119)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(198, 21)
        Me.cmbUsuario.TabIndex = 1
        '
        'lblPermisos
        '
        Me.lblPermisos.AutoSize = True
        Me.lblPermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermisos.Location = New System.Drawing.Point(100, 155)
        Me.lblPermisos.Name = "lblPermisos"
        Me.lblPermisos.Size = New System.Drawing.Size(74, 20)
        Me.lblPermisos.TabIndex = 2
        Me.lblPermisos.Text = "Permisos"
        '
        'cmbPermisos
        '
        Me.cmbPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPermisos.FormattingEnabled = True
        Me.cmbPermisos.Location = New System.Drawing.Point(180, 155)
        Me.cmbPermisos.Name = "cmbPermisos"
        Me.cmbPermisos.Size = New System.Drawing.Size(198, 21)
        Me.cmbPermisos.TabIndex = 3
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(166, 202)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(142, 29)
        Me.btnConfirmar.TabIndex = 4
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnVolverUsuario
        '
        Me.btnVolverUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverUsuario.Location = New System.Drawing.Point(120, 237)
        Me.btnVolverUsuario.Name = "btnVolverUsuario"
        Me.btnVolverUsuario.Size = New System.Drawing.Size(233, 29)
        Me.btnVolverUsuario.TabIndex = 5
        Me.btnVolverUsuario.Text = "Volver al menu de usuario"
        Me.btnVolverUsuario.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(168, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmModificarPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(467, 285)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVolverUsuario)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.cmbPermisos)
        Me.Controls.Add(Me.lblPermisos)
        Me.Controls.Add(Me.cmbUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModificarPermisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Modificar permisos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents cmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents lblPermisos As System.Windows.Forms.Label
    Friend WithEvents cmbPermisos As System.Windows.Forms.ComboBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnVolverUsuario As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
