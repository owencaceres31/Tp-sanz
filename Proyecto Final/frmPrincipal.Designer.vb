<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsddbProductos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ProcesadoresCPUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MotherboardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlacasDeVideoGPUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NVIDIAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AMDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TecladosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MousesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GabinetesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemoriasRAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscosRígidosHDDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscosRígidosHDDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscosSólidosSSDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuricularesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParlantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuentesDeAlimentaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenamientoPortátilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenDrivesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbMisDatos = New System.Windows.Forms.ToolStripButton()
        Me.tslCerrarSesion = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslBienvenido = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.imgDefault = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsddbProductos, Me.tsbMisDatos, Me.tslCerrarSesion, Me.ToolStripSeparator1, Me.tslBienvenido})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 177)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1431, 38)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsddbProductos
        '
        Me.tsddbProductos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcesadoresCPUToolStripMenuItem, Me.MotherboardsToolStripMenuItem, Me.PlacasDeVideoGPUToolStripMenuItem, Me.MonitoresToolStripMenuItem, Me.TecladosToolStripMenuItem, Me.MousesToolStripMenuItem, Me.GabinetesToolStripMenuItem, Me.MemoriasRAMToolStripMenuItem, Me.DiscosRígidosHDDToolStripMenuItem, Me.AudioToolStripMenuItem, Me.AccesoriosToolStripMenuItem, Me.FuentesDeAlimentaciónToolStripMenuItem, Me.AlmacenamientoPortátilToolStripMenuItem})
        Me.tsddbProductos.Image = Global.Proyecto_Final.My.Resources.Resources.monitor_dibujo
        Me.tsddbProductos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsddbProductos.Name = "tsddbProductos"
        Me.tsddbProductos.Size = New System.Drawing.Size(135, 33)
        Me.tsddbProductos.Text = "Productos"
        '
        'ProcesadoresCPUToolStripMenuItem
        '
        Me.ProcesadoresCPUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IntelToolStripMenuItem, Me.AMToolStripMenuItem})
        Me.ProcesadoresCPUToolStripMenuItem.Name = "ProcesadoresCPUToolStripMenuItem"
        Me.ProcesadoresCPUToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.ProcesadoresCPUToolStripMenuItem.Text = "Procesadores (CPU)"
        '
        'IntelToolStripMenuItem
        '
        Me.IntelToolStripMenuItem.Image = Global.Proyecto_Final.My.Resources.Resources.images
        Me.IntelToolStripMenuItem.Name = "IntelToolStripMenuItem"
        Me.IntelToolStripMenuItem.Size = New System.Drawing.Size(155, 34)
        Me.IntelToolStripMenuItem.Text = "Intel"
        '
        'AMToolStripMenuItem
        '
        Me.AMToolStripMenuItem.Image = Global.Proyecto_Final.My.Resources.Resources.AMD_Arrows
        Me.AMToolStripMenuItem.Name = "AMToolStripMenuItem"
        Me.AMToolStripMenuItem.Size = New System.Drawing.Size(155, 34)
        Me.AMToolStripMenuItem.Text = "AMD"
        '
        'MotherboardsToolStripMenuItem
        '
        Me.MotherboardsToolStripMenuItem.Name = "MotherboardsToolStripMenuItem"
        Me.MotherboardsToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.MotherboardsToolStripMenuItem.Text = "Motherboards"
        '
        'PlacasDeVideoGPUToolStripMenuItem
        '
        Me.PlacasDeVideoGPUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NVIDIAToolStripMenuItem, Me.AMDToolStripMenuItem})
        Me.PlacasDeVideoGPUToolStripMenuItem.Name = "PlacasDeVideoGPUToolStripMenuItem"
        Me.PlacasDeVideoGPUToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.PlacasDeVideoGPUToolStripMenuItem.Text = "Placas de Video (GPU)"
        '
        'NVIDIAToolStripMenuItem
        '
        Me.NVIDIAToolStripMenuItem.Image = Global.Proyecto_Final.My.Resources.Resources.NVIDIA_Color
        Me.NVIDIAToolStripMenuItem.Name = "NVIDIAToolStripMenuItem"
        Me.NVIDIAToolStripMenuItem.Size = New System.Drawing.Size(173, 34)
        Me.NVIDIAToolStripMenuItem.Text = "NVIDIA"
        '
        'AMDToolStripMenuItem
        '
        Me.AMDToolStripMenuItem.Image = Global.Proyecto_Final.My.Resources.Resources.AMD_Arrows
        Me.AMDToolStripMenuItem.Name = "AMDToolStripMenuItem"
        Me.AMDToolStripMenuItem.Size = New System.Drawing.Size(173, 34)
        Me.AMDToolStripMenuItem.Text = "AMD"
        '
        'MonitoresToolStripMenuItem
        '
        Me.MonitoresToolStripMenuItem.Name = "MonitoresToolStripMenuItem"
        Me.MonitoresToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.MonitoresToolStripMenuItem.Text = "Monitores"
        '
        'TecladosToolStripMenuItem
        '
        Me.TecladosToolStripMenuItem.Name = "TecladosToolStripMenuItem"
        Me.TecladosToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.TecladosToolStripMenuItem.Text = "Teclados"
        '
        'MousesToolStripMenuItem
        '
        Me.MousesToolStripMenuItem.Name = "MousesToolStripMenuItem"
        Me.MousesToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.MousesToolStripMenuItem.Text = "Mouses"
        '
        'GabinetesToolStripMenuItem
        '
        Me.GabinetesToolStripMenuItem.Name = "GabinetesToolStripMenuItem"
        Me.GabinetesToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.GabinetesToolStripMenuItem.Text = "Gabinetes"
        '
        'MemoriasRAMToolStripMenuItem
        '
        Me.MemoriasRAMToolStripMenuItem.Name = "MemoriasRAMToolStripMenuItem"
        Me.MemoriasRAMToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.MemoriasRAMToolStripMenuItem.Text = "Memorias RAM"
        '
        'DiscosRígidosHDDToolStripMenuItem
        '
        Me.DiscosRígidosHDDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiscosRígidosHDDToolStripMenuItem1, Me.DiscosSólidosSSDToolStripMenuItem1})
        Me.DiscosRígidosHDDToolStripMenuItem.Name = "DiscosRígidosHDDToolStripMenuItem"
        Me.DiscosRígidosHDDToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.DiscosRígidosHDDToolStripMenuItem.Text = "Almacenamiento"
        '
        'DiscosRígidosHDDToolStripMenuItem1
        '
        Me.DiscosRígidosHDDToolStripMenuItem1.Name = "DiscosRígidosHDDToolStripMenuItem1"
        Me.DiscosRígidosHDDToolStripMenuItem1.Size = New System.Drawing.Size(285, 34)
        Me.DiscosRígidosHDDToolStripMenuItem1.Text = "Discos Rígidos (HDD)"
        '
        'DiscosSólidosSSDToolStripMenuItem1
        '
        Me.DiscosSólidosSSDToolStripMenuItem1.Name = "DiscosSólidosSSDToolStripMenuItem1"
        Me.DiscosSólidosSSDToolStripMenuItem1.Size = New System.Drawing.Size(285, 34)
        Me.DiscosSólidosSSDToolStripMenuItem1.Text = "Discos Sólidos (SSD)"
        '
        'AudioToolStripMenuItem
        '
        Me.AudioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AuricularesToolStripMenuItem, Me.ParlantesToolStripMenuItem})
        Me.AudioToolStripMenuItem.Name = "AudioToolStripMenuItem"
        Me.AudioToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.AudioToolStripMenuItem.Text = "Audio"
        '
        'AuricularesToolStripMenuItem
        '
        Me.AuricularesToolStripMenuItem.Name = "AuricularesToolStripMenuItem"
        Me.AuricularesToolStripMenuItem.Size = New System.Drawing.Size(200, 34)
        Me.AuricularesToolStripMenuItem.Text = "Auriculares"
        '
        'ParlantesToolStripMenuItem
        '
        Me.ParlantesToolStripMenuItem.Name = "ParlantesToolStripMenuItem"
        Me.ParlantesToolStripMenuItem.Size = New System.Drawing.Size(200, 34)
        Me.ParlantesToolStripMenuItem.Text = "Parlantes"
        '
        'AccesoriosToolStripMenuItem
        '
        Me.AccesoriosToolStripMenuItem.Name = "AccesoriosToolStripMenuItem"
        Me.AccesoriosToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.AccesoriosToolStripMenuItem.Text = "Accesorios"
        '
        'FuentesDeAlimentaciónToolStripMenuItem
        '
        Me.FuentesDeAlimentaciónToolStripMenuItem.Name = "FuentesDeAlimentaciónToolStripMenuItem"
        Me.FuentesDeAlimentaciónToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.FuentesDeAlimentaciónToolStripMenuItem.Text = "Fuentes de Alimentación"
        '
        'AlmacenamientoPortátilToolStripMenuItem
        '
        Me.AlmacenamientoPortátilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemoriasToolStripMenuItem, Me.PenDrivesToolStripMenuItem})
        Me.AlmacenamientoPortátilToolStripMenuItem.Name = "AlmacenamientoPortátilToolStripMenuItem"
        Me.AlmacenamientoPortátilToolStripMenuItem.Size = New System.Drawing.Size(308, 34)
        Me.AlmacenamientoPortátilToolStripMenuItem.Text = "Almacenamiento Portátil"
        '
        'MemoriasToolStripMenuItem
        '
        Me.MemoriasToolStripMenuItem.Name = "MemoriasToolStripMenuItem"
        Me.MemoriasToolStripMenuItem.Size = New System.Drawing.Size(193, 34)
        Me.MemoriasToolStripMenuItem.Text = "Memorias"
        '
        'PenDrivesToolStripMenuItem
        '
        Me.PenDrivesToolStripMenuItem.Name = "PenDrivesToolStripMenuItem"
        Me.PenDrivesToolStripMenuItem.Size = New System.Drawing.Size(193, 34)
        Me.PenDrivesToolStripMenuItem.Text = "PenDrives"
        '
        'tsbMisDatos
        '
        Me.tsbMisDatos.Image = Global.Proyecto_Final.My.Resources.Resources.datos
        Me.tsbMisDatos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMisDatos.Name = "tsbMisDatos"
        Me.tsbMisDatos.Size = New System.Drawing.Size(120, 33)
        Me.tsbMisDatos.Text = "Mis Datos"
        '
        'tslCerrarSesion
        '
        Me.tslCerrarSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslCerrarSesion.IsLink = True
        Me.tslCerrarSesion.Name = "tslCerrarSesion"
        Me.tslCerrarSesion.Size = New System.Drawing.Size(116, 33)
        Me.tslCerrarSesion.Text = "Cerrar Sesión"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'tslBienvenido
        '
        Me.tslBienvenido.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslBienvenido.Name = "tslBienvenido"
        Me.tslBienvenido.Size = New System.Drawing.Size(99, 33)
        Me.tslBienvenido.Text = "Bienvenido"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Location = New System.Drawing.Point(22, 251)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1388, 338)
        Me.Panel1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1114, 280)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(846, 280)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(578, 280)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 280)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 280)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(1119, 26)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(225, 231)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(850, 26)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(225, 231)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(314, 26)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(225, 231)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(582, 26)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(225, 231)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(38, 26)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(225, 231)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'imgDefault
        '
        Me.imgDefault.Image = Global.Proyecto_Final.My.Resources.Resources.auriculares
        Me.imgDefault.Location = New System.Drawing.Point(-12, 556)
        Me.imgDefault.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.imgDefault.Name = "imgDefault"
        Me.imgDefault.Size = New System.Drawing.Size(1454, 618)
        Me.imgDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDefault.TabIndex = 3
        Me.imgDefault.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_Final.My.Resources.Resources.Logo_HUERGO_GAMING1
        Me.PictureBox1.Location = New System.Drawing.Point(279, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(849, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1432, 1002)
        Me.Controls.Add(Me.imgDefault)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDefault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsddbProductos As ToolStripDropDownButton
    Friend WithEvents ProcesadoresCPUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MotherboardsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlacasDeVideoGPUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonitoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TecladosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MousesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GabinetesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MemoriasRAMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiscosRígidosHDDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiscosRígidosHDDToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DiscosSólidosSSDToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuricularesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParlantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccesoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuentesDeAlimentaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenamientoPortátilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MemoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenDrivesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbMisDatos As ToolStripButton
    Friend WithEvents tslCerrarSesion As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tslBienvenido As ToolStripLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents IntelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NVIDIAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AMDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents imgDefault As PictureBox
End Class
