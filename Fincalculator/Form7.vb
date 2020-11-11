Public Class Form7

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim act As Single
        Dim des As Single
        Dim util As Single
        Dim dep As Single

        'Ingresar Datos
        act = Val(TxtACT.Text)
        des = Val(TxtDES.Text)
        util = Val(TxtUTIL.Text)

        'Calcular Depreciacion (Metodo por la Linea Recta)
        dep = (act - des) / util

        'Resultados
        TxtDEP.Text = Math.Round(Convert.ToDouble(dep), 2) & " $"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Limpiar en los ingresos de datos
        TxtACT.Text = " "
        TxtDES.Text = " "
        TxtUTIL.Text = " "

        'Limpiar Pantalla en los resultados
        TxtDEP.Text = " "
        TxtACT.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class