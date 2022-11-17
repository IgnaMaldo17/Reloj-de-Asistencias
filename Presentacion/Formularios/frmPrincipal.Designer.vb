<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.msPrincipal = New System.Windows.Forms.MenuStrip()
        Me.tsmArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiIniciar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHerramientas = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAcerca = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssPrincipal = New System.Windows.Forms.StatusStrip()
        Me.tsslUsuariotext = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslNombreUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.niPrincipal = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmsNotifyIcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiInicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.msPrincipal.SuspendLayout()
        Me.ssPrincipal.SuspendLayout()
        Me.cmsNotifyIcon.SuspendLayout()
        Me.SuspendLayout()
        '
        'msPrincipal
        '
        Me.msPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmArchivo, Me.tsmHerramientas, Me.tsmAyuda})
        Me.msPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.msPrincipal.Name = "msPrincipal"
        Me.msPrincipal.Size = New System.Drawing.Size(924, 24)
        Me.msPrincipal.TabIndex = 0
        Me.msPrincipal.Text = "MenuStrip1"
        '
        'tsmArchivo
        '
        Me.tsmArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiIniciar, Me.tsmiCerrar, Me.ToolStripSeparator1, Me.tsmiSalir})
        Me.tsmArchivo.Name = "tsmArchivo"
        Me.tsmArchivo.Size = New System.Drawing.Size(60, 20)
        Me.tsmArchivo.Text = "Archivo"
        '
        'tsmiIniciar
        '
        Me.tsmiIniciar.Image = Global.RelojAsistencias.My.Resources.Resources.Login
        Me.tsmiIniciar.Name = "tsmiIniciar"
        Me.tsmiIniciar.Size = New System.Drawing.Size(180, 22)
        Me.tsmiIniciar.Text = "Iniciar sesión"
        '
        'tsmiCerrar
        '
        Me.tsmiCerrar.Enabled = False
        Me.tsmiCerrar.Image = Global.RelojAsistencias.My.Resources.Resources.Login_out
        Me.tsmiCerrar.Name = "tsmiCerrar"
        Me.tsmiCerrar.Size = New System.Drawing.Size(180, 22)
        Me.tsmiCerrar.Text = "Cerrar sesión"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'tsmiSalir
        '
        Me.tsmiSalir.Image = Global.RelojAsistencias.My.Resources.Resources._Exit
        Me.tsmiSalir.Name = "tsmiSalir"
        Me.tsmiSalir.Size = New System.Drawing.Size(180, 22)
        Me.tsmiSalir.Text = "Salir"
        '
        'tsmHerramientas
        '
        Me.tsmHerramientas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiOpciones, Me.tsmiInicio})
        Me.tsmHerramientas.Name = "tsmHerramientas"
        Me.tsmHerramientas.Size = New System.Drawing.Size(90, 20)
        Me.tsmHerramientas.Text = "Herramientas"
        Me.tsmHerramientas.Visible = False
        '
        'tsmiOpciones
        '
        Me.tsmiOpciones.Image = Global.RelojAsistencias.My.Resources.Resources.Configurar
        Me.tsmiOpciones.Name = "tsmiOpciones"
        Me.tsmiOpciones.Size = New System.Drawing.Size(180, 22)
        Me.tsmiOpciones.Text = "Opciones"
        '
        'tsmAyuda
        '
        Me.tsmAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAcerca})
        Me.tsmAyuda.Name = "tsmAyuda"
        Me.tsmAyuda.Size = New System.Drawing.Size(53, 20)
        Me.tsmAyuda.Text = "Ayuda"
        '
        'tsmiAcerca
        '
        Me.tsmiAcerca.Image = Global.RelojAsistencias.My.Resources.Resources.Ayuda
        Me.tsmiAcerca.Name = "tsmiAcerca"
        Me.tsmiAcerca.Size = New System.Drawing.Size(135, 22)
        Me.tsmiAcerca.Text = "Acerca de..."
        '
        'ssPrincipal
        '
        Me.ssPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUsuariotext, Me.tsslNombreUsuario})
        Me.ssPrincipal.Location = New System.Drawing.Point(0, 615)
        Me.ssPrincipal.Name = "ssPrincipal"
        Me.ssPrincipal.Size = New System.Drawing.Size(924, 22)
        Me.ssPrincipal.TabIndex = 1
        Me.ssPrincipal.Text = "StatusStrip1"
        '
        'tsslUsuariotext
        '
        Me.tsslUsuariotext.Name = "tsslUsuariotext"
        Me.tsslUsuariotext.Size = New System.Drawing.Size(62, 17)
        Me.tsslUsuariotext.Text = "USUARIO: "
        Me.tsslUsuariotext.Visible = False
        '
        'tsslNombreUsuario
        '
        Me.tsslNombreUsuario.Name = "tsslNombreUsuario"
        Me.tsslNombreUsuario.Size = New System.Drawing.Size(108, 17)
        Me.tsslNombreUsuario.Text = "NOMBRE USUARIO"
        Me.tsslNombreUsuario.Visible = False
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPrincipal.Location = New System.Drawing.Point(5, 35)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(912, 573)
        Me.pnlPrincipal.TabIndex = 2
        '
        'niPrincipal
        '
        Me.niPrincipal.ContextMenuStrip = Me.cmsNotifyIcon
        Me.niPrincipal.Icon = CType(resources.GetObject("niPrincipal.Icon"), System.Drawing.Icon)
        Me.niPrincipal.Text = "Reloj Asistencias"
        Me.niPrincipal.Visible = True
        '
        'cmsNotifyIcon
        '
        Me.cmsNotifyIcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem1})
        Me.cmsNotifyIcon.Name = "cmsNotifyIcon"
        Me.cmsNotifyIcon.Size = New System.Drawing.Size(97, 26)
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'tsmiInicio
        '
        Me.tsmiInicio.Image = Global.RelojAsistencias.My.Resources.Resources.home
        Me.tsmiInicio.Name = "tsmiInicio"
        Me.tsmiInicio.Size = New System.Drawing.Size(180, 22)
        Me.tsmiInicio.Text = "Inicio"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 637)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.ssPrincipal)
        Me.Controls.Add(Me.msPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msPrincipal
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reloj de Asistencias"
        Me.msPrincipal.ResumeLayout(False)
        Me.msPrincipal.PerformLayout()
        Me.ssPrincipal.ResumeLayout(False)
        Me.ssPrincipal.PerformLayout()
        Me.cmsNotifyIcon.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msPrincipal As MenuStrip
    Friend WithEvents tsmArchivo As ToolStripMenuItem
    Friend WithEvents tsmiIniciar As ToolStripMenuItem
    Friend WithEvents tsmiCerrar As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmiSalir As ToolStripMenuItem
    Friend WithEvents tsmAyuda As ToolStripMenuItem
    Friend WithEvents tsmiAcerca As ToolStripMenuItem
    Friend WithEvents ssPrincipal As StatusStrip
    Friend WithEvents tsslUsuariotext As ToolStripStatusLabel
    Friend WithEvents tsslNombreUsuario As ToolStripStatusLabel
    Friend WithEvents pnlPrincipal As Panel
    Friend WithEvents niPrincipal As NotifyIcon
    Friend WithEvents cmsNotifyIcon As ContextMenuStrip
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tsmHerramientas As ToolStripMenuItem
    Friend WithEvents tsmiOpciones As ToolStripMenuItem
    Friend WithEvents tsmiInicio As ToolStripMenuItem
End Class
