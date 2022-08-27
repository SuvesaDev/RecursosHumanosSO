Imports System.data.SqlClient
Imports Utilidades
Imports DevExpress.Utils

Public Class frmControlTiempo2
    Inherits FrmPlantilla

#Region "Variables"
    Public Shared FechaI As String
    Public Edicion As Boolean = False
    Public extra As Integer = 0
    Public Shared NombreCliente As String
    Public Shared FechaF As String
    Public Shared IdPlanilla As Integer 'psv
    Public Shared DTINICIO As String
    Public Shared Dtfinal As String
    Public Shared Rept As String
    Public Shared contex, IdPlanilla1 As Integer
    Public Shared Id_Empleado As String
    Public Shared Ident As String
    Public Shared Phuella As String
    Public Shared Ptarjeta As String
    Public TablaRenta1, TablaRenta, TablaPlanilla As New DataTable
    Public NUMEROPLANILLAS As Integer
    Dim usua As Object
    Dim dlg As WaitDialogForm
    Dim DataView As New DataView
    Dim Id As Long
    Public num As Integer
    Dim cxcActualEdit As Integer = 0
    Dim Pagomes As Double
    Dim logeado, var, CuentasxC As Boolean
    Dim Cedula_usuario, NombreUsuario, Codigo, NumeroPlanilla1, nombre, Cedula As String
    Public Shared dataset1, dataset2 As SqlDataReader
    Dim huella, tarjeta As String
    Dim user1, user2 As String
    Dim cconexion1 As New Conexion
    Dim sqlconexion1 As SqlConnection
    Friend WithEvents GridColumnAbono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnLimpiarAbonoCxC As System.Windows.Forms.Button
    Friend WithEvents btnBloquear As System.Windows.Forms.Button
    Friend WithEvents btnActualizarDatosEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnLimpiarCxC As System.Windows.Forms.Button
    Dim cedulajuridica As String = ""
