Imports System.data.sqlclient
Imports Utilidades

Public Class LiquidacionLaboral
    Inherits Plantilla

#Region "Variables"
    Public Codigo As String
    Public Diario As Double
    Public TotalGanado, Adelantos As Double
    Public Año As Double
    Public Shared FechaEmpleado As Integer
    Dim usua As Object
    Dim MesesVacaciones As Double
    Dim Total As Double
    Dim IdCheque, IdBanco, IdCuenta As Integer
    Dim NumeroAsiento As String
    Dim cconexion1 As New Conexion
    Dim sqlconexion1 As SqlConnection
    Dim cedulajuridica As String = ""
    Dim Total1, Total2, Total3, Total4, TotalAguinaldo As Double
    Dim salDiario As Double = 0
#End Region

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adEmpleado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsLiquidacion As Planilla.DsLiquidacion
    Friend WithEvents Combo1 As System.Windows.Forms.ComboBox
    Friend WithEvents adPlanillaDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adPlanilla As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents adAccion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents adLiquidacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DiaCesantia As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents adAdelantos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaComprobante As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdEstado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CheckTodos As System.Windows.Forms.CheckBox
    Friend WithEvents GBBancos As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents LCuenta As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBoxCuentaBancaria As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxBanco As System.Windows.Forms.ComboBox
    Friend WithEvents AdapterBancos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsBancos As Planilla.DsBancos
    Friend WithEvents AdapterCuentasBancarias As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label_CodBanco As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LCuentaDestino As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterCheques As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMontoLetras As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(LiquidacionLaboral))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.CheckTodos = New System.Windows.Forms.CheckBox
        Me.Combo1 = New System.Windows.Forms.ComboBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.DsLiquidacion = New Planilla.DsLiquidacion
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.TextBox22 = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.TextBoxMontoLetras = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaComprobante = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TextBox21 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.DiaCesantia = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.adEmpleado = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.adPlanillaDetalle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.adPlanilla = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.adAccion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand9 = New System.Data.SqlClient.SqlCommand
        Me.adLiquidacion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.adAdelantos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.AdEstado = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.AdMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.GBBancos = New System.Windows.Forms.GroupBox
        Me.LCuentaDestino = New System.Windows.Forms.Label
        Me.Label_CodBanco = New System.Windows.Forms.Label
        Me.ComboBoxBanco = New System.Windows.Forms.ComboBox
        Me.DsBancos = New Planilla.DsBancos
        Me.ComboBoxCuentaBancaria = New System.Windows.Forms.ComboBox
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.ComboBoxTipoPago = New System.Windows.Forms.ComboBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.LCuenta = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.AdapterBancos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        Me.AdapterCuentasBancarias = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.AdapterCheques = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand10 = New System.Data.SqlClient.SqlCommand
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DsLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBBancos.SuspendLayout()
        CType(Me.DsBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(816, 32)
        Me.TituloModulo.Text = "Liquidación Laboral"
        Me.TituloModulo.UseMnemonic = False
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 494)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(816, 56)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CheckTodos)
        Me.GroupBox1.Controls.Add(Me.Combo1)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 160)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Empleado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Location = New System.Drawing.Point(648, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 128)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tiempo Laborado"
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.Blue
        Me.TextBox8.Location = New System.Drawing.Point(72, 24)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(48, 15)
        Me.TextBox8.TabIndex = 68
        Me.TextBox8.Text = ""
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.Blue
        Me.TextBox9.Location = New System.Drawing.Point(72, 56)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(48, 15)
        Me.TextBox9.TabIndex = 67
        Me.TextBox9.Text = ""
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(8, 24)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(56, 16)
        Me.Label38.TabIndex = 3
        Me.Label38.Text = "Año(s):"
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(8, 56)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 16)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "Mes(es):"
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(8, 88)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 16)
        Me.Label36.TabIndex = 1
        Me.Label36.Text = "Dia(s):"
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.ForeColor = System.Drawing.Color.Blue
        Me.TextBox10.Location = New System.Drawing.Point(72, 88)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(48, 15)
        Me.TextBox10.TabIndex = 66
        Me.TextBox10.Text = ""
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckTodos
        '
        Me.CheckTodos.Location = New System.Drawing.Point(16, 56)
        Me.CheckTodos.Name = "CheckTodos"
        Me.CheckTodos.Size = New System.Drawing.Size(104, 16)
        Me.CheckTodos.TabIndex = 64
        Me.CheckTodos.Text = "Buscar Todos"
        '
        'Combo1
        '
        Me.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo1.ForeColor = System.Drawing.Color.Blue
        Me.Combo1.Items.AddRange(New Object() {"Renuncia", "Despido Con Responsabilidad", "Despido Sin Responsabilidad"})
        Me.Combo1.Location = New System.Drawing.Point(264, 96)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.Size = New System.Drawing.Size(232, 21)
        Me.Combo1.TabIndex = 63
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.Observaciones"))
        Me.TextBox7.ForeColor = System.Drawing.Color.Blue
        Me.TextBox7.Location = New System.Drawing.Point(8, 136)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(624, 14)
        Me.TextBox7.TabIndex = 26
        Me.TextBox7.Text = ""
        '
        'DsLiquidacion
        '
        Me.DsLiquidacion.DataSetName = "DsLiquidacion"
        Me.DsLiquidacion.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(8, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(624, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Observaciones"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Blue
        Me.TextBox6.Location = New System.Drawing.Point(512, 96)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(120, 15)
        Me.TextBox6.TabIndex = 24
        Me.TextBox6.Text = ""
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(512, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Fecha Salida"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(264, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Cese de Funciones por"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.ForeColor = System.Drawing.Color.Blue
        Me.TextBox4.Location = New System.Drawing.Point(136, 96)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(120, 14)
        Me.TextBox4.TabIndex = 20
        Me.TextBox4.Text = ""
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(136, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Salario Diario"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.ForeColor = System.Drawing.Color.Blue
        Me.TextBox3.Location = New System.Drawing.Point(8, 96)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(120, 14)
        Me.TextBox3.TabIndex = 18
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Salario Mensual"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Blue
        Me.TextBox2.Location = New System.Drawing.Point(512, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(120, 15)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = ""
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(136, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(360, 14)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = ""
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombre.Location = New System.Drawing.Point(8, 40)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(120, 14)
        Me.TxtNombre.TabIndex = 14
        Me.TxtNombre.Text = ""
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(512, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Ingreso"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(136, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Empleado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identificación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 24)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Día(s):"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 24)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Mes(es):"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Año(s):"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox11)
        Me.GroupBox3.Controls.Add(Me.Label41)
        Me.GroupBox3.Controls.Add(Me.TextBox22)
        Me.GroupBox3.Controls.Add(Me.Label42)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.TextBoxMontoLetras)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.GridControl1)
        Me.GroupBox3.Controls.Add(Me.TextBox21)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.DiaCesantia)
        Me.GroupBox3.Controls.Add(Me.TextBox16)
        Me.GroupBox3.Controls.Add(Me.TextBox19)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.TextBox17)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.TextBox18)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.TextBox15)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.TextBox13)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.TextBox14)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.TextBox12)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(8, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 184)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calculos"
        '
        'TextBox11
        '
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.MontoLaborados"))
        Me.TextBox11.ForeColor = System.Drawing.Color.Blue
        Me.TextBox11.Location = New System.Drawing.Point(280, 168)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox11.Size = New System.Drawing.Size(120, 13)
        Me.TextBox11.TabIndex = 48
        Me.TextBox11.Text = ""
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label41
        '
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Location = New System.Drawing.Point(280, 152)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label41.Size = New System.Drawing.Size(120, 16)
        Me.Label41.TabIndex = 47
        Me.Label41.Text = " Monto"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox22
        '
        Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.DiaLaborados"))
        Me.TextBox22.ForeColor = System.Drawing.Color.Blue
        Me.TextBox22.Location = New System.Drawing.Point(136, 168)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(120, 13)
        Me.TextBox22.TabIndex = 46
        Me.TextBox22.Text = ""
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label42
        '
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Location = New System.Drawing.Point(136, 152)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(120, 16)
        Me.Label42.TabIndex = 45
        Me.Label42.Text = "Días"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.ForeColor = System.Drawing.Color.Blue
        Me.Label40.Location = New System.Drawing.Point(8, 152)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(88, 16)
        Me.Label40.TabIndex = 44
        Me.Label40.Text = "Días Laborados:"
        '
        'TextBoxMontoLetras
        '
        Me.TextBoxMontoLetras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxMontoLetras.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMontoLetras.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxMontoLetras.Location = New System.Drawing.Point(408, 136)
        Me.TextBoxMontoLetras.Name = "TextBoxMontoLetras"
        Me.TextBoxMontoLetras.ReadOnly = True
        Me.TextBoxMontoLetras.Size = New System.Drawing.Size(384, 10)
        Me.TextBoxMontoLetras.TabIndex = 43
        Me.TextBoxMontoLetras.Text = "Monto En Letras"
        Me.TextBoxMontoLetras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(664, 24)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 16)
        Me.Label28.TabIndex = 42
        Me.Label28.Text = "Total Deducciones:"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.DsLiquidacion
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(432, 40)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(208, 88)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 41
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFechaComprobante, Me.colMonto})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colNumero
        '
        Me.colNumero.Caption = "Numero"
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colNumero.VisibleIndex = 0
        '
        'colFechaComprobante
        '
        Me.colFechaComprobante.Caption = "FechaComprobante"
        Me.colFechaComprobante.FieldName = "FechaComprobante"
        Me.colFechaComprobante.Name = "colFechaComprobante"
        Me.colFechaComprobante.VisibleIndex = 1
        '
        'colMonto
        '
        Me.colMonto.Caption = "Saldo"
        Me.colMonto.FieldName = "Saldo"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.VisibleIndex = 2
        '
        'TextBox21
        '
        Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox21.ForeColor = System.Drawing.Color.Blue
        Me.TextBox21.Location = New System.Drawing.Point(672, 48)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.ReadOnly = True
        Me.TextBox21.Size = New System.Drawing.Size(80, 13)
        Me.TextBox21.TabIndex = 40
        Me.TextBox21.Text = ""
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Location = New System.Drawing.Point(488, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 16)
        Me.Label27.TabIndex = 38
        Me.Label27.Text = "Deducciones"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DiaCesantia
        '
        Me.DiaCesantia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DiaCesantia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.DiaCesantia"))
        Me.DiaCesantia.ForeColor = System.Drawing.Color.Blue
        Me.DiaCesantia.Location = New System.Drawing.Point(136, 40)
        Me.DiaCesantia.Name = "DiaCesantia"
        Me.DiaCesantia.ReadOnly = True
        Me.DiaCesantia.Size = New System.Drawing.Size(120, 13)
        Me.DiaCesantia.TabIndex = 37
        Me.DiaCesantia.Text = ""
        Me.DiaCesantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox16
        '
        Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.DiaAguinal"))
        Me.TextBox16.ForeColor = System.Drawing.Color.Blue
        Me.TextBox16.Location = New System.Drawing.Point(136, 104)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.ReadOnly = True
        Me.TextBox16.Size = New System.Drawing.Size(120, 13)
        Me.TextBox16.TabIndex = 36
        Me.TextBox16.Text = ""
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox19
        '
        Me.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox19.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.Total"))
        Me.TextBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.ForeColor = System.Drawing.Color.Blue
        Me.TextBox19.Location = New System.Drawing.Point(664, 104)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.ReadOnly = True
        Me.TextBox19.Size = New System.Drawing.Size(120, 14)
        Me.TextBox19.TabIndex = 35
        Me.TextBox19.Text = ""
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Location = New System.Drawing.Point(656, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(120, 16)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "Monto Liquidación "
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox17
        '
        Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox17.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.MontoVaca"))
        Me.TextBox17.ForeColor = System.Drawing.Color.Blue
        Me.TextBox17.Location = New System.Drawing.Point(280, 136)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox17.Size = New System.Drawing.Size(120, 13)
        Me.TextBox17.TabIndex = 33
        Me.TextBox17.Text = ""
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(280, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label21.Size = New System.Drawing.Size(120, 16)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = " Monto"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox18
        '
        Me.TextBox18.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox18.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.DiaVaca"))
        Me.TextBox18.ForeColor = System.Drawing.Color.Blue
        Me.TextBox18.Location = New System.Drawing.Point(136, 136)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(120, 13)
        Me.TextBox18.TabIndex = 31
        Me.TextBox18.Text = ""
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Location = New System.Drawing.Point(136, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(120, 16)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Días"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.Location = New System.Drawing.Point(8, 120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Vacaciones:"
        '
        'TextBox15
        '
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.MontoAguinal"))
        Me.TextBox15.ForeColor = System.Drawing.Color.Blue
        Me.TextBox15.Location = New System.Drawing.Point(280, 104)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox15.Size = New System.Drawing.Size(120, 13)
        Me.TextBox15.TabIndex = 28
        Me.TextBox15.Text = ""
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(280, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label18.Size = New System.Drawing.Size(120, 16)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = " Monto"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(136, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 16)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Total Salarios"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 88)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 16)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Aguinaldo:"
        '
        'TextBox13
        '
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox13.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.MontoPreaviso"))
        Me.TextBox13.ForeColor = System.Drawing.Color.Blue
        Me.TextBox13.Location = New System.Drawing.Point(280, 72)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox13.Size = New System.Drawing.Size(120, 13)
        Me.TextBox13.TabIndex = 23
        Me.TextBox13.Text = ""
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(280, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = " Monto"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox14
        '
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox14.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.DiaPreaviso"))
        Me.TextBox14.ForeColor = System.Drawing.Color.Blue
        Me.TextBox14.Location = New System.Drawing.Point(136, 72)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(120, 13)
        Me.TextBox14.TabIndex = 21
        Me.TextBox14.Text = ""
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(136, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 16)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Días"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Preaviso:"
        '
        'TextBox12
        '
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.MontoCesa"))
        Me.TextBox12.ForeColor = System.Drawing.Color.Blue
        Me.TextBox12.Location = New System.Drawing.Point(280, 40)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox12.Size = New System.Drawing.Size(120, 13)
        Me.TextBox12.TabIndex = 18
        Me.TextBox12.Text = ""
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(280, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label14.Size = New System.Drawing.Size(120, 16)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = " Monto"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(136, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 16)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Días"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cesantía:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DIEGOGAMBOA;packet size=4096;integrated security=SSPI;data source=" & _
        "DIEGOGAMBOA;persist security info=False;initial catalog=Planilla"
        '
        'adEmpleado
        '
        Me.adEmpleado.DeleteCommand = Me.SqlDeleteCommand1
        Me.adEmpleado.InsertCommand = Me.SqlInsertCommand1
        Me.adEmpleado.SelectCommand = Me.SqlSelectCommand1
        Me.adEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Fecha_Ingreso", "Fecha_Ingreso"), New System.Data.Common.DataColumnMapping("Fecha_Salida", "Fecha_Salida"), New System.Data.Common.DataColumnMapping("Diario", "Diario"), New System.Data.Common.DataColumnMapping("Semana", "Semana"), New System.Data.Common.DataColumnMapping("Quincena", "Quincena"), New System.Data.Common.DataColumnMapping("Mensual", "Mensual"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("Hora", "Hora"), New System.Data.Common.DataColumnMapping("Cod_Estado", "Cod_Estado"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("CuentaBancaria", "CuentaBancaria")})})
        Me.adEmpleado.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Empleado WHERE (Identificacion = @Original_Identificacion) AND (Cod_E" & _
        "stado = @Original_Cod_Estado) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Cuent" & _
        "aBancaria = @Original_CuentaBancaria OR @Original_CuentaBancaria IS NULL AND Cue" & _
        "ntaBancaria IS NULL) AND (Diario = @Original_Diario) AND (Fecha_Ingreso = @Origi" & _
        "nal_Fecha_Ingreso) AND (Fecha_Salida = @Original_Fecha_Salida) AND (Hora = @Orig" & _
        "inal_Hora) AND (Mensual = @Original_Mensual) AND (Nombre = @Original_Nombre) AND" & _
        " (Quincena = @Original_Quincena) AND (Salario = @Original_Salario) AND (Semana =" & _
        " @Original_Semana)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaBancaria", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaBancaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Empleado(Identificacion, Nombre, Fecha_Ingreso, Fecha_Salida, Diario," & _
        " Semana, Quincena, Mensual, Salario, Hora, Cod_Estado, Cod_Moneda, CuentaBancari" & _
        "a) VALUES (@Identificacion, @Nombre, @Fecha_Ingreso, @Fecha_Salida, @Diario, @Se" & _
        "mana, @Quincena, @Mensual, @Salario, @Hora, @Cod_Estado, @Cod_Moneda, @CuentaBan" & _
        "caria); SELECT Identificacion, Nombre, Fecha_Ingreso, Fecha_Salida, Diario, Sema" & _
        "na, Quincena, Mensual, Salario, Hora, Cod_Estado, Cod_Moneda, CuentaBancaria FRO" & _
        "M Empleado WHERE (Identificacion = @Identificacion)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaBancaria", System.Data.SqlDbType.VarChar, 50, "CuentaBancaria"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Identificacion, Nombre, Fecha_Ingreso, Fecha_Salida, Diario, Semana, Quinc" & _
        "ena, Mensual, Salario, Hora, Cod_Estado, Cod_Moneda, CuentaBancaria FROM Emplead" & _
        "o"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Empleado SET Identificacion = @Identificacion, Nombre = @Nombre, Fecha_Ing" & _
        "reso = @Fecha_Ingreso, Fecha_Salida = @Fecha_Salida, Diario = @Diario, Semana = " & _
        "@Semana, Quincena = @Quincena, Mensual = @Mensual, Salario = @Salario, Hora = @H" & _
        "ora, Cod_Estado = @Cod_Estado, Cod_Moneda = @Cod_Moneda, CuentaBancaria = @Cuent" & _
        "aBancaria WHERE (Identificacion = @Original_Identificacion) AND (Cod_Estado = @O" & _
        "riginal_Cod_Estado) AND (Cod_Moneda = @Original_Cod_Moneda) AND (CuentaBancaria " & _
        "= @Original_CuentaBancaria OR @Original_CuentaBancaria IS NULL AND CuentaBancari" & _
        "a IS NULL) AND (Diario = @Original_Diario) AND (Fecha_Ingreso = @Original_Fecha_" & _
        "Ingreso) AND (Fecha_Salida = @Original_Fecha_Salida) AND (Hora = @Original_Hora)" & _
        " AND (Mensual = @Original_Mensual) AND (Nombre = @Original_Nombre) AND (Quincena" & _
        " = @Original_Quincena) AND (Salario = @Original_Salario) AND (Semana = @Original" & _
        "_Semana); SELECT Identificacion, Nombre, Fecha_Ingreso, Fecha_Salida, Diario, Se" & _
        "mana, Quincena, Mensual, Salario, Hora, Cod_Estado, Cod_Moneda, CuentaBancaria F" & _
        "ROM Empleado WHERE (Identificacion = @Identificacion)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaBancaria", System.Data.SqlDbType.VarChar, 50, "CuentaBancaria"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaBancaria", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaBancaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing))
        '
        'adPlanillaDetalle
        '
        Me.adPlanillaDetalle.DeleteCommand = Me.SqlDeleteCommand2
        Me.adPlanillaDetalle.InsertCommand = Me.SqlInsertCommand2
        Me.adPlanillaDetalle.SelectCommand = Me.SqlSelectCommand2
        Me.adPlanillaDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Planilla_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("FormaPago", "FormaPago"), New System.Data.Common.DataColumnMapping("SalarioBruto", "SalarioBruto"), New System.Data.Common.DataColumnMapping("Id_Planilla", "Id_Planilla"), New System.Data.Common.DataColumnMapping("Id", "Id")})})
        Me.adPlanillaDetalle.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Planilla_Detalle WHERE (Id = @Original_Id) AND (Cedula = @Original_Ce" & _
        "dula) AND (FormaPago = @Original_FormaPago) AND (Id_Planilla = @Original_Id_Plan" & _
        "illa) AND (Nombre = @Original_Nombre) AND (Salario = @Original_Salario) AND (Sal" & _
        "arioBruto = @Original_SalarioBruto)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioBruto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioBruto", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Planilla_Detalle(Cedula, Nombre, Salario, FormaPago, SalarioBruto, Id" & _
        "_Planilla) VALUES (@Cedula, @Nombre, @Salario, @FormaPago, @SalarioBruto, @Id_Pl" & _
        "anilla); SELECT Cedula, Nombre, Salario, FormaPago, SalarioBruto, Id_Planilla, I" & _
        "d FROM Planilla_Detalle WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 15, "FormaPago"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioBruto", System.Data.SqlDbType.Float, 8, "SalarioBruto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 8, "Id_Planilla"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Cedula, Nombre, Salario, FormaPago, SalarioBruto, Id_Planilla, Id FROM Pla" & _
        "nilla_Detalle"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Planilla_Detalle SET Cedula = @Cedula, Nombre = @Nombre, Salario = @Salari" & _
        "o, FormaPago = @FormaPago, SalarioBruto = @SalarioBruto, Id_Planilla = @Id_Plani" & _
        "lla WHERE (Id = @Original_Id) AND (Cedula = @Original_Cedula) AND (FormaPago = @" & _
        "Original_FormaPago) AND (Id_Planilla = @Original_Id_Planilla) AND (Nombre = @Ori" & _
        "ginal_Nombre) AND (Salario = @Original_Salario) AND (SalarioBruto = @Original_Sa" & _
        "larioBruto); SELECT Cedula, Nombre, Salario, FormaPago, SalarioBruto, Id_Planill" & _
        "a, Id FROM Planilla_Detalle WHERE (Id = @Id)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 15, "FormaPago"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioBruto", System.Data.SqlDbType.Float, 8, "SalarioBruto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 8, "Id_Planilla"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FormaPago", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormaPago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioBruto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioBruto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'adPlanilla
        '
        Me.adPlanilla.DeleteCommand = Me.SqlDeleteCommand3
        Me.adPlanilla.InsertCommand = Me.SqlInsertCommand3
        Me.adPlanilla.SelectCommand = Me.SqlSelectCommand3
        Me.adPlanilla.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Planilla", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Planilla", "Id_Planilla"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("FechaInicial", "FechaInicial"), New System.Data.Common.DataColumnMapping("FechaFinal", "FechaFinal"), New System.Data.Common.DataColumnMapping("CierreMes", "CierreMes"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("Nombre_Usuario", "Nombre_Usuario"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado")})})
        Me.adPlanilla.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Planilla WHERE (Id_Planilla = @Original_Id_Planilla) AND (Anulado = @" & _
        "Original_Anulado) AND (Ced_Usuario = @Original_Ced_Usuario) AND (CierreMes = @Or" & _
        "iginal_CierreMes) AND (Fecha = @Original_Fecha) AND (FechaFinal = @Original_Fech" & _
        "aFinal) AND (FechaInicial = @Original_FechaInicial) AND (Nombre_Usuario = @Origi" & _
        "nal_Nombre_Usuario)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CierreMes", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CierreMes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaFinal", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaFinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaInicial", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaInicial", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Planilla(Id_Planilla, Fecha, FechaInicial, FechaFinal, CierreMes, Ced" & _
        "_Usuario, Nombre_Usuario, Anulado) VALUES (@Id_Planilla, @Fecha, @FechaInicial, " & _
        "@FechaFinal, @CierreMes, @Ced_Usuario, @Nombre_Usuario, @Anulado); SELECT Id_Pla" & _
        "nilla, Fecha, FechaInicial, FechaFinal, CierreMes, Ced_Usuario, Nombre_Usuario, " & _
        "Anulado FROM Planilla WHERE (Id_Planilla = @Id_Planilla)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 8, "Id_Planilla"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaInicial", System.Data.SqlDbType.DateTime, 8, "FechaInicial"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaFinal", System.Data.SqlDbType.DateTime, 8, "FechaFinal"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CierreMes", System.Data.SqlDbType.Bit, 1, "CierreMes"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, "Nombre_Usuario"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id_Planilla, Fecha, FechaInicial, FechaFinal, CierreMes, Ced_Usuario, Nomb" & _
        "re_Usuario, Anulado FROM Planilla"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Planilla SET Id_Planilla = @Id_Planilla, Fecha = @Fecha, FechaInicial = @F" & _
        "echaInicial, FechaFinal = @FechaFinal, CierreMes = @CierreMes, Ced_Usuario = @Ce" & _
        "d_Usuario, Nombre_Usuario = @Nombre_Usuario, Anulado = @Anulado WHERE (Id_Planil" & _
        "la = @Original_Id_Planilla) AND (Anulado = @Original_Anulado) AND (Ced_Usuario =" & _
        " @Original_Ced_Usuario) AND (CierreMes = @Original_CierreMes) AND (Fecha = @Orig" & _
        "inal_Fecha) AND (FechaFinal = @Original_FechaFinal) AND (FechaInicial = @Origina" & _
        "l_FechaInicial) AND (Nombre_Usuario = @Original_Nombre_Usuario); SELECT Id_Plani" & _
        "lla, Fecha, FechaInicial, FechaFinal, CierreMes, Ced_Usuario, Nombre_Usuario, An" & _
        "ulado FROM Planilla WHERE (Id_Planilla = @Id_Planilla)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Planilla", System.Data.SqlDbType.BigInt, 8, "Id_Planilla"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaInicial", System.Data.SqlDbType.DateTime, 8, "FechaInicial"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaFinal", System.Data.SqlDbType.DateTime, 8, "FechaFinal"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CierreMes", System.Data.SqlDbType.Bit, 1, "CierreMes"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, "Nombre_Usuario"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CierreMes", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CierreMes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaFinal", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaFinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaInicial", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaInicial", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Usuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(432, 520)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(64, 20)
        Me.TextBox5.TabIndex = 1000
        Me.TextBox5.Text = ""
        '
        'TextBox20
        '
        Me.TextBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.Liquidacion"))
        Me.TextBox20.Enabled = False
        Me.TextBox20.Location = New System.Drawing.Point(336, 520)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.ReadOnly = True
        Me.TextBox20.Size = New System.Drawing.Size(80, 20)
        Me.TextBox20.TabIndex = 9999
        Me.TextBox20.Text = ""
        '
        'Label25
        '
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.Location = New System.Drawing.Point(328, 504)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 16)
        Me.Label25.TabIndex = 65
        Me.Label25.Text = "Liquidación No. :"
        '
        'Label26
        '
        Me.Label26.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label26.Location = New System.Drawing.Point(432, 504)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 16)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "Fecha"
        '
        'adAccion
        '
        Me.adAccion.DeleteCommand = Me.SqlDeleteCommand9
        Me.adAccion.InsertCommand = Me.SqlInsertCommand9
        Me.adAccion.SelectCommand = Me.SqlSelectCommand5
        Me.adAccion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AccionPersonal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Accion", "Id_Accion"), New System.Data.Common.DataColumnMapping("DiasaDescontar", "DiasaDescontar"), New System.Data.Common.DataColumnMapping("Id_Empleado", "Id_Empleado"), New System.Data.Common.DataColumnMapping("Liquidacion", "Liquidacion"), New System.Data.Common.DataColumnMapping("Num_Accion", "Num_Accion")})})
        Me.adAccion.UpdateCommand = Me.SqlUpdateCommand9
        '
        'SqlDeleteCommand9
        '
        Me.SqlDeleteCommand9.CommandText = "DELETE FROM AccionPersonal WHERE (Num_Accion = @Original_Num_Accion) AND (DiasaDe" & _
        "scontar = @Original_DiasaDescontar) AND (Id_Accion = @Original_Id_Accion) AND (I" & _
        "d_Empleado = @Original_Id_Empleado) AND (Liquidacion = @Original_Liquidacion)"
        Me.SqlDeleteCommand9.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiasaDescontar", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiasaDescontar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Accion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Liquidacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Liquidacion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand9
        '
        Me.SqlInsertCommand9.CommandText = "INSERT INTO AccionPersonal(Id_Accion, DiasaDescontar, Id_Empleado, Liquidacion) V" & _
        "ALUES (@Id_Accion, @DiasaDescontar, @Id_Empleado, @Liquidacion); SELECT Id_Accio" & _
        "n, DiasaDescontar, Id_Empleado, Liquidacion, Num_Accion FROM AccionPersonal WHER" & _
        "E (Num_Accion = @@IDENTITY)"
        Me.SqlInsertCommand9.Connection = Me.SqlConnection1
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 4, "Id_Accion"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Float, 8, "DiasaDescontar"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 250, "Id_Empleado"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Liquidacion", System.Data.SqlDbType.Bit, 1, "Liquidacion"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Id_Accion, DiasaDescontar, Id_Empleado, Liquidacion, Num_Accion FROM Accio" & _
        "nPersonal"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand9
        '
        Me.SqlUpdateCommand9.CommandText = "UPDATE AccionPersonal SET Id_Accion = @Id_Accion, DiasaDescontar = @DiasaDesconta" & _
        "r, Id_Empleado = @Id_Empleado, Liquidacion = @Liquidacion WHERE (Num_Accion = @O" & _
        "riginal_Num_Accion) AND (DiasaDescontar = @Original_DiasaDescontar) AND (Id_Acci" & _
        "on = @Original_Id_Accion) AND (Id_Empleado = @Original_Id_Empleado) AND (Liquida" & _
        "cion = @Original_Liquidacion); SELECT Id_Accion, DiasaDescontar, Id_Empleado, Li" & _
        "quidacion, Num_Accion FROM AccionPersonal WHERE (Num_Accion = @Num_Accion)"
        Me.SqlUpdateCommand9.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 4, "Id_Accion"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Float, 8, "DiasaDescontar"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 250, "Id_Empleado"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Liquidacion", System.Data.SqlDbType.Bit, 1, "Liquidacion"))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiasaDescontar", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiasaDescontar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Accion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Liquidacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Liquidacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Accion", System.Data.SqlDbType.BigInt, 8, "Num_Accion"))
        '
        'adLiquidacion
        '
        Me.adLiquidacion.DeleteCommand = Me.SqlDeleteCommand4
        Me.adLiquidacion.InsertCommand = Me.SqlInsertCommand4
        Me.adLiquidacion.SelectCommand = Me.SqlSelectCommand4
        Me.adLiquidacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "liquidacionempleados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Liquidacion", "Liquidacion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("FechaIngreso", "FechaIngreso"), New System.Data.Common.DataColumnMapping("SalarioMensual", "SalarioMensual"), New System.Data.Common.DataColumnMapping("SalarioDiario", "SalarioDiario"), New System.Data.Common.DataColumnMapping("FechaSalida", "FechaSalida"), New System.Data.Common.DataColumnMapping("Cese", "Cese"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anos", "Anos"), New System.Data.Common.DataColumnMapping("Meses", "Meses"), New System.Data.Common.DataColumnMapping("Dia", "Dia"), New System.Data.Common.DataColumnMapping("DiaCesantia", "DiaCesantia"), New System.Data.Common.DataColumnMapping("MontoCesa", "MontoCesa"), New System.Data.Common.DataColumnMapping("DiaPreaviso", "DiaPreaviso"), New System.Data.Common.DataColumnMapping("MontoPreaviso", "MontoPreaviso"), New System.Data.Common.DataColumnMapping("DiaAguinal", "DiaAguinal"), New System.Data.Common.DataColumnMapping("MontoAguinal", "MontoAguinal"), New System.Data.Common.DataColumnMapping("DiaVaca", "DiaVaca"), New System.Data.Common.DataColumnMapping("MontoVaca", "MontoVaca"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Num_Cheque", "Num_Cheque"), New System.Data.Common.DataColumnMapping("DiaLaborados", "DiaLaborados"), New System.Data.Common.DataColumnMapping("MontoLaborados", "MontoLaborados")})})
        Me.adLiquidacion.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM liquidacionempleados WHERE (Liquidacion = @Original_Liquidacion) AND " & _
        "(Anos = @Original_Anos) AND (Cese = @Original_Cese) AND (Dia = @Original_Dia) AN" & _
        "D (DiaAguinal = @Original_DiaAguinal) AND (DiaCesantia = @Original_DiaCesantia) " & _
        "AND (DiaLaborados = @Original_DiaLaborados) AND (DiaPreaviso = @Original_DiaPrea" & _
        "viso) AND (DiaVaca = @Original_DiaVaca) AND (Fecha = @Original_Fecha) AND (Fecha" & _
        "Ingreso = @Original_FechaIngreso) AND (FechaSalida = @Original_FechaSalida) AND " & _
        "(Identificacion = @Original_Identificacion) AND (Meses = @Original_Meses) AND (M" & _
        "ontoAguinal = @Original_MontoAguinal) AND (MontoCesa = @Original_MontoCesa) AND " & _
        "(MontoLaborados = @Original_MontoLaborados) AND (MontoPreaviso = @Original_Monto" & _
        "Preaviso) AND (MontoVaca = @Original_MontoVaca) AND (Nombre = @Original_Nombre) " & _
        "AND (Num_Cheque = @Original_Num_Cheque) AND (Observaciones = @Original_Observaci" & _
        "ones OR @Original_Observaciones IS NULL AND Observaciones IS NULL) AND (SalarioD" & _
        "iario = @Original_SalarioDiario) AND (SalarioMensual = @Original_SalarioMensual)" & _
        " AND (Total = @Original_Total)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Liquidacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Liquidacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cese", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cese", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Dia", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaAguinal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaAguinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaCesantia", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaCesantia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaLaborados", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaLaborados", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaPreaviso", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaPreaviso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaVaca", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaVaca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaIngreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaIngreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaSalida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaSalida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Meses", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Meses", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoAguinal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoAguinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoCesa", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoCesa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoLaborados", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoLaborados", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoPreaviso", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoPreaviso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoVaca", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoVaca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 65, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Cheque", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Cheque", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioDiario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioDiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioMensual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioMensual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO liquidacionempleados(Fecha, Identificacion, Nombre, FechaIngreso, Sal" & _
        "arioMensual, SalarioDiario, FechaSalida, Cese, Observaciones, Anos, Meses, Dia, " & _
        "DiaCesantia, MontoCesa, DiaPreaviso, MontoPreaviso, DiaAguinal, MontoAguinal, Di" & _
        "aVaca, MontoVaca, Total, Num_Cheque, DiaLaborados, MontoLaborados) VALUES (@Fech" & _
        "a, @Identificacion, @Nombre, @FechaIngreso, @SalarioMensual, @SalarioDiario, @Fe" & _
        "chaSalida, @Cese, @Observaciones, @Anos, @Meses, @Dia, @DiaCesantia, @MontoCesa," & _
        " @DiaPreaviso, @MontoPreaviso, @DiaAguinal, @MontoAguinal, @DiaVaca, @MontoVaca," & _
        " @Total, @Num_Cheque, @DiaLaborados, @MontoLaborados); SELECT Liquidacion, Fecha" & _
        ", Identificacion, Nombre, FechaIngreso, SalarioMensual, SalarioDiario, FechaSali" & _
        "da, Cese, Observaciones, Anos, Meses, Dia, DiaCesantia, MontoCesa, DiaPreaviso, " & _
        "MontoPreaviso, DiaAguinal, MontoAguinal, DiaVaca, MontoVaca, Total, Num_Cheque, " & _
        "DiaLaborados, MontoLaborados FROM liquidacionempleados WHERE (Liquidacion = @@ID" & _
        "ENTITY)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 25, "Identificacion"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 65, "Nombre"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaIngreso", System.Data.SqlDbType.DateTime, 8, "FechaIngreso"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioMensual", System.Data.SqlDbType.Float, 8, "SalarioMensual"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioDiario", System.Data.SqlDbType.Float, 8, "SalarioDiario"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaSalida", System.Data.SqlDbType.DateTime, 8, "FechaSalida"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cese", System.Data.SqlDbType.VarChar, 50, "Cese"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 150, "Observaciones"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anos", System.Data.SqlDbType.Float, 8, "Anos"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Meses", System.Data.SqlDbType.Float, 8, "Meses"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dia", System.Data.SqlDbType.Float, 8, "Dia"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaCesantia", System.Data.SqlDbType.Float, 8, "DiaCesantia"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoCesa", System.Data.SqlDbType.Float, 8, "MontoCesa"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaPreaviso", System.Data.SqlDbType.Float, 8, "DiaPreaviso"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoPreaviso", System.Data.SqlDbType.Float, 8, "MontoPreaviso"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaAguinal", System.Data.SqlDbType.Float, 8, "DiaAguinal"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoAguinal", System.Data.SqlDbType.Float, 8, "MontoAguinal"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaVaca", System.Data.SqlDbType.Float, 8, "DiaVaca"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoVaca", System.Data.SqlDbType.Float, 8, "MontoVaca"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Cheque", System.Data.SqlDbType.BigInt, 8, "Num_Cheque"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaLaborados", System.Data.SqlDbType.Float, 8, "DiaLaborados"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoLaborados", System.Data.SqlDbType.Float, 8, "MontoLaborados"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Liquidacion, Fecha, Identificacion, Nombre, FechaIngreso, SalarioMensual, " & _
        "SalarioDiario, FechaSalida, Cese, Observaciones, Anos, Meses, Dia, DiaCesantia, " & _
        "MontoCesa, DiaPreaviso, MontoPreaviso, DiaAguinal, MontoAguinal, DiaVaca, MontoV" & _
        "aca, Total, Num_Cheque, DiaLaborados, MontoLaborados FROM liquidacionempleados"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE liquidacionempleados SET Fecha = @Fecha, Identificacion = @Identificacion," & _
        " Nombre = @Nombre, FechaIngreso = @FechaIngreso, SalarioMensual = @SalarioMensua" & _
        "l, SalarioDiario = @SalarioDiario, FechaSalida = @FechaSalida, Cese = @Cese, Obs" & _
        "ervaciones = @Observaciones, Anos = @Anos, Meses = @Meses, Dia = @Dia, DiaCesant" & _
        "ia = @DiaCesantia, MontoCesa = @MontoCesa, DiaPreaviso = @DiaPreaviso, MontoPrea" & _
        "viso = @MontoPreaviso, DiaAguinal = @DiaAguinal, MontoAguinal = @MontoAguinal, D" & _
        "iaVaca = @DiaVaca, MontoVaca = @MontoVaca, Total = @Total, Num_Cheque = @Num_Che" & _
        "que, DiaLaborados = @DiaLaborados, MontoLaborados = @MontoLaborados WHERE (Liqui" & _
        "dacion = @Original_Liquidacion) AND (Anos = @Original_Anos) AND (Cese = @Origina" & _
        "l_Cese) AND (Dia = @Original_Dia) AND (DiaAguinal = @Original_DiaAguinal) AND (D" & _
        "iaCesantia = @Original_DiaCesantia) AND (DiaLaborados = @Original_DiaLaborados) " & _
        "AND (DiaPreaviso = @Original_DiaPreaviso) AND (DiaVaca = @Original_DiaVaca) AND " & _
        "(Fecha = @Original_Fecha) AND (FechaIngreso = @Original_FechaIngreso) AND (Fecha" & _
        "Salida = @Original_FechaSalida) AND (Identificacion = @Original_Identificacion) " & _
        "AND (Meses = @Original_Meses) AND (MontoAguinal = @Original_MontoAguinal) AND (M" & _
        "ontoCesa = @Original_MontoCesa) AND (MontoLaborados = @Original_MontoLaborados) " & _
        "AND (MontoPreaviso = @Original_MontoPreaviso) AND (MontoVaca = @Original_MontoVa" & _
        "ca) AND (Nombre = @Original_Nombre) AND (Num_Cheque = @Original_Num_Cheque) AND " & _
        "(Observaciones = @Original_Observaciones OR @Original_Observaciones IS NULL AND " & _
        "Observaciones IS NULL) AND (SalarioDiario = @Original_SalarioDiario) AND (Salari" & _
        "oMensual = @Original_SalarioMensual) AND (Total = @Original_Total); SELECT Liqui" & _
        "dacion, Fecha, Identificacion, Nombre, FechaIngreso, SalarioMensual, SalarioDiar" & _
        "io, FechaSalida, Cese, Observaciones, Anos, Meses, Dia, DiaCesantia, MontoCesa, " & _
        "DiaPreaviso, MontoPreaviso, DiaAguinal, MontoAguinal, DiaVaca, MontoVaca, Total," & _
        " Num_Cheque, DiaLaborados, MontoLaborados FROM liquidacionempleados WHERE (Liqui" & _
        "dacion = @Liquidacion)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 25, "Identificacion"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 65, "Nombre"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaIngreso", System.Data.SqlDbType.DateTime, 8, "FechaIngreso"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioMensual", System.Data.SqlDbType.Float, 8, "SalarioMensual"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalarioDiario", System.Data.SqlDbType.Float, 8, "SalarioDiario"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaSalida", System.Data.SqlDbType.DateTime, 8, "FechaSalida"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cese", System.Data.SqlDbType.VarChar, 50, "Cese"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 150, "Observaciones"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anos", System.Data.SqlDbType.Float, 8, "Anos"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Meses", System.Data.SqlDbType.Float, 8, "Meses"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dia", System.Data.SqlDbType.Float, 8, "Dia"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaCesantia", System.Data.SqlDbType.Float, 8, "DiaCesantia"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoCesa", System.Data.SqlDbType.Float, 8, "MontoCesa"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaPreaviso", System.Data.SqlDbType.Float, 8, "DiaPreaviso"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoPreaviso", System.Data.SqlDbType.Float, 8, "MontoPreaviso"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaAguinal", System.Data.SqlDbType.Float, 8, "DiaAguinal"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoAguinal", System.Data.SqlDbType.Float, 8, "MontoAguinal"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaVaca", System.Data.SqlDbType.Float, 8, "DiaVaca"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoVaca", System.Data.SqlDbType.Float, 8, "MontoVaca"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Cheque", System.Data.SqlDbType.BigInt, 8, "Num_Cheque"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaLaborados", System.Data.SqlDbType.Float, 8, "DiaLaborados"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoLaborados", System.Data.SqlDbType.Float, 8, "MontoLaborados"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Liquidacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Liquidacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cese", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cese", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Dia", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaAguinal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaAguinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaCesantia", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaCesantia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaLaborados", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaLaborados", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaPreaviso", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaPreaviso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaVaca", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaVaca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaIngreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaIngreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaSalida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaSalida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Meses", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Meses", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoAguinal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoAguinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoCesa", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoCesa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoLaborados", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoLaborados", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoPreaviso", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoPreaviso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoVaca", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoVaca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 65, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Cheque", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Cheque", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioDiario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioDiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SalarioMensual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SalarioMensual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Liquidacion", System.Data.SqlDbType.BigInt, 8, "Liquidacion"))
        '
        'adAdelantos
        '
        Me.adAdelantos.DeleteCommand = Me.SqlDeleteCommand5
        Me.adAdelantos.InsertCommand = Me.SqlInsertCommand5
        Me.adAdelantos.SelectCommand = Me.SqlSelectCommand6
        Me.adAdelantos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Adelantos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Adelanto", "Adelanto"), New System.Data.Common.DataColumnMapping("Prestamo", "Prestamo"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("FechaComprobante", "FechaComprobante"), New System.Data.Common.DataColumnMapping("Num_Pago", "Num_Pago"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("MontoEnLetras", "MontoEnLetras"), New System.Data.Common.DataColumnMapping("FechaCobro", "FechaCobro"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("DeducirxPago", "DeducirxPago"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo")})})
        Me.adAdelantos.UpdateCommand = Me.SqlUpdateCommand5
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
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Numero, Identificacion, Nombre, Adelanto, Prestamo, Puesto, Salario, Fecha" & _
        "Comprobante, Num_Pago, Monto, MontoEnLetras, FechaCobro, Observaciones, Deducirx" & _
        "Pago, Usuario, NombreUsuario, Cod_Moneda, Anulado, Saldo FROM Adelantos"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
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
        'AdEstado
        '
        Me.AdEstado.DeleteCommand = Me.SqlDeleteCommand6
        Me.AdEstado.InsertCommand = Me.SqlInsertCommand6
        Me.AdEstado.SelectCommand = Me.SqlSelectCommand7
        Me.AdEstado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Estado_Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Salida", "Salida")})})
        Me.AdEstado.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM Estado_Empleado WHERE (Codigo = @Original_Codigo) AND (Descripcion = " & _
        "@Original_Descripcion) AND (Salida = @Original_Salida)"
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salida", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salida", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO Estado_Empleado(Descripcion, Salida) VALUES (@Descripcion, @Salida); " & _
        "SELECT Codigo, Descripcion, Salida FROM Estado_Empleado WHERE (Codigo = @@IDENTI" & _
        "TY)"
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 1, "Salida"))
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT Codigo, Descripcion, Salida FROM Estado_Empleado"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "UPDATE Estado_Empleado SET Descripcion = @Descripcion, Salida = @Salida WHERE (Co" & _
        "digo = @Original_Codigo) AND (Descripcion = @Original_Descripcion) AND (Salida =" & _
        " @Original_Salida); SELECT Codigo, Descripcion, Salida FROM Estado_Empleado WHER" & _
        "E (Codigo = @Codigo)"
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 1, "Salida"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salida", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        '
        'AdMoneda
        '
        Me.AdMoneda.SelectCommand = Me.SqlSelectCommand8
        Me.AdMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta FROM Moneda"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'GBBancos
        '
        Me.GBBancos.Controls.Add(Me.LCuentaDestino)
        Me.GBBancos.Controls.Add(Me.Label_CodBanco)
        Me.GBBancos.Controls.Add(Me.ComboBoxBanco)
        Me.GBBancos.Controls.Add(Me.ComboBoxCuentaBancaria)
        Me.GBBancos.Controls.Add(Me.TextEdit1)
        Me.GBBancos.Controls.Add(Me.ComboBoxTipoPago)
        Me.GBBancos.Controls.Add(Me.Label33)
        Me.GBBancos.Controls.Add(Me.Label34)
        Me.GBBancos.Controls.Add(Me.Label35)
        Me.GBBancos.Controls.Add(Me.LCuenta)
        Me.GBBancos.Controls.Add(Me.Label31)
        Me.GBBancos.Controls.Add(Me.Label32)
        Me.GBBancos.Controls.Add(Me.Label30)
        Me.GBBancos.Controls.Add(Me.Label29)
        Me.GBBancos.ForeColor = System.Drawing.Color.Blue
        Me.GBBancos.Location = New System.Drawing.Point(8, 400)
        Me.GBBancos.Name = "GBBancos"
        Me.GBBancos.Size = New System.Drawing.Size(800, 88)
        Me.GBBancos.TabIndex = 10000
        Me.GBBancos.TabStop = False
        Me.GBBancos.Text = "Datos De La Liquidación"
        '
        'LCuentaDestino
        '
        Me.LCuentaDestino.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LCuentaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCuentaDestino.ForeColor = System.Drawing.Color.Blue
        Me.LCuentaDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LCuentaDestino.Location = New System.Drawing.Point(624, 56)
        Me.LCuentaDestino.Name = "LCuentaDestino"
        Me.LCuentaDestino.Size = New System.Drawing.Size(168, 16)
        Me.LCuentaDestino.TabIndex = 208
        Me.LCuentaDestino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_CodBanco
        '
        Me.Label_CodBanco.BackColor = System.Drawing.Color.Transparent
        Me.Label_CodBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_CodBanco.Font = New System.Drawing.Font("OCR A Extended", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_CodBanco.ForeColor = System.Drawing.Color.Lime
        Me.Label_CodBanco.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label_CodBanco.Location = New System.Drawing.Point(304, 16)
        Me.Label_CodBanco.Name = "Label_CodBanco"
        Me.Label_CodBanco.Size = New System.Drawing.Size(88, 16)
        Me.Label_CodBanco.TabIndex = 207
        Me.Label_CodBanco.Text = "000000"
        Me.Label_CodBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBoxBanco
        '
        Me.ComboBoxBanco.DataSource = Me.DsBancos
        Me.ComboBoxBanco.DisplayMember = "Bancos.Descripcion"
        Me.ComboBoxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBanco.ForeColor = System.Drawing.Color.Blue
        Me.ComboBoxBanco.ItemHeight = 13
        Me.ComboBoxBanco.Location = New System.Drawing.Point(120, 40)
        Me.ComboBoxBanco.Name = "ComboBoxBanco"
        Me.ComboBoxBanco.Size = New System.Drawing.Size(272, 21)
        Me.ComboBoxBanco.TabIndex = 206
        Me.ComboBoxBanco.ValueMember = "Bancos.Codigo_banco"
        '
        'DsBancos
        '
        Me.DsBancos.DataSetName = "DsBancos"
        Me.DsBancos.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'ComboBoxCuentaBancaria
        '
        Me.ComboBoxCuentaBancaria.DataSource = Me.DsBancos
        Me.ComboBoxCuentaBancaria.DisplayMember = "Bancos.BancosCuentas_bancarias.Cuenta"
        Me.ComboBoxCuentaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCuentaBancaria.ForeColor = System.Drawing.Color.Blue
        Me.ComboBoxCuentaBancaria.ItemHeight = 13
        Me.ComboBoxCuentaBancaria.Location = New System.Drawing.Point(120, 64)
        Me.ComboBoxCuentaBancaria.Name = "ComboBoxCuentaBancaria"
        Me.ComboBoxCuentaBancaria.Size = New System.Drawing.Size(120, 21)
        Me.ComboBoxCuentaBancaria.TabIndex = 205
        Me.ComboBoxCuentaBancaria.ValueMember = "Cuentas_bancarias.Id_CuentaBancaria"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsLiquidacion, "liquidacionempleados.Num_Cheque"))
        Me.TextEdit1.EditValue = ""
        Me.TextEdit1.Location = New System.Drawing.Point(520, 56)
        Me.TextEdit1.Name = "TextEdit1"
        '
        'TextEdit1.Properties
        '
        Me.TextEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.Enabled = False
        Me.TextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TextEdit1.Size = New System.Drawing.Size(96, 19)
        Me.TextEdit1.TabIndex = 203
        '
        'ComboBoxTipoPago
        '
        Me.ComboBoxTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoPago.ForeColor = System.Drawing.Color.Blue
        Me.ComboBoxTipoPago.Items.AddRange(New Object() {"CHEQUE", "TRANFERENCIA"})
        Me.ComboBoxTipoPago.Location = New System.Drawing.Point(408, 56)
        Me.ComboBoxTipoPago.Name = "ComboBoxTipoPago"
        Me.ComboBoxTipoPago.Size = New System.Drawing.Size(104, 21)
        Me.ComboBoxTipoPago.TabIndex = 202
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Blue
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(624, 40)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(168, 16)
        Me.Label33.TabIndex = 201
        Me.Label33.Text = "Cuenta Destino"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Blue
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(520, 40)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(96, 16)
        Me.Label34.TabIndex = 200
        Me.Label34.Text = "Documento"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Blue
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(408, 40)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(104, 16)
        Me.Label35.TabIndex = 199
        Me.Label35.Text = "Tipo Pago"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LCuenta
        '
        Me.LCuenta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCuenta.ForeColor = System.Drawing.Color.Blue
        Me.LCuenta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LCuenta.Location = New System.Drawing.Point(248, 64)
        Me.LCuenta.Name = "LCuenta"
        Me.LCuenta.Size = New System.Drawing.Size(144, 16)
        Me.LCuenta.TabIndex = 198
        Me.LCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Blue
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(8, 40)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(104, 18)
        Me.Label31.TabIndex = 197
        Me.Label31.Text = "Banco"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Blue
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(8, 64)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 21)
        Me.Label32.TabIndex = 196
        Me.Label32.Text = "Cuenta Bancaria"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label30.Location = New System.Drawing.Point(408, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(384, 16)
        Me.Label30.TabIndex = 195
        Me.Label30.Text = "Forma de Pago a Empleado"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.Location = New System.Drawing.Point(8, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(384, 16)
        Me.Label29.TabIndex = 185
        Me.Label29.Text = "Origen de la Forma de Pago"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdapterBancos
        '
        Me.AdapterBancos.DeleteCommand = Me.SqlDeleteCommand7
        Me.AdapterBancos.InsertCommand = Me.SqlInsertCommand7
        Me.AdapterBancos.SelectCommand = Me.SqlSelectCommand9
        Me.AdapterBancos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bancos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        Me.AdapterBancos.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = "DELETE FROM Bancos WHERE (Codigo_banco = @Original_Codigo_banco) AND (Descripcion" & _
        " = @Original_Descripcion)"
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo_banco", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_banco", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=DIEGOGAMBOA;packet size=4096;integrated security=SSPI;data source=" & _
        """."";persist security info=False;initial catalog=Bancos"
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = "INSERT INTO Bancos(Descripcion) VALUES (@Descripcion); SELECT Codigo_banco, Descr" & _
        "ipcion FROM Bancos WHERE (Codigo_banco = @@IDENTITY)"
        Me.SqlInsertCommand7.Connection = Me.SqlConnection2
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT Codigo_banco, Descripcion FROM Bancos"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = "UPDATE Bancos SET Descripcion = @Descripcion WHERE (Codigo_banco = @Original_Codi" & _
        "go_banco) AND (Descripcion = @Original_Descripcion); SELECT Codigo_banco, Descri" & _
        "pcion FROM Bancos WHERE (Codigo_banco = @Codigo_banco)"
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo_banco", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_banco", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo_banco", System.Data.SqlDbType.BigInt, 8, "Codigo_banco"))
        '
        'AdapterCuentasBancarias
        '
        Me.AdapterCuentasBancarias.DeleteCommand = Me.SqlDeleteCommand8
        Me.AdapterCuentasBancarias.InsertCommand = Me.SqlInsertCommand8
        Me.AdapterCuentasBancarias.SelectCommand = Me.SqlSelectCommand10
        Me.AdapterCuentasBancarias.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_bancarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("tipoCuenta", "tipoCuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        Me.AdapterCuentasBancarias.UpdateCommand = Me.SqlUpdateCommand8
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = "DELETE FROM Cuentas_bancarias WHERE (Id_CuentaBancaria = @Original_Id_CuentaBanca" & _
        "ria) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Codigo_banco = @Original_Codig" & _
        "o_banco) AND (Cuenta = @Original_Cuenta) AND (NombreCuenta = @Original_NombreCue" & _
        "nta) AND (tipoCuenta = @Original_tipoCuenta)"
        Me.SqlDeleteCommand8.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo_banco", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_banco", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipoCuenta", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoCuenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO Cuentas_bancarias(Codigo_banco, tipoCuenta, NombreCuenta, Cuenta, Cod" & _
        "_Moneda) VALUES (@Codigo_banco, @tipoCuenta, @NombreCuenta, @Cuenta, @Cod_Moneda" & _
        "); SELECT Codigo_banco, Id_CuentaBancaria, tipoCuenta, NombreCuenta, Cuenta, Cod" & _
        "_Moneda FROM Cuentas_bancarias WHERE (Id_CuentaBancaria = @@IDENTITY)"
        Me.SqlInsertCommand8.Connection = Me.SqlConnection2
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo_banco", System.Data.SqlDbType.BigInt, 8, "Codigo_banco"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipoCuenta", System.Data.SqlDbType.VarChar, 20, "tipoCuenta"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 75, "Cuenta"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT Codigo_banco, Id_CuentaBancaria, tipoCuenta, NombreCuenta, Cuenta, Cod_Mon" & _
        "eda FROM Cuentas_bancarias"
        Me.SqlSelectCommand10.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = "UPDATE Cuentas_bancarias SET Codigo_banco = @Codigo_banco, tipoCuenta = @tipoCuen" & _
        "ta, NombreCuenta = @NombreCuenta, Cuenta = @Cuenta, Cod_Moneda = @Cod_Moneda WHE" & _
        "RE (Id_CuentaBancaria = @Original_Id_CuentaBancaria) AND (Cod_Moneda = @Original" & _
        "_Cod_Moneda) AND (Codigo_banco = @Original_Codigo_banco) AND (Cuenta = @Original" & _
        "_Cuenta) AND (NombreCuenta = @Original_NombreCuenta) AND (tipoCuenta = @Original" & _
        "_tipoCuenta); SELECT Codigo_banco, Id_CuentaBancaria, tipoCuenta, NombreCuenta, " & _
        "Cuenta, Cod_Moneda FROM Cuentas_bancarias WHERE (Id_CuentaBancaria = @Id_CuentaB" & _
        "ancaria)"
        Me.SqlUpdateCommand8.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo_banco", System.Data.SqlDbType.BigInt, 8, "Codigo_banco"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipoCuenta", System.Data.SqlDbType.VarChar, 20, "tipoCuenta"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 75, "Cuenta"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo_banco", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_banco", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipoCuenta", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria"))
        '
        'AdapterCheques
        '
        Me.AdapterCheques.DeleteCommand = Me.SqlDeleteCommand10
        Me.AdapterCheques.InsertCommand = Me.SqlInsertCommand10
        Me.AdapterCheques.SelectCommand = Me.SqlSelectCommand11
        Me.AdapterCheques.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cheques", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Cheque", "Id_Cheque"), New System.Data.Common.DataColumnMapping("Num_Cheque", "Num_Cheque"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Portador", "Portador"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Conciliado", "Conciliado"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Asiento", "Asiento"), New System.Data.Common.DataColumnMapping("Cuenta_Destino", "Cuenta_Destino"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Num_Conciliacion", "Num_Conciliacion"), New System.Data.Common.DataColumnMapping("MontoLetras", "MontoLetras"), New System.Data.Common.DataColumnMapping("CodigoMoneda", "CodigoMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.AdapterCheques.UpdateCommand = Me.SqlUpdateCommand10
        '
        'SqlDeleteCommand10
        '
        Me.SqlDeleteCommand10.CommandText = "DELETE FROM Cheques WHERE (Id_Cheque = @Original_Id_Cheque) AND (Anulado = @Origi" & _
        "nal_Anulado) AND (Asiento = @Original_Asiento) AND (Ced_Usuario = @Original_Ced_" & _
        "Usuario) AND (CodigoMoneda = @Original_CodigoMoneda) AND (Conciliado = @Original" & _
        "_Conciliado) AND (Contabilizado = @Original_Contabilizado) AND (Cuenta_Destino =" & _
        " @Original_Cuenta_Destino) AND (Fecha = @Original_Fecha) AND (Id_CuentaBancaria " & _
        "= @Original_Id_CuentaBancaria) AND (Monto = @Original_Monto) AND (MontoLetras = " & _
        "@Original_MontoLetras) AND (Num_Cheque = @Original_Num_Cheque) AND (Num_Concilia" & _
        "cion = @Original_Num_Conciliacion) AND (Observaciones = @Original_Observaciones)" & _
        " AND (Portador = @Original_Portador) AND (Tipo = @Original_Tipo) AND (TipoCambio" & _
        " = @Original_TipoCambio)"
        Me.SqlDeleteCommand10.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Cheque", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cheque", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodigoMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Conciliado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Conciliado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta_Destino", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta_Destino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoLetras", System.Data.SqlDbType.VarChar, 350, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoLetras", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Cheque", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Cheque", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Conciliacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Portador", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Portador", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand10
        '
        Me.SqlInsertCommand10.CommandText = "INSERT INTO Cheques(Num_Cheque, Id_CuentaBancaria, Fecha, Portador, Monto, Concil" & _
        "iado, Anulado, Observaciones, Ced_Usuario, Contabilizado, Asiento, Cuenta_Destin" & _
        "o, Tipo, Num_Conciliacion, MontoLetras, CodigoMoneda, TipoCambio) VALUES (@Num_C" & _
        "heque, @Id_CuentaBancaria, @Fecha, @Portador, @Monto, @Conciliado, @Anulado, @Ob" & _
        "servaciones, @Ced_Usuario, @Contabilizado, @Asiento, @Cuenta_Destino, @Tipo, @Nu" & _
        "m_Conciliacion, @MontoLetras, @CodigoMoneda, @TipoCambio); SELECT Id_Cheque, Num" & _
        "_Cheque, Id_CuentaBancaria, Fecha, Portador, Monto, Conciliado, Anulado, Observa" & _
        "ciones, Ced_Usuario, Contabilizado, Asiento, Cuenta_Destino, Tipo, Num_Conciliac" & _
        "ion, MontoLetras, CodigoMoneda, TipoCambio FROM Cheques WHERE (Id_Cheque = @@IDE" & _
        "NTITY)"
        Me.SqlInsertCommand10.Connection = Me.SqlConnection2
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Cheque", System.Data.SqlDbType.BigInt, 8, "Num_Cheque"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Portador", System.Data.SqlDbType.VarChar, 250, "Portador"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Conciliado", System.Data.SqlDbType.Bit, 1, "Conciliado"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.VarChar, 15, "Asiento"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_Destino", System.Data.SqlDbType.VarChar, 100, "Cuenta_Destino"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 20, "Tipo"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, "Num_Conciliacion"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoLetras", System.Data.SqlDbType.VarChar, 350, "MontoLetras"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodigoMoneda", System.Data.SqlDbType.Int, 4, "CodigoMoneda"))
        Me.SqlInsertCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT Id_Cheque, Num_Cheque, Id_CuentaBancaria, Fecha, Portador, Monto, Concilia" & _
        "do, Anulado, Observaciones, Ced_Usuario, Contabilizado, Asiento, Cuenta_Destino," & _
        " Tipo, Num_Conciliacion, MontoLetras, CodigoMoneda, TipoCambio FROM Cheques"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand10
        '
        Me.SqlUpdateCommand10.CommandText = "UPDATE Cheques SET Num_Cheque = @Num_Cheque, Id_CuentaBancaria = @Id_CuentaBancar" & _
        "ia, Fecha = @Fecha, Portador = @Portador, Monto = @Monto, Conciliado = @Concilia" & _
        "do, Anulado = @Anulado, Observaciones = @Observaciones, Ced_Usuario = @Ced_Usuar" & _
        "io, Contabilizado = @Contabilizado, Asiento = @Asiento, Cuenta_Destino = @Cuenta" & _
        "_Destino, Tipo = @Tipo, Num_Conciliacion = @Num_Conciliacion, MontoLetras = @Mon" & _
        "toLetras, CodigoMoneda = @CodigoMoneda, TipoCambio = @TipoCambio WHERE (Id_Chequ" & _
        "e = @Original_Id_Cheque) AND (Anulado = @Original_Anulado) AND (Asiento = @Origi" & _
        "nal_Asiento) AND (Ced_Usuario = @Original_Ced_Usuario) AND (CodigoMoneda = @Orig" & _
        "inal_CodigoMoneda) AND (Conciliado = @Original_Conciliado) AND (Contabilizado = " & _
        "@Original_Contabilizado) AND (Cuenta_Destino = @Original_Cuenta_Destino) AND (Fe" & _
        "cha = @Original_Fecha) AND (Id_CuentaBancaria = @Original_Id_CuentaBancaria) AND" & _
        " (Monto = @Original_Monto) AND (MontoLetras = @Original_MontoLetras) AND (Num_Ch" & _
        "eque = @Original_Num_Cheque) AND (Num_Conciliacion = @Original_Num_Conciliacion)" & _
        " AND (Observaciones = @Original_Observaciones) AND (Portador = @Original_Portado" & _
        "r) AND (Tipo = @Original_Tipo) AND (TipoCambio = @Original_TipoCambio); SELECT I" & _
        "d_Cheque, Num_Cheque, Id_CuentaBancaria, Fecha, Portador, Monto, Conciliado, Anu" & _
        "lado, Observaciones, Ced_Usuario, Contabilizado, Asiento, Cuenta_Destino, Tipo, " & _
        "Num_Conciliacion, MontoLetras, CodigoMoneda, TipoCambio FROM Cheques WHERE (Id_C" & _
        "heque = @Id_Cheque)"
        Me.SqlUpdateCommand10.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Cheque", System.Data.SqlDbType.BigInt, 8, "Num_Cheque"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Portador", System.Data.SqlDbType.VarChar, 250, "Portador"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Conciliado", System.Data.SqlDbType.Bit, 1, "Conciliado"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.VarChar, 15, "Asiento"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_Destino", System.Data.SqlDbType.VarChar, 100, "Cuenta_Destino"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 20, "Tipo"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, "Num_Conciliacion"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoLetras", System.Data.SqlDbType.VarChar, 350, "MontoLetras"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodigoMoneda", System.Data.SqlDbType.Int, 4, "CodigoMoneda"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Cheque", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cheque", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodigoMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Conciliado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Conciliado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta_Destino", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta_Destino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoLetras", System.Data.SqlDbType.VarChar, 350, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoLetras", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Cheque", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Cheque", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Conciliacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Portador", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Portador", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Cheque", System.Data.SqlDbType.BigInt, 8, "Id_Cheque"))
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.txtNombreUsuario)
        Me.Panel4.Controls.Add(Me.Label39)
        Me.Panel4.Controls.Add(Me.txtUsuario)
        Me.Panel4.Controls.Add(Me.txtCedulaUsuario)
        Me.Panel4.Location = New System.Drawing.Point(512, 504)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(291, 32)
        Me.Panel4.TabIndex = 0
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(125, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.txtNombreUsuario.TabIndex = 1
        Me.txtNombreUsuario.Text = ""
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(-8, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(72, 13)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Usuario->"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(64, 0)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.Text = ""
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtCedulaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCedulaUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedulaUsuario.Enabled = False
        Me.txtCedulaUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(216, 16)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(72, 13)
        Me.txtCedulaUsuario.TabIndex = 3
        Me.txtCedulaUsuario.Text = ""
        '
        'LiquidacionLaboral
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(816, 550)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GBBancos)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LiquidacionLaboral"
        Me.Text = "Liquidacion Laboral"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.Label25, 0)
        Me.Controls.SetChildIndex(Me.Label26, 0)
        Me.Controls.SetChildIndex(Me.TextBox5, 0)
        Me.Controls.SetChildIndex(Me.TextBox20, 0)
        Me.Controls.SetChildIndex(Me.GBBancos, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DsLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBBancos.ResumeLayout(False)
        CType(Me.DsBancos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub LiquidacionLaboral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

        
            SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
            SqlConnection2.ConnectionString = GetSetting("SeeSOFT", "Bancos", "Conexion")
            Bloquear()
            txtUsuario.Focus()
            adAdelantos.Fill(DsLiquidacion, "Adelantos")
            adEmpleado.Fill(DsLiquidacion.Empleado)
            AdEstado.Fill(DsLiquidacion.Estado_Empleado)
            AdMoneda.Fill(DsLiquidacion.Moneda)
            If (Me.AdapterBancos.Fill(Me.DsBancos, "Bancos")) = 0 Then
                MsgBox("No se pueden Realizar abonos porque no hay Bancos Registrados, el módulo se cerrará", MsgBoxStyle.Critical)
                Me.Close()
            Else
                Me.ComboBoxBanco.SelectedIndex = 0
            End If

            sqlconexion1 = cconexion1.Conectar("Planilla")
            cedulajuridica = CStr(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT Cedula FROM Configuraciones"))
            cconexion1.DesConectar(sqlconexion1)
            If cedulajuridica.Equals("3-101-104775") Or cedulajuridica.Equals("3-101-354662") Then '3-101-104775
                GBBancos.Visible = False
            Else
                GBBancos.Visible = True
            End If


            Me.AdapterCuentasBancarias.Fill(Me.DsBancos, "Cuentas_bancarias")
            Me.AdapterCheques.Fill(Me.DsBancos, "Cheques")

            Me.ComboBoxCuentaBancaria.SelectedIndex = 0


            'Bindings
            Me.Label_CodBanco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsBancos, "Bancos.Codigo_banco"))
            Me.LCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsBancos, "Bancos.BancosCuentas_bancarias.NombreCuenta"))

            ToolBar1.Buttons(0).Enabled = False
            ToolBar1.Buttons(1).Enabled = False
            ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(4).Enabled = False
            ToolBar1.Buttons(5).Enabled = False

            Me.txtUsuario.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Toolbar"
    Private Sub ToolBar1_ButtonClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()

            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 4 : If PMU.Delete Then eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

                'Case 6 : imprimir()

            Case 7 : Me.Close()
        End Select
    End Sub
#End Region

#Region "Nuevo"
    Private Function Nuevo()
        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            'cambia la imagen de nuevo y desabilita los botones
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Try 'inicia la edicion
                Me.DsLiquidacion.Clear()
                Me.Limpiar()
                TxtNombre.Focus()
                TextBox5.Text = Now
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").CancelCurrentEdit()
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").EndCurrentEdit()
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").AddNew()
                Me.DesBloquear()
                Me.ToolBar1.Buttons(1).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = True
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.ToolBar1.Buttons(5).Enabled = False
                Me.TxtNombre.Focus()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.Bloquear()
                Me.Limpiar()

                Me.DsLiquidacion.Clear()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Function
#End Region

#Region "Guardar"
    Private Function Guardar()
        Dim cconexion1 As New Conexion
        Dim sqlconexion1 As SqlConnection
        Dim cedulajuridica As String = ""
        sqlconexion1 = cconexion1.Conectar("Planilla")
        cedulajuridica = CStr(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT Cedula FROM Configuraciones"))
        cconexion1.DesConectar(sqlconexion1)

        If txtUsuario.Text = "" Or txtNombreUsuario.Text = "" Or Me.txtCedulaUsuario.Text = "" Then
            MsgBox("Debe indicar cual usuario esta haciendo el movimiento", MsgBoxStyle.Information, "Atención...")
            txtUsuario.Focus()
            Exit Function
        End If
        If cedulajuridica.Equals("3-101-104775") Or cedulajuridica.Equals("3-101-354662") Then
        Else
            If Me.ComboBoxTipoPago.SelectedValue = 1 Then
                If VerificaDocumento() Then
                    MsgBox("El Numero de Documento Ya Existe", MsgBoxStyle.Exclamation)
                    Me.TextEdit1.Text = ""
                    Exit Function
                End If
            End If
        End If
        Me.adEmpleado.Fill(Me.DsLiquidacion, "Empleado")
        AdEstado.Fill(Me.DsLiquidacion, "Estado_Empleado")
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Dim Resp As Integer
        Try
            If ValidarDatos() Then

                Actualiza_Empleado()
                ActualizaAdelantos()
                MontoLetras()
                'finaliza la edición
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Identificacion") = TxtNombre.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Nombre") = TextBox1.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Fecha") = TextBox5.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("FechaIngreso") = TextBox2.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("SalarioMensual") = TextBox3.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("SalarioDiario") = TextBox4.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("FechaSalida") = TextBox6.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Cese") = Combo1.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Anos") = Me.TextBox8.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Meses") = Me.TextBox9.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Dia") = Me.TextBox10.Text

                Me.adLiquidacion.UpdateCommand.Transaction = Trans
                Me.adLiquidacion.InsertCommand.Transaction = Trans
                Me.adLiquidacion.DeleteCommand.Transaction = Trans
                Me.adEmpleado.UpdateCommand.Transaction = Trans
                Me.adEmpleado.InsertCommand.Transaction = Trans
                Me.adEmpleado.DeleteCommand.Transaction = Trans
                Me.adEmpleado.Update(Me.DsLiquidacion.Empleado)
                Me.adAdelantos.UpdateCommand.Transaction = Trans
                Me.adAdelantos.InsertCommand.Transaction = Trans
                Me.adAdelantos.DeleteCommand.Transaction = Trans
                Me.adAdelantos.Update(Me.DsLiquidacion.Adelantos)
                If cedulajuridica.Equals("3-101-104775") Or cedulajuridica.Equals("3-101-354662") Then
                    Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Num_Cheque") = "0"
                End If


                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").EndCurrentEdit()
                Me.adLiquidacion.Update(Me.DsLiquidacion, "liquidacionempleados")

                ActualizaAccion()
                If Not cedulajuridica.Equals("3-101-104775") Or cedulajuridica.Equals("3-101-354662") Then
                    GuardaCheque()
                    GuardaAsiento()
                End If


                Trans.Commit()
                Me.DsLiquidacion.AcceptChanges()

                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.Bloquear()
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
                Me.ToolBar1.Buttons(5).Enabled = True
                'cerrar
                Me.ToolBar1.Buttons(6).Enabled = True

                If MsgBox("Desea Imprimir esta Liquidacion ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    imprimir()
                End If

                If Me.ComboBoxTipoPago.SelectedIndex = 0 Then
                    Resp = MessageBox.Show("¿Desea Imprimir el Cheque?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If Resp = 6 Then
                        Me.imprimirCheque()
                    End If
                End If

                Me.DsLiquidacion.Clear()
                Me.Limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Trans.Rollback()
        End Try
    End Function
#End Region

#Region "Eliminar"
    Private Sub eliminar()
        Dim Cconexion As New Conexion
        Dim Resultado, Identificacion As String
        If Me.TxtNombre.Text <> "" Then

            If MessageBox.Show(" ¿ Desea Eliminar Esta Liquidacion ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub
            Resultado = Cconexion.SlqExecute(Cconexion.Conectar("Planilla"), "Delete from liquidacionempleados where Identificacion='" & Me.TxtNombre.Text & "' AND Liquidacion = " & CInt(Me.TextBox20.Text))
            ActualizaAccionElim()
            ActualizaAsiento()
            If Resultado = vbNullString Then
                MessageBox.Show("La Liquidacion Fue Eliminada", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DsLiquidacion.Clear()
                Me.Limpiar()
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
                Me.ToolBar1.Buttons(5).Enabled = True
                'Cerrar
                Me.ToolBar1.Buttons(6).Enabled = True
            Else
                MessageBox.Show(Resultado)
                Exit Sub
            End If
        Else
            MessageBox.Show("No hay Horas a eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

#Region "Busca Datos"
    Private Sub TxtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNombre.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            If Me.CheckTodos.Checked = True Then
                Me.TxtNombre.Text = cFunciones.BuscarDatos2("select Identificacion, Nombre, Fecha_Ingreso, Fecha_Salida, Diario, Semana, Quincena, Mensual, Hora, Salario from Empleado", "Nombre", " ORDER BY Nombre", "Buscar Empleado ...", SqlConnection1.ConnectionString)
            Else
                Me.TxtNombre.Text = cFunciones.BuscarDatos2("select Identificacion, Nombre, Fecha_Ingreso, Fecha_Salida, Diario, Semana, Quincena, Mensual, Hora, Salario from dbo.AccionPersonal INNER JOIN dbo.Empleado ON dbo.AccionPersonal.Id_Empleado COLLATE SQL_Latin1_General_CP1_CI_AS = dbo.Empleado.Identificacion INNER JOIN dbo.Estado_Empleado ON dbo.AccionPersonal.Cod_Estado = dbo.Estado_Empleado.Codigo where (dbo.Estado_Empleado.Salida = 1)  AND dbo.AccionPersonal.Anula = 0 AND dbo.AccionPersonal.Liquidacion = 0", "Nombre", "", "Buscar Salida Empleado ...", SqlConnection1.ConnectionString)
            End If

            If TxtNombre.Text <> "" Then
                CargarInformacionCliente(TxtNombre.Text)
            End If
        End If
    End Sub

    Private Sub CargarInformacionCliente(ByVal CodCliente As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader
        Dim i, Dia1, Dia2, Mes1, Mes2, Año1, Año2 As Integer
        Dim fila As DataRow
        Dim factura As Long
        Dim FormaPagos As String
        Dim FechaSalida, FechaEntrada, Fecha As DateTime
        Dim Salario, Mes, Dia, Tiempo, Año, PromedioMensual As Double
        Codigo = CodCliente
        If CodCliente <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar("Planilla"), "select Identificacion, Nombre, Fecha_Ingreso, Fecha_Salida, Diario, Semana, Quincena, Mensual, Hora, Salario from Empleado where Identificacion = '" & CodCliente & "'")
            Try
                If rs.Read Then
                    TxtNombre.Text = rs("Identificacion")
                    TextBox1.Text = rs("Nombre")
                    TextBox2.Text = Format(rs("Fecha_Ingreso"), "dd/MM/yyyy")
                    TextBox6.Text = Format(rs("Fecha_Salida"), "dd/MM/yyyy")
                    Salario = rs("Salario")

                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    If rs("Hora") = True Then FormaPagos = "HORA"
                    If rs("Diario") = True Then FormaPagos = "DIARIO"
                    If rs("Semana") = True Then FormaPagos = "SEMANAL"
                    If rs("Quincena") = True Then FormaPagos = "QUINCENAL"
                    If rs("Mensual") = True Then FormaPagos = "MENSUAL"
                    Select Case FormaPagos
                        Case "HORA" : Diario = Salario * 8
                        Case "DIARIO" : Diario = Salario
                        Case "SEMANAL" : Diario = Salario / 7.5
                        Case "QUINCENAL" : Diario = Salario / 15
                        Case "MENSUAL" : Diario = Salario / 30
                            TextBox4.Text = Diario
                    End Select
                    TextBox4.Text = Diario
                    TextBox3.Text = Diario * 30
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Combo1.Focus()
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            rs.Close()
            cConexion.DesConectar(cConexion.Conectar)
        Else
            MsgBox("La identificación del Cliente no se encuentra", MsgBoxStyle.Information, "Atención...")
            TextBox1.Text = ""
            TxtNombre.Focus()
            rs.Close()
        End If
    End Sub

    Function LlenarLiquidacion(ByVal Id As String)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim Total, Total1, Total2, Total3, Total4, TotalVacaciones, PromedioMensual As Double
        Dim i As Integer
        'Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''LLENAR LIQUIDACION''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM liquidacionempleados where Identificacion = @Id"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.VarChar))
            cmdv.Parameters("@Id").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DsLiquidacion, "liquidacionempleados")
            Combo1.Text = Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Cese")
            TextBox5.Text = Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Fecha")
            TextBox6.Text = Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("FechaSalida")
            'Me.adEmpleados.Fill(Me.DsPlanilla1, "Empleado")
            'TxtIdentificacion.Text = ""
            ' funcion.Llenar_Tabla_Generico("Select * from Empleado", Me.TablaEmpleado, Me.SqlConnection2.ConnectionString)
            'If Me.DsPlanilla1.Empleado.Rows.Count - 1 = -1 Then
            '    Me.LlenarEmpleado(Id)
            'End If
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

    Private Function Buscar()
        Dim funcion As New cFunciones
        Dim Id As String
        Dim FechaEmplea As String
        Dim Identificacion As Integer
        Try
            Me.DsLiquidacion.Clear()
            FechaEmpleado = 1
            Id = funcion.BuscarDatos("Select * from liquidacionempleados", "Nombre", "Buscar Liquidacion", SqlConnection1.ConnectionString, FechaEmpleado)
            FechaEmpleado = 0
            'buscando = True
            'Id = cFunciones.descripcion
            If Id = "" Then ' si se dio en el boton de cancelar
                ' Me.buscando = False
                Exit Function
            End If
            Me.LlenarLiquidacion(Id)
            Me.CargarInformacionCliente(Id)
            Me.CargarInformacionCheque()
            Me.Formato()
            'nuevo
            Me.ToolBar1.Buttons(0).Enabled = True
            'buscar
            Me.ToolBar1.Buttons(1).Enabled = True
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
            Me.Bloquear()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
#End Region

#Region "Calculos"
    Function Calculos()

        Dim i, Dia1, Dia2, Mes1, Mes2, Año1, Año2 As Integer
        Dim fila As DataRow
        Dim factura As Long
        Dim FormaPagos As String
        Dim FechaSalida, FechaEntrada As Date
        Dim Tiempo, Año As Double
        Dim Salario, Mes, Dia, PromedioMensual As Double

        FechaEntrada = CDate(TextBox2.Text)
        FechaSalida = CDate(TextBox6.Text)

        Tiempo = DateDiff(DateInterval.Day, FechaEntrada, FechaSalida)
        Año = Tiempo / 365
        TextBox8.Text = QuitaDecimal(Año)

        Mes = (((Año - TextBox8.Text) * 365) / 30)
        TextBox9.Text = QuitaDecimal(Mes)
        
        MesesVacaciones = (TextBox9.Text * 1.16) + (TextBox8.Text * 14)

        Dia = (Mes - TextBox9.Text) * 30

        TextBox10.Text = CInt(Dia)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Calculo de la Cesantia
        If Combo1.Text = "Despido Con Responsabilidad" Then
            If Año <= 0 And Mes < 3 Then
                DiaCesantia.Text = 0
                TextBox12.Text = Format(0, "#,#0.00")
            End If
            If Año <= 1 And Mes >= 3 And Mes < 6 Then
                DiaCesantia.Text = 7
                TextBox12.Text = Format(Diario * 7, "#,#0.00")
            End If
            If Año <= 1 And Mes >= 6 Then
                DiaCesantia.Text = 14
                TextBox12.Text = Format(Diario * 14, "#,#0.00")
            End If
            If Año >= 1 And Año < 2 Then
                DiaCesantia.Text = 19.5
                TextBox12.Text = Format(Diario * 19.5, "#,#0.00")
            End If
            If Año >= 2 And Año < 3 Then
                If Mes <= 6 Then
                    DiaCesantia.Text = 20 * TextBox8.Text
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                Else
                    DiaCesantia.Text = 20 * (TextBox8.Text + 1)
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                End If
            End If
            If Año >= 3 And Año < 4 Then
                If Mes <= 6 Then
                    DiaCesantia.Text = 20.5 * TextBox8.Text
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                Else
                    DiaCesantia.Text = 20.5 * (TextBox8.Text + 1)
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                End If
            End If
            If Año >= 4 And Año < 5 Then
                If Mes <= 6 Then
                    DiaCesantia.Text = 21 * TextBox8.Text
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                Else
                    DiaCesantia.Text = 21 * (TextBox8.Text + 1)
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                End If
            End If
            If Año >= 5 And Año < 6 Then
                If Mes <= 6 Then
                    DiaCesantia.Text = 21.24 * TextBox8.Text
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                Else
                    DiaCesantia.Text = 21.24 * (TextBox8.Text + 1)
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                End If
            End If
            If Año >= 6 And Año < 7 Then
                If Mes <= 6 Then
                    DiaCesantia.Text = 21.5 * TextBox8.Text
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                Else
                    DiaCesantia.Text = 21.5 * (TextBox8.Text + 1)
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                End If
            End If
            If Año >= 7 And Año < 10 Then
                If Mes <= 6 Then
                    DiaCesantia.Text = 22 * TextBox8.Text
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                Else
                    DiaCesantia.Text = 22 * (TextBox8.Text + 1)
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                End If
            End If
            If Año >= 10 And Año < 11 Then
                If Mes <= 6 Then
                    DiaCesantia.Text = 21.5 * TextBox8.Text
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                Else
                    DiaCesantia.Text = 21.5 * (TextBox8.Text + 1)
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                End If
            End If
            If Año >= 12 And Año < 13 Then
                If Mes <= 6 Then
                    DiaCesantia.Text = 20.5 * TextBox8.Text
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                Else
                    DiaCesantia.Text = 20.5 * (TextBox8.Text + 1)
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                End If
            End If

            If Año >= 13 Then
                If Mes <= 6 Then
                    DiaCesantia.Text = 20 * TextBox8.Text
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                Else
                    DiaCesantia.Text = 20 * (TextBox8.Text + 1)
                    TextBox12.Text = Format(Diario * DiaCesantia.Text, "#,#0.00")
                End If

            End If
            If Me.DiaCesantia.Text = Nothing Then
                Me.DiaCesantia.Text = "0.00"
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Calculo de Preaviso
            If Año < 1 And Mes >= 3 And Mes < 6 Then
                TextBox14.Text = 7
                TextBox13.Text = Format(Diario * 7, "#,#0.00")
            End If
            If Año < 1 And Mes >= 6 Then
                TextBox14.Text = 15
                TextBox13.Text = Format(Diario * 15, "#,#0.00")
            End If
            If Año >= 1 Then
                TextBox14.Text = 30
                TextBox13.Text = Format(Diario * 30, "#,#0.00")
            End If
            If TextBox14.Text = "" Then
                TextBox14.Text = 0
            End If
            salDiario = Diario
        Else
            DiaCesantia.Text = "0.00"
            TextBox12.Text = "0.00"
            TextBox14.Text = "0.00"
            TextBox13.Text = "0.00"
            TextBox22.Text = "0.00"
            TextBox11.Text = "0.00"
        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Buscar el id de la acción de personal de vacaciones
        Dim cconexion As New Conexion
        Dim sqlconexion As New SqlClient.SqlConnection
        Dim IdVacaciones As Integer
        sqlconexion = cconexion.Conectar("Planilla")
        IdVacaciones = CInt(cconexion.SlqExecuteScalar(sqlconexion, "SELECT Codigo FROM Accion WHERE (Vacaciones = 1)"))
        cconexion.DesConectar(sqlconexion)
        LlenarVacaciones(Codigo, IdVacaciones)
        LlenarEmpleados(Codigo)
    End Function

    Function CalculoAdelantos(ByVal Codigo)
        Dim j, k As Integer
        Dim Adelanto, Prestamo As Double
        Dim DataView As DataView
        Try
            Adelanto = 0
            Adelantos = 0
            Prestamo = 0

            Me.adAdelantos.Fill(DsLiquidacion, "Adelantos")
            Me.adEmpleado.Fill(DsLiquidacion, "Empleado")
            Me.AdMoneda.Fill(DsLiquidacion, "Moneda")

            Me.GridControl1.DataSource = Me.DsLiquidacion.Adelantos.Select("Identificacion = '" & Codigo & "'and Saldo > 0 and Anulado = 0")

            For j = 0 To Me.DsLiquidacion.Adelantos.Rows.Count - 1
                If Me.DsLiquidacion.Adelantos.Rows(j).Item("Identificacion") = Codigo And Me.DsLiquidacion.Adelantos.Rows(j).Item("Saldo") > 0 And Me.DsLiquidacion.Adelantos.Rows(j).Item("Anulado") = 0 Then

                    For k = 0 To Me.DsLiquidacion.Empleado.Rows.Count - 1
                        If Me.DsLiquidacion.Empleado.Rows(k).Item("Identificacion") = Codigo And Me.DsLiquidacion.Empleado.Rows(k).Item("Cod_Moneda") <> Me.DsLiquidacion.Adelantos.Rows(j).Item("Cod_Moneda") Then

                            If Me.DsLiquidacion.Empleado.Rows(k).Item("Cod_Moneda") = 1 Then
                                Me.DsLiquidacion.Adelantos.Rows(j).Item("Saldo") = Me.DsLiquidacion.Adelantos.Rows(j).Item("Saldo") * Me.DsLiquidacion.Moneda.Rows(1).Item("ValorCompra")
                            Else
                                Me.DsLiquidacion.Adelantos.Rows(j).Item("Saldo") = Me.DsLiquidacion.Adelantos.Rows(j).Item("Saldo") / Me.DsLiquidacion.Moneda.Rows(1).Item("ValorCompra")
                            End If
                        End If
                    Next
                    Adelanto = Me.DsLiquidacion.Adelantos.Rows(j).Item("Saldo")
                    Adelantos = Adelantos + Adelanto
                End If
            Next
            TextBox21.Text = Format(Adelantos, "#,#0.00")
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Function

    Private Function QuitaDecimal(ByVal numero As String) As String
        Dim punto As Integer = -1

        punto = numero.IndexOf(".")
        If punto <> -1 Then
            QuitaDecimal = numero.Substring(0, punto)
            Exit Function
        End If

        QuitaDecimal = numero
    End Function

    Function LlenarVacaciones(ByVal Id As String, ByVal IdVacaciones As Integer)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim Total, Total1, Total2, Total3, Total4, TotalVacaciones, PromedioMensual As Double
        Dim i As Integer
        'Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''LLENAR VACACIONES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM AccionPersonal where Anula = 0 and (Id_Accion =" & IdVacaciones & " ) AND (Id_Empleado = @Id) And Fecha >= '" & Format(CDate(Me.TextBox2.Text), "dd/MM/yyyy") & "'"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.VarChar))
            cmdv.Parameters("@Id").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DsLiquidacion, "AccionPersonal")
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
            For i = 0 To Me.DsLiquidacion.AccionPersonal.Rows.Count - 1
                TotalVacaciones = TotalVacaciones + Me.DsLiquidacion.AccionPersonal.Rows(i).Item("DiasaDescontar")
            Next
            PromedioMensual = (TotalGanado / 12) / 30
            If Año < 1 Then
                TextBox18.Text = Format(MesesVacaciones - TotalVacaciones, "#,##0")
                TextBox17.Text = Format(TextBox18.Text * Diario, "#,#0.00")
            End If
            If Año >= 1 Then
                TextBox18.Text = ((12 * TextBox8.Text) + TextBox9.Text) - TotalVacaciones
                TextBox17.Text = Format(TextBox18.Text * Diario, "#,#0.00")
            End If

        End Try

    End Function

    Function LlenarEmpleados(ByVal Id As String)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones

        Dim i As Integer
        TotalGanado = 0
        'Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''LLENAR PAGOS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT Planilla_Detalle.Cedula, Planilla_Detalle.Nombre, Planilla_Detalle.Salario, Planilla_Detalle.SalarioBruto, Planilla_Detalle.FormaPago,Planilla_Detalle.Id, Planilla_Detalle.Id_Planilla FROM Planilla_Detalle INNER JOIN Planilla ON  Planilla_Detalle.Id_Planilla = Planilla.Id_Planilla WHERE (Planilla_Detalle.Cedula = @Id) and (Planilla.Anulado <> 1) AND (Planilla.FechaFinal > '" & CDate(Me.TextBox2.Text) & "')"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.VarChar))
            cmdv.Parameters("@Id").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DsLiquidacion, "Planilla_Detalle")
            'Me.adEmpleados.Fill(Me.DsPlanilla1, "Empleado")
            'TxtIdentificacion.Text = ""
            ' funcion.Llenar_Tabla_Generico("Select * from Empleado", Me.TablaEmpleado, Me.SqlConnection2.ConnectionString)
            'If Me.DsPlanilla1.Empleado.Rows.Count - 1 = -1 Then
            '    Me.LlenarEmpleado(Id)
            'End If
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
            For i = 0 To Me.DsLiquidacion.Planilla_Detalle.Rows.Count - 1
                TotalGanado = TotalGanado + Me.DsLiquidacion.Planilla_Detalle.Rows(i).Item("SalarioBruto")
                If VerificaAguinaldo(DsLiquidacion.Planilla_Detalle.Rows(i).Item("Id_Planilla")) Then
                    TotalAguinaldo = TotalAguinaldo + Me.DsLiquidacion.Planilla_Detalle.Rows(i).Item("SalarioBruto")
                End If
            Next
            TextBox16.Text = Format(TotalAguinaldo, "#,#0.00")
            TextBox15.Text = Format(TotalAguinaldo / 12, "#,#0.00")
            If TextBox12.Text = "" Then
                TextBox12.Text = 0
            End If
            If TextBox13.Text = "" Then
                TextBox13.Text = 0
            End If
            If TextBox15.Text = "" Then
                TextBox15.Text = 0
            End If
            Total1 = TextBox12.Text
            Total2 = TextBox13.Text
            Total3 = TextBox15.Text
            If TextBox17.Text = "" Then
                TextBox17.Text = 0
            End If
            Total4 = TextBox17.Text
            Total = Total1 + Total2 + Total3 + Total4
            CalculoAdelantos(Codigo)
            Total = Total - Adelantos
            TextBox19.Text = Format(Total, "#,#0.00")
        End Try
    End Function

    Function VerificaAguinaldo(ByVal Planilla As String) As Boolean
        Dim cConexion As New Conexion
        Dim Fecha, FechaFinal As DateTime

        Try
            FechaFinal = CDate(TextBox6.Text)
            Fecha = cConexion.SlqExecuteScalar(cConexion.Conectar("Planilla"), "SELECT FechaFinal FROM Planilla WHERE Id_Planilla = " & Planilla)

            If Fecha.Year < FechaFinal.Year Then
                If Fecha.Month = 12 Then
                    Return True
                Else
                    Return False
                End If
            ElseIf Fecha.Year = FechaFinal.Year Then
                If Fecha.Month = 12 And FechaFinal.Month <> 12 Then
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function
#End Region

#Region "Otros"
    Function Bloquear()
        TxtNombre.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        Combo1.Enabled = False
        TextBox6.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        'TextBox7.Enabled = False
        TextBox10.Enabled = False
        DiaCesantia.Enabled = False
        TextBox12.Enabled = False
        TextBox14.Enabled = False
        TextBox13.Enabled = False
        TextBox16.Enabled = False
        TextBox15.Enabled = False
        TextBox18.Enabled = False
        TextBox17.Enabled = False
        TextBox19.Enabled = False
        CheckTodos.Enabled = False
        Me.ComboBoxBanco.Enabled = False
        Me.ComboBoxCuentaBancaria.Enabled = False
        Me.ComboBoxTipoPago.Enabled = False
        Me.TextEdit1.Enabled = False
    End Function

    Function DesBloquear()
        TxtNombre.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        Combo1.Enabled = True
        TextBox6.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        'TextBox7.Enabled = True
        TextBox10.Enabled = True
        DiaCesantia.Enabled = True
        TextBox12.Enabled = True
        TextBox14.Enabled = True
        TextBox13.Enabled = True
        TextBox16.Enabled = True
        TextBox15.Enabled = True
        TextBox18.Enabled = True
        TextBox17.Enabled = True
        TextBox19.Enabled = True
        CheckTodos.Enabled = True
        Me.ComboBoxBanco.Enabled = True
        Me.ComboBoxCuentaBancaria.Enabled = True
        Me.ComboBoxTipoPago.Enabled = True
    End Function

    Function Formato()
        TextBox12.Text = Format(TextBox12.Text * 1, "#,#0.00")
        TextBox13.Text = Format(TextBox13.Text * 1, "#,#0.00")
        TextBox16.Text = Format(TextBox16.Text * 1, "#,#0.00")
        TextBox15.Text = Format(TextBox15.Text * 1, "#,#0.00")
        TextBox18.Text = Format(TextBox18.Text * 1, "#,#0.00")
        TextBox17.Text = Format(TextBox17.Text * 1, "#,#0.00")
        TextBox19.Text = Format(TextBox19.Text * 1, "#,#0.00")
    End Function

    Function ValidarDatos() As Boolean
        ValidarDatos = False
        If TxtNombre.Text = "" Then
            MsgBox("Debe Seleccionar el Empleado", MsgBoxStyle.Information, "Sistema SeeSoft")
            TxtNombre.Focus()
            Exit Function
        End If
        If Combo1.Text = "" Then
            MsgBox("Debe Seleccionar el Causa de Despido", MsgBoxStyle.Information, "Sistema SeeSoft")
            Combo1.Focus()
            Exit Function
        End If
        Dim cedulajuridica As String = ""
        sqlconexion1 = cconexion1.Conectar("Planilla")
        cedulajuridica = CStr(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT Cedula FROM Configuraciones"))
        cconexion1.DesConectar(sqlconexion1)
        If Not cedulajuridica.Equals("3-101-104775") And Not cedulajuridica.Equals("3-101-354662") Then
            If Me.ComboBoxTipoPago.Text = "" Then
                MsgBox("Debe Selecionar un Tipo de Pago", MsgBoxStyle.Information, "Sistema SeeSoft")
                Me.ComboBoxTipoPago.Focus()
                Exit Function
            End If
            If Me.TextEdit1.Text = "" Then
                MsgBox("Debe Selecionar Número de Documento", MsgBoxStyle.Information, "Sistema SeeSoft")
                Me.TextEdit1.Focus()
                Exit Function
            End If
        End If
        ValidarDatos = True
    End Function

    Function Limpiar()
        TxtNombre.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Combo1.Text = ""
        TextBox6.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox7.Text = ""
        TextBox10.Text = ""
        DiaCesantia.Text = ""
        TextBox12.Text = ""
        TextBox14.Text = ""
        TextBox13.Text = ""
        TextBox16.Text = ""
        TextBox15.Text = ""
        TextBox18.Text = ""
        TextBox17.Text = ""
        TextBox19.Text = ""
        CheckTodos.Checked = False
        Me.TextEdit1.Text = ""
        Me.LCuentaDestino.Text = ""
        TextBoxMontoLetras.Text = "Monto En Letras"
    End Function

    Private Sub CheckTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckTodos.CheckedChanged
        If Me.CheckTodos.Checked = True Then
            Me.ToolBarRegistrar.Enabled = False
        Else
            Me.ToolBarRegistrar.Enabled = True
        End If
    End Sub

    Private Sub TextEdit1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextEdit1.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros enteros
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub Combo1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Combo1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox7.ReadOnly = False
            TextBox7.Focus()
        End If
    End Sub
#End Region

#Region "Imprimir"
    Private Function imprimir()
        Try
            Dim Imprimir_Liquidacion As New Liquidacion
            Dim visor As New frmVisorReportes
            Utilidades.CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Imprimir_Liquidacion, False, GetSetting("SeeSOFT", "Planilla", "Conexion"))
            Imprimir_Liquidacion.SetParameterValue(0, TxtNombre.Text)
            visor.rptViewer.ReportSource = Imprimir_Liquidacion
            visor.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Function

    Private Function imprimirCheque()
        Try
            Dim ChequeLiq As New ReporteChequesEstructura
            Dim servidor As String = SqlConnection2.DataSource
            Dim visor As New frmVisorReportes
            BuscaId()
            ChequeLiq.SetParameterValue(0, IdCheque)
            Utilidades.CrystalReportsConexion.LoadReportViewer(visor.rptViewer, ChequeLiq, False, GetSetting("SeeSOFT", "Bancos", "Conexion"))
            visor.rptViewer.Visible = True
            ChequeLiq = Nothing
            visor.MdiParent = ParentForm
            visor.Show()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly, "Atención...")
        End Try
    End Function

#End Region

#Region "Actualiza"
    Private Sub Actualiza_Empleado()
        Dim i, n As Integer
        Try
            For i = 0 To Me.DsLiquidacion.Empleado.Rows.Count - 1
                If Me.DsLiquidacion.Empleado.Rows(i).Item("Identificacion") = TxtNombre.Text Then
                    For n = 0 To Me.DsLiquidacion.Estado_Empleado.Rows.Count - 1
                        If Combo1.Text = "Despido Con Responsabilidad" Or Combo1.Text = "Despido Sin Responsabilidad" And DsLiquidacion.Estado_Empleado.Rows(n).Item("Descripcion") = "DESPEDIDO" Then
                            Me.DsLiquidacion.Empleado.Rows(i).Item("Cod_Estado") = Me.DsLiquidacion.Estado_Empleado.Rows(n).Item("Codigo")

                        ElseIf Combo1.Text = "Renuncia" And DsLiquidacion.Estado_Empleado.Rows(n).Item("Descripcion") = "RENUNCIO" Then
                            Me.DsLiquidacion.Empleado.Rows(i).Item("Cod_Estado") = Me.DsLiquidacion.Estado_Empleado.Rows(n).Item("Codigo")
                        End If
                    Next
                    DsLiquidacion.Empleado.Rows(i).Item("Fecha_Salida") = TextBox6.Text
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Function ActualizaAdelantos()
        Dim j As Integer

        Try
            Me.GridControl1.DataSource = Me.DsLiquidacion.Adelantos.Select("Identificacion = '" & TxtNombre.Text & "'and Saldo > 0 and Anulado = 0")
            For j = 0 To Me.DsLiquidacion.Adelantos.Rows.Count - 1
                If Me.DsLiquidacion.Adelantos.Rows(j).Item("Identificacion") = TxtNombre.Text And Me.DsLiquidacion.Adelantos.Rows(j).Item("Saldo") > 0 And Me.DsLiquidacion.Adelantos.Rows(j).Item("Anulado") = 0 Then
                    Me.DsLiquidacion.Adelantos.Rows(j).Item("Saldo") = 0
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub ActualizaAsiento()
        Dim cConexion As New Conexion
        cConexion.SlqExecuteScalar(cConexion.Conectar("Contabilidad"), "UPDATE AsientosContables SET Anulado = 1 WHERE NumDoc = " & CInt(Me.TextBox20.Text))
        cConexion.DesConectar(cConexion.sQlconexion)
    End Sub

#Region "Actualiza Accion de Personal"
    Private Sub ActualizaAccion()
        Dim cConexion As New Conexion
        cConexion.SlqExecuteScalar(cConexion.Conectar("Planilla"), "UPDATE AccionPersonal SET Liquidacion = 1 FROM dbo.AccionPersonal INNER JOIN dbo.Estado_Empleado ON dbo.AccionPersonal.Cod_Estado = dbo.Estado_Empleado.Codigo WHERE (Id_Empleado = '" & Me.TxtNombre.Text & "') AND (dbo.Estado_Empleado.Salida = 1) AND (dbo.AccionPersonal.Liquidacion = 0)")
        cConexion.DesConectar(cConexion.sQlconexion)
    End Sub

    Private Sub ActualizaAccionElim()
        Dim cConexion As New Conexion
        cConexion.SlqExecuteScalar(cConexion.Conectar("Planilla"), "UPDATE AccionPersonal SET Liquidacion = 0 FROM dbo.AccionPersonal INNER JOIN dbo.Estado_Empleado ON dbo.AccionPersonal.Cod_Estado = dbo.Estado_Empleado.Codigo WHERE (Id_Empleado = '" & Me.TxtNombre.Text & "') AND (dbo.Estado_Empleado.Salida = 1) AND (dbo.AccionPersonal.Liquidacion = 0)")
        cConexion.DesConectar(cConexion.sQlconexion)
    End Sub

#End Region

#End Region

#Region "Cheque y Bancos"
    Private Sub GuardaCheque()
        Dim cConexion As New Conexion
        Dim CuentaDes As String

        Try
            If Me.ComboBoxTipoPago.SelectedIndex = 1 Then
                CuentaDes = Me.LCuentaDestino.Text
            Else
                CuentaDes = ""
            End If

            Me.Total = TextBox19.Text

            cConexion.SlqExecuteScalar(cConexion.Conectar("Bancos"), "INSERT INTO Cheques (Num_Cheque, Id_CuentaBancaria, " & _
            "Fecha, Portador, Monto, Conciliado, Anulado, Observaciones, Ced_Usuario, Contabilizado, Asiento, Cuenta_Destino, " & _
            "Tipo, Num_Conciliacion, MontoLetras, CodigoMoneda, TipoCambio) VALUES (" & CInt(Me.TextEdit1.Text) & ", " & CInt(Me.ComboBoxCuentaBancaria.SelectedValue) & ", " & _
            "'" & Now.Date & "', '" & Me.TextBox1.Text & "', " & Me.Total & ", 0, 0, 'Pago De Liquidación de " & TextBox1.Text & "' , " & Me.txtCedulaUsuario.Text & ", " & _
            "1, 0, '" & CuentaDes & "', '" & Me.ComboBoxTipoPago.Text & "', 0, '" & Me.TextBoxMontoLetras.Text & "', 1, 1)")
            cConexion.DesConectar(cConexion.sQlconexion)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BuscarNumeroCheque()
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim n As Integer
        Dim sql, Cuenta As String

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Bancos", "CONEXION")
        cnnConexion.Open()

        If Me.ComboBoxCuentaBancaria.SelectedIndex = -1 Then Exit Sub

        Cuenta = Me.ComboBoxCuentaBancaria.Text

        sql = " select isnull(max(num_cheque + 1 ),1) as numero from cheques che, Cuentas_bancarias CB  " & _
                " where Che.id_cuentabancaria = CB.Id_CuentaBancaria " & _
                " and CB.Cuenta ='" & Cuenta & "' and Tipo = 'CHEQUE'"

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rstReader.Read() = False Then Exit Sub
        Me.TextEdit1.Text = rstReader("NUMERO")
        Me.LCuentaDestino.Text = ""
        rstReader.Close()
    End Sub

    Private Sub BuscaId()
        Dim cConexion As New Conexion
        Try
            IdCheque = cConexion.SlqExecuteScalar(cConexion.Conectar("Bancos"), "SELECT Id_Cheque FROM Cheques WHERE Num_Cheque = " & CInt(Me.TextEdit1.Text))
            cConexion.DesConectar(cConexion.sQlconexion)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            Calculos()
            MontoLetras()
        End If
    End Sub

    Function MontoLetras()
        Dim Num2Text As New cNum2Text
        TextBoxMontoLetras.Text = Num2Text.Numero2Letra(Me.TextBox19.Text, 0, 2, "", " CENTIMO", cNum2Text.eSexo.Masculino, cNum2Text.eSexo.Masculino).ToUpper.ToString
    End Function

    Function VerificaDocumento() As Boolean
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader

        VerificaDocumento = False
        If Me.TextEdit1.Text <> "" Then
            rs = cConexion.GetRecorset(cConexion.Conectar("Bancos"), "SELECT Num_Cheque from Cheques where Tipo ='TRANSFERENCIA'")
            While rs.Read
                Try
                    If TextEdit1.Text = rs("Num_Cheque") Then
                        VerificaDocumento = True
                    End If
                Catch ex As SystemException
                    MsgBox(ex.Message)
                End Try
            End While
            rs.Close()
            cConexion.DesConectar(cConexion.Conectar)

        Else
            MsgBox("Debe de digitar el número de Documento", MsgBoxStyle.Exclamation)
        End If
    End Function

    Private Sub CargarInformacionCheque()
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader
        Dim fila As DataRow

        If Me.TextBox1.Text <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar("Bancos"), "select Num_Cheque, Id_CuentaBancaria, Cuenta_Destino, Tipo,MontoLetras from Cheques where Portador = '" & Me.TextBox1.Text & "' AND Num_Cheque = " & CInt(Me.TextEdit1.Text))
            Try
                If rs.Read Then
                    Me.IdCuenta = rs("Id_CuentaBancaria")
                    BuscaBanco()
                    Me.ComboBoxCuentaBancaria.SelectedValue = Me.IdCuenta
                    Me.LCuentaDestino.Text = rs("Cuenta_Destino")
                    Me.ComboBoxTipoPago.SelectedItem = rs("Tipo")
                    Me.TextEdit1.Text = rs("Num_Cheque")
                    Me.TextBoxMontoLetras.Text = rs("MontoLetras")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            rs.Close()
            cConexion.DesConectar(cConexion.Conectar)
        Else
            MsgBox("Seleccione un Empleado", MsgBoxStyle.Information, "Atención...")
            TextBox1.Text = ""
            TxtNombre.Focus()
            rs.Close()
        End If
    End Sub

    Private Sub TextEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If VerificaDocumento() Then
                MsgBox("El Numero de Documento Ya Existe", MsgBoxStyle.Exclamation)
                Me.TextEdit1.Text = ""
            End If
        End If
    End Sub

    Private Sub BuscaBanco()
        Dim cConexion As New Conexion
        Try
            Me.ComboBoxBanco.SelectedValue = cConexion.SlqExecuteScalar(cConexion.Conectar("Bancos"), "SELECT Codigo_banco FROM Cuentas_bancarias WHERE Id_CuentaBancaria = " & Me.IdCuenta)
            cConexion.DesConectar(cConexion.sQlconexion)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ComboBoxCuentaBancaria_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxCuentaBancaria.SelectedIndexChanged
        If Me.ComboBoxTipoPago.SelectedIndex = 0 Then
            BuscarNumeroCheque()
        End If
    End Sub

    Private Sub ComboBoxTipoPago_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxTipoPago.SelectedIndexChanged
        Select Case Me.ComboBoxTipoPago.SelectedIndex
            Case 0 : TextEdit1.Enabled = False : BuscarNumeroCheque()
            Case 1 : TextEdit1.Text = "" : TextEdit1.Enabled = True : BuscaCuenta()
        End Select
    End Sub

    Private Sub BuscaCuenta()
        If Me.TxtNombre.Text <> "" Then
            Dim cConexion As New Conexion
            Me.LCuentaDestino.Text = cConexion.SlqExecuteScalar(cConexion.Conectar("Planilla"), "SELECT CuentaBancaria From Empleado WHERE (Identificacion = '" & Me.TxtNombre.Text & "')")
            cConexion.DesConectar(cConexion.sQlconexion)
        Else
            MsgBox("Debe Seleccionar un Empleado", MsgBoxStyle.Information, "Sistema SeeSoft")
        End If
    End Sub

#End Region

#Region "Loggin Usuario"
    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Loggin_Usuario() Then
            End If
        End If
    End Sub

    Function Loggin_Usuario() As Boolean
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader

        Try
            If Me.txtUsuario.Text <> "" Then
                rs = cConexion.GetRecorset(cConexion.Conectar2, "SELECT Id_Usuario, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Focus()
                    txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.txtCedulaUsuario.Text = ""
                    Return False
                End If
                While rs.Read
                    Try
                        Me.txtNombreUsuario.Text = rs("Nombre")
                        Me.txtCedulaUsuario.Text = rs("Id_Usuario")
                        TextBox2.Enabled = False
                        ToolBar1.Buttons(0).Enabled = True
                        ToolBar1.Buttons(1).Enabled = True
                        Return True

                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.Conectar)
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                txtUsuario.Focus()
                Me.txtNombreUsuario.Text = ""
                Me.txtCedulaUsuario.Text = ""
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
#End Region

#Region "Asiento Contables"
    Private Sub GuardaAsiento()
        Dim cConexion As New Conexion
        Dim Fx As New cFunciones

        NumeroAsiento = Fx.BuscaNumeroAsiento("PLA-" & Format(Now.Month, "00") & Format(Now.Date, "yy") & "-")

        Try
            cConexion.SlqExecuteScalar(cConexion.Conectar("Contabilidad"), "INSERT INTO AsientosContables (NumAsiento,Fecha, IdNumDoc, NumDoc, " & _
            "Beneficiario, TipoDoc, Accion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, " & _
            "NombreUsuario, TotalDebe, TotalHaber) VALUES ('" & NumeroAsiento & "','" & Now.Date & "', " & Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Liquidacion") & ", " & _
            "'" & Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Liquidacion") & "','" & Me.TextBox1.Text & "', 23, 'AUT',0, '" & Now.Date & "', 0, '" & Fx.BuscaPeriodo(Now.Date) & "' , 0, " & _
            "'Planilla', 'Asiento de Liquidación Laboral del Empleado " & Me.TextBox1.Text & "', '" & Me.txtNombreUsuario.Text & "', " & Me.Total & ", " & Me.Total & ")")
            cConexion.DesConectar(cConexion.sQlconexion)

            GuardaDetalleDebe()
            GuardaDetalleHaber()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GuardaDetalleDebe()
        Dim cConexion As New Conexion
        Dim rs, DrCuentas As SqlDataReader
        Dim Con As New Conexion
        Dim Monto As Double

        If NumeroAsiento <> vbNullString Then
            rs = cConexion.GetRecorset(cConexion.Conectar("Planilla"), "Select IdDepartamento,Porcentaje from EmpleadoDistribucionContable where EmpleadoIdentificacion = '" & Me.TxtNombre.Text & "'")
            Try
                '------------------------- Recorre los Departamentos del Empleado -------------------------'
                While rs.Read
                    '-------------------------- Carga Datos de Preaviso -------------------------'
                    Dim ConPre As New Conexion
                    Dim ConNPre As New Conexion
                    Monto = 0
                    Dim CuentaPre, NCuentaPre As String

                    Monto = CDbl(Me.TextBox13.Text) * (rs("Porcentaje") / 100)

                    CuentaPre = ConPre.SlqExecuteScalar(ConPre.Conectar("Planilla"), "SELECT CuentaPreaviso FROM Departamento WHERE Id = " & rs("IdDepartamento"))
                    ConPre.DesConectar(ConPre.sQlconexion)

                    NCuentaPre = ConNPre.SlqExecuteScalar(ConNPre.Conectar("Planilla"), "SELECT NCuentaPreaviso FROM Departamento WHERE Id = " & rs("IdDepartamento"))
                    ConNPre.DesConectar(ConNPre.sQlconexion)
                    '-------------------------- Fin Carga Datos de Preaviso -------------------------'

                    '-------------------------- Guarda Preaviso -------------------------'
                    Dim ConexionPre As New Conexion
                    Try
                        ConexionPre.SlqExecuteScalar(ConexionPre.Conectar("Contabilidad"), "INSERT INTO DetallesAsientosContable (NumAsiento, Cuenta, " & _
                        "NombreCuenta, Monto, Debe, Haber, DescripcionAsiento) VALUES ('" & NumeroAsiento & "', '" & CuentaPre & "', " & _
                        "'" & NCuentaPre & "', " & Monto & ", 1,0, 'Liquidacion Laboral de " & Me.TextBox1.Text & "')")
                        ConexionPre.DesConectar(ConexionPre.sQlconexion)

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    '----------------------- Fin de Guarda Preaviso ------------------------'

                    Dim ConDep As New Conexion
                    DrCuentas = ConDep.GetRecorset(ConDep.Conectar("Planilla"), "Select CuentaContable,Cesantia,Vacaciones,Aguinaldo from LigueAsiento where IdDepartamento = " & rs("IdDepartamento"))
                    Try
                        '-------------------------------- Recorre las Cuentas Contables del Departamento --------------------------------'
                        While DrCuentas.Read
                            '------------------ Busca Nombre de la Cuenta Contable ------------------'
                            Dim ConBuscaCuenta As New Conexion
                            Dim NombreCuenta As String
                            Try
                                NombreCuenta = ConBuscaCuenta.SlqExecuteScalar(ConBuscaCuenta.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable = '" & DrCuentas("CuentaContable") & "'")
                                ConBuscaCuenta.DesConectar(ConBuscaCuenta.sQlconexion)

                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                            '-------------- Fin de Busca Nombre de la Cuenta Contable --------------'

                            '-------------------------- Guarda la Cesantia -------------------------'
                            If DrCuentas("Cesantia") = True Then
                                Monto = 0
                                Dim ConexionAsiento As New Conexion
                                Monto = CDbl(Me.TextBox12.Text) * (rs("Porcentaje") / 100)

                                Try
                                    ConexionAsiento.SlqExecuteScalar(ConexionAsiento.Conectar("Contabilidad"), "INSERT INTO DetallesAsientosContable (NumAsiento, Cuenta, " & _
                                    "NombreCuenta, Monto, Debe, Haber, DescripcionAsiento) VALUES ('" & NumeroAsiento & "', '" & DrCuentas("CuentaContable") & "', " & _
                                    "'" & NombreCuenta & "', " & Monto & ", 1,0, 'Liquidacion Laboral de " & Me.TextBox1.Text & "')")
                                    ConexionAsiento.DesConectar(ConexionAsiento.sQlconexion)

                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                                '----------------------- Fin de Guarda Cesantía ------------------------'

                                '-------------------------- Guarda las Vacaciones -------------------------'
                            ElseIf DrCuentas("Vacaciones") = True Then
                                Monto = 0
                                Dim ConexionAsiento As New Conexion
                                Monto = CDbl(Me.TextBox17.Text) * (rs("Porcentaje") / 100)

                                Try
                                    ConexionAsiento.SlqExecuteScalar(ConexionAsiento.Conectar("Contabilidad"), "INSERT INTO DetallesAsientosContable (NumAsiento, Cuenta, " & _
                                    "NombreCuenta, Monto, Debe, Haber, DescripcionAsiento) VALUES ('" & NumeroAsiento & "', '" & DrCuentas("CuentaContable") & "', " & _
                                    "'" & NombreCuenta & "', " & Monto & ", 1,0, 'Liquidacion Laboral de " & Me.TextBox1.Text & "')")
                                    ConexionAsiento.DesConectar(ConexionAsiento.sQlconexion)

                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                                '----------------------- Fin de Guarda Vacaciones ------------------------'

                                '-------------------------- Guarda el Aguinaldo -------------------------'
                            ElseIf DrCuentas("Aguinaldo") = True Then
                                Monto = 0
                                Dim ConexionAsiento As New Conexion
                                Monto = CDbl(Me.TextBox15.Text) * (rs("Porcentaje") / 100)

                                Try
                                    ConexionAsiento.SlqExecuteScalar(ConexionAsiento.Conectar("Contabilidad"), "INSERT INTO DetallesAsientosContable (NumAsiento, Cuenta, " & _
                                    "NombreCuenta, Monto, Debe, Haber, DescripcionAsiento) VALUES ('" & NumeroAsiento & "', '" & DrCuentas("CuentaContable") & "', " & _
                                    "'" & NombreCuenta & "', " & Monto & ", 1,0, 'Liquidacion Laboral de " & Me.TextBox1.Text & "')")
                                    ConexionAsiento.DesConectar(ConexionAsiento.sQlconexion)

                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                                '----------------------- Fin de Guarda Aguinaldo ------------------------'
                            End If
                        End While

                        '-------------------------------- Fin de Recorre las Cuentas Contables del Departamento --------------------------------'
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    ConDep.DesConectar(ConDep.sQlconexion)

                End While
                '------------------------- Fin de Recorre los Departamentos del Empleado -------------------------'
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            rs.Close()
            cConexion.DesConectar(cConexion.Conectar)
        Else
            MsgBox("Seleccione un Empleado", MsgBoxStyle.Information, "Atención...")
            TextBox1.Text = ""
            TxtNombre.Focus()
            rs.Close()
        End If
    End Sub

    Private Sub GuardaDetalleHaber()
        Dim IdCuenta As Integer
        Dim Cuenta, NCuenta, CuentaBanco, NCuentaBanco As String

        If NumeroAsiento <> vbNullString Then
            '-------------------------- Busca Cuenta de Setting --------------------------'
            Dim Con As New Conexion
            Try
                IdCuenta = Con.SlqExecuteScalar(Con.Conectar("Contabilidad"), "SELECT IdAdelanto FROM SettingCuentaContable")
                Con.DesConectar(Con.sQlconexion)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            '------------------------ Fin Busca Cuenta de Setting -------------------------'

            '--------------------------- Busca Numero de Cuenta ---------------------------'
            Dim ConCuenta As New Conexion
            Try
                Cuenta = ConCuenta.SlqExecuteScalar(ConCuenta.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE id = " & IdCuenta)
                ConCuenta.DesConectar(ConCuenta.sQlconexion)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            '------------------------- Fin Busca Numero de Cuenta --------------------------'

            '--------------------------- Busca Nombre de Cuenta ----------------------------'
            Dim ConNCuenta As New Conexion
            Try
                NCuenta = ConNCuenta.SlqExecuteScalar(ConNCuenta.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE id = " & IdCuenta)
                ConNCuenta.DesConectar(ConNCuenta.sQlconexion)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            '------------------------- Fin Busca Nombre de Cuenta --------------------------'

            '----------------------- Guarda Ctas x Cobrar Empleado -------------------------'
            Dim cConexion As New Conexion
            Try
                cConexion.SlqExecuteScalar(cConexion.Conectar("Contabilidad"), "INSERT INTO DetallesAsientosContable (NumAsiento, Cuenta, " & _
                "NombreCuenta, Monto, Debe, Haber, DescripcionAsiento) VALUES ('" & NumeroAsiento & "', '" & Cuenta & "', " & _
                "'" & NCuenta & "', " & CDbl(Me.TextBox21.Text) & ", 0,1, 'Liquidacion Laboral de " & Me.TextBox1.Text & "')")
                cConexion.DesConectar(cConexion.sQlconexion)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            '--------------------- Fin Guarda Ctas x Cobrar Empleado -----------------------'

            '------------------------- Busca Numero de Cuenta Banco -------------------------'
            Dim ConCuentaBanco As New Conexion
            Try
                CuentaBanco = ConCuentaBanco.SlqExecuteScalar(ConCuentaBanco.Conectar("Bancos"), "SELECT CuentaContable FROM Cuentas_bancarias WHERE Codigo_banco = " & Me.ComboBoxBanco.SelectedValue & " And Id_CuentaBancaria = " & Me.ComboBoxCuentaBancaria.SelectedValue)
                ConCuentaBanco.DesConectar(ConCuentaBanco.sQlconexion)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            '----------------------- Fin Busca Numero de Cuenta Banco ------------------------'

            '------------------------- Busca Nombre de Cuenta Banco --------------------------'
            Dim ConNCuentaBanco As New Conexion
            Try
                NCuentaBanco = ConNCuenta.SlqExecuteScalar(ConNCuenta.Conectar("Contabilidad"), "SELECT NombreCuentaContable FROM Cuentas_bancarias WHERE Codigo_banco = " & Me.ComboBoxBanco.SelectedValue & " And Id_CuentaBancaria = " & Me.ComboBoxCuentaBancaria.SelectedValue)
                ConNCuenta.DesConectar(ConNCuenta.sQlconexion)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            '----------------------- Fin Busca Nombre de Cuenta Banco ------------------------'

            '----------------------- Guarda Cuenta Contable Banco --------------------------'
            Dim ConexionBanco As New Conexion
            Try
                cConexion.SlqExecuteScalar(ConexionBanco.Conectar("Contabilidad"), "INSERT INTO DetallesAsientosContable (NumAsiento, Cuenta, " & _
                "NombreCuenta, Monto, Debe, Haber, DescripcionAsiento) VALUES ('" & NumeroAsiento & "', '" & CuentaBanco & "', " & _
                "'" & NCuentaBanco & "', " & CDbl(Me.TextBox19.Text) & ", 0,1, 'Liquidacion Laboral de " & Me.TextBox1.Text & "')")
                ConexionBanco.DesConectar(ConexionBanco.sQlconexion)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            '--------------------- Fin Guarda Cuenta Contable Banco ------------------------'

        Else
            MsgBox("Seleccione un Empleado", MsgBoxStyle.Information, "Atención...")
            TextBox1.Text = ""
            TxtNombre.Focus()
        End If
    End Sub

#End Region

   
    Private Sub TextBox14_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox14.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
            If Me.TextBox14.Text.Equals("") Then Exit Sub
            calculoSeparado()
                Me.TextBox19.Text = (Total1 + TextBox13.Text + Total3 + Total4 + TextBox11.Text) - Adelantos
                Me.MontoLetras()
            Catch ex As Exception
            End Try
        End If
        
    End Sub
    Sub calculoSeparado()
        TextBox13.Text = Format(salDiario * Me.TextBox14.Text, "#,#0.00")        
    End Sub

    Private Sub TextBox22_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox22.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If Me.TextBox14.Text.Equals("") Then Exit Sub
                TextBox11.Text = Format(salDiario * Me.TextBox22.Text, "#,#0.00")
                Me.TextBox19.Text = (Total1 + TextBox13.Text + Total3 + Total4 + TextBox11.Text) - Adelantos
                Me.MontoLetras()
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TxtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombre.TextChanged

    End Sub
End Class
