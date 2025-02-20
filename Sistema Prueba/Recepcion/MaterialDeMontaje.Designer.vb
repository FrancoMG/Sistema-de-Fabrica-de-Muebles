<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialDeMontaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialDeMontaje))
        Me.lblTituloMaterialMontaje = New System.Windows.Forms.Label()
        Me.lblMaterialMontaje1 = New System.Windows.Forms.Label()
        Me.cmbMaterialM = New System.Windows.Forms.ComboBox()
        Me.lblCantidadM = New System.Windows.Forms.Label()
        Me.txtCantidadM = New System.Windows.Forms.TextBox()
        Me.btnAceptarM = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTituloMaterialMontaje
        '
        Me.lblTituloMaterialMontaje.AutoSize = True
        Me.lblTituloMaterialMontaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloMaterialMontaje.Location = New System.Drawing.Point(110, 9)
        Me.lblTituloMaterialMontaje.Name = "lblTituloMaterialMontaje"
        Me.lblTituloMaterialMontaje.Size = New System.Drawing.Size(348, 24)
        Me.lblTituloMaterialMontaje.TabIndex = 0
        Me.lblTituloMaterialMontaje.Text = "Ingrese los datos de material de montaje"
        '
        'lblMaterialMontaje1
        '
        Me.lblMaterialMontaje1.AutoSize = True
        Me.lblMaterialMontaje1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterialMontaje1.Location = New System.Drawing.Point(65, 62)
        Me.lblMaterialMontaje1.Name = "lblMaterialMontaje1"
        Me.lblMaterialMontaje1.Size = New System.Drawing.Size(75, 24)
        Me.lblMaterialMontaje1.TabIndex = 1
        Me.lblMaterialMontaje1.Text = "Material"
        '
        'cmbMaterialM
        '
        Me.cmbMaterialM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaterialM.FormattingEnabled = True
        Me.cmbMaterialM.Location = New System.Drawing.Point(161, 62)
        Me.cmbMaterialM.Name = "cmbMaterialM"
        Me.cmbMaterialM.Size = New System.Drawing.Size(121, 21)
        Me.cmbMaterialM.TabIndex = 2
        '
        'lblCantidadM
        '
        Me.lblCantidadM.AutoSize = True
        Me.lblCantidadM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadM.Location = New System.Drawing.Point(320, 62)
        Me.lblCantidadM.Name = "lblCantidadM"
        Me.lblCantidadM.Size = New System.Drawing.Size(84, 24)
        Me.lblCantidadM.TabIndex = 3
        Me.lblCantidadM.Text = "Cantidad"
        '
        'txtCantidadM
        '
        Me.txtCantidadM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadM.Location = New System.Drawing.Point(419, 62)
        Me.txtCantidadM.MaxLength = 8
        Me.txtCantidadM.Name = "txtCantidadM"
        Me.txtCantidadM.Size = New System.Drawing.Size(51, 24)
        Me.txtCantidadM.TabIndex = 4
        '
        'btnAceptarM
        '
        Me.btnAceptarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarM.Location = New System.Drawing.Point(195, 127)
        Me.btnAceptarM.Name = "btnAceptarM"
        Me.btnAceptarM.Size = New System.Drawing.Size(147, 38)
        Me.btnAceptarM.TabIndex = 6
        Me.btnAceptarM.Text = "Aceptar"
        Me.btnAceptarM.UseVisualStyleBackColor = True
        '
        'frmMaterialDeMontaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(555, 184)
        Me.Controls.Add(Me.btnAceptarM)
        Me.Controls.Add(Me.txtCantidadM)
        Me.Controls.Add(Me.lblCantidadM)
        Me.Controls.Add(Me.cmbMaterialM)
        Me.Controls.Add(Me.lblMaterialMontaje1)
        Me.Controls.Add(Me.lblTituloMaterialMontaje)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaterialDeMontaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Material de Montaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTituloMaterialMontaje As Label
    Friend WithEvents lblMaterialMontaje1 As Label
    Friend WithEvents cmbMaterialM As ComboBox
    Friend WithEvents lblCantidadM As Label
    Friend WithEvents txtCantidadM As TextBox
    Friend WithEvents btnAceptarM As Button
End Class
