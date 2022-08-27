Public Class FrmIngresosEmpleados
    Inherits System.Windows.Forms.Form

    Public tipo As Boolean
    Dim adapter As System.Data.SqlClient.SqlDataAdapter
    Dim ds As New DataSet

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents DTP_fechainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_fechafinal As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DTP_fechafinal = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinal = New System.Windows.Forms.Label
        Me.DTP_fechainicio = New System.Windows.Forms.DateTimePicker
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.lblFechaInicio = New System.Windows.Forms.Label
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.DTP_fechafinal)
        Me.Panel1.Controls.Add(Me.lblFechaFinal)
        Me.Panel1.Controls.Add(Me.DTP_fechainicio)
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.lblFechaInicio)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1032, 72)
        Me.Panel1.TabIndex = 3
        '
        'DTP_fechafinal
        '
        Me.DTP_fechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTP_fechafinal.Location = New System.Drawing.Point(176, 24)
        Me.DTP_fechafinal.Name = "DTP_fechafinal"
        Me.DTP_fechafinal.Size = New System.Drawing.Size(112, 20)
        Me.DTP_fechafinal.TabIndex = 28
        Me.DTP_fechafinal.Value = New Date(2009, 2, 18, 0, 0, 0, 0)
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(176, 8)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.TabIndex = 29
        Me.lblFechaFinal.Text = "Fecha Final"
        '
        'DTP_fechainicio
        '
        Me.DTP_fechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTP_fechainicio.Location = New System.Drawing.Point(32, 24)
        Me.DTP_fechainicio.Name = "DTP_fechainicio"
        Me.DTP_fechainicio.Size = New System.Drawing.Size(112, 20)
        Me.DTP_fechainicio.TabIndex = 26
        Me.DTP_fechainicio.Value = New Date(2009, 2, 18, 0, 0, 0, 0)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(488, 32)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.TabIndex = 25
        Me.SimpleButton1.Text = "Mostrar"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(32, 8)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.TabIndex = 27
        Me.lblFechaInicio.Text = "Fecha Inicio"
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer2.DisplayGroupTree = False
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(0, 72)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.ReportSource = Nothing
        Me.CrystalReportViewer2.ShowCloseButton = False
        Me.CrystalReportViewer2.ShowGotoPageButton = False
        Me.CrystalReportViewer2.ShowGroupTreeButton = False
        Me.CrystalReportViewer2.ShowRefreshButton = False
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1028, 504)
        Me.CrystalReportViewer2.TabIndex = 4
        '
        'FrmIngresosEmpleados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1032, 585)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmIngresosEmpleados"
        Me.Text = "Centro Gastos por Empleado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub FrmRepHistoricos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTP_fechainicio.Value = Now.Date
        DTP_fechafinal.Value = Now.Date
    End Sub
#End Region

#Region "Mostrar"
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            Dim Fecha_inicio, Fecha_final As Date
            Dim Reporte_IngresosEmpleados As New rptCentroGastos

            Fecha_inicio = FormatDateTime(DTP_fechainicio.Text, DateFormat.ShortDate)
            Fecha_final = FormatDateTime(DTP_fechafinal.Text, DateFormat.ShortDate)
            Reporte_IngresosEmpleados.SetParameterValue(0, Fecha_inicio)
            Reporte_IngresosEmpleados.SetParameterValue(1, Fecha_final)
            CrystalReportsConexion.LoadReportViewer(CrystalReportViewer2, Reporte_IngresosEmpleados, False)
            CrystalReportViewer2.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region



End Class
