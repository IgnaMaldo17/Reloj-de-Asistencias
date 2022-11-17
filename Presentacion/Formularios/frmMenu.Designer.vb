<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.tbpMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnFichador = New System.Windows.Forms.Button()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnCambiarContraseña = New System.Windows.Forms.Button()
        Me.tbpMenu.SuspendLayout()
        Me.gbLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpMenu
        '
        Me.tbpMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbpMenu.ColumnCount = 3
        Me.tbpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tbpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tbpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tbpMenu.Controls.Add(Me.gbLogin, 1, 1)
        Me.tbpMenu.Controls.Add(Me.lblDescripcion, 1, 2)
        Me.tbpMenu.Location = New System.Drawing.Point(8, 3)
        Me.tbpMenu.Name = "tbpMenu"
        Me.tbpMenu.RowCount = 3
        Me.tbpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.49637!))
        Me.tbpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.45098!))
        Me.tbpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.05882!))
        Me.tbpMenu.Size = New System.Drawing.Size(830, 510)
        Me.tbpMenu.TabIndex = 2
        '
        'gbLogin
        '
        Me.gbLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbLogin.Controls.Add(Me.btnFichador)
        Me.gbLogin.Controls.Add(Me.btnPersonal)
        Me.gbLogin.Controls.Add(Me.btnUsuarios)
        Me.gbLogin.Controls.Add(Me.btnCambiarContraseña)
        Me.gbLogin.Location = New System.Drawing.Point(229, 135)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(372, 230)
        Me.gbLogin.TabIndex = 0
        Me.gbLogin.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(415, 449)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(0, 33)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFichador
        '
        Me.btnFichador.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFichador.Image = CType(resources.GetObject("btnFichador.Image"), System.Drawing.Image)
        Me.btnFichador.Location = New System.Drawing.Point(186, 19)
        Me.btnFichador.Name = "btnFichador"
        Me.btnFichador.Size = New System.Drawing.Size(164, 95)
        Me.btnFichador.TabIndex = 3
        Me.btnFichador.Text = "Registro de Asistencias"
        Me.btnFichador.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFichador.UseVisualStyleBackColor = True
        '
        'btnPersonal
        '
        Me.btnPersonal.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPersonal.Image = CType(resources.GetObject("btnPersonal.Image"), System.Drawing.Image)
        Me.btnPersonal.Location = New System.Drawing.Point(16, 120)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(164, 95)
        Me.btnPersonal.TabIndex = 2
        Me.btnPersonal.Text = "Personal"
        Me.btnPersonal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPersonal.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.Image = CType(resources.GetObject("btnUsuarios.Image"), System.Drawing.Image)
        Me.btnUsuarios.Location = New System.Drawing.Point(16, 19)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(164, 95)
        Me.btnUsuarios.TabIndex = 0
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnCambiarContraseña
        '
        Me.btnCambiarContraseña.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarContraseña.Image = CType(resources.GetObject("btnCambiarContraseña.Image"), System.Drawing.Image)
        Me.btnCambiarContraseña.Location = New System.Drawing.Point(186, 120)
        Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
        Me.btnCambiarContraseña.Size = New System.Drawing.Size(164, 95)
        Me.btnCambiarContraseña.TabIndex = 1
        Me.btnCambiarContraseña.Text = "Cambiar Contraseña"
        Me.btnCambiarContraseña.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCambiarContraseña.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 513)
        Me.Controls.Add(Me.tbpMenu)
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.tbpMenu.ResumeLayout(False)
        Me.tbpMenu.PerformLayout()
        Me.gbLogin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnCambiarContraseña As Button
    Friend WithEvents tbpMenu As TableLayoutPanel
    Friend WithEvents gbLogin As GroupBox
    Friend WithEvents btnFichador As Button
    Friend WithEvents btnPersonal As Button
    Friend WithEvents lblDescripcion As Label
End Class
