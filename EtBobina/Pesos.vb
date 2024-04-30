Public Class Pesos
    Public Function Mostrar_Lista_Pesos(xOP As String, xBobina As Integer) As Boolean
        Dim ds As DataSet = Nothing

        If xOP = "" And xBobina = 0 Then
            MsgBox("No se ha indicado Orden de Fabricación ni Nº de Rollo")
            Mostrar_Lista_Pesos = False
            Exit Function
        End If

        Me.Text = "Informe Pesos Bobina:   " + Format(Now, "dd-MM-yy HH:mm:ss")

        ListView1.View = View.Details

        ListView1.Columns.Clear()
        ListView1.Items.Clear()
        ListView1.Columns.Add("OF", 90, HorizontalAlignment.Right)
        ListView1.Columns.Add("Rollo", 90, HorizontalAlignment.Right)
        ListView1.Columns.Add("Palet", 120, HorizontalAlignment.Right)
        ListView1.Columns.Add("Peso", 120, HorizontalAlignment.Right)
        ListView1.Columns.Add("Registrado", 110, HorizontalAlignment.Center)

        Mostrar_Lista_Pesos = WebServices.Detalle_Peso_OP(xOP, xBobina, ds)

        If Mostrar_Lista_Pesos Then
            Dim TotalPeso As Integer = 0

            For Each dt As DataRow In ds.Tables(0).Rows
                Dim Item As New ListViewItem

                Item.Text = dt.Item("OP").ToString
                ListView1.Items.Add(Item)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dt.Item("Bobina").ToString)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dt.Item("Palet").ToString)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dt.Item("Peso").ToString)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dt.Item("Registrado").ToString)

                TotalPeso += dt.Item("Peso")
            Next

            Dim Item2 As New ListViewItem

            Item2.Text = "TOTAL"
            ListView1.Items.Add(Item2)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(TotalPeso.ToString)
            ListView1.Items(ListView1.Items.Count - 1).Font = New Font(ListView1.Font, FontStyle.Bold)
        End If

    End Function
End Class