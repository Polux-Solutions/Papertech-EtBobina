Public Class ListaVerde
    Dim OrdenarPor As String = "[Bobina] DESC, [Lote] DESC"
    Public Function Mostrar_Lista_Verde() As Boolean
        Dim oRead As SqlClient.SqlDataReader
        Dim cSql As String
        Dim Monitor() As Screen = Screen.AllScreens
        Dim PantallaNo As Integer = 0
        Dim Qty As Integer = 0

        If Monitor.Count > 1 Then PantallaNo = 1

        Me.Left = Monitor(PantallaNo).Bounds.Left + 10
        Me.Top = Monitor(PantallaNo).Bounds.Top + 10

        Mostrar_Lista_Verde = False

        Me.Text = "Informe de Bobina:   " + Format(Now, "dd-MM-yy HH:mm:ss")
        Me.txTurno.Text = Etiqueta.Turno
        Me.txHorario.Text = Etiqueta.Horario

        ListView1.View = View.Details

        ListView1.Columns.Clear()
        ListView1.Items.Clear()
        ListView1.Columns.Add("Descripción", 300, HorizontalAlignment.Left)
        ListView1.Columns.Add("OF", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Rollo", 100, HorizontalAlignment.Right)
        ListView1.Columns.Add("Palet", 140, HorizontalAlignment.Right)
        ListView1.Columns.Add("Cantidad", 90, HorizontalAlignment.Right)

        ListView2.View = View.Details

        ListView2.Columns.Clear()
        ListView2.Items.Clear()
        ListView2.Columns.Add("OF", 80, HorizontalAlignment.Center)
        ListView2.Columns.Add("Cont.", 70, HorizontalAlignment.Right)
        ListView2.Columns.Add("C. turno", 90, HorizontalAlignment.Right)
        ListView2.Columns.Add("C. Orden", 90, HorizontalAlignment.Right)
        ListView2.Columns.Add("C. Pdte.", 90, HorizontalAlignment.Right)



        If Etiqueta.Turno = "" Or Etiqueta.Horario = "" Then Exit Function

        If Not Abrir_BBDD_Reporting() Then Exit Function

        Dim oComm As New SqlClient.SqlCommand

        Try
            Dim param(1) As SqlClient.SqlParameter
            param(0) = New SqlClient.SqlParameter
            param(1) = New SqlClient.SqlParameter
            param(0).ParameterName = "@Turno"
            param(0).Value = Etiqueta.Turno
            param(1).ParameterName = "@Hora"
            param(1).Value = Etiqueta.Horario

            oComm.Connection = Datos.ConexReporting
            oComm.CommandType = CommandType.StoredProcedure
            oComm.CommandText = "Etiquetas2-OK"
            oComm.Parameters.Add(param(0))
            oComm.Parameters.Add(param(1))

            oComm.ExecuteNonQuery()
        Catch ex As Exception
            Log("Error Reporting Ejecutar Procedimiento Almacenado Informe Verde " + oComm.CommandText + " " + ex.Message)
            Exit Function
        End Try


        cSql = "SELECT * from [Etiquetas Salida2] ORDER BY " + OrdenarPor

        oRead = Nothing

        If Not Ejecutar_Datareader_Reporting(cSql, oRead, False) Then Exit Function

        Dim textoAnt As String = ""
        Dim TextoAct As String = ""
        Dim OFAnt As String = ""
        Dim OFAct As String = ""
        Dim RolloAnt As String = ""
        Dim RolloAct As String = ""
        Dim FlipFlop As Boolean = False

        Do While oRead.Read
            Dim Item As New ListViewItem


            TextoAct = ""
            If textoAnt <> oRead.Item("Description").ToString Then
                TextoAct = oRead.Item("Description").ToString
                textoAnt = oRead.Item("Description").ToString
            End If

            OFAct = ""
            If OFAnt <> oRead.Item("Orden").ToString Then
                OFAct = oRead.Item("Orden").ToString
                OFAnt = oRead.Item("Orden").ToString
            End If

            RolloAct = ""
            If RolloAnt <> oRead.Item("Bobina").ToString Then
                RolloAct = oRead.Item("Bobina").ToString
                RolloAnt = oRead.Item("Bobina").ToString
            End If

            Item.Text = TextoAct
            Item.Tag = oRead.Item("Orden").ToString
            Item.ForeColor = Color.Black
            If FlipFlop Then
                Item.BackColor = Color.White
            Else
                Item.BackColor = Color.AliceBlue
            End If

            FlipFlop = Not FlipFlop

            If oRead.Item("OK") = 0 Then Item.ForeColor = Color.Red

            ListView1.Items.Add(Item)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(OFAct)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(RolloAct)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(oRead.Item("Lote").ToString)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(oRead.Item("Cantidad"), "#,##0"))
        Loop

        oRead.Close()

        cSql = "SELECT * from [Etiquetas Salida3]  ORDER BY [Orden] DESC"

        oRead = Nothing

        If Not Ejecutar_Datareader_Reporting(cSql, oRead, False) Then Exit Function

        Qty = 0
        Do While oRead.Read
            Dim Item As New ListViewItem

            Item.Text = oRead.Item("Orden").ToString

            ListView2.Items.Add(Item)
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Format(oRead.Item("Counter"), "#,##0"))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Format(oRead.Item("Cantidad Turno"), "#,##0"))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Format(oRead.Item("Cantidad OF"), "#,##0"))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Format(oRead.Item("Cantidad Pendiente"), "#,##0"))
            Qty += oRead.Item("Cantidad Turno")
        Loop

        oRead.Close()

        Cerrar_BBDD()

        Me.txTotal.Text = ""
        If Qty <> 0 Then Me.txTotal.Text = Format(Qty, "#,##0")

        Mostrar_Lista_Verde = True
    End Function

    Private Sub ListView1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDown
        Dim ht As ListViewHitTestInfo = ListView1.HitTest(e.Location)
        Dim Code As String

        If IsNothing(ht) Then Exit Sub
        If IsNothing(ht.SubItem) Then Exit Sub

        Me.txOF.Text = ht.Item.Tag
        Code = ht.Item.SubItems(3).Text

        If Code.LastIndexOf("/") > 0 Then
            Code = Code.Substring(0, Code.LastIndexOf("/"))
        End If

        If IsNumeric(Code) Then Me.txPalet.Text = Code
    End Sub

    Private Sub Manual_Click(sender As Object, e As EventArgs) Handles Manual.Click
        Dim et2 As stEtiqueta


        et2 = Etiqueta
        If FuncionesDatos.Extraer_Datos(Me.txOF.Text, 0, False) <> "OK" Then Exit Sub
        Etiqueta.Palet = Me.txPalet.Text
        Etiqueta.PlanVerifcaAlta = False

        Plan.ShowDialog()

        Etiqueta = et2
    End Sub

    Private Sub ListaVerde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Ordenar1_Click(sender As Object, e As EventArgs) Handles Ordenar1.Click
        OrdenarPor = "[Orden] ASC, [Bobina] DESC, [Lote] DESC"
        Mostrar_Lista_Verde()
    End Sub

    Private Sub Ordenar2_Click(sender As Object, e As EventArgs) Handles Ordenar2.Click
        OrdenarPor = "[Bobina] DESC, [Lote] DESC"
        Mostrar_Lista_Verde()
    End Sub
End Class