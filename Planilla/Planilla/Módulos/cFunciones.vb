Imports System.Data.SqlClient
'Imports 'CrystalDecisions.CrystalReports.Engine
Public Class cFunciones
    Public Shared descripcion As String
    Public Shared Fechaemp As Integer

    Public Function BuscarDatos(ByVal strConsulta As String, ByVal campo As String, Optional ByVal nombre As String = "Buscar...", Optional ByVal NuevaConexionStr As String = "", Optional ByVal Fecha As Integer = 0, Optional ByVal adicional As String = "") As String
        Dim frmBuscar As New Buscar
        Dim codigo As String
        Fechaemp = Fecha
        frmBuscar.sqlString = strConsulta
        frmBuscar.sqlAdicional = adicional
        frmBuscar.Text = nombre
        frmBuscar.campo = campo
        frmBuscar.NuevaConexion = NuevaConexionStr
        frmBuscar.ShowDialog()
        codigo = frmBuscar.codigo
        descripcion = frmBuscar.descrip
        Return codigo
    End Function


    Public Function BuscarDatos2(ByVal strConsulta As String, ByVal campo As String, ByVal pSqlAdicional As String, Optional ByVal nombre As String = "Buscar...", Optional ByVal NuevaConexionStr As String = "", Optional ByVal Fecha As Integer = 0, Optional ByVal BuscoEmpleado As Boolean = False) As String
        Dim frmBuscar As New Buscar
        Dim codigo As String
        Fechaemp = Fecha
        frmBuscar.sqlString = strConsulta
        frmBuscar.Text = nombre
        frmBuscar.campo = campo
        frmBuscar.sqlAdicional = pSqlAdicional
        frmBuscar.NuevaConexion = NuevaConexionStr
        frmBuscar.BuscoEmpleadoEnAccionEmpleados = BuscoEmpleado
        frmBuscar.ShowDialog()
        codigo = frmBuscar.codigo
        descripcion = frmBuscar.descrip
        Return codigo
    End Function

    Public Function BuscarDatos3(ByVal strConsulta As String, ByVal campo As String, ByVal pSqlAdicional As String, Optional ByVal nombre As String = "Buscar...", Optional ByVal NuevaConexionStr As String = "", Optional ByVal Fecha As Integer = 0) As String
        Dim frmBuscar As New Buscar
        Dim codigo As String
        Fechaemp = Fecha
        frmBuscar.sqlString = strConsulta
        frmBuscar.Text = nombre
        frmBuscar.campo = campo
        frmBuscar.sqlAdicional = pSqlAdicional
        frmBuscar.Where = True
        frmBuscar.NuevaConexion = NuevaConexionStr        
        frmBuscar.ShowDialog()
        codigo = frmBuscar.codigo
        descripcion = frmBuscar.descrip
        Return codigo
    End Function

    Public Function BuscarDatosEmpleados(ByVal strConsulta As String, ByVal campo As String, ByVal pSqlAdicional As String, Optional ByVal nombre As String = "Buscar...", Optional ByVal NuevaConexionStr As String = "", Optional ByVal Fecha As Integer = 0) As String
        Dim frmBuscar As New frmBuscaEmpleado
        Dim codigo As String
        Fechaemp = Fecha
        frmBuscar.sqlString = strConsulta
        frmBuscar.Text = nombre
        frmBuscar.campo = campo
        frmBuscar.sqlAdicional = pSqlAdicional
        frmBuscar.NuevaConexion = NuevaConexionStr
        frmBuscar.ShowDialog()
        codigo = frmBuscar.codigo
        descripcion = frmBuscar.descrip
        Return codigo
    End Function

    Public Function BuscarDatosModificaPlanilla(ByVal strConsulta As String, ByVal campo As String, ByVal pSqlAdicional As String, Optional ByVal nombre As String = "Buscar...", Optional ByVal NuevaConexionStr As String = "", Optional ByVal Fecha As Integer = 0) As String
        Dim frmBuscar As New frmBuscaModificaPlanilla
        Dim codigo As String
        Fechaemp = Fecha
        frmBuscar.sqlString = strConsulta
        frmBuscar.Text = nombre
        frmBuscar.campo = campo
        frmBuscar.sqlAdicional = pSqlAdicional
        frmBuscar.NuevaConexion = NuevaConexionStr
        frmBuscar.ShowDialog()
        codigo = frmBuscar.codigo
        descripcion = frmBuscar.descrip
        Return codigo
    End Function

    Public Function Buscar_X_Descripcion_Fecha(ByVal SQLString As String, ByVal CampoFiltro As String, ByVal CampoFechaFiltro As String, Optional ByVal NombreBuscador As String = "Buscar...") As String
        Dim frmBuscar As New FrmBuscador
        Dim codigo As String
        frmBuscar.SQLString = SQLString
        frmBuscar.Text = NombreBuscador
        frmBuscar.CampoFiltro = CampoFiltro
        frmBuscar.CampoFecha = CampoFechaFiltro
        frmBuscar.ShowDialog()
        If frmBuscar.Cancelado Then
            Return Nothing
        Else
            Return frmBuscar.Codigo
        End If
    End Function
    'Esta Función Cálcula el saldo de la factura
    Public Function Saldo_de_Factura(ByVal FacturaNo As Double, ByVal MontoFactura As Double, ByVal TipoCambFact As Double, ByVal TipoCambRecibo As Double) As Double
        Dim cConexion As New Conexion
        Dim sqlConexion As New SqlConnection
        Dim MontoDevoluciones As Double
        Dim MontoAbonos As Double
        Dim MontoNCredito As Double
        Dim MontoNDebito As Double
        Dim InteresCob As Double
        Dim ConexionLocal As New Conexion
        Dim rs As SqlDataReader
        Dim id As Double
        sqlConexion = cConexion.Conectar
        If FacturaNo = 0 Then Exit Function
        rs = ConexionLocal.GetRecorset(ConexionLocal.Conectar, "SELECT id from Ventas where Tipo = 'CRE' and Num_Factura = " & FacturaNo)
        If rs.Read Then
            id = rs("id")
            'Cálcula Devoluciones
            MontoDevoluciones = cConexion.SlqExecuteScalar(sqlConexion, "SELECT SUM(Monto) as TotalMonto FROM Devoluciones_Ventas WHERE Id_Factura =" & rs("id") & " AND Anulado = 0")
        Else
            MontoDevoluciones = 0
        End If
        'Cálcula los Abonos
        'MontoAbonos = cConexion.SlqExecuteScalar(sqlConexion, "SELECT  dbo.detalle_abonoccobrar.Factura, dbo.detalle_abonoccobrar.Tipo, SUM(dbo.detalle_abonoccobrar.Abono_SuMoneda) AS TotalAbono, dbo.abonoccobrar.Anula FROM dbo.abonoccobrar INNER JOIN dbo.detalle_abonoccobrar ON dbo.abonoccobrar.Id_Recibo = dbo.detalle_abonoccobrar.Id_Recibo GROUP BY dbo.detalle_abonoccobrar.Factura, dbo.detalle_abonoccobrar.Tipo, dbo.abonoccobrar.Anula HAVING  dbo.detalle_abonoccobrar.Tipo = 'CRE' and dbo.detalle_abonoccobrar.Factura =" & FacturaNo & " AND dbo.abonoccobrar.Anula = 0")
        MontoAbonos = cConexion.SlqExecuteScalar(sqlConexion, "SELECT  SUM(dbo.detalle_abonoccobrar.Abono_SuMoneda) AS TotalAbono FROM dbo.abonoccobrar INNER JOIN dbo.detalle_abonoccobrar ON dbo.abonoccobrar.Id_Recibo = dbo.detalle_abonoccobrar.Id_Recibo GROUP BY dbo.detalle_abonoccobrar.Factura, dbo.detalle_abonoccobrar.Tipo, dbo.abonoccobrar.Anula HAVING  dbo.detalle_abonoccobrar.Tipo = 'CRE' and dbo.detalle_abonoccobrar.Factura =" & FacturaNo & " AND dbo.abonoccobrar.Anula = 0")
        'NOTAS DE CREDITO
        MontoNCredito = cConexion.SlqExecuteScalar(sqlConexion, "SELECT  SUM(dbo.detalle_ajustesccobrar.Ajuste_SuMoneda) AS TotalAjuste FROM dbo.ajustesccobrar INNER JOIN dbo.detalle_ajustesccobrar ON dbo.ajustesccobrar.ID_Ajuste = dbo.detalle_ajustesccobrar.Id_AjustecCobrar GROUP BY dbo.detalle_ajustesccobrar.Factura, dbo.detalle_ajustesccobrar.Tipo, dbo.detalle_ajustesccobrar.TipoNota, dbo.ajustesccobrar.Anula HAVING dbo.detalle_ajustesccobrar.Tipo = 'CRE' and dbo.detalle_ajustesccobrar.Factura =" & FacturaNo & " AND dbo.detalle_ajustesccobrar.TipoNota='CRE' AND dbo.ajustesccobrar.Anula = 0")
        'NOTAS DE DEBITO
        MontoNDebito = cConexion.SlqExecuteScalar(sqlConexion, "SELECT  SUM(dbo.detalle_ajustesccobrar.Ajuste_SuMoneda) AS TotalAjuste FROM dbo.ajustesccobrar INNER JOIN dbo.detalle_ajustesccobrar ON dbo.ajustesccobrar.ID_Ajuste = dbo.detalle_ajustesccobrar.Id_AjustecCobrar GROUP BY dbo.detalle_ajustesccobrar.Factura, dbo.detalle_ajustesccobrar.Tipo, dbo.detalle_ajustesccobrar.TipoNota, dbo.ajustesccobrar.Anula HAVING dbo.detalle_ajustesccobrar.Tipo = 'CRE' and dbo.detalle_ajustesccobrar.Factura =" & FacturaNo & " AND dbo.detalle_ajustesccobrar.TipoNota='DEB' AND dbo.ajustesccobrar.Anula = 0")
        'Obtener el saldo final de la factura
        Saldo_de_Factura = MontoFactura + ((MontoNDebito - MontoNCredito - MontoAbonos - MontoDevoluciones) * TipoCambFact / TipoCambRecibo)
        'Saldo_de_Factura = ((MontoFactura - MontoDevoluciones) + InteresCob + MontoNDebito) - (MontoNCredito + MontoAbonos)
        cConexion.DesConectar(sqlConexion)
    End Function

    Public Shared Function BuscarFacturas(ByVal CodigoCliente As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataTable
        ' Dentro de un Try/Catch por si se produce un error
        Try
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = GetSetting("Hotel", "Hotel", "CONEXION")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            'Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = _
                "SELECT Num_Factura as Factura, Fecha, Total, Cod_Moneda from Ventas WHERE Tipo = 'CRE' and FacturaCancelado = 0 and Anulado = 0 and Cod_Cliente = @Codigo"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.Int))
            cmd.Parameters("@Codigo").Value = CodigoCliente
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(dt)
        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
        ' Devolvemos el objeto DataTable con los datos de la consulta
        Return dt
    End Function
    Public Shared Function Cargar_Tabla_Generico(ByRef DataAdapter As SqlDataAdapter, ByVal SQLCommand As String) As DataTable
        Dim StringConexion As String = GetSetting("SeeSoft", "Planilla", "Conexion")
        Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)
        Dim Tabla As New DataTable
        Dim Comando As SqlCommand = New SqlCommand
        Try
            ConexionX.Open()
            Comando.CommandText = SQLCommand
            Comando.Connection = ConexionX
            Comando.CommandType = CommandType.Text
            Comando.CommandTimeout = 90
            DataAdapter.SelectCommand = Comando
            DataAdapter.Fill(Tabla)
        Catch ex As System.Exception
            MsgBox(ex.ToString) ' Si hay error, devolvemos un valor nulo.
            Return Nothing
        Finally
            If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                ConexionX.Close()
            End If
        End Try
        Return Tabla ' Devolvemos el objeto DataTable con los datos de la consulta
    End Function

    Public Shared Function Llenar_Tabla_Generico(ByVal SQLCommand As String, ByRef Tabla As DataTable, Optional ByVal NuevaConexionStr As String = "")
        Dim StringConexion As String
        If NuevaConexionStr = "" Then
            StringConexion = GetSetting("Seesoft", "Planilla", "CONEXION")
        Else
            StringConexion = NuevaConexionStr
        End If
        Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)
        Dim Comando As SqlCommand = ConexionX.CreateCommand
        Try
            ConexionX.Open()
            Comando.CommandText = SQLCommand
            Comando.Connection = ConexionX
            Comando.CommandType = CommandType.Text
            Comando.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = Comando
            Tabla.Clear()
            da.Fill(Tabla)
        Catch ex As System.Exception
            MsgBox(ex.ToString) ' Si hay error, devolvemos un valor nulo.
            Return Nothing
        Finally
            If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                ConexionX.Close()
            End If
        End Try
    End Function



    Public Function BuscaNumeroAsiento(ByVal InicioAsiento As String) As String
        Dim cConexion As New Conexion
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader
        Dim Numero As String
        Dim Max As String = "0"
        Dim Ceros, Length As Integer

        Try
            'BUSCA LOS NUMEROS DE ASIENTOS EXISTENTES PARA EL AÑO Y MES ESTABLECIDOS
            rs = cConexion.GetRecorset(cConexion.Conectar("Contabilidad"), "SELECT NumAsiento from AsientosContables Where NumAsiento Like '" & InicioAsiento & "%'")

            While rs.Read
                Numero = rs("NumAsiento").Substring(9)  'SELECCIONA SOLO EL NUMERO DE CONSECUTIVO DEL ASIENTO SIN EL AÑO Y MES
                If CInt(Max) < CInt(Numero) Then        'VERIFICA SI EL NUMERO QUE ESTA LEYENDO ES EL MAYOR
                    Max = Numero                        'DE SER MAYOR SE LO ASIGNA AL NUMERO MAX
                End If
            End While
            rs.Close()

            If Max = 0 Then
                BuscaNumeroAsiento = InicioAsiento & "0001"  'ENVIA EL SIGUIENTE NUMERO DE ASIENTO
            Else
                '-----------------------------------------------------------
                'PARA SABER LA CANTIDAD DE CEROS QUE DEBE HABER EN EL CONSECUTIVO DEL ASIENTO
                Ceros = Max.TrimStart("0").Length
                Max = CInt(Max)
                Length = Max.Length
                Max += 1
                If Max.Length <> Length Then
                    Ceros += 1
                End If
                For i As Integer = 0 To (3 - Ceros)
                    InicioAsiento = InicioAsiento & "0"
                Next
                '-----------------------------------------------------------
                BuscaNumeroAsiento = InicioAsiento & Max  'ENVIA EL SIGUIENTE NUMERO DE ASIENTO
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function

    Public Function BuscaPeriodo(ByVal Fecha As DateTime) As String
        Dim cConexion As New Conexion                   'BUSCA EL PERIODO DE LA TRANSACCIÓN DE ACUERDO AL PERIODO FISCAL
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader
        Dim Inicio, Final As DateTime

        Try
            'BUSCA LOS PERIODOS FISCALES ABIERTOS
            rs = cConexion.GetRecorset(cConexion.Conectar("Contabilidad"), "SELECT dbo.DateOnlyInicio(FechaInicio) AS FechaInicio, FechaFinal FROM PeriodoFiscal WHERE Estado = 0")

            While rs.Read
                If Fecha >= rs("FechaInicio") Then
                    If Fecha <= rs("FechaFinal") Then
                        Inicio = rs("FechaInicio")
                        Final = rs("FechaFinal")
                        Fecha = CDate("01" & "/" & Fecha.Month & "/" & Fecha.Year)
                        Inicio = CDate("01" & "/" & Inicio.Month & "/" & Inicio.Year)
                        For i As Integer = 1 To 12
                            If Inicio < Fecha Then
                                Inicio = Inicio.AddMonths(1)
                            Else
                                BuscaPeriodo = i & "/" & Final.Year
                                Exit For
                            End If
                        Next
                    End If
                End If
            End While
            rs.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function

End Class
