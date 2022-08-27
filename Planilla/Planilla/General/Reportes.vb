Public Class Reportes
    Inherits System.Windows.Forms.Form
    Dim TipoReporte As Integer

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Tipo As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        TipoReporte = Tipo
        If TipoReporte = 1 Then
            Label2.Text = "CAJA COSTARRICENSE DE SEGURO SOCIAL"
        End If
        If TipoReporte = 2 Then
            Label2.Text = "INSTITUTO NACIONAL DE SEGUROS"
        End If
        If TipoReporte = 3 Then
            Label2.Text = "PAGO DE AGUINALDOS"
        End If
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub
    'Public Sub New(ByVal Tipo As Boolean)
    '    MyBase.New()

    '    'El Diseñador de Windows Forms requiere esta llamada.
    '    InitializeComponent()
    '    TipoReporte = Tipo
    '    'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    'End Sub
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
    Friend WithEvents dtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Reportes))
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFechaInicio.Location = New System.Drawing.Point(64, 72)
        Me.dtFechaInicio.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaInicio.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtFechaInicio.Size = New System.Drawing.Size(85, 20)
        Me.dtFechaInicio.TabIndex = 66
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFechaFinal.Location = New System.Drawing.Point(168, 72)
        Me.dtFechaFinal.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFechaFinal.MinDate = New Date(1995, 1, 1, 0, 0, 0, 0)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtFechaFinal.Size = New System.Drawing.Size(85, 20)
        Me.dtFechaFinal.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(64, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Fecha Inicio:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(168, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(80, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 40)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Mostrar "
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(48, 48)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 23)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Reporte"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Reportes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(320, 189)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtFechaFinal)
        Me.Controls.Add(Me.dtFechaInicio)
        Me.Name = "Reportes"
        Me.Text = "Modulo de Reportes"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Reportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            If TipoReporte = 1 Then
                Dim Imprimir As New CCSS
                Dim visor As New frmVisorReportes
                Imprimir.SetParameterValue(0, dtFechaInicio.Text)
                Imprimir.SetParameterValue(1, dtFechaFinal.Text)
                visor.rptViewer.ReportSource = Imprimir
                Planilla.CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Imprimir)
                visor.Show()
            End If
            If TipoReporte = 2 Then
                Dim Imprimir As New INS
                Dim visor As New frmVisorReportes
                Imprimir.SetParameterValue(0, dtFechaInicio.Text)
                Imprimir.SetParameterValue(1, dtFechaFinal.Text)
                visor.rptViewer.ReportSource = Imprimir
                Planilla.CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Imprimir)
                visor.Show()
            End If
            If TipoReporte = 3 Then
                Dim Imprimir As New Aguinaldos
                Dim visor As New frmVisorReportes
                Imprimir.SetParameterValue(0, dtFechaInicio.Text)
                Imprimir.SetParameterValue(1, dtFechaFinal.Text)
                visor.rptViewer.ReportSource = Imprimir
                Planilla.CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Imprimir)
                visor.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Sub
End Class
