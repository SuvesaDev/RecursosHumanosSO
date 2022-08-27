Imports System.data.SqlClient
Imports Utilidades

Public Class frmModificaPlanilla
    Inherits FrmPlantilla

    Public TablaModifica As New DataTable
    Dim IdPlanilla1 As Integer
    Dim usua As Object
    Dim Id, Cedula As String
    Dim Pagomes As Double
    Dim FechaI, FechaF As Date
    Dim cierre As Boolean
    Public TablaRenta1, TablaRenta As New DataTable


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Protected WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdPlanilla As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdPlanillaDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsModificaPlanilla1 As Planilla.DsModificaPlanilla
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdDeducciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdPlanillaDeducciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdAdelantos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdAccion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdEmpleado_Deducciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdRenta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdAdelantos_Detalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdEmpleado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand11 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmModificaPlanilla))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.AdPlanilla = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.AdPlanillaDetalle = New System.Data.SqlClient.SqlDataAdapter
        Me.DsModificaPlanilla1 = New Planilla.DsModificaPlanilla
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.AdDeducciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.AdPlanillaDeducciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.AdAdelantos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.AdAccion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        Me.AdMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        Me.AdEmpleado_Deducciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand9 = New System.Data.SqlClient.SqlCommand
        Me.AdRenta = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand10 = New System.Data.SqlClient.SqlCommand
        Me.AdAdelantos_Detalle = New System.Data.SqlClient.SqlDataAdapter
        Me.AdEmpleado = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand11 = New System.Data.SqlClient.SqlCommand
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsModificaPlanilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 175)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(778, 64)
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(778, 32)
        Me.TituloModulo.Text = "Modifica Planilla"
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
        Me.GridControl1.Location = New System.Drawing.Point(0, 32)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(776, 151)
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
        Me.GridControl1.TabIndex = 60
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.FixedLineWidth = 1
        Me.GridView1.GroupFormat = ""
        Me.GridView1.GroupPanelText = "Datos del Empleado"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id_Planilla, Fecha, FechaInicial, FechaFinal, CierreMes, Ced_Usuario, Nomb" & _
        "re_Usuario, Anulado, Id_Proyecto FROM Planilla"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=Oscar;" & _
        "persist security info=False;initial catalog=Planilla"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Planilla(Fecha, FechaInicial, FechaFinal, CierreMes, Ced_Usuario, Nom" & _
        "bre_Usuario, Anulado, Id_Proyecto) VALUES (@Fecha, @FechaInicial, @FechaFinal, @" & _
        "CierreMes, @Ced_Usuario, @Nombre_Usuario, @Anulado, @Id_Proyecto); SELECT Id_Pla" & _
        "nilla, Fecha, FechaInicial, FechaFinal, CierreMes, Ced_Usuario, Nombre_Usuario, " & _
        "Anulado, Id_Proyecto FROM Planilla WHERE (Id_Planilla = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaInicial", System.Data.SqlDbType.DateTime, 8, "FechaInicial"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaFinal", System.Data.SqlDbType.DateTime, 8, "FechaFinal"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CierreMes", System.Data.SqlDbType.Bit, 1, "CierreMes"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, "Nombre_Usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Proyecto", System.Data.SqlDbType.Int, 4, "Id_Proyecto"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Planilla SET Fecha = @Fecha, FechaInicial = @FechaInicial, FechaFinal = @F" & _
        "echaFinal, CierreMes = @CierreMes, Ced_Usuario = @Ced_Usuario, Nombre_Usuario = " & _
        "@Nombre_Usuario, Anulado = @Anulado, Id_Proyecto = @Id_Proyecto WHERE (Id_Planil" & _
        "la = @Original_Id_Planilla) AND (Anulado = @Original_Anulado) AND (Ced_Usuario =" & _
        " @Original_Ced_Usuario) AND (CierreMes = @Original_CierreMes) AND (Fecha = @Orig" & _
        "inal_Fecha) AND (FechaFinal = @Original_FechaFinal) AND (FechaInicial = @Origina" & _
        "l_FechaInicial) AND (Id_Proyecto = @Original_Id_Proyecto) AND (Nombre_Usuario = " & _
        "@Original_Nombre_Usuario); SELECT Id_Planilla, Fecha, FechaInicial, FechaFinal, " & _
        "CierreMes, Ced_Usuario, Nombre_Usuario, Anulado, Id_Proyecto FROM Planilla WHERE" & _
        " (Id_Planilla = @Id_Planilla)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaInicial", System.Data.SqlDbType.DateTime, 8, "FechaInicial"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaFinal", System.Data.SqlDbType.DateTime, 8, "FechaFinal"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CierreMes", System.Data.SqlDbType.Bit, 1, "CierreMes"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, "Nombre_Usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Proyecto", System.Data.SqlDbType.Int, 4, "Id_Proyecto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CierreMes", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CierreMes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaFinal", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaFinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaInicial", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaInicial", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Proyecto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Proyecto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 8, "Id_Planilla"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Planilla WHERE (Id_Planilla = @Original_Id_Planilla) AND (Anulado = @" & _
        "Original_Anulado) AND (Ced_Usuario = @Original_Ced_Usuario) AND (CierreMes = @Or" & _
        "iginal_CierreMes) AND (Fecha = @Original_Fecha) AND (FechaFinal = @Original_Fech" & _
        "aFinal) AND (FechaInicial = @Original_FechaInicial) AND (Id_Proyecto = @Original" & _
        "_Id_Proyecto) AND (Nombre_Usuario = @Original_Nombre_Usuario)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CierreMes", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CierreMes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaFinal", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaFinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaInicial", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaInicial", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Proyecto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Proyecto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdPlanilla
        '
        Me.AdPlanilla.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdPlanilla.InsertCommand = Me.SqlInsertCommand1
        Me.AdPlanilla.SelectCommand = Me.SqlSelectCommand1
        Me.AdPlanilla.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Planilla", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Planilla", "Id_Planilla"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("FechaInicial", "FechaInicial"), New System.Data.Common.DataColumnMapping("FechaFinal", "FechaFinal"), New System.Data.Common.DataColumnMapping("CierreMes", "CierreMes"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("Nombre_Usuario", "Nombre_Usuario"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Id_Proyecto", "Id_Proyecto")})})
        Me.AdPlanilla.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id, Id_Planilla, Cedula, Nombre, Puesto, Salario, FormaPago, Ordinaria, Ex" & _
        "tra, Doble, SalarioBruto, Adelantos, Prestamos, Renta, TotalDeducciones, Salario" & _
        "Neto, Cod_Moneda, Modificado FROM Planilla_Detalle"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Planilla_Detalle(Id_Planilla, Cedula, Nombre, Puesto, Salario, FormaP" & _
        "ago, Ordinaria, Extra, Doble, SalarioBruto, Adelantos, Prestamos, Renta, TotalDe" & _
        "ducciones, SalarioNeto, Cod_Moneda, Modificado) VALUES (@Id_Planilla, @Cedula, @" & _
        "Nombre, @Puesto, @Salario, @FormaPago, @Ordinaria, @Extra, @Doble, @SalarioBruto" & _
        ", @Adelantos, @Prestamos, @Renta, @TotalDeducciones, @SalarioNeto, @Cod_Moneda, " & _
        "@Modificado); SELECT Id, Id_Planilla, Cedula, Nombre, Puesto, Salario, FormaPago" & _
        ", Ordinaria, Extra, Doble, SalarioBruto, Adelantos, Prestamos, Renta, TotalDeduc" & _
        "ciones, SalarioNeto, Cod_Moneda, Modificado FROM Planilla_Detalle WHERE (Id = @@" & _
        "IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 8, "Id_Planilla"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 15, "FormaPago"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ordinaria", System.Data.SqlDbType.Float, 8, "Ordinaria"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Extra", System.Data.SqlDbType.Float, 8, "Extra"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Doble", System.Data.SqlDbType.Float, 8, "Doble"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioBruto", System.Data.SqlDbType.Float, 8, "SalarioBruto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Adelantos", System.Data.SqlDbType.Float, 8, "Adelantos"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Prestamos", System.Data.SqlDbType.Float, 8, "Prestamos"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Renta", System.Data.SqlDbType.Float, 8, "Renta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDeducciones", System.Data.SqlDbType.Float, 8, "TotalDeducciones"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioNeto", System.Data.SqlDbType.Float, 8, "SalarioNeto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modificado", System.Data.SqlDbType.Bit, 1, "Modificado"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Planilla_Detalle SET Id_Planilla = @Id_Planilla, Cedula = @Cedula, Nombre " & _
        "= @Nombre, Puesto = @Puesto, Salario = @Salario, FormaPago = @FormaPago, Ordinar" & _
        "ia = @Ordinaria, Extra = @Extra, Doble = @Doble, SalarioBruto = @SalarioBruto, A" & _
        "delantos = @Adelantos, Prestamos = @Prestamos, Renta = @Renta, TotalDeducciones " & _
        "= @TotalDeducciones, SalarioNeto = @SalarioNeto, Cod_Moneda = @Cod_Moneda, Modif" & _
        "icado = @Modificado WHERE (Id = @Original_Id) AND (Adelantos = @Original_Adelant" & _
        "os) AND (Cedula = @Original_Cedula) AND (Cod_Moneda = @Original_Cod_Moneda) AND " & _
        "(Doble = @Original_Doble) AND (Extra = @Original_Extra) AND (FormaPago = @Origin" & _
        "al_FormaPago) AND (Id_Planilla = @Original_Id_Planilla) AND (Modificado = @Origi" & _
        "nal_Modificado) AND (Nombre = @Original_Nombre) AND (Ordinaria = @Original_Ordin" & _
        "aria) AND (Prestamos = @Original_Prestamos) AND (Puesto = @Original_Puesto) AND " & _
        "(Renta = @Original_Renta) AND (Salario = @Original_Salario) AND (SalarioBruto = " & _
        "@Original_SalarioBruto) AND (SalarioNeto = @Original_SalarioNeto) AND (TotalDedu" & _
        "cciones = @Original_TotalDeducciones); SELECT Id, Id_Planilla, Cedula, Nombre, P" & _
        "uesto, Salario, FormaPago, Ordinaria, Extra, Doble, SalarioBruto, Adelantos, Pre" & _
        "stamos, Renta, TotalDeducciones, SalarioNeto, Cod_Moneda, Modificado FROM Planil" & _
        "la_Detalle WHERE (Id = @Id)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 8, "Id_Planilla"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 15, "FormaPago"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ordinaria", System.Data.SqlDbType.Float, 8, "Ordinaria"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Extra", System.Data.SqlDbType.Float, 8, "Extra"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Doble", System.Data.SqlDbType.Float, 8, "Doble"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioBruto", System.Data.SqlDbType.Float, 8, "SalarioBruto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Adelantos", System.Data.SqlDbType.Float, 8, "Adelantos"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Prestamos", System.Data.SqlDbType.Float, 8, "Prestamos"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Renta", System.Data.SqlDbType.Float, 8, "Renta"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDeducciones", System.Data.SqlDbType.Float, 8, "TotalDeducciones"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioNeto", System.Data.SqlDbType.Float, 8, "SalarioNeto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modificado", System.Data.SqlDbType.Bit, 1, "Modificado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Adelantos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adelantos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Doble", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Doble", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Extra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Extra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modificado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modificado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ordinaria", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ordinaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Prestamos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prestamos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Renta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Renta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioBruto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioBruto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioNeto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioNeto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDeducciones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDeducciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Planilla_Detalle WHERE (Id = @Original_Id) AND (Adelantos = @Original" & _
        "_Adelantos) AND (Cedula = @Original_Cedula) AND (Cod_Moneda = @Original_Cod_Mone" & _
        "da) AND (Doble = @Original_Doble) AND (Extra = @Original_Extra) AND (FormaPago =" & _
        " @Original_FormaPago) AND (Id_Planilla = @Original_Id_Planilla) AND (Modificado " & _
        "= @Original_Modificado) AND (Nombre = @Original_Nombre) AND (Ordinaria = @Origin" & _
        "al_Ordinaria) AND (Prestamos = @Original_Prestamos) AND (Puesto = @Original_Pues" & _
        "to) AND (Renta = @Original_Renta) AND (Salario = @Original_Salario) AND (Salario" & _
        "Bruto = @Original_SalarioBruto) AND (SalarioNeto = @Original_SalarioNeto) AND (T" & _
        "otalDeducciones = @Original_TotalDeducciones)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Adelantos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adelantos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Doble", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Doble", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Extra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Extra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modificado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modificado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ordinaria", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ordinaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Prestamos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prestamos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Renta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Renta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioBruto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioBruto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioNeto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioNeto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDeducciones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDeducciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdPlanillaDetalle
        '
        Me.AdPlanillaDetalle.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdPlanillaDetalle.InsertCommand = Me.SqlInsertCommand2
        Me.AdPlanillaDetalle.SelectCommand = Me.SqlSelectCommand2
        Me.AdPlanillaDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Planilla_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_Planilla", "Id_Planilla"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("FormaPago", "FormaPago"), New System.Data.Common.DataColumnMapping("Ordinaria", "Ordinaria"), New System.Data.Common.DataColumnMapping("Extra", "Extra"), New System.Data.Common.DataColumnMapping("Doble", "Doble"), New System.Data.Common.DataColumnMapping("SalarioBruto", "SalarioBruto"), New System.Data.Common.DataColumnMapping("Adelantos", "Adelantos"), New System.Data.Common.DataColumnMapping("Prestamos", "Prestamos"), New System.Data.Common.DataColumnMapping("Renta", "Renta"), New System.Data.Common.DataColumnMapping("TotalDeducciones", "TotalDeducciones"), New System.Data.Common.DataColumnMapping("SalarioNeto", "SalarioNeto"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Modificado", "Modificado")})})
        Me.AdPlanillaDetalle.UpdateCommand = Me.SqlUpdateCommand2
        '
        'DsModificaPlanilla1
        '
        Me.DsModificaPlanilla1.DataSetName = "DsModificaPlanilla"
        Me.DsModificaPlanilla1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Codigo, Descripcion, Monto, Tipo, Aplica, Cod_Moneda FROM Deducciones"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Deducciones(Descripcion, Monto, Tipo, Aplica, Cod_Moneda) VALUES (@De" & _
        "scripcion, @Monto, @Tipo, @Aplica, @Cod_Moneda); SELECT Codigo, Descripcion, Mon" & _
        "to, Tipo, Aplica, Cod_Moneda FROM Deducciones WHERE (Codigo = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplica", System.Data.SqlDbType.Bit, 1, "Aplica"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Deducciones SET Descripcion = @Descripcion, Monto = @Monto, Tipo = @Tipo, " & _
        "Aplica = @Aplica, Cod_Moneda = @Cod_Moneda WHERE (Codigo = @Original_Codigo) AND" & _
        " (Aplica = @Original_Aplica) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Descri" & _
        "pcion = @Original_Descripcion) AND (Monto = @Original_Monto) AND (Tipo = @Origin" & _
        "al_Tipo); SELECT Codigo, Descripcion, Monto, Tipo, Aplica, Cod_Moneda FROM Deduc" & _
        "ciones WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplica", System.Data.SqlDbType.Bit, 1, "Aplica"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aplica", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplica", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Deducciones WHERE (Codigo = @Original_Codigo) AND (Aplica = @Original" & _
        "_Aplica) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Descripcion = @Original_De" & _
        "scripcion) AND (Monto = @Original_Monto) AND (Tipo = @Original_Tipo)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aplica", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplica", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdDeducciones
        '
        Me.AdDeducciones.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdDeducciones.InsertCommand = Me.SqlInsertCommand3
        Me.AdDeducciones.SelectCommand = Me.SqlSelectCommand3
        Me.AdDeducciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Deducciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Aplica", "Aplica"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        Me.AdDeducciones.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Id, Id_PlanillaDetalle, Cod_Deduccion, Nombre, Monto, Cod_Moneda FROM Plan" & _
        "illa_Deducciones"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Planilla_Deducciones(Id_PlanillaDetalle, Cod_Deduccion, Nombre, Monto" & _
        ", Cod_Moneda) VALUES (@Id_PlanillaDetalle, @Cod_Deduccion, @Nombre, @Monto, @Cod" & _
        "_Moneda); SELECT Id, Id_PlanillaDetalle, Cod_Deduccion, Nombre, Monto, Cod_Moned" & _
        "a FROM Planilla_Deducciones WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_PlanillaDetalle", System.Data.SqlDbType.BigInt, 8, "Id_PlanillaDetalle"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Deduccion", System.Data.SqlDbType.Int, 4, "Cod_Deduccion"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Planilla_Deducciones SET Id_PlanillaDetalle = @Id_PlanillaDetalle, Cod_Ded" & _
        "uccion = @Cod_Deduccion, Nombre = @Nombre, Monto = @Monto, Cod_Moneda = @Cod_Mon" & _
        "eda WHERE (Id = @Original_Id) AND (Cod_Deduccion = @Original_Cod_Deduccion) AND " & _
        "(Cod_Moneda = @Original_Cod_Moneda) AND (Id_PlanillaDetalle = @Original_Id_Plani" & _
        "llaDetalle) AND (Monto = @Original_Monto) AND (Nombre = @Original_Nombre); SELEC" & _
        "T Id, Id_PlanillaDetalle, Cod_Deduccion, Nombre, Monto, Cod_Moneda FROM Planilla" & _
        "_Deducciones WHERE (Id = @Id)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_PlanillaDetalle", System.Data.SqlDbType.BigInt, 8, "Id_PlanillaDetalle"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Deduccion", System.Data.SqlDbType.Int, 4, "Cod_Deduccion"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Deduccion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Deduccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_PlanillaDetalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_PlanillaDetalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Planilla_Deducciones WHERE (Id = @Original_Id) AND (Cod_Deduccion = @" & _
        "Original_Cod_Deduccion) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Id_Planilla" & _
        "Detalle = @Original_Id_PlanillaDetalle) AND (Monto = @Original_Monto) AND (Nombr" & _
        "e = @Original_Nombre)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Deduccion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Deduccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_PlanillaDetalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_PlanillaDetalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdPlanillaDeducciones
        '
        Me.AdPlanillaDeducciones.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdPlanillaDeducciones.InsertCommand = Me.SqlInsertCommand4
        Me.AdPlanillaDeducciones.SelectCommand = Me.SqlSelectCommand4
        Me.AdPlanillaDeducciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Planilla_Deducciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_PlanillaDetalle", "Id_PlanillaDetalle"), New System.Data.Common.DataColumnMapping("Cod_Deduccion", "Cod_Deduccion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        Me.AdPlanillaDeducciones.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Numero, Identificacion, Nombre, Adelanto, Prestamo, Puesto, Salario, Fecha" & _
        "Comprobante, Num_Pago, Monto, MontoEnLetras, FechaCobro, Observaciones, Deducirx" & _
        "Pago, Usuario, NombreUsuario, Cod_Moneda, Anulado, Saldo FROM Adelantos"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO Adelantos(Identificacion, Nombre, Adelanto, Prestamo, Puesto, Salario" & _
        ", FechaComprobante, Num_Pago, Monto, MontoEnLetras, FechaCobro, Observaciones, D" & _
        "educirxPago, Usuario, NombreUsuario, Cod_Moneda, Anulado, Saldo) VALUES (@Identi" & _
        "ficacion, @Nombre, @Adelanto, @Prestamo, @Puesto, @Salario, @FechaComprobante, @" & _
        "Num_Pago, @Monto, @MontoEnLetras, @FechaCobro, @Observaciones, @DeducirxPago, @U" & _
        "suario, @NombreUsuario, @Cod_Moneda, @Anulado, @Saldo); SELECT Numero, Identific" & _
        "acion, Nombre, Adelanto, Prestamo, Puesto, Salario, FechaComprobante, Num_Pago, " & _
        "Monto, MontoEnLetras, FechaCobro, Observaciones, DeducirxPago, Usuario, NombreUs" & _
        "uario, Cod_Moneda, Anulado, Saldo FROM Adelantos WHERE (Numero = @@IDENTITY)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Adelanto", System.Data.SqlDbType.Bit, 1, "Adelanto"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Prestamo", System.Data.SqlDbType.Bit, 1, "Prestamo"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaComprobante", System.Data.SqlDbType.DateTime, 8, "FechaComprobante"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Pago", System.Data.SqlDbType.Int, 4, "Num_Pago"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoEnLetras", System.Data.SqlDbType.VarChar, 250, "MontoEnLetras"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaCobro", System.Data.SqlDbType.DateTime, 8, "FechaCobro"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DeducirxPago", System.Data.SqlDbType.Float, 8, "DeducirxPago"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 50, "Usuario"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 8, "Saldo"))
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE Adelantos SET Identificacion = @Identificacion, Nombre = @Nombre, Adelanto" & _
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
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Adelanto", System.Data.SqlDbType.Bit, 1, "Adelanto"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Prestamo", System.Data.SqlDbType.Bit, 1, "Prestamo"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaComprobante", System.Data.SqlDbType.DateTime, 8, "FechaComprobante"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Pago", System.Data.SqlDbType.Int, 4, "Num_Pago"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoEnLetras", System.Data.SqlDbType.VarChar, 250, "MontoEnLetras"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaCobro", System.Data.SqlDbType.DateTime, 8, "FechaCobro"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DeducirxPago", System.Data.SqlDbType.Float, 8, "DeducirxPago"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 50, "Usuario"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 8, "Saldo"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Adelanto", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adelanto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DeducirxPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeducirxPago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaCobro", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaCobro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaComprobante", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaComprobante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoEnLetras", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnLetras", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Pago", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Pago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Prestamo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prestamo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero"))
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM Adelantos WHERE (Numero = @Original_Numero) AND (Adelanto = @Original" & _
        "_Adelanto) AND (Anulado = @Original_Anulado) AND (Cod_Moneda = @Original_Cod_Mon" & _
        "eda) AND (DeducirxPago = @Original_DeducirxPago) AND (FechaCobro = @Original_Fec" & _
        "haCobro) AND (FechaComprobante = @Original_FechaComprobante) AND (Identificacion" & _
        " = @Original_Identificacion) AND (Monto = @Original_Monto) AND (MontoEnLetras = " & _
        "@Original_MontoEnLetras) AND (Nombre = @Original_Nombre) AND (NombreUsuario = @O" & _
        "riginal_NombreUsuario) AND (Num_Pago = @Original_Num_Pago) AND (Observaciones = " & _
        "@Original_Observaciones) AND (Prestamo = @Original_Prestamo) AND (Puesto = @Orig" & _
        "inal_Puesto) AND (Salario = @Original_Salario) AND (Saldo = @Original_Saldo OR @" & _
        "Original_Saldo IS NULL AND Saldo IS NULL) AND (Usuario = @Original_Usuario)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Adelanto", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adelanto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DeducirxPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeducirxPago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaCobro", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaCobro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaComprobante", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaComprobante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoEnLetras", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnLetras", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Pago", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Pago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Prestamo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prestamo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdAdelantos
        '
        Me.AdAdelantos.DeleteCommand = Me.SqlDeleteCommand5
        Me.AdAdelantos.InsertCommand = Me.SqlInsertCommand5
        Me.AdAdelantos.SelectCommand = Me.SqlSelectCommand5
        Me.AdAdelantos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Adelantos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Adelanto", "Adelanto"), New System.Data.Common.DataColumnMapping("Prestamo", "Prestamo"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("FechaComprobante", "FechaComprobante"), New System.Data.Common.DataColumnMapping("Num_Pago", "Num_Pago"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("MontoEnLetras", "MontoEnLetras"), New System.Data.Common.DataColumnMapping("FechaCobro", "FechaCobro"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("DeducirxPago", "DeducirxPago"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo")})})
        Me.AdAdelantos.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Num_Accion, Id_Empleado, Nombre_Empleado, Puesto, Id_Accion, Fecha, Observ" & _
        "aciones, RigeDesde, RigeHasta, DiasaDescontar, HechoPor, NombreUsuario, Anula FR" & _
        "OM AccionPersonal"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO AccionPersonal(Num_Accion, Id_Empleado, Nombre_Empleado, Puesto, Id_A" & _
        "ccion, Fecha, Observaciones, RigeDesde, RigeHasta, DiasaDescontar, HechoPor, Nom" & _
        "breUsuario, Anula) VALUES (@Num_Accion, @Id_Empleado, @Nombre_Empleado, @Puesto," & _
        " @Id_Accion, @Fecha, @Observaciones, @RigeDesde, @RigeHasta, @DiasaDescontar, @H" & _
        "echoPor, @NombreUsuario, @Anula); SELECT Num_Accion, Id_Empleado, Nombre_Emplead" & _
        "o, Puesto, Id_Accion, Fecha, Observaciones, RigeDesde, RigeHasta, DiasaDescontar" & _
        ", HechoPor, NombreUsuario, Anula FROM AccionPersonal WHERE (Num_Accion = @Num_Ac" & _
        "cion)"
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Accion", System.Data.SqlDbType.BigInt, 8, "Num_Accion"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 250, "Id_Empleado"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, "Nombre_Empleado"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 4, "Id_Accion"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeDesde", System.Data.SqlDbType.DateTime, 8, "RigeDesde"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeHasta", System.Data.SqlDbType.DateTime, 8, "RigeHasta"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Float, 8, "DiasaDescontar"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HechoPor", System.Data.SqlDbType.VarChar, 75, "HechoPor"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"))
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "UPDATE AccionPersonal SET Num_Accion = @Num_Accion, Id_Empleado = @Id_Empleado, N" & _
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
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Accion", System.Data.SqlDbType.BigInt, 8, "Num_Accion"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 250, "Id_Empleado"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, "Nombre_Empleado"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 4, "Id_Accion"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeDesde", System.Data.SqlDbType.DateTime, 8, "RigeDesde"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeHasta", System.Data.SqlDbType.DateTime, 8, "RigeHasta"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Float, 8, "DiasaDescontar"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HechoPor", System.Data.SqlDbType.VarChar, 75, "HechoPor"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiasaDescontar", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiasaDescontar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HechoPor", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HechoPor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Accion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeDesde", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeDesde", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeHasta", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeHasta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM AccionPersonal WHERE (Num_Accion = @Original_Num_Accion) AND (Anula =" & _
        " @Original_Anula) AND (DiasaDescontar = @Original_DiasaDescontar) AND (Fecha = @" & _
        "Original_Fecha) AND (HechoPor = @Original_HechoPor) AND (Id_Accion = @Original_I" & _
        "d_Accion) AND (Id_Empleado = @Original_Id_Empleado) AND (NombreUsuario = @Origin" & _
        "al_NombreUsuario) AND (Nombre_Empleado = @Original_Nombre_Empleado) AND (Observa" & _
        "ciones = @Original_Observaciones) AND (Puesto = @Original_Puesto) AND (RigeDesde" & _
        " = @Original_RigeDesde) AND (RigeHasta = @Original_RigeHasta)"
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiasaDescontar", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiasaDescontar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HechoPor", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HechoPor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Accion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeDesde", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeDesde", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeHasta", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeHasta", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdAccion
        '
        Me.AdAccion.DeleteCommand = Me.SqlDeleteCommand6
        Me.AdAccion.InsertCommand = Me.SqlInsertCommand6
        Me.AdAccion.SelectCommand = Me.SqlSelectCommand6
        Me.AdAccion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AccionPersonal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Num_Accion", "Num_Accion"), New System.Data.Common.DataColumnMapping("Id_Empleado", "Id_Empleado"), New System.Data.Common.DataColumnMapping("Nombre_Empleado", "Nombre_Empleado"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Id_Accion", "Id_Accion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("RigeDesde", "RigeDesde"), New System.Data.Common.DataColumnMapping("RigeHasta", "RigeHasta"), New System.Data.Common.DataColumnMapping("DiasaDescontar", "DiasaDescontar"), New System.Data.Common.DataColumnMapping("HechoPor", "HechoPor"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("Anula", "Anula")})})
        Me.AdAccion.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo) VAL" & _
        "UES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simbolo); SELECT Cod" & _
        "Moneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda WHERE (CodMon" & _
        "eda = @CodMoneda)"
        Me.SqlInsertCommand7.Connection = Me.SqlConnection1
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = "UPDATE Moneda SET CodMoneda = @CodMoneda, MonedaNombre = @MonedaNombre, ValorComp" & _
        "ra = @ValorCompra, ValorVenta = @ValorVenta, Simbolo = @Simbolo WHERE (CodMoneda" & _
        " = @Original_CodMoneda) AND (MonedaNombre = @Original_MonedaNombre) AND (Simbolo" & _
        " = @Original_Simbolo) AND (ValorCompra = @Original_ValorCompra) AND (ValorVenta " & _
        "= @Original_ValorVenta); SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta" & _
        ", Simbolo FROM Moneda WHERE (CodMoneda = @CodMoneda)"
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = "DELETE FROM Moneda WHERE (CodMoneda = @Original_CodMoneda) AND (MonedaNombre = @O" & _
        "riginal_MonedaNombre) AND (Simbolo = @Original_Simbolo) AND (ValorCompra = @Orig" & _
        "inal_ValorCompra) AND (ValorVenta = @Original_ValorVenta)"
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdMoneda
        '
        Me.AdMoneda.DeleteCommand = Me.SqlDeleteCommand7
        Me.AdMoneda.InsertCommand = Me.SqlInsertCommand7
        Me.AdMoneda.SelectCommand = Me.SqlSelectCommand7
        Me.AdMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.AdMoneda.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT Id, Identificacion, Codigo, Descripcion, Monto, Tipo, Cod_Moneda FROM Empl" & _
        "eado_Deducciones"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO Empleado_Deducciones(Identificacion, Codigo, Descripcion, Monto, Tipo" & _
        ", Cod_Moneda) VALUES (@Identificacion, @Codigo, @Descripcion, @Monto, @Tipo, @Co" & _
        "d_Moneda); SELECT Id, Identificacion, Codigo, Descripcion, Monto, Tipo, Cod_Mone" & _
        "da FROM Empleado_Deducciones WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand8.Connection = Me.SqlConnection1
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = "UPDATE Empleado_Deducciones SET Identificacion = @Identificacion, Codigo = @Codig" & _
        "o, Descripcion = @Descripcion, Monto = @Monto, Tipo = @Tipo, Cod_Moneda = @Cod_M" & _
        "oneda WHERE (Id = @Original_Id) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Cod" & _
        "igo = @Original_Codigo) AND (Descripcion = @Original_Descripcion) AND (Identific" & _
        "acion = @Original_Identificacion) AND (Monto = @Original_Monto) AND (Tipo = @Ori" & _
        "ginal_Tipo); SELECT Id, Identificacion, Codigo, Descripcion, Monto, Tipo, Cod_Mo" & _
        "neda FROM Empleado_Deducciones WHERE (Id = @Id)"
        Me.SqlUpdateCommand8.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = "DELETE FROM Empleado_Deducciones WHERE (Id = @Original_Id) AND (Cod_Moneda = @Ori" & _
        "ginal_Cod_Moneda) AND (Codigo = @Original_Codigo) AND (Descripcion = @Original_D" & _
        "escripcion) AND (Identificacion = @Original_Identificacion) AND (Monto = @Origin" & _
        "al_Monto) AND (Tipo = @Original_Tipo)"
        Me.SqlDeleteCommand8.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdEmpleado_Deducciones
        '
        Me.AdEmpleado_Deducciones.DeleteCommand = Me.SqlDeleteCommand8
        Me.AdEmpleado_Deducciones.InsertCommand = Me.SqlInsertCommand8
        Me.AdEmpleado_Deducciones.SelectCommand = Me.SqlSelectCommand8
        Me.AdEmpleado_Deducciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado_Deducciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        Me.AdEmpleado_Deducciones.UpdateCommand = Me.SqlUpdateCommand8
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT Id, MontoExento, MontoDe, MontoHasta, Porcentaje1, MontoEnAdelante, Porcen" & _
        "taje2, Esposa, Hijo FROM ParametroRenta"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand9
        '
        Me.SqlInsertCommand9.CommandText = "INSERT INTO ParametroRenta(MontoExento, MontoDe, MontoHasta, Porcentaje1, MontoEn" & _
        "Adelante, Porcentaje2, Esposa, Hijo) VALUES (@MontoExento, @MontoDe, @MontoHasta" & _
        ", @Porcentaje1, @MontoEnAdelante, @Porcentaje2, @Esposa, @Hijo); SELECT Id, Mont" & _
        "oExento, MontoDe, MontoHasta, Porcentaje1, MontoEnAdelante, Porcentaje2, Esposa," & _
        " Hijo FROM ParametroRenta WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand9.Connection = Me.SqlConnection1
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoExento", System.Data.SqlDbType.Float, 8, "MontoExento"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoDe", System.Data.SqlDbType.Float, 8, "MontoDe"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoHasta", System.Data.SqlDbType.Float, 8, "MontoHasta"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porcentaje1", System.Data.SqlDbType.Float, 8, "Porcentaje1"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoEnAdelante", System.Data.SqlDbType.Float, 8, "MontoEnAdelante"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porcentaje2", System.Data.SqlDbType.Float, 8, "Porcentaje2"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Esposa", System.Data.SqlDbType.Float, 8, "Esposa"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijo", System.Data.SqlDbType.Float, 8, "Hijo"))
        '
        'SqlUpdateCommand9
        '
        Me.SqlUpdateCommand9.CommandText = "UPDATE ParametroRenta SET MontoExento = @MontoExento, MontoDe = @MontoDe, MontoHa" & _
        "sta = @MontoHasta, Porcentaje1 = @Porcentaje1, MontoEnAdelante = @MontoEnAdelant" & _
        "e, Porcentaje2 = @Porcentaje2, Esposa = @Esposa, Hijo = @Hijo WHERE (Id = @Origi" & _
        "nal_Id) AND (Esposa = @Original_Esposa) AND (Hijo = @Original_Hijo) AND (MontoDe" & _
        " = @Original_MontoDe) AND (MontoEnAdelante = @Original_MontoEnAdelante) AND (Mon" & _
        "toExento = @Original_MontoExento) AND (MontoHasta = @Original_MontoHasta) AND (P" & _
        "orcentaje1 = @Original_Porcentaje1) AND (Porcentaje2 = @Original_Porcentaje2); S" & _
        "ELECT Id, MontoExento, MontoDe, MontoHasta, Porcentaje1, MontoEnAdelante, Porcen" & _
        "taje2, Esposa, Hijo FROM ParametroRenta WHERE (Id = @Id)"
        Me.SqlUpdateCommand9.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoExento", System.Data.SqlDbType.Float, 8, "MontoExento"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoDe", System.Data.SqlDbType.Float, 8, "MontoDe"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoHasta", System.Data.SqlDbType.Float, 8, "MontoHasta"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porcentaje1", System.Data.SqlDbType.Float, 8, "Porcentaje1"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoEnAdelante", System.Data.SqlDbType.Float, 8, "MontoEnAdelante"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porcentaje2", System.Data.SqlDbType.Float, 8, "Porcentaje2"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Esposa", System.Data.SqlDbType.Float, 8, "Esposa"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijo", System.Data.SqlDbType.Float, 8, "Hijo"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Esposa", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Esposa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoDe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoDe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoEnAdelante", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnAdelante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoHasta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoHasta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porcentaje1", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porcentaje2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'SqlDeleteCommand9
        '
        Me.SqlDeleteCommand9.CommandText = "DELETE FROM ParametroRenta WHERE (Id = @Original_Id) AND (Esposa = @Original_Espo" & _
        "sa) AND (Hijo = @Original_Hijo) AND (MontoDe = @Original_MontoDe) AND (MontoEnAd" & _
        "elante = @Original_MontoEnAdelante) AND (MontoExento = @Original_MontoExento) AN" & _
        "D (MontoHasta = @Original_MontoHasta) AND (Porcentaje1 = @Original_Porcentaje1) " & _
        "AND (Porcentaje2 = @Original_Porcentaje2)"
        Me.SqlDeleteCommand9.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Esposa", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Esposa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoDe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoDe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoEnAdelante", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnAdelante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoHasta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoHasta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porcentaje1", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porcentaje2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje2", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdRenta
        '
        Me.AdRenta.DeleteCommand = Me.SqlDeleteCommand9
        Me.AdRenta.InsertCommand = Me.SqlInsertCommand9
        Me.AdRenta.SelectCommand = Me.SqlSelectCommand9
        Me.AdRenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ParametroRenta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("MontoExento", "MontoExento"), New System.Data.Common.DataColumnMapping("MontoDe", "MontoDe"), New System.Data.Common.DataColumnMapping("MontoHasta", "MontoHasta"), New System.Data.Common.DataColumnMapping("Porcentaje1", "Porcentaje1"), New System.Data.Common.DataColumnMapping("MontoEnAdelante", "MontoEnAdelante"), New System.Data.Common.DataColumnMapping("Porcentaje2", "Porcentaje2"), New System.Data.Common.DataColumnMapping("Esposa", "Esposa"), New System.Data.Common.DataColumnMapping("Hijo", "Hijo")})})
        Me.AdRenta.UpdateCommand = Me.SqlUpdateCommand9
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT Id_Detalle_AP, Id_Empleado, Numero, Tipo_Pago, Monto FROM Adelantos_Detall" & _
        "e"
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand10
        '
        Me.SqlInsertCommand10.CommandText = "INSERT INTO Adelantos_Detalle(Id_Empleado, Numero, Tipo_Pago, Monto) VALUES (@Id_" & _
        "Empleado, @Numero, @Tipo_Pago, @Monto); SELECT Id_Detalle_AP, Id_Empleado, Numer" & _
        "o, Tipo_Pago, Monto FROM Adelantos_Detalle WHERE (Id_Detalle_AP = @@IDENTITY)"
        Me.SqlInsertCommand10.Connection = Me.SqlConnection1
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 50, "Id_Empleado"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Pago", System.Data.SqlDbType.Bit, 1, "Tipo_Pago"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        '
        'SqlUpdateCommand10
        '
        Me.SqlUpdateCommand10.CommandText = "UPDATE Adelantos_Detalle SET Id_Empleado = @Id_Empleado, Numero = @Numero, Tipo_P" & _
        "ago = @Tipo_Pago, Monto = @Monto WHERE (Id_Detalle_AP = @Original_Id_Detalle_AP)" & _
        " AND (Id_Empleado = @Original_Id_Empleado) AND (Monto = @Original_Monto) AND (Nu" & _
        "mero = @Original_Numero) AND (Tipo_Pago = @Original_Tipo_Pago); SELECT Id_Detall" & _
        "e_AP, Id_Empleado, Numero, Tipo_Pago, Monto FROM Adelantos_Detalle WHERE (Id_Det" & _
        "alle_AP = @Id_Detalle_AP)"
        Me.SqlUpdateCommand10.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 50, "Id_Empleado"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Pago", System.Data.SqlDbType.Bit, 1, "Tipo_Pago"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle_AP", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle_AP", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Pago", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Detalle_AP", System.Data.SqlDbType.Int, 4, "Id_Detalle_AP"))
        '
        'SqlDeleteCommand10
        '
        Me.SqlDeleteCommand10.CommandText = "DELETE FROM Adelantos_Detalle WHERE (Id_Detalle_AP = @Original_Id_Detalle_AP) AND" & _
        " (Id_Empleado = @Original_Id_Empleado) AND (Monto = @Original_Monto) AND (Numero" & _
        " = @Original_Numero) AND (Tipo_Pago = @Original_Tipo_Pago)"
        Me.SqlDeleteCommand10.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle_AP", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle_AP", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Pago", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdAdelantos_Detalle
        '
        Me.AdAdelantos_Detalle.DeleteCommand = Me.SqlDeleteCommand10
        Me.AdAdelantos_Detalle.InsertCommand = Me.SqlInsertCommand10
        Me.AdAdelantos_Detalle.SelectCommand = Me.SqlSelectCommand10
        Me.AdAdelantos_Detalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Adelantos_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Detalle_AP", "Id_Detalle_AP"), New System.Data.Common.DataColumnMapping("Id_Empleado", "Id_Empleado"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Tipo_Pago", "Tipo_Pago"), New System.Data.Common.DataColumnMapping("Monto", "Monto")})})
        Me.AdAdelantos_Detalle.UpdateCommand = Me.SqlUpdateCommand10
        '
        'AdEmpleado
        '
        Me.AdEmpleado.DeleteCommand = Me.SqlDeleteCommand11
        Me.AdEmpleado.InsertCommand = Me.SqlInsertCommand11
        Me.AdEmpleado.SelectCommand = Me.SqlSelectCommand11
        Me.AdEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Estado_Civil", "Estado_Civil"), New System.Data.Common.DataColumnMapping("Hijos", "Hijos"), New System.Data.Common.DataColumnMapping("Cod_Nacionalidad", "Cod_Nacionalidad"), New System.Data.Common.DataColumnMapping("Fecha_Nacimiento", "Fecha_Nacimiento"), New System.Data.Common.DataColumnMapping("Edad", "Edad"), New System.Data.Common.DataColumnMapping("Telefono1", "Telefono1"), New System.Data.Common.DataColumnMapping("Telefono2", "Telefono2"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Fecha_Ingreso", "Fecha_Ingreso"), New System.Data.Common.DataColumnMapping("Fecha_Salida", "Fecha_Salida"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("Cod_Departamento", "Cod_Departamento"), New System.Data.Common.DataColumnMapping("Masculino", "Masculino"), New System.Data.Common.DataColumnMapping("Femenino", "Femenino"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Hora", "Hora"), New System.Data.Common.DataColumnMapping("Diario", "Diario"), New System.Data.Common.DataColumnMapping("Semana", "Semana"), New System.Data.Common.DataColumnMapping("Quincena", "Quincena"), New System.Data.Common.DataColumnMapping("Mensual", "Mensual"), New System.Data.Common.DataColumnMapping("Cod_Estado", "Cod_Estado"), New System.Data.Common.DataColumnMapping("Foto", "Foto"), New System.Data.Common.DataColumnMapping("CuentaBancaria", "CuentaBancaria")})})
        Me.AdEmpleado.UpdateCommand = Me.SqlUpdateCommand11
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT Identificacion, Nombre, Estado_Civil, Hijos, Cod_Nacionalidad, Fecha_Nacim" & _
        "iento, Edad, Telefono1, Telefono2, Email, Direccion, Puesto, Fecha_Ingreso, Fech" & _
        "a_Salida, Salario, Cod_Departamento, Masculino, Femenino, Cod_Moneda, Hora, Diar" & _
        "io, Semana, Quincena, Mensual, Cod_Estado, Foto, CuentaBancaria FROM Empleado"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand11
        '
        Me.SqlInsertCommand11.CommandText = "INSERT INTO Empleado(Identificacion, Nombre, Estado_Civil, Hijos, Cod_Nacionalida" & _
        "d, Fecha_Nacimiento, Edad, Telefono1, Telefono2, Email, Direccion, Puesto, Fecha" & _
        "_Ingreso, Fecha_Salida, Salario, Cod_Departamento, Masculino, Femenino, Cod_Mone" & _
        "da, Hora, Diario, Semana, Quincena, Mensual, Cod_Estado, Foto, CuentaBancaria) V" & _
        "ALUES (@Identificacion, @Nombre, @Estado_Civil, @Hijos, @Cod_Nacionalidad, @Fech" & _
        "a_Nacimiento, @Edad, @Telefono1, @Telefono2, @Email, @Direccion, @Puesto, @Fecha" & _
        "_Ingreso, @Fecha_Salida, @Salario, @Cod_Departamento, @Masculino, @Femenino, @Co" & _
        "d_Moneda, @Hora, @Diario, @Semana, @Quincena, @Mensual, @Cod_Estado, @Foto, @Cue" & _
        "ntaBancaria); SELECT Identificacion, Nombre, Estado_Civil, Hijos, Cod_Nacionalid" & _
        "ad, Fecha_Nacimiento, Edad, Telefono1, Telefono2, Email, Direccion, Puesto, Fech" & _
        "a_Ingreso, Fecha_Salida, Salario, Cod_Departamento, Masculino, Femenino, Cod_Mon" & _
        "eda, Hora, Diario, Semana, Quincena, Mensual, Cod_Estado, Foto, CuentaBancaria F" & _
        "ROM Empleado WHERE (Identificacion = @Identificacion)"
        Me.SqlInsertCommand11.Connection = Me.SqlConnection1
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 50, "Estado_Civil"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 4, "Hijos"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, "Cod_Nacionalidad"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, "Fecha_Nacimiento"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 50, "Telefono1"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 50, "Telefono2"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 100, "Puesto"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 4, "Cod_Departamento"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 1, "Masculino"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 1, "Femenino"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        Me.SqlInsertCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaBancaria", System.Data.SqlDbType.VarChar, 50, "CuentaBancaria"))
        '
        'SqlUpdateCommand11
        '
        Me.SqlUpdateCommand11.CommandText = "UPDATE Empleado SET Identificacion = @Identificacion, Nombre = @Nombre, Estado_Ci" & _
        "vil = @Estado_Civil, Hijos = @Hijos, Cod_Nacionalidad = @Cod_Nacionalidad, Fecha" & _
        "_Nacimiento = @Fecha_Nacimiento, Edad = @Edad, Telefono1 = @Telefono1, Telefono2" & _
        " = @Telefono2, Email = @Email, Direccion = @Direccion, Puesto = @Puesto, Fecha_I" & _
        "ngreso = @Fecha_Ingreso, Fecha_Salida = @Fecha_Salida, Salario = @Salario, Cod_D" & _
        "epartamento = @Cod_Departamento, Masculino = @Masculino, Femenino = @Femenino, C" & _
        "od_Moneda = @Cod_Moneda, Hora = @Hora, Diario = @Diario, Semana = @Semana, Quinc" & _
        "ena = @Quincena, Mensual = @Mensual, Cod_Estado = @Cod_Estado, Foto = @Foto, Cue" & _
        "ntaBancaria = @CuentaBancaria WHERE (Identificacion = @Original_Identificacion) " & _
        "AND (Cod_Departamento = @Original_Cod_Departamento) AND (Cod_Estado = @Original_" & _
        "Cod_Estado) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Cod_Nacionalidad = @Ori" & _
        "ginal_Cod_Nacionalidad) AND (CuentaBancaria = @Original_CuentaBancaria OR @Origi" & _
        "nal_CuentaBancaria IS NULL AND CuentaBancaria IS NULL) AND (Diario = @Original_D" & _
        "iario) AND (Direccion = @Original_Direccion) AND (Edad = @Original_Edad) AND (Em" & _
        "ail = @Original_Email) AND (Estado_Civil = @Original_Estado_Civil) AND (Fecha_In" & _
        "greso = @Original_Fecha_Ingreso) AND (Fecha_Nacimiento = @Original_Fecha_Nacimie" & _
        "nto) AND (Fecha_Salida = @Original_Fecha_Salida) AND (Femenino = @Original_Femen" & _
        "ino) AND (Hijos = @Original_Hijos) AND (Hora = @Original_Hora) AND (Masculino = " & _
        "@Original_Masculino) AND (Mensual = @Original_Mensual) AND (Nombre = @Original_N" & _
        "ombre) AND (Puesto = @Original_Puesto) AND (Quincena = @Original_Quincena) AND (" & _
        "Salario = @Original_Salario) AND (Semana = @Original_Semana) AND (Telefono1 = @O" & _
        "riginal_Telefono1) AND (Telefono2 = @Original_Telefono2); SELECT Identificacion," & _
        " Nombre, Estado_Civil, Hijos, Cod_Nacionalidad, Fecha_Nacimiento, Edad, Telefono" & _
        "1, Telefono2, Email, Direccion, Puesto, Fecha_Ingreso, Fecha_Salida, Salario, Co" & _
        "d_Departamento, Masculino, Femenino, Cod_Moneda, Hora, Diario, Semana, Quincena," & _
        " Mensual, Cod_Estado, Foto, CuentaBancaria FROM Empleado WHERE (Identificacion =" & _
        " @Identificacion)"
        Me.SqlUpdateCommand11.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 50, "Estado_Civil"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 4, "Hijos"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, "Cod_Nacionalidad"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, "Fecha_Nacimiento"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 50, "Telefono1"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 50, "Telefono2"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 100, "Puesto"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 4, "Cod_Departamento"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 1, "Masculino"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 1, "Femenino"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaBancaria", System.Data.SqlDbType.VarChar, 50, "CuentaBancaria"))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Departamento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Departamento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Nacionalidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaBancaria", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaBancaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Edad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Estado_Civil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado_Civil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nacimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Femenino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Femenino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Masculino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Masculino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand11
        '
        Me.SqlDeleteCommand11.CommandText = "DELETE FROM Empleado WHERE (Identificacion = @Original_Identificacion) AND (Cod_D" & _
        "epartamento = @Original_Cod_Departamento) AND (Cod_Estado = @Original_Cod_Estado" & _
        ") AND (Cod_Moneda = @Original_Cod_Moneda) AND (Cod_Nacionalidad = @Original_Cod_" & _
        "Nacionalidad) AND (CuentaBancaria = @Original_CuentaBancaria OR @Original_Cuenta" & _
        "Bancaria IS NULL AND CuentaBancaria IS NULL) AND (Diario = @Original_Diario) AND" & _
        " (Direccion = @Original_Direccion) AND (Edad = @Original_Edad) AND (Email = @Ori" & _
        "ginal_Email) AND (Estado_Civil = @Original_Estado_Civil) AND (Fecha_Ingreso = @O" & _
        "riginal_Fecha_Ingreso) AND (Fecha_Nacimiento = @Original_Fecha_Nacimiento) AND (" & _
        "Fecha_Salida = @Original_Fecha_Salida) AND (Femenino = @Original_Femenino) AND (" & _
        "Hijos = @Original_Hijos) AND (Hora = @Original_Hora) AND (Masculino = @Original_" & _
        "Masculino) AND (Mensual = @Original_Mensual) AND (Nombre = @Original_Nombre) AND" & _
        " (Puesto = @Original_Puesto) AND (Quincena = @Original_Quincena) AND (Salario = " & _
        "@Original_Salario) AND (Semana = @Original_Semana) AND (Telefono1 = @Original_Te" & _
        "lefono1) AND (Telefono2 = @Original_Telefono2)"
        Me.SqlDeleteCommand11.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Departamento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Departamento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Nacionalidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaBancaria", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaBancaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Edad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Estado_Civil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado_Civil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nacimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Femenino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Femenino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Masculino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Masculino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand11.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing))
        '
        'frmModificaPlanilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(778, 239)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmModificaPlanilla"
        Me.Text = "MODIFICAR PLANILLA"
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsModificaPlanilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmModificaPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        Me.AdDeducciones.Fill(Me.DsModificaPlanilla1.Deducciones)
        Me.AdAdelantos.Fill(Me.DsModificaPlanilla1.Adelantos)
        Me.AdAccion.Fill(Me.DsModificaPlanilla1.AccionPersonal)
        Me.adMoneda.Fill(Me.DsModificaPlanilla1.Moneda)
        Me.AdPlanilla.Fill(Me.DsModificaPlanilla1.Planilla)
        Me.AdEmpleado_Deducciones.Fill(Me.DsModificaPlanilla1.Empleado_Deducciones)
        Me.AdRenta.Fill(Me.DsModificaPlanilla1.ParametroRenta)
        Me.AdAdelantos_Detalle.Fill(Me.DsModificaPlanilla1.Adelantos_Detalle)
        Me.AdEmpleado.Fill(Me.DsModificaPlanilla1.Empleado)


        CrearTabla()
        GridControl1.DataSource = TablaModifica

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

    End Function

    Function CrearTabla()
        Dim i As Int16
        Dim j As Int16
        Me.TablaModifica.Clear()
        Me.TablaModifica.Columns.Clear()
        Me.CrearColumnas("Cedula", "Cédula", 150, 1, "Cedula", False, False, False)
        Me.TablaModifica.Columns.Add(New DataColumn("Cedula", GetType(String)))
        Me.CrearColumnas("Nombre", "Nombre del Empleado", 350, 2, "Nombre", False, False, False)
        Me.TablaModifica.Columns.Add(New DataColumn("Nombre", GetType(String)))

        Me.CrearColumnas("Moneda", "Moneda", 75, 3, "Moneda", False, False, False)
        Me.TablaModifica.Columns.Add(New DataColumn("Moneda", GetType(String)))

        Me.CrearColumnas("Salario", "Salario", 100, 4, "Salario", True, False, False)
        Me.TablaModifica.Columns.Add(New DataColumn("Salario", GetType(Double)))
        Me.CrearColumnas("Forma", "Forma Pago", 100, 5, "FormaPago", False, False, False)
        Me.TablaModifica.Columns.Add(New DataColumn("FormaPago", GetType(String)))

        Me.CrearColumnas("DíasDescontar", "DíasDescontar", 75, 6, "DíasDescontar", True, False, False)
        Me.TablaModifica.Columns.Add(New DataColumn("DíasDescontar", GetType(Double)))

        Me.CrearColumnas("Ordinarias", "H. Ordinarias", 125, 7, "Ordinarias", True, True, True)
        Me.TablaModifica.Columns.Add(New DataColumn("Ordinarias", GetType(Double)))
        Me.CrearColumnas("Extras", "H. Extras", 100, 8, "Extras", True, True, True)
        Me.TablaModifica.Columns.Add(New DataColumn("Extras", GetType(Double)))
        Me.CrearColumnas("Dobles", "H. Dobles", 100, 9, "Dobles", True, True, True)
        Me.TablaModifica.Columns.Add(New DataColumn("Dobles", GetType(Double)))
        Me.CrearColumnas("SalarioBruta", "Salario Bruto", 150, 10, "SalarioBruto", True, False, False)
        Me.TablaModifica.Columns.Add(New DataColumn("SalarioBruto", GetType(Double)))
        j = 11
        For i = 0 To Me.DsModificaPlanilla1.Deducciones.Rows.Count - 1
            Me.CrearColumnas(Me.DsModificaPlanilla1.Deducciones.Rows(i).Item("Descripcion").ToString, Me.DsModificaPlanilla1.Deducciones.Rows(i).Item("Descripcion"), 125, j, Me.DsModificaPlanilla1.Deducciones.Rows(i).Item("Descripcion").ToString, True, False, False)
            j = j + 1
            Me.TablaModifica.Columns.Add(New DataColumn(Me.DsModificaPlanilla1.Deducciones.Rows(i).Item("Descripcion").ToString, GetType(Double)))
        Next
        Me.CrearColumnas("Adelantos", "Adelantos", 100, j, "Adelantos", True, False, False) : j = j + 1
        Me.TablaModifica.Columns.Add(New DataColumn("Adelantos", GetType(Double)))
        Me.CrearColumnas("Préstamos", "Préstamos", 125, j, "Prestamos", True, False, False) : j = j + 1 'cambio
        Me.TablaModifica.Columns.Add(New DataColumn("Prestamos", GetType(Double)))

        Me.CrearColumnas("Saldo", "Saldo Prestamos", 150, j, "Saldo", True, False, False) : j = j + 1 'modi
        Me.TablaModifica.Columns.Add(New DataColumn("Saldo", GetType(Double))) 'modi

        Me.CrearColumnas("Renta", "Renta", 100, j, "Renta", True, False, False) : j = j + 1
        Me.TablaModifica.Columns.Add(New DataColumn("Renta", GetType(Double)))
        Me.CrearColumnas("TotalDeducciones", "Total Deducciones", 175, j, "TotalDeducciones", True, False, False) : j = j + 1
        Me.TablaModifica.Columns.Add(New DataColumn("TotalDeducciones", GetType(Double)))
        Me.CrearColumnas("SalarioNeto", "Salario Neto", 150, j, "SalarioNeto", True, False, False)
        Me.TablaModifica.Columns.Add(New DataColumn("SalarioNeto", GetType(Double)))

    End Function

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1

            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : If PMU.Update Then Editar() Else MsgBox("No tiene permiso para Editar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 4 : If PMU.Update Then registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub


            Case 7 : If MessageBox.Show("¿Desea Cerrar el Módulo de Planilla?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Me.Close()
                End If
        End Select
    End Sub

    Private Sub Buscar()
        Try
            Dim cnnConexion As New SqlConnection
            Dim Fx As New cFunciones
            Dim pos As Integer
            Dim vista As DataView
            cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")

            Id = Fx.BuscarDatosModificaPlanilla("Select Id_Planilla, Nombre from Planilla_Detalle", "Nombre", " ORDER BY Id_Planilla DESC,Nombre", "Buscar Planilla...", cnnConexion.ConnectionString)

            If Id = "" Or Id = "0" Then
                Exit Sub
            Else
                IdPlanilla1 = Id
                Cedula = Fx.descripcion
                Me.LlenarPlanilla(Id, Cedula)
                Me.ToolBar1.Buttons(4).Enabled = True
                Me.ToolBar1.Buttons(5).Enabled = True
                Me.ToolBar1.Buttons(3).Enabled = False
            End If
            Me.GridControl1.Enabled = False

        Catch ex As SystemException

            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Editar()
        Me.GridControl1.Enabled = True
        Me.ToolBar1.Buttons(3).Enabled = True
    End Sub

    Function LlenarPlanilla(ByVal Id As String, ByVal cedula As String)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim x As Integer
        Dim saldoA
        Dim cConexion As New Conexion

        Me.TablaModifica.Clear()
        Try

            Me.AdPlanilla.Fill(Me.DsModificaPlanilla1.Planilla)
            Me.AdPlanillaDetalle.Fill(Me.DsModificaPlanilla1, "Planilla_Detalle")
            Me.AdPlanillaDeducciones.Fill(Me.DsModificaPlanilla1, "Planilla_Deducciones")

            Dim i, J As Integer
            Dim dr As DataRow
            Dim Descripcion1, Descripcion As String
            dr = Me.TablaModifica.NewRow

            For i = 0 To Me.DsModificaPlanilla1.Planilla_Detalle.Rows.Count - 1
                '                If Id = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Id_Planilla") And cedula = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Cedula") Then
                If Id = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Id_Planilla") And cedula = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Nombre") Then
                    dr = Me.TablaModifica.NewRow
                    dr("Cedula") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Cedula")
                    dr("Nombre") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Nombre")

                    If Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Cod_Moneda") = 1 Then
                        dr("Moneda") = "COLON"
                    End If
                    If Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Cod_Moneda") = 2 Then
                        dr("Moneda") = "DOLAR"
                    End If
                    If Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Cod_Moneda") = 3 Then
                        dr("Moneda") = "EUROS"
                    End If
                    dr("Salario") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Salario")
                    dr("FormaPago") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("FormaPago")
                    dr("Ordinarias") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Ordinaria")
                    dr("Extras") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Extra")
                    dr("Dobles") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Doble")
                    dr("SalarioBruto") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("SalarioBruto")
                    dr("Adelantos") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Adelantos")
                    dr("Prestamos") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Prestamos")
                    dr("Renta") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Renta")
                    dr("TotalDeducciones") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("TotalDeducciones")
                    dr("SalarioNeto") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("SalarioNeto")

                    For J = 0 To Me.DsModificaPlanilla1.Adelantos.Rows.Count - 1
                        If Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Cedula") = Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Identificacion") Then
                            saldoA = saldoA + Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Saldo")
                        End If
                    Next
                    If saldoA = Nothing Then
                        dr("Saldo") = 0
                    Else
                        dr("Saldo") = saldoA
                    End If
                    saldoA = 0
                    dr("DíasDescontar") = 0
                    For J = 0 To Me.DsModificaPlanilla1.Planilla_Deducciones.Rows.Count - 1
                        If Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Id") = Me.DsModificaPlanilla1.Planilla_Deducciones.Rows(J).Item("Id_PlanillaDetalle") Then
                            Descripcion1 = Me.DsModificaPlanilla1.Planilla_Deducciones.Rows(J).Item("Nombre").ToString
                            dr(Descripcion1) = Me.DsModificaPlanilla1.Planilla_Deducciones.Rows(J).Item("Monto")
                        End If
                    Next
                    Me.TablaModifica.Rows.Add(dr)
                End If

                For J = 0 To Me.DsModificaPlanilla1.AccionPersonal.Rows.Count - 1
                    Dim n, Mes1, Mes2 As Integer
                    Dim Cuenta As String
                    Dim FechaSalida, FechaEntrada As DateTime

                    If Me.DsModificaPlanilla1.AccionPersonal.Rows(J).Item("Id_Empleado") = Me.DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Cedula") Then
                        FechaSalida = Now
                        FechaEntrada = Me.DsModificaPlanilla1.AccionPersonal.Rows(J).Item("RigeDesde")
                        Mes1 = FechaSalida.Month
                        Mes2 = FechaEntrada.Month
                        If Mes1 = Mes2 Then
                            dr("DíasDescontar") = Me.DsModificaPlanilla1.AccionPersonal.Rows(J).Item("DiasaDescontar")
                        End If
                    End If
                Next
            Next
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally

            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function

    Private Sub GridControl1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.Recalcular_Fila_Saldo(Me.BindingContext(Me.TablaModifica).Position())
        End If
    End Sub

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

        For J = 0 To Me.DsModificaPlanilla1.Planilla.Rows.Count - 1
            If Me.DsModificaPlanilla1.Planilla.Rows(J).Item("Id_Planilla") = Id Then
                FechaI = Me.DsModificaPlanilla1.Planilla.Rows(J).Item("FechaInicial")
                FechaF = Me.DsModificaPlanilla1.Planilla.Rows(J).Item("FechaFinal")
                cierre = Me.DsModificaPlanilla1.Planilla.Rows(J).Item("CierreMes")
            End If

        Next
        If x >= 0 Then
            Try
                dr = Me.TablaModifica.NewRow
                Me.BindingContext(Me.TablaModifica).EndCurrentEdit()
                Ordinarias = TablaModifica.Rows(x).Item("Ordinarias")
                Extras = TablaModifica.Rows(x).Item("Extras")
                Dobles = TablaModifica.Rows(x).Item("Dobles")
                Salario = TablaModifica.Rows(x).Item("Salario")

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Select Case TablaModifica.Rows(x).Item("FormaPago")
                    Case "HORA" : TablaModifica.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salario) + ((Extras * 1.5) * Salario) + (Salario * (2 * Dobles)))
                        DiasDescontados2 = DiasDescontados1 * (Salario * 8)
                        DeduccionHO = (Ordinarias * Salario)
                    Case "DIARIO"
                        Salarios = (Salario / 8)
                        DiasDescontados2 = DiasDescontados1 * Salario
                        TablaModifica.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                    Case "SEMANAL"
                        Salarios = (Salario / 48)
                        DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                        TablaModifica.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                    Case "QUINCENAL"
                        Salarios = (Salario / 96)
                        DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                        TablaModifica.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                    Case "MENSUAL"
                        Salarios = (Salario / 192)
                        DiasDescontados2 = DiasDescontados1 * (Salarios * 8)
                        TablaModifica.Rows(x).Item("SalarioBruto") = ((Ordinarias * Salarios) + ((Extras * 1.5) * Salarios) + (Salarios * (2 * Dobles)))
                End Select
                SalarioBruto = TablaModifica.Rows(x).Item("SalarioBruto")
                'SalarioBruto = SalarioBruto - DiasDescontados2

                For J = 0 To Me.DsModificaPlanilla1.Empleado_Deducciones.Rows.Count - 1
                    If TablaModifica.Rows(x).Item("Cedula") = Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(J).Item("Identificacion") Then
                        Tipo = Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(J).Item("Tipo")
                        'If Descripcion <> Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(i).Item("Descripcion") Then
                        Select Case Tipo
                            Case "V"
                                'Total = Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(J).Item("Monto")

                                'If TablaModifica.Rows(x).Item("Moneda") = "DOLAR" Then
                                '    If Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(J).Item("Cod_Moneda") = 1 Then
                                '        Total = Total / Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                '    End If
                                'Else
                                '    If Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(J).Item("Cod_Moneda") = 2 Then
                                '        Total = Total * Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra")
                                '    End If
                                'End If

                                'TablaModifica.Rows(x).Item(Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion").ToString) = Total
                                'TotalDeducciones = TotalDeducciones + Total
                            Case "%"
                                Monto = Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(J).Item("Monto")
                                Deduccion = ((Monto / 100) * TablaModifica.Rows(x).Item("SalarioBruto"))
                                TablaModifica.Rows(x).Item(Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion").ToString) = Deduccion
                                TotalDeducciones = TotalDeducciones + Deduccion
                        End Select
                        Descripcion = Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(J).Item("Descripcion")
                        ' End If
                    End If
                Next

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                For J = 0 To Me.DsModificaPlanilla1.Adelantos.Rows.Count - 1

                    If TablaModifica.Rows(x).Item("Cedula") = Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Identificacion") Then
                        If Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Anulado") = False Then

                            If Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Adelanto") Then  'cambio =true

                                Dim fecha As Date
                                fecha = Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("FechaCobro")

                                If FechaI.Date <= fecha.Date And FechaF.Date >= fecha.Date Then
                                    Adelanto = Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Monto") 'TablaModifica.Rows(x).Item("Adelantos") Cambios

                                    If TablaModifica.Rows(x).Item("Moneda") = "DOLAR" Then
                                        If Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 1 Then
                                            saldos = Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Saldo") / Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio

                                        End If
                                    Else
                                        If Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 2 Then
                                            saldos = saldos * Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio

                                        End If
                                        saldos = Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                    End If


                                    saldo = saldo + saldos
                                    Adelantos = Adelanto + Adelantos

                                End If
                            End If
                            If Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Prestamo") = True Then

                                For h = 0 To Me.DsModificaPlanilla1.Adelantos_Detalle.Rows.Count - 1
                                    If Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Identificacion") = Me.DsModificaPlanilla1.Adelantos_Detalle.Rows(h).Item("Id_Empleado") And Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Numero") = Me.DsModificaPlanilla1.Adelantos_Detalle.Rows(h).Item("Numero") Then
                                        saldos = Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                        Prestamo = Me.DsModificaPlanilla1.Adelantos_Detalle.Rows(h).Item("Monto")

                                    End If
                                Next

                                If TablaModifica.Rows(x).Item("Moneda") = "DOLAR" Then
                                    If Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 1 Then
                                        saldos = Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Saldo") / Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra") 'cambio
                                    Else
                                        Prestamo = Prestamo
                                    End If
                                Else
                                    If Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Cod_Moneda") = 2 Then
                                        saldos = saldos * Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra")  'cambio

                                    End If
                                    saldos = Me.DsModificaPlanilla1.Adelantos.Rows(J).Item("Saldo")
                                End If
                                If Prestamo > saldos Then
                                    Prestamo = saldos
                                End If

                                saldo = saldo + saldos
                                Prestamos = Prestamos + Prestamo

                            End If
                        End If
                    End If

                Next

                TablaModifica.Rows(x).Item("Saldo") = 0
                TablaModifica.Rows(x).Item("Adelantos") = Adelantos
                TablaModifica.Rows(x).Item("Prestamos") = Prestamos
                TablaModifica.Rows(x).Item("Saldo") = saldo - Prestamos - Adelantos 'modi

                SalarioBruto = TablaModifica.Rows(x).Item("SalarioBruto")

                fijo = 9900
                MontoDe = Me.DsModificaPlanilla1.ParametroRenta.Rows(0).Item("MontoDe")
                MontoHasta = Me.DsModificaPlanilla1.ParametroRenta.Rows(0).Item("MontoHasta")
                MontoExento = Me.DsModificaPlanilla1.ParametroRenta.Rows(0).Item("MontoExento")
                MontoAdelante = Me.DsModificaPlanilla1.ParametroRenta.Rows(0).Item("MontoEnAdelante")
                Porcentaje1 = Me.DsModificaPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje1")
                Porcentaje2 = Me.DsModificaPlanilla1.ParametroRenta.Rows(0).Item("Porcentaje2")
                PHijo = Me.DsModificaPlanilla1.ParametroRenta.Rows(0).Item("Hijo")
                PEsposa = Me.DsModificaPlanilla1.ParametroRenta.Rows(0).Item("Esposa")
                For k = 0 To Me.DsModificaPlanilla1.Empleado.Rows.Count - 1
                    If Me.DsModificaPlanilla1.Empleado.Rows(k).Item("Identificacion") = TablaModifica.Rows(x).Item("Cedula") Then
                        Estado_Civil = Me.DsModificaPlanilla1.Empleado.Rows(k).Item("Estado_Civil")
                        Hijos = Me.DsModificaPlanilla1.Empleado.Rows(k).Item("Hijos")
                        Exit For
                    End If

                Next

                If TablaModifica.Rows(x).Item("Moneda") = "DOLAR" Then
                    MontoDe = MontoDe / Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra") '514
                    MontoHasta = MontoHasta / Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra") ' 514
                    MontoExento = MontoExento / Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra") '/ 514
                    fijo = fijo / Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra") ' cambio
                    MontoAdelante = MontoAdelante / Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra") '514
                    PHijo = PHijo / Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra") '514
                    PEsposa = PEsposa / Me.DsModificaPlanilla1.Moneda.Rows(1).Item("ValorCompra") '514
                End If
                Cedula = TablaModifica.Rows(x).Item("Nombre")
                If cierre = True Then
                    ParametroRenta()
                    SalarioBruto2 = SalarioBruto + Pagomes

                    If SalarioBruto2 <= MontoExento Then
                        TablaModifica.Rows(x).Item("Renta") = 0
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
                        TablaModifica.Rows(x).Item("Renta") = RentaTotal
                    End If
                Else
                    TablaModifica.Rows(x).Item("Renta") = 0
                End If
                'TotalDeducciones = TablaModifica.Rows(x).Item("C.C.S.S.") + TablaModifica.Rows(x).Item("ASOCIACION")

                TotalDeducciones = TotalDeducciones + RentaTotal + Adelantos + Prestamos '+ DiasDescontados2
                TablaModifica.Rows(x).Item("TotalDeducciones") = TotalDeducciones
                TablaModifica.Rows(x).Item("SalarioNeto") = SalarioBruto - TotalDeducciones
                Descripcion = ""
                TotalDeducciones = 0
                Deduccion = 0
                Pagomes = 0
                DiasDescontados = 0
                DiasDescontados1 = 0
                DiasDescontados2 = 0
                Aumento = 0

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If

    End Sub

    Function ParametroRenta()
        Dim funcion As New cFunciones
        Dim Id, n, Mes1, Mes2 As Integer
        Dim Cuenta As String
        Dim FechaSalida, FechaEntrada As DateTime
        funcion.Llenar_Tabla_Generico("Select * from Planilla", TablaRenta, Me.SqlConnection1.ConnectionString)
        For n = 0 To Me.TablaRenta.Rows.Count - 1
            FechaSalida = FechaI.Date
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

    Private Sub registrar()
        Dim i, n, k As Integer
        For i = 0 To Me.DsModificaPlanilla1.Planilla_Detalle.Rows.Count - 1
            'If Id = DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Id_Planilla") And DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Cedula") = Cedula Then
            If Id = DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Id_Planilla") And DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Nombre") = Cedula Then
                DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Ordinaria") = Me.TablaModifica.Rows(0).Item("Ordinarias")
                DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Extra") = Me.TablaModifica.Rows(0).Item("Extras")
                DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Doble") = Me.TablaModifica.Rows(0).Item("Dobles")
                DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("SalarioBruto") = Me.TablaModifica.Rows(0).Item("SalarioBruto")
                DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Adelantos") = Me.TablaModifica.Rows(0).Item("Adelantos")
                DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Prestamos") = Me.TablaModifica.Rows(0).Item("Prestamos")
                DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Renta") = Me.TablaModifica.Rows(0).Item("Renta")
                DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("TotalDeducciones") = Me.TablaModifica.Rows(0).Item("TotalDeducciones")
                DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("SalarioNeto") = Me.TablaModifica.Rows(0).Item("SalarioNeto")
                DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Modificado") = True
                Eliminar_Deducciones(DsModificaPlanilla1.Planilla_Detalle.Rows(i).Item("Id"))

                Registrar_Planilla()
                MsgBox("Datos Modificados Correctamente", MsgBoxStyle.Information)

                Exit Sub
            End If
        Next

    End Sub

    Function Eliminar_Deducciones(ByVal Id As Integer)
        Try

            Dim Cconexion As New Conexion
            Dim Resultado As String
            Dim Tipo As Char
            Dim j As Integer
            Dim Total, Monto, TotalDeducciones, Deduccion As Double

            Me.AdEmpleado_Deducciones.Fill(Me.DsModificaPlanilla1.Empleado_Deducciones)
            Me.AdMoneda.Fill(Me.DsModificaPlanilla1.Moneda)
         
            Resultado = Cconexion.SlqExecute(Cconexion.Conectar("Planilla"), "Delete from Planilla_Deducciones where Id_PlanillaDetalle='" & Id & "'")


            For j = 0 To Me.DsModificaPlanilla1.Empleado_Deducciones.Rows.Count - 1

                If TablaModifica.Rows(0).Item("Cedula") = Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(j).Item("Identificacion") Then

                    Me.BindingContext(Me.DsModificaPlanilla1.Planilla_Deducciones).EndCurrentEdit()
                    Me.BindingContext(Me.DsModificaPlanilla1.Planilla_Deducciones).AddNew()
                    Me.BindingContext(Me.DsModificaPlanilla1.Planilla_Deducciones).Current("Id_PlanillaDetalle") = Id
                    Me.BindingContext(Me.DsModificaPlanilla1.Planilla_Deducciones).Current("Cod_Deduccion") = Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(j).Item("Codigo")
                    Me.BindingContext(Me.DsModificaPlanilla1.Planilla_Deducciones).Current("nombre") = Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(j).Item("Descripcion")

                    Tipo = Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(j).Item("Tipo")
                    Select Case Tipo
                        Case "V"
                            Deduccion = Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(j).Item("Monto")
                        Case "%"
                            Monto = Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(j).Item("Monto")
                            Deduccion = ((Monto / 100) * TablaModifica.Rows(0).Item("SalarioBruto"))
                            TablaModifica.Rows(0).Item(Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(j).Item("Descripcion").ToString) = Deduccion
                    End Select

                    Me.BindingContext(Me.DsModificaPlanilla1.Planilla_Deducciones).Current("Monto") = Deduccion
                    Me.BindingContext(Me.DsModificaPlanilla1.Planilla_Deducciones).Current("Cod_Moneda") = Me.DsModificaPlanilla1.Empleado_Deducciones.Rows(j).Item("Cod_Moneda")
                    Me.BindingContext(Me.DsModificaPlanilla1.Planilla_Deducciones).EndCurrentEdit()


                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function Registrar_Planilla() As Boolean

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try

            Me.AdPlanillaDetalle.InsertCommand.Transaction = Trans
            Me.AdPlanillaDetalle.UpdateCommand.Transaction = Trans
            Me.AdPlanillaDetalle.DeleteCommand.Transaction = Trans
            Me.AdPlanillaDetalle.SelectCommand.Transaction = Trans
            AdPlanillaDetalle.Update(Me.DsModificaPlanilla1.Planilla_Detalle)

            Me.AdPlanillaDeducciones.InsertCommand.Transaction = Trans
            Me.AdPlanillaDeducciones.UpdateCommand.Transaction = Trans
            Me.AdPlanillaDeducciones.DeleteCommand.Transaction = Trans
            Me.AdPlanillaDeducciones.SelectCommand.Transaction = Trans
            AdPlanillaDeducciones.Update(Me.DsModificaPlanilla1.Planilla_Deducciones)

            Me.AdAdelantos_Detalle.InsertCommand.Transaction = Trans
            Me.AdAdelantos_Detalle.UpdateCommand.Transaction = Trans
            Me.AdAdelantos_Detalle.DeleteCommand.Transaction = Trans
            Me.AdAdelantos_Detalle.SelectCommand.Transaction = Trans
            AdAdelantos_Detalle.Update(Me.DsModificaPlanilla1.Adelantos_Detalle)

            Me.DsModificaPlanilla1.AcceptChanges() '''aqui
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

End Class
