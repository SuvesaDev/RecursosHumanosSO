Public Class FrmBuscarArticulo
    Inherits System.Windows.Forms.Form
    '    Dim DV As DataView
    Public Codigo As String
    Public Cancelado As Boolean
    Dim CadenaWhere As String
    Public NuevaConexion As String
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
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetCatalogoInventario As DataSetCatalogoInventario
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colMarca As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExistencia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioFinal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUbicacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TxtCodigo As ValidText.ValidText
    Friend WithEvents ButtonAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Filtro_Inicio_del_Campo As System.Windows.Forms.RadioButton
    Friend WithEvents Filtro_Cualquier_Parte_del_Campo As System.Windows.Forms.RadioButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Public WithEvents CheckBoxInHabilitados As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DataSetCatalogoInventario = New DataSetCatalogoInventario
        Me.GridControl = New DevExpress.XtraGrid.GridControl
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colMarca = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colExistencia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPrecioFinal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colUbicacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Filtro_Inicio_del_Campo = New System.Windows.Forms.RadioButton
        Me.Filtro_Cualquier_Parte_del_Campo = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.ButtonAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.ButtonCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.TxtCodigo = New ValidText.ValidText
        Me.CheckBoxInHabilitados = New System.Windows.Forms.CheckBox
        CType(Me.DataSetCatalogoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=HAZEL;packet size=4096;integrated security=SSPI;data source=DELSER" & _
        "VER;persist security info=False;initial catalog=SeePos"
        '
        'SqlDataAdapter
        '
        Me.SqlDataAdapter.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CatalogoInventario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Barras", "Barras"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Marca", "Marca"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("Precio_A", "Precio_A"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("PrecioFinal", "PrecioFinal"), New System.Data.Common.DataColumnMapping("Existencia", "Existencia"), New System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"), New System.Data.Common.DataColumnMapping("Inhabilitado", "Inhabilitado")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Barras, Descripcion, Marca, Simbolo, Precio_A, ValorCompra, Precio" & _
        "Final, Existencia, Ubicacion, Inhabilitado FROM CatalogoInventario"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'DataSetCatalogoInventario
        '
        Me.DataSetCatalogoInventario.DataSetName = "DataSetCatalogoInventario"
        Me.DataSetCatalogoInventario.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'GridControl
        '
        '
        'GridControl.EmbeddedNavigator
        '
        Me.GridControl.EmbeddedNavigator.Name = ""
        Me.GridControl.Location = New System.Drawing.Point(8, 8)
        Me.GridControl.MainView = Me.AdvBandedGridView1
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(752, 312)
        Me.GridControl.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl.TabIndex = 1
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCodigo, Me.colDescripcion, Me.colMarca, Me.colExistencia, Me.colPrecioFinal, Me.colUbicacion})
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsView.ShowGroupPanel = False
        '
        'GridBand2
        '
        Me.GridBand2.Columns.Add(Me.colCodigo)
        Me.GridBand2.Columns.Add(Me.colDescripcion)
        Me.GridBand2.Columns.Add(Me.colMarca)
        Me.GridBand2.Columns.Add(Me.colExistencia)
        Me.GridBand2.Columns.Add(Me.colPrecioFinal)
        Me.GridBand2.Columns.Add(Me.colUbicacion)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 506
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.Visible = True
        Me.colCodigo.Width = 42
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.Visible = True
        Me.colDescripcion.Width = 213
        '
        'colMarca
        '
        Me.colMarca.Caption = "Barras"
        Me.colMarca.FieldName = "Barras"
        Me.colMarca.Name = "colMarca"
        Me.colMarca.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMarca.Visible = True
        Me.colMarca.Width = 86
        '
        'colExistencia
        '
        Me.colExistencia.Caption = "Existencia"
        Me.colExistencia.FieldName = "Existencia"
        Me.colExistencia.Name = "colExistencia"
        Me.colExistencia.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colExistencia.Visible = True
        Me.colExistencia.Width = 33
        '
        'colPrecioFinal
        '
        Me.colPrecioFinal.Caption = "Precio Final"
        Me.colPrecioFinal.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecioFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecioFinal.FieldName = "PrecioFinal"
        Me.colPrecioFinal.Name = "colPrecioFinal"
        Me.colPrecioFinal.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecioFinal.Visible = True
        Me.colPrecioFinal.Width = 57
        '
        'colUbicacion
        '
        Me.colUbicacion.Caption = "Ubicación"
        Me.colUbicacion.FieldName = "Ubicacion"
        Me.colUbicacion.Name = "colUbicacion"
        Me.colUbicacion.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colUbicacion.Visible = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxBuscar.Location = New System.Drawing.Point(10, 326)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(750, 13)
        Me.TextBoxBuscar.TabIndex = 0
        Me.TextBoxBuscar.Text = ""
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.White
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton1.Location = New System.Drawing.Point(136, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 16)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Descripción"
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.White
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton2.Location = New System.Drawing.Point(232, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "Ubicación"
        '
        'RadioButton3
        '
        Me.RadioButton3.BackColor = System.Drawing.Color.White
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton3.Location = New System.Drawing.Point(320, 0)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(78, 16)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.Text = "Código II"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busqueda en -->"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Location = New System.Drawing.Point(10, 341)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 16)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Filtro_Inicio_del_Campo)
        Me.Panel2.Controls.Add(Me.Filtro_Cualquier_Parte_del_Campo)
        Me.Panel2.Location = New System.Drawing.Point(9, 360)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 16)
        Me.Panel2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Coincidir  -->"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Filtro_Inicio_del_Campo
        '
        Me.Filtro_Inicio_del_Campo.BackColor = System.Drawing.Color.White
        Me.Filtro_Inicio_del_Campo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filtro_Inicio_del_Campo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Filtro_Inicio_del_Campo.Location = New System.Drawing.Point(140, 2)
        Me.Filtro_Inicio_del_Campo.Name = "Filtro_Inicio_del_Campo"
        Me.Filtro_Inicio_del_Campo.Size = New System.Drawing.Size(116, 13)
        Me.Filtro_Inicio_del_Campo.TabIndex = 0
        Me.Filtro_Inicio_del_Campo.Text = "Inicio del Campo"
        '
        'Filtro_Cualquier_Parte_del_Campo
        '
        Me.Filtro_Cualquier_Parte_del_Campo.BackColor = System.Drawing.Color.White
        Me.Filtro_Cualquier_Parte_del_Campo.Checked = True
        Me.Filtro_Cualquier_Parte_del_Campo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filtro_Cualquier_Parte_del_Campo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Filtro_Cualquier_Parte_del_Campo.Location = New System.Drawing.Point(285, 0)
        Me.Filtro_Cualquier_Parte_del_Campo.Name = "Filtro_Cualquier_Parte_del_Campo"
        Me.Filtro_Cualquier_Parte_del_Campo.Size = New System.Drawing.Size(112, 16)
        Me.Filtro_Cualquier_Parte_del_Campo.TabIndex = 1
        Me.Filtro_Cualquier_Parte_del_Campo.TabStop = True
        Me.Filtro_Cualquier_Parte_del_Campo.Text = "Cualquier Parte"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(456, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Cód. Seleccionado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(613, 344)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(64, 28)
        Me.ButtonAceptar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.ButtonAceptar.TabIndex = 4
        Me.ButtonAceptar.Text = "Aceptar"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelar.Location = New System.Drawing.Point(693, 344)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(64, 28)
        Me.ButtonCancelar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.ButtonCancelar.TabIndex = 5
        Me.ButtonCancelar.Text = "Cancelar"
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 575
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigo.FieldReference = Nothing
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodigo.Location = New System.Drawing.Point(456, 360)
        Me.TxtCodigo.MaskEdit = ""
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtCodigo.Required = False
        Me.TxtCodigo.ShowErrorIcon = False
        Me.TxtCodigo.Size = New System.Drawing.Size(128, 13)
        Me.TxtCodigo.TabIndex = 3
        Me.TxtCodigo.Text = "0.00"
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCodigo.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtCodigo.ValidText = "#0"
        '
        'CheckBoxInHabilitados
        '
        Me.CheckBoxInHabilitados.Enabled = False
        Me.CheckBoxInHabilitados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxInHabilitados.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CheckBoxInHabilitados.Location = New System.Drawing.Point(620, 10)
        Me.CheckBoxInHabilitados.Name = "CheckBoxInHabilitados"
        Me.CheckBoxInHabilitados.Size = New System.Drawing.Size(136, 14)
        Me.CheckBoxInHabilitados.TabIndex = 78
        Me.CheckBoxInHabilitados.Text = "Mostrar Inhabilitados"
        '
        'FrmBuscarArticulo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.ButtonCancelar
        Me.ClientSize = New System.Drawing.Size(768, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckBoxInHabilitados)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmBuscarArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Artículo"
        CType(Me.DataSetCatalogoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmBuscarArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim A As String()
        'Me.SqlDataAdapter.Fill(Me.DataSetCatalogoInventario, "CatalogoInventario")
        Me.SqlConnection.ConnectionString = IIf(NuevaConexion = "", GetSetting("SeeSOFT", "SeePos", "Conexion"), NuevaConexion)

        Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView.AllowDelete = False
        Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView.AllowEdit = False
        Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView.AllowNew = False
        Me.GridControl.DataSource = Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView

        Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView, "Codigo"))

        If Me.BindingContext(Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView).Count Then
            Me.BindingContext(Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView).Position = 0
        End If
        '        AddHandler Me.BindingContext(Me.DV).PositionChanged, AddressOf Me.Position_Changed
    End Sub

    Private Sub TextBoxBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxBuscar.TextChanged
        If TextBoxBuscar.Text.Length > 2 Then
            'Me.SqlConnection.ConnectionString = GetSetting("SeeSOFT", "SeePos", "Conexion")
            If Me.RadioButton1.Checked = True Then
                BuscarDatos(Me.TextBoxBuscar.Text, "Descripcion")
            ElseIf Me.RadioButton2.Checked = True Then
                BuscarDatos(Me.TextBoxBuscar.Text, "Ubicacion")
            Else
                BuscarDatos(Me.TextBoxBuscar.Text, "Barras")
            End If
        End If
    End Sub
    Private Sub BuscarDatos(ByVal Descripcion As String, ByVal CampoFiltro As String)
        If Me.Filtro_Inicio_del_Campo.Checked = True Then
            CadenaWhere = " WHERE " & CampoFiltro & " lIKE '" & Descripcion & "%'" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " and Inhabilitado = 0")
        ElseIf Me.Filtro_Cualquier_Parte_del_Campo.Checked = True Then
            CadenaWhere = " WHERE " & CampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " and Inhabilitado = 0")
        Else
            CadenaWhere = "" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " Inhabilitado = 0")
        End If
        Try
            Me.DataSetCatalogoInventario.Clear()
            Me.SqlDataAdapter.SelectCommand.CommandText = "SELECT Codigo, Barras, Descripcion, Marca, Simbolo, Precio_A, ValorCompra, PrecioFinal, Existencia, Ubicacion, Inhabilitado FROM CatalogoInventario" & CadenaWhere
            Me.SqlDataAdapter.Fill(Me.DataSetCatalogoInventario, "CatalogoInventario")
            Me.GridControl.DataSource = Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub TextBoxBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxBuscar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            GridControl.Focus()
        End If
    End Sub
    Private Sub GridControl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridControl.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SeleccionarCodigo()
            Me.ButtonAceptar.Focus()
        End If
    End Sub
    Sub SeleccionarCodigo()
        Dim hi As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = AdvBandedGridView1.CalcHitInfo(CType(GridControl, Control).PointToClient(Control.MousePosition))
        If hi.RowHandle >= 0 Then 'BuscarById(AdvBandedGridView1.GetDataRow(hi.RowHandle))
            TxtCodigo.Text = AdvBandedGridView1.GetDataRow(AdvBandedGridView1.FocusedRowHandle).ItemArray(0)
        ElseIf AdvBandedGridView1.FocusedRowHandle >= 0 Then
            TxtCodigo.Text = AdvBandedGridView1.GetDataRow(AdvBandedGridView1.FocusedRowHandle).ItemArray(0)
        Else
            TxtCodigo.Text = 0
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If TextBoxBuscar.Text.Length > 2 Then BuscarDatos(Me.TextBoxBuscar.Text, "Descripcion")
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If TextBoxBuscar.Text.Length > 2 Then BuscarDatos(Me.TextBoxBuscar.Text, "Ubicacion")
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If TextBoxBuscar.Text.Length > 2 Then BuscarDatos(Me.TextBoxBuscar.Text, "Barras")
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        Cancelado = False
        Codigo = TxtCodigo.Text
        Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Cancelado = True
        Codigo = 0
        Close()
    End Sub

    Private Sub GridControl_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl.DoubleClick
        Me.ButtonAceptar.Focus()
    End Sub
    Private Sub Filtro_Inicio_del_Campo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filtro_Inicio_del_Campo.CheckedChanged, Filtro_Cualquier_Parte_del_Campo.CheckedChanged
        If RadioButton1.Checked = True Then
            If TextBoxBuscar.Text.Length > 2 Then BuscarDatos(Me.TextBoxBuscar.Text, "Descripcion")
        ElseIf RadioButton2.Checked = True Then
            If TextBoxBuscar.Text.Length > 2 Then BuscarDatos(Me.TextBoxBuscar.Text, "Ubicacion")
        ElseIf RadioButton3.Checked = True Then
            If TextBoxBuscar.Text.Length > 2 Then BuscarDatos(Me.TextBoxBuscar.Text, "Barras")
        End If
    End Sub

    Private Sub CheckBoxInHabilitados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxInHabilitados.CheckedChanged
        If TextBoxBuscar.Text.Length > 2 Then
            'Me.SqlConnection.ConnectionString = GetSetting("SeeSOFT", "SeePos", "Conexion")
            If Me.RadioButton1.Checked = True Then
                BuscarDatos(Me.TextBoxBuscar.Text, "Descripcion")
            ElseIf Me.RadioButton2.Checked = True Then
                BuscarDatos(Me.TextBoxBuscar.Text, "Ubicacion")
            Else
                BuscarDatos(Me.TextBoxBuscar.Text, "Barras")
            End If
        End If
    End Sub
End Class