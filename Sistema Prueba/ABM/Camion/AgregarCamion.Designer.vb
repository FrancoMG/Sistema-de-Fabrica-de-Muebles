<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCamion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarCamion))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxAgregarCamion = New System.Windows.Forms.GroupBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.btnAgregarCamion = New System.Windows.Forms.Button()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.gbxAgregarCamion.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnVolverMenuABM.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(51, 340)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(244, 31)
        Me.btnVolverMenuABM.TabIndex = 9
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxAgregarCamion
        '
        Me.gbxAgregarCamion.Controls.Add(Me.txtModelo)
        Me.gbxAgregarCamion.Controls.Add(Me.lblModelo)
        Me.gbxAgregarCamion.Controls.Add(Me.txtMarca)
        Me.gbxAgregarCamion.Controls.Add(Me.btnAgregarCamion)
        Me.gbxAgregarCamion.Controls.Add(Me.lblMarca)
        Me.gbxAgregarCamion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAgregarCamion.Location = New System.Drawing.Point(31, 34)
        Me.gbxAgregarCamion.Name = "gbxAgregarCamion"
        Me.gbxAgregarCamion.Size = New System.Drawing.Size(277, 266)
        Me.gbxAgregarCamion.TabIndex = 8
        Me.gbxAgregarCamion.TabStop = False
        Me.gbxAgregarCamion.Text = "Camion"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(38, 153)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(211, 20)
        Me.txtModelo.TabIndex = 5
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(86, 121)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(119, 20)
        Me.lblModelo.TabIndex = 4
        Me.lblModelo.Text = "Ingresa Modelo"
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(38, 82)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(211, 20)
        Me.txtMarca.TabIndex = 3
        '
        'btnAgregarCamion
        '
        Me.btnAgregarCamion.Location = New System.Drawing.Point(60, 214)
        Me.btnAgregarCamion.Name = "btnAgregarCamion"
        Me.btnAgregarCamion.Size = New System.Drawing.Size(159, 31)
        Me.btnAgregarCamion.TabIndex = 2
        Me.btnAgregarCamion.Text = "Agregar"
        Me.btnAgregarCamion.UseVisualStyleBackColor = True
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(89, 49)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(116, 20)
        Me.lblMarca.TabIndex = 0
        Me.lblMarca.Text = "Ingresar Marca"
        '
        'frmAgregarCamion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(340, 399)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxAgregarCamion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarCamion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Agregar camion"
        Me.gbxAgregarCamion.ResumeLayout(False)
        Me.gbxAgregarCamion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxAgregarCamion As System.Windows.Forms.GroupBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarCamion As System.Windows.Forms.Button
    Friend WithEvents lblMarca As System.Windows.Forms.Label
End Class
