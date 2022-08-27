Imports System.IO
Imports System.data.SqlClient
Imports Utilidades

Public Class frmPagoAutomaticoBN
    Inherits FrmPlantilla

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        usua = Usuario_Parametro
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
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCuentaBancaria As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents RB_Nacional As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CostaRica As System.Windows.Forms.RadioButton
    Friend WithEvents AdapterBancos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterCuentas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsPagoAutomatico1 As Planilla.DsPagoAutomatico
    Friend WithEvents txtCedulaAutorizada As System.Windows.Forms.TextBox
    Friend WithEvents LCedula As System.Windows.Forms.Label
    Friend WithEvents LFechaAplicacion As System.Windows.Forms.Label
    Friend WithEvents DTFecha As DevExpress.XtraEditors.DateEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbBanco = New System.Windows.Forms.ComboBox
        Me.DsPagoAutomatico1 = New Planilla.DsPagoAutomatico
        Me.cmbCuentaBancaria = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPlanilla = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNumeroCliente = New System.Windows.Forms.TextBox
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.RB_Nacional = New System.Windows.Forms.RadioButton
        Me.RB_CostaRica = New System.Windows.Forms.RadioButton
        Me.AdapterBancos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterCuentas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.txtCedulaAutorizada = New System.Windows.Forms.TextBox
        Me.LCedula = New System.Windows.Forms.Label
        Me.LFechaAplicacion = New System.Windows.Forms.Label
        Me.DTFecha = New DevExpress.XtraEditors.DateEdit
        CType(Me.DsPagoAutomatico1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarEditar
        '
        Me.ToolBarEditar.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 256)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(368, 56)
        Me.ToolBar1.TabIndex = 6
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(368, 32)
        Me.TituloModulo.Text = "Pago Planilla Automática Bancos"
        '
        'cmbBanco
        '
        Me.cmbBanco.DataSource = Me.DsPagoAutomatico1.Bancos
        Me.cmbBanco.DisplayMember = "Descripcion"
        Me.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBanco.Enabled = False
        Me.cmbBanco.Location = New System.Drawing.Point(16, 232)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(160, 21)
        Me.cmbBanco.TabIndex = 7
        '
        'DsPagoAutomatico1
        '
        Me.DsPagoAutomatico1.DataSetName = "DsPagoAutomatico"
        Me.DsPagoAutomatico1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'cmbCuentaBancaria
        '
        Me.cmbCuentaBancaria.DataSource = Me.DsPagoAutomatico1.Bancos
        Me.cmbCuentaBancaria.DisplayMember = "BancosCuentas_bancarias.Cuenta"
        Me.cmbCuentaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuentaBancaria.Enabled = False
        Me.cmbCuentaBancaria.Location = New System.Drawing.Point(200, 232)
        Me.cmbCuentaBancaria.Name = "cmbCuentaBancaria"
        Me.cmbCuentaBancaria.Size = New System.Drawing.Size(160, 21)
        Me.cmbCuentaBancaria.TabIndex = 8
        Me.cmbCuentaBancaria.ValueMember = "BancosCuentas_bancarias.Id_CuentaBancaria"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Banco:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(200, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cuenta bancaria:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Planilla"
        '
        'txtPlanilla
        '
        Me.txtPlanilla.Enabled = False
        Me.txtPlanilla.Location = New System.Drawing.Point(152, 72)
        Me.txtPlanilla.Name = "txtPlanilla"
        Me.txtPlanilla.ReadOnly = True
        Me.txtPlanilla.Size = New System.Drawing.Size(192, 20)
        Me.txtPlanilla.TabIndex = 2
        Me.txtPlanilla.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Numero de cliente:"
        '
        'txtNumeroCliente
        '
        Me.txtNumeroCliente.Enabled = False
        Me.txtNumeroCliente.Location = New System.Drawing.Point(152, 96)
        Me.txtNumeroCliente.MaxLength = 12
        Me.txtNumeroCliente.Name = "txtNumeroCliente"
        Me.txtNumeroCliente.Size = New System.Drawing.Size(144, 20)
        Me.txtNumeroCliente.TabIndex = 3
        Me.txtNumeroCliente.Text = ""
        '
        'txtConcepto
        '
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Enabled = False
        Me.txtConcepto.Location = New System.Drawing.Point(152, 120)
        Me.txtConcepto.MaxLength = 30
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(192, 20)
        Me.txtConcepto.TabIndex = 4
        Me.txtConcepto.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Concepto:"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.ForeColor = System.Drawing.Color.Blue
        Me.TextBox2.Location = New System.Drawing.Point(192, 296)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(32, 13)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = ""
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label36
        '
        Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(136, 296)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 13)
        Me.Label36.TabIndex = 204
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(224, 296)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(144, 13)
        Me.txtNombreUsuario.TabIndex = 205
        Me.txtNombreUsuario.Text = ""
        '
        'RB_Nacional
        '
        Me.RB_Nacional.Location = New System.Drawing.Point(56, 40)
        Me.RB_Nacional.Name = "RB_Nacional"
        Me.RB_Nacional.Size = New System.Drawing.Size(104, 16)
        Me.RB_Nacional.TabIndex = 0
        Me.RB_Nacional.Text = "Banco Nacional"
        '
        'RB_CostaRica
        '
        Me.RB_CostaRica.Location = New System.Drawing.Point(200, 40)
        Me.RB_CostaRica.Name = "RB_CostaRica"
        Me.RB_CostaRica.Size = New System.Drawing.Size(136, 16)
        Me.RB_CostaRica.TabIndex = 1
        Me.RB_CostaRica.Text = "Banco de Costa Rica"
        '
        'AdapterBancos
        '
        Me.AdapterBancos.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterBancos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bancos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo_banco, Descripcion FROM Bancos"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Bancos"
        '
        'AdapterCuentas
        '
        Me.AdapterCuentas.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterCuentas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_bancarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("tipoCuenta", "tipoCuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Cuenta, Codigo_banco, tipoCuenta, NombreCuenta, Id_CuentaBancaria, Cod_Mon" & _
        "eda FROM Cuentas_bancarias"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'txtCedulaAutorizada
        '
        Me.txtCedulaAutorizada.Location = New System.Drawing.Point(152, 144)
        Me.txtCedulaAutorizada.MaxLength = 12
        Me.txtCedulaAutorizada.Name = "txtCedulaAutorizada"
        Me.txtCedulaAutorizada.Size = New System.Drawing.Size(144, 20)
        Me.txtCedulaAutorizada.TabIndex = 5
        Me.txtCedulaAutorizada.Text = ""
        Me.txtCedulaAutorizada.Visible = False
        '
        'LCedula
        '
        Me.LCedula.Location = New System.Drawing.Point(24, 144)
        Me.LCedula.Name = "LCedula"
        Me.LCedula.Size = New System.Drawing.Size(112, 16)
        Me.LCedula.TabIndex = 209
        Me.LCedula.Text = "Cedula Autorizada:"
        Me.LCedula.Visible = False
        '
        'LFechaAplicacion
        '
        Me.LFechaAplicacion.Location = New System.Drawing.Point(24, 168)
        Me.LFechaAplicacion.Name = "LFechaAplicacion"
        Me.LFechaAplicacion.Size = New System.Drawing.Size(112, 16)
        Me.LFechaAplicacion.TabIndex = 210
        Me.LFechaAplicacion.Text = "Fecha de Aplicación :"
        Me.LFechaAplicacion.Visible = False
        '
        'DTFecha
        '
        Me.DTFecha.EditValue = New Date(2010, 3, 22, 0, 0, 0, 0)
        Me.DTFecha.Location = New System.Drawing.Point(152, 168)
        Me.DTFecha.Name = "DTFecha"
        '
        'DTFecha.Properties
        '
        Me.DTFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DTFecha.Size = New System.Drawing.Size(88, 19)
        Me.DTFecha.TabIndex = 6
        Me.DTFecha.Visible = False
        '
        'frmPagoAutomaticoBN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(368, 312)
        Me.Controls.Add(Me.DTFecha)
        Me.Controls.Add(Me.LFechaAplicacion)
        Me.Controls.Add(Me.txtCedulaAutorizada)
        Me.Controls.Add(Me.LCedula)
        Me.Controls.Add(Me.RB_CostaRica)
        Me.Controls.Add(Me.RB_Nacional)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtNumeroCliente)
        Me.Controls.Add(Me.txtPlanilla)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCuentaBancaria)
        Me.Controls.Add(Me.cmbBanco)
        Me.Name = "frmPagoAutomaticoBN"
        Me.Text = "Pago Planilla Automática Bancos"
        Me.TopMost = True
        Me.Controls.SetChildIndex(Me.cmbBanco, 0)
        Me.Controls.SetChildIndex(Me.cmbCuentaBancaria, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtPlanilla, 0)
        Me.Controls.SetChildIndex(Me.txtNumeroCliente, 0)
        Me.Controls.SetChildIndex(Me.txtConcepto, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.RB_Nacional, 0)
        Me.Controls.SetChildIndex(Me.RB_CostaRica, 0)
        Me.Controls.SetChildIndex(Me.LCedula, 0)
        Me.Controls.SetChildIndex(Me.txtCedulaAutorizada, 0)
        Me.Controls.SetChildIndex(Me.LFechaAplicacion, 0)
        Me.Controls.SetChildIndex(Me.DTFecha, 0)
        CType(Me.DsPagoAutomatico1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim IdPlanilla As Integer 'Id de la planilla que corresponde al pago automático
    Dim IdBancos() As Integer
    Dim IdCuentasBancarias() As Integer
    Dim espacio As String
    Dim usua As Object
    Dim Cedula_usuario As String
    Dim NombreUsuario As String
    'Variable creada para prubas
    Private PruebaData As String
    'Esta variable se utiliza para poder obtener tokens proventientes de un string
    Private Guion As String = "-"
    'Constantes que se utilizan para tener una cantidad exacta en los digitos, Viene ordenado
    'Como comunmente se digitan las cuentas (Producto-moneda-Ofinia-cuenta-verificador)
    Dim CantidadDigitosFormato() As Integer = {3, 2, 3, 6, 1}
    Dim CantidadDigitosFormatoBCR() As Integer = {3, 7, 1}
    Dim IdPlanilla2 As Integer
#End Region

#Region "Funciones GUI"
    Private Sub frmPagoAutomaticoBN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If Me.cmbBanco.Left = -1 Then Exit Sub
        'LlenarCmbCuentaBancaria(IdBancos(cmbBanco.SelectedIndex))
    End Sub

    Private Sub txtPlanilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlanilla.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode <> Keys.F1 Then
            Exit Sub
        End If
        Try
            Dim cnnConexion As New System.Data.SqlClient.SqlConnection
            Dim Fx As New cFunciones
            Dim Id As String
            Dim pos As Integer
            Dim vista As DataView
            cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
            Id = Fx.BuscarDatos("Select Id_Planilla, cast(dbo.DateOnly(FechaInicial) as varchar(11)) + '  -  ' + cast(dbo.DateOnly(FechaFinal) as varchar(11))  AS Periodo  from Planilla", "FechaInicial", "Buscar Planilla...", cnnConexion.ConnectionString, 0, " Order By Id_Planilla DESC")
            If Id = "" Or Id = "0" Then
                Exit Sub
            Else
                IdPlanilla = Id
                IdPlanilla2 = Id
                txtPlanilla.Text = Fx.descripcion
            End If

        Catch ex As SystemException

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtNumeroCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumeroCliente.KeyDown, txtCedulaAutorizada.KeyDown, DTFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBanco.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbCuentaBancaria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCuentaBancaria.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtConcepto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConcepto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCedulaAutorizada.Visible = True Then
                SendKeys.Send("{TAB}")
            Else
                cmbBanco.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Loggin_Usuario() Then
            End If
        End If
    End Sub

    Private Sub txtNumeroCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroCliente.KeyPress
        If Asc(e.KeyChar) = 8 Then
            Exit Sub
        End If

        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub RB_CostaRica_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_CostaRica.CheckedChanged, RB_Nacional.CheckedChanged
        If RB_Nacional.Checked Then
            LCedula.Visible = False : txtCedulaAutorizada.Visible = False
            LFechaAplicacion.Visible = False : DTFecha.Visible = False
            SaveSetting("SeeSOFT", "Planilla", "Banco", "BN")
            txtPlanilla.Focus()
        Else
            LCedula.Visible = True : txtCedulaAutorizada.Visible = True
            LFechaAplicacion.Visible = True : DTFecha.Visible = True
            SaveSetting("SeeSOFT", "Planilla", "Banco", "BCR")
            txtPlanilla.Focus()
        End If
    End Sub

    'Metodo para verificar los datos accedidos por el sistema
    'creado por Javier Rodriguez
    Private Sub SHOWDATA(ByVal dataToShow As String)
        Console.Write(dataToShow & "-" & dataToShow.Length & ControlChars.Tab)
    End Sub
#End Region

#Region "Funciones Cargar"
    Private Sub Cargar()
        SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Bancos", "Conexion")
        AdapterBancos.Fill(DsPagoAutomatico1.Bancos)
        AdapterCuentas.Fill(DsPagoAutomatico1.Cuentas_bancarias)
        DTFecha.EditValue = Now.Date
        IdPlanilla = 1
        espacio = ""
        'LlenarCmbBanco()

        '-----------------------------------------------------------------------
        'VERIFICA EL BANCO A GENERAR LA PLANILLA - ORA
        Try
            If GetSetting("SeeSOFT", "Planilla", "Banco") = "BN" Then
                RB_Nacional.Checked = True
            ElseIf GetSetting("SeeSOFT", "Planilla", "Banco") = "BCR" Then
                RB_CostaRica.Checked = True
            Else
                SaveSetting("SeeSOFT", "Planilla", "Banco", "BN")
                RB_Nacional.Checked = True
            End If
        Catch ex As Exception
            SaveSetting("SeeSOFT", "Planilla", "Banco", "BN")
            RB_Nacional.Checked = True
        End Try
        '-----------------------------------------------------------------------
    End Sub

    Private Sub LlenarCmbBanco()
        Try
            Dim sql As String
            Dim clsConexion As New Conexion
            Dim cnnConexion As New System.Data.SqlClient.SqlConnection
            Dim rstReader As System.Data.SqlClient.SqlDataReader

            cnnConexion.ConnectionString = GetSetting("SeeSoft", "Bancos", "CONEXION")
            cnnConexion.Open()
            sql = "SELECT Codigo_banco,Descripcion FROM Bancos ORDER BY Descripcion"
            rstReader = clsConexion.GetRecorset(cnnConexion, sql)

            Dim n As Integer
            n = 0
            Do While rstReader.Read()
                Me.cmbBanco.Items.Add(RTrim(rstReader("Descripcion")))
                ReDim Preserve IdBancos(n + 1)
                IdBancos(n) = rstReader("Codigo_banco")
                n = n + 1
            Loop

            rstReader.Close()
            cnnConexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LlenarCmbCuentaBancaria(ByVal pIdBanco As Integer)
        Try
            Dim sql As String
            Dim clsConexion As New Conexion
            Dim cnnConexion As New System.Data.SqlClient.SqlConnection
            Dim rstReader As System.Data.SqlClient.SqlDataReader

            cmbCuentaBancaria.Items.Clear()
            cmbCuentaBancaria.Text = ""
            cmbCuentaBancaria.SelectedIndex = -1

            cnnConexion.ConnectionString = GetSetting("SeeSoft", "Bancos", "CONEXION")
            cnnConexion.Open()
            sql = "SELECT Id_CuentaBancaria,Cuenta FROM Cuentas_bancarias WHERE Codigo_banco = " & pIdBanco & " ORDER BY Cuenta"
            rstReader = clsConexion.GetRecorset(cnnConexion, sql)

            Dim n As Integer
            n = 0
            Do While rstReader.Read()
                cmbCuentaBancaria.Items.Add(RTrim(rstReader("Cuenta")))
                ReDim Preserve IdCuentasBancarias(n + 1)
                IdCuentasBancarias(n) = rstReader("Id_CuentaBancaria")
                n = n + 1
            Loop

            rstReader.Close()
            cnnConexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Funciones Generar Archivo BN"

    Private Sub GenerarBN()

        Dim saveFileDialog1 As New SaveFileDialog
        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter

        If ValidarCampos() = False Then Exit Sub

        saveFileDialog1.Filter = "*.env|"
        saveFileDialog1.Title = "Save an File"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName = "" Then
            MsgBox("Elija la dirección del archivo y su nombre", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try

            Dim FilePath As String = saveFileDialog1.FileName & ".env"
            'Se abre el archivo y si este no existe se crea
            strStreamW = File.OpenWrite(FilePath)
            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.ASCII)
            Encabezado(strStreamWriter)
            RegistroDebito(strStreamWriter)

            RegistroCredito(strStreamWriter)

            RegistroControl(strStreamWriter)
            strStreamWriter.Close()
            MsgBox("El archivo se generó con éxito")

        Catch ex As Exception
            strStreamWriter.Close()
            MsgBox(ex.Message)
            Console.WriteLine(ex.StackTrace)
        End Try

    End Sub


    Private Sub Encabezado(ByRef Escribe As StreamWriter)
        'Tipo de registro
        Escribe.Write("1" & espacio)
        'Numero cliente
        Escribe.Write(LlenarEspaciosInicio(txtNumeroCliente.Text, 6, "0") & espacio)
        'FechaTransaccion
        PruebaData = ObtenerFecha()
        Escribe.Write(ObtenerFecha() & espacio)
        'Transferencia real
        Escribe.Write("000001" & espacio)
        'Transferencia interna
        Escribe.Write("000001" & espacio)
        'Tipo transaccion
        Escribe.Write("1" & espacio)
        'Codigo error
        Escribe.Write("0000" & espacio)
        'Total Transferancia
        Escribe.Write(ObtenerMontoDebito() & espacio)
        'Tipo de cambio compra del dia
        Escribe.Write("0000000" & espacio)
        'Tipo de cambio venta del dia
        Escribe.Write("0000000" & espacio)
        'Campo sin uso
        Escribe.Write("0000000000" & espacio)
        Escribe.WriteLine("")
    End Sub

    Private Sub RegistroDebito(ByRef Escribe As StreamWriter)

        Dim cuentabancaria As String
        cuentabancaria = cmbCuentaBancaria.Text

        'Tipo de registro
        Escribe.Write("2" & espacio)
        'OficinaApertura
        Escribe.Write(Mid(cuentabancaria, 8, 3) & espacio)
        'Producto
        Escribe.Write(Mid(cuentabancaria, 1, 3) & espacio)
        'Moneda
        Escribe.Write(Mid(cuentabancaria, 5, 2) & espacio)
        'Numero Cuenta
        Escribe.Write(Mid(cuentabancaria, 12, 6) & espacio)
        'Digito verificador
        Escribe.Write(Mid(cuentabancaria, 19, 1) & espacio)
        'Numero de comprobante
        Escribe.Write("00000001" & espacio)
        'Monto
        Escribe.Write(ObtenerMontoDebito() & espacio)
        'Concepto del pago
        Escribe.Write(LlenarEspaciosFinal(txtConcepto.Text, 30, " ") & espacio)
        'Señal de aplicacion
        Escribe.Write("00" & espacio)
        Escribe.WriteLine("")

    End Sub

    Private Sub RegistroCredito(ByRef Escribe As StreamWriter)

        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        Dim Monto As String
        'Esta constante es para ponerla en caso de que los datos sean erroneos
        Const CuentaError As String = "000000000000000"
        'Variable que se utiliza para poder obtener el numero de cuenta de un usuario
        Dim numeroCuenta As String
        'Esta variable se utiliza para obtener el resultado proveniente de la funcion split
        Dim datosCuenta() As String

        Dim n As Integer = 2

        sql = "SELECT CuentaBancaria,Salarioneto AS SalarioNeto FROM Planilla_Detalle PD , Empleado E " & _
                " WHERE (E.CuentaBancaria <> '') And PD.cedula = E.Identificacion And PD.Id_Planilla = " & IdPlanilla2


        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        Do While rstReader.Read

            Monto = rstReader("SalarioNeto")

            'Tipo de registro
            Escribe.Write("3" & espacio)
            Dim ValorPrueba As String
            numeroCuenta = rstReader("CuentaBancaria")
            'Se utiliza Split para obtener los Tokens provenientes del string de la cuenta
            datosCuenta = Split(numeroCuenta, Guion)
            Dim indiceDatos As Integer
            'Para poder crear una trasaccion los numeros de cuenta del cliente deben ser validos
            'estos provienen de la base de datos, en caso de que no sean validos se establece 
            'una cuenta error la cual son solo 0
            If datosCuenta.Length <> CantidadDigitosFormato.Length Then
                Escribe.Write(CuentaError)
            Else
                'Se escribe primero la oficina segun el formato establecido
                Escribe.Write(LlenarEspaciosInicio(datosCuenta(2), CantidadDigitosFormato(2), "0"))
                For indiceDatos = 0 To CantidadDigitosFormato.Length - 1
                    'Se escriben los demás datos en este ciclo
                    If indiceDatos <> 2 Then
                        Escribe.Write(LlenarEspaciosInicio(datosCuenta(indiceDatos), CantidadDigitosFormato(indiceDatos), "0"))
                    End If
                Next
            End If
            'Numero de comprobante
            Escribe.Write(LlenarEspaciosInicio(n, 8, "0") & espacio)
            'Monto
            Escribe.Write(LlenarEspaciosInicio(PasarDouble_String(Monto), 12, "0") & espacio)
            'Concepto del pago
            Escribe.Write(LlenarEspaciosFinal(txtConcepto.Text, 30, " ") & espacio)
            'Señal de aplicacion
            Escribe.Write("00" & espacio)
            Escribe.WriteLine("")
            Console.WriteLine()
            n = n + 1
        Loop
        rstReader.Close()


    End Sub

    Private Sub RegistroControl(ByRef Escribe As StreamWriter)
        'Tipo de registro
        Escribe.Write("4" & espacio)
        ' Sumatoria de montos ( debito y credito
        Escribe.Write(ObtenerSumatoriaMonto() & espacio)
        'Sumatoria de cuentas
        Escribe.Write(ObtenerSumatoriaCuentas() & espacio)
        'TestKey
        Escribe.Write("0000000000" & espacio)
        'Monto en dolares
        Escribe.Write("000000000000" & espacio)
        'Monto en comisiones
        Escribe.Write("000000000000" & espacio)
        'Campo sin uso
        Escribe.Write("00000000" & espacio)
        Escribe.WriteLine("")
    End Sub

    Private Function ObtenerFecha() As String
        Dim dia, mes As String
        If Date.Now.Day < 10 Then
            dia = "0" & Date.Now.Day
        Else
            dia = Date.Now.Day
        End If
        If Date.Now.Month < 10 Then
            mes = "0" & Date.Now.Month
        Else
            mes = Date.Now.Month
        End If

        ObtenerFecha = dia & mes & Date.Now.Year

    End Function

    Private Function ObtenerSumatoriaMonto() As String

        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        Dim Monto As String
        'Quitar los empleados sin cuenta bancaria
        sql = "SELECT round((SUM(SalarioNeto)*2),2) FROM Planilla_Detalle INNER JOIN Empleado ON Planilla_Detalle.Cedula = Empleado.Identificacion WHERE (Empleado.CuentaBancaria <> '') and Id_Planilla = " & IdPlanilla2

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read = False Then Exit Function

        Monto = rstReader(0)
        Monto = PasarDouble_String(Monto)
        rstReader.Close()
        ObtenerSumatoriaMonto = LlenarEspaciosInicio(Monto, 15, "0")

    End Function

    Private Function ObtenerMontoDebito() As String

        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String

        sql = "SELECT SUM(round(SalarioNeto,2)) As Resultado FROM Planilla_Detalle INNER JOIN Empleado ON Planilla_Detalle.Cedula = Empleado.Identificacion WHERE (Empleado.CuentaBancaria <> '') and Id_Planilla = " & IdPlanilla

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        Dim Monto As String
        If rstReader.Read = False Then
            Monto = "0"
        Else
            Monto = rstReader("Resultado")
            Monto = PasarDouble_String(Monto)
            End If
        rstReader.Close()
        ObtenerMontoDebito = LlenarEspaciosInicio(Monto, 12, "0")
    End Function

    Private Function ObtenerSumatoriaCuentas() As String

        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        Dim cuentabancaria As String
        cuentabancaria = Me.cmbCuentaBancaria.Text

        'Variable que se utilizan para obtener los tokens de cadenas de numeros de una cuenta
        Dim cuentaDigitos() As String


        Dim Monto As Double

        sql = "SELECT CuentaBancaria FROM Planilla_Detalle PD , Empleado E " & _
             " WHERE PD.cedula = E.Identificacion And PD.Id_Planilla = " & IdPlanilla

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        Do While rstReader.Read
            'Se verifica que la cantidad de tokens sea igual a la cantidad exacta de una cuenta
            cuentaDigitos = Split(rstReader("CuentaBancaria"), Guion)
            If cuentaDigitos.Length = CantidadDigitosFormato.Length Then
                'Se obtiene el token 4 que es el de la cuenta
                Monto = Monto + CDbl(cuentaDigitos(3))
            End If
        Loop
        rstReader.Close()

        cuentaDigitos = Split(cmbCuentaBancaria.Text, Guion)
        If cuentaDigitos.Length = CantidadDigitosFormato.Length Then
            Monto = Monto + CDbl(cuentaDigitos(3))
        End If


        ObtenerSumatoriaCuentas = LlenarEspaciosInicio(Monto, 10, "0")

    End Function

    Private Function LlenarEspaciosInicio(ByVal pString As String, ByVal pLongitud As Integer, ByVal pCaracter As String)

        Dim n As Integer

        For n = pString.Length To pLongitud - 1
            pString = pCaracter & pString
        Next

        LlenarEspaciosInicio = pString
    End Function

    Private Function LlenarEspaciosFinal(ByVal pString As String, ByVal pLongitud As Integer, ByVal pCaracter As String)

        Dim n As Integer

        For n = pString.Length To pLongitud - 1
            pString = pString & pCaracter
        Next

        LlenarEspaciosFinal = pString.Substring(0, pLongitud)
    End Function

    Private Function PasarDouble_String(ByVal pString As String) As String

        Dim posicion As String = -1
        posicion = pString.IndexOf(".")
        If posicion <> -1 Then
            If posicion + 2 = pString.Length Then
                pString = pString + "0"
            End If
            pString = Mid(pString, 1, posicion) & Mid(pString, posicion + 2, 2)
        Else
            pString = pString + "00"
        End If
        PasarDouble_String = pString
    End Function

#End Region

#Region "Funciones Generar Archivo BCR"
    Private Sub GenerarBCR()
        If ValidarCampos() = False Then Exit Sub

        Dim saveFileDialog1 As New SaveFileDialog
        saveFileDialog1.Filter = "*.txt|"
        saveFileDialog1.Title = "Save an File"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName = "" Then
            MsgBox("Elija la dirección del archivo y su nombre", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim strStreamW As Stream
        Dim strStreamWriter As StreamWriter

        Try
            Dim FilePath As String = saveFileDialog1.FileName & ".txt"
            
            'Se abre el archivo y si este no existe se crea
            strStreamW = File.OpenWrite(FilePath)

            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.ASCII)

            EncabezadoBCR(strStreamWriter)
            RegistroDebitoBCR(strStreamWriter)

            'For i As Integer = 1 To 20
            'IdPlanilla = i
            RegistroCreditoBCR(strStreamWriter)
            strStreamWriter.WriteLine()
            'Next

            'RegistroControl(strStreamWriter)
            strStreamWriter.Close()
            MsgBox("El archivo se generó con éxito")

        Catch ex As Exception
            strStreamWriter.Close()
            MsgBox(ex.Message)
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub EncabezadoBCR(ByRef Escribe As StreamWriter)
        'Tipo de registro
        Escribe.Write("000")
        'Numero cliente
        Escribe.Write(LlenarEspaciosInicio(txtNumeroCliente.Text, 12, "0"))
        'Numero de Archivo
        Escribe.Write("001")
        'Filler
        Escribe.Write("000000")
        'Cedula de funcionario autorizado
        Escribe.Write(LlenarEspaciosInicio(txtCedulaAutorizada.Text, 12, "0"))
        'TestKey
        Escribe.Write(TestKey())
        'Hora
        Escribe.Write("000000")
        'FechaTransaccion
        Escribe.Write(Format(DTFecha.EditValue, "ddMMyyyy"))
        'Filler
        Escribe.Write("                     ")
        'Señal Y2K
        Escribe.Write("Y")
        'Pasa de Linea
        Escribe.WriteLine("")
    End Sub

    Private Sub RegistroDebitoBCR(ByRef Escribe As StreamWriter)
        Try
            Dim cuentabancaria As String
            Dim datosCuenta() As String

            cuentabancaria = cmbCuentaBancaria.Text
            datosCuenta = Split(cuentabancaria, Guion)

            'INICIO
            Escribe.Write("000")
            'TIPO DE CUENTA
            If BindingContext(DsPagoAutomatico1, "Cuentas_bancarias").Current("Tipocuenta") = "CORRIENTE" Then
                Escribe.Write("1")
            Else
                Escribe.Write("2")
            End If
            'FILLER
            Escribe.Write("00000")
            'OFICINA
            Escribe.Write(LlenarEspaciosInicio(datosCuenta(0), CantidadDigitosFormatoBCR(0), "0"))
            'NUMERO DE CUENTA
            Escribe.Write(LlenarEspaciosInicio(datosCuenta(1), CantidadDigitosFormatoBCR(1), "0"))
            'DIGITO DE LA CUENTA
            Escribe.Write(LlenarEspaciosInicio(datosCuenta(2), CantidadDigitosFormatoBCR(2), "0"))
            'CODIGO DE MONEDA
            Escribe.Write(BindingContext(DsPagoAutomatico1, "Cuentas_bancarias").Current("Cod_Moneda"))
            'TIPO DE TRANSACCION
            Escribe.Write("4")
            'CAUSA
            Escribe.Write("0000")
            'NUMERO DE DOCUMENTO
            Escribe.Write(LlenarEspaciosInicio(IdPlanilla, 8, "0"))
            'MONTO
            Escribe.Write(ObtenerMontoDebito())
            'FECHA
            Escribe.Write(Format(DTFecha.EditValue, "ddMMyyyy"))
            'FILLER
            Escribe.Write("0")
            'CONCEPTO
            Escribe.Write(LlenarEspaciosFinal(txtConcepto.Text, 30, " "))
            'PASA DE LINEA
            Escribe.WriteLine("")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RegistroCreditoBCR(ByRef Escribe As StreamWriter)
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        Dim Monto As String
        'Esta constante es para ponerla en caso de que los datos sean erroneos
        Const CuentaError As String = "00000000000"
        'Variable que se utiliza para poder obtener el numero de cuenta de un usuario
        Dim numeroCuenta As String
        'Esta variable se utiliza para obtener el resultado proveniente de la funcion split
        Dim datosCuenta() As String

        Dim n As Integer = 1

        sql = "SELECT CuentaBancaria,Salarioneto AS SalarioNeto FROM Planilla_Detalle PD , Empleado E " & _
                " WHERE PD.cedula = E.Identificacion And PD.Id_Planilla = " & IdPlanilla

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        While rstReader.Read
            Monto = rstReader("SalarioNeto")
            'INICIO
            Escribe.Write("000")
            'TIPO DE CUENTA*********
            Escribe.Write("1")
            'FILLER
            Escribe.Write("00000")

            numeroCuenta = rstReader("CuentaBancaria")
            'Se utiliza Split para obtener los Tokens provenientes del string de la cuenta
            datosCuenta = Split(numeroCuenta, Guion)
            Dim indiceDatos As Integer
            'Para poder crear una trasaccion los numeros de cuenta del cliente deben ser validos
            'estos provienen de la base de datos, en caso de que no sean validos se establece 
            'una cuenta error la cual son solo 0
            If datosCuenta.Length <> CantidadDigitosFormatoBCR.Length Then
                Escribe.Write(CuentaError)
            Else
                'Se escribe primero la oficina segun el formato establecido
                For indiceDatos = 0 To CantidadDigitosFormatoBCR.Length - 1
                    'Se escriben los demás datos en este ciclo
                    Escribe.Write(LlenarEspaciosInicio(datosCuenta(indiceDatos), CantidadDigitosFormatoBCR(indiceDatos), "0"))
                Next
            End If
            'MONEDA
            Escribe.Write("1")
            'TIPO DE TRANSACCION
            Escribe.Write("2")
            'CAUSA
            Escribe.Write("0000")
            'NUMERO DE DOCUMENTO
            Escribe.Write(LlenarEspaciosInicio(n, 8, "0"))
            'MONTO
            Escribe.Write(LlenarEspaciosInicio(PasarDouble_String(Monto), 12, "0"))
            'FECHA
            Escribe.Write(Format(DTFecha.EditValue, "ddMMyyyy"))
            'FILLER
            Escribe.Write("0")
            'CONCEPTO DE PAGO
            Escribe.Write(LlenarEspaciosFinal(txtPlanilla.Text, 30, " "))
            Escribe.WriteLine("")
            n += 1
        End While

        rstReader.Close()
    End Sub

    Function TestKey() As String
        Try
            Dim TestKey1, TestKey2 As Int64
            Dim cuentabancaria, TestK As String
            Dim datosCuenta() As String
            cuentabancaria = cmbCuentaBancaria.Text
            DsPagoAutomatico1.TestKey.Clear()

            'DEBITO
            datosCuenta = Split(cuentabancaria, Guion)
            BindingContext(DsPagoAutomatico1, "TestKey").AddNew()
            BindingContext(DsPagoAutomatico1, "TestKey").Current("Oficina") = LlenarEspaciosInicio(datosCuenta(0), CantidadDigitosFormatoBCR(0), "0")
            BindingContext(DsPagoAutomatico1, "TestKey").Current("Cuenta") = LlenarEspaciosInicio(datosCuenta(1), CantidadDigitosFormatoBCR(1), "0")
            BindingContext(DsPagoAutomatico1, "TestKey").Current("Monto") = ObtenerMontoDebito()
            BindingContext(DsPagoAutomatico1, "TestKey").EndCurrentEdit()

            'CREDITO
            LlenarCreditoTestKey()

            For i As Integer = 0 To DsPagoAutomatico1.TestKey.Count - 1
                TestKey1 += (CLng(DsPagoAutomatico1.TestKey(i).Oficina) + CLng(DsPagoAutomatico1.TestKey(i).Cuenta))
                If DsPagoAutomatico1.TestKey(i).Monto > 1 Then
                    TestKey2 += CLng(CLng(DsPagoAutomatico1.TestKey(i).Oficina + DsPagoAutomatico1.TestKey(i).Cuenta) / CDbl(DsPagoAutomatico1.TestKey(i).Monto))
                Else
                    TestKey2 += CLng(CLng(DsPagoAutomatico1.TestKey(i).Oficina + DsPagoAutomatico1.TestKey(i).Cuenta) / 1)
                End If
            Next

            TestK = CLng(TestKey1 + TestKey2)
            If TestK.Length > 12 Then
                TestK.Substring(TestK.Length - 12)
            ElseIf TestK.Length < 12 Then
                TestK = LlenarEspaciosInicio(TestK, 12, 0)
            End If

            Return TestK

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Private Sub LlenarCreditoTestKey()
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        Dim datosCuenta() As String
        Dim numeroCuenta As String

        sql = "SELECT CuentaBancaria,Salarioneto AS SalarioNeto FROM Planilla_Detalle PD , Empleado E " & _
                " WHERE PD.cedula = E.Identificacion And PD.Id_Planilla = " & IdPlanilla

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        While rstReader.Read
            BindingContext(DsPagoAutomatico1, "TestKey").AddNew()
            numeroCuenta = rstReader("CuentaBancaria")
            datosCuenta = Split(numeroCuenta, Guion)
            BindingContext(DsPagoAutomatico1, "TestKey").Current("Oficina") = LlenarEspaciosInicio(datosCuenta(0), CantidadDigitosFormatoBCR(0), "0")
            BindingContext(DsPagoAutomatico1, "TestKey").Current("Cuenta") = LlenarEspaciosInicio(datosCuenta(1), CantidadDigitosFormatoBCR(1), "0")
            BindingContext(DsPagoAutomatico1, "TestKey").Current("Monto") = rstReader("SalarioNeto")
            BindingContext(DsPagoAutomatico1, "TestKey").EndCurrentEdit()
        End While
    End Sub
#End Region

#Region "Funciones Validar"
    Private Function ValidarCampos() As Boolean

        If txtPlanilla.Text = "" Then
            MensajeError(txtPlanilla, "Especifique la planillad")
            Exit Function
        End If

        If txtNumeroCliente.Text = "" Then
            MensajeError(txtNumeroCliente, "Especifique el número de cliente")
            Exit Function
        End If

        If txtConcepto.Text = "" Then
            MensajeError(txtConcepto, "Especifique el concepto de la transacción")
            Exit Function
        End If

        If cmbCuentaBancaria.SelectedIndex = -1 Then
            MensajeError(Me.cmbCuentaBancaria, "Elija una cuenta del banco nacional")
            Exit Function
        End If

        Dim cuentabancaria As String

        cuentabancaria = cmbCuentaBancaria.Text

        'If cuentabancaria.Length = 0 Or cuentabancaria.Length <> 19 Then
        '    MensajeError(Me.cmbCuentaBancaria, "El formato de cuenta no corresponde a la de una cuenta del BN")
        '    Exit Function
        'End If

        Try
            'Dim valor As Double

            'valor = CDbl(Mid(cuentabancaria, 1, 3))
            'If valor < 1 Then
            '    MensajeError(Me.cmbCuentaBancaria, "El formato de cuenta no corresponde a la de una cuenta del BN")
            '    Exit Function
            'End If

            'valor = CDbl(Mid(cuentabancaria, 5, 2))
            'If valor < 1 Then
            '    MensajeError(Me.cmbCuentaBancaria, "El formato de cuenta no corresponde a la de una cuenta del BN")
            '    Exit Function
            'End If

            'valor = CDbl(Mid(cuentabancaria, 12, 6))
            'If valor < 1 Then
            '    MensajeError(Me.cmbCuentaBancaria, "El formato de cuenta no corresponde a la de una cuenta del BN")
            '    Exit Function
            'End If

            'valor = CDbl(Mid(cuentabancaria, 19, 1))
            'If valor < 1 Then
            '    MensajeError(Me.cmbCuentaBancaria, "El formato de cuenta no corresponde a la de una cuenta del BN")
            '    Exit Function
            'End If

        Catch ex As Exception
            MensajeError(Me.cmbCuentaBancaria, "El formato de cuenta no corresponde a la de una cuenta del BN")
            Exit Function
        End Try
        ValidarCampos = True
    End Function

    Private Sub MensajeError(ByRef pObjetoGui As Object, ByVal pMensaje As String)
        pObjetoGui.focus()
        MsgBox(pMensaje, MsgBoxStyle.Information)
    End Sub
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(Usuario.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 4
                If PMU.Update Then
                    If RB_Nacional.Checked Then
                        GenerarBN()
                    ElseIf RB_CostaRica.Checked Then
                        GenerarBCR()
                    End If
                Else
                    MsgBox("No tiene permiso para generar pagos automáticos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                End If

            Case 7 : If MessageBox.Show("¿Desea Cerrar el Módulo de Planilla?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Close()
                End If
        End Select
    End Sub
#End Region

#Region "Validar Usuario"
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
                        Me.ToolBarRegistrar.Enabled = True
                        Me.txtPlanilla.Enabled = True
                        Me.txtNumeroCliente.Enabled = True
                        Me.txtConcepto.Enabled = True
                        Me.cmbCuentaBancaria.Enabled = True
                        Me.cmbBanco.Enabled = True
                        Me.txtPlanilla.Focus()
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

    Private Sub txtPlanilla_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPlanilla.TextChanged

    End Sub
End Class
