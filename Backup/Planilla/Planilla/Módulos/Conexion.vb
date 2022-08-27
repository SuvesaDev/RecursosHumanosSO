Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Conexion
    Public sQlconexion As New SqlConnection
    Public SQLStringConexion As String

    Private conexion As New OleDbConnection
    Private adaptador As SqlDataAdapter
    Private datos As New DataSet
    Private comand As New OleDbCommand

    Public Function Conectar(Optional ByVal Modulo As String = "Planilla") As SqlConnection
        'Dim strConexion As String
        If sQlconexion.State <> ConnectionState.Open Then
            SQLStringConexion = GetSetting("SeeSoft", Modulo, "CONEXION")
            sQlconexion.ConnectionString = SQLStringConexion
            sQlconexion.Open()
        Else
        End If
        Return sQlconexion
    End Function

    Public Function Conectar2() As SqlConnection
        'Dim strConexion As String
        If sQlconexion.State <> ConnectionState.Open Then
            SQLStringConexion = GetSetting("SeeSoft", "Seguridad", "CONEXION")
            sQlconexion.ConnectionString = SQLStringConexion
            sQlconexion.Open()
        Else
        End If
        Return sQlconexion
    End Function
    Public Function Conectar3(Optional ByVal Modulo As String = "Lector") As SqlConnection
        'Dim strConexion As String
        If sQlconexion.State <> ConnectionState.Open Then
            SQLStringConexion = GetSetting("SeeSoft", Modulo, "CONEXION")
            sQlconexion.ConnectionString = SQLStringConexion
            sQlconexion.Open()
        Else
        End If
        Return sQlconexion
    End Function

    Public Sub DesConectar(ByRef sqlConexion As SqlConnection)
        sqlConexion.Close()
        sqlConexion.Dispose()
    End Sub
    Public Sub BeginTrans(ByRef sqlConexion As SqlConnection)
        sqlConexion.BeginTransaction()
    End Sub
    Public Sub ConTrans(ByRef sqlConexion As SqlConnection)
        sqlConexion.BeginTransaction.Commit()
    End Sub
    Public Sub RollBack(ByRef sqlConexion As SqlConnection)
        sqlConexion.BeginTransaction.Rollback()
    End Sub
    ' DEVUELVE EL DataReader DE LA CONSULTA
    Public Function GetRecorset(ByRef conexion As SqlConnection, ByVal StrQuery As String) As SqlDataReader
        Dim Command As SqlCommand
        Dim SqlDatos As SqlDataReader
        Dim Mensaje As String
        Try
            Command = New SqlCommand(StrQuery, conexion)
            SqlDatos = Command.ExecuteReader
        Catch ex As Exception
            Mensaje = ex.Message
            MsgBox(Mensaje, MsgBoxStyle.Critical, "Alerta..")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return SqlDatos
    End Function
    'DEVUELVE  EL RESULTADO DE LA CONSULTA
    Public Function SlqExecuteScalar(ByRef Conexion As SqlConnection, ByVal StrQuery As String) As String
        Dim Command As SqlCommand
        Dim Dato As String
        Dim Mensaje As String
        Command = New SqlCommand(StrQuery, Conexion)
        Try
            Dato = Command.ExecuteScalar()
        Catch ex As Exception
            Mensaje = ex.Message
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Dato
    End Function
    Public Sub GetDataSet(ByRef conexion As SqlConnection, ByVal StrQuery As String, ByRef DataS As DataSet, ByVal tabla As String)
        Dim mensaje As String
        Dim adapter As New SqlDataAdapter(StrQuery, conexion)
        If conexion.State <> ConnectionState.Open Then conexion.Open()
        Try
            adapter.Fill(DataS, tabla)
        Catch ex As Exception
            mensaje = ex.Message
        Finally
            adapter.Dispose()
            adapter = Nothing
        End Try
    End Sub
    Public Function SQLExeScalar(ByVal StrQuery As String) As String
        Dim Command As SqlCommand
        Dim Dato As String
        Dim Mensaje As String
        Command = New SqlCommand(StrQuery, Conectar)
        Try
            Dato = Command.ExecuteScalar
        Catch ex As Exception
            Mensaje = ex.Message
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Dato
    End Function
    Public Function SlqExecute(ByRef conexion As SqlConnection, ByVal strQuery As String) As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        Command = New SqlCommand(strQuery, conexion)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Mensaje
    End Function

    Public Function AddNewRecord(ByRef Table As Object, ByRef Campos As Object, ByRef Datos As Object) As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        Command = New SqlCommand("INSERT INTO " & Table & " (" & Campos & ") VALUES (" & Datos & ")", Conectar)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Mensaje
    End Function
    '*******************************************************************
    'FUNCION QUE PERMITE LA ACTUALIZACION DE REGISTROS SEGUN DETERMINADA
    '*******************************************************************
    Public Function UpdateRecords(ByRef Table As Object, ByRef Datos As Object, ByRef Condicion As Object) As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        If Condicion <> "" Then
            Command = New SqlCommand("UPDATE " & Table & " SET " & Datos & " WHERE " & Condicion, Conectar)
        Else
            Command = New SqlCommand("UPDATE " & Table & " SET " & Datos, Conectar)
        End If
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Mensaje
    End Function
    '*******************************************************************
    'FUNCION DEFINIDA PARA LA ELIMINACION DE UNO O VARIOS REGISTROS 
    '*******************************************************************
    Public Function DeleteRecords(ByRef Table As String, ByRef Condicion As Object) As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        If Condicion = "" Then
            Command = New SqlCommand("DELETE FROM " & Table, Conectar)
        Else
            Command = New SqlCommand("DELETE FROM " & Table & " WHERE " & Condicion, Conectar)
        End If
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Mensaje
    End Function
    Public Function Cargar(ByVal sql As String, ByVal Modulo As String) As DataSet
        datos.Clear()
        adaptador = Nothing
        Dim s As String
        s = GetSetting("SeeSoft", Modulo, "CONEXION")
        Try
            Me.sQlconexion = New SqlConnection(s)
            sQlconexion.Open()
            adaptador = New SqlDataAdapter(sql, sQlconexion)
            datos = New DataSet
            adaptador.Fill(datos)
            adaptador.Update(datos)
            adaptador.Dispose()
            sQlconexion.Close()

        Catch e As Exception
            MsgBox(e.ToString)
            datos = Nothing
        Finally
        End Try
        Return datos
    End Function
    Function ds(ByVal consulta As String) As DataSet
        Dim mensaje As String
        Dim s As String
        s = GetSetting("SeeSoft", "Lector", "CONEXION")
        Me.sQlconexion = New SqlConnection(s)
        Dim datas As New DataSet
        Try
            Dim adapter As New SqlDataAdapter(consulta, Me.sQlconexion)
            If Me.sQlconexion.State <> ConnectionState.Open Then Me.sQlconexion.Open()
            Try
                adapter.Fill(datas, "Check1")
            Catch ex As Exception
                mensaje = ex.Message
            Finally
                adapter.Dispose()
                adapter = Nothing
            End Try
        Catch ex As Exception
            MsgBox(EX.Message)
        End Try

        Return datas
    End Function
    Function ds1(ByVal consulta As String) As DataSet
        Dim mensaje As String
        Dim s As String
        s = GetSetting("SeeSoft", "Planilla", "CONEXION")
        Me.sQlconexion = New SqlConnection(s)
        Dim datas As New DataSet
        Try
            Dim adapter As New SqlDataAdapter(consulta, Me.sQlconexion)
            If Me.sQlconexion.State <> ConnectionState.Open Then Me.sQlconexion.Open()
            Try
                adapter.Fill(datas, "VistaVacaciones")
            Catch ex As Exception
                mensaje = ex.Message
            Finally
                adapter.Dispose()
                adapter = Nothing
            End Try
        Catch ex As Exception
            MsgBox(EX.Message)
        End Try

        Return datas
    End Function
End Class

