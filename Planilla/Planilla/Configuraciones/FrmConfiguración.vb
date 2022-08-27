Imports System.Data.SqlClient
Public Class FrmConfiguración
    Inherits System.Windows.Forms.Form
    Private sqlConexion As SqlConnection
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents VTTel2 As ValidText.ValidText
    Friend WithEvents VTFax2 As ValidText.ValidText
    Friend WithEvents VTFax1 As ValidText.ValidText
    Friend WithEvents VTTel1 As ValidText.ValidText
    Friend WithEvents TxtFrase As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCedula As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtInteres As System.Windows.Forms.TextBox
    Friend WithEvents TxtCajeros As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents TxtImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents pictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaConfiguracion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsConfiguracion As DsConfiguracion
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConfiguración))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.DsConfiguracion = New Planilla.DsConfiguracion
        Me.Label20 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.VTTel2 = New ValidText.ValidText
        Me.VTFax2 = New ValidText.ValidText
        Me.VTFax1 = New ValidText.ValidText
        Me.VTTel1 = New ValidText.ValidText
        Me.TxtFrase = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCedula = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtEmpresa = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.TxtCajeros = New System.Windows.Forms.TextBox
        Me.TxtInteres = New System.Windows.Forms.TextBox
        Me.TxtImpuesto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DaConfiguracion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DsConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(408, 320)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(400, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Empresas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TxtDireccion)
        Me.GroupBox2.Controls.Add(Me.VTTel2)
        Me.GroupBox2.Controls.Add(Me.VTFax2)
        Me.GroupBox2.Controls.Add(Me.VTFax1)
        Me.GroupBox2.Controls.Add(Me.VTTel1)
        Me.GroupBox2.Controls.Add(Me.TxtFrase)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtCedula)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtEmpresa)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 288)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'TextBox8
        '
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.PersonaJuridica"))
        Me.TextBox8.Location = New System.Drawing.Point(12, 61)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(376, 20)
        Me.TextBox8.TabIndex = 3
        Me.TextBox8.Text = ""
        '
        'DsConfiguracion
        '
        Me.DsConfiguracion.DataSetName = "DsConfiguracion"
        Me.DsConfiguracion.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(12, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(376, 16)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Nombre Comercial"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(213, 261)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(176, 20)
        Me.TextBox5.TabIndex = 23
        Me.TextBox5.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(15, 261)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(176, 20)
        Me.TextBox4.TabIndex = 21
        Me.TextBox4.Text = ""
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(213, 245)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(176, 16)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Cuenta Bancaria 2:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(15, 245)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(176, 16)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Cuenta Bancaria 1:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBox3.Location = New System.Drawing.Point(212, 219)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(176, 20)
        Me.TextBox3.TabIndex = 19
        Me.TextBox3.Text = ""
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(212, 204)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(176, 16)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Dirreción Web:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(14, 220)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 20)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.Text = ""
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(14, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 16)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Email:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDireccion
        '
        Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDireccion.Location = New System.Drawing.Point(13, 180)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(376, 20)
        Me.TxtDireccion.TabIndex = 15
        Me.TxtDireccion.Text = ""
        '
        'VTTel2
        '
        Me.VTTel2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VTTel2.FieldReference = Nothing
        Me.VTTel2.Location = New System.Drawing.Point(317, 100)
        Me.VTTel2.MaskEdit = ""
        Me.VTTel2.Name = "VTTel2"
        Me.VTTel2.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.VTTel2.Required = False
        Me.VTTel2.ShowErrorIcon = False
        Me.VTTel2.Size = New System.Drawing.Size(72, 20)
        Me.VTTel2.TabIndex = 8
        Me.VTTel2.Text = ""
        Me.VTTel2.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.VTTel2.ValidText = ""
        '
        'VTFax2
        '
        Me.VTFax2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VTFax2.FieldReference = Nothing
        Me.VTFax2.Location = New System.Drawing.Point(316, 140)
        Me.VTFax2.MaskEdit = ""
        Me.VTFax2.Name = "VTFax2"
        Me.VTFax2.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.VTFax2.Required = False
        Me.VTFax2.ShowErrorIcon = False
        Me.VTFax2.Size = New System.Drawing.Size(72, 20)
        Me.VTFax2.TabIndex = 13
        Me.VTFax2.Text = ""
        Me.VTFax2.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.VTFax2.ValidText = ""
        '
        'VTFax1
        '
        Me.VTFax1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VTFax1.FieldReference = Nothing
        Me.VTFax1.Location = New System.Drawing.Point(229, 140)
        Me.VTFax1.MaskEdit = ""
        Me.VTFax1.Name = "VTFax1"
        Me.VTFax1.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.VTFax1.Required = False
        Me.VTFax1.ShowErrorIcon = False
        Me.VTFax1.Size = New System.Drawing.Size(76, 20)
        Me.VTFax1.TabIndex = 12
        Me.VTFax1.Text = ""
        Me.VTFax1.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.VTFax1.ValidText = ""
        '
        'VTTel1
        '
        Me.VTTel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VTTel1.FieldReference = Nothing
        Me.VTTel1.Location = New System.Drawing.Point(229, 100)
        Me.VTTel1.MaskEdit = ""
        Me.VTTel1.Name = "VTTel1"
        Me.VTTel1.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.VTTel1.Required = False
        Me.VTTel1.ShowErrorIcon = False
        Me.VTTel1.Size = New System.Drawing.Size(72, 20)
        Me.VTTel1.TabIndex = 7
        Me.VTTel1.Text = ""
        Me.VTTel1.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.VTTel1.ValidText = ""
        '
        'TxtFrase
        '
        Me.TxtFrase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFrase.Location = New System.Drawing.Point(13, 140)
        Me.TxtFrase.Name = "TxtFrase"
        Me.TxtFrase.Size = New System.Drawing.Size(176, 20)
        Me.TxtFrase.TabIndex = 10
        Me.TxtFrase.Text = ""
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(13, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(376, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Dirección"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(229, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fax (es)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(13, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Frase Publicitaria"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCedula
        '
        Me.TxtCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCedula.Location = New System.Drawing.Point(13, 100)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(176, 20)
        Me.TxtCedula.TabIndex = 5
        Me.TxtCedula.Text = ""
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(229, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Teléfono (s)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(13, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cédula Jurídica"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtEmpresa
        '
        Me.TxtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEmpresa.Location = New System.Drawing.Point(13, 24)
        Me.TxtEmpresa.Name = "TxtEmpresa"
        Me.TxtEmpresa.Size = New System.Drawing.Size(376, 20)
        Me.TxtEmpresa.TabIndex = 1
        Me.TxtEmpresa.Text = ""
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(13, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Persona Jurídica"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(400, 294)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Valores"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.pictureEdit1)
        Me.GroupBox1.Controls.Add(Me.TxtCajeros)
        Me.GroupBox1.Controls.Add(Me.TxtInteres)
        Me.GroupBox1.Controls.Add(Me.TxtImpuesto)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.CantidadHabitaciones"))
        Me.TextBox10.Enabled = False
        Me.TextBox10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox10.Location = New System.Drawing.Point(120, 213)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(128, 20)
        Me.TextBox10.TabIndex = 19
        Me.TextBox10.Text = "0.00"
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Location = New System.Drawing.Point(120, 197)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 16)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Cantidad Habitaciones"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox6
        '
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox6.Location = New System.Drawing.Point(263, 126)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(128, 20)
        Me.TextBox6.TabIndex = 12
        Me.TextBox6.Text = "0.00"
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(264, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 16)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Máximo % Descuento"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox3
        '
        Me.CheckBox3.Location = New System.Drawing.Point(312, 176)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(80, 16)
        Me.CheckBox3.TabIndex = 16
        Me.CheckBox3.Text = "Restaurant"
        Me.CheckBox3.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(224, 176)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox2.TabIndex = 15
        Me.CheckBox2.Text = "Servicios"
        Me.CheckBox2.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(120, 176)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Habitaciones"
        Me.CheckBox1.Visible = False
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(120, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(272, 16)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Pago Comisiones"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label15.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(168, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Días"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(120, 128)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown1.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(120, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Política cancelación"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.Location = New System.Drawing.Point(264, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(264, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Impuesto ICT"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureEdit1
        '
        Me.pictureEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureEdit1.Location = New System.Drawing.Point(8, 16)
        Me.pictureEdit1.Name = "pictureEdit1"
        Me.pictureEdit1.Size = New System.Drawing.Size(104, 88)
        Me.pictureEdit1.TabIndex = 17
        '
        'TxtCajeros
        '
        Me.TxtCajeros.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TxtCajeros.Location = New System.Drawing.Point(120, 80)
        Me.TxtCajeros.Name = "TxtCajeros"
        Me.TxtCajeros.Size = New System.Drawing.Size(128, 20)
        Me.TxtCajeros.TabIndex = 5
        Me.TxtCajeros.Text = "0.00"
        '
        'TxtInteres
        '
        Me.TxtInteres.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TxtInteres.Location = New System.Drawing.Point(264, 32)
        Me.TxtInteres.Name = "TxtInteres"
        Me.TxtInteres.Size = New System.Drawing.Size(128, 20)
        Me.TxtInteres.TabIndex = 3
        Me.TxtInteres.Text = "0.00"
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TxtImpuesto.Location = New System.Drawing.Point(120, 32)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.Size = New System.Drawing.Size(128, 20)
        Me.TxtImpuesto.TabIndex = 1
        Me.TxtImpuesto.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(120, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Propina Salonero"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(264, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Intereses"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(120, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Impuesto Venta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(400, 294)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sistema"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 232)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'TextBox7
        '
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox7.Location = New System.Drawing.Point(13, 31)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(360, 20)
        Me.TextBox7.TabIndex = 12
        Me.TextBox7.Text = ""
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(13, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(360, 16)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Impresora Facturación"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarRegistrar, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 330)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(408, 52)
        Me.ToolBar1.TabIndex = 61
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=LUIFER;packet size=4096;integrated security=SSPI;initial catalog=H" & _
        "otel;persist security info=False"
        '
        'DaConfiguracion
        '
        Me.DaConfiguracion.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaConfiguracion.InsertCommand = Me.SqlInsertCommand1
        Me.DaConfiguracion.SelectCommand = Me.SqlSelectCommand1
        Me.DaConfiguracion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "configuraciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Empresa", "Empresa"), New System.Data.Common.DataColumnMapping("Tel_01", "Tel_01"), New System.Data.Common.DataColumnMapping("Tel_02", "Tel_02"), New System.Data.Common.DataColumnMapping("Fax_01", "Fax_01"), New System.Data.Common.DataColumnMapping("Fax_02", "Fax_02"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Frase", "Frase"), New System.Data.Common.DataColumnMapping("Imp_Servicio", "Imp_Servicio"), New System.Data.Common.DataColumnMapping("Logo", "Logo"), New System.Data.Common.DataColumnMapping("Intereses", "Intereses"), New System.Data.Common.DataColumnMapping("Imp_ICT", "Imp_ICT"), New System.Data.Common.DataColumnMapping("Total_Dias_Cancelar", "Total_Dias_Cancelar"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Dirrecion_Web", "Dirrecion_Web"), New System.Data.Common.DataColumnMapping("Comision_Habitaciones", "Comision_Habitaciones"), New System.Data.Common.DataColumnMapping("Comision_Servicio", "Comision_Servicio"), New System.Data.Common.DataColumnMapping("Comision_Restaurant", "Comision_Restaurant"), New System.Data.Common.DataColumnMapping("Cuenta_Bancaria1", "Cuenta_Bancaria1"), New System.Data.Common.DataColumnMapping("Cuenta_Bancaria2", "Cuenta_Bancaria2"), New System.Data.Common.DataColumnMapping("Impresora_Facturacion", "Impresora_Facturacion"), New System.Data.Common.DataColumnMapping("Maximo_Descuento", "Maximo_Descuento"), New System.Data.Common.DataColumnMapping("PersonaJuridica", "PersonaJuridica"), New System.Data.Common.DataColumnMapping("CantidadHabitaciones", "CantidadHabitaciones")})})
        Me.DaConfiguracion.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM configuraciones WHERE (Cedula = @Original_Cedula) AND (CantidadHabita" & _
        "ciones = @Original_CantidadHabitaciones) AND (Comision_Habitaciones = @Original_" & _
        "Comision_Habitaciones) AND (Comision_Restaurant = @Original_Comision_Restaurant)" & _
        " AND (Comision_Servicio = @Original_Comision_Servicio) AND (Cuenta_Bancaria1 = @" & _
        "Original_Cuenta_Bancaria1 OR @Original_Cuenta_Bancaria1 IS NULL AND Cuenta_Banca" & _
        "ria1 IS NULL) AND (Cuenta_Bancaria2 = @Original_Cuenta_Bancaria2 OR @Original_Cu" & _
        "enta_Bancaria2 IS NULL AND Cuenta_Bancaria2 IS NULL) AND (Direccion = @Original_" & _
        "Direccion) AND (Dirrecion_Web = @Original_Dirrecion_Web OR @Original_Dirrecion_W" & _
        "eb IS NULL AND Dirrecion_Web IS NULL) AND (Email = @Original_Email OR @Original_" & _
        "Email IS NULL AND Email IS NULL) AND (Empresa = @Original_Empresa) AND (Fax_01 =" & _
        " @Original_Fax_01 OR @Original_Fax_01 IS NULL AND Fax_01 IS NULL) AND (Fax_02 = " & _
        "@Original_Fax_02 OR @Original_Fax_02 IS NULL AND Fax_02 IS NULL) AND (Frase = @O" & _
        "riginal_Frase OR @Original_Frase IS NULL AND Frase IS NULL) AND (Imp_ICT = @Orig" & _
        "inal_Imp_ICT OR @Original_Imp_ICT IS NULL AND Imp_ICT IS NULL) AND (Imp_Servicio" & _
        " = @Original_Imp_Servicio) AND (Imp_Venta = @Original_Imp_Venta) AND (Impresora_" & _
        "Facturacion = @Original_Impresora_Facturacion OR @Original_Impresora_Facturacion" & _
        " IS NULL AND Impresora_Facturacion IS NULL) AND (Intereses = @Original_Intereses" & _
        ") AND (Maximo_Descuento = @Original_Maximo_Descuento OR @Original_Maximo_Descuen" & _
        "to IS NULL AND Maximo_Descuento IS NULL) AND (PersonaJuridica = @Original_Person" & _
        "aJuridica OR @Original_PersonaJuridica IS NULL AND PersonaJuridica IS NULL) AND " & _
        "(Tel_01 = @Original_Tel_01) AND (Tel_02 = @Original_Tel_02 OR @Original_Tel_02 I" & _
        "S NULL AND Tel_02 IS NULL) AND (Total_Dias_Cancelar = @Original_Total_Dias_Cance" & _
        "lar)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CantidadHabitaciones", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CantidadHabitaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Comision_Habitaciones", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comision_Habitaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Comision_Restaurant", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comision_Restaurant", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Comision_Servicio", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comision_Servicio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta_Bancaria1", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta_Bancaria1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta_Bancaria2", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta_Bancaria2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Dirrecion_Web", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dirrecion_Web", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Empresa", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Empresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fax_01", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fax_02", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Frase", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Frase", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imp_ICT", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_ICT", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imp_Servicio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Servicio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Impresora_Facturacion", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impresora_Facturacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Intereses", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Intereses", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Maximo_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Maximo_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PersonaJuridica", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PersonaJuridica", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tel_01", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tel_02", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total_Dias_Cancelar", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total_Dias_Cancelar", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO configuraciones(Cedula, Empresa, Tel_01, Tel_02, Fax_01, Fax_02, Dire" & _
        "ccion, Imp_Venta, Frase, Imp_Servicio, Logo, Intereses, Imp_ICT, Total_Dias_Canc" & _
        "elar, Email, Dirrecion_Web, Comision_Habitaciones, Comision_Servicio, Comision_R" & _
        "estaurant, Cuenta_Bancaria1, Cuenta_Bancaria2, Impresora_Facturacion, Maximo_Des" & _
        "cuento, PersonaJuridica, CantidadHabitaciones) VALUES (@Cedula, @Empresa, @Tel_0" & _
        "1, @Tel_02, @Fax_01, @Fax_02, @Direccion, @Imp_Venta, @Frase, @Imp_Servicio, @Lo" & _
        "go, @Intereses, @Imp_ICT, @Total_Dias_Cancelar, @Email, @Dirrecion_Web, @Comisio" & _
        "n_Habitaciones, @Comision_Servicio, @Comision_Restaurant, @Cuenta_Bancaria1, @Cu" & _
        "enta_Bancaria2, @Impresora_Facturacion, @Maximo_Descuento, @PersonaJuridica, @Ca" & _
        "ntidadHabitaciones); SELECT Cedula, Empresa, Tel_01, Tel_02, Fax_01, Fax_02, Dir" & _
        "eccion, Imp_Venta, Frase, Imp_Servicio, Logo, Intereses, Imp_ICT, Total_Dias_Can" & _
        "celar, Email, Dirrecion_Web, Comision_Habitaciones, Comision_Servicio, Comision_" & _
        "Restaurant, Cuenta_Bancaria1, Cuenta_Bancaria2, Impresora_Facturacion, Maximo_De" & _
        "scuento, PersonaJuridica, CantidadHabitaciones FROM configuraciones WHERE (Cedul" & _
        "a = @Cedula)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 255, "Cedula"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 255, "Empresa"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tel_01", System.Data.SqlDbType.VarChar, 255, "Tel_01"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tel_02", System.Data.SqlDbType.VarChar, 255, "Tel_02"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fax_01", System.Data.SqlDbType.VarChar, 255, "Fax_01"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fax_02", System.Data.SqlDbType.VarChar, 255, "Fax_02"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 255, "Direccion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Frase", System.Data.SqlDbType.VarChar, 255, "Frase"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_Servicio", System.Data.SqlDbType.Float, 8, "Imp_Servicio"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Logo", System.Data.SqlDbType.VarBinary, 2147483647, "Logo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Int, 4, "Intereses"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_ICT", System.Data.SqlDbType.Float, 8, "Imp_ICT"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total_Dias_Cancelar", System.Data.SqlDbType.Int, 4, "Total_Dias_Cancelar"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dirrecion_Web", System.Data.SqlDbType.VarChar, 100, "Dirrecion_Web"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Comision_Habitaciones", System.Data.SqlDbType.Bit, 1, "Comision_Habitaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Comision_Servicio", System.Data.SqlDbType.Bit, 1, "Comision_Servicio"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Comision_Restaurant", System.Data.SqlDbType.Bit, 1, "Comision_Restaurant"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_Bancaria1", System.Data.SqlDbType.VarChar, 200, "Cuenta_Bancaria1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_Bancaria2", System.Data.SqlDbType.VarChar, 200, "Cuenta_Bancaria2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Impresora_Facturacion", System.Data.SqlDbType.VarChar, 200, "Impresora_Facturacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Maximo_Descuento", System.Data.SqlDbType.Float, 8, "Maximo_Descuento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PersonaJuridica", System.Data.SqlDbType.VarChar, 255, "PersonaJuridica"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CantidadHabitaciones", System.Data.SqlDbType.Int, 4, "CantidadHabitaciones"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cedula, Empresa, Tel_01, Tel_02, Fax_01, Fax_02, Direccion, Imp_Venta, Fra" & _
        "se, Imp_Servicio, Logo, Intereses, Imp_ICT, Total_Dias_Cancelar, Email, Dirrecio" & _
        "n_Web, Comision_Habitaciones, Comision_Servicio, Comision_Restaurant, Cuenta_Ban" & _
        "caria1, Cuenta_Bancaria2, Impresora_Facturacion, Maximo_Descuento, PersonaJuridi" & _
        "ca, CantidadHabitaciones FROM configuraciones"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE configuraciones SET Cedula = @Cedula, Empresa = @Empresa, Tel_01 = @Tel_01" & _
        ", Tel_02 = @Tel_02, Fax_01 = @Fax_01, Fax_02 = @Fax_02, Direccion = @Direccion, " & _
        "Imp_Venta = @Imp_Venta, Frase = @Frase, Imp_Servicio = @Imp_Servicio, Logo = @Lo" & _
        "go, Intereses = @Intereses, Imp_ICT = @Imp_ICT, Total_Dias_Cancelar = @Total_Dia" & _
        "s_Cancelar, Email = @Email, Dirrecion_Web = @Dirrecion_Web, Comision_Habitacione" & _
        "s = @Comision_Habitaciones, Comision_Servicio = @Comision_Servicio, Comision_Res" & _
        "taurant = @Comision_Restaurant, Cuenta_Bancaria1 = @Cuenta_Bancaria1, Cuenta_Ban" & _
        "caria2 = @Cuenta_Bancaria2, Impresora_Facturacion = @Impresora_Facturacion, Maxi" & _
        "mo_Descuento = @Maximo_Descuento, PersonaJuridica = @PersonaJuridica, CantidadHa" & _
        "bitaciones = @CantidadHabitaciones WHERE (Cedula = @Original_Cedula) AND (Cantid" & _
        "adHabitaciones = @Original_CantidadHabitaciones) AND (Comision_Habitaciones = @O" & _
        "riginal_Comision_Habitaciones) AND (Comision_Restaurant = @Original_Comision_Res" & _
        "taurant) AND (Comision_Servicio = @Original_Comision_Servicio) AND (Cuenta_Banca" & _
        "ria1 = @Original_Cuenta_Bancaria1 OR @Original_Cuenta_Bancaria1 IS NULL AND Cuen" & _
        "ta_Bancaria1 IS NULL) AND (Cuenta_Bancaria2 = @Original_Cuenta_Bancaria2 OR @Ori" & _
        "ginal_Cuenta_Bancaria2 IS NULL AND Cuenta_Bancaria2 IS NULL) AND (Direccion = @O" & _
        "riginal_Direccion) AND (Dirrecion_Web = @Original_Dirrecion_Web OR @Original_Dir" & _
        "recion_Web IS NULL AND Dirrecion_Web IS NULL) AND (Email = @Original_Email OR @O" & _
        "riginal_Email IS NULL AND Email IS NULL) AND (Empresa = @Original_Empresa) AND (" & _
        "Fax_01 = @Original_Fax_01 OR @Original_Fax_01 IS NULL AND Fax_01 IS NULL) AND (F" & _
        "ax_02 = @Original_Fax_02 OR @Original_Fax_02 IS NULL AND Fax_02 IS NULL) AND (Fr" & _
        "ase = @Original_Frase OR @Original_Frase IS NULL AND Frase IS NULL) AND (Imp_ICT" & _
        " = @Original_Imp_ICT OR @Original_Imp_ICT IS NULL AND Imp_ICT IS NULL) AND (Imp_" & _
        "Servicio = @Original_Imp_Servicio) AND (Imp_Venta = @Original_Imp_Venta) AND (Im" & _
        "presora_Facturacion = @Original_Impresora_Facturacion OR @Original_Impresora_Fac" & _
        "turacion IS NULL AND Impresora_Facturacion IS NULL) AND (Intereses = @Original_I" & _
        "ntereses) AND (Maximo_Descuento = @Original_Maximo_Descuento OR @Original_Maximo" & _
        "_Descuento IS NULL AND Maximo_Descuento IS NULL) AND (PersonaJuridica = @Origina" & _
        "l_PersonaJuridica OR @Original_PersonaJuridica IS NULL AND PersonaJuridica IS NU" & _
        "LL) AND (Tel_01 = @Original_Tel_01) AND (Tel_02 = @Original_Tel_02 OR @Original_" & _
        "Tel_02 IS NULL AND Tel_02 IS NULL) AND (Total_Dias_Cancelar = @Original_Total_Di" & _
        "as_Cancelar); SELECT Cedula, Empresa, Tel_01, Tel_02, Fax_01, Fax_02, Direccion," & _
        " Imp_Venta, Frase, Imp_Servicio, Logo, Intereses, Imp_ICT, Total_Dias_Cancelar, " & _
        "Email, Dirrecion_Web, Comision_Habitaciones, Comision_Servicio, Comision_Restaur" & _
        "ant, Cuenta_Bancaria1, Cuenta_Bancaria2, Impresora_Facturacion, Maximo_Descuento" & _
        ", PersonaJuridica, CantidadHabitaciones FROM configuraciones WHERE (Cedula = @Ce" & _
        "dula)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 255, "Cedula"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 255, "Empresa"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tel_01", System.Data.SqlDbType.VarChar, 255, "Tel_01"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tel_02", System.Data.SqlDbType.VarChar, 255, "Tel_02"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fax_01", System.Data.SqlDbType.VarChar, 255, "Fax_01"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fax_02", System.Data.SqlDbType.VarChar, 255, "Fax_02"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 255, "Direccion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Frase", System.Data.SqlDbType.VarChar, 255, "Frase"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_Servicio", System.Data.SqlDbType.Float, 8, "Imp_Servicio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Logo", System.Data.SqlDbType.VarBinary, 2147483647, "Logo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Intereses", System.Data.SqlDbType.Int, 4, "Intereses"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Imp_ICT", System.Data.SqlDbType.Float, 8, "Imp_ICT"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total_Dias_Cancelar", System.Data.SqlDbType.Int, 4, "Total_Dias_Cancelar"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Dirrecion_Web", System.Data.SqlDbType.VarChar, 100, "Dirrecion_Web"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Comision_Habitaciones", System.Data.SqlDbType.Bit, 1, "Comision_Habitaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Comision_Servicio", System.Data.SqlDbType.Bit, 1, "Comision_Servicio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Comision_Restaurant", System.Data.SqlDbType.Bit, 1, "Comision_Restaurant"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_Bancaria1", System.Data.SqlDbType.VarChar, 200, "Cuenta_Bancaria1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_Bancaria2", System.Data.SqlDbType.VarChar, 200, "Cuenta_Bancaria2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Impresora_Facturacion", System.Data.SqlDbType.VarChar, 200, "Impresora_Facturacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Maximo_Descuento", System.Data.SqlDbType.Float, 8, "Maximo_Descuento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PersonaJuridica", System.Data.SqlDbType.VarChar, 255, "PersonaJuridica"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CantidadHabitaciones", System.Data.SqlDbType.Int, 4, "CantidadHabitaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CantidadHabitaciones", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CantidadHabitaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Comision_Habitaciones", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comision_Habitaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Comision_Restaurant", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comision_Restaurant", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Comision_Servicio", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comision_Servicio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta_Bancaria1", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta_Bancaria1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta_Bancaria2", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta_Bancaria2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Dirrecion_Web", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dirrecion_Web", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Empresa", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Empresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fax_01", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fax_02", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Frase", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Frase", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imp_ICT", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_ICT", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imp_Servicio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Servicio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Impresora_Facturacion", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impresora_Facturacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Intereses", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Intereses", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Maximo_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Maximo_Descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PersonaJuridica", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PersonaJuridica", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tel_01", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tel_02", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tel_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total_Dias_Cancelar", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total_Dias_Cancelar", System.Data.DataRowVersion.Original, Nothing))
        '
        'FrmConfiguración
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 382)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolBar1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(416, 416)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(416, 416)
        Me.Name = "FrmConfiguración"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuración"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DsConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variable"

#End Region

    Private Sub FrmConfiguración_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = GetSetting("Seesoft", "Planilla", "CONEXION")
        Me.DaConfiguracion.Fill(Me.DsConfiguracion, "configuraciones")

        Me.DsConfiguracion.configuraciones.Imp_VentaColumn.DefaultValue = "0"
        Me.DsConfiguracion.configuraciones.InteresesColumn.DefaultValue = "0"
        Me.DsConfiguracion.configuraciones.Imp_ServicioColumn.DefaultValue = "0"
        Me.DsConfiguracion.configuraciones.Imp_ICTColumn.DefaultValue = "0"
        Me.DsConfiguracion.configuraciones.Total_Dias_CancelarColumn.DefaultValue = "0"
        Me.DsConfiguracion.configuraciones.Comision_HabitacionesColumn.DefaultValue = "True"
        Me.DsConfiguracion.configuraciones.Comision_RestaurantColumn.DefaultValue = "false"
        Me.DsConfiguracion.configuraciones.Comision_ServicioColumn.DefaultValue = "false"
        Me.DsConfiguracion.configuraciones.Maximo_DescuentoColumn.DefaultValue = "0"
        Me.DsConfiguracion.configuraciones.CantidadHabitacionesColumn.DefaultValue = "0"

        If Me.DsConfiguracion.configuraciones.Count > 0 Then
            Me.ToolBar1.Buttons(0).Enabled = False
        End If

        Binding()
    End Sub

    Function Binding()
        Me.TxtImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Imp_Venta"))
        Me.TxtCajeros.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Imp_Servicio"))
        Me.TxtInteres.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Intereses"))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Imp_ICT"))
        Me.TxtEmpresa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Empresa"))
        Me.TxtCedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Cedula"))
        Me.TxtFrase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Frase"))
        Me.VTTel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Tel_01"))
        Me.VTFax1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Fax_01"))
        Me.VTFax2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Fax_02"))
        Me.VTTel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Tel_02"))
        Me.TxtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Direccion"))
        Me.pictureEdit1.DataBindings.Add(New Binding("EditValue", DsConfiguracion, "configuraciones.Logo"))
        Me.NumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsConfiguracion, "configuraciones.Total_Dias_Cancelar"))
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Cuenta_Bancaria1"))
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Impresora_Facturacion"))
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.Comision_Habitaciones"))
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.Comision_Servicio"))
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsConfiguracion, "configuraciones.Comision_Restaurant"))
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Maximo_Descuento"))
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Email"))
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Dirrecion_Web"))
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsConfiguracion, "configuraciones.Cuenta_Bancaria2"))
    End Function

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Me.nuevo()

            Case 2 : Me.registrar()

            Case 3 : Me.Close()

        End Select
    End Sub
    Private Sub nuevo()

        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 4

            Try 'inicia la edicion
                Me.BindingContext(Me.DsConfiguracion, "Configuraciones").EndCurrentEdit()
                Me.BindingContext(Me.DsConfiguracion, "Configuraciones").AddNew()

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                Me.BindingContext(Me.DsConfiguracion, "Configuraciones").CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Sub
    Private Sub registrar()
        Try
            If Me.Validar Then
                Me.BindingContext(Me.DsConfiguracion, "Configuraciones").EndCurrentEdit()
                Me.DaConfiguracion.Update(Me.DsConfiguracion.configuraciones)
                MsgBox("Los datos fueron ingresados correctamente")
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function Validar() As Boolean
        Dim NumeroCajeros As Integer

        If TxtEmpresa.Text.Length = 0 Then
            Me.ErrorProvider1.SetError(TxtEmpresa, "Debes digitar el nombre comercial")
            Return False
        Else
            Me.ErrorProvider1.SetError(TxtEmpresa, "")
        End If

        If TextBox8.Text.Length = 0 Then
            Me.ErrorProvider1.SetError(TextBox8, "Debes digitar el nombre jurídico")
            Return False
        Else
            Me.ErrorProvider1.SetError(TextBox8, "")
        End If

        If TxtCedula.Text.Length = 0 Then
            Me.ErrorProvider1.SetError(TxtCedula, "Debes digitar una cédula")
            Return False
        Else
            Me.ErrorProvider1.SetError(TxtCedula, "")
        End If

        If TxtDireccion.Text.Length = 0 Then
            Me.ErrorProvider1.SetError(TxtDireccion, "Debes digitar una dirección")
            Return False
        Else
            Me.ErrorProvider1.SetError(TxtDireccion, "")
        End If

        If VTTel1.Text.Length = 0 Then
            Me.ErrorProvider1.SetError(VTTel1, "Debes digitar una dirección")
            Return False
        Else
            Me.ErrorProvider1.SetError(VTTel1, "")
        End If

        Return True
    End Function



    Private Sub TxtEmpresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEmpresa.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtCedula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCedula.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtCajeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCajeros.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtDolar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtFrase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFrase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtImpuesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImpuesto.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtInteres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtInteres.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub VTFax1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VTFax1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub VTFax2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VTFax2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub VTTel1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VTTel1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub VTTel2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VTTel2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class
