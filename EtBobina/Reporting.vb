Option Explicit On
Module Reporting
    Private Function Procedimiento(NombreStoreProcedure As String) As Boolean
        Procedimiento = True

        If Etiqueta.Turno = "" Or Etiqueta.Horario = "" Then
            MsgBox("No se ha definido Turno / Horario", MsgBoxStyle.Critical)
            Procedimiento = False
        End If

        If Procedimiento Then Procedimiento = Abrir_BBDD_Reporting()


        If Procedimiento Then
            Dim oComm As New SqlClient.SqlCommand

            Try
                Dim param(1) As SqlClient.SqlParameter
                param(0) = New SqlClient.SqlParameter
                param(1) = New SqlClient.SqlParameter
                param(0).ParameterName = "@Turno"
                param(0).Value = Etiqueta.Turno
                param(1).ParameterName = "@Hora"
                param(1).Value = Etiqueta.Horario

                oComm.Connection = Datos.ConexReporting
                oComm.CommandType = CommandType.StoredProcedure
                oComm.CommandText = NombreStoreProcedure
                oComm.Parameters.Add(param(0))
                oComm.Parameters.Add(param(1))

                oComm.ExecuteNonQuery()
            Catch ex As Exception
                Procedimiento = False
                Log("Error Reporting Ejecutar Procedimiento Almacenado Informe Verde " + oComm.CommandText + " " + ex.Message)
            End Try
        End If

    End Function


    Public Function Informe1() As Boolean
        Informe1 = Procedimiento("Etiquetas1")
        If Informe1 Then
            ReportV.ReportViewer1.LocalReport.ReportEmbeddedResource = "EtBobina.Report2.rdlc"
            ReportV.ShowDialog()
            Cerrar_BBDD_Reporting()
            ReportV.Dispose()
        End If
    End Function

    Public Function Informe2() As Boolean
        Informe2 = Procedimiento("Etiquetas1")
        If Informe2 Then
            ReportV.ReportViewer1.LocalReport.ReportEmbeddedResource = "EtBobina.Report1.rdlc"
            ReportV.ShowDialog()
            Cerrar_BBDD_Reporting()
            ReportV.Dispose()
        End If
    End Function
    Public Function Informe3() As Boolean

        Informe3 = Procedimiento("Etiquetas1")

        If Informe3 Then
            ReportV.ReportViewer1.LocalReport.ReportEmbeddedResource = "EtBobina.Report3.rdlc"
            ReportV.ShowDialog()
            Cerrar_BBDD_Reporting()
            ReportV.Dispose()
        End If
    End Function
End Module
