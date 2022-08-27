Imports CrystalDecisions.CrystalReports.Engine

Public Class ReportesAccion
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    'Friend WithEvents DsReportes As DsReportes
    'Friend WithEvents DaActivos1 As Activos_Fijos.daActivos
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adEmpleado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsReportes As Planilla.DsReportes
    Public WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents adAccion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReportesAccion))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.adEmpleado = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DsReportes = New Planilla.DsReportes
        Me.adAccion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        CType(Me.DsReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.dtFechaFinal)
        Me.Panel1.Controls.Add(Me.dtFechaInicio)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.ButtonMostrar)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 664)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(16, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Fecha Final:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(16, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Fecha Inicio:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFechaFinal.Location = New System.Drawing.Point(96, 320)
        Me.dtFechaFinal.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaFinal.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtFechaFinal.Size = New System.Drawing.Size(85, 20)
        Me.dtFechaFinal.TabIndex = 71
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFechaInicio.Location = New System.Drawing.Point(96, 280)
        Me.dtFechaInicio.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaInicio.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtFechaInicio.Size = New System.Drawing.Size(85, 20)
        Me.dtFechaInicio.TabIndex = 70
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton3.Location = New System.Drawing.Point(8, 144)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(184, 24)
        Me.RadioButton3.TabIndex = 24
        Me.RadioButton3.Text = "Reporte Por Empleado"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(7, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Empleados"
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Location = New System.Drawing.Point(5, 224)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonMostrar.ImageIndex = 0
        Me.ButtonMostrar.ImageList = Me.ImageList1
        Me.ButtonMostrar.Location = New System.Drawing.Point(24, 376)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(152, 48)
        Me.ButtonMostrar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.InactiveCaptionText, System.Drawing.Color.RoyalBlue)
        Me.ButtonMostrar.TabIndex = 21
        Me.ButtonMostrar.Text = "Mostrar Reporte"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(48, 48)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton2.Location = New System.Drawing.Point(8, 96)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(184, 24)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.Text = "Reporte Por Tipo de  Acción"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton1.Location = New System.Drawing.Point(8, 42)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(186, 24)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Reporte Por Fecha"
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer2.DisplayGroupTree = False
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(208, 8)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.ReportSource = Nothing
        Me.CrystalReportViewer2.ShowGroupTreeButton = False
        Me.CrystalReportViewer2.ShowRefreshButton = False
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(768, 656)
        Me.CrystalReportViewer2.TabIndex = 4
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=MARIANO;packet size=4096;integrated security=SSPI;data source=""(lo" & _
        "cal)"";persist security info=False;initial catalog=Planilla"
        '
        'adEmpleado
        '
        Me.adEmpleado.DeleteCommand = Me.SqlDeleteCommand1
        Me.adEmpleado.InsertCommand = Me.SqlInsertCommand1
        Me.adEmpleado.SelectCommand = Me.SqlSelectCommand1
        Me.adEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        Me.adEmpleado.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Empleado WHERE (Identificacion = @Original_Identificacion) AND (Nombr" & _
        "e = @Original_Nombre)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Empleado(Identificacion, Nombre) VALUES (@Identificacion, @Nombre); S" & _
        "ELECT Identificacion, Nombre FROM Empleado WHERE (Identificacion = @Identificaci" & _
        "on)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Identificacion, Nombre FROM Empleado"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Empleado SET Identificacion = @Identificacion, Nombre = @Nombre WHERE (Ide" & _
        "ntificacion = @Original_Identificacion) AND (Nombre = @Original_Nombre); SELECT " & _
        "Identificacion, Nombre FROM Empleado WHERE (Identificacion = @Identificacion)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsReportes
        '
        Me.DsReportes.DataSetName = "DsReportes"
        Me.DsReportes.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'adAccion
        '
        Me.adAccion.DeleteCommand = Me.SqlDeleteCommand2
        Me.adAccion.InsertCommand = Me.SqlInsertCommand2
        Me.adAccion.SelectCommand = Me.SqlSelectCommand2
        Me.adAccion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("RangoFecha", "RangoFecha"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        Me.adAccion.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Accion WHERE (Codigo = @Original_Codigo) AND (Descripcion = @Original" & _
        "_Descripcion) AND (Nombre = @Original_Nombre) AND (RangoFecha = @Original_RangoF" & _
        "echa)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RangoFecha", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RangoFecha", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Accion(Descripcion, RangoFecha, Nombre) VALUES (@Descripcion, @RangoF" & _
        "echa, @Nombre); SELECT Codigo, Descripcion, RangoFecha, Nombre FROM Accion WHERE" & _
        " (Codigo = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RangoFecha", System.Data.SqlDbType.Bit, 1, "RangoFecha"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Codigo, Descripcion, RangoFecha, Nombre FROM Accion"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Accion SET Descripcion = @Descripcion, RangoFecha = @RangoFecha, Nombre = " & _
        "@Nombre WHERE (Codigo = @Original_Codigo) AND (Descripcion = @Original_Descripci" & _
        "on) AND (Nombre = @Original_Nombre) AND (RangoFecha = @Original_RangoFecha); SEL" & _
        "ECT Codigo, Descripcion, RangoFecha, Nombre FROM Accion WHERE (Codigo = @Codigo)" & _
        ""
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RangoFecha", System.Data.SqlDbType.Bit, 1, "RangoFecha"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RangoFecha", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RangoFecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        '
        'ReportesAccion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(976, 662)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ReportesAccion"
        Me.Text = "Reportes Acción del Personal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmEntradaSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cx As New cFunciones
        SqlConnection1.ConnectionString = GetSetting("Seesoft", "Planilla", "CONEXION")
        Me.DsReportes.Clear()
        cx.Llenar_Tabla_Generico("SELECT * FROM Empleado", Me.DsReportes.Empleado)
        cx.Llenar_Tabla_Generico("SELECT * FROM Accion", Me.DsReportes.Accion)
        ValidarCheck()
    End Sub

    Function ValidarCheck()
        Dim cx As New cFunciones
        If RadioButton2.Checked = True Then
            dtFechaInicio.Enabled = False
            dtFechaFinal.Enabled = False
            Me.ComboBox1.Enabled = True
            Me.ComboBox1.DataSource = Me.DsReportes
            Me.ComboBox1.DisplayMember = "Accion.Nombre"
            Label1.Text = "Acciones"
        End If
        If RadioButton3.Checked = True Then
            dtFechaInicio.Enabled = False
            dtFechaFinal.Enabled = False
            Me.ComboBox1.Enabled = True
            Me.ComboBox1.DataSource = Me.DsReportes
            Me.ComboBox1.DisplayMember = "Empleado.Nombre"
            Label1.Text = "Empleados"
        End If
        If RadioButton1.Checked = True Then
            Me.ComboBox1.Enabled = False
            dtFechaInicio.Enabled = True
            dtFechaFinal.Enabled = True
        End If
    End Function



    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ValidarCheck()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ValidarCheck()
    End Sub

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click

            If RadioButton1.Checked = True Then
            Dim ReporteFecha As New AccionPorFecha
            ReporteFecha.SetParameterValue(0, dtFechaInicio.Text)
            ReporteFecha.SetParameterValue(1, dtFechaFinal.Text)
            CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer2, ReporteFecha)
                Me.CrystalReportViewer2.Show()
            End If

            If RadioButton2.Checked = True Then
            Dim ReporteAccion As New ReporteporAccion
            ReporteAccion.SetParameterValue(0, ComboBox1.Text)
            Planilla.CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer2, ReporteAccion)
            Me.CrystalReportViewer2.Show()
        End If

        If RadioButton3.Checked = True Then
            Dim ReporteporEmpleado As New AccionPersonales
            ReporteporEmpleado.SetParameterValue(0, Me.BindingContext(Me.DsReportes, "Empleado").Current("Identificacion"))
            CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer2, ReporteporEmpleado)
            Me.CrystalReportViewer2.Show()
        End If
    End Sub

End Class
