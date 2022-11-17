<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUSR
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUSR))
        Me.tsUsuarios = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbHabilitar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCortar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCopiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbPegar = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.rdActivos = New System.Windows.Forms.RadioButton()
        Me.rdEliminados = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNickName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.gbListados = New System.Windows.Forms.GroupBox()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tsUsuarios.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatos.SuspendLayout()
        Me.gbListados.SuspendLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsUsuarios
        '
        Me.tsUsuarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.tsbGuardar, Me.tsbImprimir, Me.tsbHabilitar, Me.toolStripSeparator, Me.tsbEliminar, Me.ToolStripSeparator2, Me.tsbCortar, Me.tsbCopiar, Me.tsbPegar, Me.toolStripSeparator1, Me.tsbCancelar, Me.tsbSalir})
        Me.tsUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.tsUsuarios.Name = "tsUsuarios"
        Me.tsUsuarios.Size = New System.Drawing.Size(574, 25)
        Me.tsUsuarios.TabIndex = 0
        Me.tsUsuarios.Text = "ToolStrip1"
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
        'tsbGuardar
        '
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(23, 22)
        Me.tsbGuardar.Text = "&Guardar"
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
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'tsbCopiar
        '
        Me.tsbCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCopiar.Image = CType(resources.GetObject("tsbCopiar.Image"), System.Drawing.Image)
        Me.tsbCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCopiar.Name = "tsbCopiar"
        Me.tsbCopiar.Size = New System.Drawing.Size(23, 22)
        Me.tsbCopiar.Text = "&Copiar"
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
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = Global.RelojAsistencias.My.Resources.Resources._Exit
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalir.Text = "Salir"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(6, 42)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(540, 190)
        Me.dgvUsuarios.TabIndex = 1
        '
        'rdActivos
        '
        Me.rdActivos.AutoSize = True
        Me.rdActivos.Location = New System.Drawing.Point(6, 19)
        Me.rdActivos.Name = "rdActivos"
        Me.rdActivos.Size = New System.Drawing.Size(99, 17)
        Me.rdActivos.TabIndex = 2
        Me.rdActivos.TabStop = True
        Me.rdActivos.Text = "Usuario Activos"
        Me.rdActivos.UseVisualStyleBackColor = True
        '
        'rdEliminados
        '
        Me.rdEliminados.AutoSize = True
        Me.rdEliminados.Location = New System.Drawing.Point(123, 19)
        Me.rdEliminados.Name = "rdEliminados"
        Me.rdEliminados.Size = New System.Drawing.Size(119, 17)
        Me.rdEliminados.TabIndex = 3
        Me.rdEliminados.TabStop = True
        Me.rdEliminados.Text = "Usuarios Eliminados"
        Me.rdEliminados.UseVisualStyleBackColor = True
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
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NickName"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(258, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtID.Location = New System.Drawing.Point(73, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(168, 20)
        Me.txtID.TabIndex = 9
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(73, 47)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(168, 20)
        Me.txtApellido.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(73, 75)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtNombre.TabIndex = 11
        '
        'txtNickName
        '
        Me.txtNickName.Location = New System.Drawing.Point(73, 101)
        Me.txtNickName.MaxLength = 50
        Me.txtNickName.Name = "txtNickName"
        Me.txtNickName.Size = New System.Drawing.Size(168, 20)
        Me.txtNickName.TabIndex = 12
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(354, 19)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(148, 20)
        Me.txtPassword.TabIndex = 13
        '
        'txtPassword2
        '
        Me.txtPassword2.Location = New System.Drawing.Point(354, 45)
        Me.txtPassword2.MaxLength = 50
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2.Size = New System.Drawing.Size(148, 20)
        Me.txtPassword2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(258, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Repetir Password"
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.txtID)
        Me.gbDatos.Controls.Add(Me.Label6)
        Me.gbDatos.Controls.Add(Me.Label1)
        Me.gbDatos.Controls.Add(Me.txtPassword2)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.txtPassword)
        Me.gbDatos.Controls.Add(Me.Label3)
        Me.gbDatos.Controls.Add(Me.txtNickName)
        Me.gbDatos.Controls.Add(Me.Label4)
        Me.gbDatos.Controls.Add(Me.txtNombre)
        Me.gbDatos.Controls.Add(Me.Label5)
        Me.gbDatos.Controls.Add(Me.txtApellido)
        Me.gbDatos.Location = New System.Drawing.Point(12, 36)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(535, 133)
        Me.gbDatos.TabIndex = 16
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos de Usuario"
        '
        'gbListados
        '
        Me.gbListados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbListados.Controls.Add(Me.rdActivos)
        Me.gbListados.Controls.Add(Me.dgvUsuarios)
        Me.gbListados.Controls.Add(Me.rdEliminados)
        Me.gbListados.Location = New System.Drawing.Point(12, 176)
        Me.gbListados.Name = "gbListados"
        Me.gbListados.Size = New System.Drawing.Size(552, 238)
        Me.gbListados.TabIndex = 17
        Me.gbListados.TabStop = False
        Me.gbListados.Text = "Usuarios"
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'frmUSR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 423)
        Me.Controls.Add(Me.gbListados)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.tsUsuarios)
        Me.Name = "frmUSR"
        Me.Text = "frmUSR"
        Me.tsUsuarios.ResumeLayout(False)
        Me.tsUsuarios.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.gbListados.ResumeLayout(False)
        Me.gbListados.PerformLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsUsuarios As ToolStrip
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbImprimir As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents tsbCortar As ToolStripButton
    Friend WithEvents tsbCopiar As ToolStripButton
    Friend WithEvents tsbPegar As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents tsbEliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents rdActivos As RadioButton
    Friend WithEvents rdEliminados As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNickName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents tsbHabilitar As ToolStripButton
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents gbListados As GroupBox
    Friend WithEvents ep As ErrorProvider
End Class
