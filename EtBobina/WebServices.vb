Option Explicit On

Module WebServices
    ' Función de pruebas
    Public Function HolaMundo() As Boolean
        Dim MyWs As New WebReference.Web

        HolaMundo = True
        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)
            MsgBox("hola mundo ->" + MyWs.Capitalize("hola Mundo"))
        Catch ex As Exception
            Log("Error en los servicios WEB Hola Mundo: " + ex.Message)
            HolaMundo = False
        End Try

        MyWs.Dispose()
    End Function
    Public Function Cambiar_Palet(xPalet As Integer) As Boolean
        Dim MyWs As New WebReference.Web

        Cambiar_Palet = True

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            MyWs.Cambiar_Palet(xPalet)
        Catch ex As Exception
            Log("Error en los servicios WEB Cambiar Palet: " + ex.Message)
            Cambiar_Palet = False
        End Try

        MyWs.Dispose()
    End Function
    Public Function Fecha_Trabajo(xTurno As String, xHora As String) As Date
        Dim MyWs As New WebReference.Web

        Fecha_Trabajo = Now

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            Fecha_Trabajo = MyWs.Fecha_Trabajo(xTurno, xHora)
        Catch ex As Exception
            Log("Error en los servicios WEB Fecha_Trabajo: " + ex.Message)
            Fecha_Trabajo = Now
        End Try

        MyWs.Dispose()
    End Function

    Public Function Insertar_Rechazo(xRechazo As String, xBobina As String, xRodajas As Int32, xPesoEstimado As Int32) As Boolean
        Dim MyWs As New WebReference.Web

        Insertar_Rechazo = True

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            MyWs.Rechazos(xRechazo, xBobina, xRodajas, xPesoEstimado)
        Catch ex As Exception
            Log("Error en los servicios WEB Rechazo: " + ex.Message)
            Insertar_Rechazo = False
        End Try

        MyWs.Dispose()
    End Function

    Public Function Scrap(xOP As String, xBobina As Integer, xCode As String, xKG As Single) As Boolean
        Dim MyWs As New WebReference.Web

        Scrap = True

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            MyWs.Scrap(xOP, xBobina, xCode, xKG)
        Catch ex As Exception
            Log("Error en los servicios WEB Scrap: " + ex.Message)
            Scrap = False
        End Try

        MyWs.Dispose()
    End Function


    Public Function Verificar_No_Bobina(xOP As String, xBobina As Integer) As Boolean
        Dim MyWs As New WebReference.Web

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            Verificar_No_Bobina = MyWs.Verificar_No_Bobina(xOP, xBobina)
        Catch ex As Exception
            Log("Error en los servicios WEB Verificar No Bobina: " + ex.Message)
            Verificar_No_Bobina = False
        End Try

        MyWs.Dispose()
    End Function

    Public Sub Peso_Bobina(xOP As String, xBobina As Integer)
        Dim MyWs As New WebReference.Web
        Dim Peso As Integer = 0

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            Peso = MyWs.Peso_OF_Bobina(xOP, xBobina, False, Year(Now))
        Catch ex As Exception
            Log("Error en los servicios WEB Peso bobina: " + ex.Message)
        End Try

        MsgBox(Peso.ToString)

        MyWs.Dispose()
    End Sub

    Public Function Detalle_Peso_OP(xOP As String, xBobina As Integer, ByRef ds As DataSet) As Boolean
        Dim FileName As String = System.IO.Path.GetTempFileName()
        Dim MyWs As New WebReference.Web

        Detalle_Peso_OP = True

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)
            MyWs.Timeout = 50000

            Using sw As System.IO.StreamWriter = New System.IO.StreamWriter(FileName)
                sw.Write(MyWs.XML_Peso_Bobina(xOP, xBobina))
            End Using
        Catch ex As Exception
            Log("Error Llamada WebService Detalle_Peso_OP: " + ex.Message)
            Detalle_Peso_OP = False
        End Try

        If Detalle_Peso_OP Then
            Try
                Dim xmlFile As System.Xml.XmlReader
                xmlFile = System.Xml.XmlReader.Create(FileName, New System.Xml.XmlReaderSettings())

                If Not IsNothing(ds) Then ds.Dispose()
                ds = New DataSet
                ds.ReadXml(xmlFile)
            Catch ex As Exception
                Log("Error Carga xml Pesos: " + ex.Message)
                Detalle_Peso_OP = False
            End Try
        End If

        MyWs.Dispose()
    End Function

    Public Function Verificar_Peso_Bobina(xOP As String, xBobina As Integer, xPeso As Integer) As Integer
        Dim MyWs As New WebReference.Web

        Verificar_Peso_Bobina = 0

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            Verificar_Peso_Bobina = MyWs.Verificar_Peso_Bobina(xOP, xBobina, xPeso)
        Catch ex As Exception
            Log("Error en los servicios WEB Verificar_Peso_Bobina: " + ex.Message)
        End Try

        MyWs.Dispose()
    End Function

    Public Function Diario_Salida() As Boolean
        Dim MyWs As New WebReference.Web

        Diario_Salida = True

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            If Etiqueta.FruverPack_OP <> "" Then
                MyWs.DiarioSalida_FruverPack(Datos.FechaTrabajo, Etiqueta.Turno, Etiqueta.Horario, Etiqueta.FruverPack_OP, Etiqueta.Bobina, Etiqueta.Palet,
                                             Etiqueta.CZZ_Rodajas, Etiqueta.PesoNeto, Etiqueta.PesoPalet, Etiqueta.MetrosRodaja, Etiqueta.PedirMetrosPalet,
                                             Etiqueta.CZZ_Ancho, Etiqueta.Gramaje, Etiqueta.Calibre,
                                             Etiqueta.Terminar, Datos.ActualizarPalet, Etiqueta.Pendiente)


            Else
                MyWs.DiarioSalida7(Datos.FechaTrabajo, Etiqueta.Turno, Etiqueta.Horario, Etiqueta.OP, Etiqueta.Bobina, Etiqueta.Palet, Etiqueta.Rodajas,
                                   Etiqueta.PesoNeto, Etiqueta.PesoPalet, Etiqueta.MetrosRodaja, Etiqueta.PedirMetrosPalet,
                                   Etiqueta.Ancho, Etiqueta.Gramaje, Etiqueta.Calibre,
                                   Etiqueta.Terminar, Datos.ActualizarPalet, Etiqueta.Pulper, Etiqueta.Desclasificado, Etiqueta.Pendiente,
                                   Etiqueta.CZZ_Ancho, Etiqueta.CZZ_Rodajas)
            End If

        Catch ex As Exception
            Log("Error en los servicios WEB Diario_Salida: " + ex.Message)
            Diario_Salida = False
        End Try

        MyWs.Dispose()
    End Function

    Public Sub Diario_Salida_Test() ' No Usar
        Dim MyWs As New WebReference.Web

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            MyWs.DiarioSalida2(Now, "A", "1", "OF031828", "33", 2, 12, 11, 1, 1, 0, 0)
        Catch ex As Exception
            Log("Error en los servicios WEB Diario_Salida TEST: " + ex.Message)
        End Try

        MyWs.Dispose()
    End Sub

    Public Function Plan_Verificacion_Ask(xCliente As String) As Boolean
        Dim MyWs As New WebReference.Web

        Plan_Verificacion_Ask = False

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            Plan_Verificacion_Ask = MyWs.Plan_Verificacion_Ask(xCliente)
        Catch ex As Exception
            Log("Error en los servicios WEB Plan de Verificación ASK: " + ex.Message)
        End Try

        MyWs.Dispose()
    End Function

    Public Sub Cambio_Rollo(Etiqueta As stEtiqueta)
        Dim MyWs As New WebReference.Web

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            MyWs.Cambio_Rollo(Etiqueta.Bobina, Etiqueta.Rollo_AnchoRodaja, Etiqueta.Rollo_AnchoMandril, Etiqueta.Rollo_RodajasDuras)
        Catch ex As Exception
            Log($"Error en los servicios WEB Cambio Rollo: {ex.Message}")
        End Try

        MyWs.Dispose()
    End Sub

    Public Function Existe_Palet(xPalet) As Boolean
        Dim MyWs As New WebReference.Web

        Existe_Palet = False

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            Existe_Palet = MyWs.Verificar_No_Palet(xPalet)
        Catch ex As Exception
            Log("Error en los servicios WEB Existe Palet: " + ex.Message)
        End Try

        MyWs.Dispose()
    End Function

    Public Sub Plan_Verificacion_Counter(xCliente As String)
        Dim MyWs As New WebReference.Web

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            MyWs.Plan_Verificacion_Counter(xCliente)
        Catch ex As Exception
            Log("Error en los servicios WEB Plan de Verificación Counter: " + ex.Message)
        End Try

        MyWs.Dispose()
    End Sub

    Public Function Plan_Verificacion_Insertar(xPalet As Integer, xOF As String, xPlan As String, xLine As Integer, xOK As Boolean, xTexto As String) As Boolean
        Dim MyWs As New WebReference.Web

        Plan_Verificacion_Insertar = True

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            MyWs.Plan_Verificacion_Insertar(xPalet, xOF, xPlan, xLine, xOK, xTexto)
        Catch ex As Exception
            Log("Error en los servicios WEB Plan de Verificación Insertar: " + ex.Message)
            Plan_Verificacion_Insertar = False
        End Try

        MyWs.Dispose()
    End Function

    Public Function Plan_Verificacion_Insertar2(xXml) As Boolean
        Dim MyWs As New WebReference.Web

        Plan_Verificacion_Insertar2 = True

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            MyWs.Plan_Verificacion_Insertar2(xXml)
        Catch ex As Exception
            Log("Error en los servicios WEB Plan de Verificación Insertar: " + ex.Message)
            Plan_Verificacion_Insertar2 = False
        End Try

        MyWs.Dispose()
    End Function

    Public Function Plan_Verificacion_Borrar(xPalet As Integer) As Boolean
        Dim MyWs As New WebReference.Web

        Plan_Verificacion_Borrar = True

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            MyWs.Plan_Verificacion_Borrar(xPalet)
        Catch ex As Exception
            Log("Error en los servicios WEB Plan de Verificación Borrar: " + ex.Message)
            Plan_Verificacion_Borrar = False
        End Try

        MyWs.Dispose()
    End Function

    Public Function Plan_Verificacion_Existe(xPalet As Integer) As Boolean
        Dim MyWs As New WebReference.Web

        Plan_Verificacion_Existe = False

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            Plan_Verificacion_Existe = MyWs.Plan_Verificacion_Existe(xPalet)
        Catch ex As Exception
            Log("Error en los servicios WEB Plan de Verificación Existe Palet: " + xPalet.ToString + "   Error: " + ex.Message)
            Plan_Verificacion_Existe = False
        End Try

        MyWs.Dispose()
    End Function
    Public Function ReAbrir(NoOP As String) As Boolean
        Dim MyWs As New WebReference.Web

        ReAbrir = True

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            MyWs.Abrir_OP(NoOP)
        Catch ex As Exception
            Log("Error en los servicios WEB Reabrir: " + ex.Message)
            ReAbrir = False
        End Try

        MyWs.Dispose()
    End Function
    Public Function Eliminar_Linea(NoReserva As Integer, Orden As String, Referencia As String, Variante As String, Cantidad As Integer) As Boolean
        Dim MyWs As New WebReference.Web
        Dim Counter As Integer

        Eliminar_Linea = True

        Try
            MyWs.Url = Datos.ServidorWeb
            MyWs.Credentials = New System.Net.NetworkCredential(Datos.UsuarioWeb, Datos.PasswordWeb, Datos.DominioWeb)

            Counter = MyWs.EliminarDiarioSalida(NoReserva, Orden, Referencia, Variante, Cantidad)
            If Counter = 0 Then
                MsgBox("NO existen líneas en el diario de esta NoReserva/orden/Referencia/Variante", vbExclamation)
            Else
                MsgBox("Línea Borrada con Éxito", vbExclamation)
            End If
        Catch ex As Exception
            Log("Error en los servicios WEB Eliminar_Linea: " + ex.Message)
            Eliminar_Linea = False
        End Try

        MyWs.Dispose()
    End Function
End Module
