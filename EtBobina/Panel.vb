Option Explicit On
Public Class Panel
    Public Contador As Byte
    Private Sub Etiqueta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFondo()
        Me.MODOToolStrip.Text = ""

        If Datos.ModoTest Then Me.MODOToolStrip.Text = " **** TEST ****  "
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Status_Quo(0)
    End Sub

    Private Sub Status_Quo(Estado As Byte)
        Dim punto As New Point
        Dim punto2 As New Point

        punto.X = Me.Location.X + Me.Size.Width
        punto.Y = Me.Location.Y

        Select Case Estado
            Case 0 ' Estado Inicial
                Lienzo.Dispose()
                Me.turnoA.Checked = False
                Me.turnoB.Checked = False
                Me.turnoC.Checked = False
                Me.turnoD.Checked = False
                Me.turnoE.Checked = False
                Me.Hora1.Checked = False
                Me.Hora2.Checked = False
                Me.Hora3.Checked = False
                Me.grHora.Visible = True
                Me.grHora.Enabled = True
                Me.grTurno.Visible = True
                Me.grTurno.Enabled = True
                Me.GrFecha.Visible = False
                Me.GrFecha.Enabled = False
                Me.grCopias.Visible = False
                Me.grEtPalet.Visible = False
                Me.grOpciones.Visible = False
                Me.grBobina.Visible = False
                Me.grDatos.Visible = False
                Me.grOF.Visible = False
                Me.grRepetir.Visible = False
                Me.Salir.Visible = True
                Me.txEtiqPalet.Text = "1"
                Me.txMetrosPalet.Text = ""
                Contador = 1

                Dim sz As Size

                sz.Height = 514
                Lienzo.Size = sz

                ListaOP.Show()
                punto2.X = Me.Location.X + Me.Size.Width + 5
                punto2.Y = Me.Location.Y + Lienzo.Size.Height + 10
                ListaOP.Location = punto2
                ListaOP.Visible = False

                ListaVerde.Show()
                punto2.X = Me.Location.X + Me.Size.Width + 5
                punto2.Y = Me.Location.Y + 10
                ListaVerde.Location = punto2
                ListaVerde.Visible = False
                Timer1.Stop()

            Case 1 ' Introducir OF
                Lienzo.Dispose()
                Limpiar_Etiqueta()
                cargar_Horario()
                If Datos.FechaTrabajo.Year = 2003 Then Datos.FechaTrabajo = Fecha_Trabajo(Etiqueta.Turno, Etiqueta.Horario)
                Me.txFechaTrabajo.Text = Format(Datos.FechaTrabajo, "dd-MM")
                Me.grHora.Visible = True
                Me.grHora.Enabled = False
                Me.grTurno.Visible = True
                Me.grTurno.Enabled = False
                Me.GrFecha.Visible = True
                Me.GrFecha.Enabled = True
                Me.grOpciones.Visible = False
                Me.grBobina.Visible = False
                Me.grCopias.Visible = True
                Me.grEtPalet.Visible = True
                Me.EtMas.Visible = True
                Me.etMenos.Visible = True
                'Me.txEtiqPalet.Text = "1"
                Me.txNoCopias.Text = "1"
                Me.grOF.Visible = True
                Me.grOF.Enabled = True
                Me.grRepetir.Visible = True
                Me.grDatos.Visible = False
                Me.Salir.Visible = True

                Me.txOF.Text = ""
                Me.txOF.Select()
                Me.OK.Visible = True
                Me.Manual.Visible = True
                Me.AcceptButton = Me.OK
                Me.txRodajas.Text = ""
                Me.txPesoNeto.Text = ""
                Me.txMetrosRodaja.Text = ""
                Me.txMetrosPalet.Text = ""

                Me.OK.Visible = True
                Me.Manual.Visible = True
                Me.AcceptButton = Me.OK

                Me.grDatos.Visible = False
                Me.Salir.Visible = True

                Me.txOF.Text = ""
                Me.txOF.Select()

                Mostrar_OFS()
                Contador = 0

                ListaOP.Visible = True
                ListaOP.Mostrar_Lista_OP()

                If Screen.AllScreens.Count > 1 Then
                    Timer1.Interval = 90000 ' 1 Minuto
                    Timer1.Start()

                    ListaVerde.Visible = True
                    ListaVerde.Mostrar_Lista_Verde()
                End If


            Case 2 ' Introducir Datos
                Lienzo.Location = punto
                Lienzo.Show()
                ListaOP.Visible = True
                ListaOP.Mostrar_Lista_OP()

                If Screen.AllScreens.Count > 1 Then
                    ListaVerde.Visible = True
                    ListaVerde.Mostrar_Lista_Verde()
                End If


                Me.grHora.Visible = True
                Me.grHora.Enabled = False
                Me.grTurno.Visible = True
                Me.grTurno.Enabled = False
                Me.GrFecha.Visible = True
                Me.GrFecha.Enabled = False
                Me.grOpciones.Visible = True
                Me.grBobina.Visible = True
                Me.grCopias.Visible = True
                Me.grEtPalet.Visible = True
                Me.EtMas.Visible = False
                Me.etMenos.Visible = False
                Me.grOF.Enabled = False
                Me.grRepetir.Visible = True
                Me.grRepetir.Enabled = True
                Me.OK.Visible = False

                Me.Manual.Visible = False
                Me.grDatos.Visible = True
                Me.Salir.Visible = False
                Me.AcceptButton = Me.DatosOK

                If Datos.ActualizarPalet Then
                    Me.txPalet.ForeColor = Me.txPesoPalet.ForeColor
                Else
                    Me.txPalet.ForeColor = Color.Red
                End If

                Me.Select()
                Me.txRodajas.Text = ""
                Me.txPesoPalet.Text = ""
                Me.txPesoNeto.Text = ""
                Me.txMetrosRodaja.Text = ""
                Me.txPalet.Text = ""
                Me.txBobina.Text = ""
                Me.txMetrosRodaja.Enabled = Etiqueta.PedirMetrosRodaja
                Me.chkTerminar.Checked = False

                Me.txPesoPalet.Text = Etiqueta.PesoPalet.ToString
                Me.txPalet.Text = Etiqueta.Palet.ToString
                Me.txBobina.Text = Etiqueta.Bobina.ToString

                If Etiqueta.Rodajas <> 0 Then Me.txRodajas.Text = Etiqueta.Rodajas.ToString("00")
                If Etiqueta.PesoNeto <> 0 Then Me.txPesoNeto.Text = Etiqueta.PesoNeto.ToString
                If Etiqueta.MetrosRodaja <> 0 Then Me.txMetrosRodaja.Text = Etiqueta.MetrosRodaja.ToString
                If Etiqueta.MetrosPalet <> 0 Then Me.txMetrosPalet.Text = Etiqueta.MetrosPalet.ToString
                Me.chCalibre.Checked = Etiqueta.MostrarCalibre
                Me.ChGramaje.Checked = Etiqueta.MostrarGramaje

                Me.Actualizar_Lienzo()

                Me.chkTerminar.Visible = True
                If ((Etiqueta.EtiquetasPorPalet > 1) And (Contador < Etiqueta.EtiquetasPorPalet)) Then Me.chkTerminar.Visible = False
                Me.txParcial.Text = Format(Contador, "0") + "/" + Etiqueta.EtiquetasPorPalet.ToString

                Me.txPesoNeto.Select()

                Timer1.Interval = 60000 ' 1 Minuto
                Timer1.Start()
        End Select
        Me.Refresh()
    End Sub

    Private Sub Actualizar_Lienzo()
        If Etiqueta.ReferenciaTranslation <> "" Then
            Lienzo.txCalidad.Text = Etiqueta.ReferenciaTranslation.ToString
        Else
            Lienzo.txCalidad.Text = Etiqueta.ReferenciaNombre
        End If

        Lienzo.txGramaje.Visible = Etiqueta.MostrarGramaje
        Lienzo.txCalibre.Visible = Etiqueta.MostrarCalibre

        Lienzo.txCliente.Text = Etiqueta.Cliente
        Lienzo.txFecha.Text = Format(Datos.FechaTrabajo, "dd/MM/yyyy")
        Lienzo.txAncho.Text = FORmatoAncho(Etiqueta.Ancho)
        Lienzo.txRodajas.Text = Etiqueta.Rodajas.ToString("00")
        Lienzo.txGramaje.Text = Etiqueta.Gramaje.ToString
        Lienzo.txCalibre.Text = Etiqueta.Calibre.ToString
        Lienzo.txPalet.Text = Etiqueta.Palet.ToString
        Lienzo.txBobina.Text = Etiqueta.Bobina.ToString
        Lienzo.txBruto.Text = Etiqueta.PesoBruto.ToString
        Lienzo.txNeto.Text = Etiqueta.PesoNeto.ToString
        Lienzo.txOF.Text = Etiqueta.OP.ToString
        If Etiqueta.ObsEtiqueta <> Nothing Then
            Lienzo.txObservaciones01.Text = Etiqueta.ObsEtiqueta.ToString
        End If

        Lienzo.txObservaciones02.Text = Etiqueta.PedidoCliente.ToString + "/" + Etiqueta.ReferenciaCruzada.ToString

        Lienzo.txMostrarMetros.Visible = False

        If Etiqueta.PedirMetrosPalet Then
            Lienzo.txMostrarMetros.Text = "Meters: " + Etiqueta.MetrosPalet.ToString
            Lienzo.txMostrarMetros.Visible = True
        End If

        If Not Etiqueta.PedirMetrosPalet And Etiqueta.PedirMetrosRodaja Then
            Lienzo.txMostrarMetros.Text = "Meters: " + Etiqueta.MetrosRodaja.ToString
            Lienzo.txMostrarMetros.Visible = True
        End If

        If Etiqueta.Pulper Then
            Lienzo.txAncho.Text = Etiqueta.CZZ_Ancho
            Lienzo.txRodajas.Text = Etiqueta.CZZ_Rodajas
        End If
    End Sub

    Private Sub turnoA_CheckedChanged(sender As Object, e As EventArgs) Handles turnoA.CheckedChanged
        Validar_Horario()
    End Sub


    Private Sub turnoB_CheckedChanged(sender As Object, e As EventArgs) Handles turnoB.CheckedChanged
        Validar_Horario()
    End Sub

    Private Sub turnoC_CheckedChanged(sender As Object, e As EventArgs) Handles turnoC.CheckedChanged
        Validar_Horario()
    End Sub

    Private Sub turnoD_CheckedChanged(sender As Object, e As EventArgs) Handles turnoD.CheckedChanged
        Validar_Horario()
    End Sub

    Private Sub turnoE_CheckedChanged(sender As Object, e As EventArgs) Handles turnoE.CheckedChanged
        Validar_Horario()
    End Sub

    Private Sub Hora1_CheckedChanged(sender As Object, e As EventArgs) Handles Hora1.CheckedChanged
        Validar_Horario()
    End Sub

    Private Sub Hora2_CheckedChanged(sender As Object, e As EventArgs) Handles Hora2.CheckedChanged
        Validar_Horario()
    End Sub

    Private Sub Hora3_CheckedChanged(sender As Object, e As EventArgs) Handles Hora3.CheckedChanged
        Validar_Horario()
    End Sub

    Private Sub Validar_Horario()
        If (Me.turnoA.Checked Or Me.turnoB.Checked Or Me.turnoC.Checked Or
           Me.turnoD.Checked Or Me.turnoE.Checked) And
           (Me.Hora1.Checked Or Me.Hora2.Checked Or Me.Hora3.Checked) Then

            Status_Quo(1)
        End If
    End Sub
    Private Sub cargar_Horario()
        If Me.turnoA.Checked Then Etiqueta.Turno = "A"
        If Me.turnoB.Checked Then Etiqueta.Turno = "B"
        If Me.turnoC.Checked Then Etiqueta.Turno = "C"
        If Me.turnoD.Checked Then Etiqueta.Turno = "D"
        If Me.turnoE.Checked Then Etiqueta.Turno = "E"

        If Me.Hora1.Checked Then Etiqueta.Horario = "1"
        If Me.Hora2.Checked Then Etiqueta.Horario = "2"
        If Me.Hora3.Checked Then Etiqueta.Horario = "3"
    End Sub

    Private Sub Mostrar_OFS()
        Me.OF_1.Visible = False
        Me.OF_2.Visible = False
        Me.OF_3.Visible = False
        Me.OF_4.Visible = False
        Me.OF_5.Visible = False
        Me.OF_6.Visible = False

        If IsNothing(Historial) Then Exit Sub

        Dim n As Byte
        n = 0
        If Historial.Length > 6 Then n = Historial.Length - 6

        If Historial.Length >= 1 Then
            Me.OF_1.Text = Historial(n).OP.ToString + "-" + Historial(n).Rodajas.ToString("00") + "-" + Historial(n).EtiquetasPorPalet.ToString("00")
            Me.OF_1.Visible = True
        End If
        If Historial.Length >= 2 Then
            n += 1
            Me.OF_2.Text = Historial(n).OP.ToString + "-" + Historial(n).Rodajas.ToString("00") + "-" + Historial(n).EtiquetasPorPalet.ToString("00")
            Me.OF_2.Visible = True
        End If
        If Historial.Length >= 3 Then
            n += 1
            Me.OF_3.Text = Historial(n).OP.ToString + "-" + Historial(n).Rodajas.ToString("00") + "-" + Historial(n).EtiquetasPorPalet.ToString("00")
            Me.OF_3.Visible = True
        End If
        If Historial.Length >= 4 Then
            n += 1
            Me.OF_4.Text = Historial(n).OP.ToString + "-" + Historial(n).Rodajas.ToString("00") + "-" + Historial(n).EtiquetasPorPalet.ToString("00")
            Me.OF_4.Visible = True
        End If
        If Historial.Length >= 5 Then
            n += 1
            Me.OF_5.Text = Historial(n).OP.ToString + "-" + Historial(n).Rodajas.ToString("00") + "-" + Historial(n).EtiquetasPorPalet.ToString("00")
            Me.OF_5.Visible = True
        End If
        If Historial.Length >= 6 Then
            n += 1
            Me.OF_6.Text = Historial(n).OP.ToString + "-" + Historial(n).Rodajas.ToString("00") + "-" + Historial(n).EtiquetasPorPalet.ToString("00")
            Me.OF_6.Visible = True
        End If

    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Bye
    End Sub

    Private Sub Bye()
        Me.Close()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Aceptar_OP()
    End Sub

    Private Sub Aceptar_OP()
        Dim Incremento As Byte

        Me.txOF.Text = Componer_OF(Me.txOF.Text)

        Limpiar_Etiqueta()
        If Not IsNumeric(Me.txEtiqPalet.Text) Then
            MsgBox("Error, No se han definidio Etiquetas por Palet", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Not IsNumeric(Me.txNoCopias.Text) Then
            MsgBox("Error, No se han definidio Nº de Copias por Palet", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Etiqueta.EtiquetasPorPalet = CInt(Me.txEtiqPalet.Text)
        Etiqueta.Copias = CInt(Me.txNoCopias.Text)

        Contador += 1
        If Contador > Etiqueta.EtiquetasPorPalet Then Contador = 1

        Incremento = 1
        If Etiqueta.EtiquetasPorPalet > 1 And Contador > 1 Then Incremento = 0

        If Datos_OF(Me.txOF.Text, Incremento, True) Then
            Etiqueta.Manual = False
            Status_Quo(2)
        End If
    End Sub

    Private Function Datos_OF(OrderNo As String, Incremento As Byte, SoloAbiertas As Boolean) As Boolean
        Dim status As String

        Datos_OF = True

        status = FuncionesDatos.Extraer_Datos(OrderNo, Incremento, SoloAbiertas)

        If status = "ERROR" Then
            MsgBox("No Se puede acceder a los datos, solamente se pueden hacer etiquetas manuales", MsgBoxStyle.Critical, "Etiquetaje")
            Datos_OF = False
        End If
        If status = "NO EXISTE" Then
            MsgBox("No Existe a Orden " + Me.txOF.Text, MsgBoxStyle.Critical, "Etiquetaje")
            Datos_OF = False
        End If

        If SoloAbiertas And (status = "OP TERMINADA") Then
            MsgBox("La OP " + Me.txOF.Text + "  Está Terminada", MsgBoxStyle.Exclamation)
            Datos_OF = False
        End If

        If status = "NO QCS" Then
            MsgBox("La OP " + Me.txOF.Text + "  NO está dada de alta, avisar al maquinista", MsgBoxStyle.Exclamation)
            Datos_OF = False
        End If
    End Function

    Private Function Componer_OF(texto As String) As String
        Dim no As Long

        Componer_OF = ""

        If texto.Length > 0 And Not IsNumeric(texto) Then
            Dim n As Byte
            Dim texto2 As String = ""

            For n = 0 To texto.Length - 1
                If IsNumeric(texto.Substring(n, 1)) Then texto2 += texto.Substring(n, 1)
            Next
            texto = texto2
        End If

        If IsNumeric(texto) Then
            no = CLng(texto)
            Componer_OF = "OF" + Format(no, "000000")
        End If
    End Function

    Private Sub DatosSalir_Click_(sender As Object, e As EventArgs) Handles DatosSalir.Click
        Status_Quo(1)
    End Sub


    Private Sub DatosOK_Click(sender As Object, e As EventArgs) Handles DatosOK.Click
        Dim NoOrden As String
        Dim Peso As Integer
        Dim NoRodajas As Integer
        Dim NoEtiquetas As Integer
        Dim NoCopias As Integer
        Dim NoContador As Integer
        Dim NoPalet As Integer
        Dim NoBobina As Integer

        Timer1.Stop()

        NoPalet = Etiqueta.Palet
        NoBobina = Etiqueta.Bobina
        NoOrden = Etiqueta.OP
        NoRodajas = Etiqueta.Rodajas
        Peso = Etiqueta.PesoNeto
        NoEtiquetas = Etiqueta.EtiquetasPorPalet

        NoContador = Contador

        If Not Validar_Datos() Then
            Timer1.Start()
            Exit Sub
        End If

        NoCopias = Etiqueta.Copias

        If WebServices.Existe_Palet(Etiqueta.Palet) Then
            If MsgBox("Ya Existe el Número de Palet Seleccionado (" + Etiqueta.Palet.ToString + ")." + vbCrLf + " ¿Desea Continuar?", vbYesNo, " Verificar Nº de Palet") = vbNo Then
                Timer1.Start()
                Exit Sub
            End If
        End If

        If WebServices.Plan_Verificacion_Ask(Etiqueta.Cliente) Then
            Dim respuesta As String

            Etiqueta.PlanVerifcaAlta = True
            Plan.ShowDialog()
            respuesta = Plan.Tag
            Plan.Dispose()
            If respuesta <> "OK" Then
                Timer1.Start()
                Exit Sub
            End If
        End If

        If Not Diario_Salida() Then
            MsgBox("Se ha producido un error en la conexión con Navision, No se va a registrar la etiqueta " + vbCrLf +
                    " La etiqueta se ha de grabar de registrar en Navision con posterioridad")
        End If


        If Etiqueta.Copias > 0 Then
            Actualizar_Lienzo()
            If Etiqueta.Pulper Then
                Etiqueta.Ancho = Etiqueta.CZZ_Ancho
                Etiqueta.Rodajas = Etiqueta.CZZ_Rodajas
                Etiqueta.ReferenciaNombre = Datos.CZZ_Nombre
            End If
            Lienzo.Imprimir_Etiqueta()
            Grabar_Etiqueta()
            Lienzo.Close()
        End If

        Status_Quo(1)

        If NoEtiquetas > 1 And NoContador >= NoEtiquetas Then Exit Sub

        Contador = NoContador

        If Not Etiqueta.Terminar Then
            Me.txEtiqPalet.Text = NoEtiquetas.ToString
            Me.txOF.Text = NoOrden
            Aceptar_OP()

            Me.txRodajas.Text = NoRodajas.ToString
            Me.txPesoNeto.Text = Peso.ToString
            Me.txPesoNeto.Select()
        End If

        If Not Datos.ActualizarPalet Then
            Me.txPalet.Text = (NoPalet + 1).ToString
        End If

        Me.txBobina.Text = NoBobina.ToString
        Me.txNoCopias.Text = NoCopias.ToString
    End Sub

    Private Function Validar_Datos() As Boolean
        Validar_Datos = True

        If Me.txPesoPalet.Text = "" Then Me.txPesoPalet.Text = "0"

        If Not IsNumeric(Me.txBobina.Text) Then
            MsgBox("No se ha introducido Nº de Bobina", MsgBoxStyle.Critical, "Etiquetas")
            Me.txBobina.SelectAll()
            Me.txBobina.Select()
            Validar_Datos = False
            Exit Function
        End If

        If Not WebServices.Verificar_No_Bobina(txOF.Text, CLng(Me.txBobina.Text)) Then
            MsgBox("El Nº de Bobina introducido no corresponde con esa Orden de Producción", MsgBoxStyle.Critical, "Etiquetas")
            Me.txBobina.SelectAll()
            Me.txBobina.Select()
            Validar_Datos = False
            Exit Function
        End If

        If Not IsNumeric(Me.txPalet.Text) Then
            Me.txPalet.SelectAll()
            Me.txPalet.Select()
            Validar_Datos = False
            Exit Function
        End If
        If Not IsNumeric(Me.txPesoPalet.Text) Then
            Me.txPesoPalet.SelectAll()
            Me.txPesoPalet.Select()
            Validar_Datos = False
            Exit Function
        End If
        If Not IsNumeric(Me.txRodajas.Text) Then
            Me.txRodajas.SelectAll()
            Me.txRodajas.Select()
            Validar_Datos = False
            Exit Function
        End If
        If Not IsNumeric(Me.txPesoNeto.Text) Then
            Me.txPesoNeto.SelectAll()
            Me.txPesoNeto.Select()
            Validar_Datos = False
            Exit Function
        End If

        If Etiqueta.PedirMetrosRodaja And Not IsNumeric(Me.txMetrosRodaja.Text) Then
            Me.txMetrosRodaja.SelectAll()
            Me.txMetrosRodaja.Select()
            Validar_Datos = False
            Exit Function
        End If

        If Not WebServices.Verificar_Peso_Bobina(txOF.Text, CLng(Me.txBobina.Text), CInt(Me.txPesoNeto.Text)) Then
            MsgBox("El Peso Excede la cantidad de la orden de Producción", MsgBoxStyle.Critical, "Etiquetas")
            Me.txBobina.SelectAll()
            Me.txBobina.Select()
            Validar_Datos = False
            Exit Function
        End If


        If Validar_Datos Then
            If IsNumeric(Me.txBobina.Text) Then Etiqueta.Bobina = CLng(Me.txBobina.Text)
            If IsNumeric(Me.txPalet.Text) Then Etiqueta.Palet = CLng(txPalet.Text)
            If IsNumeric(Me.txPesoNeto.Text) Then Etiqueta.PesoNeto = CLng(txPesoNeto.Text)
            If IsNumeric(Me.txRodajas.Text) Then Etiqueta.Rodajas = CLng(txRodajas.Text)
            If IsNumeric(Me.txPesoPalet.Text) Then Etiqueta.PesoPalet = CLng(txPesoPalet.Text)
            If IsNumeric(Me.txMetrosRodaja.Text) Then Etiqueta.MetrosRodaja = CLng(txMetrosRodaja.Text)

            Etiqueta.Terminar = Me.chkTerminar.Checked
            Etiqueta.EtiquetasPorPalet = CInt(Me.txEtiqPalet.Text)
            Etiqueta.Copias = CInt(Me.txNoCopias.Text)
            Etiqueta.PesoBruto = Etiqueta.PesoNeto + Etiqueta.PesoPalet

            If Etiqueta.PedirMetrosRodaja Then
                If Etiqueta.MetrosRodaja < (Etiqueta.MetrosPalet / Etiqueta.Rodajas) * 0.8 Or Etiqueta.MetrosRodaja > (Etiqueta.MetrosPalet / Etiqueta.Rodajas) * 1.2 Then
                    MsgBox("La cantidad de Metros esta fuera del intervalo de tolerancia", MsgBoxStyle.Critical, "Validación datos etiqueta")
                    Me.txMetrosRodaja.SelectAll()
                    Me.txMetrosRodaja.Select()
                    Validar_Datos = False
                    Exit Function
                End If
            End If

            Me.Actualizar_Lienzo()
        End If
    End Function

    Private Sub Panel2Lienzo()
        If IsNumeric(Me.txPalet.Text) Then Etiqueta.Palet = CLng(txPalet.Text)
        If IsNumeric(Me.txBobina.Text) Then Etiqueta.Bobina = CLng(txBobina.Text)
        If IsNumeric(Me.txPesoNeto.Text) Then Etiqueta.PesoNeto = CLng(txPesoNeto.Text)
        If IsNumeric(Me.txRodajas.Text) Then Etiqueta.Rodajas = CLng(txRodajas.Text)
        If IsNumeric(Me.txPesoPalet.Text) Then Etiqueta.PesoPalet = CLng(txPesoPalet.Text)
        If IsNumeric(Me.txMetrosRodaja.Text) Then Etiqueta.MetrosRodaja = CLng(txMetrosRodaja.Text)

        Etiqueta.Terminar = Me.chkTerminar.Checked
        Etiqueta.EtiquetasPorPalet = CInt(Me.txEtiqPalet.Text)
        Etiqueta.Copias = CInt(Me.txNoCopias.Text)
        Etiqueta.PesoBruto = Etiqueta.PesoNeto + Etiqueta.PesoPalet
        Me.Actualizar_Lienzo()
    End Sub

    Private Sub OF_1_Click(sender As Object, e As EventArgs) Handles OF_1.Click
        Cargar_Datos_Etiqueta(0)
        Etiqueta.Manual = False
        Status_Quo(2)
    End Sub

    Private Sub OF_2_Click(sender As Object, e As EventArgs) Handles OF_2.Click
        Cargar_Datos_Etiqueta(1)
        Etiqueta.Manual = False
        Status_Quo(2)
    End Sub

    Private Sub OF_3_Click(sender As Object, e As EventArgs) Handles OF_3.Click
        Cargar_Datos_Etiqueta(2)
        Etiqueta.Manual = False
        Status_Quo(2)
    End Sub

    Private Sub OF_4_Click(sender As Object, e As EventArgs) Handles OF_4.Click
        Cargar_Datos_Etiqueta(3)
        Etiqueta.Manual = False
        Status_Quo(2)
    End Sub

    Private Sub OF_5_Click(sender As Object, e As EventArgs) Handles OF_5.Click
        Cargar_Datos_Etiqueta(4)
        Etiqueta.Manual = False
        Status_Quo(2)
    End Sub

    Private Sub OF_6_Click(sender As Object, e As EventArgs) Handles OF_6.Click
        Cargar_Datos_Etiqueta(5)
        Etiqueta.Manual = False
        Status_Quo(2)
    End Sub

    Private Sub Cargar_Datos_Etiqueta(Id As Byte)
        Dim NoPalet As Integer
        Dim NoBobina As Integer

        Me.txOF.Text = Historial(Id).OP
        Aceptar_OP()
        NoPalet = Etiqueta.Palet
        NoBobina = Etiqueta.Bobina

        Etiqueta = Historial(Id)
        Etiqueta.Palet = NoPalet
        Etiqueta.Bobina = NoBobina

        Me.txOF.Text = Etiqueta.OP.ToString
        Me.txRodajas.Text = Etiqueta.Rodajas.ToString("00")
        Me.txPesoPalet.Text = Etiqueta.PesoPalet.ToString
        Me.txPesoNeto.Text = Etiqueta.PesoNeto.ToString
        Me.txMetrosRodaja.Text = Etiqueta.MetrosRodaja.ToString
        Me.txNoCopias.Text = Etiqueta.Copias.ToString
        Me.txEtiqPalet.Text = Etiqueta.EtiquetasPorPalet.ToString
        Me.Actualizar_Lienzo()
    End Sub

    Private Sub Manual_Click(sender As Object, e As EventArgs) Handles Manual.Click
        Dim sw9 As Boolean = False

        If EtManual.OP <> "" Then
            sw9 = (MsgBox("¿Desea cargar los datos de la OP: " + EtManual.OP + "?", vbYesNo, "Etiquetas Manuales") = vbYes)
        End If

        If sw9 Then
            Etiqueta = EtManual
        Else
            Etiqueta.OP = InputBox("Etiqueta", "Entrada Manual", "")
            Etiqueta.OP = Componer_OF(Etiqueta.OP)
        End If

        Me.txOF.Text = Etiqueta.OP
        Etiqueta.Manual = True
        Status_Quo(2)
        Me.txPesoPalet.Select()
    End Sub

    Private Sub EtMas_Click(sender As Object, e As EventArgs) Handles EtMas.Click
        If Not IsNumeric(Me.txEtiqPalet.Text) Then Exit Sub

        Dim valor As Byte
        valor = CByte(Me.txEtiqPalet.Text)
        Me.txEtiqPalet.Text = (valor + 1).ToString
    End Sub

    Private Sub etMenos_Click(sender As Object, e As EventArgs) Handles etMenos.Click
        If Not IsNumeric(Me.txEtiqPalet.Text) Then Exit Sub

        Dim valor As Byte
        valor = CByte(Me.txEtiqPalet.Text)
        If valor > 0 Then Me.txEtiqPalet.Text = (valor - 1).ToString
    End Sub

    Private Sub MenuConexDatos_Click(sender As Object, e As EventArgs) Handles MenuConexDatos.Click
        If Abrir_BBDD() Then
            MsgBox("Conexión con el servidor Correcta", MsgBoxStyle.Information, "Comprobar Conexiones")
            Cerrar_BBDD()
        Else
            MsgBox("Conexión con el servidor no establecida", MsgBoxStyle.Critical, "Comprobar Conexiones")
        End If
    End Sub

    Private Sub MenuConexNAV_Click(sender As Object, e As EventArgs) Handles MenuConexNAV.Click
        If WebServices.HolaMundo Then
            MsgBox("Conexión con NAV Correcta", MsgBoxStyle.Information, "Comprobar Conexiones")
        Else
            MsgBox("Conexión con NAV no establecida", MsgBoxStyle.Critical, "Comprobar Conexiones")
        End If
    End Sub

    Private Sub ResumenDia_Click(sender As Object, e As EventArgs) Handles ResumenDia.Click
        Reporting.Informe1()
    End Sub

    Private Sub ResumenPorOFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenPorOFToolStripMenuItem.Click
        Reporting.Informe2()
    End Sub


    Private Sub MenuAbrir_Click(sender As Object, e As EventArgs) Handles MenuAbrir.Click
        Dim NoDoc As String

        NoDoc = InputBox("Orden de producción ", "Reabrir Orden de producción", "")
        If NoDoc <> "" Then
            NoDoc = Componer_OF(NoDoc)

            If WebServices.ReAbrir(NoDoc) Then
                MsgBox("La Orden " + NoDoc + " Ha sido Abierta", MsgBoxStyle.Exclamation, "Abrir OP")
            Else
                MsgBox("No se ha podido Abrir la Orden " + NoDoc, MsgBoxStyle.Critical, "Abrir OP")
            End If
        End If
    End Sub

    Private Sub etMasCopias_Click(sender As Object, e As EventArgs) Handles etMasCopias.Click
        If Not IsNumeric(Me.txNoCopias.Text) Then Me.txNoCopias.Text = "0"

        Dim valor As Byte
        valor = CByte(Me.txNoCopias.Text)
        Me.txNoCopias.Text = (valor + 1).ToString
    End Sub

    Private Sub etMenosCopias_Click(sender As Object, e As EventArgs) Handles etMenosCopias.Click
        If Not IsNumeric(Me.txNoCopias.Text) Then Me.txNoCopias.Text = "2"

        Dim valor As Byte
        valor = CByte(Me.txNoCopias.Text)
        If valor > 0 Then Me.txNoCopias.Text = (valor - 1).ToString
    End Sub


    Private Sub MenuPalet_Click(sender As Object, e As EventArgs)
        Dim tt As String

        tt = InputBox("Nº de Palet", "Cambiar Palet", "")

        If tt <> "" And IsNumeric(tt) Then
            Cambiar_Palet(CInt(tt))
        End If

    End Sub

    Private Sub MenuSinPalet_Click(sender As Object, e As EventArgs) Handles MenuSinPalet.Click
        If Datos.ActualizarPalet Then MsgBox("NO se Actualizará el No. de Palet", MsgBoxStyle.Exclamation)
        If Not Datos.ActualizarPalet Then MsgBox("Se ACTUALIZARÁ el No. de Palet", MsgBoxStyle.Exclamation)

        Datos.ActualizarPalet = Not Datos.ActualizarPalet
    End Sub

    Private Sub ResumenTurnoLote_Click(sender As Object, e As EventArgs) Handles ResumenTurnoLote.Click
        Reporting.Informe3()
    End Sub

    Private Sub MenuSalir_Click(sender As Object, e As EventArgs) Handles MenuSalir.Click
        Me.Close()
    End Sub


    Private Sub MenuCambioTurno_Click(sender As Object, e As EventArgs) Handles MenuCambioTurno.Click
        Status_Quo(0)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txFechaTrabajo.TextChanged

    End Sub

    Private Sub etMasFecha_Click(sender As Object, e As EventArgs) Handles etMasFecha.Click
        Datos.FechaTrabajo = DateAdd(DateInterval.Day, 1, Datos.FechaTrabajo)
        Me.txFechaTrabajo.Text = Format(Datos.FechaTrabajo, "dd-MM")
    End Sub

    Private Sub etMenosFecha_Click(sender As Object, e As EventArgs) Handles etMenosFecha.Click
        Datos.FechaTrabajo = DateAdd(DateInterval.Day, -1, Datos.FechaTrabajo)
        Me.txFechaTrabajo.Text = Format(Datos.FechaTrabajo, "dd-MM")
    End Sub

    Private Sub txPalet_Validated(sender As Object, e As EventArgs) Handles txPalet.Validated
        Panel2Lienzo()
    End Sub


    Private Sub txPesoPalet_Validated(sender As Object, e As EventArgs) Handles txPesoPalet.Validated
        Panel2Lienzo()
    End Sub

    Private Sub txRodajas_Validated(sender As Object, e As EventArgs) Handles txRodajas.Validated
        Panel2Lienzo()
    End Sub

    Private Sub txPesoNeto_Validated(sender As Object, e As EventArgs) Handles txPesoNeto.Validated
        Panel2Lienzo()
    End Sub

    Private Sub txMetros_Validated(sender As Object, e As EventArgs) Handles txMetrosRodaja.Validated
        Panel2Lienzo()
    End Sub

    Private Sub ChGramaje_CheckedChanged(sender As Object, e As EventArgs) Handles ChGramaje.CheckedChanged
        Etiqueta.MostrarGramaje = Me.ChGramaje.Checked
        Panel2Lienzo()
    End Sub

    Private Sub chCalibre_CheckedChanged(sender As Object, e As EventArgs) Handles chCalibre.CheckedChanged
        Etiqueta.MostrarCalibre = Me.chCalibre.Checked
        Panel2Lienzo()
    End Sub

    Private Sub SoloImprimir_Click(sender As Object, e As EventArgs) Handles SoloImprimir.Click
        If Etiqueta.Manual Then EtManual = Etiqueta

        If Etiqueta.Copias > 0 Then
            'Lienzo.Imprimir_Etiqueta_Pulper()
            Lienzo.Imprimir_Etiqueta()
            Lienzo.Close()
        End If

        Status_Quo(1)
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        MsgBox(" Tú eres: " + Usuario + vbCrLf +
               " Tu máquina es: " + My.Computer.Name)
    End Sub


    Private Sub txPesoNeto_TextChanged(sender As Object, e As EventArgs) Handles txPesoNeto.TextChanged
        If IsNumeric(Me.txPesoNeto.Text) Then
            If IsNumeric(Me.txRodajas.Text) Then Etiqueta.Rodajas = CInt(Me.txRodajas.Text)
            If IsNumeric(Me.txPesoNeto.Text) Then Etiqueta.PesoNeto = CLng(txPesoNeto.Text)
            Calcular_Metros()
        End If
    End Sub

    Private Sub txRodajas_TextChanged(sender As Object, e As EventArgs) Handles txRodajas.TextChanged
        If IsNumeric(Me.txPesoNeto.Text) Then
            Etiqueta.PesoNeto = CLng(txPesoNeto.Text)
            If IsNumeric(Me.txRodajas.Text) Then Etiqueta.Rodajas = CLng(txRodajas.Text)
        End If
        Calcular_Metros()
    End Sub

    Private Sub EnviarOPTESTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarOPTESTToolStripMenuItem.Click
        WebServices.Diario_Salida_Test()
    End Sub

    Private Sub BobinaMas_Click(sender As Object, e As EventArgs) Handles BobinaMas.Click
        If Not IsNumeric(Me.txBobina.Text) Then Exit Sub

        Me.txBobina.Text = (CLng(Me.txBobina.Text) + 1).ToString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim et2 As stEtiqueta

        cargar_Horario()
        et2 = Etiqueta

        ListaOP.Mostrar_Lista_OP()
        ListaVerde.Mostrar_Lista_Verde()

        Etiqueta = et2
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Peso_Bobina(Me.txOF.Text, Me.txBobina.Text)
    End Sub

    Private Sub PesosPorOF_Click_1(sender As Object, e As EventArgs) Handles PesosPorOF.Click
        If Pesos.Mostrar_Lista_Pesos(Me.txOF.Text, 0) Then Pesos.ShowDialog()
    End Sub

    Private Sub PesosPorOFyBobina_Click(sender As Object, e As EventArgs) Handles PesosPorOFyBobina.Click
        Dim BobinaNo As Integer = 0

        If IsNumeric(Me.txBobina.Text) Then BobinaNo = CInt(Me.txBobina.Text)
        If Pesos.Mostrar_Lista_Pesos(Me.txOF.Text, BobinaNo) Then Pesos.ShowDialog()
    End Sub

    Private Sub PesoPorBobina_Click(sender As Object, e As EventArgs) Handles PesoPorBobina.Click
        Dim BobinaNo As Integer = 0

        If IsNumeric(Me.txBobina.Text) Then BobinaNo = CInt(Me.txBobina.Text)
        If Pesos.Mostrar_Lista_Pesos("", BobinaNo) Then Pesos.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        MsgBox(Datos.Versión.ToString, MsgBoxStyle.Information)
    End Sub

    Private Sub RepetirEtiquetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepetirEtiquetaToolStripMenuItem.Click
        Repetir_Etiqueta()
    End Sub

    Private Sub Repetir_Etiqueta()
        Dim NoDoc As String

        NoDoc = InputBox("Nº de Palet ", "Repetir Etiqueta", "")
        If NoDoc = "" Then Exit Sub

        Dim ds As DataSet = Nothing
        Dim tt As String

        tt = "SELECT * FROM [" + Datos.Empresa + "$Lot No_ Information]  WHERE [Palet No_] = " + NoDoc + " ORDER BY [Order No_] DESC"
        If Cargar_Dataset(ds, tt) Then
            If ds.Tables(0).Rows.Count > 0 Then
                Limpiar_Etiqueta()

                If Datos_OF(ds.Tables(0).Rows(0).Item("Order No_"), 0, False) Then
                    Etiqueta.Palet = ds.Tables(0).Rows(0).Item("Palet No_")
                    Etiqueta.Rodajas = ds.Tables(0).Rows(0).Item("Rodajas")
                    Etiqueta.Bobina = ds.Tables(0).Rows(0).Item("Bobina")
                    Etiqueta.PesoNeto = ds.Tables(0).Rows(0).Item("Peso Neto")
                    Etiqueta.Gramaje = ds.Tables(0).Rows(0).Item("Gramaje")
                    Etiqueta.Calibre = ds.Tables(0).Rows(0).Item("Calibre")
                    Etiqueta.PesoPalet = ds.Tables(0).Rows(0).Item("Peso Palet")
                    Etiqueta.PesoBruto = Etiqueta.PesoNeto + Etiqueta.PesoPalet
                    Etiqueta.Fecha = ds.Tables(0).Rows(0).Item("Fecha")
                    Etiqueta.Copias = 1

                    Lienzo.txNeto.Text = Etiqueta.PesoNeto.ToString

                    Lienzo.Imprimir_Etiqueta()
                    Lienzo.Close()

                    Status_Quo(1)
                End If
            End If

            ds.Dispose()
        End If


    End Sub

    Private Sub MenuModoTest_Click(sender As Object, e As EventArgs) Handles MenuModoTest.Click
        Datos.ModoTest = Not Datos.ModoTest
        Datos.Reload = True

        Bye()
    End Sub

    Private Sub ImprimirQRPruebasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirQRPruebasToolStripMenuItem.Click
        Lienzo.Imprimir_Etiqueta_QR()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Rechazar()
    End Sub

    Private Sub Rechazar()
        Rechazo.ShowDialog()
    End Sub
End Class