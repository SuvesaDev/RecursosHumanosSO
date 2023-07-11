Imports System.Data
Public Class SaldoVacaciones

    Private Function CadenaConexionPlanilla() As String
        Return GetSetting("SeeSOFT", "Planilla", "Conexion")
    End Function

    Public Function MesAcumulado(_Identificacion As String, _Corte As DateTime) As Double
        Dim Meses As Double = 0
        Dim dt As New DataTable
        Try
            cFunciones.Llenar_Tabla_Generico("select Fecha_Ingreso from empleado where Identificacion = '" & _Identificacion & "'", dt, CadenaConexionPlanilla)
            If dt.Rows.Count > 0 Then
                Dim FechaIngreso As Date = dt.Rows(0).Item("Fecha_Ingreso")
                Dim DiaIngreso As Integer = CInt(FechaIngreso.ToShortDateString.Split("/")(0))
                Dim Temp As Date = FechaIngreso

                While Temp < CDate(_Corte.ToShortDateString)
                    Temp = Temp.AddDays(1)
                    If CInt(Temp.ToShortDateString.Split("/")(0)) = DiaIngreso Then
                        Meses += 1
                    End If
                End While
            End If
        Catch ex As Exception
        End Try
        Return Meses
    End Function


    Public Function GenerarMesesAcumulados(_Corte As Date) As Boolean
        Dim db As OBSoluciones.SQL.Sentencias
        Dim dt As New DataTable
        Dim Acumulado As Integer = 0
        cFunciones.Llenar_Tabla_Generico("select Identificacion from Empleado where Cod_Estado = 1 and ServiciosProf = 0", dt, CadenaConexionPlanilla)
        If dt.Rows.Count > 0 Then
            db = New OBSoluciones.SQL.Sentencias(CadenaConexionPlanilla)
            Try
                db.Ejecutar("Update Empleado set Acumulado = 0", CommandType.Text)
                For Each row As DataRow In dt.Rows
                    Acumulado = Me.MesAcumulado(row.Item("Identificacion"), _Corte)
                    db.Ejecutar("Update Empleado set Acumulado = " & Acumulado & " Where Identificacion = '" & row.Item("Identificacion") & "'", CommandType.Text)
                Next
                Return True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Return False
            End Try
        End If
    End Function

End Class
