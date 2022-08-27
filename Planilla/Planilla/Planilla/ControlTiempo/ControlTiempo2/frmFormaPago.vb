Imports Utilidades
Public Class frmFormaPago
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Protected Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEditar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCuentaBancaria As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnCambiar As System.Windows.Forms.Button
    Friend WithEvents griDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents dtsFormaPago As Planilla.DatasetFormaPago
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFormaPago))
        Me.griDetalle = New DevExpress.XtraGrid.GridControl
        Me.dtsFormaPago = New Planilla.DatasetFormaPago
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbBanco = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEditar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.cmbCuentaBancaria = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.btnCambiar = New System.Windows.Forms.Button
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'griDetalle
        '
        Me.griDetalle.DataSource = Me.dtsFormaPago.FormaPago
        '
        'griDetalle.EmbeddedNavigator
        '
        Me.griDetalle.EmbeddedNavigator.Name = ""
        Me.griDetalle.Location = New System.Drawing.Point(16, 128)
        Me.griDetalle.MainView = Me.GridView1
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(592, 184)
        Me.griDetalle.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.griDetalle.TabIndex = 0
        Me.griDetalle.Text = "GridControl1"
        '
        'dtsFormaPago
        '
        Me.dtsFormaPago.DataSetName = "DatasetFormaPago"
        Me.dtsFormaPago.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cédula"
        Me.GridColumn1.FieldName = "Cedula"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Salario neto"
        Me.GridColumn3.FieldName = "SalarioNeto"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Banco"
        Me.GridColumn4.FieldName = "Banco"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Cuenta bancaria"
        Me.GridColumn5.FieldName = "CuentaBancaria"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tipo"
        Me.GridColumn6.FieldName = "Tipo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Comprobante"
        Me.GridColumn7.FieldName = "Comprobante"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn7.VisibleIndex = 6
        '
        'cmbBanco
        '
        Me.cmbBanco.Location = New System.Drawing.Point(32, 56)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(152, 21)
        Me.cmbBanco.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(32, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Banco:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(192, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Cuenta bancaria"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(440, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTipo
        '
        Me.cmbTipo.Items.AddRange(New Object() {"CHEQUE", "TRANSFERENCIA"})
        Me.cmbTipo.Location = New System.Drawing.Point(440, 56)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(120, 21)
        Me.cmbTipo.TabIndex = 67
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarEditar, Me.ToolBarRegistrar, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 322)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(624, 52)
        Me.ToolBar1.TabIndex = 71
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarEditar
        '
        Me.ToolBarEditar.ImageIndex = 9
        Me.ToolBarEditar.Text = "Editar"
        Me.ToolBarEditar.Visible = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'cmbCuentaBancaria
        '
        Me.cmbCuentaBancaria.Location = New System.Drawing.Point(192, 56)
        Me.cmbCuentaBancaria.Name = "cmbCuentaBancaria"
        Me.cmbCuentaBancaria.Size = New System.Drawing.Size(240, 21)
        Me.cmbCuentaBancaria.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(40, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Nombre:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(192, 8)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(224, 20)
        Me.txtNombre.TabIndex = 74
        Me.txtNombre.Text = ""
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(280, 88)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.TabIndex = 75
        Me.btnCambiar.Text = "Cambiar"
        '
        'frmFormaPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 374)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCuentaBancaria)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbBanco)
        Me.Controls.Add(Me.griDetalle)
        Me.Name = "frmFormaPago"
        Me.Text = "Forma de pago"
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim IdBanco() As Integer
    Dim IdCuentaBancaria() As Integer
    Dim IdEmpleado As String
    Dim Posicion As Integer
    Public Cedula_usuario As String


    Private Sub frmFormaPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

#Region "Funciones Llenar"
    Private Sub Cargar()

        If Me.CumpleAgregar = False Then
            MsgBox("La forma de pago ya fue establecida, por lo tanto no se puede modificar", MsgBoxStyle.Information)
            Me.Close()
        End If
        LimpiarDatos()
        LlenarCmbBanco()
        btnCambiar.Enabled = False
    End Sub

    Private Sub LlenarCmbBanco()
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Bancos", "CONEXION")
        cnnConexion.Open()
        sql = "SELECT Codigo_banco,Descripcion FROM Bancos ORDER BY Descripcion"
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        Dim n As Integer
        n = 0
        Do While rstReader.Read()
            Me.cmbBanco.Items.Add(rstReader("Descripcion"))
            ReDim Preserve IdBanco(n + 1)
            IdBanco(n) = rstReader("Codigo_banco")
            n = n + 1
        Loop

        rstReader.Close()
        cnnConexion.Close()
    End Sub

    Private Sub LlenarCmbCuentaBancaria(ByVal pIdBanco As Integer)
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader

        Me.cmbCuentaBancaria.Items.Clear()
        Me.cmbCuentaBancaria.Text = ""
        cmbCuentaBancaria.SelectedIndex = -1

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Bancos", "CONEXION")
        cnnConexion.Open()
        sql = "SELECT Id_CuentaBancaria,Cuenta FROM Cuentas_bancarias WHERE Codigo_banco = " & pIdBanco & " ORDER BY Cuenta"
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        Dim n As Integer
        n = 0
        Do While rstReader.Read()
            Me.cmbCuentaBancaria.Items.Add(rstReader("Cuenta"))
            ReDim Preserve IdCuentaBancaria(n + 1)
            IdCuentaBancaria(n) = rstReader("Id_CuentaBancaria")
            n = n + 1
        Loop

        rstReader.Close()
        cnnConexion.Close()
    End Sub

#End Region

    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If Me.cmbBanco.Left = -1 Then Exit Sub
        LlenarCmbCuentaBancaria(IdBanco(cmbBanco.SelectedIndex))
    End Sub

    Private Sub BuscarBanco(ByVal pIdBanco As Integer)
        Dim n As Integer

        For n = 0 To Me.cmbBanco.SelectedIndex - 1
            If IdBanco(n) = pIdBanco Then
                Me.cmbBanco.SelectedIndex = n
                Exit For
            End If
        Next
    End Sub

    Private Sub BuscarCuentaBancaria(ByVal pIdCuentaBancaria As Integer)
        Dim n As Integer

        For n = 0 To Me.cmbCuentaBancaria.SelectedIndex - 1
            If IdCuentaBancaria(n) = pIdCuentaBancaria Then
                Me.cmbCuentaBancaria.SelectedIndex = n
                Exit For
            End If
        Next

    End Sub

    Private Function ValidarCampos() As Boolean

        If Me.txtNombre.Text = "" Then
            MsgBox("Debe elegir un empleado de la lista")
            Exit Function
        End If
        If Me.cmbBanco.SelectedIndex = -1 Then
            MensajeError(cmbBanco, "Debe elegir el banco")
            Exit Function
        End If

        If Me.cmbCuentaBancaria.SelectedIndex = -1 Then
            MensajeError(cmbCuentaBancaria, "Debe elegir la cuenta bancaria")
            Exit Function
        End If

        If Me.cmbTipo.SelectedIndex = -1 Then
            MensajeError(cmbTipo, "Debe elegir el tipo de transferencia")
            Exit Function
        End If

        ValidarCampos = True
    End Function

    Private Function ValidarAgregar() As Boolean
        Dim n As Integer
        For n = 0 To dtsFormaPago.FormaPago.Count - 1
            With dtsFormaPago.FormaPago(n)

                If .Banco = "" Then
                    Exit Function
                End If

                If .CuentaBancaria = "" Then
                    Exit Function
                End If

                If .Tipo = "" Then
                    Exit Function
                End If

            End With
        Next
        ValidarAgregar = True
    End Function

    Private Function CumpleAgregar() As Boolean
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim n As Integer
  


        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Bancos", "CONEXION")
        cnnConexion.Open()

        For n = 0 To dtsFormaPago.FormaPago.Count - 1
            With dtsFormaPago.FormaPago(n)
        

                sql = "SELECT count(Id_Cheque) FROM Cheques WHERE Num_Cheque = " & .Comprobante
                rstReader = clsConexion.GetRecorset(cnnConexion, sql)

                If rstReader.Read() = False Then Exit Function

                If rstReader(0) <> 0 Then
                    Exit Function
                End If
                rstReader.Close()
            End With
        Next

        CumpleAgregar = True
        cnnConexion.Close()
    End Function

    Private Sub MensajeError(ByRef pObjetoGUI As Object, ByVal pMensaje As String)
        pObjetoGUI.Focus()
        MsgBox(pMensaje, MsgBoxStyle.Information)
    End Sub

    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click

        If Posicion = -1 Then Exit Sub

        If ValidarCampos() = False Then Exit Sub


        With dtsFormaPago.FormaPago(Posicion)
            .Codigo_Banco = IdBanco(cmbBanco.SelectedIndex)
            .Id_CuentaBancaria = IdCuentaBancaria(Me.cmbCuentaBancaria.SelectedIndex)
            .Banco = Me.cmbBanco.SelectedItem
            .CuentaBancaria = Me.cmbCuentaBancaria.SelectedItem
            .Tipo = Me.cmbTipo.SelectedItem
        End With

        LimpiarDatos()
        btnCambiar.Enabled = False
    End Sub

    Private Sub LimpiarDatos()
        Me.txtNombre.Text = ""
        IdEmpleado = ""
        Posicion = -1

    End Sub

    Private Sub griDetalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griDetalle.DoubleClick

        If Me.dtsFormaPago.FormaPago.Count = 0 Then Exit Sub
        Posicion = Me.BindingContext(dtsFormaPago.FormaPago).Position()

        With dtsFormaPago.FormaPago(Posicion)
            Me.txtNombre.Text = .Nombre
            BuscarBanco(.Codigo_Banco)
            BuscarCuentaBancaria(.Id_CuentaBancaria)
            Me.cmbTipo.SelectedItem = .Tipo
            IdEmpleado = .Cedula
        End With
        Me.btnCambiar.Enabled = True

    End Sub

    Public Sub LlenarGridDetalle(ByVal pIdPlanilla As Double)
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim adpAdapter As New SqlClient.SqlDataAdapter
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand
        Dim sql As String

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()

        sql = "SELECT  id as comprobante,Id_Planilla, Nombre, Cedula, SalarioNeto,'' as cuentabancaria,'' as tipo,'' as banco,0 as codigo_banco,0 as id_cuentaBancaria FROM   Planilla_Detalle PD WHERE id_planilla =" & pIdPlanilla

        Me.dtsFormaPago.FormaPago.Clear()

        sqlCommand.Connection = cnnConexion
        sqlCommand.CommandText = sql
        adpAdapter.SelectCommand = sqlCommand
        adpAdapter.Fill(dtsFormaPago, "FormaPago")
        cnnConexion.Close()


    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(Usuario.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1


            Case 4

                Registrar()



            Case 5
                Me.Close()

        End Select

    End Sub

    Private Sub Registrar()
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim n As Integer
        Dim CuentaDestino As String
        Dim CuentaContable, CuentaContableDescripcion As String
        Dim IdCheque As Double

        If ValidarAgregar() = False Then
            MsgBox("Debe especica la cuenta bancaria de cada uno de los empleados", MsgBoxStyle.Information)
            Exit Sub
        End If

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Bancos", "CONEXION")
        cnnConexion.Open()

        For n = 0 To dtsFormaPago.FormaPago.Count - 1
            With dtsFormaPago.FormaPago(n)
                sql = "SELECT  CuentaBancaria FROM Planilla.dbo.Empleado where Identificacion='" & .Cedula & "'"
                rstReader = clsConexion.GetRecorset(cnnConexion, sql)

                If rstReader.Read() Then
                    CuentaDestino = rstReader("CuentaBancaria")
                End If
                rstReader.Close()


                sql = "INSERT INTO Cheques(Num_Cheque,Id_CuentaBancaria,Fecha,Portador,Monto,Conciliado,Anulado,Observaciones,Ced_Usuario,Contabilizado,Asiento,Cuenta_Destino,Tipo,Num_Conciliacion,MontoLetras) " & _
                        "VALUES(" & .Comprobante & "," & .Id_CuentaBancaria & ",'" & Date.Now.Date & "'" & _
                        ",'" & .Nombre & "'," & .SalarioNeto & ",0,0,'Pago de planilla, Generado automáticamente'," & Cedula_usuario & ",0,0,'" & CuentaDestino & "','" & .Tipo & "',0,'')"
                clsConexion.SlqExecute(cnnConexion, sql)


                sql = "SELECT MAX(Id_Cheque) as Id_Cheque FROM Cheques WHERE Num_Cheque = " & .Comprobante & " AND Id_CuentaBancaria =" & .Id_CuentaBancaria
                rstReader = clsConexion.GetRecorset(cnnConexion, sql)

                If rstReader.Read() Then
                    IdCheque = rstReader("Id_Cheque")
                End If
                rstReader.Close()

                sql = " SELECT CB.CuentaContable, C.Descripcion  " & _
                        " FROM BANCOS.dbo.Cuentas_bancarias CB, " & _
                        "  Contabilidad.dbo.CuentaContable C " & _
                        " WHERE C.CuentaContable  COLLATE Traditional_Spanish_CI_AS = CB.CuentaContable " & _
                        " AND CB.Id_CuentaBancaria = " & .Id_CuentaBancaria
                rstReader = clsConexion.GetRecorset(cnnConexion, sql)
                If rstReader.Read() Then
                    CuentaContable = rstReader("CuentaContable")
                    CuentaContableDescripcion = rstReader("Descripcion")
                End If
                rstReader.Close()


                sql = "INSERT INTO Cheques_Detalle(Id_Cheque,Descripcion_Mov,Cuenta_Contable,Monto,Nombre_Cuenta) " & _
                    "VALUES(" & IdCheque & ",'Pago de planilla, Generación automática','" & CuentaContable & "'," & .SalarioNeto & ",'" & CuentaContableDescripcion & "')"
                clsConexion.SlqExecute(cnnConexion, sql)
            End With
        Next
        MsgBox("La forma de pago fue registrado satisfactoriamente", MsgBoxStyle.Information)
        cnnConexion.Close()
    End Sub
End Class
