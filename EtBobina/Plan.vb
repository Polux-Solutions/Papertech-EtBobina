Option Explicit On
Imports System.Globalization

Public Class Plan
    Private dsPlan As DataSet
    Private dsDatos As DataSet

    Private Sub TodosOK_CheckedChanged(sender As Object, e As EventArgs) Handles TodosOK.CheckedChanged
        OK1.Checked = True
        OK2.Checked = True
        OK3.Checked = True
        OK4.Checked = True
        OK5.Checked = True
        OK6.Checked = True
        OK7.Checked = True
        OK8.Checked = True
        OK9.Checked = True
        OK10.Checked = True
        OK11.Checked = True
        OK12.Checked = True
        OK13.Checked = True
        OK14.Checked = True
        OK15.Checked = True
        OK16.Checked = True

        NOK1.Checked = False
        NOK2.Checked = False
        NOK3.Checked = False
        NOK4.Checked = False
        NOK5.Checked = False
        NOK6.Checked = False
        NOK7.Checked = False
        NOK8.Checked = False
        NOK9.Checked = False
        NOK10.Checked = False
        NOK11.Checked = False
        NOK12.Checked = False
        NOK13.Checked = False
        NOK14.Checked = False
        NOK15.Checked = False
        NOK16.Checked = False
    End Sub

    Private Sub Plan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cSql As String
        Dim n As Integer

        cSql = "SELECT * FROM [" + Datos.Empresa + "$Plan de Verificacion] WHERE [Plan] = '" + Etiqueta.PlanVerificacion + "'"

        If Not Cargar_Dataset(dsPlan, cSql) Then
            MsgBox("Error al cargar el plan", MsgBoxStyle.Critical)
            Bye()
            Exit Sub
        End If

        cSql = "SELECT * FROM [" + Datos.Empresa + "$Hist_ Verificacion Palets] WHERE [Palet No_] = " + Etiqueta.Palet.ToString

        If Not Cargar_Dataset(dsDatos, cSql) Then
            MsgBox("Error al cargar el los datos del palet", MsgBoxStyle.Critical)
            Bye()
            Exit Sub
        End If

        Palet.Text = Etiqueta.Palet.ToString
        Orden.Text = Etiqueta.OP.ToString
        Cliente.Text = Etiqueta.Cliente

        Invisible()

        n = 0
        For Each dt As DataRow In dsPlan.Tables(0).Select("Bloque=0", "Line No_")
            n += 1
            Mostrar(n, dt.Item("Plan"), dt.Item("Line No_"), dt.Item("Pregunta"))
        Next

        n = 0
        For Each dt As DataRow In dsPlan.Tables(0).Select("Bloque=1", "Line No_")
            n += 1
            Mostrar_Comentarios(n, dt.Item("Plan"), dt.Item("Line No_"), dt.Item("Pregunta"), dt.Item("Modificable"))
        Next
        n = 0
        For Each dt As DataRow In dsPlan.Tables(0).Select("Bloque=2", "Line No_")
            n += 1
            Mostrar_Hechos(n, dt.Item("Plan"), dt.Item("Line No_"), dt.Item("Pregunta"), dt.Item("Pulper"), dt.Item("Desclasificado"), dt.Item("Pulper"))
        Next

        Me.GroupBox1.Enabled = Etiqueta.PlanVerifcaAlta
        Me.GroupBox3.Enabled = Etiqueta.PlanVerifcaAlta

        Rollo_Nuevo()

        Me.GrupoRollo.Enabled = Etiqueta.CambioRollo
        Me.RolloAnchoRodaja.Text = Etiqueta.Rollo_AnchoRodaja.ToString
        Me.RolloAnchoMandril.Text = Etiqueta.Rollo_AnchoMandril
        Me.RolloRodajaDuraOK.Checked = Etiqueta.Rollo_RodajasDuras
        Me.RolloRodajaDuraNOK.Checked = Not Etiqueta.Rollo_RodajasDuras
    End Sub


    Private Sub Mostrar(i As Integer, PlanNo As String, Line As Integer, texto As String)
        Dim valor As Integer = 0 ' (0-> Sin Marcar 1-> True 2-> False)

        For Each dt As DataRow In dsDatos.Tables(0).Select("[Palet No_] =" + Etiqueta.Palet.ToString + "AND [Plan] = '" + PlanNo + "' AND [Line No_] = " + Line.ToString)
            valor = IIf(dt.Item("OK"), 1, 2)
        Next

        Select Case i
            Case 1
                OK1.Visible = True
                NOK1.Visible = True
                OK1.Checked = (valor = 1)
                NOK1.Checked = (valor = 2)
                Label1.Visible = True
                Label1.Tag = Line.ToString
                Label1.Text = texto
            Case 2
                OK2.Visible = True
                NOK2.Visible = True
                OK2.Checked = (valor = 1)
                NOK2.Checked = (valor = 2)
                Label2.Visible = True
                Label2.Tag = Line.ToString
                Label2.Text = texto
            Case 3
                OK3.Visible = True
                NOK3.Visible = True
                OK3.Checked = (valor = 1)
                NOK3.Checked = (valor = 2)
                Label3.Visible = True
                Label3.Tag = Line.ToString
                Label3.Text = texto
            Case 4
                OK4.Visible = True
                NOK4.Visible = True
                OK4.Checked = (valor = 1)
                NOK4.Checked = (valor = 2)
                Label4.Visible = True
                Label4.Tag = Line.ToString
                Label4.Text = texto
            Case 5
                OK5.Visible = True
                NOK5.Visible = True
                OK5.Checked = (valor = 1)
                NOK5.Checked = (valor = 2)
                Label5.Visible = True
                Label5.Tag = Line.ToString
                Label5.Text = texto
            Case 6
                OK6.Visible = True
                NOK6.Visible = True
                OK6.Checked = (valor = 1)
                NOK6.Checked = (valor = 2)
                Label6.Visible = True
                Label6.Tag = Line.ToString
                Label6.Text = texto
            Case 7
                OK7.Visible = True
                NOK7.Visible = True
                OK7.Checked = (valor = 1)
                NOK7.Checked = (valor = 2)
                Label7.Visible = True
                Label7.Tag = Line.ToString
                Label7.Text = texto
            Case 8
                OK8.Visible = True
                NOK8.Visible = True
                OK8.Checked = (valor = 1)
                NOK8.Checked = (valor = 2)
                Label8.Visible = True
                Label8.Tag = Line.ToString
                Label8.Text = texto
            Case 9
                OK9.Visible = True
                NOK9.Visible = True
                OK9.Checked = (valor = 1)
                NOK9.Checked = (valor = 2)
                Label9.Visible = True
                Label9.Tag = Line.ToString
                Label9.Text = texto
            Case 10
                OK10.Visible = True
                NOK10.Visible = True
                OK10.Checked = (valor = 1)
                NOK10.Checked = (valor = 2)
                Label10.Visible = True
                Label10.Tag = Line.ToString
                Label10.Text = texto
            Case 11
                OK11.Visible = True
                NOK11.Visible = True
                OK11.Checked = (valor = 1)
                NOK11.Checked = (valor = 2)
                Label11.Visible = True
                Label11.Tag = Line.ToString
                Label11.Text = texto
            Case 12
                OK12.Visible = True
                NOK12.Visible = True
                OK12.Checked = (valor = 1)
                NOK12.Checked = (valor = 2)
                Label12.Visible = True
                Label12.Tag = Line.ToString
                Label12.Text = texto
            Case 13
                OK13.Visible = True
                NOK13.Visible = True
                OK13.Checked = (valor = 1)
                NOK13.Checked = (valor = 2)
                Label13.Visible = True
                Label13.Tag = Line.ToString
                Label13.Text = texto
            Case 14
                OK14.Visible = True
                NOK14.Visible = True
                OK14.Checked = (valor = 1)
                NOK14.Checked = (valor = 2)
                Label14.Visible = True
                Label14.Tag = Line.ToString
                Label14.Text = texto
            Case 15
                OK15.Visible = True
                NOK15.Visible = True
                OK15.Checked = (valor = 1)
                NOK15.Checked = (valor = 2)
                Label15.Visible = True
                Label15.Tag = Line.ToString
                Label15.Text = texto
            Case 16
                OK16.Visible = True
                NOK16.Visible = True
                OK16.Checked = (valor = 1)
                NOK16.Checked = (valor = 2)
                Label16.Visible = True
                Label16.Tag = Line.ToString
                Label16.Text = texto
        End Select
    End Sub

    Private Sub Mostrar_Comentarios(i As Integer, PlanNo As String, Line As Integer, texto As String, Modificable As Integer)
        Dim valor As String = ""

        For Each dt As DataRow In dsDatos.Tables(0).Select("[Palet No_] =" + Etiqueta.Palet.ToString + " AND [Plan] = '" + PlanNo + "' AND [Line No_] = " + Line.ToString)
            valor = dt.Item("Texto")
        Next
        Select Case i
            Case 1
                Texto1.Visible = True
                Comentarios1.Visible = True
                Comentarios1.Tag = Line.ToString
                Comentarios1.Text = valor
                Texto1.Text = texto
                Comentarios1.Enabled = (Modificable = 1)
            Case 2
                Texto2.Visible = True
                Comentarios2.Visible = True
                Comentarios2.Tag = Line.ToString
                Comentarios2.Text = valor
                Texto2.Text = texto
                Comentarios2.Enabled = (Modificable = 1)
            Case 3
                Texto3.Visible = True
                Comentarios3.Visible = True
                Comentarios3.Tag = Line.ToString
                Comentarios3.Text = valor
                Texto3.Text = texto
                Comentarios3.Enabled = (Modificable = 1)
        End Select
    End Sub

    Private Sub Mostrar_Hechos(i As Integer, PlanNo As String, Line As Integer, texto As String, Rechazado As Integer, Desclasificado As Integer, Pulper As Integer)
        Dim valor As Boolean = False

        For Each dt As DataRow In dsDatos.Tables(0).Select("[Palet No_] =" + Etiqueta.Palet.ToString + " AND [Plan] = '" + PlanNo + "' AND [Line No_] = " + Line.ToString)
            valor = dt.Item("OK")
        Next

        Select Case i
            Case 1
                Hecho1.Visible = True
                Hecho1.Tag = Line.ToString
                Hecho1.Text = texto
                Hecho1.Checked = valor
                If (Pulper) Then Hecho1.ForeColor = Color.Red
            Case 2
                Hecho2.Visible = True
                Hecho2.Tag = Line.ToString
                Hecho2.Text = texto
                Hecho2.Checked = valor
                If (Pulper) Then Hecho2.ForeColor = Color.Red
            Case 3
                Hecho3.Visible = True
                Hecho3.Tag = Line.ToString
                Hecho3.Text = texto
                Hecho3.Checked = valor
                If (Pulper) Then Hecho3.ForeColor = Color.Red
            Case 4
                Hecho4.Visible = True
                Hecho4.Tag = Line.ToString
                Hecho4.Text = texto
                Hecho4.Checked = valor
                If (Pulper) Then Hecho4.ForeColor = Color.Red
            Case 5
                Hecho5.Visible = True
                Hecho5.Tag = Line.ToString
                Hecho5.Text = texto
                Hecho5.Checked = valor
                If (Pulper) Then Hecho5.ForeColor = Color.Red
            Case 6
                Hecho6.Visible = True
                Hecho6.Tag = Line.ToString
                Hecho6.Text = texto
                Hecho6.Checked = valor
                If (Pulper) Then Hecho6.ForeColor = Color.Red
            Case 7
                Hecho7.Visible = True
                Hecho7.Tag = Line.ToString
                Hecho7.Text = texto
                Hecho7.Checked = valor
                If (Pulper) Then Hecho7.ForeColor = Color.Red
            Case 8
                Hecho8.Visible = True
                Hecho8.Tag = Line.ToString
                Hecho8.Text = texto
                Hecho8.Checked = valor
                If (Pulper) Then Hecho8.ForeColor = Color.Red
            Case 9
                Hecho9.Visible = True
                Hecho9.Tag = Line.ToString
                Hecho9.Text = texto
                Hecho9.Checked = valor
                If (Pulper) Then Hecho9.ForeColor = Color.Red
        End Select
    End Sub

    Private Sub Invisible()
        OK1.Visible = False
        OK2.Visible = False
        OK3.Visible = False
        OK4.Visible = False
        OK5.Visible = False
        OK6.Visible = False
        OK7.Visible = False
        OK8.Visible = False
        OK9.Visible = False
        OK10.Visible = False
        OK11.Visible = False
        OK12.Visible = False
        OK13.Visible = False
        OK14.Visible = False
        OK15.Visible = False
        OK16.Visible = False
        NOK1.Visible = False
        NOK2.Visible = False
        NOK3.Visible = False
        NOK4.Visible = False
        NOK5.Visible = False
        NOK6.Visible = False
        NOK7.Visible = False
        NOK8.Visible = False
        NOK9.Visible = False
        NOK10.Visible = False
        NOK11.Visible = False
        NOK12.Visible = False
        NOK13.Visible = False
        NOK14.Visible = False
        NOK15.Visible = False
        NOK16.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False

        Texto1.Visible = False
        Texto2.Visible = False
        Texto3.Visible = False

        Comentarios1.Visible = False
        Comentarios2.Visible = False
        Comentarios3.Visible = False

        Hecho1.Visible = False
        Hecho2.Visible = False
        Hecho3.Visible = False
        Hecho4.Visible = False
        Hecho5.Visible = False
        Hecho6.Visible = False
        Hecho7.Visible = False
        Hecho8.Visible = False
        Hecho9.Visible = False
    End Sub

    Private Sub Bye()
        Me.Close()
    End Sub

    Private Sub OK1_CheckedChanged(sender As Object, e As EventArgs) Handles OK1.CheckedChanged
        NOK1.Checked = Not OK1.Checked
    End Sub

    Private Sub OK2_CheckedChanged(sender As Object, e As EventArgs) Handles OK2.CheckedChanged
        NOK2.Checked = Not OK2.Checked
    End Sub

    Private Sub OK3_CheckedChanged(sender As Object, e As EventArgs) Handles OK3.CheckedChanged
        NOK3.Checked = Not OK3.Checked
    End Sub

    Private Sub OK4_CheckedChanged(sender As Object, e As EventArgs) Handles OK4.CheckedChanged
        NOK4.Checked = Not OK4.Checked
    End Sub

    Private Sub OK5_CheckedChanged(sender As Object, e As EventArgs) Handles OK5.CheckedChanged
        NOK5.Checked = Not OK5.Checked
    End Sub

    Private Sub OK6_CheckedChanged(sender As Object, e As EventArgs) Handles OK6.CheckedChanged
        NOK6.Checked = Not OK6.Checked
    End Sub

    Private Sub OK7_CheckedChanged(sender As Object, e As EventArgs) Handles OK7.CheckedChanged
        NOK7.Checked = Not OK7.Checked
    End Sub

    Private Sub OK8_CheckedChanged(sender As Object, e As EventArgs) Handles OK8.CheckedChanged
        NOK8.Checked = Not OK8.Checked
    End Sub

    Private Sub OK9_CheckedChanged(sender As Object, e As EventArgs) Handles OK9.CheckedChanged
        NOK9.Checked = Not OK9.Checked
    End Sub

    Private Sub OK10_CheckedChanged(sender As Object, e As EventArgs) Handles OK10.CheckedChanged
        NOK10.Checked = Not OK10.Checked
    End Sub

    Private Sub OK11_CheckedChanged(sender As Object, e As EventArgs) Handles OK11.CheckedChanged
        NOK11.Checked = Not OK11.Checked
    End Sub

    Private Sub OK12_CheckedChanged(sender As Object, e As EventArgs) Handles OK12.CheckedChanged
        NOK12.Checked = Not OK12.Checked
    End Sub

    Private Sub OK13_CheckedChanged(sender As Object, e As EventArgs) Handles OK13.CheckedChanged
        NOK13.Checked = Not OK13.Checked
    End Sub

    Private Sub OK14_CheckedChanged(sender As Object, e As EventArgs) Handles OK14.CheckedChanged
        NOK14.Checked = Not OK14.Checked
    End Sub

    Private Sub OK15_CheckedChanged(sender As Object, e As EventArgs) Handles OK15.CheckedChanged
        NOK15.Checked = Not OK15.Checked
    End Sub

    Private Sub OK16_CheckedChanged(sender As Object, e As EventArgs) Handles OK16.CheckedChanged
        NOK16.Checked = Not OK16.Checked
    End Sub

    Private Sub NOK1_CheckedChanged(sender As Object, e As EventArgs) Handles NOK1.CheckedChanged
        OK1.Checked = Not NOK1.Checked
    End Sub

    Private Sub NOK2_CheckedChanged(sender As Object, e As EventArgs) Handles NOK2.CheckedChanged
        OK2.Checked = Not NOK2.Checked
    End Sub

    Private Sub NOK3_CheckedChanged(sender As Object, e As EventArgs) Handles NOK3.CheckedChanged
        OK3.Checked = Not NOK3.Checked
    End Sub

    Private Sub NOK4_CheckedChanged(sender As Object, e As EventArgs) Handles NOK4.CheckedChanged
        OK4.Checked = Not NOK4.Checked
    End Sub

    Private Sub NOK5_CheckedChanged(sender As Object, e As EventArgs) Handles NOK5.CheckedChanged
        OK5.Checked = Not NOK5.Checked
    End Sub

    Private Sub NOK6_CheckedChanged(sender As Object, e As EventArgs) Handles NOK6.CheckedChanged
        OK6.Checked = Not NOK6.Checked
    End Sub

    Private Sub NOK7_CheckedChanged(sender As Object, e As EventArgs) Handles NOK7.CheckedChanged
        OK7.Checked = Not NOK7.Checked
    End Sub

    Private Sub NOK8_CheckedChanged(sender As Object, e As EventArgs) Handles NOK8.CheckedChanged
        OK8.Checked = Not NOK8.Checked
    End Sub

    Private Sub NOK9_CheckedChanged(sender As Object, e As EventArgs) Handles NOK9.CheckedChanged
        OK9.Checked = Not NOK9.Checked
    End Sub

    Private Sub NOK10_CheckedChanged(sender As Object, e As EventArgs) Handles NOK10.CheckedChanged
        OK10.Checked = Not NOK10.Checked
    End Sub

    Private Sub NOK11_CheckedChanged(sender As Object, e As EventArgs) Handles NOK11.CheckedChanged
        OK11.Checked = Not NOK11.Checked
    End Sub

    Private Sub NOK12_CheckedChanged(sender As Object, e As EventArgs) Handles NOK12.CheckedChanged
        OK12.Checked = Not NOK12.Checked
    End Sub

    Private Sub NOK13_CheckedChanged(sender As Object, e As EventArgs) Handles NOK13.CheckedChanged
        OK13.Checked = Not NOK13.Checked
    End Sub

    Private Sub NOK14_CheckedChanged(sender As Object, e As EventArgs) Handles NOK14.CheckedChanged
        OK14.Checked = Not NOK14.Checked
    End Sub

    Private Sub NOK15_CheckedChanged(sender As Object, e As EventArgs) Handles NOK15.CheckedChanged
        OK15.Checked = Not NOK15.Checked
    End Sub

    Private Sub NOK16_CheckedChanged(sender As Object, e As EventArgs) Handles NOK16.CheckedChanged
        OK16.Checked = Not NOK16.Checked
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Tag = ""
        Bye()
    End Sub

    Private Function Verificar_datos() As Boolean
        Verificar_datos = True

        If Verificar_datos And OK1.Visible And (Not OK1.Checked And Not NOK1.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If

        If Verificar_datos And OK2.Visible And (Not OK2.Checked And Not NOK2.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK3.Visible And (Not OK3.Checked And Not NOK3.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK4.Visible And (Not OK4.Checked And Not NOK4.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK5.Visible And (Not OK5.Checked And Not NOK5.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK6.Visible And (Not OK6.Checked And Not NOK6.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK7.Visible And (Not OK7.Checked And Not NOK7.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK8.Visible And (Not OK8.Checked And Not NOK8.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK9.Visible And (Not OK9.Checked And Not NOK9.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK10.Visible And (Not OK10.Checked And Not NOK10.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK11.Visible And (Not OK11.Checked And Not NOK11.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK12.Visible And (Not OK12.Checked And Not NOK12.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK13.Visible And (Not OK13.Checked And Not NOK13.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK14.Visible And (Not OK14.Checked And Not NOK14.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK15.Visible And (Not OK15.Checked And Not NOK15.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If
        If Verificar_datos And OK16.Visible And (Not OK16.Checked And Not NOK16.Checked) Then
            MsgBox("Falta por completar datos del plan")
            Verificar_datos = False
        End If

        If NOK1.Checked Or NOK2.Checked Or NOK3.Checked Or NOK4.Checked Or NOK5.Checked Or NOK6.Checked Or
           NOK7.Checked Or NOK8.Checked Or NOK9.Checked Or NOK10.Checked Or NOK11.Checked Or NOK12.Checked Or
           NOK13.Checked Or NOK14.Checked Or NOK15.Checked Or NOK16.Checked Then

            If Not Hecho1.Checked And Not Hecho2.Checked And Not Hecho3.Checked And Not Hecho4.Checked And Not Hecho5.Checked And Not Hecho6.Checked And Not Hecho7.Checked And Not Hecho8.Checked And Not Hecho8.Checked Then
                MsgBox("No se ha especificado Qué se ha hecho")
                Verificar_datos = False
            End If
        End If

        If Verificar_datos Then
            Etiqueta.Pulper = False
            Etiqueta.Desclasificado = False
            Etiqueta.Pendiente = False

            If Hecho1.Visible And Hecho1.Checked Then Verificar_Pulper_Desclasificado(Hecho1.Tag)
            If Hecho2.Visible And Hecho2.Checked Then Verificar_Pulper_Desclasificado(Hecho2.Tag)
            If Hecho3.Visible And Hecho3.Checked Then Verificar_Pulper_Desclasificado(Hecho3.Tag)
            If Hecho4.Visible And Hecho4.Checked Then Verificar_Pulper_Desclasificado(Hecho4.Tag)
            If Hecho5.Visible And Hecho5.Checked Then Verificar_Pulper_Desclasificado(Hecho5.Tag)
            If Hecho6.Visible And Hecho6.Checked Then Verificar_Pulper_Desclasificado(Hecho6.Tag)
            If Hecho7.Visible And Hecho7.Checked Then Verificar_Pulper_Desclasificado(Hecho7.Tag)
            If Hecho8.Visible And Hecho8.Checked Then Verificar_Pulper_Desclasificado(Hecho8.Tag)
            If Hecho9.Visible And Hecho9.Checked Then Verificar_Pulper_Desclasificado(Hecho9.Tag)

            If Etiqueta.Pendiente And (Etiqueta.Pulper Or Etiqueta.Desclasificado) Then
                MsgBox("No se puede seleccionar PENDIENTE REVISAR y PULPER o DESCLASIFICADO")
                Verificar_datos = False
            End If

            If Etiqueta.Pulper And Etiqueta.Desclasificado Then
                MsgBox("No se puede seleccionar PULPER y DESCLASIFICADO")
                Verificar_datos = False
            End If
        End If
        If Verificar_datos And Etiqueta.Pulper Then
            If Ancho.Text = "" Or Not IsNumeric(Ancho.Text) Then
                MsgBox("No Se ha indicado Ancho CZZ")
                Verificar_datos = False
            End If
        End If
        If Verificar_datos And Etiqueta.Pulper Then
            If Rodajas.Text = "" Or Not IsNumeric(Rodajas.Text) Then
                MsgBox("No Se han indicado Rodajas CZZ")
                Verificar_datos = False
            End If
        End If

        If Verificar_datos And Etiqueta.Pulper And FruverPack.Checked Then
            If Not Variante_FruverPack(CSng(Ancho.Text)) Then
                MsgBox("El ancho no coincide con los anchos de FruverPack")
                Verificar_datos = False
            End If
        End If

        If Verificar_datos And Etiqueta.CambioRollo Then
            If (Me.RolloAnchoMandril.Text = "0") Or (Me.RolloAnchoMandril.Text = "") Then
                MsgBox($"No se ha indicado Ancho Mandril")
                Verificar_datos = False
            End If
            If Verificar_datos And ((Me.RolloAnchoRodaja.Text = "0") Or (Me.RolloAnchoRodaja.Text = "")) Then
                MsgBox($"No se ha indicado Ancho Rodaja")
                Verificar_datos = False
            End If
            If Verificar_datos And Not Me.RolloRodajaDuraNOK.Checked And Not Me.RolloRodajaDuraOK.Checked Then
                MsgBox($"No se ha indicado si la rodasjas son duras")
                Verificar_datos = False
            End If
        End If

        If Verificar_datos And Etiqueta.CambioRollo Then
            Etiqueta.Rollo_AnchoRodaja = CSng(Me.RolloAnchoRodaja.Text)
            Etiqueta.Rollo_AnchoMandril = CSng(Me.RolloAnchoMandril.Text)
            Etiqueta.Rollo_RodajasDuras = Me.RolloRodajaDuraOK.Checked
        End If

        If Verificar_datos And Not Etiqueta.Pulper Then
            Etiqueta.CZZ_Ancho = 0
            Etiqueta.CZZ_Rodajas = 0
            Etiqueta.FruverPack_Item = ""
            Etiqueta.FruverPack_OP = ""
            Etiqueta.FruverPack_VariantCode = ""
        End If

        If Verificar_datos And Etiqueta.Pulper Then
            Etiqueta.CZZ_Ancho = CSng(Ancho.Text)
            Etiqueta.CZZ_Rodajas = CSng(Rodajas.Text)
            Etiqueta.ReferenciaNombre = Datos.CZZ_Nombre
        End If



    End Function

    Private Function Variante_FruverPack(xAncho As Single) As Boolean
        Dim dsFruverPack As DataSet = New DataSet()
        Dim sql As String
        Dim Mensaje As String = ""

        sql = $"Select VA.[Item No_], VA.[Code], VA.[Ancho], MAX(POL.[Prod_ Order No_]) OP
                from [{Datos.Empresa}$Item Variant] VA
                inner Join [{Datos.Empresa}$Prod_ Order Line] POL ON POL.[Item No_] = VA.[Item No_] And POL.[Variant Code] = VA.[Code]
                where VA.[Cliente] = '052'
                  And POL.[Status] = 3
                group by VA.[Item No_], VA.[Code], VA.[Ancho]
                order by VA.[Item No_], VA.[Code], VA.[Ancho]"


        Variante_FruverPack = FuncionesDatos.Cargar_Dataset(dsFruverPack, sql)

        If Variante_FruverPack Then
            Variante_FruverPack = False
            For Each dt As DataRow In dsFruverPack.Tables(0).Rows
                Mensaje += vbCrLf + $"{dt.Item("Item No_")} - {dt.Item("Code")} Ancho: {Format(dt.Item("Ancho"), "###0")}"
                If dt.Item("Ancho") = xAncho Then
                    Etiqueta.FruverPack_Item = dt.Item("Item No_")
                    Etiqueta.FruverPack_VariantCode = dt.Item("Code")
                    Etiqueta.FruverPack_OP = dt.Item("OP")
                    Variante_FruverPack = True
                    Exit For
                End If
            Next

            If Not Variante_FruverPack Then MsgBox($"No se ha indicado un ancho correcto para FruverPack: {Mensaje}")
        End If

    End Function

    Private Sub Rollo_Nuevo()
        Dim sql As String
        Dim oRead As SqlClient.SqlDataReader

        sql = $"SELECT * FROM [{Datos.Empresa}$Cambio Rollo] WHERE [Rollo] = {Etiqueta.Bobina}"
        FuncionesDatos.Ejecutar_Datareader(sql, oRead, False)

        If oRead.HasRows Then
            oRead.Read()
            Etiqueta.CambioRollo = False
            Etiqueta.Rollo_AnchoRodaja = oRead.Item("Ancho Rodaja")
            Etiqueta.Rollo_AnchoMandril = oRead.Item("Ancho Mandril")
            Etiqueta.Rollo_RodajasDuras = (oRead.Item("Rodajas Duras") <> 0)
        Else
            Etiqueta.CambioRollo = True
            Etiqueta.Rollo_AnchoRodaja = 0
            Etiqueta.Rollo_AnchoMandril = 0
            Etiqueta.Rollo_RodajasDuras = True
        End If

        oRead.Close()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim MiCursor As Cursor = Me.Cursor
        Dim MiXml As String = ""
        Dim Comillas As String = Chr(34)

        If Not Verificar_datos() Then Exit Sub

        If Not WebServices.Plan_Verificacion_Borrar(Etiqueta.Palet) Then
            MsgBox("Error al eliminar datos anteriores")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            MiXml = "<?xml version=" + Comillas + "1.0" + Comillas + " encoding=" + Comillas + "ISO-8859-2" + Comillas + " standalone=" + Comillas + "no" + Comillas + "?>" + vbCrLf
            MiXml += "<root>" + vbCrLf

            If Label1.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label1.Tag, OK1.Checked, "")
            If Label2.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label2.Tag, OK2.Checked, "")
            If Label3.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label3.Tag, OK3.Checked, "")
            If Label4.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label4.Tag, OK4.Checked, "")
            If Label5.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label5.Tag, OK5.Checked, "")
            If Label6.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label6.Tag, OK6.Checked, "")
            If Label7.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label7.Tag, OK7.Checked, "")
            If Label8.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label8.Tag, OK8.Checked, "")
            If Label9.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label9.Tag, OK9.Checked, "")
            If Label10.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label10.Tag, OK10.Checked, "")
            If Label11.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label11.Tag, OK11.Checked, "")
            If Label12.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label12.Tag, OK12.Checked, "")
            If Label13.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label13.Tag, OK13.Checked, "")
            If Label14.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label14.Tag, OK14.Checked, "")
            If Label15.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label15.Tag, OK15.Checked, "")
            If Label16.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Label16.Tag, OK16.Checked, "")

            If Comentarios1.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Comentarios1.Tag, False, Comentarios1.Text)
            If Comentarios2.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Comentarios2.Tag, False, Comentarios2.Text)
            If Comentarios3.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Comentarios3.Tag, False, Comentarios3.Text)

            If Hecho1.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Hecho1.Tag, Hecho1.Checked, "")
            If Hecho2.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Hecho2.Tag, Hecho2.Checked, "")
            If Hecho3.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Hecho3.Tag, Hecho3.Checked, "")
            If Hecho4.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Hecho4.Tag, Hecho4.Checked, "")
            If Hecho5.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Hecho5.Tag, Hecho5.Checked, "")
            If Hecho6.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Hecho6.Tag, Hecho6.Checked, "")
            If Hecho7.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Hecho7.Tag, Hecho7.Checked, "")
            If Hecho8.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Hecho8.Tag, Hecho8.Checked, "")
            If Hecho9.Visible Then MiXml += Plan_Xml(Etiqueta.Palet, Etiqueta.OP, Etiqueta.PlanVerificacion, Hecho9.Tag, Hecho9.Checked, "")

            MiXml += "</root>" + vbCrLf

            'WebServices.Plan_Verificacion_Insertar2(MiXml)
            'WebServices.Plan_Verificacion_Counter(Etiqueta.Cliente)

            Me.Tag = "OK"
        Catch ex As Exception
            Me.Tag = ""
        Finally
            Me.Cursor = MiCursor
            Bye()
        End Try

        If Etiqueta.CambioRollo Then
            WebServices.Cambio_Rollo(Etiqueta)
        End If
    End Sub

    Private Function Plan_Xml(xPalet As Integer, xOF As String, xPlan As String, xLine As Integer, xOK As Boolean, xTexto As String) As String
        Dim Desclasificado As Boolean = False
        Dim Pulper As Boolean = False

        Plan_Xml = "<Registro>"
        Plan_Xml += "<Palet>" + xPalet.ToString + "</Palet>"
        Plan_Xml += "<OF>" + xOF + "</OF>"
        Plan_Xml += "<Plan>" + xPlan + "</Plan>"
        Plan_Xml += "<Line>" + xLine.ToString + "</Line>"
        Plan_Xml += "<OK>" + TrueFalse(xOK) + "</OK>"
        Plan_Xml += "<Texto>" + xTexto + "</Texto>"
        Plan_Xml += "</Registro>" + vbCrLf
    End Function

    Private Sub Verificar_Pulper_Desclasificado(xLine As String)
        For Each dt As DataRow In dsPlan.Tables(0).Select("[Line No_] = " + xLine)
            Etiqueta.Pulper = (dt.Item("Pulper") <> 0)
            Etiqueta.Desclasificado = (dt.Item("Desclasificado") <> 0)
            Etiqueta.Pendiente = (dt.Item("Pendiente Revision") <> 0)
        Next
    End Sub

    Private Sub Mostrar_Grupo_CZZ()
        Dim Activo As Boolean
        Dim Linea As String = ""
        Dim Encontrado As Boolean = False

        GrupoCZZ.Visible = False

        For n = 1 To 9
            Select Case n
                Case 1 : Activo = Hecho1.Checked
                    Linea = Hecho1.Tag
                Case 2 : Activo = Hecho2.Checked
                    Linea = Hecho2.Tag
                Case 3 : Activo = Hecho3.Checked
                    Linea = Hecho3.Tag
                Case 4 : Activo = Hecho4.Checked
                    Linea = Hecho4.Tag
                Case 5 : Activo = Hecho5.Checked
                    Linea = Hecho5.Tag
                Case 6 : Activo = Hecho6.Checked
                    Linea = Hecho6.Tag
                Case 7 : Activo = Hecho7.Checked
                    Linea = Hecho7.Tag
                Case 8 : Activo = Hecho8.Checked
                    Linea = Hecho8.Tag
                Case 9 : Activo = Hecho9.Checked
                    Linea = Hecho9.Tag
            End Select

            If Linea <> "" Then
                For Each dt As DataRow In dsPlan.Tables(0).Select("[Line No_] = " + Linea)
                    If dt.Item("Pulper") <> 0 Then
                        GrupoCZZ.Visible = Activo
                        Encontrado = True
                    End If
                Next

            End If

            If Encontrado Then
                    If Not GrupoCZZ.Visible Then
                        If Comentarios3.Visible Then
                            Comentarios3.Text = ""
                        ElseIf Comentarios2.Visible Then
                            Comentarios2.Text = ""
                        ElseIf Comentarios1.Visible Then
                            Comentarios1.Text = ""
                        End If
                    End If

                    Exit For
                End If
        Next

    End Sub


    Private Sub Hecho1_CheckedChanged(sender As Object, e As EventArgs) Handles Hecho1.CheckedChanged
        Mostrar_Grupo_CZZ()
    End Sub

    Private Sub Hecho2_CheckedChanged(sender As Object, e As EventArgs) Handles Hecho2.CheckedChanged
        Mostrar_Grupo_CZZ()
    End Sub

    Private Sub Hecho3_CheckedChanged(sender As Object, e As EventArgs) Handles Hecho3.CheckedChanged
        Mostrar_Grupo_CZZ()
    End Sub

    Private Sub Hecho4_CheckedChanged(sender As Object, e As EventArgs) Handles Hecho4.CheckedChanged
        Mostrar_Grupo_CZZ()
    End Sub

    Private Sub Hecho5_CheckedChanged(sender As Object, e As EventArgs) Handles Hecho5.CheckedChanged
        Mostrar_Grupo_CZZ()
    End Sub

    Private Sub Hecho6_CheckedChanged(sender As Object, e As EventArgs) Handles Hecho6.CheckedChanged
        Mostrar_Grupo_CZZ()
    End Sub

    Private Sub Hecho7_CheckedChanged(sender As Object, e As EventArgs) Handles Hecho7.CheckedChanged
        Mostrar_Grupo_CZZ()
    End Sub

    Private Sub Hecho8_CheckedChanged(sender As Object, e As EventArgs) Handles Hecho8.CheckedChanged
        Mostrar_Grupo_CZZ()
    End Sub

    Private Sub Hecho9_CheckedChanged(sender As Object, e As EventArgs) Handles Hecho9.CheckedChanged
        Mostrar_Grupo_CZZ()
    End Sub

    Private Sub Ancho_TextChanged(sender As Object, e As EventArgs) Handles Ancho.TextChanged
        If Comentarios3.Visible Then
            Comentarios3.Text = $" Ancho CZZ:{Ancho.Text}   Rodajas CZZ:{Rodajas.Text}"
        Else
            If Comentarios2.Visible Then
                Comentarios2.Text = $" Ancho CZZ:{Ancho.Text}   Rodajas CZZ:{Rodajas.Text}"
            Else
                If Comentarios1.Visible Then
                    Comentarios1.Text = $" Ancho CZZ:{Ancho.Text}   Rodajas CZZ:{Rodajas.Text}"
                End If
            End If
        End If
    End Sub

    Private Sub Rodajas_TextChanged(sender As Object, e As EventArgs) Handles Rodajas.TextChanged
        If Comentarios3.Visible Then
            Comentarios3.Text = $" Ancho CZZ:{Ancho.Text}   Rodajas CZZ:{Rodajas.Text}"
        Else
            If Comentarios2.Visible Then
                Comentarios2.Text = $" Ancho CZZ:{Ancho.Text}   Rodajas CZZ:{Rodajas.Text}"
            Else
                If Comentarios1.Visible Then
                    Comentarios1.Text = $" Ancho CZZ:{Ancho.Text}   Rodajas CZZ:{Rodajas.Text}"
                End If
            End If
        End If
    End Sub
End Class