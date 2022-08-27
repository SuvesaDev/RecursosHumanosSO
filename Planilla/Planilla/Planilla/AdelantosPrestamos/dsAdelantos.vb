﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
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
Public Class dsAdelantos
    Inherits DataSet
    
    Private tableMoneda As MonedaDataTable
    
    Private tableAdelantos As AdelantosDataTable
    
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
            If (Not (ds.Tables("Moneda")) Is Nothing) Then
                Me.Tables.Add(New MonedaDataTable(ds.Tables("Moneda")))
            End If
            If (Not (ds.Tables("Adelantos")) Is Nothing) Then
                Me.Tables.Add(New AdelantosDataTable(ds.Tables("Adelantos")))
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
    Public ReadOnly Property Moneda As MonedaDataTable
        Get
            Return Me.tableMoneda
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Adelantos As AdelantosDataTable
        Get
            Return Me.tableAdelantos
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsAdelantos = CType(MyBase.Clone,dsAdelantos)
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
        If (Not (ds.Tables("Moneda")) Is Nothing) Then
            Me.Tables.Add(New MonedaDataTable(ds.Tables("Moneda")))
        End If
        If (Not (ds.Tables("Adelantos")) Is Nothing) Then
            Me.Tables.Add(New AdelantosDataTable(ds.Tables("Adelantos")))
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
        Me.tableMoneda = CType(Me.Tables("Moneda"),MonedaDataTable)
        If (Not (Me.tableMoneda) Is Nothing) Then
            Me.tableMoneda.InitVars
        End If
        Me.tableAdelantos = CType(Me.Tables("Adelantos"),AdelantosDataTable)
        If (Not (Me.tableAdelantos) Is Nothing) Then
            Me.tableAdelantos.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsAdelantos"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsAdelantos.xsd"
        Me.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableMoneda = New MonedaDataTable
        Me.Tables.Add(Me.tableMoneda)
        Me.tableAdelantos = New AdelantosDataTable
        Me.Tables.Add(Me.tableAdelantos)
    End Sub
    
    Private Function ShouldSerializeMoneda() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeAdelantos() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub MonedaRowChangeEventHandler(ByVal sender As Object, ByVal e As MonedaRowChangeEvent)
    
    Public Delegate Sub AdelantosRowChangeEventHandler(ByVal sender As Object, ByVal e As AdelantosRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class MonedaDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCodMoneda As DataColumn
        
        Private columnMonedaNombre As DataColumn
        
        Private columnValorCompra As DataColumn
        
        Private columnValorVenta As DataColumn
        
        Private columnSimbolo As DataColumn
        
        Friend Sub New()
            MyBase.New("Moneda")
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
        
        Friend ReadOnly Property CodMonedaColumn As DataColumn
            Get
                Return Me.columnCodMoneda
            End Get
        End Property
        
        Friend ReadOnly Property MonedaNombreColumn As DataColumn
            Get
                Return Me.columnMonedaNombre
            End Get
        End Property
        
        Friend ReadOnly Property ValorCompraColumn As DataColumn
            Get
                Return Me.columnValorCompra
            End Get
        End Property
        
        Friend ReadOnly Property ValorVentaColumn As DataColumn
            Get
                Return Me.columnValorVenta
            End Get
        End Property
        
        Friend ReadOnly Property SimboloColumn As DataColumn
            Get
                Return Me.columnSimbolo
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As MonedaRow
            Get
                Return CType(Me.Rows(index),MonedaRow)
            End Get
        End Property
        
        Public Event MonedaRowChanged As MonedaRowChangeEventHandler
        
        Public Event MonedaRowChanging As MonedaRowChangeEventHandler
        
        Public Event MonedaRowDeleted As MonedaRowChangeEventHandler
        
        Public Event MonedaRowDeleting As MonedaRowChangeEventHandler
        
        Public Overloads Sub AddMonedaRow(ByVal row As MonedaRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddMonedaRow(ByVal CodMoneda As Integer, ByVal MonedaNombre As String, ByVal ValorCompra As Double, ByVal ValorVenta As Double, ByVal Simbolo As String) As MonedaRow
            Dim rowMonedaRow As MonedaRow = CType(Me.NewRow,MonedaRow)
            rowMonedaRow.ItemArray = New Object() {CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo}
            Me.Rows.Add(rowMonedaRow)
            Return rowMonedaRow
        End Function
        
        Public Function FindByCodMoneda(ByVal CodMoneda As Integer) As MonedaRow
            Return CType(Me.Rows.Find(New Object() {CodMoneda}),MonedaRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As MonedaDataTable = CType(MyBase.Clone,MonedaDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New MonedaDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCodMoneda = Me.Columns("CodMoneda")
            Me.columnMonedaNombre = Me.Columns("MonedaNombre")
            Me.columnValorCompra = Me.Columns("ValorCompra")
            Me.columnValorVenta = Me.Columns("ValorVenta")
            Me.columnSimbolo = Me.Columns("Simbolo")
        End Sub
        
        Private Sub InitClass()
            Me.columnCodMoneda = New DataColumn("CodMoneda", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCodMoneda)
            Me.columnMonedaNombre = New DataColumn("MonedaNombre", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnMonedaNombre)
            Me.columnValorCompra = New DataColumn("ValorCompra", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnValorCompra)
            Me.columnValorVenta = New DataColumn("ValorVenta", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnValorVenta)
            Me.columnSimbolo = New DataColumn("Simbolo", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSimbolo)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnCodMoneda}, true))
            Me.columnCodMoneda.AllowDBNull = false
            Me.columnCodMoneda.Unique = true
            Me.columnMonedaNombre.AllowDBNull = false
            Me.columnValorCompra.AllowDBNull = false
            Me.columnValorVenta.AllowDBNull = false
            Me.columnSimbolo.AllowDBNull = false
        End Sub
        
        Public Function NewMonedaRow() As MonedaRow
            Return CType(Me.NewRow,MonedaRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New MonedaRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(MonedaRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.MonedaRowChangedEvent) Is Nothing) Then
                RaiseEvent MonedaRowChanged(Me, New MonedaRowChangeEvent(CType(e.Row,MonedaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.MonedaRowChangingEvent) Is Nothing) Then
                RaiseEvent MonedaRowChanging(Me, New MonedaRowChangeEvent(CType(e.Row,MonedaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.MonedaRowDeletedEvent) Is Nothing) Then
                RaiseEvent MonedaRowDeleted(Me, New MonedaRowChangeEvent(CType(e.Row,MonedaRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.MonedaRowDeletingEvent) Is Nothing) Then
                RaiseEvent MonedaRowDeleting(Me, New MonedaRowChangeEvent(CType(e.Row,MonedaRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveMonedaRow(ByVal row As MonedaRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class MonedaRow
        Inherits DataRow
        
        Private tableMoneda As MonedaDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableMoneda = CType(Me.Table,MonedaDataTable)
        End Sub
        
        Public Property CodMoneda As Integer
            Get
                Return CType(Me(Me.tableMoneda.CodMonedaColumn),Integer)
            End Get
            Set
                Me(Me.tableMoneda.CodMonedaColumn) = value
            End Set
        End Property
        
        Public Property MonedaNombre As String
            Get
                Return CType(Me(Me.tableMoneda.MonedaNombreColumn),String)
            End Get
            Set
                Me(Me.tableMoneda.MonedaNombreColumn) = value
            End Set
        End Property
        
        Public Property ValorCompra As Double
            Get
                Return CType(Me(Me.tableMoneda.ValorCompraColumn),Double)
            End Get
            Set
                Me(Me.tableMoneda.ValorCompraColumn) = value
            End Set
        End Property
        
        Public Property ValorVenta As Double
            Get
                Return CType(Me(Me.tableMoneda.ValorVentaColumn),Double)
            End Get
            Set
                Me(Me.tableMoneda.ValorVentaColumn) = value
            End Set
        End Property
        
        Public Property Simbolo As String
            Get
                Return CType(Me(Me.tableMoneda.SimboloColumn),String)
            End Get
            Set
                Me(Me.tableMoneda.SimboloColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class MonedaRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As MonedaRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As MonedaRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As MonedaRow
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
    Public Class AdelantosDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnNumero As DataColumn
        
        Private columnIdentificacion As DataColumn
        
        Private columnNombre As DataColumn
        
        Private columnAdelanto As DataColumn
        
        Private columnPrestamo As DataColumn
        
        Private columnPuesto As DataColumn
        
        Private columnSalario As DataColumn
        
        Private columnFechaComprobante As DataColumn
        
        Private columnNum_Pago As DataColumn
        
        Private columnMonto As DataColumn
        
        Private columnMontoEnLetras As DataColumn
        
        Private columnFechaCobro As DataColumn
        
        Private columnObservaciones As DataColumn
        
        Private columnDeducirxPago As DataColumn
        
        Private columnUsuario As DataColumn
        
        Private columnNombreUsuario As DataColumn
        
        Private columnCod_Moneda As DataColumn
        
        Private columnAnulado As DataColumn
        
        Private columnSaldo As DataColumn
        
        Friend Sub New()
            MyBase.New("Adelantos")
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
        
        Friend ReadOnly Property NumeroColumn As DataColumn
            Get
                Return Me.columnNumero
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
        
        Friend ReadOnly Property AdelantoColumn As DataColumn
            Get
                Return Me.columnAdelanto
            End Get
        End Property
        
        Friend ReadOnly Property PrestamoColumn As DataColumn
            Get
                Return Me.columnPrestamo
            End Get
        End Property
        
        Friend ReadOnly Property PuestoColumn As DataColumn
            Get
                Return Me.columnPuesto
            End Get
        End Property
        
        Friend ReadOnly Property SalarioColumn As DataColumn
            Get
                Return Me.columnSalario
            End Get
        End Property
        
        Friend ReadOnly Property FechaComprobanteColumn As DataColumn
            Get
                Return Me.columnFechaComprobante
            End Get
        End Property
        
        Friend ReadOnly Property Num_PagoColumn As DataColumn
            Get
                Return Me.columnNum_Pago
            End Get
        End Property
        
        Friend ReadOnly Property MontoColumn As DataColumn
            Get
                Return Me.columnMonto
            End Get
        End Property
        
        Friend ReadOnly Property MontoEnLetrasColumn As DataColumn
            Get
                Return Me.columnMontoEnLetras
            End Get
        End Property
        
        Friend ReadOnly Property FechaCobroColumn As DataColumn
            Get
                Return Me.columnFechaCobro
            End Get
        End Property
        
        Friend ReadOnly Property ObservacionesColumn As DataColumn
            Get
                Return Me.columnObservaciones
            End Get
        End Property
        
        Friend ReadOnly Property DeducirxPagoColumn As DataColumn
            Get
                Return Me.columnDeducirxPago
            End Get
        End Property
        
        Friend ReadOnly Property UsuarioColumn As DataColumn
            Get
                Return Me.columnUsuario
            End Get
        End Property
        
        Friend ReadOnly Property NombreUsuarioColumn As DataColumn
            Get
                Return Me.columnNombreUsuario
            End Get
        End Property
        
        Friend ReadOnly Property Cod_MonedaColumn As DataColumn
            Get
                Return Me.columnCod_Moneda
            End Get
        End Property
        
        Friend ReadOnly Property AnuladoColumn As DataColumn
            Get
                Return Me.columnAnulado
            End Get
        End Property
        
        Friend ReadOnly Property SaldoColumn As DataColumn
            Get
                Return Me.columnSaldo
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As AdelantosRow
            Get
                Return CType(Me.Rows(index),AdelantosRow)
            End Get
        End Property
        
        Public Event AdelantosRowChanged As AdelantosRowChangeEventHandler
        
        Public Event AdelantosRowChanging As AdelantosRowChangeEventHandler
        
        Public Event AdelantosRowDeleted As AdelantosRowChangeEventHandler
        
        Public Event AdelantosRowDeleting As AdelantosRowChangeEventHandler
        
        Public Overloads Sub AddAdelantosRow(ByVal row As AdelantosRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddAdelantosRow( _
                    ByVal Identificacion As String,  _
                    ByVal Nombre As String,  _
                    ByVal Adelanto As Boolean,  _
                    ByVal Prestamo As Boolean,  _
                    ByVal Puesto As String,  _
                    ByVal Salario As Double,  _
                    ByVal FechaComprobante As Date,  _
                    ByVal Num_Pago As Integer,  _
                    ByVal Monto As Double,  _
                    ByVal MontoEnLetras As String,  _
                    ByVal FechaCobro As Date,  _
                    ByVal Observaciones As String,  _
                    ByVal DeducirxPago As Double,  _
                    ByVal Usuario As String,  _
                    ByVal NombreUsuario As String,  _
                    ByVal Cod_Moneda As Integer,  _
                    ByVal Anulado As Boolean,  _
                    ByVal Saldo As Double) As AdelantosRow
            Dim rowAdelantosRow As AdelantosRow = CType(Me.NewRow,AdelantosRow)
            rowAdelantosRow.ItemArray = New Object() {Nothing, Identificacion, Nombre, Adelanto, Prestamo, Puesto, Salario, FechaComprobante, Num_Pago, Monto, MontoEnLetras, FechaCobro, Observaciones, DeducirxPago, Usuario, NombreUsuario, Cod_Moneda, Anulado, Saldo}
            Me.Rows.Add(rowAdelantosRow)
            Return rowAdelantosRow
        End Function
        
        Public Function FindByNumero(ByVal Numero As Long) As AdelantosRow
            Return CType(Me.Rows.Find(New Object() {Numero}),AdelantosRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As AdelantosDataTable = CType(MyBase.Clone,AdelantosDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New AdelantosDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnNumero = Me.Columns("Numero")
            Me.columnIdentificacion = Me.Columns("Identificacion")
            Me.columnNombre = Me.Columns("Nombre")
            Me.columnAdelanto = Me.Columns("Adelanto")
            Me.columnPrestamo = Me.Columns("Prestamo")
            Me.columnPuesto = Me.Columns("Puesto")
            Me.columnSalario = Me.Columns("Salario")
            Me.columnFechaComprobante = Me.Columns("FechaComprobante")
            Me.columnNum_Pago = Me.Columns("Num_Pago")
            Me.columnMonto = Me.Columns("Monto")
            Me.columnMontoEnLetras = Me.Columns("MontoEnLetras")
            Me.columnFechaCobro = Me.Columns("FechaCobro")
            Me.columnObservaciones = Me.Columns("Observaciones")
            Me.columnDeducirxPago = Me.Columns("DeducirxPago")
            Me.columnUsuario = Me.Columns("Usuario")
            Me.columnNombreUsuario = Me.Columns("NombreUsuario")
            Me.columnCod_Moneda = Me.Columns("Cod_Moneda")
            Me.columnAnulado = Me.Columns("Anulado")
            Me.columnSaldo = Me.Columns("Saldo")
        End Sub
        
        Private Sub InitClass()
            Me.columnNumero = New DataColumn("Numero", GetType(System.Int64), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNumero)
            Me.columnIdentificacion = New DataColumn("Identificacion", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnIdentificacion)
            Me.columnNombre = New DataColumn("Nombre", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNombre)
            Me.columnAdelanto = New DataColumn("Adelanto", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAdelanto)
            Me.columnPrestamo = New DataColumn("Prestamo", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPrestamo)
            Me.columnPuesto = New DataColumn("Puesto", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPuesto)
            Me.columnSalario = New DataColumn("Salario", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSalario)
            Me.columnFechaComprobante = New DataColumn("FechaComprobante", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFechaComprobante)
            Me.columnNum_Pago = New DataColumn("Num_Pago", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNum_Pago)
            Me.columnMonto = New DataColumn("Monto", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnMonto)
            Me.columnMontoEnLetras = New DataColumn("MontoEnLetras", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnMontoEnLetras)
            Me.columnFechaCobro = New DataColumn("FechaCobro", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFechaCobro)
            Me.columnObservaciones = New DataColumn("Observaciones", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnObservaciones)
            Me.columnDeducirxPago = New DataColumn("DeducirxPago", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDeducirxPago)
            Me.columnUsuario = New DataColumn("Usuario", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUsuario)
            Me.columnNombreUsuario = New DataColumn("NombreUsuario", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNombreUsuario)
            Me.columnCod_Moneda = New DataColumn("Cod_Moneda", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCod_Moneda)
            Me.columnAnulado = New DataColumn("Anulado", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAnulado)
            Me.columnSaldo = New DataColumn("Saldo", GetType(System.Double), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSaldo)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnNumero}, true))
            Me.columnNumero.AutoIncrement = true
            Me.columnNumero.AllowDBNull = false
            Me.columnNumero.ReadOnly = true
            Me.columnNumero.Unique = true
            Me.columnIdentificacion.AllowDBNull = false
            Me.columnNombre.AllowDBNull = false
            Me.columnAdelanto.AllowDBNull = false
            Me.columnPrestamo.AllowDBNull = false
            Me.columnPuesto.AllowDBNull = false
            Me.columnSalario.AllowDBNull = false
            Me.columnFechaComprobante.AllowDBNull = false
            Me.columnNum_Pago.AllowDBNull = false
            Me.columnMonto.AllowDBNull = false
            Me.columnMontoEnLetras.AllowDBNull = false
            Me.columnFechaCobro.AllowDBNull = false
            Me.columnObservaciones.AllowDBNull = false
            Me.columnDeducirxPago.AllowDBNull = false
            Me.columnUsuario.AllowDBNull = false
            Me.columnNombreUsuario.AllowDBNull = false
            Me.columnCod_Moneda.AllowDBNull = false
            Me.columnAnulado.AllowDBNull = false
        End Sub
        
        Public Function NewAdelantosRow() As AdelantosRow
            Return CType(Me.NewRow,AdelantosRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New AdelantosRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(AdelantosRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.AdelantosRowChangedEvent) Is Nothing) Then
                RaiseEvent AdelantosRowChanged(Me, New AdelantosRowChangeEvent(CType(e.Row,AdelantosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.AdelantosRowChangingEvent) Is Nothing) Then
                RaiseEvent AdelantosRowChanging(Me, New AdelantosRowChangeEvent(CType(e.Row,AdelantosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.AdelantosRowDeletedEvent) Is Nothing) Then
                RaiseEvent AdelantosRowDeleted(Me, New AdelantosRowChangeEvent(CType(e.Row,AdelantosRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.AdelantosRowDeletingEvent) Is Nothing) Then
                RaiseEvent AdelantosRowDeleting(Me, New AdelantosRowChangeEvent(CType(e.Row,AdelantosRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveAdelantosRow(ByVal row As AdelantosRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AdelantosRow
        Inherits DataRow
        
        Private tableAdelantos As AdelantosDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableAdelantos = CType(Me.Table,AdelantosDataTable)
        End Sub
        
        Public Property Numero As Long
            Get
                Return CType(Me(Me.tableAdelantos.NumeroColumn),Long)
            End Get
            Set
                Me(Me.tableAdelantos.NumeroColumn) = value
            End Set
        End Property
        
        Public Property Identificacion As String
            Get
                Return CType(Me(Me.tableAdelantos.IdentificacionColumn),String)
            End Get
            Set
                Me(Me.tableAdelantos.IdentificacionColumn) = value
            End Set
        End Property
        
        Public Property Nombre As String
            Get
                Return CType(Me(Me.tableAdelantos.NombreColumn),String)
            End Get
            Set
                Me(Me.tableAdelantos.NombreColumn) = value
            End Set
        End Property
        
        Public Property Adelanto As Boolean
            Get
                Return CType(Me(Me.tableAdelantos.AdelantoColumn),Boolean)
            End Get
            Set
                Me(Me.tableAdelantos.AdelantoColumn) = value
            End Set
        End Property
        
        Public Property Prestamo As Boolean
            Get
                Return CType(Me(Me.tableAdelantos.PrestamoColumn),Boolean)
            End Get
            Set
                Me(Me.tableAdelantos.PrestamoColumn) = value
            End Set
        End Property
        
        Public Property Puesto As String
            Get
                Return CType(Me(Me.tableAdelantos.PuestoColumn),String)
            End Get
            Set
                Me(Me.tableAdelantos.PuestoColumn) = value
            End Set
        End Property
        
        Public Property Salario As Double
            Get
                Return CType(Me(Me.tableAdelantos.SalarioColumn),Double)
            End Get
            Set
                Me(Me.tableAdelantos.SalarioColumn) = value
            End Set
        End Property
        
        Public Property FechaComprobante As Date
            Get
                Return CType(Me(Me.tableAdelantos.FechaComprobanteColumn),Date)
            End Get
            Set
                Me(Me.tableAdelantos.FechaComprobanteColumn) = value
            End Set
        End Property
        
        Public Property Num_Pago As Integer
            Get
                Return CType(Me(Me.tableAdelantos.Num_PagoColumn),Integer)
            End Get
            Set
                Me(Me.tableAdelantos.Num_PagoColumn) = value
            End Set
        End Property
        
        Public Property Monto As Double
            Get
                Return CType(Me(Me.tableAdelantos.MontoColumn),Double)
            End Get
            Set
                Me(Me.tableAdelantos.MontoColumn) = value
            End Set
        End Property
        
        Public Property MontoEnLetras As String
            Get
                Return CType(Me(Me.tableAdelantos.MontoEnLetrasColumn),String)
            End Get
            Set
                Me(Me.tableAdelantos.MontoEnLetrasColumn) = value
            End Set
        End Property
        
        Public Property FechaCobro As Date
            Get
                Return CType(Me(Me.tableAdelantos.FechaCobroColumn),Date)
            End Get
            Set
                Me(Me.tableAdelantos.FechaCobroColumn) = value
            End Set
        End Property
        
        Public Property Observaciones As String
            Get
                Return CType(Me(Me.tableAdelantos.ObservacionesColumn),String)
            End Get
            Set
                Me(Me.tableAdelantos.ObservacionesColumn) = value
            End Set
        End Property
        
        Public Property DeducirxPago As Double
            Get
                Return CType(Me(Me.tableAdelantos.DeducirxPagoColumn),Double)
            End Get
            Set
                Me(Me.tableAdelantos.DeducirxPagoColumn) = value
            End Set
        End Property
        
        Public Property Usuario As String
            Get
                Return CType(Me(Me.tableAdelantos.UsuarioColumn),String)
            End Get
            Set
                Me(Me.tableAdelantos.UsuarioColumn) = value
            End Set
        End Property
        
        Public Property NombreUsuario As String
            Get
                Return CType(Me(Me.tableAdelantos.NombreUsuarioColumn),String)
            End Get
            Set
                Me(Me.tableAdelantos.NombreUsuarioColumn) = value
            End Set
        End Property
        
        Public Property Cod_Moneda As Integer
            Get
                Return CType(Me(Me.tableAdelantos.Cod_MonedaColumn),Integer)
            End Get
            Set
                Me(Me.tableAdelantos.Cod_MonedaColumn) = value
            End Set
        End Property
        
        Public Property Anulado As Boolean
            Get
                Return CType(Me(Me.tableAdelantos.AnuladoColumn),Boolean)
            End Get
            Set
                Me(Me.tableAdelantos.AnuladoColumn) = value
            End Set
        End Property
        
        Public Property Saldo As Double
            Get
                Try 
                    Return CType(Me(Me.tableAdelantos.SaldoColumn),Double)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("No se puede obtener el valor porque es DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableAdelantos.SaldoColumn) = value
            End Set
        End Property
        
        Public Function IsSaldoNull() As Boolean
            Return Me.IsNull(Me.tableAdelantos.SaldoColumn)
        End Function
        
        Public Sub SetSaldoNull()
            Me(Me.tableAdelantos.SaldoColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class AdelantosRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As AdelantosRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As AdelantosRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As AdelantosRow
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
