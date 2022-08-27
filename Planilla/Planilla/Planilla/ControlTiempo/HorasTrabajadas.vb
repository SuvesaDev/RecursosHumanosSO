Imports System.data.sqlclient
Imports Utilidades
Public Class HorasTrabajadas
    Inherits FrmPlantilla
    Dim Id As Long
    Dim buscando As Boolean
    Public Shared FechaEmpleado As Integer
    Public TablaHoras As New DataTable
    Dim Identificacion As Integer
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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adProyecto As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adEmpleado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsProyectoHoras As Planilla.DsProyectoHoras
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsEmpleadoHoras As Planilla.DsEmpleadoHoras
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents adHorasLaboradas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents adEmpleadoProyecto As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents dtInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DsProyectoHoras = New Planilla.DsProyectoHoras
        Me.Label25 = New System.Windows.Forms.Label
        Me.DsEmpleadoHoras = New Planilla.DsEmpleadoHoras
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.adProyecto = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.adEmpleado = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.adHorasLaboradas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.adEmpleadoProyecto = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.dtInicio = New System.Windows.Forms.DateTimePicker
        CType(Me.DsProyectoHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpleadoHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 412)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(818, 52)
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(818, 32)
        Me.TituloModulo.Text = "Horas Laboradas"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DsProyectoHoras
        Me.ComboBox1.DisplayMember = "Proyecto.NombreProyecto"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(40, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(304, 23)
        Me.ComboBox1.TabIndex = 194
        '
        'DsProyectoHoras
        '
        Me.DsProyectoHoras.DataSetName = "DsProyectoHoras"
        Me.DsProyectoHoras.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label25.Location = New System.Drawing.Point(40, 48)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(304, 13)
        Me.Label25.TabIndex = 193
        Me.Label25.Text = "Nombre del Proyecto"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DsEmpleadoHoras
        '
        Me.DsEmpleadoHoras.DataSetName = "DsEmpleadoHoras"
        Me.DsEmpleadoHoras.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MARIANO;packet size=4096;integrated security=SSPI;data source=PICH" & _
        "INGA;persist security info=False;initial catalog=Proyectos"
        '
        'adProyecto
        '
        Me.adProyecto.DeleteCommand = Me.SqlDeleteCommand1
        Me.adProyecto.InsertCommand = Me.SqlInsertCommand1
        Me.adProyecto.SelectCommand = Me.SqlSelectCommand1
        Me.adProyecto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Proyecto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Num_Proyecto", "Num_Proyecto"), New System.Data.Common.DataColumnMapping("NombreProyecto", "NombreProyecto")})})
        Me.adProyecto.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Proyecto WHERE (Num_Proyecto = @Original_Num_Proyecto) AND (NombrePro" & _
        "yecto = @Original_NombreProyecto)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Proyecto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Proyecto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreProyecto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreProyecto", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Proyecto(NombreProyecto) VALUES (@NombreProyecto); SELECT Num_Proyect" & _
        "o, NombreProyecto FROM Proyecto WHERE (Num_Proyecto = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreProyecto", System.Data.SqlDbType.VarChar, 250, "NombreProyecto"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Num_Proyecto, NombreProyecto FROM Proyecto"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Proyecto SET NombreProyecto = @NombreProyecto WHERE (Num_Proyecto = @Origi" & _
        "nal_Num_Proyecto) AND (NombreProyecto = @Original_NombreProyecto); SELECT Num_Pr" & _
        "oyecto, NombreProyecto FROM Proyecto WHERE (Num_Proyecto = @Num_Proyecto)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreProyecto", System.Data.SqlDbType.VarChar, 250, "NombreProyecto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Proyecto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Proyecto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreProyecto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreProyecto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Proyecto", System.Data.SqlDbType.Int, 4, "Num_Proyecto"))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=MARIANO;packet size=4096;integrated security=SSPI;data source=PICH" & _
        "INGA;persist security info=False;initial catalog=Planilla"
        '
        'adEmpleado
        '
        Me.adEmpleado.DeleteCommand = Me.SqlDeleteCommand2
        Me.adEmpleado.InsertCommand = Me.SqlInsertCommand2
        Me.adEmpleado.SelectCommand = Me.SqlSelectCommand2
        Me.adEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        Me.adEmpleado.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Empleado WHERE (Identificacion = @Original_Identificacion) AND (Nombr" & _
        "e = @Original_Nombre)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Empleado(Identificacion, Nombre) VALUES (@Identificacion, @Nombre); S" & _
        "ELECT Identificacion, Nombre FROM Empleado WHERE (Identificacion = @Identificaci" & _
        "on)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection2
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Identificacion, Nombre FROM Empleado"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Empleado SET Identificacion = @Identificacion, Nombre = @Nombre WHERE (Ide" & _
        "ntificacion = @Original_Identificacion) AND (Nombre = @Original_Nombre); SELECT " & _
        "Identificacion, Nombre FROM Empleado WHERE (Identificacion = @Identificacion)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(488, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "Fecha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsProyectoHoras, "Proyecto.Num_Proyecto"))
        Me.TextBox1.Location = New System.Drawing.Point(488, 352)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(32, 20)
        Me.TextBox1.TabIndex = 205
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEmpleadoHoras, "Empleado.Identificacion"))
        Me.TextBox2.Location = New System.Drawing.Point(536, 352)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(32, 20)
        Me.TextBox2.TabIndex = 206
        Me.TextBox2.Text = ""
        '
        'adHorasLaboradas
        '
        Me.adHorasLaboradas.DeleteCommand = Me.SqlDeleteCommand3
        Me.adHorasLaboradas.InsertCommand = Me.SqlInsertCommand3
        Me.adHorasLaboradas.SelectCommand = Me.SqlSelectCommand3
        Me.adHorasLaboradas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "HorasTrabajadas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("HoraOrdinaria", "HoraOrdinaria"), New System.Data.Common.DataColumnMapping("HoraExtra", "HoraExtra"), New System.Data.Common.DataColumnMapping("HoraDoble", "HoraDoble"), New System.Data.Common.DataColumnMapping("Id_Proyecto", "Id_Proyecto")})})
        Me.adHorasLaboradas.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM HorasTrabajadas WHERE (Id = @Original_Id) AND (Fecha = @Original_Fech" & _
        "a) AND (HoraDoble = @Original_HoraDoble) AND (HoraExtra = @Original_HoraExtra) A" & _
        "ND (HoraOrdinaria = @Original_HoraOrdinaria) AND (Id_Proyecto = @Original_Id_Pro" & _
        "yecto) AND (Identificacion = @Original_Identificacion)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoraDoble", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraDoble", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoraExtra", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraExtra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoraOrdinaria", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraOrdinaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Proyecto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Proyecto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO HorasTrabajadas(Identificacion, Fecha, HoraOrdinaria, HoraExtra, Hora" & _
        "Doble, Id_Proyecto) VALUES (@Identificacion, @Fecha, @HoraOrdinaria, @HoraExtra," & _
        " @HoraDoble, @Id_Proyecto); SELECT Id, Identificacion, Fecha, HoraOrdinaria, Hor" & _
        "aExtra, HoraDoble, Id_Proyecto FROM HorasTrabajadas WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection2
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 20, "Identificacion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoraOrdinaria", System.Data.SqlDbType.Float, 8, "HoraOrdinaria"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoraExtra", System.Data.SqlDbType.VarChar, 10, "HoraExtra"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoraDoble", System.Data.SqlDbType.VarChar, 10, "HoraDoble"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Proyecto", System.Data.SqlDbType.Int, 4, "Id_Proyecto"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id, Identificacion, Fecha, HoraOrdinaria, HoraExtra, HoraDoble, Id_Proyect" & _
        "o FROM HorasTrabajadas"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE HorasTrabajadas SET Identificacion = @Identificacion, Fecha = @Fecha, Hora" & _
        "Ordinaria = @HoraOrdinaria, HoraExtra = @HoraExtra, HoraDoble = @HoraDoble, Id_P" & _
        "royecto = @Id_Proyecto WHERE (Id = @Original_Id) AND (Fecha = @Original_Fecha) A" & _
        "ND (HoraDoble = @Original_HoraDoble) AND (HoraExtra = @Original_HoraExtra) AND (" & _
        "HoraOrdinaria = @Original_HoraOrdinaria) AND (Id_Proyecto = @Original_Id_Proyect" & _
        "o) AND (Identificacion = @Original_Identificacion); SELECT Id, Identificacion, F" & _
        "echa, HoraOrdinaria, HoraExtra, HoraDoble, Id_Proyecto FROM HorasTrabajadas WHER" & _
        "E (Id = @Id)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 20, "Identificacion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoraOrdinaria", System.Data.SqlDbType.Float, 8, "HoraOrdinaria"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoraExtra", System.Data.SqlDbType.VarChar, 10, "HoraExtra"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HoraDoble", System.Data.SqlDbType.VarChar, 10, "HoraDoble"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Proyecto", System.Data.SqlDbType.Int, 4, "Id_Proyecto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoraDoble", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraDoble", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoraExtra", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraExtra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HoraOrdinaria", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoraOrdinaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Proyecto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Proyecto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(16, 136)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(784, 256)
        Me.GridControl1.Styles.AddReplace("Preview", New DevExpress.Utils.ViewStyleEx("Preview", "Grid", New System.Drawing.Font("Tahoma", 10.0!), "", True, True, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Top, Nothing, System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(10, Byte), CType(36, Byte), CType(106, Byte)), System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FooterPanel", New DevExpress.Utils.ViewStyleEx("FooterPanel", "Grid", New System.Drawing.Font("Tahoma", 10.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupButton", New DevExpress.Utils.ViewStyleEx("GroupButton", "Grid", New System.Drawing.Font("Tahoma", 10.0!), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FilterCloseButton", New DevExpress.Utils.ViewStyleEx("FilterCloseButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(118, Byte), CType(170, Byte), CType(225, Byte)), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("EvenRow", New DevExpress.Utils.ViewStyleEx("EvenRow", "Grid", New System.Drawing.Font("Tahoma", 10.0!), CType((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.GhostWhite, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("HideSelectionRow", New DevExpress.Utils.ViewStyleEx("HideSelectionRow", "Grid", New System.Drawing.Font("Tahoma", 10.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FixedLine", New DevExpress.Utils.ViewStyleEx("FixedLine", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(58, Byte), CType(58, Byte), CType(58, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("HeaderPanel", New DevExpress.Utils.ViewStyleEx("HeaderPanel", "Grid", New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupPanel", New DevExpress.Utils.ViewStyleEx("GroupPanel", "Grid", New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(58, Byte), CType(110, Byte), CType(165, Byte)), System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("Empty", New DevExpress.Utils.ViewStyleEx("Empty", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(232, Byte), CType(228, Byte), CType(220, Byte)), System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupFooter", New DevExpress.Utils.ViewStyleEx("GroupFooter", "Grid", New System.Drawing.Font("Tahoma", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(222, Byte), CType(218, Byte), CType(210, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupRow", New DevExpress.Utils.ViewStyleEx("GroupRow", "Grid", New System.Drawing.Font("Tahoma", 10.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("HorzLine", New DevExpress.Utils.ViewStyleEx("HorzLine", "Grid", New System.Drawing.Font("Tahoma", 10.0!), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Gray, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButton", New DevExpress.Utils.ViewStyleEx("ColumnFilterButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(232, Byte), CType(228, Byte), CType(220, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FocusedRow", New DevExpress.Utils.ViewStyleEx("FocusedRow", "Grid", New System.Drawing.Font("Tahoma", 10.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(10, Byte), CType(36, Byte), CType(106, Byte)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(60, Byte), CType(86, Byte), CType(156, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("VertLine", New DevExpress.Utils.ViewStyleEx("VertLine", "Grid", New System.Drawing.Font("Tahoma", 10.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Gray, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FocusedCell", New DevExpress.Utils.ViewStyleEx("FocusedCell", "Grid", New System.Drawing.Font("Tahoma", 10.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(225, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("OddRow", New DevExpress.Utils.ViewStyleEx("OddRow", "Grid", New System.Drawing.Font("Tahoma", 10.0!), CType((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor), DevExpress.Utils.StyleOptions), System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal))
        Me.GridControl1.Styles.AddReplace("SelectedRow", New DevExpress.Utils.ViewStyleEx("SelectedRow", "Grid", New System.Drawing.Font("Tahoma", 10.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(20, Byte), CType(46, Byte), CType(116, Byte)), System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("Row", New DevExpress.Utils.ViewStyleEx("Row", "Grid", New System.Drawing.Font("Tahoma", 10.0!), DevExpress.Utils.StyleOptions.StyleEnabled, System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FilterPanel", New DevExpress.Utils.ViewStyleEx("FilterPanel", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(28, Byte), CType(80, Byte), CType(135, Byte)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("RowSeparator", New DevExpress.Utils.ViewStyleEx("RowSeparator", "Grid", New System.Drawing.Font("Arial", 8.0!), DevExpress.Utils.StyleOptions.StyleEnabled, System.Drawing.Color.White, System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(232, Byte), CType(228, Byte), CType(220, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.LightGray, System.Drawing.Color.Blue, System.Drawing.Color.WhiteSmoke, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("DetailTip", New DevExpress.Utils.ViewStyleEx("DetailTip", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(225, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 207
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.FixedLineWidth = 1
        Me.GridView1.GroupFormat = ""
        Me.GridView1.GroupPanelText = "Horas Trabajadas de Empleados"
        Me.GridView1.Name = "GridView1"
        '
        'adEmpleadoProyecto
        '
        Me.adEmpleadoProyecto.DeleteCommand = Me.SqlDeleteCommand4
        Me.adEmpleadoProyecto.InsertCommand = Me.SqlInsertCommand4
        Me.adEmpleadoProyecto.SelectCommand = Me.SqlSelectCommand4
        Me.adEmpleadoProyecto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado_Proyecto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Id_Proyecto", "Id_Proyecto")})})
        Me.adEmpleadoProyecto.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Empleado_Proyecto WHERE (Id = @Original_Id) AND (Id_Proyecto = @Origi" & _
        "nal_Id_Proyecto) AND (Identificacion = @Original_Identificacion)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Proyecto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Proyecto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Empleado_Proyecto(Identificacion, Id_Proyecto) VALUES (@Identificacio" & _
        "n, @Id_Proyecto); SELECT Id, Identificacion, Id_Proyecto FROM Empleado_Proyecto " & _
        "WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection2
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Proyecto", System.Data.SqlDbType.Int, 4, "Id_Proyecto"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Id, Identificacion, Id_Proyecto FROM Empleado_Proyecto"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Empleado_Proyecto SET Identificacion = @Identificacion, Id_Proyecto = @Id_" & _
        "Proyecto WHERE (Id = @Original_Id) AND (Id_Proyecto = @Original_Id_Proyecto) AND" & _
        " (Identificacion = @Original_Identificacion); SELECT Id, Identificacion, Id_Proy" & _
        "ecto FROM Empleado_Proyecto WHERE (Id = @Id)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Proyecto", System.Data.SqlDbType.Int, 4, "Id_Proyecto"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Proyecto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Proyecto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'dtInicio
        '
        Me.dtInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtInicio.Enabled = False
        Me.dtInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtInicio.Location = New System.Drawing.Point(488, 72)
        Me.dtInicio.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtInicio.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtInicio.Size = New System.Drawing.Size(128, 22)
        Me.dtInicio.TabIndex = 208
        '
        'HorasTrabajadas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(818, 464)
        Me.Controls.Add(Me.dtInicio)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "HorasTrabajadas"
        Me.Text = "Formulario Horas Trabajadas"
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.Label25, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.dtInicio, 0)
        CType(Me.DsProyectoHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpleadoHoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Funcion As New cFunciones
            Id = Funcion.BuscarDatos("Select Num_Proyecto, NombreProyecto from Proyecto", "NombreProyecto", "Buscar Proyecto ...", Me.SqlConnection1.ConnectionString)
            Me.ComboBox1.Text = cFunciones.descripcion
            Me.TextBox1.Text = Id
        End If
        If e.KeyCode = Keys.Enter Then
            'Me.LlenarEmpleados(Id)
            dtInicio.Focus()
        End If

    End Sub
    Function LlenarEmpleados(ByVal Id As Long)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        'Dentro de un Try/Catch por si se produce un error
        Try

            '''''''''LLENAR EMPLEADOS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT Empleado.Identificacion, Empleado.Nombre FROM Empleado INNER JOIN Empleado_Proyecto ON Empleado.Identificacion = Empleado_Proyecto.Identificacion and Empleado_Proyecto.Id_Proyecto = @Id"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.Int))
            cmdv.Parameters("@Id").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DsEmpleadoHoras, "Empleado")
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
    Function CrearTabla()
      
        Me.TablaHoras.Clear()
        Me.TablaHoras.Columns.Clear()
        Me.CrearColumnas("Identificacion", "Cédula", 20, 0, "Identificacion", False, False, False)
        Me.TablaHoras.Columns.Add(New DataColumn("Identificacion", GetType(String)))

        Me.CrearColumnas("Nombre", "Nombre del Empleado", 300, 1, "Nombre", False, False, False)
        Me.TablaHoras.Columns.Add(New DataColumn("Nombre", GetType(String)))

        Me.CrearColumnas("HoraOrdinaria", "H. Ordinarias", 175, 2, "HoraOrdinaria", True, True, True)
        Me.TablaHoras.Columns.Add(New DataColumn("HoraOrdinaria", GetType(Double)))

        Me.CrearColumnas("HoraExtra", "H. Extras", 125, 3, "HoraExtra", True, True, True)
        Me.TablaHoras.Columns.Add(New DataColumn("HoraExtra", GetType(Double)))

        Me.CrearColumnas("HoraDoble", "H. Dobles", 125, 4, "HoraDoble", True, True, True)
        Me.TablaHoras.Columns.Add(New DataColumn("HoraDoble", GetType(Double)))

    End Function

    Function CrearColumnas(ByVal Nombre As String, ByVal Titulo As String, ByVal Tamano As Int16, ByVal Orden As Int16, ByVal Campo As String, ByVal Numerico As Boolean, ByVal Editable As Boolean, ByVal Calculadora As Boolean)
        Dim Column = Me.GridView1.Columns.Add
        Column.Caption = Titulo
        Column.fieldname = Campo
        Column.Name = Nombre
        Column.VisibleIndex = Orden
        Column.width = Tamano
        If Numerico = True Then
            Column.displayformat.formattype = DevExpress.Utils.FormatType.Numeric
            Column.displayformat.formatstring = "#,#0.00"

        End If
        If Editable = False Then
            Column.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions) Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused
        Else
            Column.options = DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused
        End If
        If Calculadora = True Then
            '  Column.columnedit = RepositoryItemCalcEdit1
        End If
        'Me.GridView1.Columns.AddRange(Column)

    End Function

    Private Sub CargarDatos()
        Dim dr As DataRow
        Dim i, j, n, Id_Proyecto As Integer

        Me.adEmpleado.Fill(Me.DsEmpleadoHoras.Empleado)
        Me.adEmpleadoProyecto.Fill(Me.DsEmpleadoHoras.Empleado_Proyecto)
        Me.TablaHoras.Clear()
        Try
            For i = 0 To Me.DsEmpleadoHoras.Empleado_Proyecto.Rows.Count - 1

                If Me.DsEmpleadoHoras.Empleado_Proyecto.Rows(i).Item("Id_Proyecto") = Me.TextBox1.Text Then

                    dr = Me.TablaHoras.NewRow
                    dr("Identificacion") = Me.DsEmpleadoHoras.Empleado_Proyecto.Rows(i).Item("Identificacion").ToString
                    Id_Proyecto = Me.DsEmpleadoHoras.Empleado_Proyecto.Rows(i).Item("Id_Proyecto").ToString
                    dr("HoraOrdinaria") = 0
                    dr("HoraExtra") = 0
                    dr("HoraDoble") = 0

                    Me.TablaHoras.Rows.Add(dr)
                    For j = 0 To Me.DsEmpleadoHoras.Empleado.Rows.Count - 1
                        If dr("Identificacion") = Me.DsEmpleadoHoras.Empleado.Rows(j).Item("Identificacion") Then
                            dr("Nombre") = Me.DsEmpleadoHoras.Empleado.Rows(j).Item("Nombre").ToString
                            Exit For
                        End If
                    Next
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub HorasTrabajadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection2.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
            SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Proyecto", "Conexion")
            ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(4).Enabled = False
            ToolBar1.Buttons(5).Enabled = False

            Me.adEmpleado.Fill(Me.DsEmpleadoHoras.Empleado)
            Me.adEmpleadoProyecto.Fill(Me.DsEmpleadoHoras.Empleado_Proyecto)
            Dim ii As Integer = Me.DsEmpleadoHoras.Empleado_Proyecto.Rows.Count
            Me.Bloquear()
            CrearTabla()
            Me.GridControl1.DataSource = Me.TablaHoras
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()

            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : Editar()

            Case 4 : If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Delete Then eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : imprimir()

            Case 7 : Me.Close()

        End Select
    End Sub

    Private Sub imprimir()
        Try

        Catch ex As Exception
            MsgBox("Problemas al Mostrar Reporte !!!", MsgBoxStyle.Information)
        End Try
    End Sub
    Private Function Nuevo()
        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            'cambia la imagen de nuevo y desabilita los botones
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Try 'inicia la edicion
                Me.DsEmpleadoHoras.Clear()
                Me.DsProyectoHoras.Clear()
                Me.TablaHoras.Clear()
                Me.dtInicio.ResetText()

                Me.DesBloquear()

                Me.ToolBar1.Buttons(1).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = True
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.ToolBar1.Buttons(5).Enabled = True
                Me.ComboBox1.Focus()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                Me.BindingContext(Me.DsEmpleadoHoras, "HorasTrabajadas").CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.GridControl1.DataSource.clear()
                Me.Bloquear()
                Me.DsEmpleadoHoras.Clear()
                Me.DsProyectoHoras.Clear()
                Me.ComboBox1.Text = ""
                'me.ComboBox2.Text = ""
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Function

    Private Function Buscar()
        Dim funcion As New cFunciones
        Dim Id As String
        Dim FechaEmplea As String

        Try
            Me.DsEmpleadoHoras.HorasTrabajadas.Clear()
            Me.GridControl1.DataSource.clear()

            FechaEmpleado = 2
            Identificacion = funcion.BuscarDatos("Select * from HorasTrabajadas", "Identificacion", "Buscar Horas Laboradas ...", SqlConnection2.ConnectionString, FechaEmpleado)
            FechaEmpleado = 0
            buscando = True
            Id = cFunciones.descripcion
            If Identificacion = 0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Function
            End If
            Me.LlenaHoras(Identificacion)
            Me.LlenaEmpleado(Id)
            'nuevo
            Me.ToolBar1.Buttons(0).Enabled = True
            'buscar
            Me.ToolBar1.Buttons(1).Enabled = True
            'editar
            ' Me.ToolBar1.Buttons(2).Enabled = True
            'registrar
            Me.ToolBar1.Buttons(3).Enabled = False
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

    Function Editar()
        Me.DesBloquear()
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
        Dim i As Integer

        If Me.SqlConnection2.State <> Me.SqlConnection2.State.Open Then Me.SqlConnection2.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection2.BeginTransaction
        Try
            If ValidarDatos() Then
                'finaliza la edición

                For i = 0 To Me.TablaHoras.Rows.Count - 1
                    If Me.TablaHoras.Rows(i).Item("HoraOrdinaria") = 0 And Me.TablaHoras.Rows(i).Item("HoraExtra") = 0 And Me.TablaHoras.Rows(i).Item("HoraDoble") = 0 Then
                    Else
                        Me.BindingContext(Me.DsEmpleadoHoras, "HorasTrabajadas").AddNew()
                        Me.BindingContext(Me.DsEmpleadoHoras, "HorasTrabajadas").Current("Identificacion") = Me.TablaHoras.Rows(i).Item("Identificacion").ToString
                        Me.BindingContext(Me.DsEmpleadoHoras, "HorasTrabajadas").Current("Fecha") = Me.dtInicio.Value
                        Me.BindingContext(Me.DsEmpleadoHoras, "HorasTrabajadas").Current("HoraOrdinaria") = Me.TablaHoras.Rows(i).Item("HoraOrdinaria")
                        Me.BindingContext(Me.DsEmpleadoHoras, "HorasTrabajadas").Current("HoraExtra") = Me.TablaHoras.Rows(i).Item("HoraExtra")
                        Me.BindingContext(Me.DsEmpleadoHoras, "HorasTrabajadas").Current("HoraDoble") = Me.TablaHoras.Rows(i).Item("HoraDoble")
                        Me.BindingContext(Me.DsEmpleadoHoras, "HorasTrabajadas").Current("Id_Proyecto") = TextBox1.Text
                        Me.BindingContext(Me.DsEmpleadoHoras, "HorasTrabajadas").EndCurrentEdit()
                    End If
                Next


                Me.adHorasLaboradas.UpdateCommand.Transaction = Trans
                Me.adHorasLaboradas.InsertCommand.Transaction = Trans
                Me.adHorasLaboradas.DeleteCommand.Transaction = Trans


                Me.adHorasLaboradas.Update(Me.DsEmpleadoHoras.HorasTrabajadas)
                Trans.Commit()
                Me.DsEmpleadoHoras.AcceptChanges()
                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.Bloquear()
                Me.TablaHoras.Clear()
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
                Me.DsEmpleadoHoras.HorasTrabajadas.Clear()
                Me.DsEmpleadoHoras.Empleado.Clear()
                Me.DsProyectoHoras.Proyecto.Clear()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Trans.Rollback()
        End Try
    End Function
    Private Sub eliminar()
        Dim Cconexion As New Conexion
        Dim Resultado As String
        If Me.ComboBox1.Text <> "" Then

            If MessageBox.Show(" ¿ Desea Eliminar este las horas de este Empleado ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub
            Resultado = Cconexion.SlqExecute(Cconexion.Conectar, "Delete from HorasTrabajadas where Id ='" & Identificacion & "'")
            If Resultado = vbNullString Then
                MessageBox.Show("Las Horas Fueron eliminadas", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DsEmpleadoHoras.HorasTrabajadas.Clear()
                Me.GridControl1.DataSource.clear()
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
    'Private Function imprimir()
    '    Try
    '        Dim Imprimir_Departamentos As New ListadoDepartamento
    '        Dim visor As New frmVisorReportes
    '        visor.rptViewer.ReportSource = Imprimir_Departamentos
    '        visor.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
    '    End Try
    'End Function
    Function Bloquear()
        Me.ComboBox1.Enabled = False

        dtInicio.Enabled = False

    End Function
    Function DesBloquear()
        Me.ComboBox1.Enabled = True
        dtInicio.Enabled = True
        'CalcEdit2.Enabled = True
        'txtValorMetro.Enabled = True
        'CalcEdit1.Enabled = True
    End Function
    Function ValidarDatos() As Boolean
        ValidarDatos = False
        If ComboBox1.Text = "" Then
            MsgBox("Debe Seleccionar el Nombre del Proyecto", MsgBoxStyle.Information, "Sistema SeeSoft")
            ComboBox1.Focus()
            Exit Function
        End If

        'If CalcEdit2.Text = "" And txtValorMetro.Text = "" And CalcEdit1.Text = "" Then
        '    MsgBox("Debe ingresar las Horas Laboradas", MsgBoxStyle.Information, "Sistema SeeSoft")
        '    CalcEdit2.Focus()
        '    Exit Function
        'End If

        ValidarDatos = True
    End Function

    Function LlenaHoras(ByVal Id As Long)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim i As Integer
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        'Dentro de un Try/Catch por si se produce un error
        Try

            '''''''''LLENAR HORAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM HorasTrabajadas WHERE Id = @Id "
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.Int))
            cmdv.Parameters("@Id").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DsEmpleadoHoras, "HorasTrabajadas")
            'Me.adEmpleados.Fill(Me.DsPlanilla1, "Empleado")
            'TxtIdentificacion.Text = ""
            ' funcion.Llenar_Tabla_Generico("Select * from Empleado", Me.TablaEmpleado, Me.SqlConnection2.ConnectionString)
            'If Me.DsPlanilla1.Empleado.Rows.Count - 1 = -1 Then
            '    Me.LlenarEmpleado(Id)
            'End If

            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            Dim dr As DataRow

            dr = Me.TablaHoras.NewRow

            dr("Identificacion") = Me.DsEmpleadoHoras.HorasTrabajadas.Rows(0).Item("Identificacion").ToString

            For i = 0 To Me.DsEmpleadoHoras.Empleado.Rows.Count - 1
                If dr("Identificacion") = Me.DsEmpleadoHoras.Empleado.Rows(i).Item("Identificacion") Then
                    dr("Nombre") = Me.DsEmpleadoHoras.Empleado.Rows(i).Item("Nombre").ToString
                End If
            Next

            dr("HoraOrdinaria") = Me.DsEmpleadoHoras.HorasTrabajadas.Rows(0).Item("HoraOrdinaria").ToString
            dr("HoraExtra") = Me.DsEmpleadoHoras.HorasTrabajadas.Rows(0).Item("HoraExtra").ToString
            dr("HoraDoble") = Me.DsEmpleadoHoras.HorasTrabajadas.Rows(0).Item("HoraDoble").ToString
            dtInicio.Value = Me.DsEmpleadoHoras.HorasTrabajadas.Rows(0).Item("Fecha").ToString
            Me.TablaHoras.Rows.Add(dr)


            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
            Dim Id_Proyecto As Integer
            Id_Proyecto = Me.BindingContext(Me.DsEmpleadoHoras, "HorasTrabajadas").Current("Id_Proyecto")
            Me.LlenaProyecto(Id_Proyecto)
        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
        Finally
        End Try
    End Function
    Function LlenaEmpleado(ByVal Id As String)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        'Dentro de un Try/Catch por si se produce un error
        Try

            '''''''''LLENAR EMPLEADOS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Empleado WHERE (Identificacion = @Id_Empleado) "
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Empleado", SqlDbType.VarChar))
            cmdv.Parameters("@Id_Empleado").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DsEmpleadoHoras, "Empleado")
            'Me.adEmpleados.Fill(Me.DsPlanilla1, "Empleado")
            'TxtIdentificacion.Text = ""
            ' funcion.Llenar_Tabla_Generico("Select * from Empleado", Me.TablaEmpleado, Me.SqlConnection2.ConnectionString)
            'If Me.DsPlanilla1.Empleado.Rows.Count - 1 = -1 Then
            '    Me.LlenarEmpleado(Id)
            'End If

            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.

            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If

            '''''''''LLENAR DEDUCCIONES''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
        Finally
        End Try

    End Function
    Function LlenaProyecto(ByVal Id As Long)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        'Dentro de un Try/Catch por si se produce un error
        Try

            '''''''''LLENAR HORAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = GetSetting("SeeSoft", "Proyecto", "CONEXION")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT Num_Proyecto, NombreProyecto FROM Proyecto WHERE Num_Proyecto = @Id "
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.Int))
            cmdv.Parameters("@Id").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DsProyectoHoras, "Proyecto")
            'Me.adEmpleados.Fill(Me.DsPlanilla1, "Empleado")
            'TxtIdentificacion.Text = ""
            ' funcion.Llenar_Tabla_Generico("Select * from Empleado", Me.TablaEmpleado, Me.SqlConnection2.ConnectionString)
            'If Me.DsPlanilla1.Empleado.Rows.Count - 1 = -1 Then
            '    Me.LlenarEmpleado(Id)
            'End If

            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
        Finally
        End Try
    End Function


    Private Sub dtInicio_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.GridControl1.DataSource.clear()
            CargarDatos()

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
