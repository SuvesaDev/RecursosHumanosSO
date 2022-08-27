Imports System.data.sqlclient
Imports Utilidades

Public Class FrmEmpleado
    Inherits FrmPlantilla

#Region "Variables"
    Dim buscando, HORA_IND As Boolean
    Dim usua As Object
    Dim pos, HORAS_ORD As Integer
    Dim p As String
    Dim phuella, ptarjeta As String
    Protected WithEvents ImageList As System.Windows.Forms.ImageList
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.PictureEdit1.DataBindings.Add(New Binding("EditValue", Me.DsEmpleado1, "Empleado.Foto"))
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents TxtEdad As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtEMail As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CbNacionalidad As System.Windows.Forms.ComboBox
    Friend WithEvents CbEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents CbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CkMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents CkFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaNacionalidad As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TxtHijos As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CkMensual As System.Windows.Forms.RadioButton
    Friend WithEvents CkSemanal As System.Windows.Forms.RadioButton
    Friend WithEvents CkQuincena As System.Windows.Forms.RadioButton
    Friend WithEvents CkDiario As System.Windows.Forms.RadioButton
    Friend WithEvents Ckhora As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaDepartamento As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaDeducciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaAcademico As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaLicencia As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsEmpleado1 As Planilla.DsEmpleado
    Friend WithEvents txtSueldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolBar2 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents cbTipoDed As System.Windows.Forms.ComboBox
    Friend WithEvents txtMontoDeducion As DevExpress.XtraEditors.TextEdit
    '    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents GridDeducciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAño As System.Windows.Forms.TextBox
    Friend WithEvents txtNivel As System.Windows.Forms.TextBox
    Friend WithEvents txtInstitucion As System.Windows.Forms.TextBox
    Friend WithEvents ToolBar3 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents colTitulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNivel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInstitucion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAño As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents ToolBar4 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTipoLicencia As System.Windows.Forms.TextBox
    Friend WithEvents txtLicencia As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents DaEstado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cbMonedaDeduccion As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodDeduccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreDeduccion As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adMoneda2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents dtEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaEmpleado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaBancaria As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolBar5 As System.Windows.Forms.ToolBar
    Friend WithEvents txtCuentaContablePorcentaje As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuentaContableDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuentaContable As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaContableTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tbbCuentaContableNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbCuentaContableEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbCuentaContableGuardar As System.Windows.Forms.ToolBarButton
    Friend WithEvents txtFechaSalida As System.Windows.Forms.TextBox
    Friend WithEvents DPFecha_Ingreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents LHoras As System.Windows.Forms.Label
    Friend WithEvents NuHoras As System.Windows.Forms.NumericUpDown
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Check_ServiciosProf As System.Windows.Forms.CheckBox
    Friend WithEvents ckCedula As System.Windows.Forms.CheckBox
    Friend WithEvents txtNuevaCedula As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txttarjeta As System.Windows.Forms.TextBox
    Friend WithEvents txthuella As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TextEditSRD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo10 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo11 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo12 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo13 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo14 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleado))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CkFemenino = New System.Windows.Forms.RadioButton
        Me.CkMasculino = New System.Windows.Forms.RadioButton
        Me.DsEmpleado1 = New Planilla.DsEmpleado
        Me.CbEstadoCivil = New System.Windows.Forms.ComboBox
        Me.CbNacionalidad = New System.Windows.Forms.ComboBox
        Me.DpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtEMail = New System.Windows.Forms.TextBox
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.TxtTelefono2 = New System.Windows.Forms.TextBox
        Me.TxtTelefono1 = New System.Windows.Forms.TextBox
        Me.TxtEdad = New System.Windows.Forms.TextBox
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.TxtIdentificacion = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CbDepartamento = New System.Windows.Forms.ComboBox
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label31 = New System.Windows.Forms.Label
        Me.cbMonedaDeduccion = New System.Windows.Forms.ComboBox
        Me.txtCodDeduccion = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ToolBar2 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.cbTipoDed = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtNombreDeduccion = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.GridDeducciones = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtMontoDeducion = New DevExpress.XtraEditors.TextEdit
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ToolBar3 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.txtAño = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtNivel = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtInstitucion = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtTitulo = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colTitulo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNivel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colInstitucion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAño = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.dtVencimiento = New System.Windows.Forms.DateTimePicker
        Me.dtEmision = New System.Windows.Forms.DateTimePicker
        Me.ToolBar4 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtTipoLicencia = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtLicencia = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipo1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEmision = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVencimiento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.txtCuentaContableTotal = New DevExpress.XtraEditors.TextEdit
        Me.Label36 = New System.Windows.Forms.Label
        Me.ToolBar5 = New System.Windows.Forms.ToolBar
        Me.tbbCuentaContableNuevo = New System.Windows.Forms.ToolBarButton
        Me.tbbCuentaContableEliminar = New System.Windows.Forms.ToolBarButton
        Me.tbbCuentaContableGuardar = New System.Windows.Forms.ToolBarButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtCuentaContablePorcentaje = New DevExpress.XtraEditors.TextEdit
        Me.txtCuentaContableDescripcion = New DevExpress.XtraEditors.TextEdit
        Me.txtCuentaContable = New DevExpress.XtraEditors.TextEdit
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaNacionalidad = New System.Data.SqlClient.SqlDataAdapter
        Me.TxtHijos = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.TextEditSRD = New DevExpress.XtraEditors.TextEdit
        Me.NuHoras = New System.Windows.Forms.NumericUpDown
        Me.LHoras = New System.Windows.Forms.Label
        Me.CkMensual = New System.Windows.Forms.RadioButton
        Me.CkSemanal = New System.Windows.Forms.RadioButton
        Me.CkQuincena = New System.Windows.Forms.RadioButton
        Me.CkDiario = New System.Windows.Forms.RadioButton
        Me.Ckhora = New System.Windows.Forms.RadioButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CbMoneda = New System.Windows.Forms.ComboBox
        Me.txtSueldo = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtFechaSalida = New System.Windows.Forms.TextBox
        Me.Check_ServiciosProf = New System.Windows.Forms.CheckBox
        Me.DPFecha_Ingreso = New System.Windows.Forms.DateTimePicker
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaDepartamento = New System.Data.SqlClient.SqlDataAdapter
        Me.DaDeducciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaAcademico = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaLicencia = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.Label29 = New System.Windows.Forms.Label
        Me.CbEstado = New System.Windows.Forms.ComboBox
        Me.DaEstado = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        Me.adMoneda2 = New System.Data.SqlClient.SqlDataAdapter
        Me.DaEmpleado = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtCuentaBancaria = New System.Windows.Forms.TextBox
        Me.ckCedula = New System.Windows.Forms.CheckBox
        Me.txtNuevaCedula = New System.Windows.Forms.TextBox
        Me.txttarjeta = New System.Windows.Forms.TextBox
        Me.txthuella = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox4.SuspendLayout()
        CType(Me.DsEmpleado1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoDeducion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.txtCuentaContableTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaContablePorcentaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaContableDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaContable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TextEditSRD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSueldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(658, 32)
        Me.TituloModulo.Text = "Registro de Empleados"
        '
        'ToolBar1
        '
        Me.ToolBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.ImageList = Me.ImageList
        Me.ToolBar1.Location = New System.Drawing.Point(0, 517)
        Me.ToolBar1.Size = New System.Drawing.Size(658, 52)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CkFemenino)
        Me.GroupBox4.Controls.Add(Me.CkMasculino)
        Me.GroupBox4.Location = New System.Drawing.Point(543, 51)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(96, 53)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        '
        'CkFemenino
        '
        Me.CkFemenino.ForeColor = System.Drawing.Color.Blue
        Me.CkFemenino.Location = New System.Drawing.Point(8, 32)
        Me.CkFemenino.Name = "CkFemenino"
        Me.CkFemenino.Size = New System.Drawing.Size(80, 16)
        Me.CkFemenino.TabIndex = 1
        Me.CkFemenino.Text = "&Femenino"
        '
        'CkMasculino
        '
        Me.CkMasculino.ForeColor = System.Drawing.Color.Blue
        Me.CkMasculino.Location = New System.Drawing.Point(8, 8)
        Me.CkMasculino.Name = "CkMasculino"
        Me.CkMasculino.Size = New System.Drawing.Size(80, 16)
        Me.CkMasculino.TabIndex = 0
        Me.CkMasculino.Text = "&Masculino"
        '
        'DsEmpleado1
        '
        Me.DsEmpleado1.DataSetName = "DsEmpleado"
        Me.DsEmpleado1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsEmpleado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CbEstadoCivil
        '
        Me.CbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Union Libre", "Divorciado", "Viudo"})
        Me.CbEstadoCivil.Location = New System.Drawing.Point(443, 56)
        Me.CbEstadoCivil.Name = "CbEstadoCivil"
        Me.CbEstadoCivil.Size = New System.Drawing.Size(93, 21)
        Me.CbEstadoCivil.TabIndex = 31
        '
        'CbNacionalidad
        '
        Me.CbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNacionalidad.ForeColor = System.Drawing.Color.Blue
        Me.CbNacionalidad.Location = New System.Drawing.Point(83, 96)
        Me.CbNacionalidad.Name = "CbNacionalidad"
        Me.CbNacionalidad.Size = New System.Drawing.Size(136, 21)
        Me.CbNacionalidad.TabIndex = 30
        '
        'DpFecha
        '
        Me.DpFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DpFecha.Enabled = False
        Me.DpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DpFecha.Location = New System.Drawing.Point(224, 96)
        Me.DpFecha.MaxDate = New Date(2019, 9, 24, 0, 0, 0, 0)
        Me.DpFecha.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.DpFecha.Name = "DpFecha"
        Me.DpFecha.Size = New System.Drawing.Size(120, 20)
        Me.DpFecha.TabIndex = 29
        Me.DpFecha.Value = New Date(2006, 7, 24, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(11, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(205, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Teléfono"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(355, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Edad"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(13, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(467, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Dirección"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtEMail
        '
        Me.TxtEMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEMail.ForeColor = System.Drawing.Color.Blue
        Me.TxtEMail.Location = New System.Drawing.Point(224, 136)
        Me.TxtEMail.Name = "TxtEMail"
        Me.TxtEMail.Size = New System.Drawing.Size(240, 13)
        Me.TxtEMail.TabIndex = 24
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDireccion.ForeColor = System.Drawing.Color.Blue
        Me.TxtDireccion.Location = New System.Drawing.Point(13, 172)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(467, 13)
        Me.TxtDireccion.TabIndex = 23
        '
        'TxtTelefono2
        '
        Me.TxtTelefono2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTelefono2.ForeColor = System.Drawing.Color.Blue
        Me.TxtTelefono2.Location = New System.Drawing.Point(120, 136)
        Me.TxtTelefono2.Name = "TxtTelefono2"
        Me.TxtTelefono2.Size = New System.Drawing.Size(96, 13)
        Me.TxtTelefono2.TabIndex = 22
        '
        'TxtTelefono1
        '
        Me.TxtTelefono1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTelefono1.ForeColor = System.Drawing.Color.Blue
        Me.TxtTelefono1.Location = New System.Drawing.Point(11, 136)
        Me.TxtTelefono1.Name = "TxtTelefono1"
        Me.TxtTelefono1.Size = New System.Drawing.Size(101, 13)
        Me.TxtTelefono1.TabIndex = 21
        '
        'TxtEdad
        '
        Me.TxtEdad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEdad.Enabled = False
        Me.TxtEdad.ForeColor = System.Drawing.Color.Blue
        Me.TxtEdad.Location = New System.Drawing.Point(355, 96)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(181, 13)
        Me.TxtEdad.TabIndex = 18
        Me.TxtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombre.Location = New System.Drawing.Point(115, 56)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(320, 13)
        Me.TxtNombre.TabIndex = 13
        '
        'TxtIdentificacion
        '
        Me.TxtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdentificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIdentificacion.ForeColor = System.Drawing.Color.Blue
        Me.TxtIdentificacion.Location = New System.Drawing.Point(11, 56)
        Me.TxtIdentificacion.Name = "TxtIdentificacion"
        Me.TxtIdentificacion.Size = New System.Drawing.Size(100, 13)
        Me.TxtIdentificacion.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(224, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "E-Mail"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(224, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha de Nacimiento"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(83, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nacionalidad"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(11, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "# de Hijos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(443, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estado Civil"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(115, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(11, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identificación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbDepartamento
        '
        Me.CbDepartamento.DisplayMember = "Id"
        Me.CbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbDepartamento.ForeColor = System.Drawing.Color.Blue
        Me.CbDepartamento.Location = New System.Drawing.Point(8, 112)
        Me.CbDepartamento.Name = "CbDepartamento"
        Me.CbDepartamento.Size = New System.Drawing.Size(240, 21)
        Me.CbDepartamento.TabIndex = 9
        Me.CbDepartamento.ValueMember = "Id"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.TxtDescripcion.Location = New System.Drawing.Point(8, 21)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(240, 13)
        Me.TxtDescripcion.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(136, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Fecha Salida"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label17.ForeColor = System.Drawing.Color.Blue
        Me.Label17.Location = New System.Drawing.Point(8, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(240, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Departamento"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(8, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Fecha Ingreso"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(8, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(240, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Descripción del Puesto"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(264, 192)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 272)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.cbMonedaDeduccion)
        Me.TabPage1.Controls.Add(Me.txtCodDeduccion)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.cbTipoDed)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.txtNombreDeduccion)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.GridDeducciones)
        Me.TabPage1.Controls.Add(Me.txtMontoDeducion)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(376, 246)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Deducciones"
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Blue
        Me.Label31.Location = New System.Drawing.Point(160, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(144, 13)
        Me.Label31.TabIndex = 178
        Me.Label31.Text = "Moneda"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbMonedaDeduccion
        '
        Me.cbMonedaDeduccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonedaDeduccion.Enabled = False
        Me.cbMonedaDeduccion.ForeColor = System.Drawing.Color.Blue
        Me.cbMonedaDeduccion.Location = New System.Drawing.Point(160, 48)
        Me.cbMonedaDeduccion.Name = "cbMonedaDeduccion"
        Me.cbMonedaDeduccion.Size = New System.Drawing.Size(144, 21)
        Me.cbMonedaDeduccion.TabIndex = 179
        '
        'txtCodDeduccion
        '
        Me.txtCodDeduccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodDeduccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodDeduccion.Enabled = False
        Me.txtCodDeduccion.ForeColor = System.Drawing.Color.Blue
        Me.txtCodDeduccion.Location = New System.Drawing.Point(8, 16)
        Me.txtCodDeduccion.Name = "txtCodDeduccion"
        Me.txtCodDeduccion.Size = New System.Drawing.Size(96, 13)
        Me.txtCodDeduccion.TabIndex = 177
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label30.ForeColor = System.Drawing.Color.Blue
        Me.Label30.Location = New System.Drawing.Point(8, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 13)
        Me.Label30.TabIndex = 176
        Me.Label30.Text = "Código"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolBar2)
        Me.Panel2.Location = New System.Drawing.Point(16, 189)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(328, 40)
        Me.Panel2.TabIndex = 175
        '
        'ToolBar2
        '
        Me.ToolBar2.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar2.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton3, Me.ToolBarButton2})
        Me.ToolBar2.Divider = False
        Me.ToolBar2.DropDownArrows = True
        Me.ToolBar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar2.ImageList = Me.ImageList2
        Me.ToolBar2.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar2.Name = "ToolBar2"
        Me.ToolBar2.ShowToolTips = True
        Me.ToolBar2.Size = New System.Drawing.Size(328, 40)
        Me.ToolBar2.TabIndex = 0
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 2
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "Nueva"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 0
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Text = "Eliminar"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Text = "Guardar"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        '
        'cbTipoDed
        '
        Me.cbTipoDed.Enabled = False
        Me.cbTipoDed.ForeColor = System.Drawing.Color.Blue
        Me.cbTipoDed.Items.AddRange(New Object() {"%", "V"})
        Me.cbTipoDed.Location = New System.Drawing.Point(322, 47)
        Me.cbTipoDed.Name = "cbTipoDed"
        Me.cbTipoDed.Size = New System.Drawing.Size(40, 21)
        Me.cbTipoDed.TabIndex = 65
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(322, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "Tipo"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(8, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 13)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "Monto"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreDeduccion
        '
        Me.txtNombreDeduccion.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNombreDeduccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreDeduccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreDeduccion.Enabled = False
        Me.txtNombreDeduccion.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreDeduccion.Location = New System.Drawing.Point(112, 16)
        Me.txtNombreDeduccion.Name = "txtNombreDeduccion"
        Me.txtNombreDeduccion.Size = New System.Drawing.Size(256, 13)
        Me.txtNombreDeduccion.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(112, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(256, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Descripción"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridDeducciones
        '
        Me.GridDeducciones.DataMember = "Empleado_Deducciones"
        Me.GridDeducciones.DataSource = Me.DsEmpleado1
        '
        '
        '
        Me.GridDeducciones.EmbeddedNavigator.Name = ""
        Me.GridDeducciones.Location = New System.Drawing.Point(0, 71)
        Me.GridDeducciones.MainView = Me.GridView1
        Me.GridDeducciones.Name = "GridDeducciones"
        Me.GridDeducciones.Size = New System.Drawing.Size(376, 112)
        Me.GridDeducciones.TabIndex = 0
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescripcion, Me.colMonto, Me.colTipo})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.FilterInfo = ColumnFilterInfo1
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 0
        Me.colDescripcion.Width = 100
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto"
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.FilterInfo = ColumnFilterInfo2
        Me.colMonto.Name = "colMonto"
        Me.colMonto.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto.VisibleIndex = 1
        Me.colMonto.Width = 50
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.FilterInfo = ColumnFilterInfo3
        Me.colTipo.Name = "colTipo"
        Me.colTipo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTipo.VisibleIndex = 2
        Me.colTipo.Width = 50
        '
        'txtMontoDeducion
        '
        Me.txtMontoDeducion.EditValue = ""
        Me.txtMontoDeducion.Location = New System.Drawing.Point(8, 48)
        Me.txtMontoDeducion.Name = "txtMontoDeducion"
        '
        '
        '
        Me.txtMontoDeducion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtMontoDeducion.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtMontoDeducion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoDeducion.Properties.Enabled = False
        Me.txtMontoDeducion.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtMontoDeducion.Size = New System.Drawing.Size(128, 17)
        Me.txtMontoDeducion.TabIndex = 63
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ToolBar3)
        Me.TabPage3.Controls.Add(Me.txtAño)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.txtNivel)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.txtInstitucion)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.txtTitulo)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.GridControl2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(376, 246)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Formación Académica"
        '
        'ToolBar3
        '
        Me.ToolBar3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolBar3.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar3.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton6})
        Me.ToolBar3.Divider = False
        Me.ToolBar3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar3.DropDownArrows = True
        Me.ToolBar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar3.ImageList = Me.ImageList2
        Me.ToolBar3.Location = New System.Drawing.Point(8, 200)
        Me.ToolBar3.Name = "ToolBar3"
        Me.ToolBar3.ShowToolTips = True
        Me.ToolBar3.Size = New System.Drawing.Size(328, 40)
        Me.ToolBar3.TabIndex = 22
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 2
        Me.ToolBarButton4.Name = "ToolBarButton4"
        Me.ToolBarButton4.Text = "Nueva"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 0
        Me.ToolBarButton5.Name = "ToolBarButton5"
        Me.ToolBarButton5.Text = "Eliminar"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 1
        Me.ToolBarButton6.Name = "ToolBarButton6"
        Me.ToolBarButton6.Text = "Guardar"
        '
        'txtAño
        '
        Me.txtAño.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAño.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAño.Enabled = False
        Me.txtAño.ForeColor = System.Drawing.Color.Blue
        Me.txtAño.Location = New System.Drawing.Point(264, 47)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(104, 13)
        Me.txtAño.TabIndex = 21
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.Location = New System.Drawing.Point(264, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 13)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = "Año"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNivel
        '
        Me.txtNivel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNivel.Enabled = False
        Me.txtNivel.ForeColor = System.Drawing.Color.Blue
        Me.txtNivel.Location = New System.Drawing.Point(264, 15)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(104, 13)
        Me.txtNivel.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.Location = New System.Drawing.Point(264, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(104, 13)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Nivel"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInstitucion
        '
        Me.txtInstitucion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInstitucion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInstitucion.Enabled = False
        Me.txtInstitucion.ForeColor = System.Drawing.Color.Blue
        Me.txtInstitucion.Location = New System.Drawing.Point(0, 46)
        Me.txtInstitucion.Name = "txtInstitucion"
        Me.txtInstitucion.Size = New System.Drawing.Size(256, 13)
        Me.txtInstitucion.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(0, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(256, 13)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Institución"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTitulo
        '
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTitulo.Enabled = False
        Me.txtTitulo.ForeColor = System.Drawing.Color.Blue
        Me.txtTitulo.Location = New System.Drawing.Point(0, 13)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(256, 13)
        Me.txtTitulo.TabIndex = 15
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(256, 13)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Título"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "Empleado_Academico"
        Me.GridControl2.DataSource = Me.DsEmpleado1
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(0, 64)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(372, 112)
        Me.GridControl2.TabIndex = 1
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTitulo, Me.colNivel, Me.colInstitucion, Me.colAño})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFilterPanel = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colTitulo
        '
        Me.colTitulo.Caption = "Titulo"
        Me.colTitulo.FieldName = "Titulo"
        Me.colTitulo.FilterInfo = ColumnFilterInfo4
        Me.colTitulo.Name = "colTitulo"
        Me.colTitulo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTitulo.VisibleIndex = 0
        Me.colTitulo.Width = 50
        '
        'colNivel
        '
        Me.colNivel.Caption = "Nivel"
        Me.colNivel.FieldName = "Nivel"
        Me.colNivel.FilterInfo = ColumnFilterInfo5
        Me.colNivel.Name = "colNivel"
        Me.colNivel.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colNivel.VisibleIndex = 1
        Me.colNivel.Width = 25
        '
        'colInstitucion
        '
        Me.colInstitucion.Caption = "Institucion"
        Me.colInstitucion.FieldName = "Institucion"
        Me.colInstitucion.FilterInfo = ColumnFilterInfo6
        Me.colInstitucion.Name = "colInstitucion"
        Me.colInstitucion.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colInstitucion.VisibleIndex = 2
        Me.colInstitucion.Width = 50
        '
        'colAño
        '
        Me.colAño.Caption = "Año"
        Me.colAño.FieldName = "Año"
        Me.colAño.FilterInfo = ColumnFilterInfo7
        Me.colAño.Name = "colAño"
        Me.colAño.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colAño.VisibleIndex = 3
        Me.colAño.Width = 25
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dtVencimiento)
        Me.TabPage4.Controls.Add(Me.dtEmision)
        Me.TabPage4.Controls.Add(Me.ToolBar4)
        Me.TabPage4.Controls.Add(Me.Label28)
        Me.TabPage4.Controls.Add(Me.Label27)
        Me.TabPage4.Controls.Add(Me.txtTipoLicencia)
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.txtLicencia)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.GridControl3)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(376, 246)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Licencias"
        '
        'dtVencimiento
        '
        Me.dtVencimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtVencimiento.Enabled = False
        Me.dtVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVencimiento.Location = New System.Drawing.Point(224, 48)
        Me.dtVencimiento.MaxDate = New Date(2019, 7, 24, 0, 0, 0, 0)
        Me.dtVencimiento.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.dtVencimiento.Name = "dtVencimiento"
        Me.dtVencimiento.Size = New System.Drawing.Size(152, 20)
        Me.dtVencimiento.TabIndex = 31
        Me.dtVencimiento.Value = New Date(2006, 7, 24, 0, 0, 0, 0)
        '
        'dtEmision
        '
        Me.dtEmision.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtEmision.Enabled = False
        Me.dtEmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEmision.Location = New System.Drawing.Point(0, 48)
        Me.dtEmision.MaxDate = New Date(2019, 7, 24, 0, 0, 0, 0)
        Me.dtEmision.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.dtEmision.Name = "dtEmision"
        Me.dtEmision.Size = New System.Drawing.Size(152, 20)
        Me.dtEmision.TabIndex = 30
        Me.dtEmision.Value = New Date(2006, 7, 24, 0, 0, 0, 0)
        '
        'ToolBar4
        '
        Me.ToolBar4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolBar4.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar4.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton7, Me.ToolBarButton8, Me.ToolBarButton9})
        Me.ToolBar4.Divider = False
        Me.ToolBar4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar4.DropDownArrows = True
        Me.ToolBar4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar4.ImageList = Me.ImageList2
        Me.ToolBar4.Location = New System.Drawing.Point(8, 208)
        Me.ToolBar4.Name = "ToolBar4"
        Me.ToolBar4.ShowToolTips = True
        Me.ToolBar4.Size = New System.Drawing.Size(328, 40)
        Me.ToolBar4.TabIndex = 24
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 2
        Me.ToolBarButton7.Name = "ToolBarButton7"
        Me.ToolBarButton7.Text = "Nueva"
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.ImageIndex = 0
        Me.ToolBarButton8.Name = "ToolBarButton8"
        Me.ToolBarButton8.Text = "Eliminar"
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 1
        Me.ToolBarButton9.Name = "ToolBarButton9"
        Me.ToolBarButton9.Text = "Guardar"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.Location = New System.Drawing.Point(224, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(152, 13)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Vencimiento"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Blue
        Me.Label27.Location = New System.Drawing.Point(0, 32)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(152, 13)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "Emisión"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTipoLicencia
        '
        Me.txtTipoLicencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTipoLicencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoLicencia.Enabled = False
        Me.txtTipoLicencia.ForeColor = System.Drawing.Color.Blue
        Me.txtTipoLicencia.Location = New System.Drawing.Point(248, 16)
        Me.txtTipoLicencia.Name = "txtTipoLicencia"
        Me.txtTipoLicencia.Size = New System.Drawing.Size(128, 13)
        Me.txtTipoLicencia.TabIndex = 19
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(248, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(128, 13)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Tipo"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLicencia
        '
        Me.txtLicencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLicencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLicencia.Enabled = False
        Me.txtLicencia.ForeColor = System.Drawing.Color.Blue
        Me.txtLicencia.Location = New System.Drawing.Point(0, 14)
        Me.txtLicencia.Name = "txtLicencia"
        Me.txtLicencia.Size = New System.Drawing.Size(240, 13)
        Me.txtLicencia.TabIndex = 17
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Blue
        Me.Label25.Location = New System.Drawing.Point(0, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(240, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "No. Licencia"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "Empleado_Licencias"
        Me.GridControl3.DataSource = Me.DsEmpleado1
        '
        '
        '
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(4, 72)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(372, 112)
        Me.GridControl3.TabIndex = 1
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colTipo1, Me.colEmision, Me.colVencimiento})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowFilterPanel = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colNumero
        '
        Me.colNumero.Caption = "Numero"
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.FilterInfo = ColumnFilterInfo8
        Me.colNumero.Name = "colNumero"
        Me.colNumero.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colNumero.VisibleIndex = 0
        Me.colNumero.Width = 60
        '
        'colTipo1
        '
        Me.colTipo1.Caption = "Tipo"
        Me.colTipo1.FieldName = "Tipo"
        Me.colTipo1.FilterInfo = ColumnFilterInfo9
        Me.colTipo1.Name = "colTipo1"
        Me.colTipo1.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTipo1.VisibleIndex = 1
        Me.colTipo1.Width = 50
        '
        'colEmision
        '
        Me.colEmision.Caption = "Emision"
        Me.colEmision.FieldName = "Emision"
        Me.colEmision.FilterInfo = ColumnFilterInfo10
        Me.colEmision.Name = "colEmision"
        Me.colEmision.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colEmision.VisibleIndex = 2
        Me.colEmision.Width = 50
        '
        'colVencimiento
        '
        Me.colVencimiento.Caption = "Vencimiento"
        Me.colVencimiento.FieldName = "Vencimiento"
        Me.colVencimiento.FilterInfo = ColumnFilterInfo11
        Me.colVencimiento.Name = "colVencimiento"
        Me.colVencimiento.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colVencimiento.VisibleIndex = 3
        Me.colVencimiento.Width = 50
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureEdit1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(376, 246)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Foto"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(16, 8)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(344, 208)
        Me.PictureEdit1.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtCuentaContableTotal)
        Me.TabPage5.Controls.Add(Me.Label36)
        Me.TabPage5.Controls.Add(Me.ToolBar5)
        Me.TabPage5.Controls.Add(Me.GridControl1)
        Me.TabPage5.Controls.Add(Me.txtCuentaContablePorcentaje)
        Me.TabPage5.Controls.Add(Me.txtCuentaContableDescripcion)
        Me.TabPage5.Controls.Add(Me.txtCuentaContable)
        Me.TabPage5.Controls.Add(Me.Label35)
        Me.TabPage5.Controls.Add(Me.Label34)
        Me.TabPage5.Controls.Add(Me.Label33)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(376, 246)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "Distribución Contable"
        '
        'txtCuentaContableTotal
        '
        Me.txtCuentaContableTotal.EditValue = ""
        Me.txtCuentaContableTotal.Location = New System.Drawing.Point(280, 192)
        Me.txtCuentaContableTotal.Name = "txtCuentaContableTotal"
        '
        '
        '
        Me.txtCuentaContableTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCuentaContableTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuentaContableTotal.Properties.Enabled = False
        Me.txtCuentaContableTotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.Blue)
        Me.txtCuentaContableTotal.Size = New System.Drawing.Size(80, 17)
        Me.txtCuentaContableTotal.TabIndex = 68
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label36.ForeColor = System.Drawing.Color.Blue
        Me.Label36.Location = New System.Drawing.Point(192, 192)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 13)
        Me.Label36.TabIndex = 67
        Me.Label36.Text = "Total"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolBar5
        '
        Me.ToolBar5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolBar5.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar5.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbCuentaContableNuevo, Me.tbbCuentaContableEliminar, Me.tbbCuentaContableGuardar})
        Me.ToolBar5.Divider = False
        Me.ToolBar5.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar5.DropDownArrows = True
        Me.ToolBar5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar5.ImageList = Me.ImageList2
        Me.ToolBar5.Location = New System.Drawing.Point(8, 200)
        Me.ToolBar5.Name = "ToolBar5"
        Me.ToolBar5.ShowToolTips = True
        Me.ToolBar5.Size = New System.Drawing.Size(328, 40)
        Me.ToolBar5.TabIndex = 66
        '
        'tbbCuentaContableNuevo
        '
        Me.tbbCuentaContableNuevo.ImageIndex = 2
        Me.tbbCuentaContableNuevo.Name = "tbbCuentaContableNuevo"
        Me.tbbCuentaContableNuevo.Text = "Nueva"
        '
        'tbbCuentaContableEliminar
        '
        Me.tbbCuentaContableEliminar.ImageIndex = 0
        Me.tbbCuentaContableEliminar.Name = "tbbCuentaContableEliminar"
        Me.tbbCuentaContableEliminar.Text = "Eliminar"
        '
        'tbbCuentaContableGuardar
        '
        Me.tbbCuentaContableGuardar.ImageIndex = 1
        Me.tbbCuentaContableGuardar.Name = "tbbCuentaContableGuardar"
        Me.tbbCuentaContableGuardar.Text = "Guardar"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "DistribucionContable"
        Me.GridControl1.DataSource = Me.DsEmpleado1
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 72)
        Me.GridControl1.MainView = Me.GridView4
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(360, 112)
        Me.GridControl1.TabIndex = 65
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridView4.GroupPanelText = ""
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Código"
        Me.GridColumn1.FieldName = "IdDepartamento"
        Me.GridColumn1.FilterInfo = ColumnFilterInfo12
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Departamento"
        Me.GridColumn2.FieldName = "Departamento"
        Me.GridColumn2.FilterInfo = ColumnFilterInfo13
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Porcentaje"
        Me.GridColumn3.FieldName = "Porcentaje"
        Me.GridColumn3.FilterInfo = ColumnFilterInfo14
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.VisibleIndex = 2
        '
        'txtCuentaContablePorcentaje
        '
        Me.txtCuentaContablePorcentaje.EditValue = ""
        Me.txtCuentaContablePorcentaje.Location = New System.Drawing.Point(256, 40)
        Me.txtCuentaContablePorcentaje.Name = "txtCuentaContablePorcentaje"
        '
        '
        '
        Me.txtCuentaContablePorcentaje.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCuentaContablePorcentaje.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuentaContablePorcentaje.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuentaContablePorcentaje.Properties.Enabled = False
        Me.txtCuentaContablePorcentaje.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.Blue)
        Me.txtCuentaContablePorcentaje.Size = New System.Drawing.Size(112, 17)
        Me.txtCuentaContablePorcentaje.TabIndex = 64
        '
        'txtCuentaContableDescripcion
        '
        Me.txtCuentaContableDescripcion.EditValue = ""
        Me.txtCuentaContableDescripcion.Location = New System.Drawing.Point(96, 40)
        Me.txtCuentaContableDescripcion.Name = "txtCuentaContableDescripcion"
        '
        '
        '
        Me.txtCuentaContableDescripcion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCuentaContableDescripcion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuentaContableDescripcion.Properties.Enabled = False
        Me.txtCuentaContableDescripcion.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.Blue)
        Me.txtCuentaContableDescripcion.Size = New System.Drawing.Size(144, 17)
        Me.txtCuentaContableDescripcion.TabIndex = 63
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.EditValue = ""
        Me.txtCuentaContable.Location = New System.Drawing.Point(8, 40)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        '
        '
        '
        Me.txtCuentaContable.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCuentaContable.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuentaContable.Properties.Enabled = False
        Me.txtCuentaContable.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.Color.Blue)
        Me.txtCuentaContable.Size = New System.Drawing.Size(80, 17)
        Me.txtCuentaContable.TabIndex = 62
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label35.ForeColor = System.Drawing.Color.Blue
        Me.Label35.Location = New System.Drawing.Point(256, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(112, 13)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "Porcentaje:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label34.ForeColor = System.Drawing.Color.Blue
        Me.Label34.Location = New System.Drawing.Point(96, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(144, 13)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "Descripcion:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label33.ForeColor = System.Drawing.Color.Blue
        Me.Label33.Location = New System.Drawing.Point(8, 24)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 13)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "Codigo:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "Data Source=.;Initial Catalog=planilla;Integrated Security=True"
        Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT codigo, descripcion, ABREV FROM Nacionalidad"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Nacionalidad(codigo, descripcion, ABREV) VALUES (@codigo, @descripcio" & _
            "n, @ABREV); SELECT codigo, descripcion, ABREV FROM Nacionalidad"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@codigo", System.Data.SqlDbType.Int, 4, "codigo"), New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar, 50, "descripcion"), New System.Data.SqlClient.SqlParameter("@ABREV", System.Data.SqlDbType.VarChar, 2, "ABREV")})
        '
        'DaNacionalidad
        '
        Me.DaNacionalidad.InsertCommand = Me.SqlInsertCommand2
        Me.DaNacionalidad.SelectCommand = Me.SqlSelectCommand2
        Me.DaNacionalidad.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Nacionalidad", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("codigo", "codigo"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("ABREV", "ABREV")})})
        '
        'TxtHijos
        '
        Me.TxtHijos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtHijos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtHijos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHijos.ForeColor = System.Drawing.Color.Blue
        Me.TxtHijos.Location = New System.Drawing.Point(11, 96)
        Me.TxtHijos.Name = "TxtHijos"
        Me.TxtHijos.Size = New System.Drawing.Size(64, 13)
        Me.TxtHijos.TabIndex = 15
        Me.TxtHijos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.TextEditSRD)
        Me.GroupBox3.Controls.Add(Me.NuHoras)
        Me.GroupBox3.Controls.Add(Me.LHoras)
        Me.GroupBox3.Controls.Add(Me.CkMensual)
        Me.GroupBox3.Controls.Add(Me.CkSemanal)
        Me.GroupBox3.Controls.Add(Me.CkQuincena)
        Me.GroupBox3.Controls.Add(Me.CkDiario)
        Me.GroupBox3.Controls.Add(Me.Ckhora)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.CbMoneda)
        Me.GroupBox3.Controls.Add(Me.txtSueldo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 342)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 138)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de Pago"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label39.ForeColor = System.Drawing.Color.Blue
        Me.Label39.Location = New System.Drawing.Point(144, 96)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(96, 13)
        Me.Label39.TabIndex = 65
        Me.Label39.Text = "S.R.D"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEditSRD
        '
        Me.TextEditSRD.EditValue = ""
        Me.TextEditSRD.Location = New System.Drawing.Point(144, 112)
        Me.TextEditSRD.Name = "TextEditSRD"
        '
        '
        '
        Me.TextEditSRD.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEditSRD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEditSRD.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEditSRD.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TextEditSRD.Size = New System.Drawing.Size(96, 17)
        Me.TextEditSRD.TabIndex = 66
        '
        'NuHoras
        '
        Me.NuHoras.ForeColor = System.Drawing.Color.Blue
        Me.NuHoras.Location = New System.Drawing.Point(80, 32)
        Me.NuHoras.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NuHoras.Name = "NuHoras"
        Me.NuHoras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.NuHoras.Size = New System.Drawing.Size(56, 20)
        Me.NuHoras.TabIndex = 64
        Me.NuHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuHoras.Visible = False
        '
        'LHoras
        '
        Me.LHoras.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LHoras.ForeColor = System.Drawing.Color.Blue
        Me.LHoras.Location = New System.Drawing.Point(80, 18)
        Me.LHoras.Name = "LHoras"
        Me.LHoras.Size = New System.Drawing.Size(56, 13)
        Me.LHoras.TabIndex = 63
        Me.LHoras.Text = "Horas"
        Me.LHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LHoras.Visible = False
        '
        'CkMensual
        '
        Me.CkMensual.ForeColor = System.Drawing.Color.Blue
        Me.CkMensual.Location = New System.Drawing.Point(8, 80)
        Me.CkMensual.Name = "CkMensual"
        Me.CkMensual.Size = New System.Drawing.Size(72, 16)
        Me.CkMensual.TabIndex = 4
        Me.CkMensual.Text = "&Mensual"
        '
        'CkSemanal
        '
        Me.CkSemanal.ForeColor = System.Drawing.Color.Blue
        Me.CkSemanal.Location = New System.Drawing.Point(8, 48)
        Me.CkSemanal.Name = "CkSemanal"
        Me.CkSemanal.Size = New System.Drawing.Size(72, 16)
        Me.CkSemanal.TabIndex = 3
        Me.CkSemanal.Text = "&Semana"
        '
        'CkQuincena
        '
        Me.CkQuincena.ForeColor = System.Drawing.Color.Blue
        Me.CkQuincena.Location = New System.Drawing.Point(8, 64)
        Me.CkQuincena.Name = "CkQuincena"
        Me.CkQuincena.Size = New System.Drawing.Size(80, 16)
        Me.CkQuincena.TabIndex = 2
        Me.CkQuincena.Text = "&Quincena"
        '
        'CkDiario
        '
        Me.CkDiario.ForeColor = System.Drawing.Color.Blue
        Me.CkDiario.Location = New System.Drawing.Point(8, 32)
        Me.CkDiario.Name = "CkDiario"
        Me.CkDiario.Size = New System.Drawing.Size(56, 16)
        Me.CkDiario.TabIndex = 1
        Me.CkDiario.Text = "&Diario"
        '
        'Ckhora
        '
        Me.Ckhora.ForeColor = System.Drawing.Color.Blue
        Me.Ckhora.Location = New System.Drawing.Point(8, 16)
        Me.Ckhora.Name = "Ckhora"
        Me.Ckhora.Size = New System.Drawing.Size(56, 16)
        Me.Ckhora.TabIndex = 0
        Me.Ckhora.Text = "&Hora"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(144, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Salario"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(144, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Moneda"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbMoneda
        '
        Me.CbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbMoneda.ForeColor = System.Drawing.Color.Blue
        Me.CbMoneda.Location = New System.Drawing.Point(144, 70)
        Me.CbMoneda.Name = "CbMoneda"
        Me.CbMoneda.Size = New System.Drawing.Size(96, 21)
        Me.CbMoneda.TabIndex = 62
        '
        'txtSueldo
        '
        Me.txtSueldo.EditValue = ""
        Me.txtSueldo.Location = New System.Drawing.Point(144, 32)
        Me.txtSueldo.Name = "txtSueldo"
        '
        '
        '
        Me.txtSueldo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSueldo.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtSueldo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSueldo.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtSueldo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtSueldo.Size = New System.Drawing.Size(96, 17)
        Me.txtSueldo.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(543, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Sexo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtFechaSalida)
        Me.Panel1.Controls.Add(Me.Check_ServiciosProf)
        Me.Panel1.Controls.Add(Me.CbDepartamento)
        Me.Panel1.Controls.Add(Me.TxtDescripcion)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.DPFecha_Ingreso)
        Me.Panel1.Location = New System.Drawing.Point(8, 195)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 141)
        Me.Panel1.TabIndex = 60
        '
        'txtFechaSalida
        '
        Me.txtFechaSalida.Enabled = False
        Me.txtFechaSalida.Location = New System.Drawing.Point(152, 70)
        Me.txtFechaSalida.Name = "txtFechaSalida"
        Me.txtFechaSalida.ReadOnly = True
        Me.txtFechaSalida.Size = New System.Drawing.Size(80, 20)
        Me.txtFechaSalida.TabIndex = 11
        Me.txtFechaSalida.Visible = False
        '
        'Check_ServiciosProf
        '
        Me.Check_ServiciosProf.Location = New System.Drawing.Point(8, 36)
        Me.Check_ServiciosProf.Name = "Check_ServiciosProf"
        Me.Check_ServiciosProf.Size = New System.Drawing.Size(160, 16)
        Me.Check_ServiciosProf.TabIndex = 10
        Me.Check_ServiciosProf.Text = "Servicios Profesionales"
        '
        'DPFecha_Ingreso
        '
        Me.DPFecha_Ingreso.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DPFecha_Ingreso.Enabled = False
        Me.DPFecha_Ingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPFecha_Ingreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DPFecha_Ingreso.Location = New System.Drawing.Point(8, 70)
        Me.DPFecha_Ingreso.MaxDate = New Date(2019, 11, 30, 0, 0, 0, 0)
        Me.DPFecha_Ingreso.MinDate = New Date(1940, 1, 1, 0, 0, 0, 0)
        Me.DPFecha_Ingreso.Name = "DPFecha_Ingreso"
        Me.DPFecha_Ingreso.Size = New System.Drawing.Size(112, 20)
        Me.DPFecha_Ingreso.TabIndex = 65
        Me.DPFecha_Ingreso.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Departamento, Id FROM Departamento"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Departamento(Departamento) VALUES (@Departamento); SELECT Departament" & _
            "o, Id FROM Departamento"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Departamento", System.Data.SqlDbType.VarChar, 100, "Departamento")})
        '
        'DaDepartamento
        '
        Me.DaDepartamento.InsertCommand = Me.SqlInsertCommand3
        Me.DaDepartamento.SelectCommand = Me.SqlSelectCommand3
        Me.DaDepartamento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Departamento", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Departamento", "Departamento"), New System.Data.Common.DataColumnMapping("Id", "Id")})})
        '
        'DaDeducciones
        '
        Me.DaDeducciones.DeleteCommand = Me.SqlDeleteCommand2
        Me.DaDeducciones.InsertCommand = Me.SqlInsertCommand4
        Me.DaDeducciones.SelectCommand = Me.SqlSelectCommand4
        Me.DaDeducciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado_Deducciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        Me.DaDeducciones.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Id, Identificacion, Codigo, Descripcion, Monto, Tipo, Cod_Moneda FROM Empl" & _
            "eado_Deducciones"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'DaAcademico
        '
        Me.DaAcademico.DeleteCommand = Me.SqlDeleteCommand3
        Me.DaAcademico.InsertCommand = Me.SqlInsertCommand5
        Me.DaAcademico.SelectCommand = Me.SqlSelectCommand5
        Me.DaAcademico.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado_Academico", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Titulo", "Titulo"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Institucion", "Institucion"), New System.Data.Common.DataColumnMapping("Año", "Año")})})
        Me.DaAcademico.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Año", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Año", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Institucion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Institucion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Titulo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Titulo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Titulo", System.Data.SqlDbType.VarChar, 250, "Titulo"), New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.VarChar, 100, "Nivel"), New System.Data.SqlClient.SqlParameter("@Institucion", System.Data.SqlDbType.VarChar, 150, "Institucion"), New System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.Int, 4, "Año")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Id, Identificacion, Titulo, Nivel, Institucion, Año FROM Empleado_Academic" & _
            "o"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Titulo", System.Data.SqlDbType.VarChar, 250, "Titulo"), New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.VarChar, 100, "Nivel"), New System.Data.SqlClient.SqlParameter("@Institucion", System.Data.SqlDbType.VarChar, 150, "Institucion"), New System.Data.SqlClient.SqlParameter("@Año", System.Data.SqlDbType.Int, 4, "Año"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Año", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Año", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Institucion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Institucion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Titulo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Titulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'DaLicencia
        '
        Me.DaLicencia.DeleteCommand = Me.SqlDeleteCommand4
        Me.DaLicencia.InsertCommand = Me.SqlInsertCommand6
        Me.DaLicencia.SelectCommand = Me.SqlSelectCommand6
        Me.DaLicencia.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado_Licencias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Emision", "Emision"), New System.Data.Common.DataColumnMapping("Vencimiento", "Vencimiento")})})
        Me.DaLicencia.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Emision", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Emision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = resources.GetString("SqlInsertCommand6.CommandText")
        Me.SqlInsertCommand6.Connection = Me.SqlConnection
        Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 100, "Numero"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 10, "Tipo"), New System.Data.SqlClient.SqlParameter("@Emision", System.Data.SqlDbType.DateTime, 8, "Emision"), New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Id, Identificacion, Numero, Tipo, Emision, Vencimiento FROM Empleado_Licen" & _
            "cias"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 100, "Numero"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 10, "Tipo"), New System.Data.SqlClient.SqlParameter("@Emision", System.Data.SqlDbType.DateTime, 8, "Emision"), New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Emision", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Emision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vencimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vencimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=JEANCARLO;packet size=4096;integrated security=SSPI;data source=JE" & _
            "ANCARLO;persist security info=False;initial catalog=Planilla"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = resources.GetString("SqlInsertCommand7.CommandText")
        Me.SqlInsertCommand7.Connection = Me.SqlConnection1
        Me.SqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DaMoneda
        '
        Me.DaMoneda.DeleteCommand = Me.SqlDeleteCommand5
        Me.DaMoneda.InsertCommand = Me.SqlInsertCommand7
        Me.DaMoneda.SelectCommand = Me.SqlSelectCommand7
        Me.DaMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.DaMoneda.UpdateCommand = Me.SqlUpdateCommand5
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Blue
        Me.Label29.Location = New System.Drawing.Point(472, 120)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(168, 13)
        Me.Label29.TabIndex = 61
        Me.Label29.Text = "Estado"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbEstado
        '
        Me.CbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEstado.ForeColor = System.Drawing.Color.Blue
        Me.CbEstado.Location = New System.Drawing.Point(472, 136)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(168, 21)
        Me.CbEstado.TabIndex = 62
        '
        'DaEstado
        '
        Me.DaEstado.DeleteCommand = Me.SqlDeleteCommand6
        Me.DaEstado.InsertCommand = Me.SqlInsertCommand8
        Me.DaEstado.SelectCommand = Me.SqlSelectCommand8
        Me.DaEstado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Estado_Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        Me.DaEstado.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM Estado_Empleado WHERE (Codigo = @Original_Codigo) AND (Descripcion = " & _
            "@Original_Descripcion)"
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection
        Me.SqlDeleteCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO Estado_Empleado(Descripcion) VALUES (@Descripcion); SELECT Codigo, De" & _
            "scripcion FROM Estado_Empleado WHERE (Codigo = @@IDENTITY)"
        Me.SqlInsertCommand8.Connection = Me.SqlConnection
        Me.SqlInsertCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion")})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT Codigo, Descripcion FROM Estado_Empleado"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = resources.GetString("SqlUpdateCommand6.CommandText")
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection
        Me.SqlUpdateCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo")})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand9
        '
        Me.SqlInsertCommand9.CommandText = resources.GetString("SqlInsertCommand9.CommandText")
        Me.SqlInsertCommand9.Connection = Me.SqlConnection1
        Me.SqlInsertCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = resources.GetString("SqlUpdateCommand7.CommandText")
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = resources.GetString("SqlDeleteCommand7.CommandText")
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'adMoneda2
        '
        Me.adMoneda2.DeleteCommand = Me.SqlDeleteCommand7
        Me.adMoneda2.InsertCommand = Me.SqlInsertCommand9
        Me.adMoneda2.SelectCommand = Me.SqlSelectCommand9
        Me.adMoneda2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda2", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.adMoneda2.UpdateCommand = Me.SqlUpdateCommand7
        '
        'DaEmpleado
        '
        Me.DaEmpleado.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaEmpleado.InsertCommand = Me.SqlInsertCommand1
        Me.DaEmpleado.SelectCommand = Me.SqlSelectCommand1
        Me.DaEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Estado_Civil", "Estado_Civil"), New System.Data.Common.DataColumnMapping("Hijos", "Hijos"), New System.Data.Common.DataColumnMapping("Cod_Nacionalidad", "Cod_Nacionalidad"), New System.Data.Common.DataColumnMapping("Fecha_Nacimiento", "Fecha_Nacimiento"), New System.Data.Common.DataColumnMapping("Edad", "Edad"), New System.Data.Common.DataColumnMapping("Telefono1", "Telefono1"), New System.Data.Common.DataColumnMapping("Telefono2", "Telefono2"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Fecha_Ingreso", "Fecha_Ingreso"), New System.Data.Common.DataColumnMapping("Fecha_Salida", "Fecha_Salida"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("Cod_Departamento", "Cod_Departamento"), New System.Data.Common.DataColumnMapping("Masculino", "Masculino"), New System.Data.Common.DataColumnMapping("Femenino", "Femenino"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Hora", "Hora"), New System.Data.Common.DataColumnMapping("Diario", "Diario"), New System.Data.Common.DataColumnMapping("Semana", "Semana"), New System.Data.Common.DataColumnMapping("Quincena", "Quincena"), New System.Data.Common.DataColumnMapping("Mensual", "Mensual"), New System.Data.Common.DataColumnMapping("Cod_Estado", "Cod_Estado"), New System.Data.Common.DataColumnMapping("CuentaBancaria", "CuentaBancaria"), New System.Data.Common.DataColumnMapping("id_usuario", "id_usuario"), New System.Data.Common.DataColumnMapping("HorasOrdinarias", "HorasOrdinarias"), New System.Data.Common.DataColumnMapping("ServiciosProf", "ServiciosProf"), New System.Data.Common.DataColumnMapping("CambioCedula", "CambioCedula"), New System.Data.Common.DataColumnMapping("NuevaCedula", "NuevaCedula"), New System.Data.Common.DataColumnMapping("Pin_Huella", "Pin_Huella"), New System.Data.Common.DataColumnMapping("Pin_tarjeta", "Pin_tarjeta"), New System.Data.Common.DataColumnMapping("SRD", "SRD")})})
        Me.DaEmpleado.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Empleado] WHERE (([Identificacion] = @Original_Identificacion))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 0, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"), New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 0, "Estado_Civil"), New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 0, "Hijos"), New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 0, "Cod_Nacionalidad"), New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 0, "Fecha_Nacimiento"), New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 0, "Edad"), New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 0, "Telefono1"), New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 0, "Telefono2"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 0, "Direccion"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 0, "Puesto"), New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 0, "Fecha_Ingreso"), New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 0, "Fecha_Salida"), New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 0, "Salario"), New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 0, "Cod_Departamento"), New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 0, "Masculino"), New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 0, "Femenino"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 0, "Hora"), New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 0, "Diario"), New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 0, "Semana"), New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 0, "Quincena"), New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 0, "Mensual"), New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 0, "Cod_Estado"), New System.Data.SqlClient.SqlParameter("@CuentaBancaria", System.Data.SqlDbType.VarChar, 0, "CuentaBancaria"), New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 0, "id_usuario"), New System.Data.SqlClient.SqlParameter("@HorasOrdinarias", System.Data.SqlDbType.Int, 0, "HorasOrdinarias"), New System.Data.SqlClient.SqlParameter("@ServiciosProf", System.Data.SqlDbType.Bit, 0, "ServiciosProf"), New System.Data.SqlClient.SqlParameter("@CambioCedula", System.Data.SqlDbType.Bit, 0, "CambioCedula"), New System.Data.SqlClient.SqlParameter("@NuevaCedula", System.Data.SqlDbType.VarChar, 0, "NuevaCedula"), New System.Data.SqlClient.SqlParameter("@Pin_Huella", System.Data.SqlDbType.VarChar, 0, "Pin_Huella"), New System.Data.SqlClient.SqlParameter("@Pin_tarjeta", System.Data.SqlDbType.VarChar, 0, "Pin_tarjeta"), New System.Data.SqlClient.SqlParameter("@SRD", System.Data.SqlDbType.Float, 0, "SRD")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 0, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 0, "Nombre"), New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 0, "Estado_Civil"), New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 0, "Hijos"), New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 0, "Cod_Nacionalidad"), New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 0, "Fecha_Nacimiento"), New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 0, "Edad"), New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 0, "Telefono1"), New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 0, "Telefono2"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 0, "Direccion"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 0, "Puesto"), New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 0, "Fecha_Ingreso"), New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 0, "Fecha_Salida"), New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 0, "Salario"), New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 0, "Cod_Departamento"), New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 0, "Masculino"), New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 0, "Femenino"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 0, "Hora"), New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 0, "Diario"), New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 0, "Semana"), New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 0, "Quincena"), New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 0, "Mensual"), New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 0, "Cod_Estado"), New System.Data.SqlClient.SqlParameter("@CuentaBancaria", System.Data.SqlDbType.VarChar, 0, "CuentaBancaria"), New System.Data.SqlClient.SqlParameter("@id_usuario", System.Data.SqlDbType.VarChar, 0, "id_usuario"), New System.Data.SqlClient.SqlParameter("@HorasOrdinarias", System.Data.SqlDbType.Int, 0, "HorasOrdinarias"), New System.Data.SqlClient.SqlParameter("@ServiciosProf", System.Data.SqlDbType.Bit, 0, "ServiciosProf"), New System.Data.SqlClient.SqlParameter("@CambioCedula", System.Data.SqlDbType.Bit, 0, "CambioCedula"), New System.Data.SqlClient.SqlParameter("@NuevaCedula", System.Data.SqlDbType.VarChar, 0, "NuevaCedula"), New System.Data.SqlClient.SqlParameter("@Pin_Huella", System.Data.SqlDbType.VarChar, 0, "Pin_Huella"), New System.Data.SqlClient.SqlParameter("@Pin_tarjeta", System.Data.SqlDbType.VarChar, 0, "Pin_tarjeta"), New System.Data.SqlClient.SqlParameter("@SRD", System.Data.SqlDbType.Float, 0, "SRD"), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Blue
        Me.Label32.Location = New System.Drawing.Point(486, 158)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(160, 13)
        Me.Label32.TabIndex = 63
        Me.Label32.Text = "Cuenta Bancaria"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCuentaBancaria
        '
        Me.txtCuentaBancaria.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtCuentaBancaria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaBancaria.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaBancaria.Location = New System.Drawing.Point(486, 173)
        Me.txtCuentaBancaria.Name = "txtCuentaBancaria"
        Me.txtCuentaBancaria.Size = New System.Drawing.Size(160, 14)
        Me.txtCuentaBancaria.TabIndex = 64
        Me.txtCuentaBancaria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ckCedula
        '
        Me.ckCedula.Location = New System.Drawing.Point(8, 496)
        Me.ckCedula.Name = "ckCedula"
        Me.ckCedula.Size = New System.Drawing.Size(112, 16)
        Me.ckCedula.TabIndex = 65
        Me.ckCedula.Text = "Cambia Cédula"
        '
        'txtNuevaCedula
        '
        Me.txtNuevaCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNuevaCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNuevaCedula.ForeColor = System.Drawing.Color.Blue
        Me.txtNuevaCedula.Location = New System.Drawing.Point(120, 496)
        Me.txtNuevaCedula.Name = "txtNuevaCedula"
        Me.txtNuevaCedula.Size = New System.Drawing.Size(136, 13)
        Me.txtNuevaCedula.TabIndex = 66
        '
        'txttarjeta
        '
        Me.txttarjeta.Location = New System.Drawing.Point(304, 469)
        Me.txttarjeta.Name = "txttarjeta"
        Me.txttarjeta.Size = New System.Drawing.Size(100, 20)
        Me.txttarjeta.TabIndex = 76
        '
        'txthuella
        '
        Me.txthuella.Location = New System.Drawing.Point(544, 466)
        Me.txthuella.Name = "txthuella"
        Me.txthuella.Size = New System.Drawing.Size(100, 20)
        Me.txthuella.TabIndex = 75
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(273, 469)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(64, 23)
        Me.Label38.TabIndex = 74
        Me.Label38.Text = "Pin Tarjeta"
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(486, 467)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(64, 23)
        Me.Label37.TabIndex = 73
        Me.Label37.Text = "Pin Huella"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "document.png")
        Me.ImageList.Images.SetKeyName(1, "016-search.png")
        Me.ImageList.Images.SetKeyName(2, "015-floppy-disk.png")
        Me.ImageList.Images.SetKeyName(3, "011-trash.png")
        Me.ImageList.Images.SetKeyName(4, "014-invoice.png")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "real-estate.png")
        Me.ImageList.Images.SetKeyName(7, "014-invoice.png")
        Me.ImageList.Images.SetKeyName(8, "real-estate.png")
        Me.ImageList.Images.SetKeyName(9, "012-edit.png")
        '
        'FrmEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.ClientSize = New System.Drawing.Size(658, 569)
        Me.Controls.Add(Me.txttarjeta)
        Me.Controls.Add(Me.txthuella)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.txtNuevaCedula)
        Me.Controls.Add(Me.ckCedula)
        Me.Controls.Add(Me.txtCuentaBancaria)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.CbEstado)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbNacionalidad)
        Me.Controls.Add(Me.DpFecha)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtEMail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TxtTelefono1)
        Me.Controls.Add(Me.CbEstadoCivil)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.TxtHijos)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTelefono2)
        Me.Controls.Add(Me.TxtIdentificacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "FrmEmpleado"
        Me.Text = "Registro de Empleados"
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtIdentificacion, 0)
        Me.Controls.SetChildIndex(Me.TxtTelefono2, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.TxtNombre, 0)
        Me.Controls.SetChildIndex(Me.TxtHijos, 0)
        Me.Controls.SetChildIndex(Me.TxtEdad, 0)
        Me.Controls.SetChildIndex(Me.CbEstadoCivil, 0)
        Me.Controls.SetChildIndex(Me.TxtTelefono1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtDireccion, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtEMail, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.DpFecha, 0)
        Me.Controls.SetChildIndex(Me.CbNacionalidad, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.Label29, 0)
        Me.Controls.SetChildIndex(Me.CbEstado, 0)
        Me.Controls.SetChildIndex(Me.Label32, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaBancaria, 0)
        Me.Controls.SetChildIndex(Me.ckCedula, 0)
        Me.Controls.SetChildIndex(Me.txtNuevaCedula, 0)
        Me.Controls.SetChildIndex(Me.Label37, 0)
        Me.Controls.SetChildIndex(Me.Label38, 0)
        Me.Controls.SetChildIndex(Me.txthuella, 0)
        Me.Controls.SetChildIndex(Me.txttarjeta, 0)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DsEmpleado1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoDeducion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.txtCuentaContableTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaContablePorcentaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaContableDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaContable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TextEditSRD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSueldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Variable"
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
#End Region

