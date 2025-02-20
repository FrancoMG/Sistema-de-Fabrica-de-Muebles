<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABM))
        Me.gbxPersona = New System.Windows.Forms.GroupBox()
        Me.btnModificarPersona = New System.Windows.Forms.Button()
        Me.btnBorrarPersona = New System.Windows.Forms.Button()
        Me.btnAgregarPersona = New System.Windows.Forms.Button()
        Me.gbxTecnico = New System.Windows.Forms.GroupBox()
        Me.btnModificarTecnico = New System.Windows.Forms.Button()
        Me.btnBorrarTecnico = New System.Windows.Forms.Button()
        Me.btnAgregarTecnico = New System.Windows.Forms.Button()
        Me.gbxCliente = New System.Windows.Forms.GroupBox()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.btnBorrarCliente = New System.Windows.Forms.Button()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.gbxRecepcionista = New System.Windows.Forms.GroupBox()
        Me.btnModificarRecep = New System.Windows.Forms.Button()
        Me.btnBorrarRecep = New System.Windows.Forms.Button()
        Me.btnAgregarRecep = New System.Windows.Forms.Button()
        Me.gbxTipoMueble = New System.Windows.Forms.GroupBox()
        Me.btnModificarTM = New System.Windows.Forms.Button()
        Me.btnBorrarTM = New System.Windows.Forms.Button()
        Me.btnAgregarTM = New System.Windows.Forms.Button()
        Me.gbxMadera = New System.Windows.Forms.GroupBox()
        Me.btnModificarMadera = New System.Windows.Forms.Button()
        Me.btnBorrarMadera = New System.Windows.Forms.Button()
        Me.btnAgregarMadera = New System.Windows.Forms.Button()
        Me.gbxMaterialMontaje = New System.Windows.Forms.GroupBox()
        Me.btnModificarMM = New System.Windows.Forms.Button()
        Me.btnBorrarMM = New System.Windows.Forms.Button()
        Me.btnAgregarMM = New System.Windows.Forms.Button()
        Me.gbxCamion = New System.Windows.Forms.GroupBox()
        Me.btnModificaCamion = New System.Windows.Forms.Button()
        Me.btnBorrarCamion = New System.Windows.Forms.Button()
        Me.btnAgregarCamion = New System.Windows.Forms.Button()
        Me.pbxExtras = New System.Windows.Forms.GroupBox()
        Me.btnModificarExtra = New System.Windows.Forms.Button()
        Me.btnBorrarExtra = New System.Windows.Forms.Button()
        Me.btnAgregarExtra = New System.Windows.Forms.Button()
        Me.gbxProveedor = New System.Windows.Forms.GroupBox()
        Me.btnModificarProveedor = New System.Windows.Forms.Button()
        Me.btnBorrarProveedor = New System.Windows.Forms.Button()
        Me.btnAgregarProveedor = New System.Windows.Forms.Button()
        Me.gbxProducto = New System.Windows.Forms.GroupBox()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnBorrarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.btnVolverMenuPrincipal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxPersona.SuspendLayout()
        Me.gbxTecnico.SuspendLayout()
        Me.gbxCliente.SuspendLayout()
        Me.gbxRecepcionista.SuspendLayout()
        Me.gbxTipoMueble.SuspendLayout()
        Me.gbxMadera.SuspendLayout()
        Me.gbxMaterialMontaje.SuspendLayout()
        Me.gbxCamion.SuspendLayout()
        Me.pbxExtras.SuspendLayout()
        Me.gbxProveedor.SuspendLayout()
        Me.gbxProducto.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxPersona
        '
        Me.gbxPersona.Controls.Add(Me.btnModificarPersona)
        Me.gbxPersona.Controls.Add(Me.btnBorrarPersona)
        Me.gbxPersona.Controls.Add(Me.btnAgregarPersona)
        Me.gbxPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPersona.Location = New System.Drawing.Point(38, 86)
        Me.gbxPersona.Name = "gbxPersona"
        Me.gbxPersona.Size = New System.Drawing.Size(356, 70)
        Me.gbxPersona.TabIndex = 16
        Me.gbxPersona.TabStop = False
        Me.gbxPersona.Text = "Persona"
        '
        'btnModificarPersona
        '
        Me.btnModificarPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPersona.Location = New System.Drawing.Point(238, 25)
        Me.btnModificarPersona.Name = "btnModificarPersona"
        Me.btnModificarPersona.Size = New System.Drawing.Size(110, 31)
        Me.btnModificarPersona.TabIndex = 18
        Me.btnModificarPersona.Text = "Modificar"
        Me.btnModificarPersona.UseVisualStyleBackColor = True
        '
        'btnBorrarPersona
        '
        Me.btnBorrarPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarPersona.Location = New System.Drawing.Point(122, 25)
        Me.btnBorrarPersona.Name = "btnBorrarPersona"
        Me.btnBorrarPersona.Size = New System.Drawing.Size(110, 31)
        Me.btnBorrarPersona.TabIndex = 18
        Me.btnBorrarPersona.Text = "Borrar"
        Me.btnBorrarPersona.UseVisualStyleBackColor = True
        '
        'btnAgregarPersona
        '
        Me.btnAgregarPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPersona.Location = New System.Drawing.Point(6, 25)
        Me.btnAgregarPersona.Name = "btnAgregarPersona"
        Me.btnAgregarPersona.Size = New System.Drawing.Size(110, 31)
        Me.btnAgregarPersona.TabIndex = 17
        Me.btnAgregarPersona.Text = "Agregar"
        Me.btnAgregarPersona.UseVisualStyleBackColor = True
        '
        'gbxTecnico
        '
        Me.gbxTecnico.Controls.Add(Me.btnModificarTecnico)
        Me.gbxTecnico.Controls.Add(Me.btnBorrarTecnico)
        Me.gbxTecnico.Controls.Add(Me.btnAgregarTecnico)
        Me.gbxTecnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTecnico.Location = New System.Drawing.Point(38, 256)
        Me.gbxTecnico.Name = "gbxTecnico"
        Me.gbxTecnico.Size = New System.Drawing.Size(356, 70)
        Me.gbxTecnico.TabIndex = 19
        Me.gbxTecnico.TabStop = False
        Me.gbxTecnico.Text = "Tecnico"
        '
        'btnModificarTecnico
        '
        Me.btnModificarTecnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarTecnico.Location = New System.Drawing.Point(238, 25)
        Me.btnModificarTecnico.Name = "btnModificarTecnico"
        Me.btnModificarTecnico.Size = New System.Drawing.Size(110, 31)
        Me.btnModificarTecnico.TabIndex = 18
        Me.btnModificarTecnico.Text = "Modificar"
        Me.btnModificarTecnico.UseVisualStyleBackColor = True
        '
        'btnBorrarTecnico
        '
        Me.btnBorrarTecnico.Enabled = False
        Me.btnBorrarTecnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarTecnico.Location = New System.Drawing.Point(122, 25)
        Me.btnBorrarTecnico.Name = "btnBorrarTecnico"
        Me.btnBorrarTecnico.Size = New System.Drawing.Size(110, 31)
        Me.btnBorrarTecnico.TabIndex = 18
        Me.btnBorrarTecnico.Text = "Borrar"
        Me.btnBorrarTecnico.UseVisualStyleBackColor = True
        '
        'btnAgregarTecnico
        '
        Me.btnAgregarTecnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarTecnico.Location = New System.Drawing.Point(6, 25)
        Me.btnAgregarTecnico.Name = "btnAgregarTecnico"
        Me.btnAgregarTecnico.Size = New System.Drawing.Size(110, 31)
        Me.btnAgregarTecnico.TabIndex = 17
        Me.btnAgregarTecnico.Text = "Agregar"
        Me.btnAgregarTecnico.UseVisualStyleBackColor = True
        '
        'gbxCliente
        '
        Me.gbxCliente.Controls.Add(Me.btnModificarCliente)
        Me.gbxCliente.Controls.Add(Me.btnBorrarCliente)
        Me.gbxCliente.Controls.Add(Me.btnAgregarCliente)
        Me.gbxCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCliente.Location = New System.Drawing.Point(38, 171)
        Me.gbxCliente.Name = "gbxCliente"
        Me.gbxCliente.Size = New System.Drawing.Size(356, 70)
        Me.gbxCliente.TabIndex = 20
        Me.gbxCliente.TabStop = False
        Me.gbxCliente.Text = "Cliente"
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Enabled = False
        Me.btnModificarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCliente.Location = New System.Drawing.Point(238, 25)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(110, 31)
        Me.btnModificarCliente.TabIndex = 18
        Me.btnModificarCliente.Text = "Modificar"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        '
        'btnBorrarCliente
        '
        Me.btnBorrarCliente.Enabled = False
        Me.btnBorrarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarCliente.Location = New System.Drawing.Point(122, 25)
        Me.btnBorrarCliente.Name = "btnBorrarCliente"
        Me.btnBorrarCliente.Size = New System.Drawing.Size(110, 31)
        Me.btnBorrarCliente.TabIndex = 18
        Me.btnBorrarCliente.Text = "Borrar"
        Me.btnBorrarCliente.UseVisualStyleBackColor = True
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.Location = New System.Drawing.Point(6, 25)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(110, 31)
        Me.btnAgregarCliente.TabIndex = 17
        Me.btnAgregarCliente.Text = "Agregar"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'gbxRecepcionista
        '
        Me.gbxRecepcionista.Controls.Add(Me.btnModificarRecep)
        Me.gbxRecepcionista.Controls.Add(Me.btnBorrarRecep)
        Me.gbxRecepcionista.Controls.Add(Me.btnAgregarRecep)
        Me.gbxRecepcionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRecepcionista.Location = New System.Drawing.Point(38, 341)
        Me.gbxRecepcionista.Name = "gbxRecepcionista"
        Me.gbxRecepcionista.Size = New System.Drawing.Size(356, 70)
        Me.gbxRecepcionista.TabIndex = 21
        Me.gbxRecepcionista.TabStop = False
        Me.gbxRecepcionista.Text = "Recepcionista"
        '
        'btnModificarRecep
        '
        Me.btnModificarRecep.Enabled = False
        Me.btnModificarRecep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarRecep.Location = New System.Drawing.Point(238, 25)
        Me.btnModificarRecep.Name = "btnModificarRecep"
        Me.btnModificarRecep.Size = New System.Drawing.Size(110, 31)
        Me.btnModificarRecep.TabIndex = 18
        Me.btnModificarRecep.Text = "Modificar"
        Me.btnModificarRecep.UseVisualStyleBackColor = True
        '
        'btnBorrarRecep
        '
        Me.btnBorrarRecep.Enabled = False
        Me.btnBorrarRecep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarRecep.Location = New System.Drawing.Point(122, 25)
        Me.btnBorrarRecep.Name = "btnBorrarRecep"
        Me.btnBorrarRecep.Size = New System.Drawing.Size(110, 31)
        Me.btnBorrarRecep.TabIndex = 18
        Me.btnBorrarRecep.Text = "Borrar"
        Me.btnBorrarRecep.UseVisualStyleBackColor = True
        '
        'btnAgregarRecep
        '
        Me.btnAgregarRecep.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRecep.Location = New System.Drawing.Point(6, 25)
        Me.btnAgregarRecep.Name = "btnAgregarRecep"
        Me.btnAgregarRecep.Size = New System.Drawing.Size(110, 31)
        Me.btnAgregarRecep.TabIndex = 17
        Me.btnAgregarRecep.Text = "Agregar"
        Me.btnAgregarRecep.UseVisualStyleBackColor = True
        '
        'gbxTipoMueble
        '
        Me.gbxTipoMueble.Controls.Add(Me.btnModificarTM)
        Me.gbxTipoMueble.Controls.Add(Me.btnBorrarTM)
        Me.gbxTipoMueble.Controls.Add(Me.btnAgregarTM)
        Me.gbxTipoMueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxTipoMueble.Location = New System.Drawing.Point(38, 426)
        Me.gbxTipoMueble.Name = "gbxTipoMueble"
        Me.gbxTipoMueble.Size = New System.Drawing.Size(356, 70)
        Me.gbxTipoMueble.TabIndex = 22
        Me.gbxTipoMueble.TabStop = False
        Me.gbxTipoMueble.Text = "Tipo Mueble"
        '
        'btnModificarTM
        '
        Me.btnModificarTM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarTM.Location = New System.Drawing.Point(238, 25)
        Me.btnModificarTM.Name = "btnModificarTM"
        Me.btnModificarTM.Size = New System.Drawing.Size(110, 31)
        Me.btnModificarTM.TabIndex = 18
        Me.btnModificarTM.Text = "Modificar"
        Me.btnModificarTM.UseVisualStyleBackColor = True
        '
        'btnBorrarTM
        '
        Me.btnBorrarTM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarTM.Location = New System.Drawing.Point(122, 25)
        Me.btnBorrarTM.Name = "btnBorrarTM"
        Me.btnBorrarTM.Size = New System.Drawing.Size(110, 31)
        Me.btnBorrarTM.TabIndex = 18
        Me.btnBorrarTM.Text = "Borrar"
        Me.btnBorrarTM.UseVisualStyleBackColor = True
        '
        'btnAgregarTM
        '
        Me.btnAgregarTM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarTM.Location = New System.Drawing.Point(6, 25)
        Me.btnAgregarTM.Name = "btnAgregarTM"
        Me.btnAgregarTM.Size = New System.Drawing.Size(110, 31)
        Me.btnAgregarTM.TabIndex = 17
        Me.btnAgregarTM.Text = "Agregar"
        Me.btnAgregarTM.UseVisualStyleBackColor = True
        '
        'gbxMadera
        '
        Me.gbxMadera.Controls.Add(Me.btnModificarMadera)
        Me.gbxMadera.Controls.Add(Me.btnBorrarMadera)
        Me.gbxMadera.Controls.Add(Me.btnAgregarMadera)
        Me.gbxMadera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxMadera.Location = New System.Drawing.Point(437, 86)
        Me.gbxMadera.Name = "gbxMadera"
        Me.gbxMadera.Size = New System.Drawing.Size(356, 70)
        Me.gbxMadera.TabIndex = 23
        Me.gbxMadera.TabStop = False
        Me.gbxMadera.Text = "Madera"
        '
        'btnModificarMadera
        '
        Me.btnModificarMadera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarMadera.Location = New System.Drawing.Point(238, 25)
        Me.btnModificarMadera.Name = "btnModificarMadera"
        Me.btnModificarMadera.Size = New System.Drawing.Size(110, 31)
        Me.btnModificarMadera.TabIndex = 18
        Me.btnModificarMadera.Text = "Modificar"
        Me.btnModificarMadera.UseVisualStyleBackColor = True
        '
        'btnBorrarMadera
        '
        Me.btnBorrarMadera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarMadera.Location = New System.Drawing.Point(122, 25)
        Me.btnBorrarMadera.Name = "btnBorrarMadera"
        Me.btnBorrarMadera.Size = New System.Drawing.Size(110, 31)
        Me.btnBorrarMadera.TabIndex = 18
        Me.btnBorrarMadera.Text = "Borrar"
        Me.btnBorrarMadera.UseVisualStyleBackColor = True
        '
        'btnAgregarMadera
        '
        Me.btnAgregarMadera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarMadera.Location = New System.Drawing.Point(6, 25)
        Me.btnAgregarMadera.Name = "btnAgregarMadera"
        Me.btnAgregarMadera.Size = New System.Drawing.Size(110, 31)
        Me.btnAgregarMadera.TabIndex = 17
        Me.btnAgregarMadera.Text = "Agregar"
        Me.btnAgregarMadera.UseVisualStyleBackColor = True
        '
        'gbxMaterialMontaje
        '
        Me.gbxMaterialMontaje.Controls.Add(Me.btnModificarMM)
        Me.gbxMaterialMontaje.Controls.Add(Me.btnBorrarMM)
        Me.gbxMaterialMontaje.Controls.Add(Me.btnAgregarMM)
        Me.gbxMaterialMontaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxMaterialMontaje.Location = New System.Drawing.Point(437, 171)
        Me.gbxMaterialMontaje.Name = "gbxMaterialMontaje"
        Me.gbxMaterialMontaje.Size = New System.Drawing.Size(356, 70)
        Me.gbxMaterialMontaje.TabIndex = 24
        Me.gbxMaterialMontaje.TabStop = False
        Me.gbxMaterialMontaje.Text = "Material de Montaje"
        '
        'btnModificarMM
        '
        Me.btnModificarMM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarMM.Location = New System.Drawing.Point(238, 25)
        Me.btnModificarMM.Name = "btnModificarMM"
        Me.btnModificarMM.Size = New System.Drawing.Size(110, 31)
        Me.btnModificarMM.TabIndex = 18
        Me.btnModificarMM.Text = "Modificar"
        Me.btnModificarMM.UseVisualStyleBackColor = True
        '
        'btnBorrarMM
        '
        Me.btnBorrarMM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarMM.Location = New System.Drawing.Point(122, 25)
        Me.btnBorrarMM.Name = "btnBorrarMM"
        Me.btnBorrarMM.Size = New System.Drawing.Size(110, 31)
        Me.btnBorrarMM.TabIndex = 18
        Me.btnBorrarMM.Text = "Borrar"
        Me.btnBorrarMM.UseVisualStyleBackColor = True
        '
        'btnAgregarMM
        '
        Me.btnAgregarMM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarMM.Location = New System.Drawing.Point(6, 25)
        Me.btnAgregarMM.Name = "btnAgregarMM"
        Me.btnAgregarMM.Size = New System.Drawing.Size(110, 31)
        Me.btnAgregarMM.TabIndex = 17
        Me.btnAgregarMM.Text = "Agregar"
        Me.btnAgregarMM.UseVisualStyleBackColor = True
        '
        'gbxCamion
        '
        Me.gbxCamion.Controls.Add(Me.btnModificaCamion)
        Me.gbxCamion.Controls.Add(Me.btnBorrarCamion)
        Me.gbxCamion.Controls.Add(Me.btnAgregarCamion)
        Me.gbxCamion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCamion.Location = New System.Drawing.Point(437, 256)
        Me.gbxCamion.Name = "gbxCamion"
        Me.gbxCamion.Size = New System.Drawing.Size(356, 70)
        Me.gbxCamion.TabIndex = 25
        Me.gbxCamion.TabStop = False
        Me.gbxCamion.Text = "Camion"
        '
        'btnModificaCamion
        '
        Me.btnModificaCamion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificaCamion.Location = New System.Drawing.Point(238, 25)
        Me.btnModificaCamion.Name = "btnModificaCamion"
        Me.btnModificaCamion.Size = New System.Drawing.Size(110, 31)
        Me.btnModificaCamion.TabIndex = 18
        Me.btnModificaCamion.Text = "Modificar"
        Me.btnModificaCamion.UseVisualStyleBackColor = True
        '
        'btnBorrarCamion
        '
        Me.btnBorrarCamion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarCamion.Location = New System.Drawing.Point(122, 25)
        Me.btnBorrarCamion.Name = "btnBorrarCamion"
        Me.btnBorrarCamion.Size = New System.Drawing.Size(110, 31)
        Me.btnBorrarCamion.TabIndex = 18
        Me.btnBorrarCamion.Text = "Borrar"
        Me.btnBorrarCamion.UseVisualStyleBackColor = True
        '
        'btnAgregarCamion
        '
        Me.btnAgregarCamion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCamion.Location = New System.Drawing.Point(6, 25)
        Me.btnAgregarCamion.Name = "btnAgregarCamion"
        Me.btnAgregarCamion.Size = New System.Drawing.Size(110, 31)
        Me.btnAgregarCamion.TabIndex = 17
        Me.btnAgregarCamion.Text = "Agregar"
        Me.btnAgregarCamion.UseVisualStyleBackColor = True
        '
        'pbxExtras
        '
        Me.pbxExtras.Controls.Add(Me.btnModificarExtra)
        Me.pbxExtras.Controls.Add(Me.btnBorrarExtra)
        Me.pbxExtras.Controls.Add(Me.btnAgregarExtra)
        Me.pbxExtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pbxExtras.Location = New System.Drawing.Point(437, 341)
        Me.pbxExtras.Name = "pbxExtras"
        Me.pbxExtras.Size = New System.Drawing.Size(356, 70)
        Me.pbxExtras.TabIndex = 26
        Me.pbxExtras.TabStop = False
        Me.pbxExtras.Text = "Extras"
        '
        'btnModificarExtra
        '
        Me.btnModificarExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarExtra.Location = New System.Drawing.Point(238, 25)
        Me.btnModificarExtra.Name = "btnModificarExtra"
        Me.btnModificarExtra.Size = New System.Drawing.Size(110, 31)
        Me.btnModificarExtra.TabIndex = 18
        Me.btnModificarExtra.Text = "Modificar"
        Me.btnModificarExtra.UseVisualStyleBackColor = True
        '
        'btnBorrarExtra
        '
        Me.btnBorrarExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarExtra.Location = New System.Drawing.Point(122, 25)
        Me.btnBorrarExtra.Name = "btnBorrarExtra"
        Me.btnBorrarExtra.Size = New System.Drawing.Size(110, 31)
        Me.btnBorrarExtra.TabIndex = 18
        Me.btnBorrarExtra.Text = "Borrar"
        Me.btnBorrarExtra.UseVisualStyleBackColor = True
        '
        'btnAgregarExtra
        '
        Me.btnAgregarExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarExtra.Location = New System.Drawing.Point(6, 25)
        Me.btnAgregarExtra.Name = "btnAgregarExtra"
        Me.btnAgregarExtra.Size = New System.Drawing.Size(110, 31)
        Me.btnAgregarExtra.TabIndex = 17
        Me.btnAgregarExtra.Text = "Agregar"
        Me.btnAgregarExtra.UseVisualStyleBackColor = True
        '
        'gbxProveedor
        '
        Me.gbxProveedor.Controls.Add(Me.btnModificarProveedor)
        Me.gbxProveedor.Controls.Add(Me.btnBorrarProveedor)
        Me.gbxProveedor.Controls.Add(Me.btnAgregarProveedor)
        Me.gbxProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxProveedor.Location = New System.Drawing.Point(437, 426)
        Me.gbxProveedor.Name = "gbxProveedor"
        Me.gbxProveedor.Size = New System.Drawing.Size(356, 70)
        Me.gbxProveedor.TabIndex = 27
        Me.gbxProveedor.TabStop = False
        Me.gbxProveedor.Text = "Proveedor"
        '
        'btnModificarProveedor
        '
        Me.btnModificarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProveedor.Location = New System.Drawing.Point(238, 25)
        Me.btnModificarProveedor.Name = "btnModificarProveedor"
        Me.btnModificarProveedor.Size = New System.Drawing.Size(110, 31)
        Me.btnModificarProveedor.TabIndex = 18
        Me.btnModificarProveedor.Text = "Modificar"
        Me.btnModificarProveedor.UseVisualStyleBackColor = True
        '
        'btnBorrarProveedor
        '
        Me.btnBorrarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarProveedor.Location = New System.Drawing.Point(122, 25)
        Me.btnBorrarProveedor.Name = "btnBorrarProveedor"
        Me.btnBorrarProveedor.Size = New System.Drawing.Size(110, 31)
        Me.btnBorrarProveedor.TabIndex = 18
        Me.btnBorrarProveedor.Text = "Borrar"
        Me.btnBorrarProveedor.UseVisualStyleBackColor = True
        '
        'btnAgregarProveedor
        '
        Me.btnAgregarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProveedor.Location = New System.Drawing.Point(6, 25)
        Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
        Me.btnAgregarProveedor.Size = New System.Drawing.Size(110, 31)
        Me.btnAgregarProveedor.TabIndex = 17
        Me.btnAgregarProveedor.Text = "Agregar"
        Me.btnAgregarProveedor.UseVisualStyleBackColor = True
        '
        'gbxProducto
        '
        Me.gbxProducto.Controls.Add(Me.btnModificarProducto)
        Me.gbxProducto.Controls.Add(Me.btnBorrarProducto)
        Me.gbxProducto.Controls.Add(Me.btnAgregarProducto)
        Me.gbxProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxProducto.Location = New System.Drawing.Point(238, 527)
        Me.gbxProducto.Name = "gbxProducto"
        Me.gbxProducto.Size = New System.Drawing.Size(356, 70)
        Me.gbxProducto.TabIndex = 27
        Me.gbxProducto.TabStop = False
        Me.gbxProducto.Text = "Producto"
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProducto.Location = New System.Drawing.Point(238, 25)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(110, 31)
        Me.btnModificarProducto.TabIndex = 18
        Me.btnModificarProducto.Text = "Modificar"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnBorrarProducto
        '
        Me.btnBorrarProducto.Enabled = False
        Me.btnBorrarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarProducto.Location = New System.Drawing.Point(122, 25)
        Me.btnBorrarProducto.Name = "btnBorrarProducto"
        Me.btnBorrarProducto.Size = New System.Drawing.Size(110, 31)
        Me.btnBorrarProducto.TabIndex = 18
        Me.btnBorrarProducto.Text = "Borrar"
        Me.btnBorrarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Enabled = False
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Location = New System.Drawing.Point(6, 25)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(110, 31)
        Me.btnAgregarProducto.TabIndex = 17
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'btnVolverMenuPrincipal
        '
        Me.btnVolverMenuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverMenuPrincipal.Location = New System.Drawing.Point(318, 29)
        Me.btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal"
        Me.btnVolverMenuPrincipal.Size = New System.Drawing.Size(193, 38)
        Me.btnVolverMenuPrincipal.TabIndex = 19
        Me.btnVolverMenuPrincipal.Text = "Volver al menu principal"
        Me.btnVolverMenuPrincipal.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Logo1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(100, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 72)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'frmABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(829, 631)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnVolverMenuPrincipal)
        Me.Controls.Add(Me.gbxProducto)
        Me.Controls.Add(Me.gbxProveedor)
        Me.Controls.Add(Me.pbxExtras)
        Me.Controls.Add(Me.gbxCamion)
        Me.Controls.Add(Me.gbxMaterialMontaje)
        Me.Controls.Add(Me.gbxMadera)
        Me.Controls.Add(Me.gbxTipoMueble)
        Me.Controls.Add(Me.gbxRecepcionista)
        Me.Controls.Add(Me.gbxCliente)
        Me.Controls.Add(Me.gbxTecnico)
        Me.Controls.Add(Me.gbxPersona)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmABM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Pine - ABM"
        Me.gbxPersona.ResumeLayout(False)
        Me.gbxTecnico.ResumeLayout(False)
        Me.gbxCliente.ResumeLayout(False)
        Me.gbxRecepcionista.ResumeLayout(False)
        Me.gbxTipoMueble.ResumeLayout(False)
        Me.gbxMadera.ResumeLayout(False)
        Me.gbxMaterialMontaje.ResumeLayout(False)
        Me.gbxCamion.ResumeLayout(False)
        Me.pbxExtras.ResumeLayout(False)
        Me.gbxProveedor.ResumeLayout(False)
        Me.gbxProducto.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPersona As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregarPersona As System.Windows.Forms.Button
    Friend WithEvents btnModificarPersona As System.Windows.Forms.Button
    Friend WithEvents btnBorrarPersona As System.Windows.Forms.Button
    Friend WithEvents gbxTecnico As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarTecnico As System.Windows.Forms.Button
    Friend WithEvents btnAgregarTecnico As System.Windows.Forms.Button
    Friend WithEvents gbxCliente As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregarCliente As System.Windows.Forms.Button
    Friend WithEvents gbxRecepcionista As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregarRecep As System.Windows.Forms.Button
    Friend WithEvents gbxTipoMueble As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarTM As System.Windows.Forms.Button
    Friend WithEvents btnBorrarTM As System.Windows.Forms.Button
    Friend WithEvents btnAgregarTM As System.Windows.Forms.Button
    Friend WithEvents gbxMadera As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarMadera As System.Windows.Forms.Button
    Friend WithEvents btnBorrarMadera As System.Windows.Forms.Button
    Friend WithEvents btnAgregarMadera As System.Windows.Forms.Button
    Friend WithEvents gbxMaterialMontaje As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarMM As System.Windows.Forms.Button
    Friend WithEvents btnBorrarMM As System.Windows.Forms.Button
    Friend WithEvents btnAgregarMM As System.Windows.Forms.Button
    Friend WithEvents gbxCamion As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificaCamion As System.Windows.Forms.Button
    Friend WithEvents btnAgregarCamion As System.Windows.Forms.Button
    Friend WithEvents pbxExtras As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarExtra As System.Windows.Forms.Button
    Friend WithEvents btnBorrarExtra As System.Windows.Forms.Button
    Friend WithEvents btnAgregarExtra As System.Windows.Forms.Button
    Friend WithEvents gbxProveedor As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarProveedor As System.Windows.Forms.Button
    Friend WithEvents btnBorrarProveedor As System.Windows.Forms.Button
    Friend WithEvents btnAgregarProveedor As System.Windows.Forms.Button
    Friend WithEvents gbxProducto As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificarProducto As System.Windows.Forms.Button
    Friend WithEvents btnVolverMenuPrincipal As System.Windows.Forms.Button
    Friend WithEvents btnBorrarCamion As System.Windows.Forms.Button
    Friend WithEvents btnBorrarTecnico As System.Windows.Forms.Button
    Friend WithEvents btnModificarCliente As System.Windows.Forms.Button
    Friend WithEvents btnBorrarCliente As System.Windows.Forms.Button
    Friend WithEvents btnModificarRecep As System.Windows.Forms.Button
    Friend WithEvents btnBorrarRecep As System.Windows.Forms.Button
    Friend WithEvents btnBorrarProducto As System.Windows.Forms.Button
    Friend WithEvents btnAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
