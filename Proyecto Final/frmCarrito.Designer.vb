<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarrito
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
        Me.Lstcarrito = New System.Windows.Forms.ListBox()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdVaciar = New System.Windows.Forms.Button()
        Me.cmdComprar = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Lstprecios = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Lstcarrito
        '
        Me.Lstcarrito.FormattingEnabled = True
        Me.Lstcarrito.ItemHeight = 20
        Me.Lstcarrito.Items.AddRange(New Object() {"hola", "chau"})
        Me.Lstcarrito.Location = New System.Drawing.Point(18, 18)
        Me.Lstcarrito.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Lstcarrito.Name = "Lstcarrito"
        Me.Lstcarrito.Size = New System.Drawing.Size(950, 464)
        Me.Lstcarrito.TabIndex = 0
        Me.Lstcarrito.UseWaitCursor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(18, 494)
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(218, 57)
        Me.cmdEliminar.TabIndex = 1
        Me.cmdEliminar.Text = "Eliminar Artículo"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdVaciar
        '
        Me.cmdVaciar.Location = New System.Drawing.Point(18, 560)
        Me.cmdVaciar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdVaciar.Name = "cmdVaciar"
        Me.cmdVaciar.Size = New System.Drawing.Size(218, 57)
        Me.cmdVaciar.TabIndex = 2
        Me.cmdVaciar.Text = "Vaciar Carrito"
        Me.cmdVaciar.UseVisualStyleBackColor = True
        '
        'cmdComprar
        '
        Me.cmdComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComprar.Location = New System.Drawing.Point(778, 494)
        Me.cmdComprar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdComprar.Name = "cmdComprar"
        Me.cmdComprar.Size = New System.Drawing.Size(192, 80)
        Me.cmdComprar.TabIndex = 3
        Me.cmdComprar.Text = "COMPRAR"
        Me.cmdComprar.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(340, 591)
        Me.cmdVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(318, 54)
        Me.cmdVolver.TabIndex = 4
        Me.cmdVolver.Text = "Volver a Selección de Artículos"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(531, 500)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(76, 20)
        Me.lblPrecio.TabIndex = 5
        Me.lblPrecio.Text = "TOTAL: $"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(620, 494)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(148, 26)
        Me.txtPrecio.TabIndex = 6
        '
        'Lstprecios
        '
        Me.Lstprecios.FormattingEnabled = True
        Me.Lstprecios.ItemHeight = 20
        Me.Lstprecios.Location = New System.Drawing.Point(1029, 18)
        Me.Lstprecios.Name = "Lstprecios"
        Me.Lstprecios.Size = New System.Drawing.Size(211, 464)
        Me.Lstprecios.TabIndex = 7
        '
        'frmCarrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 663)
        Me.Controls.Add(Me.Lstprecios)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdComprar)
        Me.Controls.Add(Me.cmdVaciar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.Lstcarrito)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCarrito"
        Me.Text = "frmCarrito"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lstcarrito As ListBox
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmdVaciar As Button
    Friend WithEvents cmdComprar As Button
    Friend WithEvents cmdVolver As Button
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Lstprecios As ListBox
End Class
