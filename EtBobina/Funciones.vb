Option Explicit On
Imports System.Data.SqlClient
Imports System.Xml
Imports System.Type
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module Funciones

    Public Function Leer_Parametros() As Boolean
        Dim Config As New System.Configuration.AppSettingsReader

        Leer_Parametros = True

        Datos.FechaTrabajo = CDate("August 27, 2003")
        Datos.ActualizarPalet = True
        Try
            Datos.Servidor_Prod = Config.GetValue("SERVER-SQL", GetType(System.String)).ToString
            Datos.BD_Prod = Config.GetValue("BD-SQL", GetType(System.String)).ToString
            Datos.Empresa_Prod = Config.GetValue("EMPRESA", GetType(System.String)).ToString
            Datos.Usuario_Prod = Funciones.Decrypt("_venus13", Config.GetValue("USUARIO-SQL", GetType(System.String)).ToString)
            Datos.Password_Prod = Funciones.Decrypt("_venus13", Config.GetValue("CONTRASEÑA-SQL", GetType(System.String)).ToString)
            Datos.ServidorWeb_Prod = Config.GetValue("SERVER-WEB", GetType(System.String)).ToString
            Datos.UsuarioWeb_Prod = Funciones.Decrypt("_venus13", Config.GetValue("USUARIO-WEB", GetType(System.String)).ToString)
            Datos.PasswordWeb_Prod = Funciones.Decrypt("_venus13", Config.GetValue("CONTRASEÑA-WEB", GetType(System.String)).ToString)
            Datos.DominioWeb_Prod = Funciones.Decrypt("_venus13", Config.GetValue("DOMINIO-WEB", GetType(System.String)).ToString)
            Datos.ServidorReporting_Prod = Config.GetValue("SERVER-REPORTING", GetType(System.String)).ToString
            Datos.BDReporting_Prod = Config.GetValue("BD-REPORTING", GetType(System.String)).ToString
            Datos.UsuarioReporting_Prod = Funciones.Decrypt("_venus13", Config.GetValue("USUARIO-REPORTING", GetType(System.String)).ToString)
            Datos.PasswordReporting_Prod = Funciones.Decrypt("_venus13", Config.GetValue("CONTRASEÑA-REPORTING", GetType(System.String)).ToString)
            Datos.Servidor_Test = Config.GetValue("SERVER-SQL-TEST", GetType(System.String)).ToString
            Datos.BD_Test = Config.GetValue("BD-SQL-TEST", GetType(System.String)).ToString
            Datos.Empresa_Test = Config.GetValue("EMPRESA-TEST", GetType(System.String)).ToString
            Datos.Usuario_Test = Funciones.Decrypt("_venus13", Config.GetValue("USUARIO-SQL-TEST", GetType(System.String)).ToString)
            Datos.Password_Test = Funciones.Decrypt("_venus13", Config.GetValue("CONTRASEÑA-SQL-TEST", GetType(System.String)).ToString)
            Datos.ServidorWeb_Test = Config.GetValue("SERVER-WEB-TEST", GetType(System.String)).ToString
            Datos.UsuarioWeb_Test = Funciones.Decrypt("_venus13", Config.GetValue("USUARIO-WEB-TEST", GetType(System.String)).ToString)
            Datos.PasswordWeb_Test = Funciones.Decrypt("_venus13", Config.GetValue("CONTRASEÑA-WEB-TEST", GetType(System.String)).ToString)
            Datos.DominioWeb_Test = Funciones.Decrypt("_venus13", Config.GetValue("DOMINIO-WEB-TEST", GetType(System.String)).ToString)
            Datos.ServidorReporting_Test = Config.GetValue("SERVER-REPORTING-TEST", GetType(System.String)).ToString
            Datos.BDReporting_Test = Config.GetValue("BD-REPORTING-TEST", GetType(System.String)).ToString
            Datos.UsuarioReporting_Test = Funciones.Decrypt("_venus13", Config.GetValue("USUARIO-REPORTING-TEST", GetType(System.String)).ToString)
            Datos.PasswordReporting_Test = Funciones.Decrypt("_venus13", Config.GetValue("CONTRASEÑA-REPORTING-TEST", GetType(System.String)).ToString)
            Datos.ImpresoraQR = Config.GetValue("IMPRESORA-QR", GetType(System.String)).ToString
            Datos.TecIt_ID = Config.GetValue("TECIT ID", GetType(System.String)).ToString
            Datos.TecIt_Empresa = Config.GetValue("TECIT EMPRESA", GetType(System.String)).ToString
            Datos.TecIt_License = Config.GetValue("TECIT LICENSE", GetType(System.String)).ToString
            Datos.Log = Config.GetValue("LOG", GetType(System.String)).ToString
            Datos.Versión = Config.GetValue("VERSION", GetType(System.String)).ToString
            Datos.Lote_Palet = (Config.GetValue("LOTE-PALET", GetType(System.String)).ToString = "SI")
            Datos.Reload = True
            Datos.ModoTest = False
        Catch ex As Exception
            MsgBox("Error al leer parámetros " & ex.Message, MsgBoxStyle.Critical)
            Leer_Parametros = False
            Exit Function
        End Try
    End Function

    Public Sub Parametros_Utilizar()
        If Datos.ModoTest Then
            Datos.Servidor = Datos.Servidor_Test
            Datos.BD = Datos.BD_Test
            Datos.Empresa = Datos.Empresa_Test
            Datos.Usuario = Datos.Usuario_Test
            Datos.Password = Datos.Password_Test
            Datos.ServidorWeb = Datos.ServidorWeb_Test
            Datos.UsuarioWeb = Datos.UsuarioWeb_Test
            Datos.PasswordWeb = Datos.PasswordWeb_Test
            Datos.DominioWeb = Datos.DominioWeb_Test
            Datos.ServidorReporting = Datos.ServidorReporting_Test
            Datos.BDReporting = Datos.BDReporting_Test
            Datos.UsuarioReporting = Datos.UsuarioReporting_Test
            Datos.PasswordReporting = Datos.PasswordReporting_Test
        Else
            Datos.Servidor = Datos.Servidor_Prod
            Datos.BD = Datos.BD_Prod
            Datos.Empresa = Datos.Empresa_Prod
            Datos.Usuario = Datos.Usuario_Prod
            Datos.Password = Datos.Password_Prod
            Datos.ServidorWeb = Datos.ServidorWeb_Prod
            Datos.UsuarioWeb = Datos.UsuarioWeb_Prod
            Datos.PasswordWeb = Datos.PasswordWeb_Prod
            Datos.DominioWeb = Datos.DominioWeb_Prod
            Datos.ServidorReporting = Datos.ServidorReporting_Prod
            Datos.BDReporting = Datos.BDReporting_Prod
            Datos.UsuarioReporting = Datos.UsuarioReporting_Prod
            Datos.PasswordReporting = Datos.PasswordReporting_Prod
        End If
    End Sub


    Public Sub Log(ByVal texto As String)
        Dim sr As System.IO.StreamWriter

        Try
            sr = New System.IO.StreamWriter(Datos.Log, True)
            sr.WriteLine(Datos.Versión & " " & Format(Now, "dd.MM.yy hh:mm:ss") & "   " & texto)
            sr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub Code128()
        Dim Peso As Integer = Etiqueta.PesoNeto

        If Etiqueta.TipoPeso = 1 Then Peso = Etiqueta.PesoBruto

        Etiqueta.Barcode = "(00) " + "3" + "84" + "33274" + Format(Etiqueta.Palet, "00000000") +
                                    Format(Etiqueta.Rodajas, "00")



        Etiqueta.BarcodeLeiza = Etiqueta.PedidoCliente + "/" + Etiqueta.ReferenciaCruzada + "/" + Format(Peso, "0000")

        'Etiqueta.BarcodeLeiza = "09102020_SIDE" + "/" + Etiqueta.ReferenciaCruzada + "/" +
        'Format(Etiqueta.PesoNeto, "0000")

        Etiqueta.barcodeSCA1 = "90" + Etiqueta.PedidoCliente + "30" + Format(Peso, "0000")

        If Datos.Lote_Palet Then
            Etiqueta.barcodeSCA2 = "10" + Etiqueta.Palet
        Else
            If Etiqueta.OP.Length > 2 Then Etiqueta.barcodeSCA2 = "10" + Etiqueta.OP.Substring(2, Etiqueta.OP.Length - 2)
        End If

    End Sub

    Public Sub Limpiar_Etiqueta()
        Etiqueta.OP = ""
        Etiqueta.Manual = False
        Etiqueta.Line = 0
        Etiqueta.NoReserva = 0
        Etiqueta.Pedido = ""
        Etiqueta.Cliente = ""
        Etiqueta.TipoEtiqueta = 0
        Etiqueta.Idioma = ""
        Etiqueta.SuReferencia = ""
        Etiqueta.PedidoCliente = ""
        Etiqueta.Referencia = ""
        Etiqueta.ReferenciaNombre = ""
        Etiqueta.ReferenciaTranslation = ""
        Etiqueta.ReferenciaCruzada = ""
        Etiqueta.Variante = ""
        Etiqueta.VarianteNombre = ""
        Etiqueta.VarianteTranslation = ""
        Etiqueta.ObsEtiqueta = ""
        Etiqueta.Calidad = ""
        Etiqueta.Fecha = Datos.FechaTrabajo
        Etiqueta.Ancho = 0
        Etiqueta.Rodajas = 0
        Etiqueta.Gramaje = 0
        Etiqueta.Calibre = 0
        Etiqueta.Palet = 0
        Etiqueta.Bobina = 0
        Etiqueta.PesoBruto = 0
        Etiqueta.PesoNeto = 0
        Etiqueta.PesoPalet = 0
        Etiqueta.NoEAN = 0
        Etiqueta.Barcode = ""
        Etiqueta.BarcodeLeiza = ""
        Etiqueta.barcodeSCA1 = ""
        Etiqueta.barcodeSCA2 = ""
        Etiqueta.MetrosRodaja = 0
        Etiqueta.PedirMetrosRodaja = False
        Etiqueta.PedirMetrosPalet = False
        Etiqueta.MetrosPalet = 0
        Etiqueta.Terminar = False
        Etiqueta.MostrarCalibre = True
        Etiqueta.MostrarGramaje = True
        Etiqueta.CZZ_Ancho = 0
        Etiqueta.CZZ_Rodajas = 0
        Etiqueta.FruverPack_Item = ""
        Etiqueta.FruverPack_OP = ""
        Etiqueta.FruverPack_VariantCode = ""
        Etiqueta.Pendiente = False
        Etiqueta.CambioRollo = False
        Etiqueta.Rollo_AnchoMandril = 0
        Etiqueta.Rollo_AnchoRodaja = 0
        Etiqueta.Rollo_RodajasDuras = False
    End Sub

    Public Sub Grabar_Etiqueta()
        If Etiqueta.Manual Then
            EtManual = Etiqueta
            Exit Sub
        End If

        If IsNothing(Historial) Then
            ReDim Historial(0)
        Else
            Dim n As Byte

            For n = 0 To Historial.Length - 1
                If Historial(n).OP = Etiqueta.OP And Historial(n).Rodajas = Etiqueta.Rodajas And
                   Historial(n).EtiquetasPorPalet = Etiqueta.EtiquetasPorPalet Then
                    Exit Sub
                End If

            Next

            If Historial.Length = 6 Then
                For n = 0 To 4
                    Historial(n) = Historial(n + 1)
                Next
            End If
            If Historial.Length < 6 Then ReDim Preserve Historial(Historial.Length)
        End If

        Historial(Historial.Length - 1) = Etiqueta

        'Historial(Historial.Length - 1).PesoNeto = 0
        Historial(Historial.Length - 1).MetrosRodaja = 0

        Etiqueta.OP = ""
        Etiqueta.PesoNeto = 0
        Etiqueta.PesoPalet = 0
    End Sub

    Public Function FormatoAncho(valor As Single) As String
        If Right(Format(valor, "0.0"), 1) = "0" Then
            FormatoAncho = Format(valor, "###,##0")
        Else
            FormatoAncho = Format(valor, "###,##0.0")
        End If

    End Function

    Public Sub Calcular_Metros()
        Dim Metros As Single
        Dim Ancho As Single
        Dim Gramaje As Single

        Etiqueta.MetrosPalet = 0
        Etiqueta.MetrosRodaja = 0

        Panel.txMetrosPalet.Text = ""
        Panel.txMetrosRodaja.Text = ""

        If Etiqueta.PesoNeto = 0 Then Exit Sub
        If Etiqueta.Gramaje = 0 Then Exit Sub
        If Etiqueta.Ancho = 0 Then Exit Sub

        Gramaje = Etiqueta.Gramaje / 1000 ' Gramaje en KGS.
        Ancho = Etiqueta.Ancho / 1000
        Metros = (Etiqueta.PesoNeto / Gramaje) / Ancho

        Etiqueta.MetrosPalet = CInt(Metros)

        If Etiqueta.Rodajas <> 0 Then Etiqueta.MetrosRodaja = CInt(Metros / Etiqueta.Rodajas)

        Panel.txMetrosPalet.Text = Etiqueta.MetrosPalet.ToString
        Panel.txMetrosRodaja.Text = Etiqueta.MetrosRodaja.ToString
    End Sub

    Public Function ColorFondo() As Color
        If Datos.ModoTest Then
            ColorFondo = Color.SkyBlue
        Else
            ColorFondo = SystemColors.Control
        End If
    End Function

    Public Function TrueFalse(sw As Boolean) As String
        If sw Then
            TrueFalse = "true"
        Else
            TrueFalse = "false"
        End If
    End Function

    Public Function Existe_Impresora(xPrinter As String)
        Existe_Impresora = False

        For Each strInstalledPrinters In PrinterSettings.InstalledPrinters
            If strInstalledPrinters.ToString.ToUpper = xPrinter.ToUpper Then
                Existe_Impresora = True
                Exit For
            End If
        Next strInstalledPrinters
    End Function


    Public Function Gs1_Digito_Control(gs1 As String) As String
        Dim Pares As Integer = 0
        Dim Impares As Integer = 0
        Dim total As String = ""
        Dim Unidades As Integer

        Gs1_Digito_Control = ""

        For n = 1 To gs1.Length
            If n \ 2 = n / 2 Then
                Pares += gs1.Substring(n - 1, 1)
            Else
                Impares += gs1.Substring(n - 1, 1)
            End If
        Next

        total = (Pares + (Impares * 3)).ToString

        Unidades = total.Substring(total.Length - 1, 1)
        If Unidades <> 0 Then Unidades = 10 - Unidades

        Gs1_Digito_Control = Unidades.ToString
    End Function

    Public Function Valor_OP(xOP As String) As Integer
        Dim t As String = "0"
        Dim n As Integer

        For n = 0 To xOP.Length - 1
            If IsNumeric(xOP.Substring(n, 1)) Then t += xOP.Substring(n, 1)
        Next

        Valor_OP = CInt(t)
    End Function


    Public Function Encrypt(clave As String, clearText As String) As String
        Dim EncryptionKey As String = clave
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    Public Function Decrypt(clave As String, cipherText As String) As String
        Dim EncryptionKey As String = clave
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
End Module
