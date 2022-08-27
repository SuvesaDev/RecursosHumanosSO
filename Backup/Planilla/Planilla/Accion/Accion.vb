Imports System.Data.SqlClient
Imports Utilidades

Public Class Accion
    Inherits Plantilla
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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterAccion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetAccion1 As Planilla.DataSetAccion
    Friend WithEvents ckRango As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CKIncapacidad As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CKEmbarazo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CKINS As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPorIncapacidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPorEmbarazo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPorINS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ck_Vacaciones As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Accion))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterAccion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DataSetAccion1 = New Planilla.DataSetAccion
        Me.ckRango = New DevExpress.XtraEditors.CheckEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtAccion = New DevExpress.XtraEditors.TextEdit
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CKIncapacidad = New DevExpress.XtraEditors.CheckEdit
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CKEmbarazo = New DevExpress.XtraEditors.CheckEdit
        Me.Button3 = New System.Windows.Forms.Button
        Me.CKINS = New DevExpress.XtraEditors.CheckEdit
        Me.txtPorIncapacidad = New DevExpress.XtraEditors.TextEdit
        Me.txtPorEmbarazo = New DevExpress.XtraEditors.TextEdit
        Me.txtPorINS = New DevExpress.XtraEditors.TextEdit
        Me.Ck_Vacaciones = New DevExpress.XtraEditors.CheckEdit
        CType(Me.DataSetAccion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckRango.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CKIncapacidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CKEmbarazo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CKINS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorIncapacidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorEmbarazo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorINS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ck_Vacaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
        Me.ToolBarExcel.ImageIndex = 9
        Me.ToolBarExcel.Text = "Editar"
        Me.ToolBarExcel.Visible = True
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(410, 32)
        Me.TituloModulo.TabIndex = 0
        Me.TituloModulo.Text = "Formulario de Acciones"
        '
        'ToolBar1
        '
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 196)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(410, 52)
        Me.ToolBar1.TabIndex = 15
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=Oscar;" & _
        "persist security info=False;initial catalog=Planilla"
        '
        'AdapterAccion
        '
        Me.AdapterAccion.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterAccion.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterAccion.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterAccion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Accion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("RangoFecha", "RangoFecha"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Incapacidad", "Incapacidad"), New System.Data.Common.DataColumnMapping("PorIncapacidad", "PorIncapacidad"), New System.Data.Common.DataColumnMapping("Embarazo", "Embarazo"), New System.Data.Common.DataColumnMapping("PorEmbarazo", "PorEmbarazo"), New System.Data.Common.DataColumnMapping("INS", "INS"), New System.Data.Common.DataColumnMapping("PorINS", "PorINS"), New System.Data.Common.DataColumnMapping("Vacaciones", "Vacaciones")})})
        Me.AdapterAccion.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Accion WHERE (Codigo = @Original_Codigo) AND (Descripcion = @Original" & _
        "_Descripcion) AND (Embarazo = @Original_Embarazo) AND (INS = @Original_INS) AND " & _
        "(Incapacidad = @Original_Incapacidad) AND (Nombre = @Original_Nombre) AND (PorEm" & _
        "barazo = @Original_PorEmbarazo) AND (PorINS = @Original_PorINS) AND (PorIncapaci" & _
        "dad = @Original_PorIncapacidad) AND (RangoFecha = @Original_RangoFecha) AND (Vac" & _
        "aciones = @Original_Vacaciones)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Embarazo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Embarazo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_INS", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "INS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Incapacidad", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Incapacidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PorEmbarazo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PorEmbarazo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PorINS", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PorINS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PorIncapacidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PorIncapacidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RangoFecha", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RangoFecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Vacaciones", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vacaciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Accion(Descripcion, RangoFecha, Nombre, Incapacidad, PorIncapacidad, " & _
        "Embarazo, PorEmbarazo, INS, PorINS, Vacaciones) VALUES (@Descripcion, @RangoFech" & _
        "a, @Nombre, @Incapacidad, @PorIncapacidad, @Embarazo, @PorEmbarazo, @INS, @PorIN" & _
        "S, @Vacaciones); SELECT Codigo, Descripcion, RangoFecha, Nombre, Incapacidad, Po" & _
        "rIncapacidad, Embarazo, PorEmbarazo, INS, PorINS, Vacaciones FROM Accion WHERE (" & _
        "Codigo = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RangoFecha", System.Data.SqlDbType.Bit, 1, "RangoFecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Incapacidad", System.Data.SqlDbType.Bit, 1, "Incapacidad"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PorIncapacidad", System.Data.SqlDbType.Float, 8, "PorIncapacidad"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Embarazo", System.Data.SqlDbType.Bit, 1, "Embarazo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PorEmbarazo", System.Data.SqlDbType.Float, 8, "PorEmbarazo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@INS", System.Data.SqlDbType.Bit, 1, "INS"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PorINS", System.Data.SqlDbType.Float, 8, "PorINS"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vacaciones", System.Data.SqlDbType.Bit, 1, "Vacaciones"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Descripcion, RangoFecha, Nombre, Incapacidad, PorIncapacidad, Emba" & _
        "razo, PorEmbarazo, INS, PorINS, Vacaciones FROM Accion"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Accion SET Descripcion = @Descripcion, RangoFecha = @RangoFecha, Nombre = " & _
        "@Nombre, Incapacidad = @Incapacidad, PorIncapacidad = @PorIncapacidad, Embarazo " & _
        "= @Embarazo, PorEmbarazo = @PorEmbarazo, INS = @INS, PorINS = @PorINS, Vacacione" & _
        "s = @Vacaciones WHERE (Codigo = @Original_Codigo) AND (Descripcion = @Original_D" & _
        "escripcion) AND (Embarazo = @Original_Embarazo) AND (INS = @Original_INS) AND (I" & _
        "ncapacidad = @Original_Incapacidad) AND (Nombre = @Original_Nombre) AND (PorEmba" & _
        "razo = @Original_PorEmbarazo) AND (PorINS = @Original_PorINS) AND (PorIncapacida" & _
        "d = @Original_PorIncapacidad) AND (RangoFecha = @Original_RangoFecha) AND (Vacac" & _
        "iones = @Original_Vacaciones); SELECT Codigo, Descripcion, RangoFecha, Nombre, I" & _
        "ncapacidad, PorIncapacidad, Embarazo, PorEmbarazo, INS, PorINS, Vacaciones FROM " & _
        "Accion WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RangoFecha", System.Data.SqlDbType.Bit, 1, "RangoFecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Incapacidad", System.Data.SqlDbType.Bit, 1, "Incapacidad"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PorIncapacidad", System.Data.SqlDbType.Float, 8, "PorIncapacidad"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Embarazo", System.Data.SqlDbType.Bit, 1, "Embarazo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PorEmbarazo", System.Data.SqlDbType.Float, 8, "PorEmbarazo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@INS", System.Data.SqlDbType.Bit, 1, "INS"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PorINS", System.Data.SqlDbType.Float, 8, "PorINS"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vacaciones", System.Data.SqlDbType.Bit, 1, "Vacaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Embarazo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Embarazo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_INS", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "INS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Incapacidad", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Incapacidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PorEmbarazo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PorEmbarazo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PorINS", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PorINS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PorIncapacidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PorIncapacidad", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RangoFecha", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RangoFecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Vacaciones", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vacaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        '
        'DataSetAccion1
        '
        Me.DataSetAccion1.DataSetName = "DataSetAccion"
        Me.DataSetAccion1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'ckRango
        '
        Me.ckRango.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetAccion1, "Accion.RangoFecha"))
        Me.ckRango.EditValue = False
        Me.ckRango.Location = New System.Drawing.Point(8, 128)
        Me.ckRango.Name = "ckRango"
        '
        'ckRango.Properties
        '
        Me.ckRango.Properties.Caption = "Rango Fecha"
        Me.ckRango.Properties.Enabled = False
        Me.ckRango.Size = New System.Drawing.Size(96, 19)
        Me.ckRango.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(0, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Descripción"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(0, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(408, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nombre Acción"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtAccion
        '
        Me.txtAccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccion1, "Accion.Nombre"))
        Me.txtAccion.EditValue = ""
        Me.txtAccion.Location = New System.Drawing.Point(0, 56)
        Me.txtAccion.Name = "txtAccion"
        '
        'txtAccion.Properties
        '
        Me.txtAccion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccion.Properties.Enabled = False
        Me.txtAccion.Size = New System.Drawing.Size(408, 19)
        Me.txtAccion.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAccion1, "Accion.Descripcion"))
        Me.txtDescripcion.EditValue = ""
        Me.txtDescripcion.Location = New System.Drawing.Point(0, 96)
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        'txtDescripcion.Properties
        '
        Me.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Properties.Enabled = False
        Me.txtDescripcion.Size = New System.Drawing.Size(408, 19)
        Me.txtDescripcion.TabIndex = 4
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'CKIncapacidad
        '
        Me.CKIncapacidad.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetAccion1, "Accion.Incapacidad"))
        Me.CKIncapacidad.EditValue = False
        Me.CKIncapacidad.Location = New System.Drawing.Point(136, 136)
        Me.CKIncapacidad.Name = "CKIncapacidad"
        '
        'CKIncapacidad.Properties
        '
        Me.CKIncapacidad.Properties.Caption = "Incapacidad por Enfermedad"
        Me.CKIncapacidad.Properties.Enabled = False
        Me.CKIncapacidad.Size = New System.Drawing.Size(168, 19)
        Me.CKIncapacidad.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(356, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 17)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "%"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(356, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(16, 17)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "%"
        '
        'CKEmbarazo
        '
        Me.CKEmbarazo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetAccion1, "Accion.Embarazo"))
        Me.CKEmbarazo.EditValue = False
        Me.CKEmbarazo.Location = New System.Drawing.Point(136, 152)
        Me.CKEmbarazo.Name = "CKEmbarazo"
        '
        'CKEmbarazo.Properties
        '
        Me.CKEmbarazo.Properties.Caption = "Incapacidad por Embarazo"
        Me.CKEmbarazo.Properties.Enabled = False
        Me.CKEmbarazo.Size = New System.Drawing.Size(168, 19)
        Me.CKEmbarazo.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(355, 168)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(16, 17)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "%"
        '
        'CKINS
        '
        Me.CKINS.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetAccion1, "Accion.INS"))
        Me.CKINS.EditValue = False
        Me.CKINS.Location = New System.Drawing.Point(136, 168)
        Me.CKINS.Name = "CKINS"
        '
        'CKINS.Properties
        '
        Me.CKINS.Properties.Caption = "Incapacidad por INS"
        Me.CKINS.Properties.Enabled = False
        Me.CKINS.Size = New System.Drawing.Size(168, 19)
        Me.CKINS.TabIndex = 12
        '
        'txtPorIncapacidad
        '
        Me.txtPorIncapacidad.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetAccion1, "Accion.PorIncapacidad"))
        Me.txtPorIncapacidad.EditValue = "0"
        Me.txtPorIncapacidad.Location = New System.Drawing.Point(304, 136)
        Me.txtPorIncapacidad.Name = "txtPorIncapacidad"
        '
        'txtPorIncapacidad.Properties
        '
        Me.txtPorIncapacidad.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtPorIncapacidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorIncapacidad.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtPorIncapacidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorIncapacidad.Properties.Enabled = False
        Me.txtPorIncapacidad.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Navy)
        Me.txtPorIncapacidad.Size = New System.Drawing.Size(48, 19)
        Me.txtPorIncapacidad.TabIndex = 7
        '
        'txtPorEmbarazo
        '
        Me.txtPorEmbarazo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetAccion1, "Accion.PorEmbarazo"))
        Me.txtPorEmbarazo.EditValue = "0"
        Me.txtPorEmbarazo.Location = New System.Drawing.Point(304, 152)
        Me.txtPorEmbarazo.Name = "txtPorEmbarazo"
        '
        'txtPorEmbarazo.Properties
        '
        Me.txtPorEmbarazo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorEmbarazo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorEmbarazo.Properties.Enabled = False
        Me.txtPorEmbarazo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Navy)
        Me.txtPorEmbarazo.Size = New System.Drawing.Size(48, 19)
        Me.txtPorEmbarazo.TabIndex = 10
        '
        'txtPorINS
        '
        Me.txtPorINS.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetAccion1, "Accion.PorINS"))
        Me.txtPorINS.EditValue = "0"
        Me.txtPorINS.Location = New System.Drawing.Point(304, 168)
        Me.txtPorINS.Name = "txtPorINS"
        '
        'txtPorINS.Properties
        '
        Me.txtPorINS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorINS.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPorINS.Properties.Enabled = False
        Me.txtPorINS.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Navy)
        Me.txtPorINS.Size = New System.Drawing.Size(48, 19)
        Me.txtPorINS.TabIndex = 13
        '
        'Ck_Vacaciones
        '
        Me.Ck_Vacaciones.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetAccion1, "Accion.Vacaciones"))
        Me.Ck_Vacaciones.EditValue = False
        Me.Ck_Vacaciones.Location = New System.Drawing.Point(136, 120)
        Me.Ck_Vacaciones.Name = "Ck_Vacaciones"
        '
        'Ck_Vacaciones.Properties
        '
        Me.Ck_Vacaciones.Properties.Caption = "Vacaciones"
        Me.Ck_Vacaciones.Properties.Enabled = False
        Me.Ck_Vacaciones.Size = New System.Drawing.Size(168, 19)
        Me.Ck_Vacaciones.TabIndex = 16
        '
        'Accion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(410, 248)
        Me.Controls.Add(Me.Ck_Vacaciones)
        Me.Controls.Add(Me.txtPorINS)
        Me.Controls.Add(Me.txtPorEmbarazo)
        Me.Controls.Add(Me.txtPorIncapacidad)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CKINS)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CKEmbarazo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CKIncapacidad)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ckRango)
        Me.Controls.Add(Me.txtAccion)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Accion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acciones"
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txtAccion, 0)
        Me.Controls.SetChildIndex(Me.ckRango, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.CKIncapacidad, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.CKEmbarazo, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Controls.SetChildIndex(Me.CKINS, 0)
        Me.Controls.SetChildIndex(Me.Button3, 0)
        Me.Controls.SetChildIndex(Me.txtPorIncapacidad, 0)
        Me.Controls.SetChildIndex(Me.txtPorEmbarazo, 0)
        Me.Controls.SetChildIndex(Me.txtPorINS, 0)
        Me.Controls.SetChildIndex(Me.Ck_Vacaciones, 0)
        CType(Me.DataSetAccion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckRango.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CKIncapacidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CKEmbarazo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CKINS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorIncapacidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorEmbarazo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorINS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ck_Vacaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim busca As BuscaAccion

    Private Sub Accion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
        Me.DataSetAccion1.Accion.NombreColumn.DefaultValue = ""
        Me.DataSetAccion1.Accion.DescripcionColumn.DefaultValue = ""
        Me.DataSetAccion1.Accion.RangoFechaColumn.DefaultValue = False
        Me.DataSetAccion1.Accion.IncapacidadColumn.DefaultValue = False
        Me.DataSetAccion1.Accion.PorIncapacidadColumn.DefaultValue = 0
        Me.DataSetAccion1.Accion.EmbarazoColumn.DefaultValue = False
        Me.DataSetAccion1.Accion.PorEmbarazoColumn.DefaultValue = 0
        Me.DataSetAccion1.Accion.INSColumn.DefaultValue = False
        Me.DataSetAccion1.Accion.PorINSColumn.DefaultValue = 0
        Me.DataSetAccion1.Accion.VacacionesColumn.DefaultValue = False
    End Sub

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1

            Case 1 : Nuevo()

            Case 2 : If PMU.Find Then buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : If PMU.Update Then Registrar(0) Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 4 : If PMU.Delete Then Eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : Editar()

            Case 7 : Me.Close()

        End Select
    End Sub
#End Region

#Region "Nuevo"
    Sub Nuevo()
        If Me.ToolBarNuevo.Text = "Nuevo" Then
            Me.BindingContext(Me.DataSetAccion1, "Accion").EndCurrentEdit()
            Me.BindingContext(Me.DataSetAccion1, "Accion").AddNew()
            Me.ToolBarNuevo.Text = "Cancelar"
            Me.ToolBarNuevo.ImageIndex = 4
            control_toolbar(False)
            Me.ToolBarNuevo.Enabled = True
            Me.ToolBarRegistrar.Enabled = True
            control_controles(True)
            Me.txtAccion.Focus()
        Else
            Try
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.ToolBarNuevo.ImageIndex = 0
                Me.BindingContext(Me.DataSetAccion1, "Accion").CancelCurrentEdit()
                Me.DataSetAccion1.Accion.Clear()
                control_toolbar(False)
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarBuscar.Enabled = True
                control_controles(False)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
#End Region

#Region "buscar"
    Sub buscar()
        busca = New BuscaAccion
        busca.ShowDialog()
        If Not busca.id < 0 Then
            Try
                Me.DataSetAccion1.Clear()
                Dim fu As New cFunciones
                fu.Cargar_Tabla_Generico(AdapterAccion, "select * from Accion where Codigo = " & busca.id)
                AdapterAccion.Fill(Me.DataSetAccion1.Accion)
                control_toolbar(True)
                ToolBarRegistrar.Enabled = False
                control_controles(False)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub
#End Region

#Region "Registrar"
    Sub Registrar(ByVal identificador As Integer, Optional ByVal str As String = "Eliminado", Optional ByVal bool As Boolean = False)
        Dim Trans As SqlTransaction
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        If Me.txtAccion.Text <> "" And Me.txtDescripcion.Text <> "" Or bool = True Then
            Try
                Me.BindingContext(Me.DataSetAccion1, "Accion").EndCurrentEdit()
                Me.BindingContext(Me.DataSetAccion1, "Accion").AddNew()
                Me.BindingContext(Me.DataSetAccion1, "Accion").CancelCurrentEdit()
                Trans = Me.SqlConnection1.BeginTransaction
                Me.AdapterAccion.InsertCommand.Transaction = Trans
                Me.AdapterAccion.UpdateCommand.Transaction = Trans
                Me.AdapterAccion.DeleteCommand.Transaction = Trans
                Me.AdapterAccion.Update(Me.DataSetAccion1.Accion)
                Me.DataSetAccion1.AcceptChanges()
                Trans.Commit()
                control_toolbar(False)
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarBuscar.Enabled = True
                control_controles(False)
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.ToolBarNuevo.ImageIndex = 0
                Me.ToolBarExcel.Text = "Editar"
                Me.ToolBarExcel.ImageIndex = 5
                If identificador = 0 Then
                    MsgBox("Acción registrada satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MsgBox("Se ha eliminado " & str & " satisfactoriamente")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
                Trans.Rollback()
            Finally
                SqlConnection1.Close()
            End Try
        Else
            MsgBox("Los campos Nombre Acción y Descripción no deben estar vacíos")
        End If
    End Sub
#End Region

#Region "Eliminar"
    Sub Eliminar()

        Dim Cconexion As New Conexion
        Dim res As MsgBoxResult
        res = MsgBox("¿Está Seguro(a) que desea eliminar este registro de Acciones de forma permanente?", MsgBoxStyle.YesNo)
        If res = MsgBoxResult.Yes Then
            If Me.BindingContext(Me.DataSetAccion1, "Accion").Count > 0 Then
                Dim straccion As String = Me.BindingContext(Me.DataSetAccion1, "Accion").Current("Nombre")
                Me.BindingContext(Me.DataSetAccion1, "Accion").RemoveAt(Me.BindingContext(Me.DataSetAccion1, "Accion").Position)
                Registrar(1, straccion, True)
            Else
                MsgBox("¡No existen Acciones a Eliminar!", MsgBoxStyle.Information)
            End If
        End If
    End Sub
#End Region

#Region "Editar"
    Sub Editar()
        If Me.ToolBarExcel.Text = "Editar" Then
            Me.ToolBarExcel.Text = "Cancelar"
            Me.ToolBarExcel.ImageIndex = 4
            control_toolbar(False)
            Me.ToolBarExcel.Enabled = True
            Me.ToolBarRegistrar.Enabled = True
            control_controles(True)
        Else
            Me.ToolBarExcel.Text = "Editar"
            Me.ToolBarExcel.ImageIndex = 9
            control_toolbar(True)
            Me.ToolBarRegistrar.Enabled = False
            control_controles(False)
        End If
    End Sub
#End Region

#Region "Salir"
    Sub Salir()
        Me.Close()
    End Sub
#End Region

    Private Function Imprimir()
        Try
            Dim Acciones As New Acciones
            Dim visor As New frmVisorReportes
            visor.rptViewer.ReportSource = Acciones
            CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Acciones)
            visor.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Function

    Sub control_toolbar(ByVal bool As Boolean)
        Me.ToolBarBuscar.Enabled = bool
        Me.ToolBarEliminar.Enabled = bool
        Me.ToolBarExcel.Enabled = bool
        Me.ToolBarNuevo.Enabled = bool
        Me.ToolBarRegistrar.Enabled = bool
    End Sub

    Sub control_controles(ByVal bool As Boolean)
        Me.txtDescripcion.Enabled = bool
        Me.ckRango.Enabled = bool
        Me.txtAccion.Enabled = bool
        Me.CKIncapacidad.Enabled = bool
        Me.txtPorIncapacidad.Enabled = bool
        Me.CKEmbarazo.Enabled = bool
        Me.txtPorEmbarazo.Enabled = bool
        Me.CKINS.Enabled = bool
        Me.txtPorINS.Enabled = bool
        Ck_Vacaciones.Enabled = bool
    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtDescripcion.Text <> "" Then
            Me.ckRango.Focus()
        End If
    End Sub

    Private Sub txtAccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAccion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtDescripcion.Focus()
        End If
    End Sub

    Private Sub ckRango_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ckRango.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDescripcion.Focus()
        End If
    End Sub

    Private Sub CKIncapacidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CKIncapacidad.CheckedChanged
        If CKIncapacidad.Checked = True Then
            Me.CKINS.Checked = False : Me.txtPorINS.Text = 0
            Me.CKEmbarazo.Checked = False : Me.txtPorEmbarazo.Text = 0
            Me.txtPorIncapacidad.Focus()
        Else
            Me.txtPorIncapacidad.Text = 0
        End If
    End Sub

    Private Sub CKINS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CKINS.CheckedChanged
        If CKINS.Checked = True Then
            Me.CKEmbarazo.Checked = False : Me.txtPorEmbarazo.Text = 0
            Me.CKIncapacidad.Checked = False : Me.txtPorIncapacidad.Text = 0
            Me.txtPorINS.Focus()
        Else
            Me.txtPorINS.Text = 0
        End If
    End Sub

    Private Sub CKEmbarazo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CKEmbarazo.CheckedChanged
        If CKEmbarazo.Checked = True Then
            Me.CKIncapacidad.Checked = False : Me.txtPorIncapacidad.Text = 0
            Me.CKINS.Checked = False : Me.txtPorINS.Text = 0
            Me.txtPorEmbarazo.Focus()
        Else
            Me.txtPorEmbarazo.Text = 0
        End If
    End Sub

End Class
