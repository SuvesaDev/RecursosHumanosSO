Imports CrystalDecisions.CrystalReports.Engine
Imports DevExpress.Utils
Imports System.Data.SqlClient
Public Class FrmReportes
    Inherits System.Windows.Forms.Form

    Dim Wait As WaitDialogForm
    Dim cconexion1 As New Conexion
    Dim sqlconexion1 As SqlConnection
    Dim cedulajuridica As String = ""
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
    'Friend WithEvents DsReportes As DsReportes
    'Friend WithEvents DaActivos1 As Activos_Fijos.daActivos
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adEmpleado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsReportes As Planilla.DsReportes
    Public WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CBMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CkBEconomicos As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmReportes))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.CkBEconomicos = New System.Windows.Forms.CheckBox
        Me.CBMoneda = New System.Windows.Forms.ComboBox
        Me.DsReportes = New Planilla.DsReportes
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        CType(Me.DsReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.CkBEconomicos)
        Me.Panel1.Controls.Add(Me.CBMoneda)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ButtonMostrar)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 664)
        Me.Panel1.TabIndex = 3
        '
        'RadioButton4
        '
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton4.Location = New System.Drawing.Point(8, 240)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(136, 32)
        Me.RadioButton4.TabIndex = 77787
        Me.RadioButton4.Text = "Empleado Sin cuenta Bancaria"
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton3.Location = New System.Drawing.Point(8, 192)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(136, 32)
        Me.RadioButton3.TabIndex = 77786
        Me.RadioButton3.Text = "Empleado con cuenta Bancaria"
        '
        'CkBEconomicos
        '
        Me.CkBEconomicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkBEconomicos.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CkBEconomicos.Location = New System.Drawing.Point(16, 320)
        Me.CkBEconomicos.Name = "CkBEconomicos"
        Me.CkBEconomicos.Size = New System.Drawing.Size(144, 24)
        Me.CkBEconomicos.TabIndex = 77785
        Me.CkBEconomicos.Text = "Versiones Economicas"
        '
        'CBMoneda
        '
        Me.CBMoneda.DataSource = Me.DsReportes.Moneda
        Me.CBMoneda.DisplayMember = "MonedaNombre"
        Me.CBMoneda.Location = New System.Drawing.Point(32, 64)
        Me.CBMoneda.Name = "CBMoneda"
        Me.CBMoneda.Size = New System.Drawing.Size(112, 21)
        Me.CBMoneda.TabIndex = 77784
        Me.CBMoneda.ValueMember = "CodMoneda"
        '
        'DsReportes
        '
        Me.DsReportes.DataSetName = "DsReportes"
        Me.DsReportes.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(32, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 14)
        Me.Label6.TabIndex = 77783
        Me.Label6.Text = "Moneda"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonMostrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.ButtonMostrar.ImageIndex = 0
        Me.ButtonMostrar.ImageList = Me.ImageList1
        Me.ButtonMostrar.Location = New System.Drawing.Point(24, 384)
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
        Me.RadioButton2.Location = New System.Drawing.Point(8, 144)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(168, 40)
        Me.RadioButton2.TabIndex = 13
        Me.RadioButton2.Text = "Comprobante de Pago Por Empleado"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton1.Location = New System.Drawing.Point(8, 112)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(184, 24)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Reporte General de Planilla"
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
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Planilla"
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
        'AdapterMoneda
        '
        Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda")})})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Moneda(MonedaNombre, CodMoneda) VALUES (@MonedaNombre, @CodMoneda); S" & _
        "ELECT MonedaNombre, CodMoneda FROM Moneda"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT MonedaNombre, CodMoneda FROM Moneda"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'FrmReportes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(976, 662)
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmReportes"
        Me.Text = "Reporte Planillas"
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
        ValidarCheck()
        AdapterMoneda.Fill(DsReportes.Moneda)
        CBMoneda.SelectedIndex = 0
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



    Function ValidarCheck()
        Dim cx As New cFunciones
        'If RadioButton2.Checked = True Then
        '    Me.ComboBox1.DataSource = Nothing
        'End If
        'If RadioButton2.Checked = True Then
        '    Me.ComboBox1.DataSource = Me.DsReportes
        '    Me.ComboBox1.DisplayMember = "Empleado.Nombre"
        'End If
    End Function



    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        ValidarCheck()
        Label6.Visible = RadioButton1.Checked
        CBMoneda.Visible = RadioButton1.Checked
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        ValidarCheck()
        Label6.Visible = RadioButton1.Checked
        CBMoneda.Visible = RadioButton1.Checked
    End Sub

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Try
            sqlconexion1 = cconexion1.Conectar("Planilla")
            'MODIFICACIONES DE ECOLE TRAVEL IA
            cedulajuridica = CStr(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT Cedula FROM Configuraciones"))
            cconexion1.DesConectar(sqlconexion1)

            If frmControlTiempo2.Rept = 1 Then
                Wait = New WaitDialogForm("Generando Reporte")
                ButtonMostrar.Enabled = False

                If RadioButton1.Checked = True Then
                    If CkBEconomicos.Checked = False Then
                        Dim ReportePlanilla As Object

                        If cedulajuridica = "3-101-104775" Then ' Modificado para Buena Vista
                            ReportePlanilla = New ReportePlanilla3
                        ElseIf cedulajuridica = "3-101-1486-2900" Then 'MODIFICACIONES DE ECOLE TRAVEL IA
                            ReportePlanilla = New ReportePlanilla_ECOLE
                        ElseIf cedulajuridica = "3-101-227990" Then 'Modificado para Borinquen
                            ReportePlanilla = New ReportePlanillaBorin
                        Else
                            ReportePlanilla = New ReportePlanilla
                        End If

                        ReportePlanilla.SetParameterValue(0, frmControlTiempo2.IdPlanilla1)
                        ReportePlanilla.SetParameterValue(1, CBMoneda.SelectedValue)
                        Utilidades.CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer2, ReportePlanilla, False, GetSetting("SeeSOFT", "Planilla", "Conexion"))
                        CrystalReportViewer2.Show()
                    Else
                        If cedulajuridica = "3-101-1486-2900" Then 'MODIFICACIONES DE ECOLE TRAVEL IA
                            Dim ReportePlanilla As New ReportePlanilla_Economico_ECOLE
                            ReportePlanilla.SetParameterValue(0, frmControlTiempo2.IdPlanilla1)
                            ReportePlanilla.SetParameterValue(1, CBMoneda.SelectedValue)
                            Utilidades.CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer2, ReportePlanilla, False, GetSetting("SeeSOFT", "Planilla", "Conexion"))
                            CrystalReportViewer2.Show()

                        Else
                            Dim ReportePlanilla As New ReportePlanilla_Economico
                            ReportePlanilla.SetParameterValue(0, frmControlTiempo2.IdPlanilla1)
                            ReportePlanilla.SetParameterValue(1, CBMoneda.SelectedValue)
                            Utilidades.CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer2, ReportePlanilla, False, GetSetting("SeeSOFT", "Planilla", "Conexion"))
                            CrystalReportViewer2.Show()
                        End If

                    End If
                End If

                If RadioButton2.Checked = True Then
                    If CkBEconomicos.Checked = False Then
                        If cedulajuridica = "3-101-1486-2900" Then 'MODIFICACIONES DE ECOLE TRAVEL IA
                            Dim ReporteComprobante As New Comprobante_ECOLE
                            ReporteComprobante.SetParameterValue(0, frmControlTiempo2.IdPlanilla1)
                            Utilidades.CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer2, ReporteComprobante, False, GetSetting("SeeSOFT", "Planilla", "Conexion"))
                            Me.CrystalReportViewer2.Show()
                        Else
                            Dim ReporteComprobante As New Comprobante
                            ReporteComprobante.SetParameterValue(0, frmControlTiempo2.IdPlanilla1)
                            Utilidades.CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer2, ReporteComprobante, False, GetSetting("SeeSOFT", "Planilla", "Conexion"))
                            Me.CrystalReportViewer2.Show()
                        End If

                    Else
                        If cedulajuridica = "3-101-1486-2900" Then 'MODIFICACIONES DE ECOLE TRAVEL IA
                            Dim ReporteComprobante As New Comprobante_Economico_ECOLE
                            ReporteComprobante.SetParameterValue(0, frmControlTiempo2.IdPlanilla1)
                            Utilidades.CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer2, ReporteComprobante, False, GetSetting("SeeSOFT", "Planilla", "Conexion"))
                            Me.CrystalReportViewer2.Show()
                        Else
                            Dim ReporteComprobante As New Comprobante_Economico
                            ReporteComprobante.SetParameterValue(0, frmControlTiempo2.IdPlanilla1)
                            Utilidades.CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer2, ReporteComprobante, False, GetSetting("SeeSOFT", "Planilla", "Conexion"))
                            Me.CrystalReportViewer2.Show()

                        End If

                    End If
                End If
                If RadioButton3.Checked = True Then
                    Dim ReportePlanilla As New ReporteBancario
                    ReportePlanilla.SetParameterValue(0, frmControlTiempo2.IdPlanilla1)
                    Utilidades.CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer2, ReportePlanilla, False, GetSetting("SeeSOFT", "Planilla", "Conexion"))
                    CrystalReportViewer2.Show()
                End If
                If RadioButton4.Checked = True Then
                    Dim ReportePlanilla As New ReporteChecke
                    ReportePlanilla.SetParameterValue(0, frmControlTiempo2.IdPlanilla1)
                    Utilidades.CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer2, ReportePlanilla, False, GetSetting("SeeSOFT", "Planilla", "Conexion"))
                    CrystalReportViewer2.Show()
                End If
            Else

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            Wait.Close()
            ButtonMostrar.Enabled = True
        End Try
    End Sub
End Class
