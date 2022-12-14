'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2407
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class DSEstado
    Inherits DataSet
    
    Private tableEstado_Empleado As Estado_EmpleadoDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Estado_Empleado")) Is Nothing) Then
                Me.Tables.Add(New Estado_EmpleadoDataTable(ds.Tables("Estado_Empleado")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Estado_Empleado As Estado_EmpleadoDataTable
        Get
            Return Me.tableEstado_Empleado
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DSEstado = CType(MyBase.Clone,DSEstado)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Estado_Empleado")) Is Nothing) Then
            Me.Tables.Add(New Estado_EmpleadoDataTable(ds.Tables("Estado_Empleado")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableEstado_Empleado = CType(Me.Tables("Estado_Empleado"),Estado_EmpleadoDataTable)
        If (Not (Me.tableEstado_Empleado) Is Nothing) Then
            Me.tableEstado_Empleado.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DSEstado"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DSEstado.xsd"
        Me.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableEstado_Empleado = New Estado_EmpleadoDataTable
        Me.Tables.Add(Me.tableEstado_Empleado)
    End Sub
    
    Private Function ShouldSerializeEstado_Empleado() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub Estado_EmpleadoRowChangeEventHandler(ByVal sender As Object, ByVal e As Estado_EmpleadoRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Estado_EmpleadoDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCodigo As DataColumn
        
        Private columnDescripcion As DataColumn
        
        Private columnSalida As DataColumn
        
        Friend Sub New()
            MyBase.New("Estado_Empleado")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property CodigoColumn As DataColumn
            Get
                Return Me.columnCodigo
            End Get
        End Property
        
        Friend ReadOnly Property DescripcionColumn As DataColumn
            Get
                Return Me.columnDescripcion
            End Get
        End Property
        
        Friend ReadOnly Property SalidaColumn As DataColumn
            Get
                Return Me.columnSalida
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Estado_EmpleadoRow
            Get
                Return CType(Me.Rows(index),Estado_EmpleadoRow)
            End Get
        End Property
        
        Public Event Estado_EmpleadoRowChanged As Estado_EmpleadoRowChangeEventHandler
        
        Public Event Estado_EmpleadoRowChanging As Estado_EmpleadoRowChangeEventHandler
        
        Public Event Estado_EmpleadoRowDeleted As Estado_EmpleadoRowChangeEventHandler
        
        Public Event Estado_EmpleadoRowDeleting As Estado_EmpleadoRowChangeEventHandler
        
        Public Overloads Sub AddEstado_EmpleadoRow(ByVal row As Estado_EmpleadoRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddEstado_EmpleadoRow(ByVal Descripcion As String, ByVal Salida As Boolean) As Estado_EmpleadoRow
            Dim rowEstado_EmpleadoRow As Estado_EmpleadoRow = CType(Me.NewRow,Estado_EmpleadoRow)
            rowEstado_EmpleadoRow.ItemArray = New Object() {Nothing, Descripcion, Salida}
            Me.Rows.Add(rowEstado_EmpleadoRow)
            Return rowEstado_EmpleadoRow
        End Function
        
        Public Function FindByCodigo(ByVal Codigo As Integer) As Estado_EmpleadoRow
            Return CType(Me.Rows.Find(New Object() {Codigo}),Estado_EmpleadoRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Estado_EmpleadoDataTable = CType(MyBase.Clone,Estado_EmpleadoDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Estado_EmpleadoDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCodigo = Me.Columns("Codigo")
            Me.columnDescripcion = Me.Columns("Descripcion")
            Me.columnSalida = Me.Columns("Salida")
        End Sub
        
        Private Sub InitClass()
            Me.columnCodigo = New DataColumn("Codigo", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCodigo)
            Me.columnDescripcion = New DataColumn("Descripcion", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescripcion)
            Me.columnSalida = New DataColumn("Salida", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSalida)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnCodigo}, true))
            Me.columnCodigo.AutoIncrement = true
            Me.columnCodigo.AllowDBNull = false
            Me.columnCodigo.ReadOnly = true
            Me.columnCodigo.Unique = true
            Me.columnDescripcion.AllowDBNull = false
            Me.columnSalida.AllowDBNull = false
        End Sub
        
        Public Function NewEstado_EmpleadoRow() As Estado_EmpleadoRow
            Return CType(Me.NewRow,Estado_EmpleadoRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Estado_EmpleadoRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Estado_EmpleadoRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Estado_EmpleadoRowChangedEvent) Is Nothing) Then
                RaiseEvent Estado_EmpleadoRowChanged(Me, New Estado_EmpleadoRowChangeEvent(CType(e.Row,Estado_EmpleadoRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Estado_EmpleadoRowChangingEvent) Is Nothing) Then
                RaiseEvent Estado_EmpleadoRowChanging(Me, New Estado_EmpleadoRowChangeEvent(CType(e.Row,Estado_EmpleadoRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Estado_EmpleadoRowDeletedEvent) Is Nothing) Then
                RaiseEvent Estado_EmpleadoRowDeleted(Me, New Estado_EmpleadoRowChangeEvent(CType(e.Row,Estado_EmpleadoRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Estado_EmpleadoRowDeletingEvent) Is Nothing) Then
                RaiseEvent Estado_EmpleadoRowDeleting(Me, New Estado_EmpleadoRowChangeEvent(CType(e.Row,Estado_EmpleadoRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveEstado_EmpleadoRow(ByVal row As Estado_EmpleadoRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Estado_EmpleadoRow
        Inherits DataRow
        
        Private tableEstado_Empleado As Estado_EmpleadoDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableEstado_Empleado = CType(Me.Table,Estado_EmpleadoDataTable)
        End Sub
        
        Public Property Codigo As Integer
            Get
                Return CType(Me(Me.tableEstado_Empleado.CodigoColumn),Integer)
            End Get
            Set
                Me(Me.tableEstado_Empleado.CodigoColumn) = value
            End Set
        End Property
        
        Public Property Descripcion As String
            Get
                Return CType(Me(Me.tableEstado_Empleado.DescripcionColumn),String)
            End Get
            Set
                Me(Me.tableEstado_Empleado.DescripcionColumn) = value
            End Set
        End Property
        
        Public Property Salida As Boolean
            Get
                Return CType(Me(Me.tableEstado_Empleado.SalidaColumn),Boolean)
            End Get
            Set
                Me(Me.tableEstado_Empleado.SalidaColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Estado_EmpleadoRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Estado_EmpleadoRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Estado_EmpleadoRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Estado_EmpleadoRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
