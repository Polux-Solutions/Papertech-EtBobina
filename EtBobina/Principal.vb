Option Explicit On
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Diagnostics
Imports System
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Management


Module Principal
    Public Datos As Datosclass = New Datosclass
    Public Etiqueta As EtiquetaClass = New EtiquetaClass
    Public MQTT As Macsa_Envio = New Macsa_Envio()
    Public Historial As New List(Of EtiquetaClass)
    Public EtManual As EtiquetaClass = New EtiquetaClass
    Public Usuario As String


    Public Sub MAIN()
        Dim sw9 As Boolean

        Usuario = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()

        If Usuario.StartsWith("URSS") Then Usuario = "SPCDOMN\158973"

        sw9 = Leer_Parametros(Datos)

        Parametros_Utilizar()
        If sw9 Then sw9 = Extraer_Usuario_Web(Datos)

        If sw9 And (Datos.ImpresoraAntiguas = String.Empty) Then
            Dim ps As New PrinterSettings()
            Datos.ImpresoraAntiguas = ps.PrinterName
        End If
        If sw9 And (Datos.ImpresoraAntiguas <> "") Then
            sw9 = Funciones.Existe_Impresora(Datos.ImpresoraAntiguas)
            If Not sw9 Then MsgBox($"No Existe la impresora QR {Datos.ImpresoraAntiguas}", vbCritical, "Etiquetas Bobina")
        End If

        If sw9 Then
            While Datos.Reload
                Datos.Reload = False

                    Parametros_Utilizar()
                    Panel.ShowDialog()
                End While
            End If
    End Sub

End Module
