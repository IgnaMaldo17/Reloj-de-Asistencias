<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistroAsistencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistroAsistencias))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbpRegistro = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbUsuario = New System.Windows.Forms.PictureBox()
        Me.txtPersonal = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.pbCodigo = New System.Windows.Forms.PictureBox()
        Me.txtbarra = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.tmrDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tbpRegistro.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 572)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.tbpRegistro)
        Me.GroupBox3.Location = New System.Drawing.Point(46, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(752, 387)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'tbpRegistro
        '
        Me.tbpRegistro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbpRegistro.ColumnCount = 2
        Me.tbpRegistro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.97043!))
        Me.tbpRegistro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.02956!))
        Me.tbpRegistro.Controls.Add(Me.PictureBox1, 0, 2)
        Me.tbpRegistro.Controls.Add(Me.pbUsuario, 0, 0)
        Me.tbpRegistro.Controls.Add(Me.txtPersonal, 1, 0)
        Me.tbpRegistro.Controls.Add(Me.txtCodigo, 1, 1)
        Me.tbpRegistro.Controls.Add(Me.pbCodigo, 0, 1)
        Me.tbpRegistro.Controls.Add(Me.txtbarra, 1, 2)
        Me.tbpRegistro.Location = New System.Drawing.Point(58, 13)
        Me.tbpRegistro.Name = "tbpRegistro"
        Me.tbpRegistro.RowCount = 3
        Me.tbpRegistro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.tbpRegistro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tbpRegistro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tbpRegistro.Size = New System.Drawing.Size(626, 368)
        Me.tbpRegistro.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 251)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pbUsuario
        '
        Me.pbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbUsuario.Image = CType(resources.GetObject("pbUsuario.Image"), System.Drawing.Image)
        Me.pbUsuario.Location = New System.Drawing.Point(3, 9)
        Me.pbUsuario.Name = "pbUsuario"
        Me.pbUsuario.Size = New System.Drawing.Size(144, 107)
        Me.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUsuario.TabIndex = 4
        Me.pbUsuario.TabStop = False
        '
        'txtPersonal
        '
        Me.txtPersonal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPersonal.Enabled = False
        Me.txtPersonal.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonal.Location = New System.Drawing.Point(153, 20)
        Me.txtPersonal.Name = "txtPersonal"
        Me.txtPersonal.Size = New System.Drawing.Size(470, 85)
        Me.txtPersonal.TabIndex = 1
        Me.txtPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.No
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(153, 143)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(470, 85)
        Me.txtCodigo.TabIndex = 2
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbCodigo
        '
        Me.pbCodigo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbCodigo.Image = CType(resources.GetObject("pbCodigo.Image"), System.Drawing.Image)
        Me.pbCodigo.Location = New System.Drawing.Point(3, 130)
        Me.pbCodigo.Name = "pbCodigo"
        Me.pbCodigo.Size = New System.Drawing.Size(144, 111)
        Me.pbCodigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCodigo.TabIndex = 5
        Me.pbCodigo.TabStop = False
        '
        'txtbarra
        '
        Me.txtbarra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtbarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbarra.Cursor = System.Windows.Forms.Cursors.No
        Me.txtbarra.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbarra.Location = New System.Drawing.Point(153, 264)
        Me.txtbarra.MaxLength = 10
        Me.txtbarra.Name = "txtbarra"
        Me.txtbarra.Size = New System.Drawing.Size(470, 85)
        Me.txtbarra.TabIndex = 6
        Me.txtbarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.lblHora)
        Me.GroupBox2.Controls.Add(Me.pbLogo)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(799, 129)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'lblHora
        '
        Me.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(169, 39)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(179, 58)
        Me.lblHora.TabIndex = 2
        Me.lblHora.Text = "Horario"
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbLogo.Image = Global.RelojAsistencias.My.Resources.Resources.reloj1
        Me.pbLogo.Location = New System.Drawing.Point(6, 18)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(157, 100)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 3
        Me.pbLogo.TabStop = False
        '
        'tmrDateTime
        '
        '
        'frmRegistroAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 581)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRegistroAsistencias"
        Me.Text = "frmRegistroAsistencias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.tbpRegistro.ResumeLayout(False)
        Me.tbpRegistro.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tmrDateTime As Timer
    Friend WithEvents tbpRegistro As TableLayoutPanel
    Friend WithEvents lblHora As Label
    Friend WithEvents pbUsuario As PictureBox
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtPersonal As TextBox
    Friend WithEvents pbCodigo As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtbarra As TextBox
End Class
