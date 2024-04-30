Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports Microsoft.Reporting.WinForms
Public Class ReportV

    Private Sub ReportV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReportingNAVDataSet2.Etiquetas_Salida2' Puede moverla o quitarla según sea necesario.
        'Me.Etiquetas_Salida2TableAdapter.Fill(Me.ReportingNAVDataSet2.Etiquetas_Salida2)
        'TODO: esta línea de código carga datos en la tabla 'ReportingNAVDataSet1.Etiquetas_Salida2' Puede moverla o quitarla según sea necesario.
        'Me.Etiquetas_Salida2TableAdapter.Fill(Me.ReportingNAVDataSet1.Etiquetas_Salida2)
        'TODO: esta línea de código carga datos en la tabla 'ReportingNAVDataSet.Etiquetas_Salida' Puede moverla o quitarla según sea necesario.
        Cargar()
    End Sub

    Private Sub Cargar()
        Me.Etiquetas_SalidaTableAdapter.Connection = Datos.ConexReporting

        Me.Etiquetas_SalidaTableAdapter.Fill(Me.ReportingNAVDataSet.Etiquetas_Salida)

        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub ReportViewer1_BookmarkNavigation(sender As Object, e As BookmarkNavigationEventArgs) Handles ReportViewer1.BookmarkNavigation
        If Not IsNumeric(e.BookmarkId.ToString) Then Exit Sub

        Dim Dr() As DataRow
        Dr = ReportingNAVDataSet.Tables(0).Select("[EntryId] = " + e.BookmarkId.ToString)

        If Dr.Length = 0 Then
            MsgBox("No Existe el registro: " + e.BookmarkId.ToString, MsgBoxStyle.Exclamation, "-Informe Etiquetas-")
            Exit Sub
        End If
        If Dr.Length = 1 Then
            Dim mensaje As String
            mensaje = "¿Desea Borrar El Lote: " + Dr(0).Item("Lote").ToString + " De la Orden : " + Dr(0).Item("Orden") + vbCrLf +
                       " Con Cantidad: " + Dr(0).Item("Cantidad").ToString + "?"
            If MsgBox(mensaje, MsgBoxStyle.OkCancel, "Eliminar Movimientos") = MsgBoxResult.Ok Then
                If Eliminar_Linea(Dr(0).Item("NoReserva"), Dr(0).Item("Orden").ToString, Dr(0).Item("Referencia").ToString, Dr(0).Item("Variante").ToString,
                                  Dr(0).Item("Cantidad")) Then
                    Dr(0).Delete()
                    'Cargar()
                End If
            End If
        End If
    End Sub

End Class