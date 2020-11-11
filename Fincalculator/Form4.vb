Public Class Form4
    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Dim Precio, Cantidad, Total As Single
        Precio = Single.Parse(TxtPrecio.Text)
        Cantidad = Single.Parse(TxtCantidad.Text)
        Total = Precio * Cantidad
        LblTotal.Text = Total.ToString("###,##0.00 $")
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        TxtProducto.Text = ""
        TxtPrecio.Text = ""
        TxtCantidad.Text = ""
        LblTotal.Text = ""
        TxtProducto.Focus()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class