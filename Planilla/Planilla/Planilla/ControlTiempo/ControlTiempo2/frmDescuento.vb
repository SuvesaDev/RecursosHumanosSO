Imports System.data.SqlClient
Public Class frmDescuento
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsPlanilla1 As Planilla.dsPlanilla
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents adAdelantos_Detalle As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DsPlanilla1 = New Planilla.dsPlanilla
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.adAdelantos_Detalle = New System.Data.SqlClient.SqlDataAdapter
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.DsPlanilla1.Adelantos_Detalle
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(32, 96)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(432, 160)
        Me.DataGrid1.TabIndex = 1
        '
        'DsPlanilla1
        '
        Me.DsPlanilla1.DataSetName = "dsPlanilla"
        Me.DsPlanilla1.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id_Detalle_AP, Id_Planilla_Detalle, Id_Empleado, Numero, Tipo_Pago, Monto " & _
        "FROM Adelantos_Detalle"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=PICHINGA;packet size=4096;integrated security=SSPI;data source=PIC" & _
        "HINGA;persist security info=False;initial catalog=Planilla"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Adelantos_Detalle(Id_Planilla_Detalle, Id_Empleado, Numero, Tipo_Pago" & _
        ", Monto) VALUES (@Id_Planilla_Detalle, @Id_Empleado, @Numero, @Tipo_Pago, @Monto" & _
        "); SELECT Id_Detalle_AP, Id_Planilla_Detalle, Id_Empleado, Numero, Tipo_Pago, Mo" & _
        "nto FROM Adelantos_Detalle WHERE (Id_Detalle_AP = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Planilla_Detalle", System.Data.SqlDbType.BigInt, 8, "Id_Planilla_Detalle"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 50, "Id_Empleado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Pago", System.Data.SqlDbType.Bit, 1, "Tipo_Pago"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Adelantos_Detalle SET Id_Planilla_Detalle = @Id_Planilla_Detalle, Id_Emple" & _
        "ado = @Id_Empleado, Numero = @Numero, Tipo_Pago = @Tipo_Pago, Monto = @Monto WHE" & _
        "RE (Id_Detalle_AP = @Original_Id_Detalle_AP) AND (Id_Empleado = @Original_Id_Emp" & _
        "leado) AND (Id_Planilla_Detalle = @Original_Id_Planilla_Detalle) AND (Monto = @O" & _
        "riginal_Monto) AND (Numero = @Original_Numero) AND (Tipo_Pago = @Original_Tipo_P" & _
        "ago); SELECT Id_Detalle_AP, Id_Planilla_Detalle, Id_Empleado, Numero, Tipo_Pago," & _
        " Monto FROM Adelantos_Detalle WHERE (Id_Detalle_AP = @Id_Detalle_AP)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Planilla_Detalle", System.Data.SqlDbType.BigInt, 8, "Id_Planilla_Detalle"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Empleado", System.Data.SqlDbType.VarChar, 50, "Id_Empleado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.BigInt, 8, "Numero"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo_Pago", System.Data.SqlDbType.Bit, 1, "Tipo_Pago"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle_AP", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle_AP", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Pago", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Detalle_AP", System.Data.SqlDbType.Int, 4, "Id_Detalle_AP"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Adelantos_Detalle WHERE (Id_Detalle_AP = @Original_Id_Detalle_AP) AND" & _
        " (Id_Empleado = @Original_Id_Empleado) AND (Id_Planilla_Detalle = @Original_Id_P" & _
        "lanilla_Detalle) AND (Monto = @Original_Monto) AND (Numero = @Original_Numero) A" & _
        "ND (Tipo_Pago = @Original_Tipo_Pago)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle_AP", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle_AP", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Empleado", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Empleado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Planilla_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Planilla_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Numero", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo_Pago", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Pago", System.Data.DataRowVersion.Original, Nothing))
        '
        'adAdelantos_Detalle
        '
        Me.adAdelantos_Detalle.DeleteCommand = Me.SqlDeleteCommand1
        Me.adAdelantos_Detalle.InsertCommand = Me.SqlInsertCommand1
        Me.adAdelantos_Detalle.SelectCommand = Me.SqlSelectCommand1
        Me.adAdelantos_Detalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Adelantos_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Detalle_AP", "Id_Detalle_AP"), New System.Data.Common.DataColumnMapping("Id_Planilla_Detalle", "Id_Planilla_Detalle"), New System.Data.Common.DataColumnMapping("Id_Empleado", "Id_Empleado"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Tipo_Pago", "Tipo_Pago"), New System.Data.Common.DataColumnMapping("Monto", "Monto")})})
        Me.adAdelantos_Detalle.UpdateCommand = Me.SqlUpdateCommand1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar"
        '
        'frmDescuento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 390)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "frmDescuento"
        Me.Text = "frmDescuento"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPlanilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDescuento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Cedula As String
        Me.DataGrid1.Update()
        Cedula = frmControlTiempo2.Id_Empleado

        Try   ' Trap Filter exceptions


            ' Restore persisted DataSource.
            With Me.DsPlanilla1.Tables(0)
                .DefaultView.RowFilter = "Select * from Adelantos_Detalle Where Id_Empleado = =@Cedula"
                If .DefaultView.Count > 0 Then

                    DataGrid1.DataSource = _
                       DsPlanilla1.Tables(0).DefaultView
                Else
                    MsgBox("No titles meet criteria.")
                End If
            End With

        Catch exg As Exception     ' Trap Filter exceptions.
            MsgBox(exg.ToString)
        End Try



        'Dim cnn As SqlConnection = Nothing
        'Dim dt As New DataTable
        'Dim cConexion As New Conexion
        'Dim funcion As New cFunciones
        'Dim Cedula As String
        ''Dentro de un Try/Catch por si se produce un error
        'Try
        '    Cedula = frmControlTiempo2.Id_Empleado

        '    'Obtenemos la cadena de conexión adecuada

        '    Dim sConn As String = GetSetting("SeeSoft", "Planilla", "CONEXION")
        '    cnn = New SqlConnection(sConn)
        '    cnn.Open()
        '    'Creamos el comando para la consulta

        '    Dim cmd As SqlCommand = New SqlCommand
        '    Dim sel As String = "SELECT Numero, Nombre, Adelanto, Prestamo, DeducirxPago FROM Adelantos where (Identificacion =@Cedula)"
        '    cmd.CommandText = sel
        '    cmd.Connection = cnn
        '    cmd.CommandType = CommandType.Text
        '    cmd.CommandTimeout = 90

        '    Dim da As New SqlDataAdapter
        '    da.SelectCommand = cmd
        '    da.Fill(Me.DsPlanilla1.Adelantos_Detalle)
        'Catch ex As System.Exception
        '    MsgBox(ex.ToString)
        'Finally

        '    If Not cnn Is Nothing Then
        '        cnn.Close()
        '    End If
        'End Try
    End Sub



End Class