#Region "Load"
    Private Sub FrmEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
            SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Seguridad", "Conexion")
            Me.DaNacionalidad.Fill(Me.DsEmpleado1, "Nacionalidad")
            Me.DaDepartamento.Fill(Me.DsEmpleado1, "Departamento")
            Me.DaMoneda.Fill(Me.DsEmpleado1, "Moneda")
            Me.adMoneda2.Fill(Me.DsEmpleado1, "Moneda2")
            Me.DaEstado.Fill(Me.DsEmpleado1, "Estado_Empleado")
            BuscaHorasOrdinarias()
            DefaulValue() 'valores por defecto
            bindings()
            Bloquear()
            Bloquear_Detalle()
            ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(4).Enabled = False
            ToolBar1.Buttons(5).Enabled = False
            txtNuevaCedula.Visible = False
            DesactivarGUICuentaContable()

        Catch ex As Exception
            MsgBox(ex.Message)
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub BuscaHorasOrdinarias()
        Dim sqlConexion2 As New SqlConnection
        Dim cConexion2 As New Conexion
        Dim rsa As SqlDataReader
        Try
            sqlConexion2 = cConexion2.Conectar("Planilla")
            rsa = cConexion2.GetRecorset(sqlConexion2, "SELECT Horas, Individual FROM Horas_Ordinarias")

            If rsa.Read Then
                Try
                    HORAS_ORD = rsa("Horas")
                    HORA_IND = rsa("Individual")

                Catch ex As System.Exception
                    MsgBox(ex.Message)
                End Try
            End If
            rsa.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cConexion2.DesConectar(cConexion2.Conectar)
        End Try
    End Sub

    Function bindings()
        Try
            Me.cbMonedaDeduccion.DataSource = Me.DsEmpleado1.Moneda2
            Me.cbMonedaDeduccion.DisplayMember = "MonedaNombre"
            Me.cbMonedaDeduccion.ValueMember = "CodMoneda"
            Me.CbNacionalidad.DataSource = Me.DsEmpleado1.Nacionalidad
            Me.CbNacionalidad.DisplayMember = "descripcion"
            Me.CbNacionalidad.ValueMember = "codigo"
            Me.CbDepartamento.DataSource = Me.DsEmpleado1.Departamento
            Me.CbDepartamento.DisplayMember = "Departamento"
            Me.CbDepartamento.ValueMember = "Id"
            Me.CbMoneda.DataSource = Me.DsEmpleado1.Moneda
            Me.CbMoneda.DisplayMember = "MonedaNombre"
            Me.CbMoneda.ValueMember = "CodMoneda"
            Me.CbEstado.DataSource = Me.DsEmpleado1.Estado_Empleado
            Me.CbEstado.DisplayMember = "Descripcion"
            Me.CbEstado.ValueMember = "Codigo"
            'Empleado
            Me.CbEstadoCivil.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Estado_Civil"))
            Me.DpFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Fecha_Nacimiento"))
            Me.TxtEMail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Email"))
            Me.TxtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Direccion"))
            Me.TxtTelefono2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Telefono2"))
            Me.TxtTelefono1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Telefono1"))
            Me.TxtEdad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Edad"))
            Me.TxtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Nombre"))
            Me.txtCuentaBancaria.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.CuentaBancaria"))
            Me.TxtIdentificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Identificacion"))
            Me.DPFecha_Ingreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Fecha_Ingreso"))
            Me.txtFechaSalida.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Fecha_Salida"))
            Me.TxtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Puesto"))
            Me.TxtHijos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Hijos"))
            Me.CkFemenino.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsEmpleado1, "Empleado.Femenino"))
            Me.CkMasculino.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsEmpleado1, "Empleado.Masculino"))
            Me.CkMensual.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsEmpleado1, "Empleado.Mensual"))
            Me.CkSemanal.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsEmpleado1, "Empleado.Semana"))
            Me.CkQuincena.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsEmpleado1, "Empleado.Quincena"))
            Me.CkDiario.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsEmpleado1, "Empleado.Diario"))
            Me.Ckhora.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsEmpleado1, "Empleado.Hora"))
            Me.CbNacionalidad.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsEmpleado1, "Empleado.Cod_Nacionalidad"))
            Me.CbDepartamento.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsEmpleado1, "Empleado.Cod_Departamento"))
            Me.CbMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsEmpleado1, "Empleado.Cod_Moneda"))
            Me.txtSueldo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsEmpleado1, "Empleado.Salario"))
            Me.CbEstado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsEmpleado1, "Empleado.Cod_Estado"))
            Me.Check_ServiciosProf.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsEmpleado1, "Empleado.ServiciosProf"))
            Me.NuHoras.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsEmpleado1, "Empleado.HorasOrdinarias"))
            Me.ckCedula.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsEmpleado1, "Empleado.CambioCedula"))
            Me.txtNuevaCedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.NuevaCedula"))
            Me.txthuella.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Pin_Huella"))
            Me.txttarjeta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.Pin_tarjeta"))
            Me.TextEditSRD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.SRD"))

            'Detalles Empleado
            Me.txtCodDeduccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones.Codigo"))
            Me.cbMonedaDeduccion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones.Cod_Moneda"))
            Me.cbTipoDed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones.Tipo"))
            Me.txtMontoDeducion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones.Monto"))
            Me.txtNombreDeduccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones.Descripcion"))
            Me.txtAño.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico.Año"))
            Me.txtNivel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico.Nivel"))
            Me.txtInstitucion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico.Institucion"))
            Me.txtTitulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico.Titulo"))
            Me.dtVencimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias.Vencimiento"))
            Me.dtEmision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias.Emision"))
            Me.txtTipoLicencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias.Tipo"))
            Me.txtLicencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias.Numero"))



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

