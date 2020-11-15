Public Class frmPrincipal
    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs)

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

    Private Sub IntelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntelToolStripMenuItem.Click
        tipoproducto = "ProceIntel"
        Label1.Text = "Core ™ i9-10980XE Extreme Edition"
        Label2.Text = "Core ™ i9-9900KS"
        Label3.Text = "Core ™ i7-10700T"
        Label4.Text = "Core ™ i5-10400T"
        Label5.Text = "Core ™ i3-10320"
        PictureBox6.Image = My.Resources.i9x
        PictureBox4.Image = My.Resources.i9
        PictureBox2.Image = My.Resources.i7
        PictureBox3.Image = My.Resources.i5
        PictureBox5.Image = My.Resources.i3
        imgDefault.Visible = False
    End Sub

    Private Sub AMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AMToolStripMenuItem.Click
        tipoproducto = "ProceAMD"
        Label1.Text = "Ryzen Threadripper 3970X"
        Label2.Text = "Ryzen 9 3900XT"
        Label3.Text = "Ryzen 7 3800X"
        Label4.Text = "Ryzen 5 3600XT"
        Label5.Text = "Ryzen 3 3400G"
        PictureBox6.Image = My.Resources.threadreaper
        PictureBox4.Image = My.Resources.ryzen9
        PictureBox2.Image = My.Resources.ryzen7
        PictureBox3.Image = My.Resources.ryzen5
        PictureBox5.Image = My.Resources.ryzen53400
        imgDefault.Visible = False
    End Sub
    Private Sub NVIDIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NVIDIAToolStripMenuItem.Click
        tipoproducto = "PlacaNvidia"
        Label1.Text = "GEFORCE RTX 3090"
        Label2.Text = "TITAN RTX"
        Label3.Text = "GEFORCE RTX 2080 Ti"
        Label4.Text = "GEFORCE RTX 2060"
        Label5.Text = "GEFORCE GTX 1650 SUPER"
        PictureBox6.Image = My.Resources._3090
        PictureBox4.Image = My.Resources.titan
        PictureBox2.Image = My.Resources._2080
        PictureBox3.Image = My.Resources._2060
        PictureBox5.Image = My.Resources._1650
        imgDefault.Visible = False
    End Sub

    Private Sub AMDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AMDToolStripMenuItem.Click
        tipoproducto = "PlacaAMD"
        Label1.Text = "Radeon RX 6900 XT"
        Label2.Text = "Radeon RX 6800"
        Label3.Text = "Radeon RX 5700"
        Label4.Text = "Radeon RX 5500 XT"
        Label5.Text = "Radeon RX Vega⁶⁴"
        PictureBox6.Image = My.Resources._6900
        PictureBox4.Image = My.Resources._6800
        PictureBox2.Image = My.Resources._5700
        PictureBox3.Image = My.Resources._5500
        PictureBox5.Image = My.Resources.VEGA
        imgDefault.Visible = False
    End Sub

    Private Sub DiscosRígidosHDDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DiscosRígidosHDDToolStripMenuItem1.Click
        tipoproducto = "HDD"
        Label1.Text = "Seagate Barracuda PRO 14TB"
        Label2.Text = "Seagate FireCUDA 2TB"
        Label3.Text = "Western Digital Blue 1TB"
        Label4.Text = "Western Digital Black 1TB"
        Label5.Text = "Western Digital Gold 1TB"
        PictureBox6.Image = My.Resources.BarracudaPro
        PictureBox4.Image = My.Resources.Firecuda
        PictureBox2.Image = My.Resources.blue
        PictureBox3.Image = My.Resources.black
        PictureBox5.Image = My.Resources.gold
        imgDefault.Visible = False
    End Sub

    Private Sub DiscosSólidosSSDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DiscosSólidosSSDToolStripMenuItem1.Click
        tipoproducto = "SSD"
        Label1.Text = "Corsair Force Series MP510 240GB"
        Label2.Text = "Kingston KC2000 240GB"
        Label3.Text = "WD Blue SN550 240GB"
        Label4.Text = "Crucial MX500 240GB"
        Label5.Text = "Samsung SSD 970 Evo Plus 240GB"
        PictureBox6.Image = My.Resources.force
        PictureBox4.Image = My.Resources.kc20001
        PictureBox2.Image = My.Resources.sn550
        PictureBox3.Image = My.Resources.crucial
        PictureBox5.Image = My.Resources.samsung
        imgDefault.Visible = False
    End Sub

    Private Sub AuricularesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuricularesToolStripMenuItem.Click
        tipoproducto = "Auricular"
        Label1.Text = "Astro A40 TR + MIXAMP PRO TR"
        Label2.Text = "Razer kraken"
        Label3.Text = "HyperX Cloud Stinger"
        Label4.Text = "HyperX Cloud Revolver S"
        Label5.Text = "Razer Thresher Ultimate"
        PictureBox6.Image = My.Resources.a40
        PictureBox4.Image = My.Resources.kraken
        PictureBox2.Image = My.Resources.stinger
        PictureBox3.Image = My.Resources.revolver
        PictureBox5.Image = My.Resources.RAZER
        imgDefault.Visible = False
    End Sub

    Private Sub ParlantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParlantesToolStripMenuItem.Click
        tipoproducto = "Parlantes"
        Label1.Text = "Logitech G560"
        Label2.Text = "Creative GigaWorks T20"
        Label3.Text = "Bose Companion 2 Serie III"
        Label4.Text = "Razer Nommo Pro"
        Label5.Text = "Logitech Z623"
        PictureBox6.Image = My.Resources.i9x
        PictureBox4.Image = My.Resources.i9
        PictureBox2.Image = My.Resources.i7
        PictureBox3.Image = My.Resources.i5
        PictureBox5.Image = My.Resources.i3
        imgDefault.Visible = False
    End Sub

    Private Sub MemoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemoriasToolStripMenuItem.Click
        tipoproducto = "MicroSD"
        Label1.Text = "Kingston 16GB"
        Label2.Text = "Kingston 64GB"
        Label3.Text = "Kingston 32GB"
        Label4.Text = "Kingston 128GB"
        Label5.Text = "Verbatim 32GB"
        PictureBox6.Image = My.Resources.i9x
        PictureBox4.Image = My.Resources.i9
        PictureBox2.Image = My.Resources.i7
        PictureBox3.Image = My.Resources.i5
        PictureBox5.Image = My.Resources.i3
        imgDefault.Visible = False

    End Sub

    Private Sub PenDrivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenDrivesToolStripMenuItem.Click
        tipoproducto = "Pendrives"
        Label1.Text = "SanDisk Cruzer Blade 32GB"
        Label2.Text = "Kingston DataTraveler G4 32GB"
        Label3.Text = "SanDisk Ultra Fit 32GB"
        Label4.Text = "SanDisk Ultra Dual 64GB"
        Label5.Text = "Verbatim Store 'n' Go Slider 32GB"
        PictureBox6.Image = My.Resources.threadreaper
        PictureBox4.Image = My.Resources.ryzen9
        PictureBox2.Image = My.Resources.ryzen7
        PictureBox3.Image = My.Resources.ryzen5
        PictureBox5.Image = My.Resources.ryzen53400
        imgDefault.Visible = False
    End Sub
End Class
