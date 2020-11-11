Public Class Form12

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Ap, i1, m, m1, d, n As Double
        Dim c1 As Double
        Dim cien As Single

        'Numero 100
        cien = 100

        'Ingresos de datos
        Ap = Val(TxtAP.Text)   'Capital
        i1 = Val(TxtINT.Text)  'Tasa de Interes
        n = Val(TxtTMP.Text)   'Tiempo

        'Divisor entre 100
        d = i1 / cien

        'Calculo multiplo interes mas tiempo
        m = d * n

        'Calculo suma 1 mas resultado m = d * n
        m1 = 1 + m

        'Calculo capital mas resultado m = 1 + m
        c1 = Ap * m1

        'Salida de Datos
        'TxtMENSUAL.Text = c1
        TxtMENSUAL.Text = Math.Round(Convert.ToDouble(c1), 2) & " $"
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class