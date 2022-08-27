﻿'------------------------------------------------------------------------------
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
Public Class dsPlanilla2
    Inherits DataSet
    
    Private tableAdelantos_Detalle As Adelantos_DetalleDataTable
    
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
            If (Not (ds.Tables("Adelantos_Detalle")) Is Nothing) Then
                Me.Tables.Add(New Adelantos_DetalleDataTable(ds.Tables("Adelantos_Detalle")))
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
    Public ReadOnly Property Adelantos_Detalle As Adelantos_DetalleDataTable
        Get
            Return Me.tableAdelantos_Detalle
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsPlanilla2 = CType(MyBase.Clone,dsPlanilla2)
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
        If (Not (ds.Tables("Adelantos_Detalle")) Is Nothing) Then
            Me.Tables.Add(New Adelantos_DetalleDataTable(ds.Tables("Adelantos_Detalle")))
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
        Me.tableAdelantos_Detalle = CType(Me.Tables("Adelantos_Detalle"),Adelantos_DetalleDataTable)
        If (Not (Me.tableAdelantos_Detalle) Is Nothing) Then
            Me.tableAdelantos_Detalle.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsPlanilla2"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsPlanilla2.xsd"
        Me.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableAdelantos_Detalle = New Adelantos_DetalleDataTable
        Me.Tables.Add(Me.tableAdelantos_Detalle)
    End Sub
    
    Private Function ShouldSerializeAdelantos_Detalle() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub Adelantos_DetalleRowChangeEventHandler(ByVal sender As Object, ByVal e As Adelantos_DetalleRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Adelantos_DetalleDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnId_Detalle_AP As DataColumn
        
        Private columnId_Empleado As DataColumn
        
        Private columnNumero As DataColumn
        
        Private columnTipo_Pago As DataColumn
        
        Private columnMonto As DataColumn
        
        Friend Sub New()
            MyBase.New("Adelantos_Detalle")
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
        
        Friend ReadOnly Property Id_Detalle_APColumn As DataColumn
            Get
                Return Me.columnId_Detalle_AP
            End Get
        End Property
        
        Friend ReadOnly Property Id_EmpleadoColumn As DataColumn
            Get
                Return Me.columnId_Empleado
            End Get
        End Property
        
        Friend ReadOnly Property NumeroColumn As DataColumn
            Get
                Return Me.columnNumero
            End Get
        End Property
        
        Friend ReadOnly Property Tipo_PagoColumn As DataColumn
            Get
                Return Me.columnTipo_Pago
            End Get
        End Property
        
        Friend ReadOnly Property MontoColumn As DataColumn
            Get
                Return Me.columnMonto
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Adelantos_DetalleRow
            Get
                Return CType(Me.Rows(index),Adelantos_DetalleRow)
            End Get
        End Property
        
        Public Event Adelantos_DetalleRowChanged As Adelantos_DetalleRowChangeEventHandler
        
        Public Event Adelantos_DetalleRowChanging As Adelantos_DetalleRowChangeEventHandler
        
        Public Event Adelantos_DetalleRowDeleted As Adelantos_DetalleRowChangeEventHandler
        
        Public Event Adelantos_DetalleRowDeleting As Adelantos_DetalleRowChangeEventHandler
        
        Public Overloads Sub AddAdelantos_DetalleRow(ByVal row As Adelantos_DetalleRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddAdelantos_DetalleRow(ByVal Id_Empleado As String, ByVal Numero As Long, ByVal Tipo_Pago As Boolean, ByVal Monto As Double) As Adelantos_DetalleRow
            Dim rowAdelantos_DetalleRow As Adelantos_DetalleRow = CType(Me.NewRow,Adelantos_DetalleRow)
            rowAdelantos_DetalleRow.ItemArray = New Object() {Nothing, Id_Empleado, Numero, Tipo_Pago, Monto}
            Me.Rows.Add(rowAdelantos_DetalleRow)
            Return rowAdelantos_DetalleRow
        End Function
        
        Public Function FindById_Detalle_AP(ByVal Id_Detalle_AP As Integer) As Adelantos_DetalleRow
            Return CType(Me.Rows.Find(New Object() {Id_Detalle_AP}),Adelantos_DetalleRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Adelantos_DetalleDataTable = CType(MyBase.Clone,Adelantos_DetalleDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Adelantos_DetalleDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnId_Detalle_AP = Me.Columns("Id_Detalle_AP")
            Me.columnId_Empleado = Me.Columns("Id_Empleado")
            Me.columnNumero = Me.Columns("Numero")
            Me.columnTipo_Pago = Me.Columns("Tipo_Pago")
            Me.columnMonto = Me.Columns("Monto")
        End Sub
        
        Private Sub InitClass()
            Me.columnId_Detalle_AP = New DataColumn("Id_Detalle_AP", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnId_Detalle_AP)
            Me.columnId_Empleado = New DataColumn("Id_Empleado", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnId_Empleado)
            Me.columnNumero = New DataColumn("Numero", GetType(System.Int64), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNumero)
            Me.columnTipo_Pago = New DataColumn("Tipo_Pago", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTipo_Pago)
            Me.columnMonto = New DataColumn("Monto", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnMonto)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnId_Detalle_AP}, true))
            Me.columnId_Detalle_AP.AutoIncrement = true
            Me.columnId_Detalle_AP.AllowDBNull = false
            Me.columnId_Detalle_AP.ReadOnly = true
            Me.columnId_Detalle_AP.Unique = true
            Me.columnId_Empleado.AllowDBNull = false
            Me.columnNumero.AllowDBNull = false
            Me.columnTipo_Pago.AllowDBNull = false
            Me.columnMonto.AllowDBNull = false
        End Sub
        
        Public Function NewAdelantos_DetalleRow() As Adelantos_DetalleRow
            Return CType(Me.NewRow,Adelantos_DetalleRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Adelantos_DetalleRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Adelantos_DetalleRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Adelantos_DetalleRowChangedEvent) Is Nothing) Then
                RaiseEvent Adelantos_DetalleRowChanged(Me, New Adelantos_DetalleRowChangeEvent(CType(e.Row,Adelantos_DetalleRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Adelantos_DetalleRowChangingEvent) Is Nothing) Then
                RaiseEvent Adelantos_DetalleRowChanging(Me, New Adelantos_DetalleRowChangeEvent(CType(e.Row,Adelantos_DetalleRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Adelantos_DetalleRowDeletedEvent) Is Nothing) Then
                RaiseEvent Adelantos_DetalleRowDeleted(Me, New Adelantos_DetalleRowChangeEvent(CType(e.Row,Adelantos_DetalleRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Adelantos_DetalleRowDeletingEvent) Is Nothing) Then
                RaiseEvent Adelantos_DetalleRowDeleting(Me, New Adelantos_DetalleRowChangeEvent(CType(e.Row,Adelantos_DetalleRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveAdelantos_DetalleRow(ByVal row As Adelantos_DetalleRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Adelantos_DetalleRow
        Inherits DataRow
        
        Private tableAdelantos_Detalle As Adelantos_DetalleDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableAdelantos_Detalle = CType(Me.Table,Adelantos_DetalleDataTable)
        End Sub
        
        Public Property Id_Detalle_AP As Integer
            Get
                Return CType(Me(Me.tableAdelantos_Detalle.Id_Detalle_APColumn),Integer)
            End Get
            Set
                Me(Me.tableAdelantos_Detalle.Id_Detalle_APColumn) = value
            End Set
        End Property
        
        Public Property Id_Empleado As String
            Get
                Return CType(Me(Me.tableAdelantos_Detalle.Id_EmpleadoColumn),String)
            End Get
            Set
                Me(Me.tableAdelantos_Detalle.Id_EmpleadoColumn) = value
            End Set
        End Property
        
        Public Property Numero As Long
            Get
                Return CType(Me(Me.tableAdelantos_Detalle.NumeroColumn),Long)
            End Get
            Set
                Me(Me.tableAdelantos_Detalle.NumeroColumn) = value
            End Set
        End Property
        
        Public Property Tipo_Pago As Boolean
            Get
                Return CType(Me(Me.tableAdelantos_Detalle.Tipo_PagoColumn),Boolean)
            End Get
            Set
                Me(Me.tableAdelantos_Detalle.Tipo_PagoColumn) = value
            End Set
        End Property
        
        Public Property Monto As Double
            Get
                Return CType(Me(Me.tableAdelantos_Detalle.MontoColumn),Double)
            End Get
            Set
                Me(Me.tableAdelantos_Detalle.MontoColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Adelantos_DetalleRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Adelantos_DetalleRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Adelantos_DetalleRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Adelantos_DetalleRow
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