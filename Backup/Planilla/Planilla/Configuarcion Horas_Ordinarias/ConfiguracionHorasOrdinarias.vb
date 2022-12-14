Imports System.data.SqlClient
Imports Utilidades

Public Class ConfiguracionHorasOrdinarias
    Inherits System.Windows.Forms.Form
    Dim usuario As Object

#Region " C?digo generado por el Dise?ador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Dise?ador de Windows Forms requiere esta llamada.
        InitializeComponent()
        Usuario = Usuario_Parametro
        'Agregar cualquier inicializaci?n despu?s de la llamada a InitializeComponent()

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

    'Requerido por el Dise?ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise?ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise?ador de Windows Forms. 
    'No lo modifique con el editor de c?digo.
    Protected Friend WithEvents TituloModulo As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdHoras_Ordinarias As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSet_HorasOrdinarias1 As Planilla.DataSet_HorasOrdinarias
    Friend WithEvents txtHoras As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Protected Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarEditar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents Check_Individual As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ConfiguracionHorasOrdinarias))
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Check_Individual = New System.Windows.Forms.CheckBox
        Me.DataSet_HorasOrdinarias1 = New Planilla.DataSet_HorasOrdinarias
        Me.txtHoras = New System.Windows.Forms.TextBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdHoras_Ordinarias = New System.Data.SqlClient.SqlDataAdapter
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEditar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet_HorasOrdinarias1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TituloModulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TituloModulo.ForeColor = System.Drawing.Color.White
        Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
        Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TituloModulo.Location = New System.Drawing.Point(0, 0)
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(392, 32)
        Me.TituloModulo.TabIndex = 61
        Me.TituloModulo.Text = "Horas Ordinarias"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(24, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Horas Ordinarias:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Check_Individual)
        Me.GroupBox1.Controls.Add(Me.txtHoras)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 88)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        '
        'Check_Individual
        '
        Me.Check_Individual.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_HorasOrdinarias1, "Horas_Ordinarias.Individual"))
        Me.Check_Individual.ForeColor = System.Drawing.Color.Blue
        Me.Check_Individual.Location = New System.Drawing.Point(168, 56)
        Me.Check_Individual.Name = "Check_Individual"
        Me.Check_Individual.Size = New System.Drawing.Size(96, 24)
        Me.Check_Individual.TabIndex = 65
        Me.Check_Individual.Text = "Individualizar"
        '
        'DataSet_HorasOrdinarias1
        '
        Me.DataSet_HorasOrdinarias1.DataSetName = "DataSet_HorasOrdinarias"
        Me.DataSet_HorasOrdinarias1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'txtHoras
        '
        Me.txtHoras.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_HorasOrdinarias1, "Horas_Ordinarias.Horas"))
        Me.txtHoras.Location = New System.Drawing.Point(168, 24)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.Size = New System.Drawing.Size(88, 20)
        Me.txtHoras.TabIndex = 64
        Me.txtHoras.Text = ""
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Planilla"
        '
        'AdHoras_Ordinarias
        '
        Me.AdHoras_Ordinarias.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdHoras_Ordinarias.InsertCommand = Me.SqlInsertCommand1
        Me.AdHoras_Ordinarias.SelectCommand = Me.SqlSelectCommand1
        Me.AdHoras_Ordinarias.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Horas_Ordinarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Horas", "Horas"), New System.Data.Common.DataColumnMapping("Individual", "Individual"), New System.Data.Common.DataColumnMapping("Id", "Id")})})
        Me.AdHoras_Ordinarias.UpdateCommand = Me.SqlUpdateCommand1
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarRegistrar, Me.ToolBarEditar, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 130)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(392, 52)
        Me.ToolBar1.TabIndex = 141
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarEditar
        '
        Me.ToolBarEditar.ImageIndex = 9
        Me.ToolBarEditar.Text = "Editar"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Horas, Individual, Id FROM Horas_Ordinarias"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Horas_Ordinarias(Horas, Individual) VALUES (@Horas, @Individual); SEL" & _
        "ECT Horas, Individual, Id FROM Horas_Ordinarias WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Horas", System.Data.SqlDbType.Int, 4, "Horas"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Individual", System.Data.SqlDbType.Bit, 1, "Individual"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Horas_Ordinarias SET Horas = @Horas, Individual = @Individual WHERE (Id = " & _
        "@Original_Id) AND (Horas = @Original_Horas) AND (Individual = @Original_Individu" & _
        "al); SELECT Horas, Individual, Id FROM Horas_Ordinarias WHERE (Id = @Id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Horas", System.Data.SqlDbType.Int, 4, "Horas"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Individual", System.Data.SqlDbType.Bit, 1, "Individual"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Horas", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Horas", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Individual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Individual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Horas_Ordinarias WHERE (Id = @Original_Id) AND (Horas = @Original_Hor" & _
        "as) AND (Individual = @Original_Individual)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Horas", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Horas", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Individual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Individual", System.Data.DataRowVersion.Original, Nothing))
        '
        'ConfiguracionHorasOrdinarias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 182)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TituloModulo)
        Me.MaximizeBox = False
        Me.Name = "ConfiguracionHorasOrdinarias"
        Me.Text = "Configuraci?n de Horas Ordinarias"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSet_HorasOrdinarias1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ConfiguracionHorasOrdinarias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
            Me.AdHoras_Ordinarias.Fill(Me.DataSet_HorasOrdinarias1, "Horas_Ordinarias")
            Me.txtHoras.Enabled = False
            Check_Individual.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub txtHoras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHoras.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usuario.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atenci?n...") : Exit Sub
            Case 2 : Editar()
            Case 3 : Me.Close()
        End Select

    End Sub

    Private Sub Registrar()
        Try
            Me.BindingContext(Me.DataSet_HorasOrdinarias1, "Horas_Ordinarias").EndCurrentEdit()
            Me.AdHoras_Ordinarias.Update(Me.DataSet_HorasOrdinarias1, "Horas_Ordinarias")
            Me.txtHoras.Enabled = False
            Check_Individual.Enabled = False
            MsgBox("Horas Ordinarias Actualizadas Corretamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Editar()
        Me.txtHoras.Enabled = True
        Check_Individual.Enabled = True
    End Sub
End Class