#Region "DefaulValue"
    Function DefaulValue()
        'Tabla Empleado
        Me.DsEmpleado1.Empleado.IdentificacionColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado.Pin_HuellaColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado.Pin_tarjetaColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado.NombreColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado.CuentaBancariaColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado.Estado_CivilColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado.HijosColumn.DefaultValue = 0
        Me.DsEmpleado1.Empleado.Cod_NacionalidadColumn.DefaultValue = DsEmpleado1.Nacionalidad.Rows(0).Item("Codigo")
        Me.DsEmpleado1.Empleado.Fecha_NacimientoColumn.DefaultValue = Now
        Me.DsEmpleado1.Empleado.EdadColumn.DefaultValue = 0
        Me.DsEmpleado1.Empleado.Telefono1Column.DefaultValue = ""
        Me.DsEmpleado1.Empleado.Telefono2Column.DefaultValue = ""
        Me.DsEmpleado1.Empleado.EmailColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado.DireccionColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado.PuestoColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado.Fecha_IngresoColumn.DefaultValue = Now
        Me.DsEmpleado1.Empleado.Fecha_SalidaColumn.DefaultValue = Now
        Me.DsEmpleado1.Empleado.SalarioColumn.DefaultValue = 0
        Me.DsEmpleado1.Empleado.Cod_DepartamentoColumn.DefaultValue = DsEmpleado1.Departamento.Rows(0).Item("Id")
        Me.DsEmpleado1.Empleado.MasculinoColumn.DefaultValue = "True"
        Me.DsEmpleado1.Empleado.FemeninoColumn.DefaultValue = "False"
        Me.DsEmpleado1.Empleado.HoraColumn.DefaultValue = True
        Me.DsEmpleado1.Empleado.DiarioColumn.DefaultValue = False
        Me.DsEmpleado1.Empleado.SemanaColumn.DefaultValue = False
        Me.DsEmpleado1.Empleado.QuincenaColumn.DefaultValue = False
        Me.DsEmpleado1.Empleado.MensualColumn.DefaultValue = False
        Me.DsEmpleado1.Empleado.Cod_EstadoColumn.DefaultValue = DsEmpleado1.Estado_Empleado.Rows(0).Item("Codigo")
        Me.DsEmpleado1.Empleado.Cod_MonedaColumn.DefaultValue = DsEmpleado1.Moneda.Rows(0).Item("CodMoneda")
        Me.DsEmpleado1.Empleado.ServiciosProfColumn.DefaultValue = False
        Me.DsEmpleado1.Empleado.id_usuarioColumn.DefaultValue = usua.cedula
        Me.DsEmpleado1.Empleado.HorasOrdinariasColumn.DefaultValue = HORAS_ORD
        Me.DsEmpleado1.Empleado.CambioCedulaColumn.DefaultValue = False
        Me.DsEmpleado1.Empleado.NuevaCedulaColumn.DefaultValue = ""

        'Tabla Empleado_Deducciones
        Me.DsEmpleado1.Empleado_Deducciones.IdentificacionColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado_Deducciones.CodigoColumn.DefaultValue = 0
        Me.DsEmpleado1.Empleado_Deducciones.DescripcionColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado_Deducciones.MontoColumn.DefaultValue = 0
        Me.DsEmpleado1.Empleado_Deducciones.TipoColumn.DefaultValue = "%"
        Me.DsEmpleado1.Empleado_Deducciones.Cod_MonedaColumn.DefaultValue = 1

        'Tabla Empleado_Academico
        Me.DsEmpleado1.Empleado_Academico.IdentificacionColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado_Academico.TituloColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado_Academico.NivelColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado_Academico.InstitucionColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado_Academico.AñoColumn.DefaultValue = 0

        'Tabla Empleado_Licencias
        Me.DsEmpleado1.Empleado_Licencias.IdentificacionColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado_Licencias.NumeroColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado_Licencias.TipoColumn.DefaultValue = ""
        Me.DsEmpleado1.Empleado_Licencias.EmisionColumn.DefaultValue = Now
        Me.DsEmpleado1.Empleado_Licencias.VencimientoColumn.DefaultValue = Now

        'Tabla Distribucion_Contable
        Me.DsEmpleado1.DistribucionContable.EmpleadoIdentificacionColumn.DefaultValue = ""
        Me.DsEmpleado1.DistribucionContable.IdDepartamentoColumn.DefaultValue = 0
        Me.DsEmpleado1.DistribucionContable.DepartamentoColumn.DefaultValue = ""
        Me.DsEmpleado1.DistribucionContable.PorcentajeColumn.DefaultValue = 0
    End Function
