Imports System.data.sqlclient
Imports Utilidades
Public Class Deducciones
    Inherits FrmPlantilla
    Dim buscando As Boolean
    Dim usua As Object
    Dim CConexion As New Conexion
  
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        usua = Usuario_Parametro
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
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTipoDed As System.Windows.Forms.ComboBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adDeduccion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Deduccion1 As Planilla.Deduccion
    Friend WithEvents txtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckAplica As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daEmpleadoDeducciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daEmpleado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.Deduccion1 = New Planilla.Deduccion
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtMonto = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbTipoDed = New System.Windows.Forms.ComboBox
        Me.CheckAplica = New System.Windows.Forms.CheckBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.adDeduccion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Label11 = New System.Windows.Forms.Label
        Me.CbMoneda = New System.Windows.Forms.ComboBox
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.adMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.daEmpleadoDeducciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.daEmpleado = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCuentaContable = New System.Windows.Forms.TextBox
        Me.txtCuentaContableDescripcion = New System.Windows.Forms.TextBox
        CType(Me.Deduccion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 196)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(370, 52)
        Me.ToolBar1.TabIndex = 9
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(370, 32)
        Me.TituloModulo.TabIndex = 0
        Me.TituloModulo.Text = "Deducción"
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deduccion1, "Deducciones.Descripcion"))
        Me.TxtNombre.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombre.Location = New System.Drawing.Point(8, 56)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(352, 13)
        Me.TxtNombre.TabIndex = 2
        Me.TxtNombre.Text = ""
        '
        'Deduccion1
        '
        Me.Deduccion1.DataSetName = "Deduccion"
        Me.Deduccion1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(8, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Monto"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMonto
        '
        Me.txtMonto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.Deduccion1, "Deducciones.Monto"))
        Me.txtMonto.EditValue = ""
        Me.txtMonto.Location = New System.Drawing.Point(8, 96)
        Me.txtMonto.Name = "txtMonto"
        '
        'txtMonto.Properties
        '
        Me.txtMonto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtMonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMonto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtMonto.Size = New System.Drawing.Size(112, 17)
        Me.txtMonto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(138, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tipo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbTipoDed
        '
        Me.cbTipoDed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deduccion1, "Deducciones.Tipo"))
        Me.cbTipoDed.Enabled = False
        Me.cbTipoDed.ForeColor = System.Drawing.Color.Blue
        Me.cbTipoDed.Items.AddRange(New Object() {"%", "V"})
        Me.cbTipoDed.Location = New System.Drawing.Point(138, 96)
        Me.cbTipoDed.Name = "cbTipoDed"
        Me.cbTipoDed.Size = New System.Drawing.Size(72, 21)
        Me.cbTipoDed.TabIndex = 6
        '
        'CheckAplica
        '
        Me.CheckAplica.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Deduccion1, "Deducciones.Aplica"))
        Me.CheckAplica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAplica.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CheckAplica.Location = New System.Drawing.Point(240, 128)
        Me.CheckAplica.Name = "CheckAplica"
        Me.CheckAplica.Size = New System.Drawing.Size(120, 16)
        Me.CheckAplica.TabIndex = 7
        Me.CheckAplica.Text = "Aplica para Todos"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SEESOFTELIAS;packet size=4096;integrated security=SSPI;data source" & _
        "=""(local)"";persist security info=False;initial catalog=Planilla"
        '
        'adDeduccion
        '
        Me.adDeduccion.DeleteCommand = Me.SqlDeleteCommand1
        Me.adDeduccion.InsertCommand = Me.SqlInsertCommand1
        Me.adDeduccion.SelectCommand = Me.SqlSelectCommand1
        Me.adDeduccion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Deducciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Aplica", "Aplica"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable")})})
        Me.adDeduccion.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Deducciones WHERE (Codigo = @Original_Codigo) AND (Aplica = @Original" & _
        "_Aplica) AND (Cod_Moneda = @Original_Cod_Moneda) AND (CuentaContable = @Original" & _
        "_CuentaContable OR @Original_CuentaContable IS NULL AND CuentaContable IS NULL) " & _
        "AND (Descripcion = @Original_Descripcion) AND (Monto = @Original_Monto) AND (Tip" & _
        "o = @Original_Tipo)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aplica", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplica", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Deducciones(Descripcion, Monto, Tipo, Aplica, Cod_Moneda, CuentaConta" & _
        "ble) VALUES (@Descripcion, @Monto, @Tipo, @Aplica, @Cod_Moneda, @CuentaContable)" & _
        "; SELECT Codigo, Descripcion, Monto, Tipo, Aplica, Cod_Moneda, CuentaContable FR" & _
        "OM Deducciones WHERE (Codigo = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplica", System.Data.SqlDbType.Bit, 1, "Aplica"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Descripcion, Monto, Tipo, Aplica, Cod_Moneda, CuentaContable FROM " & _
        "Deducciones"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Deducciones SET Descripcion = @Descripcion, Monto = @Monto, Tipo = @Tipo, " & _
        "Aplica = @Aplica, Cod_Moneda = @Cod_Moneda, CuentaContable = @CuentaContable WHE" & _
        "RE (Codigo = @Original_Codigo) AND (Aplica = @Original_Aplica) AND (Cod_Moneda =" & _
        " @Original_Cod_Moneda) AND (CuentaContable = @Original_CuentaContable OR @Origin" & _
        "al_CuentaContable IS NULL AND CuentaContable IS NULL) AND (Descripcion = @Origin" & _
        "al_Descripcion) AND (Monto = @Original_Monto) AND (Tipo = @Original_Tipo); SELEC" & _
        "T Codigo, Descripcion, Monto, Tipo, Aplica, Cod_Moneda, CuentaContable FROM Dedu" & _
        "cciones WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplica", System.Data.SqlDbType.Bit, 1, "Aplica"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Aplica", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Aplica", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(240, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Moneda"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbMoneda
        '
        Me.CbMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Deduccion1, "Deducciones.Cod_Moneda"))
        Me.CbMoneda.DataSource = Me.Deduccion1.Moneda
        Me.CbMoneda.DisplayMember = "MonedaNombre"
        Me.CbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbMoneda.ForeColor = System.Drawing.Color.Blue
        Me.CbMoneda.Location = New System.Drawing.Point(240, 96)
        Me.CbMoneda.Name = "CbMoneda"
        Me.CbMoneda.Size = New System.Drawing.Size(112, 21)
        Me.CbMoneda.TabIndex = 8
        Me.CbMoneda.ValueMember = "CodMoneda"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=SEESOFTELIAS;packet size=4096;integrated security=SSPI;data source" & _
        "=""(local)"";persist security info=False;initial catalog=Planilla"
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo) VAL" & _
        "UES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simbolo); SELECT Cod" & _
        "Moneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda WHERE (CodMon" & _
        "eda = @CodMoneda)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection2
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Moneda SET CodMoneda = @CodMoneda, MonedaNombre = @MonedaNombre, ValorComp" & _
        "ra = @ValorCompra, ValorVenta = @ValorVenta, Simbolo = @Simbolo WHERE (CodMoneda" & _
        " = @Original_CodMoneda) AND (MonedaNombre = @Original_MonedaNombre) AND (Simbolo" & _
        " = @Original_Simbolo) AND (ValorCompra = @Original_ValorCompra) AND (ValorVenta " & _
        "= @Original_ValorVenta); SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta" & _
        ", Simbolo FROM Moneda WHERE (CodMoneda = @CodMoneda)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Moneda WHERE (CodMoneda = @Original_CodMoneda) AND (MonedaNombre = @O" & _
        "riginal_MonedaNombre) AND (Simbolo = @Original_Simbolo) AND (ValorCompra = @Orig" & _
        "inal_ValorCompra) AND (ValorVenta = @Original_ValorVenta)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'adMoneda
        '
        Me.adMoneda.DeleteCommand = Me.SqlDeleteCommand2
        Me.adMoneda.InsertCommand = Me.SqlInsertCommand2
        Me.adMoneda.SelectCommand = Me.SqlSelectCommand2
        Me.adMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.adMoneda.UpdateCommand = Me.SqlUpdateCommand2
        '
        'daEmpleadoDeducciones
        '
        Me.daEmpleadoDeducciones.DeleteCommand = Me.SqlDeleteCommand3
        Me.daEmpleadoDeducciones.InsertCommand = Me.SqlInsertCommand3
        Me.daEmpleadoDeducciones.SelectCommand = Me.SqlSelectCommand3
        Me.daEmpleadoDeducciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado_Deducciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        Me.daEmpleadoDeducciones.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Empleado_Deducciones WHERE (Id = @Original_Id) AND (Cod_Moneda = @Ori" & _
        "ginal_Cod_Moneda) AND (Codigo = @Original_Codigo) AND (Descripcion = @Original_D" & _
        "escripcion) AND (Identificacion = @Original_Identificacion) AND (Monto = @Origin" & _
        "al_Monto) AND (Tipo = @Original_Tipo)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Empleado_Deducciones(Identificacion, Codigo, Descripcion, Monto, Tipo" & _
        ", Cod_Moneda) VALUES (@Identificacion, @Codigo, @Descripcion, @Monto, @Tipo, @Co" & _
        "d_Moneda); SELECT Id, Identificacion, Codigo, Descripcion, Monto, Tipo, Cod_Mone" & _
        "da FROM Empleado_Deducciones WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id, Identificacion, Codigo, Descripcion, Monto, Tipo, Cod_Moneda FROM Empl" & _
        "eado_Deducciones"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Empleado_Deducciones SET Identificacion = @Identificacion, Codigo = @Codig" & _
        "o, Descripcion = @Descripcion, Monto = @Monto, Tipo = @Tipo, Cod_Moneda = @Cod_M" & _
        "oneda WHERE (Id = @Original_Id) AND (Cod_Moneda = @Original_Cod_Moneda) AND (Cod" & _
        "igo = @Original_Codigo) AND (Descripcion = @Original_Descripcion) AND (Identific" & _
        "acion = @Original_Identificacion) AND (Monto = @Original_Monto) AND (Tipo = @Ori" & _
        "ginal_Tipo); SELECT Id, Identificacion, Codigo, Descripcion, Monto, Tipo, Cod_Mo" & _
        "neda FROM Empleado_Deducciones WHERE (Id = @Id)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 1, "Tipo"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'daEmpleado
        '
        Me.daEmpleado.DeleteCommand = Me.SqlDeleteCommand4
        Me.daEmpleado.InsertCommand = Me.SqlInsertCommand4
        Me.daEmpleado.SelectCommand = Me.SqlSelectCommand4
        Me.daEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion")})})
        Me.daEmpleado.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Empleado WHERE (Identificacion = @Original_Identificacion)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Empleado(Identificacion) VALUES (@Identificacion); SELECT Identificac" & _
        "ion FROM Empleado WHERE (Identificacion = @Identificacion)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Identificacion FROM Empleado"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Empleado SET Identificacion = @Identificacion WHERE (Identificacion = @Ori" & _
        "ginal_Identificacion); SELECT Identificacion FROM Empleado WHERE (Identificacion" & _
        " = @Identificacion)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Identificacion", System.Data.SqlDbType.VarChar, 75, "Identificacion"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Identificacion", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Identificacion", System.Data.DataRowVersion.Original, Nothing))
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(160, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descripción"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(16, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cuenta contable:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Deduccion1, "Deducciones.CuentaContable"))
        Me.txtCuentaContable.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContable.Location = New System.Drawing.Point(16, 168)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.Size = New System.Drawing.Size(136, 13)
        Me.txtCuentaContable.TabIndex = 12
        Me.txtCuentaContable.Text = ""
        '
        'txtCuentaContableDescripcion
        '
        Me.txtCuentaContableDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableDescripcion.Location = New System.Drawing.Point(160, 168)
        Me.txtCuentaContableDescripcion.Name = "txtCuentaContableDescripcion"
        Me.txtCuentaContableDescripcion.Size = New System.Drawing.Size(192, 13)
        Me.txtCuentaContableDescripcion.TabIndex = 13
        Me.txtCuentaContableDescripcion.Text = ""
        '
        'Deducciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(370, 248)
        Me.Controls.Add(Me.txtCuentaContableDescripcion)
        Me.Controls.Add(Me.txtCuentaContable)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CbMoneda)
        Me.Controls.Add(Me.CheckAplica)
        Me.Controls.Add(Me.cbTipoDed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Deducciones"
        Me.Text = "Formularios Deducciones"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNombre, 0)
        Me.Controls.SetChildIndex(Me.txtMonto, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.cbTipoDed, 0)
        Me.Controls.SetChildIndex(Me.CheckAplica, 0)
        Me.Controls.SetChildIndex(Me.CbMoneda, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContable, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableDescripcion, 0)
        CType(Me.Deduccion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Deducciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
            SqlConnection2.ConnectionString = GetSetting("SeeSoft", "Seguridad", "Conexion")
            TxtNombre.Enabled = False
            txtMonto.Enabled = False
            cbTipoDed.Enabled = False
            CheckAplica.Enabled = False
            CbMoneda.Enabled = False
            Me.adMoneda.Fill(Me.Deduccion1, "Moneda")
            'Me.adMoneda.Fill(Me.Deduccion1, "Empleado")
            'Me.adMoneda.Fill(Me.Deduccion1, "Deducciones1")  
            'Me.adMoneda.Fill(Me.Deduccion1, "Empleado_Deducciones") 
            Me.Deduccion1.Deducciones.DescripcionColumn.DefaultValue = ""
            Me.Deduccion1.Deducciones.MontoColumn.DefaultValue = 0
            Me.Deduccion1.Deducciones.TipoColumn.DefaultValue = ""
            Me.Deduccion1.Deducciones.AplicaColumn.DefaultValue = 0
            Me.Deduccion1.Deducciones.Cod_MonedaColumn.DefaultValue = 0
            ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(4).Enabled = False
            ToolBar1.Buttons(5).Enabled = True
            DesactivarCuentaContable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function Nuevo()
        LimpiarCuentaContable()
        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            'cambia la imagen de nuevo y desabilita los botones
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Try 'inicia la edicion
                Me.Deduccion1.Deducciones.Clear()
                Me.BindingContext(Me.Deduccion1, "Deducciones").CancelCurrentEdit()
                Me.BindingContext(Me.Deduccion1, "Deducciones").EndCurrentEdit()
                Me.BindingContext(Me.Deduccion1, "Deducciones").AddNew()
                Me.ToolBar1.Buttons(1).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = True
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.ToolBar1.Buttons(5).Enabled = True
                ActivarCuentaContable()
                TxtNombre.Enabled = True
                txtMonto.Enabled = True
                cbTipoDed.Enabled = True
                CheckAplica.Enabled = True
                CbMoneda.Enabled = True
                TxtNombre.Focus()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                Me.BindingContext(Me.Deduccion1, "Deducciones").CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False
                TxtNombre.Enabled = False
                txtMonto.Enabled = False
                cbTipoDed.Enabled = False
                CheckAplica.Enabled = False
                CbMoneda.Enabled = False
                DesactivarCuentaContable()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Function
    Private Function Buscar()
        Dim funcion As New cFunciones
        Dim Id As String
        Try
            Me.Deduccion1.Deducciones.Clear()
            LimpiarCuentaContable()
            Id = funcion.BuscarDatos("Select Codigo As Identificación, Descripcion as Nombre from Deducciones", "Descripcion", "Buscar Deducción ...")
            buscando = True
            If Id = 0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Function
            End If
            Me.LlenarDeduccion(Id)

            Dim sql As String
            Dim clsConexion As New Conexion
            Dim cnnConexion As New System.Data.SqlClient.SqlConnection
            Dim rstReader As System.Data.SqlClient.SqlDataReader

            cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnConexion.Open()
            sql = "SELECT Descripcion FROM Contabilidad.dbo.CuentaContable WHERE CuentaContable = '" & Me.txtCuentaContable.Text & "'"
            rstReader = clsConexion.GetRecorset(cnnConexion, sql)

            If rstReader.Read() Then
                Me.txtCuentaContableDescripcion.Text = rstReader(0)
            End If
            rstReader.Close()
            ActivarCuentaContable()
            'nuevo
            Me.ToolBar1.Buttons(0).Enabled = True
            'buscar
            Me.ToolBar1.Buttons(1).Enabled = True
            'editar 
            Me.ToolBar1.Buttons(2).Enabled = True
            'registrar
            Me.ToolBar1.Buttons(3).Enabled = False
            'eliminar
            Me.ToolBar1.Buttons(4).Enabled = True
            'Imprimir
            Me.ToolBar1.Buttons(5).Enabled = True
            'Cerrar
            Me.ToolBar1.Buttons(6).Enabled = True
            TxtNombre.Enabled = False : txtMonto.Enabled = False : cbTipoDed.Enabled = False : CheckAplica.Enabled = False : CbMoneda.Enabled = False
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
    Function Editar()
        TxtNombre.Enabled = True : txtMonto.Enabled = True : cbTipoDed.Enabled = True : CheckAplica.Enabled = True : CbMoneda.Enabled = True
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
    Function LlenarDeduccion(ByVal Id As Integer)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        'Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''LLENAR EMPLEADO''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Deducciones WHERE (Codigo = @Id_Codigo)"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Codigo", SqlDbType.Int))
            cmdv.Parameters("@Id_Codigo").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.Deduccion1, "Deducciones")
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
    Private Function Guardar()
        If TxtNombre.Text = "" Then
            MsgBox("Debe incluir el nombre de la deducción", MsgBoxStyle.Information, "Atención...")
            Exit Function
        End If
        If txtMonto.Text <= 0 Then
            MsgBox("El monto debe ser mayor que 0", MsgBoxStyle.Information, "Atención...")
            Exit Function
        End If
        If cbTipoDed.Text = "" Then
            MsgBox("Debe de escoger el tipo de deducción", MsgBoxStyle.Information, "Atención...")
        End If

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            'finaliza la edición
            Me.adDeduccion.UpdateCommand.Transaction = Trans
            Me.adDeduccion.InsertCommand.Transaction = Trans
            Me.adDeduccion.DeleteCommand.Transaction = Trans

            Me.BindingContext(Me.Deduccion1, "Deducciones").EndCurrentEdit()

            Me.adDeduccion.Update(Me.Deduccion1, "Deducciones")

            Trans.Commit()
            Me.Deduccion1.AcceptChanges()
            MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Me.TxtNombre.Enabled = False : Me.txtMonto.Enabled = False : cbTipoDed.Enabled = False : CheckAplica.Enabled = False : CbMoneda.Enabled = False
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
            Me.Deduccion1.Deducciones.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Trans.Rollback()
        End Try
    End Function
    Private Sub eliminar()
        Try

            If Me.BindingContext(Deduccion1, "Deducciones").Count > 0 Then

                Dim Cconexion As New Conexion
                Dim strDel As String = Me.BindingContext(Deduccion1, "Deducciones").Current("Codigo")
                Dim rs As SqlDataReader
                rs = Cconexion.GetRecorset(Cconexion.Conectar, "SELECT Identificacion FROM Empleado_Deducciones WHERE Codigo =" & strDel)

                If rs.Read Then
                    MsgBox("Estos datos no se pueden eliminar, existen empleados asociados a estos datos", MsgBoxStyle.Exclamation, "Error...")
                    Exit Sub
                End If
                rs.Close() '<----modificado

                Dim rs1 As SqlDataReader
                rs1 = Cconexion.GetRecorset(Cconexion.Conectar, "SELECT Id_PlanillaDetalle FROM Planilla_Deducciones WHERE Cod_Deduccion =" & strDel)

                If rs1.Read Then
                    MessageBox.Show("Estos datos no se pueden eliminar, existen registros de planilla asociados a estos datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
                rs1.Close()

                Dim Resultado As String
                If Me.TxtNombre.Text <> "" Then
                    If MessageBox.Show(" ¿ Desea Eliminar esta Deducción ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub
                    Resultado = Cconexion.SlqExecute(Cconexion.Conectar("Planilla"), "Delete from Deducciones where Descripcion='" & Me.TxtNombre.Text & "'")
                    If Resultado = vbNullString Then
                        MessageBox.Show("La Deducción fue eliminado", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Deduccion1.Deducciones.Clear()
                        TxtNombre.Enabled = False : txtMonto.Enabled = False : cbTipoDed.Enabled = False : CheckAplica.Enabled = False : CbMoneda.Enabled = False
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
                    MessageBox.Show("No hay deducciones a eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("No hay deducciones a eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error...")
        End Try
    End Sub
    Private Function imprimir()
        Try
            Dim Imprimir_Deduccion As New ListDeducciones
            Utilidades.CrystalReportsConexion.LoadShow(Imprimir_Deduccion, Me.MdiParent, Me.SqlConnection1.ConnectionString)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Function

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()
            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3
                If Me.BindingContext(Deduccion1, "Deducciones").Count > 0 Then '#1

                    Dim Cconexion As New Conexion
                    Dim strDel As String = Me.BindingContext(Deduccion1, "Deducciones").Current("Codigo")
                    Dim rs As SqlDataReader
                    rs = Cconexion.GetRecorset(Cconexion.Conectar, "SELECT Identificacion FROM Empleado_Deducciones WHERE Codigo =" & strDel)

                    If rs.Read Then '#2
                        If MessageBox.Show(" Hay empleados asociados a estos datos si los modifica, modificara los datos de estos" & vbCrLf & " ¿desea continuar de todos modos  ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then '#3
                            rs.Close()
                            Exit Select
                        End If '#3

                    Else '#2
                        rs.Close()
                    End If '#2

                End If '#1
                Editar()
            Case 4 : If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Delete Then eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 7 : Me.Close()
        End Select
    End Sub

    Private Sub TxtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMonto.Focus()
        End If
    End Sub

    Private Sub txtMonto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbTipoDed.Focus()
        End If
    End Sub

    Private Sub cbTipoDed_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbTipoDed.KeyDown
        If e.KeyCode = Keys.Enter Then
            CbMoneda.Focus()
        End If
    End Sub

    Private Sub CbMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbMoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            CheckAplica.Focus()
        End If
    End Sub


    Private Sub txtCuentaContable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaContable.TextChanged

    End Sub

    Private Sub txtCuentaContable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContable.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContable()
        End If
    End Sub


    Private Sub LlamarFmrBuscarAsientoVenta()

        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
" where Movimiento=1 "
        busca.campo = "descripcion"
        busca.sqlStringAdicional = " ORDER BY CuentaContable  "
        busca.ShowDialog()

        If busca.codigo Is Nothing Then Exit Sub

        Me.txtCuentaContable.Text = busca.codigo
        Me.txtCuentaContableDescripcion.Text = busca.descrip


    End Sub

    Private Sub BuscarCuentaContable()
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String = "SELECT descripcion  FROM CuentaContable where CuentaContable = '" & Me.txtCuentaContable.Text & "' "

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then
            Me.txtCuentaContable.Text = ""
            Me.txtCuentaContableDescripcion.Text = ""
            Exit Sub
        End If

        Me.txtCuentaContableDescripcion.Text = rstReader(0)
        cnnConexion.Close()
    End Sub

    Private Sub LimpiarCuentaContable()
        Me.txtCuentaContable.Text = ""
        Me.txtCuentaContableDescripcion.Text = ""
    End Sub

    Private Sub ActivarCuentaContable()
        Me.txtCuentaContable.Enabled = True
        Me.txtCuentaContableDescripcion.Enabled = True
    End Sub

    Private Sub DesactivarCuentaContable()
        Me.txtCuentaContable.Enabled = False
        Me.txtCuentaContableDescripcion.Enabled = False
    End Sub
End Class
