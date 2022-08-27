Imports System.Data.SqlClient
Public Class ImpuestoRenta
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesde1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHasta1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDesde2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEsposo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtHijo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterParametro As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetParametro1 As Planilla.DataSetParametro
    Friend WithEvents txtExento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPaga1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPaga2 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtExento = New DevExpress.XtraEditors.TextEdit
        Me.DataSetParametro1 = New Planilla.DataSetParametro
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPaga2 = New System.Windows.Forms.TextBox
        Me.txtPaga1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDesde2 = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtHasta1 = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDesde1 = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtHijo = New DevExpress.XtraEditors.TextEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtEsposo = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterParametro = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.txtExento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetParametro1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDesde2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHasta1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesde1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtHijo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEsposo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hasta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtExento
        '
        Me.txtExento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetParametro1, "ParametroRenta.MontoExento"))
        Me.txtExento.EditValue = ""
        Me.txtExento.Location = New System.Drawing.Point(8, 32)
        Me.txtExento.Name = "txtExento"
        '
        'txtExento.Properties
        '
        Me.txtExento.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtExento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExento.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtExento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExento.Size = New System.Drawing.Size(96, 19)
        Me.txtExento.TabIndex = 1
        '
        'DataSetParametro1
        '
        Me.DataSetParametro1.DataSetName = "DataSetParametro"
        Me.DataSetParametro1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(56, 248)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 24)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPaga2)
        Me.GroupBox1.Controls.Add(Me.txtPaga1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDesde2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtHasta1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDesde1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtExento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros para el Cáculo de Impuesto de Renta"
        '
        'txtPaga2
        '
        Me.txtPaga2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetParametro1, "ParametroRenta.Porcentaje2"))
        Me.txtPaga2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaga2.ForeColor = System.Drawing.Color.Blue
        Me.txtPaga2.Location = New System.Drawing.Point(216, 112)
        Me.txtPaga2.Name = "txtPaga2"
        Me.txtPaga2.Size = New System.Drawing.Size(96, 20)
        Me.txtPaga2.TabIndex = 14
        Me.txtPaga2.Text = ""
        Me.txtPaga2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPaga1
        '
        Me.txtPaga1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetParametro1, "ParametroRenta.Porcentaje1"))
        Me.txtPaga1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaga1.ForeColor = System.Drawing.Color.Blue
        Me.txtPaga1.Location = New System.Drawing.Point(216, 72)
        Me.txtPaga1.Name = "txtPaga1"
        Me.txtPaga1.Size = New System.Drawing.Size(96, 20)
        Me.txtPaga1.TabIndex = 8
        Me.txtPaga1.Text = ""
        Me.txtPaga1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "%"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(216, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Paga"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(120, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "En Adelante"
        '
        'txtDesde2
        '
        Me.txtDesde2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetParametro1, "ParametroRenta.MontoEnAdelante"))
        Me.txtDesde2.EditValue = ""
        Me.txtDesde2.Location = New System.Drawing.Point(8, 112)
        Me.txtDesde2.Name = "txtDesde2"
        '
        'txtDesde2.Properties
        '
        Me.txtDesde2.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDesde2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDesde2.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtDesde2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDesde2.Size = New System.Drawing.Size(96, 19)
        Me.txtDesde2.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(8, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Desde"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(320, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "%"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(216, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Paga"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHasta1
        '
        Me.txtHasta1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetParametro1, "ParametroRenta.MontoHasta"))
        Me.txtHasta1.EditValue = ""
        Me.txtHasta1.Location = New System.Drawing.Point(112, 72)
        Me.txtHasta1.Name = "txtHasta1"
        '
        'txtHasta1.Properties
        '
        Me.txtHasta1.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtHasta1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHasta1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtHasta1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtHasta1.Size = New System.Drawing.Size(96, 19)
        Me.txtHasta1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(112, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Hasta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDesde1
        '
        Me.txtDesde1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetParametro1, "ParametroRenta.MontoDe"))
        Me.txtDesde1.EditValue = ""
        Me.txtDesde1.Location = New System.Drawing.Point(8, 72)
        Me.txtDesde1.Name = "txtDesde1"
        '
        'txtDesde1.Properties
        '
        Me.txtDesde1.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDesde1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDesde1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtDesde1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDesde1.Size = New System.Drawing.Size(96, 19)
        Me.txtDesde1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Desde"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Exento"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHijo)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtEsposo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 80)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Créditos"
        '
        'txtHijo
        '
        Me.txtHijo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetParametro1, "ParametroRenta.Hijo"))
        Me.txtHijo.EditValue = ""
        Me.txtHijo.Location = New System.Drawing.Point(200, 40)
        Me.txtHijo.Name = "txtHijo"
        '
        'txtHijo.Properties
        '
        Me.txtHijo.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtHijo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHijo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtHijo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtHijo.Size = New System.Drawing.Size(112, 19)
        Me.txtHijo.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(200, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Hijo(a)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEsposo
        '
        Me.txtEsposo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetParametro1, "ParametroRenta.Esposa"))
        Me.txtEsposo.EditValue = ""
        Me.txtEsposo.Location = New System.Drawing.Point(8, 40)
        Me.txtEsposo.Name = "txtEsposo"
        '
        'txtEsposo.Properties
        '
        Me.txtEsposo.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtEsposo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEsposo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtEsposo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtEsposo.Size = New System.Drawing.Size(112, 19)
        Me.txtEsposo.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(8, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Esposo(a)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(192, 248)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 24)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=SEESER" & _
        "VER;persist security info=False;initial catalog=Planilla"
        '
        'AdapterParametro
        '
        Me.AdapterParametro.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterParametro.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterParametro.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterParametro.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ParametroRenta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("MontoExento", "MontoExento"), New System.Data.Common.DataColumnMapping("MontoDe", "MontoDe"), New System.Data.Common.DataColumnMapping("MontoHasta", "MontoHasta"), New System.Data.Common.DataColumnMapping("Porcentaje1", "Porcentaje1"), New System.Data.Common.DataColumnMapping("MontoEnAdelante", "MontoEnAdelante"), New System.Data.Common.DataColumnMapping("Porcentaje2", "Porcentaje2"), New System.Data.Common.DataColumnMapping("Esposa", "Esposa"), New System.Data.Common.DataColumnMapping("Hijo", "Hijo")})})
        Me.AdapterParametro.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM ParametroRenta WHERE (Id = @Original_Id) AND (Esposa = @Original_Espo" & _
        "sa) AND (Hijo = @Original_Hijo) AND (MontoDe = @Original_MontoDe) AND (MontoEnAd" & _
        "elante = @Original_MontoEnAdelante) AND (MontoExento = @Original_MontoExento) AN" & _
        "D (MontoHasta = @Original_MontoHasta) AND (Porcentaje1 = @Original_Porcentaje1) " & _
        "AND (Porcentaje2 = @Original_Porcentaje2)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Esposa", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Esposa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoDe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoDe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoEnAdelante", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnAdelante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoHasta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoHasta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porcentaje1", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porcentaje2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje2", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO ParametroRenta(MontoExento, MontoDe, MontoHasta, Porcentaje1, MontoEn" & _
        "Adelante, Porcentaje2, Esposa, Hijo) VALUES (@MontoExento, @MontoDe, @MontoHasta" & _
        ", @Porcentaje1, @MontoEnAdelante, @Porcentaje2, @Esposa, @Hijo); SELECT Id, Mont" & _
        "oExento, MontoDe, MontoHasta, Porcentaje1, MontoEnAdelante, Porcentaje2, Esposa," & _
        " Hijo FROM ParametroRenta WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoExento", System.Data.SqlDbType.Float, 8, "MontoExento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoDe", System.Data.SqlDbType.Float, 8, "MontoDe"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoHasta", System.Data.SqlDbType.Float, 8, "MontoHasta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porcentaje1", System.Data.SqlDbType.Float, 8, "Porcentaje1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoEnAdelante", System.Data.SqlDbType.Float, 8, "MontoEnAdelante"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porcentaje2", System.Data.SqlDbType.Float, 8, "Porcentaje2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Esposa", System.Data.SqlDbType.Float, 8, "Esposa"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijo", System.Data.SqlDbType.Float, 8, "Hijo"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id, MontoExento, MontoDe, MontoHasta, Porcentaje1, MontoEnAdelante, Porcen" & _
        "taje2, Esposa, Hijo FROM ParametroRenta"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE ParametroRenta SET MontoExento = @MontoExento, MontoDe = @MontoDe, MontoHa" & _
        "sta = @MontoHasta, Porcentaje1 = @Porcentaje1, MontoEnAdelante = @MontoEnAdelant" & _
        "e, Porcentaje2 = @Porcentaje2, Esposa = @Esposa, Hijo = @Hijo WHERE (Id = @Origi" & _
        "nal_Id) AND (Esposa = @Original_Esposa) AND (Hijo = @Original_Hijo) AND (MontoDe" & _
        " = @Original_MontoDe) AND (MontoEnAdelante = @Original_MontoEnAdelante) AND (Mon" & _
        "toExento = @Original_MontoExento) AND (MontoHasta = @Original_MontoHasta) AND (P" & _
        "orcentaje1 = @Original_Porcentaje1) AND (Porcentaje2 = @Original_Porcentaje2); S" & _
        "ELECT Id, MontoExento, MontoDe, MontoHasta, Porcentaje1, MontoEnAdelante, Porcen" & _
        "taje2, Esposa, Hijo FROM ParametroRenta WHERE (Id = @Id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoExento", System.Data.SqlDbType.Float, 8, "MontoExento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoDe", System.Data.SqlDbType.Float, 8, "MontoDe"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoHasta", System.Data.SqlDbType.Float, 8, "MontoHasta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porcentaje1", System.Data.SqlDbType.Float, 8, "Porcentaje1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoEnAdelante", System.Data.SqlDbType.Float, 8, "MontoEnAdelante"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porcentaje2", System.Data.SqlDbType.Float, 8, "Porcentaje2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Esposa", System.Data.SqlDbType.Float, 8, "Esposa"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hijo", System.Data.SqlDbType.Float, 8, "Hijo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Esposa", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Esposa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Hijo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Hijo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoDe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoDe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoEnAdelante", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoEnAdelante", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoExento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MontoHasta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoHasta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porcentaje1", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Porcentaje2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porcentaje2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'ImpuestoRenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 270)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAceptar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(368, 304)
        Me.MinimumSize = New System.Drawing.Size(368, 304)
        Me.Name = "ImpuestoRenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parámetro de Impuesto de Renta"
        CType(Me.txtExento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetParametro1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtDesde2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHasta1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesde1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtHijo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEsposo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ImpuestoRenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
        Try
            Me.AdapterParametro.Fill(Me.DataSetParametro1.ParametroRenta)
            If Me.BindingContext(Me.DataSetParametro1, "ParametroRenta").Count < 1 Then
                ValoresDefault()
                Me.BindingContext(Me.DataSetParametro1, "ParametroRenta").EndCurrentEdit()
                Me.BindingContext(Me.DataSetParametro1, "ParametroRenta").AddNew()
            End If
            Me.txtExento.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ValoresDefault()
        Me.DataSetParametro1.ParametroRenta.MontoExentoColumn.DefaultValue = 0
        Me.DataSetParametro1.ParametroRenta.MontoDeColumn.DefaultValue = 0
        Me.DataSetParametro1.ParametroRenta.MontoHastaColumn.DefaultValue = 0
        Me.DataSetParametro1.ParametroRenta.Porcentaje1Column.DefaultValue = 0
        Me.DataSetParametro1.ParametroRenta.MontoEnAdelanteColumn.DefaultValue = 0
        Me.DataSetParametro1.ParametroRenta.Porcentaje2Column.DefaultValue = 0
        Me.DataSetParametro1.ParametroRenta.EsposaColumn.DefaultValue = 0
        Me.DataSetParametro1.ParametroRenta.HijoColumn.DefaultValue = 0
        txtExento.Focus()
    End Sub

#Region "valida"
    Function valida() As Boolean
        If Me.txtDesde1.Text = "" Then
            Return False
        ElseIf Me.txtDesde2.Text = "" Then
            Return False
        ElseIf Me.txtEsposo.Text = "" Then
            Return False
        ElseIf Me.txtExento.Text = "" Then
            Return False
        ElseIf Me.txtHasta1.Text = "" Then
            Return False
        ElseIf Me.txtHijo.Text = "" Then
            Return False
        ElseIf Me.txtPaga2.Text = "" Then
            Return False
        ElseIf Me.txtPaga1.Text = "" Then
            Return False
        End If
        Return True
    End Function
#End Region

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim trans As SqlTransaction
        Try
            If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            If valida() Then
                Me.BindingContext(Me.DataSetParametro1, "ParametroRenta").EndCurrentEdit()
                trans = Me.SqlConnection1.BeginTransaction
                Me.AdapterParametro.InsertCommand.Transaction = trans
                Me.AdapterParametro.UpdateCommand.Transaction = trans
                Me.AdapterParametro.Update(Me.DataSetParametro1.ParametroRenta)
                Me.DataSetParametro1.AcceptChanges()
                trans.Commit()
                MsgBox("Parámetro de Impuesto de Renta registrado satisfactoriamente", MsgBoxStyle.Information)
                Me.Close()
            Else
                MsgBox("¡No debe dejar espacios en blanco!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtExento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExento.KeyPress
        If Not (Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
        'todo: Validar mejor!!!!!
    End Sub

    Private Sub txtExento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExento.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDesde1.Focus()
        End If
    End Sub

    Private Sub txtDesde1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesde1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtHasta1.Focus()
        End If
    End Sub

    Private Sub txtHasta1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHasta1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPaga1.Focus()
        End If
    End Sub

    Private Sub txtPaga1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaga1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDesde2.Focus()
        End If
    End Sub

    Private Sub txtDesde2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesde2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPaga2.Focus()
        End If
    End Sub

    Private Sub txtPaga2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaga2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtEsposo.Focus()
        End If
    End Sub


    Private Sub txtEsposo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEsposo.EditValueChanged

    End Sub

    Private Sub txtEsposo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEsposo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtHijo.Focus()
        End If
    End Sub

    Private Sub txtHijo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHijo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.Focus()
        End If
    End Sub
End Class
