Imports System.Data.SqlClient
Imports Utilidades
Public Class FrmNacionalidad
    Inherits Planilla.FrmPlantilla
    Dim buscando As Boolean
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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterNacionalidad As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsNacionalidad1 As Planilla.DsNacionalidad1
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterNacionalidad = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DsNacionalidad1 = New Planilla.DsNacionalidad1
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DsNacionalidad1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(346, 32)
        Me.TituloModulo.Text = "Nacionalidades"
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 248)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(346, 56)
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=JEANCARLO;packet size=4096;integrated security=SSPI;data source=JE" & _
        "ANCARLO;persist security info=False;initial catalog=Planilla"
        '
        'AdapterNacionalidad
        '
        Me.AdapterNacionalidad.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterNacionalidad.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterNacionalidad.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterNacionalidad.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Nacionalidad", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("ABREV", "ABREV")})})
        Me.AdapterNacionalidad.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Nacionalidad WHERE (Codigo = @Original_Codigo) AND (ABREV = @Original" & _
        "_ABREV) AND (Descripcion = @Original_Descripcion)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABREV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABREV", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Nacionalidad(Descripcion, ABREV) VALUES (@Descripcion, @ABREV); SELEC" & _
        "T Codigo, Descripcion, ABREV FROM Nacionalidad WHERE (Codigo = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 50, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABREV", System.Data.SqlDbType.VarChar, 2, "ABREV"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Descripcion, ABREV FROM Nacionalidad"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Nacionalidad SET Descripcion = @Descripcion, ABREV = @ABREV WHERE (Codigo " & _
        "= @Original_Codigo) AND (ABREV = @Original_ABREV) AND (Descripcion = @Original_D" & _
        "escripcion); SELECT Codigo, Descripcion, ABREV FROM Nacionalidad WHERE (Codigo =" & _
        " @Codigo)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 50, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ABREV", System.Data.SqlDbType.VarChar, 2, "ABREV"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ABREV", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ABREV", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        '
        'DsNacionalidad1
        '
        Me.DsNacionalidad1.DataSetName = "DsNacionalidad1"
        Me.DsNacionalidad1.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataNavigator1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 192)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.DataMember = "Nacionalidad"
        Me.DataNavigator1.DataSource = Me.DsNacionalidad1
        Me.DataNavigator1.Location = New System.Drawing.Point(160, 160)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(168, 24)
        Me.DataNavigator1.TabIndex = 4
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNacionalidad1, "Nacionalidad.ABREV"))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(80, 136)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(184, 21)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsNacionalidad1, "Nacionalidad.Descripcion"))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(80, 56)
        Me.TextBox1.MaxLength = 25
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 21)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Abreviatura"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nacionalidad"
        '
        'FrmNacionalidad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(346, 304)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmNacionalidad"
        Me.Text = "Administrador de Nacionalidad"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        CType(Me.DsNacionalidad1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

 
#Region "Nuevo"
    Private Function Nuevo()
        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            'cambia la imagen de nuevo y desabilita los botones
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Try 'inicia la edicion
                Me.DsNacionalidad1.Nacionalidad.Clear()
                Me.BindingContext(Me.DsNacionalidad1, "Nacionalidad").CancelCurrentEdit()
                Me.BindingContext(Me.DsNacionalidad1, "Nacionalidad").EndCurrentEdit()
                Me.BindingContext(Me.DsNacionalidad1, "Nacionalidad").AddNew()
                Me.ToolBar1.Buttons(1).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = True
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.ToolBar1.Buttons(5).Enabled = False
                Desbloquear()
                Me.TextBox1.Focus()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                Me.BindingContext(Me.DsNacionalidad1, "Nacionalidad").CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(2).Enabled = True
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False
                Bloquear()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Function
#End Region
#Region "Editar"
    Function Editar()
        Desbloquear()
        'nuevo
        Me.ToolBar1.Buttons(0).Enabled = True
        Me.ToolBar1.Buttons(0).ImageIndex = 8
        Me.ToolBar1.Buttons(0).Text = "Cancelar"
        'buscar
        Me.ToolBar1.Buttons(1).Enabled = False
        'editar
        Me.ToolBar1.Buttons(2).Enabled = False
        'registrar
        Me.ToolBar1.Buttons(3).Enabled = True
        'eliminar
        Me.ToolBar1.Buttons(4).Enabled = False
        'Imprimir
        Me.ToolBar1.Buttons(5).Enabled = False
        'Cerrar
        Me.ToolBar1.Buttons(6).Enabled = True
    End Function
#End Region
#Region "Guardar"
    Private Function Guardar()
        Dim resp As Integer
        If Me.TextBox1.Text = "" Then
            MsgBox("Debe ingresar la Nacionalidad", MsgBoxStyle.Information, "Atención...")
            Me.TextBox1.Focus()
            Exit Function
        End If
        If Me.TextBox2.Text = "" Then
            MsgBox("Debe ingresar la Abreviatura", MsgBoxStyle.Information, "Atención...")
            Me.TextBox2.Focus()
            Exit Function
        End If
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            'finaliza la edición
            Me.BindingContext(Me.DsNacionalidad1, "Nacionalidad").EndCurrentEdit()
            Me.AdapterNacionalidad.UpdateCommand.Transaction = Trans
            Me.AdapterNacionalidad.InsertCommand.Transaction = Trans
            Me.AdapterNacionalidad.DeleteCommand.Transaction = Trans

            Me.AdapterNacionalidad.Update(Me.DsNacionalidad1, "Nacionalidad")

            Trans.Commit()
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            'txtUsuario.Text = ""
            Me.DsNacionalidad1.AcceptChanges()
            MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)

            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Bloquear()
            'nuevo
            Me.ToolBar1.Buttons(0).Enabled = True
            'buscar
            Me.ToolBar1.Buttons(1).Enabled = True
            'Editar
            Me.ToolBar1.Buttons(2).Enabled = True
            'registrar
            Me.ToolBar1.Buttons(3).Enabled = False
            'eliminar
            Me.ToolBar1.Buttons(4).Enabled = False
            'Imprimir
            Me.ToolBar1.Buttons(5).Enabled = True
            'cerrar
            Me.ToolBar1.Buttons(6).Enabled = True
            Me.DsNacionalidad1.Nacionalidad.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Trans.Rollback()
        End Try
    End Function
