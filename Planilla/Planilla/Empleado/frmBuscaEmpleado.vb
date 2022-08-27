Imports System.Data.SqlClient

Public Class frmBuscaEmpleado
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
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents dg As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents RB_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Planilla As System.Windows.Forms.RadioButton
    Friend WithEvents RB_ServProf As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        Me.dg = New System.Windows.Forms.DataGrid
        Me.cmbEstado = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RB_Todos = New System.Windows.Forms.RadioButton
        Me.RB_Planilla = New System.Windows.Forms.RadioButton
        Me.RB_ServProf = New System.Windows.Forms.RadioButton
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(332, 332)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(28, 332)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "&Aceptar"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(20, 296)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(392, 23)
        Me.txtBusqueda.TabIndex = 8
        Me.txtBusqueda.Text = ""
        '
        'dg
        '
        Me.dg.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dg.BackgroundColor = System.Drawing.Color.LightGray
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dg.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.CaptionText = "Resultado de la Búsqueda"
        Me.dg.DataMember = ""
        Me.dg.FlatMode = True
        Me.dg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dg.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dg.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dg.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dg.LinkColor = System.Drawing.Color.Teal
        Me.dg.Location = New System.Drawing.Point(20, -4)
        Me.dg.Name = "dg"
        Me.dg.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.PreferredColumnWidth = 150
        Me.dg.ReadOnly = True
        Me.dg.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dg.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dg.Size = New System.Drawing.Size(392, 268)
        Me.dg.TabIndex = 9
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.Location = New System.Drawing.Point(56, 272)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(168, 21)
        Me.cmbEstado.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Estado:"
        '
        'RB_Todos
        '
        Me.RB_Todos.Location = New System.Drawing.Point(232, 272)
        Me.RB_Todos.Name = "RB_Todos"
        Me.RB_Todos.Size = New System.Drawing.Size(56, 24)
        Me.RB_Todos.TabIndex = 14
        Me.RB_Todos.Text = "Todos"
        '
        'RB_Planilla
        '
        Me.RB_Planilla.Location = New System.Drawing.Point(288, 272)
        Me.RB_Planilla.Name = "RB_Planilla"
        Me.RB_Planilla.Size = New System.Drawing.Size(64, 24)
        Me.RB_Planilla.TabIndex = 15
        Me.RB_Planilla.Text = "Planilla"
        '
        'RB_ServProf
        '
        Me.RB_ServProf.Location = New System.Drawing.Point(352, 272)
        Me.RB_ServProf.Name = "RB_ServProf"
        Me.RB_ServProf.Size = New System.Drawing.Size(80, 24)
        Me.RB_ServProf.TabIndex = 16
        Me.RB_ServProf.Text = "Serv. Prof."
        '
        'frmBuscaEmpleado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 358)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.RB_ServProf)
        Me.Controls.Add(Me.RB_Planilla)
        Me.Controls.Add(Me.RB_Todos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.dg)
        Me.Name = "frmBuscaEmpleado"
        Me.Text = "Buscar"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Shared NuevaConexion As String


#Region "Variables"
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
    Friend codigo As String
    Friend descrip As String
    Friend campo As String
    Friend sqlString As String
    Public sqlAdicional As String
    Dim ds As DataSet
    Dim bandera As Boolean = False
    Dim IdEstado() As Integer