#End Region

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
    Private WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
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
    Friend WithEvents adMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdAdelanto_Detalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsPlanilla1 As Planilla.dsPlanilla
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
    Friend WithEvents AdOrdinarias As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents btnFormaPago As System.Windows.Forms.Button
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Private WithEvents ContextMenuPlanilla As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBoxCxC As System.Windows.Forms.GroupBox
    Friend WithEvents GridControlFacturasCobrar As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnNumero_Factura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCobrar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents ButtonActualizar As System.Windows.Forms.Button
    Friend WithEvents SqlDataAdapterAbonocCobrar As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnectionHotel As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapterDetalleAbono_cCobrar As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Check_ServProf As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtPlanillaNumero As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridColumnFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterDed As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand14 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlTiempo2))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo10 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuPlanilla = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.DsPlanilla1 = New Planilla.dsPlanilla()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckCierreMes = New System.Windows.Forms.CheckBox()
        Me.CheckAnulado = New System.Windows.Forms.CheckBox()
        Me.DsProyecto = New Planilla.DsProyecto()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.adPlanillaDeducciones = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.adPlanillaDetalle = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.adEmpleados = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.adDeducciones = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.adAdelantos = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.adRenta = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.adEmpleadoDeducciones = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.HorasTrabajadas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.adPlanilla = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.adAccion = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.adMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.AdAdelanto_Detalle = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId_Empleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.colAccionPersonal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.AdOrdinarias = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.btnFormaPago = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Check_ServProf = New System.Windows.Forms.CheckBox()
        Me.GroupBoxCxC = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarAbonoCxC = New System.Windows.Forms.Button()
        Me.GridControlFacturasCobrar = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumnFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnNumero_Factura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnCobrar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumnAbono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ButtonCancelar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.SqlDataAdapterAbonocCobrar = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnectionHotel = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand16 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapterDetalleAbono_cCobrar = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.txtPlanillaNumero = New System.Windows.Forms.TextBox()
        Me.AdapterDed = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand17 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.btnBloquear = New System.Windows.Forms.Button()
        Me.btnActualizarDatosEmpleado = New System.Windows.Forms.Button()
        Me.btnLimpiarCxC = New System.Windows.Forms.Button()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxCxC.SuspendLayout()
        CType(Me.GridControlFacturasCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TituloModulo.Size = New System.Drawing.Size(1189, 32)
        Me.TituloModulo.Text = "Pago de Planilla"
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 602)
        Me.ToolBar1.Size = New System.Drawing.Size(1189, 56)
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Text = "Anular"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.ContextMenu = Me.ContextMenuPlanilla
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(4, 32)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1183, 568)
        Me.GridControl1.TabIndex = 59
        Me.GridControl1.Text = "GridControl1"
        '
        'ContextMenuPlanilla
        '
        Me.ContextMenuPlanilla.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Editar Facturas Pendientes"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Editar Prestamos Pendientes"
        '
        'GridView1
        '
        Me.GridView1.FixedLineWidth = 1
        Me.GridView1.GroupFormat = ""
        Me.GridView1.GroupPanelText = "Cálculos de Pago a Empleados"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPlanilla1, "Planilla.Id_Planilla", True))
        Me.txtNumero.ForeColor = System.Drawing.Color.Blue
        Me.txtNumero.Location = New System.Drawing.Point(72, 16)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(16, 13)
        Me.txtNumero.TabIndex = 61
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumero.Visible = False
        '
        'DsPlanilla1
        '
        Me.DsPlanilla1.DataSetName = "DsPlanilla1"
        Me.DsPlanilla1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DsPlanilla1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 15)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Fecha Inicio:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(120, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckCierreMes
        '
        Me.CheckCierreMes.BackColor = System.Drawing.Color.Transparent
        Me.CheckCierreMes.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPlanilla1, "Planilla.CierreMes", True))
        Me.CheckCierreMes.Enabled = False
        Me.CheckCierreMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckCierreMes.ForeColor = System.Drawing.Color.Blue
        Me.CheckCierreMes.Location = New System.Drawing.Point(216, 24)
        Me.CheckCierreMes.Name = "CheckCierreMes"
        Me.CheckCierreMes.Size = New System.Drawing.Size(88, 16)
        Me.CheckCierreMes.TabIndex = 174
        Me.CheckCierreMes.Text = "Cierre Mes"
        Me.CheckCierreMes.UseVisualStyleBackColor = False
        '
        'CheckAnulado
        '
        Me.CheckAnulado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckAnulado.BackColor = System.Drawing.Color.Transparent
        Me.CheckAnulado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPlanilla1, "Planilla.Anulado", True))
        Me.CheckAnulado.Enabled = False
        Me.CheckAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAnulado.ForeColor = System.Drawing.Color.Red
        Me.CheckAnulado.Location = New System.Drawing.Point(152, 663)
        Me.CheckAnulado.Name = "CheckAnulado"
        Me.CheckAnulado.Size = New System.Drawing.Size(88, 16)
        Me.CheckAnulado.TabIndex = 176
        Me.CheckAnulado.Text = "Anulado"
        Me.CheckAnulado.UseVisualStyleBackColor = False
        '
        'DsProyecto
        '
        Me.DsProyecto.DataSetName = "DsProyecto"
        Me.DsProyecto.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DsProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=.;Initial Catalog=planilla;Integrated Security=True"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Planilla;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
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
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Deduccion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Deduccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_PlanillaDetalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_PlanillaDetalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_PlanillaDetalle", System.Data.SqlDbType.BigInt, 8, "Id_PlanillaDetalle"), New System.Data.SqlClient.SqlParameter("@Cod_Deduccion", System.Data.SqlDbType.Int, 4, "Cod_Deduccion"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id, Id_PlanillaDetalle, Cod_Deduccion, Nombre, Monto, Cod_Moneda FROM Plan" & _
    "illa_Deducciones"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_PlanillaDetalle", System.Data.SqlDbType.BigInt, 8, "Id_PlanillaDetalle"), New System.Data.SqlClient.SqlParameter("@Cod_Deduccion", System.Data.SqlDbType.Int, 4, "Cod_Deduccion"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Deduccion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Deduccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_PlanillaDetalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_PlanillaDetalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'adPlanillaDetalle
        '
        Me.adPlanillaDetalle.DeleteCommand = Me.SqlDeleteCommand3
        Me.adPlanillaDetalle.InsertCommand = Me.SqlInsertCommand3
        Me.adPlanillaDetalle.SelectCommand = Me.SqlSelectCommand3
        Me.adPlanillaDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Planilla_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_Planilla", "Id_Planilla"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("FormaPago", "FormaPago"), New System.Data.Common.DataColumnMapping("Ordinaria", "Ordinaria"), New System.Data.Common.DataColumnMapping("Extra", "Extra"), New System.Data.Common.DataColumnMapping("Doble", "Doble"), New System.Data.Common.DataColumnMapping("SalarioBruto", "SalarioBruto"), New System.Data.Common.DataColumnMapping("Adelantos", "Adelantos"), New System.Data.Common.DataColumnMapping("Prestamos", "Prestamos"), New System.Data.Common.DataColumnMapping("Renta", "Renta"), New System.Data.Common.DataColumnMapping("TotalDeducciones", "TotalDeducciones"), New System.Data.Common.DataColumnMapping("SalarioNeto", "SalarioNeto"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Feriada", "Feriada"), New System.Data.Common.DataColumnMapping("Prestamos_Int", "Prestamos_Int"), New System.Data.Common.DataColumnMapping("Otros_Ingresos", "Otros_Ingresos"), New System.Data.Common.DataColumnMapping("CuentasxCobrar", "CuentasxCobrar"), New System.Data.Common.DataColumnMapping("Ord_Nocturna", "Ord_Nocturna"), New System.Data.Common.DataColumnMapping("Ext_Nocturna", "Ext_Nocturna"), New System.Data.Common.DataColumnMapping("DiasLibre", "DiasLibre"), New System.Data.Common.DataColumnMapping("DiasDescontar", "DiasDescontar"), New System.Data.Common.DataColumnMapping("Vacaciones", "Vacaciones"), New System.Data.Common.DataColumnMapping("INS", "INS"), New System.Data.Common.DataColumnMapping("CCSS", "CCSS"), New System.Data.Common.DataColumnMapping("Embarazo", "Embarazo")})})
        Me.adPlanillaDetalle.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM [Planilla_Detalle] WHERE (([Id] = @Original_Id))"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 0, "Id_Planilla"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 0, "Cedula"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 0, "Puesto"), New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 0, "Salario"), New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 0, "FormaPago"), New System.Data.SqlClient.SqlParameter("@Ordinaria", System.Data.SqlDbType.Float, 0, "Ordinaria"), New System.Data.SqlClient.SqlParameter("@Extra", System.Data.SqlDbType.Float, 0, "Extra"), New System.Data.SqlClient.SqlParameter("@Doble", System.Data.SqlDbType.Float, 0, "Doble"), New System.Data.SqlClient.SqlParameter("@SalarioBruto", System.Data.SqlDbType.Float, 0, "SalarioBruto"), New System.Data.SqlClient.SqlParameter("@Adelantos", System.Data.SqlDbType.Float, 0, "Adelantos"), New System.Data.SqlClient.SqlParameter("@Prestamos", System.Data.SqlDbType.Float, 0, "Prestamos"), New System.Data.SqlClient.SqlParameter("@Renta", System.Data.SqlDbType.Float, 0, "Renta"), New System.Data.SqlClient.SqlParameter("@TotalDeducciones", System.Data.SqlDbType.Float, 0, "TotalDeducciones"), New System.Data.SqlClient.SqlParameter("@SalarioNeto", System.Data.SqlDbType.Float, 0, "SalarioNeto"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Feriada", System.Data.SqlDbType.Float, 0, "Feriada"), New System.Data.SqlClient.SqlParameter("@Prestamos_Int", System.Data.SqlDbType.Float, 0, "Prestamos_Int"), New System.Data.SqlClient.SqlParameter("@Otros_Ingresos", System.Data.SqlDbType.Float, 0, "Otros_Ingresos"), New System.Data.SqlClient.SqlParameter("@CuentasxCobrar", System.Data.SqlDbType.Float, 0, "CuentasxCobrar"), New System.Data.SqlClient.SqlParameter("@Ord_Nocturna", System.Data.SqlDbType.Float, 0, "Ord_Nocturna"), New System.Data.SqlClient.SqlParameter("@Ext_Nocturna", System.Data.SqlDbType.Float, 0, "Ext_Nocturna"), New System.Data.SqlClient.SqlParameter("@DiasLibre", System.Data.SqlDbType.Float, 0, "DiasLibre"), New System.Data.SqlClient.SqlParameter("@DiasDescontar", System.Data.SqlDbType.Float, 0, "DiasDescontar"), New System.Data.SqlClient.SqlParameter("@Vacaciones", System.Data.SqlDbType.Float, 0, "Vacaciones"), New System.Data.SqlClient.SqlParameter("@INS", System.Data.SqlDbType.Float, 0, "INS"), New System.Data.SqlClient.SqlParameter("@CCSS", System.Data.SqlDbType.Float, 0, "CCSS"), New System.Data.SqlClient.SqlParameter("@Embarazo", System.Data.SqlDbType.Float, 0, "Embarazo")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 0, "Id_Planilla"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 0, "Cedula"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 0, "Puesto"), New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 0, "Salario"), New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 0, "FormaPago"), New System.Data.SqlClient.SqlParameter("@Ordinaria", System.Data.SqlDbType.Float, 0, "Ordinaria"), New System.Data.SqlClient.SqlParameter("@Extra", System.Data.SqlDbType.Float, 0, "Extra"), New System.Data.SqlClient.SqlParameter("@Doble", System.Data.SqlDbType.Float, 0, "Doble"), New System.Data.SqlClient.SqlParameter("@SalarioBruto", System.Data.SqlDbType.Float, 0, "SalarioBruto"), New System.Data.SqlClient.SqlParameter("@Adelantos", System.Data.SqlDbType.Float, 0, "Adelantos"), New System.Data.SqlClient.SqlParameter("@Prestamos", System.Data.SqlDbType.Float, 0, "Prestamos"), New System.Data.SqlClient.SqlParameter("@Renta", System.Data.SqlDbType.Float, 0, "Renta"), New System.Data.SqlClient.SqlParameter("@TotalDeducciones", System.Data.SqlDbType.Float, 0, "TotalDeducciones"), New System.Data.SqlClient.SqlParameter("@SalarioNeto", System.Data.SqlDbType.Float, 0, "SalarioNeto"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Feriada", System.Data.SqlDbType.Float, 0, "Feriada"), New System.Data.SqlClient.SqlParameter("@Prestamos_Int", System.Data.SqlDbType.Float, 0, "Prestamos_Int"), New System.Data.SqlClient.SqlParameter("@Otros_Ingresos", System.Data.SqlDbType.Float, 0, "Otros_Ingresos"), New System.Data.SqlClient.SqlParameter("@CuentasxCobrar", System.Data.SqlDbType.Float, 0, "CuentasxCobrar"), New System.Data.SqlClient.SqlParameter("@Ord_Nocturna", System.Data.SqlDbType.Float, 0, "Ord_Nocturna"), New System.Data.SqlClient.SqlParameter("@Ext_Nocturna", System.Data.SqlDbType.Float, 0, "Ext_Nocturna"), New System.Data.SqlClient.SqlParameter("@DiasLibre", System.Data.SqlDbType.Float, 0, "DiasLibre"), New System.Data.SqlClient.SqlParameter("@DiasDescontar", System.Data.SqlDbType.Float, 0, "DiasDescontar"), New System.Data.SqlClient.SqlParameter("@Vacaciones", System.Data.SqlDbType.Float, 0, "Vacaciones"), New System.Data.SqlClient.SqlParameter("@INS", System.Data.SqlDbType.Float, 0, "INS"), New System.Data.SqlClient.SqlParameter("@CCSS", System.Data.SqlDbType.Float, 0, "CCSS"), New System.Data.SqlClient.SqlParameter("@Embarazo", System.Data.SqlDbType.Float, 0, "Embarazo"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'adEmpleados
        '
        Me.adEmpleados.DeleteCommand = Me.SqlDeleteCommand4
        Me.adEmpleados.InsertCommand = Me.SqlInsertCommand4
        Me.adEmpleados.SelectCommand = Me.SqlSelectCommand4
        Me.adEmpleados.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Estado_Civil", "Estado_Civil"), New System.Data.Common.DataColumnMapping("Hijos", "Hijos"), New System.Data.Common.DataColumnMapping("Cod_Nacionalidad", "Cod_Nacionalidad"), New System.Data.Common.DataColumnMapping("Fecha_Nacimiento", "Fecha_Nacimiento"), New System.Data.Common.DataColumnMapping("Edad", "Edad"), New System.Data.Common.DataColumnMapping("Telefono1", "Telefono1"), New System.Data.Common.DataColumnMapping("Telefono2", "Telefono2"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Fecha_Ingreso", "Fecha_Ingreso"), New System.Data.Common.DataColumnMapping("Fecha_Salida", "Fecha_Salida"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("Cod_Departamento", "Cod_Departamento"), New System.Data.Common.DataColumnMapping("Masculino", "Masculino"), New System.Data.Common.DataColumnMapping("Femenino", "Femenino"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Hora", "Hora"), New System.Data.Common.DataColumnMapping("Diario", "Diario"), New System.Data.Common.DataColumnMapping("Semana", "Semana"), New System.Data.Common.DataColumnMapping("Quincena", "Quincena"), New System.Data.Common.DataColumnMapping("Mensual", "Mensual"), New System.Data.Common.DataColumnMapping("Cod_Estado", "Cod_Estado"), New System.Data.Common.DataColumnMapping("Foto", "Foto"), New System.Data.Common.DataColumnMapping("HorasOrdinarias", "HorasOrdinarias"), New System.Data.Common.DataColumnMapping("ServiciosProf", "ServiciosProf"), New System.Data.Common.DataColumnMapping("CambioCedula", "CambioCedula"), New System.Data.Common.DataColumnMapping("NuevaCedula", "NuevaCedula")})})
        Me.adEmpleados.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CambioCedula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambioCedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Departamento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Departamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Nacionalidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Edad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Estado_Civil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado_Civil", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Femenino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Femenino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Hijos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HorasOrdinarias", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HorasOrdinarias", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Masculino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Masculino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NuevaCedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NuevaCedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ServiciosProf", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ServiciosProf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"), New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 50, "Estado_Civil"), New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 4, "Hijos"), New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, "Cod_Nacionalidad"), New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, "Fecha_Nacimiento"), New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"), New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 50, "Telefono1"), New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 50, "Telefono2"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 100, "Puesto"), New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"), New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"), New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"), New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 4, "Cod_Departamento"), New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 1, "Masculino"), New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 1, "Femenino"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"), New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"), New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"), New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"), New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"), New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"), New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"), New System.Data.SqlClient.SqlParameter("@HorasOrdinarias", System.Data.SqlDbType.Int, 4, "HorasOrdinarias"), New System.Data.SqlClient.SqlParameter("@ServiciosProf", System.Data.SqlDbType.Bit, 1, "ServiciosProf"), New System.Data.SqlClient.SqlParameter("@CambioCedula", System.Data.SqlDbType.Bit, 1, "CambioCedula"), New System.Data.SqlClient.SqlParameter("@NuevaCedula", System.Data.SqlDbType.VarChar, 75, "NuevaCedula")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"), New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 50, "Estado_Civil"), New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 4, "Hijos"), New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, "Cod_Nacionalidad"), New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, "Fecha_Nacimiento"), New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"), New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 50, "Telefono1"), New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 50, "Telefono2"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 100, "Puesto"), New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"), New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"), New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"), New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 4, "Cod_Departamento"), New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 1, "Masculino"), New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 1, "Femenino"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"), New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"), New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"), New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"), New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"), New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"), New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"), New System.Data.SqlClient.SqlParameter("@HorasOrdinarias", System.Data.SqlDbType.Int, 4, "HorasOrdinarias"), New System.Data.SqlClient.SqlParameter("@ServiciosProf", System.Data.SqlDbType.Bit, 1, "ServiciosProf"), New System.Data.SqlClient.SqlParameter("@CambioCedula", System.Data.SqlDbType.Bit, 1, "CambioCedula"), New System.Data.SqlClient.SqlParameter("@NuevaCedula", System.Data.SqlDbType.VarChar, 75, "NuevaCedula"), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CambioCedula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambioCedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Departamento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Departamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Nacionalidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Edad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Estado_Civil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado_Civil", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Femenino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Femenino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Hijos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HorasOrdinarias", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HorasOrdinarias", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Masculino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Masculino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NuevaCedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NuevaCedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ServiciosProf", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ServiciosProf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing)})
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
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Aplica", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"), New System.Data.SqlClient.SqlParameter("@Aplica", System.Data.SqlDbType.Bit, 1, "Aplica"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Codigo, Descripcion, Monto, Tipo, Aplica, Cod_Moneda FROM Deducciones"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"), New System.Data.SqlClient.SqlParameter("@Aplica", System.Data.SqlDbType.Bit, 1, "Aplica"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Aplica", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo")})
        '
        'adAdelantos
        '
        Me.adAdelantos.DeleteCommand = Me.SqlDeleteCommand6
        Me.adAdelantos.InsertCommand = Me.SqlInsertCommand6
        Me.adAdelantos.SelectCommand = Me.SqlSelectCommand6
        Me.adAdelantos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Adelantos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Adelanto", "Adelanto"), New System.Data.Common.DataColumnMapping("Prestamo", "Prestamo"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("FechaComprobante", "FechaComprobante"), New System.Data.Common.DataColumnMapping("Num_Pago", "Num_Pago"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("MontoEnLetras", "MontoEnLetras"), New System.Data.Common.DataColumnMapping("FechaCobro", "FechaCobro"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("DeducirxPago", "DeducirxPago"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo"), New System.Data.Common.DataColumnMapping("InteresPrestamo", "InteresPrestamo")})})
        Me.adAdelantos.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = resources.GetString("SqlDeleteCommand6.CommandText")
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Adelanto", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adelanto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DeducirxPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeducirxPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaCobro", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaCobro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaComprobante", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaComprobante", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_InteresPrestamo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InteresPrestamo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoEnLetras", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnLetras", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Pago", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Pago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Prestamo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prestamo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = resources.GetString("SqlInsertCommand6.CommandText")
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"), New System.Data.SqlClient.SqlParameter("@Adelanto", System.Data.SqlDbType.Bit, 1, "Adelanto"), New System.Data.SqlClient.SqlParameter("@Prestamo", System.Data.SqlDbType.Bit, 1, "Prestamo"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"), New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"), New System.Data.SqlClient.SqlParameter("@FechaComprobante", System.Data.SqlDbType.DateTime, 8, "FechaComprobante"), New System.Data.SqlClient.SqlParameter("@Num_Pago", System.Data.SqlDbType.Int, 4, "Num_Pago"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@MontoEnLetras", System.Data.SqlDbType.VarChar, 250, "MontoEnLetras"), New System.Data.SqlClient.SqlParameter("@FechaCobro", System.Data.SqlDbType.DateTime, 8, "FechaCobro"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@DeducirxPago", System.Data.SqlDbType.Float, 8, "DeducirxPago"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 50, "Usuario"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 8, "Saldo"), New System.Data.SqlClient.SqlParameter("@InteresPrestamo", System.Data.SqlDbType.Float, 8, "InteresPrestamo")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = resources.GetString("SqlSelectCommand6.CommandText")
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = resources.GetString("SqlUpdateCommand6.CommandText")
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"), New System.Data.SqlClient.SqlParameter("@Adelanto", System.Data.SqlDbType.Bit, 1, "Adelanto"), New System.Data.SqlClient.SqlParameter("@Prestamo", System.Data.SqlDbType.Bit, 1, "Prestamo"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"), New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"), New System.Data.SqlClient.SqlParameter("@FechaComprobante", System.Data.SqlDbType.DateTime, 8, "FechaComprobante"), New System.Data.SqlClient.SqlParameter("@Num_Pago", System.Data.SqlDbType.Int, 4, "Num_Pago"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@MontoEnLetras", System.Data.SqlDbType.VarChar, 250, "MontoEnLetras"), New System.Data.SqlClient.SqlParameter("@FechaCobro", System.Data.SqlDbType.DateTime, 8, "FechaCobro"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@DeducirxPago", System.Data.SqlDbType.Float, 8, "DeducirxPago"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 50, "Usuario"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 8, "Saldo"), New System.Data.SqlClient.SqlParameter("@InteresPrestamo", System.Data.SqlDbType.Float, 8, "InteresPrestamo"), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Adelanto", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adelanto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DeducirxPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeducirxPago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaCobro", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaCobro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaComprobante", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaComprobante", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_InteresPrestamo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "InteresPrestamo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoEnLetras", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnLetras", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Pago", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Pago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Prestamo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prestamo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero")})
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
        Me.SqlDeleteCommand7.CommandText = resources.GetString("SqlDeleteCommand7.CommandText")
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Esposa", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Esposa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Hijo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoDe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoDe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoEnAdelante", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnAdelante", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoHasta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoHasta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Porcentaje1", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Porcentaje2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje2", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = resources.GetString("SqlInsertCommand7.CommandText")
        Me.SqlInsertCommand7.Connection = Me.SqlConnection1
        Me.SqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MontoExento", System.Data.SqlDbType.Float, 8, "MontoExento"), New System.Data.SqlClient.SqlParameter("@MontoDe", System.Data.SqlDbType.Float, 8, "MontoDe"), New System.Data.SqlClient.SqlParameter("@MontoHasta", System.Data.SqlDbType.Float, 8, "MontoHasta"), New System.Data.SqlClient.SqlParameter("@Porcentaje1", System.Data.SqlDbType.Float, 8, "Porcentaje1"), New System.Data.SqlClient.SqlParameter("@MontoEnAdelante", System.Data.SqlDbType.Float, 8, "MontoEnAdelante"), New System.Data.SqlClient.SqlParameter("@Porcentaje2", System.Data.SqlDbType.Float, 8, "Porcentaje2"), New System.Data.SqlClient.SqlParameter("@Esposa", System.Data.SqlDbType.Float, 8, "Esposa"), New System.Data.SqlClient.SqlParameter("@Hijo", System.Data.SqlDbType.Float, 8, "Hijo")})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT Id, MontoExento, MontoDe, MontoHasta, Porcentaje1, MontoEnAdelante, Porcen" & _
    "taje2, Esposa, Hijo FROM ParametroRenta"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = resources.GetString("SqlUpdateCommand7.CommandText")
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MontoExento", System.Data.SqlDbType.Float, 8, "MontoExento"), New System.Data.SqlClient.SqlParameter("@MontoDe", System.Data.SqlDbType.Float, 8, "MontoDe"), New System.Data.SqlClient.SqlParameter("@MontoHasta", System.Data.SqlDbType.Float, 8, "MontoHasta"), New System.Data.SqlClient.SqlParameter("@Porcentaje1", System.Data.SqlDbType.Float, 8, "Porcentaje1"), New System.Data.SqlClient.SqlParameter("@MontoEnAdelante", System.Data.SqlDbType.Float, 8, "MontoEnAdelante"), New System.Data.SqlClient.SqlParameter("@Porcentaje2", System.Data.SqlDbType.Float, 8, "Porcentaje2"), New System.Data.SqlClient.SqlParameter("@Esposa", System.Data.SqlDbType.Float, 8, "Esposa"), New System.Data.SqlClient.SqlParameter("@Hijo", System.Data.SqlDbType.Float, 8, "Hijo"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Esposa", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Esposa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Hijo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoDe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoDe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoEnAdelante", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnAdelante", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoHasta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoHasta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Porcentaje1", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Porcentaje2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
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
        Me.SqlDeleteCommand10.CommandText = resources.GetString("SqlDeleteCommand10.CommandText")
        Me.SqlDeleteCommand10.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand10
        '
        Me.SqlInsertCommand10.CommandText = resources.GetString("SqlInsertCommand10.CommandText")
        Me.SqlInsertCommand10.Connection = Me.SqlConnection1
        Me.SqlInsertCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda")})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT Id, Identificacion, Codigo, Descripcion, Monto, Tipo, Cod_Moneda FROM Empl" & _
    "eado_Deducciones"
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand10
        '
        Me.SqlUpdateCommand10.CommandText = resources.GetString("SqlUpdateCommand10.CommandText")
        Me.SqlUpdateCommand10.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
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
        Me.SqlDeleteCommand11.CommandText = resources.GetString("SqlDeleteCommand11.CommandText")
        Me.SqlDeleteCommand11.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand11.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HoraDoble", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraDoble", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HoraExtra", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraExtra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HoraOrdinaria", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraOrdinaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand11
        '
        Me.SqlInsertCommand11.CommandText = resources.GetString("SqlInsertCommand11.CommandText")
        Me.SqlInsertCommand11.Connection = Me.SqlConnection1
        Me.SqlInsertCommand11.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@HoraOrdinaria", System.Data.SqlDbType.Float, 8, "HoraOrdinaria"), New System.Data.SqlClient.SqlParameter("@HoraExtra", System.Data.SqlDbType.VarChar, 10, "HoraExtra"), New System.Data.SqlClient.SqlParameter("@HoraDoble", System.Data.SqlDbType.VarChar, 10, "HoraDoble"), New System.Data.SqlClient.SqlParameter("@Id_Proyecto", System.Data.SqlDbType.Int, 4, "Id_Proyecto")})
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT Id, Identificacion, Fecha, HoraOrdinaria, HoraExtra, HoraDoble, Id_Proyect" & _
    "o FROM HorasTrabajadas"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand11
        '
        Me.SqlUpdateCommand11.CommandText = resources.GetString("SqlUpdateCommand11.CommandText")
        Me.SqlUpdateCommand11.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand11.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@HoraOrdinaria", System.Data.SqlDbType.Float, 8, "HoraOrdinaria"), New System.Data.SqlClient.SqlParameter("@HoraExtra", System.Data.SqlDbType.VarChar, 10, "HoraExtra"), New System.Data.SqlClient.SqlParameter("@HoraDoble", System.Data.SqlDbType.VarChar, 10, "HoraDoble"), New System.Data.SqlClient.SqlParameter("@Id_Proyecto", System.Data.SqlDbType.Int, 4, "Id_Proyecto"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HoraDoble", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraDoble", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HoraExtra", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraExtra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HoraOrdinaria", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraOrdinaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(752, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(24, 20)
        Me.TextBox1.TabIndex = 193
        '
        'adPlanilla
        '
        Me.adPlanilla.DeleteCommand = Me.SqlDeleteCommand1
        Me.adPlanilla.InsertCommand = Me.SqlInsertCommand1
        Me.adPlanilla.SelectCommand = Me.SqlSelectCommand1
        Me.adPlanilla.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Planilla", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Planilla", "Id_Planilla"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("FechaInicial", "FechaInicial"), New System.Data.Common.DataColumnMapping("FechaFinal", "FechaFinal"), New System.Data.Common.DataColumnMapping("CierreMes", "CierreMes"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("Nombre_Usuario", "Nombre_Usuario"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Serv_Prof", "Serv_Prof"), New System.Data.Common.DataColumnMapping("NumeroPlanilla", "NumeroPlanilla")})})
        Me.adPlanilla.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CierreMes", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CierreMes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaFinal", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaFinal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaInicial", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaInicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroPlanilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroPlanilla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Serv_Prof", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Serv_Prof", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@FechaInicial", System.Data.SqlDbType.DateTime, 8, "FechaInicial"), New System.Data.SqlClient.SqlParameter("@FechaFinal", System.Data.SqlDbType.DateTime, 8, "FechaFinal"), New System.Data.SqlClient.SqlParameter("@CierreMes", System.Data.SqlDbType.Bit, 1, "CierreMes"), New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"), New System.Data.SqlClient.SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, "Nombre_Usuario"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Serv_Prof", System.Data.SqlDbType.Bit, 1, "Serv_Prof"), New System.Data.SqlClient.SqlParameter("@NumeroPlanilla", System.Data.SqlDbType.BigInt, 8, "NumeroPlanilla")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id_Planilla, Fecha, FechaInicial, FechaFinal, CierreMes, Ced_Usuario, Nomb" & _
    "re_Usuario, Anulado, Serv_Prof, NumeroPlanilla FROM Planilla"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@FechaInicial", System.Data.SqlDbType.DateTime, 8, "FechaInicial"), New System.Data.SqlClient.SqlParameter("@FechaFinal", System.Data.SqlDbType.DateTime, 8, "FechaFinal"), New System.Data.SqlClient.SqlParameter("@CierreMes", System.Data.SqlDbType.Bit, 1, "CierreMes"), New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"), New System.Data.SqlClient.SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, "Nombre_Usuario"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Serv_Prof", System.Data.SqlDbType.Bit, 1, "Serv_Prof"), New System.Data.SqlClient.SqlParameter("@NumeroPlanilla", System.Data.SqlDbType.BigInt, 8, "NumeroPlanilla"), New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CierreMes", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CierreMes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaFinal", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaFinal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaInicial", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaInicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroPlanilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroPlanilla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Serv_Prof", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Serv_Prof", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 8, "Id_Planilla")})
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
        Me.SqlDeleteCommand8.CommandText = resources.GetString("SqlDeleteCommand8.CommandText")
        Me.SqlDeleteCommand8.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DiasaDescontar", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiasaDescontar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HechoPor", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HechoPor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Accion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Empleado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RigeDesde", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeDesde", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RigeHasta", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeHasta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = resources.GetString("SqlInsertCommand8.CommandText")
        Me.SqlInsertCommand8.Connection = Me.SqlConnection1
        Me.SqlInsertCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 250, "Id_Empleado"), New System.Data.SqlClient.SqlParameter("@Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, "Nombre_Empleado"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"), New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 4, "Id_Accion"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@RigeDesde", System.Data.SqlDbType.DateTime, 8, "RigeDesde"), New System.Data.SqlClient.SqlParameter("@RigeHasta", System.Data.SqlDbType.DateTime, 8, "RigeHasta"), New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Float, 8, "DiasaDescontar"), New System.Data.SqlClient.SqlParameter("@HechoPor", System.Data.SqlDbType.VarChar, 75, "HechoPor"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula")})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT Num_Accion, Id_Empleado, Nombre_Empleado, Puesto, Id_Accion, Fecha, Observ" & _
    "aciones, RigeDesde, RigeHasta, DiasaDescontar, HechoPor, NombreUsuario, Anula FR" & _
    "OM AccionPersonal WHERE (Anula = 0)"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = resources.GetString("SqlUpdateCommand8.CommandText")
        Me.SqlUpdateCommand8.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 250, "Id_Empleado"), New System.Data.SqlClient.SqlParameter("@Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, "Nombre_Empleado"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"), New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 4, "Id_Accion"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@RigeDesde", System.Data.SqlDbType.DateTime, 8, "RigeDesde"), New System.Data.SqlClient.SqlParameter("@RigeHasta", System.Data.SqlDbType.DateTime, 8, "RigeHasta"), New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Float, 8, "DiasaDescontar"), New System.Data.SqlClient.SqlParameter("@HechoPor", System.Data.SqlDbType.VarChar, 75, "HechoPor"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"), New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DiasaDescontar", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiasaDescontar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HechoPor", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HechoPor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Accion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Empleado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RigeDesde", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeDesde", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RigeHasta", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeHasta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Num_Accion", System.Data.SqlDbType.BigInt, 8, "Num_Accion")})
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
        Me.SqlInsertCommand12.CommandText = resources.GetString("SqlInsertCommand12.CommandText")
        Me.SqlInsertCommand12.Connection = Me.SqlConnection1
        Me.SqlInsertCommand12.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand12.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand12
        '
        Me.SqlUpdateCommand12.CommandText = resources.GetString("SqlUpdateCommand12.CommandText")
        Me.SqlUpdateCommand12.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand12.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'AdAdelanto_Detalle
        '
        Me.AdAdelanto_Detalle.DeleteCommand = Me.SqlDeleteCommand9
        Me.AdAdelanto_Detalle.InsertCommand = Me.SqlInsertCommand9
        Me.AdAdelanto_Detalle.SelectCommand = Me.SqlSelectCommand9
        Me.AdAdelanto_Detalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Adelantos_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Detalle_AP", "Id_Detalle_AP"), New System.Data.Common.DataColumnMapping("Id_Empleado", "Id_Empleado"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Tipo_Pago", "Tipo_Pago"), New System.Data.Common.DataColumnMapping("Id_Planilla", "Id_Planilla"), New System.Data.Common.DataColumnMapping("Interes_Prestamo", "Interes_Prestamo"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo")})})
        Me.AdAdelanto_Detalle.UpdateCommand = Me.SqlUpdateCommand9
        '
        'SqlDeleteCommand9
        '
        Me.SqlDeleteCommand9.CommandText = resources.GetString("SqlDeleteCommand9.CommandText")
        Me.SqlDeleteCommand9.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle_AP", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle_AP", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Interes_Prestamo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Interes_Prestamo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Pago", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand9
        '
        Me.SqlInsertCommand9.CommandText = resources.GetString("SqlInsertCommand9.CommandText")
        Me.SqlInsertCommand9.Connection = Me.SqlConnection1
        Me.SqlInsertCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 50, "Id_Empleado"), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Tipo_Pago", System.Data.SqlDbType.Bit, 1, "Tipo_Pago"), New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.Int, 4, "Id_Planilla"), New System.Data.SqlClient.SqlParameter("@Interes_Prestamo", System.Data.SqlDbType.Float, 8, "Interes_Prestamo"), New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 8, "Saldo")})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT Id_Detalle_AP, Id_Empleado, Numero, Monto, Tipo_Pago, Id_Planilla, Interes" & _
    "_Prestamo, Saldo FROM Adelantos_Detalle"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand9
        '
        Me.SqlUpdateCommand9.CommandText = resources.GetString("SqlUpdateCommand9.CommandText")
        Me.SqlUpdateCommand9.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 50, "Id_Empleado"), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Tipo_Pago", System.Data.SqlDbType.Bit, 1, "Tipo_Pago"), New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.Int, 4, "Id_Planilla"), New System.Data.SqlClient.SqlParameter("@Interes_Prestamo", System.Data.SqlDbType.Float, 8, "Interes_Prestamo"), New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 8, "Saldo"), New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle_AP", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle_AP", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Interes_Prestamo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Interes_Prestamo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Pago", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Detalle_AP", System.Data.SqlDbType.Int, 4, "Id_Detalle_AP")})
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Location = New System.Drawing.Point(440, 40)
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
        Me.GroupBox1.Location = New System.Drawing.Point(168, 224)
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
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(16, 24)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(416, 104)
        Me.GridControl2.TabIndex = 197
        Me.GridControl2.Text = "GridControl2"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId_Empleado, Me.colNumero, Me.colMonto, Me.colSaldo})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowHorzLines = False
        '
        'colId_Empleado
        '
        Me.colId_Empleado.Caption = "Cedula"
        Me.colId_Empleado.FieldName = "Identificacion"
        Me.colId_Empleado.FilterInfo = ColumnFilterInfo1
        Me.colId_Empleado.Name = "colId_Empleado"
        Me.colId_Empleado.VisibleIndex = 0
        '
        'colNumero
        '
        Me.colNumero.Caption = "Numero"
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.FilterInfo = ColumnFilterInfo2
        Me.colNumero.Name = "colNumero"
        Me.colNumero.VisibleIndex = 1
        '
        'colMonto
        '
        Me.colMonto.Caption = "Deducir"
        Me.colMonto.DisplayFormat.FormatString = "#,##0.00"
        Me.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto.FieldName = "DeducirxPago"
        Me.colMonto.FilterInfo = ColumnFilterInfo3
        Me.colMonto.Name = "colMonto"
        Me.colMonto.VisibleIndex = 2
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.DisplayFormat.FormatString = "#,##0.00"
        Me.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.FilterInfo = ColumnFilterInfo4
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colSaldo.VisibleIndex = 3
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button2.Location = New System.Drawing.Point(440, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 24)
        Me.Button2.TabIndex = 196
        Me.Button2.Text = "Cancelar"
        '
        'colAccionPersonal
        '
        Me.colAccionPersonal.Caption = "AccionPersonal"
        Me.colAccionPersonal.FieldName = "AccionPersonal"
        Me.colAccionPersonal.FilterInfo = ColumnFilterInfo5
        Me.colAccionPersonal.Name = "colAccionPersonal"
        Me.colAccionPersonal.VisibleIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(1080, 662)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 198
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsPlanilla1, "Planilla.FechaInicial", True))
        Me.dtFechaInicio.Enabled = False
        Me.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicio.Location = New System.Drawing.Point(8, 22)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Size = New System.Drawing.Size(88, 20)
        Me.dtFechaInicio.TabIndex = 199
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsPlanilla1, "Planilla.FechaFinal", True))
        Me.dtFechaFinal.Enabled = False
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(120, 22)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(88, 20)
        Me.dtFechaFinal.TabIndex = 200
        '
        'AdOrdinarias
        '
        Me.AdOrdinarias.SelectCommand = Me.SqlSelectCommand14
        Me.AdOrdinarias.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Horas_Ordinarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Horas", "Horas"), New System.Data.Common.DataColumnMapping("Individual", "Individual")})})
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.CommandText = "SELECT Horas, Individual FROM Horas_Ordinarias"
        Me.SqlSelectCommand14.Connection = Me.SqlConnection1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(983, 664)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 204
        Me.Label2.Text = "Total Planilla"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(681, 664)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(264, 13)
        Me.txtNombreUsuario.TabIndex = 203
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.ForeColor = System.Drawing.Color.Blue
        Me.TextBox2.Location = New System.Drawing.Point(635, 664)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(40, 13)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(558, 664)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 202
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFormaPago
        '
        Me.btnFormaPago.Location = New System.Drawing.Point(352, 4)
        Me.btnFormaPago.Name = "btnFormaPago"
        Me.btnFormaPago.Size = New System.Drawing.Size(56, 40)
        Me.btnFormaPago.TabIndex = 205
        Me.btnFormaPago.Text = "Forma Pago"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(811, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(369, 16)
        Me.Label4.TabIndex = 206
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 658)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(1189, 22)
        Me.StatusBar1.TabIndex = 207
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "F4 Reportes de Marcas"
        Me.StatusBarPanel1.Width = 140
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Check_ServProf)
        Me.Panel1.Controls.Add(Me.dtFechaInicio)
        Me.Panel1.Controls.Add(Me.dtFechaFinal)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CheckCierreMes)
        Me.Panel1.Controls.Add(Me.btnFormaPago)
        Me.Panel1.Location = New System.Drawing.Point(755, 608)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 48)
        Me.Panel1.TabIndex = 208
        '
        'Check_ServProf
        '
        Me.Check_ServProf.BackColor = System.Drawing.Color.Transparent
        Me.Check_ServProf.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPlanilla1, "Planilla.Serv_Prof", True))
        Me.Check_ServProf.Enabled = False
        Me.Check_ServProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_ServProf.ForeColor = System.Drawing.Color.Blue
        Me.Check_ServProf.Location = New System.Drawing.Point(216, 8)
        Me.Check_ServProf.Name = "Check_ServProf"
        Me.Check_ServProf.Size = New System.Drawing.Size(128, 16)
        Me.Check_ServProf.TabIndex = 206
        Me.Check_ServProf.Text = "Serv. Profesionales"
        Me.Check_ServProf.UseVisualStyleBackColor = False
        '
        'GroupBoxCxC
        '
        Me.GroupBoxCxC.Controls.Add(Me.btnLimpiarAbonoCxC)
        Me.GroupBoxCxC.Controls.Add(Me.GridControlFacturasCobrar)
        Me.GroupBoxCxC.Controls.Add(Me.ButtonCancelar)
        Me.GroupBoxCxC.Controls.Add(Me.ButtonActualizar)
        Me.GroupBoxCxC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxCxC.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxCxC.Location = New System.Drawing.Point(192, 160)
        Me.GroupBoxCxC.Name = "GroupBoxCxC"
        Me.GroupBoxCxC.Size = New System.Drawing.Size(576, 216)
        Me.GroupBoxCxC.TabIndex = 209
        Me.GroupBoxCxC.TabStop = False
        Me.GroupBoxCxC.Text = "Facturas a cobrar"
        Me.GroupBoxCxC.Visible = False
        '
        'btnLimpiarAbonoCxC
        '
        Me.btnLimpiarAbonoCxC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarAbonoCxC.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnLimpiarAbonoCxC.Location = New System.Drawing.Point(494, 90)
        Me.btnLimpiarAbonoCxC.Name = "btnLimpiarAbonoCxC"
        Me.btnLimpiarAbonoCxC.Size = New System.Drawing.Size(72, 24)
        Me.btnLimpiarAbonoCxC.TabIndex = 198
        Me.btnLimpiarAbonoCxC.Text = "Limpiar"
        '
        'GridControlFacturasCobrar
        '
        Me.GridControlFacturasCobrar.DataMember = "Facturas_Cobrar"
        Me.GridControlFacturasCobrar.DataSource = Me.DsPlanilla1
        '
        '
        '
        Me.GridControlFacturasCobrar.EmbeddedNavigator.Name = ""
        Me.GridControlFacturasCobrar.Location = New System.Drawing.Point(8, 16)
        Me.GridControlFacturasCobrar.MainView = Me.GridView3
        Me.GridControlFacturasCobrar.Name = "GridControlFacturasCobrar"
        Me.GridControlFacturasCobrar.Size = New System.Drawing.Size(480, 192)
        Me.GridControlFacturasCobrar.TabIndex = 197
        Me.GridControlFacturasCobrar.Text = "GridControlFacturarCobrar"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnFecha, Me.GridColumnNumero_Factura, Me.GridColumnCobrar, Me.GridColumnTotal, Me.GridColumnAbono})
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", Me.GridColumnTotal, "")})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumnFecha
        '
        Me.GridColumnFecha.Caption = "Fecha"
        Me.GridColumnFecha.DisplayFormat.FormatString = "d"
        Me.GridColumnFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumnFecha.FieldName = "Fecha"
        Me.GridColumnFecha.FilterInfo = ColumnFilterInfo6
        Me.GridColumnFecha.Name = "GridColumnFecha"
        Me.GridColumnFecha.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumnFecha.VisibleIndex = 0
        Me.GridColumnFecha.Width = 80
        '
        'GridColumnNumero_Factura
        '
        Me.GridColumnNumero_Factura.Caption = "Factura"
        Me.GridColumnNumero_Factura.FieldName = "NumeroFactura"
        Me.GridColumnNumero_Factura.FilterInfo = ColumnFilterInfo7
        Me.GridColumnNumero_Factura.Name = "GridColumnNumero_Factura"
        Me.GridColumnNumero_Factura.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumnNumero_Factura.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.GridColumnNumero_Factura.VisibleIndex = 1
        Me.GridColumnNumero_Factura.Width = 95
        '
        'GridColumnCobrar
        '
        Me.GridColumnCobrar.Caption = "Cobrar"
        Me.GridColumnCobrar.FieldName = "Cobrar"
        Me.GridColumnCobrar.FilterInfo = ColumnFilterInfo8
        Me.GridColumnCobrar.Name = "GridColumnCobrar"
        Me.GridColumnCobrar.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumnCobrar.VisibleIndex = 2
        Me.GridColumnCobrar.Width = 90
        '
        'GridColumnTotal
        '
        Me.GridColumnTotal.Caption = "Total"
        Me.GridColumnTotal.DisplayFormat.FormatString = "N2"
        Me.GridColumnTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnTotal.FieldName = "Total"
        Me.GridColumnTotal.FilterInfo = ColumnFilterInfo9
        Me.GridColumnTotal.Name = "GridColumnTotal"
        Me.GridColumnTotal.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumnTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumnTotal.VisibleIndex = 3
        Me.GridColumnTotal.Width = 100
        '
        'GridColumnAbono
        '
        Me.GridColumnAbono.Caption = "Abono"
        Me.GridColumnAbono.DisplayFormat.FormatString = "N2"
        Me.GridColumnAbono.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumnAbono.FieldName = "Abono"
        Me.GridColumnAbono.FilterInfo = ColumnFilterInfo10
        Me.GridColumnAbono.Name = "GridColumnAbono"
        Me.GridColumnAbono.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumnAbono.VisibleIndex = 4
        Me.GridColumnAbono.Width = 101
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ButtonCancelar.Location = New System.Drawing.Point(496, 184)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(72, 24)
        Me.ButtonCancelar.TabIndex = 196
        Me.ButtonCancelar.Text = "Cerrar"
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonActualizar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ButtonActualizar.Location = New System.Drawing.Point(496, 120)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(72, 24)
        Me.ButtonActualizar.TabIndex = 195
        Me.ButtonActualizar.Text = "Actualizar"
        '
        'SqlDataAdapterAbonocCobrar
        '
        Me.SqlDataAdapterAbonocCobrar.DeleteCommand = Me.SqlDeleteCommand13
        Me.SqlDataAdapterAbonocCobrar.InsertCommand = Me.SqlInsertCommand14
        Me.SqlDataAdapterAbonocCobrar.SelectCommand = Me.SqlSelectCommand16
        Me.SqlDataAdapterAbonocCobrar.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "abonoccobrar", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Recibo", "Id_Recibo"), New System.Data.Common.DataColumnMapping("Num_Recibo", "Num_Recibo"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente"), New System.Data.Common.DataColumnMapping("Saldo_Cuenta", "Saldo_Cuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Saldo_Actual", "Saldo_Actual"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anula", "Anula"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Asiento", "Asiento"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Id_Planilla", "Id_Planilla")})})
        Me.SqlDataAdapterAbonocCobrar.UpdateCommand = Me.SqlUpdateCommand14
        '
        'SqlDeleteCommand13
        '
        Me.SqlDeleteCommand13.CommandText = "DELETE FROM [abonoccobrar] WHERE (([Id_Recibo] = @Original_Id_Recibo))"
        Me.SqlDeleteCommand13.Connection = Me.SqlConnectionHotel
        Me.SqlDeleteCommand13.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Recibo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Recibo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnectionHotel
        '
        Me.SqlConnectionHotel.ConnectionString = "Data Source=.;Initial Catalog=SeePOS;Integrated Security=True"
        Me.SqlConnectionHotel.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand14
        '
        Me.SqlInsertCommand14.CommandText = resources.GetString("SqlInsertCommand14.CommandText")
        Me.SqlInsertCommand14.Connection = Me.SqlConnectionHotel
        Me.SqlInsertCommand14.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Recibo", System.Data.SqlDbType.BigInt, 0, "Num_Recibo"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.BigInt, 0, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Saldo_Cuenta", System.Data.SqlDbType.Float, 0, "Saldo_Cuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Actual", System.Data.SqlDbType.Float, 0, "Saldo_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 0, "Anula"), New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 0, "Ced_Usuario"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 0, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.BigInt, 0, "Asiento"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 0, "Id_Planilla")})
        '
        'SqlSelectCommand16
        '
        Me.SqlSelectCommand16.CommandText = resources.GetString("SqlSelectCommand16.CommandText")
        Me.SqlSelectCommand16.Connection = Me.SqlConnectionHotel
        '
        'SqlUpdateCommand14
        '
        Me.SqlUpdateCommand14.CommandText = resources.GetString("SqlUpdateCommand14.CommandText")
        Me.SqlUpdateCommand14.Connection = Me.SqlConnectionHotel
        Me.SqlUpdateCommand14.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Recibo", System.Data.SqlDbType.BigInt, 0, "Num_Recibo"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.BigInt, 0, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Saldo_Cuenta", System.Data.SqlDbType.Float, 0, "Saldo_Cuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Actual", System.Data.SqlDbType.Float, 0, "Saldo_Actual"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 0, "Anula"), New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 0, "Ced_Usuario"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 0, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.BigInt, 0, "Asiento"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 0, "Id_Planilla"), New System.Data.SqlClient.SqlParameter("@Original_Id_Recibo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Recibo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Recibo", System.Data.SqlDbType.BigInt, 8, "Id_Recibo")})
        '
        'SqlDataAdapterDetalleAbono_cCobrar
        '
        Me.SqlDataAdapterDetalleAbono_cCobrar.DeleteCommand = Me.SqlDeleteCommand12
        Me.SqlDataAdapterDetalleAbono_cCobrar.InsertCommand = Me.SqlInsertCommand13
        Me.SqlDataAdapterDetalleAbono_cCobrar.SelectCommand = Me.SqlSelectCommand15
        Me.SqlDataAdapterDetalleAbono_cCobrar.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "detalle_abonoccobrar", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Consecutivo", "Consecutivo"), New System.Data.Common.DataColumnMapping("Id_Recibo", "Id_Recibo"), New System.Data.Common.DataColumnMapping("Factura", "Factura"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Saldo_Ant", "Saldo_Ant"), New System.Data.Common.DataColumnMapping("Intereses", "Intereses"), New System.Data.Common.DataColumnMapping("Abono", "Abono"), New System.Data.Common.DataColumnMapping("Abono_SuMoneda", "Abono_SuMoneda"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo")})})
        Me.SqlDataAdapterDetalleAbono_cCobrar.UpdateCommand = Me.SqlUpdateCommand13
        '
        'SqlDeleteCommand12
        '
        Me.SqlDeleteCommand12.CommandText = "DELETE FROM [detalle_abonoccobrar] WHERE (([Consecutivo] = @Original_Consecutivo)" & _
    ")"
        Me.SqlDeleteCommand12.Connection = Me.SqlConnectionHotel
        Me.SqlDeleteCommand12.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand13
        '
        Me.SqlInsertCommand13.CommandText = resources.GetString("SqlInsertCommand13.CommandText")
        Me.SqlInsertCommand13.Connection = Me.SqlConnectionHotel
        Me.SqlInsertCommand13.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Recibo", System.Data.SqlDbType.BigInt, 0, "Id_Recibo"), New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 0, "Factura"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 0, "Tipo"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 0, "Saldo_Ant"), New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Float, 0, "Intereses"), New System.Data.SqlClient.SqlParameter("@Abono", System.Data.SqlDbType.Float, 0, "Abono"), New System.Data.SqlClient.SqlParameter("@Abono_SuMoneda", System.Data.SqlDbType.Float, 0, "Abono_SuMoneda"), New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 0, "Saldo")})
        '
        'SqlSelectCommand15
        '
        Me.SqlSelectCommand15.CommandText = "SELECT        Consecutivo, Id_Recibo, Factura, Fecha, Tipo, Monto, Saldo_Ant, Int" & _
    "ereses, Abono, Abono_SuMoneda, Saldo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            detalle_abonoccobrar"
        Me.SqlSelectCommand15.Connection = Me.SqlConnectionHotel
        '
        'SqlUpdateCommand13
        '
        Me.SqlUpdateCommand13.CommandText = resources.GetString("SqlUpdateCommand13.CommandText")
        Me.SqlUpdateCommand13.Connection = Me.SqlConnectionHotel
        Me.SqlUpdateCommand13.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Recibo", System.Data.SqlDbType.BigInt, 0, "Id_Recibo"), New System.Data.SqlClient.SqlParameter("@Factura", System.Data.SqlDbType.Float, 0, "Factura"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 0, "Tipo"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Saldo_Ant", System.Data.SqlDbType.Float, 0, "Saldo_Ant"), New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Float, 0, "Intereses"), New System.Data.SqlClient.SqlParameter("@Abono", System.Data.SqlDbType.Float, 0, "Abono"), New System.Data.SqlClient.SqlParameter("@Abono_SuMoneda", System.Data.SqlDbType.Float, 0, "Abono_SuMoneda"), New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 0, "Saldo"), New System.Data.SqlClient.SqlParameter("@Original_Consecutivo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Consecutivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Consecutivo", System.Data.SqlDbType.BigInt, 8, "Consecutivo")})
        '
        'txtPlanillaNumero
        '
        Me.txtPlanillaNumero.BackColor = System.Drawing.Color.White
        Me.txtPlanillaNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlanillaNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlanillaNumero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPlanilla1, "Planilla.NumeroPlanilla", True))
        Me.txtPlanillaNumero.ForeColor = System.Drawing.Color.Blue
        Me.txtPlanillaNumero.Location = New System.Drawing.Point(80, 16)
        Me.txtPlanillaNumero.Name = "txtPlanillaNumero"
        Me.txtPlanillaNumero.ReadOnly = True
        Me.txtPlanillaNumero.Size = New System.Drawing.Size(96, 13)
        Me.txtPlanillaNumero.TabIndex = 210
        Me.txtPlanillaNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AdapterDed
        '
        Me.AdapterDed.DeleteCommand = Me.SqlDeleteCommand14
        Me.AdapterDed.InsertCommand = Me.SqlInsertCommand15
        Me.AdapterDed.SelectCommand = Me.SqlSelectCommand17
        Me.AdapterDed.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Deduccion_Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Deduccion", "Id_Deduccion"), New System.Data.Common.DataColumnMapping("Id_Detalle", "Id_Detalle"), New System.Data.Common.DataColumnMapping("CCSS", "CCSS"), New System.Data.Common.DataColumnMapping("ALIMENTACION", "ALIMENTACION"), New System.Data.Common.DataColumnMapping("CAMISETAS", "CAMISETAS"), New System.Data.Common.DataColumnMapping("PENSION", "PENSION"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda")})})
        Me.AdapterDed.UpdateCommand = Me.SqlUpdateCommand15
        '
        'SqlDeleteCommand14
        '
        Me.SqlDeleteCommand14.CommandText = resources.GetString("SqlDeleteCommand14.CommandText")
        Me.SqlDeleteCommand14.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand14.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Deduccion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Deduccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ALIMENTACION", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ALIMENTACION", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CAMISETAS", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAMISETAS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CCSS", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CCSS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PENSION", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PENSION", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand15
        '
        Me.SqlInsertCommand15.CommandText = resources.GetString("SqlInsertCommand15.CommandText")
        Me.SqlInsertCommand15.Connection = Me.SqlConnection1
        Me.SqlInsertCommand15.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Detalle", System.Data.SqlDbType.BigInt, 8, "Id_Detalle"), New System.Data.SqlClient.SqlParameter("@CCSS", System.Data.SqlDbType.Float, 8, "CCSS"), New System.Data.SqlClient.SqlParameter("@ALIMENTACION", System.Data.SqlDbType.Float, 8, "ALIMENTACION"), New System.Data.SqlClient.SqlParameter("@CAMISETAS", System.Data.SqlDbType.Float, 8, "CAMISETAS"), New System.Data.SqlClient.SqlParameter("@PENSION", System.Data.SqlDbType.Float, 8, "PENSION"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda")})
        '
        'SqlSelectCommand17
        '
        Me.SqlSelectCommand17.CommandText = "SELECT Id_Deduccion, Id_Detalle, CCSS, ALIMENTACION, CAMISETAS, PENSION, CodMoned" & _
    "a FROM Deduccion_Empleado"
        Me.SqlSelectCommand17.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand15
        '
        Me.SqlUpdateCommand15.CommandText = resources.GetString("SqlUpdateCommand15.CommandText")
        Me.SqlUpdateCommand15.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand15.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Detalle", System.Data.SqlDbType.BigInt, 8, "Id_Detalle"), New System.Data.SqlClient.SqlParameter("@CCSS", System.Data.SqlDbType.Float, 8, "CCSS"), New System.Data.SqlClient.SqlParameter("@ALIMENTACION", System.Data.SqlDbType.Float, 8, "ALIMENTACION"), New System.Data.SqlClient.SqlParameter("@CAMISETAS", System.Data.SqlDbType.Float, 8, "CAMISETAS"), New System.Data.SqlClient.SqlParameter("@PENSION", System.Data.SqlDbType.Float, 8, "PENSION"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Original_Id_Deduccion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Deduccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ALIMENTACION", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ALIMENTACION", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CAMISETAS", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CAMISETAS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CCSS", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CCSS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PENSION", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PENSION", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Deduccion", System.Data.SqlDbType.BigInt, 8, "Id_Deduccion")})
        '
        'btnBloquear
        '
        Me.btnBloquear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBloquear.Location = New System.Drawing.Point(339, 602)
        Me.btnBloquear.Name = "btnBloquear"
        Me.btnBloquear.Size = New System.Drawing.Size(75, 55)
        Me.btnBloquear.TabIndex = 211
        Me.btnBloquear.Text = "Bloquear Planilla"
        Me.btnBloquear.UseVisualStyleBackColor = True
        '
        'btnActualizarDatosEmpleado
        '
        Me.btnActualizarDatosEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnActualizarDatosEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarDatosEmpleado.Location = New System.Drawing.Point(487, 602)
        Me.btnActualizarDatosEmpleado.Name = "btnActualizarDatosEmpleado"
        Me.btnActualizarDatosEmpleado.Size = New System.Drawing.Size(75, 55)
        Me.btnActualizarDatosEmpleado.TabIndex = 212
        Me.btnActualizarDatosEmpleado.Text = "Actualizar Datos Empleado"
        Me.btnActualizarDatosEmpleado.UseVisualStyleBackColor = True
        '
        'btnLimpiarCxC
        '
        Me.btnLimpiarCxC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiarCxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarCxC.Location = New System.Drawing.Point(413, 602)
        Me.btnLimpiarCxC.Name = "btnLimpiarCxC"
        Me.btnLimpiarCxC.Size = New System.Drawing.Size(75, 55)
        Me.btnLimpiarCxC.TabIndex = 213
        Me.btnLimpiarCxC.Text = "Limpiar Cuentas por Cobrar"
        Me.btnLimpiarCxC.UseVisualStyleBackColor = True
        '
        'frmControlTiempo2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1189, 680)
        Me.Controls.Add(Me.btnLimpiarCxC)
        Me.Controls.Add(Me.btnActualizarDatosEmpleado)
        Me.Controls.Add(Me.btnBloquear)
        Me.Controls.Add(Me.txtPlanillaNumero)
        Me.Controls.Add(Me.GroupBoxCxC)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckAnulado)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.MaximizeBox = True
        Me.Name = "frmControlTiempo2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de Planilla"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.StatusBar1, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.CheckAnulado, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.txtNumero, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxCxC, 0)
        Me.Controls.SetChildIndex(Me.txtPlanillaNumero, 0)
        Me.Controls.SetChildIndex(Me.btnBloquear, 0)
        Me.Controls.SetChildIndex(Me.btnActualizarDatosEmpleado, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiarCxC, 0)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBoxCxC.ResumeLayout(False)
        CType(Me.GridControlFacturasCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub frmControlTiempo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IdPlanilla1 = 0
        sqlconexion1 = cconexion1.Conectar("Planilla")
        cedulajuridica = CStr(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT Cedula FROM Configuraciones"))
        cconexion1.DesConectar(sqlconexion1)
        Try
            '------------------------------------------------------------------------------
            'VALIDA SI UTILIZA CUENTAS X COBRAR O NO - ORA
            Try
                If GetSetting("SeeSoft", "Planilla", "CXC") = 1 Then
                    CuentasxC = True
                Else
                    CuentasxC = False
                End If
            Catch ex As Exception
                SaveSetting("SeeSoft", "Planilla", "CXC", "0")
            End Try
            '------------------------------------------------------------------------------

            dlg = New WaitDialogForm("Cargando saldos de Cuentas por Cobrar")
            SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
            SqlConnection2.ConnectionString = GetSetting("SeeSoft", "Proyecto", "Conexion")
            SqlConnectionHotel.ConnectionString = GetSetting("SeeSoft", "Hotel", "Conexion")

            Defaulvalue() 'valores por defecto
            adEmpleados.Fill(DsPlanilla1.Empleado)
            adDeducciones.Fill(DsPlanilla1.Deducciones)
            adAdelantos.Fill(DsPlanilla1.Adelantos)
            adRenta.Fill(DsPlanilla1.ParametroRenta)
            adAccion.Fill(DsPlanilla1.AccionPersonal)
            adMoneda.Fill(DsPlanilla1.Moneda)
            adPlanilla.Fill(DsPlanilla1.Planilla)
            AdOrdinarias.Fill(DsPlanilla1.Horas_Ordinarias)
            Me.CargarAccionesEmpleados()


            adEmpleadoDeducciones.Fill(DsPlanilla1, "Empleado_Deducciones")


            txtNumero.Text = ""
            txtNumero.ReadOnly = True
            CheckCierreMes.Checked = False
            CheckAnulado.Checked = False
            Check_ServProf.Checked = False
            dtFechaFinal.Enabled = False
            dtFechaInicio.Enabled = False
            TextBox2.Focus()
            CrearTabla()
            GridControl1.DataSource = TablaPlanilla
            ToolBar1.Buttons(0).Enabled = False
            ToolBar1.Buttons(1).Enabled = False
            ToolBar1.Buttons(2).Enabled = False
            Me.btnBloquear.Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(4).Enabled = False
            ToolBar1.Buttons(5).Enabled = False
            dtFechaFinal.Value = Now
            dtFechaInicio.Value = Now
            AddHandler BindingContext(TablaPlanilla).CurrentChanged, AddressOf Current_Changed
            dlg.Close()
            TextBox2.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Defaulvalue()
        'Tabla Planilla
        DsPlanilla1.Planilla.NumeroPlanillaColumn.DefaultValue = 0
        DsPlanilla1.Planilla.FechaColumn.DefaultValue = Now
        DsPlanilla1.Planilla.CierreMesColumn.DefaultValue = False
        DsPlanilla1.Planilla.Ced_UsuarioColumn.DefaultValue = ""
        DsPlanilla1.Planilla.Nombre_UsuarioColumn.DefaultValue = ""
        DsPlanilla1.Planilla.AnuladoColumn.DefaultValue = False
        DsPlanilla1.Planilla.Serv_ProfColumn.DefaultValue = False

        DsPlanilla1.Planilla.Id_PlanillaColumn.AutoIncrement = True
        DsPlanilla1.Planilla.Id_PlanillaColumn.AutoIncrementSeed = -1
        DsPlanilla1.Planilla.Id_PlanillaColumn.AutoIncrementStep = -1

        DsPlanilla1.Planilla_Detalle.IdColumn.AutoIncrement = True
        DsPlanilla1.Planilla_Detalle.IdColumn.AutoIncrementSeed = -1
        DsPlanilla1.Planilla_Detalle.IdColumn.AutoIncrementStep = -1
        DsPlanilla1.Planilla_Detalle.CuentasxCobrarColumn.DefaultValue = 0

        DsPlanilla1.Planilla_Deducciones.IdColumn.AutoIncrement = True
        DsPlanilla1.Planilla_Deducciones.IdColumn.AutoIncrementSeed = -1
        DsPlanilla1.Planilla_Deducciones.IdColumn.AutoIncrementStep = -1

        DsPlanilla1.Deduccion_Empleado.Id_DeduccionColumn.AutoIncrement = True
        DsPlanilla1.Deduccion_Empleado.Id_DeduccionColumn.AutoIncrementSeed = -1
        DsPlanilla1.Deduccion_Empleado.Id_DeduccionColumn.AutoIncrementStep = -1

        'Planilla_DetallePlanilla_Deducciones
        DsPlanilla1.Planilla_Deducciones.MontoColumn.DefaultValue = 0
    End Sub
    Function CrearColumnas(ByVal Nombre As String, ByVal Titulo As String, ByVal Tamano As Int16, ByVal Orden As Int16, ByVal Campo As String, ByVal Numerico As Boolean, ByVal Editable As Boolean, ByVal Calculadora As Boolean, ByVal Sumar As Boolean, Optional ByVal Visible As Boolean = True)
        Dim Column = GridView1.Columns.Add
        Column.Caption = Titulo
        Column.fieldname = Campo
        Column.Name = Nombre
        Column.VisibleIndex = Orden
        Column.width = Tamano

        If Visible = False Then
            Column.VisibleIndex = -1
            Column.width = 0
        End If

        If Sumar = True Then
            Try
                Column.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                'GridColumnTotal.SummaryItem.DisplayFormat = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

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
    End Function
    Function CrearTabla()
        Try
            Dim i As Int16
            TablaPlanilla.Clear()
            TablaPlanilla.Columns.Clear()

            Dim Orden As Integer = 1

            CrearColumnas("Cedula", "Cédula", 150, Orden, "Cedula", False, False, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("Cedula", GetType(String)))
            Orden += 1

            CrearColumnas("Nombre", "Nombre del Empleado", 350, Orden, "Nombre", False, False, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("Nombre", GetType(String)))
            Orden += 1

            CrearColumnas("Moneda", "Moneda", 75, Orden, "Moneda", False, False, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("Moneda", GetType(String)))
            Orden += 1

            CrearColumnas("Salario", "Salario", 100, Orden, "Salario", True, False, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("Salario", GetType(Double)))
            Orden += 1

            CrearColumnas("Forma", "Forma Pago", 100, Orden, "FormaPago", False, False, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("FormaPago", GetType(String)))
            Orden += 1

            '*****************************************************************************************************************************
            CrearColumnas("DíasLibre", "Días Libre", 110, Orden, "DíasLibre", True, False, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("DíasLibre", GetType(Double)))
            Orden += 1

            CrearColumnas("DíasDescontar", "Días Descontar", 75, Orden, "DíasDescontar", True, False, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("DíasDescontar", GetType(Double)))
            Orden += 1

            CrearColumnas("Vacacciones", "Vacacciones", 75, Orden, "Vacacciones", True, False, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("Vacacciones", GetType(Double)))
            Orden += 1

            CrearColumnas("IncapacidadINS", "INS", 75, Orden, "IncapacidadINS", True, False, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("IncapacidadINS", GetType(Double)))
            Orden += 1

            CrearColumnas("IncapacidadCCSS", "CCSS", 75, Orden, "IncapacidadCCSS", True, False, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("IncapacidadCCSS", GetType(Double)))
            Orden += 1

            CrearColumnas("IncapacidadEmbarazo", "Embarazo", 75, Orden, "IncapacidadEmbarazo", True, False, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("IncapacidadEmbarazo", GetType(Double)))
            Orden += 1
            '*****************************************************************************************************************************

            CrearColumnas("Ordinarias", "H. Ordinarias", 125, Orden, "Ordinarias", True, True, True, False)
            TablaPlanilla.Columns.Add(New DataColumn("Ordinarias", GetType(Double)))
            Orden += 1

            CrearColumnas("Ord_Nocturna", "Ord.Nocturna", 125, Orden, "Ord_Nocturna", True, True, True, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("Ord_Nocturna", GetType(Double)))
            Orden += 1

            CrearColumnas("Extras", "H. Extras", 100, Orden, "Extras", True, True, True, False)
            TablaPlanilla.Columns.Add(New DataColumn("Extras", GetType(Double)))
            Orden += 1

            CrearColumnas("Ext_Nocturna", "Ext.Nocturna", 100, Orden, "Ext_Nocturna", True, True, True, False, False)
            TablaPlanilla.Columns.Add(New DataColumn("Ext_Nocturna", GetType(Double)))
            Orden += 1

            CrearColumnas("Dobles", "H. Dobles", 100, Orden, "Dobles", True, True, True, False)
            TablaPlanilla.Columns.Add(New DataColumn("Dobles", GetType(Double)))
            Orden += 1

            CrearColumnas("Feriadas", "H. Feriadas", 100, Orden, "Feriadas", True, True, True, False)
            TablaPlanilla.Columns.Add(New DataColumn("Feriadas", GetType(Double)))
            Orden += 1

            CrearColumnas("Otros_Ingresos", "Otros Ingresos", 125, Orden, "Otros_Ingresos", True, True, True, True)
            TablaPlanilla.Columns.Add(New DataColumn("Otros_Ingresos", GetType(Double)))
            Orden += 1

            CrearColumnas("SalarioBruta", "Salario Bruto", 150, Orden, "SalarioBruto", True, False, False, True)
            TablaPlanilla.Columns.Add(New DataColumn("SalarioBruto", GetType(Double)))
            Orden += 1

            For i = 0 To DsPlanilla1.Deducciones.Rows.Count - 1
                CrearColumnas(DsPlanilla1.Deducciones.Rows(i).Item("Descripcion").ToString, DsPlanilla1.Deducciones.Rows(i).Item("Descripcion"), 125, Orden, DsPlanilla1.Deducciones.Rows(i).Item("Descripcion").ToString, True, True, True, True)
                Orden += 1
                TablaPlanilla.Columns.Add(New DataColumn(DsPlanilla1.Deducciones.Rows(i).Item("Descripcion").ToString, GetType(Double)))
            Next

            CrearColumnas("Adelantos", "Adelantos", 100, Orden, "Adelantos", True, False, False, True)
            TablaPlanilla.Columns.Add(New DataColumn("Adelantos", GetType(Double)))
            Orden += 1

            CrearColumnas("Préstamos", "Préstamos", 125, Orden, "Prestamos", True, False, False, True)
            TablaPlanilla.Columns.Add(New DataColumn("Prestamos", GetType(Double)))
            Orden += 1

            CrearColumnas("Prestamos_Int", "Intereses Prest.", 125, Orden, "Prestamos_Int", True, False, False, True)
            TablaPlanilla.Columns.Add(New DataColumn("Prestamos_Int", GetType(Double)))
            Orden += 1

            CrearColumnas("Saldo", "Saldo Prestamos", 150, Orden, "Saldo", True, False, False, True)
            TablaPlanilla.Columns.Add(New DataColumn("Saldo", GetType(Double)))
            Orden += 1

            CrearColumnas("Renta", "Renta", 100, Orden, "Renta", True, False, False, True)
            TablaPlanilla.Columns.Add(New DataColumn("Renta", GetType(Double)))
            Orden += 1

            If CuentasxC Then
                CrearColumnas("CxC", "Cuentas por Cobrar", 150, Orden, "CxC", True, False, False, True)
                TablaPlanilla.Columns.Add(New DataColumn("CxC", GetType(Double)))
                Orden += 1
            End If

            CrearColumnas("TotalDeducciones", "Total Deducciones", 175, Orden, "TotalDeducciones", True, False, False, True)
            TablaPlanilla.Columns.Add(New DataColumn("TotalDeducciones", GetType(Double)))
            Orden += 1

            CrearColumnas("SalarioNeto", "Salario Neto", 150, Orden, "SalarioNeto", True, False, False, True)
            TablaPlanilla.Columns.Add(New DataColumn("SalarioNeto", GetType(Double)))
            Orden += 1

        Catch ex As Exception
            MsgBox("No se pudo cargar la tabla, comunique del siguiente error al administrador del sistema" + ex.ToString, MsgBoxStyle.Critical, "SeePos")
        End Try
    End Function
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(Usuario.Cedula, Name) 'Carga los privilegios del usuario con el modulo
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()
            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : Editar()
            Case 4 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : Anular()
            Case 6 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 7 : If MessageBox.Show("¿Desea Cerrar el Módulo de Planilla?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Close()
        End Select
    End Sub
#End Region
#Region "Controles"
    Private Sub Desbloquear()
        dtFechaInicio.Enabled = True
        dtFechaFinal.Enabled = True
        CheckCierreMes.Enabled = True
        CheckAnulado.Enabled = True
        Check_ServProf.Enabled = True
    End Sub

    Private Sub Bloquear()
        dtFechaInicio.Enabled = False
        dtFechaFinal.Enabled = False
        CheckCierreMes.Enabled = False
        CheckAnulado.Enabled = False
        Check_ServProf.Enabled = False
        txtNumero.Text = ""
        txtNumero.ReadOnly = True
    End Sub

    Function Limpiar()
        txtNumero.Text = ""
        txtPlanillaNumero.Text = ""
        dtFechaInicio.Value = Now()
        dtFechaFinal.Value = Now()
        CheckCierreMes.Checked = False
        CheckAnulado.Checked = False
        Check_ServProf.Checked = False
    End Function
#End Region
#Region "Editar"
    Function Editar()

        If Me.PuedeEditar(Me.txtPlanillaNumero.Text) = False Then
            Exit Function
        End If

        Dim opc As Boolean
        Dim Cx As New Conexion
        opc = Cx.SlqExecuteScalar(Cx.Conectar("Planilla"), "select formapago from planilla where id_planilla='" & Me.IdPlanilla1 & "'")
        If opc = False Then
            Me.GridControl1.Enabled = True
            ToolBar1.Buttons(0).Text = "Cancelar"
            ToolBar1.Buttons(0).ImageIndex = 8
            Me.Desbloquear()
            ToolBar1.Buttons(3).Text = "Actualizar"
            'nuevo
            Me.ToolBar1.Buttons(0).Enabled = True
            'buscar
            Me.ToolBar1.Buttons(1).Enabled = False
            'editar
            Me.ToolBar1.Buttons(2).Enabled = False
            Me.btnBloquear.Enabled = False
            'registrar
            Me.ToolBar1.Buttons(3).Enabled = True
            'eliminar
            Me.ToolBar1.Buttons(4).Enabled = True
            'Imprimir
            Me.ToolBar1.Buttons(5).Enabled = True
            'Cerrar
            Me.ToolBar1.Buttons(6).Enabled = True
        Else
            MsgBox("La planilla ya esta paga no se puede modificar", MsgBoxStyle.Information)
        End If

    End Function
#End Region
#Region "Nuevo"
    Private Sub Nuevo()
        IdPlanilla1 = 0
        If ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            'cambia la imagen de nuevo y desabilita los botones
            btnFormaPago.Enabled = False
            dtFechaFinal.Enabled = True
            Me.GridControl1.Enabled = True
            ToolBar1.Buttons(0).Text = "Cancelar"
            ToolBar1.Buttons(0).ImageIndex = 8
            Try 'inicia la edicion
                var = False
                dtFechaInicio.Focus()
                TablaPlanilla.Clear()
                Label3.Text = ""
                Check_ServProf.Checked = False
                BindingContext(DsPlanilla1.Planilla).CancelCurrentEdit()
                BindingContext(DsPlanilla1.Planilla).EndCurrentEdit()
                BindingContext(DsPlanilla1.Planilla).AddNew()
                ToolBar1.Buttons(1).Enabled = True
                ToolBar1.Buttons(2).Enabled = False
                Me.btnBloquear.Enabled = False
                ToolBar1.Buttons(3).Enabled = True
                ToolBar1.Buttons(4).Enabled = False
                ToolBar1.Buttons(5).Enabled = False
                dtFechaFinal.Value = Now
                dtFechaInicio.Value = Now
                GridControl1.Enabled = True
                NumeroPlanilla()
                Desbloquear()
                PlanillaNumero()
                dtFechaInicio.Focus()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                Limpiar()
                Edicion = False
                TablaPlanilla.Clear()
                var = False
                Me.DsPlanilla1.Planilla_Deducciones.Clear()
                Me.DsPlanilla1.Planilla_Detalle.Clear()
                Me.DsPlanilla1.Planilla.Clear()
                BindingContext(DsPlanilla1, "Planilla_Detalle").CancelCurrentEdit()
                BindingContext(DsPlanilla1.Planilla).CancelCurrentEdit()
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
                ToolBar1.Buttons(1).Enabled = True
                ToolBar1.Buttons(2).Enabled = False
                Me.btnBloquear.Enabled = False
                ToolBar1.Buttons(3).Enabled = False
                ToolBar1.Buttons(4).Enabled = False
                Bloquear()
                Me.ToolBarRegistrar.Text = "Registrar"
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Sub

    Sub NumeroPlanilla()
        Dim Cx As New Conexion
        NumeroPlanilla1 = Cx.SlqExecuteScalar(Cx.Conectar("Planilla"), "SELECT ISNULL(MAX(Id_Planilla), 0) + 1  FROM Planilla  ")
        Cx.DesConectar(Cx.sQlconexion)
        txtNumero.Text = NumeroPlanilla1
    End Sub

    Sub PlanillaNumero()
        Dim Cx As New Conexion
        txtPlanillaNumero.Text = Cx.SlqExecuteScalar(Cx.Conectar("Planilla"), "SELECT ISNULL(MAX(NumeroPlanilla), 0) + 1  FROM Planilla Where Serv_Prof = " & CInt(Check_ServProf.CheckState))
        Cx.DesConectar(Cx.sQlconexion)
    End Sub
#End Region
#Region "Generar Planilla"
    Function CodigoEstado()
        Dim Cx As New Conexion
        Codigo = Cx.SlqExecuteScalar(Cx.Conectar("Planilla"), "SELECT Codigo FROM Estado_Empleado  where Descripcion='Activo'")
        Cx.DesConectar(Cx.sQlconexion)
    End Function

    Private Sub CargarDatos()

        Dim dr As DataRow
        Dim contador As Integer
        Dim i, k As Integer : Dim J As Integer : Dim Z As Integer : Dim Y As Integer
        Dim HF, HO, HE, HD, HO1, HE1, HD1, HorasTotales As Integer
        Dim FormaPagos, Descripcion, Descripcion1 As String
        Dim Fecha1, Fecha2 As Date
        Dim HorasD, HorasE, HorasO, HorasF As Double
        Dim Tipo As Char
        Dim Estado_Civil As String
        Dim Ordinarias, Extras, Dobles, Feriadas, Salario, Salarios, SalarioBruto, Monto, Deduccion, TotalDeducciones, SalarioNeto, Total, Porcentaje1, Porcentaje2, Hijos As Double
        Dim Adelanto, Prestamo, Adelantos, Prestamos, MontoExento, MontoDe, MontoHasta, MontoAdelante, PEsposa, PHijo, Renta, Renta1, Renta2, Renta3, RentaTotal As Double
        Dim fechainicial, fechafinal, FECHA As String
        Dim fijo As Double


        adAdelantos.Fill(DsPlanilla1, "Adelantos")
        adAccion.Fill(DsPlanilla1, "AccionPersonal")
        AdOrdinarias.Fill(DsPlanilla1, "Horas_Ordinarias")
        adEmpleados.Fill(DsPlanilla1.Empleado)
        HorasTrabajadas.Fill(DsPlanilla1.HorasTrabajadas)
        fechainicial = dtFechaInicio.Text
        fechafinal = dtFechaFinal.Text
        CodigoEstado()
        TablaPlanilla.Clear()

        For i = 0 To DsPlanilla1.Empleado.Rows.Count - 1
            If DsPlanilla1.Empleado.Rows(i).Item("Cod_Estado") = Codigo And DsPlanilla1.Empleado.Rows(i).Item("ServiciosProf") = Check_ServProf.Checked Then  ' SE CARGAN SOLO LOS EMPLEADOS ACTIVOS
                dr = TablaPlanilla.NewRow
                dr("Cedula") = DsPlanilla1.Empleado.Rows(i).Item("Identificacion").ToString
                dr("Nombre") = DsPlanilla1.Empleado.Rows(i).Item("Nombre").ToString
                dr("Salario") = DsPlanilla1.Empleado.Rows(i).Item("Salario")
                If DsPlanilla1.Empleado.Rows(i).Item("Hora") = True Then FormaPagos = "HORA"
                If DsPlanilla1.Empleado.Rows(i).Item("Diario") = True Then FormaPagos = "DIARIO"
                If DsPlanilla1.Empleado.Rows(i).Item("Semana") = True Then FormaPagos = "SEMANAL"
                If DsPlanilla1.Empleado.Rows(i).Item("Quincena") = True Then FormaPagos = "QUINCENAL"
                If DsPlanilla1.Empleado.Rows(i).Item("Mensual") = True Then FormaPagos = "MENSUAL"
                dr("FormaPago") = FormaPagos
                '''''''''''''''''''' AQUI '''''''''''
                'Dim moned As String = DsPlanilla1.Empleado.Rows(i).Item("Cod_Moneda")
                'Moneda(moned)
                'dr("Moneda") = nombre
                '''''''''''''''''''''''''''''''''''''
                If DsPlanilla1.Empleado.Rows(i).Item("Cod_Moneda") = 1 Then
                    dr("Moneda") = "COLON"
                Else
                    dr("Moneda") = "DOLAR"
                End If
                'dr("DíasDescontar") = 0
                'dr("Vacacciones") = 0
                'dr("IncapacidadINS") = 0
                'dr("IncapacidadCCSS") = 0
                'dr("IncapacidadEmbarazo") = 0

                If GetSetting("SeeSoft", "Planilla", "Marcador") = 0 Then
                    If DsPlanilla1.Horas_Ordinarias.Rows(0).Item("Individual") Then
                        dr("Ordinarias") = DsPlanilla1.Empleado.Rows(i).Item("HorasOrdinarias")
                    Else

                        dr("Ordinarias") = DsPlanilla1.Horas_Ordinarias.Rows(0).Item("Horas")
                    End If
                Else

                    Dim fech As String
                    Dim dt As SqlDataReader
                    Dim ds As DataSet
                    Datos(i)
                    fech = Me.ConvertirFecha()
                    dt = Me.Cargar("SELECT CHECKTIME,CHECKTYPE FROM Check1 WHERE USERID=" & user1 & " OR USERID=" & user2 & " and (CHECKTIME >=" & "'" & " " & dtFechaInicio.Text & "'" & ")  and (CHECKTIME < " & "'" & " " & fech & "'" & ") ORDER BY CHECKTIME")
                    If GetSetting("SeeSoft", "Planilla", "Calcular") = 0 Then
                        dr("Ordinarias") = Me.Horas(dt, Me.dtFechaInicio.Text, fech)
                        If GetSetting("SeeSoft", "Planilla", "Extra") = 0 Then
                            dr("Extras") = 0
                        Else
                            dr("Extras") = extra
                            extra = 0
                        End If
                    ElseIf GetSetting("SeeSoft", "Planilla", "Calcular") = 1 Then
                        dr("Ordinarias") = Me.HorasOrdinarias(dt, i)
                    ElseIf GetSetting("SeeSoft", "Planilla", "Calcular") = 2 Then
                        dr("Ordinarias") = Me.HorasOrdinarias3()
                        If GetSetting("SeeSoft", "Planilla", "Extra") = 0 Then
                            dr("Extras") = 0
                        Else
                            dr("Extras") = extra
                            extra = 0
                        End If
                    End If

                    dt = Nothing
                End If

                dr("Ord_Nocturna") = 0
                dr("Ext_Nocturna") = 0
                dr("Feriadas") = 0
                dr("Dobles") = 0
                dr("Otros_Ingresos") = 0
                dr("Extras") = 0
                If FormaPagos = "HORA" Then
                    For J = 0 To DsPlanilla1.HorasTrabajadas.Rows.Count - 1
                        Fecha1 = DsPlanilla1.HorasTrabajadas.Rows(J).Item("Fecha")
                        If dr("Cedula") = DsPlanilla1.HorasTrabajadas.Rows(J).Item("Identificacion") And Fecha1.Date >= dtFechaInicio.Value.Date And Fecha1.Date <= dtFechaFinal.Value.Date Then
                            HorasD = HorasD + DsPlanilla1.HorasTrabajadas.Rows(J).Item("HoraDoble")
                            HorasE = HorasE + DsPlanilla1.HorasTrabajadas.Rows(J).Item("HoraExtra")
                            HorasO = HorasO + DsPlanilla1.HorasTrabajadas.Rows(J).Item("HoraOrdinaria")
                            HorasF = HorasF + DsPlanilla1.HorasTrabajadas.Rows(J).Item("HoraFeriada")
                        End If
                    Next
                    If HorasO <> 0 Then
                        dr("Ordinarias") = HorasO
                        dr("Extras") = HorasE
                        dr("Dobles") = HorasD
                        dr("Feriadas") = HorasF
                    End If

                    HorasE = 0
                    HorasD = 0
                    HorasO = 0
                    HorasF = 0
                End If

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                dr("Adelantos") = 0
                dr("Prestamos") = 0
                dr("Prestamos_Int") = 0
                dr("Saldo") = 0  'Modi
                Ordinarias = dr("Ordinarias")
                Extras = dr("Extras")
                Dobles = dr("Dobles")
                Feriadas = dr("Feriadas")
                Salario = dr("Salario")
                Select Case FormaPagos
                    Case "HORA" : dr("SalarioBruto") = ((Ordinarias * Salario) + ((Extras * 1.5) * Salario) + (Salario * (1 * Feriadas)) + (Salario * (2 * Dobles)))
                    Case "DIARIO"
                        Salarios = IIf(Ordinarias = 0, 0, Salario / Ordinarias)
                        dr("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles)))
                    Case "SEMANAL"
                        Salarios = (IIf(Ordinarias = 0, 0, Salario / (Ordinarias * 7)))
                        dr("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles)))
                    Case "QUINCENAL"
                        Salarios = IIf(Ordinarias = 0, 0, Salario / (15 * Ordinarias))
                        dr("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles)))
                    Case "MENSUAL"
                        Salarios = IIf(Ordinarias = 0, 0, Salario / (30 * Ordinarias))
                        dr("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles)))
                End Select

                dr("SalarioBruto") = dr("SalarioBruto") + dr("Otros_Ingresos")
                SalarioBruto = dr("SalarioBruto")

                For J = 0 To DsPlanilla1.Deducciones.Rows.Count - 1
                    dr(DsPlanilla1.Deducciones.Rows(J).Item("Descripcion").ToString) = 0
                Next

                MontoDe = DsPlanilla1.ParametroRenta.Rows(0).Item("MontoDe")
                MontoHasta = DsPlanilla1.ParametroRenta.Rows(0).Item("MontoHasta")
                MontoExento = DsPlanilla1.ParametroRenta.Rows(0).Item("MontoExento")
                MontoAdelante = DsPlanilla1.ParametroRenta.Rows(0).Item("MontoEnAdelante")
                Porcentaje1 = DsPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje1")
                Porcentaje2 = DsPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje2")
                PHijo = DsPlanilla1.ParametroRenta.Rows(0).Item("Hijo")
                PEsposa = DsPlanilla1.ParametroRenta.Rows(0).Item("Esposa")

                fijo = (MontoHasta - MontoDe) * (Porcentaje1 / 100)

                For k = 0 To DsPlanilla1.Empleado.Rows.Count - 1
                    If DsPlanilla1.Empleado.Rows(k).Item("Identificacion") = dr("Cedula") Then
                        Estado_Civil = DsPlanilla1.Empleado.Rows(k).Item("Estado_Civil")
                        Hijos = DsPlanilla1.Empleado.Rows(k).Item("Hijos")
                        Exit For
                    End If

                Next

                If CheckCierreMes.Checked = True And Check_ServProf.Checked = False Then
                    ParametroRenta()
                    Dim salariobruto2 As Double
                    salariobruto2 = SalarioBruto + Pagomes

                    If salariobruto2 <= MontoExento Then
                        dr("Renta") = 0
                    Else
                        If salariobruto2 > MontoDe And salariobruto2 < MontoAdelante Then
                            Renta = salariobruto2 - MontoDe
                            Renta = (Renta * Porcentaje1) / 100
                        End If

                        If salariobruto2 > MontoAdelante Then
                            Renta = fijo
                            Renta1 = salariobruto2 - MontoAdelante
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
                        dr("Renta") = RentaTotal
                    End If
                Else
                    dr("Renta") = 0
                End If

                TotalDeducciones = TotalDeducciones + RentaTotal
                dr("TotalDeducciones") = 0
                dr("SalarioNeto") = 0
                TablaPlanilla.Rows.Add(dr)
                Descripcion = ""
                RentaTotal = 0 : TotalDeducciones = 0
                Adelanto = 0 : Adelantos = 0
                Prestamo = 0 : Prestamos = 0
                HF = 0 : HO = 0 : HE = 0 : HD = 0
                HO1 = 0 : HE1 = 0 : HD1 = 0
                contador += 1 ' CUENTA LOS EMPLEADOS QUE FUERON CARGADOS
            End If
        Next

        Dim l As Integer = 0
        contador = contador - 1
        For l = 0 To contador ' SE MANDA A RECALCULAR LA PLANILLA PARA LOS EMPLEADOS CARGADOS
            Recalcular_Fila_Planilla(l)
        Next
        PlanillaNumero()
    End Sub

    Private vVacacciones, vINS, vCCSS, vEmbarazo As String
    Private Function GetAccionVacaccion() As String
        Return Me.vVacacciones
    End Function

    Private Function GetAccionINS() As String
        Return Me.vINS
    End Function

    Private Function GetAccionCCSS() As String
        Return Me.vCCSS
    End Function

    Private Function GetAccionEmbarazo() As String
        Return Me.vEmbarazo
    End Function

    Private Function GetAccionDiaLibre() As String
        '*********************************************************************************************************************
        'OJO
        '   En el regedit se asigna el codigo de la accion para dia libre
        '*********************************************************************************************************************
        '*********************************************************************************************************************
        Return GetSetting("SeeSoft", "Planilla", "Accion")
    End Function

    Private Sub Recalcular_Fila_Planilla(ByVal x As Integer)
        Dim Ordinarias, Extras, Dobles, ord_noct, ext_noct, Feriadas, Salario, Salarios, Monto, Deduccion, SalarioBruto, SalarioBruto2, Total, TotalDeducciones, Porcentaje1, Porcentaje2, Hijos As Double
        Dim MontoExento, MontoDe, MontoHasta, MontoAdelante, PEsposa, PHijo, Renta, Renta1, Renta2, Renta3, RentaTotal, Fijo As Double
        Dim J, k, Dias_IntPre As Integer
        Dim Pagar As Double
        Dim Tipo As Char
        Dim Descripcion, Descripcion1 As String
        Dim Adelanto, Prestamo, Adelantos, Prestamos, DiasDescontados1, DiasDescontados2, Aumento, DeduccionHO As Double
        Dim saldos, saldo, Porcentaje_IntPre, Monto_IntPre, Monto_IntPreTotal As Double
        Dim dr As DataRow
        Dim Estado_Civil As String
        Dim Vacaciones As String
        Dim Dias As Double = 0
        Dim libre, DiasDescontados, Vaca, INS, CCSS, Embarazo, DiasTemporal As Double
        Dim libre1 As Double = 0

        If x >= 0 Then
            dr = TablaPlanilla.NewRow
            BindingContext(TablaPlanilla).EndCurrentEdit()
            Ordinarias = TablaPlanilla.Rows(x).Item("Ordinarias")
            Extras = TablaPlanilla.Rows(x).Item("Extras")
            Feriadas = TablaPlanilla.Rows(x).Item("Feriadas")
            Dobles = TablaPlanilla.Rows(x).Item("Dobles")
            Salario = TablaPlanilla.Rows(x).Item("Salario")
            ord_noct = TablaPlanilla.Rows(x).Item("Ord_Nocturna")
            ext_noct = TablaPlanilla.Rows(x).Item("Ext_Nocturna")
            Dias = 0

            DiasTemporal = 0
            libre = 0
            DiasDescontados = 0
            Vaca = 0
            INS = 0
            CCSS = 0
            Embarazo = 0
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            For J = 0 To DsPlanilla1.AccionPersonal.Rows.Count - 1


                If DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Empleado") = TablaPlanilla.Rows(x).Item("Cedula") Then
                    Select Case DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion").ToString
                        Case Me.GetAccionDiaLibre
                            If dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    libre1 = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Value))) + 1
                                    libre += libre1
                                Else
                                    libre1 = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                    libre += libre1
                                End If
                            ElseIf dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                Dim dia As Double = 0
                                libre1 = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaInicio.Value)))
                                dia = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                libre1 = (dia - libre1)
                                libre += libre1
                            End If
                        Case Me.GetAccionVacaccion
                            '*****************************************************************************************************************************************
                            'Calculo de dias de vacacciones
                            '*****************************************************************************************************************************************
                            If dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Value))) + 1
                                    Vaca += DiasTemporal
                                Else
                                    DiasTemporal = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                    Vaca += DiasTemporal
                                End If
                            ElseIf dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                Dim dia As Double = 0
                                DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaInicio.Value)))
                                dia = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                DiasTemporal = (dia - DiasTemporal)
                                Vaca += DiasTemporal
                            End If
                            '*****************************************************************************************************************************************
                        Case Me.GetAccionINS
                            '*****************************************************************************************************************************************
                            'Calculo de dias de Incapacidades de INS
                            '*****************************************************************************************************************************************
                            If dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Value))) + 1
                                    INS += DiasTemporal
                                Else
                                    DiasTemporal = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                    INS += DiasTemporal
                                End If
                            ElseIf dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                Dim dia As Double = 0
                                DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaInicio.Value)))
                                dia = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                DiasTemporal = (dia - DiasTemporal)
                                INS += DiasTemporal
                            End If
                            '*****************************************************************************************************************************************
                        Case Me.GetAccionCCSS
                            '*****************************************************************************************************************************************
                            'Calculo de dias de Incapacidades de CCSS
                            '*****************************************************************************************************************************************
                            If dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Value))) + 1
                                    CCSS += DiasTemporal
                                Else
                                    DiasTemporal = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                    CCSS += DiasTemporal
                                End If
                            ElseIf dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                Dim dia As Double = 0
                                DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaInicio.Value)))
                                dia = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                DiasTemporal = (dia - DiasTemporal)
                                CCSS += DiasTemporal
                            End If
                            '*****************************************************************************************************************************************
                        Case Me.GetAccionEmbarazo
                            '*****************************************************************************************************************************************
                            'Calculo de dias de Incapacidades de Embarazo
                            '*****************************************************************************************************************************************
                            If dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Value))) + 1
                                    Embarazo += DiasTemporal
                                Else
                                    DiasTemporal = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                    Embarazo += DiasTemporal
                                End If
                            ElseIf dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                Dim dia As Double = 0
                                DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaInicio.Value)))
                                dia = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                DiasTemporal = (dia - DiasTemporal)
                                Embarazo += DiasTemporal
                            ElseIf dtFechaInicio.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                DiasTemporal = (DateDiff(DateInterval.Day, CDate(dtFechaInicio.Value), CDate(dtFechaFinal.Value))) + 1
                                Embarazo += DiasTemporal
                            End If
                            '*****************************************************************************************************************************************
                        Case Else
                            If dtFechaInicio.Text <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Text >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    Dias = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Text))) + 1
                                    Dias = Dias * PorcentajeAccion(DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion"))
                                    DiasDescontados = DiasDescontados + Dias
                                Else
                                    Dias = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                    Dias = Dias * PorcentajeAccion(DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion"))
                                    DiasDescontados = DiasDescontados + Dias
                                End If
                            ElseIf dtFechaInicio.Text <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Text >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                Dias = (DateDiff(DateInterval.Day, CDate(dtFechaInicio.Text), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                Dias = Dias * PorcentajeAccion(DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion"))
                                DiasDescontados = DiasDescontados + Dias
                            End If
                    End Select
                End If
            Next

            TablaPlanilla.Rows(x).Item("DíasLibre") = libre
            TablaPlanilla.Rows(x).Item("DíasDescontar") = DiasDescontados
            TablaPlanilla.Rows(x).Item("Vacacciones") = Vaca
            TablaPlanilla.Rows(x).Item("IncapacidadINS") = INS
            TablaPlanilla.Rows(x).Item("IncapacidadCCSS") = CCSS
            TablaPlanilla.Rows(x).Item("IncapacidadEmbarazo") = Embarazo

            If CCSS > 0 Then
                Dim dif As Integer = CCSS - 3
                If dif > 0 Then
                    DiasDescontados1 = DiasDescontados + INS + (Embarazo / 2) + dif
                Else
                    DiasDescontados1 = DiasDescontados + INS + (Embarazo / 2)
                End If                
            Else
                DiasDescontados1 = DiasDescontados + INS + (Embarazo / 2)
            End If


            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Select Case TablaPlanilla.Rows(x).Item("FormaPago")
                Case "HORA" : TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salario) + ((Extras * 1.5) * Salario) + ((ord_noct * 1.33) * Salario) + (((ext_noct * 1.33) * 1.5) * Salario) + (Salario * (1 * Feriadas)) + (Salario * (2 * Dobles)))
                    DiasDescontados2 = DiasDescontados1 * (Salario * 8)
                    DeduccionHO = (Ordinarias * Salario)
                Case "DIARIO"
                    Salarios = (Salario / 8)
                    DiasDescontados2 = DiasDescontados1 * Salario
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles)))
                Case "SEMANAL"
                    Salarios = (Salario / 56)
                    DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles)))
                Case "QUINCENAL"
                    Salarios = (Salario / 120)
                    DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles)))
                Case "MENSUAL"
                    Salarios = (Salario / 240)
                    DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles)))
            End Select

            For J = 0 To DsPlanilla1.Empleado.Rows.Count - 1

                If TablaPlanilla.Rows(x).Item("FormaPago") = "QUINCENAL" And DsPlanilla1.Empleado.Rows(J).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                    'TablaPlanilla.Rows(x).Item("SalarioBruto") = (Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles))
                    'TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = DsPlanilla1.Empleado.Rows(J).Item("Salario") + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles))
                    'TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                End If
                If TablaPlanilla.Rows(x).Item("FormaPago") = "MENSUAL" And DsPlanilla1.Empleado.Rows(J).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = DsPlanilla1.Empleado.Rows(J).Item("Salario")
                    TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                End If
                If TablaPlanilla.Rows(x).Item("FormaPago") = "SEMANAL" And DsPlanilla1.Empleado.Rows(J).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                    TablaPlanilla.Rows(x).Item("SalarioBruto") = DsPlanilla1.Empleado.Rows(J).Item("Salario")
                    TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                End If
            Next

            'zoe carmela
            TablaPlanilla.Rows(x).Item("SalarioBruto") = TablaPlanilla.Rows(x).Item("SalarioBruto") + TablaPlanilla.Rows(x).Item("Otros_ingresos") - Math.Round(DiasDescontados2, 2)
            SalarioBruto = TablaPlanilla.Rows(x).Item("SalarioBruto")

            'quita las deducciones de porcentajes para volver a calcularlas despues
            For rows As Integer = 0 To Me.DsPlanilla1.Deducciones.Count - 1
                If Me.DsPlanilla1.Deducciones(rows).Tipo = "%" Then
                    TablaPlanilla.Rows(x).Item(DsPlanilla1.Deducciones.Rows(rows).Item("Descripcion").ToString) = "0"
                End If
            Next

            For J = 0 To DsPlanilla1.Empleado_Deducciones.Rows.Count - 1
                If TablaPlanilla.Rows(x).Item("Cedula") = DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Identificacion") Then
                    Tipo = DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Tipo")
                    Select Case Tipo
                        Case "V"
                            Total = DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Monto") 'original
                            Dim ee As Integer = DsPlanilla1.Empleado_Deducciones.Rows.Count
                            Dim ii As Integer = TablaPlanilla.Rows.Count
                            If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                If DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Cod_Moneda") = 1 Then
                                    Total = Total / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                End If
                            Else
                                If DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Cod_Moneda") = 2 Then
                                    Total = Total * DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                End If
                            End If

                            TablaPlanilla.Rows(x).Item(DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion").ToString) = Total
                            DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Monto") = Total  'psv
                            TotalDeducciones = TotalDeducciones + Total
                        Case "%"
                            Monto = DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Monto") 'original
                            'Monto = TablaPlanilla.Rows(x).Item("Monto")'psv
                            Deduccion = ((Monto / 100) * TablaPlanilla.Rows(x).Item("SalarioBruto"))
                            TablaPlanilla.Rows(x).Item(DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion").ToString) = Deduccion
                            TotalDeducciones = TotalDeducciones + Deduccion
                    End Select
                    Descripcion = DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion")
                End If
            Next
            saldo = 0

            For J = 0 To DsPlanilla1.Adelantos.Rows.Count - 1
                Dim s1 As String = TablaPlanilla.Rows(x).Item("Cedula")
                Dim s As String = DsPlanilla1.Adelantos.Rows(J).Item("Identificacion")
                If TablaPlanilla.Rows(x).Item("Cedula") = DsPlanilla1.Adelantos.Rows(J).Item("Identificacion") Then
                    If DsPlanilla1.Adelantos.Rows(J).Item("Anulado") = False Then
                        '--------------------------------------------------------------------------
                        'ADELANTOS
                        If DsPlanilla1.Adelantos.Rows(J).Item("Adelanto") Then  'cambio =true
                            Dim fecha As Date
                            fecha = DsPlanilla1.Adelantos.Rows(J).Item("FechaCobro")
                            If dtFechaInicio.Text <= fecha.Date And dtFechaFinal.Text >= fecha.Date Then

                                Adelanto = DsPlanilla1.Adelantos.Rows(J).Item("Monto") 'DsPlanilla1.Adelantos.Rows(J).Item("Monto") Cambios

                                If Adelanto > DsPlanilla1.Adelantos.Rows(J).Item("Saldo") Then
                                    Adelanto = DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                End If

                                If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                    If DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 1 Then
                                        Adelanto = Adelanto / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")  'cambio 
                                    End If
                                Else
                                    If DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 2 Then
                                        Adelanto = Adelanto * DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                    End If
                                End If
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").AddNew()
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Id_Empleado") = TablaPlanilla.Rows(x).Item("Cedula")
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Numero") = DsPlanilla1.Adelantos.Rows(J).Item("Numero")
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Tipo_Pago") = False
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Monto") = Adelanto
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Interes_Prestamo") = 0
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Saldo") = Adelanto
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Id_Planilla") = txtNumero.Text
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").EndCurrentEdit()
                                Adelantos = Adelanto + Adelantos
                            End If
                        End If
                        '--------------------------------------------------------------------------
                        'PRESTAMOS
                        If DsPlanilla1.Adelantos.Rows(J).Item("Prestamo") = True Then
                            Dim fecha As Date
                            fecha = DsPlanilla1.Adelantos.Rows(J).Item("FechaCobro")
                            If dtFechaFinal.Text >= fecha.Date Then
                                Prestamo = DsPlanilla1.Adelantos.Rows(J).Item("DeducirxPago")     'DsPlanilla1.Adelantos.Rows(J).Item("Monto")
                                saldos = DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                '--------------------------------------------------------------------------
                                'INTERESES SOBRE PRESTAMOS - ORA
                                Porcentaje_IntPre = DsPlanilla1.Adelantos.Rows(J).Item("InteresPrestamo")
                                If CDate(dtFechaInicio.Value) < DsPlanilla1.Adelantos.Rows(J).Item("FechaComprobante") Then
                                    Dias_IntPre = (DateDiff(DateInterval.Day, DsPlanilla1.Adelantos.Rows(J).Item("FechaComprobante"), CDate(dtFechaFinal.Value))) + 1
                                Else
                                    Dias_IntPre = (DateDiff(DateInterval.Day, CDate(dtFechaInicio.Value), CDate(dtFechaFinal.Value))) + 1
                                End If

                                Porcentaje_IntPre = (Porcentaje_IntPre / 30)    'CALCULO DE PORCENTAJE POR DIA
                                Monto_IntPre = (saldos * ((Porcentaje_IntPre * Dias_IntPre) / 100))
                                '--------------------------------------------------------------------------

                                If Prestamo > saldos Then
                                    Prestamo = saldos
                                End If

                                If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                    If DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 1 Then
                                        Prestamo = Prestamo / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'Cambio 
                                        saldos = DsPlanilla1.Adelantos.Rows(J).Item("Saldo") / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                        Monto_IntPre = Monto_IntPre / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'CAMBIO INTERES PRESTAMO - ORA
                                    End If
                                Else
                                    If DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 2 Then
                                        Prestamo = Prestamo * DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                        saldos = DsPlanilla1.Adelantos.Rows(J).Item("Saldo") * DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                        Monto_IntPre = Monto_IntPre * DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'CAMBIO INTERES PRESTAMO - ORA
                                    End If
                                    saldos = DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                End If

                                BindingContext(DsPlanilla1, "Adelantos_Detalle").AddNew()
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Id_Empleado") = TablaPlanilla.Rows(x).Item("Cedula")
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Numero") = DsPlanilla1.Adelantos.Rows(J).Item("Numero")
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Tipo_Pago") = True
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Monto") = Prestamo
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Interes_Prestamo") = Monto_IntPre
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Saldo") = saldos
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").Current("Id_Planilla") = txtNumero.Text
                                BindingContext(DsPlanilla1, "Adelantos_Detalle").EndCurrentEdit()

                                saldo = saldo + saldos
                                Prestamos = Prestamos + Prestamo
                                Monto_IntPreTotal = Monto_IntPreTotal + Monto_IntPre
                            End If
                        End If
                        '--------------------------------------------------------------------------
                    End If
                End If

            Next

            TablaPlanilla.Rows(x).Item("Adelantos") = Adelantos
            TablaPlanilla.Rows(x).Item("Prestamos") = Prestamos
            TablaPlanilla.Rows(x).Item("Prestamos_Int") = Monto_IntPreTotal
            TablaPlanilla.Rows(x).Item("Saldo") = saldo
            TablaPlanilla.Rows(x).Item("Saldo") = TablaPlanilla.Rows(x).Item("Saldo") - Prestamos

            Fijo = (MontoHasta - MontoDe) * (Porcentaje1 / 100)
            MontoDe = DsPlanilla1.ParametroRenta.Rows(0).Item("MontoDe")
            MontoHasta = DsPlanilla1.ParametroRenta.Rows(0).Item("MontoHasta")
            MontoExento = DsPlanilla1.ParametroRenta.Rows(0).Item("MontoExento")
            MontoAdelante = DsPlanilla1.ParametroRenta.Rows(0).Item("MontoEnAdelante")
            Porcentaje1 = DsPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje1")
            Porcentaje2 = DsPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje2")
            PHijo = DsPlanilla1.ParametroRenta.Rows(0).Item("Hijo")
            PEsposa = DsPlanilla1.ParametroRenta.Rows(0).Item("Esposa")
            For k = 0 To DsPlanilla1.Empleado.Rows.Count - 1
                If DsPlanilla1.Empleado.Rows(k).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                    Estado_Civil = DsPlanilla1.Empleado.Rows(k).Item("Estado_Civil")
                    Hijos = DsPlanilla1.Empleado.Rows(k).Item("Hijos")
                    Exit For
                End If

            Next

            If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                MontoDe = MontoDe / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                MontoHasta = MontoHasta / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                MontoExento = MontoExento / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                Fijo = Fijo / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                MontoAdelante = MontoAdelante / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                PHijo = PHijo / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                PEsposa = PEsposa / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
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
                        ' Renta = Fijo
                        Renta = (MontoAdelante - MontoDe) * Porcentaje1 / 100
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
                    TablaPlanilla.Rows(x).Item("Renta") = Math.Round(RentaTotal, 2)
                End If
            Else
                TablaPlanilla.Rows(x).Item("Renta") = 0
            End If

            Dim TotalCxC As Double
            If CuentasxC Then
                'TotalCxC = Me.devolverCxC(TablaPlanilla.Rows(x).Item("Cedula"), TablaPlanilla.Rows(x).Item("Moneda"))
                TotalCxC = Me.devolverCxC_SoloActivas(TablaPlanilla.Rows(x).Item("Cedula"), TablaPlanilla.Rows(x).Item("Moneda"))
                TablaPlanilla.Rows(x).Item("CxC") = TotalCxC
            Else
                TotalCxC = 0
            End If

            TotalDeducciones = TotalDeducciones + Math.Round(RentaTotal, 2) + Math.Round(Adelantos, 2) + Math.Round(Prestamos, 2) + Math.Round(Monto_IntPreTotal, 2) + Math.Round(TotalCxC, 2)
            TablaPlanilla.Rows(x).Item("TotalDeducciones") = Math.Round(TotalDeducciones, 2)
            TablaPlanilla.Rows(x).Item("SalarioNeto") = Math.Round(SalarioBruto, 2) - Math.Round(TotalDeducciones, 2)
            Descripcion = ""
            TotalDeducciones = 0 : Deduccion = 0
            Pagomes = 0 : DiasDescontados = 0
            DiasDescontados1 = 0 : DiasDescontados2 = 0
            Aumento = 0
        End If
    End Sub

    Function devolverCxC_SoloActivas(ByVal Id_Empleado As String, ByVal Moneda As String) As Double
        'zoe
        Dim saldoActual As Double = 0
        Dim i As Integer = 0
        Dim dt As New DataTable
        Dim cf As New cFunciones
        cFunciones.Llenar_Tabla_Generico("Select IdCliente From Empleado Where Identificacion = '" & Id_Empleado & "'", dt, GetSetting("Planilla", "Planilla", "Conexion"))
        Dim cliente As Integer = 0
        If dt.Rows.Count > 0 Then
            cliente = dt.Rows(0).Item(0)
        Else
            Return 0
        End If
        For i = 0 To Me.DsPlanilla1.ConsultaSaldos.Count - 1
            If Me.DsPlanilla1.ConsultaSaldos(i).Cod_Cliente = cliente And Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual > 0 Then
                If Me.DsPlanilla1.ConsultaSaldos(i).Cobrar = True Then
                    If Moneda = "COLON" Then
                        If Me.DsPlanilla1.ConsultaSaldos(i).Cod_Moneda = 1 Then
                            saldoActual += Me.DsPlanilla1.ConsultaSaldos(i).Abono
                        Else
                            saldoActual += DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") * Me.DsPlanilla1.ConsultaSaldos(i).Abono
                        End If
                    Else
                        If Me.DsPlanilla1.ConsultaSaldos(i).Cod_Moneda = 2 Then
                            saldoActual += Me.DsPlanilla1.ConsultaSaldos(i).Abono
                        Else
                            saldoActual += Me.DsPlanilla1.ConsultaSaldos(i).Abono / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                        End If
                    End If
                End If
            End If
        Next
        Return saldoActual
    End Function
    Function devolverCxC(ByVal Id_Empleado As String, ByVal Moneda As String) As Double
        'zoe
        Dim saldoActual As Double = 0
        Dim i As Integer = 0
        Dim dt As New DataTable
        Dim cf As New cFunciones
        cFunciones.Llenar_Tabla_Generico("Select IdCliente From Empleado Where Identificacion = '" & Id_Empleado & "'", dt, GetSetting("Planilla", "Planilla", "Conexion"))
        Dim cliente As Integer = 0
        If dt.Rows.Count > 0 Then
            cliente = dt.Rows(0).Item(0)
        Else
            Return 0
        End If
        For i = 0 To Me.DsPlanilla1.ConsultaSaldos.Count - 1
            If Me.DsPlanilla1.ConsultaSaldos(i).Cod_Cliente = cliente And Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual > 0 Then
                If Moneda = "COLON" Then
                    If Me.DsPlanilla1.ConsultaSaldos(i).Cod_Moneda = 1 Then
                        saldoActual += Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual
                    Else
                        saldoActual += DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") * Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual
                    End If


                Else
                    If Me.DsPlanilla1.ConsultaSaldos(i).Cod_Moneda = 2 Then
                        saldoActual += Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual
                    Else
                        saldoActual += Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                    End If

                End If

            End If
        Next
        Return saldoActual
    End Function

    Function ParametroRenta()
        Dim funcion As New cFunciones
        Dim Id, n, Mes1, Mes2 As Integer
        Dim Cuenta As String
        Dim FechaSalida, FechaEntrada As DateTime
        funcion.Llenar_Tabla_Generico("Select * from Planilla", TablaRenta, SqlConnection1.ConnectionString)
        For n = 0 To TablaRenta.Rows.Count - 1
            FechaSalida = dtFechaInicio.Text
            FechaEntrada = TablaRenta.Rows(n).Item("FechaInicial")
            Mes1 = FechaSalida.Month
            Mes2 = FechaEntrada.Month
            If Mes1 = Mes2 Then
                Id = TablaRenta.Rows(n).Item("Id_Planilla")
                ParametroRent(Id)
            End If
        Next
        Return True
    End Function

    Function ParametroRent(ByVal Id As Integer)
        Dim funcion As New cFunciones
        Dim n, Mes1, Mes2 As Integer
        Dim Cuenta As String
        Pagomes = 0
        funcion.Llenar_Tabla_Generico("Select * from Planilla_Detalle", TablaRenta1, SqlConnection1.ConnectionString)
        For n = 0 To TablaRenta1.Rows.Count - 1
            If Id = TablaRenta1.Rows(n).Item("Id_Planilla") And TablaRenta1.Rows(n).Item("Cedula") = Cedula Then
                Pagomes = Pagomes + TablaRenta1.Rows(n).Item("SalarioBruto") 'original
                Exit Function 'original
            End If
        Next
        Return True
    End Function

    Private Sub Recalcular_Fila_Saldo(ByVal x As Integer)

        Dim Ordinarias, Extras, Feriadas, Dobles, Ord_Noct, Ext_Noct, Salario, Salarios, Monto, Deduccion, SalarioBruto, SalarioBruto2, Total, TotalDeducciones, Porcentaje1, Porcentaje2, Hijos As Double
        Dim MontoExento, MontoDe, MontoHasta, MontoAdelante, PEsposa, PHijo, Renta, Renta1, Renta2, Renta3, RentaTotal As Double
        Dim J, k, h, Dias_IntPre As Integer
        Dim Pagar As Double
        Dim Tipo As Char
        Dim Estado_Civil As String
        Dim Descripcion, Descripcion1 As String
        Dim Adelanto, Prestamo, Adelantos, Prestamos, DiasDescontados1, DiasDescontados2, Aumento, DeduccionHO As Double
        Dim saldos, saldo, fijo, Porcentaje_IntPre, Monto_IntPre, Monto_IntPreTotal As Double
        Dim dr As DataRow
        Dim sqlconexion1 As New SqlClient.SqlConnection
        Dim cconexion1 As New Conexion
        Dim CedulaJuridica As String
        Dim Dias As Double = 0
        Dim libre, DiasDescontados, Vaca, INS, CCSS, Embarazo, DiasTemporal As Double
        Dim libre1 As Double = 0
        DiasTemporal = 0
        libre = 0
        DiasDescontados = 0
        Vaca = 0
        INS = 0
        CCSS = 0
        Embarazo = 0
        If x >= 0 Then
            Try
                dr = TablaPlanilla.NewRow
                BindingContext(TablaPlanilla).EndCurrentEdit()
                Ordinarias = TablaPlanilla.Rows(x).Item("Ordinarias")
                Ord_Noct = TablaPlanilla.Rows(x).Item("Ord_Nocturna")
                Extras = TablaPlanilla.Rows(x).Item("Extras")
                Ext_Noct = TablaPlanilla.Rows(x).Item("Ext_Nocturna")
                Feriadas = TablaPlanilla.Rows(x).Item("Feriadas")
                Dobles = TablaPlanilla.Rows(x).Item("Dobles")
                Salario = TablaPlanilla.Rows(x).Item("Salario")


                libre = 0
                DiasDescontados = 0
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '-----------------------------------------------------------------------
                ' ACCIONES DE PERSONAL
                For J = 0 To DsPlanilla1.AccionPersonal.Rows.Count - 1
                   
                    If DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Empleado") = TablaPlanilla.Rows(x).Item("Cedula") Then

                        Select Case DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion").ToString
                            Case Me.GetAccionDiaLibre

                                '    If dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                '        If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                '            libre1 = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Value))) + 1
                                '            libre += libre1
                                '        Else
                                '            libre1 = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                '            libre += libre1
                                '        End If
                                '    ElseIf dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                '        Dim dia As Double = 0
                                '        libre1 = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaInicio.Value)))
                                '        dia = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                '        libre1 = dia - libre1
                                '        libre += libre1
                                '    End If

                                If dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                    If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                        libre1 = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Value))) + 1
                                        libre += libre1
                                    Else
                                        libre1 = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                        libre += libre1
                                    End If
                                ElseIf dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    Dim dia As Double = 0
                                    libre1 = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaInicio.Value)))
                                    dia = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                    libre1 = (dia - libre1)
                                    libre += libre1
                                End If
                            Case Me.GetAccionVacaccion
                                '*****************************************************************************************************************************************
                                'Calculo de dias de vacacciones
                                '*****************************************************************************************************************************************
                                If dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                    If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                        DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Value))) + 1
                                        Vaca += DiasTemporal
                                    Else
                                        DiasTemporal = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                        Vaca += DiasTemporal
                                    End If
                                ElseIf dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    Dim dia As Double = 0
                                    DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaInicio.Value)))
                                    dia = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                    DiasTemporal = (dia - DiasTemporal)
                                    Vaca += DiasTemporal
                                End If
                                '*****************************************************************************************************************************************
                            Case Me.GetAccionINS
                                '*****************************************************************************************************************************************
                                'Calculo de dias de Incapacidades de INS
                                '*****************************************************************************************************************************************
                                If dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                    If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                        DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Value))) + 1
                                        INS += DiasTemporal
                                    Else
                                        DiasTemporal = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                        INS += DiasTemporal
                                    End If
                                ElseIf dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    Dim dia As Double = 0
                                    DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaInicio.Value)))
                                    dia = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                    DiasTemporal = (dia - DiasTemporal)
                                    INS += DiasTemporal
                                End If
                                '*****************************************************************************************************************************************
                            Case Me.GetAccionCCSS
                                '*****************************************************************************************************************************************
                                'Calculo de dias de Incapacidades de CCSS
                                '*****************************************************************************************************************************************
                                If dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                    If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                        DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Value))) + 1
                                        CCSS += DiasTemporal
                                    Else
                                        DiasTemporal = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                        CCSS += DiasTemporal
                                    End If
                                ElseIf dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    Dim dia As Double = 0
                                    DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaInicio.Value)))
                                    dia = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                    DiasTemporal = (dia - DiasTemporal)
                                    CCSS += DiasTemporal
                                End If
                                '*****************************************************************************************************************************************
                            Case Me.GetAccionEmbarazo
                                '*****************************************************************************************************************************************
                                'Calculo de dias de Incapacidades de Embarazo
                                '*****************************************************************************************************************************************
                                If dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                    If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                        DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Value))) + 1
                                        Embarazo += DiasTemporal
                                    Else
                                        DiasTemporal = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                        Embarazo += DiasTemporal
                                    End If
                                ElseIf dtFechaInicio.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    Dim dia As Double = 0
                                    DiasTemporal = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaInicio.Value)))
                                    dia = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                    DiasTemporal = (dia - DiasTemporal)
                                    Embarazo += DiasTemporal
                                ElseIf dtFechaInicio.Value >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Value <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    DiasTemporal = (DateDiff(DateInterval.Day, CDate(dtFechaInicio.Value), CDate(dtFechaFinal.Value))) + 1
                                    Embarazo += DiasTemporal
                                End If
                                '*****************************************************************************************************************************************
                            Case Else

                                '    If dtFechaInicio.Text <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Text >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                '        If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                '            Dias = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Text))) + 1
                                '            Dias = Dias * PorcentajeAccion(DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion"))
                                '            DiasDescontados = DiasDescontados + Dias
                                '        Else
                                '            Dias = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                '            Dias = Dias * PorcentajeAccion(DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion"))
                                '            DiasDescontados = DiasDescontados + Dias
                                '        End If
                                '    ElseIf dtFechaInicio.Text <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Text >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                '        Dias = (DateDiff(DateInterval.Day, CDate(dtFechaInicio.Text), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                '        Dias = Dias * PorcentajeAccion(DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion"))
                                '        DiasDescontados = DiasDescontados + Dias
                                '    End If

                                If dtFechaInicio.Text <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Text >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                                    If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                        Dias = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Text))) + 1
                                        Dias = Dias * PorcentajeAccion(DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion"))
                                        DiasDescontados = DiasDescontados + Dias
                                    Else
                                        Dias = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                                        Dias = Dias * PorcentajeAccion(DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion"))
                                        DiasDescontados = DiasDescontados + Dias
                                    End If
                                ElseIf dtFechaInicio.Text <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Text >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                                    Dias = (DateDiff(DateInterval.Day, CDate(dtFechaInicio.Text), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                                    Dias = Dias * PorcentajeAccion(DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion"))
                                    DiasDescontados = DiasDescontados + Dias
                                End If
                        End Select
                    End If
                Next

                TablaPlanilla.Rows(x).Item("DíasLibre") = libre
                TablaPlanilla.Rows(x).Item("DíasDescontar") = DiasDescontados
                TablaPlanilla.Rows(x).Item("Vacacciones") = Vaca
                TablaPlanilla.Rows(x).Item("IncapacidadINS") = INS
                TablaPlanilla.Rows(x).Item("IncapacidadCCSS") = CCSS
                TablaPlanilla.Rows(x).Item("IncapacidadEmbarazo") = Embarazo

                If CCSS > 0 Then
                    Dim dif As Integer = CCSS - 3
                    If dif > 0 Then
                        DiasDescontados1 = DiasDescontados + INS + (Embarazo / 2) + dif
                    Else
                        DiasDescontados1 = DiasDescontados + INS + (Embarazo / 2)
                    End If
                Else
                    DiasDescontados1 = DiasDescontados + INS + (Embarazo / 2)
                End If

                '-----------------------------------------------------------------------
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Select Case TablaPlanilla.Rows(x).Item("FormaPago")
                    Case "HORA" : TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salario) + ((Extras * 1.5) * Salario) + ((Ord_Noct * 1.33) * Salario) + (((Ext_Noct * 1.33) * 1.5) * Salario) + (Salario * (1 * Feriadas)) + (Salario * (2 * Dobles)))
                        DiasDescontados2 = DiasDescontados1 * (Salario * 8)
                        DeduccionHO = (Ordinarias * Salario)
                    Case "DIARIO"
                        Salarios = (Salario / 8)
                        DiasDescontados2 = DiasDescontados1 * Salario
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles)))
                    Case "SEMANAL"
                        Salarios = (Salario / 56)
                        DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles)))
                    Case "QUINCENAL"
                        Salarios = (Salario / 120)
                        DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salario * (1 * Feriadas)) + (Salario * (2 * Dobles)))
                    Case "MENSUAL"
                        Salarios = (Salario / 240)
                        DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salario * (1 * Feriadas)) + (Salario * (2 * Dobles)))
                End Select
                For J = 0 To DsPlanilla1.Empleado.Rows.Count - 1

                    If TablaPlanilla.Rows(x).Item("FormaPago") = "QUINCENAL" And DsPlanilla1.Empleado.Rows(J).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                        ' TablaPlanilla.Rows(x).Item("SalarioBruto") = (Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles))
                        'TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = DsPlanilla1.Empleado.Rows(J).Item("Salario") + ((Extras * 1.5) * Salarios) + (Salarios * (1 * Feriadas)) + (Salarios * (2 * Dobles))
                        'TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                    End If
                    If TablaPlanilla.Rows(x).Item("FormaPago") = "MENSUAL" And DsPlanilla1.Empleado.Rows(J).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = DsPlanilla1.Empleado.Rows(J).Item("Salario")
                        TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                    End If
                    If TablaPlanilla.Rows(x).Item("FormaPago") = "SEMANAL" And DsPlanilla1.Empleado.Rows(J).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                        TablaPlanilla.Rows(x).Item("SalarioBruto") = DsPlanilla1.Empleado.Rows(J).Item("Salario")
                        TablaPlanilla.Rows(x).Item("Ordinarias") = 0
                    End If
                Next
                TablaPlanilla.Rows(x).Item("SalarioBruto") = TablaPlanilla.Rows(x).Item("SalarioBruto") + TablaPlanilla.Rows(x).Item("Otros_ingresos") - Math.Round(DiasDescontados2, 2)
                SalarioBruto = TablaPlanilla.Rows(x).Item("SalarioBruto")
                '-----------------------------------------------------------------------
                ' DEDUCCIONES
                For J = 0 To DsPlanilla1.Empleado_Deducciones.Rows.Count - 1
                    If TablaPlanilla.Rows(x).Item("Cedula") = DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Identificacion") Then
                        Tipo = DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Tipo")
                        Select Case Tipo
                            Case "V"
                                Dim ii As Double = TablaPlanilla.Rows(x).Item(DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion"))
                                Total = TablaPlanilla.Rows(x).Item(DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion")) 'psv
                                If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                    If DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Cod_Moneda") = 1 Then
                                        Total = Total / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                    End If
                                Else
                                    If DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Cod_Moneda") = 2 Then
                                        Total = Total * DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                    End If
                                End If

                                TablaPlanilla.Rows(x).Item(DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion").ToString) = Total
                                TotalDeducciones = TotalDeducciones + Total
                            Case "%"
                                sqlconexion1 = cconexion1.Conectar("Planilla")
                                CedulaJuridica = CStr(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT Cedula FROM Configuraciones"))
                                cconexion1.DesConectar(sqlconexion1)
                                If CedulaJuridica = "3-101-124567" Then
                                    Dim ii As Double = TablaPlanilla.Rows(x).Item(DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion"))
                                    Total = TablaPlanilla.Rows(x).Item(DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion")) 'psv
                                    If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                        If DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Cod_Moneda") = 1 Then
                                            Total = Total / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                        End If
                                    Else
                                        If DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Cod_Moneda") = 2 Then
                                            Total = Total * DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                        End If
                                    End If

                                    TablaPlanilla.Rows(x).Item(DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion").ToString) = Total
                                    TotalDeducciones = TotalDeducciones + Total
                                Else
                                    Monto = DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Monto")
                                    Deduccion = ((Monto / 100) * TablaPlanilla.Rows(x).Item("SalarioBruto"))
                                    TablaPlanilla.Rows(x).Item(DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion").ToString) = Deduccion
                                    TotalDeducciones = TotalDeducciones + Deduccion
                                End If
                        End Select
                        Descripcion = DsPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion")
                    End If
                Next
                '-----------------------------------------------------------------------

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                For J = 0 To DsPlanilla1.Adelantos.Rows.Count - 1
                    If TablaPlanilla.Rows(x).Item("Cedula") = DsPlanilla1.Adelantos.Rows(J).Item("Identificacion") Then
                        If DsPlanilla1.Adelantos.Rows(J).Item("Anulado") = False Then
                            '-----------------------------------------------------------------------
                            'ADELANTOS
                            If DsPlanilla1.Adelantos.Rows(J).Item("Adelanto") Then  'cambio =true
                                Dim fecha As Date
                                fecha = DsPlanilla1.Adelantos.Rows(J).Item("FechaCobro")

                                If dtFechaInicio.Text <= fecha.Date And dtFechaFinal.Text >= fecha.Date Then
                                    Adelanto = DsPlanilla1.Adelantos.Rows(J).Item("Monto") 'TablaPlanilla.Rows(x).Item("Adelantos") Cambios
                                    If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                        If DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 1 Then
                                            'saldos = DsPlanilla1.Adelantos.Rows(J).Item("Saldo") / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                        End If
                                    Else
                                        If DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 2 Then
                                            'saldos = saldos * DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                        End If
                                        'saldos = DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                    End If
                                    Adelantos = Adelanto + Adelantos
                                End If
                            End If

                            '-----------------------------------------------------------------------------------------
                            'PRESTAMOS
                            If DsPlanilla1.Adelantos.Rows(J).Item("Prestamo") = True Then
                                For h = 0 To DsPlanilla1.Adelantos_Detalle.Rows.Count - 1
                                    If DsPlanilla1.Adelantos.Rows(J).Item("Identificacion") = DsPlanilla1.Adelantos_Detalle.Rows(h).Item("Id_Empleado") And DsPlanilla1.Adelantos.Rows(J).Item("Numero") = DsPlanilla1.Adelantos_Detalle.Rows(h).Item("Numero") Then
                                        Dim fecha As Date
                                        fecha = DsPlanilla1.Adelantos.Rows(J).Item("FechaCobro")
                                        If dtFechaFinal.Text >= fecha.Date Then
                                            saldos = DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                            Prestamo = DsPlanilla1.Adelantos_Detalle.Rows(h).Item("Monto")
                                            '--------------------------------------------------------------------------
                                            'INTERESES SOBRE PRESTAMOS - ORA
                                            Porcentaje_IntPre = DsPlanilla1.Adelantos.Rows(J).Item("InteresPrestamo")
                                            Porcentaje_IntPre = DsPlanilla1.Adelantos.Rows(J).Item("InteresPrestamo")
                                            If CDate(dtFechaInicio.Value) < DsPlanilla1.Adelantos.Rows(J).Item("FechaComprobante") Then
                                                Dias_IntPre = (DateDiff(DateInterval.Day, DsPlanilla1.Adelantos.Rows(J).Item("FechaComprobante"), CDate(dtFechaFinal.Value))) + 1
                                            Else
                                                Dias_IntPre = (DateDiff(DateInterval.Day, CDate(dtFechaInicio.Value), CDate(dtFechaFinal.Value))) + 1
                                            End If
                                            Porcentaje_IntPre = (Porcentaje_IntPre / 30)    'CALCULO DE PORCENTAJE POR DIA
                                            Monto_IntPre = (saldos * ((Porcentaje_IntPre * Dias_IntPre) / 100))
                                            '--------------------------------------------------------------------------
                                        End If
                                    End If
                                Next

                                If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                                    If DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 1 Then
                                        saldos = DsPlanilla1.Adelantos.Rows(J).Item("Saldo") / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                        Monto_IntPre = Monto_IntPre / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'CAMBIO INTERES PRESTAMO - ORA
                                    Else
                                        Prestamo = Prestamo
                                    End If
                                Else
                                    If DsPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 2 Then
                                        saldos = saldos * DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")  'cambio
                                        Monto_IntPre = Monto_IntPre * DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'CAMBIO INTERES PRESTAMO - ORA
                                    End If
                                    saldos = DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                End If
                                If Prestamo > saldos Then
                                    Prestamo = saldos
                                End If

                                saldo = saldo + saldos
                                Prestamos = Prestamos + Prestamo
                                Monto_IntPreTotal = Monto_IntPreTotal + Monto_IntPre

                                '------------------------Atencion, cambio hecho por jose elias----------------------------------------
                                '-----------porque no se actualizaba el saldo del adelanto--------
                                'DsPlanilla1.Adelantos(J).Saldo = saldo - Prestamos - Adelantos
                                '-----------------------FIN DEL CAMBIO----------------------------------------
                            End If
                            '-----------------------------------------------------------------------------------------
                        End If
                    End If

                Next

                TablaPlanilla.Rows(x).Item("Saldo") = 0
                'TablaPlanilla.Rows(x).Item("Adelantos") = Adelantos
                TablaPlanilla.Rows(x).Item("Prestamos") = Prestamos
                TablaPlanilla.Rows(x).Item("Prestamos_Int") = Monto_IntPreTotal
                TablaPlanilla.Rows(x).Item("Saldo") = saldo - Prestamos ' saj CORREGIDOS 

                SalarioBruto = TablaPlanilla.Rows(x).Item("SalarioBruto")

                MontoDe = DsPlanilla1.ParametroRenta.Rows(0).Item("MontoDe")
                MontoHasta = DsPlanilla1.ParametroRenta.Rows(0).Item("MontoHasta")
                MontoExento = DsPlanilla1.ParametroRenta.Rows(0).Item("MontoExento")
                MontoAdelante = DsPlanilla1.ParametroRenta.Rows(0).Item("MontoEnAdelante")
                Porcentaje1 = DsPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje1")
                Porcentaje2 = DsPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje2")
                PHijo = DsPlanilla1.ParametroRenta.Rows(0).Item("Hijo")
                PEsposa = DsPlanilla1.ParametroRenta.Rows(0).Item("Esposa")

                fijo = (MontoHasta - MontoDe) * (Porcentaje1 / 100)

                For k = 0 To DsPlanilla1.Empleado.Rows.Count - 1
                    If DsPlanilla1.Empleado.Rows(k).Item("Identificacion") = TablaPlanilla.Rows(x).Item("Cedula") Then
                        Estado_Civil = DsPlanilla1.Empleado.Rows(k).Item("Estado_Civil")
                        Hijos = DsPlanilla1.Empleado.Rows(k).Item("Hijos")
                        Exit For
                    End If

                Next

                If TablaPlanilla.Rows(x).Item("Moneda") = "DOLAR" Then
                    MontoDe = MontoDe / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") '514
                    MontoHasta = MontoHasta / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") ' 514
                    MontoExento = MontoExento / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") '/ 514
                    fijo = fijo / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") ' cambio
                    MontoAdelante = MontoAdelante / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") '514
                    PHijo = PHijo / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") '514
                    PEsposa = PEsposa / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") '514
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

                Dim TotalCxC As Double
                If CuentasxC Then
                    'ojo
                    TotalCxC = Me.devolverCxC_SoloActivas(TablaPlanilla.Rows(x).Item("Cedula"), TablaPlanilla.Rows(x).Item("Moneda"))
                    TablaPlanilla.Rows(x).Item("CxC") = TotalCxC
                Else
                    TotalCxC = 0
                End If

                TotalDeducciones = TotalDeducciones + Math.Round(RentaTotal, 2) + Math.Round(Adelantos, 2) + Math.Round(Prestamos, 2) + Math.Round(Monto_IntPreTotal, 2) + Math.Round(TotalCxC, 2)
                TablaPlanilla.Rows(x).Item("TotalDeducciones") = Math.Round(TotalDeducciones, 2)
                TablaPlanilla.Rows(x).Item("SalarioNeto") = SalarioBruto - TotalDeducciones
                Descripcion = ""
                TotalDeducciones = 0 : Deduccion = 0
                Pagomes = 0 : DiasDescontados = 0
                DiasDescontados1 = 0 : DiasDescontados2 = 0
                Aumento = 0
                Calcula_Total()
            Catch ex As Exception
                'MsgBox("La Persona Selecionada no Tiene Prestamos Pendientes") ''''''AQUI
                'MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Function PorcentajeAccion(ByVal IdAccion As Integer) As Double
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader

        Try
            If IdAccion >= 0 Then
                rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Incapacidad, PorIncapacidad, Embarazo, PorEmbarazo, INS, PorINS, Vacaciones FROM Accion WHERE Codigo = " & IdAccion)
                If rs.HasRows = False Then
                    Return 1
                End If
                While rs.Read
                    Try
                        If rs("Incapacidad") Then
                            Return (rs("PorIncapacidad") / 100)
                        ElseIf rs("Embarazo") Then
                            Return (rs("PorEmbarazo") / 100)
                        ElseIf rs("INS") Then
                            Return (rs("PorINS") / 100)
                        ElseIf rs("Vacaciones") Then
                            Return 0
                        Else
                            Return 1
                        End If

                    Catch ex As SystemException
                        MsgBox(ex.Message)
                        Return 1
                    End Try
                End While
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
            Return 1
        Finally
            If rs.IsClosed = False Then rs.Close()
            cConexion.DesConectar(cConexion.Conectar)
        End Try
    End Function
#End Region

#Region "Registrar"
    Private Sub Registrar()

        If Me.IsCerrado(dtFechaFinal.Value.ToShortDateString) = True Then
            MsgBox("Esta operación no se puede realizar!!!!" & vbCrLf _
                                    & "" & vbCrLf _
                                    & "Por motivo de que el periodo de trabajo contable se encuentra cerrado." & vbCrLf _
                                    & "Consulte con el departamento de contabilidad", MsgBoxStyle.Exclamation, Text)
            Exit Sub
        End If

        Dim Cx As New Conexion
        Try
            ToolBar1.Buttons(3).Enabled = False
            If MessageBox.Show("¿Desea Guardar los Cambios en la Planilla?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar el activo
                ToolBar1.Buttons(3).Enabled = True
                Exit Sub
            End If
            If Me.ToolBarRegistrar.Text = "Registrar" Then
                guardar()
            Else
                actualizar()
            End If
        Catch ex As System.Exception
            dlg.Visible = False
            ToolBar1.Buttons(3).Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")

        End Try
    End Sub
    Function Registrar_Planilla() As Boolean
        If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
        Dim TransPlanilla As SqlTransaction = SqlConnection1.BeginTransaction
        Try
            If var = False Then
                Dim n As Integer
                For n = 0 To DsPlanilla1.Adelantos_Detalle.Count - 1
                    With DsPlanilla1.Adelantos_Detalle(n)
                        AgregarDetalleAdelanto(DsPlanilla1.Adelantos_Detalle(n))
                    End With
                Next
            End If

            adPlanillaDetalle.InsertCommand.Transaction = TransPlanilla
            adPlanillaDetalle.UpdateCommand.Transaction = TransPlanilla
            adPlanillaDetalle.DeleteCommand.Transaction = TransPlanilla
            adPlanillaDetalle.SelectCommand.Transaction = TransPlanilla
            adPlanillaDetalle.Update(DsPlanilla1, "Planilla_Detalle")

            adPlanillaDeducciones.InsertCommand.Transaction = TransPlanilla
            adPlanillaDeducciones.UpdateCommand.Transaction = TransPlanilla
            adPlanillaDeducciones.DeleteCommand.Transaction = TransPlanilla
            adPlanillaDeducciones.SelectCommand.Transaction = TransPlanilla
            Me.adPlanillaDeducciones.Update(DsPlanilla1, "Planilla_Deducciones")

            If cedulajuridica = "3-101-104775" Or cedulajuridica = "3-101-227990" Then
                AdapterDed.InsertCommand.Transaction = TransPlanilla
                AdapterDed.UpdateCommand.Transaction = TransPlanilla
                AdapterDed.DeleteCommand.Transaction = TransPlanilla
                AdapterDed.SelectCommand.Transaction = TransPlanilla
                AdapterDed.Update(DsPlanilla1, "Deduccion_Empleado")
            End If

            If CuentasxC Then
                Me.generarAbonosAFacturas(Me.DsPlanilla1.Planilla(Me.DsPlanilla1.Planilla.Count - 1).Id_Planilla)
            End If
            'Ingreso una nueva planilla........
            'DsPlanilla1.AcceptChanges() '''aqui
            TransPlanilla.Commit()
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0

            DsPlanilla1.Clear()
            adEmpleados.Fill(DsPlanilla1.Empleado)
            adDeducciones.Fill(DsPlanilla1.Deducciones)
            adAdelantos.Fill(DsPlanilla1.Adelantos)
            adRenta.Fill(DsPlanilla1.ParametroRenta)
            adAccion.Fill(DsPlanilla1.AccionPersonal)
            adMoneda.Fill(DsPlanilla1.Moneda)
            adPlanilla.Fill(DsPlanilla1.Planilla)
            AdOrdinarias.Fill(DsPlanilla1.Horas_Ordinarias)
            adEmpleadoDeducciones.Fill(DsPlanilla1, "Empleado_Deducciones")
            dtFechaFinal.Value = Now
            dtFechaInicio.Value = Now

            Return True
        Catch ex As Exception
            TransPlanilla.Rollback()
            'MsgBox("No se puede eliminar o error de red " & ex.ToString, MsgBoxStyle.Critical)
            MsgBox(ex.Message)
            ToolBar1.Buttons(2).Enabled = True
            Me.btnBloquear.Enabled = True
            Return False
        End Try
    End Function
    Function CargarPlanilla()
        Dim i, J, n As Integer
        Dim Descripcion1 As String
        Dim Cx As New Conexion

        For i = 0 To TablaPlanilla.Rows.Count - 1
            BindingContext(DsPlanilla1.Planilla).EndCurrentEdit()
            adPlanilla.Update(DsPlanilla1.Planilla)
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").AddNew()

            If Me.ToolBarRegistrar.Text = "Actualizar" Then
                BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Id_Planilla") = Me.IdPlanilla1
            Else
                BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Id_Planilla") = BindingContext(DsPlanilla1.Planilla).Current("Id_Planilla")
            End If

            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Cedula") = TablaPlanilla.Rows(i).Item("Cedula")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Nombre") = TablaPlanilla.Rows(i).Item("Nombre")

            For n = 0 To DsPlanilla1.Empleado.Rows.Count - 1
                If TablaPlanilla.Rows(i).Item("Cedula") = DsPlanilla1.Empleado.Rows(n).Item("Identificacion") Then
                    BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Puesto") = DsPlanilla1.Empleado.Rows(n).Item("Puesto")
                End If
            Next

            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Id") = (i + 1) * -1
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Salario") = TablaPlanilla.Rows(i).Item("Salario")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("FormaPago") = TablaPlanilla.Rows(i).Item("FormaPago")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Ordinaria") = TablaPlanilla.Rows(i).Item("Ordinarias")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("DiasLibre") = TablaPlanilla.Rows(i).Item("DíasLibre")

            '****************************************************************************************************************************************************************
            'Bushting
            'guarda las incapacidades fy alas vacaciones del sistema
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("DiasDescontar") = TablaPlanilla.Rows(i).Item("DíasDescontar")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Vacaciones") = TablaPlanilla.Rows(i).Item("Vacacciones")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("INS") = TablaPlanilla.Rows(i).Item("IncapacidadINS")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("CCSS") = TablaPlanilla.Rows(i).Item("IncapacidadCCSS")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Embarazo") = TablaPlanilla.Rows(i).Item("IncapacidadEmbarazo")
            '*****************************************************************************************************************************************************************

            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Ord_Nocturna") = TablaPlanilla.Rows(i).Item("Ord_Nocturna")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Extra") = TablaPlanilla.Rows(i).Item("Extras")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Ext_Nocturna") = TablaPlanilla.Rows(i).Item("Ext_Nocturna")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Doble") = TablaPlanilla.Rows(i).Item("Dobles")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Feriada") = TablaPlanilla.Rows(i).Item("Feriadas")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Otros_Ingresos") = TablaPlanilla.Rows(i).Item("Otros_Ingresos")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("SalarioBruto") = TablaPlanilla.Rows(i).Item("SalarioBruto")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Adelantos") = TablaPlanilla.Rows(i).Item("Adelantos")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Prestamos") = TablaPlanilla.Rows(i).Item("Prestamos")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Prestamos_Int") = TablaPlanilla.Rows(i).Item("Prestamos_Int")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Renta") = TablaPlanilla.Rows(i).Item("Renta")
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("TotalDeducciones") = TablaPlanilla.Rows(i).Item("TotalDeducciones")

            If CuentasxC Then
                BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("CuentasxCobrar") = TablaPlanilla.Rows(i).Item("CxC")
            Else
                BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("CuentasxCobrar") = 0
            End If

            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("SalarioNeto") = Math.Round(TablaPlanilla.Rows(i).Item("SalarioNeto"), 2)
            If TablaPlanilla.Rows(i).Item("Moneda") = "COLON" Then
                BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Cod_Moneda") = 1 'DsPlanilla1.Empleado.Rows(i).Item("Cod_Moneda")
            Else
                BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").Current("Cod_Moneda") = 2
            End If
            BindingContext(DsPlanilla1, "Planilla.PlanillaPlanilla_Detalle").EndCurrentEdit()
        Next

        For i = 0 To TablaPlanilla.Rows.Count - 1
            For J = 0 To DsPlanilla1.Deducciones.Rows.Count - 1
                Descripcion1 = DsPlanilla1.Deducciones.Rows(J).Item("Descripcion")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").AddNew()

                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Id_PlanillaDetalle") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Id")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Cod_Deduccion") = DsPlanilla1.Deducciones.Rows(J).Item("Codigo")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Nombre") = DsPlanilla1.Deducciones.Rows(J).Item("Descripcion")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Monto") = IIf(TypeOf (TablaPlanilla.Rows(i).Item(Descripcion1)) Is System.DBNull, 0, TablaPlanilla.Rows(i).Item(Descripcion1))
                If TablaPlanilla.Rows(i).Item("Moneda") = "COLON" Then
                    BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Cod_Moneda") = 1 'DsPlanilla1.Empleado.Rows(i).Item("Cod_Moneda")
                Else
                    BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").Current("Cod_Moneda") = 2
                End If
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetallePlanilla_Deducciones").EndCurrentEdit()
            Next
        Next

        If cedulajuridica = "3-101-104775" Then
            For i = 0 To TablaPlanilla.Rows.Count - 1
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").AddNew()
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("Id_Detalle") = (i + 1) * -1 ' DsPlanilla1.Planilla_Detalle.Rows(i).Item("Id")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("CCSS") = IIf(TypeOf TablaPlanilla.Rows(i).Item("C.C.S.S.") Is System.DBNull, 0, TablaPlanilla.Rows(i).Item("C.C.S.S."))
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("ALIMENTACION") = IIf(TypeOf TablaPlanilla.Rows(i).Item("ALIMENTACION") Is System.DBNull, 0, TablaPlanilla.Rows(i).Item("ALIMENTACION"))
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("CAMISETAS") = IIf(TypeOf TablaPlanilla.Rows(i).Item("CAMISETAS") Is System.DBNull, 0, TablaPlanilla.Rows(i).Item("CAMISETAS"))
                Dim k As Integer : Dim MONTO As Double = 0
                For J = 0 To DsPlanilla1.Deducciones.Rows.Count - 1
                    Descripcion1 = DsPlanilla1.Deducciones.Rows(J).Item("Descripcion")
                    If Descripcion1 = "C.C.S.S." Or Descripcion1 = "CAMISETAS" Or Descripcion1 = "ALIMENTACION" Then
                    Else
                        MONTO += IIf(TypeOf TablaPlanilla.Rows(i).Item(Descripcion1) Is System.DBNull, 0, TablaPlanilla.Rows(i).Item(Descripcion1))
                    End If
                Next
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("PENSION") = MONTO
                If TablaPlanilla.Rows(i).Item("Moneda") = "COLON" Then
                    BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("CodMoneda") = 1 'DsPlanilla1.Empleado.Rows(i).Item("Cod_Moneda")
                Else
                    BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("CodMoneda") = 2
                End If
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").EndCurrentEdit()
            Next
        End If

        If cedulajuridica = "3-101-227990" Then
            For i = 0 To TablaPlanilla.Rows.Count - 1
                Dim f As String
                f = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Id")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").AddNew()
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("Id_Detalle") = (i + 1) * -1 'DsPlanilla1.Planilla_Detalle.Rows(i).Item("Id")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("CCSS") = TablaPlanilla.Rows(i).Item("RETENCION DE SEGURO/C.C.S.S.")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("Asociacion") = TablaPlanilla.Rows(i).Item("ASOCIACION")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("Alimentacion") = TablaPlanilla.Rows(i).Item("ALIMENTACION")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("Buseta") = TablaPlanilla.Rows(i).Item("BUSETA")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("Prest_Asoc") = TablaPlanilla.Rows(i).Item("PRESTAMO DE LA ASOCIACION")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("Otros_Asoc") = TablaPlanilla.Rows(i).Item("OTROS REBAJOS ASOCIACION")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("Soda_Asoc") = TablaPlanilla.Rows(i).Item("SODA-ASOCIACION")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("Pension") = TablaPlanilla.Rows(i).Item("RETENCION PENSION ALIMENTARIA")
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("Hospedaje") = TablaPlanilla.Rows(i).Item("HOSPEDAJE")
                Dim k As Integer
                Dim MONTO As Double = 0
                'For J = 0 To DsPlanilla1.Deducciones.Rows.Count - 1
                '    Descripcion1 = DsPlanilla1.Deducciones.Rows(J).Item("Descripcion")
                '    If Descripcion1 = "C.C.S.S." Or Descripcion1 = "CAMISETAS" Or Descripcion1 = "ALIMENTACION" Then
                '    Else
                '        MONTO += TablaPlanilla.Rows(i).Item(Descripcion1)
                '    End If

                'Next
                'BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("PENSION") = MONTO
                If TablaPlanilla.Rows(i).Item("Moneda") = "COLON" Then
                    BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("CodMoneda") = 1 'DsPlanilla1.Empleado.Rows(i).Item("Cod_Moneda")
                Else
                    BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").Current("CodMoneda") = 2
                End If
                BindingContext(DsPlanilla1, "Planilla_Detalle.Planilla_DetalleDeduccion_Empleado").EndCurrentEdit()
            Next
        End If

    End Function
    Private Sub AgregarDetalleAdelanto(ByVal pAdelantoDetalle As dsPlanilla.Adelantos_DetalleRow)
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim n As Integer = 0

        If pAdelantoDetalle.Tipo_Pago = True Then
            n = 1
        End If

        If pAdelantoDetalle.Monto <> 0 Then
            sql = "INSERT INTO Adelantos_Detalle (Id_Empleado, Numero, Tipo_Pago, Monto, Interes_Prestamo, Saldo, Id_Planilla) VALUES('" & pAdelantoDetalle.Id_Empleado & "'," & pAdelantoDetalle.Numero & "," & n & "," & pAdelantoDetalle.Monto & "," & pAdelantoDetalle.Interes_Prestamo & "," & pAdelantoDetalle.Saldo & "," & NumeroPlanilla1 & ")"
            cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnConexion.Open()
            clsConexion.SlqExecute(cnnConexion, sql)
        End If

        cnnConexion.Close()
    End Sub

