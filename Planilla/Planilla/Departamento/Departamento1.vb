Imports System.Data.SqlClient
Public Class Departamento1
    Inherits Plantilla

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
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NPorcentaje As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdentificador As System.Windows.Forms.TextBox
    Friend WithEvents rdebe As System.Windows.Forms.RadioButton
    Friend WithEvents rhaber As System.Windows.Forms.RadioButton
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaPreaviso As System.Windows.Forms.TextBox
    Friend WithEvents txtNombrePreaviso As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckVacaciones As System.Windows.Forms.CheckBox
    Friend WithEvents CheckCesantia As System.Windows.Forms.CheckBox
    Friend WithEvents CheckAguinaldo As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Departamento1))
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCuenta = New System.Windows.Forms.TextBox
        Me.NPorcentaje = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.rdebe = New System.Windows.Forms.RadioButton
        Me.rhaber = New System.Windows.Forms.RadioButton
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtIdentificador = New System.Windows.Forms.TextBox
        Me.lblCod = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCuentaPreaviso = New System.Windows.Forms.TextBox
        Me.txtNombrePreaviso = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckAguinaldo = New System.Windows.Forms.CheckBox
        Me.CheckCesantia = New System.Windows.Forms.CheckBox
        Me.CheckVacaciones = New System.Windows.Forms.CheckBox
        CType(Me.NPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(536, 32)
        Me.TituloModulo.TabIndex = 0
        Me.TituloModulo.Text = "Departamento"
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 441)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(536, 52)
        Me.ToolBar1.TabIndex = 17
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombre.Location = New System.Drawing.Point(16, 64)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(472, 13)
        Me.TxtNombre.TabIndex = 2
        Me.TxtNombre.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(80, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Departamento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(144, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Descripción:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(8, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Cuenta Contable:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Blue
        Me.txtDescripcion.Location = New System.Drawing.Point(144, 164)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(184, 13)
        Me.txtDescripcion.TabIndex = 12
        Me.txtDescripcion.Text = ""
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta.ForeColor = System.Drawing.Color.Blue
        Me.txtCuenta.Location = New System.Drawing.Point(8, 164)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(128, 13)
        Me.txtCuenta.TabIndex = 10
        Me.txtCuenta.Text = ""
        '
        'NPorcentaje
        '
        Me.NPorcentaje.DecimalPlaces = 2
        Me.NPorcentaje.Location = New System.Drawing.Point(344, 120)
        Me.NPorcentaje.Name = "NPorcentaje"
        Me.NPorcentaje.Size = New System.Drawing.Size(48, 20)
        Me.NPorcentaje.TabIndex = 8
        Me.NPorcentaje.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(328, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "%"
        '
        'rdebe
        '
        Me.rdebe.Checked = True
        Me.rdebe.Location = New System.Drawing.Point(336, 140)
        Me.rdebe.Name = "rdebe"
        Me.rdebe.Size = New System.Drawing.Size(56, 24)
        Me.rdebe.TabIndex = 13
        Me.rdebe.TabStop = True
        Me.rdebe.Text = "Debe"
        '
        'rhaber
        '
        Me.rhaber.Location = New System.Drawing.Point(336, 164)
        Me.rhaber.Name = "rhaber"
        Me.rhaber.Size = New System.Drawing.Size(56, 24)
        Me.rhaber.TabIndex = 14
        Me.rhaber.Text = "Haber"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(176, 184)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Agregar"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(8, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Nombre Identificador"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIdentificador
        '
        Me.txtIdentificador.BackColor = System.Drawing.Color.White
        Me.txtIdentificador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdentificador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdentificador.ForeColor = System.Drawing.Color.Blue
        Me.txtIdentificador.Location = New System.Drawing.Point(136, 120)
        Me.txtIdentificador.Name = "txtIdentificador"
        Me.txtIdentificador.Size = New System.Drawing.Size(176, 13)
        Me.txtIdentificador.TabIndex = 6
        Me.txtIdentificador.Text = ""
        '
        'lblCod
        '
        Me.lblCod.Location = New System.Drawing.Point(408, 424)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(64, 16)
        Me.lblCod.TabIndex = 16
        Me.lblCod.Text = "0"
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.OldLace
        Me.DataGrid1.BackColor = System.Drawing.Color.OldLace
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Tan
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.SaddleBrown
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.OldLace
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DataGrid1.GridLineColor = System.Drawing.Color.Tan
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.Wheat
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.SaddleBrown
        Me.DataGrid1.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DataGrid1.Location = New System.Drawing.Point(0, 215)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.OldLace
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.DarkSlateGray
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGrid1.Size = New System.Drawing.Size(528, 200)
        Me.DataGrid1.TabIndex = 210
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cuenta Preaviso:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCuentaPreaviso
        '
        Me.txtCuentaPreaviso.BackColor = System.Drawing.Color.White
        Me.txtCuentaPreaviso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCuentaPreaviso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaPreaviso.ForeColor = System.Drawing.Color.Blue
        Me.txtCuentaPreaviso.Location = New System.Drawing.Point(120, 80)
        Me.txtCuentaPreaviso.Name = "txtCuentaPreaviso"
        Me.txtCuentaPreaviso.Size = New System.Drawing.Size(128, 13)
        Me.txtCuentaPreaviso.TabIndex = 4
        Me.txtCuentaPreaviso.Text = ""
        '
        'txtNombrePreaviso
        '
        Me.txtNombrePreaviso.BackColor = System.Drawing.Color.White
        Me.txtNombrePreaviso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombrePreaviso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombrePreaviso.Enabled = False
        Me.txtNombrePreaviso.ForeColor = System.Drawing.Color.Blue
        Me.txtNombrePreaviso.Location = New System.Drawing.Point(256, 80)
        Me.txtNombrePreaviso.Name = "txtNombrePreaviso"
        Me.txtNombrePreaviso.ReadOnly = True
        Me.txtNombrePreaviso.Size = New System.Drawing.Size(232, 13)
        Me.txtNombrePreaviso.TabIndex = 5
        Me.txtNombrePreaviso.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckAguinaldo)
        Me.GroupBox1.Controls.Add(Me.CheckCesantia)
        Me.GroupBox1.Controls.Add(Me.CheckVacaciones)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(400, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 88)
        Me.GroupBox1.TabIndex = 211
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Retención"
        '
        'CheckAguinaldo
        '
        Me.CheckAguinaldo.Location = New System.Drawing.Point(16, 64)
        Me.CheckAguinaldo.Name = "CheckAguinaldo"
        Me.CheckAguinaldo.Size = New System.Drawing.Size(88, 16)
        Me.CheckAguinaldo.TabIndex = 2
        Me.CheckAguinaldo.Text = "Aguinaldo"
        '
        'CheckCesantia
        '
        Me.CheckCesantia.Location = New System.Drawing.Point(16, 40)
        Me.CheckCesantia.Name = "CheckCesantia"
        Me.CheckCesantia.Size = New System.Drawing.Size(88, 16)
        Me.CheckCesantia.TabIndex = 1
        Me.CheckCesantia.Text = "Cesantía"
        '
        'CheckVacaciones
        '
        Me.CheckVacaciones.Location = New System.Drawing.Point(16, 16)
        Me.CheckVacaciones.Name = "CheckVacaciones"
        Me.CheckVacaciones.Size = New System.Drawing.Size(88, 16)
        Me.CheckVacaciones.TabIndex = 0
        Me.CheckVacaciones.Text = "Vacaciones"
        '
        'Departamento1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 493)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNombrePreaviso)
        Me.Controls.Add(Me.txtCuentaPreaviso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.txtIdentificador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.rhaber)
        Me.Controls.Add(Me.rdebe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NPorcentaje)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Departamento1"
        Me.Text = "Departamento1"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.NPorcentaje, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.rdebe, 0)
        Me.Controls.SetChildIndex(Me.rhaber, 0)
        Me.Controls.SetChildIndex(Me.btnAgregar, 0)
        Me.Controls.SetChildIndex(Me.TxtNombre, 0)
        Me.Controls.SetChildIndex(Me.txtCuenta, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtIdentificador, 0)
        Me.Controls.SetChildIndex(Me.lblCod, 0)
        Me.Controls.SetChildIndex(Me.DataGrid1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtCuentaPreaviso, 0)
        Me.Controls.SetChildIndex(Me.txtNombrePreaviso, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        CType(Me.NPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variables "
    Dim cConexion As New Conexion
    Dim sqlConexion As New SqlConnection
#End Region

    Private Sub Departamento1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCod.Text = 0
        sqlConexion = cConexion.Conectar("Planilla")
        CargarVisor()
    End Sub

    Private Sub Limpia()
        Me.CheckCesantia.Checked = False
        Me.CheckVacaciones.Checked = False
        Me.CheckAguinaldo.Checked = False
    End Sub

    Private Sub txtCuentaContableSalario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuenta.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim busca As New fmrBuscarMayorizacionAsiento
            busca.NuevaConexion = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
            busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
    " where Movimiento=1 " '"select CuentaContable AS [Codigo cuenta],descripcion as Descripcion from Contabilidad.dbo.CuentaContable where  Movimiento = 1  "
            busca.campo = "descripcion"
            busca.sqlStringAdicional = " ORDER BY CuentaContable  "
            busca.ShowDialog()

            If busca.codigo Is Nothing Then Exit Sub

            txtCuenta.Text = busca.codigo
            txtDescripcion.Text = busca.descrip



        End If

        If e.KeyCode = Keys.Enter Then
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = Me.txtCuenta.Text
            valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then
                MessageBox.Show("La cuenta contable digitada no esta registrada..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtCuenta.Focus()
            Else
                Dim nombre As String
                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                Me.txtDescripcion.Text = nombre
                Me.btnAgregar.Focus()

            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If Trim(TxtNombre.Text) = vbNullString Then
            MessageBox.Show("Digite el nombre del departamento", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.CheckAguinaldo.Checked = True Or Me.CheckCesantia.Checked = True Or Me.CheckVacaciones.Checked = True Then
            If CompruebaRetencion() Then
                MsgBox("Ya existe una cuenta seleccionada con esta Retención", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        Dim sConsulta, resultado As String
        Dim tipo, Cesantia, Vacaciones, Aguinaldo As Integer

        If rdebe.Checked = True Then
            tipo = 1
        Else
            tipo = 0
        End If

        If Me.CheckCesantia.Checked = True Then
            Cesantia = 1
            Vacaciones = 0
            Aguinaldo = 0
        ElseIf Me.CheckVacaciones.Checked = True Then
            Cesantia = 0
            Vacaciones = 1
            Aguinaldo = 0
        ElseIf Me.CheckAguinaldo.Checked = True Then
            Cesantia = 0
            Vacaciones = 0
            Aguinaldo = 1
        End If

        If lblCod.Text = 0 Then

            sConsulta = "if not exists (select departamento from departamento where departamento = '" & TxtNombre.Text & "') " & _
                            "begin " & _
                            "Insert into departamento (departamento, CuentaPreaviso, NCuentaPreaviso) values ('" & TxtNombre.Text & "','" & txtCuenta.Text & "','" & txtNombrePreaviso.Text & "')" & _
                            "select max(id)from departamento " & _
                            "end"
            resultado = cConexion.SlqExecuteScalar(sqlConexion, sConsulta)
        End If



        If Not IsNothing(resultado) Then
            lblCod.Text = resultado
        End If

        sConsulta = "if not exists (SELECT item FROM ligueAsiento where item= '" & txtIdentificador.Text & "' and idDepartamento=" & lblCod.Text & ")" & _
                    " insert into ligueAsiento (idDepartamento,item,cuentaContable,debe,porcentaje,Cesantia,Vacaciones,Aguinaldo) values (" & lblCod.Text & ",'" & txtIdentificador.Text & "','" & txtCuenta.Text & "'," & tipo & "," & NPorcentaje.Value & "," & Cesantia & "," & Vacaciones & "," & Aguinaldo & ")"


        cConexion.SlqExecute(sqlConexion, sConsulta)



        CargarVisor()
        Me.txtIdentificador.Focus()
        Limpia()
    End Sub

    Private Sub CargarVisor()
        Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter("select l.idLigueAsiento as i, l.item as Nombre,l.CuentaContable,cc.descripcion as Descripcion,l.debe,l.Porcentaje,l.Cesantia,l.Vacaciones,l.Aguinaldo from ligueAsiento as l, contabilidad.dbo.cuentaContable as cc where cc.cuentaContable = l.CuentaContable COLLATE Traditional_Spanish_CI_AS and idDepartamento =" & lblCod.Text, sqlConexion)
        Dim ds As DataSet = New DataSet
        myCommand1.Fill(ds, "Departamento")
        DataGrid1.DataSource = ds.Tables(0)
        ds = Nothing

    End Sub

    Private Sub Departamento1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        cConexion.SlqExecute(sqlConexion, "Delete from departamento where activo=0 delete from ligueAsiento where activo=0")
        cConexion.DesConectar(sqlConexion)
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1

            Case 1 : Nuevo()

            Case 2 : Buscar()

            Case 3 : Guardar()

            Case 4 : Eliminar()

            Case 7 : Close()

        End Select
    End Sub

    Private Sub Nuevo()
        lblCod.Text = 0
        txtCuenta.Clear()
        txtDescripcion.Clear()
        txtIdentificador.Clear()
        TxtNombre.Clear()
        NPorcentaje.Value = 0
        rdebe.Checked = True
        CargarVisor()
    End Sub

    Private Sub Buscar()
        Dim funcion As New cFunciones
        Dim Id As Integer
        Dim Conex As String = GetSetting("SeeSoft", "Planilla", "Conexion")

        'Try
        Id = funcion.BuscarDatos("Select id as Identificador, Departamento as Nombre from Departamento", "Departamento", "Buscar Departamento ...", Conex)
        lblCod.Text = Id
        TxtNombre.Text = funcion.descripcion
        txtCuentaPreaviso.Text = cConexion.SlqExecuteScalar(sqlConexion, "Select CuentaPreaviso from Departamento where id=" & Id)
        txtNombrePreaviso.Text = cConexion.SlqExecuteScalar(sqlConexion, "Select NCuentaPreaviso from Departamento  where id=" & Id)

        CargarVisor()
        If Id = 0 Then ' si se dio en el boton de cancelar
            Exit Sub
        End If

    End Sub

    Private Sub Guardar()

        cConexion.SlqExecute(sqlConexion, "Update ligueAsiento set activo=1 where activo=0")
        cConexion.SlqExecute(sqlConexion, "Update departamento set activo=1 where activo=0")

        If lblCod.Text <> 0 Then
            cConexion.SlqExecute(sqlConexion, "Update departamento set departamento= '" & TxtNombre.Text & "',CuentaPreaviso='" & txtCuentaPreaviso.Text & "',NCuentaPreaviso='" & txtNombrePreaviso.Text & "' where id=" & lblCod.Text)
        End If


        MessageBox.Show("Registro exitoso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    Private Sub Eliminar()
        cConexion.SlqExecute(sqlConexion, "Delete from ligueAsiento where idDepartamento=" & lblCod.Text)
        cConexion.SlqExecute(sqlConexion, "Delete from departamento where id=" & lblCod.Text)
        MessageBox.Show("Departamento Eliminado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Nuevo()
    End Sub


    Private Sub TxtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNombre.KeyDown
        If e.KeyCode = Keys.F1 Then
            Buscar()
        End If
    End Sub


    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress, txtIdentificador.KeyPress, NPorcentaje.KeyPress, NPorcentaje.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub DataGrid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGrid1.KeyDown
        If e.KeyCode = Keys.Delete Then
            cConexion.SlqExecute(sqlConexion, "Delete from ligueAsiento where idLigueAsiento=" & DataGrid1(DataGrid1.CurrentRowIndex, 0))
            cConexion.SlqExecute(sqlConexion, "Delete from departamento where idLigueAsiento=" & DataGrid1(DataGrid1.CurrentRowIndex, 0))
            CargarVisor()
        End If
    End Sub

    Private Sub txtIdentificador_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdentificador.GotFocus
        Me.txtIdentificador.SelectAll()
    End Sub

    Private Sub NPorcentaje_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NPorcentaje.GotFocus
        Me.NPorcentaje.Select(0, 6)
    End Sub

    Private Sub rdebe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdebe.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtCuenta.Focus()
        End If
    End Sub

    Private Sub txtCuenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuenta.GotFocus
        Me.txtCuenta.SelectAll()
    End Sub

    Private Sub rhaber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rhaber.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtCuenta.Focus()
        End If
    End Sub

    Private Sub txtCuentaPreaviso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaPreaviso.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim busca As New fmrBuscarMayorizacionAsiento
            busca.NuevaConexion = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
            busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
    " where Movimiento=1 " '"select CuentaContable AS [Codigo cuenta],descripcion as Descripcion from Contabilidad.dbo.CuentaContable where  Movimiento = 1  "
            busca.campo = "descripcion"
            busca.sqlStringAdicional = " ORDER BY CuentaContable  "
            busca.ShowDialog()

            If busca.codigo Is Nothing Then Exit Sub

            txtCuentaPreaviso.Text = busca.codigo
            txtNombrePreaviso.Text = busca.descrip
        End If

        If e.KeyCode = Keys.Enter Then
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = Me.txtCuentaPreaviso.Text
            valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then
                MessageBox.Show("La cuenta contable digitada no esta registrada..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.txtCuenta.Focus()
            Else
                Dim nombre As String
                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                txtNombrePreaviso.Text = nombre
                txtIdentificador.Focus()
            End If
        End If
    End Sub

    Function CompruebaRetencion() As Boolean
        Dim Conexion As New Conexion
        Dim rs As SqlDataReader

        CompruebaRetencion = False
        If Me.CheckCesantia.Checked = True Or Me.CheckAguinaldo.Checked = True Or Me.CheckVacaciones.Checked = True Then
            rs = Conexion.GetRecorset(Conexion.Conectar("Planilla"), "SELECT Cesantia,Vacaciones,Aguinaldo From LigueAsiento where idDepartamento = " & CInt(lblCod.Text))
            While rs.Read
                Try
                    If Me.CheckAguinaldo.Checked = True Then
                        If rs("Aguinaldo") = True Then
                            CompruebaRetencion = True
                        End If

                    ElseIf Me.CheckCesantia.Checked = True Then
                        If rs("Cesantia") = True Then
                            CompruebaRetencion = True
                        End If

                    ElseIf Me.CheckVacaciones.Checked = True Then
                        If rs("Vacaciones") = True Then
                            CompruebaRetencion = True
                        End If
                    End If
                Catch ex As SystemException
                    MsgBox(ex.Message)
                End Try
            End While
            rs.Close()
            Conexion.DesConectar(Conexion.Conectar)
        End If
    End Function

#Region "CheckedChanged"
    Private Sub CheckAguinaldo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckAguinaldo.CheckedChanged
        If Me.CheckCesantia.Checked = True Or Me.CheckVacaciones.Checked = True Then
            Me.CheckCesantia.Checked = False
            Me.CheckVacaciones.Checked = False
        End If
    End Sub

    Private Sub CheckCesantia_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckCesantia.CheckedChanged
        If Me.CheckAguinaldo.Checked = True Or Me.CheckVacaciones.Checked = True Then
            Me.CheckAguinaldo.Checked = False
            Me.CheckVacaciones.Checked = False
        End If
    End Sub

    Private Sub CheckVacaciones_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckVacaciones.CheckedChanged
        If Me.CheckAguinaldo.Checked = True Or Me.CheckCesantia.Checked = True Then
            Me.CheckAguinaldo.Checked = False
            Me.CheckCesantia.Checked = False
        End If
    End Sub
#End Region


End Class
