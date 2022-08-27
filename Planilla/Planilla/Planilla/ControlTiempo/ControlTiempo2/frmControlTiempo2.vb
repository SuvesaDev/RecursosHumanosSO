Imports System.data.SqlClient
Imports utilidades

Public Class frmControlTiempo2
    Inherits FrmPlantilla
    Public TablaPlanilla As New DataTable
    Dim logeado As Boolean
    Dim Cedula_usuario As String
    Dim NombreUsuario As String
    Dim Id As Long
    Public Shared FechaI As String
    Public Shared FechaF As String
    Public Shared IdPlanilla As Integer 'psv
    Public Shared Rept As String
    Public TablaRenta1, TablaRenta As New DataTable
    Dim Pagomes As Double
    Dim Cedula As String
    Dim nombre As String
    Dim NumeroPlanilla1 As String
    Dim Codigo As String
    Public Shared contex, IdPlanilla1 As Integer
    Public Shared Id_Empleado As String
    Dim usua As Object
    Public num As Integer
    Dim DataView As New DataView



#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        usua = Usuario_Parametro
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckCierreMes As System.Windows.Forms.CheckBox
    Friend WithEvents CheckAnulado As System.Windows.Forms.CheckBox
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsProyecto As Planilla.DsProyecto
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adPlanillaDeducciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adPlanillaDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adEmpleados As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adDeducciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adAdelantos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adRenta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adEmpleadoDeducciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents HorasTrabajadas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand11 As System.Data.SqlClient.SqlCommand

    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents adPlanilla As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adAccion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdAdelanto_Detalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsPlanilla1 As Planilla.dsPlanilla
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAccionPersonal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId_Empleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents dtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdOrdinarias As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents btnFormaPago As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.DsPlanilla1 = New Planilla.dsPlanilla
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckCierreMes = New System.Windows.Forms.CheckBox
        Me.CheckAnulado = New System.Windows.Forms.CheckBox
        Me.DsProyecto = New Planilla.DsProyecto
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.adPlanillaDeducciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.adPlanillaDetalle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.adEmpleados = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.adDeducciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.adAdelantos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.adRenta = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        Me.adEmpleadoDeducciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand10 = New System.Data.SqlClient.SqlCommand
        Me.HorasTrabajadas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand11 = New System.Data.SqlClient.SqlCommand
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.adPlanilla = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.adAccion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.adMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand12 = New System.Data.SqlClient.SqlCommand
        Me.AdAdelanto_Detalle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand9 = New System.Data.SqlClient.SqlCommand
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId_Empleado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Button2 = New System.Windows.Forms.Button
        Me.colAccionPersonal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.AdOrdinarias = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand13 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand13 = New System.Data.SqlClient.SqlCommand
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.btnFormaPago = New System.Windows.Forms.Button
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(930, 32)
        Me.TituloModulo.Text = "Pago de Planilla"
        '
        'ToolBarEditar
        '
        Me.ToolBarEditar.Visible = False
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 440)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(930, 72)
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(16, 88)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(896, 352)
        Me.GridControl1.Styles.AddReplace("Preview", New DevExpress.Utils.ViewStyleEx("Preview", "Grid", New System.Drawing.Font("Tahoma", 10.0!), "", True, True, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Top, Nothing, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(10, Byte), CType(36, Byte), CType(106, Byte)), System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FooterPanel", New DevExpress.Utils.ViewStyleEx("FooterPanel", "Grid", New System.Drawing.Font("Tahoma", 10.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupButton", New DevExpress.Utils.ViewStyleEx("GroupButton", "Grid", New System.Drawing.Font("Tahoma", 10.0!), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FilterCloseButton", New DevExpress.Utils.ViewStyleEx("FilterCloseButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(118, Byte), CType(170, Byte), CType(225, Byte)), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("EvenRow", New DevExpress.Utils.ViewStyleEx("EvenRow", "Grid", New System.Drawing.Font("Tahoma", 10.0!), CType((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.GhostWhite, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("HideSelectionRow", New DevExpress.Utils.ViewStyleEx("HideSelectionRow", "Grid", New System.Drawing.Font("Tahoma", 10.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FixedLine", New DevExpress.Utils.ViewStyleEx("FixedLine", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(58, Byte), CType(58, Byte), CType(58, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("HeaderPanel", New DevExpress.Utils.ViewStyleEx("HeaderPanel", "Grid", New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupPanel", New DevExpress.Utils.ViewStyleEx("GroupPanel", "Grid", New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(58, Byte), CType(110, Byte), CType(165, Byte)), System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("Empty", New DevExpress.Utils.ViewStyleEx("Empty", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(232, Byte), CType(228, Byte), CType(220, Byte)), System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupFooter", New DevExpress.Utils.ViewStyleEx("GroupFooter", "Grid", New System.Drawing.Font("Tahoma", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(222, Byte), CType(218, Byte), CType(210, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupRow", New DevExpress.Utils.ViewStyleEx("GroupRow", "Grid", New System.Drawing.Font("Tahoma", 10.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("HorzLine", New DevExpress.Utils.ViewStyleEx("HorzLine", "Grid", New System.Drawing.Font("Tahoma", 10.0!), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Gray, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButton", New DevExpress.Utils.ViewStyleEx("ColumnFilterButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(232, Byte), CType(228, Byte), CType(220, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FocusedRow", New DevExpress.Utils.ViewStyleEx("FocusedRow", "Grid", New System.Drawing.Font("Tahoma", 10.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(10, Byte), CType(36, Byte), CType(106, Byte)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(60, Byte), CType(86, Byte), CType(156, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("VertLine", New DevExpress.Utils.ViewStyleEx("VertLine", "Grid", New System.Drawing.Font("Tahoma", 10.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Gray, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FocusedCell", New DevExpress.Utils.ViewStyleEx("FocusedCell", "Grid", New System.Drawing.Font("Tahoma", 10.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(225, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("OddRow", New DevExpress.Utils.ViewStyleEx("OddRow", "Grid", New System.Drawing.Font("Tahoma", 10.0!), CType((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor), DevExpress.Utils.StyleOptions), System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal))
        Me.GridControl1.Styles.AddReplace("SelectedRow", New DevExpress.Utils.ViewStyleEx("SelectedRow", "Grid", New System.Drawing.Font("Tahoma", 10.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(20, Byte), CType(46, Byte), CType(116, Byte)), System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("Row", New DevExpress.Utils.ViewStyleEx("Row", "Grid", New System.Drawing.Font("Tahoma", 10.0!), DevExpress.Utils.StyleOptions.StyleEnabled, System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FilterPanel", New DevExpress.Utils.ViewStyleEx("FilterPanel", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(28, Byte), CType(80, Byte), CType(135, Byte)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("RowSeparator", New DevExpress.Utils.ViewStyleEx("RowSeparator", "Grid", New System.Drawing.Font("Arial", 8.0!), DevExpress.Utils.StyleOptions.StyleEnabled, System.Drawing.Color.White, System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(232, Byte), CType(228, Byte), CType(220, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.LightGray, System.Drawing.Color.Blue, System.Drawing.Color.WhiteSmoke, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("DetailTip", New DevExpress.Utils.ViewStyleEx("DetailTip", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(225, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 59
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.FixedLineWidth = 1
        Me.GridView1.GroupFormat = ""
        Me.GridView1.GroupPanelText = "C�lculos de Pago a Empleados"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Location = New System.Drawing.Point(0, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 14)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "No. Planilla"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNumero
        '
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPlanilla1, "Planilla.Id_Planilla"))
        Me.txtNumero.ForeColor = System.Drawing.Color.Blue
        Me.txtNumero.Location = New System.Drawing.Point(72, 16)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(96, 13)
        Me.txtNumero.TabIndex = 61
        Me.txtNumero.Text = ""
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DsPlanilla1
        '
        Me.DsPlanilla1.DataSetName = "DsPlanilla1"
        Me.DsPlanilla1.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(232, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Fecha Inicio:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(232, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckCierreMes
        '
        Me.CheckCierreMes.BackColor = System.Drawing.Color.Transparent
        Me.CheckCierreMes.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPlanilla1, "Planilla.CierreMes"))
        Me.CheckCierreMes.Enabled = False
        Me.CheckCierreMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCierreMes.ForeColor = System.Drawing.Color.Blue
        Me.CheckCierreMes.Location = New System.Drawing.Point(464, 40)
        Me.CheckCierreMes.Name = "CheckCierreMes"
        Me.CheckCierreMes.Size = New System.Drawing.Size(88, 16)
        Me.CheckCierreMes.TabIndex = 174
        Me.CheckCierreMes.Text = "Cierre Mes"
        '
        'CheckAnulado
        '
        Me.CheckAnulado.BackColor = System.Drawing.Color.Transparent
        Me.CheckAnulado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPlanilla1, "Planilla.Anulado"))
        Me.CheckAnulado.Enabled = False
        Me.CheckAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAnulado.ForeColor = System.Drawing.Color.Red
        Me.CheckAnulado.Location = New System.Drawing.Point(464, 64)
        Me.CheckAnulado.Name = "CheckAnulado"
        Me.CheckAnulado.Size = New System.Drawing.Size(88, 16)
        Me.CheckAnulado.TabIndex = 176
        Me.CheckAnulado.Text = "Anulado"
        '
        'DsProyecto
        '
        Me.DsProyecto.DataSetName = "DsProyecto"
        Me.DsProyecto.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=;packet size=4096;integrated security=SSPI;data source=.;persist s" & _
        "ecurity info=False;initial catalog=Proyectos"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=PICHINGA;packet size=4096;integrated security=SSPI;data source=PIC" & _
        "HINGA;persist security info=False;initial catalog=Planilla"
        '
        'adPlanillaDeducciones
        '
        Me.adPlanillaDeducciones.DeleteCommand = Me.SqlDeleteCommand2
        Me.adPlanillaDeducciones.InsertCommand = Me.SqlInsertCommand2
        Me.adPlanillaDeducciones.SelectCommand = Me.SqlSelectCommand2
        Me.adPlanillaDeducciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Planilla_Deducciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_PlanillaDetalle", "Id_PlanillaDetalle"), New System.Data.Common.DataColumnMapping("Cod_Deduccion", "Cod_Deduccion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        Me.adPlanillaDeducciones.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Planilla_Deducciones WHERE (Id = @Original_Id) AND (Cod_Deduccion = @" & _
        "Original_Cod_Deduccion) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Id_Planilla" & _
        "Detalle = @Original_Id_PlanillaDetalle) AND (Monto = @Original_Monto) AND (Nombr" & _
        "e = @Original_Nombre)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Deduccion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Deduccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_PlanillaDetalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_PlanillaDetalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Planilla_Deducciones(Id_PlanillaDetalle, Cod_Deduccion, Nombre, Monto" & _
        ", Cod_Moneda) VALUES (@Id_PlanillaDetalle, @Cod_Deduccion, @Nombre, @Monto, @Cod" & _
        "_Moneda); SELECT Id, Id_PlanillaDetalle, Cod_Deduccion, Nombre, Monto, Cod_Moned" & _
        "a FROM Planilla_Deducciones WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_PlanillaDetalle", System.Data.SqlDbType.BigInt, 8, "Id_PlanillaDetalle"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Deduccion", System.Data.SqlDbType.Int, 4, "Cod_Deduccion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id, Id_PlanillaDetalle, Cod_Deduccion, Nombre, Monto, Cod_Moneda FROM Plan" & _
        "illa_Deducciones"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Planilla_Deducciones SET Id_PlanillaDetalle = @Id_PlanillaDetalle, Cod_Ded" & _
        "uccion = @Cod_Deduccion, Nombre = @Nombre, Monto = @Monto, Cod_Moneda = @Cod_Mon" & _
        "eda WHERE (Id = @Original_Id) AND (Cod_Deduccion = @Original_Cod_Deduccion) AND " & _
        "(Cod_Moneda = @Original_Cod_Moneda) AND (Id_PlanillaDetalle = @Original_Id_Plani" & _
        "llaDetalle) AND (Monto = @Original_Monto) AND (Nombre = @Original_Nombre); SELEC" & _
        "T Id, Id_PlanillaDetalle, Cod_Deduccion, Nombre, Monto, Cod_Moneda FROM Planilla" & _
        "_Deducciones WHERE (Id = @Id)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_PlanillaDetalle", System.Data.SqlDbType.BigInt, 8, "Id_PlanillaDetalle"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Deduccion", System.Data.SqlDbType.Int, 4, "Cod_Deduccion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Deduccion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Deduccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_PlanillaDetalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_PlanillaDetalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'adPlanillaDetalle
        '
        Me.adPlanillaDetalle.DeleteCommand = Me.SqlDeleteCommand3
        Me.adPlanillaDetalle.InsertCommand = Me.SqlInsertCommand3
        Me.adPlanillaDetalle.SelectCommand = Me.SqlSelectCommand3
        Me.adPlanillaDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Planilla_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_Planilla", "Id_Planilla"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("FormaPago", "FormaPago"), New System.Data.Common.DataColumnMapping("Ordinaria", "Ordinaria"), New System.Data.Common.DataColumnMapping("Extra", "Extra"), New System.Data.Common.DataColumnMapping("Doble", "Doble"), New System.Data.Common.DataColumnMapping("SalarioBruto", "SalarioBruto"), New System.Data.Common.DataColumnMapping("Adelantos", "Adelantos"), New System.Data.Common.DataColumnMapping("Prestamos", "Prestamos"), New System.Data.Common.DataColumnMapping("Renta", "Renta"), New System.Data.Common.DataColumnMapping("TotalDeducciones", "TotalDeducciones"), New System.Data.Common.DataColumnMapping("SalarioNeto", "SalarioNeto"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        Me.adPlanillaDetalle.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Planilla_Detalle WHERE (Id = @Original_Id) AND (Adelantos = @Original" & _
        "_Adelantos) AND (Cedula = @Original_Cedula) AND (Cod_Moneda = @Original_Cod_Mone" & _
        "da) AND (Doble = @Original_Doble) AND (Extra = @Original_Extra) AND (FormaPago =" & _
        " @Original_FormaPago) AND (Id_Planilla = @Original_Id_Planilla) AND (Nombre = @O" & _
        "riginal_Nombre) AND (Ordinaria = @Original_Ordinaria) AND (Prestamos = @Original" & _
        "_Prestamos) AND (Puesto = @Original_Puesto) AND (Renta = @Original_Renta) AND (S" & _
        "alario = @Original_Salario) AND (SalarioBruto = @Original_SalarioBruto) AND (Sal" & _
        "arioNeto = @Original_SalarioNeto) AND (TotalDeducciones = @Original_TotalDeducci" & _
        "ones)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Adelantos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adelantos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Doble", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Doble", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Extra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Extra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ordinaria", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ordinaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Prestamos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prestamos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Renta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Renta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioBruto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioBruto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioNeto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioNeto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDeducciones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDeducciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Planilla_Detalle(Id_Planilla, Cedula, Nombre, Puesto, Salario, FormaP" & _
        "ago, Ordinaria, Extra, Doble, SalarioBruto, Adelantos, Prestamos, Renta, TotalDe" & _
        "ducciones, SalarioNeto, Cod_Moneda) VALUES (@Id_Planilla, @Cedula, @Nombre, @Pue" & _
        "sto, @Salario, @FormaPago, @Ordinaria, @Extra, @Doble, @SalarioBruto, @Adelantos" & _
        ", @Prestamos, @Renta, @TotalDeducciones, @SalarioNeto, @Cod_Moneda); SELECT Id, " & _
        "Id_Planilla, Cedula, Nombre, Puesto, Salario, FormaPago, Ordinaria, Extra, Doble" & _
        ", SalarioBruto, Adelantos, Prestamos, Renta, TotalDeducciones, SalarioNeto, Cod_" & _
        "Moneda FROM Planilla_Detalle WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 8, "Id_Planilla"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 15, "FormaPago"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ordinaria", System.Data.SqlDbType.Float, 8, "Ordinaria"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Extra", System.Data.SqlDbType.Float, 8, "Extra"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Doble", System.Data.SqlDbType.Float, 8, "Doble"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioBruto", System.Data.SqlDbType.Float, 8, "SalarioBruto"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Adelantos", System.Data.SqlDbType.Float, 8, "Adelantos"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Prestamos", System.Data.SqlDbType.Float, 8, "Prestamos"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Renta", System.Data.SqlDbType.Float, 8, "Renta"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDeducciones", System.Data.SqlDbType.Float, 8, "TotalDeducciones"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioNeto", System.Data.SqlDbType.Float, 8, "SalarioNeto"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id, Id_Planilla, Cedula, Nombre, Puesto, Salario, FormaPago, Ordinaria, Ex" & _
        "tra, Doble, SalarioBruto, Adelantos, Prestamos, Renta, TotalDeducciones, Salario" & _
        "Neto, Cod_Moneda FROM Planilla_Detalle"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Planilla_Detalle SET Id_Planilla = @Id_Planilla, Cedula = @Cedula, Nombre " & _
        "= @Nombre, Puesto = @Puesto, Salario = @Salario, FormaPago = @FormaPago, Ordinar" & _
        "ia = @Ordinaria, Extra = @Extra, Doble = @Doble, SalarioBruto = @SalarioBruto, A" & _
        "delantos = @Adelantos, Prestamos = @Prestamos, Renta = @Renta, TotalDeducciones " & _
        "= @TotalDeducciones, SalarioNeto = @SalarioNeto, Cod_Moneda = @Cod_Moneda WHERE " & _
        "(Id = @Original_Id) AND (Adelantos = @Original_Adelantos) AND (Cedula = @Origina" & _
        "l_Cedula) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Doble = @Original_Doble) " & _
        "AND (Extra = @Original_Extra) AND (FormaPago = @Original_FormaPago) AND (Id_Plan" & _
        "illa = @Original_Id_Planilla) AND (Nombre = @Original_Nombre) AND (Ordinaria = @" & _
        "Original_Ordinaria) AND (Prestamos = @Original_Prestamos) AND (Puesto = @Origina" & _
        "l_Puesto) AND (Renta = @Original_Renta) AND (Salario = @Original_Salario) AND (S" & _
        "alarioBruto = @Original_SalarioBruto) AND (SalarioNeto = @Original_SalarioNeto) " & _
        "AND (TotalDeducciones = @Original_TotalDeducciones); SELECT Id, Id_Planilla, Ced" & _
        "ula, Nombre, Puesto, Salario, FormaPago, Ordinaria, Extra, Doble, SalarioBruto, " & _
        "Adelantos, Prestamos, Renta, TotalDeducciones, SalarioNeto, Cod_Moneda FROM Plan" & _
        "illa_Detalle WHERE (Id = @Id)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 8, "Id_Planilla"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 15, "FormaPago"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ordinaria", System.Data.SqlDbType.Float, 8, "Ordinaria"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Extra", System.Data.SqlDbType.Float, 8, "Extra"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Doble", System.Data.SqlDbType.Float, 8, "Doble"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioBruto", System.Data.SqlDbType.Float, 8, "SalarioBruto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Adelantos", System.Data.SqlDbType.Float, 8, "Adelantos"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Prestamos", System.Data.SqlDbType.Float, 8, "Prestamos"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Renta", System.Data.SqlDbType.Float, 8, "Renta"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDeducciones", System.Data.SqlDbType.Float, 8, "TotalDeducciones"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioNeto", System.Data.SqlDbType.Float, 8, "SalarioNeto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Adelantos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adelantos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Doble", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Doble", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Extra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Extra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ordinaria", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ordinaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Prestamos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prestamos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Renta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Renta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioBruto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioBruto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioNeto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioNeto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDeducciones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDeducciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'adEmpleados
        '
        Me.adEmpleados.DeleteCommand = Me.SqlDeleteCommand4
        Me.adEmpleados.InsertCommand = Me.SqlInsertCommand4
        Me.adEmpleados.SelectCommand = Me.SqlSelectCommand4
        Me.adEmpleados.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Estado_Civil", "Estado_Civil"), New System.Data.Common.DataColumnMapping("Hijos", "Hijos"), New System.Data.Common.DataColumnMapping("Cod_Nacionalidad", "Cod_Nacionalidad"), New System.Data.Common.DataColumnMapping("Fecha_Nacimiento", "Fecha_Nacimiento"), New System.Data.Common.DataColumnMapping("Edad", "Edad"), New System.Data.Common.DataColumnMapping("Telefono1", "Telefono1"), New System.Data.Common.DataColumnMapping("Telefono2", "Telefono2"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Fecha_Ingreso", "Fecha_Ingreso"), New System.Data.Common.DataColumnMapping("Fecha_Salida", "Fecha_Salida"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("Cod_Departamento", "Cod_Departamento"), New System.Data.Common.DataColumnMapping("Masculino", "Masculino"), New System.Data.Common.DataColumnMapping("Femenino", "Femenino"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Hora", "Hora"), New System.Data.Common.DataColumnMapping("Diario", "Diario"), New System.Data.Common.DataColumnMapping("Semana", "Semana"), New System.Data.Common.DataColumnMapping("Quincena", "Quincena"), New System.Data.Common.DataColumnMapping("Mensual", "Mensual"), New System.Data.Common.DataColumnMapping("Cod_Estado", "Cod_Estado"), New System.Data.Common.DataColumnMapping("Foto", "Foto")})})
        Me.adEmpleados.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Empleado WHERE (Identificacion = @Original_Identificacion) AND (Cod_D" & _
        "epartamento = @Original_Cod_Departamento) AND (Cod_Estado = @Original_Cod_Estado" & _
        ") AND (Cod_Moneda = @Original_Cod_Moneda) AND (Cod_Nacionalidad = @Original_Cod_" & _
        "Nacionalidad) AND (Diario = @Original_Diario) AND (Direccion = @Original_Direcci" & _
        "on) AND (Edad = @Original_Edad) AND (Email = @Original_Email) AND (Estado_Civil " & _
        "= @Original_Estado_Civil) AND (Fecha_Ingreso = @Original_Fecha_Ingreso) AND (Fec" & _
        "ha_Nacimiento = @Original_Fecha_Nacimiento) AND (Fecha_Salida = @Original_Fecha_" & _
        "Salida) AND (Femenino = @Original_Femenino) AND (Hijos = @Original_Hijos) AND (H" & _
        "ora = @Original_Hora) AND (Masculino = @Original_Masculino) AND (Mensual = @Orig" & _
        "inal_Mensual) AND (Nombre = @Original_Nombre) AND (Puesto = @Original_Puesto) AN" & _
        "D (Quincena = @Original_Quincena) AND (Salario = @Original_Salario) AND (Semana " & _
        "= @Original_Semana) AND (Telefono1 = @Original_Telefono1) AND (Telefono2 = @Orig" & _
        "inal_Telefono2)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Departamento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Departamento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Nacionalidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Edad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Estado_Civil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado_Civil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nacimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Femenino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Femenino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Masculino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Masculino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Empleado(Identificacion, Nombre, Estado_Civil, Hijos, Cod_Nacionalida" & _
        "d, Fecha_Nacimiento, Edad, Telefono1, Telefono2, Email, Direccion, Puesto, Fecha" & _
        "_Ingreso, Fecha_Salida, Salario, Cod_Departamento, Masculino, Femenino, Cod_Mone" & _
        "da, Hora, Diario, Semana, Quincena, Mensual, Cod_Estado, Foto) VALUES (@Identifi" & _
        "cacion, @Nombre, @Estado_Civil, @Hijos, @Cod_Nacionalidad, @Fecha_Nacimiento, @E" & _
        "dad, @Telefono1, @Telefono2, @Email, @Direccion, @Puesto, @Fecha_Ingreso, @Fecha" & _
        "_Salida, @Salario, @Cod_Departamento, @Masculino, @Femenino, @Cod_Moneda, @Hora," & _
        " @Diario, @Semana, @Quincena, @Mensual, @Cod_Estado, @Foto); SELECT Identificaci" & _
        "on, Nombre, Estado_Civil, Hijos, Cod_Nacionalidad, Fecha_Nacimiento, Edad, Telef" & _
        "ono1, Telefono2, Email, Direccion, Puesto, Fecha_Ingreso, Fecha_Salida, Salario," & _
        " Cod_Departamento, Masculino, Femenino, Cod_Moneda, Hora, Diario, Semana, Quince" & _
        "na, Mensual, Cod_Estado, Foto FROM Empleado WHERE (Identificacion = @Identificac" & _
        "ion) ORDER BY Nombre"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 50, "Estado_Civil"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 4, "Hijos"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, "Cod_Nacionalidad"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, "Fecha_Nacimiento"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 50, "Telefono1"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 50, "Telefono2"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 100, "Puesto"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 4, "Cod_Departamento"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 1, "Masculino"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 1, "Femenino"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Identificacion, Nombre, Estado_Civil, Hijos, Cod_Nacionalidad, Fecha_Nacim" & _
        "iento, Edad, Telefono1, Telefono2, Email, Direccion, Puesto, Fecha_Ingreso, Fech" & _
        "a_Salida, Salario, Cod_Departamento, Masculino, Femenino, Cod_Moneda, Hora, Diar" & _
        "io, Semana, Quincena, Mensual, Cod_Estado, Foto FROM Empleado ORDER BY Nombre"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Empleado SET Identificacion = @Identificacion, Nombre = @Nombre, Estado_Ci" & _
        "vil = @Estado_Civil, Hijos = @Hijos, Cod_Nacionalidad = @Cod_Nacionalidad, Fecha" & _
        "_Nacimiento = @Fecha_Nacimiento, Edad = @Edad, Telefono1 = @Telefono1, Telefono2" & _
        " = @Telefono2, Email = @Email, Direccion = @Direccion, Puesto = @Puesto, Fecha_I" & _
        "ngreso = @Fecha_Ingreso, Fecha_Salida = @Fecha_Salida, Salario = @Salario, Cod_D" & _
        "epartamento = @Cod_Departamento, Masculino = @Masculino, Femenino = @Femenino, C" & _
        "od_Moneda = @Cod_Moneda, Hora = @Hora, Diario = @Diario, Semana = @Semana, Quinc" & _
        "ena = @Quincena, Mensual = @Mensual, Cod_Estado = @Cod_Estado, Foto = @Foto WHER" & _
        "E (Identificacion = @Original_Identificacion) AND (Cod_Departamento = @Original_" & _
        "Cod_Departamento) AND (Cod_Estado = @Original_Cod_Estado) AND (Cod_Moneda = @Ori" & _
        "ginal_Cod_Moneda) AND (Cod_Nacionalidad = @Original_Cod_Nacionalidad) AND (Diari" & _
        "o = @Original_Diario) AND (Direccion = @Original_Direccion) AND (Edad = @Origina" & _
        "l_Edad) AND (Email = @Original_Email) AND (Estado_Civil = @Original_Estado_Civil" & _
        ") AND (Fecha_Ingreso = @Original_Fecha_Ingreso) AND (Fecha_Nacimiento = @Origina" & _
        "l_Fecha_Nacimiento) AND (Fecha_Salida = @Original_Fecha_Salida) AND (Femenino = " & _
        "@Original_Femenino) AND (Hijos = @Original_Hijos) AND (Hora = @Original_Hora) AN" & _
        "D (Masculino = @Original_Masculino) AND (Mensual = @Original_Mensual) AND (Nombr" & _
        "e = @Original_Nombre) AND (Puesto = @Original_Puesto) AND (Quincena = @Original_" & _
        "Quincena) AND (Salario = @Original_Salario) AND (Semana = @Original_Semana) AND " & _
        "(Telefono1 = @Original_Telefono1) AND (Telefono2 = @Original_Telefono2); SELECT " & _
        "Identificacion, Nombre, Estado_Civil, Hijos, Cod_Nacionalidad, Fecha_Nacimiento," & _
        " Edad, Telefono1, Telefono2, Email, Direccion, Puesto, Fecha_Ingreso, Fecha_Sali" & _
        "da, Salario, Cod_Departamento, Masculino, Femenino, Cod_Moneda, Hora, Diario, Se" & _
        "mana, Quincena, Mensual, Cod_Estado, Foto FROM Empleado WHERE (Identificacion = " & _
        "@Identificacion) ORDER BY Nombre"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 50, "Estado_Civil"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 4, "Hijos"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, "Cod_Nacionalidad"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, "Fecha_Nacimiento"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 50, "Telefono1"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 50, "Telefono2"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 100, "Puesto"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 4, "Cod_Departamento"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 1, "Masculino"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 1, "Femenino"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Departamento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Departamento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Nacionalidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Edad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Estado_Civil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado_Civil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nacimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Femenino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Femenino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Masculino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Masculino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing))
        '
        'adDeducciones
        '
        Me.adDeducciones.DeleteCommand = Me.SqlDeleteCommand5
        Me.adDeducciones.InsertCommand = Me.SqlInsertCommand5
        Me.adDeducciones.SelectCommand = Me.SqlSelectCommand5
        Me.adDeducciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Deducciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Aplica", "Aplica"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        Me.adDeducciones.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM Deducciones WHERE (Codigo = @Original_Codigo) AND (Aplica = @Original" & _
        "_Aplica) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Descripcion = @Original_De" & _
        "scripcion) AND (Monto = @Original_Monto) AND (Tipo = @Original_Tipo)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aplica", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplica", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO Deducciones(Descripcion, Monto, Tipo, Aplica, Cod_Moneda) VALUES (@De" & _
        "scripcion, @Monto, @Tipo, @Aplica, @Cod_Moneda); SELECT Codigo, Descripcion, Mon" & _
        "to, Tipo, Aplica, Cod_Moneda FROM Deducciones WHERE (Codigo = @@IDENTITY)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplica", System.Data.SqlDbType.Bit, 1, "Aplica"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Codigo, Descripcion, Monto, Tipo, Aplica, Cod_Moneda FROM Deducciones"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE Deducciones SET Descripcion = @Descripcion, Monto = @Monto, Tipo = @Tipo, " & _
        "Aplica = @Aplica, Cod_Moneda = @Cod_Moneda WHERE (Codigo = @Original_Codigo) AND" & _
        " (Aplica = @Original_Aplica) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Descri" & _
        "pcion = @Original_Descripcion) AND (Monto = @Original_Monto) AND (Tipo = @Origin" & _
        "al_Tipo); SELECT Codigo, Descripcion, Monto, Tipo, Aplica, Cod_Moneda FROM Deduc" & _
        "ciones WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplica", System.Data.SqlDbType.Bit, 1, "Aplica"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aplica", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplica", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        '
        'adAdelantos
        '
        Me.adAdelantos.DeleteCommand = Me.SqlDeleteCommand6
        Me.adAdelantos.InsertCommand = Me.SqlInsertCommand6
        Me.adAdelantos.SelectCommand = Me.SqlSelectCommand6
        Me.adAdelantos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Adelantos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Adelanto", "Adelanto"), New System.Data.Common.DataColumnMapping("Prestamo", "Prestamo"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("FechaComprobante", "FechaComprobante"), New System.Data.Common.DataColumnMapping("Num_Pago", "Num_Pago"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("MontoEnLetras", "MontoEnLetras"), New System.Data.Common.DataColumnMapping("FechaCobro", "FechaCobro"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("DeducirxPago", "DeducirxPago"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo")})})
        Me.adAdelantos.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM Adelantos WHERE (Numero = @Original_Numero) AND (Adelanto = @Original" & _
        "_Adelanto) AND (Anulado = @Original_Anulado) AND (Cod_Moneda = @Original_Cod_Mon" & _
        "eda) AND (DeducirxPago = @Original_DeducirxPago) AND (FechaCobro = @Original_Fec" & _
        "haCobro) AND (FechaComprobante = @Original_FechaComprobante) AND (Identificacion" & _
        " = @Original_Identificacion) AND (Monto = @Original_Monto) AND (MontoEnLetras = " & _
        "@Original_MontoEnLetras) AND (Nombre = @Original_Nombre) AND (NombreUsuario = @O" & _
        "riginal_NombreUsuario) AND (Num_Pago = @Original_Num_Pago) AND (Observaciones = " & _
        "@Original_Observaciones) AND (Prestamo = @Original_Prestamo) AND (Puesto = @Orig" & _
        "inal_Puesto) AND (Salario = @Original_Salario) AND (Saldo = @Original_Saldo OR @" & _
        "Original_Saldo IS NULL AND Saldo IS NULL) AND (Usuario = @Original_Usuario)"
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Adelanto", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adelanto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DeducirxPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeducirxPago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaCobro", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaCobro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaComprobante", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaComprobante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoEnLetras", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnLetras", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Pago", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Pago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Prestamo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prestamo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO Adelantos(Identificacion, Nombre, Adelanto, Prestamo, Puesto, Salario" & _
        ", FechaComprobante, Num_Pago, Monto, MontoEnLetras, FechaCobro, Observaciones, D" & _
        "educirxPago, Usuario, NombreUsuario, Cod_Moneda, Anulado, Saldo) VALUES (@Identi" & _
        "ficacion, @Nombre, @Adelanto, @Prestamo, @Puesto, @Salario, @FechaComprobante, @" & _
        "Num_Pago, @Monto, @MontoEnLetras, @FechaCobro, @Observaciones, @DeducirxPago, @U" & _
        "suario, @NombreUsuario, @Cod_Moneda, @Anulado, @Saldo); SELECT Numero, Identific" & _
        "acion, Nombre, Adelanto, Prestamo, Puesto, Salario, FechaComprobante, Num_Pago, " & _
        "Monto, MontoEnLetras, FechaCobro, Observaciones, DeducirxPago, Usuario, NombreUs" & _
        "uario, Cod_Moneda, Anulado, Saldo FROM Adelantos WHERE (Numero = @@IDENTITY)"
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Adelanto", System.Data.SqlDbType.Bit, 1, "Adelanto"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Prestamo", System.Data.SqlDbType.Bit, 1, "Prestamo"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaComprobante", System.Data.SqlDbType.DateTime, 8, "FechaComprobante"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Pago", System.Data.SqlDbType.Int, 4, "Num_Pago"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoEnLetras", System.Data.SqlDbType.VarChar, 250, "MontoEnLetras"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaCobro", System.Data.SqlDbType.DateTime, 8, "FechaCobro"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DeducirxPago", System.Data.SqlDbType.Float, 8, "DeducirxPago"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 50, "Usuario"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 8, "Saldo"))
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Numero, Identificacion, Nombre, Adelanto, Prestamo, Puesto, Salario, Fecha" & _
        "Comprobante, Num_Pago, Monto, MontoEnLetras, FechaCobro, Observaciones, Deducirx" & _
        "Pago, Usuario, NombreUsuario, Cod_Moneda, Anulado, Saldo FROM Adelantos"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "UPDATE Adelantos SET Identificacion = @Identificacion, Nombre = @Nombre, Adelanto" & _
        " = @Adelanto, Prestamo = @Prestamo, Puesto = @Puesto, Salario = @Salario, FechaC" & _
        "omprobante = @FechaComprobante, Num_Pago = @Num_Pago, Monto = @Monto, MontoEnLet" & _
        "ras = @MontoEnLetras, FechaCobro = @FechaCobro, Observaciones = @Observaciones, " & _
        "DeducirxPago = @DeducirxPago, Usuario = @Usuario, NombreUsuario = @NombreUsuario" & _
        ", Cod_Moneda = @Cod_Moneda, Anulado = @Anulado, Saldo = @Saldo WHERE (Numero = @" & _
        "Original_Numero) AND (Adelanto = @Original_Adelanto) AND (Anulado = @Original_An" & _
        "ulado) AND (Cod_Moneda = @Original_Cod_Moneda) AND (DeducirxPago = @Original_Ded" & _
        "ucirxPago) AND (FechaCobro = @Original_FechaCobro) AND (FechaComprobante = @Orig" & _
        "inal_FechaComprobante) AND (Identificacion = @Original_Identificacion) AND (Mont" & _
        "o = @Original_Monto) AND (MontoEnLetras = @Original_MontoEnLetras) AND (Nombre =" & _
        " @Original_Nombre) AND (NombreUsuario = @Original_NombreUsuario) AND (Num_Pago =" & _
        " @Original_Num_Pago) AND (Observaciones = @Original_Observaciones) AND (Prestamo" & _
        " = @Original_Prestamo) AND (Puesto = @Original_Puesto) AND (Salario = @Original_" & _
        "Salario) AND (Saldo = @Original_Saldo OR @Original_Saldo IS NULL AND Saldo IS NU" & _
        "LL) AND (Usuario = @Original_Usuario); SELECT Numero, Identificacion, Nombre, Ad" & _
        "elanto, Prestamo, Puesto, Salario, FechaComprobante, Num_Pago, Monto, MontoEnLet" & _
        "ras, FechaCobro, Observaciones, DeducirxPago, Usuario, NombreUsuario, Cod_Moneda" & _
        ", Anulado, Saldo FROM Adelantos WHERE (Numero = @Numero)"
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Adelanto", System.Data.SqlDbType.Bit, 1, "Adelanto"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Prestamo", System.Data.SqlDbType.Bit, 1, "Prestamo"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaComprobante", System.Data.SqlDbType.DateTime, 8, "FechaComprobante"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Pago", System.Data.SqlDbType.Int, 4, "Num_Pago"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoEnLetras", System.Data.SqlDbType.VarChar, 250, "MontoEnLetras"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaCobro", System.Data.SqlDbType.DateTime, 8, "FechaCobro"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DeducirxPago", System.Data.SqlDbType.Float, 8, "DeducirxPago"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 50, "Usuario"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 8, "Saldo"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Adelanto", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adelanto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DeducirxPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeducirxPago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaCobro", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaCobro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaComprobante", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaComprobante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoEnLetras", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnLetras", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Pago", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Pago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Prestamo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prestamo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero"))
        '
        'adRenta
        '
        Me.adRenta.DeleteCommand = Me.SqlDeleteCommand7
        Me.adRenta.InsertCommand = Me.SqlInsertCommand7
        Me.adRenta.SelectCommand = Me.SqlSelectCommand7
        Me.adRenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ParametroRenta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("MontoExento", "MontoExento"), New System.Data.Common.DataColumnMapping("MontoDe", "MontoDe"), New System.Data.Common.DataColumnMapping("MontoHasta", "MontoHasta"), New System.Data.Common.DataColumnMapping("Porcentaje1", "Porcentaje1"), New System.Data.Common.DataColumnMapping("MontoEnAdelante", "MontoEnAdelante"), New System.Data.Common.DataColumnMapping("Porcentaje2", "Porcentaje2"), New System.Data.Common.DataColumnMapping("Esposa", "Esposa"), New System.Data.Common.DataColumnMapping("Hijo", "Hijo")})})
        Me.adRenta.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = "DELETE FROM ParametroRenta WHERE (Id = @Original_Id) AND (Esposa = @Original_Espo" & _
        "sa) AND (Hijo = @Original_Hijo) AND (MontoDe = @Original_MontoDe) AND (MontoEnAd" & _
        "elante = @Original_MontoEnAdelante) AND (MontoExento = @Original_MontoExento) AN" & _
        "D (MontoHasta = @Original_MontoHasta) AND (Porcentaje1 = @Original_Porcentaje1) " & _
        "AND (Porcentaje2 = @Original_Porcentaje2)"
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Esposa", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Esposa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoDe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoDe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoEnAdelante", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnAdelante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoHasta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoHasta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porcentaje1", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porcentaje2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje2", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = "INSERT INTO ParametroRenta(MontoExento, MontoDe, MontoHasta, Porcentaje1, MontoEn" & _
        "Adelante, Porcentaje2, Esposa, Hijo) VALUES (@MontoExento, @MontoDe, @MontoHasta" & _
        ", @Porcentaje1, @MontoEnAdelante, @Porcentaje2, @Esposa, @Hijo); SELECT Id, Mont" & _
        "oExento, MontoDe, MontoHasta, Porcentaje1, MontoEnAdelante, Porcentaje2, Esposa," & _
        " Hijo FROM ParametroRenta WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand7.Connection = Me.SqlConnection1
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoExento", System.Data.SqlDbType.Float, 8, "MontoExento"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoDe", System.Data.SqlDbType.Float, 8, "MontoDe"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoHasta", System.Data.SqlDbType.Float, 8, "MontoHasta"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porcentaje1", System.Data.SqlDbType.Float, 8, "Porcentaje1"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoEnAdelante", System.Data.SqlDbType.Float, 8, "MontoEnAdelante"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porcentaje2", System.Data.SqlDbType.Float, 8, "Porcentaje2"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Esposa", System.Data.SqlDbType.Float, 8, "Esposa"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijo", System.Data.SqlDbType.Float, 8, "Hijo"))
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT Id, MontoExento, MontoDe, MontoHasta, Porcentaje1, MontoEnAdelante, Porcen" & _
        "taje2, Esposa, Hijo FROM ParametroRenta"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = "UPDATE ParametroRenta SET MontoExento = @MontoExento, MontoDe = @MontoDe, MontoHa" & _
        "sta = @MontoHasta, Porcentaje1 = @Porcentaje1, MontoEnAdelante = @MontoEnAdelant" & _
        "e, Porcentaje2 = @Porcentaje2, Esposa = @Esposa, Hijo = @Hijo WHERE (Id = @Origi" & _
        "nal_Id) AND (Esposa = @Original_Esposa) AND (Hijo = @Original_Hijo) AND (MontoDe" & _
        " = @Original_MontoDe) AND (MontoEnAdelante = @Original_MontoEnAdelante) AND (Mon" & _
        "toExento = @Original_MontoExento) AND (MontoHasta = @Original_MontoHasta) AND (P" & _
        "orcentaje1 = @Original_Porcentaje1) AND (Porcentaje2 = @Original_Porcentaje2); S" & _
        "ELECT Id, MontoExento, MontoDe, MontoHasta, Porcentaje1, MontoEnAdelante, Porcen" & _
        "taje2, Esposa, Hijo FROM ParametroRenta WHERE (Id = @Id)"
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoExento", System.Data.SqlDbType.Float, 8, "MontoExento"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoDe", System.Data.SqlDbType.Float, 8, "MontoDe"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoHasta", System.Data.SqlDbType.Float, 8, "MontoHasta"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porcentaje1", System.Data.SqlDbType.Float, 8, "Porcentaje1"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoEnAdelante", System.Data.SqlDbType.Float, 8, "MontoEnAdelante"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porcentaje2", System.Data.SqlDbType.Float, 8, "Porcentaje2"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Esposa", System.Data.SqlDbType.Float, 8, "Esposa"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijo", System.Data.SqlDbType.Float, 8, "Hijo"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Esposa", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Esposa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoDe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoDe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoEnAdelante", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnAdelante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoHasta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoHasta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porcentaje1", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porcentaje2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'adEmpleadoDeducciones
        '
        Me.adEmpleadoDeducciones.DeleteCommand = Me.SqlDeleteCommand10
        Me.adEmpleadoDeducciones.InsertCommand = Me.SqlInsertCommand10
        Me.adEmpleadoDeducciones.SelectCommand = Me.SqlSelectCommand10
        Me.adEmpleadoDeducciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado_Deducciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        Me.adEmpleadoDeducciones.UpdateCommand = Me.SqlUpdateCommand10
        '
        'SqlDeleteCommand10
        '
        Me.SqlDeleteCommand10.CommandText = "DELETE FROM Empleado_Deducciones WHERE (Id = @Original_Id) AND (Cod_Moneda = @Ori" & _
        "ginal_Cod_Moneda) AND (Codigo = @Original_Codigo) AND (Descripcion = @Original_D" & _
        "escripcion) AND (Identificacion = @Original_Identificacion) AND (Monto = @Origin" & _
        "al_Monto) AND (Tipo = @Original_Tipo)"
        Me.SqlDeleteCommand10.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand10
        '
        Me.SqlInsertCommand10.CommandText = "INSERT INTO Empleado_Deducciones(Identificacion, Codigo, Descripcion, Monto, Tipo" & _
        ", Cod_Moneda) VALUES (@Identificacion, @Codigo, @Descripcion, @Monto, @Tipo, @Co" & _
        "d_Moneda); SELECT Id, Identificacion, Codigo, Descripcion, Monto, Tipo, Cod_Mone" & _
        "da FROM Empleado_Deducciones WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand10.Connection = Me.SqlConnection1
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT Id, Identificacion, Codigo, Descripcion, Monto, Tipo, Cod_Moneda FROM Empl" & _
        "eado_Deducciones"
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand10
        '
        Me.SqlUpdateCommand10.CommandText = "UPDATE Empleado_Deducciones SET Identificacion = @Identificacion, Codigo = @Codig" & _
        "o, Descripcion = @Descripcion, Monto = @Monto, Tipo = @Tipo, Cod_Moneda = @Cod_M" & _
        "oneda WHERE (Id = @Original_Id) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Cod" & _
        "igo = @Original_Codigo) AND (Descripcion = @Original_Descripcion) AND (Identific" & _
        "acion = @Original_Identificacion) AND (Monto = @Original_Monto) AND (Tipo = @Ori" & _
        "ginal_Tipo); SELECT Id, Identificacion, Codigo, Descripcion, Monto, Tipo, Cod_Mo" & _
        "neda FROM Empleado_Deducciones WHERE (Id = @Id)"
        Me.SqlUpdateCommand10.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'HorasTrabajadas
        '
        Me.HorasTrabajadas.DeleteCommand = Me.SqlDeleteCommand11
        Me.HorasTrabajadas.InsertCommand = Me.SqlInsertCommand11
        Me.HorasTrabajadas.SelectCommand = Me.SqlSelectCommand11
        Me.HorasTrabajadas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "HorasTrabajadas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("HoraOrdinaria", "HoraOrdinaria"), New System.Data.Common.DataColumnMapping("HoraExtra", "HoraExtra"), New System.Data.Common.DataColumnMapping("HoraDoble", "HoraDoble"), New System.Data.Common.DataColumnMapping("Id_Proyecto", "Id_Proyecto")})})
        Me.HorasTrabajadas.UpdateCommand = Me.SqlUpdateCommand11
        '
        'SqlDeleteCommand11
        '
        Me.SqlDeleteCommand11.CommandText = "DELETE FROM HorasTrabajadas WHERE (Id = @Original_Id) AND (Fecha = @Original_Fech" & _
        "a) AND (HoraDoble = @Original_HoraDoble) AND (HoraExtra = @Original_HoraExtra) A" & _
        "ND (HoraOrdinaria = @Original_HoraOrdinaria) AND (Identificacion = @Original_Ide" & _
        "ntificacion)"
        Me.SqlDeleteCommand11.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoraDoble", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraDoble", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoraExtra", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraExtra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoraOrdinaria", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraOrdinaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand11
        '
        Me.SqlInsertCommand11.CommandText = "INSERT INTO HorasTrabajadas(Identificacion, Fecha, HoraOrdinaria, HoraExtra, Hora" & _
        "Doble, Id_Proyecto) VALUES (@Identificacion, @Fecha, @HoraOrdinaria, @HoraExtra," & _
        " @HoraDoble, @Id_Proyecto); SELECT Id, Identificacion, Fecha, HoraOrdinaria, Hor" & _
        "aExtra, HoraDoble, Id_Proyecto FROM HorasTrabajadas WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand11.Connection = Me.SqlConnection1
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoraOrdinaria", System.Data.SqlDbType.Float, 8, "HoraOrdinaria"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoraExtra", System.Data.SqlDbType.VarChar, 10, "HoraExtra"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoraDoble", System.Data.SqlDbType.VarChar, 10, "HoraDoble"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Proyecto", System.Data.SqlDbType.Int, 4, "Id_Proyecto"))
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT Id, Identificacion, Fecha, HoraOrdinaria, HoraExtra, HoraDoble, Id_Proyect" & _
        "o FROM HorasTrabajadas"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand11
        '
        Me.SqlUpdateCommand11.CommandText = "UPDATE HorasTrabajadas SET Identificacion = @Identificacion, Fecha = @Fecha, Hora" & _
        "Ordinaria = @HoraOrdinaria, HoraExtra = @HoraExtra, HoraDoble = @HoraDoble, Id_P" & _
        "royecto = @Id_Proyecto WHERE (Id = @Original_Id) AND (Fecha = @Original_Fecha) A" & _
        "ND (HoraDoble = @Original_HoraDoble) AND (HoraExtra = @Original_HoraExtra) AND (" & _
        "HoraOrdinaria = @Original_HoraOrdinaria) AND (Identificacion = @Original_Identif" & _
        "icacion); SELECT Id, Identificacion, Fecha, HoraOrdinaria, HoraExtra, HoraDoble," & _
        " Id_Proyecto FROM HorasTrabajadas WHERE (Id = @Id)"
        Me.SqlUpdateCommand11.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoraOrdinaria", System.Data.SqlDbType.Float, 8, "HoraOrdinaria"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoraExtra", System.Data.SqlDbType.VarChar, 10, "HoraExtra"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoraDoble", System.Data.SqlDbType.VarChar, 10, "HoraDoble"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Proyecto", System.Data.SqlDbType.Int, 4, "Id_Proyecto"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoraDoble", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraDoble", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoraExtra", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraExtra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoraOrdinaria", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraOrdinaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(432, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(24, 20)
        Me.TextBox1.TabIndex = 193
        Me.TextBox1.Text = ""
        '
        'adPlanilla
        '
        Me.adPlanilla.DeleteCommand = Me.SqlDeleteCommand1
        Me.adPlanilla.InsertCommand = Me.SqlInsertCommand1
        Me.adPlanilla.SelectCommand = Me.SqlSelectCommand1
        Me.adPlanilla.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Planilla", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Planilla", "Id_Planilla"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("FechaInicial", "FechaInicial"), New System.Data.Common.DataColumnMapping("FechaFinal", "FechaFinal"), New System.Data.Common.DataColumnMapping("CierreMes", "CierreMes"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("Nombre_Usuario", "Nombre_Usuario"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado")})})
        Me.adPlanilla.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Planilla WHERE (Id_Planilla = @Original_Id_Planilla) AND (Anulado = @" & _
        "Original_Anulado) AND (Ced_Usuario = @Original_Ced_Usuario) AND (CierreMes = @Or" & _
        "iginal_CierreMes) AND (Fecha = @Original_Fecha) AND (FechaFinal = @Original_Fech" & _
        "aFinal) AND (FechaInicial = @Original_FechaInicial) AND (Nombre_Usuario = @Origi" & _
        "nal_Nombre_Usuario)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CierreMes", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CierreMes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaFinal", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaFinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaInicial", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaInicial", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Planilla(Fecha, FechaInicial, FechaFinal, CierreMes, Ced_Usuario, Nom" & _
        "bre_Usuario, Anulado) VALUES (@Fecha, @FechaInicial, @FechaFinal, @CierreMes, @C" & _
        "ed_Usuario, @Nombre_Usuario, @Anulado); SELECT Id_Planilla, Fecha, FechaInicial," & _
        " FechaFinal, CierreMes, Ced_Usuario, Nombre_Usuario, Anulado FROM Planilla WHERE" & _
        " (Id_Planilla = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaInicial", System.Data.SqlDbType.DateTime, 8, "FechaInicial"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaFinal", System.Data.SqlDbType.DateTime, 8, "FechaFinal"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CierreMes", System.Data.SqlDbType.Bit, 1, "CierreMes"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, "Nombre_Usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id_Planilla, Fecha, FechaInicial, FechaFinal, CierreMes, Ced_Usuario, Nomb" & _
        "re_Usuario, Anulado FROM Planilla"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Planilla SET Fecha = @Fecha, FechaInicial = @FechaInicial, FechaFinal = @F" & _
        "echaFinal, CierreMes = @CierreMes, Ced_Usuario = @Ced_Usuario, Nombre_Usuario = " & _
        "@Nombre_Usuario, Anulado = @Anulado WHERE (Id_Planilla = @Original_Id_Planilla) " & _
        "AND (Anulado = @Original_Anulado) AND (Ced_Usuario = @Original_Ced_Usuario) AND " & _
        "(CierreMes = @Original_CierreMes) AND (Fecha = @Original_Fecha) AND (FechaFinal " & _
        "= @Original_FechaFinal) AND (FechaInicial = @Original_FechaInicial) AND (Nombre_" & _
        "Usuario = @Original_Nombre_Usuario); SELECT Id_Planilla, Fecha, FechaInicial, Fe" & _
        "chaFinal, CierreMes, Ced_Usuario, Nombre_Usuario, Anulado FROM Planilla WHERE (I" & _
        "d_Planilla = @Id_Planilla)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaInicial", System.Data.SqlDbType.DateTime, 8, "FechaInicial"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaFinal", System.Data.SqlDbType.DateTime, 8, "FechaFinal"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CierreMes", System.Data.SqlDbType.Bit, 1, "CierreMes"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, "Nombre_Usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CierreMes", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CierreMes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaFinal", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaFinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaInicial", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaInicial", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 8, "Id_Planilla"))
        '
        'adAccion
        '
        Me.adAccion.DeleteCommand = Me.SqlDeleteCommand8
        Me.adAccion.InsertCommand = Me.SqlInsertCommand8
        Me.adAccion.SelectCommand = Me.SqlSelectCommand8
        Me.adAccion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AccionPersonal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Num_Accion", "Num_Accion"), New System.Data.Common.DataColumnMapping("Id_Empleado", "Id_Empleado"), New System.Data.Common.DataColumnMapping("Nombre_Empleado", "Nombre_Empleado"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Id_Accion", "Id_Accion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("RigeDesde", "RigeDesde"), New System.Data.Common.DataColumnMapping("RigeHasta", "RigeHasta"), New System.Data.Common.DataColumnMapping("DiasaDescontar", "DiasaDescontar"), New System.Data.Common.DataColumnMapping("HechoPor", "HechoPor"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("Anula", "Anula")})})
        Me.adAccion.UpdateCommand = Me.SqlUpdateCommand8
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = "DELETE FROM AccionPersonal WHERE (Num_Accion = @Original_Num_Accion) AND (Anula =" & _
        " @Original_Anula) AND (DiasaDescontar = @Original_DiasaDescontar) AND (Fecha = @" & _
        "Original_Fecha) AND (HechoPor = @Original_HechoPor) AND (Id_Accion = @Original_I" & _
        "d_Accion) AND (Id_Empleado = @Original_Id_Empleado) AND (NombreUsuario = @Origin" & _
        "al_NombreUsuario) AND (Nombre_Empleado = @Original_Nombre_Empleado) AND (Observa" & _
        "ciones = @Original_Observaciones) AND (Puesto = @Original_Puesto) AND (RigeDesde" & _
        " = @Original_RigeDesde) AND (RigeHasta = @Original_RigeHasta)"
        Me.SqlDeleteCommand8.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiasaDescontar", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiasaDescontar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HechoPor", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HechoPor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Accion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeDesde", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeDesde", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeHasta", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeHasta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO AccionPersonal(Num_Accion, Id_Empleado, Nombre_Empleado, Puesto, Id_A" & _
        "ccion, Fecha, Observaciones, RigeDesde, RigeHasta, DiasaDescontar, HechoPor, Nom" & _
        "breUsuario, Anula) VALUES (@Num_Accion, @Id_Empleado, @Nombre_Empleado, @Puesto," & _
        " @Id_Accion, @Fecha, @Observaciones, @RigeDesde, @RigeHasta, @DiasaDescontar, @H" & _
        "echoPor, @NombreUsuario, @Anula); SELECT Num_Accion, Id_Empleado, Nombre_Emplead" & _
        "o, Puesto, Id_Accion, Fecha, Observaciones, RigeDesde, RigeHasta, DiasaDescontar" & _
        ", HechoPor, NombreUsuario, Anula FROM AccionPersonal WHERE (Num_Accion = @Num_Ac" & _
        "cion)"
        Me.SqlInsertCommand8.Connection = Me.SqlConnection1
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Accion", System.Data.SqlDbType.BigInt, 8, "Num_Accion"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 250, "Id_Empleado"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, "Nombre_Empleado"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 4, "Id_Accion"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeDesde", System.Data.SqlDbType.DateTime, 8, "RigeDesde"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeHasta", System.Data.SqlDbType.DateTime, 8, "RigeHasta"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Float, 8, "DiasaDescontar"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HechoPor", System.Data.SqlDbType.VarChar, 75, "HechoPor"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"))
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT Num_Accion, Id_Empleado, Nombre_Empleado, Puesto, Id_Accion, Fecha, Observ" & _
        "aciones, RigeDesde, RigeHasta, DiasaDescontar, HechoPor, NombreUsuario, Anula FR" & _
        "OM AccionPersonal"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = "UPDATE AccionPersonal SET Num_Accion = @Num_Accion, Id_Empleado = @Id_Empleado, N" & _
        "ombre_Empleado = @Nombre_Empleado, Puesto = @Puesto, Id_Accion = @Id_Accion, Fec" & _
        "ha = @Fecha, Observaciones = @Observaciones, RigeDesde = @RigeDesde, RigeHasta =" & _
        " @RigeHasta, DiasaDescontar = @DiasaDescontar, HechoPor = @HechoPor, NombreUsuar" & _
        "io = @NombreUsuario, Anula = @Anula WHERE (Num_Accion = @Original_Num_Accion) AN" & _
        "D (Anula = @Original_Anula) AND (DiasaDescontar = @Original_DiasaDescontar) AND " & _
        "(Fecha = @Original_Fecha) AND (HechoPor = @Original_HechoPor) AND (Id_Accion = @" & _
        "Original_Id_Accion) AND (Id_Empleado = @Original_Id_Empleado) AND (NombreUsuario" & _
        " = @Original_NombreUsuario) AND (Nombre_Empleado = @Original_Nombre_Empleado) AN" & _
        "D (Observaciones = @Original_Observaciones) AND (Puesto = @Original_Puesto) AND " & _
        "(RigeDesde = @Original_RigeDesde) AND (RigeHasta = @Original_RigeHasta); SELECT " & _
        "Num_Accion, Id_Empleado, Nombre_Empleado, Puesto, Id_Accion, Fecha, Observacione" & _
        "s, RigeDesde, RigeHasta, DiasaDescontar, HechoPor, NombreUsuario, Anula FROM Acc" & _
        "ionPersonal WHERE (Num_Accion = @Num_Accion)"
        Me.SqlUpdateCommand8.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Accion", System.Data.SqlDbType.BigInt, 8, "Num_Accion"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 250, "Id_Empleado"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, "Nombre_Empleado"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 4, "Id_Accion"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeDesde", System.Data.SqlDbType.DateTime, 8, "RigeDesde"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeHasta", System.Data.SqlDbType.DateTime, 8, "RigeHasta"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Float, 8, "DiasaDescontar"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HechoPor", System.Data.SqlDbType.VarChar, 75, "HechoPor"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiasaDescontar", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiasaDescontar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HechoPor", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HechoPor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Accion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeDesde", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeDesde", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeHasta", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeHasta", System.Data.DataRowVersion.Original, Nothing))
        '
        'adMoneda
        '
        Me.adMoneda.SelectCommand = Me.SqlSelectCommand13
        Me.adMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand13
        '
        Me.SqlSelectCommand13.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand13.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand12
        '
        Me.SqlInsertCommand12.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo) VAL" & _
        "UES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simbolo); SELECT Cod" & _
        "Moneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda WHERE (CodMon" & _
        "eda = @CodMoneda)"
        Me.SqlInsertCommand12.Connection = Me.SqlConnection1
        Me.SqlInsertCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand12.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand12
        '
        Me.SqlUpdateCommand12.CommandText = "UPDATE Moneda SET CodMoneda = @CodMoneda, MonedaNombre = @MonedaNombre, ValorComp" & _
        "ra = @ValorCompra, ValorVenta = @ValorVenta, Simbolo = @Simbolo WHERE (CodMoneda" & _
        " = @Original_CodMoneda) AND (MonedaNombre = @Original_MonedaNombre) AND (Simbolo" & _
        " = @Original_Simbolo) AND (ValorCompra = @Original_ValorCompra) AND (ValorVenta " & _
        "= @Original_ValorVenta); SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta" & _
        ", Simbolo FROM Moneda WHERE (CodMoneda = @CodMoneda)"
        Me.SqlUpdateCommand12.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdAdelanto_Detalle
        '
        Me.AdAdelanto_Detalle.DeleteCommand = Me.SqlDeleteCommand9
        Me.AdAdelanto_Detalle.InsertCommand = Me.SqlInsertCommand9
        Me.AdAdelanto_Detalle.SelectCommand = Me.SqlSelectCommand9
        Me.AdAdelanto_Detalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Adelantos_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Detalle_AP", "Id_Detalle_AP"), New System.Data.Common.DataColumnMapping("Id_Empleado", "Id_Empleado"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Tipo_Pago", "Tipo_Pago")})})
        Me.AdAdelanto_Detalle.UpdateCommand = Me.SqlUpdateCommand9
        '
        'SqlDeleteCommand9
        '
        Me.SqlDeleteCommand9.CommandText = "DELETE FROM Adelantos_Detalle WHERE (Id_Detalle_AP = @Original_Id_Detalle_AP) AND" & _
        " (Id_Empleado = @Original_Id_Empleado) AND (Monto = @Original_Monto) AND (Numero" & _
        " = @Original_Numero) AND (Tipo_Pago = @Original_Tipo_Pago)"
        Me.SqlDeleteCommand9.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle_AP", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle_AP", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Pago", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand9
        '
        Me.SqlInsertCommand9.CommandText = "INSERT INTO Adelantos_Detalle(Id_Empleado, Numero, Monto, Tipo_Pago) VALUES (@Id_" & _
        "Empleado, @Numero, @Monto, @Tipo_Pago); SELECT Id_Detalle_AP, Id_Empleado, Numer" & _
        "o, Monto, Tipo_Pago FROM Adelantos_Detalle WHERE (Id_Detalle_AP = @@IDENTITY)"
        Me.SqlInsertCommand9.Connection = Me.SqlConnection1
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 50, "Id_Empleado"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Pago", System.Data.SqlDbType.Bit, 1, "Tipo_Pago"))
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT Id_Detalle_AP, Id_Empleado, Numero, Monto, Tipo_Pago FROM Adelantos_Detall" & _
        "e"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand9
        '
        Me.SqlUpdateCommand9.CommandText = "UPDATE Adelantos_Detalle SET Id_Empleado = @Id_Empleado, Numero = @Numero, Monto " & _
        "= @Monto, Tipo_Pago = @Tipo_Pago WHERE (Id_Detalle_AP = @Original_Id_Detalle_AP)" & _
        " AND (Id_Empleado = @Original_Id_Empleado) AND (Monto = @Original_Monto) AND (Nu" & _
        "mero = @Original_Numero) AND (Tipo_Pago = @Original_Tipo_Pago); SELECT Id_Detall" & _
        "e_AP, Id_Empleado, Numero, Monto, Tipo_Pago FROM Adelantos_Detalle WHERE (Id_Det" & _
        "alle_AP = @Id_Detalle_AP)"
        Me.SqlUpdateCommand9.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 50, "Id_Empleado"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Pago", System.Data.SqlDbType.Bit, 1, "Tipo_Pago"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle_AP", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle_AP", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Pago", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Detalle_AP", System.Data.SqlDbType.Int, 4, "Id_Detalle_AP"))
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Location = New System.Drawing.Point(416, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 24)
        Me.Button1.TabIndex = 195
        Me.Button1.Text = "Guardar Cambios"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridControl2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(88, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 144)
        Me.GroupBox1.TabIndex = 196
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modifique el Monto del Prestamo Deseado"
        Me.GroupBox1.Visible = False
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.DsPlanilla1
        '
        'GridControl2.EmbeddedNavigator
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(16, 24)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(352, 104)
        Me.GridControl2.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl2.TabIndex = 197
        Me.GridControl2.Text = "GridControl2"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId_Empleado, Me.colNumero, Me.colMonto})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowHorzLines = False
        '
        'colId_Empleado
        '
        Me.colId_Empleado.Caption = "Cedula"
        Me.colId_Empleado.FieldName = "Id_Empleado"
        Me.colId_Empleado.Name = "colId_Empleado"
        Me.colId_Empleado.VisibleIndex = 0
        '
        'colNumero
        '
        Me.colNumero.Caption = "Numero"
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.VisibleIndex = 1
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto"
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.VisibleIndex = 2
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button2.Location = New System.Drawing.Point(416, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 24)
        Me.Button2.TabIndex = 196
        Me.Button2.Text = "Cancelar"
        '
        'colAccionPersonal
        '
        Me.colAccionPersonal.Caption = "AccionPersonal"
        Me.colAccionPersonal.FieldName = "AccionPersonal"
        Me.colAccionPersonal.Name = "colAccionPersonal"
        Me.colAccionPersonal.VisibleIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(840, 497)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 198
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsPlanilla1, "Planilla.FechaInicial"))
        Me.dtFechaInicio.Enabled = False
        Me.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFechaInicio.Location = New System.Drawing.Point(328, 40)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.dtFechaInicio.TabIndex = 199
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsPlanilla1, "Planilla.FechaFinal"))
        Me.dtFechaFinal.Enabled = False
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFechaFinal.Location = New System.Drawing.Point(328, 64)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtFechaFinal.TabIndex = 200
        '
        'AdOrdinarias
        '
        Me.AdOrdinarias.DeleteCommand = Me.SqlDeleteCommand12
        Me.AdOrdinarias.InsertCommand = Me.SqlInsertCommand13
        Me.AdOrdinarias.SelectCommand = Me.SqlSelectCommand14
        Me.AdOrdinarias.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Horas_Ordinarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Horas", "Horas")})})
        Me.AdOrdinarias.UpdateCommand = Me.SqlUpdateCommand13
        '
        'SqlDeleteCommand12
        '
        Me.SqlDeleteCommand12.CommandText = "DELETE FROM Horas_Ordinarias WHERE (Horas = @Original_Horas)"
        Me.SqlDeleteCommand12.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand12.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Horas", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Horas", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand13
        '
        Me.SqlInsertCommand13.CommandText = "INSERT INTO Horas_Ordinarias(Horas) VALUES (@Horas); SELECT Horas FROM Horas_Ordi" & _
        "narias WHERE (Horas = @Horas)"
        Me.SqlInsertCommand13.Connection = Me.SqlConnection1
        Me.SqlInsertCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Horas", System.Data.SqlDbType.Int, 4, "Horas"))
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.CommandText = "SELECT Horas FROM Horas_Ordinarias"
        Me.SqlSelectCommand14.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand13
        '
        Me.SqlUpdateCommand13.CommandText = "UPDATE Horas_Ordinarias SET Horas = @Horas WHERE (Horas = @Original_Horas); SELEC" & _
        "T Horas FROM Horas_Ordinarias WHERE (Horas = @Horas)"
        Me.SqlUpdateCommand13.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Horas", System.Data.SqlDbType.Int, 4, "Horas"))
        Me.SqlUpdateCommand13.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Horas", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Horas", System.Data.DataRowVersion.Original, Nothing))
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(816, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 204
        Me.Label2.Text = "Total Planilla:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(616, 456)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(264, 13)
        Me.txtNombreUsuario.TabIndex = 203
        Me.txtNombreUsuario.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.ForeColor = System.Drawing.Color.Blue
        Me.TextBox2.Location = New System.Drawing.Point(552, 456)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(56, 13)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(464, 456)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 10)
        Me.Label36.TabIndex = 202
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFormaPago
        '
        Me.btnFormaPago.Location = New System.Drawing.Point(600, 40)
        Me.btnFormaPago.Name = "btnFormaPago"
        Me.btnFormaPago.TabIndex = 205
        Me.btnFormaPago.Text = "Forma Pago"
        '
        'frmControlTiempo2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(930, 512)
        Me.Controls.Add(Me.btnFormaPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.dtFechaFinal)
        Me.Controls.Add(Me.dtFechaInicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckAnulado)
        Me.Controls.Add(Me.CheckCierreMes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.TextBox1)
        Me.MaximizeBox = True
        Me.Name = "frmControlTiempo2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de Planilla"
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CheckCierreMes, 0)
        Me.Controls.SetChildIndex(Me.CheckAnulado, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNumero, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.dtFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.dtFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnFormaPago, 0)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Current_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.BindingContext(Me.TablaPlanilla).Count - 1 = 0 Then

        Else
            'Me.Recalcular_Fila_Planilla(Me.BindingContext(Me.TablaPlanilla).Position) cambio
        End If
    End Sub

    Private Sub frmControlTiempo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
            SqlConnection2.ConnectionString = GetSetting("SeeSoft", "Proyecto", "Conexion")
            Defaulvalue() 'valores por defecto
            Me.adEmpleados.Fill(Me.DsPlanilla1.Empleado)
            Me.adDeducciones.Fill(Me.DsPlanilla1.Deducciones)
            Me.adAdelantos.Fill(Me.DsPlanilla1.Adelantos)
            Me.adRenta.Fill(Me.DsPlanilla1.ParametroRenta)
            Me.adAccion.Fill(Me.DsPlanilla1.AccionPersonal)
            Me.adMoneda.Fill(Me.DsPlanilla1.Moneda)
            Me.adPlanilla.Fill(Me.DsPlanilla1.Planilla)
            Me.AdOrdinarias.Fill(Me.DsPlanilla1.Horas_Ordinarias)

            'Me.adUsuario.Fill(Me.DsPlanilla1, "Usuarios")
            'Me.adPlanilla.Fill(Me.DsPlanilla1, "Planilla")
            Me.adEmpleadoDeducciones.Fill(Me.DsPlanilla1, "Empleado_Deducciones")
            ' Me.HorasTrabajadas.Fill(Me.DsPlanilla1, "HorasTrabajadas")
            'Me.adPlanillaDetalle.Fill(Me.DsPlanilla1, "Planilla_Detalle")
            'Me.adPlanillaDeducciones.Fill(Me.DsPlanilla1, "Planilla_Deducciones")
            txtNumero.Text = ""
            txtNumero.ReadOnly = True
            CheckCierreMes.Checked = False
            CheckAnulado.Checked = False
            Me.dtFechaFinal.Enabled = False
            Me.dtFechaInicio.Enabled = False
            TextBox2.Focus()
            Me.CrearTabla()
            Me.GridControl1.DataSource = Me.TablaPlanilla
            'Defaulvalue()
            ToolBar1.Buttons(0).Enabled = False
            ToolBar1.Buttons(1).Enabled = False
            ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(4).Enabled = False
            ToolBar1.Buttons(5).Enabled = False
            'ComboBox1.Enabled = False
            Me.dtFechaFinal.Value = Now
            Me.dtFechaInicio.Value = Now
            AddHandler Me.BindingContext(Me.TablaPlanilla).CurrentChanged, AddressOf Me.Current_Changed
            TextBox2.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' TextBox2.Focus()
    End Sub

    Private Sub Defaulvalue()
        'Tabla Planilla
        Me.DsPlanilla1.Planilla.FechaColumn.DefaultValue = Now
        'Me.DsPlanilla1.Planilla.FechaInicialColumn.DefaultValue = Now
        'Me.DsPlanilla1.Planilla.FechaFinalColumn.DefaultValue = Now
        Me.DsPlanilla1.Planilla.CierreMesColumn.DefaultValue = False
        Me.DsPlanilla1.Planilla.Ced_UsuarioColumn.DefaultValue = ""
        Me.DsPlanilla1.Planilla.Nombre_UsuarioColumn.DefaultValue = ""
        Me.DsPlanilla1.Planilla.AnuladoColumn.DefaultValue = False
        'Me.DsPlanilla1.Planilla.DefinitivaColumn.DefaultValue = False

        Me.DsPlanilla1.Planilla.Id_PlanillaColumn.AutoIncrement = True
        Me.DsPlanilla1.Planilla.Id_PlanillaColumn.AutoIncrementSeed = -1
        Me.DsPlanilla1.Planilla.Id_PlanillaColumn.AutoIncrementStep = -1

        Me.DsPlanilla1.Planilla_Detalle.IdColumn.AutoIncrement = True
        Me.DsPlanilla1.Planilla_Detalle.IdColumn.AutoIncrementSeed = -1
        Me.DsPlanilla1.Planilla_Detalle.IdColumn.AutoIncrementStep = -1

        Me.DsPlanilla1.Planilla_Deducciones.IdColumn.AutoIncrement = True
        Me.DsPlanilla1.Planilla_Deducciones.IdColumn.AutoIncrementSeed = -1
        Me.DsPlanilla1.Planilla_Deducciones.IdColumn.AutoIncrementStep = -1

        'Tabla Planilla_Detalle
    End Sub

    Function CrearColumnas(ByVal Nombre As String, ByVal Titulo As String, ByVal Tamano As Int16, ByVal Orden As Int16, ByVal Campo As String, ByVal Numerico As Boolean, ByVal Editable As Boolean, ByVal Calculadora As Boolean)
        Dim Column = Me.GridView1.Columns.Add
        Column.Caption = Titulo
        Column.fieldname = Campo
        Column.Name = Nombre
        Column.VisibleIndex = Orden
        Column.width = Tamano
        If Numerico = True Then
            Column.displayformat.formattype = DevExpress.Utils.FormatType.Numeric
            Column.displayformat.formatstring = "#,#0.00"
        End If
        If Editable = False Then
            Column.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions) Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused
        Else
            Column.options = DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused
        End If
        If Calculadora = True Then
            Column.columnedit = RepositoryItemCalcEdit1
        End If
        'Me.GridView1.Columns.AddRange(Column)

    End Function

    Function CrearTabla()
        Dim i As Int16
        Dim j As Int16
        Me.TablaPlanilla.Clear()
        Me.TablaPlanilla.Columns.Clear()
        Me.CrearColumnas("Cedula", "C�dula", 150, 1, "Cedula", False, False, False)
        Me.TablaPlanilla.Columns.Add(New DataColumn("Cedula", GetType(String)))
        Me.CrearColumnas("Nombre", "Nombre del Empleado", 350, 2, "Nombre", False, False, False)
        Me.TablaPlanilla.Columns.Add(New DataColumn("Nombre", GetType(String)))

        Me.CrearColumnas("Moneda", "Moneda", 75, 3, "Moneda", False, False, False)
        Me.TablaPlanilla.Columns.Add(New DataColumn("Moneda", GetType(String)))

        Me.CrearColumnas("Salario", "Salario", 100, 4, "Salario", True, False, False)
        Me.TablaPlanilla.Columns.Add(New DataColumn("Salario", GetType(Double)))
        Me.CrearColumnas("Forma", "Forma Pago", 100, 5, "FormaPago", False, False, False)
        Me.TablaPlanilla.Columns.Add(New DataColumn("FormaPago", GetType(String)))

        Me.CrearColumnas("D�asDescontar", "D�asDescontar", 75, 6, "D�asDescontar", True, False, False)
        Me.TablaPlanilla.Columns.Add(New DataColumn("D�asDescontar", GetType(Double)))

        Me.CrearColumnas("Ordinarias", "H. Ordinarias", 125, 7, "Ordinarias", True, True, True)
        Me.TablaPlanilla.Columns.Add(New DataColumn("Ordinarias", GetType(Double)))
        Me.CrearColumnas("Extras", "H. Extras", 100, 8, "Extras", True, True, True)
        Me.TablaPlanilla.Columns.Add(New DataColumn("Extras", GetType(Double)))
        Me.CrearColumnas("Dobles", "H. Dobles", 100, 9, "Dobles", True, True, True)
        Me.TablaPlanilla.Columns.Add(New DataColumn("Dobles", GetType(Double)))
        Me.CrearColumnas("SalarioBruta", "Salario Bruto", 150, 10, "SalarioBruto", True, False, False)
        Me.TablaPlanilla.Columns.Add(New DataColumn("SalarioBruto", GetType(Double)))
        j = 11
        For i = 0 To Me.DsPlanilla1.Deducciones.Rows.Count - 1
            Me.CrearColumnas(Me.DsPlanilla1.Deducciones.Rows(i).Item("Descripcion").ToString, Me.DsPlanilla1.Deducciones.Rows(i).Item("Descripcion"), 125, j, Me.DsPlanilla1.Deducciones.Rows(i).Item("Descripcion").ToString, True, True, True)
            j = j + 1
            Me.TablaPlanilla.Columns.Add(New DataColumn(Me.DsPlanilla1.Deducciones.Rows(i).Item("Descripcion").ToString, GetType(Double)))
        Next
        Me.CrearColumnas("Adelantos", "Adelantos", 100, j, "Adelantos", True, False, False) : j = j + 1
        Me.TablaPlanilla.Columns.Add(New DataColumn("Adelantos", GetType(Double)))
        Me.CrearColumnas("Pr�stamos", "Pr�stamos", 125, j, "Prestamos", True, False, False) : j = j + 1 'cambio
        Me.TablaPlanilla.Columns.Add(New DataColumn("Prestamos", GetType(Double)))

        Me.CrearColumnas("Saldo", "Saldo Prestamos", 150, j, "Saldo", True, False, False) : j = j + 1 'modi
        Me.TablaPlanilla.Columns.Add(New DataColumn("Saldo", GetType(Double))) 'modi

        Me.CrearColumnas("Renta", "Renta", 100, j, "Renta", True, False, False) : j = j + 1
        Me.TablaPlanilla.Columns.Add(New DataColumn("Renta", GetType(Double)))
        Me.CrearColumnas("TotalDeducciones", "Total Deducciones", 175, j, "TotalDeducciones", True, False, False) : j = j + 1
        Me.TablaPlanilla.Columns.Add(New DataColumn("TotalDeducciones", GetType(Double)))
        Me.CrearColumnas("SalarioNeto", "Salario Neto", 150, j, "SalarioNeto", True, False, False)
        Me.TablaPlanilla.Columns.Add(New DataColumn("SalarioNeto", GetType(Double)))

    End Function

    Private Sub Desbloquear()
        'ComboBox1.Enabled = True
        dtFechaInicio.Enabled = True
        dtFechaFinal.Enabled = True
        CheckCierreMes.Enabled = True
        CheckAnulado.Enabled = True

        'txtUsuario.Enabled = True
    End Sub

    Private Sub Bloquear()
        'ComboBox1.Enabled = False
        dtFechaInicio.Enabled = False
        dtFechaFinal.Enabled = False
        CheckCierreMes.Enabled = False
        CheckAnulado.Enabled = False
        txtNumero.Text = ""
        txtNumero.ReadOnly = True
        'txtUsuario.Enabled = False
    End Sub

    Private Sub Nuevo()

        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            'cambia la imagen de nuevo y desabilita los botones
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Try 'inicia la edicion
                dtFechaInicio.Focus()
                Me.TablaPlanilla.Clear()
                Me.Label3.Text = ""
                Me.BindingContext(Me.DsPlanilla1.Planilla).CancelCurrentEdit()
                Me.BindingContext(Me.DsPlanilla1.Planilla).EndCurrentEdit()
                Me.BindingContext(Me.DsPlanilla1.Planilla).AddNew()
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = True
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.ToolBar1.Buttons(5).Enabled = False
                Me.dtFechaFinal.Value = Now
                Me.dtFechaInicio.Value = Now
                Me.GridControl1.Enabled = True
                'ComboBox1.Enabled = True
                NumeroPlanilla()
                Desbloquear()
                'Me.CargarDatos()
                dtFechaInicio.Focus()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1

                Me.Limpiar()
                Me.TablaPlanilla.Clear()
                Me.BindingContext(Me.DsPlanilla1, "Planilla_Detalle").CancelCurrentEdit()
                Me.BindingContext(Me.DsPlanilla1.Planilla).CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False
                Bloquear()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Sub

    Function CodigoEstado()
        Dim Cx As New Conexion

        'Dim Id_Cuenta As Integer = ComboBox1.SelectedValue
        Codigo = Cx.SlqExecuteScalar(Cx.Conectar("Estado_Empleado"), "SELECT Codigo  FROM Estado_Empleado  where Descripcion='Activo'")
        Cx.DesConectar(Cx.sQlconexion)
    End Function

    Private Sub CargarDatos()
        Dim dr As DataRow
        Dim contador As Integer
        Dim i, k As Integer : Dim J As Integer : Dim Z As Integer : Dim Y As Integer
        Dim HO, HE, HD, HO1, HE1, HD1, HorasTotales As Integer
        Dim FormaPagos, Descripcion, Descripcion1 As String
        Dim Fecha1, Fecha2 As Date
        Dim HorasD, HorasE, HorasO As Double
        Dim Tipo As Char
        Dim Estado_Civil As String
        Dim Ordinarias, Extras, Dobles, Salario, Salarios, SalarioBruto, Monto, Deduccion, TotalDeducciones, SalarioNeto, Total, Porcentaje1, Porcentaje2, Hijos As Double
        Dim Adelanto, Prestamo, Adelantos, Prestamos, MontoExento, MontoDe, MontoHasta, MontoAdelante, PEsposa, PHijo, Renta, Renta1, Renta2, Renta3, RentaTotal As Double
        Dim fechainicial, fechafinal, FECHA As String
        Me.adAdelantos.Fill(Me.DsPlanilla1, "Adelantos")
        Me.adAccion.Fill(Me.DsPlanilla1, "AccionPersonal")
        Me.AdOrdinarias.Fill(Me.DsPlanilla1, "Horas_Ordinarias")
        Me.adEmpleados.Fill(Me.DsPlanilla1.Empleado)
        Me.HorasTrabajadas.Fill(Me.DsPlanilla1.HorasTrabajadas)
        fechainicial = dtFechaInicio.Text
        fechafinal = dtFechaFinal.Text
        CodigoEstado()
        Me.TablaPlanilla.Clear()
        For i = 0 To Me.DsPlanilla1.Empleado.Rows.Count - 1
            If Me.DsPlanilla1.Empleado.Rows(i).Item("Cod_Estado") = Codigo Then  ' SE CARGAN SOLO LOS EMPLEADOS ACTIVOS
                dr = Me.TablaPlanilla.NewRow
                dr("Cedula") = Me.DsPlanilla1.Empleado.Rows(i).Item("Identificacion").ToString
                dr("Nombre") = Me.DsPlanilla1.Empleado.Rows(i).Item("Nombre").ToString
                dr("Salario") = Me.DsPlanilla1.Empleado.Rows(i).Item("Salario")
                If Me.DsPlanilla1.Empleado.Rows(i).Item("Hora") = True Then FormaPagos = "HORA"
                If Me.DsPlanilla1.Empleado.Rows(i).Item("Diario") = True Then FormaPagos = "DIARIO"
                If Me.DsPlanilla1.Empleado.Rows(i).Item("Semana") = True Then FormaPagos = "SEMANAL"
                If Me.DsPlanilla1.Empleado.Rows(i).Item("Quincena") = True Then FormaPagos = "QUINCENAL"
                If Me.DsPlanilla1.Empleado.Rows(i).Item("Mensual") = True Then FormaPagos = "MENSUAL"
                dr("FormaPago") = FormaPagos
                '''''''''''''''''''' AQUI '''''''''''
                'Dim moned As String = Me.DsPlanilla1.Empleado.Rows(i).Item("Cod_Moneda")
                'Moneda(moned)
                'dr("Moneda") = nombre
                '''''''''''''''''''''''''''''''''''''
                If Me.DsPlanilla1.Empleado.Rows(i).Item("Cod_Moneda") = 1 Then
                    dr("Moneda") = "COLON"
                Else
                    dr("Moneda") = "DOLAR"
                End If
                dr("D�asDescontar") = 0
                dr("Ordinarias") = Me.DsPlanilla1.Horas_Ordinarias.Rows(0).Item("Horas")
                dr("Extras") = 0
                dr("Dobles") = 0

                If FormaPagos = "HORA" Then

                    For J = 0 To Me.DsPlanilla1.HorasTrabajadas.Rows.Count - 1
                        Fecha1 = Me.DsPlanilla1.HorasTrabajadas.Rows(J).Item("Fecha")
                        If dr("Cedula") = Me.DsPlanilla1.HorasTrabajadas.Rows(J).Item("Identificacion") And Fecha1.Date >= Me.dtFechaInicio.Value.Date And Fecha1.Date <= Me.dtFechaFinal.Value.Date Then
                            HorasD = HorasD + Me.DsPlanilla1.HorasTrabajadas.Rows(J).Item("HoraDoble")
                            HorasE = HorasE + Me.DsPlanilla1.HorasTrabajadas.Rows(J).Item("HoraExtra")
                            HorasO = HorasO + Me.DsPlanilla1.HorasTrabajadas.Rows(J).Item("HoraOrdinaria")
                        End If
                    Next
                    If HorasO <> 0 Then
                        dr("Ordinarias") = HorasO
                        dr("Extras") = HorasE
                        dr("Dobles") = HorasD
                    End If

                    HorasE = 0
                    HorasD = 0
                    HorasO = 0

                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                dr("Adelantos") = 0
                dr("Prestamos") = 0
                dr("Saldo") = 0  'Modi
                Ordinarias = dr("Ordinarias")
                Extras = dr("Extras")
                Dobles = dr("Dobles")
                Salario = dr("Salario")
                Select Case FormaPagos
                    Case "HORA" : dr("SalarioBruto") = ((Ordinarias * Salario) + ((Extras * 1.5) * Salario) + (Salario * (2 * Dobles)))
                    Case "DIARIO"
                        Salarios = IIf(Ordinarias = 0, 0, Salario / Ordinarias)

                        dr("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                    Case "SEMANAL"
                        Salarios = (IIf(Ordinarias = 0, 0, Salario / (Ordinarias * 7)))
                        dr("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                    Case "QUINCENAL"
                        Salarios = IIf(Ordinarias = 0, 0, Salario / (15 * Ordinarias))
                        dr("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                    Case "MENSUAL"
                        Salarios = IIf(Ordinarias = 0, 0, Salario / (30 * Ordinarias))
                        dr("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                End Select

                SalarioBruto = dr("SalarioBruto")

                For J = 0 To Me.DsPlanilla1.Deducciones.Rows.Count - 1
                    dr(Me.DsPlanilla1.Deducciones.Rows(J).Item("Descripcion").ToString) = 0
                Next

                MontoDe = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("MontoDe")
                MontoHasta = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("MontoHasta")
                MontoExento = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("MontoExento")
                MontoAdelante = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("MontoEnAdelante")
                Porcentaje1 = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje1")
                Porcentaje2 = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje2")
                PHijo = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("Hijo")
                PEsposa = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("Esposa")

                For k = 0 To Me.DsPlanilla1.Empleado.Rows.Count - 1
                    If Me.DsPlanilla1.Empleado.Rows(k).Item("Identificacion") = dr("Cedula") Then
                        Estado_Civil = Me.DsPlanilla1.Empleado.Rows(k).Item("Estado_Civil")
                        Hijos = Me.DsPlanilla1.Empleado.Rows(k).Item("Hijos")
                        Exit For
                    End If

                Next

                If SalarioBruto <= MontoExento Then
                    dr("Renta") = 0
                Else
                    If SalarioBruto > MontoDe Then
                        Renta = SalarioBruto - MontoDe
                        Renta = (Renta * Porcentaje1) / 100
                    End If
                    If SalarioBruto > MontoAdelante Then
                        Renta1 = SalarioBruto - MontoAdelante
                        Renta1 = (Renta1 * Porcentaje2) / 100
                    End If

                    If Estado_Civil = "Casado" Then
                        Renta2 = PEsposa
                    End If

                    Renta3 = Hijos * PHijo
                    RentaTotal = (Renta + Renta1) - (Renta2 + Renta3)
                    dr("Renta") = RentaTotal
                End If
                TotalDeducciones = TotalDeducciones + RentaTotal
                dr("TotalDeducciones") = 0
                dr("SalarioNeto") = 0
                Me.TablaPlanilla.Rows.Add(dr)
                Descripcion = ""
                RentaTotal = 0
                TotalDeducciones = 0
                Adelanto = 0
                Adelantos = 0
                Prestamo = 0
                Prestamos = 0
                HO = 0
                HE = 0
                HD = 0
                HO1 = 0
                HE1 = 0
                HD1 = 0
                contador += 1 ' CUENTA LOS EMPLEADOS QUE FUERON CARGADOS
            End If
        Next

        Dim l As Integer = 0
        contador = contador - 1
        For l = 0 To contador ' SE MANDA A RECALCULAR LA PLANILLA PARA LOS EMPLEADOS CARGADOS
            Me.Recalcular_Fila_Planilla(l)
        Next

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(Usuario.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()

            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar informaci�n...", MsgBoxStyle.Information, "Atenci�n...") : Exit Sub

            Case 3 'Editar()

            Case 4
                If PMU.Update Then
                    Registrar()
                Else
                    MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atenci�n...") : Exit Sub
                End If

            Case 5 : Anular()

            Case 6 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atenci�n...") : Exit Sub

            Case 7 : If MessageBox.Show("�Desea Cerrar el M�dulo de Planilla?", "Atenci�n...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub Recalcular_Fila_Planilla(ByVal x As Integer)
        Dim Ordinarias, Extras, Dobles, Salario, Salarios, Monto, Deduccion, SalarioBruto, SalarioBruto2, Total, TotalDeducciones, Porcentaje1, Porcentaje2, Hijos As Double
        Dim MontoExento, MontoDe, MontoHasta, MontoAdelante, PEsposa, PHijo, Renta, Renta1, Renta2, Renta3, RentaTotal, Fijo As Double
        Dim J, k As Integer
        Dim Pagar As Double
        Dim Tipo As Char
        Dim Descripcion, Descripcion1 As String
        Dim Adelanto, Prestamo, Adelantos, Prestamos, DiasDescontados, DiasDescontados1, DiasDescontados2, Aumento, DeduccionHO As Double
        Dim saldos, saldo As Double
        Dim dr As DataRow
        Dim Estado_Civil As String

        If x >= 0 Then
            dr = Me.TablaPlanilla.NewRow
            Me.BindingContext(Me.TablaPlanilla).EndCurrentEdit()
            Ordinarias = TablaPlanilla.Rows(x).Item("Ordinarias")
            Extras = TablaPlanilla.Rows(x).Item("Extras")
            Dobles = TablaPlanilla.Rows(x).Item("Dobles")
            Salario = TablaPlanilla.Rows(x).Item("Salario")

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            For J = 0 To Me.DsPlanilla1.AccionPersonal.Rows.Count - 1
                Dim Id, n As Integer
                Dim Cuenta As String
                Dim FechaSalida, FechaEntrada As DateTime

                If Me.DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Empleado") = TablaPlanilla.Rows(x).Item("Cedula") Then
                    FechaSalida = dtFechaInicio.Text
                    FechaEntrada = Me.DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde")
                    If Me.dtFechaInicio.Text <= Me.DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And Me.dtFechaFinal.Text >= Me.DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                        DiasDescontados = DiasDescontados + Me.DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                        'TablaPlanilla.Rows(x).Item("D�asDescontar") = Me.DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                    End If
                End If
            Next
            TablaPlanilla.Rows(x).Item("D�asDescontar") = DiasDescontados
            DiasDescontados1 = DiasDescontados
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Select Case TablaPlanilla.Rows(x).Item("FormaPago")
                Case "HORA" : TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salario) + ((Extras * 1.5) * Salario) + (Salario * (2 * Dobles)))
                    DiasDescontados2 = DiasDescontados1 * (Salario * 8)
                    DeduccionHO = (Ordinarias * Salario)
                Case "DIARIO"
                    Salarios = (Salario / 8)
                    DiasDescontados2 = DiasDescontados1 * Salario
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                Case "SEMANAL"
                    Salarios = (Salario / 48)
                    DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                Case "QUINCENAL"
                    Salarios = (Salario / 96)
                    DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                Case "MENSUAL"
                    Salarios = (Salario / 192)
                    DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
            End Select

            For J = 0 To Me.DsPlanilla1.Empleado.Rows.Count - 1

                If TablaPlanilla.Rows(x).Item("FormaPago") = "QUINCENAL" And Me.DsPlanilla1.Empleado.Rows(J).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = Me.DsPlanilla1.Empleado.Rows(J).Item("Salario")
                    TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                End If
                If TablaPlanilla.Rows(x).Item("FormaPago") = "MENSUAL" And Me.DsPlanilla1.Empleado.Rows(J).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = Me.DsPlanilla1.Empleado.Rows(J).Item("Salario")
                    TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                End If
                If TablaPlanilla.Rows(x).Item("FormaPago") = "SEMANAL" And Me.DsPlanilla1.Empleado.Rows(J).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = Me.DsPlanilla1.Empleado.Rows(J).Item("Salario")
                    TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                End If
            Next
            SalarioBruto = TablaPlanilla.Rows(x).Item("SalarioBruto")


            For J = 0 To Me.DsPlanilla1.Empleado_Deducciones.Rows.Count - 1
                'Tipo = Me.DsPlanilla1.Deducciones.Rows(x).Item("Tipo")

                'Descripcion1 = Me.DsPlanilla1.Deducciones.Rows(x).Item("Descripcion")
                If TablaPlanilla.Rows(x).Item("Cedula") = Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Identificacion") Then
                    Tipo = Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Tipo")
                    'If Descripcion <> Me.DsPlanilla1.Empleado_Deducciones.Rows(i).Item("Descripcion") Then
                    Select Case Tipo
                        Case "V"
                            Total = Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Monto") 'original
                            'Total = Me.TablaPlanilla.Rows(x).Item("Monto")
                            Dim ee As Integer = Me.DsPlanilla1.Empleado_Deducciones.Rows.Count
                            Dim ii As Integer = TablaPlanilla.Rows.Count
                            'Total = TablaPlanilla.Rows(J).Item("Monto")
                            If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                If Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Cod_Moneda") = 1 Then
                                    Total = Total / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                End If
                            Else
                                If Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Cod_Moneda") = 2 Then
                                    Total = Total * Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                End If
                            End If

                            TablaPlanilla.Rows(x).Item(Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion").ToString) = Total
                            Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Monto") = Total  'psv
                            TotalDeducciones = TotalDeducciones + Total
                        Case "%"
                            Monto = Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Monto") 'original
                            'Monto = Me.TablaPlanilla.Rows(x).Item("Monto")'psv
                            Deduccion = ((Monto / 100) * TablaPlanilla.Rows(x).Item("SalarioBruto"))
                            TablaPlanilla.Rows(x).Item(Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion").ToString) = Deduccion
                            TotalDeducciones = TotalDeducciones + Deduccion
                    End Select
                    Descripcion = Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion")
                    ' End If
                End If
            Next

            For J = 0 To Me.DsPlanilla1.Adelantos.Rows.Count - 1

                Dim s1 As String = TablaPlanilla.Rows(x).Item("Cedula")
                Dim s As String = Me.DsPlanilla1.Adelantos.Rows(J).Item("Identificacion")
                If TablaPlanilla.Rows(x).Item("Cedula") = Me.DsPlanilla1.Adelantos.Rows(J).Item("Identificacion") Then
                    If Me.DsPlanilla1.Adelantos.Rows(J).Item("Anulado") = False Then
                        If Me.DsPlanilla1.Adelantos.Rows(J).Item("Adelanto") Then  'cambio =true

                            'Dim fecha As String = Me.DsPlanilla1.Adelantos.Rows(J).Item("FechaCobro")
                            'Dim arrayl As Array
                            'arrayl = fecha.Split(" ")
                            Dim fecha As Date
                            fecha = Me.DsPlanilla1.Adelantos.Rows(J).Item("FechaCobro")
                            'Me.DsPlanilla1.Adelantos.Rows(J).Item("FechaCobro")
                            If Me.dtFechaInicio.Text <= fecha.Date And Me.dtFechaFinal.Text >= fecha.Date Then

                                'If Me.dtFechaInicio.Text <= arrayl(0) And Me.dtFechaFinal.Text >= arrayl(0) Then
                                Adelanto = Me.DsPlanilla1.Adelantos.Rows(J).Item("Monto") 'Me.DsPlanilla1.Adelantos.Rows(J).Item("Monto") Cambios

                                If Adelanto > Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo") Then
                                    Adelanto = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                End If

                                If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                    If Me.DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 1 Then
                                        Adelanto = Adelanto / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")  'cambio 
                                        saldos = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo") / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                    End If
                                Else
                                    If Me.DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 2 Then
                                        Adelanto = Adelanto * Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                        saldos = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo") * Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio

                                    End If
                                    saldos = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                End If


                                Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").AddNew()
                                Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").Current("Id_Empleado") = TablaPlanilla.Rows(x).Item("Cedula")
                                Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").Current("Numero") = Me.DsPlanilla1.Adelantos.Rows(J).Item("Numero")
                                Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").Current("Tipo_Pago") = False
                                Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").Current("Monto") = Adelanto
                                Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").EndCurrentEdit()

                                Adelantos = Adelanto + Adelantos
                                saldo = saldo + saldos

                            End If
                        End If
                        If Me.DsPlanilla1.Adelantos.Rows(J).Item("Prestamo") = True Then
                            Prestamo = Me.DsPlanilla1.Adelantos.Rows(J).Item("DeducirxPago")     'Me.DsPlanilla1.Adelantos.Rows(J).Item("Monto")
                            saldos = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                            If Prestamo > saldos Then
                                Prestamo = saldos
                            End If
                            If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                If Me.DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 1 Then
                                    Prestamo = Prestamo / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'Cambio 
                                    saldos = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo") / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio

                                End If
                            Else
                                If Me.DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 2 Then
                                    Prestamo = Prestamo * Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                    saldos = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo") * Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                End If
                                saldos = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                            End If

                            Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").AddNew()
                            Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").Current("Id_Empleado") = TablaPlanilla.Rows(x).Item("Cedula")
                            Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").Current("Numero") = Me.DsPlanilla1.Adelantos.Rows(J).Item("Numero")
                            Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").Current("Tipo_Pago") = True
                            Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").Current("Monto") = Prestamo
                            Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").EndCurrentEdit()

                            saldo = saldo + saldos
                            Prestamos = Prestamos + Prestamo
                        End If
                    End If
                End If

            Next

            TablaPlanilla.Rows(x).Item("Adelantos") = Adelantos
            TablaPlanilla.Rows(x).Item("Prestamos") = Prestamos
            TablaPlanilla.Rows(x).Item("Saldo") = saldo
            TablaPlanilla.Rows(x).Item("Saldo") = TablaPlanilla.Rows(x).Item("Saldo") - Adelantos - Prestamos 'modi

            Fijo = 9900
            MontoDe = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("MontoDe")
            MontoHasta = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("MontoHasta")
            MontoExento = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("MontoExento")
            MontoAdelante = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("MontoEnAdelante")
            Porcentaje1 = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje1")
            Porcentaje2 = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje2")
            PHijo = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("Hijo")
            PEsposa = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("Esposa")
            For k = 0 To Me.DsPlanilla1.Empleado.Rows.Count - 1
                If Me.DsPlanilla1.Empleado.Rows(k).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                    Estado_Civil = Me.DsPlanilla1.Empleado.Rows(k).Item("Estado_Civil")
                    Hijos = Me.DsPlanilla1.Empleado.Rows(k).Item("Hijos")
                    Exit For
                End If

            Next

            If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                MontoDe = MontoDe / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                MontoHasta = MontoHasta / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                MontoExento = MontoExento / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                Fijo = Fijo / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                MontoAdelante = MontoAdelante / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                PHijo = PHijo / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                PEsposa = PEsposa / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
            End If
            Cedula = TablaPlanilla.Rows(x).Item("Cedula")
            If CheckCierreMes.Checked = True Then

                ParametroRenta()
                SalarioBruto2 = SalarioBruto + Pagomes

                If SalarioBruto2 <= MontoExento Then
                    TablaPlanilla.Rows(x).Item("Renta") = 0
                Else
                    If SalarioBruto2 > MontoDe And SalarioBruto2 < MontoAdelante Then
                        Renta = SalarioBruto2 - MontoDe
                        Renta = (Renta * Porcentaje1) / 100
                    End If

                    If SalarioBruto2 > MontoAdelante Then
                        Renta = Fijo
                        Renta1 = SalarioBruto2 - MontoAdelante
                        Renta1 = (Renta1 * Porcentaje2) / 100
                    End If

                    If Estado_Civil = "Casado" Then
                        Renta2 = PEsposa
                    Else
                        Renta2 = 0
                    End If

                    Renta3 = Hijos * PHijo
                    RentaTotal = (Renta + Renta1) - (Renta2 + Renta3)
                    If RentaTotal <= 0 Then
                        RentaTotal = 0
                    End If
                    TablaPlanilla.Rows(x).Item("Renta") = RentaTotal
                End If
            Else
                TablaPlanilla.Rows(x).Item("Renta") = 0
            End If
            TotalDeducciones = TotalDeducciones + RentaTotal + Adelantos + Prestamos '+ DiasDescontados2
            TablaPlanilla.Rows(x).Item("TotalDeducciones") = TotalDeducciones
            TablaPlanilla.Rows(x).Item("SalarioNeto") = SalarioBruto - TotalDeducciones
            Descripcion = ""
            TotalDeducciones = 0
            Deduccion = 0
            Pagomes = 0
            DiasDescontados = 0
            DiasDescontados1 = 0
            DiasDescontados2 = 0
            Aumento = 0
        End If
    End Sub

    Function ParametroRenta()
        Dim funcion As New cFunciones
        Dim Id, n, Mes1, Mes2 As Integer
        Dim Cuenta As String
        Dim FechaSalida, FechaEntrada As DateTime
        funcion.Llenar_Tabla_Generico("Select * from Planilla", Me.TablaRenta, Me.SqlConnection1.ConnectionString)
        For n = 0 To Me.TablaRenta.Rows.Count - 1
            FechaSalida = dtFechaInicio.Text
            FechaEntrada = TablaRenta.Rows(n).Item("FechaInicial")
            Mes1 = FechaSalida.Month
            Mes2 = FechaEntrada.Month
            If Mes1 = Mes2 Then
                Id = TablaRenta.Rows(n).Item("Id_Planilla")
                ParametroRent(Id)
                'Exit Function
            End If
        Next
        Return True
    End Function

    Function ParametroRent(ByVal Id As Integer)
        Dim funcion As New cFunciones
        Dim n, Mes1, Mes2 As Integer
        Dim Cuenta As String
        funcion.Llenar_Tabla_Generico("Select * from Planilla_Detalle", Me.TablaRenta1, Me.SqlConnection1.ConnectionString)
        For n = 0 To Me.TablaRenta1.Rows.Count - 1
            If Id = TablaRenta1.Rows(n).Item("Id_Planilla") And TablaRenta1.Rows(n).Item("Cedula") = Cedula Then
                Pagomes = Pagomes + TablaRenta1.Rows(n).Item("SalarioBruto")
                Exit Function
            End If
        Next
        Return True
    End Function

    Private Sub GridControl1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyUp
        If e.KeyCode = Keys.Enter Then Me.Recalcular_Fila_Saldo(Me.BindingContext(TablaPlanilla).Position())
        'Me.Recalcular_Fila_Planilla(Me.BindingContext(TablaPlanilla).Position())
        If e.KeyCode = Keys.F1 Then
            Dim Fx As New cFunciones
            Dim valor As String
            valor = Fx.BuscarDatos("Select Identificacion, Nombre from Empleado", "Nombre", "Buscar Empleado...")
        End If

    End Sub

    Private Sub Registrar()
        Try
            Me.ToolBar1.Buttons(3).Enabled = False
            If MessageBox.Show("�Desea Guardar los Cambios en la Planilla?", "Atenci�n...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar el activo
                Me.ToolBar1.Buttons(3).Enabled = True
                Exit Sub
            End If
            Me.BindingContext(Me.DsPlanilla1.Planilla).Current("FechaInicial") = Me.dtFechaInicio.Value
            Me.BindingContext(Me.DsPlanilla1.Planilla).Current("FechaFinal") = Me.dtFechaFinal.Value

            Dim n As Integer

            For n = 0 To DsPlanilla1.Adelantos.Count - 1
                Dim sql As String
                Dim clsConexion As New Conexion
                Dim cnnConexion As New System.Data.SqlClient.SqlConnection
                sql = "UPDATE Adelantos SET Saldo = " & DsPlanilla1.Adelantos(n).Saldo & " WHERE Numero =" & DsPlanilla1.Adelantos(n).Numero
                cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
                cnnConexion.Open()
                clsConexion.SlqExecute(cnnConexion, sql)
                cnnConexion.Close()
            Next

            'adPlanilla.Update(DsPlanilla1.Planilla)
            ' DsPlanilla1.AcceptChanges()

            Me.BindingContext(Me.DsPlanilla1.Planilla).EndCurrentEdit()
            CargarPlanilla()


            'DsPlanilla1.AcceptChanges()

            If Me.Registrar_Planilla() Then  'se registra en la base de datos then

                Me.DsPlanilla1.AcceptChanges()

                Me.ToolBar1.Buttons(1).Enabled = True

                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0

                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                Limpiar()
                Me.TablaPlanilla.Clear()
                Me.DsProyecto.Proyecto.Clear()
                Me.ToolBar1.Buttons(4).Enabled = False
                Bloquear()
            Else
                MsgBox("Error al Registrar", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(3).Enabled = True
            End If

        Catch ex As System.Exception
            Me.ToolBar1.Buttons(3).Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atenci�n...")
        End Try
    End Sub

    Function NumeroPlanilla()
        Dim Cx As New Conexion

        'Dim Id_Cuenta As Integer = ComboBox1.SelectedValue
        NumeroPlanilla1 = Cx.SlqExecuteScalar(Cx.Conectar("Planilla"), "SELECT ISNULL(MAX(Id_Planilla), 0) + 1  FROM Planilla  ")
        Cx.DesConectar(Cx.sQlconexion)
        Me.txtNumero.Text = NumeroPlanilla1
    End Function

    Function CargarPlanilla()
        Dim i, J, n As Integer
        Dim Descripcion1 As String
        Me.adEmpleados.Fill(Me.DsPlanilla1.Empleado)

        For i = 0 To Me.TablaPlanilla.Rows.Count - 1
            'Me.BindingContext(Me.DsPlanilla1, "Planilla").AddNew()
            'Me.BindingContext(Me.DsPlanilla1, "Planilla").Current("Id_Planilla") = txtNumero.Text
            '000Me.BindingContext(Me.DsPlanilla1.Planilla).EndCurrentEdit()
            Me.BindingContext(Me.DsPlanilla1.Planilla).EndCurrentEdit()
            adPlanilla.Update(DsPlanilla1.Planilla)
            'DsPlanilla1.AcceptChanges()
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").AddNew()
            ' If NumeroPlanilla1 = Nothing Then
            ' Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Id_Planilla") = Me.txtNumero.Text '''''aqui
            ' Else
            '    Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Id_Planilla") = CDbl(NumeroPlanilla1) '''''aqui
            'End If
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Id_Planilla") = CDbl(NumeroPlanilla1)
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Cedula") = TablaPlanilla.Rows(i).Item("Cedula")
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Nombre") = TablaPlanilla.Rows(i).Item("Nombre")
            For n = 0 To Me.DsPlanilla1.Empleado.Rows.Count - 1
                If TablaPlanilla.Rows(i).Item("Cedula") = Me.DsPlanilla1.Empleado.Rows(n).Item("Identificacion") Then
                    Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Puesto") = Me.DsPlanilla1.Empleado.Rows(n).Item("Puesto")
                End If
            Next

            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Salario") = TablaPlanilla.Rows(i).Item("Salario")
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("FormaPago") = TablaPlanilla.Rows(i).Item("FormaPago")
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Ordinaria") = TablaPlanilla.Rows(i).Item("Ordinarias")
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Extra") = TablaPlanilla.Rows(i).Item("Extras")
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Doble") = TablaPlanilla.Rows(i).Item("Dobles")
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("SalarioBruto") = TablaPlanilla.Rows(i).Item("SalarioBruto")
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Adelantos") = TablaPlanilla.Rows(i).Item("Adelantos")
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Prestamos") = TablaPlanilla.Rows(i).Item("Prestamos")
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Renta") = TablaPlanilla.Rows(i).Item("Renta")
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("TotalDeducciones") = TablaPlanilla.Rows(i).Item("TotalDeducciones")
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("SalarioNeto") = TablaPlanilla.Rows(i).Item("SalarioNeto")
            If TablaPlanilla.Rows(i).Item("Moneda") = "COLON" Then
                Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Cod_Moneda") = 1 'Me.DsPlanilla1.Empleado.Rows(i).Item("Cod_Moneda")
            Else
                Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Cod_Moneda") = 2
            End If
            Me.BindingContext(Me.DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").EndCurrentEdit()
        Next
        For i = 0 To Me.TablaPlanilla.Rows.Count - 1
            For J = 0 To Me.DsPlanilla1.Deducciones.Rows.Count - 1
                Descripcion1 = Me.DsPlanilla1.Deducciones.Rows(J).Item("Descripcion")
                Me.BindingContext(Me.DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").AddNew()
                Me.BindingContext(Me.DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Id_PlanillaDetalle") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Id")
                Me.BindingContext(Me.DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Cod_Deduccion") = Me.DsPlanilla1.Deducciones.Rows(J).Item("Codigo")
                Me.BindingContext(Me.DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Nombre") = Me.DsPlanilla1.Deducciones.Rows(J).Item("Descripcion")
                Me.BindingContext(Me.DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Monto") = TablaPlanilla.Rows(i).Item(Descripcion1)
                If TablaPlanilla.Rows(i).Item("Moneda") = "COLON" Then
                    Me.BindingContext(Me.DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Cod_Moneda") = 1 'Me.DsPlanilla1.Empleado.Rows(i).Item("Cod_Moneda")
                Else
                    Me.BindingContext(Me.DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Cod_Moneda") = 2
                End If
                'Me.BindingContext(Me.DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Cod_Moneda") = Me.DsPlanilla1.Empleado.Rows(i).Item("Cod_Moneda")
                Me.BindingContext(Me.DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").EndCurrentEdit()
            Next
        Next


    End Function

    Function Registrar_Planilla() As Boolean

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.adPlanilla.InsertCommand.Transaction = Trans
            Me.adPlanilla.UpdateCommand.Transaction = Trans
            Me.adPlanilla.DeleteCommand.Transaction = Trans
            Me.adPlanilla.SelectCommand.Transaction = Trans
            adPlanilla.Update(Me.DsPlanilla1.Planilla) ''

            Me.adPlanillaDetalle.InsertCommand.Transaction = Trans
            Me.adPlanillaDetalle.UpdateCommand.Transaction = Trans
            Me.adPlanillaDetalle.DeleteCommand.Transaction = Trans
            Me.adPlanillaDetalle.SelectCommand.Transaction = Trans
            adPlanillaDetalle.Update(Me.DsPlanilla1.Planilla_Detalle)

            Me.adPlanillaDeducciones.InsertCommand.Transaction = Trans
            Me.adPlanillaDeducciones.UpdateCommand.Transaction = Trans
            Me.adPlanillaDeducciones.DeleteCommand.Transaction = Trans
            Me.adPlanillaDeducciones.SelectCommand.Transaction = Trans
            adPlanillaDeducciones.Update(Me.DsPlanilla1.Planilla_Deducciones)

            'Me.adAdelantos.InsertCommand.Transaction = Trans
            'Me.adAdelantos.UpdateCommand.Transaction = Trans
            'Me.adAdelantos.DeleteCommand.Transaction = Trans
            'Me.adAdelantos.SelectCommand.Transaction = Trans
            'adAdelantos.Update(Me.DsPlanilla1.Adelantos)

            'Me.AdAdelanto_Detalle.InsertCommand.Transaction = Trans
            'Me.AdAdelanto_Detalle.UpdateCommand.Transaction = Trans
            'Me.AdAdelanto_Detalle.DeleteCommand.Transaction = Trans
            'Me.AdAdelanto_Detalle.SelectCommand.Transaction = Trans
            'AdAdelanto_Detalle.Update(Me.DsPlanilla1.Adelantos_Detalle)


            Me.DsPlanilla1.AcceptChanges() '''aqui
            Trans.Commit()
            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0


            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox("No se puede eliminar, o error de red", MsgBoxStyle.Critical)


            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function

    Function Limpiar()
        ' ComboBox1.Text = ""
        txtNumero.Text = ""
        dtFechaInicio.Value = Now()
        dtFechaFinal.Value = Now()
        CheckCierreMes.Checked = False
        CheckAnulado.Checked = False
    End Function

    Sub Buscar()
        Try
            Dim Fx As New cFunciones
            Dim Id As String
            Dim pos As Integer
            Dim vista As DataView
            'Id = Fx.BuscarDatos("Select Id_Planilla, Fecha, FechaInicial, FechaFinal from Planilla", "Id_Planilla", "Buscar Planilla...")
            Id = Fx.BuscarDatos("Select Id_Planilla, cast(dbo.DateOnly(FechaInicial) as varchar(11)) + '  -  ' + cast(dbo.DateOnly(FechaFinal) as varchar(11))  AS Periodo  from Planilla", "Id_Planilla", "Buscar Planilla...")
            If Id = "" Or Id = "0" Then
                Exit Sub
            Else
                IdPlanilla1 = Id
                Me.LlenarPlanilla(Id)
                Me.ToolBar1.Buttons(4).Enabled = True
                Me.ToolBar1.Buttons(5).Enabled = True
                Me.ToolBar1.Buttons(3).Enabled = False
            End If
            Me.GridControl1.Enabled = False

            Calcula_Total()
        Catch ex As SystemException

            MsgBox(ex.Message)
        End Try

    End Sub

    Function Registrar_Anulacion() As Boolean
        Dim i As Long
        Dim Funciones As New Conexion
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            'Me.adPlanilla.InsertCommand.Transaction = Trans
            Me.SqlUpdateCommand1.Transaction = Trans
            'Me.adPlanilla.DeleteCommand.Transaction = Trans
            'Me.adPlanilla.SelectCommand.Transaction = Trans
            Me.adPlanilla.Update(DsPlanilla1, "Planilla")
            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Sub Anular()
        Dim resp As Integer
        Dim i, j As Integer
        Dim Cconexion As New Utilidades.Conexion
        Dim Resultado As String

        Try 'se intenta hacer
            If Me.CheckAnulado.CheckState = CheckState.Unchecked Then

                If Me.BindingContext(Me.DsPlanilla1, "Planilla").Count > 0 Then

                    resp = MessageBox.Show("�Desea Realmente Anular esta planilla?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                    If resp = 6 Then

                        '
                        For j = 0 To Me.DsPlanilla1.Planilla.Rows.Count - 1
                            If Me.DsPlanilla1.Planilla.Rows(j).Item("Id_Planilla") = Me.txtNumero.Text Then
                                Me.DsPlanilla1.Planilla.Rows(j).Item("Anulado") = True
                            End If
                        Next
                        CheckAnulado.Checked = True
                        Me.BindingContext(Me.DsPlanilla1, "Planilla").EndCurrentEdit()
                        If Registrar_Anulacion() Then
                            Me.DsPlanilla1.Planilla.AcceptChanges()
                        End If
                        '

                        For i = 0 To Me.TablaPlanilla.Rows.Count - 1
                            If Me.TablaPlanilla.Rows(i).Item("Adelantos") <> 0 Then
                                For j = 0 To Me.DsPlanilla1.Adelantos.Rows.Count - 1
                                    If Me.TablaPlanilla.Rows(i).Item("Cedula") = Me.DsPlanilla1.Adelantos.Rows(j).Item("Identificacion") And Me.DsPlanilla1.Adelantos.Rows(j).Item("Adelanto") = True Then
                                        Me.DsPlanilla1.Adelantos.Rows(j).Item("Saldo") = Me.DsPlanilla1.Adelantos.Rows(j).Item("Saldo") + Me.TablaPlanilla.Rows(i).Item("Adelantos")
                                        'Me.DsPlanilla1.Adelantos.Rows(j).Item("Saldo") = Me.DsPlanilla1.Adelantos.Rows(j).Item("Monto")
                                    End If
                                Next
                            End If
                        Next

                        For i = 0 To Me.TablaPlanilla.Rows.Count - 1
                            If Me.TablaPlanilla.Rows(i).Item("Prestamos") <> 0 Then
                                For j = 0 To Me.DsPlanilla1.Adelantos.Rows.Count - 1
                                    If Me.TablaPlanilla.Rows(i).Item("Cedula") = Me.DsPlanilla1.Adelantos.Rows(j).Item("Identificacion") And Me.DsPlanilla1.Adelantos.Rows(j).Item("Prestamo") = True Then
                                        Me.DsPlanilla1.Adelantos.Rows(j).Item("Saldo") = Me.DsPlanilla1.Adelantos.Rows(j).Item("Saldo") + Me.TablaPlanilla.Rows(i).Item("Prestamos")
                                        'Me.DsPlanilla1.Adelantos.Rows(j).Item("Saldo") = Me.DsPlanilla1.Adelantos.Rows(j).Item("Monto")
                                    End If
                                Next
                            End If
                        Next


                        Me.Registrar_Planilla()

                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False
                        Me.ToolBar1.Buttons(0).Enabled = True
                        MessageBox.Show("La planilla ha sido anulada", "Atenci�n...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TablaPlanilla.Clear()
                        Limpiar()
                        Bloquear()
                    Else
                        Me.BindingContext(Me.DsPlanilla1, "Planilla").CancelCurrentEdit()
                    End If
                Else
                    MsgBox("No Existen Planillas", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("La Planilla ya Esta Anulada, No es Posible Anular Nuevamnete", MsgBoxStyle.Information)
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Loggin_Usuario() As Boolean
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        Try


            If TextBox2.Text <> "" Then
                'rs = cConexion.GetRecorset(Conectando, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & TextBox2.Text & "'")
                rs = cConexion.GetRecorset(cConexion.Conectar2, "SELECT Id_Usuario, Nombre from Usuarios where Clave_Interna ='" & TextBox2.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atenci�n...")
                    TextBox2.Focus()
                    TextBox2.Text = ""
                    Return False
                End If
                While rs.Read
                    Try
                        NombreUsuario = rs("Nombre")
                        'Cedula_usuario = rs("Cedula")
                        Cedula_usuario = rs("Id_Usuario")
                        txtNombreUsuario.Text = rs("Nombre")
                        TextBox2.Enabled = False
                        ToolBar1.Buttons(0).Enabled = True
                        ToolBar1.Buttons(1).Enabled = True
                        dtFechaInicio.Focus()
                        'Me.DsPlanilla1.Planilla.Ced_UsuarioColumn.DefaultValue = rs("Cedula")
                        Me.DsPlanilla1.Planilla.Ced_UsuarioColumn.DefaultValue = rs("Id_Usuario")
                        Me.DsPlanilla1.Planilla.Nombre_UsuarioColumn.DefaultValue = rs("Nombre")
                        Me.DsPlanilla1.Planilla.FechaColumn.DefaultValue = Now.Date
                        Return True

                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.Conectar)
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                TextBox2.Focus()
            End If

            'If Me.BindingContext(Me.DsPlanilla1.Usuarios).Count > 0 Then
            '    Dim Usuario_autorizadores() As System.Data.DataRow
            '    Dim Usua As System.Data.DataRow
            '    Usuario_autorizadores = Me.DsPlanilla1.Usuarios.Select("Clave_Interna ='" & TextBox2.Text & "'")
            '    If Usuario_autorizadores.Length <> 0 Then
            '        Usua = Usuario_autorizadores(0)
            '        txtNombreUsuario.Text = Usua("Nombre")
            '        NombreUsuario = Usua("Nombre")
            '        Cedula_usuario = Usua("Cedula")
            '        Me.DsPlanilla1.Planilla.Ced_UsuarioColumn.DefaultValue = Usua("Cedula")
            '        Me.DsPlanilla1.Planilla.Nombre_UsuarioColumn.DefaultValue = Usua("Nombre")
            '        Me.DsPlanilla1.Planilla.FechaColumn.DefaultValue = Now.Date
            '        TextBox2.Enabled = False ' se inabilita el campo de la contrase�a
            '        ToolBar1.Buttons(0).Enabled = True
            '        ToolBar1.Buttons(1).Enabled = True
            '        txtNumero.Focus()
            '        Return True
            '    Else ' si no existe una contrase�la como esta
            '        MsgBox("Contrase�a interna incorrecta", MsgBoxStyle.Exclamation)
            '        TextBox2.Text = ""
            '        Return False
            '    End If
            'Else
            '    MsgBox("No Existen Usuarios, Ingrese datos")
            'End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
    Function Moneda(ByVal a As String)
        Dim Cx As New Conexion
        nombre = Cx.SlqExecuteScalar(Cx.Conectar("Seguridad"), "SELECT MonedaNombre  FROM Moneda where CodMoneda=" & a)
        Cx.DesConectar(Cx.sQlconexion)
    End Function
    Public Function Conectando() As SqlConnection
        'Dim strConexion As String
        Dim sQlconexion As New SqlConnection
        Dim SQLStringConexion As String
        If sQlconexion.State <> ConnectionState.Open Then
            SQLStringConexion = GetSetting("Seesoft", "Planilla", "Conexion")
            sQlconexion.ConnectionString = SQLStringConexion
            sQlconexion.Open()
        Else
        End If
        Return sQlconexion
    End Function

    Function LlenarPlanilla(ByVal Id As String)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim x As Integer
        Dim saldoA
        Dim cConexion As New Conexion
        'Dentro de un Try/Catch por si se produce un error
        Me.TablaPlanilla.Clear()
        Try

            Me.adPlanilla.Fill(Me.DsPlanilla1.Planilla)

            For x = 0 To Me.DsPlanilla1.Planilla.Rows.Count - 1
                If Me.DsPlanilla1.Planilla.Rows(x).Item("Id_Planilla") = Id Then
                    txtNumero.Text = Id
                    dtFechaInicio.Text = Me.DsPlanilla1.Planilla.Rows(x).Item("FechaInicial")
                    dtFechaFinal.Text = Me.DsPlanilla1.Planilla.Rows(x).Item("FechaFinal")
                    Me.CheckCierreMes.Checked = Me.DsPlanilla1.Planilla.Rows(x).Item("CierreMes")
                    Me.CheckAnulado.Checked = Me.DsPlanilla1.Planilla.Rows(x).Item("Anulado")
                End If

            Next
            Me.adPlanillaDetalle.Fill(Me.DsPlanilla1, "Planilla_Detalle")
            Me.adPlanillaDeducciones.Fill(Me.DsPlanilla1, "Planilla_Deducciones")
            Dim i, J As Integer
            Dim dr As DataRow
            Dim Descripcion1, Descripcion As String
            dr = Me.TablaPlanilla.NewRow

            For i = 0 To Me.DsPlanilla1.Planilla_Detalle.Rows.Count - 1
                If Id = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Id_Planilla") Then
                    dr = Me.TablaPlanilla.NewRow
                    dr("Cedula") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Cedula")
                    dr("Nombre") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Nombre")

                    '''''''''''''''''''' AQUI '''''''''''
                    'Dim moned As String = Me.DsPlanilla1.Empleado.Rows(i).Item("Cod_Moneda")
                    'Moneda(moned)
                    'dr("Moneda") = nombre
                    '''''''''''''''''''''''''''''''''''''
                    If Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Cod_Moneda") = 1 Then
                        dr("Moneda") = "COLON"
                    End If
                    If Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Cod_Moneda") = 2 Then
                        dr("Moneda") = "DOLAR"
                    End If
                    If Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Cod_Moneda") = 3 Then
                        dr("Moneda") = "EUROS"
                    End If
                    dr("Salario") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Salario")
                    dr("FormaPago") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("FormaPago")
                    dr("Ordinarias") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Ordinaria")
                    dr("Extras") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Extra")
                    dr("Dobles") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Doble")
                    dr("SalarioBruto") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("SalarioBruto")
                    dr("Adelantos") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Adelantos")
                    dr("Prestamos") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Prestamos")
                    dr("Renta") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Renta")
                    dr("TotalDeducciones") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("TotalDeducciones")
                    dr("SalarioNeto") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("SalarioNeto")

                    For J = 0 To Me.DsPlanilla1.Adelantos.Rows.Count - 1
                        If Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Cedula") = Me.DsPlanilla1.Adelantos.Rows(J).Item("Identificacion") Then
                            saldoA = saldoA + Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                        End If
                    Next
                    If saldoA = Nothing Then
                        dr("Saldo") = 0
                    Else
                        dr("Saldo") = saldoA
                    End If
                    saldoA = 0
                    dr("D�asDescontar") = 0
                    For J = 0 To Me.DsPlanilla1.Planilla_Deducciones.Rows.Count - 1
                        If Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Id") = Me.DsPlanilla1.Planilla_Deducciones.Rows(J).Item("Id_PlanillaDetalle") Then
                            Descripcion1 = Me.DsPlanilla1.Planilla_Deducciones.Rows(J).Item("Nombre")
                            dr(Descripcion1) = Me.DsPlanilla1.Planilla_Deducciones.Rows(J).Item("Monto")
                        End If
                    Next
                    Me.TablaPlanilla.Rows.Add(dr)
                End If

                For J = 0 To Me.DsPlanilla1.AccionPersonal.Rows.Count - 1
                    Dim n, Mes1, Mes2 As Integer
                    Dim Cuenta As String
                    Dim FechaSalida, FechaEntrada As DateTime

                    If Me.DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Empleado") = Me.DsPlanilla1.Planilla_Detalle.Rows(i).Item("Cedula") Then
                        FechaSalida = dtFechaInicio.Text
                        FechaEntrada = Me.DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde")
                        Mes1 = FechaSalida.Month
                        Mes2 = FechaEntrada.Month
                        If Mes1 = Mes2 Then
                            dr("D�asDescontar") = Me.DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")

                        End If
                    End If
                Next
            Next
        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection est� iniciado,
            ' de ser as�, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function

    Private Sub Imprimir()
        Try
            FechaF = dtFechaFinal.Text
            FechaI = dtFechaInicio.Text
            IdPlanilla = CDbl(txtNumero.Text)
            Rept = 1
            CargarForm(New FrmReportes)
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
        Rept = 1
    End Sub

    Private Sub CargarForm(ByVal Form As Form)
        Try
            'Form.MdiParent = Me
            Form.Left = (Screen.PrimaryScreen.WorkingArea.Width - Form.Width) \ 2
            Form.Top = (Screen.PrimaryScreen.WorkingArea.Height - Form.Height) \ 2

            Form.Show()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Me.Loggin_Usuario() Then
            End If
        End If
    End Sub

    Function LlenarEmpleados(ByVal Id As Long)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Try

            '''''''''LLENAR EMPLEADOS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexi�n adecuada
            Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Empleado INNER JOIN Empleado_Proyecto ON Empleado.Identificacion = Empleado_Proyecto.Identificacion and Empleado_Proyecto.Id_Proyecto = @Id"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los par�metros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.Int))
            cmdv.Parameters("@Id").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selecci�n
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DsPlanilla1, "Empleado")

        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection est� iniciado,
            ' de ser as�, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try

    End Function

    Function LlenarHorasT(ByVal Id As Long)
        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        'Dentro de un Try/Catch por si se produce un error
        Try

            '''''''''LLENAR EMPLEADOS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexi�n adecuada
            Dim fechainicial, fechafinal As String
            fechainicial = dtFechaInicio.Text
            fechafinal = dtFechaFinal.Text
            Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            'Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM HorasTrabajadas where Fecha >= @fechainicial AND Fecha <=  @fechafinal"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90

            cmd.Parameters.Add(New SqlParameter("@fechainicial", SqlDbType.DateTime))
            cmd.Parameters.Add(New SqlParameter("@fechafinal", SqlDbType.DateTime))

            cmd.Parameters("@fechainicial").Value = fechainicial
            cmd.Parameters("@fechafinal").Value = fechafinal

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(Me.DsPlanilla1.HorasTrabajadas)
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally

            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function


    Private Sub Recalcular_Fila_Saldo(ByVal x As Integer)

        Dim Ordinarias, Extras, Dobles, Salario, Salarios, Monto, Deduccion, SalarioBruto, SalarioBruto2, Total, TotalDeducciones, Porcentaje1, Porcentaje2, Hijos As Double
        Dim MontoExento, MontoDe, MontoHasta, MontoAdelante, PEsposa, PHijo, Renta, Renta1, Renta2, Renta3, RentaTotal As Double
        Dim J, k, h As Integer
        Dim Pagar As Double
        Dim Tipo As Char
        Dim Estado_Civil As String
        Dim Descripcion, Descripcion1 As String
        Dim Adelanto, Prestamo, Adelantos, Prestamos, DiasDescontados, DiasDescontados1, DiasDescontados2, Aumento, DeduccionHO As Double
        Dim saldos, saldo, fijo As Double
        Dim dr As DataRow

        If x >= 0 Then
            Try
                dr = Me.TablaPlanilla.NewRow
                Me.BindingContext(Me.TablaPlanilla).EndCurrentEdit()
                Ordinarias = TablaPlanilla.Rows(x).Item("Ordinarias")
                Extras = TablaPlanilla.Rows(x).Item("Extras")
                Dobles = TablaPlanilla.Rows(x).Item("Dobles")
                Salario = TablaPlanilla.Rows(x).Item("Salario")

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                For J = 0 To Me.DsPlanilla1.AccionPersonal.Rows.Count - 1
                    Dim Id, n As Integer
                    Dim Cuenta As String
                    Dim FechaSalida, FechaEntrada As DateTime

                    If Me.DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Empleado") = TablaPlanilla.Rows(x).Item("Cedula") Then
                        FechaSalida = dtFechaInicio.Text
                        FechaEntrada = Me.DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde")
                        If Me.dtFechaInicio.Text <= Me.DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And Me.dtFechaFinal.Text >= Me.DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                            DiasDescontados = DiasDescontados + Me.DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                            'TablaPlanilla.Rows(x).Item("D�asDescontar") = Me.DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                        End If
                    End If
                Next
                TablaPlanilla.Rows(x).Item("D�asDescontar") = DiasDescontados
                DiasDescontados1 = DiasDescontados
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Select Case TablaPlanilla.Rows(x).Item("FormaPago")
                    Case "HORA" : TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salario) + ((Extras * 1.5) * Salario) + (Salario * (2 * Dobles)))
                        DiasDescontados2 = DiasDescontados1 * (Salario * 8)
                        DeduccionHO = (Ordinarias * Salario)
                    Case "DIARIO"
                        Salarios = (Salario / 8)
                        DiasDescontados2 = DiasDescontados1 * Salario
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                    Case "SEMANAL"
                        Salarios = (Salario / 48)
                        DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                    Case "QUINCENAL"
                        Salarios = (Salario / 96)
                        DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                    Case "MENSUAL"
                        Salarios = (Salario / 192)
                        DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                End Select
                For J = 0 To Me.DsPlanilla1.Empleado.Rows.Count - 1

                    If TablaPlanilla.Rows(x).Item("FormaPago") = "QUINCENAL" And Me.DsPlanilla1.Empleado.Rows(J).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = Me.DsPlanilla1.Empleado.Rows(J).Item("Salario")
                        TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                    End If
                    If TablaPlanilla.Rows(x).Item("FormaPago") = "MENSUAL" And Me.DsPlanilla1.Empleado.Rows(J).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = Me.DsPlanilla1.Empleado.Rows(J).Item("Salario")
                        TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                    End If
                    If TablaPlanilla.Rows(x).Item("FormaPago") = "SEMANAL" And Me.DsPlanilla1.Empleado.Rows(J).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = Me.DsPlanilla1.Empleado.Rows(J).Item("Salario")
                        TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                    End If
                Next
                SalarioBruto = TablaPlanilla.Rows(x).Item("SalarioBruto")
                'SalarioBruto = SalarioBruto - DiasDescontados2

                For J = 0 To Me.DsPlanilla1.Empleado_Deducciones.Rows.Count - 1
                    'Tipo = Me.DsPlanilla1.Deducciones.Rows(x).Item("Tipo")

                    'Descripcion1 = Me.DsPlanilla1.Deducciones.Rows(x).Item("Descripcion")
                    If TablaPlanilla.Rows(x).Item("Cedula") = Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Identificacion") Then
                        Tipo = Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Tipo")
                        'If Descripcion <> Me.DsPlanilla1.Empleado_Deducciones.Rows(i).Item("Descripcion") Then
                        Select Case Tipo
                            Case "V"
                                Dim ii As Double = Me.TablaPlanilla.Rows(x).Item(Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion"))
                                'Total = Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Monto")'original
                                Total = Me.TablaPlanilla.Rows(x).Item(Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion")) 'psv
                                If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                    If Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Cod_Moneda") = 1 Then
                                        Total = Total / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                    End If
                                Else
                                    If Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Cod_Moneda") = 2 Then
                                        Total = Total * Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                    End If
                                End If

                                TablaPlanilla.Rows(x).Item(Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion").ToString) = Total
                                TotalDeducciones = TotalDeducciones + Total
                            Case "%"
                                Monto = Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Monto")
                                Deduccion = ((Monto / 100) * TablaPlanilla.Rows(x).Item("SalarioBruto"))
                                TablaPlanilla.Rows(x).Item(Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion").ToString) = Deduccion
                                TotalDeducciones = TotalDeducciones + Deduccion
                        End Select
                        Descripcion = Me.DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion")
                        ' End If
                    End If
                Next

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                For J = 0 To Me.DsPlanilla1.Adelantos.Rows.Count - 1

                    If TablaPlanilla.Rows(x).Item("Cedula") = Me.DsPlanilla1.Adelantos.Rows(J).Item("Identificacion") Then
                        If Me.DsPlanilla1.Adelantos.Rows(J).Item("Anulado") = False Then

                            If Me.DsPlanilla1.Adelantos.Rows(J).Item("Adelanto") Then  'cambio =true
                                ' Dim fecha As String = Me.DsPlanilla1.Adelantos.Rows(J).Item("FechaCobro")
                                'Dim arrayl As Array
                                'arrayl = fecha.Split(" ")
                                Dim fecha As Date
                                fecha = Me.DsPlanilla1.Adelantos.Rows(J).Item("FechaCobro")

                                If Me.dtFechaInicio.Text <= fecha.Date And Me.dtFechaFinal.Text >= fecha.Date Then
                                    Adelanto = TablaPlanilla.Rows(x).Item("Adelantos") 'Me.DsPlanilla1.Adelantos.Rows(J).Item("Monto") Cambios


                                    'For h = 0 To Me.DsPlanilla1.Adelantos.Rows.Count - 1
                                    '    If Me.DsPlanilla1.Adelantos.Rows(h).Item("Identificacion") = Me.DsPlanilla1.Adelantos_Detalle.Rows(J).Item("Id_Empleado") And Me.DsPlanilla1.Adelantos.Rows(h).Item("Numero") = Me.DsPlanilla1.Adelantos_Detalle.Rows(J).Item("Numero") Then
                                    '        saldos = Me.DsPlanilla1.Adelantos.Rows(h).Item("Saldo")
                                    '    End If
                                    'Next
                                    If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                        If Me.DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 1 Then
                                            saldos = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo") / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio

                                        End If
                                    Else
                                        If Me.DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 2 Then
                                            saldos = saldos * Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio

                                        End If
                                        saldos = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                    End If


                                    saldo = saldo + saldos
                                    Adelantos = Adelanto + Adelantos

                                End If
                            End If
                            If Me.DsPlanilla1.Adelantos.Rows(J).Item("Prestamo") = True Then

                                For h = 0 To Me.DsPlanilla1.Adelantos_Detalle.Rows.Count - 1
                                    If Me.DsPlanilla1.Adelantos.Rows(J).Item("Identificacion") = Me.DsPlanilla1.Adelantos_Detalle.Rows(h).Item("Id_Empleado") And Me.DsPlanilla1.Adelantos.Rows(J).Item("Numero") = Me.DsPlanilla1.Adelantos_Detalle.Rows(h).Item("Numero") Then
                                        saldos = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                        Prestamo = Me.DsPlanilla1.Adelantos_Detalle.Rows(h).Item("Monto")

                                    End If
                                Next

                                If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                    If Me.DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 1 Then
                                        saldos = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo") / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                    Else
                                        Prestamo = Prestamo
                                    End If
                                Else
                                    If Me.DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 2 Then
                                        saldos = saldos * Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")  'cambio

                                    End If
                                    saldos = Me.DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                End If
                                If Prestamo > saldos Then
                                    Prestamo = saldos
                                End If

                                saldo = saldo + saldos
                                Prestamos = Prestamos + Prestamo

                                '------------------------Atencion, cambio hecho por jose elias----------------------------------------
                                '-----------porque no se actualizaba el saldo del adelanto--------
                                DsPlanilla1.Adelantos(J).Saldo = saldo - Prestamos - Adelantos
                                '-----------------------FIN DEL CAMBIO----------------------------------------
                            End If
                        End If
                    End If

                Next

                TablaPlanilla.Rows(x).Item("Saldo") = 0
                TablaPlanilla.Rows(x).Item("Adelantos") = Adelantos
                TablaPlanilla.Rows(x).Item("Prestamos") = Prestamos
                TablaPlanilla.Rows(x).Item("Saldo") = saldo - Prestamos - Adelantos 'modi

                
                SalarioBruto = TablaPlanilla.Rows(x).Item("SalarioBruto")

                fijo = 9900
                MontoDe = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("MontoDe")
                MontoHasta = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("MontoHasta")
                MontoExento = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("MontoExento")
                MontoAdelante = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("MontoEnAdelante")
                Porcentaje1 = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje1")
                Porcentaje2 = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje2")
                PHijo = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("Hijo")
                PEsposa = Me.DsPlanilla1.ParametroRenta.Rows(0).Item("Esposa")
                For k = 0 To Me.DsPlanilla1.Empleado.Rows.Count - 1
                    If Me.DsPlanilla1.Empleado.Rows(k).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                        Estado_Civil = Me.DsPlanilla1.Empleado.Rows(k).Item("Estado_Civil")
                        Hijos = Me.DsPlanilla1.Empleado.Rows(k).Item("Hijos")
                        Exit For
                    End If

                Next

                If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                    MontoDe = MontoDe / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") '514
                    MontoHasta = MontoHasta / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") ' 514
                    MontoExento = MontoExento / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") '/ 514
                    fijo = fijo / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") ' cambio
                    MontoAdelante = MontoAdelante / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") '514
                    PHijo = PHijo / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") '514
                    PEsposa = PEsposa / Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") '514
                End If
                Cedula = TablaPlanilla.Rows(x).Item("Cedula")
                If CheckCierreMes.Checked = True Then
                    ParametroRenta()
                    SalarioBruto2 = SalarioBruto + Pagomes

                    If SalarioBruto2 <= MontoExento Then
                        TablaPlanilla.Rows(x).Item("Renta") = 0
                    Else
                        If SalarioBruto2 > MontoDe And SalarioBruto2 < MontoAdelante Then
                            Renta = SalarioBruto2 - MontoDe
                            Renta = (Renta * Porcentaje1) / 100
                        End If

                        If SalarioBruto2 > MontoAdelante Then
                            Renta = fijo
                            Renta1 = SalarioBruto2 - MontoAdelante
                            Renta1 = (Renta1 * Porcentaje2) / 100
                        End If

                        If Estado_Civil = "Casado" Then
                            Renta2 = PEsposa
                        Else
                            Renta2 = 0
                        End If

                        Renta3 = Hijos * PHijo
                        RentaTotal = (Renta + Renta1) - (Renta2 + Renta3)
                        If RentaTotal <= 0 Then
                            RentaTotal = 0
                        End If
                        TablaPlanilla.Rows(x).Item("Renta") = RentaTotal
                    End If
                Else
                    TablaPlanilla.Rows(x).Item("Renta") = 0
                End If
                'TotalDeducciones = TablaPlanilla.Rows(x).Item("C.C.S.S.") + TablaPlanilla.Rows(x).Item("ASOCIACION")

                TotalDeducciones = TotalDeducciones + RentaTotal + Adelantos + Prestamos '+ DiasDescontados2
                TablaPlanilla.Rows(x).Item("TotalDeducciones") = TotalDeducciones
                TablaPlanilla.Rows(x).Item("SalarioNeto") = SalarioBruto - TotalDeducciones
                Descripcion = ""
                TotalDeducciones = 0
                Deduccion = 0
                Pagomes = 0
                DiasDescontados = 0
                DiasDescontados1 = 0
                DiasDescontados2 = 0
                Aumento = 0
                Calcula_Total()
                'MsgBox("El Saldo Fue Actulizado Correctamente !!!") '''''''' AQUI
            Catch ex As Exception
                'MsgBox("La Persona Selecionada no Tiene Prestamos Pendientes") ''''''AQUI
                'MsgBox(ex.ToString)

            End Try
        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim K, n As Integer
        Try

            Me.GridControl2.EndUpdate()

            Me.Recalcular_Fila_Saldo(num)
            Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").EndCurrentEdit()
            Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").AddNew()
            Me.BindingContext(Me.DsPlanilla1, "Adelantos_Detalle").CancelCurrentEdit()


            Me.GroupBox1.Visible = False


        Catch ex As Exception
            MsgBox("La Persona Selecionada no Tiene Prestamos Pendientes")

        End Try

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.GroupBox1.Visible = False
        Catch ex As Exception

        End Try

    End Sub


    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Try
            num = Me.BindingContext(TablaPlanilla).Position()
            Id_Empleado = TablaPlanilla.Rows(num).Item("Cedula")

            Me.GridControl2.DataSource = Me.DsPlanilla1.Adelantos_Detalle.Select("Id_Empleado = '" & Id_Empleado & "' and  Tipo_Pago = '" & True & "' and Monto <> 0")

            Me.GroupBox1.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Function Calcula_Total()
        Dim i As Integer
        Dim total As Double = 0
        For i = 0 To Me.TablaPlanilla.Rows.Count - 1
            If Me.TablaPlanilla.Rows(i).Item("Moneda") = "DOLAR" Then
                total = total + (Me.TablaPlanilla.Rows(i).Item("SalarioNeto") * Me.DsPlanilla1.Moneda.Rows(1).Item("ValorCompra"))
            End If
            total = total + Me.TablaPlanilla.Rows(i).Item("SalarioNeto")
        Next
        Me.Label3.Text = Format(total, "#,#0.00")
    End Function

    Private Sub dtFechaInicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtFechaFinal.Focus()
        End If
    End Sub

    Private Sub dtFechaFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFechaFinal.KeyDown
        Try


            If e.KeyCode = Keys.Enter Then
                Me.DsPlanilla1.Adelantos_Detalle.Clear()

                Me.CargarDatos()
                Calcula_Total()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dtFechaFinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaFinal.ValueChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Loggin_Usuario() Then
            End If
        End If
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub btnFormaPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormaPago.Click
        If IdPlanilla1 = 0 Then
            MsgBox("Primero se debe registrar la planilla antes de establecer la forma de pago", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim frmFormaPago As New frmFormaPago
        frmFormaPago.LlenarGridDetalle(IdPlanilla1)
        frmFormaPago.Cedula_usuario = Cedula_usuario
        frmFormaPago.ShowDialog()

    End Sub
End Class
