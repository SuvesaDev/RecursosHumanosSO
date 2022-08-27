Imports System.data.sqlclient
Imports Planilla.cFunciones
Imports Utilidades



Public Class frmAumentos
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsAumentos1 As Planilla.dsAumentos
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents adAumentos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adEmpleado As System.Data.SqlClient.SqlDataAdapter
    Protected Friend WithEvents TituloModulo As System.Windows.Forms.Label
    Protected WithEvents ImageList As System.Windows.Forms.ImageList
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Protected Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Public WithEvents DataNavigator As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBarEditar As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAumentos))
        Me.DsAumentos1 = New Planilla.dsAumentos
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.adAumentos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox
        Me.adEmpleado = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEditar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DataNavigator = New DevExpress.XtraEditors.DataNavigator
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.DsAumentos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsAumentos1
        '
        Me.DsAumentos1.DataSetName = "dsAumentos"
        Me.DsAumentos1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=seeserver;packet size=4096;integrated security=SSPI;data source=se" & _
        "eserver;persist security info=False;initial catalog=Planilla"
        '
        'adAumentos
        '
        Me.adAumentos.DeleteCommand = Me.SqlDeleteCommand1
        Me.adAumentos.InsertCommand = Me.SqlInsertCommand1
        Me.adAumentos.SelectCommand = Me.SqlSelectCommand1
        Me.adAumentos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Aumentos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Aumento", "Aumento"), New System.Data.Common.DataColumnMapping("Comentario", "Comentario"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha")})})
        Me.adAumentos.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Aumentos WHERE (Codigo = @Original_Codigo) AND (Aumento = @Original_A" & _
        "umento) AND (Comentario = @Original_Comentario OR @Original_Comentario IS NULL A" & _
        "ND Comentario IS NULL) AND (Fecha = @Original_Fecha)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aumento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aumento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Comentario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comentario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Aumentos(Aumento, Comentario, Fecha) VALUES (@Aumento, @Comentario, @" & _
        "Fecha); SELECT Codigo, Aumento, Comentario, Fecha FROM Aumentos WHERE (Codigo = " & _
        "@@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aumento", System.Data.SqlDbType.Float, 8, "Aumento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Comentario", System.Data.SqlDbType.VarChar, 50, "Comentario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Aumento, Comentario, Fecha FROM Aumentos"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Aumentos SET Aumento = @Aumento, Comentario = @Comentario, Fecha = @Fecha " & _
        "WHERE (Codigo = @Original_Codigo) AND (Aumento = @Original_Aumento) AND (Comenta" & _
        "rio = @Original_Comentario OR @Original_Comentario IS NULL AND Comentario IS NUL" & _
        "L) AND (Fecha = @Original_Fecha); SELECT Codigo, Aumento, Comentario, Fecha FROM" & _
        " Aumentos WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aumento", System.Data.SqlDbType.Float, 8, "Aumento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Comentario", System.Data.SqlDbType.VarChar, 50, "Comentario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aumento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aumento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Comentario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comentario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtClave)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtCedulaUsuario)
        Me.Panel1.Location = New System.Drawing.Point(84, 168)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 32)
        Me.Panel1.TabIndex = 65
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(24, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtClave
        '
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.ForeColor = System.Drawing.Color.Blue
        Me.txtClave.Location = New System.Drawing.Point(104, 0)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(64, 13)
        Me.txtClave.TabIndex = 1
        Me.txtClave.Text = ""
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(176, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(144, 13)
        Me.txtNombreUsuario.TabIndex = 170
        Me.txtNombreUsuario.Text = ""
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
        Me.txtCedulaUsuario.TabIndex = 170
        Me.txtCedulaUsuario.Text = ""
        Me.txtCedulaUsuario.Visible = False
        '
        'adEmpleado
        '
        Me.adEmpleado.DeleteCommand = Me.SqlDeleteCommand2
        Me.adEmpleado.InsertCommand = Me.SqlInsertCommand2
        Me.adEmpleado.SelectCommand = Me.SqlSelectCommand2
        Me.adEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion")})})
        Me.adEmpleado.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Empleado WHERE (Identificacion = @Original_Identificacion) AND (Salar" & _
        "io = @Original_Salario)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Empleado(Salario, Identificacion) VALUES (@Salario, @Identificacion);" & _
        " SELECT Salario, Identificacion FROM Empleado WHERE (Identificacion = @Identific" & _
        "acion)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Salario, Identificacion FROM Empleado"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Empleado SET Salario = @Salario, Identificacion = @Identificacion WHERE (I" & _
        "dentificacion = @Original_Identificacion) AND (Salario = @Original_Salario); SEL" & _
        "ECT Salario, Identificacion FROM Empleado WHERE (Identificacion = @Identificacio" & _
        "n)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
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
        Me.TituloModulo.Size = New System.Drawing.Size(488, 24)
        Me.TituloModulo.TabIndex = 69
        Me.TituloModulo.Text = "Aumento de Salarios"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarEditar, Me.ToolBarRegistrar, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 202)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(488, 52)
        Me.ToolBar1.TabIndex = 70
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarEditar
        '
        Me.ToolBarEditar.ImageIndex = 9
        Me.ToolBarEditar.Text = "Editar"
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
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'DataNavigator
        '
        Me.DataNavigator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.DataMember = "Aumentos"
        Me.DataNavigator.DataSource = Me.DsAumentos1
        Me.DataNavigator.Location = New System.Drawing.Point(344, 224)
        Me.DataNavigator.Name = "DataNavigator"
        Me.DataNavigator.Size = New System.Drawing.Size(134, 21)
        Me.DataNavigator.TabIndex = 71
        Me.DataNavigator.Text = "DataNavigator"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 128)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(288, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Fecha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsAumentos1, "Aumentos.Fecha"))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(288, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 78
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(24, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Porcentaje de Aumento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(20, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(364, 13)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "Observaciones"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumentos1, "Aumentos.Comentario"))
        Me.TextBox2.Location = New System.Drawing.Point(20, 96)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(368, 24)
        Me.TextBox2.TabIndex = 75
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumentos1, "Aumentos.Aumento"))
        Me.TextBox1.Location = New System.Drawing.Point(24, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 13)
        Me.TextBox1.TabIndex = 74
        Me.TextBox1.Text = ""
        '
        'frmAumentos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 254)
        Me.Controls.Add(Me.DataNavigator)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.TituloModulo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAumentos"
        Me.Text = "Formulario de Aumentos"
        CType(Me.DsAumentos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim obj As New cFunciones
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
    Private Sub nuevos()

        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then

            Me.DsAumentos1.Aumentos.Clear()

            Me.BindingContext(Me.DsAumentos1.Aumentos).AddNew()
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 4

            Me.TextBox2.Enabled = True

            Me.TextBox1.Enabled = True
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.DateTimePicker1.Enabled = True
            Me.txtClave.Enabled = True
            Me.TextBox1.Focus()
            Me.ToolBarBuscar.Enabled = False
            Me.ToolBarEditar.Enabled = False

        Else
            Me.BindingContext(Me.DsAumentos1.Aumentos).CancelCurrentEdit()
            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Me.TextBox2.Enabled = False
            Me.TextBox1.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.TextBox2.Text = ""
            Me.TextBox1.Text = ""
            Me.DateTimePicker1.Update()
            Me.ToolBarBuscar.Enabled = True
            Me.ToolBarEditar.Enabled = True
            Me.ToolBarRegistrar.Enabled = False

        End If

    End Sub

    Private Sub frmAumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
            Me.adEmpleado.Fill(Me.DsAumentos1, "Empleado")
            Me.adAumentos.Fill(Me.DsAumentos1, "Aumentos")
            cConexion = New Conexion
            sqlConexion = cConexion.Conectar("Planilla")

            Me.TextBox2.Enabled = False
            Me.TextBox1.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.txtClave.Focus()
            Me.ToolBar1.Buttons(0).Enabled = False
            Me.ToolBar1.Buttons(1).Enabled = False
            Me.ToolBar1.Buttons(2).Enabled = False
            Me.ToolBar1.Buttons(3).Enabled = False

        Catch eEndEdit As System.Data.NoNullAllowedException
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Sub
    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown

        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        If e.KeyCode = Keys.Enter Then
            If txtClave.Text <> "" Then
                rs = cConexion.GetRecorset(cConexion.Conectar2, "SELECT Id_Usuario, Nombre from Usuarios where Clave_Interna ='" & txtClave.Text & "'")
                'Evaluo si el objeto trae datos 
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    Me.txtClave.Text = ""
                    txtClave.Focus()
                End If

                While rs.Read
                    Try
                        Me.txtNombreUsuario.Text = rs!nombre
                        Me.txtCedulaUsuario.Text = rs!Id_Usuario

                        Me.txtClave.Enabled = False

                        Me.ToolBar1.Buttons(0).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = True
                        Me.ToolBar1.Buttons(2).Enabled = True
                        Me.ToolBar1.Buttons(3).Enabled = True

                    Catch eEndEdit As System.Data.NoNullAllowedException
                        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                    End Try
                End While

                rs.Close()
                cConexion.DesConectar(cConexion.Conectar)

            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                txtClave.Focus()
            End If
        End If

    End Sub
    Sub editar()

        Try


            If Me.ToolBarEditar.Text = "Editar" Then
                Me.ToolBarEditar.Text = "Cancel"
                Me.ToolBarEditar.ImageIndex = 4
                Me.ToolBarNuevo.Enabled = False
                Me.ToolBarBuscar.Enabled = False
                '  Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True
                Me.TextBox2.Enabled = True
                Me.TextBox1.Enabled = True
                Me.DateTimePicker1.Enabled = True
                'TextBox8.Focus()
                DataNavigator.Enabled = False
            Else
                Me.BindingContext(Me.DsAumentos1, "Aumentos").CancelCurrentEdit()
                Me.ToolBarEditar.Text = "Editar"
                Me.ToolBarEditar.ImageIndex = 9
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarNuevo.Enabled = True
                ' Me.ToolBarEliminar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                Me.TextBox2.Enabled = False
                Me.TextBox1.Enabled = False
                Me.DateTimePicker1.Enabled = False
                DataNavigator.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub registrar()
        Try
            recorrer()

            Me.ToolBar1.Buttons(0).Enabled = True
            Me.ToolBar1.Buttons(1).Enabled = True
            Me.ToolBar1.Buttons(2).Enabled = False

            Me.TextBox2.Enabled = False
            Me.TextBox1.Enabled = False
            Me.DateTimePicker1.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Function recorrer()

        Dim i As Integer
        Dim Identificacion As String
        Dim Salario, Aumento As Double
        Dim Comentario, Fecha As String


        Try
            Aumento = CDbl(Me.TextBox1.Text)
            Comentario = Me.TextBox2.Text
            Fecha = Me.DateTimePicker1.Text

            For i = 0 To Me.BindingContext(Me.DsAumentos1.Empleado).Count - 1

                Me.BindingContext(Me.DsAumentos1.Empleado).Position = i

                Identificacion = Me.DsAumentos1.Empleado.Rows(i).Item("Identificacion")
                Salario = Me.DsAumentos1.Empleado.Rows(i).Item("Salario")

                Salario = Salario + (Salario * (Aumento / 100))

                Me.DsAumentos1.Empleado.Rows(i).Item("Salario") = Math.Round(Salario, 2)

                Me.BindingContext(Me.DsAumentos1, "Empleado").EndCurrentEdit()

            Next i

            If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction

            'Me muevo en el dataset para actualizar los datos en él 
            If Me.BindingContext(Me.DsAumentos1, "Empleado").Position = 0 Then
                Me.BindingContext(Me.DsAumentos1, "Empleado").Position -= 1

            Else
                Me.BindingContext(Me.DsAumentos1, "Empleado").Position -= 1
                Me.BindingContext(Me.DsAumentos1, "Empleado").Position += 1

            End If
         
            Me.BindingContext(Me.DsAumentos1, "Aumentos").EndCurrentEdit()
           
           

            '--------------------------CAMBIO DE ELIAS----------------------------

            'Me.adAumentos.InsertCommand.Transaction = Trans
            'Me.adAumentos.UpdateCommand.Transaction = Trans
            'Me.adAumentos.DeleteCommand.Transaction = Trans
            'Me.adAumentos.SelectCommand.Transaction = Trans
            'adAumentos.Update(Me.DsAumentos1.Aumentos)

            Dim sql As String
            Dim clsConexion As New Conexion
            Dim cnnConexion As New System.Data.SqlClient.SqlConnection
            sql = "INSERT INTO Aumentos(Aumento,Comentario,Fecha) VALUES(" & Aumento & ",'" & Comentario & "','" & Fecha & "')"
            cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnConexion.Open()
            clsConexion.SlqExecute(cnnConexion, sql)
            cnnConexion.Close()

            '---------------------FIN DEL CAMBIO-----------------------


            Me.adEmpleado.InsertCommand.Transaction = Trans
            Me.adEmpleado.UpdateCommand.Transaction = Trans
            Me.adEmpleado.DeleteCommand.Transaction = Trans
            Me.adEmpleado.SelectCommand.Transaction = Trans
            adEmpleado.Update(Me.DsAumentos1.Empleado)

            Trans.Commit()

            MsgBox("Aumentos Registrados Satisfactoriamente", MsgBoxStyle.Information)

            Me.ToolBar1.Buttons(2).Enabled = False
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try

    End Function




    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If


        Select Case Asc(e.KeyChar)
            Case 13
                Me.TextBox2.Focus()
        End Select

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(Usuario.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1
                nuevos()
            Case 2
                If PMU.Find Then BuscarAumento() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3
                editar()

            Case 4
                If PMU.Update Then
                    If MsgBox("Realmente Desea Aplicar este Aumento Salarial ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        registrar()
                    End If
                Else
                    MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                End If
            Case 5
                Me.Close()
        End Select

        
    End Sub
    Private Sub BuscarAumento()

        Dim fx As New cFunciones
        Dim idem As String
        idem = fx.Buscar_X_Descripcion_Fecha("SELECT Codigo,Aumento,Comentario,Fecha FROM Aumentos ORDER BY Fecha DESC", "Comentario", "Comentario", "Buscador de Aumentos...")
        If idem <> 0 And idem <> "" Then
            fx.Llenar_Tabla_Generico("select * from aumentos where Codigo = " & idem, Me.DsAumentos1.Aumentos, Me.SqlConnection1.ConnectionString)
            Me.ToolBar1.Buttons(3).Enabled = False
        End If

    End Sub

    Private Sub txtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClave.TextChanged

    End Sub
End Class
