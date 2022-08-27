Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Imports System.IO

Public Class Frm_login
    Inherits System.Windows.Forms.Form
    Public Usuario As New Usuario_Logeado
    Private SubSistema As String

#Region " Windows Form Designer generated code "

    Public Sub New(Optional ByVal Sistema As String = "SeePOS")
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.PictureEdit1.DataBindings.Add(New Binding("EditValue", Me.DataSetUsuario_logging1, "Usuarios.Foto"))
        SubSistema = Sistema
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
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents bttn_salir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttn_aceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_clave As System.Windows.Forms.Label
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adapter_Usua_Loggin As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetUsuario_logging1 As DataSetUsuario_logging
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lnkCambiarContrasena As System.Windows.Forms.LinkLabel
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_login))
        Me.txt_clave = New System.Windows.Forms.TextBox
        Me.lbl_clave = New System.Windows.Forms.Label
        Me.lbl_user = New System.Windows.Forms.Label
        Me.bttn_salir = New DevExpress.XtraEditors.SimpleButton
        Me.bttn_aceptar = New DevExpress.XtraEditors.SimpleButton
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DataSetUsuario_logging1 = New Utilidades.DataSetUsuario_logging
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Adapter_Usua_Loggin = New System.Data.SqlClient.SqlDataAdapter
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit
        Me.lnkCambiarContrasena = New System.Windows.Forms.LinkLabel
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.DataSetUsuario_logging1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(155, 103)
        Me.txt_clave.MaxLength = 10
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(149, 20)
        Me.txt_clave.TabIndex = 1
        Me.txt_clave.Text = ""
        '
        'lbl_clave
        '
        Me.lbl_clave.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_clave.Location = New System.Drawing.Point(104, 105)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(48, 15)
        Me.lbl_clave.TabIndex = 5
        Me.lbl_clave.Text = "Clave"
        '
        'lbl_user
        '
        Me.lbl_user.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_user.Location = New System.Drawing.Point(99, 64)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(205, 16)
        Me.lbl_user.TabIndex = 4
        Me.lbl_user.Text = "Usuario"
        '
        'bttn_salir
        '
        Me.bttn_salir.Image = CType(resources.GetObject("bttn_salir.Image"), System.Drawing.Image)
        Me.bttn_salir.Location = New System.Drawing.Point(212, 132)
        Me.bttn_salir.Name = "bttn_salir"
        Me.bttn_salir.Size = New System.Drawing.Size(92, 24)
        Me.bttn_salir.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight)
        Me.bttn_salir.TabIndex = 3
        Me.bttn_salir.Text = "Cancelar"
        '
        'bttn_aceptar
        '
        Me.bttn_aceptar.Image = CType(resources.GetObject("bttn_aceptar.Image"), System.Drawing.Image)
        Me.bttn_aceptar.Location = New System.Drawing.Point(96, 132)
        Me.bttn_aceptar.Name = "bttn_aceptar"
        Me.bttn_aceptar.Size = New System.Drawing.Size(88, 24)
        Me.bttn_aceptar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight)
        Me.bttn_aceptar.TabIndex = 2
        Me.bttn_aceptar.Text = "Aceptar"
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(310, 60)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DataSetUsuario_logging1
        Me.ComboBox1.DisplayMember = "Usuarios.Nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(100, 80)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Usuarios.Cedula"
        '
        'DataSetUsuario_logging1
        '
        Me.DataSetUsuario_logging1.DataSetName = "DataSetUsuario_logging"
        Me.DataSetUsuario_logging1.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(4, 62)
        Me.PictureEdit1.Name = "PictureEdit1"
        '
        'PictureEdit1.Properties
        '
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Size = New System.Drawing.Size(88, 88)
        Me.PictureEdit1.TabIndex = 15
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.Items.AddRange(New Object() {"(""Local"")"})
        Me.ComboBox2.Location = New System.Drawing.Point(512, 144)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox2.TabIndex = 16
        Me.ComboBox2.Text = "(""Local"")"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(440, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Engenie"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(164, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 15)
        Me.Label2.TabIndex = 18
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ZEUS;packet size=4096;integrated security=SSPI;data source=""."";per" & _
        "sist security info=False;initial catalog=SeePOS"
        '
        'Adapter_Usua_Loggin
        '
        Me.Adapter_Usua_Loggin.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Usua_Loggin.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Foto", "Foto")})})
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = CType(resources.GetObject("PictureEdit2.EditValue"), Object)
        Me.PictureEdit2.Location = New System.Drawing.Point(60, 171)
        Me.PictureEdit2.Name = "PictureEdit2"
        '
        'PictureEdit2.Properties
        '
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Size = New System.Drawing.Size(200, 60)
        Me.PictureEdit2.TabIndex = 19
        '
        'lnkCambiarContrasena
        '
        Me.lnkCambiarContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCambiarContrasena.Location = New System.Drawing.Point(0, 152)
        Me.lnkCambiarContrasena.Name = "lnkCambiarContrasena"
        Me.lnkCambiarContrasena.Size = New System.Drawing.Size(92, 16)
        Me.lnkCambiarContrasena.TabIndex = 20
        Me.lnkCambiarContrasena.TabStop = True
        Me.lnkCambiarContrasena.Text = "Cambiar contraseña"
        Me.lnkCambiarContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id_Usuario AS Cedula, Nombre, Clave_Entrada, Clave_Interna, Foto FROM Usua" & _
        "rios"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'Frm_login
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(310, 232)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lnkCambiarContrasena)
        Me.Controls.Add(Me.PictureEdit2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.bttn_salir)
        Me.Controls.Add(Me.bttn_aceptar)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso al sistema"
        CType(Me.DataSetUsuario_logging1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim X As Byte
    Friend tipo As Int16 = 0
    Private conn As New SqlConnection
    Private rdrlogin As SqlDataReader
    Dim contador As Byte
    Dim objmutex As Mutex
    Public conectado As Boolean
#End Region

#Region "Load"
    Private Sub Frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = GetSetting("SeeSOFT", SubSistema, "Conexion")
            Adapter_Usua_Loggin.Fill(DataSetUsuario_logging1, "Usuarios")
            ComboBox1.Text = GetSetting("SeeSOFT", "Seguridad", "LastUser")

            objmutex = New Mutex(False, "SINGLE_INSTANCE_APP_MUTEX")
            If objmutex.WaitOne(0, False) = False Then
                objmutex.Close()
                objmutex = Nothing
                'MessageBox.Show("Hay una instancia de la aplicación corriendo actualmente.  El módulo se desactivará", "Sistema SeePos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Controles Funciones"
    Private Sub bttn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_aceptar.Click
        If Loggin_Usuario() Then
            Close()
            conectado = True
        Else
            conectado = False
        End If
    End Sub

    Private Sub bttn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_salir.Click
        conectado = False
        Me.Close()
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_clave.Focus()
        End If
    End Sub

    Private Sub txt_clave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_clave.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Loggin_Usuario() Then
                Me.Close()
                conectado = True
            End If
        End If
    End Sub

#End Region

#Region "Funciones"
    Function Loggin_Usuario() As Boolean
        Try
            If Me.BindingContext(Me.DataSetUsuario_logging1.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow
                Usuario_autorizadores = Me.DataSetUsuario_logging1.Usuarios.Select("Clave_Entrada = '" & txt_clave.Text & "' And Nombre = '" & Me.ComboBox1.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    Usuario.Cedula = Usua("Cedula")
                    Usuario.Nombre = Usua("Nombre")
                    Usuario.Clave_Entrada = Usua("Clave_Entrada")
                    Usuario.Clave_Interna = Usua("Clave_Interna")
                    SaveSetting("SeeSOFT", "Seguridad", "LastUser", ComboBox1.Text)
                    Me.DialogResult = DialogResult.OK
                    Return True
                Else ' si no existe una contraseña como esta
                    MsgBox("Clave Entrada incorrecta", MsgBoxStyle.Exclamation)
                    txt_clave.Text = ""
                    txt_clave.Focus()
                    Return False
                End If
            Else
                MsgBox("No Existen Usuarios, ingrese datos")
                Return False
                txt_clave.Focus()
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
#End Region

#Region "Cambiar Contraseña"
    Private Sub lnkCambiarContrasena_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCambiarContrasena.LinkClicked
        Dim frmCambiarContrasena As New frmCambioContrasena
        frmCambiarContrasena.IdUsuario = DataSetUsuario_logging1.Usuarios(Me.ComboBox1.SelectedIndex).Cedula
        frmCambiarContrasena.ContrasenaActual = Me.txt_clave.Text
        frmCambiarContrasena.ShowDialog()
        Me.Adapter_Usua_Loggin.Fill(Me.DataSetUsuario_logging1, "Usuarios")
    End Sub
#End Region

End Class