Imports System.data.sqlclient
Imports Utilidades
Public Class Departamento
    Inherits FrmPlantilla
    Dim buscando As Boolean
    Dim usua As Object

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
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adDepartamento As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsDepartamento1 As Planilla.dsDepartamento
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaContableSalario As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableSalarioDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableCCSS As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableAguinaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableVacaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableProvAguinaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableProvVacaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableRetencionesCCSS As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableCCSSDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableAguinaldoDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableVacacionesDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableProvAguinaldoDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableProvVacacionesDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContableRetencionesCCSSDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents DsConfiguracion1 As Planilla.DsConfiguracion
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator
        Me.DsDepartamento1 = New Planilla.dsDepartamento
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.adDepartamento = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCuentaContableSalario = New System.Windows.Forms.TextBox
        Me.txtCuentaContableSalarioDescripcion = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCuentaContableCCSS = New System.Windows.Forms.TextBox
        Me.txtCuentaContableAguinaldo = New System.Windows.Forms.TextBox
        Me.txtCuentaContableVacaciones = New System.Windows.Forms.TextBox
        Me.txtCuentaContableProvAguinaldo = New System.Windows.Forms.TextBox
        Me.txtCuentaContableProvVacaciones = New System.Windows.Forms.TextBox
        Me.txtCuentaContableRetencionesCCSS = New System.Windows.Forms.TextBox
        Me.txtCuentaContableCCSSDescripcion = New System.Windows.Forms.TextBox
        Me.txtCuentaContableAguinaldoDescripcion = New System.Windows.Forms.TextBox
        Me.txtCuentaContableVacacionesDescripcion = New System.Windows.Forms.TextBox
        Me.txtCuentaContableProvAguinaldoDescripcion = New System.Windows.Forms.TextBox
        Me.txtCuentaContableProvVacacionesDescripcion = New System.Windows.Forms.TextBox
        Me.txtCuentaContableRetencionesCCSSDescripcion = New System.Windows.Forms.TextBox
        Me.DsConfiguracion1 = New Planilla.DsConfiguracion
        CType(Me.DsDepartamento1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConfiguracion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(474, 32)
        Me.TituloModulo.Text = "Departamentos"
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 268)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(474, 52)
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.NextPage.Visible = False
        Me.DataNavigator1.Buttons.PrevPage.Visible = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.DataMember = "Departamento"
        Me.DataNavigator1.DataSource = Me.DsDepartamento1
        Me.DataNavigator1.Location = New System.Drawing.Point(352, 320)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(112, 24)
        Me.DataNavigator1.TabIndex = 59
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'DsDepartamento1
        '
        Me.DsDepartamento1.DataSetName = "dsDepartamento"
        Me.DsDepartamento1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(48, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Nombre del Departamento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepartamento1, "Departamento.Departamento"))
        Me.TxtNombre.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombre.Location = New System.Drawing.Point(48, 56)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(384, 13)
        Me.TxtNombre.TabIndex = 0
        Me.TxtNombre.Text = ""
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SEESOFTELIAS;packet size=4096;integrated security=SSPI;data source" & _
        "=""(local)"";persist security info=False;initial catalog=Planilla"
        '
        'adDepartamento
        '
        Me.adDepartamento.DeleteCommand = Me.SqlDeleteCommand1
        Me.adDepartamento.InsertCommand = Me.SqlInsertCommand1
        Me.adDepartamento.SelectCommand = Me.SqlSelectCommand1
        Me.adDepartamento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Departamento", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Departamento", "Departamento"), New System.Data.Common.DataColumnMapping("CuentaContableSalario", "CuentaContableSalario"), New System.Data.Common.DataColumnMapping("CuentaContableCCSS", "CuentaContableCCSS"), New System.Data.Common.DataColumnMapping("CuentaContableAguinaldo", "CuentaContableAguinaldo"), New System.Data.Common.DataColumnMapping("CuentaContableVacaciones", "CuentaContableVacaciones"), New System.Data.Common.DataColumnMapping("CuentaContableProvAguinaldo", "CuentaContableProvAguinaldo"), New System.Data.Common.DataColumnMapping("CuentaContableProvVacaciones", "CuentaContableProvVacaciones"), New System.Data.Common.DataColumnMapping("CuentaContableRetencionesCCSS", "CuentaContableRetencionesCCSS")})})
        Me.adDepartamento.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Departamento WHERE (Id = @Original_Id) AND (CuentaContableAguinaldo =" & _
        " @Original_CuentaContableAguinaldo OR @Original_CuentaContableAguinaldo IS NULL " & _
        "AND CuentaContableAguinaldo IS NULL) AND (CuentaContableCCSS = @Original_CuentaC" & _
        "ontableCCSS OR @Original_CuentaContableCCSS IS NULL AND CuentaContableCCSS IS NU" & _
        "LL) AND (CuentaContableProvAguinaldo = @Original_CuentaContableProvAguinaldo OR " & _
        "@Original_CuentaContableProvAguinaldo IS NULL AND CuentaContableProvAguinaldo IS" & _
        " NULL) AND (CuentaContableProvVacaciones = @Original_CuentaContableProvVacacione" & _
        "s OR @Original_CuentaContableProvVacaciones IS NULL AND CuentaContableProvVacaci" & _
        "ones IS NULL) AND (CuentaContableRetencionesCCSS = @Original_CuentaContableReten" & _
        "cionesCCSS OR @Original_CuentaContableRetencionesCCSS IS NULL AND CuentaContable" & _
        "RetencionesCCSS IS NULL) AND (CuentaContableSalario = @Original_CuentaContableSa" & _
        "lario OR @Original_CuentaContableSalario IS NULL AND CuentaContableSalario IS NU" & _
        "LL) AND (CuentaContableVacaciones = @Original_CuentaContableVacaciones OR @Origi" & _
        "nal_CuentaContableVacaciones IS NULL AND CuentaContableVacaciones IS NULL) AND (" & _
        "Departamento = @Original_Departamento)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableAguinaldo", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableAguinaldo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableCCSS", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableCCSS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableProvAguinaldo", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableProvAguinaldo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableProvVacaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableProvVacaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableRetencionesCCSS", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableRetencionesCCSS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableSalario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableSalario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableVacaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableVacaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Departamento", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Departamento", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Departamento(Departamento, CuentaContableSalario, CuentaContableCCSS," & _
        " CuentaContableAguinaldo, CuentaContableVacaciones, CuentaContableProvAguinaldo," & _
        " CuentaContableProvVacaciones, CuentaContableRetencionesCCSS) VALUES (@Departame" & _
        "nto, @CuentaContableSalario, @CuentaContableCCSS, @CuentaContableAguinaldo, @Cue" & _
        "ntaContableVacaciones, @CuentaContableProvAguinaldo, @CuentaContableProvVacacion" & _
        "es, @CuentaContableRetencionesCCSS); SELECT Id, Departamento, CuentaContableSala" & _
        "rio, CuentaContableCCSS, CuentaContableAguinaldo, CuentaContableVacaciones, Cuen" & _
        "taContableProvAguinaldo, CuentaContableProvVacaciones, CuentaContableRetenciones" & _
        "CCSS FROM Departamento WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Departamento", System.Data.SqlDbType.VarChar, 100, "Departamento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableSalario", System.Data.SqlDbType.VarChar, 255, "CuentaContableSalario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableCCSS", System.Data.SqlDbType.VarChar, 255, "CuentaContableCCSS"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableAguinaldo", System.Data.SqlDbType.VarChar, 255, "CuentaContableAguinaldo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableVacaciones", System.Data.SqlDbType.VarChar, 255, "CuentaContableVacaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableProvAguinaldo", System.Data.SqlDbType.VarChar, 255, "CuentaContableProvAguinaldo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableProvVacaciones", System.Data.SqlDbType.VarChar, 255, "CuentaContableProvVacaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableRetencionesCCSS", System.Data.SqlDbType.VarChar, 255, "CuentaContableRetencionesCCSS"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id, Departamento, CuentaContableSalario, CuentaContableCCSS, CuentaContabl" & _
        "eAguinaldo, CuentaContableVacaciones, CuentaContableProvAguinaldo, CuentaContabl" & _
        "eProvVacaciones, CuentaContableRetencionesCCSS FROM Departamento"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Departamento SET Departamento = @Departamento, CuentaContableSalario = @Cu" & _
        "entaContableSalario, CuentaContableCCSS = @CuentaContableCCSS, CuentaContableAgu" & _
        "inaldo = @CuentaContableAguinaldo, CuentaContableVacaciones = @CuentaContableVac" & _
        "aciones, CuentaContableProvAguinaldo = @CuentaContableProvAguinaldo, CuentaConta" & _
        "bleProvVacaciones = @CuentaContableProvVacaciones, CuentaContableRetencionesCCSS" & _
        " = @CuentaContableRetencionesCCSS WHERE (Id = @Original_Id) AND (CuentaContableA" & _
        "guinaldo = @Original_CuentaContableAguinaldo OR @Original_CuentaContableAguinald" & _
        "o IS NULL AND CuentaContableAguinaldo IS NULL) AND (CuentaContableCCSS = @Origin" & _
        "al_CuentaContableCCSS OR @Original_CuentaContableCCSS IS NULL AND CuentaContable" & _
        "CCSS IS NULL) AND (CuentaContableProvAguinaldo = @Original_CuentaContableProvAgu" & _
        "inaldo OR @Original_CuentaContableProvAguinaldo IS NULL AND CuentaContableProvAg" & _
        "uinaldo IS NULL) AND (CuentaContableProvVacaciones = @Original_CuentaContablePro" & _
        "vVacaciones OR @Original_CuentaContableProvVacaciones IS NULL AND CuentaContable" & _
        "ProvVacaciones IS NULL) AND (CuentaContableRetencionesCCSS = @Original_CuentaCon" & _
        "tableRetencionesCCSS OR @Original_CuentaContableRetencionesCCSS IS NULL AND Cuen" & _
        "taContableRetencionesCCSS IS NULL) AND (CuentaContableSalario = @Original_Cuenta" & _
        "ContableSalario OR @Original_CuentaContableSalario IS NULL AND CuentaContableSal" & _
        "ario IS NULL) AND (CuentaContableVacaciones = @Original_CuentaContableVacaciones" & _
        " OR @Original_CuentaContableVacaciones IS NULL AND CuentaContableVacaciones IS N" & _
        "ULL) AND (Departamento = @Original_Departamento); SELECT Id, Departamento, Cuent" & _
        "aContableSalario, CuentaContableCCSS, CuentaContableAguinaldo, CuentaContableVac" & _
        "aciones, CuentaContableProvAguinaldo, CuentaContableProvVacaciones, CuentaContab" & _
        "leRetencionesCCSS FROM Departamento WHERE (Id = @Id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Departamento", System.Data.SqlDbType.VarChar, 100, "Departamento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableSalario", System.Data.SqlDbType.VarChar, 255, "CuentaContableSalario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableCCSS", System.Data.SqlDbType.VarChar, 255, "CuentaContableCCSS"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableAguinaldo", System.Data.SqlDbType.VarChar, 255, "CuentaContableAguinaldo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableVacaciones", System.Data.SqlDbType.VarChar, 255, "CuentaContableVacaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableProvAguinaldo", System.Data.SqlDbType.VarChar, 255, "CuentaContableProvAguinaldo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableProvVacaciones", System.Data.SqlDbType.VarChar, 255, "CuentaContableProvVacaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContableRetencionesCCSS", System.Data.SqlDbType.VarChar, 255, "CuentaContableRetencionesCCSS"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableAguinaldo", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableAguinaldo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableCCSS", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableCCSS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableProvAguinaldo", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableProvAguinaldo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableProvVacaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableProvVacaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableRetencionesCCSS", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableRetencionesCCSS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableSalario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableSalario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContableVacaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContableVacaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Departamento", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Departamento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(8, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Salario:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(8, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "C.C.S.S:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(8, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Aguinaldo:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(8, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Vacaciones:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(8, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Prov. Aguinaldo:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(8, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 13)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Prov. Vacaciones:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(8, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Retenciones C.C.C.S.:"
        '
        'txtCuentaContableSalario
        '
        Me.txtCuentaContableSalario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableSalario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableSalario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepartamento1, "Departamento.CuentaContableSalario"))
        Me.txtCuentaContableSalario.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableSalario.Location = New System.Drawing.Point(144, 104)
        Me.txtCuentaContableSalario.Name = "txtCuentaContableSalario"
        Me.txtCuentaContableSalario.Size = New System.Drawing.Size(128, 13)
        Me.txtCuentaContableSalario.TabIndex = 1
        Me.txtCuentaContableSalario.Text = ""
        '
        'txtCuentaContableSalarioDescripcion
        '
        Me.txtCuentaContableSalarioDescripcion.BackColor = System.Drawing.Color.White
        Me.txtCuentaContableSalarioDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableSalarioDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableSalarioDescripcion.Enabled = False
        Me.txtCuentaContableSalarioDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableSalarioDescripcion.Location = New System.Drawing.Point(280, 104)
        Me.txtCuentaContableSalarioDescripcion.Name = "txtCuentaContableSalarioDescripcion"
        Me.txtCuentaContableSalarioDescripcion.Size = New System.Drawing.Size(184, 13)
        Me.txtCuentaContableSalarioDescripcion.TabIndex = 70
        Me.txtCuentaContableSalarioDescripcion.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(144, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Cuenta Contable:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(280, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 13)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Descripción:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCuentaContableCCSS
        '
        Me.txtCuentaContableCCSS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableCCSS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableCCSS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepartamento1, "Departamento.CuentaContableCCSS"))
        Me.txtCuentaContableCCSS.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableCCSS.Location = New System.Drawing.Point(144, 128)
        Me.txtCuentaContableCCSS.Name = "txtCuentaContableCCSS"
        Me.txtCuentaContableCCSS.Size = New System.Drawing.Size(128, 13)
        Me.txtCuentaContableCCSS.TabIndex = 2
        Me.txtCuentaContableCCSS.Text = ""
        '
        'txtCuentaContableAguinaldo
        '
        Me.txtCuentaContableAguinaldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableAguinaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableAguinaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepartamento1, "Departamento.CuentaContableAguinaldo"))
        Me.txtCuentaContableAguinaldo.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableAguinaldo.Location = New System.Drawing.Point(144, 152)
        Me.txtCuentaContableAguinaldo.Name = "txtCuentaContableAguinaldo"
        Me.txtCuentaContableAguinaldo.Size = New System.Drawing.Size(128, 13)
        Me.txtCuentaContableAguinaldo.TabIndex = 3
        Me.txtCuentaContableAguinaldo.Text = ""
        '
        'txtCuentaContableVacaciones
        '
        Me.txtCuentaContableVacaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableVacaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableVacaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepartamento1, "Departamento.CuentaContableVacaciones"))
        Me.txtCuentaContableVacaciones.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableVacaciones.Location = New System.Drawing.Point(144, 176)
        Me.txtCuentaContableVacaciones.Name = "txtCuentaContableVacaciones"
        Me.txtCuentaContableVacaciones.Size = New System.Drawing.Size(128, 13)
        Me.txtCuentaContableVacaciones.TabIndex = 4
        Me.txtCuentaContableVacaciones.Text = ""
        '
        'txtCuentaContableProvAguinaldo
        '
        Me.txtCuentaContableProvAguinaldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableProvAguinaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableProvAguinaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepartamento1, "Departamento.CuentaContableProvAguinaldo"))
        Me.txtCuentaContableProvAguinaldo.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableProvAguinaldo.Location = New System.Drawing.Point(144, 200)
        Me.txtCuentaContableProvAguinaldo.Name = "txtCuentaContableProvAguinaldo"
        Me.txtCuentaContableProvAguinaldo.Size = New System.Drawing.Size(128, 13)
        Me.txtCuentaContableProvAguinaldo.TabIndex = 5
        Me.txtCuentaContableProvAguinaldo.Text = ""
        '
        'txtCuentaContableProvVacaciones
        '
        Me.txtCuentaContableProvVacaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableProvVacaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableProvVacaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepartamento1, "Departamento.CuentaContableProvVacaciones"))
        Me.txtCuentaContableProvVacaciones.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableProvVacaciones.Location = New System.Drawing.Point(144, 224)
        Me.txtCuentaContableProvVacaciones.Name = "txtCuentaContableProvVacaciones"
        Me.txtCuentaContableProvVacaciones.Size = New System.Drawing.Size(128, 13)
        Me.txtCuentaContableProvVacaciones.TabIndex = 6
        Me.txtCuentaContableProvVacaciones.Text = ""
        '
        'txtCuentaContableRetencionesCCSS
        '
        Me.txtCuentaContableRetencionesCCSS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableRetencionesCCSS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableRetencionesCCSS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepartamento1, "Departamento.CuentaContableRetencionesCCSS"))
        Me.txtCuentaContableRetencionesCCSS.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableRetencionesCCSS.Location = New System.Drawing.Point(144, 248)
        Me.txtCuentaContableRetencionesCCSS.Name = "txtCuentaContableRetencionesCCSS"
        Me.txtCuentaContableRetencionesCCSS.Size = New System.Drawing.Size(128, 13)
        Me.txtCuentaContableRetencionesCCSS.TabIndex = 7
        Me.txtCuentaContableRetencionesCCSS.Text = ""
        '
        'txtCuentaContableCCSSDescripcion
        '
        Me.txtCuentaContableCCSSDescripcion.BackColor = System.Drawing.Color.White
        Me.txtCuentaContableCCSSDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableCCSSDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableCCSSDescripcion.Enabled = False
        Me.txtCuentaContableCCSSDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableCCSSDescripcion.Location = New System.Drawing.Point(280, 128)
        Me.txtCuentaContableCCSSDescripcion.Name = "txtCuentaContableCCSSDescripcion"
        Me.txtCuentaContableCCSSDescripcion.Size = New System.Drawing.Size(184, 13)
        Me.txtCuentaContableCCSSDescripcion.TabIndex = 79
        Me.txtCuentaContableCCSSDescripcion.Text = ""
        '
        'txtCuentaContableAguinaldoDescripcion
        '
        Me.txtCuentaContableAguinaldoDescripcion.BackColor = System.Drawing.Color.White
        Me.txtCuentaContableAguinaldoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableAguinaldoDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableAguinaldoDescripcion.Enabled = False
        Me.txtCuentaContableAguinaldoDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableAguinaldoDescripcion.Location = New System.Drawing.Point(280, 152)
        Me.txtCuentaContableAguinaldoDescripcion.Name = "txtCuentaContableAguinaldoDescripcion"
        Me.txtCuentaContableAguinaldoDescripcion.Size = New System.Drawing.Size(184, 13)
        Me.txtCuentaContableAguinaldoDescripcion.TabIndex = 80
        Me.txtCuentaContableAguinaldoDescripcion.Text = ""
        '
        'txtCuentaContableVacacionesDescripcion
        '
        Me.txtCuentaContableVacacionesDescripcion.BackColor = System.Drawing.Color.White
        Me.txtCuentaContableVacacionesDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableVacacionesDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableVacacionesDescripcion.Enabled = False
        Me.txtCuentaContableVacacionesDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableVacacionesDescripcion.Location = New System.Drawing.Point(280, 176)
        Me.txtCuentaContableVacacionesDescripcion.Name = "txtCuentaContableVacacionesDescripcion"
        Me.txtCuentaContableVacacionesDescripcion.Size = New System.Drawing.Size(184, 13)
        Me.txtCuentaContableVacacionesDescripcion.TabIndex = 81
        Me.txtCuentaContableVacacionesDescripcion.Text = ""
        '
        'txtCuentaContableProvAguinaldoDescripcion
        '
        Me.txtCuentaContableProvAguinaldoDescripcion.BackColor = System.Drawing.Color.White
        Me.txtCuentaContableProvAguinaldoDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableProvAguinaldoDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableProvAguinaldoDescripcion.Enabled = False
        Me.txtCuentaContableProvAguinaldoDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableProvAguinaldoDescripcion.Location = New System.Drawing.Point(280, 200)
        Me.txtCuentaContableProvAguinaldoDescripcion.Name = "txtCuentaContableProvAguinaldoDescripcion"
        Me.txtCuentaContableProvAguinaldoDescripcion.Size = New System.Drawing.Size(184, 13)
        Me.txtCuentaContableProvAguinaldoDescripcion.TabIndex = 82
        Me.txtCuentaContableProvAguinaldoDescripcion.Text = ""
        '
        'txtCuentaContableProvVacacionesDescripcion
        '
        Me.txtCuentaContableProvVacacionesDescripcion.BackColor = System.Drawing.Color.White
        Me.txtCuentaContableProvVacacionesDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableProvVacacionesDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableProvVacacionesDescripcion.Enabled = False
        Me.txtCuentaContableProvVacacionesDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableProvVacacionesDescripcion.Location = New System.Drawing.Point(280, 224)
        Me.txtCuentaContableProvVacacionesDescripcion.Name = "txtCuentaContableProvVacacionesDescripcion"
        Me.txtCuentaContableProvVacacionesDescripcion.Size = New System.Drawing.Size(184, 13)
        Me.txtCuentaContableProvVacacionesDescripcion.TabIndex = 83
        Me.txtCuentaContableProvVacacionesDescripcion.Text = ""
        '
        'txtCuentaContableRetencionesCCSSDescripcion
        '
        Me.txtCuentaContableRetencionesCCSSDescripcion.BackColor = System.Drawing.Color.White
        Me.txtCuentaContableRetencionesCCSSDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaContableRetencionesCCSSDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContableRetencionesCCSSDescripcion.Enabled = False
        Me.txtCuentaContableRetencionesCCSSDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaContableRetencionesCCSSDescripcion.Location = New System.Drawing.Point(280, 248)
        Me.txtCuentaContableRetencionesCCSSDescripcion.Name = "txtCuentaContableRetencionesCCSSDescripcion"
        Me.txtCuentaContableRetencionesCCSSDescripcion.Size = New System.Drawing.Size(184, 13)
        Me.txtCuentaContableRetencionesCCSSDescripcion.TabIndex = 84
        Me.txtCuentaContableRetencionesCCSSDescripcion.Text = ""
        '
        'DsConfiguracion1
        '
        Me.DsConfiguracion1.DataSetName = "DsConfiguracion"
        Me.DsConfiguracion1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Departamento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(474, 320)
        Me.Controls.Add(Me.txtCuentaContableRetencionesCCSSDescripcion)
        Me.Controls.Add(Me.txtCuentaContableProvVacacionesDescripcion)
        Me.Controls.Add(Me.txtCuentaContableProvAguinaldoDescripcion)
        Me.Controls.Add(Me.txtCuentaContableVacacionesDescripcion)
        Me.Controls.Add(Me.txtCuentaContableAguinaldoDescripcion)
        Me.Controls.Add(Me.txtCuentaContableCCSSDescripcion)
        Me.Controls.Add(Me.txtCuentaContableRetencionesCCSS)
        Me.Controls.Add(Me.txtCuentaContableProvVacaciones)
        Me.Controls.Add(Me.txtCuentaContableProvAguinaldo)
        Me.Controls.Add(Me.txtCuentaContableVacaciones)
        Me.Controls.Add(Me.txtCuentaContableAguinaldo)
        Me.Controls.Add(Me.txtCuentaContableCCSS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCuentaContableSalarioDescripcion)
        Me.Controls.Add(Me.txtCuentaContableSalario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataNavigator1)
        Me.Name = "Departamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de Departamentos"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNombre, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableSalario, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableSalarioDescripcion, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableCCSS, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableAguinaldo, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableVacaciones, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableProvAguinaldo, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableProvVacaciones, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableRetencionesCCSS, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableCCSSDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableAguinaldoDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableVacacionesDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableProvAguinaldoDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableProvVacacionesDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaContableRetencionesCCSSDescripcion, 0)
        CType(Me.DsDepartamento1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsConfiguracion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Departamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
            TxtNombre.Enabled = False
            Me.adDepartamento.Fill(Me.DsDepartamento1, "Departamento")
            Me.DsDepartamento1.Departamento.DepartamentoColumn.DefaultValue = ""
            ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(4).Enabled = False
            ToolBar1.Buttons(5).Enabled = True
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
                Me.DsDepartamento1.Departamento.Clear()
                Me.BindingContext(Me.DsDepartamento1, "Departamento").CancelCurrentEdit()
                Me.BindingContext(Me.DsDepartamento1, "Departamento").EndCurrentEdit()
                Me.BindingContext(Me.DsDepartamento1, "Departamento").AddNew()
                Me.ToolBar1.Buttons(1).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = True
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.ToolBar1.Buttons(5).Enabled = True
                Me.TxtNombre.Enabled = True
                Me.TxtNombre.Focus()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                Me.BindingContext(Me.DsDepartamento1, "Departamento").CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = True
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.TxtNombre.Enabled = False
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Function

    Private Function Buscar()
        Dim funcion As New cFunciones
        Dim Id As Integer

        Try
            LimpiarCuentaContable()
            Me.DsDepartamento1.Departamento.Clear()
            Id = funcion.BuscarDatos("Select id as Identificador, Departamento as Nombre from Departamento", "Departamento", "Buscar Departamento ...")
            buscando = True
            If Id = 0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Function
            End If
            Me.LlenarDepartamento(Id)

            BuscarCuentaContableDescripcion(Me.txtCuentaContableAguinaldo, Me.txtCuentaContableAguinaldoDescripcion)
            BuscarCuentaContableDescripcion(Me.txtCuentaContableCCSS, Me.txtCuentaContableCCSSDescripcion)
            BuscarCuentaContableDescripcion(Me.txtCuentaContableProvAguinaldo, Me.txtCuentaContableProvAguinaldoDescripcion)
            BuscarCuentaContableDescripcion(Me.txtCuentaContableProvVacaciones, Me.txtCuentaContableProvVacacionesDescripcion)
            BuscarCuentaContableDescripcion(Me.txtCuentaContableRetencionesCCSS, Me.txtCuentaContableRetencionesCCSSDescripcion)
            BuscarCuentaContableDescripcion(Me.txtCuentaContableSalario, Me.txtCuentaContableSalarioDescripcion)
            BuscarCuentaContableDescripcion(Me.txtCuentaContableVacaciones, Me.txtCuentaContableVacacionesDescripcion)

            'nuevo
            Me.ToolBar1.Buttons(0).Enabled = True
            'buscar
            Me.ToolBar1.Buttons(1).Enabled = True
            'editar
            Me.ToolBar1.Buttons(2).Enabled = True
            'registrar
            Me.ToolBar1.Buttons(3).Enabled = True
            'eliminar
            Me.ToolBar1.Buttons(4).Enabled = True
            'Imprimir
            Me.ToolBar1.Buttons(5).Enabled = True
            'Cerrar
            Me.ToolBar1.Buttons(6).Enabled = True
            Me.TxtNombre.Enabled = False
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function

    Function LlenarDepartamento(ByVal Id As Integer)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        'Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''LLENAR DEPARTAMENTO''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM Departamento WHERE (id = @Id_Departamento)"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Departamento", SqlDbType.Int))
            cmdv.Parameters("@Id_Departamento").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DsDepartamento1, "Departamento")
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

    Function Editar()
        Me.TxtNombre.Enabled = True
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
        If Me.TxtNombre.Text = "" Then
            MsgBox("Digite un nombre de departamento", MsgBoxStyle.Information, "Atención...")
            Exit Function
        End If

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            'finaliza la edición
            Me.adDepartamento.UpdateCommand.Transaction = Trans
            Me.adDepartamento.InsertCommand.Transaction = Trans
            Me.adDepartamento.DeleteCommand.Transaction = Trans

            Me.BindingContext(Me.DsDepartamento1, "Departamento").EndCurrentEdit()
            Me.adDepartamento.Update(Me.DsDepartamento1, "Departamento")
            Trans.Commit()
            Me.DsDepartamento1.AcceptChanges()
            MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Me.TxtNombre.Enabled = False
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
            Me.DsDepartamento1.Departamento.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Trans.Rollback()
        End Try
    End Function

    Private Sub eliminar()
        Dim strdel As String = Me.TxtNombre.Text
        Dim Cconexion As New Conexion
        Dim Resultado As String
        If Me.TxtNombre.Text <> "" Then
            If MessageBox.Show(" ¿ Desea Eliminar este Departamento ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub

            Dim rs As SqlDataReader
            rs = Cconexion.GetRecorset(Cconexion.Conectar, "SELECT Identificacion FROM Empleado inner join Departamento on Empleado.Cod_Departamento = Departamento.Id" & _
            " where Departamento.Departamento = '" & strdel & "'")

            If rs.Read Then
                MsgBox("Estos datos no se pueden eliminar, existen empleados asociados a estos datos", MsgBoxStyle.Exclamation, "Error...")
                Exit Sub
            End If
            rs.Close()

            Resultado = Cconexion.SlqExecute(Cconexion.Conectar, "Delete from Departamento where Departamento='" & Me.TxtNombre.Text & "'")
            If Resultado = vbNullString Then
                MessageBox.Show("El Departamento fue eliminado", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DsDepartamento1.Departamento.Clear()
                Me.TxtNombre.Enabled = False
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
            MessageBox.Show("No hay departamento a eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function imprimir()
        Try
            Dim Imprimir_Departamentos As New ListadoDepartamento
            Dim visor As New frmVisorReportes
            'visor.rptViewer.ReportSource = Imprimir_Departamentos
            'visor.Show()
            Utilidades.CrystalReportsConexion.LoadShow(Imprimir_Departamentos, Me.MdiParent, Me.SqlConnection1.ConnectionString)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Function

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1

            Case 1 : Nuevo()

            Case 2
                If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : Editar()

            Case 4
                If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5
                If PMU.Delete Then eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6
                If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 7 : Me.Close()

        End Select
    End Sub

    Private Sub BuscarCuentaContableDescripcion(ByRef ptxtCuenta As Windows.Forms.TextBox, ByRef ptxtDescripcion As Windows.Forms.TextBox)
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()
        sql = "SELECT Descripcion FROM Contabilidad.dbo.CuentaContable WHERE CuentaContable = '" & ptxtCuenta.Text & "'"
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() Then
            ptxtDescripcion.Text = rstReader(0)
            SendKeys.Send("{TAB}")
        End If

        rstReader.Close()
        cnnConexion.Close()
    End Sub

    Private Sub txtCuentaContableSalario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContableSalario.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta(txtCuentaContableSalario, Me.txtCuentaContableSalarioDescripcion)
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContableDescripcion(txtCuentaContableSalario, Me.txtCuentaContableSalarioDescripcion)
        End If
    End Sub

    Private Sub txtCuentaContableCCSS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContableCCSS.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta(txtCuentaContableCCSS, txtCuentaContableCCSSDescripcion)
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContableDescripcion(txtCuentaContableCCSS, txtCuentaContableCCSSDescripcion)
        End If
    End Sub

    Private Sub txtCuentaContableAguinaldo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContableAguinaldo.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta(txtCuentaContableAguinaldo, txtCuentaContableAguinaldoDescripcion)
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContableDescripcion(txtCuentaContableAguinaldo, txtCuentaContableAguinaldoDescripcion)
        End If
    End Sub


    Private Sub txtCuentaContableVacaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContableVacaciones.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta(txtCuentaContableVacaciones, txtCuentaContableVacacionesDescripcion)
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContableDescripcion(txtCuentaContableVacaciones, txtCuentaContableVacacionesDescripcion)
        End If
    End Sub

    Private Sub txtCuentaContableProvAguinaldo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContableProvAguinaldo.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta(txtCuentaContableProvAguinaldo, txtCuentaContableProvAguinaldoDescripcion)
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContableDescripcion(txtCuentaContableProvAguinaldo, txtCuentaContableProvAguinaldoDescripcion)
        End If
    End Sub

    Private Sub txtCuentaContableProvVacaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContableProvVacaciones.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta(txtCuentaContableProvVacaciones, Me.txtCuentaContableProvVacacionesDescripcion)
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContableDescripcion(txtCuentaContableProvVacaciones, Me.txtCuentaContableProvVacacionesDescripcion)
        End If
    End Sub

    Private Sub txtCuentaContableRetencionesCCSS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContableRetencionesCCSS.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta(txtCuentaContableRetencionesCCSS, txtCuentaContableRetencionesCCSSDescripcion)
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContableDescripcion(txtCuentaContableRetencionesCCSS, txtCuentaContableRetencionesCCSSDescripcion)
        End If
    End Sub

    Private Sub LlamarFmrBuscarAsientoVenta(ByRef ptxtCuenta As Windows.Forms.TextBox, ByRef ptxtDescripcion As Windows.Forms.TextBox)

        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
" where Movimiento=1 "
        busca.campo = "descripcion"
        busca.sqlStringAdicional = " ORDER BY CuentaContable  "
        busca.ShowDialog()

        If busca.codigo Is Nothing Then Exit Sub

        ptxtCuenta.Text = busca.codigo
        ptxtDescripcion.Text = busca.descrip


    End Sub

    Private Sub LimpiarCuentaContable()
        Me.txtCuentaContableAguinaldoDescripcion.Text = ""
        Me.txtCuentaContableCCSSDescripcion.Text = ""
        Me.txtCuentaContableProvAguinaldoDescripcion.Text = ""
        Me.txtCuentaContableProvVacacionesDescripcion.Text = ""
        Me.txtCuentaContableRetencionesCCSSDescripcion.Text = ""
        Me.txtCuentaContableSalarioDescripcion.Text = ""
        Me.txtCuentaContableVacacionesDescripcion.Text = ""
    End Sub

    Private Sub txtCuentaContableSalario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaContableSalario.TextChanged

    End Sub

    Private Sub TxtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombre.TextChanged

    End Sub
End Class
