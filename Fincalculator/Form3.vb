Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cost As Single
        Dim pv As Single
        Dim cvu As Single
        Dim cal As Single


        'Ingreso de Datos
        cost = Val(TxtCOST.Text)
        pv = Val(TxtPV.Text)
        cvu = Val(TxtCVU.Text)

        'Calcular el Punto de equilibrio
        cal = cost / (pv - cvu)

        'Salida de Datos
        'TxtRES.Text = cal
        TxtRES.Text = Math.Round(Convert.ToDouble(cal), 2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Limpiar ingreso de datos
        TxtCOST.Text = " "
        TxtPV.Text = " "
        TxtCVU.Text = " "

        'Limpiar resultados
        TxtRES.Text = " "
        TxtCOST.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class