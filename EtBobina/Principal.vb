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
    Public Structure stDatos
        Public Empresa As String
        Public Servidor As String
        Public BD As String
        Public Usuario As String
        Public Password As String
        Public ServidorWeb As String
        Public PuertoWeb As String
        Public UsuarioWeb As String
        Public PasswordWeb As String
        Public DominioWeb As String
        Public ServidorReporting As String
        Public BDReporting As String
        Public UsuarioReporting As String
        Public PasswordReporting As String
        Public Empresa_Prod As String
        Public Servidor_Prod As String
        Public BD_Prod As String
        Public Usuario_Prod As String
        Public Password_Prod As String
        Public ServidorWeb_Prod As String
        Public PuertoWeb_Prod As String
        Public UsuarioWeb_Prod As String
        Public PasswordWeb_Prod As String
        Public DominioWeb_Prod As String
        Public ServidorReporting_Prod As String
        Public BDReporting_Prod As String
        Public UsuarioReporting_Prod As String
        Public PasswordReporting_Prod As String
        Public Empresa_Test As String
        Public Servidor_Test As String
        Public BD_Test As String
        Public Usuario_Test As String
        Public Password_Test As String
        Public ServidorWeb_Test As String
        Public PuertoWeb_Test As String
        Public UsuarioWeb_Test As String
        Public PasswordWeb_Test As String
        Public DominioWeb_Test As String
        Public ServidorReporting_Test As String
        Public BDReporting_Test As String
        Public UsuarioReporting_Test As String
        Public PasswordReporting_Test As String
        Public Log As String
        Public Versión As String
        Public Conex As SqlClient.SqlConnection
        Public ConexReporting As SqlClient.SqlConnection
        Public FechaTrabajo As Date
        Public ModoTest As Boolean
        Public Reload As Boolean
        Public ActualizarPalet As Boolean
        Public IdDisco As String
        Public TecIt_ID As String
        Public TecIt_Empresa As String
        Public TecIt_License As String
        Public Lote_Palet As Boolean
        Public ImpresoraQR As String
        Public CZZ_Nombre As String
    End Structure
    Public Structure stEtiqueta
        Public Turno As String
        Public Horario As String
        Public EtiquetasPorPalet As Byte
        Public Copias As Byte
        Public OP As String
        Public Bobina As Integer
        Public Manual As Boolean
        Public Line As Long
        Public NoReserva As Long
        Public Pedido As String
        Public Cliente As String
        Public TipoEtiqueta As Integer ' 0-> Normal 1-> Leiza 2-> Essity 3->Sonoco 4-> Sonoco QR
        Public TipoPeso As Integer ' 0->Neto 1->Bruto
        Public GenerarQR As Boolean
        Public Idioma As String
        Public SuReferencia As String
        Public PedidoCliente As String
        Public Referencia As String
        Public ReferenciaNombre As String
        Public ReferenciaTranslation As String
        Public ReferenciaCruzada As String
        Public Variante As String
        Public VarianteNombre As String
        Public VarianteTranslation As String
        Public ObsEtiqueta As String
        Public Calidad As String
        Public Fecha As Date
        Public Ancho As Decimal
        Public Rodajas As Integer
        Public Gramaje As Integer
        Public Calibre As Integer
        Public Palet As Long
        Public PesoBruto As Long
        Public PesoNeto As Long
        Public PesoPalet As Long
        Public NoEAN As Long
        Public Barcode As String
        Public BarcodeLeiza As String
        Public barcodeSCA1 As String
        Public barcodeSCA2 As String
        Public PedirMetrosRodaja As Boolean
        Public PedirMetrosPalet As Boolean
        Public MetrosRodaja As Integer
        Public MetrosPalet As Integer
        Public Terminar As Boolean
        Public MostrarGramaje As Boolean
        Public MostrarCalibre As Boolean
        Public PlanVerificacion As String
        Public PlanVerifcaAlta As Boolean
        Public Pulper As Boolean
        Public Desclasificado As Boolean
        Public CZZ_Ancho As Single
        Public CZZ_Rodajas As Integer
        Public FruverPack_Item As String
        Public FruverPack_VariantCode As String
        Public FruverPack_OP As String
        Public Pendiente As Boolean
        Public CambioRollo As Boolean
        Public Rollo_AnchoRodaja As Single
        Public Rollo_AnchoMandril As Single
        Public Rollo_RodajasDuras As Boolean
    End Structure
    Public Datos As stDatos
    Public Etiqueta As stEtiqueta
    Public Historial() As stEtiqueta
    Public EtManual As stEtiqueta
    Public Usuario As String


    Public Sub MAIN()
        Dim sw9 As Boolean

        Usuario = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString()

        If Usuario.StartsWith("URSS") Then Usuario = "PTEDOM01\Administrador"

        sw9 = Leer_Parametros()
        Parametros_Utilizar()
        If sw9 Then sw9 = Extraer_Usuario_Web()

        If sw9 And (Datos.ImpresoraQR <> "") Then
            sw9 = Funciones.Existe_Impresora(Datos.ImpresoraQR)
            If Not sw9 Then MsgBox($"No Existe la impresora QR {Datos.ImpresoraQR}", vbCritical, "Etiquetas Bobina")
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
