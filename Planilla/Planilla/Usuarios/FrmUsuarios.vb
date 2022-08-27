Imports System.data.SqlClient
Public Class Frmusuario
    Inherits FrmPlantilla
    Public WithEvents Label2 As System.Windows.Forms.Label
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.PictureEdit1.DataBindings.Add(New Binding("EditValue", Me.DataSetUsuario1, "Usuarios.Foto"))
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

    Public WithEvents TextBox1 As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TextBox2 As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TextBox3 As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents TextBox4 As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Public WithEvents TextBox5 As System.Windows.Forms.TextBox
    Public WithEvents TextBox6 As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents TxtDescuentoPorcentaje As System.Windows.Forms.TextBox
    Public WithEvents TxtCambioPrecioPorcentaje As System.Windows.Forms.TextBox

    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxPerfilUsuario As System.Windows.Forms.ComboBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterUsuario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetUsuario1 As DataSetUsuario
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand




    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.TxtDescuentoPorcentaje = New System.Windows.Forms.TextBox
        Me.TxtCambioPrecioPorcentaje = New System.Windows.Forms.TextBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.ComboBoxPerfilUsuario = New System.Windows.Forms.ComboBox
        Me.DataSetUsuario1 = New Planilla.DataSetUsuario
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterUsuario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator
        Me.Panel1.SuspendLayout()
        CType(Me.DataSetUsuario1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(506, 32)
        Me.TituloModulo.Text = "              Registros Usuarios"
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 243)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(506, 52)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(480, 15)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Restricciones Adicionales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(72, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 13)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(0, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 12)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Id Usuario"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Blue
        Me.TextBox2.Location = New System.Drawing.Point(104, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(392, 13)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(104, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 12)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Nombre Completo"
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.TextBox3.ForeColor = System.Drawing.Color.Blue
        Me.TextBox3.Location = New System.Drawing.Point(104, 88)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(104, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(104, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 12)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Clave de Acceso"
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.TextBox4.ForeColor = System.Drawing.Color.Blue
        Me.TextBox4.Location = New System.Drawing.Point(216, 88)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBox4.Size = New System.Drawing.Size(104, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(216, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 12)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Clave de Interna"
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox1.Location = New System.Drawing.Point(5, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(211, 13)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Anular Ventas"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.CheckBox9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CheckBox8)
        Me.Panel1.Controls.Add(Me.CheckBox7)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.TxtDescuentoPorcentaje)
        Me.Panel1.Controls.Add(Me.TxtCambioPrecioPorcentaje)
        Me.Panel1.Controls.Add(Me.CheckBox6)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.CheckBox4)
        Me.Panel1.Controls.Add(Me.CheckBox5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(8, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 116)
        Me.Panel1.TabIndex = 94
        '
        'CheckBox9
        '
        Me.CheckBox9.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox9.Location = New System.Drawing.Point(240, 54)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(112, 15)
        Me.CheckBox9.TabIndex = 91
        Me.CheckBox9.Text = "Abrir Crédito"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(432, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 12)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "%"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(432, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 12)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "%"
        '
        'CheckBox8
        '
        Me.CheckBox8.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox8.Location = New System.Drawing.Point(5, 90)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(203, 15)
        Me.CheckBox8.TabIndex = 88
        Me.CheckBox8.Text = "Acceso a Recibos CxC"
        '
        'CheckBox7
        '
        Me.CheckBox7.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox7.Location = New System.Drawing.Point(5, 46)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(204, 13)
        Me.CheckBox7.TabIndex = 87
        Me.CheckBox7.Text = "Anular Recibos"
        '
        'CheckBox3
        '
        Me.CheckBox3.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox3.Location = New System.Drawing.Point(5, 74)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(203, 16)
        Me.CheckBox3.TabIndex = 86
        Me.CheckBox3.Text = "Variar Intereses"
        '
        'TxtDescuentoPorcentaje
        '
        Me.TxtDescuentoPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescuentoPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescuentoPorcentaje.ForeColor = System.Drawing.Color.Blue
        Me.TxtDescuentoPorcentaje.Location = New System.Drawing.Point(376, 41)
        Me.TxtDescuentoPorcentaje.Name = "TxtDescuentoPorcentaje"
        Me.TxtDescuentoPorcentaje.Size = New System.Drawing.Size(56, 13)
        Me.TxtDescuentoPorcentaje.TabIndex = 12
        Me.TxtDescuentoPorcentaje.Text = ""
        '
        'TxtCambioPrecioPorcentaje
        '
        Me.TxtCambioPrecioPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCambioPrecioPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCambioPrecioPorcentaje.ForeColor = System.Drawing.Color.Blue
        Me.TxtCambioPrecioPorcentaje.Location = New System.Drawing.Point(376, 23)
        Me.TxtCambioPrecioPorcentaje.Name = "TxtCambioPrecioPorcentaje"
        Me.TxtCambioPrecioPorcentaje.Size = New System.Drawing.Size(56, 13)
        Me.TxtCambioPrecioPorcentaje.TabIndex = 10
        Me.TxtCambioPrecioPorcentaje.Text = ""
        '
        'CheckBox6
        '
        Me.CheckBox6.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox6.Location = New System.Drawing.Point(5, 59)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(210, 16)
        Me.CheckBox6.TabIndex = 8
        Me.CheckBox6.Text = "Vender con Existencia en Negativo"
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox2.Location = New System.Drawing.Point(5, 32)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(211, 13)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Anular Cotizaciones"
        '
        'CheckBox4
        '
        Me.CheckBox4.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox4.Location = New System.Drawing.Point(240, 24)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(120, 13)
        Me.CheckBox4.TabIndex = 9
        Me.CheckBox4.Text = "Cambiar Precios"
        '
        'CheckBox5
        '
        Me.CheckBox5.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox5.Location = New System.Drawing.Point(240, 37)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(120, 19)
        Me.CheckBox5.TabIndex = 11
        Me.CheckBox5.Text = "Aplicar Descuentos"
        '
        'ComboBoxPerfilUsuario
        '
        Me.ComboBoxPerfilUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPerfilUsuario.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ComboBoxPerfilUsuario.Items.AddRange(New Object() {"GENERAL", "VENTAS", "CAJA", "INVENTARIO", "ADMINISTRATIVO", "ADMINISTRADOR"})
        Me.ComboBoxPerfilUsuario.Location = New System.Drawing.Point(328, 87)
        Me.ComboBoxPerfilUsuario.Name = "ComboBoxPerfilUsuario"
        Me.ComboBoxPerfilUsuario.Size = New System.Drawing.Size(168, 21)
        Me.ComboBoxPerfilUsuario.TabIndex = 5
        '
        'DataSetUsuario1
        '
        Me.DataSetUsuario1.DataSetName = "DataSetUsuario"
        Me.DataSetUsuario1.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(328, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 12)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Perfil de Acceso"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(8, 32)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(88, 80)
        Me.PictureEdit1.TabIndex = 91
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=PICHINGA;packet size=4096;integrated security=SSPI;data source=PIC" & _
        "HINGA;persist security info=False;initial catalog=Planilla"
        '
        'AdapterUsuario
        '
        Me.AdapterUsuario.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterUsuario.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterUsuario.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterUsuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Perfil", "Perfil"), New System.Data.Common.DataColumnMapping("Anu_Venta", "Anu_Venta"), New System.Data.Common.DataColumnMapping("Anu_Cotizacion", "Anu_Cotizacion"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa"), New System.Data.Common.DataColumnMapping("RecibosDinero", "RecibosDinero"), New System.Data.Common.DataColumnMapping("AnuRecibos", "AnuRecibos"), New System.Data.Common.DataColumnMapping("VariarIntereses", "VariarIntereses"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio"), New System.Data.Common.DataColumnMapping("Foto", "Foto"), New System.Data.Common.DataColumnMapping("Abrir_Credito", "Abrir_Credito")})})
        Me.AdapterUsuario.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Usuarios WHERE (Cedula = @Original_Cedula) AND (Abrir_Credito = @Orig" & _
        "inal_Abrir_Credito) AND (AnuRecibos = @Original_AnuRecibos) AND (Anu_Cotizacion " & _
        "= @Original_Anu_Cotizacion) AND (Anu_Venta = @Original_Anu_Venta) AND (Aplicar_D" & _
        "esc = @Original_Aplicar_Desc) AND (CambiarPrecio = @Original_CambiarPrecio) AND " & _
        "(Clave_Entrada = @Original_Clave_Entrada) AND (Clave_Interna = @Original_Clave_I" & _
        "nterna) AND (Exist_Negativa = @Original_Exist_Negativa) AND (Nombre = @Original_" & _
        "Nombre) AND (Perfil = @Original_Perfil) AND (Porc_Desc = @Original_Porc_Desc) AN" & _
        "D (Porc_Precio = @Original_Porc_Precio) AND (RecibosDinero = @Original_RecibosDi" & _
        "nero) AND (VariarIntereses = @Original_VariarIntereses)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abrir_Credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abrir_Credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AnuRecibos", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnuRecibos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anu_Cotizacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anu_Cotizacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anu_Venta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anu_Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aplicar_Desc", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplicar_Desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CambiarPrecio", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambiarPrecio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Clave_Entrada", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Entrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Clave_Interna", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Interna", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exist_Negativa", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exist_Negativa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Perfil", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Desc", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Precio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RecibosDinero", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecibosDinero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VariarIntereses", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VariarIntereses", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Usuarios(Cedula, Nombre, Clave_Entrada, Clave_Interna, Perfil, Anu_Ve" & _
        "nta, Anu_Cotizacion, CambiarPrecio, Aplicar_Desc, Exist_Negativa, RecibosDinero," & _
        " AnuRecibos, VariarIntereses, Porc_Desc, Porc_Precio, Foto, Abrir_Credito) VALUE" & _
        "S (@Cedula, @Nombre, @Clave_Entrada, @Clave_Interna, @Perfil, @Anu_Venta, @Anu_C" & _
        "otizacion, @CambiarPrecio, @Aplicar_Desc, @Exist_Negativa, @RecibosDinero, @AnuR" & _
        "ecibos, @VariarIntereses, @Porc_Desc, @Porc_Precio, @Foto, @Abrir_Credito); SELE" & _
        "CT Cedula, Nombre, Clave_Entrada, Clave_Interna, Perfil, Anu_Venta, Anu_Cotizaci" & _
        "on, CambiarPrecio, Aplicar_Desc, Exist_Negativa, RecibosDinero, AnuRecibos, Vari" & _
        "arIntereses, Porc_Desc, Porc_Precio, Foto, Abrir_Credito FROM Usuarios WHERE (Ce" & _
        "dula = @Cedula)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Perfil", System.Data.SqlDbType.VarChar, 75, "Perfil"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anu_Venta", System.Data.SqlDbType.Bit, 1, "Anu_Venta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anu_Cotizacion", System.Data.SqlDbType.Bit, 1, "Anu_Cotizacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RecibosDinero", System.Data.SqlDbType.Bit, 1, "RecibosDinero"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AnuRecibos", System.Data.SqlDbType.Bit, 1, "AnuRecibos"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VariarIntereses", System.Data.SqlDbType.Bit, 1, "VariarIntereses"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abrir_Credito", System.Data.SqlDbType.Bit, 1, "Abrir_Credito"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna, Perfil, Anu_Venta, Anu_Cotiz" & _
        "acion, CambiarPrecio, Aplicar_Desc, Exist_Negativa, RecibosDinero, AnuRecibos, V" & _
        "ariarIntereses, Porc_Desc, Porc_Precio, Foto, Abrir_Credito FROM Usuarios"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Usuarios SET Cedula = @Cedula, Nombre = @Nombre, Clave_Entrada = @Clave_En" & _
        "trada, Clave_Interna = @Clave_Interna, Perfil = @Perfil, Anu_Venta = @Anu_Venta," & _
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
        "ntereses = @Original_VariarIntereses); SELECT Cedula, Nombre, Clave_Entrada, Cla" & _
        "ve_Interna, Perfil, Anu_Venta, Anu_Cotizacion, CambiarPrecio, Aplicar_Desc, Exis" & _
        "t_Negativa, RecibosDinero, AnuRecibos, VariarIntereses, Porc_Desc, Porc_Precio, " & _
        "Foto, Abrir_Credito FROM Usuarios WHERE (Cedula = @Cedula)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Perfil", System.Data.SqlDbType.VarChar, 75, "Perfil"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anu_Venta", System.Data.SqlDbType.Bit, 1, "Anu_Venta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anu_Cotizacion", System.Data.SqlDbType.Bit, 1, "Anu_Cotizacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RecibosDinero", System.Data.SqlDbType.Bit, 1, "RecibosDinero"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AnuRecibos", System.Data.SqlDbType.Bit, 1, "AnuRecibos"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VariarIntereses", System.Data.SqlDbType.Bit, 1, "VariarIntereses"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Abrir_Credito", System.Data.SqlDbType.Bit, 1, "Abrir_Credito"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Abrir_Credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Abrir_Credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AnuRecibos", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AnuRecibos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anu_Cotizacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anu_Cotizacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anu_Venta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anu_Venta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aplicar_Desc", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplicar_Desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CambiarPrecio", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CambiarPrecio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Clave_Entrada", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Entrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Clave_Interna", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Interna", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Exist_Negativa", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exist_Negativa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Perfil", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Perfil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Desc", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porc_Precio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Precio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RecibosDinero", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecibosDinero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VariarIntereses", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VariarIntereses", System.Data.DataRowVersion.Original, Nothing))
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.NextPage.Visible = False
        Me.DataNavigator1.Buttons.PrevPage.Visible = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.DataMember = "Usuarios"
        Me.DataNavigator1.DataSource = Me.DataSetUsuario1
        Me.DataNavigator1.Location = New System.Drawing.Point(384, 264)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(112, 24)
        Me.DataNavigator1.TabIndex = 98
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'Frmusuario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(506, 295)
        Me.Controls.Add(Me.DataNavigator1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBoxPerfilUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Name = "Frmusuario"
        Me.Text = "Usuario"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.PictureEdit1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TextBox3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TextBox4, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.ComboBoxPerfilUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator1, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataSetUsuario1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = GetSetting("Seesoft", "Proyecto", "Conexion")

        Me.AdapterUsuario.Fill(Me.DataSetUsuario1.Usuarios)

        Me.ToolBar1.Buttons(1).Visible = False
        Me.ToolBar1.Buttons(4).Visible = False
        Binding()
    End Sub


    Function Binding()
        Me.ComboBoxPerfilUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetUsuario1, "Usuarios.Perfil"))
        'Me.ComboBoxPerfilUsuario.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetUsuario1, "Usuarios.Perfil"))

        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetUsuario1, "Usuarios.Cedula"))
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetUsuario1, "Usuarios.Nombre"))
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetUsuario1, "Usuarios.Clave_Entrada"))
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetUsuario1, "Usuarios.Clave_Interna"))
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetUsuario1, "Usuarios.Anu_Venta"))
        Me.CheckBox8.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetUsuario1, "Usuarios.RecibosDinero"))
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetUsuario1, "Usuarios.RecibosDinero"))
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetUsuario1, "Usuarios.VariarIntereses"))
        Me.TxtDescuentoPorcentaje.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetUsuario1, "Usuarios.Porc_Desc"))
        Me.TxtCambioPrecioPorcentaje.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetUsuario1, "Usuarios.Porc_Precio"))
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetUsuario1, "Usuarios.Exist_Negativa"))
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetUsuario1, "Usuarios.Anu_Cotizacion"))
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetUsuario1, "Usuarios.CambiarPrecio"))
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetUsuario1, "Usuarios.Aplicar_Desc"))
        Me.CheckBox9.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetUsuario1, "Usuarios.Abrir_Credito"))
    End Function

    Function Limpiar()

        Me.TxtCambioPrecioPorcentaje.Text = ""
        Me.TxtDescuentoPorcentaje.Text = ""
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        ' Me.TextBox5.Text = ""
        'Me.TextBox6.Text = ""

    End Function

    Function Nuevo()
        Try
            Limpiar()
            Me.BindingContext(Me.DataSetUsuario1, "Usuarios").EndCurrentEdit()
            Me.BindingContext(Me.DataSetUsuario1, "Usuarios").AddNew()
            Limpiar()
            Me.ComboBoxPerfilUsuario.SelectedIndex = 1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Function registra()

        Dim trans As SqlTransaction
        Try
            If MessageBox.Show(" ¿ Desea Registrar Este Usuario ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
                trans = Me.SqlConnection1.BeginTransaction
                Me.BindingContext(Me.DataSetUsuario1, "Usuarios").EndCurrentEdit()
                Me.AdapterUsuario.InsertCommand.Transaction = trans
                Me.AdapterUsuario.UpdateCommand.Transaction = trans
                Me.AdapterUsuario.DeleteCommand.Transaction = trans
                Me.AdapterUsuario.Update(Me.DataSetUsuario1.Usuarios)
                Me.DataSetUsuario1.AcceptChanges()
                trans.Commit()
                MsgBox("Usuario Registrado Exitosamente", MsgBoxStyle.Information)
                
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            trans.Rollback()
        Finally
            Me.SqlConnection1.Close()
        End Try


    End Function

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ComboBoxPerfilUsuario.Focus()
        End If
    End Sub

    Private Sub ComboBoxPerfilUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxPerfilUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CheckBox1.Focus()
        End If
    End Sub

    Private Sub SoloNumericos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCambioPrecioPorcentaje.KeyPress, TxtDescuentoPorcentaje.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If

    End Sub

    Private Sub TxtCambioPrecioPorcentaje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCambioPrecioPorcentaje.TextChanged

    End Sub

    Private Sub TxtCambioPrecioPorcentaje_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtCambioPrecioPorcentaje.Validating
        Try

            If Me.TxtCambioPrecioPorcentaje.Text = "" Then 'si el campo está vacío
                ErrorProvider1.SetError(sender, "No puede estar vacío")
                e.Cancel = True
                Exit Sub
            Else
                ErrorProvider1.SetError(sender, "")

            End If


            If CDbl(TxtCambioPrecioPorcentaje.Text) > 100 Then 'si el campo está vacío
                TxtCambioPrecioPorcentaje.Text = 100
            End If


        Catch ex As SystemException
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub TxtDescuentoPorcentaje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescuentoPorcentaje.TextChanged

    End Sub

    Private Sub TxtDescuentoPorcentaje_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtDescuentoPorcentaje.Validating
        Try

            If Me.TxtDescuentoPorcentaje.Text = "" Then 'si el campo está vacío
                ErrorProvider1.SetError(sender, "No puede estar vacío")
                e.Cancel = True
                Exit Sub
            Else
                ErrorProvider1.SetError(sender, "")

            End If


            If CDbl(TxtDescuentoPorcentaje.Text) > 100 Then 'si el campo está vacío
                TxtDescuentoPorcentaje.Text = 100
            End If


        Catch ex As SystemException
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 'Me.NuevosDatos(Me.DataSetUsuario1, Me.DataSetUsuario1.Usuarios.ToString)
                Nuevo()

            Case 3 : Me.registra()

            Case 4 : Me.EliminarDatos(Me.AdapterUsuario, Me.DataSetUsuario1, Me.DataSetUsuario1.Usuarios.ToString)



            Case 6
                If MessageBox.Show("¿Desea Cerrar el Módulo de Usuario?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Me.Close()
                End If

        End Select
    End Sub

    Private Sub AdapterUsuario_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles AdapterUsuario.RowUpdated

    End Sub

    Private Sub ComboBoxPerfilUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxPerfilUsuario.KeyPress
        'If Not IsNumeric(sender.text & e.KeyChar) Then
        If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.Handled = True  ' esto invalida la tecla pulsada
        End If
        'End If

    End Sub
End Class
