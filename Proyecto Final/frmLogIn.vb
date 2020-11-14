Public Class frmLogIn
    Private dato As String



    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblError.Text = ""
        txtContraseña.Text = ""
        txtUsuario.Text = ""

    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

        lblError.Text = ""

        If txtUsuario.Text = "admin" And txtContraseña.Text = "admin" Then
            frmPrincipal.Show()
            Me.Hide()
            txtUsuario.Text = ""
            txtContraseña.Text = ""
            lblError.Text = ""
            Exit Sub
        End If

        If txtUsuario.Text = "" Then
            lblError.Text = "Ingrese el usuario"
        Else
            If txtContraseña.Text = "" Then
                lblError.Text = "Ingrese la contraseña"
            Else
                FileOpen(1, "Usuarios.txt", OpenMode.Input)
                While Not EOF(1)
                    Input(1, Nombre)
                    Input(1, Apellido)
                    Input(1, DNI)
                    Input(1, Correo)
                    Input(1, Usuario)
                    Input(1, Contraseña)
                    If txtUsuario.Text = Usuario And txtContraseña.Text = Contraseña Then
                        FileClose(1)
                        txtUsuario.Text = ""
                        txtContraseña.Text = ""
                        frmPrincipal.Show()
                        Me.Hide()
                        Exit Sub
                    Else
                        lblError.Text = "Datos Incorrectos"
                    End If
                End While
            End If
        End If

        FileClose(1)

    End Sub

    Private Sub lblRegistro_Click(sender As Object, e As EventArgs) Handles lblRegistro.Click

        frmRegistro.Show()
        Me.Hide()

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
End Class