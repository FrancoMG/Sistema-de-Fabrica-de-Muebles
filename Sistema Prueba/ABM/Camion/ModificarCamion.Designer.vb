<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarCamion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarCamion))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbxDatos = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.gbxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(142, 452)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(192, 28)
        Me.btnSalir.TabIndex = 27
        Me.btnSalir.Text = "Volver al menu de ABM"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gbxDatos
        '
        Me.gbxDatos.Controls.Add(Me.btnModificar)
        Me.gbxDatos.Controls.Add(Me.lblEstado)
        Me.gbxDatos.Controls.Add(Me.lblModelo)
        Me.gbxDatos.Controls.Add(Me.lblMarca)
        Me.gbxDatos.Controls.Add(Me.cmbEstado)
        Me.gbxDatos.Controls.Add(Me.txtModelo)
        Me.gbxDatos.Controls.Add(Me.txtMarca)
        Me.gbxDatos.Enabled = False
        Me.gbxDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatos.Location = New System.Drawing.Point(20, 167)
        Me.gbxDatos.Name = "gbxDatos"
        Me.gbxDatos.Size = New System.Drawing.Size(425, 255)
        Me.gbxDatos.TabIndex = 28
        Me.gbxDatos.TabStop = False
        Me.gbxDatos.Text = "Datos"
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(132, 204)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(171, 28)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(184, 115)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(60, 20)
        Me.lblEstado.TabIndex = 13
        Me.lblEstado.Text = "Estado"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(290, 24)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(61, 20)
        Me.lblModelo.TabIndex = 10
        Me.lblModelo.Text = "Modelo"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(72, 24)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(53, 20)
        Me.lblMarca.TabIndex = 9
        Me.lblMarca.Text = "Marca"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(150, 147)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(126, 21)
        Me.cmbEstado.TabIndex = 8
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(233, 56)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(171, 22)
        Me.txtModelo.TabIndex = 5
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(20, 56)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(171, 22)
        Me.txtMarca.TabIndex = 4
        '
        'btnCargarDatos
        '
        Me.btnCargarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarDatos.Location = New System.Drawing.Point(169, 106)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(126, 27)
        Me.btnCargarDatos.TabIndex = 26
        Me.btnCargarDatos.Text = "Cargar datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = True
        '
        'btnLista
        '
        Me.btnLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLista.Location = New System.Drawing.Point(297, 58)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(112, 23)
        Me.btnLista.TabIndex = 25
        Me.btnLista.Text = "Ver lista"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(194, 61)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(85, 20)
        Me.txtID.TabIndex = 24
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(79, 61)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(109, 20)
        Me.lblID.TabIndex = 23
        Me.lblID.Text = "ID del Camion"
        '
        'frmModificarCamion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(470, 513)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gbxDatos)
        Me.Controls.Add(Me.btnCargarDatos)
        Me.Controls.Add(Me.btnLista)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModificarCamion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Modificar camion"
        Me.gbxDatos.ResumeLayout(False)
        Me.gbxDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbxDatos As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents btnCargarDatos As System.Windows.Forms.Button
    Friend WithEvents btnLista As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
