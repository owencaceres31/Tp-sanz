<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Me.lblLogIn = New System.Windows.Forms.Label()
        Me.gbErrores = New System.Windows.Forms.GroupBox()
        Me.lblEContraseña = New System.Windows.Forms.Label()
        Me.lblEUsuario = New System.Windows.Forms.Label()
        Me.lblECorreo = New System.Windows.Forms.Label()
        Me.lblEDNI = New System.Windows.Forms.Label()
        Me.lblEApellido = New System.Windows.Forms.Label()
        Me.lblENombre = New System.Windows.Forms.Label()
        Me.cmdRegistrarse = New System.Windows.Forms.Button()
        Me.cbCorreo = New System.Windows.Forms.ComboBox()
        Me.imgContraseña = New System.Windows.Forms.PictureBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.gbErrores.SuspendLayout()
        CType(Me.imgContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLogIn
        '
        Me.lblLogIn.AutoSize = True
        Me.lblLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblLogIn.Location = New System.Drawing.Point(186, 216)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(68, 13)
        Me.lblLogIn.TabIndex = 41
        Me.lblLogIn.Text = "Iniciar sesión"
        '
        'gbErrores
        '
        Me.gbErrores.Controls.Add(Me.lblEContraseña)
        Me.gbErrores.Controls.Add(Me.lblEUsuario)
        Me.gbErrores.Controls.Add(Me.lblECorreo)
        Me.gbErrores.Controls.Add(Me.lblEDNI)
        Me.gbErrores.Controls.Add(Me.lblEApellido)
        Me.gbErrores.Controls.Add(Me.lblENombre)
        Me.gbErrores.Location = New System.Drawing.Point(30, 236)
        Me.gbErrores.Name = "gbErrores"
        Me.gbErrores.Size = New System.Drawing.Size(384, 95)
        Me.gbErrores.TabIndex = 40
        Me.gbErrores.TabStop = False
        Me.gbErrores.Text = "Información sobre Errores"
        '
        'lblEContraseña
        '
        Me.lblEContraseña.AutoSize = True
        Me.lblEContraseña.Location = New System.Drawing.Point(191, 66)
        Me.lblEContraseña.Name = "lblEContraseña"
        Me.lblEContraseña.Size = New System.Drawing.Size(61, 13)
        Me.lblEContraseña.TabIndex = 6
        Me.lblEContraseña.Text = "Contraseña"
        '
        'lblEUsuario
        '
        Me.lblEUsuario.AutoSize = True
        Me.lblEUsuario.Location = New System.Drawing.Point(191, 46)
        Me.lblEUsuario.Name = "lblEUsuario"
        Me.lblEUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblEUsuario.TabIndex = 5
        Me.lblEUsuario.Text = "Usuario"
        '
        'lblECorreo
        '
        Me.lblECorreo.AutoSize = True
        Me.lblECorreo.Location = New System.Drawing.Point(191, 24)
        Me.lblECorreo.Name = "lblECorreo"
        Me.lblECorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblECorreo.TabIndex = 4
        Me.lblECorreo.Text = "Correo"
        '
        'lblEDNI
        '
        Me.lblEDNI.AutoSize = True
        Me.lblEDNI.Location = New System.Drawing.Point(13, 67)
        Me.lblEDNI.Name = "lblEDNI"
        Me.lblEDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblEDNI.TabIndex = 2
        Me.lblEDNI.Text = "DNI"
        '
        'lblEApellido
        '
        Me.lblEApellido.AutoSize = True
        Me.lblEApellido.Location = New System.Drawing.Point(13, 46)
        Me.lblEApellido.Name = "lblEApellido"
        Me.lblEApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblEApellido.TabIndex = 1
        Me.lblEApellido.Text = "Apellido"
        '
        'lblENombre
        '
        Me.lblENombre.AutoSize = True
        Me.lblENombre.Location = New System.Drawing.Point(13, 25)
        Me.lblENombre.Name = "lblENombre"
        Me.lblENombre.Size = New System.Drawing.Size(44, 13)
        Me.lblENombre.TabIndex = 0
        Me.lblENombre.Text = "Nombre"
        '
        'cmdRegistrarse
        '
        Me.cmdRegistrarse.Location = New System.Drawing.Point(124, 185)
        Me.cmdRegistrarse.Name = "cmdRegistrarse"
        Me.cmdRegistrarse.Size = New System.Drawing.Size(192, 23)
        Me.cmdRegistrarse.TabIndex = 38
        Me.cmdRegistrarse.Text = "Registrarse"
        Me.cmdRegistrarse.UseVisualStyleBackColor = True
        '
        'cbCorreo
        '
        Me.cbCorreo.FormattingEnabled = True
        Me.cbCorreo.Items.AddRange(New Object() {"@gmail.com", "@hotmail.com", "@outlook.com", "@alumno.huergo.edu.ar", "@huergo.edu.ar"})
        Me.cbCorreo.Location = New System.Drawing.Point(295, 100)
        Me.cbCorreo.Name = "cbCorreo"
        Me.cbCorreo.Size = New System.Drawing.Size(79, 21)
        Me.cbCorreo.TabIndex = 37
        Me.cbCorreo.Text = "Seleccionar"
        '
        'imgContraseña
        '
        Me.imgContraseña.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgContraseña.Image = CType(resources.GetObject("imgContraseña.Image"), System.Drawing.Image)
        Me.imgContraseña.Location = New System.Drawing.Point(353, 153)
        Me.imgContraseña.Name = "imgContraseña"
        Me.imgContraseña.Size = New System.Drawing.Size(21, 20)
        Me.imgContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgContraseña.TabIndex = 36
        Me.imgContraseña.TabStop = False
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(159, 153)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(188, 20)
        Me.txtContraseña.TabIndex = 35
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(159, 127)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(215, 20)
        Me.txtUsuario.TabIndex = 34
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(159, 100)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(130, 20)
        Me.txtCorreo.TabIndex = 33
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(160, 74)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(215, 20)
        Me.txtDNI.TabIndex = 32
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(160, 48)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(215, 20)
        Me.txtApellido.TabIndex = 31
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(160, 22)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(215, 20)
        Me.txtNombre.TabIndex = 30
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(73, 157)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(61, 13)
        Me.lblContraseña.TabIndex = 29
        Me.lblContraseña.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(91, 131)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 28
        Me.lblUsuario.Text = "Usuario"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(96, 104)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lblCorreo.TabIndex = 27
        Me.lblCorreo.Text = "Correo"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(100, 78)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(35, 13)
        Me.lblDNI.TabIndex = 25
        Me.lblDNI.Text = "D.N.I."
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(91, 52)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 24
        Me.lblApellido.Text = "Apellido"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(91, 26)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 23
        Me.lblNombre.Text = "Nombre"
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 367)
        Me.Controls.Add(Me.lblLogIn)
        Me.Controls.Add(Me.gbErrores)
        Me.Controls.Add(Me.cmdRegistrarse)
        Me.Controls.Add(Me.cbCorreo)
        Me.Controls.Add(Me.imgContraseña)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "frmRegistro"
        Me.Text = "Registro"
        Me.gbErrores.ResumeLayout(False)
        Me.gbErrores.PerformLayout()
        CType(Me.imgContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogIn As Label
    Friend WithEvents gbErrores As GroupBox
    Friend WithEvents lblEContraseña As Label
    Friend WithEvents lblEUsuario As Label
    Friend WithEvents lblECorreo As Label
    Friend WithEvents lblEDNI As Label
    Friend WithEvents lblEApellido As Label
    Friend WithEvents lblENombre As Label
    Friend WithEvents cmdRegistrarse As Button
    Friend WithEvents cbCorreo As ComboBox
    Friend WithEvents imgContraseña As PictureBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblNombre As Label
End Class
