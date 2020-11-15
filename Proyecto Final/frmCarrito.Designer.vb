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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdVaciar = New System.Windows.Forms.Button()
        Me.cmdComprar = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(635, 303)
        Me.ListBox1.TabIndex = 0
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(12, 321)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(145, 37)
        Me.cmdEliminar.TabIndex = 1
        Me.cmdEliminar.Text = "Eliminar Artículo"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdVaciar
        '
        Me.cmdVaciar.Location = New System.Drawing.Point(12, 364)
        Me.cmdVaciar.Name = "cmdVaciar"
        Me.cmdVaciar.Size = New System.Drawing.Size(145, 37)
        Me.cmdVaciar.TabIndex = 2
        Me.cmdVaciar.Text = "Vaciar Carrito"
        Me.cmdVaciar.UseVisualStyleBackColor = True
        '
        'cmdComprar
        '
        Me.cmdComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdComprar.Location = New System.Drawing.Point(519, 321)
        Me.cmdComprar.Name = "cmdComprar"
        Me.cmdComprar.Size = New System.Drawing.Size(128, 52)
        Me.cmdComprar.TabIndex = 3
        Me.cmdComprar.Text = "COMPRAR"
        Me.cmdComprar.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(227, 384)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(212, 35)
        Me.cmdVolver.TabIndex = 4
        Me.cmdVolver.Text = "Volver a Selección de Artículos"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(354, 325)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(54, 13)
        Me.lblPrecio.TabIndex = 5
        Me.lblPrecio.Text = "TOTAL: $"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(413, 321)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 6
        '
        'frmCarrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 431)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdComprar)
        Me.Controls.Add(Me.cmdVaciar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "frmCarrito"
        Me.Text = "frmCarrito"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents cmdVaciar As Button
    Friend WithEvents cmdComprar As Button
    Friend WithEvents cmdVolver As Button
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtPrecio As TextBox
End Class
