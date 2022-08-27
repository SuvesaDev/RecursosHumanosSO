Imports Utilidades
Imports System.data.sqlclient

Public Class frmReporte_Horas
    Inherits System.Windows.Forms.Form
    Dim usua As Object

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdProyectos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsReporteProyecto1 As Planilla.dsReporteProyecto
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdEmpleado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.DsReporteProyecto1 = New Planilla.dsReporteProyecto
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdProyectos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.AdEmpleado = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        CType(Me.DsReporteProyecto1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.dtFechaFinal)
        Me.Panel1.Controls.Add(Me.dtFechaInicio)
        Me.Panel1.Controls.Add(Me.ButtonMostrar)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 736)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(24, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Empleado"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.DsReporteProyecto1.Empleado
        Me.ComboBox2.DisplayMember = "Nombre"
        Me.ComboBox2.Location = New System.Drawing.Point(16, 232)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox2.TabIndex = 78
        Me.ComboBox2.ValueMember = "Identificacion"
        '
        'DsReporteProyecto1
        '
        Me.DsReporteProyecto1.DataSetName = "dsReporteProyecto"
        Me.DsReporteProyecto1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(8, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Fecha Final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(8, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Fecha Inicio:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFechaFinal.Location = New System.Drawing.Point(96, 304)
        Me.dtFechaFinal.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaFinal.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtFechaFinal.Size = New System.Drawing.Size(85, 20)
        Me.dtFechaFinal.TabIndex = 75
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFechaInicio.Location = New System.Drawing.Point(96, 272)
        Me.dtFechaInicio.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaInicio.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtFechaInicio.Size = New System.Drawing.Size(85, 20)
        Me.dtFechaInicio.TabIndex = 74
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonMostrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ButtonMostrar.ImageIndex = 0
        Me.ButtonMostrar.Location = New System.Drawing.Point(16, 360)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(152, 48)
        Me.ButtonMostrar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.InactiveCaptionText, System.Drawing.Color.RoyalBlue)
        Me.ButtonMostrar.TabIndex = 21
        Me.ButtonMostrar.Text = "Mostrar Reporte"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton2.Location = New System.Drawing.Point(8, 144)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(168, 40)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.Text = "Detallado por Empleado"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton1.Location = New System.Drawing.Point(8, 104)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(176, 24)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "General por Proyecto"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DsReporteProyecto1.Proyecto
        Me.ComboBox1.DisplayMember = "NombreProyecto"
        Me.ComboBox1.Location = New System.Drawing.Point(24, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "Num_Proyecto"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Proyecto"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=PICHINGA;packet size=4096;integrated security=SSPI;data source=PIC" & _
        "HINGA;persist security info=False;initial catalog=Proyectos"
        '
        'AdProyectos
        '
        Me.AdProyectos.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdProyectos.InsertCommand = Me.SqlInsertCommand1
        Me.AdProyectos.SelectCommand = Me.SqlSelectCommand1
        Me.AdProyectos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Proyecto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NombreProyecto", "NombreProyecto"), New System.Data.Common.DataColumnMapping("CodCliente", "CodCliente"), New System.Data.Common.DataColumnMapping("NombreCliente", "NombreCliente"), New System.Data.Common.DataColumnMapping("Num_Proyecto", "Num_Proyecto")})})
        Me.AdProyectos.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Proyecto WHERE (Num_Proyecto = @Original_Num_Proyecto) AND (CodClient" & _
        "e = @Original_CodCliente) AND (NombreCliente = @Original_NombreCliente) AND (Nom" & _
        "breProyecto = @Original_NombreProyecto)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Proyecto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Proyecto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodCliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodCliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreProyecto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreProyecto", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Proyecto(NombreProyecto, CodCliente, NombreCliente) VALUES (@NombrePr" & _
        "oyecto, @CodCliente, @NombreCliente); SELECT NombreProyecto, CodCliente, NombreC" & _
        "liente, Num_Proyecto FROM Proyecto WHERE (Num_Proyecto = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreProyecto", System.Data.SqlDbType.VarChar, 250, "NombreProyecto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodCliente", System.Data.SqlDbType.Int, 4, "CodCliente"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCliente", System.Data.SqlDbType.VarChar, 250, "NombreCliente"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT NombreProyecto, CodCliente, NombreCliente, Num_Proyecto FROM Proyecto"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Proyecto SET NombreProyecto = @NombreProyecto, CodCliente = @CodCliente, N" & _
        "ombreCliente = @NombreCliente WHERE (Num_Proyecto = @Original_Num_Proyecto) AND " & _
        "(CodCliente = @Original_CodCliente) AND (NombreCliente = @Original_NombreCliente" & _
        ") AND (NombreProyecto = @Original_NombreProyecto); SELECT NombreProyecto, CodCli" & _
        "ente, NombreCliente, Num_Proyecto FROM Proyecto WHERE (Num_Proyecto = @Num_Proye" & _
        "cto)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreProyecto", System.Data.SqlDbType.VarChar, 250, "NombreProyecto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodCliente", System.Data.SqlDbType.Int, 4, "CodCliente"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCliente", System.Data.SqlDbType.VarChar, 250, "NombreCliente"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Proyecto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Proyecto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodCliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodCliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCliente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreProyecto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreProyecto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Proyecto", System.Data.SqlDbType.Int, 4, "Num_Proyecto"))
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptViewer.DisplayGroupTree = False
        Me.rptViewer.Location = New System.Drawing.Point(192, 7)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.ReportSource = Nothing
        Me.rptViewer.ShowGroupTreeButton = False
        Me.rptViewer.ShowRefreshButton = False
        Me.rptViewer.Size = New System.Drawing.Size(752, 656)
        Me.rptViewer.TabIndex = 5
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=PICHINGA;packet size=4096;integrated security=SSPI;data source=PIC" & _
        "HINGA;persist security info=False;initial catalog=Planilla"
        '
        'AdEmpleado
        '
        Me.AdEmpleado.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdEmpleado.InsertCommand = Me.SqlInsertCommand2
        Me.AdEmpleado.SelectCommand = Me.SqlSelectCommand2
        Me.AdEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        Me.AdEmpleado.UpdateCommand = Me.SqlUpdateCommand2
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
        'frmReporte_Horas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(952, 670)
        Me.Controls.Add(Me.rptViewer)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReporte_Horas"
        Me.Text = "Reportes de Horas Laboradas "
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsReporteProyecto1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmReporte_Horas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = GetSetting("Seesoft", "Proyecto", "CONEXION")
        SqlConnection2.ConnectionString = GetSetting("Seesoft", "Planilla", "CONEXION")
        Me.AdProyectos.Fill(Me.DsReporteProyecto1.Proyecto)
        Me.AdEmpleado.Fill(Me.DsReporteProyecto1.Empleado)
    End Sub


    Public Function ViewReport(ByVal sReportName As String, _
                     Optional ByVal sSelectionFormula As String = "", _
                     Optional ByVal param As String = "") As Boolean
        'Declaring variablesables
        Dim intCounter As Integer
        Dim intCounter1 As Integer

        'Crystal Report's report document object
        Dim objReport As New _
                    CrystalDecisions.CrystalReports.Engine.ReportDocument

        'object of table Log on info of Crystal report
        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo

        'Parameter value object of crystal report 
        ' parameters used for adding the value to parameter.
        Dim paraValue As New CrystalDecisions.Shared.ParameterDiscreteValue

        'Current parameter value object(collection) of crystal report parameters.
        Dim currValue As CrystalDecisions.Shared.ParameterValues

        'Sub report object of crystal report.
        Dim mySubReportObject As _
                  CrystalDecisions.CrystalReports.Engine.SubreportObject

        'Sub report document of crystal report.
        Dim mySubRepDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        Dim strParValPair() As String
        Dim strVal() As String
        Dim index As Integer

        Try


            'Load the report
            objReport.Load(sReportName)


            'Check if there are parameters or not in report.
            intCounter = objReport.DataDefinition.ParameterFields.Count

            'As parameter fields collection also picks the selection 
            ' formula which is not the parametermeter
            ' so if total parameter count is 1 then we check whether 
            ' its a parameter or selection formula.

            If intCounter = 1 Then
                If InStr(objReport.DataDefinition.ParameterFields(0).ParameterFieldName, ".", CompareMethod.Text) > 0 Then
                    intCounter = 0
                End If
            End If

            'If there are parameters in report and 
            'user has passed them then split the 
            'parameter string and Apply the values 
            'to there concurent parameters.

            If intCounter > 0 And Trim(param) <> "" Then
                strParValPair = param.Split("&")

                For index = 0 To UBound(strParValPair)
                    If InStr(strParValPair(index), "=") > 0 Then
                        strVal = strParValPair(index).Split("=")
                        paraValue.Value = strVal(1)
                        currValue = objReport.DataDefinition.ParameterFields(strVal(0)).CurrentValues
                        currValue.Add(paraValue)
                        objReport.DataDefinition.ParameterFields(strVal(0)).ApplyCurrentValues(currValue)
                    End If
                Next
            End If


            'Set the connection information to ConInfo object so that we can apply the 
            ' connection information on each table in the reporteport
            ConInfo.ConnectionInfo.UserID = ""
            ConInfo.ConnectionInfo.Password = ""
            ConInfo.ConnectionInfo.ServerName = "DELSERVER"
            ConInfo.ConnectionInfo.DatabaseName = "SEEPOS"

            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
            Next


            ' Loop through each section on the report then look 
            ' through each object in the section
            ' if the object is a subreport, then apply logon info 
            ' on each table of that sub report

            For index = 0 To objReport.ReportDefinition.Sections.Count - 1
                For intCounter = 0 To _
                      objReport.ReportDefinition.Sections(index).ReportObjects.Count - 1
                    With objReport.ReportDefinition.Sections(index)
                        If .ReportObjects(intCounter).Kind = _
                           CrystalDecisions.Shared.ReportObjectKind.SubreportObject Then
                            mySubReportObject = CType(.ReportObjects(intCounter), _
                            CrystalDecisions.CrystalReports.Engine.SubreportObject)
                            mySubRepDoc = _
                             mySubReportObject.OpenSubreport(mySubReportObject.SubreportName)
                            For intCounter1 = 0 To mySubRepDoc.Database.Tables.Count - 1
                                mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                                mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                            Next
                        End If
                    End With
                Next
            Next
            'If there is a selection formula passed to this function then use that
            If sSelectionFormula.Length > 0 Then
                objReport.RecordSelectionFormula = sSelectionFormula
            End If
            'Re setting control 
            'rptViewer.ReportSource = Nothing

            'Set the current report object to report.
            rptViewer.ReportSource = objReport

            'Show the report
            rptViewer.Show()
            Return True
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
         If RadioButton1.Checked = True Then
            Dim ReporteGeneral As New GeneralXFechas
            ReporteGeneral.SetParameterValue(0, Me.ComboBox1.Text)
            ReporteGeneral.SetParameterValue(1, dtFechaInicio.Text)
            ReporteGeneral.SetParameterValue(2, dtFechaFinal.Text)
            Planilla.CrystalReportsConexion.LoadReportViewer(Me.rptViewer, ReporteGeneral)
            Me.rptViewer.Show()
        End If

        If RadioButton2.Checked = True Then
            Dim ReporteEmpleado As New HorasXEmpleado
            ReporteEmpleado.SetParameterValue(0, Me.ComboBox2.SelectedValue)
            ReporteEmpleado.SetParameterValue(1, dtFechaInicio.Text)
            ReporteEmpleado.SetParameterValue(2, dtFechaFinal.Text)
            ReporteEmpleado.SetParameterValue(3, Me.ComboBox1.Text)
            Planilla.CrystalReportsConexion.LoadReportViewer(Me.rptViewer, ReporteEmpleado)
            Me.rptViewer.Show()
        End If

    End Sub


    Function ValidarCheck()
        If RadioButton1.Checked = True Then
            Me.ComboBox1.Enabled = True
            Me.ComboBox2.Enabled = False
        End If
        If RadioButton2.Checked = True Then
            Me.ComboBox1.Enabled = True
            Me.ComboBox2.Enabled = True
        End If

    End Function

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ValidarCheck()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ValidarCheck()
    End Sub
End Class
