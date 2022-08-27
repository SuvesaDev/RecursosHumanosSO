Public Class frmAguinaldo
    Private Function Conexion() As String
        Return GetSetting("SeeSoft", "Planilla", "Conexion")
    End Function

    Private Sub MostrarAguinaldo()
        Me.viewDatos.Rows.Clear()
        If Me.ExisteAguinaldo Then
            'si ya se guardo lo carga
            Me.CargarAguinaldo()
        Else
            'si no hay datos los calcula
            Me.CalcularAguinaldo()
        End If
    End Sub

    Private Sub GuardarAguinaldo()

        Dim db As New OBSoluciones.SQL.Sentencias(Me.Conexion)
        db.Ejecutar("Delete from Aguinaldo Where Annyo = " & Me.txtAnnyo.Value, CommandType.Text)

        For Each r As DataGridViewRow In Me.viewDatos.Rows
            db.AddParametro("@Annyo", Me.txtAnnyo.Value)
            db.AddParametro("@Nombre", r.Cells("cNombre").Value)
            db.AddParametro("@Dic", r.Cells("cDic").Value)
            db.AddParametro("@Ene", r.Cells("cEne").Value)
            db.AddParametro("@Feb", r.Cells("cFeb").Value)
            db.AddParametro("@Mar", r.Cells("cMar").Value)
            db.AddParametro("@Abr", r.Cells("cAbr").Value)
            db.AddParametro("@May", r.Cells("cMay").Value)
            db.AddParametro("@Jun", r.Cells("cJun").Value)
            db.AddParametro("@Jul", r.Cells("cJul").Value)
            db.AddParametro("@Ago", r.Cells("cAgo").Value)
            db.AddParametro("@Sep", r.Cells("cSep").Value)
            db.AddParametro("@Oct", r.Cells("cOct").Value)
            db.AddParametro("@Nov", r.Cells("cNov").Value)
            db.AddParametro("@Total", r.Cells("cTotal").Value)
            db.Ejecutar("Insert into Aguinaldo(Annyo,Nombre,Dic,Ene,Feb,Mar,Abr,May,Jun,Jul,Ago,Sep,Oct,Nov,Total) Values(@Annyo,@Nombre,@Dic,@Ene,@Feb,@Mar,@Abr,@May,@Jun,@Jul,@Ago,@Sep,@Oct,@Nov,@Total)", CommandType.Text)
        Next

    End Sub

    Private Function ExisteAguinaldo() As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from Aguinaldo Where Annyo = " & Me.txtAnnyo.Value, dt, Me.Conexion)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CargarAguinaldo()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from Aguinaldo Where Annyo = " & Me.txtAnnyo.Value, dt, Me.Conexion)
        If dt.Rows.Count > 0 Then

            Dim Index As Integer = 0
            For Each r As DataRow In dt.Rows
                Me.viewDatos.Rows.Add()
                Me.viewDatos.Item("cNombre", Index).Value = r.Item("nombre")
                Me.viewDatos.Item("cDic", Index).Value = r.Item("dic")
                Me.viewDatos.Item("cEne", Index).Value = r.Item("ene")
                Me.viewDatos.Item("cFeb", Index).Value = r.Item("feb")
                Me.viewDatos.Item("cMar", Index).Value = r.Item("mar")
                Me.viewDatos.Item("cAbr", Index).Value = r.Item("abr")
                Me.viewDatos.Item("cMay", Index).Value = r.Item("may")
                Me.viewDatos.Item("cJun", Index).Value = r.Item("jun")
                Me.viewDatos.Item("cJul", Index).Value = r.Item("jul")
                Me.viewDatos.Item("cAgo", Index).Value = r.Item("ago")
                Me.viewDatos.Item("cSep", Index).Value = r.Item("sep")
                Me.viewDatos.Item("cOct", Index).Value = r.Item("Oct")
                Me.viewDatos.Item("cNov", Index).Value = r.Item("nov")
                Me.viewDatos.Item("cTotal", Index).Value = r.Item("total")
                Index += 1
            Next

        End If
    End Sub

    Private Sub CalcularAguinaldo()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("exec spGeneraAguinaldo " & Me.txtAnnyo.Value, dt, Me.Conexion)
        If dt.Rows.Count > 0 Then

            Dim nombre As New System.Collections.Generic.List(Of String)
            nombre = (From x As DataRow In dt.Rows
                      Select CStr(x.Item("Nombre"))).ToList

            Dim Index As Integer = 0
            For Each nom As String In nombre.Distinct

                Dim dic, ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, total As Decimal
                dic = (From x As DataRow In dt.Rows
                       Where x.Item("Nombre") = nom And x.Item("mes") = 12
                       Select x.Item("SalarioBruto")).FirstOrDefault
                ene = (From x As DataRow In dt.Rows
                       Where x.Item("Nombre") = nom And x.Item("mes") = 1
                       Select x.Item("SalarioBruto")).FirstOrDefault
                feb = (From x As DataRow In dt.Rows
                       Where x.Item("Nombre") = nom And x.Item("mes") = 2
                       Select x.Item("SalarioBruto")).FirstOrDefault
                mar = (From x As DataRow In dt.Rows
                       Where x.Item("Nombre") = nom And x.Item("mes") = 3
                       Select x.Item("SalarioBruto")).FirstOrDefault
                abr = (From x As DataRow In dt.Rows
                       Where x.Item("Nombre") = nom And x.Item("mes") = 4
                       Select x.Item("SalarioBruto")).FirstOrDefault
                may = (From x As DataRow In dt.Rows
                       Where x.Item("Nombre") = nom And x.Item("mes") = 5
                       Select x.Item("SalarioBruto")).FirstOrDefault
                jun = (From x As DataRow In dt.Rows
                       Where x.Item("Nombre") = nom And x.Item("mes") = 6
                       Select x.Item("SalarioBruto")).FirstOrDefault
                jul = (From x As DataRow In dt.Rows
                       Where x.Item("Nombre") = nom And x.Item("mes") = 7
                       Select x.Item("SalarioBruto")).FirstOrDefault
                ago = (From x As DataRow In dt.Rows
                       Where x.Item("Nombre") = nom And x.Item("mes") = 8
                       Select x.Item("SalarioBruto")).FirstOrDefault
                sep = (From x As DataRow In dt.Rows
                       Where x.Item("Nombre") = nom And x.Item("mes") = 9
                       Select x.Item("SalarioBruto")).FirstOrDefault
                oct = (From x As DataRow In dt.Rows
                       Where x.Item("Nombre") = nom And x.Item("mes") = 10
                       Select x.Item("SalarioBruto")).FirstOrDefault
                nov = (From x As DataRow In dt.Rows
                       Where x.Item("Nombre") = nom And x.Item("mes") = 11
                       Select x.Item("SalarioBruto")).FirstOrDefault
                total = dic + ene + feb + mar + abr + may + jun + jul + ago + sep + oct + nov

                Me.viewDatos.Rows.Add()
                Me.viewDatos.Item("cNombre", Index).Value = nom
                Me.viewDatos.Item("cDic", Index).Value = dic
                Me.viewDatos.Item("cEne", Index).Value = ene
                Me.viewDatos.Item("cFeb", Index).Value = feb
                Me.viewDatos.Item("cMar", Index).Value = mar
                Me.viewDatos.Item("cAbr", Index).Value = abr
                Me.viewDatos.Item("cMay", Index).Value = may
                Me.viewDatos.Item("cJun", Index).Value = jun
                Me.viewDatos.Item("cJul", Index).Value = jul
                Me.viewDatos.Item("cAgo", Index).Value = ago
                Me.viewDatos.Item("cSep", Index).Value = sep
                Me.viewDatos.Item("cOct", Index).Value = oct
                Me.viewDatos.Item("cNov", Index).Value = nov
                Me.viewDatos.Item("cTotal", Index).Value = (total / 12)
                Index += 1
            Next

        End If
    End Sub


    Private Sub frmAguinaldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtAnnyo.Value = Date.Now.Year
    End Sub

    Private Sub btnCalcularAguinaldos_Click(sender As Object, e As EventArgs) Handles btnCalcularAguinaldos.Click
        Me.MostrarAguinaldo()
    End Sub

    Private Sub viewDatos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellValueChanged
        On Error Resume Next

        Dim dic, ene, feb, mar, abr, may, jun, jul, ago, sep, oct, nov, total As Decimal
        dic = Me.viewDatos.Item("cDic", e.RowIndex).Value
        ene = Me.viewDatos.Item("cEne", e.RowIndex).Value
        feb = Me.viewDatos.Item("cFeb", e.RowIndex).Value
        mar = Me.viewDatos.Item("cMar", e.RowIndex).Value
        abr = Me.viewDatos.Item("cAbr", e.RowIndex).Value
        may = Me.viewDatos.Item("cMay", e.RowIndex).Value
        jun = Me.viewDatos.Item("cJun", e.RowIndex).Value
        jul = Me.viewDatos.Item("cJul", e.RowIndex).Value
        ago = Me.viewDatos.Item("cAgo", e.RowIndex).Value
        sep = Me.viewDatos.Item("cSep", e.RowIndex).Value
        oct = Me.viewDatos.Item("cOct", e.RowIndex).Value
        nov = Me.viewDatos.Item("cNov", e.RowIndex).Value
        total = dic + ene + feb + mar + abr + may + jun + jul + ago + sep + oct + nov

        Me.viewDatos.Item("cTotal", e.RowIndex).Value = total / 12

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.GuardarAguinaldo()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim Imprimir As New rptAguinaldo
        Dim visor As New frmVisorReportes
        Imprimir.SetParameterValue(0, Me.txtAnnyo.Value)
        visor.rptViewer.ReportSource = Imprimir
        Planilla.CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Imprimir)
        visor.Show()
    End Sub
End Class

