Imports System.Data.SqlClient
Imports Utilidades

Public Class AccionPersonal
    Inherits Plantilla

#Region "Variables"
    Dim busca As New BuscaAccionPersonal
    Dim usua As Object
    Protected WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents gb_vacaciones As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lb_dias As System.Windows.Forms.Label
    Friend WithEvents ckSalario As System.Windows.Forms.CheckBox
    Friend WithEvents lblNuevoSalario As System.Windows.Forms.Label
    Friend WithEvents txtNuevoSalario As System.Windows.Forms.TextBox
    Friend WithEvents lblSalarioActual As System.Windows.Forms.Label
    Friend WithEvents txtSalarioActual As System.Windows.Forms.TextBox
    Friend WithEvents pUsuario As System.Windows.Forms.Panel
    Friend WithEvents lblPorcentajeAumento As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeAumento As System.Windows.Forms.TextBox
    Dim EstadoAnterior As Integer

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAccionNº As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbAccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents pnlRige As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDiasDesc As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterAccionPersonal As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetAccionPersonal1 As Planilla.DataSetAccionPersonal
    Friend WithEvents AdapterEmpleado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterAccion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents pnlPrincipal As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionPuesto As System.Windows.Forms.TextBox
    Friend WithEvents dateFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CheckEstado As System.Windows.Forms.CheckBox
    Friend WithEvents CBEstado As System.Windows.Forms.ComboBox
    Friend WithEvents AdapterEstado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsEstado As Planilla.DSEstado
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtNombreEmp As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccionPersonal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccionNº = New System.Windows.Forms.TextBox()
        Me.DataSetAccionPersonal1 = New Planilla.DataSetAccionPersonal()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbAccion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.pnlRige = New System.Windows.Forms.Panel()
        Me.dateHasta = New System.Windows.Forms.DateTimePicker()
        Me.dateDesde = New System.Windows.Forms.DateTimePicker()
        Me.txtDiasDesc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.AdapterAccionPersonal = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterEmpleado = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterAccion = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.pnlPrincipal = New System.Windows.Forms.Panel()
        Me.txtNuevoSalario = New System.Windows.Forms.TextBox()
        Me.lblNuevoSalario = New System.Windows.Forms.Label()
        Me.lblSalarioActual = New System.Windows.Forms.Label()
        Me.txtSalarioActual = New System.Windows.Forms.TextBox()
        Me.ckSalario = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.gb_vacaciones = New System.Windows.Forms.GroupBox()
        Me.lb_dias = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtNombreEmp = New System.Windows.Forms.TextBox()
        Me.dateFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcionPuesto = New System.Windows.Forms.TextBox()
        Me.txtCodigoEmpleado = New System.Windows.Forms.TextBox()
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox()
        Me.CheckEstado = New System.Windows.Forms.CheckBox()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.DsEstado = New Planilla.DSEstado()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.AdapterEstado = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.pUsuario = New System.Windows.Forms.Panel()
        Me.lblPorcentajeAumento = New System.Windows.Forms.Label()
        Me.txtPorcentajeAumento = New System.Windows.Forms.TextBox()
        CType(Me.DataSetAccionPersonal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRige.SuspendLayout()
        Me.pnlPrincipal.SuspendLayout()
        Me.gb_vacaciones.SuspendLayout()
        CType(Me.DsEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.ForeColor = System.Drawing.Color.Black
        Me.TituloModulo.Image = Nothing
        Me.TituloModulo.Size = New System.Drawing.Size(673, 32)
        Me.TituloModulo.TabIndex = 0
        Me.TituloModulo.Text = "Formulario de Acción del Personal"
        '
        'ToolBar1
        '
        Me.ToolBar1.ImageList = Me.ImageList2
        Me.ToolBar1.Location = New System.Drawing.Point(0, 349)
        Me.ToolBar1.Size = New System.Drawing.Size(673, 56)
        Me.ToolBar1.TabIndex = 1
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
        Me.ToolBarExcel.ImageIndex = 9
        Me.ToolBarExcel.Text = "Editar"
        Me.ToolBarExcel.Visible = True
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(0, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Acción Nº"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAccionNº
        '
        Me.txtAccionNº.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.Num_Accion", True))
        Me.txtAccionNº.Enabled = False
        Me.txtAccionNº.Location = New System.Drawing.Point(0, 32)
        Me.txtAccionNº.Name = "txtAccionNº"
        Me.txtAccionNº.Size = New System.Drawing.Size(80, 20)
        Me.txtAccionNº.TabIndex = 2
        '
        'DataSetAccionPersonal1
        '
        Me.DataSetAccionPersonal1.DataSetName = "DataSetAccionPersonal"
        Me.DataSetAccionPersonal1.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.DataSetAccionPersonal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(88, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Código Empleado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(192, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(477, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre del Empleado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(0, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descripción del Puesto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(358, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(303, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Acción"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbAccion
        '
        Me.cmbAccion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetAccionPersonal1, "AccionPersonal.Id_Accion", True))
        Me.cmbAccion.DataSource = Me.DataSetAccionPersonal1.Accion
        Me.cmbAccion.DisplayMember = "Nombre"
        Me.cmbAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccion.Location = New System.Drawing.Point(358, 80)
        Me.cmbAccion.Name = "cmbAccion"
        Me.cmbAccion.Size = New System.Drawing.Size(303, 21)
        Me.cmbAccion.TabIndex = 10
        Me.cmbAccion.ValueMember = "Codigo"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(264, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(0, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(661, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Observaciones de la Acción"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.Observaciones", True))
        Me.txtObservaciones.Location = New System.Drawing.Point(0, 167)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObservaciones.Size = New System.Drawing.Size(661, 49)
        Me.txtObservaciones.TabIndex = 14
        '
        'pnlRige
        '
        Me.pnlRige.Controls.Add(Me.dateHasta)
        Me.pnlRige.Controls.Add(Me.dateDesde)
        Me.pnlRige.Controls.Add(Me.txtDiasDesc)
        Me.pnlRige.Controls.Add(Me.Label11)
        Me.pnlRige.Controls.Add(Me.Label10)
        Me.pnlRige.Controls.Add(Me.Label8)
        Me.pnlRige.Controls.Add(Me.Label13)
        Me.pnlRige.Enabled = False
        Me.pnlRige.Location = New System.Drawing.Point(5, 224)
        Me.pnlRige.Name = "pnlRige"
        Me.pnlRige.Size = New System.Drawing.Size(402, 84)
        Me.pnlRige.TabIndex = 72
        '
        'dateHasta
        '
        Me.dateHasta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.RigeHasta", True))
        Me.dateHasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dateHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateHasta.Location = New System.Drawing.Point(143, 48)
        Me.dateHasta.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dateHasta.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dateHasta.Name = "dateHasta"
        Me.dateHasta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dateHasta.Size = New System.Drawing.Size(149, 22)
        Me.dateHasta.TabIndex = 77
        '
        'dateDesde
        '
        Me.dateDesde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.RigeDesde", True))
        Me.dateDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dateDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateDesde.Location = New System.Drawing.Point(9, 47)
        Me.dateDesde.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dateDesde.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dateDesde.Name = "dateDesde"
        Me.dateDesde.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dateDesde.Size = New System.Drawing.Size(128, 22)
        Me.dateDesde.TabIndex = 76
        '
        'txtDiasDesc
        '
        Me.txtDiasDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.DiasaDescontar", True))
        Me.txtDiasDesc.Enabled = False
        Me.txtDiasDesc.Location = New System.Drawing.Point(298, 41)
        Me.txtDiasDesc.Name = "txtDiasDesc"
        Me.txtDiasDesc.ReadOnly = True
        Me.txtDiasDesc.Size = New System.Drawing.Size(97, 20)
        Me.txtDiasDesc.TabIndex = 6
        Me.txtDiasDesc.Text = "0"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Location = New System.Drawing.Point(298, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Días a Descontar"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Green
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(143, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 22)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Primer día de ingreso"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Green
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 22)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Último día laborado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(-1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(403, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Rige"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(669, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Datos Generales"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Location = New System.Drawing.Point(3, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(248, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Usuario"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=Planilla;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterAccionPersonal
        '
        Me.AdapterAccionPersonal.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterAccionPersonal.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterAccionPersonal.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterAccionPersonal.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AccionPersonal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Num_Accion", "Num_Accion"), New System.Data.Common.DataColumnMapping("Id_Empleado", "Id_Empleado"), New System.Data.Common.DataColumnMapping("Nombre_Empleado", "Nombre_Empleado"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Id_Accion", "Id_Accion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("RigeDesde", "RigeDesde"), New System.Data.Common.DataColumnMapping("RigeHasta", "RigeHasta"), New System.Data.Common.DataColumnMapping("DiasaDescontar", "DiasaDescontar"), New System.Data.Common.DataColumnMapping("HechoPor", "HechoPor"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("Anula", "Anula"), New System.Data.Common.DataColumnMapping("EstadoCambio", "EstadoCambio"), New System.Data.Common.DataColumnMapping("Cod_Estado", "Cod_Estado"), New System.Data.Common.DataColumnMapping("Liquidacion", "Liquidacion"), New System.Data.Common.DataColumnMapping("AumentoSalario", "AumentoSalario"), New System.Data.Common.DataColumnMapping("SalarioActual", "SalarioActual"), New System.Data.Common.DataColumnMapping("NuevoSalario", "NuevoSalario")})})
        Me.AdapterAccionPersonal.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [AccionPersonal] WHERE (([Num_Accion] = @Original_Num_Accion))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 0, "Id_Empleado"), New System.Data.SqlClient.SqlParameter("@Nombre_Empleado", System.Data.SqlDbType.VarChar, 0, "Nombre_Empleado"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 0, "Puesto"), New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 0, "Id_Accion"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@RigeDesde", System.Data.SqlDbType.DateTime, 0, "RigeDesde"), New System.Data.SqlClient.SqlParameter("@RigeHasta", System.Data.SqlDbType.DateTime, 0, "RigeHasta"), New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Float, 0, "DiasaDescontar"), New System.Data.SqlClient.SqlParameter("@HechoPor", System.Data.SqlDbType.VarChar, 0, "HechoPor"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 0, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 0, "Anula"), New System.Data.SqlClient.SqlParameter("@EstadoCambio", System.Data.SqlDbType.Bit, 0, "EstadoCambio"), New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 0, "Cod_Estado"), New System.Data.SqlClient.SqlParameter("@Liquidacion", System.Data.SqlDbType.Bit, 0, "Liquidacion"), New System.Data.SqlClient.SqlParameter("@AumentoSalario", System.Data.SqlDbType.Bit, 0, "AumentoSalario"), New System.Data.SqlClient.SqlParameter("@SalarioActual", System.Data.SqlDbType.Float, 0, "SalarioActual"), New System.Data.SqlClient.SqlParameter("@NuevoSalario", System.Data.SqlDbType.Float, 0, "NuevoSalario")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 0, "Id_Empleado"), New System.Data.SqlClient.SqlParameter("@Nombre_Empleado", System.Data.SqlDbType.VarChar, 0, "Nombre_Empleado"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 0, "Puesto"), New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 0, "Id_Accion"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@RigeDesde", System.Data.SqlDbType.DateTime, 0, "RigeDesde"), New System.Data.SqlClient.SqlParameter("@RigeHasta", System.Data.SqlDbType.DateTime, 0, "RigeHasta"), New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Float, 0, "DiasaDescontar"), New System.Data.SqlClient.SqlParameter("@HechoPor", System.Data.SqlDbType.VarChar, 0, "HechoPor"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 0, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 0, "Anula"), New System.Data.SqlClient.SqlParameter("@EstadoCambio", System.Data.SqlDbType.Bit, 0, "EstadoCambio"), New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 0, "Cod_Estado"), New System.Data.SqlClient.SqlParameter("@Liquidacion", System.Data.SqlDbType.Bit, 0, "Liquidacion"), New System.Data.SqlClient.SqlParameter("@AumentoSalario", System.Data.SqlDbType.Bit, 0, "AumentoSalario"), New System.Data.SqlClient.SqlParameter("@SalarioActual", System.Data.SqlDbType.Float, 0, "SalarioActual"), New System.Data.SqlClient.SqlParameter("@NuevoSalario", System.Data.SqlDbType.Float, 0, "NuevoSalario"), New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Num_Accion", System.Data.SqlDbType.BigInt, 8, "Num_Accion")})
        '
        'AdapterEmpleado
        '
        Me.AdapterEmpleado.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterEmpleado.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterEmpleado.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Estado_Civil", "Estado_Civil"), New System.Data.Common.DataColumnMapping("Hijos", "Hijos"), New System.Data.Common.DataColumnMapping("Cod_Nacionalidad", "Cod_Nacionalidad"), New System.Data.Common.DataColumnMapping("Fecha_Nacimiento", "Fecha_Nacimiento"), New System.Data.Common.DataColumnMapping("Edad", "Edad"), New System.Data.Common.DataColumnMapping("Telefono1", "Telefono1"), New System.Data.Common.DataColumnMapping("Telefono2", "Telefono2"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Fecha_Ingreso", "Fecha_Ingreso"), New System.Data.Common.DataColumnMapping("Fecha_Salida", "Fecha_Salida"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("Cod_Departamento", "Cod_Departamento"), New System.Data.Common.DataColumnMapping("Masculino", "Masculino"), New System.Data.Common.DataColumnMapping("Femenino", "Femenino"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Hora", "Hora"), New System.Data.Common.DataColumnMapping("Diario", "Diario"), New System.Data.Common.DataColumnMapping("Semana", "Semana"), New System.Data.Common.DataColumnMapping("Quincena", "Quincena"), New System.Data.Common.DataColumnMapping("Mensual", "Mensual"), New System.Data.Common.DataColumnMapping("Cod_Estado", "Cod_Estado"), New System.Data.Common.DataColumnMapping("Foto", "Foto")})})
        Me.AdapterEmpleado.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Departamento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Departamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Nacionalidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Edad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Estado_Civil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado_Civil", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Femenino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Femenino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Hijos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Masculino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Masculino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"), New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 50, "Estado_Civil"), New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 4, "Hijos"), New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, "Cod_Nacionalidad"), New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, "Fecha_Nacimiento"), New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"), New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 50, "Telefono1"), New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 50, "Telefono2"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 100, "Puesto"), New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"), New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"), New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"), New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 4, "Cod_Departamento"), New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 1, "Masculino"), New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 1, "Femenino"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"), New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"), New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"), New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"), New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"), New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"), New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"), New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 50, "Estado_Civil"), New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 4, "Hijos"), New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, "Cod_Nacionalidad"), New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, "Fecha_Nacimiento"), New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"), New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 50, "Telefono1"), New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 50, "Telefono2"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"), New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 100, "Puesto"), New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"), New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"), New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"), New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 4, "Cod_Departamento"), New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 1, "Masculino"), New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 1, "Femenino"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"), New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"), New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"), New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"), New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"), New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"), New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"), New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Departamento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Departamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Nacionalidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Edad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Estado_Civil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado_Civil", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nacimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Femenino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Femenino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Hijos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Masculino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Masculino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing)})
        '
        'AdapterAccion
        '
        Me.AdapterAccion.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterAccion.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterAccion.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterAccion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("RangoFecha", "RangoFecha"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        Me.AdapterAccion.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Accion WHERE (Codigo = @Original_Codigo) AND (Descripcion = @Original" & _
    "_Descripcion) AND (Nombre = @Original_Nombre) AND (RangoFecha = @Original_RangoF" & _
    "echa)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RangoFecha", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RangoFecha", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Accion(Descripcion, RangoFecha, Nombre) VALUES (@Descripcion, @RangoF" & _
    "echa, @Nombre); SELECT Codigo, Descripcion, RangoFecha, Nombre FROM Accion WHERE" & _
    " (Codigo = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"), New System.Data.SqlClient.SqlParameter("@RangoFecha", System.Data.SqlDbType.Bit, 1, "RangoFecha"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Codigo, Descripcion, RangoFecha, Nombre FROM Accion"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"), New System.Data.SqlClient.SqlParameter("@RangoFecha", System.Data.SqlDbType.Bit, 1, "RangoFecha"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RangoFecha", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RangoFecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo")})
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.lblPorcentajeAumento)
        Me.pnlPrincipal.Controls.Add(Me.txtPorcentajeAumento)
        Me.pnlPrincipal.Controls.Add(Me.txtNuevoSalario)
        Me.pnlPrincipal.Controls.Add(Me.lblNuevoSalario)
        Me.pnlPrincipal.Controls.Add(Me.lblSalarioActual)
        Me.pnlPrincipal.Controls.Add(Me.txtSalarioActual)
        Me.pnlPrincipal.Controls.Add(Me.ckSalario)
        Me.pnlPrincipal.Controls.Add(Me.LinkLabel1)
        Me.pnlPrincipal.Controls.Add(Me.gb_vacaciones)
        Me.pnlPrincipal.Controls.Add(Me.TxtNombreEmp)
        Me.pnlPrincipal.Controls.Add(Me.dateFecha)
        Me.pnlPrincipal.Controls.Add(Me.txtDescripcionPuesto)
        Me.pnlPrincipal.Controls.Add(Me.txtCodigoEmpleado)
        Me.pnlPrincipal.Controls.Add(Me.txtCedulaUsuario)
        Me.pnlPrincipal.Controls.Add(Me.Label9)
        Me.pnlPrincipal.Controls.Add(Me.Label1)
        Me.pnlPrincipal.Controls.Add(Me.txtAccionNº)
        Me.pnlPrincipal.Controls.Add(Me.Label2)
        Me.pnlPrincipal.Controls.Add(Me.Label3)
        Me.pnlPrincipal.Controls.Add(Me.Label4)
        Me.pnlPrincipal.Controls.Add(Me.Label5)
        Me.pnlPrincipal.Controls.Add(Me.cmbAccion)
        Me.pnlPrincipal.Controls.Add(Me.Label6)
        Me.pnlPrincipal.Controls.Add(Me.Label7)
        Me.pnlPrincipal.Controls.Add(Me.txtObservaciones)
        Me.pnlPrincipal.Controls.Add(Me.pnlRige)
        Me.pnlPrincipal.Controls.Add(Me.CheckEstado)
        Me.pnlPrincipal.Controls.Add(Me.CBEstado)
        Me.pnlPrincipal.Enabled = False
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 32)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(673, 311)
        Me.pnlPrincipal.TabIndex = 254
        '
        'txtNuevoSalario
        '
        Me.txtNuevoSalario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.NuevoSalario", True))
        Me.txtNuevoSalario.Location = New System.Drawing.Point(401, 125)
        Me.txtNuevoSalario.Name = "txtNuevoSalario"
        Me.txtNuevoSalario.Size = New System.Drawing.Size(71, 20)
        Me.txtNuevoSalario.TabIndex = 84
        Me.txtNuevoSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNuevoSalario.Visible = False
        '
        'lblNuevoSalario
        '
        Me.lblNuevoSalario.AutoSize = True
        Me.lblNuevoSalario.Location = New System.Drawing.Point(357, 129)
        Me.lblNuevoSalario.Name = "lblNuevoSalario"
        Me.lblNuevoSalario.Size = New System.Drawing.Size(45, 13)
        Me.lblNuevoSalario.TabIndex = 85
        Me.lblNuevoSalario.Text = "Nuevo :"
        Me.lblNuevoSalario.Visible = False
        '
        'lblSalarioActual
        '
        Me.lblSalarioActual.AutoSize = True
        Me.lblSalarioActual.Location = New System.Drawing.Point(113, 130)
        Me.lblSalarioActual.Name = "lblSalarioActual"
        Me.lblSalarioActual.Size = New System.Drawing.Size(43, 13)
        Me.lblSalarioActual.TabIndex = 83
        Me.lblSalarioActual.Text = "Actual :"
        Me.lblSalarioActual.Visible = False
        '
        'txtSalarioActual
        '
        Me.txtSalarioActual.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.SalarioActual", True))
        Me.txtSalarioActual.Location = New System.Drawing.Point(158, 126)
        Me.txtSalarioActual.Name = "txtSalarioActual"
        Me.txtSalarioActual.ReadOnly = True
        Me.txtSalarioActual.Size = New System.Drawing.Size(71, 20)
        Me.txtSalarioActual.TabIndex = 82
        Me.txtSalarioActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSalarioActual.Visible = False
        '
        'ckSalario
        '
        Me.ckSalario.AutoSize = True
        Me.ckSalario.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetAccionPersonal1, "AccionPersonal.AumentoSalario", True))
        Me.ckSalario.Location = New System.Drawing.Point(7, 128)
        Me.ckSalario.Name = "ckSalario"
        Me.ckSalario.Size = New System.Drawing.Size(103, 17)
        Me.ckSalario.TabIndex = 81
        Me.ckSalario.Text = "Aumento Salario"
        Me.ckSalario.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(230, 160)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(226, 61)
        Me.LinkLabel1.TabIndex = 76
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Anulado"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LinkLabel1.Visible = False
        '
        'gb_vacaciones
        '
        Me.gb_vacaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gb_vacaciones.Controls.Add(Me.lb_dias)
        Me.gb_vacaciones.Controls.Add(Me.Label15)
        Me.gb_vacaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gb_vacaciones.Location = New System.Drawing.Point(413, 251)
        Me.gb_vacaciones.Name = "gb_vacaciones"
        Me.gb_vacaciones.Size = New System.Drawing.Size(248, 43)
        Me.gb_vacaciones.TabIndex = 80
        Me.gb_vacaciones.TabStop = False
        Me.gb_vacaciones.Visible = False
        '
        'lb_dias
        '
        Me.lb_dias.AutoSize = True
        Me.lb_dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dias.Location = New System.Drawing.Point(125, 15)
        Me.lb_dias.Name = "lb_dias"
        Me.lb_dias.Size = New System.Drawing.Size(17, 18)
        Me.lb_dias.TabIndex = 1
        Me.lb_dias.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Días Disponibles:"
        '
        'TxtNombreEmp
        '
        Me.TxtNombreEmp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.Nombre_Empleado", True))
        Me.TxtNombreEmp.Location = New System.Drawing.Point(192, 32)
        Me.TxtNombreEmp.Name = "TxtNombreEmp"
        Me.TxtNombreEmp.Size = New System.Drawing.Size(477, 20)
        Me.TxtNombreEmp.TabIndex = 79
        '
        'dateFecha
        '
        Me.dateFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.Fecha", True))
        Me.dateFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dateFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFecha.Location = New System.Drawing.Point(264, 80)
        Me.dateFecha.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dateFecha.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dateFecha.Name = "dateFecha"
        Me.dateFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dateFecha.Size = New System.Drawing.Size(88, 20)
        Me.dateFecha.TabIndex = 75
        '
        'txtDescripcionPuesto
        '
        Me.txtDescripcionPuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionPuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.Puesto", True))
        Me.txtDescripcionPuesto.Enabled = False
        Me.txtDescripcionPuesto.ForeColor = System.Drawing.Color.Blue
        Me.txtDescripcionPuesto.Location = New System.Drawing.Point(0, 80)
        Me.txtDescripcionPuesto.Name = "txtDescripcionPuesto"
        Me.txtDescripcionPuesto.Size = New System.Drawing.Size(260, 20)
        Me.txtDescripcionPuesto.TabIndex = 74
        '
        'txtCodigoEmpleado
        '
        Me.txtCodigoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.Id_Empleado", True))
        Me.txtCodigoEmpleado.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigoEmpleado.Location = New System.Drawing.Point(88, 32)
        Me.txtCodigoEmpleado.Name = "txtCodigoEmpleado"
        Me.txtCodigoEmpleado.Size = New System.Drawing.Size(96, 20)
        Me.txtCodigoEmpleado.TabIndex = 73
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtCedulaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCedulaUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedulaUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.HechoPor", True))
        Me.txtCedulaUsuario.Enabled = False
        Me.txtCedulaUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(416, 269)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(120, 13)
        Me.txtCedulaUsuario.TabIndex = 19
        '
        'CheckEstado
        '
        Me.CheckEstado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetAccionPersonal1, "AccionPersonal.EstadoCambio", True))
        Me.CheckEstado.Location = New System.Drawing.Point(7, 101)
        Me.CheckEstado.Name = "CheckEstado"
        Me.CheckEstado.Size = New System.Drawing.Size(104, 24)
        Me.CheckEstado.TabIndex = 77
        Me.CheckEstado.Text = "Cambiar Estado"
        '
        'CBEstado
        '
        Me.CBEstado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetAccionPersonal1, "AccionPersonal.Cod_Estado", True))
        Me.CBEstado.DataSource = Me.DsEstado.Estado_Empleado
        Me.CBEstado.DisplayMember = "Descripcion"
        Me.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEstado.Location = New System.Drawing.Point(117, 103)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(121, 21)
        Me.CBEstado.TabIndex = 78
        Me.CBEstado.ValueMember = "Codigo"
        Me.CBEstado.Visible = False
        '
        'DsEstado
        '
        Me.DsEstado.DataSetName = "DSEstado"
        Me.DsEstado.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(3, 20)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(72, 20)
        Me.txtUsuario.TabIndex = 17
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.NombreUsuario", True))
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(78, 20)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(173, 20)
        Me.txtNombreUsuario.TabIndex = 18
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=.;Initial Catalog=Planilla;Integrated Security=True"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        '
        'AdapterEstado
        '
        Me.AdapterEstado.DeleteCommand = Me.SqlDeleteCommand5
        Me.AdapterEstado.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterEstado.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterEstado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Estado_Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Salida", "Salida")})})
        Me.AdapterEstado.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM Estado_Empleado WHERE (Codigo = @Original_Codigo) AND (Descripcion = " & _
    "@Original_Descripcion) AND (Salida = @Original_Salida)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Salida", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salida", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO Estado_Empleado(Descripcion, Salida) VALUES (@Descripcion, @Salida); " & _
    "SELECT Codigo, Descripcion, Salida FROM Estado_Empleado WHERE (Codigo = @@IDENTI" & _
    "TY)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 1, "Salida")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Codigo, Descripcion, Salida FROM Estado_Empleado"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 1, "Salida"), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Salida", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salida", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo")})
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "document.png")
        Me.ImageList2.Images.SetKeyName(1, "016-search.png")
        Me.ImageList2.Images.SetKeyName(2, "015-floppy-disk.png")
        Me.ImageList2.Images.SetKeyName(3, "011-trash.png")
        Me.ImageList2.Images.SetKeyName(4, "014-invoice.png")
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "real-estate.png")
        Me.ImageList2.Images.SetKeyName(7, "014-invoice.png")
        Me.ImageList2.Images.SetKeyName(8, "real-estate.png")
        Me.ImageList2.Images.SetKeyName(9, "012-edit.png")
        '
        'pUsuario
        '
        Me.pUsuario.Controls.Add(Me.txtUsuario)
        Me.pUsuario.Controls.Add(Me.Label12)
        Me.pUsuario.Controls.Add(Me.txtNombreUsuario)
        Me.pUsuario.Enabled = False
        Me.pUsuario.Location = New System.Drawing.Point(410, 354)
        Me.pUsuario.Name = "pUsuario"
        Me.pUsuario.Size = New System.Drawing.Size(255, 42)
        Me.pUsuario.TabIndex = 86
        '
        'lblPorcentajeAumento
        '
        Me.lblPorcentajeAumento.AutoSize = True
        Me.lblPorcentajeAumento.Location = New System.Drawing.Point(236, 129)
        Me.lblPorcentajeAumento.Name = "lblPorcentajeAumento"
        Me.lblPorcentajeAumento.Size = New System.Drawing.Size(64, 13)
        Me.lblPorcentajeAumento.TabIndex = 87
        Me.lblPorcentajeAumento.Text = "Porcentaje :"
        Me.lblPorcentajeAumento.Visible = False
        '
        'txtPorcentajeAumento
        '
        Me.txtPorcentajeAumento.Location = New System.Drawing.Point(303, 125)
        Me.txtPorcentajeAumento.Name = "txtPorcentajeAumento"
        Me.txtPorcentajeAumento.Size = New System.Drawing.Size(49, 20)
        Me.txtPorcentajeAumento.TabIndex = 86
        Me.txtPorcentajeAumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPorcentajeAumento.Visible = False
        '
        'AccionPersonal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(673, 405)
        Me.Controls.Add(Me.pUsuario)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 700)
        Me.MinimumSize = New System.Drawing.Size(544, 392)
        Me.Name = "AccionPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accion del Personal"
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.pnlPrincipal, 0)
        Me.Controls.SetChildIndex(Me.pUsuario, 0)
        CType(Me.DataSetAccionPersonal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRige.ResumeLayout(False)
        Me.pnlRige.PerformLayout()
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        Me.gb_vacaciones.ResumeLayout(False)
        Me.gb_vacaciones.PerformLayout()
        CType(Me.DsEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pUsuario.ResumeLayout(False)
        Me.pUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub AccionPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
        Me.SqlConnection2.ConnectionString = GetSetting("SeeSoft", "Seguridad", "Conexion")
        Me.pnlPrincipal.Enabled = False

        If GetSetting("seesoft", "planilla", "guanavet") = "" Then
            SaveSetting("seesoft", "planilla", "guanavet", "0")
        End If

        Try
            Me.AdapterAccion.Fill(Me.DataSetAccionPersonal1.Accion)
            Me.AdapterEmpleado.Fill(Me.DataSetAccionPersonal1.Empleado)
            Me.AdapterEstado.Fill(Me.DsEstado.Estado_Empleado)
            '********************VALORES POR DEFECTO**************************************
            DataSetAccionPersonal1.AccionPersonal.Id_EmpleadoColumn.DefaultValue = ""
            DataSetAccionPersonal1.AccionPersonal.Id_AccionColumn.DefaultValue = DataSetAccionPersonal1.Accion.Rows(0).Item("Codigo")
            DataSetAccionPersonal1.AccionPersonal.FechaColumn.DefaultValue = Now.Date
            DataSetAccionPersonal1.AccionPersonal.ObservacionesColumn.DefaultValue = ""
            DataSetAccionPersonal1.AccionPersonal.RigeDesdeColumn.DefaultValue = Now
            DataSetAccionPersonal1.AccionPersonal.RigeHastaColumn.DefaultValue = Now
            DataSetAccionPersonal1.AccionPersonal.DiasaDescontarColumn.DefaultValue = 0
            DataSetAccionPersonal1.AccionPersonal.HechoPorColumn.DefaultValue = ""
            DataSetAccionPersonal1.AccionPersonal.NombreUsuarioColumn.DefaultValue = ""
            Me.DataSetAccionPersonal1.AccionPersonal.Nombre_EmpleadoColumn.DefaultValue = " "
            DataSetAccionPersonal1.AccionPersonal.EstadoCambioColumn.DefaultValue = 0
            DataSetAccionPersonal1.AccionPersonal.Cod_EstadoColumn.DefaultValue = 0

            DataSetAccionPersonal1.AccionPersonal.LiquidacionColumn.DefaultValue = False
            DataSetAccionPersonal1.AccionPersonal.AumentoSalarioColumn.DefaultValue = False
            DataSetAccionPersonal1.AccionPersonal.SalarioActualColumn.DefaultValue = 0
            DataSetAccionPersonal1.AccionPersonal.NuevoSalarioColumn.DefaultValue = 0

            valida()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1

            Case 1 : Nuevo()

            Case 2 : If PMU.Find Then buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 4 : If PMU.Delete Then Anular() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : Editar()

            Case 7 : Me.Close()

        End Select
    End Sub
#End Region

#Region "Nuevo"
    Sub Nuevo()
        If Me.ToolBarNuevo.Text = "Nuevo" Then
            Dim NombreUsuario As String
            Dim Usuario1 As String
            Try
                LinkLabel1.Visible = False
                Dim comando As SqlCommand = New SqlCommand("SELECT Count(*) AS Total FROM AccionPersonal", Me.SqlConnection1)
                Dim lee As SqlDataReader
                NombreUsuario = Me.txtNombreUsuario.Text : Usuario1 = Me.txtUsuario.Text
                Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").EndCurrentEdit()
                Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").AddNew()
                If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
                lee = comando.ExecuteReader
                If lee.Read Then
                    txtAccionNº.Text = lee(0) + 1
                Else
                    txtAccionNº.Text = "1"
                End If
                SqlConnection1.Close()
                Me.ToolBarNuevo.Text = "Cancelar"
                Me.ToolBarNuevo.ImageIndex = 4
                Control_toolbar(False)
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarRegistrar.Enabled = True
                Me.ToolBarBuscar.Enabled = True
                pUsuario.Enabled = True ' pnlPrincipal
                Me.txtUsuario.Focus()
                Me.txtUsuario.Text = Usuario1
                Me.txtNombreUsuario.Text = NombreUsuario
                Me.txtCodigoEmpleado.Focus()
                gb_vacaciones.Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            Try
                Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").CancelCurrentEdit()
                Control_toolbar(False)
                If txtCodigoEmpleado.Text <> "" Then
                    If Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("Anula") = True Then
                        LinkLabel1.Visible = True
                    End If
                End If
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarBuscar.Enabled = True                
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.txtUsuario.Text = ""
                pUsuario.Enabled = False
                pnlPrincipal.Enabled = False
                Me.ToolBarNuevo.ImageIndex = 0
                Me.CheckEstado.Checked = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
#End Region

#Region "Buscar"
    Sub buscar()
        busca.ShowDialog()
        If Not busca.id < 0 Then
            Try
                Me.DataSetAccionPersonal1.AccionPersonal.Clear()
                Dim fu As New cFunciones
                fu.Cargar_Tabla_Generico(Me.AdapterAccionPersonal, "select * from AccionPersonal where Num_Accion = " & busca.id)
                Me.AdapterAccionPersonal.Fill(Me.DataSetAccionPersonal1.AccionPersonal)
                Control_toolbar(True)
                If Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("Anula") = True Then
                    LinkLabel1.Visible = True
                    LinkLabel1.Enabled = True
                    Me.ToolBarExcel.Enabled = False
                Else
                    LinkLabel1.Visible = False

                End If
                Me.ToolBarRegistrar.Enabled = False
                Me.pnlPrincipal.Enabled = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
#End Region

#Region "Registrar"
    Sub Registrar(Optional ByVal bool As Boolean = False)
        Dim Trans As SqlTransaction
        Dim Resp As Integer
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim str As String = valida2()
        If cmbAccion.Text = "VACACIONES" Then
            If Me.calcularVacaciones = True Then
                Exit Sub
            End If
        End If
        If str = "" Or bool = True Then
            Try
                Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("Anula") = False
                If Me.pnlRige.Enabled = True And Me.ToolBarExcel.Text = "Cancelar" Then
                    Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("RigeDesde") = Me.dateDesde.Text
                    Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("RigeHasta") = Me.dateHasta.Text
                    Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("DiasaDescontar") = _
                    CInt(Me.txtDiasDesc.Text)
                ElseIf Me.pnlRige.Enabled = False And Me.ToolBarExcel.Text = "Cancelar" Then
                    Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("RigeDesde") = System.DBNull.Value
                    Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("RigeHasta") = System.DBNull.Value
                    Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("DiasDescontar") = 0
                End If

                If Me.CheckEstado.Checked = True Then
                    Dim cconexion As New Conexion
                    Dim sqlconexion As New SqlClient.SqlConnection
                    Dim Salida As Boolean
                    sqlconexion = cconexion.Conectar("Planilla")
                    'Tiene que ser dinamico, realizar una consulta acciones para ver cual está como salida
                    Salida = cconexion.SlqExecuteScalar(sqlconexion, "Select Salida from Estado_Empleado where Codigo =" & Me.CBEstado.SelectedValue)
                    cconexion.DesConectar(sqlconexion)
                    If Me.CBEstado.SelectedValue <> EstadoAnterior Then
                        Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("EstadoCambio") = 1
                        Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("Cod_Estado") = Me.CBEstado.SelectedValue
                        Me.BindingContext(Me.DataSetAccionPersonal1, "Empleado").Current("Cod_Estado") = Me.CBEstado.SelectedValue
                        ActualizaEstado()
                        If Me.CBEstado.SelectedValue = 1 Then
                            ActualizaFechaIngreso()
                        ElseIf Salida = True Then
                            ActualizaFechaSalida()
                        End If
                    Else
                        MsgBox("El Estado Seleccionado es igual al estado actual", MsgBoxStyle.Information)
                    End If
                End If

                Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").EndCurrentEdit()
                Trans = Me.SqlConnection1.BeginTransaction
                Me.AdapterAccionPersonal.InsertCommand.Transaction = Trans
                Me.AdapterAccionPersonal.UpdateCommand.Transaction = Trans
                Me.AdapterAccionPersonal.DeleteCommand.Transaction = Trans
                Me.AdapterAccionPersonal.Update(Me.DataSetAccionPersonal1, "AccionPersonal") ' saj
                Me.DataSetAccionPersonal1.AcceptChanges()
                Trans.Commit()

                Try
                    If cmbAccion.Text = "VACACIONES" Then
                        Dim db As New OBSoluciones.SQL.Sentencias(Me.SqlConnection1.ConnectionString)
                        db.Ejecutar("Update AccionPersonal Set SaldoVacacciones = " & CDec(Me.lb_dias.Text - Me.txtDiasDesc.Text) & " Where Num_Accion = " & txtAccionNº.Text, CommandType.Text)
                    End If
                Catch ex As Exception
                End Try

                Control_toolbar(False)
                Me.pnlPrincipal.Enabled = False
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.ToolBarNuevo.ImageIndex = 0
                Me.ToolBarExcel.Text = "Editar"
                Me.ToolBarExcel.ImageIndex = 9
                Me.CheckEstado.Checked = False
                MsgBox("Accion del Personal se ha registrado satisfactoriamente", MsgBoxStyle.Information)
                Resp = MessageBox.Show("¿Desea Imprimir Reporte?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If Resp = 6 Then
                    Me.imprimir()
                End If
                Me.pnlPrincipal.Enabled = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Existen problemas en los siguientes campos: " & str, MsgBoxStyle.Exclamation)
        End If
    End Sub
#End Region

#Region "Eliminar"
    Sub Anular()
        Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("Anula") = True
        Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").EndCurrentEdit()
        LinkLabel1.Visible = True
        Try
            Me.AdapterAccionPersonal.Update(Me.DataSetAccionPersonal1.AccionPersonal)
            MsgBox("Acción Anulada satisfactoriamente", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error al tratar de anular el Ajuste, Intente de nuevo, Si el problema persite, Comuniqueselo al administrador de sistema")
        End Try
    End Sub

#End Region

#Region "imprimir"
    Sub imprimir()
        Try
            Dim AccionPersonales As New AccionPersona
            Dim visor As New frmVisorReportes

            AccionPersonales.SetParameterValue(0, txtAccionNº.Text)
            'AccionPersonales.SetParameterValue(1, CDec(Me.lb_dias.Text - txtDiasDesc.Text))


            visor.rptViewer.ReportSource = AccionPersonales
            Planilla.CrystalReportsConexion.LoadReportViewer(visor.rptViewer, AccionPersonales)
            visor.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try

    End Sub
#End Region

#Region "Editar"
    Sub Editar()
        If Me.ToolBarExcel.Text = "Editar" Then
            Me.ToolBarExcel.Text = "Cancelar"
            Me.ToolBarExcel.ImageIndex = 4
            Control_toolbar(False)
            Me.ToolBarExcel.Enabled = True
            Me.ToolBarRegistrar.Enabled = True
            Me.pnlPrincipal.Enabled = True
        Else
            Me.ToolBarExcel.Text = "Editar"
            Me.ToolBarExcel.ImageIndex = 9
            Control_toolbar(True)
            Me.ToolBarRegistrar.Enabled = False
            Me.pnlPrincipal.Enabled = False
        End If
    End Sub
#End Region

#Region "validar"
    Sub valida()
        If Me.BindingContext(Me.DataSetAccionPersonal1, "Accion").Count > 0 Then
            PosicionaAccion()
            'If Me.BindingContext(Me.DataSetAccionPersonal1, "Accion").Current("RangoFecha") = True Then
            '    Me.pnlRige.Enabled = Me.BindingContext(Me.DataSetAccionPersonal1, "Accion").Current("RangoFecha")
            'Else
            '    Me.pnlRige.Enabled = False
            'End If
            Me.pnlRige.Enabled = Me.BindingContext(Me.DataSetAccionPersonal1, "Accion").Current("RangoFecha")
        End If
    End Sub

    Function valida2() As String
        Dim res As String
        If Me.pnlRige.Enabled = True And Me.txtDiasDesc.Text = "" Then
            res = "DiasDesc. "
            Me.txtDiasDesc.Focus()
        End If
        If Me.txtObservaciones.Text = "" Then
            res += "Observaciones. "
            Me.txtObservaciones.Focus()
        End If
        If Me.dateDesde.Value > Me.dateHasta.Value Then
            res += "Rango de Fechas no válido."
            Me.dateDesde.Focus()
        End If
        Return res
    End Function
#End Region

#Region "Controles"
    Sub Control_toolbar(ByVal bool As Boolean)
        Me.ToolBarRegistrar.Enabled = bool
        Me.ToolBarNuevo.Enabled = bool
        Me.ToolBarImprimir.Enabled = bool
        Me.ToolBarExcel.Enabled = bool
        Me.ToolBarEliminar.Enabled = bool
    End Sub

    Private Sub cmbAccion_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAccion.SelectedValueChanged
        valida()
    End Sub

    Private Sub dateHasta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateHasta.LostFocus
        'Dim diferencia As Integer
        'diferencia = DateDiff(DateInterval.Day, CDate(dateDesde.Text), CDate(dateHasta.Text))

        'txtDiasDesc.Text = (diferencia + 1)
    End Sub
    Sub DiasHab()
        Try
            Dim Cant As Integer = 0
            Dim Ini As DateTime = dateDesde.Value
            Dim Fin As Date = dateHasta.Value
            Dim feriados As Integer

            Dim dtsferiados As New DataTable
            cFunciones.Llenar_Tabla_Generico("select dia,mes from feriados", dtsferiados, GetSetting("seesoft", "Planilla", "conexion"))

            While Ini <> Fin

                For i As Integer = 0 To dtsferiados.Rows.Count - 1

                    If Ini.Month = dtsferiados.Rows(i).Item("mes") Then
                        If Ini.Day = dtsferiados.Rows(i).Item("dia") Then
                            feriados += 1
                        End If
                    End If

                Next

                If GetSetting("seesoft", "planilla", "guanavet") = "0" Then
                    If Not (Ini.DayOfWeek = DayOfWeek.Sunday) Then
                        Cant = Cant + 1
                    End If
                End If
                If GetSetting("seesoft", "planilla", "guanavet") = 1 Then
                    Cant = Cant + 1
                End If

                Ini = Ini.AddDays(1)
            End While
            txtDiasDesc.Text = (Cant - 1) - feriados
            'lbldias.Text = "Dias habiles: " & Cant
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CheckEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEstado.CheckedChanged
        CBEstado.Visible = CheckEstado.Checked
        CBEstado.SelectedIndex = 0
    End Sub

#Region "Keydown"
    Private Sub txtCodigoEmpleado_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoEmpleado.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            Me.txtCodigoEmpleado.Text = cFunciones.BuscarDatos2("select identificacion as Identificación,nombre as Nombre from Empleado Where Cod_Estado = 1 ", "Nombre", " ORDER BY Nombre", "Buscar Empleado ....", SqlConnection1.ConnectionString, 0, True)
            CargarInformacionEmpleado(txtCodigoEmpleado.Text)
        End If
        If e.KeyCode = Keys.Enter Then
            CargarInformacionEmpleado(txtCodigoEmpleado.Text)
        End If
    End Sub

    Private Sub cmbAccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbAccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            dateFecha.Focus()
        End If
    End Sub

    Private Sub dateFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dateFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtObservaciones.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObservaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            dateDesde.Focus()
        End If
    End Sub

    Private Sub dateDesde_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dateDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            dateHasta.Focus()
        End If
    End Sub

    Private Sub dateHasta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dateHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            DiasHab()
            txtDiasDesc.Focus()
        End If
    End Sub

    Private Sub txtDiasDesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiasDesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtUsuario.Focus()
        End If
    End Sub
#End Region

#Region "KeyPress"
    Private Sub txtAccionNº_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccionNº.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtCodigoEmpleado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub txtDescripcionPuesto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub dateDesde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub dateFecha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub dateHasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub txtDiasDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasDesc.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
#End Region

#End Region

#Region "Validar Usuario"
    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        Dim cConexion As New Conexion
        Dim sqlconex As New SqlConnection
        Dim rs As SqlDataReader

        Me.pnlPrincipal.Enabled = False
        If e.KeyCode = Keys.Enter Then
            If txtUsuario.Text <> "" Then
                sqlconex = cConexion.Conectar2
                rs = cConexion.GetRecorset(sqlconex, "SELECT Id_Usuario, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Focus()
                End If
                While rs.Read
                    Try
                        txtNombreUsuario.Text = rs("Nombre")
                        txtCedulaUsuario.Text = rs("Id_Usuario")
                        Me.pnlPrincipal.Enabled = True
                        Me.txtCodigoEmpleado.Focus()
                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(sqlconex)
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                txtUsuario.Focus()
            End If
        End If
    End Sub

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
#End Region

#Region "Actualiza Cambio de Estado"
    Function ActualizaEstado()
        Dim cConexion As New Conexion
        cConexion.SlqExecuteScalar(cConexion.Conectar("Planilla"), "UPDATE Empleado SET Cod_Estado = '" & Me.CBEstado.SelectedValue & "' WHERE (Identificacion = '" & Me.txtCodigoEmpleado.Text & "')")
        cConexion.DesConectar(cConexion.sQlconexion)
    End Function
    Function ActualizaFechaIngreso()
        Dim cConexion As New Conexion
        cConexion.SlqExecuteScalar(cConexion.Conectar("Planilla"), "UPDATE Empleado SET Fecha_Ingreso = '" & Me.dateFecha.Value & "' WHERE (Identificacion = '" & Me.txtCodigoEmpleado.Text & "')")
        cConexion.DesConectar(cConexion.sQlconexion)
    End Function
    Function ActualizaFechaSalida()
        Dim cConexion As New Conexion
        cConexion.SlqExecuteScalar(cConexion.Conectar("Planilla"), "UPDATE Empleado SET Fecha_Salida = '" & Me.dateFecha.Value & "' WHERE (Identificacion = '" & Me.txtCodigoEmpleado.Text & "')")
        cConexion.DesConectar(cConexion.sQlconexion)
    End Function
#End Region

#Region "Funciones"
    Private Sub CargarInformacionEmpleado(ByVal codigo As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader
        Dim i As Integer
        Dim fila As DataRow
        Dim factura As Long
        If codigo <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar("Planilla"), "SELECT Identificacion, Nombre, Puesto, Cod_Estado, Salario from Empleado where Identificacion ='" & codigo & "'")
            Try
                If rs.Read Then
                    Me.TxtNombreEmp.Text = rs("Nombre")
                    Me.txtDescripcionPuesto.Text = rs("Puesto")
                    Me.EstadoAnterior = rs("Cod_Estado")
                    Me.txtSalarioActual.Text = CDec(rs("Salario")).ToString("N2")
                    cmbAccion.Focus()
                Else
                    MsgBox("La identificación del Empleado no se encuentra", MsgBoxStyle.Information, "Atención...")
                    Me.TxtNombreEmp.Text = "" : Me.txtDescripcionPuesto.Text = ""
                    Me.txtCodigoEmpleado.Focus()
                    rs.Close()
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            rs.Close()
            cConexion.DesConectar(cConexion.Conectar)
        End If
    End Sub

    Private Sub PosicionaAccion()
        Dim pos As Integer      'UBICA EL BINDING DE LA BODEGA EN LA BODEGA DE LA TOMA FISICA
        Dim vista As DataView

        Try
            vista = Me.DataSetAccionPersonal1.Accion.DefaultView
            vista.Sort = "Codigo"
            pos = vista.Find(cmbAccion.SelectedValue)
            Me.BindingContext(Me.DataSetAccionPersonal1, "Accion").Position = pos
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        End Try
    End Sub
#End Region
    Function calcularVacaciones() As Boolean
        Dim ds As DataSet
        Dim cx As New Conexion
        Dim sqlc As New SqlConnection
        Dim ingreso As DateTime
        Dim acumulados As Integer
        Dim disfrutados As Integer
        Dim habiles As Integer
        Dim Tiempo, Año, Año1, Mes, Mes1 As Double
        ds = cx.ds1("select * from VistaVacaciones where Identificacion= '" & Me.txtCodigoEmpleado.Text & "'")
        Try
            Dim z As Integer
            z = ds.Tables("VistaVacaciones").Rows.Count
            If z <> 0 Then
                ingreso = ds.Tables("VistaVacaciones").Rows(0).Item(2)
                Tiempo = DateDiff(DateInterval.Day, ingreso, Date.Today)
                Año = Tiempo / 365
                Año1 = QuitaDecimal(Año)
                Mes = (((Año - Año1) * 365) / 30)
                Mes1 = QuitaDecimal(Mes)
                acumulados = (Mes1 * 1.16) + (Año1 * 12)
                Dim x As Integer
                For x = 0 To ds.Tables("VistaVacaciones").Rows.Count - 1
                    disfrutados += ds.Tables("VistaVacaciones").Rows(x).Item(7)
                Next
                habiles = acumulados - disfrutados

                If MsgBox(Me.TxtNombreEmp.Text & " Saldo Actual " & habiles & "  desea aplicar vacaciones", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return False
    End Function
    Private Function QuitaDecimal(ByVal numero As String) As String
        Return Math.Round(CDec(numero))
        'Dim punto As Integer = -1
        'punto = numero.IndexOf(".")
        'If punto <> -1 Then
        '    QuitaDecimal = numero.Substring(0, punto)
        '    Exit Function
        'End If
        'QuitaDecimal = numero
    End Function

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub dateDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateDesde.ValueChanged

    End Sub

    Private Sub dateHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateHasta.ValueChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub txtNombreUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreUsuario.TextChanged

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub cmbAccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccion.SelectedIndexChanged
        If cmbAccion.Text = "VACACIONES" Then
            calcularVacas()
        Else
            gb_vacaciones.Visible = False
        End If
    End Sub

    Function calcularVacas() As Boolean
        Dim ds As DataSet
        Dim cx As New Conexion
        Dim sqlc As New SqlConnection
        Dim ingreso As DateTime
        Dim acumulados As Integer
        Dim disfrutados As Integer
        Dim habiles As Integer
        Dim Tiempo, Año, Año1, Mes, Mes1 As Double
        ds = cx.ds1("select * from VistaVacaciones where Identificacion= '" & Me.txtCodigoEmpleado.Text & "'")
        Try
            Dim z As Integer
            z = ds.Tables("VistaVacaciones").Rows.Count
            If z <> 0 Then
                ingreso = ds.Tables("VistaVacaciones").Rows(0).Item(2)
                Tiempo = DateDiff(DateInterval.Day, ingreso, Date.Today)
                Año = Tiempo / 365
                Año1 = QuitaDecimal(Año)
                Mes = (((Año - Año1) * 365) / 30)
                Mes1 = QuitaDecimal(Mes)
                acumulados = (Mes1 * 1.16) + (Año1 * 12)
                Dim x As Integer
                For x = 0 To ds.Tables("VistaVacaciones").Rows.Count - 1
                    disfrutados += ds.Tables("VistaVacaciones").Rows(x).Item(7)
                Next
                lb_dias.Text = acumulados - disfrutados
                gb_vacaciones.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return False
    End Function

    Private Function CargarSalarioEmpleado(Identificacion As String) As Decimal
        If Identificacion = "" Then
            MsgBox("Debe seleccionar un empleado primero.")
            Return 0
        Else
            Try
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("select Salario from Empleado where Identificacion = '" & Identificacion & "'", dt, GetSetting("SeeSoft", "Planilla", "Conexion"))
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0).Item("Salario")
                Else
                    Return 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al obtener Salario del Empleado")
                Return 0
            End Try          
        End If
    End Function

    Private Sub ckSalario_CheckedChanged(sender As Object, e As EventArgs) Handles ckSalario.CheckedChanged
        Me.lblNuevoSalario.Visible = Me.ckSalario.Checked
        Me.txtNuevoSalario.Visible = Me.ckSalario.Checked
        Me.lblSalarioActual.Visible = Me.ckSalario.Checked
        Me.txtSalarioActual.Visible = Me.ckSalario.Checked
        Me.lblPorcentajeAumento.Visible = Me.ckSalario.Checked
        Me.txtPorcentajeAumento.Visible = Me.ckSalario.Checked
        Me.txtSalarioActual.Text = Me.CargarSalarioEmpleado(Me.txtCodigoEmpleado.Text).ToString("N2")
    End Sub

    Private Sub txtPorcentajeAumento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNuevoSalario.KeyDown, txtPorcentajeAumento.KeyDown
        If e.KeyCode = Keys.Enter And sender.text <> "" Then
            If IsNumeric(sender.text) Then
                Dim Antes, Porcentaje, Nuevo As Decimal
                Antes = CDec(Me.txtSalarioActual.Text)
                Porcentaje = 0
                Nuevo = 0
                Select Case sender.name
                    Case "txtNuevoSalario" 'NuevoSalario
                        Nuevo = CDec(Me.txtNuevoSalario.Text)
                        Porcentaje = ((Nuevo / Antes) - 1) * 100
                        Me.txtPorcentajeAumento.Text = Porcentaje
                    Case "txtPorcentajeAumento" 'PorcentajeAumento
                        Porcentaje = CDec(Me.txtPorcentajeAumento.Text)
                        Nuevo = Antes * (1 + (Porcentaje / 100))
                        Me.txtNuevoSalario.Text = Nuevo
                End Select

            End If
        End If
    End Sub
End Class
