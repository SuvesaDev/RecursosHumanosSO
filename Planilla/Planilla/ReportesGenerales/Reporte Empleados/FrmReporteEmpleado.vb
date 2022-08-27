Public Class FrmReporteEmpleado
    Inherits System.Windows.Forms.Form

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

    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RB_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Planilla As System.Windows.Forms.RadioButton
    Friend WithEvents BMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RB_ServProf As System.Windows.Forms.RadioButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Check_Agrupado As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmReporteEmpleado))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.RB_Todos = New System.Windows.Forms.RadioButton
        Me.RB_Planilla = New System.Windows.Forms.RadioButton
        Me.RB_ServProf = New System.Windows.Forms.RadioButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Check_Agrupado = New System.Windows.Forms.CheckBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Check_Agrupado)
        Me.Panel1.Controls.Add(Me.RB_ServProf)
        Me.Panel1.Controls.Add(Me.RB_Planilla)
        Me.Panel1.Controls.Add(Me.RB_Todos)
        Me.Panel1.Controls.Add(Me.BMostrar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1032, 72)
        Me.Panel1.TabIndex = 3
        '
        'BMostrar
        '
        Me.BMostrar.ImageIndex = 0
        Me.BMostrar.ImageList = Me.ImageList1
        Me.BMostrar.Location = New System.Drawing.Point(688, 8)
        Me.BMostrar.Name = "BMostrar"
        Me.BMostrar.Size = New System.Drawing.Size(104, 56)
        Me.BMostrar.TabIndex = 25
        Me.BMostrar.Text = "Mostrar"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(216, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Mostrar Empleados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.CrystalReportViewer2.ShowPageNavigateButtons = False
        Me.CrystalReportViewer2.ShowRefreshButton = False
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1028, 684)
        Me.CrystalReportViewer2.TabIndex = 4
        '
        'RB_Todos
        '
        Me.RB_Todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Todos.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RB_Todos.Location = New System.Drawing.Point(216, 32)
        Me.RB_Todos.Name = "RB_Todos"
        Me.RB_Todos.Size = New System.Drawing.Size(64, 24)
        Me.RB_Todos.TabIndex = 26
        Me.RB_Todos.Text = "Todos"
        '
        'RB_Planilla
        '
        Me.RB_Planilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Planilla.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RB_Planilla.Location = New System.Drawing.Point(280, 32)
        Me.RB_Planilla.Name = "RB_Planilla"
        Me.RB_Planilla.Size = New System.Drawing.Size(64, 24)
        Me.RB_Planilla.TabIndex = 27
        Me.RB_Planilla.Text = "Planilla"
        '
        'RB_ServProf
        '
        Me.RB_ServProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_ServProf.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RB_ServProf.Location = New System.Drawing.Point(344, 32)
        Me.RB_ServProf.Name = "RB_ServProf"
        Me.RB_ServProf.Size = New System.Drawing.Size(128, 24)
        Me.RB_ServProf.TabIndex = 28
        Me.RB_ServProf.Text = "Serv. Profesionales"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(48, 48)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Check_Agrupado
        '
        Me.Check_Agrupado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Agrupado.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Check_Agrupado.Location = New System.Drawing.Point(496, 32)
        Me.Check_Agrupado.Name = "Check_Agrupado"
        Me.Check_Agrupado.Size = New System.Drawing.Size(176, 16)
        Me.Check_Agrupado.TabIndex = 29
        Me.Check_Agrupado.Text = "Agrupado por Departamento"
        '
        'FrmReporteEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1032, 585)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmReporteEmpleado"
        Me.Text = "Reportes de Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim Reporte_Empleados As New CrystalDecisions.CrystalReports.Engine.ReportDocument
#End Region

#Region "Load"
    Private Sub FrmRepHistoricos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RB_Todos.Checked = True
        BMostrar.Focus()
    End Sub
#End Region

#Region "Mostrar"
    Private Sub Mostrar()
        Try
            '----------------------------------------------------------------------------
            'VERIFICA QUE TIPO DE REPORTE SE VA A MOSTRAR - ORA
            If Check_Agrupado.Checked Then
                Dim Reporte_Agrupado As New EmpleadosporDepartamento
                Reporte_Empleados = Reporte_Agrupado
            Else
                Dim Reporte_SinAgrupar As New TodosEmpleados
                Reporte_Empleados = Reporte_SinAgrupar
            End If
            '----------------------------------------------------------------------------

            '----------------------------------------------------------------------------
            'VERIFICA QUE EMPLEADOS VA A MOSTRAR - ORA
            If RB_Planilla.Checked Then
                Reporte_Empleados.RecordSelectionFormula = "{Empleado.Cod_Estado} = 1 AND not {Empleado.ServiciosProf}"
            ElseIf RB_ServProf.Checked Then
                Reporte_Empleados.RecordSelectionFormula = "{Empleado.Cod_Estado} = 1 AND {Empleado.ServiciosProf}"
            Else
                Reporte_Empleados.RecordSelectionFormula = "{Empleado.Cod_Estado} = 1"
            End If
            '----------------------------------------------------------------------------

            CrystalReportsConexion.LoadReportViewer(CrystalReportViewer2, Reporte_Empleados, False)
            CrystalReportViewer2.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Funciones Controles"
    Private Sub SimpleButton1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BMostrar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Mostrar()
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMostrar.Click
        Mostrar()
    End Sub
#End Region

End Class

