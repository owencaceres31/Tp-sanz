<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        Me.imgContraseña = New System.Windows.Forms.PictureBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        CType(Me.imgContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgContraseña
        '
        Me.imgContraseña.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgContraseña.Image = CType(resources.GetObject("imgContraseña.Image"), System.Drawing.Image)
        Me.imgContraseña.Location = New System.Drawing.Point(267, 72)
        Me.imgContraseña.Name = "imgContraseña"
        Me.imgContraseña.Size = New System.Drawing.Size(26, 20)
        Me.imgContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgContraseña.TabIndex = 15
        Me.imgContraseña.TabStop = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(104, 105)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(91, 13)
        Me.lblError.TabIndex = 14
        Me.lblError.Text = "Datos Incorrectos"
        '
        'lblRegistro
        '
        Me.lblRegistro.AutoSize = True
        Me.lblRegistro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistro.ForeColor = System.Drawing.Color.Blue
        Me.lblRegistro.Location = New System.Drawing.Point(119, 159)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(60, 13)
        Me.lblRegistro.TabIndex = 13
        Me.lblRegistro.Text = "Registrarse"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(112, 127)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 12
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(114, 72)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(142, 20)
        Me.txtContraseña.TabIndex = 11
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(114, 34)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(142, 20)
        Me.txtUsuario.TabIndex = 10
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(21, 76)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(61, 13)
        Me.lblContraseña.TabIndex = 9
        Me.lblContraseña.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(39, 37)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 8
        Me.lblUsuario.Text = "Usuario"
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 195)
        Me.Controls.Add(Me.imgContraseña)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblRegistro)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblUsuario)
        Me.Name = "frmLogIn"
        Me.Text = "Log In"
        CType(Me.imgContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgContraseña As PictureBox
    Friend WithEvents lblError As Label
    Friend WithEvents lblRegistro As Label
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblUsuario As Label
End Class
