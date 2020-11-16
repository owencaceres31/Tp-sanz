Public Class frmCarrito
    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        If Lstcarrito.Items.Count > 0 And Lstcarrito.SelectedIndex >= 0 Then

            'sumatotal = sumatotal - lstPrecios.SelectedItem
            'Lstprecios.Items.RemoveAt(Lstprecios.SelectedIndex)
            Lstcarrito.Items.RemoveAt(Lstcarrito.SelectedIndex)

            'lblPrecio.Text = sumatotal
            'items = items - 1
            'frmCompraVirtual.lblitems.Text = items

            If Lstcarrito.Items.Count > 0 Then
                Lstcarrito.SelectedIndex = 0
            End If

        Else
            MsgBox("No hay items que eliminar", vbOKOnly, "CARRITO")
        End If
    End Sub

    Private Sub cmdVaciar_Click(sender As Object, e As EventArgs) Handles cmdVaciar.Click
        Lstcarrito.Items.Clear()
    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        Me.Hide()
        frmPrincipal.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lstcarrito.SelectedIndexChanged

    End Sub
End Class