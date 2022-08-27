Imports System.Data.SqlClient
Public Class BuscaAccionPersonal
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterBuscaAccionPersonal As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetBuscaAccionPersonal1 As Planilla.DataSetBuscaAccionPersonal
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbtAmbos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFechas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEmpleado As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DateFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents AdapterEmpleado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents AdapterAccion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents colCodigoEmpleado As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoAccion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl = New DevExpress.XtraGrid.GridControl
        Me.DataSetBuscaAccionPersonal1 = New Planilla.DataSetBuscaAccionPersonal
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colCodigoEmpleado = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCodigoAccion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colFecha = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterBuscaAccionPersonal = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rbtAmbos = New System.Windows.Forms.RadioButton
        Me.rbtFechas = New System.Windows.Forms.RadioButton
        Me.rbtEmpleado = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.DateFechaInicio = New DevExpress.XtraEditors.DateEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateFechaFinal = New DevExpress.XtraEditors.DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbEmpleado = New System.Windows.Forms.ComboBox
        Me.AdapterEmpleado = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.AdapterAccion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetBuscaAccionPersonal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DateFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 32)
        Me.Label3.TabIndex = 305
        Me.Label3.Text = "Buscar por -->"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(544, 421)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(56, 23)
        Me.btnCancelar.TabIndex = 304
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(488, 421)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(56, 23)
        Me.btnAceptar.TabIndex = 303
        Me.btnAceptar.Text = "Aceptar"
        '
        'GridControl
        '
        Me.GridControl.DataMember = "AccionPersonal"
        Me.GridControl.DataSource = Me.DataSetBuscaAccionPersonal1
        '
        'GridControl.EmbeddedNavigator
        '
        Me.GridControl.EmbeddedNavigator.Name = ""
        Me.GridControl.Location = New System.Drawing.Point(6, 3)
        Me.GridControl.MainView = Me.AdvBandedGridView1
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2})
        Me.GridControl.Size = New System.Drawing.Size(594, 357)
        Me.GridControl.Styles.AddReplace("Style3", New DevExpress.Utils.ViewStyleEx("Style3", "", New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.SystemColors.Window, System.Drawing.Color.Red, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl.Styles.AddReplace("Style2", New DevExpress.Utils.ViewStyleEx("Style2", "", New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Red, System.Drawing.Color.Red, System.Drawing.Color.IndianRed, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl.Styles.AddReplace("Style1", New DevExpress.Utils.ViewStyleEx("Style1", "", System.Drawing.Color.LightCoral, System.Drawing.Color.White, System.Drawing.Color.Red, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl.Styles.AddReplace("Style4", New DevExpress.Utils.ViewStyleEx("Style4", "", New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), System.Drawing.Color.Red, System.Drawing.Color.Red, System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl.TabIndex = 302
        '
        'DataSetBuscaAccionPersonal1
        '
        Me.DataSetBuscaAccionPersonal1.DataSetName = "DataSetBuscaAccionPersonal"
        Me.DataSetBuscaAccionPersonal1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCodigoEmpleado, Me.colFecha, Me.colCodigoAccion})
        Me.AdvBandedGridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        Me.AdvBandedGridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridBand2
        '
        Me.GridBand2.Columns.Add(Me.colCodigoEmpleado)
        Me.GridBand2.Columns.Add(Me.colCodigoAccion)
        Me.GridBand2.Columns.Add(Me.colFecha)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 561
        '
        'colCodigoEmpleado
        '
        Me.colCodigoEmpleado.Caption = "Empleado"
        Me.colCodigoEmpleado.FieldName = "Nombre_Empleado"
        Me.colCodigoEmpleado.Name = "colCodigoEmpleado"
        Me.colCodigoEmpleado.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigoEmpleado.Visible = True
        Me.colCodigoEmpleado.Width = 257
        '
        'colCodigoAccion
        '
        Me.colCodigoAccion.Caption = "Accion"
        Me.colCodigoAccion.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colCodigoAccion.FieldName = "Id_Accion"
        Me.colCodigoAccion.Name = "colCodigoAccion"
        Me.colCodigoAccion.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigoAccion.Visible = True
        Me.colCodigoAccion.Width = 221
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.DataSetBuscaAccionPersonal1.Accion
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Nombre"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "Codigo"
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFecha.Visible = True
        Me.colFecha.Width = 83
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=SEESER" & _
        "VER;persist security info=False;initial catalog=Planilla"
        '
        'AdapterBuscaAccionPersonal
        '
        Me.AdapterBuscaAccionPersonal.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterBuscaAccionPersonal.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterBuscaAccionPersonal.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterBuscaAccionPersonal.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AccionPersonal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Num_Accion", "Num_Accion"), New System.Data.Common.DataColumnMapping("Id_Empleado", "Id_Empleado"), New System.Data.Common.DataColumnMapping("Nombre_Empleado", "Nombre_Empleado"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Id_Accion", "Id_Accion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("RigeDesde", "RigeDesde"), New System.Data.Common.DataColumnMapping("RigeHasta", "RigeHasta"), New System.Data.Common.DataColumnMapping("DiasaDescontar", "DiasaDescontar"), New System.Data.Common.DataColumnMapping("HechoPor", "HechoPor"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario")})})
        Me.AdapterBuscaAccionPersonal.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM AccionPersonal WHERE (Num_Accion = @Original_Num_Accion) AND (DiasaDe" & _
        "scontar = @Original_DiasaDescontar) AND (Fecha = @Original_Fecha) AND (HechoPor " & _
        "= @Original_HechoPor) AND (Id_Accion = @Original_Id_Accion) AND (Id_Empleado = @" & _
        "Original_Id_Empleado) AND (NombreUsuario = @Original_NombreUsuario) AND (Nombre_" & _
        "Empleado = @Original_Nombre_Empleado) AND (Observaciones = @Original_Observacion" & _
        "es) AND (Puesto = @Original_Puesto) AND (RigeDesde = @Original_RigeDesde) AND (R" & _
        "igeHasta = @Original_RigeHasta)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiasaDescontar", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiasaDescontar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HechoPor", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HechoPor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Accion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeDesde", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeDesde", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeHasta", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeHasta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO AccionPersonal(Num_Accion, Id_Empleado, Nombre_Empleado, Puesto, Id_A" & _
        "ccion, Fecha, Observaciones, RigeDesde, RigeHasta, DiasaDescontar, HechoPor, Nom" & _
        "breUsuario) VALUES (@Num_Accion, @Id_Empleado, @Nombre_Empleado, @Puesto, @Id_Ac" & _
        "cion, @Fecha, @Observaciones, @RigeDesde, @RigeHasta, @DiasaDescontar, @HechoPor" & _
        ", @NombreUsuario); SELECT Num_Accion, Id_Empleado, Nombre_Empleado, Puesto, Id_A" & _
        "ccion, Fecha, Observaciones, RigeDesde, RigeHasta, DiasaDescontar, HechoPor, Nom" & _
        "breUsuario FROM AccionPersonal WHERE (Num_Accion = @Num_Accion)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Accion", System.Data.SqlDbType.BigInt, 8, "Num_Accion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 250, "Id_Empleado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, "Nombre_Empleado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 4, "Id_Accion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeDesde", System.Data.SqlDbType.DateTime, 8, "RigeDesde"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeHasta", System.Data.SqlDbType.DateTime, 8, "RigeHasta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Int, 4, "DiasaDescontar"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HechoPor", System.Data.SqlDbType.VarChar, 75, "HechoPor"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Num_Accion, Id_Empleado, Nombre_Empleado, Puesto, Id_Accion, Fecha, Observ" & _
        "aciones, RigeDesde, RigeHasta, DiasaDescontar, HechoPor, NombreUsuario FROM Acci" & _
        "onPersonal"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE AccionPersonal SET Num_Accion = @Num_Accion, Id_Empleado = @Id_Empleado, N" & _
        "ombre_Empleado = @Nombre_Empleado, Puesto = @Puesto, Id_Accion = @Id_Accion, Fec" & _
        "ha = @Fecha, Observaciones = @Observaciones, RigeDesde = @RigeDesde, RigeHasta =" & _
        " @RigeHasta, DiasaDescontar = @DiasaDescontar, HechoPor = @HechoPor, NombreUsuar" & _
        "io = @NombreUsuario WHERE (Num_Accion = @Original_Num_Accion) AND (DiasaDesconta" & _
        "r = @Original_DiasaDescontar) AND (Fecha = @Original_Fecha) AND (HechoPor = @Ori" & _
        "ginal_HechoPor) AND (Id_Accion = @Original_Id_Accion) AND (Id_Empleado = @Origin" & _
        "al_Id_Empleado) AND (NombreUsuario = @Original_NombreUsuario) AND (Nombre_Emplea" & _
        "do = @Original_Nombre_Empleado) AND (Observaciones = @Original_Observaciones) AN" & _
        "D (Puesto = @Original_Puesto) AND (RigeDesde = @Original_RigeDesde) AND (RigeHas" & _
        "ta = @Original_RigeHasta); SELECT Num_Accion, Id_Empleado, Nombre_Empleado, Pues" & _
        "to, Id_Accion, Fecha, Observaciones, RigeDesde, RigeHasta, DiasaDescontar, Hecho" & _
        "Por, NombreUsuario FROM AccionPersonal WHERE (Num_Accion = @Num_Accion)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Accion", System.Data.SqlDbType.BigInt, 8, "Num_Accion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 250, "Id_Empleado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, "Nombre_Empleado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 150, "Puesto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Accion", System.Data.SqlDbType.Int, 4, "Id_Accion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeDesde", System.Data.SqlDbType.DateTime, 8, "RigeDesde"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RigeHasta", System.Data.SqlDbType.DateTime, 8, "RigeHasta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DiasaDescontar", System.Data.SqlDbType.Int, 4, "DiasaDescontar"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HechoPor", System.Data.SqlDbType.VarChar, 75, "HechoPor"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Accion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DiasaDescontar", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiasaDescontar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HechoPor", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HechoPor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Accion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Empleado", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeDesde", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeDesde", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RigeHasta", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RigeHasta", System.Data.DataRowVersion.Original, Nothing))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.rbtAmbos)
        Me.Panel1.Controls.Add(Me.rbtFechas)
        Me.Panel1.Controls.Add(Me.rbtEmpleado)
        Me.Panel1.Location = New System.Drawing.Point(104, 416)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 32)
        Me.Panel1.TabIndex = 306
        '
        'rbtAmbos
        '
        Me.rbtAmbos.BackColor = System.Drawing.Color.White
        Me.rbtAmbos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAmbos.ForeColor = System.Drawing.Color.RoyalBlue
        Me.rbtAmbos.Location = New System.Drawing.Point(160, 8)
        Me.rbtAmbos.Name = "rbtAmbos"
        Me.rbtAmbos.Size = New System.Drawing.Size(64, 16)
        Me.rbtAmbos.TabIndex = 313
        Me.rbtAmbos.Text = "Ambos"
        '
        'rbtFechas
        '
        Me.rbtFechas.BackColor = System.Drawing.Color.White
        Me.rbtFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFechas.ForeColor = System.Drawing.Color.RoyalBlue
        Me.rbtFechas.Location = New System.Drawing.Point(96, 8)
        Me.rbtFechas.Name = "rbtFechas"
        Me.rbtFechas.Size = New System.Drawing.Size(64, 16)
        Me.rbtFechas.TabIndex = 311
        Me.rbtFechas.Text = "Fechas"
        '
        'rbtEmpleado
        '
        Me.rbtEmpleado.BackColor = System.Drawing.Color.White
        Me.rbtEmpleado.Checked = True
        Me.rbtEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtEmpleado.ForeColor = System.Drawing.Color.RoyalBlue
        Me.rbtEmpleado.Location = New System.Drawing.Point(8, 8)
        Me.rbtEmpleado.Name = "rbtEmpleado"
        Me.rbtEmpleado.Size = New System.Drawing.Size(80, 16)
        Me.rbtEmpleado.TabIndex = 312
        Me.rbtEmpleado.TabStop = True
        Me.rbtEmpleado.Text = "Empleado"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DateFechaInicio)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DateFechaFinal)
        Me.Panel2.Location = New System.Drawing.Point(256, 368)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(344, 40)
        Me.Panel2.TabIndex = 307
        Me.Panel2.Visible = False
        '
        'DateFechaInicio
        '
        Me.DateFechaInicio.EditValue = New Date(2006, 8, 23, 0, 0, 0, 0)
        Me.DateFechaInicio.Location = New System.Drawing.Point(80, 12)
        Me.DateFechaInicio.Name = "DateFechaInicio"
        '
        'DateFechaInicio.Properties
        '
        Me.DateFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateFechaInicio.Size = New System.Drawing.Size(88, 19)
        Me.DateFechaInicio.TabIndex = 277
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(0, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 282
        Me.Label8.Text = "Fecha Inicio"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(176, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 283
        Me.Label1.Text = "Fecha Final"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DateFechaFinal
        '
        Me.DateFechaFinal.EditValue = New Date(2006, 8, 23, 0, 0, 0, 0)
        Me.DateFechaFinal.Location = New System.Drawing.Point(248, 12)
        Me.DateFechaFinal.Name = "DateFechaFinal"
        '
        'DateFechaFinal.Properties
        '
        Me.DateFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateFechaFinal.Size = New System.Drawing.Size(88, 19)
        Me.DateFechaFinal.TabIndex = 284
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(8, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 308
        Me.Label2.Text = "Empleado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbEmpleado
        '
        Me.cmbEmpleado.DataSource = Me.DataSetBuscaAccionPersonal1
        Me.cmbEmpleado.DisplayMember = "Empleado.Nombre"
        Me.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpleado.Location = New System.Drawing.Point(72, 8)
        Me.cmbEmpleado.Name = "cmbEmpleado"
        Me.cmbEmpleado.Size = New System.Drawing.Size(176, 21)
        Me.cmbEmpleado.TabIndex = 309
        Me.cmbEmpleado.ValueMember = "Empleado.Identificacion"
        '
        'AdapterEmpleado
        '
        Me.AdapterEmpleado.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterEmpleado.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterEmpleado.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Estado_Civil", "Estado_Civil"), New System.Data.Common.DataColumnMapping("Hijos", "Hijos"), New System.Data.Common.DataColumnMapping("Cod_Nacionalidad", "Cod_Nacionalidad"), New System.Data.Common.DataColumnMapping("Fecha_Nacimiento", "Fecha_Nacimiento"), New System.Data.Common.DataColumnMapping("Edad", "Edad"), New System.Data.Common.DataColumnMapping("Telefono1", "Telefono1"), New System.Data.Common.DataColumnMapping("Telefono2", "Telefono2"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Puesto", "Puesto"), New System.Data.Common.DataColumnMapping("Fecha_Ingreso", "Fecha_Ingreso"), New System.Data.Common.DataColumnMapping("Fecha_Salida", "Fecha_Salida"), New System.Data.Common.DataColumnMapping("Salario", "Salario"), New System.Data.Common.DataColumnMapping("Cod_Departamento", "Cod_Departamento"), New System.Data.Common.DataColumnMapping("Masculino", "Masculino"), New System.Data.Common.DataColumnMapping("Femenino", "Femenino"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Hora", "Hora"), New System.Data.Common.DataColumnMapping("Diario", "Diario"), New System.Data.Common.DataColumnMapping("Semana", "Semana"), New System.Data.Common.DataColumnMapping("Quincena", "Quincena"), New System.Data.Common.DataColumnMapping("Mensual", "Mensual"), New System.Data.Common.DataColumnMapping("Cod_Estado", "Cod_Estado"), New System.Data.Common.DataColumnMapping("Foto", "Foto")})})
        Me.AdapterEmpleado.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Empleado WHERE (Identificacion = @Original_Identificacion) AND (Cod_D" & _
        "epartamento = @Original_Cod_Departamento) AND (Cod_Estado = @Original_Cod_Estado" & _
        ") AND (Cod_Moneda = @Original_Cod_Moneda) AND (Cod_Nacionalidad = @Original_Cod_" & _
        "Nacionalidad) AND (Diario = @Original_Diario) AND (Direccion = @Original_Direcci" & _
        "on) AND (Edad = @Original_Edad) AND (Email = @Original_Email) AND (Estado_Civil " & _
        "= @Original_Estado_Civil) AND (Fecha_Ingreso = @Original_Fecha_Ingreso) AND (Fec" & _
        "ha_Nacimiento = @Original_Fecha_Nacimiento) AND (Fecha_Salida = @Original_Fecha_" & _
        "Salida) AND (Femenino = @Original_Femenino) AND (Hijos = @Original_Hijos) AND (H" & _
        "ora = @Original_Hora) AND (Masculino = @Original_Masculino) AND (Mensual = @Orig" & _
        "inal_Mensual) AND (Nombre = @Original_Nombre) AND (Puesto = @Original_Puesto) AN" & _
        "D (Quincena = @Original_Quincena) AND (Salario = @Original_Salario) AND (Semana " & _
        "= @Original_Semana) AND (Telefono1 = @Original_Telefono1) AND (Telefono2 = @Orig" & _
        "inal_Telefono2)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Departamento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Departamento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Nacionalidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Edad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Estado_Civil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado_Civil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nacimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Femenino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Femenino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Masculino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Masculino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Empleado(Identificacion, Nombre, Estado_Civil, Hijos, Cod_Nacionalida" & _
        "d, Fecha_Nacimiento, Edad, Telefono1, Telefono2, Email, Direccion, Puesto, Fecha" & _
        "_Ingreso, Fecha_Salida, Salario, Cod_Departamento, Masculino, Femenino, Cod_Mone" & _
        "da, Hora, Diario, Semana, Quincena, Mensual, Cod_Estado, Foto) VALUES (@Identifi" & _
        "cacion, @Nombre, @Estado_Civil, @Hijos, @Cod_Nacionalidad, @Fecha_Nacimiento, @E" & _
        "dad, @Telefono1, @Telefono2, @Email, @Direccion, @Puesto, @Fecha_Ingreso, @Fecha" & _
        "_Salida, @Salario, @Cod_Departamento, @Masculino, @Femenino, @Cod_Moneda, @Hora," & _
        " @Diario, @Semana, @Quincena, @Mensual, @Cod_Estado, @Foto); SELECT Identificaci" & _
        "on, Nombre, Estado_Civil, Hijos, Cod_Nacionalidad, Fecha_Nacimiento, Edad, Telef" & _
        "ono1, Telefono2, Email, Direccion, Puesto, Fecha_Ingreso, Fecha_Salida, Salario," & _
        " Cod_Departamento, Masculino, Femenino, Cod_Moneda, Hora, Diario, Semana, Quince" & _
        "na, Mensual, Cod_Estado, Foto FROM Empleado WHERE (Identificacion = @Identificac" & _
        "ion)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 50, "Estado_Civil"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 4, "Hijos"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, "Cod_Nacionalidad"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, "Fecha_Nacimiento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 50, "Telefono1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 50, "Telefono2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 100, "Puesto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 4, "Cod_Departamento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 1, "Masculino"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 1, "Femenino"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Identificacion, Nombre, Estado_Civil, Hijos, Cod_Nacionalidad, Fecha_Nacim" & _
        "iento, Edad, Telefono1, Telefono2, Email, Direccion, Puesto, Fecha_Ingreso, Fech" & _
        "a_Salida, Salario, Cod_Departamento, Masculino, Femenino, Cod_Moneda, Hora, Diar" & _
        "io, Semana, Quincena, Mensual, Cod_Estado, Foto FROM Empleado"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Empleado SET Identificacion = @Identificacion, Nombre = @Nombre, Estado_Ci" & _
        "vil = @Estado_Civil, Hijos = @Hijos, Cod_Nacionalidad = @Cod_Nacionalidad, Fecha" & _
        "_Nacimiento = @Fecha_Nacimiento, Edad = @Edad, Telefono1 = @Telefono1, Telefono2" & _
        " = @Telefono2, Email = @Email, Direccion = @Direccion, Puesto = @Puesto, Fecha_I" & _
        "ngreso = @Fecha_Ingreso, Fecha_Salida = @Fecha_Salida, Salario = @Salario, Cod_D" & _
        "epartamento = @Cod_Departamento, Masculino = @Masculino, Femenino = @Femenino, C" & _
        "od_Moneda = @Cod_Moneda, Hora = @Hora, Diario = @Diario, Semana = @Semana, Quinc" & _
        "ena = @Quincena, Mensual = @Mensual, Cod_Estado = @Cod_Estado, Foto = @Foto WHER" & _
        "E (Identificacion = @Original_Identificacion) AND (Cod_Departamento = @Original_" & _
        "Cod_Departamento) AND (Cod_Estado = @Original_Cod_Estado) AND (Cod_Moneda = @Ori" & _
        "ginal_Cod_Moneda) AND (Cod_Nacionalidad = @Original_Cod_Nacionalidad) AND (Diari" & _
        "o = @Original_Diario) AND (Direccion = @Original_Direccion) AND (Edad = @Origina" & _
        "l_Edad) AND (Email = @Original_Email) AND (Estado_Civil = @Original_Estado_Civil" & _
        ") AND (Fecha_Ingreso = @Original_Fecha_Ingreso) AND (Fecha_Nacimiento = @Origina" & _
        "l_Fecha_Nacimiento) AND (Fecha_Salida = @Original_Fecha_Salida) AND (Femenino = " & _
        "@Original_Femenino) AND (Hijos = @Original_Hijos) AND (Hora = @Original_Hora) AN" & _
        "D (Masculino = @Original_Masculino) AND (Mensual = @Original_Mensual) AND (Nombr" & _
        "e = @Original_Nombre) AND (Puesto = @Original_Puesto) AND (Quincena = @Original_" & _
        "Quincena) AND (Salario = @Original_Salario) AND (Semana = @Original_Semana) AND " & _
        "(Telefono1 = @Original_Telefono1) AND (Telefono2 = @Original_Telefono2); SELECT " & _
        "Identificacion, Nombre, Estado_Civil, Hijos, Cod_Nacionalidad, Fecha_Nacimiento," & _
        " Edad, Telefono1, Telefono2, Email, Direccion, Puesto, Fecha_Ingreso, Fecha_Sali" & _
        "da, Salario, Cod_Departamento, Masculino, Femenino, Cod_Moneda, Hora, Diario, Se" & _
        "mana, Quincena, Mensual, Cod_Estado, Foto FROM Empleado WHERE (Identificacion = " & _
        "@Identificacion)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 100, "Nombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Estado_Civil", System.Data.SqlDbType.VarChar, 50, "Estado_Civil"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijos", System.Data.SqlDbType.Int, 4, "Hijos"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, "Cod_Nacionalidad"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, "Fecha_Nacimiento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Edad", System.Data.SqlDbType.Int, 4, "Edad"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono1", System.Data.SqlDbType.VarChar, 50, "Telefono1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono2", System.Data.SqlDbType.VarChar, 50, "Telefono2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.VarChar, 100, "Email"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 250, "Direccion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Puesto", System.Data.SqlDbType.VarChar, 100, "Puesto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, "Fecha_Ingreso"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Salida", System.Data.SqlDbType.DateTime, 8, "Fecha_Salida"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salario", System.Data.SqlDbType.Float, 8, "Salario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Departamento", System.Data.SqlDbType.Int, 4, "Cod_Departamento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Masculino", System.Data.SqlDbType.Bit, 1, "Masculino"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Femenino", System.Data.SqlDbType.Bit, 1, "Femenino"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hora", System.Data.SqlDbType.Bit, 1, "Hora"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Diario", System.Data.SqlDbType.Bit, 1, "Diario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Semana", System.Data.SqlDbType.Bit, 1, "Semana"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Quincena", System.Data.SqlDbType.Bit, 1, "Quincena"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mensual", System.Data.SqlDbType.Bit, 1, "Mensual"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Estado", System.Data.SqlDbType.Int, 4, "Cod_Estado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Foto", System.Data.SqlDbType.VarBinary, 2147483647, "Foto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Departamento", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Departamento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Estado", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Nacionalidad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Nacionalidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Diario", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Direccion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Edad", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Edad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Estado_Civil", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado_Civil", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Ingreso", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Nacimiento", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Nacimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha_Salida", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha_Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Femenino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Femenino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hora", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hora", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Masculino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Masculino", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mensual", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mensual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Puesto", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Puesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Quincena", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Quincena", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Semana", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Semana", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono2", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono2", System.Data.DataRowVersion.Original, Nothing))
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cmbEmpleado)
        Me.Panel3.Location = New System.Drawing.Point(0, 376)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(256, 32)
        Me.Panel3.TabIndex = 310
        '
        'AdapterAccion
        '
        Me.AdapterAccion.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterAccion.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterAccion.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterAccion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("RangoFecha", "RangoFecha")})})
        Me.AdapterAccion.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Accion WHERE (Codigo = @Original_Codigo) AND (Descripcion = @Original" & _
        "_Descripcion) AND (Nombre = @Original_Nombre) AND (RangoFecha = @Original_RangoF" & _
        "echa)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RangoFecha", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RangoFecha", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Accion(Nombre, Descripcion, RangoFecha) VALUES (@Nombre, @Descripcion" & _
        ", @RangoFecha); SELECT Codigo, Nombre, Descripcion, RangoFecha FROM Accion WHERE" & _
        " (Codigo = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RangoFecha", System.Data.SqlDbType.Bit, 1, "RangoFecha"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Codigo, Nombre, Descripcion, RangoFecha FROM Accion"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Accion SET Nombre = @Nombre, Descripcion = @Descripcion, RangoFecha = @Ran" & _
        "goFecha WHERE (Codigo = @Original_Codigo) AND (Descripcion = @Original_Descripci" & _
        "on) AND (Nombre = @Original_Nombre) AND (RangoFecha = @Original_RangoFecha); SEL" & _
        "ECT Codigo, Nombre, Descripcion, RangoFecha FROM Accion WHERE (Codigo = @Codigo)" & _
        ""
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RangoFecha", System.Data.SqlDbType.Bit, 1, "RangoFecha"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RangoFecha", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RangoFecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(432, 421)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(56, 23)
        Me.btnBuscar.TabIndex = 311
        Me.btnBuscar.Text = "Buscar"
        '
        'BuscaAccionPersonal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 476)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GridControl)
        Me.MaximumSize = New System.Drawing.Size(650, 510)
        Me.MinimumSize = New System.Drawing.Size(608, 500)
        Me.Name = "BuscaAccionPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetBuscaAccionPersonal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DateFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public id As Integer
    Private Sub BuscaAccionPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
        Try
            Me.AdapterEmpleado.Fill(Me.DataSetBuscaAccionPersonal1.Empleado)
            Me.AdapterAccion.Fill(Me.DataSetBuscaAccionPersonal1.Accion)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

#Region "Buscar"
    Sub busca()
        Dim dt As New DataTable
        Dim adaptador As New SqlDataAdapter
        Dim strEmpleado = "Id_Empleado= '" & Me.cmbEmpleado.SelectedValue & "'"
        Dim strFechas = "Fecha BETWEEN '" & CDate(DateFechaInicio.Text).Date & "'AND " & _
         "'" & CDate(Me.DateFechaFinal.Text).Date & "'"
        Dim str = "SELECT * FROM AccionPersonal WHERE "
        Try
            If Me.rbtFechas.Checked = True Then
                str &= strFechas
            ElseIf Me.rbtEmpleado.Checked = True Then
                str &= strEmpleado
            Else
                str &= strEmpleado & " AND " & strFechas
            End If
            Dim fu As New cFunciones
            Me.DataSetBuscaAccionPersonal1.AccionPersonal.Clear()
            fu.Cargar_Tabla_Generico(Me.AdapterBuscaAccionPersonal, str)
            Me.AdapterBuscaAccionPersonal.Fill(Me.DataSetBuscaAccionPersonal1.AccionPersonal)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

    Private Sub rbtEmpleado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEmpleado.CheckedChanged
        Me.Panel3.Visible = True
        Me.Panel2.Visible = False
    End Sub

    Private Sub rbtFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtFechas.CheckedChanged
        Me.Panel2.Visible = True
        Me.Panel3.Visible = False
    End Sub

    Private Sub rbtAmbos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAmbos.CheckedChanged
        Me.Panel2.Visible = True
        Me.Panel3.Visible = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        id = -1
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.BindingContext(Me.DataSetBuscaAccionPersonal1, "AccionPersonal").Position >= 0 Then
            id = Me.BindingContext(Me.DataSetBuscaAccionPersonal1, "AccionPersonal").Current("Num_Accion")
        Else
            id = -1
        End If
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        busca()
    End Sub

    Private Sub DateFechaFinal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateFechaFinal.KeyPress
        e.Handled = True
    End Sub

    Private Sub DateFechaInicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateFechaInicio.KeyPress
        e.Handled = True
    End Sub
End Class
