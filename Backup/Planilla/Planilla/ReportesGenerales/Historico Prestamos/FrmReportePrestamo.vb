Imports DevExpress.Utils

Public Class FrmHistoricoPrestamo
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
    Friend WithEvents BMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtNumeroPrestamo As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmHistoricoPrestamo))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.txtNumeroPrestamo = New DevExpress.XtraEditors.TextEdit
        Me.Panel1.SuspendLayout()
        CType(Me.txtNumeroPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.txtNumeroPrestamo)
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
        Me.BMostrar.Location = New System.Drawing.Point(488, 8)
        Me.BMostrar.Name = "BMostrar"
        Me.BMostrar.Size = New System.Drawing.Size(104, 56)
        Me.BMostrar.TabIndex = 25
        Me.BMostrar.Text = "Mostrar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(48, 48)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(352, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Número Prestamo"
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
        'txtNumeroPrestamo
        '
        Me.txtNumeroPrestamo.EditValue = 0
        Me.txtNumeroPrestamo.Location = New System.Drawing.Point(352, 32)
        Me.txtNumeroPrestamo.Name = "txtNumeroPrestamo"
        '
        'txtNumeroPrestamo.Properties
        '
        Me.txtNumeroPrestamo.Properties.DisplayFormat.FormatString = "0"
        Me.txtNumeroPrestamo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumeroPrestamo.Properties.EditFormat.FormatString = "0"
        Me.txtNumeroPrestamo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNumeroPrestamo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumeroPrestamo.Size = New System.Drawing.Size(112, 19)
        Me.txtNumeroPrestamo.TabIndex = 0
        '
        'FrmHistoricoPrestamo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1032, 585)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmHistoricoPrestamo"
        Me.Text = "Reportes de Historicos de Prestamos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.txtNumeroPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim Wait As WaitDialogForm
#End Region

#Region "Load"
    Private Sub FrmRepHistoricos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNumeroPrestamo.Focus()
    End Sub
#End Region

#Region "Mostrar"
    Private Sub Mostrar()
        Try
            If txtNumeroPrestamo.Text <> "" Then
                BMostrar.Enabled = False
                Wait = New WaitDialogForm("Cargando Reporte de Prestamo")

                '-----------------------------------------------------------------------------
                'CARGA REPORTE - ORA
                Dim Reporte As New rptPrestamo
                Reporte.SetParameterValue(0, CInt(txtNumeroPrestamo.Text))
                CrystalReportsConexion.LoadReportViewer(CrystalReportViewer2, Reporte, False)
                CrystalReportViewer2.Show()
                '-----------------------------------------------------------------------------
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Wait.Close()
            BMostrar.Enabled = True
        End Try
    End Sub
#End Region

#Region "Funciones Controles"
    Private Sub txtNumeroPrestamo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumeroPrestamo.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                Dim Fx As New cFunciones
                Dim Id As Integer
                Id = Fx.BuscarDatos("SELECT Numero, Nombre FROM Adelantos where Prestamo = 1", "Nombre", "Buscar Prestamo...", "", 0, "Order By Numero Desc")

                If Id <> 0 Then
                    txtNumeroPrestamo.Text = Id
                Else
                    MsgBox("No se selecciono ningún Prestamo", MsgBoxStyle.Information)
                End If
            End If

            If e.KeyCode = Keys.Enter Then
                BMostrar.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtNumeroPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroPrestamo.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

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

