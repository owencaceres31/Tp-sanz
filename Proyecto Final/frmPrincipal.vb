Public Class frmPrincipal
    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AMToolStripMenuItem.Click

    End Sub

    Private Sub tslCerrarSesion_Click(sender As Object, e As EventArgs) Handles tslCerrarSesion.Click

        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Quiere cerrar sesión?", "CONFIRMACIÓN", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then

            Nombre = ""
            Apellido = ""
            DNI = 0
            Correo = ""
            Direccion = ""
            Usuario = ""
            Contraseña = ""

            frmLogIn.Show()
            Me.Close()

        End If

    End Sub

    Private Sub tsbMisDatos_Click(sender As Object, e As EventArgs) Handles tsbMisDatos.Click

        frmDatosCliente.Show()

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tslBienvenido.Text = "Bienvenido " + Nombre + " " + Apellido + " " + "(" + Usuario + ") !"

    End Sub
End Class