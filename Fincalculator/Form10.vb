Public Class Form10

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim capital As Double
        Dim interes As Double
        Dim n As Double
        Dim c1 As Double
        Dim c2 As Double
        Dim c3 As Double
        Dim c4 As Double
        Dim c5 As Double
        Dim n1 As Double
        Dim CIEN As Single
        Dim d As Double

        'Numero 100
        CIEN = 100

        'Ingresos de Datos
        capital = Val(TxtCAP.Text)
        interes = Val(TxtINT.Text)
        n = Val(TxtTIME.Text)

        'Divisor del numerador de la tasa de interés entre 100
        d = interes / CIEN


        'Calculo de Tasas de Intereses (Simple
        c1 = capital
        n1 = d * n
        c2 = 1 + n1
        c3 = c1 * c2
        c4 = d / n
        c5 = (c3 * c4) * CIEN

        'Salida de Datos
        TxtCAPI.Text = Math.Round(Convert.ToDouble(c5), 2) & " $"
        'TxtCAPI.Text = c5
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Limpiar en los ingresos de datos
        TxtCAP.Text = " "
        TxtINT.Text = " "
        TxtTIME.Text = " "

        'Limpiar Pantalla en los resultados
        TxtCAPI.Text = " "
        TxtCAP.Focus()
    End Sub
End Class