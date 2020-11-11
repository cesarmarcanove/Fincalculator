Public Class Form11

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Ap, i, i1, i2, t, n As Double
        Dim c1, c2 As Double
        Dim c3 As Double
        Dim n1 As Double
        Dim cien As Single

        'Numero 100
        cien = 100

        'Ingresos de datos
        Ap = Val(TxtAP.Text)
        i1 = Val(TxtINT.Text)
        t = Val(TxtTMP.Text)

        'Calculo de tiempo en años
        n = 12 * t

        'calculo interes dividiendo entre 100
        i2 = i1 / cien

        'calculo interes dividiendo al 12
        i = i2 / 12

        'Calculo suma de 1 mas interes
        n1 = 1 + i

        'Calculo de Hipoteca
        c1 = i * Ap
        c2 = 1 - (n1) ^ -(n)
        c3 = c1 / c2

        'Salida de Datos
        'TxtMENSUAL.Text = c3
        TxtMENSUAL.Text = Math.Round(Convert.ToDouble(c3), 2) & " $"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Limpiar en los ingresos de datos
        TxtAP.Text = " "
        TxtINT.Text = " "
        TxtTMP.Text = " "

        'Limpiar Pantalla en los resultados
        TxtMENSUAL.Text = " "
        TxtAP.Focus()
    End Sub
End Class