#Region "Abonos"
    Sub generarAbonosAFacturas(ByVal Id_Planilla As Integer)
        Dim index As Integer = 0
        'Abonos a Facturas
        Dim TransAbono As SqlTransaction
        Try
            Me.DsPlanilla1.abonoccobrar.Id_ReciboColumn.AutoIncrement = True
            Me.DsPlanilla1.abonoccobrar.Id_ReciboColumn.AutoIncrementSeed = 1
            Me.DsPlanilla1.abonoccobrar.Id_ReciboColumn.AutoIncrementStep = 1
            Me.DsPlanilla1.abonoccobrar.Num_ReciboColumn.DefaultValue = 0
            Me.DsPlanilla1.abonoccobrar.AnulaColumn.DefaultValue = 0
            Me.DsPlanilla1.abonoccobrar.Cod_ClienteColumn.DefaultValue = 0
            Me.DsPlanilla1.abonoccobrar.Saldo_ActualColumn.DefaultValue = 0
            Me.DsPlanilla1.abonoccobrar.MontoColumn.DefaultValue = 0
            Me.DsPlanilla1.abonoccobrar.Saldo_CuentaColumn.DefaultValue = 0
            Me.DsPlanilla1.abonoccobrar.FechaColumn.DefaultValue = Now
            Me.DsPlanilla1.abonoccobrar.ContabilizadoColumn.DefaultValue = 0
            Me.DsPlanilla1.abonoccobrar.AsientoColumn.DefaultValue = 0
            Me.DsPlanilla1.abonoccobrar.Cod_MonedaColumn.DefaultValue = 1
            Me.DsPlanilla1.abonoccobrar.ObservacionesColumn.DefaultValue = ""
            Me.DsPlanilla1.abonoccobrar.Ced_UsuarioColumn.DefaultValue = Cedula_usuario

            'Establecer valores por defecto Detalla_Abonoccobrar
            Me.DsPlanilla1.detalle_abonoccobrar.FacturaColumn.DefaultValue = 0
            Me.DsPlanilla1.detalle_abonoccobrar.TipoColumn.DefaultValue = "CRE"
            Me.DsPlanilla1.detalle_abonoccobrar.MontoColumn.DefaultValue = 0
            Me.DsPlanilla1.detalle_abonoccobrar.Saldo_AntColumn.DefaultValue = 0
            Me.DsPlanilla1.detalle_abonoccobrar.InteresesColumn.DefaultValue = 0
            Me.DsPlanilla1.detalle_abonoccobrar.AbonoColumn.DefaultValue = 0
            Me.DsPlanilla1.detalle_abonoccobrar.Abono_SuMonedaColumn.DefaultValue = 0
            Me.DsPlanilla1.detalle_abonoccobrar.SaldoColumn.DefaultValue = 0
            Me.DsPlanilla1.detalle_abonoccobrar.ConsecutivoColumn.AutoIncrement = True
            Me.DsPlanilla1.detalle_abonoccobrar.ConsecutivoColumn.AutoIncrementSeed = 1
            Me.DsPlanilla1.detalle_abonoccobrar.ConsecutivoColumn.AutoIncrementStep = 1

            Dim iPlanilla As Integer = 0
            For iPlanilla = 0 To Me.DsPlanilla1.Planilla_Detalle.Count - 1
                Dim i As Integer = 0
                Dim con As Boolean = True
                Dim Saldo_Anterior As Double = 0
                Dim Monto As Double = 0
                Dim Saldo_Actual As Double = 0
                For i = 0 To Me.DsPlanilla1.ConsultaSaldos.Count - 1

                    If Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual > 0 And Me.DsPlanilla1.ConsultaSaldos(i).Id_Empleado = Me.DsPlanilla1.Planilla_Detalle(iPlanilla).Cedula Then

                        If Me.DsPlanilla1.Planilla_Detalle(iPlanilla).Cod_Moneda = 1 Then
                            If Me.DsPlanilla1.ConsultaSaldos(i).Cod_Moneda = 1 Then
                                Saldo_Anterior += Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual
                            Else
                                Saldo_Anterior += DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") * Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual
                            End If



                        Else
                            If Me.DsPlanilla1.ConsultaSaldos(i).Cod_Moneda = 2 Then
                                Saldo_Anterior += Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual

                            Else
                                Saldo_Anterior += Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")

                            End If

                        End If

                        If Me.DsPlanilla1.ConsultaSaldos(i).Cobrar Then
                            If con Then
                                con = False
                                index += 1
                                Me.BindingContext(Me.DsPlanilla1, "abonoccobrar").AddNew()
                                Me.BindingContext(Me.DsPlanilla1, "abonoccobrar").Current("Cod_Cliente") = Me.DsPlanilla1.ConsultaSaldos(i).Cod_Cliente
                                Me.BindingContext(Me.DsPlanilla1, "abonoccobrar").Current("Num_Recibo") = Me.Numero_de_Recibo(index)
                                Me.BindingContext(Me.DsPlanilla1, "abonoccobrar").Current("Cod_Moneda") = Me.DsPlanilla1.Planilla_Detalle(iPlanilla).Cod_Moneda
                                Me.BindingContext(Me.DsPlanilla1, "abonoccobrar").Current("Observaciones") = "Generado automaticamente Empleado: " & Me.DsPlanilla1.Planilla_Detalle(iPlanilla).Nombre
                                Me.BindingContext(Me.DsPlanilla1, "abonoccobrar").Current("Nombre_Cliente") = Me.DsPlanilla1.Planilla_Detalle(iPlanilla).Nombre
                                Me.BindingContext(Me.DsPlanilla1, "abonoccobrar").Current("Id_Planilla") = Id_Planilla
                                Me.BindingContext(DsPlanilla1, "abonoccobrar").EndCurrentEdit()
                            End If
                            'Montos Acumulados de Saldos de los Recibos

                            If Me.DsPlanilla1.ConsultaSaldos(i).Cobrar Then
                                Dim monto_factura As Double = 0
                                Dim abono_factura As Decimal = 0
                                If Me.DsPlanilla1.Planilla_Detalle(iPlanilla).Cod_Moneda = 1 Then
                                    If Me.DsPlanilla1.ConsultaSaldos(i).Cod_Moneda = 1 Then
                                        monto_factura = Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual
                                        abono_factura = Me.DsPlanilla1.ConsultaSaldos(i).Abono
                                    Else
                                        monto_factura = DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") * Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual
                                        abono_factura = DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") * Me.DsPlanilla1.ConsultaSaldos(i).Abono
                                    End If



                                Else
                                    If Me.DsPlanilla1.ConsultaSaldos(i).Cod_Moneda = 2 Then
                                        abono_factura = Me.DsPlanilla1.ConsultaSaldos(i).Abono
                                        monto_factura = Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual
                                    Else
                                        abono_factura = Me.DsPlanilla1.ConsultaSaldos(i).Abono / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                        monto_factura = Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                    End If

                                End If
                                Monto += abono_factura
                                'Guarda el detalle  del Recibo de Pago de Facturas pendientes
                                Me.BindingContext(DsPlanilla1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").AddNew()
                                Me.BindingContext(DsPlanilla1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Factura") = Me.DsPlanilla1.ConsultaSaldos(i).Num_Factura
                                '***************************************************************************************************************************************************************
                                'este no es el monto original de la factura
                                Me.BindingContext(DsPlanilla1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Monto") = monto_factura
                                '***************************************************************************************************************************************************************
                                Me.BindingContext(DsPlanilla1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Fecha") = Me.DsPlanilla1.ConsultaSaldos(i).Fecha
                                Me.BindingContext(DsPlanilla1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Saldo_Ant") = monto_factura
                                Me.BindingContext(DsPlanilla1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Saldo") = monto_factura - abono_factura
                                Me.BindingContext(DsPlanilla1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Abono") = abono_factura
                                Me.BindingContext(DsPlanilla1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Abono_SuMoneda") = Me.DsPlanilla1.ConsultaSaldos(i).Abono
                                Me.BindingContext(DsPlanilla1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").EndCurrentEdit()
                            End If
                        End If

                    End If
                Next
                If con = False Then
                    Saldo_Actual = Saldo_Anterior - Monto
                    Me.BindingContext(Me.DsPlanilla1, "abonoccobrar").Current("Saldo_Actual") = Saldo_Actual
                    Me.BindingContext(Me.DsPlanilla1, "abonoccobrar").Current("Saldo_Cuenta") = Saldo_Anterior
                    Me.BindingContext(Me.DsPlanilla1, "abonoccobrar").Current("Monto") = Monto
                    Me.BindingContext(Me.DsPlanilla1, "abonoccobrar").EndCurrentEdit()
                    con = True
                End If

            Next

            If Me.BindingContext(Me.DsPlanilla1, "abonoccobrar").Count > 0 Then
                If Me.SqlConnectionHotel.State <> ConnectionState.Open Then Me.SqlConnectionHotel.Open()
                TransAbono = Me.SqlConnectionHotel.BeginTransaction

                Me.SqlDataAdapterAbonocCobrar.UpdateCommand.Transaction = TransAbono
                Me.SqlDataAdapterAbonocCobrar.InsertCommand.Transaction = TransAbono
                Me.SqlDataAdapterAbonocCobrar.DeleteCommand.Transaction = TransAbono

                Me.SqlDataAdapterDetalleAbono_cCobrar.UpdateCommand.Transaction = TransAbono
                Me.SqlDataAdapterDetalleAbono_cCobrar.InsertCommand.Transaction = TransAbono
                Me.SqlDataAdapterDetalleAbono_cCobrar.DeleteCommand.Transaction = TransAbono

                Me.SqlDataAdapterAbonocCobrar.Update(Me.DsPlanilla1, "abonoccobrar")
                Me.SqlDataAdapterDetalleAbono_cCobrar.Update(Me.DsPlanilla1, "detalle_abonoccobrar")

                TransAbono.Commit()
                Me.ImprimiRecibos(Id_Planilla)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            TransAbono.Rollback()
        End Try
        If Me.SqlConnectionHotel.State <> ConnectionState.Closed Then Me.SqlConnectionHotel.Close()
    End Sub


    Private Function Numero_de_Recibo(ByVal i As Int16) As Double
        Dim cConexion As New Conexion
        Dim sqlCon As SqlConnection
        sqlCon = cConexion.Conectar("Hotel")
        Dim Num_Recibo As Double
        Num_Recibo = CDbl(cConexion.SlqExecuteScalar(sqlCon, "SELECT ISNULL(MAX(Num_Recibo), 0) AS Expr1 FROM abonoccobrar"))
        Numero_de_Recibo = Num_Recibo + i
        cConexion.DesConectar(sqlCon)

        Return Numero_de_Recibo
    End Function


    Sub ImprimiRecibos(ByVal Id_Planilla As Integer)
        If MsgBox("¿Desea imprimir los recibos de Dinero para los empleados?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim clr As New ReciboDinero
            Dim rtp As New frmVisorReportes
            clr.SetParameterValue(0, Id_Planilla)
            CrystalReportsConexion.LoadReportViewer(rtp.rptViewer, clr)
            rtp.rptViewer.Show()
            rtp.Show()
        End If
    End Sub
#End Region
#End Region
#Region "Buscar"
    Sub Buscar()
        Try
            Dim Fx As New cFunciones
            Dim Id As String
            Dim pos As Integer
            Dim vista As DataView
            DsPlanilla1.Planilla.Clear()
            Id = Fx.BuscarDatos("Select Id_Planilla, NumeroPlanilla AS Planilla, cast(dbo.DateOnly(FechaInicial) as varchar(11)) + '  -  ' + cast(dbo.DateOnly(FechaFinal) as varchar(11))  AS Periodo,(Case When Serv_Prof = 0 Then 'Planilla' Else 'Serv.Prof' End) AS Tipo from Planilla ", "FechaInicial", "Buscar Planilla...", SqlConnection1.ConnectionString, 3, " order by Id_Planilla DESC")
            If Id = "" Or Id = "0" Then
                TablaPlanilla.Clear()
                ToolBar1.Buttons(0).Enabled = True
                ToolBar1.Buttons(1).Enabled = True
                Me.btnBloquear.Enabled = False
                ToolBar1.Buttons(2).Enabled = False
                Me.btnBloquear.Enabled = False
                ToolBar1.Buttons(3).Enabled = False
                ToolBar1.Buttons(4).Enabled = False
                ToolBar1.Buttons(5).Enabled = False
                Exit Sub
            Else
                Dim numero As Integer
                Dim Cx As New Conexion

                IdPlanilla1 = Id
                LlenarPlanilla(Id)
                numero = Cx.SlqExecuteScalar(Cx.Conectar("Planilla"), "select numeroplanilla from planilla where id_planilla=" & Me.IdPlanilla1)

                Me.GridControl1.Enabled = False
                ToolBar1.Buttons(4).Enabled = True
                ToolBar1.Buttons(5).Enabled = True
                ToolBar1.Buttons(3).Enabled = False
                ToolBar1.Buttons(2).Enabled = True
                Me.btnBloquear.Enabled = True
                Me.txtPlanillaNumero.Text = numero
            End If
            Calcula_Total()
            btnFormaPago.Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Function LlenarPlanilla(ByVal Id As String)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim x As Integer
        Dim saldoA
        Dim cConexion As New Conexion
        'Dentro de un Try/Catch por si se produce un error
        TablaPlanilla.Clear()
        Try
            adPlanilla.Fill(DsPlanilla1.Planilla)

            For x = 0 To DsPlanilla1.Planilla.Rows.Count - 1
                If DsPlanilla1.Planilla.Rows(x).Item("Id_Planilla") = Id Then
                    txtNumero.Text = Id
                    txtPlanillaNumero.Text = DsPlanilla1.Planilla.Rows(x).Item("NumeroPlanilla")
                    dtFechaInicio.Text = DsPlanilla1.Planilla.Rows(x).Item("FechaInicial")
                    dtFechaFinal.Text = DsPlanilla1.Planilla.Rows(x).Item("FechaFinal")
                    CheckCierreMes.Checked = DsPlanilla1.Planilla.Rows(x).Item("CierreMes")
                    CheckAnulado.Checked = DsPlanilla1.Planilla.Rows(x).Item("Anulado")
                    Check_ServProf.Checked = DsPlanilla1.Planilla.Rows(x).Item("Serv_Prof")
                End If

            Next
            'BANDERA
            adPlanillaDetalle.Fill(DsPlanilla1, "Planilla_Detalle")
            adPlanillaDeducciones.Fill(DsPlanilla1, "Planilla_Deducciones")

            Dim i, J As Integer
            Dim dr As DataRow
            Dim Descripcion1, Descripcion As String
            dr = TablaPlanilla.NewRow

            For i = 0 To DsPlanilla1.Planilla_Detalle.Rows.Count - 1
                If Id = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Id_Planilla") Then
                    dr = TablaPlanilla.NewRow
                    dr("Cedula") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Cedula")
                    dr("Nombre") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Nombre")

                    If DsPlanilla1.Planilla_Detalle.Rows(i).Item("Cod_Moneda") = 1 Then
                        dr("Moneda") = "COLON"
                    End If
                    If DsPlanilla1.Planilla_Detalle.Rows(i).Item("Cod_Moneda") = 2 Then
                        dr("Moneda") = "DOLAR"
                    End If
                    If DsPlanilla1.Planilla_Detalle.Rows(i).Item("Cod_Moneda") = 3 Then
                        dr("Moneda") = "EUROS"
                    End If
                    dr("Salario") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Salario")
                    dr("FormaPago") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("FormaPago")
                    dr("Ordinarias") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Ordinaria")
                    dr("Ord_Nocturna") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Ord_Nocturna")
                    dr("Extras") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Extra")
                    dr("Ext_Nocturna") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Ext_Nocturna")
                    dr("Dobles") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Doble")
                    dr("Feriadas") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Feriada")
                    dr("Otros_Ingresos") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Otros_Ingresos")
                    dr("SalarioBruto") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("SalarioBruto")
                    dr("Adelantos") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Adelantos")
                    dr("Prestamos") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Prestamos")
                    dr("Prestamos_Int") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Prestamos_Int")
                    dr("Renta") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Renta")
                    dr("TotalDeducciones") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("TotalDeducciones")
                    dr("SalarioNeto") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("SalarioNeto")

                    dr("DíasLibre") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("DiasLibre")
                    dr("DíasDescontar") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("DiasDescontar")
                    dr("Vacacciones") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Vacaciones")
                    dr("IncapacidadINS") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("INS")
                    dr("IncapacidadCCSS") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("CCSS")
                    dr("IncapacidadEmbarazo") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("Embarazo")

                    If CuentasxC Then
                        dr("CXC") = DsPlanilla1.Planilla_Detalle.Rows(i).Item("CuentasxCobrar")
                    End If

                    For J = 0 To DsPlanilla1.Adelantos.Rows.Count - 1
                        If DsPlanilla1.Planilla_Detalle.Rows(i).Item("Cedula") = DsPlanilla1.Adelantos.Rows(J).Item("Identificacion") Then
                            saldoA = saldoA + DsPlanilla1.Adelantos.Rows(J).Item("Saldo")
                        End If
                    Next
                    If saldoA = Nothing Then
                        dr("Saldo") = 0
                    Else
                        dr("Saldo") = saldoA
                    End If
                    saldoA = 0
                    'dr("DíasDescontar") = 0
                    For J = 0 To DsPlanilla1.Planilla_Deducciones.Rows.Count - 1
                        If DsPlanilla1.Planilla_Detalle.Rows(i).Item("Id") = DsPlanilla1.Planilla_Deducciones.Rows(J).Item("Id_PlanillaDetalle") Then
                            Descripcion1 = DsPlanilla1.Planilla_Deducciones.Rows(J).Item("Nombre")
                            dr(Descripcion1) = DsPlanilla1.Planilla_Deducciones.Rows(J).Item("Monto")
                        End If
                    Next
                    TablaPlanilla.Rows.Add(dr)
                    'For J = 0 To DsPlanilla1.AccionPersonal.Rows.Count - 1
                    '    Dim Dias As Double = 0
                    '    If DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Empleado") = dr("Cedula") Then
                    '        If dtFechaInicio.Text <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") And dtFechaFinal.Text >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde") Then
                    '            If dtFechaFinal.Text < DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                    '                Dias = (DateDiff(DateInterval.Day, DsPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde"), CDate(dtFechaFinal.Text))) + 1
                    '                Dias = Dias * PorcentajeAccion(DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion"))
                    '            Else
                    '                Dias = DsPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                    '                Dias = Dias * PorcentajeAccion(DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion"))
                    '            End If
                    '        ElseIf dtFechaInicio.Text <= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") And dtFechaFinal.Text >= DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta") Then
                    '            Dias = (DateDiff(DateInterval.Day, CDate(dtFechaInicio.Text), DsPlanilla1.AccionPersonal.Rows(J).Item("RigeHasta"))) + 1
                    '            Dias = Dias * PorcentajeAccion(DsPlanilla1.AccionPersonal.Rows(J).Item("Id_Accion"))
                    '        End If
                    '        dr("DíasDescontar") = Dias
                    '    End If
                    'Next

                End If

            Next


        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function
#End Region
#Region "Anular"
    Function Registrar_Anulacion() As Boolean
        Dim i As Long
        Dim Funciones As New Conexion
        If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
        Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
        Try
            SqlUpdateCommand1.Transaction = Trans
            adPlanilla.Update(DsPlanilla1, "Planilla")
            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Sub Anular()
        Dim resp As Integer
        Dim i, j As Integer
        Dim Cconexion As New Utilidades.Conexion
        Dim Resultado As String

        Try 'se intenta hacer
            If CheckAnulado.CheckState = CheckState.Unchecked Then

                If BindingContext(DsPlanilla1, "Planilla").Count > 0 Then

                    resp = MessageBox.Show("¿Desea Realmente Anular esta planilla?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    var = True
                    If resp = 6 Then
                        'Edicion = False
                        DsPlanilla1.Adelantos_Detalle.Clear()
                        AdAdelanto_Detalle.Fill(DsPlanilla1.Adelantos_Detalle)
                        For i = 0 To DsPlanilla1.Adelantos_Detalle.Rows.Count - 1
                            If DsPlanilla1.Adelantos_Detalle.Rows(i).Item("Id_Planilla") = txtNumero.Text Then
                                Dim sql As String
                                Dim clsConexion As New Conexion
                                Dim cnnConexion As New System.Data.SqlClient.SqlConnection
                                sql = "UPDATE Adelantos SET Saldo = Saldo + " & DsPlanilla1.Adelantos_Detalle.Rows(i).Item("Monto") & " WHERE Numero =" & DsPlanilla1.Adelantos_Detalle.Rows(i).Item("Numero")
                                cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
                                cnnConexion.Open()
                                clsConexion.SlqExecute(cnnConexion, sql)
                                cnnConexion.Close()
                            End If
                        Next

                        For j = 0 To DsPlanilla1.Planilla.Rows.Count - 1
                            If DsPlanilla1.Planilla.Rows(j).Item("Id_Planilla") = txtNumero.Text Then
                                DsPlanilla1.Planilla.Rows(j).Item("Anulado") = True
                            End If
                        Next
                        CheckAnulado.Checked = True
                        BindingContext(DsPlanilla1, "Planilla").EndCurrentEdit()
                        If Registrar_Anulacion() Then
                            DsPlanilla1.Planilla.AcceptChanges()
                        End If

                        ToolBar1.Buttons(2).Enabled = False
                        Me.btnBloquear.Enabled = False
                        ToolBar1.Buttons(3).Enabled = False
                        ToolBar1.Buttons(4).Enabled = False
                        ToolBar1.Buttons(0).Enabled = True
                        MessageBox.Show("La planilla ha sido anulada", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TablaPlanilla.Clear()
                        Limpiar()
                        Bloquear()
                    Else
                        BindingContext(DsPlanilla1, "Planilla").CancelCurrentEdit()
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
#End Region
#Region "Loggin usuario"
    Function Loggin_Usuario() As Boolean
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader

        Try
            If TextBox2.Text <> "" Then
                rs = cConexion.GetRecorset(cConexion.Conectar2, "SELECT Id_Usuario, Nombre from Usuarios where Clave_Interna ='" & TextBox2.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    TextBox2.Focus()
                    TextBox2.Text = ""
                    Return False
                End If
                While rs.Read
                    Try
                        NombreUsuario = rs("Nombre")
                        Cedula_usuario = rs("Id_Usuario")
                        txtNombreUsuario.Text = rs("Nombre")
                        TextBox2.Enabled = False
                        ToolBar1.Buttons(0).Enabled = True
                        ToolBar1.Buttons(1).Enabled = True
                        dtFechaInicio.Focus()
                        DsPlanilla1.Planilla.Ced_UsuarioColumn.DefaultValue = rs("Id_Usuario")
                        DsPlanilla1.Planilla.Nombre_UsuarioColumn.DefaultValue = rs("Nombre")
                        DsPlanilla1.Planilla.FechaColumn.DefaultValue = Now.Date
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

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
#End Region
#Region "Imprimir"
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
            Form.Left = (Screen.PrimaryScreen.WorkingArea.Width - Form.Width) \ 2
            Form.Top = (Screen.PrimaryScreen.WorkingArea.Height - Form.Height) \ 2
            Form.Show()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Funciones Controles"
    Private Sub dtFechaInicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtFechaFinal.Focus()
        End If
    End Sub

    Private Function IsCerrado(ByVal _fecha As Date) As Boolean
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Cerrado from Periodo where Mes = " & _fecha.Month & " and Anno = " & _fecha.Year & "", dts, GetSetting("SeeSOFT", "Contabilidad", "Conexion"))
            If dts.Rows.Count > 0 Then
                If dts.Rows(0).Item(0) = 1 Or dts.Rows(0).Item(0) = True Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
            Return False
        End Try
    End Function

    Private Sub dtFechaFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFechaFinal.KeyDown
        If Me.IsCerrado(dtFechaFinal.Value.ToShortDateString) = True Then
            MsgBox("Esta operación no se puede realizar!!!!" & vbCrLf _
                                    & "" & vbCrLf _
                                    & "Por motivo de que el periodo de trabajo contable se encuentra cerrado." & vbCrLf _
                                    & "Consulte con el departamento de contabilidad", MsgBoxStyle.Exclamation, Text)
            Exit Sub
        End If

        Try
            If e.KeyCode = Keys.Enter Then
                dlg = New WaitDialogForm("Generando Planilla")
                DsPlanilla1.Adelantos_Detalle.Clear()

                If CuentasxC Then
                    cFunciones.Llenar_Tabla_Generico("SELECT Cod_Cliente, SaldoActual, Cod_Moneda, Intereses, Tipo_Cambio,  Num_Factura, 1 As Cobrar, Id, Id_Empleado,Fecha, SaldoActual as Abono FROM dbo.Estado_CxC_Actual_Empleado Where SaldoActual > 0", Me.DsPlanilla1.ConsultaSaldos, GetSetting("Planilla", "Planilla", "Conexion"))
                End If

                dtFechaFinal.Enabled = False
                CargarDatos()
                Calcula_Total()
                dtFechaFinal.Enabled = True
                dlg.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Loggin_Usuario() Then
            End If
        End If
    End Sub

    Private Sub GridControl1_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.TabIndexChanged
        If BindingContext(TablaPlanilla).Count <> 0 Then
            num = BindingContext(TablaPlanilla).Position()
            Label4.Text = TablaPlanilla.Rows(num).Item("Nombre")
        End If
    End Sub

    Private Sub GridControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.Click
        If BindingContext(TablaPlanilla).Count <> 0 Then
            num = BindingContext(TablaPlanilla).Position()
            Label4.Text = TablaPlanilla.Rows(num).Item("Nombre")
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If BindingContext(TablaPlanilla).Count <> 0 Then
            num = BindingContext(TablaPlanilla).Position()
            Label4.Text = TablaPlanilla.Rows(num).Item("Nombre")
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        procesarPrestamos()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.GroupBoxCxC.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim K, n As Integer
        Dim i, j As Integer
        Try
            GridControl2.EndUpdate()

            For i = 0 To DsPlanilla1.Adelantos_Detalle.Count - 1
                For j = 0 To DsPlanilla1.AdelantoPrueba.Count - 1
                    If DsPlanilla1.Adelantos_Detalle.Rows(i).Item("id_Empleado") = DsPlanilla1.AdelantoPrueba.Rows(j).Item("Identificacion") And DsPlanilla1.Adelantos_Detalle.Rows(i).Item("Numero") = DsPlanilla1.AdelantoPrueba.Rows(j).Item("Numero") Then
                        DsPlanilla1.Adelantos_Detalle.Rows(i).Item("Monto") = DsPlanilla1.AdelantoPrueba.Rows(j).Item("DeducirxPago")
                        BindingContext(DsPlanilla1, "Adelantos_Detalle").EndCurrentEdit()
                    End If
                Next
            Next

            Recalcular_Fila_Saldo(num)
            BindingContext(DsPlanilla1, "Adelantos_Detalle").EndCurrentEdit()
            BindingContext(DsPlanilla1, "Adelantos_Detalle").AddNew()
            BindingContext(DsPlanilla1, "Adelantos_Detalle").CancelCurrentEdit()

            GroupBox1.Visible = False

        Catch ex As Exception
            MsgBox("La Persona Selecionada no Tiene Prestamos Pendientes")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            GroupBox1.Visible = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Loggin_Usuario() Then
            End If
        End If
    End Sub

    Private Sub Current_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If BindingContext(TablaPlanilla).Count - 1 = 0 Then

        Else
            'Recalcular_Fila_Planilla(BindingContext(TablaPlanilla).Position) cambio
        End If
    End Sub

    Private Sub GridControl1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyUp
        If e.KeyCode = Keys.Enter Then Recalcular_Fila_Saldo(BindingContext(TablaPlanilla).Position())
        If e.KeyCode = Keys.F1 Then
            Dim Fx As New cFunciones
            Dim valor As String
            valor = Fx.BuscarDatos("Select Identificacion, Nombre from Empleado", "Nombre", "Buscar Empleado...")
        End If
    End Sub

    Private Sub Check_ServProf_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Check_ServProf.CheckedChanged
        CheckCierreMes.Enabled = Not Check_ServProf.Checked
        If Check_ServProf.Checked = True Then
            CheckCierreMes.Checked = False
        End If
    End Sub
#End Region
#Region "Prestamos"
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        procesarPrestamos()
    End Sub

    Sub procesarPrestamos()
        Dim i, j As Integer

        Try
            num = BindingContext(TablaPlanilla).Position()
            Id_Empleado = TablaPlanilla.Rows(num).Item("Cedula")

            DsPlanilla1.AdelantoPrueba.Clear()
            For i = 0 To DsPlanilla1.Adelantos.Count - 1
                If DsPlanilla1.Adelantos.Rows(i).Item("Identificacion") = Id_Empleado And DsPlanilla1.Adelantos.Rows(i).Item("Prestamo") = True And DsPlanilla1.Adelantos.Rows(i).Item("Saldo") <> 0 And DsPlanilla1.Adelantos.Rows(i).Item("Anulado") = False Then
                    BindingContext(DsPlanilla1.AdelantoPrueba).AddNew()
                    BindingContext(DsPlanilla1.AdelantoPrueba).Current("Numero") = DsPlanilla1.Adelantos.Rows(i).Item("Numero")
                    BindingContext(DsPlanilla1.AdelantoPrueba).Current("Identificacion") = DsPlanilla1.Adelantos.Rows(i).Item("Identificacion")
                    If DsPlanilla1.Adelantos.Rows(i).Item("Saldo") < DsPlanilla1.Adelantos.Rows(i).Item("DeducirxPago") Then
                        BindingContext(DsPlanilla1.AdelantoPrueba).Current("DeducirxPago") = DsPlanilla1.Adelantos.Rows(i).Item("Saldo")
                    Else
                        BindingContext(DsPlanilla1.AdelantoPrueba).Current("DeducirxPago") = DsPlanilla1.Adelantos.Rows(i).Item("DeducirxPago")
                    End If
                    BindingContext(DsPlanilla1.AdelantoPrueba).Current("Saldo") = DsPlanilla1.Adelantos.Rows(i).Item("Saldo") - BindingContext(DsPlanilla1.AdelantoPrueba).Current("DeducirxPago")
                    BindingContext(DsPlanilla1.AdelantoPrueba).EndCurrentEdit()
                End If
            Next
            GridControl2.DataSource = DsPlanilla1.AdelantoPrueba
            GroupBox1.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Calcula total"
    Function Calcula_Total()
        Dim i As Integer
        Dim total As Double = 0
        For i = 0 To TablaPlanilla.Rows.Count - 1
            If TablaPlanilla.Rows(i).Item("Moneda") = "DOLAR" Then
                total = total + (TablaPlanilla.Rows(i).Item("SalarioNeto") * DsPlanilla1.Moneda.Rows(1).Item("ValorCompra"))
            End If
            total = total + TablaPlanilla.Rows(i).Item("SalarioNeto")
        Next
        Label3.Text = Format(total, "#,#0.00")
    End Function
#End Region
#Region "Calcular Horas"
    Function HorasOrdinarias2() As Integer
        Dim ds1, ds2 As DataSet
        Dim FechaAnterior As DateTime = Nothing
        Dim total As Integer = 0
        Dim dr2, dr1 As SqlDataReader
        Dim x, y As Integer
        Dim total1 As Integer = 0
        Dim Temp As Integer = 0
        Dim Ex As Boolean = False
        Dim horas1, horas2 As Integer
        Dim cx As New Conexion
        Dim f3, f4 As DateTime
        Dim FA As DateTime
        Dim sqlc As New SqlConnection
        sqlc.ConnectionString = GetSetting("SeeSoft", "Lector", "CONEXION")
        sqlc.Open()
        extra = 0
        Try

            ds1 = cx.ds("SELECT CHECKTIME,CHECKTYPE FROM Check1 WHERE (USERID=" & user1 & "OR USERID=" & user2 & ") and (CHECKTIME >=" & "'" & " " & Me.dtFechaInicio.Text & "'" & ")  and (CHECKTIME <=" & "'" & " " & Me.dtFechaFinal.Text & "'" & ") ORDER BY CHECKTIME")
            ds2 = cx.ds("SELECT CHECKTIME,CHECKTYPE FROM Check1 WHERE (USERID=" & user1 & "OR USERID=" & user2 & ") and (CHECKTIME >=" & "'" & " " & Me.dtFechaInicio.Text & "'" & ")  and (CHECKTIME <=" & "'" & " " & Me.dtFechaFinal.Text & "'" & ") ORDER BY CHECKTIME")
            For x = 0 To ds1.Tables(0).Rows.Count - 1

                f3 = ds1.Tables(0).Rows(x).Item(0)
                f3 = f3.Date
                If FA <> f3 Then
                    FA = ds1.Tables(0).Rows(x).Item(0)
                    FA = FA.Date

                    If Temp > 8 Then
                        total = total + 8
                        extra = extra + (Temp - 8)
                    Else
                        total = total + Temp
                    End If
                    Temp = 0
                End If
                y = x + 1
                For y = y To ds2.Tables(0).Rows.Count - 1
                    Dim f1, f2 As DateTime
                    f2 = ds2.Tables(0).Rows(y).Item(0)
                    f2 = f2.Date
                    Dim salida As String
                    salida = ds2.Tables(0).Rows(y).Item(1)
                    f4 = ds1.Tables(0).Rows(x).Item(0)
                    f4 = f4.Date
                    f4 = f4.AddDays(1)
                    If f2 = f3 And salida = "O" Then
                        horas1 = DateDiff(DateInterval.Minute, ds1.Tables(0).Rows(x).Item(0), ds2.Tables(0).Rows(y).Item(0))
                        horas1 = Math.Round(horas1 / 60, 2)
                        Temp = horas1 + Temp
                        Exit For
                    ElseIf f4 = f2 And salida = "O" Then
                        horas2 = DateDiff(DateInterval.Hour, ds1.Tables(0).Rows(x).Item(0), ds2.Tables(0).Rows(y).Item(0))
                        If horas2 > 0 Then
                            Dim z As Integer
                            z = (DateDiff("N", ds1.Tables(0).Rows(x).Item(0), ds2.Tables(0).Rows(y).Item(0)) / 60) - 1
                            total1 = horas2
                            If total1 > 8 Then
                                total = total + 8
                                extra = extra + (total1 - 8)
                            Else
                                total = total + total1
                            End If
                            Exit For
                        End If
                    ElseIf f2 = f3 And salida = "I" Then
                        Exit For
                    ElseIf f2 = f4 And salida = "I" Then
                        Exit For
                    End If


                Next
            Next
        Catch exc As Exception

        End Try
        Return total
    End Function
    Function HorasOrdinarias(ByVal dr1 As SqlDataReader, ByVal i As Integer) As Integer
        Dim h1, h2 As String
        Dim total As Integer = 0
        Dim dt1 As New DateTime
        Dim dt2 As DateTime
        Dim dr2 As SqlDataReader
        Dim cx As New Conexion
        Dim bol As Boolean = False
        Dim DS As DataSet
        Try
            Dim fech, fech1 As String
            fech = Me.ConvertirFecha()
            ''Arreglar esta consulta
            dr2 = Me.Cargar("SELECT CHECKTIME FROM Check1 WHERE (USERID=" & user1 & "OR USERID=" & user2 & ") and (CHECKTIME >=" & "'" & " " & Me.dtFechaInicio.Text & "'" & ")  and (CHECKTIME < " & "'" & " " & fech & "'" & ") ORDER BY CHECKTIME")
            DS = Me.convertir(dr2)

            While dr1.Read

                Dim p1, p2 As DateTime

                p1 = dr1("CHECKTIME")
                fech1 = p1.Date
                If fech1 = Nothing Then
                    Exit While
                End If
                ' While dr2.Read
                Dim W As Integer
                For W = 0 To DS.Tables(0).Rows.Count - 1
                    If bol = True Then
                        bol = False
                        Exit For
                    End If
                    Dim x As Integer = 0
                    p1 = dr1("CHECKTIME")
                    p1 = p1.Date
                    p2 = DS.Tables(0).Rows(W).Item(0)
                    p2 = p2.Date
                    x = DateDiff(DateInterval.Hour, dr1("CHECKTIME"), DS.Tables(0).Rows(W).Item(0))
                    If p2 = p1 And x > 0 Then
                        Dim Xy As Integer = 0
                        dt1 = dr1("CHECKTIME")
                        dt2 = DS.Tables(0).Rows(W).Item(0)
                        Xy = (DateDiff("N", dt1, dt2) / 60) - 1
                        If Xy > 8 Then
                            total = total + 8
                            extra = extra + (Xy - 8)
                        Else
                            total = total + Xy

                        End If
                        bol = True
                        Exit For
                    End If
                Next

                ' End While
                dr2 = Nothing
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dr1 = Nothing
        Return total
    End Function

    Function HorasOrdinarias3() As Integer
        Dim ds1, ds2 As DataSet
        Dim FechaAnterior As DateTime = Nothing
        Dim total As Integer = 0
        Dim dr2, dr1 As SqlDataReader
        Dim x, y As Integer
        Dim total1 As Integer = 0
        Dim Temp As Integer = 0
        Dim Ex As Boolean = False
        Dim horas1, horas2 As Integer
        Dim cx As New Conexion
        Dim f3 As DateTime = Nothing
        Dim f4 As DateTime = Nothing
        Dim FA As DateTime
        Dim sqlc As New SqlConnection
        sqlc.ConnectionString = GetSetting("SeeSoft", "Lector", "CONEXION")
        sqlc.Open()
        extra = 0
        Try

            ds1 = cx.ds("SELECT CHECKTIME,CHECKTYPE FROM Check1 WHERE (USERID=" & user1 & "OR USERID=" & user2 & ") and (CHECKTIME >=" & "'" & " " & Me.dtFechaInicio.Text & "'" & ")  and (CHECKTIME <=" & "'" & " " & Me.dtFechaFinal.Text & "'" & ") ORDER BY CHECKTIME")
            ds2 = cx.ds("SELECT CHECKTIME,CHECKTYPE FROM Check1 WHERE (USERID=" & user1 & "OR USERID=" & user2 & ") and (CHECKTIME >=" & "'" & " " & Me.dtFechaInicio.Text & "'" & ")  and (CHECKTIME <=" & "'" & " " & Me.dtFechaFinal.Text & "'" & ") ORDER BY CHECKTIME")
            For x = 0 To ds1.Tables(0).Rows.Count - 1
                y = x + 1
                f3 = ds1.Tables(0).Rows(x).Item(0)
                f3 = f3.Date()
                If f4 = f3 Then
                Else
                    If Temp > 8 Then
                        total += 8
                        extra += (Temp - 8)
                    Else
                        total += Temp
                    End If
                    Temp = 0
                End If

                For y = y To ds2.Tables(0).Rows.Count - 1
                    Dim f1, f2 As DateTime
                    f2 = ds2.Tables(0).Rows(y).Item(0)
                    f2 = f2.Date
                    Dim salida As String
                    Dim entrada As String
                    salida = ds2.Tables(0).Rows(y).Item(1)
                    entrada = ds1.Tables(0).Rows(x).Item(1)
                    f4 = ds1.Tables(0).Rows(x).Item(0)
                    f4 = f4.Date
                    If f2 = f4 Then
                        If salida = "O" And entrada = "I" Then
                            horas1 = DateDiff(DateInterval.Minute, ds1.Tables(0).Rows(x).Item(0), ds2.Tables(0).Rows(y).Item(0))
                            horas1 = Math.Round(horas1 / 60, 2)
                            Temp = horas1 + Temp
                            Exit For
                        Else
                            Exit For
                        End If
                    Else
                        f4 = f4.AddDays(1)
                        f4 = f4.Date
                        If f4 = f2 And salida = "O" And entrada = "I" Then
                            horas2 = DateDiff(DateInterval.Hour, ds1.Tables(0).Rows(x).Item(0), ds2.Tables(0).Rows(y).Item(0))
                            If horas2 > 8 Then
                                total += 8
                                extra += (horas2 - 8)
                            Else
                                total += horas2
                            End If
                            Exit For
                        Else
                            Exit For
                        End If
                    End If


                Next
            Next
        Catch exc As Exception

        End Try
        Return total
    End Function
    Function Cargar(ByVal SQL As String) As SqlDataReader
        Dim cx As New Conexion
        Dim dt As SqlDataReader
        Dim sqlc As New SqlConnection
        sqlc.ConnectionString = GetSetting("SeeSoft", "Lector", "CONEXION")
        sqlc.Open()
        dt = cx.GetRecorset(sqlc, SQL)
        Return dt
    End Function
    Function Horas(ByVal dr1 As SqlDataReader, ByVal feci As DateTime, ByVal feci2 As DateTime) As Integer
        Dim cx As New Conexion
        Dim fecha As DateTime = Nothing
        Dim total As Integer
        Dim f1 As DateTime
        While dr1.Read
            If dr1("Checktime") >= feci And dr1("Checktime") <= feci2 Then
                Dim fec As DateTime
                fec = dr1("CheckTime")
                fec = fec.Date()
                If fec = fecha Then
                Else
                    Dim fec1 As DateTime = Nothing
                    fec1 = dr1("CheckTime")
                    fecha = fec1.Date
                    total += 8
                End If
            End If

        End While
        Return total
    End Function
#End Region
#Region "CXC"
    Private Sub btnLimpiarAbonoCxC_Click(sender As Object, e As EventArgs) Handles btnLimpiarAbonoCxC.Click
        If CuentasxC Then
            LimpiarCxC()
        End If
    End Sub

    Sub LimpiarCxC()
        Dim totalACobrar As Double = 0
        Dim i As Integer = 0
        For i = 0 To Me.DsPlanilla1.Facturas_Cobrar.Count - 1
            Dim j As Integer = 0
            For j = 0 To Me.DsPlanilla1.ConsultaSaldos.Count - 1
                If Me.DsPlanilla1.ConsultaSaldos(j).Id = Me.DsPlanilla1.Facturas_Cobrar(i).Id_Factura Then
                    Me.DsPlanilla1.ConsultaSaldos(j).Cobrar = False
                    Me.DsPlanilla1.ConsultaSaldos(j).Abono = 0

                    Me.DsPlanilla1.Facturas_Cobrar(i).Cobrar = False
                    Me.DsPlanilla1.Facturas_Cobrar(i).Abono = 0
                End If
            Next
        Next

        Dim totalCxC As Double = TablaPlanilla.Rows(cxcActualEdit).Item("CxC") - totalACobrar
        Me.TablaPlanilla.Rows(Me.cxcActualEdit).Item("CxC") = totalACobrar
        TablaPlanilla.Rows(cxcActualEdit).Item("TotalDeducciones") = TablaPlanilla.Rows(cxcActualEdit).Item("TotalDeducciones") - totalCxC
        TablaPlanilla.Rows(cxcActualEdit).Item("SalarioNeto") = TablaPlanilla.Rows(cxcActualEdit).Item("SalarioBruto") - TablaPlanilla.Rows(cxcActualEdit).Item("TotalDeducciones")
        Calcula_Total()
    End Sub
    Private Sub ButtonActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonActualizar.Click
        If CuentasxC Then
            ActualizarCxC()
        End If
    End Sub

    Sub ActualizarCxC()
        Dim totalACobrar As Double
        Dim i As Integer = 0
        For i = 0 To Me.DsPlanilla1.Facturas_Cobrar.Count - 1
            Dim j As Integer = 0
            For j = 0 To Me.DsPlanilla1.ConsultaSaldos.Count - 1
                If Me.DsPlanilla1.ConsultaSaldos(j).Id = Me.DsPlanilla1.Facturas_Cobrar(i).Id_Factura Then

                    Me.DsPlanilla1.ConsultaSaldos(j).Cobrar = Me.DsPlanilla1.Facturas_Cobrar(i).Cobrar
                    Me.DsPlanilla1.ConsultaSaldos(j).Abono = Me.DsPlanilla1.Facturas_Cobrar(i).Abono

                    If Me.DsPlanilla1.Facturas_Cobrar(i).Cobrar Then
                        If Me.TablaPlanilla.Rows(Me.cxcActualEdit).Item("Moneda") = "COLON" Then
                            If Me.DsPlanilla1.ConsultaSaldos(j).Cod_Moneda = 1 Then
                                totalACobrar += Me.DsPlanilla1.ConsultaSaldos(j).Abono
                            Else
                                totalACobrar += DsPlanilla1.Moneda.Rows(1).Item("ValorCompra") * Me.DsPlanilla1.ConsultaSaldos(j).Abono
                            End If
                        Else
                            If Me.DsPlanilla1.ConsultaSaldos(j).Cod_Moneda = 2 Then
                                totalACobrar += Me.DsPlanilla1.ConsultaSaldos(j).Abono

                            Else
                                totalACobrar += Me.DsPlanilla1.ConsultaSaldos(j).Abono / DsPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                            End If

                        End If

                    End If

                End If

            Next
        Next

        Dim totalCxC As Double = TablaPlanilla.Rows(cxcActualEdit).Item("CxC") - totalACobrar
        Me.TablaPlanilla.Rows(Me.cxcActualEdit).Item("CxC") = totalACobrar
        TablaPlanilla.Rows(cxcActualEdit).Item("TotalDeducciones") = TablaPlanilla.Rows(cxcActualEdit).Item("TotalDeducciones") - totalCxC
        TablaPlanilla.Rows(cxcActualEdit).Item("SalarioNeto") = TablaPlanilla.Rows(cxcActualEdit).Item("SalarioBruto") - TablaPlanilla.Rows(cxcActualEdit).Item("TotalDeducciones")
        Calcula_Total()

    End Sub

    Sub procesarCxC()
        Me.cxcActualEdit = num
        If Me.TablaPlanilla.Rows.Count > 0 Then
            DsPlanilla1.Facturas_Cobrar.Clear()
            Dim i As Integer = 0
            For i = 0 To Me.DsPlanilla1.ConsultaSaldos.Count - 1
                If Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual > 0 And DsPlanilla1.ConsultaSaldos(i).Id_Empleado = Me.TablaPlanilla.Rows(cxcActualEdit).Item("Cedula") Then
                    Me.BindingContext(Me.DsPlanilla1, "Facturas_Cobrar").AddNew()
                    Me.BindingContext(Me.DsPlanilla1, "Facturas_Cobrar").Current("NumeroFactura") = Me.DsPlanilla1.ConsultaSaldos(i).Num_Factura
                    Me.BindingContext(Me.DsPlanilla1, "Facturas_Cobrar").Current("Cobrar") = Me.DsPlanilla1.ConsultaSaldos(i).Cobrar
                    Me.BindingContext(Me.DsPlanilla1, "Facturas_Cobrar").Current("Fecha") = Me.DsPlanilla1.ConsultaSaldos(i).Fecha
                    Me.BindingContext(Me.DsPlanilla1, "Facturas_Cobrar").Current("Total") = Me.DsPlanilla1.ConsultaSaldos(i).SaldoActual
                    Me.BindingContext(Me.DsPlanilla1, "Facturas_Cobrar").Current("Id_Factura") = Me.DsPlanilla1.ConsultaSaldos(i).Id
                    Me.BindingContext(Me.DsPlanilla1, "Facturas_Cobrar").Current("Abono") = Me.DsPlanilla1.ConsultaSaldos(i).Abono
                    Me.BindingContext(Me.DsPlanilla1, "Facturas_Cobrar").EndCurrentEdit()

                End If
            Next

        Else

        End If
        Me.GroupBoxCxC.Visible = True
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If CuentasxC Then
            procesarCxC()
        End If
    End Sub
#End Region
#Region "Forma Pago"
    Private Sub btnFormaPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormaPago.Click
        If IdPlanilla1 = 0 Then
            MsgBox("Primero se debe registrar la planilla antes de establecer la forma de pago", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim frmFormaPago As New frmFormaPago
        frmFormaPago.IdPlanilla = IdPlanilla1
        frmFormaPago.FechaInicio = dtFechaInicio.Value.Date
        frmFormaPago.FechaFinal = dtFechaFinal.Value.Date
        frmFormaPago.LlenarGridDetalle(IdPlanilla1)
        frmFormaPago.Cedula_usuario = Cedula_usuario
        frmFormaPago.ShowDialog()
    End Sub
#End Region
#Region "Codigo Deshabilitado"
    'Function Moneda(ByVal a As String)
    '    Dim Cx As New Conexion
    '    nombre = Cx.SlqExecuteScalar(Cx.Conectar("Seguridad"), "SELECT MonedaNombre  FROM Moneda where CodMoneda=" & a)
    '    Cx.DesConectar(Cx.sQlconexion)
    'End Function

    'Public Function Conectando() As SqlConnection
    '    Dim sQlconexion As New SqlConnection
    '    Dim SQLStringConexion As String
    '    If sQlconexion.State <> ConnectionState.Open Then
    '        SQLStringConexion = GetSetting("Seesoft", "Planilla", "Conexion")
    '        sQlconexion.ConnectionString = SQLStringConexion
    '        sQlconexion.Open()
    '    Else
    '    End If
    '    Return sQlconexion
    'End Function

    'Function LlenarEmpleados(ByVal Id As Long)
    '    Dim cnnv As SqlConnection = Nothing
    '    Dim dt As New DataTable
    '    Dim cConexion As New Conexion
    '    Dim funcion As New cFunciones
    '    Try

    '        '''''''''LLENAR EMPLEADOS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '        'Obtenemos la cadena de conexión adecuada
    '        Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
    '        cnnv = New SqlConnection(sConn)
    '        cnnv.Open()
    '        'Creamos el comando para la consulta
    '        Dim cmdv As SqlCommand = New SqlCommand
    '        Dim sel As String = "SELECT * FROM Empleado INNER JOIN Empleado_Proyecto ON Empleado.Identificacion = Empleado_Proyecto.Identificacion and Empleado_Proyecto.Id_Proyecto = @Id"
    '        cmdv.CommandText = sel
    '        cmdv.Connection = cnnv
    '        cmdv.CommandType = CommandType.Text
    '        cmdv.CommandTimeout = 90
    '        'Los parámetros usados en la cadena de la consulta 
    '        cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.Int))
    '        cmdv.Parameters("@Id").Value = Id
    '        'Creamos el dataAdapter y asignamos el comando de selección
    '        Dim dv As New SqlDataAdapter
    '        dv.SelectCommand = cmdv
    '        ' Llenamos la tabla
    '        dv.Fill(DsPlanilla1, "Empleado")

    '    Catch ex As System.Exception
    '        ' Si hay error, devolvemos un valor nulo.
    '        MsgBox(ex.ToString)
    '    Finally
    '        ' Por si se produce un error,
    '        ' comprobamos si en realidad el objeto Connection está iniciado,
    '        ' de ser así, lo cerramos.
    '        If Not cnnv Is Nothing Then
    '            cnnv.Close()
    '        End If
    '    End Try

    'End Function

    'Function LlenarHorasT(ByVal Id As Long)
    '    Dim cnn As SqlConnection = Nothing
    '    Dim dt As New DataTable
    '    Dim cConexion As New Conexion
    '    Dim funcion As New cFunciones
    '    'Dentro de un Try/Catch por si se produce un error
    '    Try

    '        '''''''''LLENAR EMPLEADOS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '        'Obtenemos la cadena de conexión adecuada
    '        Dim fechainicial, fechafinal As String
    '        fechainicial = dtFechaInicio.Text
    '        fechafinal = dtFechaFinal.Text
    '        Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
    '        cnn = New SqlConnection(sConn)
    '        cnn.Open()
    '        'Creamos el comando para la consulta
    '        Dim cmd As SqlCommand = New SqlCommand
    '        Dim sel As String = "SELECT * FROM HorasTrabajadas where Fecha >= @fechainicial AND Fecha <=  @fechafinal"
    '        cmd.CommandText = sel
    '        cmd.Connection = cnn
    '        cmd.CommandType = CommandType.Text
    '        cmd.CommandTimeout = 90

    '        cmd.Parameters.Add(New SqlParameter("@fechainicial", SqlDbType.DateTime))
    '        cmd.Parameters.Add(New SqlParameter("@fechafinal", SqlDbType.DateTime))

    '        cmd.Parameters("@fechainicial").Value = fechainicial
    '        cmd.Parameters("@fechafinal").Value = fechafinal

    '        Dim da As New SqlDataAdapter
    '        da.SelectCommand = cmd
    '        da.Fill(DsPlanilla1.HorasTrabajadas)
    '    Catch ex As System.Exception
    '        MsgBox(ex.ToString)
    '    Finally

    '        If Not cnn Is Nothing Then
    '            cnn.Close()
    '        End If
    '    End Try
    'End Function
#End Region
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        Dim cx As New Conexion
        If GetSetting("SeeSoft", "Planilla", "Marcador") = 1 Then
            If BindingContext(TablaPlanilla).Count <> 0 Then
                If e.KeyCode = Keys.F4 Then
                    Dim dt1, dt2 As DateTime
                    Dim pos As Integer
                    pos = BindingContext(TablaPlanilla).Position()
                    Ident = TablaPlanilla.Rows(pos).Item("Cedula")
                    Me.DTINICIO = Me.dtFechaInicio.Text
                    Me.Dtfinal = Me.dtFechaFinal.Text
                    Phuella = cx.SlqExecuteScalar(cx.Conectar("Planilla"), "SELECT Pin_Huella FROM Empleado WHERE Identificacion = '" + Ident + "'")
                    cx.DesConectar(cx.sQlconexion)
                    Ptarjeta = cx.SlqExecuteScalar(cx.Conectar("Planilla"), "SELECT Pin_tarjeta FROM Empleado WHERE Identificacion = '" + Ident + "'")
                    cx.DesConectar(cx.sQlconexion)
                    Me.NombreCliente = cx.SlqExecuteScalar(cx.Conectar("Planilla"), "select Nombre FROM Empleado WHERE Identificacion = '" + Ident + "'")
                    cx.DesConectar(cx.sQlconexion)
                    Dim f As New Fmarcas
                    f.ShowDialog()
                End If

            End If
        End If

    End Sub
    Function ConvertirFecha() As String
        Dim d, ds As DateTime
        Dim f, a, d1, m As String
        Dim dia As Integer
        d = Me.dtFechaFinal.Text
        ds = d.AddDays(1)
        d1 = ds.Day
        m = ds.Month
        a = ds.Year
        f = d1 + "/" + m + "/" + a
        Return f
    End Function
    Sub Datos(ByVal i As Integer)
        Dim cx As New Conexion
        huella = cx.SlqExecuteScalar(cx.Conectar("Planilla"), "SELECT Pin_Huella FROM Empleado WHERE Identificacion = '" + DsPlanilla1.Empleado.Rows(i).Item("Identificacion") + "'")
        cx.DesConectar(cx.sQlconexion)
        tarjeta = cx.SlqExecuteScalar(cx.Conectar("Planilla"), "SELECT Pin_tarjeta FROM Empleado WHERE Identificacion = '" + DsPlanilla1.Empleado.Rows(i).Item("Identificacion") + "'")
        cx.DesConectar(cx.sQlconexion)
        user1 = cx.SlqExecuteScalar(cx.Conectar("Lector"), "SELECT USERID FROM Check1 WHERE BADGENUMBER = '" + huella + "'")
        cx.DesConectar(cx.sQlconexion)
        user2 = cx.SlqExecuteScalar(cx.Conectar("Lector"), "SELECT USERID FROM Check1 WHERE BADGENUMBER = '" + tarjeta + "'")
        cx.DesConectar(cx.sQlconexion)
        If user1 = Nothing Then
            user1 = "0"
        End If
        If user2 = Nothing Then
            user2 = "0"
        End If
    End Sub
    Function convertir(ByVal reader As SqlDataReader) As DataSet
        Dim ds = New DataSet
        Dim Y = 0
        Dim Z = Me.CONTAR(reader)
        Try
            Do While Y <= Z
                Dim SCHEMA As DataTable
                SCHEMA = reader.GetSchemaTable()
                Dim TABLE = New DataTable
                If SCHEMA Is Nothing Then
                    Dim column = New DataColumn("RowsAffected")
                    TABLE.Columns.Add(column)
                    ds.Tables.Add(TABLE)
                    Dim row = TABLE.NewRow()
                    row(0) = reader.RecordsAffected
                    TABLE.Rows.Add(row)
                Else
                    '' Crear un DataTable y agregarlo al DataSet
                    Dim I As Integer
                    For I = 0 To SCHEMA.Rows.Count - 1
                        Dim row = SCHEMA.Rows(I)
                        Dim name = row("ColumnName")
                        Dim column = New DataColumn(name, row("DataType"))
                        TABLE.Columns.Add(column)
                    Next
                    ds.Tables.Add(TABLE)
                    '' Rellene la tabla de datos
                    While (reader.Read())
                        Dim X As Integer
                        Dim row = TABLE.NewRow()
                        For X = 0 To reader.FieldCount - 1
                            row(X) = reader.GetValue(X)
                            TABLE.Rows.Add(row)
                        Next
                    End While

                End If
                Y = Y + 1
                reader.NextResult()
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return ds
    End Function

    Function CONTAR(ByVal dr As SqlDataReader) As Integer

        Dim FECH As String
        FECH = Me.ConvertirFecha
        dr = Me.Cargar("SELECT CHECKTIME FROM Check1 WHERE (USERID=" & user1 & "OR USERID=" & user2 & ") and (CHECKTIME >=" & "'" & " " & Me.dtFechaInicio.Text & "'" & ")  and (CHECKTIME <= " & "'" & " " & Me.dtFechaFinal.Value & "'" & ") ")
        Dim X As Integer
        While dr.Read
            X = X + 1
        End While
        Return X
    End Function

    Sub guardar()
        dlg = New WaitDialogForm("Guardando Planilla")
        PlanillaNumero()
        BindingContext(DsPlanilla1.Planilla).Current("FechaInicial") = dtFechaInicio.Value
        BindingContext(DsPlanilla1.Planilla).Current("FechaFinal") = dtFechaFinal.Value
        BindingContext(DsPlanilla1.Planilla).Current("Serv_Prof") = Check_ServProf.Checked
        BindingContext(DsPlanilla1.Planilla).Current("NumeroPlanilla") = CInt(txtPlanillaNumero.Text)
        BindingContext(DsPlanilla1.Planilla).EndCurrentEdit()
        Dim n As Integer
        BindingContext(DsPlanilla1.Planilla).EndCurrentEdit()
        If ToolBar1.Buttons(3).Text = "Registrar" Then
            NumeroPlanilla()
        End If
        CargarPlanilla()
        If Registrar_Planilla() Then  'se registra en la base de datos then
            DsPlanilla1.AcceptChanges()
            ToolBar1.Buttons(1).Enabled = True
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
            dlg.Close()
            MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
            Limpiar()
            TablaPlanilla.Clear()
            DsProyecto.Proyecto.Clear()
            ToolBar1.Buttons(4).Enabled = False
            Bloquear()
            Me.ToolBarRegistrar.Text = "Registrar"
        Else
            MsgBox("Error al Registrar", MsgBoxStyle.Critical)
            ToolBar1.Buttons(3).Enabled = True
        End If
    End Sub


    Sub actualizar()
        Me.DsPlanilla1.Planilla_Deducciones.Clear()
        Me.DsPlanilla1.Deduccion_Empleado.Clear()
        Me.DsPlanilla1.Planilla_Detalle.Clear()
        Dim Cx As New Conexion
        dlg = New WaitDialogForm("Guardando Planilla")

        'BindingContext(DsPlanilla1.Planilla).Current("FechaInicial") = dtFechaInicio.Value
        'BindingContext(DsPlanilla1.Planilla).Current("FechaFinal") = dtFechaFinal.Value
        'BindingContext(DsPlanilla1.Planilla).Current("Serv_Prof") = Check_ServProf.Checked
        'BindingContext(DsPlanilla1.Planilla).Current("NumeroPlanilla") = CInt(txtPlanillaNumero.Text)
        CargarPlanilla()

        If ToolBar1.Buttons(3).Text = "Actualizar" Then
            'Si es actualizar la planilla
            'Dim cxa As New Conexion
            'Me.SqlConnection1 = cxa.Conectar("Planilla")
            'Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
            'rolando obando rojas
            'rolando obando rojas
            Try
                Cx.SlqExecuteScalar(Cx.Conectar("Planilla"), "DELETE FROM Planilla_Detalle where id_planilla=" & Me.IdPlanilla1)
                If Registrar_Planilla() Then  'se registra en la base de datos then
                    DsPlanilla1.AcceptChanges()
                    ToolBar1.Buttons(1).Enabled = True
                    ToolBar1.Buttons(0).Text = "Nuevo"
                    ToolBar1.Buttons(0).ImageIndex = 0

                    dlg.Close()
                    MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                    Limpiar()
                    TablaPlanilla.Clear()
                    DsProyecto.Proyecto.Clear()
                    ToolBar1.Buttons(4).Enabled = False
                    Bloquear()
                    Me.ToolBarRegistrar.Text = "Registrar"
                Else
                    MsgBox("Error al Registrar", MsgBoxStyle.Critical)
                    ToolBar1.Buttons(3).Enabled = True
                End If
                'Trans.Commit()
            Catch ex As Exception
                'cxa.RollBack(Me.SqlConnection1)
                'Trans.Rollback()
            End Try

        Else
            'Si es registrar una nueva planilla
            If Registrar_Planilla() Then  'se registra en la base de datos then
                DsPlanilla1.AcceptChanges()
                ToolBar1.Buttons(1).Enabled = True
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0

                dlg.Close()
                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                Limpiar()
                TablaPlanilla.Clear()
                DsProyecto.Proyecto.Clear()
                ToolBar1.Buttons(4).Enabled = False
                Bloquear()
                Me.ToolBarRegistrar.Text = "Registrar"
            Else
                MsgBox("Error al Registrar", MsgBoxStyle.Critical)
                ToolBar1.Buttons(3).Enabled = True
            End If
        End If
    End Sub

    Private Sub dtFechaFinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaFinal.ValueChanged

    End Sub

    Private Sub CerrarPlanilla(IdPlanilla As Long)
        Try
            Dim db As New OBSoluciones.SQL.Sentencias(Me.SqlConnection1.ConnectionString)
            Dim strSQL As String = "Update Planilla Set Cerrada = 1 Where NumeroPlanilla = " & IdPlanilla
            db.Ejecutar(strSQL, CommandType.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Function PuedeEditar(IdPlanilla As Long) As Boolean
        Try
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select * From Planilla Where NumeroPlanilla = " & IdPlanilla, dt, Me.SqlConnection1.ConnectionString)
            If dt.Rows.Count > 0 Then
                Dim Cerrada As Boolean = dt.Rows(0).Item("Cerrada")
                If Cerrada = True Then
                    MsgBox("La planilla ya esta Terminada no se puede editar", MsgBoxStyle.Information, Text)
                    Return False
                Else
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
            Return False
        End Try
    End Function

    Private Function GetSalarioEmpleado(Identificacion As String) As Decimal
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Salario from empleado where Identificacion = '" & Identificacion & "'", dt, Me.SqlConnection1.ConnectionString)
        If dt.Rows.Count > 0 Then
            If IsNumeric(dt.Rows(0).Item("Salario")) Then
                If CDec(dt.Rows(0).Item("Salario")) > 0 Then
                    Return CDec(dt.Rows(0).Item("Salario"))
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function


    Private Sub CargarAccionesEmpleados()
        Dim dt As New DataTable
        Dim strSQL As String = ""
        Try
            strSQL = "Select Codigo From Accion Where Vacaciones = 1"
            cFunciones.Llenar_Tabla_Generico(strSQL, dt, Me.SqlConnection1.ConnectionString)
            If dt.Rows.Count > 0 Then
                Me.vVacacciones = dt.Rows(0).Item("Codigo")
            Else
                Me.vVacacciones = 0
            End If
        Catch ex As Exception
        End Try

        Try
            strSQL = "Select Codigo From Accion Where INS = 1"
            cFunciones.Llenar_Tabla_Generico(strSQL, dt, Me.SqlConnection1.ConnectionString)
            If dt.Rows.Count > 0 Then
                Me.vINS = dt.Rows(0).Item("Codigo")
            Else
                Me.vINS = 0
            End If
        Catch ex As Exception
        End Try

        Try
            strSQL = "Select Codigo From Accion Where Embarazo = 1"
            cFunciones.Llenar_Tabla_Generico(strSQL, dt, Me.SqlConnection1.ConnectionString)
            If dt.Rows.Count > 0 Then
                Me.vEmbarazo = dt.Rows(0).Item("Codigo")
            Else
                Me.vEmbarazo = 0
            End If
        Catch ex As Exception
        End Try

        Try
            strSQL = "Select Codigo From Accion Where Incapacidad = 1"
            cFunciones.Llenar_Tabla_Generico(strSQL, dt, Me.SqlConnection1.ConnectionString)
            If dt.Rows.Count > 0 Then
                Me.vCCSS = dt.Rows(0).Item("Codigo")
            Else
                Me.vCCSS = 0
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ActualizarDatosEmpleado()
        Dim Salario As Decimal = 0
        Dim ActualizaDatos As Boolean = False
        '*************************************************************************************************************************
        'vuelve a cargar la informacion del sistema
        '*************************************************************************************************************************
        adEmpleados.Fill(DsPlanilla1.Empleado)
        adDeducciones.Fill(DsPlanilla1.Deducciones)
        adAdelantos.Fill(DsPlanilla1.Adelantos)
        adRenta.Fill(DsPlanilla1.ParametroRenta)
        adAccion.Fill(DsPlanilla1.AccionPersonal)
        adMoneda.Fill(DsPlanilla1.Moneda)
        AdOrdinarias.Fill(DsPlanilla1.Horas_Ordinarias)
        adEmpleadoDeducciones.Fill(DsPlanilla1, "Empleado_Deducciones")
        Me.CargarAccionesEmpleados()

        If CuentasxC Then
            If MsgBox("Desea volver a cargar las cuentas por cobrar?" & vbCrLf _
                      & "Este proceso limpiara las cuentas por cobrar y luego las volver a cargar.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Acccion") = MsgBoxResult.Yes Then
                cFunciones.Llenar_Tabla_Generico("SELECT Cod_Cliente, SaldoActual, Cod_Moneda, Intereses, Tipo_Cambio,  Num_Factura, 1 As Cobrar, Id, Id_Empleado,Fecha, SaldoActual as Abono FROM dbo.Estado_CxC_Actual_Empleado Where SaldoActual > 0", Me.DsPlanilla1.ConsultaSaldos, GetSetting("Planilla", "Planilla", "Conexion"))
            End If
        End If
        '*************************************************************************************************************************
        dlg = New WaitDialogForm("Actualizando Datos")
        For i As Integer = 0 To Me.TablaPlanilla.Rows.Count - 1
            Salario = Me.GetSalarioEmpleado(Me.TablaPlanilla.Rows(i).Item("Cedula"))
            Me.TablaPlanilla.Rows(i).Item("Salario") = Salario
            Me.Recalcular_Fila_Planilla(i)
            Me.Recalcular_Fila_Saldo(i)
        Next
        dlg.Close()
    End Sub

    Private Sub btnBloquear_Click(sender As Object, e As EventArgs) Handles btnBloquear.Click
        If MsgBox("Desea Cerrar la Planilla, no se podra editar despues de esto", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Text) = MsgBoxResult.Yes Then
            Me.CerrarPlanilla(Me.txtPlanillaNumero.Text)
        End If
    End Sub

    Private Sub btnActualizarDatosEmpleado_Click(sender As Object, e As EventArgs) Handles btnActualizarDatosEmpleado.Click
        'If IsNumeric(Me.txtPlanillaNumero.Text) Then
        '    If CDec(Me.txtPlanillaNumero.Text) > 0 Then
        '        If Me.PuedeEditar(Me.txtPlanillaNumero.Text) = False Then
        '            Exit Sub
        '        End If
        '        Me.ActualizarDatosEmpleado()
        '    Else
        '        Me.ActualizarDatosEmpleado()
        '    End If
        'End If
        Me.ActualizarDatosEmpleado()

    End Sub

    Private Sub btnLimpiarCxC_Click(sender As Object, e As EventArgs) Handles btnLimpiarCxC.Click
        Try
            If MsgBox("Desea limpiar las Cuentas por Cobrar", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                dlg = New WaitDialogForm("Limpiando Cuentas por Cobrar")
                For i As Integer = 0 To Me.DsPlanilla1.ConsultaSaldos.Rows.Count - 1
                    Me.DsPlanilla1.ConsultaSaldos(i).Cobrar = False
                    Me.DsPlanilla1.ConsultaSaldos(i).Abono = 0
                Next
                For i As Integer = 0 To Me.TablaPlanilla.Rows.Count - 1
                    Me.Recalcular_Fila_Planilla(i)
                    Me.Recalcular_Fila_Saldo(i)
                Next
                dlg.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
