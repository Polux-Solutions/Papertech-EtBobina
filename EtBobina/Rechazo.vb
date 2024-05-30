Option Explicit On
Imports System.Globalization

Public Class Rechazo
    Dim dsRechazo As DataSet

    Private Sub Rechazo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsRechazo = Nothing

        FuncionesDatos.Cargar_Dataset(dsRechazo, $"SELECT [Code], [Nombre ESP] FROM [{Datos.Empresa}$Scrap] 
                                                   WHERE [Area] = 1 AND [Activo] <>0")
        If dsRechazo.Tables(0).Rows.Count = 0 Then
            MsgBox("No Existen Códigos de Rechazo")
            Me.Close()
        End If

        coRechazo.DisplayMember = "Nombre ESP"
        coRechazo.ValueMember = "Code"
        coRechazo.DataSource = dsRechazo.Tables(0)
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim sw9 As Boolean

        sw9 = Validar_Datos()

        If sw9 Then sw9 = WebServices.Scrap(Me.OP.Text, CInt(Me.Bobina.Text), Me.coRechazo.SelectedValue, CSng(Me.KGS.Text))

        If sw9 Then Salir()
    End Sub

    Private Sub Salir()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Function Validar_Datos() As Boolean
        Validar_Datos = True

        If Me.coRechazo.SelectedValue = "" Then
            Validar_Datos = False
            MsgBox("No se ha indicado motivo de rechazo")
        End If

        If Validar_Datos And (Me.Bobina.Text = "") Then
            Validar_Datos = False
            MsgBox("No se ha indicado  Nº de Bobina")
        End If

        If Validar_Datos And (Me.KGS.Text = "") Then
            Validar_Datos = False
            MsgBox("No se ha indicado el peso estimado")
        End If

        If Validar_Datos And Not IsNumeric(Me.KGS.Text) Then
            Validar_Datos = False
            MsgBox("El Peso ha de ser numérico")
        End If
    End Function

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Salir()
    End Sub

    Private Sub BobinaMas_Click(sender As Object, e As EventArgs) Handles BobinaMas.Click
        If Not IsNumeric(Bobina.Text) Then Bobina.Text = ""
        If Bobina.Text = "" Then Bobina.Text = "0"


        Try
            Bobina.Text = Format(CInt(Bobina.Text) + 1)
        Catch
            Bobina.Text = "1"
        End Try
    End Sub

    Private Sub BobinaMenos_Click(sender As Object, e As EventArgs) Handles BobinaMenos.Click
        If Not IsNumeric(Bobina.Text) Then Bobina.Text = ""
        If Bobina.Text = "" Or Bobina.Text = "0" Then Bobina.Text = "1"

        Try
            Bobina.Text = Format(CInt(Bobina.Text) - 1)
        Catch
            Bobina.Text = "1"
        End Try
    End Sub
End Class