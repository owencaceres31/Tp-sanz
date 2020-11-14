Public Class frmRegistro
    Dim Correo = "^([0-9a-zA-z]([-.\w][0-9a-zA-Z])@([0-9a-zA-z][-\w]*[0-9a-zA-Z].)+[a-zA-Z]{2,9})$"
    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNombre.Text = ""
        txtApellido.Text = ""
        txtContraseña.Text = ""
        txtCorreo.Text = ""
        txtDNI.Text = ""
        txtUsuario.Text = ""

    End Sub

    Private Sub cmdRegistrarse_Click(sender As Object, e As EventArgs) Handles cmdRegistrarse.Click

        Dim cantPalabras, totalPalabras As Integer
        Dim cantErrores As Integer
        Dim cantNum As Integer
        Dim frase As String

        cantErrores = 0

        If txtNombre.Text = "" Then
            lblENombre.Text = "Ingrese su nombre"
            cantErrores += 1
        Else
            lblENombre.Text = "Nombre: ✔"
        End If

        If txtApellido.Text = "" Then
            lblEApellido.Text = "Ingrese su apellido"
            cantErrores += 1
        Else
            lblEApellido.Text = "Apellido: ✔"
        End If

        If txtDNI.Text = "" Then
            lblEDNI.Text = "Ingrese su DNI"
            cantErrores += 1
        End If
        cantNum = Len(txtDNI.Text)
        If txtDNI.Text <> "" Then
            If Not IsNumeric(txtDNI.Text) = True Then
                lblEDNI.Text = "DNI: Formato Incorrecto"
                cantErrores += 1
            Else
                If cantNum = 8 Or cantNum = 9 Then
                    lblEDNI.Text = "DNI: ✔"
                Else
                    lblEDNI.Text = "DNI: Cantidad de Dígitos Incorrecta"
                    cantErrores += 1
                End If
            End If
        End If

        If txtCorreo.Text <> "" Then
            lblECorreo.Text = "Correo: ✔"
        Else
            If txtCorreo.Text = "" Then
                lblECorreo.Text = "Ingrese un correo"
                cantErrores += 1
            End If
        End If

        If cbCorreo.SelectedIndex = -1 Then
            lblECorreo.Text = "Correo: Dominio invalido"
            cantErrores += 1
        End If

        frase = txtUsuario.Text
        cantPalabras = 0
        totalPalabras = 0

        For c = 1 To Len(Trim(frase))
            If Mid(Trim(frase), c, 1) = " " Then
                cantPalabras += 1
            End If
        Next

        totalPalabras = cantPalabras + 1

        If txtUsuario.Text = "" Then
            lblEUsuario.Text = "Ingrese un nombre de usuario"
            cantErrores += 1
        Else
            If totalPalabras = 1 Then
                If txtUsuario.Text = Usuario Then
                    lblEUsuario.Text = "Nombre de Usuario ya registrado"
                    cantErrores += 1
                Else
                    lblEUsuario.Text = "Usuario: ✔"
                End If
            Else
                lblEUsuario.Text = "Usuario: Solo 1 palabra"
                cantErrores += 1
            End If
        End If

        If txtContraseña.Text = "" Then
            lblEContraseña.Text = "Ingrese una contraseña"
            cantErrores = cantErrores + 1
        Else
            lblEContraseña.Text = "Contraseña: ✔"
        End If

        If cantErrores = 0 Then
            FileOpen(1, "Usuarios.txt", OpenMode.Append)
            Write(1, txtNombre.Text,
                  txtApellido.Text,
                  txtDNI.Text,
                  txtCorreo.Text + cbCorreo.SelectedItem.ToString(),
                  txtUsuario.Text,
                  txtContraseña.Text)
            FileClose(1)
            frmLogIn.Show()
            Me.Close()
        End If

    End Sub

    Private Sub imgContraseña_Click(sender As Object, e As EventArgs) Handles imgContraseña.Click

        Dim caracterPass As String

        caracterPass = txtContraseña.PasswordChar.ToString()

        If txtContraseña.PasswordChar = "*" Then
            txtContraseña.PasswordChar = ""
        End If

        If txtContraseña.PasswordChar = caracterPass Then
            txtContraseña.PasswordChar = "*"
        End If

    End Sub

    Private Sub lblLogIn_Click(sender As Object, e As EventArgs) Handles lblLogIn.Click

        frmLogIn.Show()
        Me.Hide()

    End Sub
End Class
