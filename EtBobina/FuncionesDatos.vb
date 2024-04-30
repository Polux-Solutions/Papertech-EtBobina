Imports System.Data.SqlClient
Module FuncionesDatos
    Public Function Abrir_BBDD() As Boolean
        Abrir_BBDD = True

        If Not IsNothing(Datos.Conex) Then
            If Datos.Conex.State = ConnectionState.Open Then Exit Function
        End If

        Try
            Datos.Conex = New SqlConnection("server=" & Datos.Servidor & ";uid=" & Datos.Usuario &
                                                        ";pwd=" & Datos.Password & ";database=" & Datos.BD &
                                                        ";MultipleActiveResultSets=True;Connection Timeout=3")
            Datos.Conex.Open()
        Catch ex As SqlClient.SqlException
            Log("ERROR APERTURA CONEXION CON BASE DE DATOS " + vbCrLf +
                 "Servidor : " + Datos.Servidor + "   Uid= " + Datos.Usuario + "   Database: " + Datos.BD + vbCrLf +
                 " Error : " + ex.Message)
            Abrir_BBDD = False
            Exit Function
        End Try
    End Function
    Public Function Abrir_BBDD_Reporting() As Boolean
        Abrir_BBDD_Reporting = True

        Try
            Datos.ConexReporting = New SqlConnection("server=" & Datos.ServidorReporting & ";uid=" & Datos.UsuarioReporting &
                                                        ";pwd=" & Datos.PasswordReporting & ";database=" & Datos.BDReporting &
                                                        ";MultipleActiveResultSets=True;Connection Timeout=3")
            Datos.ConexReporting.Open()
        Catch ex As SqlClient.SqlException
            Log("ERROR APERTURA CONEXION CON BASE DE DATOS REPORTING" + vbCrLf +
                 "Servidor : " + Datos.ServidorReporting + "   Uid= " + Datos.UsuarioReporting + "   Database: " + Datos.BDReporting + vbCrLf +
                 " Error : " + ex.Message)
            Abrir_BBDD_Reporting = False
            Exit Function
        End Try
    End Function
    Public Function Cerrar_BBDD() As Boolean
        Cerrar_BBDD = True

        Try
            If Datos.Conex.State = ConnectionState.Open Then Datos.Conex.Close()
        Catch ex As SqlClient.SqlException
            Log("ERROR CERRAR CONEXION CON BASE DE DATOS " & ex.Message)
            Cerrar_BBDD = False
        End Try
    End Function

    Public Function Cerrar_BBDD_Reporting() As Boolean
        Cerrar_BBDD_Reporting = True

        Try
            If Datos.ConexReporting.State = ConnectionState.Open Then Datos.ConexReporting.Close()
        Catch ex As SqlClient.SqlException
            Log("ERROR CERRAR CONEXION CON BASE DE DATOS Reporting" & ex.Message)
            Cerrar_BBDD_Reporting = False
        End Try
    End Function

    Public Function Extraer_Datos(NoOP As String, IncrementoPalet As Byte, SoloAbiertas As Boolean) As String
        Dim oRead As SqlClient.SqlDataReader
        Dim PuedeUsarOPSinActivar As Boolean = False
        Dim cSql As String

        Extraer_Datos = "OK"
        If Not Abrir_BBDD() Then
            Extraer_Datos = "ERROR"
            Exit Function
        End If


        Etiqueta.OP = NoOP
        cSql = "SELECT TOP 1 OPL.[Line No_], OPL.[Item No_], OPL.[Variant Code], OPL.[Quantity], OPH.[Terminada], OPH.[Pedido Origen], OPH.[Ref_ Externa] " &
               "FROM [" & Datos.Empresa + "$Prod_ Order Line] OPL" +
               " inner join [" & Datos.Empresa + "$Production Order] OPH ON OPL.[Status] = OPH.[Status] AND OPL.[Prod_ Order No_] = OPH.[No_] " +
               " WHERE OPL.[Status] IN (3,4) AND OPL.[Prod_ Order No_] = '" + NoOP + "'"

        oRead = Nothing
        If Not Ejecutar_Datareader(cSql, oRead, True) Then
            Extraer_Datos = "ERROR"
            Exit Function
        End If
        If Not oRead.HasRows Then
            Extraer_Datos = "NO EXISTE"
            oRead.Close()
            Exit Function
        End If

        If SoloAbiertas And oRead.Item("Terminada") <> False Then
            Extraer_Datos = "OP TERMINADA"
            oRead.Close()
            Exit Function
        End If

        Etiqueta.Line = oRead.Item("Line No_")
        Etiqueta.Referencia = oRead.Item("Item No_").ToString
        Etiqueta.Variante = oRead.Item("Variant Code").ToString
        Etiqueta.Pedido = oRead.Item("Pedido Origen").ToString
        Etiqueta.SuReferencia = oRead.Item("Ref_ Externa").ToString
        oRead.Close()

        oRead = Nothing

        cSql = "SELECT [Puede Utilizar OP sin Activar] FROM [" & Datos.Empresa + "$User Setup] USU  WHERE USU.[User ID] = '" + Usuario.ToUpper + "'"

        If Not Ejecutar_Datareader(cSql, oRead, True) Then
            Extraer_Datos = "ERROR"
            Exit Function
        End If

        If oRead.HasRows Then PuedeUsarOPSinActivar = (oRead.Item("Puede Utilizar OP sin Activar") <> 0)
        oRead.Close()

        If Not PuedeUsarOPSinActivar Then 'And (Etiqueta.Variante.Substring(0, 3) <> "897" And Etiqueta.Variante.Substring(0, 3) <> "898") Then
            cSql = " SELECT COUNT(*) FROM [" + Datos.Empresa + "$Informe Bobinadora] IB" +
                        " WHERE IB.[COD_FAB1] = '" + NoOP + "'" +
                        "    OR IB.[COD_FAB2] = '" + NoOP + "'" +
                        "    OR IB.[COD_FAB3] = '" + NoOP + "'" +
                        "    OR IB.[COD_FAB4] = '" + NoOP + "'" +
                        "    OR IB.[COD_FAB5] = '" + NoOP + "'"

            If Not Ejecutar_Datareader(cSql, oRead, True) Then
                Extraer_Datos = "ERROR"
                Exit Function
            End If


            If oRead.HasRows Then
                If oRead.Item(0) = 0 Then
                    Extraer_Datos = "NO QCS"
                    oRead.Close()
                    Exit Function
                End If
            End If
            oRead.Close()
        End If

        If Etiqueta.Pedido = "" Then
            cSql = " SELECT CU.[No_] , '', CU.[Su Referencia], CU.[Language Code], CU.[Plan de Verificacion], CU.[Tipo Etiqueta], CU.[Etiqueta Tipo Peso], CU.[Generar Etiqueta QR]" +
                      " FROM [" + Datos.Empresa + "$Customer] CU" +
                      "  where CU.[No_] = '" + Etiqueta.Variante.Substring(0, 3) + "'"
        Else
            cSql = " SELECT SH.[Sell-to Customer No_], SH.[External Document No_], CU.[Su Referencia], CU.[Language Code], CU.[Plan de Verificacion],CU.[Tipo Etiqueta], CU.[Etiqueta Tipo Peso], CU.[Generar Etiqueta QR] " +
                    " FROM [" + Datos.Empresa + "$Sales Header] SH" +
                    " INNER JOIN  [" + Datos.Empresa + "$Customer] CU" +
                    "       ON CU.[No_] = SH.[Sell-to Customer No_]" +
                    "  where SH.[Document Type] = 1  AND SH.[No_] = '" + Etiqueta.Pedido.ToString + "'"
        End If

        If Not Ejecutar_Datareader(cSql, oRead, True) Then
            Extraer_Datos = "ERROR"
            Exit Function
        End If

        If oRead.HasRows Then
            Etiqueta.Cliente = oRead.Item(0).ToString
            Etiqueta.PedidoCliente = oRead.Item(1).ToString
            If Etiqueta.SuReferencia = "" Then
                Etiqueta.SuReferencia = oRead.Item(2).ToString
            End If
            Etiqueta.Idioma = oRead.Item(3).ToString
            Etiqueta.PlanVerificacion = oRead.Item("Plan de Verificacion").ToString
            Etiqueta.TipoEtiqueta = oRead.Item("Tipo Etiqueta")
            Etiqueta.TipoPeso = oRead.Item("Etiqueta Tipo Peso")
            Etiqueta.GenerarQR = oRead.Item("Generar Etiqueta QR")
        End If

        ' KK
        'Etiqueta.TipoEtiqueta = 4
        oRead.Close()

        'Nombre CZZ
        cSql = $"SELECT [Description] FROM [{Datos.Empresa}$Item] WHERE [No_] = 'CZZ'"

        If Not Ejecutar_Datareader(cSql, oRead, True) Then
            Extraer_Datos = "ERROR"
            Exit Function
        End If

        If oRead.HasRows Then Datos.CZZ_Nombre = oRead.Item("Description")
        oRead.Close()



        cSql = "SELECT IT.[Description], VA.[Gramaje], VA.[Ancho], VA.[Calibre], VA.[EAN], " +
                      "VA.[Observaciones Etiqueta], VA.[Imprimir Gramaje], VA.[Imprimir Calibre]," +
                      "COALESCE(RF.[Cross-Reference No_], '') AS [Cross-Reference No_], " +
                      "COALESCE(ITL.[Description], '') AS ItemTranslation, " +
                      "COALESCE(ITLV.[Description], '') AS VariantTranslation" +
               "       FROM [" + Datos.Empresa + "$Item Variant] VA" +
               "       Inner Join [" + Datos.Empresa + "$Item] IT" +
               "             ON IT.[No_] = VA.[Item No_]" +
               "       LEFT  JOIN [" + Datos.Empresa + "$Item Cross Reference] RF " +
               "             ON RF.[Item No_] = IT.[No_] And RF.[Variant Code] = VA.[Code] " +
               "                And RF.[Cross-Reference Type] = 1 And RF.[Cross-Reference Type No_] = '" + Etiqueta.Cliente + "'" +
               "       LEFT  JOIN [" + Datos.Empresa + "$Item Translation] ITL " +
               "             ON ITL.[Item No_] = IT.[No_]  AND ITL.[Variant Code] = '' " +
               "                AND ITL.[Language Code] = '" + Etiqueta.Idioma + "'" +
               "       LEFT  JOIN [" + Datos.Empresa + "$Item Translation] ITLV " +
               "             ON ITLV.[Item No_] = IT.[No_] AND ITLV.[Variant Code] = VA.[Code] " +
               "                AND ITLV.[Language Code] = '" + Etiqueta.Idioma + "'" +
               "       WHERE VA.[Item No_] = '" + Etiqueta.Referencia + "' AND VA.[Code] = '" + Etiqueta.Variante + "'"

        'Item Cross Reference

        If Not Ejecutar_Datareader(cSql, oRead, True) Then
            Extraer_Datos = "ERROR"
            Exit Function
        End If
        If oRead.HasRows Then
            Etiqueta.ReferenciaNombre = oRead.Item("Description").ToString
            If Etiqueta.ReferenciaNombre.Length > 3 Then
                If Etiqueta.ReferenciaNombre.Substring(0, 3) = "CAL" Then
                    Etiqueta.ReferenciaNombre = Etiqueta.ReferenciaNombre.Substring(4, Etiqueta.ReferenciaNombre.Length - 4)
                End If
            End If

            Etiqueta.Gramaje = oRead.Item("Gramaje")
            Etiqueta.Ancho = oRead.Item("Ancho")
            Etiqueta.Calibre = oRead.Item("Calibre")
            Etiqueta.NoEAN = oRead.Item("EAN")
            Etiqueta.ReferenciaCruzada = oRead.Item("Cross-Reference No_").ToString
            Etiqueta.ObsEtiqueta = oRead.Item("Observaciones Etiqueta").ToString ' + "  " + Etiqueta.SuReferencia.ToString
            Etiqueta.ReferenciaTranslation = oRead.Item("ItemTranslation").ToString
            Etiqueta.VarianteTranslation = oRead.Item("VariantTranslation").ToString
            Etiqueta.MostrarGramaje = oRead("Imprimir Gramaje")
            Etiqueta.MostrarCalibre = oRead("Imprimir Calibre")
        End If
        oRead.Close()

        cSql = "SELECT TOP 1 [Ultimo No_ de Palet Utilizado], [Ultimo Peso Palet], [Ultimo No_ Bobina]  FROM [" + Datos.Empresa + "$Inventory Setup]"

        If Not Ejecutar_Datareader(cSql, oRead, True) Then
            Extraer_Datos = "ERROR"
            Exit Function
        End If


        If oRead.HasRows Then
            Etiqueta.Palet = oRead.Item("Ultimo No_ de Palet Utilizado") + IncrementoPalet
            Etiqueta.PesoPalet = oRead.Item("Ultimo Peso Palet")
            Etiqueta.Bobina = oRead.Item("Ultimo No_ Bobina")
        End If

        oRead.Close()

        If Etiqueta.Variante.ToString.Length > 3 Then
            cSql = "SELECT [Metros Rodaja], [Metros Palet] FROM [" + Datos.Empresa + "$Customer] " +
                   " WHERE [No_] = '" + Etiqueta.Variante.ToString.Substring(0, 3) + "'"

            If Not Ejecutar_Datareader(cSql, oRead, True) Then
                Extraer_Datos = "ERROR"
                Exit Function
            End If

            If oRead.HasRows Then
                Etiqueta.PedirMetrosRodaja = oRead.Item("Metros Rodaja")
                Etiqueta.PedirMetrosPalet = oRead.Item("Metros Palet")
            End If


            oRead.Close()
        End If

        If Etiqueta.Cliente = "" And Etiqueta.Variante <> "" Then Etiqueta.Cliente = Etiqueta.Variante.Substring(0, 3)

        Cerrar_BBDD()
    End Function

    Function Ejecutar_Datareader(Csql As String, ByRef oRead As SqlClient.SqlDataReader, leer As Boolean) As Boolean
        Dim oComm As New SqlClient.SqlCommand

        Ejecutar_Datareader = Abrir_BBDD()

        Try
            oComm.Connection = Datos.Conex
            oComm.CommandText = Csql
            oRead = oComm.ExecuteReader
            If leer Then oRead.read
            oComm.Dispose()
        Catch ex As Exception
            Ejecutar_Datareader = False
            Log("Error Ejecutar Datareader " + ex.Message + vbCrLf +
                " Sql : " + Csql)
        End Try
    End Function

    Function Ejecutar_Datareader_Reporting(Csql As String, ByRef oRead As SqlClient.SqlDataReader, leer As Boolean) As Boolean
        Dim oComm As New SqlClient.SqlCommand

        Ejecutar_Datareader_Reporting = Abrir_BBDD_Reporting()

        Try
            oComm.Connection = Datos.ConexReporting
            oComm.CommandText = Csql
            oRead = oComm.ExecuteReader
            If leer Then oRead.Read()
            oComm.Dispose()
        Catch ex As Exception
            Ejecutar_Datareader_Reporting = False
            Log("Error Ejecutar Datareader Reporting " + ex.Message + vbCrLf +
                " Sql : " + Csql)
        End Try
    End Function

    Public Function Cargar_Dataset(ByRef ds As DataSet, cSql As String) As Boolean
        Dim da As SqlClient.SqlDataAdapter

        Cargar_Dataset = Abrir_BBDD()

        Try
            da = New SqlClient.SqlDataAdapter(cSql, Datos.Conex)

            If ds Is Nothing Then ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Resumen")
            da.Dispose()
        Catch ex As Exception
            Log("Error datos Cargar_Dataset SQL:" + cSql + " Error: " + ex.Message)
            Cargar_Dataset = False
        End Try
    End Function



End Module
