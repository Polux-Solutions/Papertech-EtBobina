Option Explicit On
Imports BarcodeLib

Imports ZXing
Imports ZXing.QrCode
Imports System.Web.Mvc
Imports System.Drawing
Imports System.Drawing.Printing

Public Class Lienzo

    Private QrCode As String

    Private Sub Papel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Barcode1.Barcode.License(Datos.TecIt_Empresa, Barcode1.Barcode.LicenseType.Single, 1, Datos.TecIt_License, Barcode1.Barcode.LicensedProduct.Barcode1D)
        Barcode1B.Barcode.License(Datos.TecIt_Empresa, Barcode1B.Barcode.LicenseType.Single, 1, Datos.TecIt_License, Barcode1B.Barcode.LicensedProduct.Barcode1D)
        Barcode2.Barcode.License(Datos.TecIt_Empresa, Barcode2.Barcode.LicenseType.Single, 1, Datos.TecIt_License, Barcode2.Barcode.LicensedProduct.Barcode1D)
        Barcode3.Barcode.License(Datos.TecIt_Empresa, Barcode3.Barcode.LicenseType.Single, 1, Datos.TecIt_License, Barcode3.Barcode.LicensedProduct.Barcode1D)
        generar_Barcode()

        Dim sz As Size

        sz.Width = Me.Width
        sz.Height = 514
        If Etiqueta.TipoEtiqueta = 2 Or Etiqueta.TipoEtiqueta = 3 Or Etiqueta.TipoEtiqueta = 4 Then sz.Height += 90
        Me.Size = sz

        Dim punto2 As New Point
        punto2.Y = Me.Location.Y + Me.Size.Height + 10
        punto2.X = ListaOP.Location.X
        ListaOP.Location = punto2
    End Sub

    Private Sub generar_Barcode()
        Dim bar = New BarcodeLib.Barcode

        Funciones.Code128()

        bar.IncludeLabel = True
        'Barcode1.Image = bar.Encode(BarcodeLib.TYPE.CODE128B, Etiqueta.Barcode, Barcode.Size.Width, Barcode.Size.Height)

        BarcodeLeiza.Visible = False
        Barcode1.Visible = False
        Barcode1.Size = New Size(343, 58)
        Barcode1B.Visible = False
        Barcode2.Visible = False
        Barcode3.Visible = False
        BarcodeQR.Visible = False

        If Etiqueta.TipoEtiqueta = 0 Then

        End If

        ' Etiqueta Normal
        If Etiqueta.TipoEtiqueta = 0 Then
            Barcode1.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.Code128
            Barcode1.Barcode.TranslateEscapeSequences = True
            Barcode1.Barcode.Data = Etiqueta.Barcode
            Barcode1.Visible = True

            Barcode1.Refresh()
        End If

        'Etiqueta Leiza
        If Etiqueta.TipoEtiqueta = 1 Then
            BarcodeLeiza.Image = bar.Encode(BarcodeLib.TYPE.CODE128B, Etiqueta.BarcodeLeiza,
                                            BarcodeLeiza.Size.Width, BarcodeLeiza.Size.Height)
            BarcodeLeiza.Visible = True
        End If

        ' Etiqueta Essity
        If Etiqueta.TipoEtiqueta = 2 Then
            Dim Peso As String = Me.txNeto.Text

            Try
                If Etiqueta.TipoPeso = 1 Then Peso = Me.txBruto.Text

                Barcode1.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.EanUcc128
                Barcode1.Barcode.TranslateEscapeSequences = True
                Barcode1.Barcode.Data = "93" + Etiqueta.ReferenciaCruzada + Chr(92) + "F" + "30" + Peso
                Barcode1.Size = New Size(172, 58)
                Barcode1.Visible = True
                Barcode1.Refresh()

                Barcode2.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.EanUcc128
                Barcode2.Barcode.TranslateEscapeSequences = True
                Barcode2.Visible = True

                If Datos.Lote_Palet Then
                    Barcode2.Barcode.Data = "10" + Etiqueta.Palet.ToString
                Else
                    Barcode2.Barcode.Data = "10" + Etiqueta.OP.Substring(2, Etiqueta.OP.Length - 2)
                End If

                Barcode2.Refresh()

                Dim gs1 As String = "3" + "84" + "33274" + Format(Etiqueta.Palet, "0000000") + Format(Etiqueta.Rodajas, "00")

                Barcode3.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.GS1_128
                Barcode3.Barcode.TranslateEscapeSequences = True
                Barcode3.Barcode.Data = "00" + gs1 + Gs1_Digito_Control(gs1)
                Barcode3.Visible = True
                Barcode3.Refresh()
            Catch ex As Exception
                Log("Error al generar Barcode SCA: " + ex.Message)
            End Try

        End If


        If Etiqueta.TipoEtiqueta = 3 Then ' Sonoco
            Dim Peso As String = Me.txNeto.Text

            Try
                If Etiqueta.TipoPeso = 1 Then Peso = Me.txBruto.Text

                Barcode1.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.Code128
                Barcode1.Barcode.TranslateEscapeSequences = True
                Barcode1.Barcode.Data = "G740" + Etiqueta.Palet.ToString
                Barcode1.Size = New Size(172, 58)
                Barcode1.Visible = True
                Barcode1.Refresh()

                Barcode1B.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.Code128
                Barcode1B.Barcode.TranslateEscapeSequences = True
                Barcode1B.Barcode.Data = Etiqueta.PesoNeto
                Barcode1B.Size = New Size(140, 58)
                Barcode1B.Visible = True
                Barcode1B.Refresh()

                Barcode2.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.Code128
                Barcode2.Barcode.TranslateEscapeSequences = True
                Barcode2.Barcode.Data = Etiqueta.ReferenciaCruzada
                Barcode2.Size = New Size(140, 58)
                Barcode2.Visible = True
                Barcode2.Refresh()

                Dim gs1 As String = "3" + "84" + "33274" + Format(Etiqueta.Palet, "0000000") + Format(Etiqueta.Rodajas, "00")

                Barcode3.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.GS1_128
                Barcode3.Barcode.TranslateEscapeSequences = True
                Barcode3.Barcode.Data = "00" + gs1 + Gs1_Digito_Control(gs1)
                Barcode3.Refresh()
                Barcode3.Visible = True
            Catch ex As Exception
                Log("Error al generar Barcode SCA: " + ex.Message)
            End Try
        End If

        If Etiqueta.TipoEtiqueta = 4 Then ' Sonoco QR
            Dim Peso As String = Me.txNeto.Text

            Try
                If Etiqueta.TipoPeso = 1 Then Peso = Me.txBruto.Text
                Dim separador As String = Microsoft.VisualBasic.Constants.vbTab

                Barcode2.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.Code128
                Barcode2.Barcode.TranslateEscapeSequences = True
                Barcode2.Barcode.Data = Etiqueta.ReferenciaCruzada
                Barcode2.Size = New Size(140, 58)
                Barcode2.Visible = True
                Barcode2.Refresh()

                Barcode3.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.Code128
                Barcode3.Barcode.TranslateEscapeSequences = True
                Barcode3.Barcode.Data = "G740" + Etiqueta.Palet.ToString
                Barcode3.Size = New Size(172, 58)
                Barcode3.Visible = True
                Barcode3.Refresh()

                QrCode = $"G740{Etiqueta.Palet.ToString}{separador}RAW{separador}00.00{separador}{Etiqueta.ReferenciaCruzada}{separador}{separador}{Peso.ToString}{separador}"

                BarcodeQR.Image = GenerateQR(QrCode, 90, 90)
                BarcodeQR.Visible = True
                BarcodeQR.Refresh()
            Catch ex As Exception
                Log("Error al generar Barcode QR: " + ex.Message)
            End Try
        End If


        ' Etiqueta Sonoco Anterior
        If Etiqueta.TipoEtiqueta = 3333 Then
            Dim Peso As String = Me.txNeto.Text

            Try
                If Etiqueta.TipoPeso = 1 Then Peso = Me.txBruto.Text

                Barcode1.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.Code128
                Barcode1.Barcode.TranslateEscapeSequences = True
                Barcode1.Barcode.Data = Etiqueta.ReferenciaCruzada
                Barcode1.Size = New Size(172, 58)
                Barcode1.Refresh()

                Barcode1B.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.Code128
                Barcode1B.Barcode.TranslateEscapeSequences = True
                Barcode1B.Barcode.Data = Etiqueta.PesoNeto
                Barcode1B.Size = New Size(140, 58)
                Barcode1B.Visible = True
                Barcode1B.Refresh()

                Barcode2.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.EanUcc128
                Barcode2.Barcode.TranslateEscapeSequences = True
                Barcode2.Barcode.Data = "10" + Etiqueta.Palet.ToString
                Barcode2.Refresh()

                Dim gs1 As String = "3" + "84" + "33274" + Format(Etiqueta.Palet, "0000000") + Format(Etiqueta.Rodajas, "00")

                Barcode3.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.GS1_128
                Barcode3.Barcode.TranslateEscapeSequences = True
                Barcode3.Barcode.Data = "00" + gs1 + Gs1_Digito_Control(gs1)
                Barcode3.Refresh()


                Barcode2.Visible = True
                Barcode3.Visible = True
            Catch ex As Exception
                Log("Error al generar Barcode SCA: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Borrar()
        Me.txCliente.Text = ""
        Me.txCalidad.Text = ""
        Me.txFecha.Text = ""
        Me.txAncho.Text = ""
        Me.txRodajas.Text = ""
        Me.txBobina.Text = ""
        Me.txGramaje.Text = ""
        Me.txCalibre.Text = ""
        Me.txPalet.Text = ""
        Me.txBruto.Text = ""
        Me.txNeto.Text = ""
        Me.txObservaciones01.Text = ""
        Me.txObservaciones02.Text = ""
        Me.txOF.Text = ""
        Me.BarcodeLeiza.Visible = False
        Me.Barcode2.Visible = False
        Me.Barcode3.Visible = False
    End Sub

    Private Sub boSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub txPalet_TextChanged(sender As Object, e As EventArgs) Handles txPalet.TextChanged
        If Me.txPalet.Text = "" Then Exit Sub
        If Not IsNumeric(Me.txPalet.Text) Then
            MsgBox("El Palet debe de ser un número entero", vbAbort, "Validación Etiqueta")
            Me.txPalet.Text = ""
            Exit Sub
        End If
        Etiqueta.Palet = CLng(Me.txPalet.Text)
        generar_Barcode()
    End Sub

    Private Sub txRodajas_TextChanged(sender As Object, e As EventArgs) Handles txRodajas.TextChanged
        If Me.txRodajas.Text = "" Then Exit Sub
        If Not IsNumeric(Me.txRodajas.Text) Then
            MsgBox("El Palet debe de ser un número entero", vbAbort, "Validación Etiqueta")
            Me.txRodajas.Text = ""
            Exit Sub
        End If
        Etiqueta.Rodajas = CLng(Me.txRodajas.Text)
        generar_Barcode()
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs)
        Etiqueta.Terminar = (MsgBox("Desea Terminar la Orden", MsgBoxStyle.YesNo, "Impresión Etiquetas") = MsgBoxResult.Yes)

        If Not Diario_Salida() Then
            MsgBox("Se ha producido un error en la conexión con Navision, No se va a registrar la etiqueta " + vbCrLf +
                    " La etiqueta se ha de grabar de registrar en Navision con posterioridad")
        End If
        Imprimir_Etiqueta()
        Grabar_Etiqueta()
        Me.Close()
    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs)
        Imprimir_Etiqueta()
        Grabar_Etiqueta()
        Me.Close()
    End Sub

    Public Sub Imprimir_Etiqueta()
        Dim n As Byte
        Dim PaperSize As System.Drawing.Printing.PaperSize

        If Etiqueta.Copias > 0 Then
            generar_Barcode()
            For n = 1 To Etiqueta.Copias
                For Each PaperSize In PrintDoc.PrinterSettings.PaperSizes
                    If (PaperSize.PaperName = "A4") Then
                        PrintDoc.DefaultPageSettings.PaperSize = PaperSize
                        Exit For
                    End If
                Next

                PrintDoc.DefaultPageSettings.Landscape = True
                PrintDoc.DefaultPageSettings.Margins.Left = 0
                PrintDoc.DefaultPageSettings.Margins.Top = 0
                PrintDoc.Print()

                'If Etiqueta.Cliente = "931" Then Etiqueta.GenerarQR = True

                If Etiqueta.GenerarQR Then
                    PrintQR.PrinterSettings.PrinterName = Datos.ImpresoraQR
                    'PrintQR.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Etiqueta QR", 315, 131)
                    'PrintQR.DefaultPageSettings.Landscape = True
                    PrintQR.DefaultPageSettings.Margins.Left = 0
                    PrintQR.DefaultPageSettings.Margins.Top = 0
                    ' KKK PrintQR.Print()
                End If

                If Etiqueta.Pulper Then Imprimir_Etiqueta_Pulper()
            Next
        End If
    End Sub

    Public Sub Imprimir_Etiqueta_Pulper()
        PrintCZZ.PrinterSettings.PrinterName = Datos.ImpresoraQR
        PrintCZZ.PrinterSettings.Copies = 2
        PrintCZZ.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Etiqueta QR", 394, 591)
        PrintCZZ.DefaultPageSettings.Landscape = True
        PrintCZZ.DefaultPageSettings.Margins.Left = 0
        PrintCZZ.DefaultPageSettings.Margins.Top = 0
        PrintCZZ.DefaultPageSettings.Margins.Right = 0
        PrintCZZ.DefaultPageSettings.Margins.Bottom = 0
        PrintCZZ.Print()
    End Sub

    Public Sub Imprimir_Etiqueta_QR()
        generar_Barcode()

        PrintQR.PrinterSettings.PrinterName = Datos.ImpresoraQR
        'PrintQR.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Etiqueta QR", 315, 131)
        'PrintQR.DefaultPageSettings.Landscape = True
        PrintQR.DefaultPageSettings.Margins.Left = 0
        PrintQR.DefaultPageSettings.Margins.Top = 0
        PrintQR.Print()
    End Sub


    Private Sub txGramaje_TextChanged(sender As Object, e As EventArgs) Handles txGramaje.TextChanged
        If IsNumeric(txGramaje.Text) Then Etiqueta.Gramaje = CLng(txGramaje.Text)
        Calcular_Metros()
    End Sub

    Private Sub txCalibre_TextChanged(sender As Object, e As EventArgs) Handles txCalibre.TextChanged
        If IsNumeric(txCalibre.Text) Then Etiqueta.Calibre = CLng(txCalibre.Text)
    End Sub

    Private Sub txCliente_TextChanged(sender As Object, e As EventArgs) Handles txCliente.TextChanged
        Etiqueta.Cliente = txCliente.Text
    End Sub

    Private Sub txCalidad_TextChanged(sender As Object, e As EventArgs) Handles txCalidad.TextChanged
        Etiqueta.ReferenciaNombre = txCalidad.Text
    End Sub

    Private Sub txFecha_TextChanged(sender As Object, e As EventArgs) Handles txFecha.TextChanged
        If IsDate(txFecha.Text) Then Etiqueta.Fecha = CDate(txFecha.Text)
    End Sub

    Private Sub txObservaciones01_TextChanged(sender As Object, e As EventArgs) Handles txObservaciones01.TextChanged
        Etiqueta.ObsEtiqueta = txObservaciones01.Text
    End Sub

    Private Sub txAncho_TextChanged(sender As Object, e As EventArgs) Handles txAncho.TextChanged
        If Etiqueta.Manual Then
            Etiqueta.Ancho = 0
            If IsNumeric(txAncho.Text) Then Etiqueta.Ancho = CLng(txAncho.Text)
            Calcular_Metros()
        End If
    End Sub

    Private Sub TxNeto_TextChanged(sender As Object, e As EventArgs) Handles txNeto.TextChanged
        Etiqueta.PesoNeto = Me.txNeto.Text
        generar_Barcode()
    End Sub


    Private Function GenerateQR(qrCode As String, Ancho As Int32, Alto As Int32) As Image

        GenerateQR = Nothing

        Try
            Dim options As QrCodeEncodingOptions = New QrCodeEncodingOptions()


            options.DisableECI = True
            options.CharacterSet = "UTF-8"
            options.Width = Ancho
            options.Height = Alto

            Dim Writer As BarcodeWriter = New BarcodeWriter()
            Writer.Format = BarcodeFormat.QR_CODE
            Writer.Options = options

            GenerateQR = Writer.Write(qrCode)

        Catch ex As Exception
            Log($"Error Generate QR: {ex.Message}")
        End Try
    End Function

    Public Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim ftHelvetica75 As New System.Drawing.Font("Helvetica Bolt", 75)
        Dim ftHelvetica12 As New System.Drawing.Font("Helvetica Bolt", 12)
        Dim ftHelvetica14 As New System.Drawing.Font("Helvetica Bolt", 14)
        Dim ftHelvetica18 As New System.Drawing.Font("Helvetica Bolt", 18)
        Dim ftHelvetica55 As New System.Drawing.Font("Helvetica Bolt", 55)
        Dim ftHelvetica72 As New System.Drawing.Font("Helvetica Bolt", 72)
        Dim ftHelvetica64 As New System.Drawing.Font("Helvetica Bolt", 64)
        Dim Pt As New System.Drawing.Point

        e.Graphics.PageUnit = GraphicsUnit.Millimeter

        Pt.X = 0
        Pt.Y = 55

        Dim Nombre As String = Etiqueta.ReferenciaNombre
        If Nombre = "" Then Nombre = Etiqueta.ReferenciaTranslation
        e.Graphics.DrawString(Nombre, ftHelvetica75, Brushes.Black, Pt)

        Pt.X = 250
        Pt.Y = 55
        e.Graphics.DrawString(Format(Etiqueta.Fecha, "dd-MM-yyyy"), ftHelvetica14, Brushes.Black, Pt)

        Pt.X = 250
        Pt.Y = 58
        e.Graphics.DrawString(Etiqueta.Cliente, ftHelvetica55, Brushes.Black, Pt)

        Pt.X = 225
        Pt.Y = 77
        e.Graphics.DrawString("FSC: SGSCH-COC-009649", ftHelvetica14, Brushes.Black, Pt)

        Pt.X = 0
        Pt.Y = 92
        If (Etiqueta.Ancho < 999) And (Etiqueta.Ancho Mod 2 = 0) Then
            e.Graphics.DrawString(FormatoAncho(Etiqueta.Ancho) + "/" + Etiqueta.Rodajas.ToString("00"), ftHelvetica72, Brushes.Black, Pt)
        Else
            e.Graphics.DrawString(FormatoAncho(Etiqueta.Ancho) + "/" + Etiqueta.Rodajas.ToString("00"), ftHelvetica64, Brushes.Black, Pt)
        End If


        If Etiqueta.MostrarGramaje Then
            Pt.X = 120
            Pt.Y = 92
            e.Graphics.DrawString(Etiqueta.Gramaje.ToString("#####"), ftHelvetica72, Brushes.Black, Pt)
        End If

        If Etiqueta.MostrarCalibre Then
            Pt.X = 205
            Pt.Y = 92
            e.Graphics.DrawString(Etiqueta.Calibre.ToString("#####"), ftHelvetica72, Brushes.Black, Pt)
        End If

        Pt.X = 0
        Pt.Y = 128
        e.Graphics.DrawString(Etiqueta.Palet.ToString("######"), ftHelvetica72, Brushes.Black, Pt)

        Pt.X = 70
        Pt.Y = 153
        e.Graphics.DrawString(Etiqueta.Bobina.ToString("######"), ftHelvetica18, Brushes.Black, Pt)

        Pt.X = 125
        Pt.Y = 128
        e.Graphics.DrawString(Etiqueta.PesoBruto.ToString, ftHelvetica72, Brushes.Black, Pt)

        Pt.X = 210
        Pt.Y = 128
        e.Graphics.DrawString(Etiqueta.PesoNeto.ToString, ftHelvetica72, Brushes.Black, Pt)

        Pt.X = 5
        Pt.Y = 165

        If Etiqueta.TipoEtiqueta = 0 Or Etiqueta.TipoEtiqueta = 1 Then
            Dim bar = New BarcodeLib.Barcode
            bar.IncludeLabel = True
            e.Graphics.DrawImage(bar.Encode(BarcodeLib.TYPE.CODE128B, Etiqueta.Barcode, 324, 72), Pt.X, Pt.Y, 130, 30)
        End If

        If Etiqueta.TipoEtiqueta <> 4 Then
            Pt.X = 140
            Pt.Y = 165
            e.Graphics.DrawString(Etiqueta.ObsEtiqueta, ftHelvetica14, Brushes.Black, Pt)
        End If

        If Etiqueta.TipoEtiqueta = 0 Then
            Pt.X = 140
            Pt.Y = 175
            e.Graphics.DrawString(Etiqueta.PedidoCliente + "/" + Etiqueta.ReferenciaCruzada, ftHelvetica14, Brushes.Black, Pt)
        End If

        If Etiqueta.TipoEtiqueta <> 4 Then
            Pt.X = 140
            Pt.Y = 185

            If Etiqueta.TipoEtiqueta = 1 Then Pt.Y = 170

            e.Graphics.DrawString(Etiqueta.OP, ftHelvetica18, Brushes.Black, Pt)

        End If

        If Etiqueta.PedirMetrosPalet Then
            Pt.X = 180
            Pt.Y = 185
            e.Graphics.DrawString("Meters: " + Etiqueta.MetrosPalet.ToString, ftHelvetica18, Brushes.Black, Pt)
        End If

        If Not Etiqueta.PedirMetrosPalet And Etiqueta.PedirMetrosRodaja Then
            Pt.X = 180
            Pt.Y = 185
            e.Graphics.DrawString("Meters: " + Etiqueta.MetrosRodaja.ToString, ftHelvetica18, Brushes.Black, Pt)
        End If

        ' Etiqueta Leiza
        If Etiqueta.TipoEtiqueta = 1 Then
            Dim bar2 = New BarcodeLib.Barcode
            bar2.IncludeLabel = True

            Pt.X = 170
            Pt.Y = 180
            Try
                e.Graphics.DrawImage(bar2.Encode(BarcodeLib.TYPE.CODE128B, Etiqueta.BarcodeLeiza, 324, 72), Pt.X, Pt.Y, 110, 17)
            Catch ex As Exception
                Log("Error Imagen Leiza, Etiqueta Leiza:" + Etiqueta.BarcodeLeiza + " Error: " + ex.Message)
            End Try
        End If

        ' Etiqueta Essity
        If Etiqueta.TipoEtiqueta = 2 Then
            Pt.X = 140
            Pt.Y = 170
            e.Graphics.DrawString("OP: " + Etiqueta.OP.ToString, ftHelvetica14, Brushes.Black, Pt)
            Pt.X = 200
            Pt.Y = 170
            e.Graphics.DrawString("Pedido Cliente: " + Etiqueta.PedidoCliente, ftHelvetica14, Brushes.Black, Pt)

            Barcode1.Barcode.BoundingRectangle = New Rectangle(200, 4000, 2600, 600)
            Barcode1.Barcode.Draw(e.Graphics)

            Barcode2.Barcode.BoundingRectangle = New Rectangle(3200, 4150, 1100, 350)
            Barcode2.Barcode.Draw(e.Graphics)

            Barcode3.Barcode.BoundingRectangle = New Rectangle(4500, 4150, 2100, 350)
            Barcode3.Barcode.Draw(e.Graphics)
        End If

        ' Etiqueta Sonoco
        If Etiqueta.TipoEtiqueta = 3 Then
            Pt.X = 140
            Pt.Y = 170
            e.Graphics.DrawString("OP: " + Etiqueta.OP.ToString, ftHelvetica14, Brushes.Black, Pt)

            Pt.X = 200
            Pt.Y = 170
            e.Graphics.DrawString("Pedido Cliente: " + Etiqueta.PedidoCliente, ftHelvetica14, Brushes.Black, Pt)

            Pt.X = 20
            Pt.Y = 170
            e.Graphics.DrawString("Palet", New System.Drawing.Font("Helvetica Bolt", 12), Brushes.Black, Pt)

            Pt.X = 80
            Pt.Y = 170
            e.Graphics.DrawString("Peso Neto", New System.Drawing.Font("Helvetica Bolt", 12), Brushes.Black, Pt)

            Barcode1.Barcode.BoundingRectangle = New Rectangle(200, 4150, 1500, 350)
            Barcode1.Barcode.Draw(e.Graphics)

            Barcode1B.Barcode.BoundingRectangle = New Rectangle(1900, 4150, 700, 350)
            Barcode1B.Barcode.Draw(e.Graphics)

            Barcode2.Barcode.BoundingRectangle = New Rectangle(3200, 4150, 1100, 350)
            Barcode2.Barcode.Draw(e.Graphics)

            Barcode3.Barcode.BoundingRectangle = New Rectangle(4500, 4150, 2100, 350)
            Barcode3.Barcode.Draw(e.Graphics)
        End If

        ' Etiqueta Sonoco
        If Etiqueta.TipoEtiqueta = 4 Then
            Barcode3.Barcode.BoundingRectangle = New Rectangle(200, 4150, 2000, 350)
            Barcode3.Barcode.Draw(e.Graphics)

            Pt.X = 120 '230
            Pt.Y = 160
            e.Graphics.DrawImage(GenerateQR(QrCode, 140, 140), Pt)

            Barcode2.Barcode.BoundingRectangle = New Rectangle(4500, 4150, 2000, 350)
            Barcode2.Barcode.Draw(e.Graphics)
        End If

        e.HasMorePages = False
    End Sub

    Public Sub PrintQR_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintQR.PrintPage
        Dim Pt As New System.Drawing.Point
        Dim ftHelvetica18 As New System.Drawing.Font("Helvetica Bolt", 18)
        Dim QrSize As Integer = 180

        e.Graphics.PageUnit = GraphicsUnit.Millimeter

        Pt.X = 0
        Pt.Y = 5
        e.Graphics.DrawImage(GenerateQR(QrCode, QrSize, QrSize), Pt)

        Pt.X = 49
        e.Graphics.DrawImage(GenerateQR(QrCode, QrSize, QrSize), Pt)

        Pt.X = 3
        Pt.Y = 0
        e.Graphics.DrawString("G740" + Etiqueta.Palet.ToString, ftHelvetica18, Brushes.Black, Pt)
        Pt.X = 53
        e.Graphics.DrawString("G740" + Etiqueta.Palet.ToString, ftHelvetica18, Brushes.Black, Pt)

        e.HasMorePages = False
    End Sub

    Private Sub PrintCZZ_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintCZZ.PrintPage
        Dim Pt As New System.Drawing.Point
        Dim ftHelvetica18 As New System.Drawing.Font("Helvetica Bolt", 18)
        Dim ftHelvetica55 As New System.Drawing.Font("Helvetica Bolt", 55)
        Dim ftHelvetica65 As New System.Drawing.Font("Helvetica Bolt", 65)
        Dim ftHelvetica25 As New System.Drawing.Font("Helvetica Bolt", 25)
        Dim QrSize As Integer = 180

        e.Graphics.PageUnit = GraphicsUnit.Millimeter

        Pt.X = 2
        Pt.Y = 5

        e.Graphics.DrawString("STOCKS LOTS", ftHelvetica55, Brushes.Black, Pt)

        Pt.X = 2
        Pt.Y = 30

        e.Graphics.DrawString($"{Etiqueta.Bobina.ToString}-{Etiqueta.Palet.ToString}", ftHelvetica65, Brushes.Black, Pt)

        Pt.X = 2
        Pt.Y = 60
        e.Graphics.DrawString($"{Etiqueta.PesoNeto} KG", ftHelvetica65, Brushes.Black, Pt)

        Pt.Y = 87
        e.Graphics.DrawString($"{Funciones.Valor_OP(Etiqueta.OP).ToString}  {Etiqueta.CZZ_Ancho} mm/<300-430>   {Format(Now, "MM-yy")}", ftHelvetica25, Brushes.Black, Pt)

        e.HasMorePages = False
    End Sub


End Class
