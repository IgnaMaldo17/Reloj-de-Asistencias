<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEMP
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEMP))
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.dtpFecNac = New System.Windows.Forms.DateTimePicker()
        Me.cbSector = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtID2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.gbListados = New System.Windows.Forms.GroupBox()
        Me.rdActivos = New System.Windows.Forms.RadioButton()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.rdEliminados = New System.Windows.Forms.RadioButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbPegar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCopiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCortar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHabilitar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsUsuarios = New System.Windows.Forms.ToolStrip()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatos.SuspendLayout()
        Me.gbListados.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'gbDatos
        '
        Me.gbDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbDatos.Controls.Add(Me.dtpFecNac)
        Me.gbDatos.Controls.Add(Me.cbSector)
        Me.gbDatos.Controls.Add(Me.Label8)
        Me.gbDatos.Controls.Add(Me.txtID2)
        Me.gbDatos.Controls.Add(Me.Label6)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.txtDireccion)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.txtNombre)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txtApellido)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.txtDNI)
        Me.gbDatos.Location = New System.Drawing.Point(12, 42)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(513, 133)
        Me.gbDatos.TabIndex = 19
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos de Usuario"
        '
        'dtpFecNac
        '
        Me.dtpFecNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNac.Location = New System.Drawing.Point(354, 78)
        Me.dtpFecNac.MaxDate = New Date(2022, 10, 27, 0, 0, 0, 0)
        Me.dtpFecNac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFecNac.Name = "dtpFecNac"
        Me.dtpFecNac.Size = New System.Drawing.Size(148, 22)
        Me.dtpFecNac.TabIndex = 19
        Me.dtpFecNac.Value = New Date(2022, 10, 26, 0, 0, 0, 0)
        '
        'cbSector
        '
        Me.cbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSector.FormattingEnabled = True
        Me.cbSector.Location = New System.Drawing.Point(354, 47)
        Me.cbSector.MaxLength = 50
        Me.cbSector.Name = "cbSector"
        Me.cbSector.Size = New System.Drawing.Size(148, 21)
        Me.cbSector.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(257, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fec Nacimiento"
        '
        'txtID2
        '
        Me.txtID2.Location = New System.Drawing.Point(73, 19)
        Me.txtID2.MaxLength = 10
        Me.txtID2.Name = "txtID2"
        Me.txtID2.Size = New System.Drawing.Size(168, 20)
        Me.txtID2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(258, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Sector"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DNI"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(354, 19)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(148, 20)
        Me.txtDireccion.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(73, 101)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtNombre.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(73, 75)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(168, 20)
        Me.txtApellido.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dirección"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(73, 47)
        Me.txtDNI.MaxLength = 10
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(168, 20)
        Me.txtDNI.TabIndex = 10
        '
        'gbListados
        '
        Me.gbListados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbListados.Controls.Add(Me.rdActivos)
        Me.gbListados.Controls.Add(Me.dgvEmpleados)
        Me.gbListados.Controls.Add(Me.rdEliminados)
        Me.gbListados.Location = New System.Drawing.Point(12, 182)
        Me.gbListados.Name = "gbListados"
        Me.gbListados.Size = New System.Drawing.Size(738, 256)
        Me.gbListados.TabIndex = 20
        Me.gbListados.TabStop = False
        Me.gbListados.Text = "Personal"
        '
        'rdActivos
        '
        Me.rdActivos.AutoSize = True
        Me.rdActivos.Location = New System.Drawing.Point(6, 19)
        Me.rdActivos.Name = "rdActivos"
        Me.rdActivos.Size = New System.Drawing.Size(99, 17)
        Me.rdActivos.TabIndex = 2
        Me.rdActivos.TabStop = True
        Me.rdActivos.Text = "Personal Activo"
        Me.rdActivos.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleados.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Location = New System.Drawing.Point(6, 42)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleados.Size = New System.Drawing.Size(726, 208)
        Me.dgvEmpleados.TabIndex = 1
        '
        'rdEliminados
        '
        Me.rdEliminados.AutoSize = True
        Me.rdEliminados.Location = New System.Drawing.Point(123, 19)
        Me.rdEliminados.Name = "rdEliminados"
        Me.rdEliminados.Size = New System.Drawing.Size(114, 17)
        Me.rdEliminados.TabIndex = 3
        Me.rdEliminados.TabStop = True
        Me.rdEliminados.Text = "Personal Eliminado"
        Me.rdEliminados.UseVisualStyleBackColor = True
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = Global.RelojAsistencias.My.Resources.Resources._Exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Text = "Salir"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(23, 22)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbPegar
        '
        Me.tsbPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPegar.Image = CType(resources.GetObject("tsbPegar.Image"), System.Drawing.Image)
        Me.tsbPegar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPegar.Name = "tsbPegar"
        Me.tsbPegar.Size = New System.Drawing.Size(23, 22)
        Me.tsbPegar.Text = "&Pegar"
        '
        'tsbCopiar
        '
        Me.tsbCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCopiar.Image = CType(resources.GetObject("tsbCopiar.Image"), System.Drawing.Image)
        Me.tsbCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCopiar.Name = "tsbCopiar"
        Me.tsbCopiar.Size = New System.Drawing.Size(23, 22)
        Me.tsbCopiar.Text = "&Copiar"
        '
        'tsbCortar
        '
        Me.tsbCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCortar.Image = CType(resources.GetObject("tsbCortar.Image"), System.Drawing.Image)
        Me.tsbCortar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCortar.Name = "tsbCortar"
        Me.tsbCortar.Size = New System.Drawing.Size(23, 22)
        Me.tsbCortar.Text = "Cort&ar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbEliminar
        '
        Me.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(23, 22)
        Me.tsbEliminar.Text = "Eliminar"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'tsbHabilitar
        '
        Me.tsbHabilitar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHabilitar.Enabled = False
        Me.tsbHabilitar.Image = Global.RelojAsistencias.My.Resources.Resources.Aprobado
        Me.tsbHabilitar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHabilitar.Name = "tsbHabilitar"
        Me.tsbHabilitar.Size = New System.Drawing.Size(23, 22)
        Me.tsbHabilitar.Text = "Recuperar Usuario"
        '
        'tsbImprimir
        '
        Me.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbImprimir.Image = CType(resources.GetObject("tsbImprimir.Image"), System.Drawing.Image)
        Me.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimir.Name = "tsbImprimir"
        Me.tsbImprimir.Size = New System.Drawing.Size(23, 22)
        Me.tsbImprimir.Text = "&Imprimir"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGuardar.Text = "&Guardar"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), System.Drawing.Image)
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(23, 22)
        Me.tsbNuevo.Text = "&Nuevo"
        '
        'tsUsuarios
        '
        Me.tsUsuarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.tsbGuardar, Me.tsbImprimir, Me.tsbHabilitar, Me.toolStripSeparator, Me.tsbEliminar, Me.ToolStripSeparator2, Me.tsbCortar, Me.tsbCopiar, Me.tsbPegar, Me.toolStripSeparator1, Me.tsbCancelar, Me.tsbSalir})
        Me.tsUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.tsUsuarios.Name = "tsUsuarios"
        Me.tsUsuarios.Size = New System.Drawing.Size(762, 25)
        Me.tsUsuarios.TabIndex = 18
        Me.tsUsuarios.Text = "ToolStrip1"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frmEMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 450)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.gbListados)
        Me.Controls.Add(Me.tsUsuarios)
        Me.Name = "frmEMP"
        Me.Text = "frmEMP"
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbListados.ResumeLayout(False)
        Me.gbListados.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsUsuarios.ResumeLayout(False)
        Me.tsUsuarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ep As ErrorProvider
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents txtID2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents gbListados As GroupBox
    Friend WithEvents rdActivos As RadioButton
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents rdEliminados As RadioButton
    Friend WithEvents tsUsuarios As ToolStrip
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbImprimir As ToolStripButton
    Friend WithEvents tsbHabilitar As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents tsbEliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCortar As ToolStripButton
    Friend WithEvents tsbCopiar As ToolStripButton
    Friend WithEvents tsbPegar As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpFecNac As DateTimePicker
    Friend WithEvents cbSector As ComboBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
