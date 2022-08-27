Imports System.data.sqlclient
Imports Utilidades
Public Class frmEstadoEmpleado
    Inherits FrmPlantilla
    Dim buscando As Boolean
    Dim usua As Object
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        usua = Usuario_Parametro
        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adEstadoEmpleado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsEstadoEmpleado1 As Planilla.dsEstadoEmpleado
    Friend WithEvents checkSalidad As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.DsEstadoEmpleado1 = New Planilla.dsEstadoEmpleado
        Me.Label2 = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.adEstadoEmpleado = New System.Data.SqlClient.SqlDataAdapter
        Me.checkSalidad = New DevExpress.XtraEditors.CheckEdit
        CType(Me.DsEstadoEmpleado1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkSalidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 108)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(418, 52)
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(418, 32)
        Me.TituloModulo.Text = "Estado del Empleado"
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsEstadoEmpleado1, "Estado_Empleado.Descripcion"))
        Me.TxtNombre.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombre.Location = New System.Drawing.Point(8, 56)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(384, 13)
        Me.TxtNombre.TabIndex = 63
        Me.TxtNombre.Text = ""
        '
        'DsEstadoEmpleado1
        '
        Me.DsEstadoEmpleado1.DataSetName = "dsEstadoEmpleado"
        Me.DsEstadoEmpleado1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Estado del Empleado"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Descripcion, Salida FROM Estado_Empleado"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=SEESER" & _
        "VER;persist security info=False;initial catalog=Planilla"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Estado_Empleado(Descripcion, Salida) VALUES (@Descripcion, @Salida); " & _
        "SELECT Codigo, Descripcion, Salida FROM Estado_Empleado WHERE (Codigo = @@IDENTI" & _
        "TY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 1, "Salida"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Estado_Empleado SET Descripcion = @Descripcion, Salida = @Salida WHERE (Co" & _
        "digo = @Original_Codigo) AND (Descripcion = @Original_Descripcion) AND (Salida =" & _
        " @Original_Salida); SELECT Codigo, Descripcion, Salida FROM Estado_Empleado WHER" & _
        "E (Codigo = @Codigo)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 1, "Salida"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salida", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salida", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Estado_Empleado WHERE (Codigo = @Original_Codigo) AND (Descripcion = " & _
        "@Original_Descripcion) AND (Salida = @Original_Salida)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Salida", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Salida", System.Data.DataRowVersion.Original, Nothing))
        '
        'adEstadoEmpleado
        '
        Me.adEstadoEmpleado.DeleteCommand = Me.SqlDeleteCommand1
        Me.adEstadoEmpleado.InsertCommand = Me.SqlInsertCommand1
        Me.adEstadoEmpleado.SelectCommand = Me.SqlSelectCommand1
        Me.adEstadoEmpleado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Estado_Empleado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Salida", "Salida")})})
        Me.adEstadoEmpleado.UpdateCommand = Me.SqlUpdateCommand1
        '
        'checkSalidad
        '
        Me.checkSalidad.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsEstadoEmpleado1, "Estado_Empleado.Salida"))
        Me.checkSalidad.EditValue = False
        Me.checkSalidad.Location = New System.Drawing.Point(8, 80)
        Me.checkSalidad.Name = "checkSalidad"
        '
        'checkSalidad.Properties
        '
        Me.checkSalidad.Properties.Caption = "Salida"
        Me.checkSalidad.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ActiveCaption)
        Me.checkSalidad.Size = New System.Drawing.Size(96, 19)
        Me.checkSalidad.TabIndex = 65
        '
        'frmEstadoEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(418, 160)
        Me.Controls.Add(Me.checkSalidad)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmEstadoEmpleado"
        Me.Text = "Estado del Empleado"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNombre, 0)
        Me.Controls.SetChildIndex(Me.checkSalidad, 0)
        CType(Me.DsEstadoEmpleado1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkSalidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmEstadoEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "Conexion")
            TxtNombre.Enabled = False
            checkSalidad.Enabled = False
            Me.adEstadoEmpleado.Fill(Me.DsEstadoEmpleado1, "Estado_Empleado")
            Me.DsEstadoEmpleado1.Estado_Empleado.DescripcionColumn.DefaultValue = ""
            Me.DsEstadoEmpleado1.Estado_Empleado.SalidaColumn.DefaultValue = 0
            ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(4).Enabled = False
            ToolBar1.Buttons(5).Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Nuevo()
        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            'cambia la imagen de nuevo y desabilita los botones
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Try 'inicia la edicion
                '--------------------------------------------------------
                Me.DsEstadoEmpleado1.Estado_Empleado.Clear()
                Me.BindingContext(Me.DsEstadoEmpleado1, "Estado_Empleado").CancelCurrentEdit()
                Me.BindingContext(Me.DsEstadoEmpleado1, "Estado_Empleado").EndCurrentEdit()
                Me.BindingContext(Me.DsEstadoEmpleado1, "Estado_Empleado").AddNew()
                Me.ToolBar1.Buttons(1).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = True
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.ToolBar1.Buttons(5).Enabled = True
                Me.TxtNombre.Enabled = True
                Me.checkSalidad.Enabled = True
                Me.TxtNombre.Focus()
                '--------------------------------------------------------
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try

                'cambia la imagen a nuevo y habilita los botones del toolbar1
                '------------------------------------------------------------
                Me.BindingContext(Me.DsEstadoEmpleado1, "Estado_Empleado").CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(1).Enabled = True
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False
                Me.TxtNombre.Enabled = False
                '-----------------------------------------------------------

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If

    End Function

    Private Function Buscar()

        Dim funcion As New cFunciones
        Dim Id As Integer

        Try

            Me.DsEstadoEmpleado1.Estado_Empleado.Clear()
            Id = funcion.BuscarDatos("Select Codigo as Identificador, Descripcion as Nombre from Estado_Empleado", "Descripcion", "Buscar Estado del Empleado ...")
            buscando = True
            If Id = 0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Function
            End If

            Me.LlenarEstado(Id)
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
            Me.TxtNombre.Enabled = False

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
    Function LlenarEstado(ByVal Id As Integer)
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
            Dim sel As String = "SELECT * FROM Estado_Empleado WHERE (Codigo = @Id_Codigo)"
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
            dv.Fill(Me.DsEstadoEmpleado1, "Estado_Empleado")
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
        Me.checkSalidad.Enabled = True
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
            MsgBox("Digite un estado del empleado", MsgBoxStyle.Information, "Atención...")
            Exit Function
        End If

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            'finaliza la edición
            Me.adEstadoEmpleado.UpdateCommand.Transaction = Trans
            Me.adEstadoEmpleado.InsertCommand.Transaction = Trans
            Me.adEstadoEmpleado.DeleteCommand.Transaction = Trans

            Me.BindingContext(Me.DsEstadoEmpleado1, "Estado_Empleado").EndCurrentEdit()
            Me.adEstadoEmpleado.Update(Me.DsEstadoEmpleado1, "Estado_Empleado")
            Trans.Commit()
            Me.DsEstadoEmpleado1.AcceptChanges()
            MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Me.TxtNombre.Enabled = False
            Me.checkSalidad.Enabled = False
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
            Me.DsEstadoEmpleado1.Estado_Empleado.Clear()
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
            If MessageBox.Show(" ¿ Desea Eliminar este estado del empleado ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub

            Dim rs As SqlDataReader
            rs = Cconexion.GetRecorset(Cconexion.Conectar, "SELECT Identificacion FROM Empleado inner join Estado_Empleado on Empleado.Cod_Estado = Estado_Empleado.Codigo" & _
            " where Estado_Empleado.Descripcion = '" & strdel & "'")

            If rs.Read Then
                MsgBox("Estos datos no se pueden eliminar, existen empleados asociados a estos datos", MsgBoxStyle.Exclamation, "Error...")
                Exit Sub
            End If
            rs.Close()

            Resultado = Cconexion.SlqExecute(Cconexion.Conectar, "Delete from Estado_Empleado where Descripcion='" & Me.TxtNombre.Text & "'")
            If Resultado = vbNullString Then
                MessageBox.Show("El Estado del empleado fue eliminado", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DsEstadoEmpleado1.Estado_Empleado.Clear()
                Me.TxtNombre.Enabled = False
                Me.checkSalidad.Enabled = False
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
            MessageBox.Show("No hay estado a eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function imprimir()
        Try
            Dim Imprimir_Estados As New RepEstadoEmpleado
            'Dim visor As New frmVisorReportes
            'visor.rptViewer.ReportSource = Imprimir_Estados
            'visor.Show()
            Utilidades.CrystalReportsConexion.LoadShow(Imprimir_Estados, Me.MdiParent, Me.SqlConnection1.ConnectionString)
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

            Case 3 : Editar()

            Case 4 : If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Delete Then eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 7 : Me.Close()

        End Select
    End Sub
End Class
