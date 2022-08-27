Imports System.Data.SqlClient
Imports Utilidades
Public Class AccionPersonal
    Inherits Plantilla
    Dim busca As New BuscaAccionPersonal
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAccionNº As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDiasDesc As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents AdapterUsuario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsUsuario As Planilla.DsUsuario
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AccionPersonal))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAccionNº = New DevExpress.XtraEditors.TextEdit
        Me.DataSetAccionPersonal1 = New Planilla.DataSetAccionPersonal
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbAccion = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.pnlRige = New System.Windows.Forms.Panel
        Me.dateHasta = New System.Windows.Forms.DateTimePicker
        Me.dateDesde = New System.Windows.Forms.DateTimePicker
        Me.txtDiasDesc = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterAccionPersonal = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.AdapterEmpleado = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.AdapterAccion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.pnlPrincipal = New System.Windows.Forms.Panel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.dateFecha = New System.Windows.Forms.DateTimePicker
        Me.txtDescripcionPuesto = New System.Windows.Forms.TextBox
        Me.txtCodigoEmpleado = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.AdapterUsuario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DsUsuario = New Planilla.DsUsuario
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.txtAccionNº.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAccionPersonal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRige.SuspendLayout()
        CType(Me.txtDiasDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.DsUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(536, 32)
        Me.TituloModulo.TabIndex = 0
        Me.TituloModulo.Text = "Formulario de Acción del Personal"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        '
        'ToolBar1
        '
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 306)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(536, 52)
        Me.ToolBar1.TabIndex = 1
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
        Me.ToolBarExcel.ImageIndex = 9
        Me.ToolBarExcel.Text = "Editar"
        Me.ToolBarExcel.Visible = True
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
        Me.txtAccionNº.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetAccionPersonal1, "AccionPersonal.Num_Accion"))
        Me.txtAccionNº.EditValue = ""
        Me.txtAccionNº.Location = New System.Drawing.Point(0, 32)
        Me.txtAccionNº.Name = "txtAccionNº"
        '
        'txtAccionNº.Properties
        '
        Me.txtAccionNº.Properties.Enabled = False
        Me.txtAccionNº.Size = New System.Drawing.Size(80, 19)
        Me.txtAccionNº.TabIndex = 2
        '
        'DataSetAccionPersonal1
        '
        Me.DataSetAccionPersonal1.DataSetName = "DataSetAccionPersonal"
        Me.DataSetAccionPersonal1.Locale = New System.Globalization.CultureInfo("es-ES")
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
        Me.Label3.Size = New System.Drawing.Size(336, 16)
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
        Me.Label4.Size = New System.Drawing.Size(184, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descripción del Puesto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(192, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Acción"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbAccion
        '
        Me.cmbAccion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetAccionPersonal1, "AccionPersonal.Id_Accion"))
        Me.cmbAccion.DataSource = Me.DataSetAccionPersonal1.Accion
        Me.cmbAccion.DisplayMember = "Nombre"
        Me.cmbAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccion.Location = New System.Drawing.Point(192, 80)
        Me.cmbAccion.Name = "cmbAccion"
        Me.cmbAccion.Size = New System.Drawing.Size(240, 21)
        Me.cmbAccion.TabIndex = 10
        Me.cmbAccion.ValueMember = "Codigo"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(440, 64)
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
        Me.Label7.Location = New System.Drawing.Point(0, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(528, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Observaciones de la Acción"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.Observaciones"))
        Me.txtObservaciones.Location = New System.Drawing.Point(0, 128)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObservaciones.Size = New System.Drawing.Size(528, 56)
        Me.txtObservaciones.TabIndex = 14
        Me.txtObservaciones.Text = ""
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
        Me.pnlRige.Location = New System.Drawing.Point(0, 192)
        Me.pnlRige.Name = "pnlRige"
        Me.pnlRige.Size = New System.Drawing.Size(272, 72)
        Me.pnlRige.TabIndex = 72
        '
        'dateHasta
        '
        Me.dateHasta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.RigeHasta"))
        Me.dateHasta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dateHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dateHasta.Location = New System.Drawing.Point(96, 40)
        Me.dateHasta.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dateHasta.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dateHasta.Name = "dateHasta"
        Me.dateHasta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dateHasta.Size = New System.Drawing.Size(88, 20)
        Me.dateHasta.TabIndex = 77
        '
        'dateDesde
        '
        Me.dateDesde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.RigeDesde"))
        Me.dateDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dateDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dateDesde.Location = New System.Drawing.Point(0, 40)
        Me.dateDesde.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dateDesde.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dateDesde.Name = "dateDesde"
        Me.dateDesde.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dateDesde.Size = New System.Drawing.Size(88, 20)
        Me.dateDesde.TabIndex = 76
        '
        'txtDiasDesc
        '
        Me.txtDiasDesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetAccionPersonal1, "AccionPersonal.DiasaDescontar"))
        Me.txtDiasDesc.EditValue = ""
        Me.txtDiasDesc.Location = New System.Drawing.Point(192, 40)
        Me.txtDiasDesc.Name = "txtDiasDesc"
        '
        'txtDiasDesc.Properties
        '
        Me.txtDiasDesc.Properties.Enabled = False
        Me.txtDiasDesc.Size = New System.Drawing.Size(72, 19)
        Me.txtDiasDesc.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Location = New System.Drawing.Point(192, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Días a Descontar"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Location = New System.Drawing.Point(96, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Hasta"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Location = New System.Drawing.Point(0, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Desde"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(-1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(272, 16)
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
        Me.Label9.Size = New System.Drawing.Size(528, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Datos Generales"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Location = New System.Drawing.Point(280, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(248, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Usuario"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(280, 192)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(248, 16)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Hecho Por"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=(local" & _
        ");persist security info=False;initial catalog=Planilla"
        '
        'AdapterAccionPersonal
        '
        Me.AdapterAccionPersonal.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterAccionPersonal.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterAccionPersonal.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterAccionPersonal.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AccionPersonal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Num_Accion", "Num_Accion"), New System.Data.Common.DataColumnMapping("Id_Empleado", "Id_Empleado"), New System.Data.Common.DataColumnMapping("Nombre_Empleado", "Nombre_Empleado"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Id_Accion", "Id_Accion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("RigeDesde", "RigeDesde"), New System.Data.Common.DataColumnMapping("RigeHasta", "RigeHasta"), New System.Data.Common.DataColumnMapping("DiasaDescontar", "DiasaDescontar"), New System.Data.Common.DataColumnMapping("HechoPor", "HechoPor"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("Anula", "Anula")})})
        Me.AdapterAccionPersonal.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM AccionPersonal WHERE (Num_Accion = @Original_Num_Accion) AND (Anula =" & _
        " @Original_Anula) AND (DiasaDescontar = @Original_DiasaDescontar) AND (Fecha = @" & _
        "Original_Fecha) AND (HechoPor = @Original_HechoPor) AND (Id_Accion = @Original_I" & _
        "d_Accion) AND (Id_Empleado = @Original_Id_Empleado) AND (NombreUsuario = @Origin" & _
        "al_NombreUsuario) AND (Nombre_Empleado = @Original_Nombre_Empleado) AND (Observa" & _
        "ciones = @Original_Observaciones) AND (Puesto = @Original_Puesto) AND (RigeDesde" & _
        " = @Original_RigeDesde) AND (RigeHasta = @Original_RigeHasta)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiasaDescontar", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiasaDescontar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HechoPor", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HechoPor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Accion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeDesde", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeDesde", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeHasta", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeHasta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO AccionPersonal(Num_Accion, Id_Empleado, Nombre_Empleado, Puesto, Id_A" & _
        "ccion, Fecha, Observaciones, RigeDesde, RigeHasta, DiasaDescontar, HechoPor, Nom" & _
        "breUsuario, Anula) VALUES (@Num_Accion, @Id_Empleado, @Nombre_Empleado, @Puesto," & _
        " @Id_Accion, @Fecha, @Observaciones, @RigeDesde, @RigeHasta, @DiasaDescontar, @H" & _
        "echoPor, @NombreUsuario, @Anula); SELECT Num_Accion, Id_Empleado, Nombre_Emplead" & _
        "o, Puesto, Id_Accion, Fecha, Observaciones, RigeDesde, RigeHasta, DiasaDescontar" & _
        ", HechoPor, NombreUsuario, Anula FROM AccionPersonal WHERE (Num_Accion = @Num_Ac" & _
        "cion)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Accion", System.Data.SqlDbType.BigInt, 8, "Num_Accion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 250, "Id_Empleado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, "Nombre_Empleado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 4, "Id_Accion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeDesde", System.Data.SqlDbType.DateTime, 8, "RigeDesde"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeHasta", System.Data.SqlDbType.DateTime, 8, "RigeHasta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Int, 4, "DiasaDescontar"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HechoPor", System.Data.SqlDbType.VarChar, 75, "HechoPor"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Num_Accion, Id_Empleado, Nombre_Empleado, Puesto, Id_Accion, Fecha, Observ" & _
        "aciones, RigeDesde, RigeHasta, DiasaDescontar, HechoPor, NombreUsuario, Anula FR" & _
        "OM AccionPersonal"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE AccionPersonal SET Num_Accion = @Num_Accion, Id_Empleado = @Id_Empleado, N" & _
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
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Accion", System.Data.SqlDbType.BigInt, 8, "Num_Accion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 250, "Id_Empleado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, "Nombre_Empleado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 4, "Id_Accion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeDesde", System.Data.SqlDbType.DateTime, 8, "RigeDesde"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeHasta", System.Data.SqlDbType.DateTime, 8, "RigeHasta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Int, 4, "DiasaDescontar"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HechoPor", System.Data.SqlDbType.VarChar, 75, "HechoPor"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiasaDescontar", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiasaDescontar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HechoPor", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HechoPor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Accion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeDesde", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeDesde", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeHasta", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeHasta", System.Data.DataRowVersion.Original, Nothing))
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
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Empleado WHERE (Identificacion = @Original_Identificacion) AND (Cod_D" & _
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
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Departamento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Departamento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Nacionalidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Edad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Estado_Civil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado_Civil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nacimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Femenino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Femenino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Masculino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Masculino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Empleado(Identificacion, Nombre, Estado_Civil, Hijos, Cod_Nacionalida" & _
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
        "ion)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 50, "Estado_Civil"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 4, "Hijos"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, "Cod_Nacionalidad"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, "Fecha_Nacimiento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 50, "Telefono1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 50, "Telefono2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 100, "Puesto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 4, "Cod_Departamento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 1, "Masculino"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 1, "Femenino"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Identificacion, Nombre, Estado_Civil, Hijos, Cod_Nacionalidad, Fecha_Nacim" & _
        "iento, Edad, Telefono1, Telefono2, Email, Direccion, Puesto, Fecha_Ingreso, Fech" & _
        "a_Salida, Salario, Cod_Departamento, Masculino, Femenino, Cod_Moneda, Hora, Diar" & _
        "io, Semana, Quincena, Mensual, Cod_Estado, Foto FROM Empleado"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Empleado SET Identificacion = @Identificacion, Nombre = @Nombre, Estado_Ci" & _
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
        "@Identificacion)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 50, "Estado_Civil"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 4, "Hijos"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, "Cod_Nacionalidad"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, "Fecha_Nacimiento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 50, "Telefono1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 50, "Telefono2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 100, "Puesto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 4, "Cod_Departamento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 1, "Masculino"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 1, "Femenino"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Departamento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Departamento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Nacionalidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Edad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Estado_Civil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado_Civil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nacimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Femenino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Femenino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Masculino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Masculino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing))
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
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RangoFecha", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RangoFecha", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Accion(Descripcion, RangoFecha, Nombre) VALUES (@Descripcion, @RangoF" & _
        "echa, @Nombre); SELECT Codigo, Descripcion, RangoFecha, Nombre FROM Accion WHERE" & _
        " (Codigo = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RangoFecha", System.Data.SqlDbType.Bit, 1, "RangoFecha"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Codigo, Descripcion, RangoFecha, Nombre FROM Accion"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Accion SET Descripcion = @Descripcion, RangoFecha = @RangoFecha, Nombre = " & _
        "@Nombre WHERE (Codigo = @Original_Codigo) AND (Descripcion = @Original_Descripci" & _
        "on) AND (Nombre = @Original_Nombre) AND (RangoFecha = @Original_RangoFecha); SEL" & _
        "ECT Codigo, Descripcion, RangoFecha, Nombre FROM Accion WHERE (Codigo = @Codigo)" & _
        ""
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RangoFecha", System.Data.SqlDbType.Bit, 1, "RangoFecha"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RangoFecha", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RangoFecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.LinkLabel1)
        Me.pnlPrincipal.Controls.Add(Me.dateFecha)
        Me.pnlPrincipal.Controls.Add(Me.txtDescripcionPuesto)
        Me.pnlPrincipal.Controls.Add(Me.txtCodigoEmpleado)
        Me.pnlPrincipal.Controls.Add(Me.txtUsuario)
        Me.pnlPrincipal.Controls.Add(Me.txtNombreUsuario)
        Me.pnlPrincipal.Controls.Add(Me.txtCedulaUsuario)
        Me.pnlPrincipal.Controls.Add(Me.txtNombre)
        Me.pnlPrincipal.Controls.Add(Me.Label9)
        Me.pnlPrincipal.Controls.Add(Me.Label12)
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
        Me.pnlPrincipal.Controls.Add(Me.Label14)
        Me.pnlPrincipal.Enabled = False
        Me.pnlPrincipal.Location = New System.Drawing.Point(0, 32)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(536, 272)
        Me.pnlPrincipal.TabIndex = 254
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(104, 112)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(296, 72)
        Me.LinkLabel1.TabIndex = 76
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Anulado"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LinkLabel1.Visible = False
        '
        'dateFecha
        '
        Me.dateFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.Fecha"))
        Me.dateFecha.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dateFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dateFecha.Location = New System.Drawing.Point(440, 80)
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
        Me.txtDescripcionPuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.Puesto"))
        Me.txtDescripcionPuesto.Enabled = False
        Me.txtDescripcionPuesto.ForeColor = System.Drawing.Color.Blue
        Me.txtDescripcionPuesto.Location = New System.Drawing.Point(0, 80)
        Me.txtDescripcionPuesto.Name = "txtDescripcionPuesto"
        Me.txtDescripcionPuesto.Size = New System.Drawing.Size(184, 20)
        Me.txtDescripcionPuesto.TabIndex = 74
        Me.txtDescripcionPuesto.Text = ""
        '
        'txtCodigoEmpleado
        '
        Me.txtCodigoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.Id_Empleado"))
        Me.txtCodigoEmpleado.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigoEmpleado.Location = New System.Drawing.Point(88, 32)
        Me.txtCodigoEmpleado.Name = "txtCodigoEmpleado"
        Me.txtCodigoEmpleado.Size = New System.Drawing.Size(96, 20)
        Me.txtCodigoEmpleado.TabIndex = 73
        Me.txtCodigoEmpleado.Text = ""
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(280, 224)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(72, 20)
        Me.txtUsuario.TabIndex = 17
        Me.txtUsuario.Text = ""
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.NombreUsuario"))
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(355, 224)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(173, 20)
        Me.txtNombreUsuario.TabIndex = 18
        Me.txtNombreUsuario.Text = ""
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtCedulaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedulaUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedulaUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.HechoPor"))
        Me.txtCedulaUsuario.Enabled = False
        Me.txtCedulaUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(408, 224)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(120, 20)
        Me.txtCedulaUsuario.TabIndex = 19
        Me.txtCedulaUsuario.Text = ""
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccionPersonal1, "AccionPersonal.Nombre_Empleado"))
        Me.txtNombre.Enabled = False
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(192, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(336, 20)
        Me.txtNombre.TabIndex = 6
        Me.txtNombre.Text = ""
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=MARIANO;packet size=4096;integrated security=SSPI;data source=(loc" & _
        "al);persist security info=False;initial catalog=Planilla"
        '
        'AdapterUsuario
        '
        Me.AdapterUsuario.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdapterUsuario.InsertCommand = Me.SqlInsertCommand4
        Me.AdapterUsuario.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterUsuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Perfil", "Perfil"), New System.Data.Common.DataColumnMapping("Anu_Venta", "Anu_Venta"), New System.Data.Common.DataColumnMapping("Anu_Cotizacion", "Anu_Cotizacion"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa"), New System.Data.Common.DataColumnMapping("RecibosDinero", "RecibosDinero"), New System.Data.Common.DataColumnMapping("AnuRecibos", "AnuRecibos"), New System.Data.Common.DataColumnMapping("VariarIntereses", "VariarIntereses"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio"), New System.Data.Common.DataColumnMapping("Foto", "Foto"), New System.Data.Common.DataColumnMapping("Abrir_Credito", "Abrir_Credito")})})
        Me.AdapterUsuario.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Usuarios WHERE (Cedula = @Original_Cedula) AND (Abrir_Credito = @Orig" & _
        "inal_Abrir_Credito) AND (AnuRecibos = @Original_AnuRecibos) AND (Anu_Cotizacion " & _
        "= @Original_Anu_Cotizacion) AND (Anu_Venta = @Original_Anu_Venta) AND (Aplicar_D" & _
        "esc = @Original_Aplicar_Desc) AND (CambiarPrecio = @Original_CambiarPrecio) AND " & _
        "(Clave_Entrada = @Original_Clave_Entrada) AND (Clave_Interna = @Original_Clave_I" & _
        "nterna) AND (Exist_Negativa = @Original_Exist_Negativa) AND (Nombre = @Original_" & _
        "Nombre) AND (Perfil = @Original_Perfil) AND (Porc_Desc = @Original_Porc_Desc) AN" & _
        "D (Porc_Precio = @Original_Porc_Precio) AND (RecibosDinero = @Original_RecibosDi" & _
        "nero) AND (VariarIntereses = @Original_VariarIntereses)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection3
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abrir_Credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abrir_Credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AnuRecibos", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnuRecibos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anu_Cotizacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anu_Cotizacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anu_Venta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anu_Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aplicar_Desc", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplicar_Desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CambiarPrecio", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambiarPrecio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Clave_Entrada", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Entrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Clave_Interna", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Interna", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exist_Negativa", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exist_Negativa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Perfil", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Desc", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Precio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RecibosDinero", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecibosDinero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VariarIntereses", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VariarIntereses", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "workstation id=LUIFER;packet size=4096;integrated security=SSPI;data source=""."";p" & _
        "ersist security info=False;initial catalog=Planilla"
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Usuarios(Cedula, Nombre, Clave_Interna, Clave_Entrada, Perfil, Anu_Ve" & _
        "nta, Anu_Cotizacion, CambiarPrecio, Aplicar_Desc, Exist_Negativa, RecibosDinero," & _
        " AnuRecibos, VariarIntereses, Porc_Desc, Porc_Precio, Foto, Abrir_Credito) VALUE" & _
        "S (@Cedula, @Nombre, @Clave_Interna, @Clave_Entrada, @Perfil, @Anu_Venta, @Anu_C" & _
        "otizacion, @CambiarPrecio, @Aplicar_Desc, @Exist_Negativa, @RecibosDinero, @AnuR" & _
        "ecibos, @VariarIntereses, @Porc_Desc, @Porc_Precio, @Foto, @Abrir_Credito); SELE" & _
        "CT Cedula, Nombre, Clave_Interna, Clave_Entrada, Perfil, Anu_Venta, Anu_Cotizaci" & _
        "on, CambiarPrecio, Aplicar_Desc, Exist_Negativa, RecibosDinero, AnuRecibos, Vari" & _
        "arIntereses, Porc_Desc, Porc_Precio, Foto, Abrir_Credito FROM Usuarios WHERE (Ce" & _
        "dula = @Cedula)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection3
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Perfil", System.Data.SqlDbType.VarChar, 75, "Perfil"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anu_Venta", System.Data.SqlDbType.Bit, 1, "Anu_Venta"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anu_Cotizacion", System.Data.SqlDbType.Bit, 1, "Anu_Cotizacion"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RecibosDinero", System.Data.SqlDbType.Bit, 1, "RecibosDinero"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AnuRecibos", System.Data.SqlDbType.Bit, 1, "AnuRecibos"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VariarIntereses", System.Data.SqlDbType.Bit, 1, "VariarIntereses"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abrir_Credito", System.Data.SqlDbType.Bit, 1, "Abrir_Credito"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Cedula, Nombre, Clave_Interna, Clave_Entrada, Perfil, Anu_Venta, Anu_Cotiz" & _
        "acion, CambiarPrecio, Aplicar_Desc, Exist_Negativa, RecibosDinero, AnuRecibos, V" & _
        "ariarIntereses, Porc_Desc, Porc_Precio, Foto, Abrir_Credito FROM Usuarios"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection3
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Usuarios SET Cedula = @Cedula, Nombre = @Nombre, Clave_Interna = @Clave_In" & _
        "terna, Clave_Entrada = @Clave_Entrada, Perfil = @Perfil, Anu_Venta = @Anu_Venta," & _
        " Anu_Cotizacion = @Anu_Cotizacion, CambiarPrecio = @CambiarPrecio, Aplicar_Desc " & _
        "= @Aplicar_Desc, Exist_Negativa = @Exist_Negativa, RecibosDinero = @RecibosDiner" & _
        "o, AnuRecibos = @AnuRecibos, VariarIntereses = @VariarIntereses, Porc_Desc = @Po" & _
        "rc_Desc, Porc_Precio = @Porc_Precio, Foto = @Foto, Abrir_Credito = @Abrir_Credit" & _
        "o WHERE (Cedula = @Original_Cedula) AND (Abrir_Credito = @Original_Abrir_Credito" & _
        ") AND (AnuRecibos = @Original_AnuRecibos) AND (Anu_Cotizacion = @Original_Anu_Co" & _
        "tizacion) AND (Anu_Venta = @Original_Anu_Venta) AND (Aplicar_Desc = @Original_Ap" & _
        "licar_Desc) AND (CambiarPrecio = @Original_CambiarPrecio) AND (Clave_Entrada = @" & _
        "Original_Clave_Entrada) AND (Clave_Interna = @Original_Clave_Interna) AND (Exist" & _
        "_Negativa = @Original_Exist_Negativa) AND (Nombre = @Original_Nombre) AND (Perfi" & _
        "l = @Original_Perfil) AND (Porc_Desc = @Original_Porc_Desc) AND (Porc_Precio = @" & _
        "Original_Porc_Precio) AND (RecibosDinero = @Original_RecibosDinero) AND (VariarI" & _
        "ntereses = @Original_VariarIntereses); SELECT Cedula, Nombre, Clave_Interna, Cla" & _
        "ve_Entrada, Perfil, Anu_Venta, Anu_Cotizacion, CambiarPrecio, Aplicar_Desc, Exis" & _
        "t_Negativa, RecibosDinero, AnuRecibos, VariarIntereses, Porc_Desc, Porc_Precio, " & _
        "Foto, Abrir_Credito FROM Usuarios WHERE (Cedula = @Cedula)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection3
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Perfil", System.Data.SqlDbType.VarChar, 75, "Perfil"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anu_Venta", System.Data.SqlDbType.Bit, 1, "Anu_Venta"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anu_Cotizacion", System.Data.SqlDbType.Bit, 1, "Anu_Cotizacion"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RecibosDinero", System.Data.SqlDbType.Bit, 1, "RecibosDinero"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AnuRecibos", System.Data.SqlDbType.Bit, 1, "AnuRecibos"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VariarIntereses", System.Data.SqlDbType.Bit, 1, "VariarIntereses"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abrir_Credito", System.Data.SqlDbType.Bit, 1, "Abrir_Credito"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abrir_Credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abrir_Credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AnuRecibos", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnuRecibos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anu_Cotizacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anu_Cotizacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anu_Venta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anu_Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aplicar_Desc", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplicar_Desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CambiarPrecio", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambiarPrecio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Clave_Entrada", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Entrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Clave_Interna", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Interna", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exist_Negativa", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exist_Negativa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Perfil", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Desc", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Precio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RecibosDinero", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecibosDinero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VariarIntereses", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VariarIntereses", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsUsuario
        '
        Me.DsUsuario.DataSetName = "DsUsuario"
        Me.DsUsuario.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'AccionPersonal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 358)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(544, 392)
        Me.MinimumSize = New System.Drawing.Size(544, 392)
        Me.Name = "AccionPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accion del Personal"
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.pnlPrincipal, 0)
        CType(Me.txtAccionNº.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAccionPersonal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRige.ResumeLayout(False)
        CType(Me.txtDiasDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPrincipal.ResumeLayout(False)
        CType(Me.DsUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub AccionPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
        Try
            Me.AdapterAccion.Fill(Me.DataSetAccionPersonal1.Accion)
            Me.AdapterEmpleado.Fill(Me.DataSetAccionPersonal1.Empleado)
            'Me.AdapterUsuario.Fill(Me.DsUsuario.Usuarios)
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
            valida()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

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
            Try
                LinkLabel1.Visible = False
                Dim comando As SqlCommand = New SqlCommand("SELECT Count(*) AS Total FROM AccionPersonal", Me.SqlConnection1)
                Dim lee As SqlDataReader
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
                control_toolbar(False)
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarRegistrar.Enabled = True
                Me.ToolBarBuscar.Enabled = True
                Me.pnlPrincipal.Enabled = True
                Me.txtCodigoEmpleado.Focus()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            Try
                Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").CancelCurrentEdit()
                control_toolbar(False)
                If txtCodigoEmpleado.Text <> "" Then
                    If Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("Anula") = True Then
                        LinkLabel1.Visible = True
                    End If
                End If
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarBuscar.Enabled = True
                Me.pnlPrincipal.Enabled = False
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.ToolBarNuevo.ImageIndex = 0
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
#End Region

#Region "buscar"
    Sub buscar()
        busca.ShowDialog()
        If Not busca.id < 0 Then
            Try
                Me.DataSetAccionPersonal1.AccionPersonal.Clear()
                Dim fu As New cFunciones
                fu.Cargar_Tabla_Generico(Me.AdapterAccionPersonal, "select * from AccionPersonal where Num_Accion = " & busca.id)
                Me.AdapterAccionPersonal.Fill(Me.DataSetAccionPersonal1.AccionPersonal)
                control_toolbar(True)
                If Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").Current("Anula") = True Then
                    LinkLabel1.Visible = True
                    LinkLabel1.Enabled = True
                    Me.ToolBarExcel.Enabled = False
                Else
                    LinkLabel1.Visible = False

                End If
                'control_toolbar(True)
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
                Me.BindingContext(Me.DataSetAccionPersonal1, "AccionPersonal").EndCurrentEdit()
                Trans = Me.SqlConnection1.BeginTransaction
                Me.AdapterAccionPersonal.InsertCommand.Transaction = Trans
                Me.AdapterAccionPersonal.UpdateCommand.Transaction = Trans
                Me.AdapterAccionPersonal.DeleteCommand.Transaction = Trans
                Me.AdapterAccionPersonal.Update(Me.DataSetAccionPersonal1.AccionPersonal)
                Me.DataSetAccionPersonal1.AcceptChanges()
                Trans.Commit()
                control_toolbar(False)
                Me.pnlPrincipal.Enabled = False
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.ToolBarNuevo.ImageIndex = 0
                Me.ToolBarExcel.Text = "Editar"
                Me.ToolBarExcel.ImageIndex = 9
                MsgBox("Accion del Personal se ha registrado satisfactoriamente", MsgBoxStyle.Information)
                Resp = MessageBox.Show("¿Desea Imprimir Reporte?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If Resp = 6 Then
                    Me.imprimir()
                End If
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
            'AccionPersonales.SetParameterValue(0, txtCodigoEmpleado.Text)
            AccionPersonales.SetParameterValue(0, txtAccionNº.Text)
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
            control_toolbar(False)
            Me.ToolBarExcel.Enabled = True
            Me.ToolBarRegistrar.Enabled = True
            Me.pnlPrincipal.Enabled = True
        Else
            Me.ToolBarExcel.Text = "Editar"
            Me.ToolBarExcel.ImageIndex = 9
            control_toolbar(True)
            Me.ToolBarRegistrar.Enabled = False
            Me.pnlPrincipal.Enabled = False
        End If
    End Sub
#End Region

#Region "valida"
    Sub valida()
        If Me.BindingContext(Me.DataSetAccionPersonal1, "Accion").Count > 0 Then
            If Me.BindingContext(Me.DataSetAccionPersonal1, "Accion").Current("RangoFecha") = True Then
                Me.pnlRige.Enabled = True
            Else
                Me.pnlRige.Enabled = False
            End If
        End If
    End Sub
#End Region

#Region "valida2"
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
        If Me.dateDesde.Text > Me.dateHasta.Text Then
            res += "Rango de Fechas no válido."
            Me.dateDesde.Focus()
        End If
        Return res
    End Function
#End Region

    Sub control_toolbar(ByVal bool As Boolean)
        Me.ToolBarRegistrar.Enabled = bool
        Me.ToolBarNuevo.Enabled = bool
        Me.ToolBarImprimir.Enabled = bool
        Me.ToolBarExcel.Enabled = bool
        Me.ToolBarEliminar.Enabled = bool
    End Sub

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

    Private Sub AccionPersonal_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Not Me.cmbAccion.SelectedIndex < 0 Then
            valida()
        End If
    End Sub

    Private Sub txtDiasDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasDesc.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CargarInformacionEmpleado(ByVal codigo As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader
        Dim i As Integer
        Dim fila As DataRow
        Dim factura As Long
        If codigo <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Identificacion, Nombre, Puesto, Salario from Empleado where Identificacion ='" & codigo & "'")
            Try
                If rs.Read Then
                    txtNombre.Text = rs("Nombre")
                    txtDescripcionPuesto.Text = rs("Puesto")
                    cmbAccion.Focus()
                Else
                    MsgBox("La identificación del Empleado no se encuentra", MsgBoxStyle.Information, "Atención...")
                    txtNombre.Text = "" : txtDescripcionPuesto.Text = ""
                    txtCodigoEmpleado.Focus()
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

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        If e.KeyCode = Keys.Enter Then
            If txtUsuario.Text <> "" Then
                rs = cConexion.GetRecorset(Conectando, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Focus()
                End If
                While rs.Read
                    Try
                        txtNombreUsuario.Text = rs("Nombre")
                        txtCedulaUsuario.Text = rs("Cedula")
                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.Conectar)
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

    Private Sub txtCodigoEmpleado_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoEmpleado.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            Me.txtCodigoEmpleado.Text = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Empleado", "Nombre")
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

    Private Sub txtObservaciones_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservaciones.TextChanged

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
            txtDiasDesc.Focus()
        End If
    End Sub

    Private Sub txtDiasDesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDiasDesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtUsuario.Focus()
        End If
    End Sub


    Private Sub dateHasta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateHasta.LostFocus
        Dim diferencia As Integer
        diferencia = DateDiff(DateInterval.Day, CDate(dateDesde.Text), CDate(dateHasta.Text))
        txtDiasDesc.Text = diferencia
    End Sub

    Private Sub txtCodigoEmpleado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoEmpleado.TextChanged

    End Sub

    Private Sub pnlPrincipal_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlPrincipal.Paint

    End Sub
End Class
