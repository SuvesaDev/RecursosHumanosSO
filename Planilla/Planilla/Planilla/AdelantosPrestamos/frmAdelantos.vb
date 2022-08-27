Imports System.data.sqlclient
Imports Utilidades
Public Class frmAdelantos
    Inherits FrmPlantilla
    Dim buscando As Boolean
    Dim usua As Object

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        usua = Usuario_Parametro
        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adAdelantos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsAdelantos1 As Planilla.dsAdelantos
    Friend WithEvents opPrestamo As System.Windows.Forms.RadioButton
    Friend WithEvents opAdelanto As System.Windows.Forms.RadioButton
    Friend WithEvents DtFechaCompro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNum_Pagos As System.Windows.Forms.TextBox
    Friend WithEvents dtFechaCobro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtDeducirxPago As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ComboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtSalario As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoLetras As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckAnulado As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSalario = New System.Windows.Forms.TextBox
        Me.DsAdelantos1 = New Planilla.dsAdelantos
        Me.txtPuesto = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtIdentificacion = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.opPrestamo = New System.Windows.Forms.RadioButton
        Me.opAdelanto = New System.Windows.Forms.RadioButton
        Me.DtFechaCompro = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtNum_Pagos = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.txtMontoLetras = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDeducirxPago = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtFechaCobro = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ComboMoneda = New System.Windows.Forms.ComboBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.adAdelantos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.adMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.CheckAnulado = New System.Windows.Forms.CheckBox
        Me.Panel1.SuspendLayout()
        CType(Me.DsAdelantos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(728, 32)
        Me.TituloModulo.TabIndex = 0
        Me.TituloModulo.Text = "Adelantos o Préstamos"
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 332)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(728, 52)
        Me.ToolBar1.TabIndex = 12
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ToolBarEditar
        '
        Me.ToolBarEditar.Enabled = False
        Me.ToolBarEditar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtSalario)
        Me.Panel1.Controls.Add(Me.txtPuesto)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtIdentificacion)
        Me.Panel1.Location = New System.Drawing.Point(8, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 88)
        Me.Panel1.TabIndex = 4
        '
        'txtSalario
        '
        Me.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSalario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.Salario"))
        Me.txtSalario.ForeColor = System.Drawing.Color.Blue
        Me.txtSalario.Location = New System.Drawing.Point(336, 57)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(168, 13)
        Me.txtSalario.TabIndex = 7
        Me.txtSalario.Text = ""
        Me.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DsAdelantos1
        '
        Me.DsAdelantos1.DataSetName = "dsAdelantos"
        Me.DsAdelantos1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'txtPuesto
        '
        Me.txtPuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.Puesto"))
        Me.txtPuesto.ForeColor = System.Drawing.Color.Blue
        Me.txtPuesto.Location = New System.Drawing.Point(8, 58)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(312, 13)
        Me.txtPuesto.TabIndex = 5
        Me.txtPuesto.Text = ""
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.Nombre"))
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(120, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(384, 13)
        Me.txtNombre.TabIndex = 3
        Me.txtNombre.Text = ""
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(120, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(384, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Nombre Empleado"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(335, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Salario"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(7, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Puesto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identificación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtIdentificacion
        '
        Me.TxtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdentificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIdentificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.Identificacion"))
        Me.TxtIdentificacion.ForeColor = System.Drawing.Color.Blue
        Me.TxtIdentificacion.Location = New System.Drawing.Point(7, 27)
        Me.TxtIdentificacion.Name = "TxtIdentificacion"
        Me.TxtIdentificacion.TabIndex = 1
        Me.TxtIdentificacion.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opPrestamo)
        Me.GroupBox1.Controls.Add(Me.opAdelanto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(536, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 36)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Documento"
        '
        'opPrestamo
        '
        Me.opPrestamo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsAdelantos1, "Adelantos.Prestamo"))
        Me.opPrestamo.Location = New System.Drawing.Point(104, 16)
        Me.opPrestamo.Name = "opPrestamo"
        Me.opPrestamo.Size = New System.Drawing.Size(72, 15)
        Me.opPrestamo.TabIndex = 1
        Me.opPrestamo.Text = "Préstamo"
        '
        'opAdelanto
        '
        Me.opAdelanto.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsAdelantos1, "Adelantos.Adelanto"))
        Me.opAdelanto.Location = New System.Drawing.Point(8, 16)
        Me.opAdelanto.Name = "opAdelanto"
        Me.opAdelanto.Size = New System.Drawing.Size(72, 16)
        Me.opAdelanto.TabIndex = 0
        Me.opAdelanto.Text = "Adelanto"
        '
        'DtFechaCompro
        '
        Me.DtFechaCompro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.FechaComprobante"))
        Me.DtFechaCompro.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DtFechaCompro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFechaCompro.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtFechaCompro.Location = New System.Drawing.Point(535, 96)
        Me.DtFechaCompro.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.DtFechaCompro.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.DtFechaCompro.Name = "DtFechaCompro"
        Me.DtFechaCompro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DtFechaCompro.Size = New System.Drawing.Size(112, 20)
        Me.DtFechaCompro.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.ForeColor = System.Drawing.Color.Blue
        Me.Label18.Location = New System.Drawing.Point(535, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Fecha Comprobante"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNum_Pagos
        '
        Me.txtNum_Pagos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNum_Pagos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNum_Pagos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNum_Pagos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.Num_Pago"))
        Me.txtNum_Pagos.Enabled = False
        Me.txtNum_Pagos.ForeColor = System.Drawing.Color.Blue
        Me.txtNum_Pagos.Location = New System.Drawing.Point(657, 96)
        Me.txtNum_Pagos.Name = "txtNum_Pagos"
        Me.txtNum_Pagos.Size = New System.Drawing.Size(63, 13)
        Me.txtNum_Pagos.TabIndex = 9
        Me.txtNum_Pagos.Text = ""
        Me.txtNum_Pagos.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(657, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "# Pagos"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(32, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Información del Empleado"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(32, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(208, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Detalle del Adelanto o Préstamo"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtMonto)
        Me.Panel2.Controls.Add(Me.txtObservaciones)
        Me.Panel2.Controls.Add(Me.txtMontoLetras)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtDeducirxPago)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.dtFechaCobro)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.ComboMoneda)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Location = New System.Drawing.Point(8, 152)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(712, 128)
        Me.Panel2.TabIndex = 11
        '
        'txtMonto
        '
        Me.txtMonto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAdelantos1, "Adelantos.Monto"))
        Me.txtMonto.EditValue = ""
        Me.txtMonto.Location = New System.Drawing.Point(118, 24)
        Me.txtMonto.Name = "txtMonto"
        '
        'txtMonto.Properties
        '
        Me.txtMonto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtMonto.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtMonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Properties.Enabled = False
        Me.txtMonto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtMonto.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.ControlText)
        Me.txtMonto.Size = New System.Drawing.Size(96, 17)
        Me.txtMonto.TabIndex = 1
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.Observaciones"))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.Blue
        Me.txtObservaciones.Location = New System.Drawing.Point(118, 65)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(586, 53)
        Me.txtObservaciones.TabIndex = 11
        Me.txtObservaciones.Text = ""
        '
        'txtMontoLetras
        '
        Me.txtMontoLetras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoLetras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMontoLetras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.MontoEnLetras"))
        Me.txtMontoLetras.ForeColor = System.Drawing.Color.Blue
        Me.txtMontoLetras.Location = New System.Drawing.Point(224, 24)
        Me.txtMontoLetras.Name = "txtMontoLetras"
        Me.txtMontoLetras.Size = New System.Drawing.Size(481, 13)
        Me.txtMontoLetras.TabIndex = 3
        Me.txtMontoLetras.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(8, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Deducir x Pago"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'txtDeducirxPago
        '
        Me.txtDeducirxPago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDeducirxPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeducirxPago.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.DeducirxPago"))
        Me.txtDeducirxPago.Enabled = False
        Me.txtDeducirxPago.ForeColor = System.Drawing.Color.Blue
        Me.txtDeducirxPago.Location = New System.Drawing.Point(8, 104)
        Me.txtDeducirxPago.Name = "txtDeducirxPago"
        Me.txtDeducirxPago.Size = New System.Drawing.Size(96, 13)
        Me.txtDeducirxPago.TabIndex = 9
        Me.txtDeducirxPago.Text = ""
        Me.txtDeducirxPago.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(117, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(585, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Observaciones"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtFechaCobro
        '
        Me.dtFechaCobro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.FechaCobro"))
        Me.dtFechaCobro.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtFechaCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFechaCobro.Location = New System.Drawing.Point(8, 64)
        Me.dtFechaCobro.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaCobro.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dtFechaCobro.Name = "dtFechaCobro"
        Me.dtFechaCobro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtFechaCobro.Size = New System.Drawing.Size(96, 20)
        Me.dtFechaCobro.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Fecha de Cobro"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(224, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(484, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Monto En Letras"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(118, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Monto"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboMoneda
        '
        Me.ComboMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsAdelantos1, "Adelantos.Cod_Moneda"))
        Me.ComboMoneda.DataSource = Me.DsAdelantos1
        Me.ComboMoneda.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMoneda.Enabled = False
        Me.ComboMoneda.ForeColor = System.Drawing.Color.Blue
        Me.ComboMoneda.Location = New System.Drawing.Point(8, 21)
        Me.ComboMoneda.Name = "ComboMoneda"
        Me.ComboMoneda.Size = New System.Drawing.Size(97, 21)
        Me.ComboMoneda.TabIndex = 5
        Me.ComboMoneda.ValueMember = "Moneda.CodMoneda"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(8, 5)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 16)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Moneda"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumero
        '
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.Numero"))
        Me.txtNumero.ForeColor = System.Drawing.Color.Blue
        Me.txtNumero.Location = New System.Drawing.Point(56, 17)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(72, 13)
        Me.txtNumero.TabIndex = 2
        Me.txtNumero.Text = ""
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Location = New System.Drawing.Point(16, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "No.:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=PICHIN" & _
        "GA;persist security info=False;initial catalog=Planilla"
        '
        'adAdelantos
        '
        Me.adAdelantos.DeleteCommand = Me.SqlDeleteCommand1
        Me.adAdelantos.InsertCommand = Me.SqlInsertCommand1
        Me.adAdelantos.SelectCommand = Me.SqlSelectCommand1
        Me.adAdelantos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Adelantos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Adelanto", "Adelanto"), New System.Data.Common.DataColumnMapping("Prestamo", "Prestamo"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("FechaComprobante", "FechaComprobante"), New System.Data.Common.DataColumnMapping("Num_Pago", "Num_Pago"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("MontoEnLetras", "MontoEnLetras"), New System.Data.Common.DataColumnMapping("FechaCobro", "FechaCobro"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("DeducirxPago", "DeducirxPago"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo")})})
        Me.adAdelantos.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Adelantos WHERE (Numero = @Original_Numero) AND (Adelanto = @Original" & _
        "_Adelanto) AND (Anulado = @Original_Anulado) AND (Cod_Moneda = @Original_Cod_Mon" & _
        "eda) AND (DeducirxPago = @Original_DeducirxPago) AND (FechaCobro = @Original_Fec" & _
        "haCobro) AND (FechaComprobante = @Original_FechaComprobante) AND (Identificacion" & _
        " = @Original_Identificacion) AND (Monto = @Original_Monto) AND (MontoEnLetras = " & _
        "@Original_MontoEnLetras) AND (Nombre = @Original_Nombre) AND (NombreUsuario = @O" & _
        "riginal_NombreUsuario) AND (Num_Pago = @Original_Num_Pago) AND (Observaciones = " & _
        "@Original_Observaciones) AND (Prestamo = @Original_Prestamo) AND (Puesto = @Orig" & _
        "inal_Puesto) AND (Salario = @Original_Salario) AND (Saldo = @Original_Saldo OR @" & _
        "Original_Saldo IS NULL AND Saldo IS NULL) AND (Usuario = @Original_Usuario)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Adelanto", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adelanto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DeducirxPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeducirxPago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaCobro", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaCobro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaComprobante", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaComprobante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoEnLetras", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnLetras", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Pago", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Pago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Prestamo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prestamo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Adelantos(Identificacion, Nombre, Adelanto, Prestamo, Puesto, Salario" & _
        ", FechaComprobante, Num_Pago, Monto, MontoEnLetras, FechaCobro, Observaciones, D" & _
        "educirxPago, Usuario, NombreUsuario, Cod_Moneda, Anulado, Saldo) VALUES (@Identi" & _
        "ficacion, @Nombre, @Adelanto, @Prestamo, @Puesto, @Salario, @FechaComprobante, @" & _
        "Num_Pago, @Monto, @MontoEnLetras, @FechaCobro, @Observaciones, @DeducirxPago, @U" & _
        "suario, @NombreUsuario, @Cod_Moneda, @Anulado, @Saldo); SELECT Numero, Identific" & _
        "acion, Nombre, Adelanto, Prestamo, Puesto, Salario, FechaComprobante, Num_Pago, " & _
        "Monto, MontoEnLetras, FechaCobro, Observaciones, DeducirxPago, Usuario, NombreUs" & _
        "uario, Cod_Moneda, Anulado, Saldo FROM Adelantos WHERE (Numero = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Adelanto", System.Data.SqlDbType.Bit, 1, "Adelanto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Prestamo", System.Data.SqlDbType.Bit, 1, "Prestamo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaComprobante", System.Data.SqlDbType.DateTime, 8, "FechaComprobante"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Pago", System.Data.SqlDbType.Int, 4, "Num_Pago"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoEnLetras", System.Data.SqlDbType.VarChar, 250, "MontoEnLetras"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaCobro", System.Data.SqlDbType.DateTime, 8, "FechaCobro"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DeducirxPago", System.Data.SqlDbType.Float, 8, "DeducirxPago"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 50, "Usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 8, "Saldo"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Numero, Identificacion, Nombre, Adelanto, Prestamo, Puesto, Salario, Fecha" & _
        "Comprobante, Num_Pago, Monto, MontoEnLetras, FechaCobro, Observaciones, Deducirx" & _
        "Pago, Usuario, NombreUsuario, Cod_Moneda, Anulado, Saldo FROM Adelantos"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Adelantos SET Identificacion = @Identificacion, Nombre = @Nombre, Adelanto" & _
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
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Adelanto", System.Data.SqlDbType.Bit, 1, "Adelanto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Prestamo", System.Data.SqlDbType.Bit, 1, "Prestamo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaComprobante", System.Data.SqlDbType.DateTime, 8, "FechaComprobante"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Pago", System.Data.SqlDbType.Int, 4, "Num_Pago"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoEnLetras", System.Data.SqlDbType.VarChar, 250, "MontoEnLetras"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaCobro", System.Data.SqlDbType.DateTime, 8, "FechaCobro"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DeducirxPago", System.Data.SqlDbType.Float, 8, "DeducirxPago"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 50, "Usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Saldo", System.Data.SqlDbType.Float, 8, "Saldo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Adelanto", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Adelanto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DeducirxPago", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeducirxPago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaCobro", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaCobro", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaComprobante", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaComprobante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoEnLetras", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnLetras", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Pago", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Pago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Prestamo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prestamo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Saldo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Saldo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero"))
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label36)
        Me.Panel4.Controls.Add(Me.txtUsuario)
        Me.Panel4.Controls.Add(Me.txtNombreUsuario)
        Me.Panel4.Controls.Add(Me.txtCedulaUsuario)
        Me.Panel4.Location = New System.Drawing.Point(432, 288)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(291, 32)
        Me.Panel4.TabIndex = 73
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(-8, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(64, 0)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.Text = ""
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.NombreUsuario"))
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(125, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.txtNombreUsuario.TabIndex = 2
        Me.txtNombreUsuario.Text = ""
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtCedulaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCedulaUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedulaUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAdelantos1, "Adelantos.Usuario"))
        Me.txtCedulaUsuario.Enabled = False
        Me.txtCedulaUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(216, 16)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(72, 13)
        Me.txtCedulaUsuario.TabIndex = 3
        Me.txtCedulaUsuario.Text = ""
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo) VAL" & _
        "UES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simbolo); SELECT Cod" & _
        "Moneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda WHERE (CodMon" & _
        "eda = @CodMoneda)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Moneda SET CodMoneda = @CodMoneda, MonedaNombre = @MonedaNombre, ValorComp" & _
        "ra = @ValorCompra, ValorVenta = @ValorVenta, Simbolo = @Simbolo WHERE (CodMoneda" & _
        " = @Original_CodMoneda) AND (MonedaNombre = @Original_MonedaNombre) AND (Simbolo" & _
        " = @Original_Simbolo) AND (ValorCompra = @Original_ValorCompra) AND (ValorVenta " & _
        "= @Original_ValorVenta); SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta" & _
        ", Simbolo FROM Moneda WHERE (CodMoneda = @CodMoneda)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Moneda WHERE (CodMoneda = @Original_CodMoneda) AND (MonedaNombre = @O" & _
        "riginal_MonedaNombre) AND (Simbolo = @Original_Simbolo) AND (ValorCompra = @Orig" & _
        "inal_ValorCompra) AND (ValorVenta = @Original_ValorVenta)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'adMoneda
        '
        Me.adMoneda.DeleteCommand = Me.SqlDeleteCommand2
        Me.adMoneda.InsertCommand = Me.SqlInsertCommand2
        Me.adMoneda.SelectCommand = Me.SqlSelectCommand2
        Me.adMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.adMoneda.UpdateCommand = Me.SqlUpdateCommand2
        '
        'CheckAnulado
        '
        Me.CheckAnulado.BackColor = System.Drawing.Color.Transparent
        Me.CheckAnulado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsAdelantos1, "Adelantos.Anulado"))
        Me.CheckAnulado.Enabled = False
        Me.CheckAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAnulado.ForeColor = System.Drawing.Color.Red
        Me.CheckAnulado.Location = New System.Drawing.Point(536, 120)
        Me.CheckAnulado.Name = "CheckAnulado"
        Me.CheckAnulado.Size = New System.Drawing.Size(72, 16)
        Me.CheckAnulado.TabIndex = 173
        Me.CheckAnulado.Text = "Anulada"
        '
        'frmAdelantos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 384)
        Me.Controls.Add(Me.CheckAnulado)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNum_Pagos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DtFechaCompro)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAdelantos"
        Me.Text = "Adelantos o Prestamos de Empleados"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.DtFechaCompro, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtNum_Pagos, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txtNumero, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Panel4, 0)
        Me.Controls.SetChildIndex(Me.CheckAnulado, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsAdelantos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmAdelantos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
            Me.DsAdelantos1.Adelantos.IdentificacionColumn.DefaultValue = ""
            Me.DsAdelantos1.Adelantos.NombreColumn.DefaultValue = ""
            Me.DsAdelantos1.Adelantos.AdelantoColumn.DefaultValue = 1
            Me.DsAdelantos1.Adelantos.PrestamoColumn.DefaultValue = 0
            Me.DsAdelantos1.Adelantos.PuestoColumn.DefaultValue = ""
            Me.DsAdelantos1.Adelantos.SalarioColumn.DefaultValue = 0
            Me.DsAdelantos1.Adelantos.FechaComprobanteColumn.DefaultValue = Now
            Me.DsAdelantos1.Adelantos.Num_PagoColumn.DefaultValue = 0
            Me.DsAdelantos1.Adelantos.MontoColumn.DefaultValue = 0
            Me.DsAdelantos1.Adelantos.MontoEnLetrasColumn.DefaultValue = ""
            Me.DsAdelantos1.Adelantos.FechaCobroColumn.DefaultValue = Now
            Me.DsAdelantos1.Adelantos.ObservacionesColumn.DefaultValue = ""
            Me.DsAdelantos1.Adelantos.DeducirxPagoColumn.DefaultValue = 0
            Me.DsAdelantos1.Adelantos.UsuarioColumn.DefaultValue = ""
            Me.DsAdelantos1.Adelantos.NombreUsuarioColumn.DefaultValue = ""
            Me.DsAdelantos1.Adelantos.AnuladoColumn.DefaultValue = 0

            Me.adMoneda.Fill(DsAdelantos1, "Moneda")

            Bloquear()
            ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(4).Enabled = False
            ToolBar1.Buttons(5).Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Bloquear()
        txtNumero.Enabled = False : TxtIdentificacion.Enabled = False
        TxtNombre.Enabled = False : txtPuesto.Enabled = False
        txtSalario.Enabled = False : opAdelanto.Enabled = False
        opPrestamo.Enabled = False : DtFechaCompro.Enabled = False
        txtMonto.Enabled = False : txtMontoLetras.Enabled = False
        dtFechaCobro.Enabled = False : txtObservaciones.Enabled = False
        txtUsuario.Enabled = False : txtNombreUsuario.Enabled = False
        ComboMoneda.Enabled = False
    End Sub

    Private Sub Desbloquear()
        TxtIdentificacion.Enabled = True : opAdelanto.Enabled = True
        opPrestamo.Enabled = True : DtFechaCompro.Enabled = True
        txtMonto.Enabled = True : dtFechaCobro.Enabled = True
        txtObservaciones.Enabled = True : txtUsuario.Enabled = True
        ComboMoneda.Enabled = True
    End Sub

    Private Function Nuevo()
        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            'cambia la imagen de nuevo y desabilita los botones
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Try 'inicia la edicion
                Me.DsAdelantos1.Adelantos.Clear()
                Me.BindingContext(Me.DsAdelantos1, "Adelantos").CancelCurrentEdit()
                Me.BindingContext(Me.DsAdelantos1, "Adelantos").EndCurrentEdit()
                Me.BindingContext(Me.DsAdelantos1, "Adelantos").AddNew()
                Me.ToolBar1.Buttons(1).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = True
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.ToolBar1.Buttons(5).Enabled = False
                Desbloquear()
                TxtIdentificacion.Focus()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                Me.BindingContext(Me.DsAdelantos1, "Adelantos").CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False
                txtNum_Pagos.Visible = False
                txtDeducirxPago.Visible = False
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
            Me.DsAdelantos1.Adelantos.Clear()
            Id = funcion.BuscarDatos("Select Numero, Nombre from Adelantos", "Nombre", "Buscar Adelantos o Préstamos ...")
            buscando = True
            If Id = 0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Function
            End If
            Me.LlenarDeduccion(Id)
            'nuevo
            Me.ToolBar1.Buttons(0).Enabled = True
            'buscar
            Me.ToolBar1.Buttons(1).Enabled = True
            'editar
            Me.ToolBar1.Buttons(2).Enabled = True
            'registrar
            Me.ToolBar1.Buttons(3).Enabled = False
            'eliminar
            If CheckAnulado.Checked = True Then
                Me.ToolBar1.Buttons(4).Enabled = False
            Else
                Me.ToolBar1.Buttons(4).Enabled = True
            End If
            If opAdelanto.Checked = True Then
                txtNum_Pagos.Visible = False
                txtDeducirxPago.Visible = False
            Else
                txtNum_Pagos.Visible = True : txtNum_Pagos.Enabled = False
                txtDeducirxPago.Visible = True : txtDeducirxPago.Enabled = False
            End If
            'Imprimir
            Me.ToolBar1.Buttons(5).Enabled = True
            'Cerrar
            Me.ToolBar1.Buttons(6).Enabled = True
            Bloquear()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
    Function LlenarDeduccion(ByVal Id As Integer)
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
            Dim sel As String = "SELECT * FROM Adelantos WHERE (Numero = @Id_Codigo)"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Codigo", SqlDbType.Int))
            cmdv.Parameters("@Id_Codigo").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DsAdelantos1, "Adelantos")
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

    Function Editar()
        Desbloquear()
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

    Private Function Guardar()
        Dim resp As Integer
        If TxtIdentificacion.Text = "" Then
            MsgBox("Debe ingresar el número de cédula", MsgBoxStyle.Information, "Atención...")
            TxtIdentificacion.Focus()
            Exit Function
        End If
        If txtNombre.Text = "" Then
            MsgBox("Debe de escoger el empleado a realizarle el adelanto o préstamo", MsgBoxStyle.Information, "Atención...")
            TxtIdentificacion.Focus()
            Exit Function
        End If
        If txtMonto.Text <= 0 Then
            MsgBox("El monto debe ser mayor que 0", MsgBoxStyle.Information, "Atención...")
            txtMonto.Focus()
            Exit Function
        End If
        If txtUsuario.Text = "" Or txtNombreUsuario.Text = "" Then
            MsgBox("Debe indicar cual usuario esta haciendo el movimiento", MsgBoxStyle.Information, "Atención...")
            txtUsuario.Focus()
            Exit Function
        End If
        Me.BindingContext(Me.DsAdelantos1, "Adelantos").Current("Saldo") = Me.txtMonto.Text

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            'finaliza la edición
            Me.BindingContext(Me.DsAdelantos1, "Adelantos").EndCurrentEdit()
            Me.adAdelantos.UpdateCommand.Transaction = Trans
            Me.adAdelantos.InsertCommand.Transaction = Trans
            Me.adAdelantos.DeleteCommand.Transaction = Trans

            Me.adAdelantos.Update(Me.DsAdelantos1, "Adelantos")

            Trans.Commit()
            Me.txtUsuario.Text = ""
            Me.txtNombreUsuario.Text = ""
            Me.txtCedulaUsuario.Text = ""
            Me.DsAdelantos1.AcceptChanges()
            MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
            resp = MessageBox.Show("¿Desea Imprimir Reporte?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If resp = 6 Then
                Me.imprimir()
            End If
            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Bloquear()
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
            Me.DsAdelantos1.Adelantos.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Trans.Rollback()
        End Try
    End Function

    'Private Sub eliminar()
    '    Dim Cconexion As New Conexion
    '    Dim Resultado As String
    '    If Me.txtNombre.Text <> "" Then
    '        If MessageBox.Show(" ¿ Desea Eliminar este Adelanto o Préstamo ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub
    '        Resultado = Cconexion.SlqExecute(Cconexion.Conectar, "Delete from Adelantos where Numero=" & Me.txtNumero.Text)
    '        If Resultado = vbNullString Then
    '            MessageBox.Show("El Adelanto o Préstamo fue eliminado", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.DsAdelantos1.Adelantos.Clear()
    '            Bloquear()
    '            'nuevo
    '            Me.ToolBar1.Buttons(0).Enabled = True
    '            'buscar
    '            Me.ToolBar1.Buttons(1).Enabled = True
    '            'editar
    '            Me.ToolBar1.Buttons(2).Enabled = False
    '            'registrar
    '            Me.ToolBar1.Buttons(3).Enabled = False
    '            'eliminar
    '            Me.ToolBar1.Buttons(4).Enabled = False
    '            'imprimir
    '            Me.ToolBar1.Buttons(5).Enabled = True
    '            'Cerrar
    '            Me.ToolBar1.Buttons(6).Enabled = True
    '        Else
    '            MessageBox.Show(Resultado)
    '            Exit Sub
    '        End If
    '    Else
    '        MessageBox.Show("No hay Adelantos o Préstamos a eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub
    Function Anular()
        Try
            Dim resp As Integer
            If Me.BindingContext(Me.DsAdelantos1, "Adelantos").Count > 0 Then
                resp = MessageBox.Show("¿Desea Anular este Adelanto o Préstamo?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    CheckAnulado.Checked = True
                    Me.BindingContext(Me.DsAdelantos1, "Adelantos").EndCurrentEdit()
                    If Registrar_Anulacion() Then
                        Me.DsAdelantos1.AcceptChanges()
                        MsgBox("El Adelanto o Préstamo ha sido anulado correctamente", MsgBoxStyle.Information)
                        Me.DsAdelantos1.Adelantos.Clear()

                        Me.ToolBar1.Buttons(4).Enabled = False
                        Me.ToolBar1.Buttons(1).Enabled = True

                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(0).Enabled = True
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False
                        Me.ToolBar1.Buttons(5).Enabled = False
                    End If

                Else : Exit Function
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function Registrar_Anulacion() As Boolean
        Dim i As Long
        Dim Funciones As New Conexion
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.SqlUpdateCommand1.Transaction = Trans
            Me.adAdelantos.Update(DsAdelantos1, "Adelantos")
            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function imprimir()
        Try
            Dim Imprimir_Adelanto As New ReporteAdelantos
            Dim visor As New frmVisorReportes
            Imprimir_Adelanto.SetParameterValue(0, txtNumero.Text)
            visor.rptViewer.ReportSource = Imprimir_Adelanto
            Planilla.CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Imprimir_Adelanto)
            visor.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Function

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()

            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : Editar()

            Case 4 : If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Delete Then Anular() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 7 : Me.Close()
        End Select

       
    End Sub

    Private Sub TxtIdentificacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtIdentificacion.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            Me.TxtIdentificacion.Text = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Empleado ORDER BY Nombre", "Nombre")
            CargarInformacionEmpleado(TxtIdentificacion.Text)
        End If
        If e.KeyCode = Keys.Enter Then
            CargarInformacionEmpleado(TxtIdentificacion.Text)
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
                    txtPuesto.Text = rs("Puesto")
                    txtSalario.Text = Format(rs("Salario"), "#,#0.00")
                    opAdelanto.Focus()
                Else
                    MsgBox("La identificación del Empleado no se encuentra", MsgBoxStyle.Information, "Atención...")
                    txtNombre.Text = "" : txtPuesto.Text = "" : txtSalario.Text = ""
                    TxtIdentificacion.Focus()
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

    Private Sub opAdelanto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles opAdelanto.Click
        If opAdelanto.Checked = True Then
            txtNum_Pagos.Text = 0 : txtDeducirxPago.Text = 0
            Label5.Visible = False : Label6.Visible = False
            txtNum_Pagos.Visible = False
            txtDeducirxPago.Visible = False
            DtFechaCompro.Focus()
        End If
    End Sub

    Private Sub opPrestamo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles opPrestamo.Click
        If opPrestamo.Checked = True Then
            Label5.Visible = True : Label6.Visible = True
            txtNum_Pagos.Visible = True : txtNum_Pagos.Enabled = True
            txtDeducirxPago.Visible = True
            txtNum_Pagos.Focus()
        End If
    End Sub

    Private Sub txtNum_Pagos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNum_Pagos.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDeducirxPago.Text = Format(txtMonto.Text / txtNum_Pagos.Text, "#,#0.00")
            DtFechaCompro.Focus()
        End If
    End Sub

    Private Sub DtFechaCompro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtFechaCompro.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboMoneda.Focus()
        End If
    End Sub

    Private Sub txtMonto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ComboMoneda.Focus()
        End If
    End Sub

    Private Sub dtFechaCobro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFechaCobro.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtObservaciones.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtUsuario.Focus()
        End If
    End Sub

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        If e.KeyCode = Keys.Enter Then
            If txtUsuario.Text <> "" Then
                'rs = cConexion.GetRecorset(Conectando, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                rs = cConexion.GetRecorset(cConexion.Conectar2, "SELECT Id_Usuario, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Focus()
                End If
                While rs.Read
                    Try
                        txtNombreUsuario.Text = rs("Nombre")
                        'txtCedulaUsuario.Text = rs("Cedula")
                        txtCedulaUsuario.Text = rs("Id_Usuario")
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

    Private Sub ComboMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboMoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMonto.Focus()
        End If
    End Sub

    Private Sub txtMonto_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            MostrarMontoLetras()
            txtDeducirxPago.Text = Format(txtMonto.Text / txtNum_Pagos.Text, "#,#0.00")
            dtFechaCobro.Focus()
        End If
    End Sub
    Function MostrarMontoLetras()
        If Me.ToolBar1.Buttons(0).Text = "Cancelar" Then
            Dim cambio As New cNum2Text
            Me.txtMontoLetras.Text = cambio.Numero2Letra(Me.txtMonto.Text, 0, 2, ComboMoneda.Text, "CENTIMO", cNum2Text.eSexo.Masculino, cNum2Text.eSexo.Masculino)
        End If
    End Function

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class