#End Region

#End Region

#Region "Principal"
    Private Function Nuevo()
        LimpiarCuentaContable()
        CbEstado.Enabled = True
        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            'cambia la imagen de nuevo y desabilita los botones
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Try 'inicia la edicion

                Me.DsEmpleado1.Empleado_Academico.Clear()
                Me.DsEmpleado1.Empleado_Deducciones.Clear()
                Me.DsEmpleado1.Empleado_Licencias.Clear()

                Me.BindingContext(Me.DsEmpleado1, "Empleado").CancelCurrentEdit()
                Me.BindingContext(Me.DsEmpleado1, "Empleado").EndCurrentEdit()
                Me.BindingContext(Me.DsEmpleado1, "Empleado").AddNew()

                Me.ToolBar1.Buttons(1).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = True
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.ToolBar1.Buttons(5).Enabled = False

                Desbloquear()
                Me.CbNacionalidad.SelectedIndex = -1
                Me.CbDepartamento.SelectedIndex = -1
                Me.CbEstado.SelectedIndex = -1
                TxtIdentificacion.Focus()

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                Me.BindingContext(Me.DsEmpleado1, "Empleado").CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False
                LHoras.Visible = False
                NuHoras.Visible = False
                Bloquear()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Function
    Private Function Buscar()
        Dim funcion As New cFunciones
        Dim Id As String

        Try
            If Me.BindingContext(Me.DsEmpleado1, "Empleado").Count > 0 Then
                If (MsgBox("Actualmente se está realizando un ingreso Nuevo, si continúa se perderan los datos, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Function
                End If
            End If

            Me.DsEmpleado1.Empleado_Academico.Clear()
            Me.DsEmpleado1.Empleado_Deducciones.Clear()
            Me.DsEmpleado1.Empleado_Licencias.Clear()
            Me.DsEmpleado1.DistribucionContable.Clear()
            Me.DsEmpleado1.Empleado.Clear()
            LHoras.Visible = False
            NuHoras.Visible = False

            Id = funcion.BuscarDatosEmpleados("Select Identificacion As Identificación, Nombre from Empleado", "Nombre", " ORDER BY Nombre", "Buscar Empleado ...", SqlConnection.ConnectionString)
            buscando = True
            If Id = "0" Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Function
            End If
            LimpiarCuentaContable()

            Me.LlenarEmpleado(Id)
            Desbloquear()
            'DesActivarControlesSucursales()
            'nuevo
            Me.ToolBar1.Buttons(0).Enabled = True
            'buscar
            Me.ToolBar1.Buttons(1).Enabled = True
            'editar
            Me.ToolBar1.Buttons(2).Enabled = True
            'registrar
            Me.ToolBar1.Buttons(3).Enabled = False
            'eliminar
            Me.ToolBar1.Buttons(4).Enabled = True
            'Imprimir
            Me.ToolBar1.Buttons(5).Enabled = True
            'Cerrar
            Me.ToolBar1.Buttons(6).Enabled = True

            If Me.BindingContext(Me.DsEmpleado1, "Empleado").Current("Cod_Estado") = 2 Then
                Me.txtFechaSalida.Visible = True
            Else
                Me.txtFechaSalida.Visible = False
            End If
            phuella = Me.txthuella.Text
            ptarjeta = Me.txttarjeta.Text
            LLenarGridCuentaContable()
            DesactivarGUICuentaContable()
            Bloquear() : Bloquear_Detalle()
        Catch ex As SystemException
            MsgBox(ex.Message)
            Console.WriteLine(ex.StackTrace)
        End Try
    End Function
    Function Editar()

        Me.Desbloquear()
        Me.Desbloquear_Detalle()
        ActivarGuiCuentaContable()
        'nuevo
        Me.ToolBar1.Buttons(0).Enabled = True
        'buscar
        Me.ToolBar1.Buttons(1).Enabled = False
        'editar
        Me.ToolBar1.Buttons(2).Enabled = False
        'registrar
        Me.ToolBar1.Buttons(3).Enabled = True
        'eliminar
        Me.ToolBar1.Buttons(4).Enabled = True
        'Imprimir
        Me.ToolBar1.Buttons(5).Enabled = True
        'Cerrar
        Me.ToolBar1.Buttons(6).Enabled = True
    End Function
    Function LlenarEmpleado(ByVal Id As String)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        'Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''LLENAR EMPLEADO''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Empleado WHERE (Identificacion = @Id_Empleado)"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Empleado", SqlDbType.VarChar))
            cmdv.Parameters("@Id_Empleado").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DsEmpleado1, "Empleado")
            '''''''''LLENAR DEDUCCIONES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sel = "SELECT * FROM Empleado_Deducciones WHERE (Identificacion = @Id_Empleado) "
            cmd.CommandText = sel
            cmd.Connection = cnnv
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Id_Empleado", SqlDbType.VarChar))
            cmd.Parameters("@Id_Empleado").Value = Id
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(Me.DsEmpleado1.Empleado_Deducciones)
            '''''''''LLENAR ACADEMICO''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Creamos el comando para la consulta
            Dim cmda As SqlCommand = New SqlCommand
            sel = "SELECT * FROM Empleado_Academico WHERE (Identificacion = @Id_Empleado) "
            cmda.CommandText = sel
            cmda.Connection = cnnv
            cmda.CommandType = CommandType.Text
            cmda.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmda.Parameters.Add(New SqlParameter("@Id_Empleado", SqlDbType.VarChar))
            cmda.Parameters("@Id_Empleado").Value = Id
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim daa As New SqlDataAdapter
            daa.SelectCommand = cmda
            ' Llenamos la tabla
            daa.Fill(Me.DsEmpleado1.Empleado_Academico)
            '''''''''LLENAR LICENCIAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Creamos el comando para la consulta
            Dim cmdl As SqlCommand = New SqlCommand
            sel = "SELECT * FROM Empleado_Licencias WHERE (Identificacion = @Id_Empleado) "
            cmdl.CommandText = sel
            cmdl.Connection = cnnv
            cmdl.CommandType = CommandType.Text
            cmdl.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdl.Parameters.Add(New SqlParameter("@Id_Empleado", SqlDbType.VarChar))
            cmdl.Parameters("@Id_Empleado").Value = Id
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dal As New SqlDataAdapter
            dal.SelectCommand = cmdl
            ' Llenamos la tabla
            dal.Fill(Me.DsEmpleado1.Empleado_Licencias)
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
    Private Function Guardar()
        If Validar() = False Then
            Exit Function
        End If
        If Me.SqlConnection.State <> Me.SqlConnection.State.Open Then Me.SqlConnection.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection.BeginTransaction
        Try

            If buscando = False Then
                Dim Cx As New Conexion
                Dim valida As String
                Dim cedula As String = Me.TxtIdentificacion.Text
                valida = Cx.SlqExecuteScalar(Cx.Conectar("Planilla"), "SELECT Identificacion FROM Empleado WHERE Identificacion= '" & cedula & "'")
                Cx.DesConectar(Cx.sQlconexion)
                If valida = "" Then ' se verifica si la factura seleccionada puede ser eliminada
                Else
                    MessageBox.Show("La cédula digitada ya existe, por favor revisela....", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Exit Function
                End If
            End If
            'finaliza la edición
            Me.BindingContext(Me.DsEmpleado1, "Empleado").Current("Salario") = Math.Round(txtSueldo.EditValue, 2)
            Me.BindingContext(Me.DsEmpleado1, "Empleado").EndCurrentEdit()

            Me.DaEmpleado.UpdateCommand.Transaction = Trans
            Me.DaEmpleado.InsertCommand.Transaction = Trans
            Me.DaEmpleado.DeleteCommand.Transaction = Trans

            Me.DaDeducciones.InsertCommand.Transaction = Trans
            Me.DaDeducciones.DeleteCommand.Transaction = Trans

            Me.DaAcademico.UpdateCommand.Transaction = Trans
            Me.DaAcademico.InsertCommand.Transaction = Trans
            Me.DaAcademico.DeleteCommand.Transaction = Trans

            Me.DaLicencia.UpdateCommand.Transaction = Trans
            Me.DaLicencia.InsertCommand.Transaction = Trans
            Me.DaLicencia.DeleteCommand.Transaction = Trans

            Me.BindingContext(Me.DsEmpleado1, "Empleado").EndCurrentEdit()
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones").EndCurrentEdit()
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico").EndCurrentEdit()
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias").EndCurrentEdit()

            Me.DaEmpleado.Update(Me.DsEmpleado1.Empleado)
            Me.DaDeducciones.Update(Me.DsEmpleado1.Empleado_Deducciones)
            Me.DaAcademico.Update(Me.DsEmpleado1.Empleado_Academico)
            Me.DaLicencia.Update(Me.DsEmpleado1.Empleado_Licencias)
            Trans.Commit()
            AgregarCuentaContableBD()
            Me.DsEmpleado1.AcceptChanges()
            MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Me.Bloquear()
            LHoras.Visible = False
            NuHoras.Visible = False
            Me.TabPage1.Enabled = False
            'nuevo
            Me.ToolBar1.Buttons(0).Enabled = True
            'buscar
            Me.ToolBar1.Buttons(1).Enabled = True
            'Editar
            Me.ToolBar1.Buttons(2).Enabled = False
            'registrar
            Me.ToolBar1.Buttons(3).Enabled = False
            'eliminar
            Me.ToolBar1.Buttons(4).Enabled = False
            'Imprimir
            Me.ToolBar1.Buttons(5).Enabled = False
            'cerrar
            Me.ToolBar1.Buttons(6).Enabled = True
            Me.DsEmpleado1.Empleado_Deducciones.Clear()
            Me.DsEmpleado1.Empleado_Academico.Clear()
            Me.DsEmpleado1.Empleado_Licencias.Clear()
            Me.DsEmpleado1.DistribucionContable.Clear()
            Me.DsEmpleado1.Empleado.Clear()
            Me.LimpiarCuentaContable()


        Catch ex As Exception
            MsgBox(ex.ToString)
            Trans.Rollback()
        End Try
    End Function
    Private Sub eliminar()
        Try
            Dim Cconexion As New Conexion
            ''-*********************************************************
            'Evaluo si el Empleado tiene proyectos asignados si es asi no podra eliminarse este empleado 
            'hasta que se le elimine el proyecto asignado
            If Me.BindingContext(DsEmpleado1.Empleado).Count > 0 Then

                'Obtengo el id del usuario actual que se desea eliminar
                Dim strDel As String = Me.BindingContext(DsEmpleado1.Empleado).Current("Identificacion")
                Dim rs As SqlDataReader
                'Ejecuto la instruccion y si me devuelve datos indicara que el usuario tiene asignados proyectos
                rs = Cconexion.GetRecorset(Cconexion.Conectar("Planilla"), "SELECT id FROM Empleado_Proyecto WHERE Identificacion = '" & strDel & "'")
                If rs.Read() Then
                    MsgBox("Este Empleado no puede ser eliminado por que tiene proyectos asignados", MsgBoxStyle.Exclamation, "Error...")
                    rs.Close()
                    Exit Sub
                End If
                rs.Close()
            End If

            '-*********************************************************


            Dim Resultado As String
            If Me.TxtNombre.Text <> "" Then
                If MessageBox.Show(" ¿ Desea Eliminar este Empleado ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub
                Try
                    Resultado = Cconexion.SlqExecute(Cconexion.Conectar, "Delete from Empleado where Identificacion='" & Me.TxtIdentificacion.Text & "'")
                Catch EX As Exception
                    MessageBox.Show(" El empleado que se intento eliminar, Informacion pendiente", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                EliminarCuentaContableBD()
                If Resultado = vbNullString Then
                    MessageBox.Show("El empleado fue eliminado", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DsEmpleado1.Empleado_Academico.Clear()
                    Me.DsEmpleado1.Empleado_Deducciones.Clear()
                    Me.DsEmpleado1.Empleado_Licencias.Clear()
                    Me.DsEmpleado1.Empleado.Clear()
                    Me.Bloquear_Detalle()
                    Me.Bloquear()
                    'nuevo
                    Me.ToolBar1.Buttons(0).Enabled = True
                    'buscar
                    Me.ToolBar1.Buttons(1).Enabled = True
                    'editar
                    Me.ToolBar1.Buttons(2).Enabled = False
                    'registrar
                    Me.ToolBar1.Buttons(3).Enabled = False
                    'eliminar
                    Me.ToolBar1.Buttons(4).Enabled = False
                    'imprimir
                    Me.ToolBar1.Buttons(5).Enabled = False
                    'Cerrar
                    Me.ToolBar1.Buttons(6).Enabled = True
                    Me.LimpiarCuentaContable()
                Else
                    MessageBox.Show(Resultado)
                    Exit Sub
                End If
            Else
                MessageBox.Show("No hay empleado a eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
    Private Function imprimir()
        Try
            Dim Imprimir_Empleado As New ReporteEmpleado
            Dim visor As New frmVisorReportes
            p = Me.TxtIdentificacion.Text
            Imprimir_Empleado.SetParameterValue(0, p)
            Utilidades.CrystalReportsConexion.LoadShow(Imprimir_Empleado, Me.MdiParent, Me.SqlConnection1.ConnectionString)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
            Console.WriteLine(ex.StackTrace)
        End Try
    End Function
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()

            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : Editar()

            Case 4 : If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Delete Then eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 7 : Me.Close()

        End Select
    End Sub
#End Region

#Region "Bloquear Controles"
    Private Sub Bloquear_Detalle()
        TabPage1.Enabled = False
        TabPage3.Enabled = False
        TabPage4.Enabled = False
    End Sub

    Private Sub Desbloquear_Detalle()
        TabPage1.Enabled = True
        TabPage3.Enabled = True
        TabPage4.Enabled = True
        Me.tbbCuentaContableEliminar.Enabled = True
        Me.tbbCuentaContableGuardar.Enabled = True
        Me.tbbCuentaContableNuevo.Enabled = True
    End Sub

    Private Sub ActivarGuiCuentaContable()
        Me.tbbCuentaContableEliminar.Enabled = True
        Me.tbbCuentaContableNuevo.Enabled = True
        Me.tbbCuentaContableGuardar.Enabled = True
    End Sub

    Private Sub DesactivarGUICuentaContable()
        Me.tbbCuentaContableEliminar.Enabled = False
        Me.tbbCuentaContableNuevo.Enabled = False
        Me.tbbCuentaContableGuardar.Enabled = False
    End Sub

#End Region

#Region "Funciones"
    Function Bloquear()
        Me.TxtDescripcion.Enabled = False
        Me.TxtDireccion.Enabled = False
        Me.txtCuentaBancaria.Enabled = False
        Me.TxtEdad.Enabled = False
        Me.TxtEMail.Enabled = False
        Me.TxtHijos.Enabled = False
        Me.TxtIdentificacion.Enabled = False
        Me.TxtNombre.Enabled = False
        Me.txtSueldo.Enabled = False
        Me.TxtTelefono1.Enabled = False
        Me.TxtTelefono2.Enabled = False
        Me.CbDepartamento.Enabled = False
        Me.CbEstadoCivil.Enabled = False
        Me.CbNacionalidad.Enabled = False
        Me.GroupBox4.Enabled = False
        Me.GroupBox3.Enabled = False
        Me.DpFecha.Enabled = False
        Me.DPFecha_Ingreso.Enabled = False
        Me.txtFechaSalida.Enabled = False
        Me.CbEstado.Enabled = False
        Me.Check_ServiciosProf.Enabled = False
        Me.ckCedula.Enabled = False
        Me.txtNuevaCedula.Enabled = False
        Me.txthuella.Enabled = False
        Me.txttarjeta.Enabled = False
    End Function

    Function Desbloquear()
        Me.TxtDescripcion.Enabled = True
        Me.DPFecha_Ingreso.Enabled = True
        Me.TxtDireccion.Enabled = True
        Me.TxtEMail.Enabled = True
        Me.TxtHijos.Enabled = True
        Me.txtCuentaBancaria.Enabled = True
        Me.TxtIdentificacion.Enabled = True
        Me.TxtNombre.Enabled = True
        Me.txtSueldo.Enabled = True
        Me.TxtTelefono1.Enabled = True
        Me.TxtTelefono2.Enabled = True
        Me.CbDepartamento.Enabled = True
        Me.CbEstadoCivil.Enabled = True
        Me.CbNacionalidad.Enabled = True
        Me.GroupBox4.Enabled = True
        Me.GroupBox3.Enabled = True
        Me.DpFecha.Enabled = True
        Me.txtFechaSalida.Enabled = True
        Me.Check_ServiciosProf.Enabled = True
        Me.ckCedula.Enabled = True
        Me.txtNuevaCedula.Enabled = True
        Me.txthuella.Enabled = True
        Me.txttarjeta.Enabled = True
    End Function
#End Region

#Region "Funciones Controles"

#Region "KeyDown"
    Private Sub TxtIdentificacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtIdentificacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Cx As New Conexion
            Dim valida As String
            Dim cedula As String = Me.TxtIdentificacion.Text
            valida = Cx.SlqExecuteScalar(Cx.Conectar("Planilla"), "SELECT Identificacion FROM Empleado WHERE Identificacion= '" & cedula & "'")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then ' se verifica si la factura seleccionada puede ser eliminada
                TxtNombre.Focus()
            Else
                MessageBox.Show("La cédula digitada ya existe, por favor revisela....", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub TxtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            CbEstadoCivil.Focus()
        End If
    End Sub

    Private Sub TxtHijos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtHijos.KeyDown
        If e.KeyCode = Keys.Enter Then
            CbNacionalidad.Focus()
        End If
    End Sub

    Private Sub CbNacionalidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbNacionalidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DpFecha.Focus()
        End If
    End Sub

    Private Sub DpFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DpFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtEdad.Text = CalculoEdad(DpFecha.Text)
            TxtTelefono1.Focus()
        End If
    End Sub

    Private Sub TxtEdad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEdad.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTelefono1.Focus()
        End If
    End Sub

    Private Sub TxtTelefono1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTelefono1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTelefono2.Focus()
        End If
    End Sub

    Private Sub TxtTelefono2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTelefono2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtEMail.Focus()
        End If
    End Sub

    Private Sub TxtEMail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEMail.KeyDown
        If e.KeyCode = Keys.Enter Then
            CbEstado.Focus()
        End If
    End Sub

    Private Sub TxtDireccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDireccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtCuentaBancaria.Focus()
        End If
    End Sub

    Private Sub TxtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If DPFecha_Ingreso.Enabled = True Then
                DPFecha_Ingreso.Focus()
            Else
                CbDepartamento.Focus()
            End If
        End If
    End Sub

    Private Sub CbDepartamento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbDepartamento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSueldo.Focus()
        End If
    End Sub

    Private Sub txtSueldo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSueldo.KeyDown
        If e.KeyCode = Keys.Enter Then
            CbMoneda.Focus()
        End If
    End Sub

    Private Sub CbMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbMoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Validar() = False Then Exit Sub
            Me.BindingContext(Me.DsEmpleado1, "Empleado").EndCurrentEdit()
            Desbloquear_Detalle()
        End If
    End Sub

    Private Sub CkMasculino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CkMasculino.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtHijos.Focus()
        End If
    End Sub

    Private Sub CkFemenino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CkFemenino.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtHijos.Focus()
        End If
    End Sub

    Private Sub cbTipoDed_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbTipoDed.KeyDown
        If e.KeyCode = Keys.Enter Then
            For Each fila As DataRow In Me.DsEmpleado1.Empleado_Deducciones.Rows
                If fila.Item("Codigo") = Me.txtCodDeduccion.Text Then
                    MsgBox("La deduccion ya esta registrada para este empleado", MsgBoxStyle.Exclamation, "No se puede realizar la operacion")
                    Exit Sub
                End If
            Next
            Me.RegistrarDeduccion()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones").CancelCurrentEdit()
        End If
    End Sub

    Private Sub txtDeducion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombreDeduccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMontoDeducion.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones").CancelCurrentEdit()
        End If
    End Sub

    Private Sub txtMontoDeducion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoDeducion.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbMonedaDeduccion.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones").CancelCurrentEdit()
        End If
    End Sub

    Private Sub txtTitulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTitulo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNivel.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico").CancelCurrentEdit()
        End If
    End Sub

    Private Sub txtNivel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNivel.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtInstitucion.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico").CancelCurrentEdit()
        End If
    End Sub

    Private Sub txtInstitucion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInstitucion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAño.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico").CancelCurrentEdit()
        End If
    End Sub

    Private Sub txtAño_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAño.KeyDown
        If e.KeyCode = Keys.Enter Then
            RegistrarAcademico()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico").CancelCurrentEdit()
        End If
    End Sub

    Private Sub txtLicencia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLicencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTipoLicencia.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias").CancelCurrentEdit()
        End If
    End Sub

    Private Sub txtTipoLicencia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoLicencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtEmision.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias").CancelCurrentEdit()
        End If
    End Sub

    Private Sub dtEmision_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            dtVencimiento.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias").CancelCurrentEdit()
        End If
    End Sub

    Private Sub dtVencimiento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            RegistrarLicencia()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias").CancelCurrentEdit()
        End If
    End Sub

    Private Sub CbEstado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbEstado.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CbEstado.Text = "ACTIVO" Then
                DPFecha_Ingreso.Enabled = True
            Else
                DPFecha_Ingreso.Enabled = False
                DPFecha_Ingreso.Value = Now.Date
            End If
            TxtDireccion.Focus()
        End If
    End Sub

    Private Sub txtCodDeduccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodDeduccion.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                Dim cFunciones As New cFunciones
                Dim c As Integer

                c = cFunciones.BuscarDatos("select Codigo as Identificación,Descripcion as Nombre from Deducciones", "Descripcion", "Buscar Deducciones ...", SqlConnection.ConnectionString)

                If c <> 0 Then
                    Me.txtCodDeduccion.Text = c
                    BuscarDeduccion()
                Else
                    Exit Sub
                End If
            Catch ex As System.Exception
                MsgBox(ex.Message)
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarDeduccion()
            txtMontoDeducion.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones").CancelCurrentEdit()
        End If
    End Sub

    Private Sub dtEmision_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtEmision.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtVencimiento.Focus()
        End If
    End Sub

    Private Sub dtVencimiento_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtVencimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            RegistrarLicencia()
        End If
    End Sub

    Private Sub txtCuentaBancaria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaBancaria.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDescripcion.Focus()
        End If
    End Sub

    Private Sub cbMonedaDeduccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbMonedaDeduccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbTipoDed.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones").CancelCurrentEdit()
        End If
    End Sub

    Private Sub txtCuentaContable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContable.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContable()
        End If
    End Sub

    Private Sub txtCuentaContablePorcentaje_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContablePorcentaje.KeyDown
        If e.KeyCode = Keys.Enter Then
            RegistrarCuentaContable()
        End If
    End Sub

    Private Sub DPFecha_Ingreso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DPFecha_Ingreso.KeyDown
        If CbEstado.Text <> "ACTIVO" Then
            MsgBox("Solo el estado Activo permite cambiar esta casilla cambie el estado primero", MsgBoxStyle.Information, "Servicios Estructurales")
            CbDepartamento.Focus()
        End If
        If e.KeyCode = Keys.Enter Then
            CbDepartamento.Focus()
        End If
    End Sub

    Private Sub CbEstadoCivil_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbEstadoCivil.KeyDown
        If e.KeyCode = Keys.Enter Then
            CkMasculino.Focus()
        End If
    End Sub


    Private Sub NuHoras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NuHoras.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSueldo.Focus()
        End If
    End Sub
#End Region

#Region "KeyPress"
    Private Sub TxtHijos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHijos.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtEdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEdad.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtTelefono1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono1.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtTelefono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono2.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-"c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub txtSueldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSueldo.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "."c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub cbTipoDed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbTipoDed.KeyPress
        If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Or Not (e.KeyChar = Convert.ToChar(Keys.Enter)) Then e.Handled = True
    End Sub

    Private Sub CbEstadoCivil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbEstadoCivil.KeyPress
        If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Or Not (e.KeyChar = Convert.ToChar(Keys.Enter)) Then e.Handled = True
    End Sub

    Private Sub txtCodDeduccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodDeduccion.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub
#End Region

#Region "CheckedChanged"
    Private Sub Ckhora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckhora.CheckedChanged
        LHoras.Visible = HORA_IND
        NuHoras.Visible = HORA_IND

        If HORA_IND Then
            NuHoras.Focus()
        Else
            txtSueldo.Focus()
        End If
    End Sub

    Private Sub CkDiario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkDiario.CheckedChanged
        LHoras.Visible = False
        NuHoras.Visible = False
        txtSueldo.Focus()
    End Sub

    Private Sub CkSemanal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkSemanal.CheckedChanged
        LHoras.Visible = False
        NuHoras.Visible = False
        txtSueldo.Focus()
    End Sub

    Private Sub CkQuincena_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkQuincena.CheckedChanged
        LHoras.Visible = False
        NuHoras.Visible = False
        txtSueldo.Focus()
    End Sub

    Private Sub CkMensual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkMensual.CheckedChanged
        LHoras.Visible = False
        NuHoras.Visible = False
        txtSueldo.Focus()
    End Sub
#End Region

#End Region

#Region "Funciones"
    Function CalculoEdad(ByVal FechaNacimiento As Date)
        Dim Años As Int16
        Años = DateDiff(DateInterval.Year, FechaNacimiento, Date.Now)
        If Date.Now.Month < FechaNacimiento.Month Or (Date.Now.Month = FechaNacimiento.Month And Date.Now.Day < FechaNacimiento.Day) Then
            Años = Años - 1
        End If
        CalculoEdad = Años
    End Function

    Function Validar() As Boolean
        Validar = True
        If TxtIdentificacion.Text = "" Then
            MsgBox("Debe ingresar el número de Cédula o Pasaporte", MsgBoxStyle.Information, "Atención...")
            Validar = False : Exit Function
        End If
        If TxtNombre.Text = "" Then
            MsgBox("Debe ingresar el nombre del empleado", MsgBoxStyle.Information, "Atención...")
            Validar = False : Exit Function
        End If
        If CbEstadoCivil.Text = "" Then
            MsgBox("Debe ingresar el estado civil del empleado", MsgBoxStyle.Information, "Atención...")
            Validar = False : Exit Function
        End If

        If CkMasculino.Checked = False And CkFemenino.Checked = False Then
            MsgBox("Debe escoger el sexo del empleado", MsgBoxStyle.Information, "Atención...")
            Validar = False : Exit Function
        End If

        If CbNacionalidad.Text = "" Then
            MsgBox("Debe de escoger la nacionalidad del empleado", MsgBoxStyle.Information, "Atención...")
            Validar = False : Exit Function
        End If

        If TxtEdad.Text < 18 Then
            If MsgBox("Revise la fecha de nacimiento, puede estar mala, desea continuar?", MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.No Then
                Validar = False : Exit Function
            End If
        End If

        If TxtDescripcion.Text = "" Then
            MsgBox("Ingrese el puesto del empleado", MsgBoxStyle.Information, "Atención...")
            Validar = False : Exit Function
        End If

        If CbDepartamento.Text = "" Then
            MsgBox("Ingrese el Departamento del empleado", MsgBoxStyle.Information, "Atención...")
            Validar = False : Exit Function
        End If

        If Ckhora.Checked = False And CkDiario.Checked = False And CkSemanal.Checked = False And CkQuincena.Checked = False And CkMensual.Checked = False Then
            MsgBox("Escoga la forma de pago", MsgBoxStyle.Information, "Atención...")
            Validar = False : Exit Function
        End If

        If txtSueldo.Text = "" Or txtSueldo.Text <= 0 Then
            MsgBox("El monto del salario tiene que ser mayor que 0", MsgBoxStyle.Information, "Atención...")
            Validar = False : Exit Function
        End If

        If CbMoneda.Text = "" Then
            MsgBox("Escoga la moneda", MsgBoxStyle.Information, "Atención...")
            Validar = False : Exit Function
        End If

        If CbEstado.Text = "ACTIVO" And DPFecha_Ingreso.Value = Now.Date Then
            MsgBox("Debe cambiar la fecha de ingreso al sistema", MsgBoxStyle.Information, "Atención...")
            DPFecha_Ingreso.Enabled = True
            DPFecha_Ingreso.Focus()
            Validar = False : Exit Function
        End If

        If ckCedula.Checked = True Then
            If txtNuevaCedula.Text = "" Then
                MsgBox("Debe digitar la nueva cédula", MsgBoxStyle.Information, "Atención...")
                txtNuevaCedula.Focus()
                Validar = False : Exit Function
            End If
        End If
        If Me.txthuella.Text <> "0" And Me.txthuella.Text <> "" Then
            Dim cx As New Conexion
            Dim huella As String = ""
            Try
                huella = cx.SlqExecuteScalar(cx.Conectar("Planilla"), "SELECT Pin_Huella FROM Empleado WHERE Pin_Huella = '" + Me.txthuella.Text + "'")
                If huella <> "" And huella <> phuella Then
                    MsgBox("Pin Huella ya se encuentra en uso", MsgBoxStyle.Information)
                    txthuella.Focus()
                    Validar = False : Exit Function
                End If
                cx.DesConectar(cx.sQlconexion)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
        If Me.txttarjeta.Text <> "0" And Me.txttarjeta.Text <> "" Then
            Dim cx As New Conexion
            Dim tarjeta As String = ""
            Try
                tarjeta = cx.SlqExecuteScalar(cx.Conectar("Planilla"), "SELECT Pin_tarjeta FROM Empleado WHERE Pin_Huella = '" + Me.txttarjeta.Text + "'")
                If tarjeta <> "" And tarjeta <> ptarjeta Then
                    MsgBox("Pin Tarjeta ya se encuentra en uso", MsgBoxStyle.Information)
                    txttarjeta.Focus()
                    Validar = False : Exit Function
                End If
                cx.DesConectar(cx.sQlconexion)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
    End Function

    Function BuscarMonedaBinding(ByVal cod_Moda As Integer)
        Dim I As Integer
        For I = 0 To Me.BindingContext(Me.DsEmpleado1, "Moneda2").Count - 1
            If cod_Moda = Me.BindingContext(Me.DsEmpleado1, "Moneda2").Current("codmoneda") Then
                Exit For
            End If
        Next
    End Function
#End Region

#Region "Academico"
    Private Sub ToolBar3_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar3.ButtonClick
        Select Case ToolBar3.Buttons.IndexOf(e.Button)
            Case 0
                Me.NuevoAcademico()
            Case 1
                Me.EliminarAcademico()
            Case 2
                Me.RegistrarAcademico()
        End Select
    End Sub

    Private Sub NuevoAcademico()
        Me.BindingContext(Me.DsEmpleado1, "Empleado").EndCurrentEdit()
        Me.BindingContext(Me.DsEmpleado1, "Empleado").AddNew()
        Me.BindingContext(Me.DsEmpleado1, "Empleado").CancelCurrentEdit()
        Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico").EndCurrentEdit()
        Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico").AddNew()
        txtTitulo.Enabled = True : txtNivel.Enabled = True : txtInstitucion.Enabled = True : txtAño.Enabled = True
        txtTitulo.Focus()
    End Sub

    Function RegistrarAcademico()
        If txtTitulo.Text = "" Then
            MsgBox("Debe de incluir el nombre del título", MsgBoxStyle.Information, "Atención...")
            txtTitulo.Focus() : Exit Function
        End If
        If txtNivel.Text = "" Then
            MsgBox("Debe de digitar el nivel académico", MsgBoxStyle.Information, "Atención...")
            txtNivel.Focus() : Exit Function
        End If
        If txtInstitucion.Text = "" Then
            MsgBox("Debe de incluir la institución donde obtuvo el título", MsgBoxStyle.Information, "Atención...")
            txtInstitucion.Focus() : Exit Function
        End If
        If txtAño.Text = "" Then
            MsgBox("Debe de especificar el año", MsgBoxStyle.Information, "Atención...")
            txtAño.Focus() : Exit Function
        End If
        Try
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico").EndCurrentEdit()
        Catch ex As SystemException
            MsgBox(ex.Message)
            Console.WriteLine(ex.StackTrace)
        End Try
    End Function

    Function EliminarAcademico()
        Dim resp As Integer
        If Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico").Count > 0 Then  ' si hay ubicaciones
            resp = MessageBox.Show("¿Desea eliminar este Titulo?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If resp = 6 Then
                Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico").RemoveAt(Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico").Position)
                Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Academico").EndCurrentEdit()
            End If
        End If
    End Function
#End Region

#Region "Licencia"
    Private Sub ToolBar4_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar4.ButtonClick
        Select Case ToolBar4.Buttons.IndexOf(e.Button)
            Case 0
                Me.NuevaLicencia()
            Case 1
                Me.EliminarLicencia()
            Case 2
                Me.RegistrarLicencia()
        End Select
    End Sub

    Private Sub NuevaLicencia()
        Me.BindingContext(Me.DsEmpleado1, "Empleado").EndCurrentEdit()
        Me.BindingContext(Me.DsEmpleado1, "Empleado").AddNew()
        Me.BindingContext(Me.DsEmpleado1, "Empleado").CancelCurrentEdit()
        Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias").EndCurrentEdit()
        Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias").AddNew()
        txtLicencia.Enabled = True : txtTipoLicencia.Enabled = True : dtEmision.Enabled = True : dtVencimiento.Enabled = True
        txtLicencia.Focus()
    End Sub

    Function RegistrarLicencia()
        If txtLicencia.Text = "" Then
            MsgBox("Debe de incluir el número de licencia", MsgBoxStyle.Information, "Atención...")
            txtLicencia.Focus()
            Exit Function
        End If
        If txtTipoLicencia.Text = "" Then
            MsgBox("Debe de digitar el tipo de licencia", MsgBoxStyle.Information, "Atención...")
        End If
        Try
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias").EndCurrentEdit()
        Catch ex As SystemException
            MsgBox(ex.Message)
            Console.WriteLine(ex.StackTrace)
        End Try
    End Function

    Function EliminarLicencia()
        Dim resp As Integer
        If Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias").Count > 0 Then  ' si hay ubicaciones
            resp = MessageBox.Show("¿Desea eliminar esta Licencia?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If resp = 6 Then
                Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias").RemoveAt(Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias").Position)
                Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Licencias").EndCurrentEdit()
            End If
        End If
    End Function
#End Region

#Region "Deduccion"
    Private Sub ToolBar2_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar2.ButtonClick
        Select Case ToolBar2.Buttons.IndexOf(e.Button)
            Case 0
                Me.NuevaDeduccion()
            Case 1
                Me.EliminarDeduccion()
            Case 2
                Me.RegistrarDeduccion()
        End Select
    End Sub

    Private Sub NuevaDeduccion()
        Me.BindingContext(Me.DsEmpleado1, "Empleado").EndCurrentEdit()
        Me.BindingContext(Me.DsEmpleado1, "Empleado").AddNew()
        Me.BindingContext(Me.DsEmpleado1, "Empleado").CancelCurrentEdit()
        Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones").EndCurrentEdit()
        Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones").AddNew()
        txtCodDeduccion.Enabled = True : txtNombreDeduccion.Enabled = True : txtMontoDeducion.Enabled = True : cbMonedaDeduccion.Enabled = True : cbTipoDed.Enabled = True
        txtCodDeduccion.Focus()
    End Sub

    Function RegistrarDeduccion()
        If txtCodDeduccion.Text = "" Or txtCodDeduccion.Text = 0 Then
            MsgBox("Debe de incluir una deducción", MsgBoxStyle.Information, "Atención...")
            txtCodDeduccion.Focus()
            Exit Function
        End If

        If txtMontoDeducion.Text = "" Then
            MsgBox("Debe de digitar un monto mayor que 0", MsgBoxStyle.Information, "Atención...")
        End If

        If cbTipoDed.Text = "" Then
            MsgBox("Debe de incluir el tipo de deducción", MsgBoxStyle.Information, "Atención...")
        End If
        If cbMonedaDeduccion.Text = "" Then
            MsgBox("Debe de incluir la moneda de la deducción", MsgBoxStyle.Information, "Atención...")
        End If
        Try
            Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones").EndCurrentEdit()
        Catch ex As SystemException
            MsgBox(ex.Message)
            Console.WriteLine(ex.StackTrace)
        End Try
    End Function

    Function EliminarDeduccion()
        Dim resp As Integer
        If Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones").Count > 0 Then  ' si hay ubicaciones
            resp = MessageBox.Show("¿Desea eliminar esta Deducción?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If resp = 6 Then
                Dim o As Integer = Me.BindingContext(Me.DsEmpleado1, "Empleado_Deducciones").Position
                Me.BindingContext(Me.DsEmpleado1, "Empleado_Deducciones").RemoveAt(Me.BindingContext(Me.DsEmpleado1, "Empleado_Deducciones").Position)
                Me.BindingContext(Me.DsEmpleado1, "Empleado_Deducciones").EndCurrentEdit()
            End If
        End If
    End Function

    Private Sub BuscarDeduccion()
        Dim sqlConexion2 As New SqlConnection
        Dim cConexion2 As New Conexion
        Dim rsa As SqlDataReader
        If Me.txtCodDeduccion.Text <> "" And Me.txtCodDeduccion.Text <> "0" Then
            sqlConexion2 = cConexion2.Conectar("Planilla")
            rsa = cConexion2.GetRecorset(sqlConexion2, "SELECT Codigo, Descripcion, Monto, Cod_Moneda, Tipo FROM Deducciones where Codigo = " & Me.txtCodDeduccion.Text)
            If rsa.HasRows = 0 Then
                MsgBox("Este código de deducción no existe, favor revisar", MsgBoxStyle.Information, "Atención...")
                Me.txtCodDeduccion.Focus()
                Exit Sub
            End If
            While rsa.Read
                Try
                    Me.txtNombreDeduccion.Text = rsa("Descripcion")
                    Me.txtMontoDeducion.Text = rsa("Monto")
                    Me.BindingContext(Me.DsEmpleado1, "Empleado.EmpleadoEmpleado_Deducciones").Current("cod_Moneda") = rsa("cod_moneda")
                    Me.cbTipoDed.Text = rsa("Tipo")
                    Me.txtMontoDeducion.Focus()
                Catch ex As System.Exception
                    MsgBox(ex.Message)
                End Try
            End While
            rsa.Close()
            cConexion2.DesConectar(cConexion2.Conectar)
        Else
            Exit Sub
        End If
    End Sub
#End Region

#Region "DistribucionContable"
    Private Sub ToolBar5_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar5.ButtonClick
        Select Case ToolBar5.Buttons.IndexOf(e.Button)
            Case 0
                NuevaCuentaContable()
            Case 1
                EliminarCuentaContable()
            Case 2
                RegistrarCuentaContable()
        End Select
    End Sub

    Private Sub NuevaCuentaContable()
        Me.txtCuentaContable.Enabled = True : Me.txtCuentaContable.Text = ""
        Me.txtCuentaContableDescripcion.Text = ""
        Me.txtCuentaContablePorcentaje.Enabled = True : Me.txtCuentaContablePorcentaje.Text = ""
        Me.txtCuentaContable.Focus()
    End Sub

    Private Sub LimpiarCuentaContable()
        Me.txtCuentaContable.Text = ""
        Me.txtCuentaContableDescripcion.Text = ""
        Me.txtCuentaContablePorcentaje.Text = ""
        Me.txtCuentaContableTotal.Text = ""
        Me.DsEmpleado1.DistribucionContable.Clear()
    End Sub
    Private Sub EliminarCuentaContable()
        Dim posicion As Integer
        If Me.DsEmpleado1.DistribucionContable.Count = 0 Then Exit Sub
        posicion = Me.BindingContext(DsEmpleado1.DistribucionContable).Position()
        DsEmpleado1.DistribucionContable.Rows.RemoveAt(posicion)
        CalcularTotalCuentaContable()
    End Sub

    Private Sub RegistrarCuentaContable()
        If Me.txtCuentaContablePorcentaje.Text = "" Then Exit Sub

        If Me.txtCuentaContablePorcentaje.Text < 0 Or Me.txtCuentaContablePorcentaje.Text > 100 Then
            MsgBox("No se puede agregar un porcentaje menor que cero o mayor que 100", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.txtCuentaContable.Text = "" Then
            MsgBox("El campo de cuenta contable no puede estar vacio", , MsgBoxStyle.Information)
            Exit Sub
        End If

        If Me.txtCuentaContablePorcentaje.Text = "" Then
            MsgBox("El campo de porcentaje no puede estar vacio", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.txtCuentaContableTotal.Text <> "" Then
            If (CDbl(Me.txtCuentaContableTotal.Text) + CDbl(Me.txtCuentaContablePorcentaje.Text)) > 100 Then
                MsgBox("No se puede agregar un porcentaje mayor que 100", MsgBoxStyle.Information)
                Exit Sub
            End If
        End If

        Dim NuevaFila As DsEmpleado.DistribucionContableRow
        NuevaFila = DsEmpleado1.DistribucionContable.NewDistribucionContableRow
        NuevaFila.IdDepartamento = Me.txtCuentaContable.Text
        NuevaFila.Departamento = Me.txtCuentaContableDescripcion.Text
        NuevaFila.Porcentaje = Me.txtCuentaContablePorcentaje.Text
        NuevaFila.EmpleadoIdentificacion = Me.TxtIdentificacion.Text

        DsEmpleado1.DistribucionContable.Rows.Add(NuevaFila)
        CalcularTotalCuentaContable()
    End Sub

    Private Function ObtenerIdCuentaContable(ByVal pCuentaContable As String) As Integer
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rsReader As SqlClient.SqlDataReader

        ObtenerIdCuentaContable = -1

        sql = "SELECT ID FROM CuentaContable  WHERE CuentaContable = '" & pCuentaContable & "'"
        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
        cnnConexion.Open()
        rsReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rsReader.Read() = False Then Exit Function

        ObtenerIdCuentaContable = rsReader(0)
        cnnConexion.Close()
    End Function

    Private Sub LLenarGridCuentaContable()
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim adpAdapter As New SqlClient.SqlDataAdapter
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand
        Dim sql As String

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()

        sql = "SELECT EDC.EmpleadoIdentificacion,EDC.IdDepartamento,D.Departamento,EDC.Porcentaje FROM Planilla.dbo.EmpleadoDistribucionContable EDC,Departamento D WHERE EDC.IdDepartamento = D.Id  " & _
                " AND EDC.EmpleadoIdentificacion = '" & TxtIdentificacion.Text & "'"

        Me.DsEmpleado1.DistribucionContable.Clear()

        sqlCommand.Connection = cnnConexion
        sqlCommand.CommandText = sql
        adpAdapter.SelectCommand = sqlCommand
        adpAdapter.Fill(DsEmpleado1, "DistribucionContable")
        cnnConexion.Close()

        CalcularTotalCuentaContable()
    End Sub

    Private Sub AgregarCuentaContableBD()
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim n As Integer

        If Me.txtCuentaContableTotal.Text = "" Then
            Exit Sub
        End If

        If Me.txtCuentaContableTotal.Text = 0 Then
            Exit Sub
        End If

        If Me.txtCuentaContableTotal.Text <> 100 Then
            MsgBox("La distribución de las cuentas contables no se registrará" & vbCrLf & " porque el total del porcentaje es diferente de 100", MsgBoxStyle.Information)
            Exit Sub
        End If

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()
        sql = "DELETE FROM Planilla.dbo.EmpleadoDistribucionContable WHERE EmpleadoIdentificacion ='" & Me.TxtIdentificacion.Text & "'"
        clsConexion.SlqExecute(cnnConexion, sql)

        For n = 0 To DsEmpleado1.DistribucionContable.Count - 1
            With DsEmpleado1.DistribucionContable(n)
                sql = "INSERT INTO Planilla.dbo.EmpleadoDistribucionContable (EmpleadoIdentificacion,IdDepartamento,Porcentaje) VALUES ('" & Me.TxtIdentificacion.Text & "'," & .IdDepartamento & "," & .Porcentaje & ")"
                clsConexion.SlqExecute(cnnConexion, sql)
            End With
        Next
        cnnConexion.Close()
    End Sub

    Private Sub EliminarCuentaContableBD()
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim n As Integer

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()
        sql = "DELETE FROM Planilla.dbo.EmpleadoDistribucionContable WHERE EmpleadoIdentificacion ='" & Me.TxtIdentificacion.Text & "'"
        clsConexion.SlqExecute(cnnConexion, sql)

        cnnConexion.Close()
    End Sub

    Private Sub CalcularTotalCuentaContable()
        Dim total As Double
        Dim n As Integer
        total = 0
        For n = 0 To DsEmpleado1.DistribucionContable.Count - 1
            With DsEmpleado1.DistribucionContable(n)
                total = total + .Porcentaje
            End With
        Next

        Me.txtCuentaContableTotal.Text = total
    End Sub

    Private Sub LlamarFmrBuscarAsientoVenta()
        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = GetSetting("SeeSoft", "Planilla", "CONEXION")
        busca.sqlstring = " SELECT    Id, Departamento FROM   Departamento "
        busca.campo = "Departamento"
        busca.sqlStringAdicional = " ORDER BY Departamento  "
        busca.ShowDialog()

        If busca.codigo Is Nothing Then Exit Sub

        Me.txtCuentaContable.Text = busca.codigo
        Me.txtCuentaContableDescripcion.Text = busca.descrip
        Me.txtCuentaContablePorcentaje.Focus()
    End Sub

    Private Sub BuscarCuentaContable()
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String = "SELECT Departamento  FROM Departamento where id = '" & Me.txtCuentaContable.Text & "' "

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then
            Me.txtCuentaContable.Text = ""
            Me.txtCuentaContableDescripcion.Text = ""
            Exit Sub
        End If

        Me.txtCuentaContableDescripcion.Text = rstReader(0)
        Me.txtCuentaContablePorcentaje.Focus()
        cnnConexion.Close()
    End Sub
#End Region

    Private Sub ckCedula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckCedula.CheckedChanged
        If ckCedula.Checked = True Then
            txtNuevaCedula.Visible = True
            txtNuevaCedula.Focus()
        Else
            txtNuevaCedula.Text = ""
            txtNuevaCedula.Visible = False
        End If
    End Sub

    Private Sub DataNavigator1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub txthuella_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthuella.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub txttarjeta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttarjeta.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub
End Class
