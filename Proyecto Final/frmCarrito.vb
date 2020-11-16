Public Class frmCarrito
    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click

    End Sub

    Private Sub cmdVaciar_Click(sender As Object, e As EventArgs) Handles cmdVaciar.Click
        ListBox1.ClearSelected()
    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        Me.Hide()
        frmPrincipal.Show()
    End Sub
End Class