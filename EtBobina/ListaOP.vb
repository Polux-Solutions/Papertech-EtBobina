Public Class ListaOP
    Private Sub ListaOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function Mostrar_Lista_OP() As Boolean
        Dim oRead As SqlClient.SqlDataReader
        Dim cSql As String

        Me.Text = "Informe de Bobina:   " + Format(Now, "dd-MM-yy HH:mm:ss")

        ListView1.View = View.Details

        ListView1.Columns.Clear()
        ListView1.Items.Clear()
        ListView1.Columns.Add("Rollo", 60, HorizontalAlignment.Right)
        ListView1.Columns.Add("Fecha", 90, HorizontalAlignment.Center)
        ListView1.Columns.Add("Hora", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Peso", 80, HorizontalAlignment.Right)
        ListView1.Columns.Add("Contramaestre", 110, HorizontalAlignment.Left)
        ListView1.Columns.Add("OP 1", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("OP 2", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("OP 3", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("OP 4", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("OP 5", 80, HorizontalAlignment.Center)


        Mostrar_Lista_OP = Abrir_BBDD()
        If Not Mostrar_Lista_OP Then Exit Function

        cSql = "SELECT IB.[NUM_BOBINA_MANUAL], IB.[FECHA_FIN_BOBINA_INFORME],IB.[HORA_FIN_BOBINA_INFORME], IB.[PESO_BOBINA]," +
                      "IB.[CONTRAMAESTRE],IB.[COD_FAB1],IB.[COD_FAB2],IB.[COD_FAB3],IB.[COD_FAB4],IB.[COD_FAB5]" +
               " FROM [Papertech$Informe Bobinadora] IB " +
               " WHERE IB.[FECHA_NAVISION] >= dateadd(day, -2, getdate())" +
               " ORDER BY IB.[Entry No_] DESC"

        oRead = Nothing
        Mostrar_Lista_OP = Ejecutar_Datareader(cSql, oRead, False)

        If Not Mostrar_Lista_OP Then Exit Function

        Do While oRead.Read
            Dim Item As New ListViewItem

            Item.Text = oRead.Item("NUM_BOBINA_MANUAL").ToString
            ListView1.Items.Add(Item)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(oRead.Item("FECHA_FIN_BOBINA_INFORME").ToString)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(oRead.Item("HORA_FIN_BOBINA_INFORME").ToString)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(oRead.Item("PESO_BOBINA"), "#,##0.00"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(oRead.Item("CONTRAMAESTRE").ToString)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(oRead.Item("COD_FAB1").ToString)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(oRead.Item("COD_FAB2").ToString)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(oRead.Item("COD_FAB3").ToString)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(oRead.Item("COD_FAB4").ToString)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(oRead.Item("COD_FAB5").ToString)
        Loop


        oRead.Close()
        Cerrar_BBDD()
    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class