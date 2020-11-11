Public Class Form14

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        'SubTotales
        Dim Total1, Total2, Total3, Total4, Total5 As Single
        Dim Total6, Total7, Total8, Total9, Total10 As Single
        Dim Total11, Total12, Total13, Total14 As Single

        'IVA
        'Dim IVA, IVA16, i, cien As Single
        Dim IVA16, cien As Single
        Dim ISUB, IVAT, i As Single

        'Totales
        Dim TOT, SUBTOTAL As Single

        'Cantidades
        Dim Cantidad1, Cantidad2, Cantidad3, Cantidad4, Cantidad5 As Single
        Dim Cantidad6, Cantidad7, Cantidad8, Cantidad9, Cantidad10 As Single
        Dim Cantidad11, Cantidad12, Cantidad13, Cantidad14 As Single

        'Precios
        Dim Precio1, Precio2, Precio3, Precio4, Precio5 As Single
        Dim Precio6, Precio7, Precio8, Precio9, Precio10 As Single
        Dim Precio11, Precio12, Precio13, Precio14 As Single

        'Calculo Columna 1
        Precio1 = Val(TxtPrecio1.Text)
        Cantidad1 = Val(TxtCantidad1.Text)
        Total1 = Precio1 * Cantidad1
        TxtTotal1.Text = Total1.ToString("###,##0.00 $")

        'Calculo Columna 2
        Precio2 = Val(TxtPrecio2.Text)
        Cantidad2 = Val(TxtCantidad2.Text)
        Total2 = Precio2 * Cantidad2
        TxtTotal2.Text = Total2.ToString("###,##0.00 $")

        'Calculo Columna 3
        Precio3 = Val(TxtPrecio3.Text)
        Cantidad3 = Val(TxtCantidad3.Text)
        Total3 = Precio3 * Cantidad3
        TxtTotal3.Text = Total3.ToString("###,##0.00 $")

        'Calculo Columna 4
        Precio4 = Val(TxtPrecio4.Text)
        Cantidad4 = Val(TxtCantidad4.Text)
        Total4 = Precio4 * Cantidad4
        TxtTotal4.Text = Total4.ToString("###,##0.00 $")

        'Calculo Columna 5
        Precio5 = Val(TxtPrecio5.Text)
        Cantidad5 = Val(TxtCantidad5.Text)
        Total5 = Precio5 * Cantidad5
        TxtTotal5.Text = Total5.ToString("###,##0.00 $")

        'Calculo Columna 6
        Precio6 = Val(TxtPrecio6.Text)
        Cantidad6 = Val(TxtCantidad6.Text)
        Total6 = Precio6 * Cantidad6
        TxtTotal6.Text = Total6.ToString("###,##0.00 $")

        'Calculo Columna 7
        Precio8 = Val(TxtPrecio8.Text)
        Cantidad8 = Val(TxtCantidad8.Text)
        Total8 = Precio8 * Cantidad7
        TxtTotal8.Text = Total8.ToString("###,##0.00 $")

        'Calculo Columna 8
        Precio7 = Val(TxtPrecio7.Text)
        Cantidad7 = Val(TxtCantidad7.Text)
        Total7 = Precio7 * Cantidad7
        TxtTotal7.Text = Total7.ToString("###,##0.00 $")

        'Calculo Columna 9
        Precio9 = Val(TxtPrecio9.Text)
        Cantidad9 = Val(TxtCantidad9.Text)
        Total9 = Precio9 * Cantidad9
        TxtTotal9.Text = Total9.ToString("###,##0.00 $")

        'Calculo Columna 10
        Precio10 = Val(TxtPrecio10.Text)
        Cantidad10 = Val(TxtCantidad10.Text)
        Total10 = Precio10 * Cantidad10
        TxtTotal10.Text = Total10.ToString("###,##0.00 $")

        'Calculo Columna 11
        Precio11 = Val(TxtPrecio11.Text)
        Cantidad11 = Val(TxtCantidad11.Text)
        Total11 = Precio11 * Cantidad11
        TxtTotal11.Text = Total11.ToString("###,##0.00 $")

        'Calculo Columna 12
        Precio12 = Val(TxtPrecio12.Text)
        Cantidad12 = Val(TxtCantidad12.Text)
        Total12 = Precio12 * Cantidad12
        TxtTotal12.Text = Total12.ToString("###,##0.00 $")

        'Calculo Columna 13
        Precio13 = Val(TxtPrecio13.Text)
        Cantidad13 = Val(TxtCantidad13.Text)
        Total13 = Precio13 * Cantidad13
        TxtTotal13.Text = Total13.ToString("###,##0.00 $")

        'Calculo Columna 14
        Precio14 = Val(TxtPrecio14.Text)
        Cantidad14 = Val(TxtCantidad14.Text)
        Total14 = Precio14 * Cantidad14
        TxtTotal14.Text = Total14.ToString("###,##0.00 $")

        'Subtotales
        SUBTOTAL = Total1 + Total2 + Total3 + Total4 + Total5 + Total6 + Total7 + Total8 + Total9 + Total10 + Total11 + Total12 + Total13 + Total14

        'Calculo IVA
        cien = 100
        'IVA = Val(TxtIVA.Text)
        i = 16
        IVA16 = i / cien
        'i = 16

        'Calculo Subtotales + IVA y Total General
        ISUB = SUBTOTAL * IVA16
        TOT = SUBTOTAL + ISUB
        IVAT = ISUB

        'Resultados
        TxtIVAT.Text = Math.Round(Convert.ToDouble(IVAT), 2) & " $"
        TxtIVA.Text = Math.Round(Convert.ToDouble(i), 2) & " %"
        TxtSUBT.Text = Math.Round(Convert.ToDouble(SUBTOTAL), 2) & " $"
        TxtTOT.Text = Math.Round(Convert.ToDouble(TOT), 2) & " $"

    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click

        'Limpiar en los nombres del producto o mercancia
        TxtProd1.Text = " "
        TxtProd2.Text = " "
        TxtProd3.Text = " "
        TxtProd4.Text = " "
        TxtProd5.Text = " "
        TxtProd6.Text = " "
        TxtProd7.Text = " "
        TxtProd8.Text = " "
        TxtProd9.Text = " "
        TxtProd10.Text = " "
        TxtProd11.Text = " "
        TxtProd12.Text = " "
        TxtProd13.Text = " "
        TxtProd14.Text = " "

        'Limpiar en los ingresos de precio unitario
        TxtPrecio1.Text = " "
        TxtPrecio2.Text = " "
        TxtPrecio3.Text = " "
        TxtPrecio4.Text = " "
        TxtPrecio5.Text = " "
        TxtPrecio6.Text = " "
        TxtPrecio7.Text = " "
        TxtPrecio8.Text = " "
        TxtPrecio9.Text = " "
        TxtPrecio10.Text = " "
        TxtPrecio11.Text = " "
        TxtPrecio12.Text = " "
        TxtPrecio13.Text = " "
        TxtPrecio14.Text = " "

        'Limpiar en los ingresos de cantidades
        TxtCantidad1.Text = " "
        TxtCantidad2.Text = " "
        TxtCantidad3.Text = " "
        TxtCantidad4.Text = " "
        TxtCantidad5.Text = " "
        TxtCantidad6.Text = " "
        TxtCantidad7.Text = " "
        TxtCantidad8.Text = " "
        TxtCantidad9.Text = " "
        TxtCantidad10.Text = " "
        TxtCantidad11.Text = " "
        TxtCantidad12.Text = " "
        TxtCantidad13.Text = " "
        TxtCantidad14.Text = " "

        'Limpiar en los ingresos de totales
        TxtTotal1.Text = " "
        TxtTotal2.Text = " "
        TxtTotal3.Text = " "
        TxtTotal4.Text = " "
        TxtTotal5.Text = " "
        TxtTotal6.Text = " "
        TxtTotal7.Text = " "
        TxtTotal8.Text = " "
        TxtTotal9.Text = " "
        TxtTotal10.Text = " "
        TxtTotal11.Text = " "
        TxtTotal12.Text = " "
        TxtTotal13.Text = " "
        TxtTotal14.Text = " "

        'Limpiar en la ID del Cliente
        TxtNOM.Text = " "
        TxtAPE.Text = " "
        TxtCED.Text = " "
        TxtTELF.Text = " "

        'Limpiar Pantalla en los resultados
        TxtIVAT.Text = " "
        TxtIVA.Text = " "
        TxtSUBT.Text = " "
        TxtTOT.Text = " "
        TxtProd1.Focus()
    End Sub
End Class