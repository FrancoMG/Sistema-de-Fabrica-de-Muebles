<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarMadera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarMadera))
        Me.btnVolverMenuABM = New System.Windows.Forms.Button()
        Me.gbxAgregarMadera = New System.Windows.Forms.GroupBox()
        Me.txtPP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblPP = New System.Windows.Forms.Label()
        Me.txtPrecioxCM2 = New System.Windows.Forms.TextBox()
        Me.lblPrecioCM2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnAgregarMadera = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.gbxAgregarMadera.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolverMenuABM
        '
        Me.btnVolverMenuABM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuABM.Location = New System.Drawing.Point(56, 450)
        Me.btnVolverMenuABM.Name = "btnVolverMenuABM"
        Me.btnVolverMenuABM.Size = New System.Drawing.Size(244, 31)
        Me.btnVolverMenuABM.TabIndex = 11
        Me.btnVolverMenuABM.Text = "Volver al menu de ABM"
        Me.btnVolverMenuABM.UseVisualStyleBackColor = True
        '
        'gbxAgregarMadera
        '
        Me.gbxAgregarMadera.Controls.Add(Me.txtPP)
        Me.gbxAgregarMadera.Controls.Add(Me.Label1)
        Me.gbxAgregarMadera.Controls.Add(Me.txtStock)
        Me.gbxAgregarMadera.Controls.Add(Me.lblPP)
        Me.gbxAgregarMadera.Controls.Add(Me.txtPrecioxCM2)
        Me.gbxAgregarMadera.Controls.Add(Me.lblPrecioCM2)
        Me.gbxAgregarMadera.Controls.Add(Me.txtDescripcion)
        Me.gbxAgregarMadera.Controls.Add(Me.btnAgregarMadera)
        Me.gbxAgregarMadera.Controls.Add(Me.lblNombre)
        Me.gbxAgregarMadera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAgregarMadera.Location = New System.Drawing.Point(33, 38)
        Me.gbxAgregarMadera.Name = "gbxAgregarMadera"
        Me.gbxAgregarMadera.Size = New System.Drawing.Size(283, 377)
        Me.gbxAgregarMadera.TabIndex = 10
        Me.gbxAgregarMadera.TabStop = False
        Me.gbxAgregarMadera.Text = "Madera"
        '
        'txtPP
        '
        Me.txtPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPP.Location = New System.Drawing.Point(39, 272)
        Me.txtPP.Name = "txtPP"
        Me.txtPP.Size = New System.Drawing.Size(211, 20)
        Me.txtPP.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ingresar Punto de Pedido"
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(39, 204)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(211, 20)
        Me.txtStock.TabIndex = 7
        '
        'lblPP
        '
        Me.lblPP.AutoSize = True
        Me.lblPP.Location = New System.Drawing.Point(93, 181)
        Me.lblPP.Name = "lblPP"
        Me.lblPP.Size = New System.Drawing.Size(113, 20)
        Me.lblPP.TabIndex = 6
        Me.lblPP.Text = "Ingresar Stock"
        '
        'txtPrecioxCM2
        '
        Me.txtPrecioxCM2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioxCM2.Location = New System.Drawing.Point(39, 139)
        Me.txtPrecioxCM2.Name = "txtPrecioxCM2"
        Me.txtPrecioxCM2.Size = New System.Drawing.Size(211, 20)
        Me.txtPrecioxCM2.TabIndex = 5
        '
        'lblPrecioCM2
        '
        Me.lblPrecioCM2.AutoSize = True
        Me.lblPrecioCM2.Location = New System.Drawing.Point(63, 116)
        Me.lblPrecioCM2.Name = "lblPrecioCM2"
        Me.lblPrecioCM2.Size = New System.Drawing.Size(164, 20)
        Me.lblPrecioCM2.TabIndex = 4
        Me.lblPrecioCM2.Text = "Ingresar Precio x CM2"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(39, 75)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(211, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'btnAgregarMadera
        '
        Me.btnAgregarMadera.Location = New System.Drawing.Point(67, 320)
        Me.btnAgregarMadera.Name = "btnAgregarMadera"
        Me.btnAgregarMadera.Size = New System.Drawing.Size(159, 31)
        Me.btnAgregarMadera.TabIndex = 2
        Me.btnAgregarMadera.Text = "Agregar"
        Me.btnAgregarMadera.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(78, 52)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(128, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Ingresar Nombre"
        '
        'frmAgregarMadera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(353, 514)
        Me.Controls.Add(Me.btnVolverMenuABM)
        Me.Controls.Add(Me.gbxAgregarMadera)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarMadera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - Agregar madera"
        Me.gbxAgregarMadera.ResumeLayout(False)
        Me.gbxAgregarMadera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverMenuABM As System.Windows.Forms.Button
    Friend WithEvents gbxAgregarMadera As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarMadera As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents lblPP As System.Windows.Forms.Label
    Friend WithEvents txtPrecioxCM2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioCM2 As System.Windows.Forms.Label
    Friend WithEvents txtPP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
