Option Explicit On
Imports System.Globalization

Public Class Rechazo
    Dim dsRechazo As DataSet

    Private Sub Rechazo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsRechazo = Nothing

        FuncionesDatos.Cargar_Dataset(dsRechazo, $"SELECT [Code], [Description] FROM [{Datos.Empresa}$Scrap]")
        If dsRechazo.Tables(0).Rows.Count = 0 Then
            MsgBox("No Existen Códigos de Rechazo")
            Me.Close()
        End If

        coRechazo.DisplayMember = "Description"
        coRechazo.ValueMember = "Code"
        coRechazo.DataSource = dsRechazo.Tables(0)
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim sw9 As Boolean

        sw9 = Validar_Datos()

        If sw9 Then sw9 = WebServices.Insertar_Rechazo(Me.coRechazo.SelectedValue, Me.txBobina.Text, CInt(Me.txRodajas.Text), CInt(Me.txKGS.Text))

        If sw9 Then Salir
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

        If Validar_Datos And (Me.txBobina.Text = "") Then
            Validar_Datos = False
            MsgBox("No se ha indicado  Nº de Bobina")
        End If

        If Validar_Datos And (Me.txRodajas.Text = "") Then
            Validar_Datos = False
            MsgBox("No se ha indicado el Nº de Rodajas")
        End If

        If Validar_Datos And Not IsNumeric(Me.txRodajas.Text) Then
            Validar_Datos = False
            MsgBox("el Nº de rodajas ha de ser numérico")
        End If

        If Validar_Datos And (Me.txKGS.Text = "") Then
            Validar_Datos = False
            MsgBox("No se ha indicado el peso estimado")
        End If

        If Validar_Datos And Not IsNumeric(Me.txKGS.Text) Then
            Validar_Datos = False
            MsgBox("El Peso ha de ser numérico")
        End If
    End Function

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Salir()
    End Sub
End Class