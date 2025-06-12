<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.btnCrearUsuario = New System.Windows.Forms.Button()
        Me.btnBorrarUsuario = New System.Windows.Forms.Button()
        Me.btnModificarContraseña = New System.Windows.Forms.Button()
        Me.btnVolverMenu = New System.Windows.Forms.Button()
        Me.btnModificarPermisos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearUsuario.Location = New System.Drawing.Point(83, 27)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(235, 51)
        Me.btnCrearUsuario.TabIndex = 0
        Me.btnCrearUsuario.Text = "Crear usuario"
        Me.btnCrearUsuario.UseVisualStyleBackColor = True
        '
        'btnBorrarUsuario
        '
        Me.btnBorrarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarUsuario.Location = New System.Drawing.Point(83, 93)
        Me.btnBorrarUsuario.Name = "btnBorrarUsuario"
        Me.btnBorrarUsuario.Size = New System.Drawing.Size(235, 51)
        Me.btnBorrarUsuario.TabIndex = 1
        Me.btnBorrarUsuario.Text = "Borrar usuario"
        Me.btnBorrarUsuario.UseVisualStyleBackColor = True
        '
        'btnModificarContraseña
        '
        Me.btnModificarContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarContraseña.Location = New System.Drawing.Point(83, 160)
        Me.btnModificarContraseña.Name = "btnModificarContraseña"
        Me.btnModificarContraseña.Size = New System.Drawing.Size(235, 51)
        Me.btnModificarContraseña.TabIndex = 2
        Me.btnModificarContraseña.Text = "Cambiar contraseña"
        Me.btnModificarContraseña.UseVisualStyleBackColor = True
        '
        'btnVolverMenu
        '
        Me.btnVolverMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenu.Location = New System.Drawing.Point(83, 292)
        Me.btnVolverMenu.Name = "btnVolverMenu"
        Me.btnVolverMenu.Size = New System.Drawing.Size(235, 51)
        Me.btnVolverMenu.TabIndex = 3
        Me.btnVolverMenu.Text = "Volver al menu principal"
        Me.btnVolverMenu.UseVisualStyleBackColor = True
        '
        'btnModificarPermisos
        '
        Me.btnModificarPermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPermisos.Location = New System.Drawing.Point(83, 226)
        Me.btnModificarPermisos.Name = "btnModificarPermisos"
        Me.btnModificarPermisos.Size = New System.Drawing.Size(235, 51)
        Me.btnModificarPermisos.TabIndex = 4
        Me.btnModificarPermisos.Text = "Modificar permisos"
        Me.btnModificarPermisos.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Logo2
        Me.PictureBox1.Location = New System.Drawing.Point(123, 360)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(396, 464)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnModificarPermisos)
        Me.Controls.Add(Me.btnVolverMenu)
        Me.Controls.Add(Me.btnModificarContraseña)
        Me.Controls.Add(Me.btnBorrarUsuario)
        Me.Controls.Add(Me.btnCrearUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Usuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCrearUsuario As System.Windows.Forms.Button
    Friend WithEvents btnBorrarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnModificarContraseña As System.Windows.Forms.Button
    Friend WithEvents btnVolverMenu As System.Windows.Forms.Button
    Friend WithEvents btnModificarPermisos As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
