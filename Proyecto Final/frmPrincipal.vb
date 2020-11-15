Public Class frmPrincipal
    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AMToolStripMenuItem.Click
        tipoproducto = "ProceAMD"
        Label
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
        imgDefault.Visible = True
        tslBienvenido.Text = "Bienvenido " + Nombre + " " + Apellido + " " + "(" + Usuario + ") !"

    End Sub

    Private Sub tsddbProductos_Click(sender As Object, e As EventArgs) Handles tsddbProductos.Click

    End Sub



    Private Sub IntelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntelToolStripMenuItem.Click
        tipoproducto = "ProceIntel"
        Label1.Text = "Intel Core I3 9100f "
        Label2.Text = "Intel Core I5 9400f"
        Label3.Text = "Intel core I7 9700k"
        Label4.Text = "Intel core I9 9900k"
        Label5.Text = ""
        imgDefault.Visible = False
    End Sub

    Private Sub NVIDIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NVIDIAToolStripMenuItem.Click
        tipoproducto = "PlacaNvidia"
    End Sub

    Private Sub AMDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AMDToolStripMenuItem.Click
        tipoproducto = "PlacaAMD"
    End Sub

    Private Sub DiscosRígidosHDDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DiscosRígidosHDDToolStripMenuItem1.Click
        tipoproducto = "HDD"
    End Sub

    Private Sub DiscosSólidosSSDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DiscosSólidosSSDToolStripMenuItem1.Click
        tipoproducto = "SSD"
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub AuricularesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuricularesToolStripMenuItem.Click
        tipoproducto = "Auricular"
    End Sub

    Private Sub ParlantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParlantesToolStripMenuItem.Click
        tipoproducto = "Parlantes"
    End Sub

    Private Sub MemoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemoriasToolStripMenuItem.Click
        tipoproducto = "Memorias"

    End Sub

    Private Sub PenDrivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenDrivesToolStripMenuItem.Click
        tipoproducto = "Pendrives"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class