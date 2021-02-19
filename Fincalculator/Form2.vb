Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mar As Single
        Dim sell As Single
        Dim cost As Single
        Dim ajus As Single
        Dim dif As Single
        Dim cien As Double

        'Numero 100
        cien = 100

        'Ingreso de Datos
        cost = Val(TextCOST.Text)
        sell = Val(TextSELL.Text)

        'Calculo del Margen de Ganancia
        mar = ((sell - cost) / sell) * cien

        'Calculo del Margen Porcentual
        ajus = ((sell - cost) / cost) * cien

        'Calculo diferencia
        dif = sell - cost

        'Salida de Datos
        'TextMAR.Text = mar
        'TextPOR.Text = ajus
        'TextDIF.Text = dif
        TextMAR.Text = Math.Round(Convert.ToDouble(mar), 2) & " %"
        TextPOR.Text = Math.Round(Convert.ToDouble(ajus), 2) & " %"
        TextDIF.Text = Math.Round(Convert.ToDouble(dif), 2) & " $"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Limpiar en los ingresos de datos
        'Para no afectar con el Error "NaN", añadir con el apóstrofe (') para taparlos
        'TextCOST.Text = " 0.0 "
        'TextSELL.Text = " 0.0"

        'Limpiar Pantalla en los resultados
        TextMAR.Text = " 0.0 "
        TextPOR.Text = " 0.0 "
        TextDIF.Text = " 0.0 "
        TextCOST.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