#End Region
#Region "Controles"
    Private Sub Bloquear()
        Me.TextBox1.Enabled = False
        Me.TextBox2.Enabled = False
    End Sub

    Private Sub Desbloquear()
        Me.TextBox1.Enabled = True
        Me.TextBox2.Enabled = True
    End Sub
#End Region

    Private Sub FrmNacionalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
        Me.AdapterNacionalidad.Fill(Me.DsNacionalidad1, "Nacionalidad")
        'Me.DsNacionalidad1.Nacionalidad.DescripcionColumn.DefaultValue = ""
        ' Me.DsNacionalidad1.Nacionalidad.ABREVColumn.DefaultValue = ""
        Bloquear()
        ToolBar1.Buttons(2).Enabled = True
        ToolBar1.Buttons(3).Enabled = False
        ToolBar1.Buttons(4).Enabled = False
        ToolBar1.Buttons(5).Enabled = False
    End Sub
    Sub Buscar()
        Dim funcion As New cFunciones
        Dim Id As String
        Try
            Me.DsNacionalidad1.Nacionalidad.Clear()
            Id = funcion.BuscarDatos("Select Codigo, Descripcion from Nacionalidad", "Nombre", "Buscar Nacionalidad ...", SqlConnection1.ConnectionString)
            buscando = True
            If Id = 0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Sub
            End If
            llenar(Id)
           Me.AdapterNacionalidad.Fill(Me.DsNacionalidad1, "Nacionalidad")
            'nuevo
            Me.ToolBar1.Buttons(0).Enabled = True
            'buscar
            Me.ToolBar1.Buttons(1).Enabled = True
            'editar
            Me.ToolBar1.Buttons(2).Enabled = True
            'registrar
            Me.ToolBar1.Buttons(3).Enabled = False
            'eliminar
            'Imprimir
            Me.ToolBar1.Buttons(5).Enabled = True
            'Cerrar
            Me.ToolBar1.Buttons(6).Enabled = True
            Bloquear()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub llenar(ByVal id As String)
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
            Dim sel As String = "SELECT * FROM Nacionalidad WHERE (Codigo = @Id_Codigo)"
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
            dv.Fill(Me.DsNacionalidad1, "Nacionalidad")
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
    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()

            Case 2 : Buscar()

            Case 3 : Editar()

            Case 4 : Guardar()
                'Case 5 : 

            Case 7 : Me.Close()
        End Select
    End Sub
End Class
