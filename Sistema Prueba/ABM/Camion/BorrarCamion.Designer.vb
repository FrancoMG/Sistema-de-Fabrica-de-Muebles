<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrarCamion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrarCamion))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxBorrarCamion = New System.Windows.Forms.GroupBox()
        Me.btnLista = New System.Windows.Forms.Button()
        Me.txtCamion = New System.Windows.Forms.TextBox()
        Me.btnBorrarCamion = New System.Windows.Forms.Button()
        Me.lblCamion = New System.Windows.Forms.Label()
        Me.gbxBorrarCamion.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(53, 286)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(244, 31)
        Me.btnVolverMenuABM.TabIndex = 11
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxBorrarCamion
        '
        Me.gbxBorrarCamion.Controls.Add(Me.btnLista)
        Me.gbxBorrarCamion.Controls.Add(Me.txtCamion)
        Me.gbxBorrarCamion.Controls.Add(Me.btnBorrarCamion)
        Me.gbxBorrarCamion.Controls.Add(Me.lblCamion)
        Me.gbxBorrarCamion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBorrarCamion.Location = New System.Drawing.Point(33, 35)
        Me.gbxBorrarCamion.Name = "gbxBorrarCamion"
        Me.gbxBorrarCamion.Size = New System.Drawing.Size(277, 220)
        Me.gbxBorrarCamion.TabIndex = 10
        Me.gbxBorrarCamion.TabStop = False
        Me.gbxBorrarCamion.Text = "Camion"
        '
        'btnLista
        '
        Me.btnLista.Location = New System.Drawing.Point(81, 117)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(120, 29)
        Me.btnLista.TabIndex = 4
        Me.btnLista.Text = "Ver Lista"
        Me.btnLista.UseVisualStyleBackColor = True
        '
        'txtCamion
        '
        Me.txtCamion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCamion.Location = New System.Drawing.Point(38, 82)
        Me.txtCamion.Name = "txtCamion"
        Me.txtCamion.Size = New System.Drawing.Size(211, 20)
        Me.txtCamion.TabIndex = 3
        '
        'btnBorrarCamion
        '
        Me.btnBorrarCamion.Location = New System.Drawing.Point(64, 165)
        Me.btnBorrarCamion.Name = "btnBorrarCamion"
        Me.btnBorrarCamion.Size = New System.Drawing.Size(159, 31)
        Me.btnBorrarCamion.TabIndex = 2
        Me.btnBorrarCamion.Text = "Borrar"
        Me.btnBorrarCamion.UseVisualStyleBackColor = True
        '
        'lblCamion
        '
        Me.lblCamion.AutoSize = True
        Me.lblCamion.Location = New System.Drawing.Point(60, 50)
        Me.lblCamion.Name = "lblCamion"
        Me.lblCamion.Size = New System.Drawing.Size(172, 20)
        Me.lblCamion.TabIndex = 0
        Me.lblCamion.Text = "Ingresar ID del Camion"
        '
        'frmBorrarCamion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(347, 341)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxBorrarCamion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBorrarCamion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Borrar camion"
        Me.gbxBorrarCamion.ResumeLayout(False)
        Me.gbxBorrarCamion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxBorrarCamion As System.Windows.Forms.GroupBox
    Friend WithEvents txtCamion As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrarCamion As System.Windows.Forms.Button
    Friend WithEvents lblCamion As System.Windows.Forms.Label
    Friend WithEvents btnLista As System.Windows.Forms.Button
End Class
