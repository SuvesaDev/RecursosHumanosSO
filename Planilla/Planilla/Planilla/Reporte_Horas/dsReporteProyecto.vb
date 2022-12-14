'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2032
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
Public Class dsReporteProyecto
    Inherits DataSet
    
    Private tableProyecto As ProyectoDataTable
    
    Private tableEmpleado As EmpleadoDataTable
    
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
            If (Not (ds.Tables("Proyecto")) Is Nothing) Then
                Me.Tables.Add(New ProyectoDataTable(ds.Tables("Proyecto")))
            End If
            If (Not (ds.Tables("Empleado")) Is Nothing) Then
                Me.Tables.Add(New EmpleadoDataTable(ds.Tables("Empleado")))
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
    Public ReadOnly Property Proyecto As ProyectoDataTable
        Get
            Return Me.tableProyecto
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Empleado As EmpleadoDataTable
        Get
            Return Me.tableEmpleado
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsReporteProyecto = CType(MyBase.Clone,dsReporteProyecto)
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
        If (Not (ds.Tables("Proyecto")) Is Nothing) Then
            Me.Tables.Add(New ProyectoDataTable(ds.Tables("Proyecto")))
        End If
        If (Not (ds.Tables("Empleado")) Is Nothing) Then
            Me.Tables.Add(New EmpleadoDataTable(ds.Tables("Empleado")))
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
        Me.tableProyecto = CType(Me.Tables("Proyecto"),ProyectoDataTable)
        If (Not (Me.tableProyecto) Is Nothing) Then
            Me.tableProyecto.InitVars
        End If
        Me.tableEmpleado = CType(Me.Tables("Empleado"),EmpleadoDataTable)
        If (Not (Me.tableEmpleado) Is Nothing) Then
            Me.tableEmpleado.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsReporteProyecto"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsReporteProyecto.xsd"
        Me.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableProyecto = New ProyectoDataTable
        Me.Tables.Add(Me.tableProyecto)
        Me.tableEmpleado = New EmpleadoDataTable
        Me.Tables.Add(Me.tableEmpleado)
    End Sub
    
    Private Function ShouldSerializeProyecto() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeEmpleado() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub ProyectoRowChangeEventHandler(ByVal sender As Object, ByVal e As ProyectoRowChangeEvent)
    
    Public Delegate Sub EmpleadoRowChangeEventHandler(ByVal sender As Object, ByVal e As EmpleadoRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ProyectoDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnNombreProyecto As DataColumn
        
        Private columnCodCliente As DataColumn
        
        Private columnNombreCliente As DataColumn
        
        Private columnNum_Proyecto As DataColumn
        
        Friend Sub New()
            MyBase.New("Proyecto")
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
        
        Friend ReadOnly Property NombreProyectoColumn As DataColumn
            Get
                Return Me.columnNombreProyecto
            End Get
        End Property
        
        Friend ReadOnly Property CodClienteColumn As DataColumn
            Get
                Return Me.columnCodCliente
            End Get
        End Property
        
        Friend ReadOnly Property NombreClienteColumn As DataColumn
            Get
                Return Me.columnNombreCliente
            End Get
        End Property
        
        Friend ReadOnly Property Num_ProyectoColumn As DataColumn
            Get
                Return Me.columnNum_Proyecto
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As ProyectoRow
            Get
                Return CType(Me.Rows(index),ProyectoRow)
            End Get
        End Property
        
        Public Event ProyectoRowChanged As ProyectoRowChangeEventHandler
        
        Public Event ProyectoRowChanging As ProyectoRowChangeEventHandler
        
        Public Event ProyectoRowDeleted As ProyectoRowChangeEventHandler
        
        Public Event ProyectoRowDeleting As ProyectoRowChangeEventHandler
        
        Public Overloads Sub AddProyectoRow(ByVal row As ProyectoRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddProyectoRow(ByVal NombreProyecto As String, ByVal CodCliente As Integer, ByVal NombreCliente As String) As ProyectoRow
            Dim rowProyectoRow As ProyectoRow = CType(Me.NewRow,ProyectoRow)
            rowProyectoRow.ItemArray = New Object() {NombreProyecto, CodCliente, NombreCliente, Nothing}
            Me.Rows.Add(rowProyectoRow)
            Return rowProyectoRow
        End Function
        
        Public Function FindByNum_Proyecto(ByVal Num_Proyecto As Integer) As ProyectoRow
            Return CType(Me.Rows.Find(New Object() {Num_Proyecto}),ProyectoRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As ProyectoDataTable = CType(MyBase.Clone,ProyectoDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New ProyectoDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnNombreProyecto = Me.Columns("NombreProyecto")
            Me.columnCodCliente = Me.Columns("CodCliente")
            Me.columnNombreCliente = Me.Columns("NombreCliente")
            Me.columnNum_Proyecto = Me.Columns("Num_Proyecto")
        End Sub
        
        Private Sub InitClass()
            Me.columnNombreProyecto = New DataColumn("NombreProyecto", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNombreProyecto)
            Me.columnCodCliente = New DataColumn("CodCliente", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCodCliente)
            Me.columnNombreCliente = New DataColumn("NombreCliente", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNombreCliente)
            Me.columnNum_Proyecto = New DataColumn("Num_Proyecto", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNum_Proyecto)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnNum_Proyecto}, true))
            Me.columnNombreProyecto.AllowDBNull = false
            Me.columnCodCliente.AllowDBNull = false
            Me.columnNombreCliente.AllowDBNull = false
            Me.columnNum_Proyecto.AutoIncrement = true
            Me.columnNum_Proyecto.AllowDBNull = false
            Me.columnNum_Proyecto.ReadOnly = true
            Me.columnNum_Proyecto.Unique = true
        End Sub
        
        Public Function NewProyectoRow() As ProyectoRow
            Return CType(Me.NewRow,ProyectoRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New ProyectoRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(ProyectoRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ProyectoRowChangedEvent) Is Nothing) Then
                RaiseEvent ProyectoRowChanged(Me, New ProyectoRowChangeEvent(CType(e.Row,ProyectoRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ProyectoRowChangingEvent) Is Nothing) Then
                RaiseEvent ProyectoRowChanging(Me, New ProyectoRowChangeEvent(CType(e.Row,ProyectoRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ProyectoRowDeletedEvent) Is Nothing) Then
                RaiseEvent ProyectoRowDeleted(Me, New ProyectoRowChangeEvent(CType(e.Row,ProyectoRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ProyectoRowDeletingEvent) Is Nothing) Then
                RaiseEvent ProyectoRowDeleting(Me, New ProyectoRowChangeEvent(CType(e.Row,ProyectoRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveProyectoRow(ByVal row As ProyectoRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ProyectoRow
        Inherits DataRow
        
        Private tableProyecto As ProyectoDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableProyecto = CType(Me.Table,ProyectoDataTable)
        End Sub
        
        Public Property NombreProyecto As String
            Get
                Return CType(Me(Me.tableProyecto.NombreProyectoColumn),String)
            End Get
            Set
                Me(Me.tableProyecto.NombreProyectoColumn) = value
            End Set
        End Property
        
        Public Property CodCliente As Integer
            Get
                Return CType(Me(Me.tableProyecto.CodClienteColumn),Integer)
            End Get
            Set
                Me(Me.tableProyecto.CodClienteColumn) = value
            End Set
        End Property
        
        Public Property NombreCliente As String
            Get
                Return CType(Me(Me.tableProyecto.NombreClienteColumn),String)
            End Get
            Set
                Me(Me.tableProyecto.NombreClienteColumn) = value
            End Set
        End Property
        
        Public Property Num_Proyecto As Integer
            Get
                Return CType(Me(Me.tableProyecto.Num_ProyectoColumn),Integer)
            End Get
            Set
                Me(Me.tableProyecto.Num_ProyectoColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ProyectoRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As ProyectoRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As ProyectoRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As ProyectoRow
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
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class EmpleadoDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnIdentificacion As DataColumn
        
        Private columnNombre As DataColumn
        
        Friend Sub New()
            MyBase.New("Empleado")
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
        
        Friend ReadOnly Property IdentificacionColumn As DataColumn
            Get
                Return Me.columnIdentificacion
            End Get
        End Property
        
        Friend ReadOnly Property NombreColumn As DataColumn
            Get
                Return Me.columnNombre
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As EmpleadoRow
            Get
                Return CType(Me.Rows(index),EmpleadoRow)
            End Get
        End Property
        
        Public Event EmpleadoRowChanged As EmpleadoRowChangeEventHandler
        
        Public Event EmpleadoRowChanging As EmpleadoRowChangeEventHandler
        
        Public Event EmpleadoRowDeleted As EmpleadoRowChangeEventHandler
        
        Public Event EmpleadoRowDeleting As EmpleadoRowChangeEventHandler
        
        Public Overloads Sub AddEmpleadoRow(ByVal row As EmpleadoRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddEmpleadoRow(ByVal Identificacion As String, ByVal Nombre As String) As EmpleadoRow
            Dim rowEmpleadoRow As EmpleadoRow = CType(Me.NewRow,EmpleadoRow)
            rowEmpleadoRow.ItemArray = New Object() {Identificacion, Nombre}
            Me.Rows.Add(rowEmpleadoRow)
            Return rowEmpleadoRow
        End Function
        
        Public Function FindByIdentificacion(ByVal Identificacion As String) As EmpleadoRow
            Return CType(Me.Rows.Find(New Object() {Identificacion}),EmpleadoRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As EmpleadoDataTable = CType(MyBase.Clone,EmpleadoDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New EmpleadoDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnIdentificacion = Me.Columns("Identificacion")
            Me.columnNombre = Me.Columns("Nombre")
        End Sub
        
        Private Sub InitClass()
            Me.columnIdentificacion = New DataColumn("Identificacion", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdentificacion)
            Me.columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNombre)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnIdentificacion}, true))
            Me.columnIdentificacion.AllowDBNull = false
            Me.columnIdentificacion.Unique = true
            Me.columnNombre.AllowDBNull = false
        End Sub
        
        Public Function NewEmpleadoRow() As EmpleadoRow
            Return CType(Me.NewRow,EmpleadoRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New EmpleadoRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(EmpleadoRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.EmpleadoRowChangedEvent) Is Nothing) Then
                RaiseEvent EmpleadoRowChanged(Me, New EmpleadoRowChangeEvent(CType(e.Row,EmpleadoRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.EmpleadoRowChangingEvent) Is Nothing) Then
                RaiseEvent EmpleadoRowChanging(Me, New EmpleadoRowChangeEvent(CType(e.Row,EmpleadoRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.EmpleadoRowDeletedEvent) Is Nothing) Then
                RaiseEvent EmpleadoRowDeleted(Me, New EmpleadoRowChangeEvent(CType(e.Row,EmpleadoRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.EmpleadoRowDeletingEvent) Is Nothing) Then
                RaiseEvent EmpleadoRowDeleting(Me, New EmpleadoRowChangeEvent(CType(e.Row,EmpleadoRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveEmpleadoRow(ByVal row As EmpleadoRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class EmpleadoRow
        Inherits DataRow
        
        Private tableEmpleado As EmpleadoDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableEmpleado = CType(Me.Table,EmpleadoDataTable)
        End Sub
        
        Public Property Identificacion As String
            Get
                Return CType(Me(Me.tableEmpleado.IdentificacionColumn),String)
            End Get
            Set
                Me(Me.tableEmpleado.IdentificacionColumn) = value
            End Set
        End Property
        
        Public Property Nombre As String
            Get
                Return CType(Me(Me.tableEmpleado.NombreColumn),String)
            End Get
            Set
                Me(Me.tableEmpleado.NombreColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class EmpleadoRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As EmpleadoRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As EmpleadoRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As EmpleadoRow
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
