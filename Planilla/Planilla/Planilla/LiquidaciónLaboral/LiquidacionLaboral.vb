Imports System.data.sqlclient
Imports Utilidades
Public Class LiquidacionLaboral
    Inherits Plantilla
    Public Codigo As String
    Public Diario As Double
    Public TotalGanado, Adelantos As Double
    Public Año As Double
    Public Shared FechaEmpleado As Integer
    Dim usua As Object
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
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
    Friend WithEvents Label23 As System.Windows.Forms.Label
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
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents adLiquidacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DiaCesantia As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(LiquidacionLaboral))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Combo1 = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.DsLiquidacion = New Planilla.DsLiquidacion
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
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
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DsLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(656, 32)
        Me.TituloModulo.Text = "Liquidación Laboral"
        Me.TituloModulo.UseMnemonic = False
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 450)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(656, 52)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Combo1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
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
        Me.GroupBox1.Size = New System.Drawing.Size(640, 200)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Empleado"
        '
        'Combo1
        '
        Me.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo1.ForeColor = System.Drawing.Color.Blue
        Me.Combo1.Items.AddRange(New Object() {"Renuncia", "Despido Con Responsabilidad", "Despido Sin Responsabilidad"})
        Me.Combo1.Location = New System.Drawing.Point(264, 80)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.Size = New System.Drawing.Size(232, 21)
        Me.Combo1.TabIndex = 63
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(624, 56)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tiempo Laborado"
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.Dia"))
        Me.TextBox10.ForeColor = System.Drawing.Color.Blue
        Me.TextBox10.Location = New System.Drawing.Point(384, 32)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(64, 14)
        Me.TextBox10.TabIndex = 19
        Me.TextBox10.Text = ""
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DsLiquidacion
        '
        Me.DsLiquidacion.DataSetName = "DsLiquidacion"
        Me.DsLiquidacion.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(336, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 24)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Día(s):"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.Meses"))
        Me.TextBox9.ForeColor = System.Drawing.Color.Blue
        Me.TextBox9.Location = New System.Drawing.Point(224, 32)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(64, 14)
        Me.TextBox9.TabIndex = 17
        Me.TextBox9.Text = ""
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(160, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 24)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Mes(es):"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.Anos"))
        Me.TextBox8.ForeColor = System.Drawing.Color.Blue
        Me.TextBox8.Location = New System.Drawing.Point(56, 32)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(64, 14)
        Me.TextBox8.TabIndex = 15
        Me.TextBox8.Text = ""
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsLiquidacion, "liquidacionempleados.Observaciones"))
        Me.TextBox7.ForeColor = System.Drawing.Color.Blue
        Me.TextBox7.Location = New System.Drawing.Point(8, 120)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(624, 14)
        Me.TextBox7.TabIndex = 26
        Me.TextBox7.Text = ""
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(8, 104)
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
        Me.TextBox6.Location = New System.Drawing.Point(504, 80)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(120, 15)
        Me.TextBox6.TabIndex = 24
        Me.TextBox6.Text = ""
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(504, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Fecha Salida"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(264, 64)
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
        Me.TextBox4.Location = New System.Drawing.Point(136, 80)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(120, 14)
        Me.TextBox4.TabIndex = 20
        Me.TextBox4.Text = ""
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(136, 64)
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
        Me.TextBox3.Location = New System.Drawing.Point(8, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(120, 14)
        Me.TextBox3.TabIndex = 18
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(8, 64)
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
        Me.TextBox2.Location = New System.Drawing.Point(504, 40)
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
        Me.Label3.Location = New System.Drawing.Point(504, 24)
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
        'GroupBox3
        '
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
        Me.GroupBox3.Location = New System.Drawing.Point(8, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 184)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calculos"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(432, 136)
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
        Me.GridControl1.Size = New System.Drawing.Size(208, 81)
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
        Me.TextBox21.Location = New System.Drawing.Point(544, 136)
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
        Me.TextBox19.Location = New System.Drawing.Point(504, 160)
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
        Me.Label24.Location = New System.Drawing.Point(375, 160)
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
        Me.TextBox14.ReadOnly = True
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
        Me.SqlConnection1.ConnectionString = "workstation id=MARIANO;packet size=4096;integrated security=SSPI;data source=PICH" & _
        "INGA;persist security info=False;initial catalog=Planilla"
        '
        'adEmpleado
        '
        Me.adEmpleado.DeleteCommand = Me.SqlDeleteCommand1
        Me.adEmpleado.InsertCommand = Me.SqlInsertCommand1
        Me.adEmpleado.SelectCommand = Me.SqlSelectCommand1
        Me.adEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Fecha_Ingreso", "Fecha_Ingreso"), New System.Data.Common.DataColumnMapping("Fecha_Salida", "Fecha_Salida"), New System.Data.Common.DataColumnMapping("Diario", "Diario"), New System.Data.Common.DataColumnMapping("Semana", "Semana"), New System.Data.Common.DataColumnMapping("Quincena", "Quincena"), New System.Data.Common.DataColumnMapping("Mensual", "Mensual"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("Hora", "Hora"), New System.Data.Common.DataColumnMapping("Cod_Estado", "Cod_Estado"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        Me.adEmpleado.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Empleado WHERE (Identificacion = @Original_Identificacion) AND (Cod_E" & _
        "stado = @Original_Cod_Estado) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Diari" & _
        "o = @Original_Diario) AND (Fecha_Ingreso = @Original_Fecha_Ingreso) AND (Fecha_S" & _
        "alida = @Original_Fecha_Salida) AND (Hora = @Original_Hora) AND (Mensual = @Orig" & _
        "inal_Mensual) AND (Nombre = @Original_Nombre) AND (Quincena = @Original_Quincena" & _
        ") AND (Salario = @Original_Salario) AND (Semana = @Original_Semana)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
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
        " Semana, Quincena, Mensual, Salario, Hora, Cod_Estado, Cod_Moneda) VALUES (@Iden" & _
        "tificacion, @Nombre, @Fecha_Ingreso, @Fecha_Salida, @Diario, @Semana, @Quincena," & _
        " @Mensual, @Salario, @Hora, @Cod_Estado, @Cod_Moneda); SELECT Identificacion, No" & _
        "mbre, Fecha_Ingreso, Fecha_Salida, Diario, Semana, Quincena, Mensual, Salario, H" & _
        "ora, Cod_Estado, Cod_Moneda FROM Empleado WHERE (Identificacion = @Identificacio" & _
        "n)"
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
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Identificacion, Nombre, Fecha_Ingreso, Fecha_Salida, Diario, Semana, Quinc" & _
        "ena, Mensual, Salario, Hora, Cod_Estado, Cod_Moneda FROM Empleado"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Empleado SET Identificacion = @Identificacion, Nombre = @Nombre, Fecha_Ing" & _
        "reso = @Fecha_Ingreso, Fecha_Salida = @Fecha_Salida, Diario = @Diario, Semana = " & _
        "@Semana, Quincena = @Quincena, Mensual = @Mensual, Salario = @Salario, Hora = @H" & _
        "ora, Cod_Estado = @Cod_Estado, Cod_Moneda = @Cod_Moneda WHERE (Identificacion = " & _
        "@Original_Identificacion) AND (Cod_Estado = @Original_Cod_Estado) AND (Cod_Moned" & _
        "a = @Original_Cod_Moneda) AND (Diario = @Original_Diario) AND (Fecha_Ingreso = @" & _
        "Original_Fecha_Ingreso) AND (Fecha_Salida = @Original_Fecha_Salida) AND (Hora = " & _
        "@Original_Hora) AND (Mensual = @Original_Mensual) AND (Nombre = @Original_Nombre" & _
        ") AND (Quincena = @Original_Quincena) AND (Salario = @Original_Salario) AND (Sem" & _
        "ana = @Original_Semana); SELECT Identificacion, Nombre, Fecha_Ingreso, Fecha_Sal" & _
        "ida, Diario, Semana, Quincena, Mensual, Salario, Hora, Cod_Estado, Cod_Moneda FR" & _
        "OM Empleado WHERE (Identificacion = @Identificacion)"
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
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
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
        Me.TextBox5.Location = New System.Drawing.Point(584, 456)
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
        Me.TextBox20.Location = New System.Drawing.Point(472, 456)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.ReadOnly = True
        Me.TextBox20.Size = New System.Drawing.Size(80, 20)
        Me.TextBox20.TabIndex = 9999
        Me.TextBox20.Text = ""
        '
        'Label25
        '
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.Location = New System.Drawing.Point(472, 440)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 16)
        Me.Label25.TabIndex = 65
        Me.Label25.Text = "Liquidación No. :"
        '
        'Label26
        '
        Me.Label26.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label26.Location = New System.Drawing.Point(568, 440)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 16)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "Fecha"
        '
        'adAccion
        '
        Me.adAccion.SelectCommand = Me.SqlSelectCommand5
        Me.adAccion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AccionPersonal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Accion", "Id_Accion"), New System.Data.Common.DataColumnMapping("DiasaDescontar", "DiasaDescontar"), New System.Data.Common.DataColumnMapping("Id_Empleado", "Id_Empleado")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Id_Accion, DiasaDescontar, Id_Empleado FROM AccionPersonal"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'adLiquidacion
        '
        Me.adLiquidacion.DeleteCommand = Me.SqlDeleteCommand4
        Me.adLiquidacion.InsertCommand = Me.SqlInsertCommand4
        Me.adLiquidacion.SelectCommand = Me.SqlSelectCommand4
        Me.adLiquidacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "liquidacionempleados", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Liquidacion", "Liquidacion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("FechaIngreso", "FechaIngreso"), New System.Data.Common.DataColumnMapping("SalarioMensual", "SalarioMensual"), New System.Data.Common.DataColumnMapping("SalarioDiario", "SalarioDiario"), New System.Data.Common.DataColumnMapping("FechaSalida", "FechaSalida"), New System.Data.Common.DataColumnMapping("Cese", "Cese"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anos", "Anos"), New System.Data.Common.DataColumnMapping("Meses", "Meses"), New System.Data.Common.DataColumnMapping("Dia", "Dia"), New System.Data.Common.DataColumnMapping("DiaCesantia", "DiaCesantia"), New System.Data.Common.DataColumnMapping("MontoCesa", "MontoCesa"), New System.Data.Common.DataColumnMapping("DiaPreaviso", "DiaPreaviso"), New System.Data.Common.DataColumnMapping("MontoPreaviso", "MontoPreaviso"), New System.Data.Common.DataColumnMapping("DiaAguinal", "DiaAguinal"), New System.Data.Common.DataColumnMapping("MontoAguinal", "MontoAguinal"), New System.Data.Common.DataColumnMapping("DiaVaca", "DiaVaca"), New System.Data.Common.DataColumnMapping("MontoVaca", "MontoVaca"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        Me.adLiquidacion.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM liquidacionempleados WHERE (Liquidacion = @Original_Liquidacion) AND " & _
        "(Anos = @Original_Anos) AND (Cese = @Original_Cese) AND (Dia = @Original_Dia) AN" & _
        "D (DiaAguinal = @Original_DiaAguinal) AND (DiaCesantia = @Original_DiaCesantia) " & _
        "AND (DiaPreaviso = @Original_DiaPreaviso) AND (DiaVaca = @Original_DiaVaca) AND " & _
        "(Fecha = @Original_Fecha) AND (FechaIngreso = @Original_FechaIngreso) AND (Fecha" & _
        "Salida = @Original_FechaSalida) AND (Identificacion = @Original_Identificacion) " & _
        "AND (Meses = @Original_Meses) AND (MontoAguinal = @Original_MontoAguinal) AND (M" & _
        "ontoCesa = @Original_MontoCesa) AND (MontoPreaviso = @Original_MontoPreaviso) AN" & _
        "D (MontoVaca = @Original_MontoVaca) AND (Nombre = @Original_Nombre) AND (Observa" & _
        "ciones = @Original_Observaciones OR @Original_Observaciones IS NULL AND Observac" & _
        "iones IS NULL) AND (SalarioDiario = @Original_SalarioDiario) AND (SalarioMensual" & _
        " = @Original_SalarioMensual) AND (Total = @Original_Total)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Liquidacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Liquidacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anos", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cese", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cese", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Dia", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaAguinal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaAguinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaCesantia", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaCesantia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaPreaviso", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaPreaviso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaVaca", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaVaca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaIngreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaIngreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaSalida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaSalida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Meses", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Meses", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoAguinal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoAguinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoCesa", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoCesa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoPreaviso", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoPreaviso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoVaca", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoVaca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 65, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
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
        "aVaca, MontoVaca, Total) VALUES (@Fecha, @Identificacion, @Nombre, @FechaIngreso" & _
        ", @SalarioMensual, @SalarioDiario, @FechaSalida, @Cese, @Observaciones, @Anos, @" & _
        "Meses, @Dia, @DiaCesantia, @MontoCesa, @DiaPreaviso, @MontoPreaviso, @DiaAguinal" & _
        ", @MontoAguinal, @DiaVaca, @MontoVaca, @Total); SELECT Liquidacion, Fecha, Ident" & _
        "ificacion, Nombre, FechaIngreso, SalarioMensual, SalarioDiario, FechaSalida, Ces" & _
        "e, Observaciones, Anos, Meses, Dia, DiaCesantia, MontoCesa, DiaPreaviso, MontoPr" & _
        "eaviso, DiaAguinal, MontoAguinal, DiaVaca, MontoVaca, Total FROM liquidacionempl" & _
        "eados WHERE (Liquidacion = @@IDENTITY)"
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
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anos", System.Data.SqlDbType.Int, 8, "Anos"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Meses", System.Data.SqlDbType.Int, 8, "Meses"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dia", System.Data.SqlDbType.Int, 8, "Dia"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaCesantia", System.Data.SqlDbType.Int, 8, "DiaCesantia"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoCesa", System.Data.SqlDbType.Float, 8, "MontoCesa"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaPreaviso", System.Data.SqlDbType.Int, 8, "DiaPreaviso"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoPreaviso", System.Data.SqlDbType.Float, 8, "MontoPreaviso"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaAguinal", System.Data.SqlDbType.Float, 8, "DiaAguinal"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoAguinal", System.Data.SqlDbType.Float, 8, "MontoAguinal"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaVaca", System.Data.SqlDbType.Int, 8, "DiaVaca"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoVaca", System.Data.SqlDbType.Float, 8, "MontoVaca"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Liquidacion, Fecha, Identificacion, Nombre, FechaIngreso, SalarioMensual, " & _
        "SalarioDiario, FechaSalida, Cese, Observaciones, Anos, Meses, Dia, DiaCesantia, " & _
        "MontoCesa, DiaPreaviso, MontoPreaviso, DiaAguinal, MontoAguinal, DiaVaca, MontoV" & _
        "aca, Total FROM liquidacionempleados"
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
        "iaVaca = @DiaVaca, MontoVaca = @MontoVaca, Total = @Total WHERE (Liquidacion = @" & _
        "Original_Liquidacion) AND (Anos = @Original_Anos) AND (Cese = @Original_Cese) AN" & _
        "D (Dia = @Original_Dia) AND (DiaAguinal = @Original_DiaAguinal) AND (DiaCesantia" & _
        " = @Original_DiaCesantia) AND (DiaPreaviso = @Original_DiaPreaviso) AND (DiaVaca" & _
        " = @Original_DiaVaca) AND (Fecha = @Original_Fecha) AND (FechaIngreso = @Origina" & _
        "l_FechaIngreso) AND (FechaSalida = @Original_FechaSalida) AND (Identificacion = " & _
        "@Original_Identificacion) AND (Meses = @Original_Meses) AND (MontoAguinal = @Ori" & _
        "ginal_MontoAguinal) AND (MontoCesa = @Original_MontoCesa) AND (MontoPreaviso = @" & _
        "Original_MontoPreaviso) AND (MontoVaca = @Original_MontoVaca) AND (Nombre = @Ori" & _
        "ginal_Nombre) AND (Observaciones = @Original_Observaciones OR @Original_Observac" & _
        "iones IS NULL AND Observaciones IS NULL) AND (SalarioDiario = @Original_SalarioD" & _
        "iario) AND (SalarioMensual = @Original_SalarioMensual) AND (Total = @Original_To" & _
        "tal); SELECT Liquidacion, Fecha, Identificacion, Nombre, FechaIngreso, SalarioMe" & _
        "nsual, SalarioDiario, FechaSalida, Cese, Observaciones, Anos, Meses, Dia, DiaCes" & _
        "antia, MontoCesa, DiaPreaviso, MontoPreaviso, DiaAguinal, MontoAguinal, DiaVaca," & _
        " MontoVaca, Total FROM liquidacionempleados WHERE (Liquidacion = @Liquidacion)"
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
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anos", System.Data.SqlDbType.Int, 8, "Anos"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Meses", System.Data.SqlDbType.Int, 8, "Meses"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dia", System.Data.SqlDbType.Int, 8, "Dia"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaCesantia", System.Data.SqlDbType.Int, 8, "DiaCesantia"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoCesa", System.Data.SqlDbType.Float, 8, "MontoCesa"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaPreaviso", System.Data.SqlDbType.Int, 8, "DiaPreaviso"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoPreaviso", System.Data.SqlDbType.Float, 8, "MontoPreaviso"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaAguinal", System.Data.SqlDbType.Float, 8, "DiaAguinal"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoAguinal", System.Data.SqlDbType.Float, 8, "MontoAguinal"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiaVaca", System.Data.SqlDbType.Int, 8, "DiaVaca"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoVaca", System.Data.SqlDbType.Float, 8, "MontoVaca"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Liquidacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Liquidacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anos", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cese", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cese", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Dia", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaAguinal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaAguinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaCesantia", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaCesantia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaPreaviso", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaPreaviso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiaVaca", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaVaca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaIngreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaIngreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaSalida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaSalida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Meses", System.Data.SqlDbType.Int, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Meses", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoAguinal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoAguinal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoCesa", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoCesa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoPreaviso", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoPreaviso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoVaca", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoVaca", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 65, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
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
        'LiquidacionLaboral
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 502)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LiquidacionLaboral"
        Me.Text = "Liquidacion Laboral"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TextBox5, 0)
        Me.Controls.SetChildIndex(Me.TextBox20, 0)
        Me.Controls.SetChildIndex(Me.Label25, 0)
        Me.Controls.SetChildIndex(Me.Label26, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DsLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub LiquidacionLaboral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
        Me.Bloquear()
        Me.Label1.Focus()
        Me.adAdelantos.Fill(DsLiquidacion, "Adelantos")
        Me.adEmpleado.Fill(Me.DsLiquidacion.Empleado)
        Me.AdEstado.Fill(Me.DsLiquidacion.Estado_Empleado)
        Me.AdMoneda.Fill(Me.DsLiquidacion.Moneda)
        ToolBar1.Buttons(2).Enabled = False
        ToolBar1.Buttons(3).Enabled = False
        ToolBar1.Buttons(4).Enabled = False
        ToolBar1.Buttons(5).Enabled = False
    End Sub

    Private Sub TxtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNombre.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            Me.TxtNombre.Text = cFunciones.BuscarDatos("select Identificacion, Nombre, Fecha_Ingreso, Fecha_Salida, Diario, Semana, Quincena, Mensual, Hora, Salario from Empleado", "Nombre")
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
            rs = cConexion.GetRecorset(cConexion.Conectar, "select Identificacion, Nombre, Fecha_Ingreso, Fecha_Salida, Diario, Semana, Quincena, Mensual, Hora, Salario from Empleado where Identificacion = '" & CodCliente & "'")
            Try
                If rs.Read Then
                    TxtNombre.Text = rs("Identificacion")
                    TextBox1.Text = rs("Nombre")
                    TextBox2.Text = rs("Fecha_Ingreso")
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

    Function Calculos()
        Dim i, Dia1, Dia2, Mes1, Mes2, Año1, Año2 As Integer
        Dim fila As DataRow
        Dim factura As Long
        Dim FormaPagos As String
        Dim FechaSalida, FechaEntrada As DateTime
        Dim Salario, Mes, Dia, Tiempo, PromedioMensual As Double



        FechaEntrada = TextBox2.Text
        Dia1 = FechaEntrada.Day
        Mes1 = FechaEntrada.Month
        Año1 = FechaEntrada.Year
        FechaSalida = TextBox6.Text
        Dia2 = FechaSalida.Day
        Mes2 = FechaSalida.Month
        Año2 = FechaSalida.Year
        Año = Math.Abs(Año1 - Año2)
        Dia = Math.Abs(Dia1 - Dia2)
        Mes = Math.Abs(Mes1 - Mes2)
        'Tiempo = FechaSalida - FechaEntrada
        'Año = Tiempo / 360
        TextBox8.Text = Int(Año)
        'Mes = (((Año - TextBox8.Text) * 360) / 30)
        TextBox9.Text = Int(Mes)
        'Dia = (Mes - TextBox9.Text) * 30
        TextBox10.Text = Int(Dia)
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
        Else
                DiaCesantia.Text = "0.00"
                TextBox12.Text = "0.00"
                TextBox14.Text = "0.00"
                TextBox13.Text = "0.00"
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Me.LlenarEmpleados(Codigo)
            Me.LlenarVacaciones(Codigo)
            'Calculo de Vacaciones
            'Accion = Usuario.Server.OpenRecordset("Select Codigo, TipoAccion, Dias from accionpersonal where TipoAccion = 'VACACIONES' AND CODIGO = " & Chr(39) & Text1(0).Text & Chr(39))
            'With Accion
            '    Do While Not .EOF
            '        Disfrutados = Disfrutados + !Dias
            '        .MoveNext()
            '    Loop
            'End With
            'PromedioMensual = (TotalGanado / 12) / 30
            'If Año < 1 Then
            '    TextBox18.Text = TextBox9.Text - Disfrutados
            '    TextBox17.Text = Format(TextBox18.Text * Diario, "#,#0.00")
            'End If
            'If Año >= 1 Then
            '    TextBox18.Text = ((12 * TextBox8.Text) + TextBox9.Text) - Disfrutados
            '    TextBox17.Text = Format(TextBox18.Text * Diario, "#,#0.00")
            'End If

            ' TextBox19.Text = Format(Val(Format(TextBox12.Text, "#0.00")) + Val(Format(TextBox13.Text, "#0.00")) + Val(Format(TextBox15.Text, "#0.00")) + Val(Format(TextBox17.Text, "#0.00")), "#,#0.00")

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


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

            Me.GridControl1.DataSource = Me.DsLiquidacion.Adelantos.Select("Identificacion = '" & Codigo & "'and Saldo > 0")

            For j = 0 To Me.DsLiquidacion.Adelantos.Rows.Count - 1
                If Me.DsLiquidacion.Adelantos.Rows(j).Item("Identificacion") = Codigo And Me.DsLiquidacion.Adelantos.Rows(j).Item("Saldo") > 0 Then

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
    Function LlenarVacaciones(ByVal Id As String)
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
            Dim sel As String = "SELECT Id_Empleado, Id_Accion, DiasaDescontar FROM AccionPersonal where (Id_Accion = 2) AND (Id_Empleado = @Id)"
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
            For i = 0 To Me.DsLiquidacion.AccionPersonal.Rows.Count - 1
                TotalVacaciones = TotalVacaciones + Me.DsLiquidacion.AccionPersonal.Rows(i).Item("DiasaDescontar")
            Next
            PromedioMensual = (TotalGanado / 12) / 30
            If Año < 1 Then
                TextBox18.Text = Math.Abs(TextBox9.Text - TotalVacaciones)
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
        Dim Total, Total1, Total2, Total3, Total4 As Double
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
            Dim sel As String = "SELECT Planilla_Detalle.Cedula, Planilla_Detalle.Nombre, Planilla_Detalle.Salario, Planilla_Detalle.SalarioBruto, Planilla_Detalle.FormaPago,Planilla_Detalle.Id, Planilla_Detalle.Id_Planilla FROM Planilla_Detalle INNER JOIN Planilla ON  Planilla_Detalle.Id_Planilla = Planilla.Id_Planilla WHERE (Planilla_Detalle.Cedula = @Id) and (Planilla.Anulado <> 1) "
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
            Next
            TextBox16.Text = Format(TotalGanado, "#,#0.00")
            TextBox15.Text = Format(TotalGanado / 12, "#,#0.00")
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
            TextBox17.Text = 0
            Total4 = TextBox17.Text
            Total = Total1 + Total2 + Total3 + Total4
            CalculoAdelantos(Codigo)
            Total = Total - Adelantos
            TextBox19.Text = Format(Total, "#,#0.00")
        End Try

    End Function
    'Calculo de Aguinaldo
    'Set Pagos = Usuario.Server.OpenRecordset("Select Identificacion, Fecha, MontoNormales, MontoExtras, Anulado from ReciboPago where anulado <> 'SI' and Identificacion = " & Chr(39) & Text1(0).Text & Chr(39) & " and Year(FechaDos) = " & Year(Date))
    'rs = cConexion.GetRecorset(cConexion.Conectar, "select Cedula, Nombre, Salario, SalarioBruto, Id_Planilla, Id from Planilla_Detalle INNER JOIN Planilla ON Planilla_Detalle.Identificacion =" & Codigo & " and Planilla.Anulado =" & Codigo)
    'For i = 0 To Me.DsPlanilla1.Planilla_Detalle.Rows.Count - 1



    Private Sub TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Calculos()

        End If
    End Sub

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
    End Function
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
                TextBox6.Text = Now
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
    Private Function Buscar()
        Dim funcion As New cFunciones
        Dim Id As String
        Dim FechaEmplea As String
        Dim Identificacion As Integer
        Try
            Me.DsLiquidacion.Clear()
            FechaEmpleado = 1
            Id = funcion.BuscarDatos("Select * from liquidacionempleados", "Identificacion", "Buscar Liquidacion", SqlConnection1.ConnectionString, FechaEmpleado)
            FechaEmpleado = 0
            'buscando = True
            'Id = cFunciones.descripcion
            If Id = "" Or Id = "0" Then ' si se dio en el boton de cancelar
                ' Me.buscando = False
                Exit Function
            End If
            Me.LlenarLiquidacion(Id)
            Me.CargarInformacionCliente(Id)
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
    Function Formato()
        TextBox12.Text = Format(TextBox12.Text * 1, "#,#0.00")
        TextBox13.Text = Format(TextBox13.Text * 1, "#,#0.00")
        TextBox16.Text = Format(TextBox16.Text * 1, "#,#0.00")
        TextBox15.Text = Format(TextBox15.Text * 1, "#,#0.00")
        TextBox18.Text = Format(TextBox18.Text * 1, "#,#0.00")
        TextBox17.Text = Format(TextBox17.Text * 1, "#,#0.00")
        TextBox19.Text = Format(TextBox19.Text * 1, "#,#0.00")
    End Function
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
    Private Function Guardar()
        Me.adEmpleado.Fill(Me.DsLiquidacion, "Empleado")
        AdEstado.Fill(Me.DsLiquidacion, "Estado_Empleado")
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            If ValidarDatos() Then
                Actualiza_Empleado()
                'finaliza la edición
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Identificacion") = TxtNombre.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Nombre") = TextBox1.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Fecha") = TextBox5.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("FechaIngreso") = TextBox2.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("SalarioMensual") = TextBox3.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("SalarioDiario") = TextBox4.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("FechaSalida") = TextBox6.Text
                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").Current("Cese") = Combo1.Text
                Me.adLiquidacion.UpdateCommand.Transaction = Trans
                Me.adLiquidacion.InsertCommand.Transaction = Trans
                Me.adLiquidacion.DeleteCommand.Transaction = Trans
                Me.adEmpleado.UpdateCommand.Transaction = Trans
                Me.adEmpleado.InsertCommand.Transaction = Trans
                Me.adEmpleado.DeleteCommand.Transaction = Trans
                Me.adEmpleado.Update(Me.DsLiquidacion.Empleado)

                Me.BindingContext(Me.DsLiquidacion, "liquidacionempleados").EndCurrentEdit()
                Me.adLiquidacion.Update(Me.DsLiquidacion, "liquidacionempleados")
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
                Me.DsLiquidacion.Clear()
                Me.Limpiar()
                If MsgBox("Desea Imprimir esta Liquidacion ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    imprimir()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Trans.Rollback()
        End Try
    End Function
    Private Sub eliminar()
        Dim Cconexion As New Conexion
        Dim Resultado, Identificacion As String
        If Me.TxtNombre.Text <> "" Then

            If MessageBox.Show(" ¿ Desea Eliminar Esta Liquidacion ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub
            Resultado = Cconexion.SlqExecute(Cconexion.Conectar, "Delete from liquidacionempleados where Identificacion='" & Me.TxtNombre.Text & "'")
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
    Private Function imprimir()
        Try
            Dim Imprimir_Liquidacion As New Liquidacion
            Dim visor As New frmVisorReportes
            Imprimir_Liquidacion.SetParameterValue(0, TxtNombre.Text)
            visor.rptViewer.ReportSource = Imprimir_Liquidacion
            visor.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Function

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
        'If TextBox7.Text = "" Then
        '    MsgBox("Debe ingresar Observaciones", MsgBoxStyle.Information, "Sistema SeeSoft")
        '    TextBox7.Focus()
        '    Exit Function
        'End If

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
    End Function

    Private Sub Combo1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Combo1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox7.ReadOnly = False
            TextBox7.Focus()

        End If
    End Sub


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
End Class
