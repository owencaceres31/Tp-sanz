Public Class frmDatosCliente
    Private Sub frmDatosCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNombre.Text = Nombre
        txtApellido.Text = Apellido
        txtUsuario.Text = Usuario
        txtDNI.Text = DNI
        txtCorreo.Text = Correo
        txtDireccion.Text = Direccion

    End Sub
End Class