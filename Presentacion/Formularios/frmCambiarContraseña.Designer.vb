<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambiarContraseña))
        Me.gbPasChg = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.lblPassword2 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtNewPass2 = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pb3 = New System.Windows.Forms.PictureBox()
        Me.pb2 = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.gbPasChg.SuspendLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbPasChg
        '
        Me.gbPasChg.Controls.Add(Me.pb3)
        Me.gbPasChg.Controls.Add(Me.pb2)
        Me.gbPasChg.Controls.Add(Me.pb1)
        Me.gbPasChg.Controls.Add(Me.Label1)
        Me.gbPasChg.Controls.Add(Me.txtNewPass)
        Me.gbPasChg.Controls.Add(Me.btnCancelar)
        Me.gbPasChg.Controls.Add(Me.btnCambiar)
        Me.gbPasChg.Controls.Add(Me.lblPassword2)
        Me.gbPasChg.Controls.Add(Me.lblPassword)
        Me.gbPasChg.Controls.Add(Me.lblUsuario)
        Me.gbPasChg.Controls.Add(Me.txtNewPass2)
        Me.gbPasChg.Controls.Add(Me.txtpassword)
        Me.gbPasChg.Controls.Add(Me.txtUsuario)
        Me.gbPasChg.Location = New System.Drawing.Point(12, 12)
        Me.gbPasChg.Name = "gbPasChg"
        Me.gbPasChg.Size = New System.Drawing.Size(268, 287)
        Me.gbPasChg.TabIndex = 0
        Me.gbPasChg.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Contraseña Nueva"
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(32, 129)
        Me.txtNewPass.MaxLength = 50
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(209, 20)
        Me.txtNewPass.TabIndex = 9
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(32, 246)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(209, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(32, 217)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(209, 23)
        Me.btnCambiar.TabIndex = 6
        Me.btnCambiar.Text = "Cambiar Contraseña"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'lblPassword2
        '
        Me.lblPassword2.AutoSize = True
        Me.lblPassword2.Location = New System.Drawing.Point(29, 152)
        Me.lblPassword2.Name = "lblPassword2"
        Me.lblPassword2.Size = New System.Drawing.Size(98, 13)
        Me.lblPassword2.TabIndex = 5
        Me.lblPassword2.Text = "Repetir Contraseña"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(29, 70)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(61, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(29, 27)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario"
        '
        'txtNewPass2
        '
        Me.txtNewPass2.Location = New System.Drawing.Point(32, 168)
        Me.txtNewPass2.MaxLength = 50
        Me.txtNewPass2.Name = "txtNewPass2"
        Me.txtNewPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass2.Size = New System.Drawing.Size(209, 20)
        Me.txtNewPass2.TabIndex = 2
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(32, 86)
        Me.txtpassword.MaxLength = 50
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(209, 20)
        Me.txtpassword.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(32, 43)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(209, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'pb3
        '
        Me.pb3.Image = Global.RelojAsistencias.My.Resources.Resources.hide
        Me.pb3.Location = New System.Drawing.Point(6, 168)
        Me.pb3.Name = "pb3"
        Me.pb3.Size = New System.Drawing.Size(20, 20)
        Me.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb3.TabIndex = 13
        Me.pb3.TabStop = False
        '
        'pb2
        '
        Me.pb2.Image = Global.RelojAsistencias.My.Resources.Resources.hide
        Me.pb2.Location = New System.Drawing.Point(6, 129)
        Me.pb2.Name = "pb2"
        Me.pb2.Size = New System.Drawing.Size(20, 20)
        Me.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb2.TabIndex = 12
        Me.pb2.TabStop = False
        '
        'pb1
        '
        Me.pb1.Image = Global.RelojAsistencias.My.Resources.Resources.hide
        Me.pb1.Location = New System.Drawing.Point(6, 86)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(20, 20)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 11
        Me.pb1.TabStop = False
        '
        'frmCambiarContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 311)
        Me.Controls.Add(Me.gbPasChg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(308, 350)
        Me.MinimumSize = New System.Drawing.Size(308, 314)
        Me.Name = "frmCambiarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Contraseña"
        Me.gbPasChg.ResumeLayout(False)
        Me.gbPasChg.PerformLayout()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbPasChg As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCambiar As Button
    Friend WithEvents lblPassword2 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtNewPass2 As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents pb3 As PictureBox
    Friend WithEvents pb2 As PictureBox
    Friend WithEvents pb1 As PictureBox
End Class
