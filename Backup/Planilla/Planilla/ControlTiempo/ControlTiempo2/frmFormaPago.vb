Imports Utilidades

Public Class frmFormaPago
    Inherits System.Windows.Forms.Form
    'Inherits FrmPlantilla

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

    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtComprobante As System.Windows.Forms.TextBox
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnAplicarTodo As System.Windows.Forms.Button
    Friend WithEvents dtsFormaPago As Planilla.DatasetFormaPago
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFormaPago))
        Me.griDetalle = New DevExpress.XtraGrid.GridControl
        Me.dtsFormaPago = New Planilla.DatasetFormaPago
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
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
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.cmbCuentaBancaria = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.btnCambiar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtComprobante = New System.Windows.Forms.TextBox
        Me.btnAplicarTodo = New System.Windows.Forms.Button
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'griDetalle
        '
        Me.griDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.griDetalle.DataSource = Me.dtsFormaPago.FormaPago
        '
        'griDetalle.EmbeddedNavigator
        '
        Me.griDetalle.EmbeddedNavigator.Name = ""
        Me.griDetalle.Location = New System.Drawing.Point(0, 64)
        Me.griDetalle.MainView = Me.GridView1
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.griDetalle.Size = New System.Drawing.Size(776, 296)
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
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cédula"
        Me.GridColumn1.FieldName = "Cedula"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 101
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
        Me.GridColumn2.Width = 237
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Salario neto"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.GridColumn3.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
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
        Me.GridColumn3.Width = 94
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
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
        Me.GridColumn4.Width = 159
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
        Me.GridColumn5.Width = 95
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
        Me.GridColumn6.Width = 76
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
        Me.GridColumn7.Width = 93
        '
        'cmbBanco
        '
        Me.cmbBanco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBanco.Location = New System.Drawing.Point(112, 16)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(264, 21)
        Me.cmbBanco.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 18)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Banco"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(384, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Cuenta bancaria"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(552, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Tipo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTipo
        '
        Me.cmbTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Items.AddRange(New Object() {"CHEQUE", "TRANSFERENCIA"})
        Me.cmbTipo.Location = New System.Drawing.Point(552, 16)
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
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarEditar, Me.ToolBarRegistrar, Me.ToolBarImprimir, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 362)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(776, 52)
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
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'cmbCuentaBancaria
        '
        Me.cmbCuentaBancaria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCuentaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCuentaBancaria.Location = New System.Drawing.Point(384, 16)
        Me.cmbCuentaBancaria.Name = "cmbCuentaBancaria"
        Me.cmbCuentaBancaria.Size = New System.Drawing.Size(160, 21)
        Me.cmbCuentaBancaria.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Nombre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(115, 0)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(261, 13)
        Me.txtNombre.TabIndex = 74
        Me.txtNombre.Text = ""
        '
        'btnCambiar
        '
        Me.btnCambiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCambiar.Location = New System.Drawing.Point(592, 40)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.TabIndex = 75
        Me.btnCambiar.Text = "Cambiar"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(672, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Comprobante"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtComprobante
        '
        Me.txtComprobante.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComprobante.Location = New System.Drawing.Point(672, 16)
        Me.txtComprobante.Name = "txtComprobante"
        Me.txtComprobante.Size = New System.Drawing.Size(104, 20)
        Me.txtComprobante.TabIndex = 77
        Me.txtComprobante.Text = ""
        '
        'btnAplicarTodo
        '
        Me.btnAplicarTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAplicarTodo.Location = New System.Drawing.Point(672, 40)
        Me.btnAplicarTodo.Name = "btnAplicarTodo"
        Me.btnAplicarTodo.Size = New System.Drawing.Size(104, 23)
        Me.btnAplicarTodo.TabIndex = 78
        Me.btnAplicarTodo.Text = "Aplicar a todos"
        '
        'frmFormaPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(776, 414)
        Me.Controls.Add(Me.btnAplicarTodo)
        Me.Controls.Add(Me.txtComprobante)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCambiar)
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
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim IdBanco() As Integer
    Dim IdCuentaBancaria() As Integer
    Dim IdEmpleado As String
    Dim Posicion As Integer
    Public Cedula_usuario As String
    Public IdPlanilla As Double
    Public FechaInicio, FechaFinal As String

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

        For n = 0 To Me.cmbBanco.Items.Count - 1
            If IdBanco(n) = pIdBanco Then
                Me.cmbBanco.SelectedIndex = n
                LlenarCmbCuentaBancaria(IdBanco(cmbBanco.SelectedIndex))
                Exit For
            End If
        Next
    End Sub

    Private Sub BuscarCuentaBancaria(ByVal pIdCuentaBancaria As Integer)
        Dim n As Integer

        For n = 0 To Me.cmbCuentaBancaria.Items.Count - 1
            If IdCuentaBancaria(n) = pIdCuentaBancaria Then
                Me.cmbCuentaBancaria.SelectedIndex = n
                Exit For
            End If
        Next

    End Sub

    Private Function ValidarCampos() As Boolean


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

        If Me.cmbTipo.SelectedIndex = 1 And Me.txtComprobante.Text = "" Then
            MensajeError(Me.txtComprobante, "Debe especifica el numero de la transación")
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



        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        cnnConexion.Open()

        For n = 0 To dtsFormaPago.FormaPago.Count - 1
            With dtsFormaPago.FormaPago(n)


                sql = "SELECT FormaPago FROM Planilla WHERE Id_Planilla=" & IdPlanilla
                rstReader = clsConexion.GetRecorset(cnnConexion, sql)

                If rstReader.Read() = False Then Exit Function

                If rstReader(0) Then
                    CumpleAgregar = False
                Else
                    CumpleAgregar = True
                End If
                rstReader.Close()
            End With
        Next

        cnnConexion.Close()
    End Function

    Private Sub MensajeError(ByRef pObjetoGUI As Object, ByVal pMensaje As String)
        pObjetoGUI.Focus()
        MsgBox(pMensaje, MsgBoxStyle.Information)
    End Sub

    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click

        If Posicion = -1 Then Exit Sub

        If Me.txtNombre.Text = "" Then
            MsgBox("Debe elegir un empleado de la lista")
            Exit Sub
        End If

        If ValidarCampos() = False Then Exit Sub


        With dtsFormaPago.FormaPago(Posicion)
            .Codigo_Banco = IdBanco(cmbBanco.SelectedIndex)
            .Id_CuentaBancaria = IdCuentaBancaria(Me.cmbCuentaBancaria.SelectedIndex)
            .Banco = Me.cmbBanco.SelectedItem
            .CuentaBancaria = Me.cmbCuentaBancaria.SelectedItem
            .Tipo = Me.cmbTipo.SelectedItem
            If .Tipo = "CHEQUE" Then
                .Comprobante = "Por definir" 'BuscarComprobante(.Id_CuentaBancaria)
            Else
                .Comprobante = Me.txtComprobante.Text
            End If
            .Separar = True
        End With

        LimpiarDatos()
        btnCambiar.Enabled = False
    End Sub

    Private Sub LimpiarDatos()
        Me.txtNombre.Text = ""
        IdEmpleado = ""
        Posicion = -1
        Me.txtComprobante.Text = ""

    End Sub

    Private Sub griDetalle_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griDetalle.DoubleClick

        If Me.dtsFormaPago.FormaPago.Count = 0 Then Exit Sub
        Posicion = Me.BindingContext(dtsFormaPago.FormaPago).Position()

        With dtsFormaPago.FormaPago(Posicion)
            Me.txtNombre.Text = .Nombre
            BuscarBanco(.Codigo_Banco)

            BuscarCuentaBancaria(.Id_CuentaBancaria)
            Me.cmbTipo.SelectedItem = .Tipo
            Me.txtComprobante.Text = .Comprobante
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

        sql = "SELECT  -1 as id_cheque, '' as comprobante,Id_Planilla, Nombre, Cedula, SalarioNeto,'' as cuentabancaria,'' as tipo,'' as banco,0 as codigo_banco,0 as id_cuentaBancaria, 0 as Separar,id as IdPlanillaDetalle FROM   Planilla_Detalle PD WHERE id_planilla =" & pIdPlanilla

        Me.dtsFormaPago.FormaPago.Clear()

        sqlCommand.Connection = cnnConexion
        sqlCommand.CommandText = sql
        adpAdapter.SelectCommand = sqlCommand
        adpAdapter.Fill(dtsFormaPago, "FormaPago")
        cnnConexion.Close()
        IdPlanilla = pIdPlanilla

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(Usuario.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1

            Case 4
                Registrar()
            Case 5
                Imprimir()
            Case 6
                Me.Close()
        End Select

    End Sub

    Private Sub Registrar()
        Dim sql, sql2 As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader, rstReader2 As System.Data.SqlClient.SqlDataReader
        Dim n As Integer
        Dim CuentaDestino As String
        Dim CuentaContable, CuentaContableDescripcion As String
        Dim IdCheque As Double

        If ValidarAgregar() = False Then
            MsgBox("Debe especificar la cuenta bancaria de cada uno de los empleados", MsgBoxStyle.Information)
            Exit Sub
        End If

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Bancos", "CONEXION")
        cnnConexion.Open()

        sql = "UPDATE Planilla.dbo.Planilla SET FormaPago=1 WHERE Id_Planilla = " & IdPlanilla
        clsConexion.SlqExecute(cnnConexion, sql)


        For n = 0 To dtsFormaPago.FormaPago.Count - 1
            With dtsFormaPago.FormaPago(n)

                sql = "SELECT  CuentaBancaria FROM Planilla.dbo.Empleado where Identificacion='" & .Cedula & "'"
                rstReader = clsConexion.GetRecorset(cnnConexion, sql)


                If rstReader.Read() Then
                    CuentaDestino = rstReader("CuentaBancaria")
                End If
                rstReader.Close()
                If .Tipo = "CHEQUE" And .Separar = True Then
                    .Comprobante = BuscarComprobante(.Id_CuentaBancaria)
                End If
                If .Tipo = "CHEQUE" And .Separar = False And .Comprobante = "Por definir" Then
                    .Comprobante = BuscarComprobante(.Id_CuentaBancaria)
                    AsignarComprobanteCheque(.Comprobante)
                End If

                .Id_Cheque = ObtenerIdCheque(.Comprobante, .Id_CuentaBancaria, .Tipo)

                Dim tipoMEmpleado As String
                sql = "SELECT Cod_Moneda FROM Planilla.dbo.Empleado where Identificacion='" & .Cedula & "'"
                tipoMEmpleado = clsConexion.SlqExecuteScalar(cnnConexion, sql)

                Dim tipoMCheque As Integer
                sql = "Select cod_moneda from cuentas_bancarias where Id_CuentaBancaria = '" & .Id_CuentaBancaria & "'"
                tipoMCheque = clsConexion.SlqExecuteScalar(cnnConexion, sql)

                Dim valmoneda As Double = 1
                'Vale solo si codigo de moneda colon es igual a 1
                If tipoMEmpleado <> tipoMCheque Then
                    If tipoMEmpleado = 1 Then
                        sql = "Select valorCompra from moneda where codMoneda = " & tipoMCheque
                        valmoneda = 1 / CDbl(clsConexion.SlqExecuteScalar(cnnConexion, sql))

                    Else
                        sql = "Select valorCompra from moneda where codMoneda = " & tipoMEmpleado
                        valmoneda = clsConexion.SlqExecuteScalar(cnnConexion, sql)
                    End If
                End If
                'Valifica el codigo de moneda de la cuenta banco para poder identificar el valor en letras del cheque.
                Dim NombreMoneda As String
                If tipoMCheque = 1 Then
                    NombreMoneda = "COLON"
                End If
                If tipoMCheque = 2 Then
                    NombreMoneda = "DOLAR"
                End If

                Dim cambio As New cNum2Text
                Dim MontoLetras As String
                MontoLetras = cambio.Numero2Letra((.SalarioNeto * valmoneda), 0, 2, NombreMoneda, "CENTIMO", cNum2Text.eSexo.Masculino, cNum2Text.eSexo.Masculino)
                If .Id_Cheque = -1 Then
                    sql = "INSERT INTO Cheques(Num_Cheque,Id_CuentaBancaria,Fecha,Portador,Monto,Conciliado,Anulado,Observaciones,Ced_Usuario,Contabilizado,Asiento,Cuenta_Destino,Tipo,Num_Conciliacion,MontoLetras) " & _
                            "VALUES(" & .Comprobante & "," & .Id_CuentaBancaria & ",'" & Date.Now.Date & "'" & _
                            ",'" & .Nombre & "'," & .SalarioNeto * valmoneda & ",0,0,'Pago de planilla, Generado automáticamente','" & Cedula_usuario & "',1,0,'" & CuentaDestino & "','" & .Tipo & "',0,'" & MontoLetras.ToUpper & "')"
                    clsConexion.SlqExecute(cnnConexion, sql)

                    sql = "SELECT MAX(Id_Cheque) as Id_Cheque FROM Cheques WHERE Num_Cheque = " & .Comprobante & " AND Id_CuentaBancaria =" & .Id_CuentaBancaria
                    rstReader = clsConexion.GetRecorset(cnnConexion, sql)

                    If rstReader.Read() Then
                        .Id_Cheque = rstReader("Id_Cheque")
                    End If
                    rstReader.Close()

                    sql = " SELECT CB.CuentaContable, C.Descripcion  " & _
                            " FROM BANCOS.dbo.Cuentas_bancarias CB, " & _
                            "  Contabilidad.dbo.CuentaContable C " & _
                            " WHERE C.CuentaContable  COLLATE Traditional_Spanish_CI_AS = CB.CuentaContable " & _
                            " AND CB.Id_CuentaBancaria = " & .Id_CuentaBancaria
                    rstReader = clsConexion.GetRecorset(cnnConexion, sql)
                    If rstReader.Read() Then
                        CuentaContable = RTrim(rstReader("CuentaContable"))
                        CuentaContableDescripcion = RTrim(rstReader("Descripcion"))
                    End If
                    rstReader.Close()

                    sql = "INSERT INTO Cheques_Detalle(Id_Cheque,Descripcion_Mov,Cuenta_Contable,Monto,Nombre_Cuenta) " & _
                        "VALUES(" & .Id_Cheque & ",'Pago de planilla, Generación automática','" & CuentaContable & "'," & .SalarioNeto * valmoneda & ",'" & CuentaContableDescripcion & "')"
                    clsConexion.SlqExecute(cnnConexion, sql)
                Else
                    '--------------------------------------------------------------------------
                    'CALCULA EL MONTO EN LETRAS TOTAL PARA EL CHEQUE - ORA
                    Dim Montototal As Double
                    sql = "Select Monto from Cheques where Id_Cheque = " & .Id_Cheque
                    Montototal = clsConexion.SlqExecuteScalar(cnnConexion, sql)
                    MontoLetras = cambio.Numero2Letra(Montototal + (.SalarioNeto * valmoneda), 0, 2, NombreMoneda, "CENTIMO", cNum2Text.eSexo.Masculino, cNum2Text.eSexo.Masculino)
                    '--------------------------------------------------------------------------
                    sql = "UPDATE Cheques SET Portador = 'Portador planilla', Monto = Monto + " & .SalarioNeto * valmoneda & ",contabilizado=1, MontoLetras = '" & MontoLetras.ToUpper & "' WHERE Id_Cheque = " & .Id_Cheque
                    clsConexion.SlqExecute(cnnConexion, sql)
                    sql = "UPDATE Cheques_Detalle SET Monto = Monto + " & .SalarioNeto * valmoneda & " WHERE Id_Cheque = " & .Id_Cheque
                    clsConexion.SlqExecute(cnnConexion, sql)
                End If
                'Diego
                sql = " SELECT CB.CuentaContable, C.Descripcion  " & _
                            " FROM BANCOS.dbo.Cuentas_bancarias CB, " & _
                            "  Contabilidad.dbo.CuentaContable C " & _
                            " WHERE C.CuentaContable  COLLATE Traditional_Spanish_CI_AS = CB.CuentaContable " & _
                            " AND CB.Id_CuentaBancaria = " & .Id_CuentaBancaria
                rstReader = clsConexion.GetRecorset(cnnConexion, sql)
                If rstReader.Read() Then
                    CuentaContable = RTrim(rstReader("CuentaContable"))
                    CuentaContableDescripcion = RTrim(rstReader("Descripcion"))
                End If
                rstReader.Close()


                'Diego
                sql = "INSERT INTO Planilla.dbo.FormaPago (IdPlanillaDetalle,Monto,CuentaBancaria,CuentaContable) VALUES(" & .IdPlanillaDetalle & "," & .SalarioNeto & "," & .Id_CuentaBancaria & ",'" & CuentaContable & "')"
                clsConexion.SlqExecute(cnnConexion, sql)
            End With

        Next
        MsgBox("La forma de pago fue registrado satisfactoriamente", MsgBoxStyle.Information)
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarImprimir.Enabled = True
        cnnConexion.Close()
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged
        If Me.cmbTipo.SelectedIndex = 0 Then
            Me.txtComprobante.Enabled = False
            Me.txtComprobante.Text = ""
        Else
            Me.txtComprobante.Enabled = True
            Me.txtComprobante.Text = ""
        End If

    End Sub

    Private Function BuscarComprobante(ByVal pIdCuentaBancaria As Double) As Double
        BuscarComprobante = -1

        'If Me.cmbCuentaBancaria.SelectedIndex = -1 Then Exit Function
        ' If Me.cmbTipo.SelectedIndex <> 0 Then Exit Function

        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Bancos", "CONEXION")
        cnnConexion.Open()

        sql = " SELECT     MAX(Num_Cheque) AS Num_Cheque " & _
" FROM         Cheques " & _
" WHERE   Tipo = 'CHEQUE' AND Id_CuentaBancaria = " & pIdCuentaBancaria


        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() Then
            If rstReader.IsDBNull(0) = False Then
                BuscarComprobante = rstReader("Num_Cheque") + 1
            Else
                BuscarComprobante = 1
            End If

        End If
        rstReader.Close()
    End Function

    Private Sub Imprimir()
        Dim IdCheque As String
        Dim n As Integer

        For n = 0 To Me.dtsFormaPago.FormaPago.Count - 1
            With Me.dtsFormaPago.FormaPago(n)
                If n <> 0 Then
                    IdCheque = IdCheque & ","
                End If
                IdCheque = IdCheque & .Id_Cheque
            End With

        Next

        Try
            Dim rptFormaPago As New rptFormaPago
            Dim visor As New frmVisorReportes
            rptFormaPago.SetParameterValue(0, FechaInicio)
            rptFormaPago.SetParameterValue(1, FechaFinal)
            rptFormaPago.RecordSelectionFormula = "{Cheques.Id_Cheque} IN [" & IdCheque & "]"
            Utilidades.CrystalReportsConexion.LoadShow(rptFormaPago, Me.MdiParent, GetSetting("SeeSoft", "Bancos", "CONEXION"))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Sub

    Private Sub btnAplicarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarTodo.Click

        If ValidarCampos() = False Then Exit Sub
        Dim n As Integer
        For n = 0 To dtsFormaPago.FormaPago.Count - 1

            With dtsFormaPago.FormaPago(n)
                .Codigo_Banco = IdBanco(cmbBanco.SelectedIndex)
                .Id_CuentaBancaria = IdCuentaBancaria(Me.cmbCuentaBancaria.SelectedIndex)
                .Banco = Me.cmbBanco.SelectedItem
                .CuentaBancaria = Me.cmbCuentaBancaria.SelectedItem
                .Tipo = Me.cmbTipo.SelectedItem
                If .Tipo = "CHEQUE" Then
                    .Comprobante = "Por definir" 'BuscarComprobante(.Id_CuentaBancaria)

                Else
                    .Comprobante = Me.txtComprobante.Text
                End If
                .Separar = False
            End With
        Next
        LimpiarDatos()
        btnCambiar.Enabled = False
    End Sub

    Private Function ObtenerIdCheque(ByVal pComprobante As Double, ByVal pIdCuentaBancaria As Integer, ByVal pTipo As String) As Double
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader

        cnnConexion.ConnectionString = GetSetting("SeeSoft", "Bancos", "CONEXION")
        cnnConexion.Open()

        sql = "SELECT Id_Cheque FROM Cheques WHERE Num_Cheque = " & pComprobante & " AND Id_CuentaBancaria=" & pIdCuentaBancaria & " AND Tipo = '" & pTipo & "'"
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read = False Then
            ObtenerIdCheque = -1
            Exit Function
        End If

        ObtenerIdCheque = rstReader(0)
        cnnConexion.Close()
    End Function

    Private Sub AsignarComprobanteCheque(ByVal pComprobante As String)
        Dim n As Integer

        For n = 0 To Me.dtsFormaPago.FormaPago.Count - 1
            With dtsFormaPago.FormaPago(n)
                If .Separar = False And .Tipo = "CHEQUE" Then
                    .Comprobante = pComprobante
                End If
            End With
        Next
    End Sub

End Class
