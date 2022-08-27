Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class cFunciones
    Public Shared Descripcion As String
    Public Function BuscarDatos(ByVal strConsulta As String, ByVal Campo As String, Optional ByVal nombre As String = "Buscar...", Optional ByVal NuevaConexionStr As String = "") As String
        Dim frmBuscar As New Buscar
        Dim codigo As String
        frmBuscar.sqlstring = strConsulta
        frmBuscar.Text = nombre
        frmBuscar.campo = Campo
        frmBuscar.NuevaConexion = NuevaConexionStr
        frmBuscar.ShowDialog()
        codigo = frmBuscar.codigo
        Descripcion = frmBuscar.descrip
        Return codigo
    End Function
    Public Function Buscar_X_Descripcion_Fecha(ByVal SQLString As String, ByVal CampoFiltro As String, ByVal CampoFechaFiltro As String, Optional ByVal NombreBuscador As String = "Buscar...", Optional ByVal NuevaConexion As String = "") As String
        Dim frmBuscar As New FrmBuscador
        Dim codigo As String
        frmBuscar.SQLString = SQLString
        frmBuscar.Text = NombreBuscador
        frmBuscar.CampoFiltro = CampoFiltro
        frmBuscar.CampoFecha = CampoFechaFiltro
        frmBuscar.NuevaConexion = NuevaConexion
        frmBuscar.ShowDialog()
        If frmBuscar.Cancelado Then
            Return Nothing
        Else
            Return frmBuscar.Codigo
        End If
    End Function
    Public Function Buscar_X_Descripcion_FechaX(ByVal SQLString As String, ByVal CampoFiltro As String, ByVal CampoFechaFiltro As String, Optional ByVal NombreBuscador As String = "Buscar...", Optional ByVal NuevaConexion As String = "") As String
        Dim frmBuscar As New FrmBuscadorN
        Dim codigo As String
        frmBuscar.SQLString = SQLString
        frmBuscar.Text = NombreBuscador
        frmBuscar.CampoFiltro = CampoFiltro
        frmBuscar.CampoFecha = CampoFechaFiltro
        frmBuscar.NuevaConexion = NuevaConexion
        frmBuscar.ShowDialog()
        If frmBuscar.Cancelado Then
            Return Nothing
        Else
            Return frmBuscar.Codigo
        End If
    End Function

    'Public Function Buscar_X_Descripcion_Fecha1(ByVal SQLString As String, ByVal CampoFiltro As String, ByVal strNumeroD As String, ByVal CampoFechaFiltro As String, Optional ByVal NombreBuscador As String = "Buscar...", Optional ByVal NuevaConexion As String = "") As String
    '    Dim frmBuscar As New FrmBuscador
    '    Dim codigo As String
    '    frmBuscar.SQLString = SQLString
    '    frmBuscar.Text = NombreBuscador
    '    'Asigno la primer columna por la buscare
    '    frmBuscar.CampoFiltro = CampoFiltro
    '    'Asigno el otro la otra columna por la que buscare
    '    frmBuscar.strNumeroDocumento = strNumeroD
    '    frmBuscar.CampoFecha = CampoFechaFiltro
    '    frmBuscar.NuevaConexion = NuevaConexion
    '    frmBuscar.ShowDialog()
    '    If frmBuscar.Cancelado Then
    '        Return Nothing
    '    Else
    '        Return frmBuscar.Codigo
    '    End If
    'End Function
    Public Function Buscar_X_Descripcion_Fecha5C(ByVal SQLString As String, ByVal CampoFiltro As String, ByVal CampoFechaFiltro As String, Optional ByVal NombreBuscador As String = "Buscar...") As String
        'BUSCADOR DISEÑADO PARA CINCO COLUMNAS
        Dim frmBuscar As New FrmBuscador5C
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

    'Esta Función Calcula el saldo de la factura
    Public Function Saldo_de_Factura(ByVal FacturaNo As Double, ByVal MontoFactura As Double, ByVal TipoCambFact As Double, ByVal TipoCambRecibo As Double, Optional ByVal strModulo As String = "SeePOS") As Double
        Dim cConexion As New Conexion
        Dim sqlConexion As New SqlConnection
        sqlConexion = cConexion.Conectar(strModulo)
        Saldo_de_Factura = cConexion.SlqExecuteScalar(sqlConexion, "Select  dbo.SaldoFactura(GETDATE(), " & FacturaNo & ")") * (TipoCambFact / TipoCambRecibo)
        cConexion.DesConectar(sqlConexion)
    End Function

    Public Shared Function Saldo_de_Factura_Proveedor(ByVal FacturaNo As Double, ByVal MontoFactura As Double, ByVal TipoCambFact As Double, ByVal TipoCambRecibo As Double, ByVal Proveedor As Double, Optional ByVal strModulo As String = "") As Double
        Dim cConexion As New Conexion
        If FacturaNo = 0 Then Exit Function
        Saldo_de_Factura_Proveedor = (cConexion.SlqExecuteScalar(cConexion.Conectar(strModulo), "Select dbo.SaldoFacturaCompra(GETDATE(), " & FacturaNo & "," & Proveedor & ")") * TipoCambFact / TipoCambRecibo)
        cConexion.DesConectar(cConexion.sQlconexion)

    End Function
    Public Shared Function BuscarFacturas(ByVal CodigoCliente As Integer) As DataTable

        Dim dt As New DataTable

        '' Dentro de un Try/Catch por si se produce un error
        Try
            Llenar_Tabla_Generico("SELECT Num_Factura as Factura, Fecha, Total, Cod_Moneda from Ventas WHERE Tipo = 'CRE'  and Anulado = 0 and Cod_Cliente = " & CodigoCliente & " and (dbo.SaldoFactura(GETDATE(), Num_Factura) > 0)", dt)
        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            'If Not cnn Is Nothing Then
            'cnn.Close()
            'End If
        End Try
        ' Devolvemos el objeto DataTable con los datos de la consulta
        Return dt
    End Function

    Public Shared Function BuscarFacturas_Proveedor(ByVal CodigoProv As Integer, Optional ByVal Conexion As String = "") As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataTable
        ' Dentro de un Try/Catch por si se produce un error
        Try
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = IIf(Conexion = "", GetSetting("SeeSOFT", "SEEPOS", "CONEXION"), Conexion)
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = _
            "SELECT Factura, Fecha, TotalFactura, Cod_MonedaCompra FROM compras WHERE (FacturaCancelado = 0) AND (TipoCompra = 'CRE') AND (CodigoProv = " & CodigoProv & ") AND (dbo.SaldoFacturaCompra(GETDATE(), Factura, CodigoProv) <> 0)"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.Int))
            cmd.Parameters("@Codigo").Value = CodigoProv
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

        Return dt ' Devolvemos el objeto DataTable con los datos de la consulta
    End Function

    Public Shared Function Cargar_Tabla_Generico(ByRef DataAdapter As SqlDataAdapter, ByVal SQLCommand As String, Optional ByVal NuevaConexionStr As String = "") As DataTable
        Dim StringConexion As String = IIf(NuevaConexionStr = "", GetSetting("SeeSOFT", "SEEPOS", "CONEXION"), NuevaConexionStr) 'JCGA 19032007
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
        StringConexion = IIf(NuevaConexionStr = "", GetSetting("SeeSOFT", "SEEPOS", "CONEXION"), NuevaConexionStr)

        Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)
        Dim Comando As SqlCommand = New SqlCommand
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Alerta..") ' Si hay error, devolvemos un valor nulo.
            Return Nothing
        Finally
            If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                ConexionX.Close()
            End If
        End Try
    End Function
    Public Shared Function BuscaString(ByVal strQuery As String, ByVal Conected As String, Optional ByVal strCampo As String = "") As String 'JCGA 12042007
        Dim strDatos As String = ""

        Try
            'Creo el Objeto de Conexion para realizar la consulta
            Dim myConnection As New SqlConnection(Conected)
            'Creo el Objeto Command con el que realizare la consulta
            Dim myCommand As New SqlCommand(strQuery, myConnection)

            myConnection.Open()

            'Objeto reader que utilizare en para la consulta
            Dim myReader As SqlDataReader

            'Asigno los datos de la consulta
            myReader = myCommand.ExecuteReader()
            If strCampo = "" Then

                If myReader.Read Then
                    strDatos = myReader.GetString(0)
                End If
            End If

            If strCampo <> "" Then
                If myReader.Read Then
                    strDatos = myReader(strCampo)
                End If
            End If

            myReader.Close()

            'Cierro la conexion
            myConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al mostrar datos", _
                                     MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return strDatos
    End Function
    Public Function VerificarBaseDatos(ByVal BaseDatos As String) As Boolean
        Dim Cx As New Conexion
        Dim Resultado As String
        Try
            Resultado = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Name FROM MASTER.DBO.sysdatabases WHERE name = N'" & BaseDatos & "'")
            Cx.DesConectar(Cx.sQlconexion)
            If Resultado = Nothing Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al mostrar datos", _
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
End Class