#End Region

    Private Sub Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cConexion = New Conexion
        sqlConexion = New SqlConnection

        If NuevaConexion = "" Then
            sqlConexion = cConexion.Conectar
        Else
            sqlConexion.ConnectionString = NuevaConexion
            sqlConexion.Open()
        End If
        LlenarCmbEstado()
        RB_Todos.Checked = True
        cargarInformacion("")
        Me.txtBusqueda.Focus()
    End Sub

    Private Sub cargarInformacion(ByVal sWhere As String)

        If RB_Planilla.Checked = True Then
            If sWhere <> "" Then
                sWhere = sWhere & " AND ServiciosProf = 0 "
            Else
                sWhere = " where ServiciosProf = 0 "
            End If
        ElseIf RB_ServProf.Checked = True Then
            If sWhere <> "" Then
                sWhere = sWhere & " AND ServiciosProf = 1 "
            Else
                sWhere = " where ServiciosProf = 1 "
            End If
        End If

        Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter(sqlString & sWhere & " " & sqlAdicional, sqlConexion)
        Dim ds As DataSet = New DataSet
        myCommand1.Fill(ds, "Informacion")

        If bandera = False Then
            Dim tbl As New DataGridTableStyle
            tbl.MappingName = "Informacion"

            Dim Column As New DataGridTextBoxColumn

            If cFunciones.Fechaemp = 2 Then
                Column.MappingName = ds.Tables(0).Columns(0).Caption()
                Column.HeaderText = ds.Tables(0).Columns(0).Caption()
                Column.Width = 80
                Column.Alignment = HorizontalAlignment.Center
                tbl.GridColumnStyles.Add(Column)
                Column = New DataGridTextBoxColumn
                Column.MappingName = ds.Tables(0).Columns(1).Caption()
                Column.HeaderText = ds.Tables(0).Columns(1).Caption()
                Column.Width = 80
                Column.Alignment = HorizontalAlignment.Center
                tbl.GridColumnStyles.Add(Column)

                Column = New DataGridTextBoxColumn
                Column.MappingName = ds.Tables(0).Columns(2).Caption()
                Column.HeaderText = ds.Tables(0).Columns(2).Caption()
                Column.Width = 300
                Column.Alignment = HorizontalAlignment.Center
                tbl.GridColumnStyles.Add(Column)
                dg.TableStyles.Add(tbl)
                tbl = Nothing
                bandera = True

            End If
            If cFunciones.Fechaemp = 1 Then
                Column.MappingName = ds.Tables(0).Columns(2).Caption()
                Column.HeaderText = ds.Tables(0).Columns(2).Caption()
                Column.Width = 80
                Column.Alignment = HorizontalAlignment.Center
                tbl.GridColumnStyles.Add(Column)

                Column = New DataGridTextBoxColumn
                Column.MappingName = ds.Tables(0).Columns(3).Caption()
                Column.HeaderText = ds.Tables(0).Columns(3).Caption()
                Column.Width = 300
                Column.Alignment = HorizontalAlignment.Center
                tbl.GridColumnStyles.Add(Column)
                dg.TableStyles.Add(tbl)
                tbl = Nothing
                bandera = True
            ElseIf cFunciones.Fechaemp <> 2 Then

                Column.MappingName = ds.Tables(0).Columns(0).Caption()
                Column.HeaderText = ds.Tables(0).Columns(0).Caption()
                Column.Width = 80
                Column.Alignment = HorizontalAlignment.Center
                tbl.GridColumnStyles.Add(Column)

                Column = New DataGridTextBoxColumn
                Column.MappingName = ds.Tables(0).Columns(1).Caption()
                Column.HeaderText = ds.Tables(0).Columns(1).Caption()
                Column.Width = 300
                tbl.GridColumnStyles.Add(Column)
                dg.TableStyles.Add(tbl)
                tbl = Nothing
                bandera = True

            End If
        End If

        dg.DataSource = ds.Tables(0)
        ds = Nothing
        dg.AllowSorting = True
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click, dg.DoubleClick
        If dg.VisibleRowCount > 0 Then
            If cFunciones.Fechaemp = 2 Then
                codigo = CStr(dg(dg.CurrentRowIndex, 0))
                descrip = CStr(dg(dg.CurrentRowIndex, 1))
            End If
            If cFunciones.Fechaemp = 1 Then
                codigo = CStr(dg(dg.CurrentRowIndex, 0))
                descrip = CStr(dg(dg.CurrentRowIndex, 1))
            Else
                codigo = CStr(dg(dg.CurrentRowIndex, 0))
                descrip = CStr(dg(dg.CurrentRowIndex, 1))
            End If
        End If
        Me.Dispose(True)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        '-----------------------
        codigo = 0
        Me.Dispose(True)
        Me.Close()
        '-----------------
    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        CambiaEstado()
    End Sub

    Private Sub Buscar_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        cConexion.DesConectar(sqlConexion)
        sqlConexion = Nothing
        cConexion = Nothing
    End Sub

    Private Sub LlenarCmbEstado()
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim n As Integer
        Dim sql As String

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()

        sql = " SELECT Codigo,Descripcion FROM Estado_Empleado Order by Descripcion"
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        n = 0
        Do While rstReader.Read

            cmbEstado.Items.Add(rstReader("Descripcion"))
            ReDim Preserve IdEstado(n + 1)
            IdEstado(n) = rstReader("Codigo")
            n = n + 1
        Loop
        rstReader.Close()
        cnnConexion.Close()
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedIndexChanged
        CambiaEstado()
    End Sub

    Private Sub RB_Planilla_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_Planilla.CheckedChanged, RB_ServProf.CheckedChanged, RB_Todos.CheckedChanged
        CambiaEstado()
    End Sub

    Public Sub CambiaEstado()
        Dim Estado As String
        If sqlString.IndexOf("where") > 0 Then
            If Me.cmbEstado.SelectedIndex <> -1 Then
                Estado = " and Cod_estado = " & IdEstado(Me.cmbEstado.SelectedIndex)
            End If
            cargarInformacion(Estado & " and " & campo & " like '%" & txtBusqueda.Text & "%'")
        Else
            If Me.cmbEstado.SelectedIndex <> -1 Then
                Estado = " Cod_estado = " & IdEstado(Me.cmbEstado.SelectedIndex) & " AND "
            End If

            cargarInformacion(" where " & Estado & campo & " like '%" & txtBusqueda.Text & "%'")
        End If
    End Sub
End Class
