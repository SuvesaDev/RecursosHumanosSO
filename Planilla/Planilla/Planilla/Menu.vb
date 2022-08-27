Imports System.data.SqlClient
Imports Utilidades.Seguridad

Public Class MenuPlanilla
    Inherits System.Windows.Forms.Form
    Public Shared Control As Integer
    Dim Contador As Integer
    Dim EnEspera As New DevExpress.Utils.WaitDialogForm
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal Usuario_Parametro)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItemDeducciones As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAumentos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemDepartamentos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemEstadosdelEmpleado As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemEmpleados As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemParametrosRenta As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAcciones As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAdelantosPrestamos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAccionPersonal As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemComprobantePagos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLiquidacionLaboral As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteVacaciones As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteCCSS As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteINS As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteAdelantos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReportePagoAguinaldos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteAccionPersonal As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MenuPlanilla))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItemDeducciones = New System.Windows.Forms.MenuItem
        Me.MenuItemAumentos = New System.Windows.Forms.MenuItem
        Me.MenuItemDepartamentos = New System.Windows.Forms.MenuItem
        Me.MenuItemEstadosdelEmpleado = New System.Windows.Forms.MenuItem
        Me.MenuItemEmpleados = New System.Windows.Forms.MenuItem
        Me.MenuItemParametrosRenta = New System.Windows.Forms.MenuItem
        Me.MenuItemAcciones = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItemAdelantosPrestamos = New System.Windows.Forms.MenuItem
        Me.MenuItemAccionPersonal = New System.Windows.Forms.MenuItem
        Me.MenuItemComprobantePagos = New System.Windows.Forms.MenuItem
        Me.MenuItemLiquidacionLaboral = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItemReporteVacaciones = New System.Windows.Forms.MenuItem
        Me.MenuItemReporteCCSS = New System.Windows.Forms.MenuItem
        Me.MenuItemReporteINS = New System.Windows.Forms.MenuItem
        Me.MenuItemReporteAdelantos = New System.Windows.Forms.MenuItem
        Me.MenuItemReportePagoAguinaldos = New System.Windows.Forms.MenuItem
        Me.MenuItemReporteAccionPersonal = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem20})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemDeducciones, Me.MenuItemAumentos, Me.MenuItemDepartamentos, Me.MenuItemEstadosdelEmpleado, Me.MenuItemEmpleados, Me.MenuItemParametrosRenta, Me.MenuItemAcciones, Me.MenuItem4})
        Me.MenuItem1.Text = "Mantenimientos"
        '
        'MenuItemDeducciones
        '
        Me.MenuItemDeducciones.Index = 0
        Me.MenuItemDeducciones.Text = "Deducciones"
        '
        'MenuItemAumentos
        '
        Me.MenuItemAumentos.Index = 1
        Me.MenuItemAumentos.Text = "Aumentos"
        '
        'MenuItemDepartamentos
        '
        Me.MenuItemDepartamentos.Index = 2
        Me.MenuItemDepartamentos.Text = "Departamentos"
        '
        'MenuItemEstadosdelEmpleado
        '
        Me.MenuItemEstadosdelEmpleado.Index = 3
        Me.MenuItemEstadosdelEmpleado.Text = "Estados del Empleado"
        '
        'MenuItemEmpleados
        '
        Me.MenuItemEmpleados.Index = 4
        Me.MenuItemEmpleados.Text = "Empleados"
        '
        'MenuItemParametrosRenta
        '
        Me.MenuItemParametrosRenta.Index = 5
        Me.MenuItemParametrosRenta.Text = "Parámetros de Renta"
        '
        'MenuItemAcciones
        '
        Me.MenuItemAcciones.Index = 6
        Me.MenuItemAcciones.Text = "Acciones"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 7
        Me.MenuItem4.Text = "Horas Ordinarias"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemAdelantosPrestamos, Me.MenuItemAccionPersonal, Me.MenuItemComprobantePagos, Me.MenuItemLiquidacionLaboral, Me.MenuItem5})
        Me.MenuItem2.Text = "Transacciones"
        '
        'MenuItemAdelantosPrestamos
        '
        Me.MenuItemAdelantosPrestamos.Index = 0
        Me.MenuItemAdelantosPrestamos.Text = "Adelantos o Préstamos"
        '
        'MenuItemAccionPersonal
        '
        Me.MenuItemAccionPersonal.Index = 1
        Me.MenuItemAccionPersonal.Text = "Acción de Personal"
        '
        'MenuItemComprobantePagos
        '
        Me.MenuItemComprobantePagos.Index = 2
        Me.MenuItemComprobantePagos.Text = "Comprobantes de Pago"
        '
        'MenuItemLiquidacionLaboral
        '
        Me.MenuItemLiquidacionLaboral.Index = 3
        Me.MenuItemLiquidacionLaboral.Text = "Liquidación Laboral"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Modificar Planilla"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemReporteVacaciones, Me.MenuItemReporteCCSS, Me.MenuItemReporteINS, Me.MenuItemReporteAdelantos, Me.MenuItemReportePagoAguinaldos, Me.MenuItemReporteAccionPersonal})
        Me.MenuItem3.Text = "Reportes"
        '
        'MenuItemReporteVacaciones
        '
        Me.MenuItemReporteVacaciones.Index = 0
        Me.MenuItemReporteVacaciones.Text = "Vacaciones"
        '
        'MenuItemReporteCCSS
        '
        Me.MenuItemReporteCCSS.Index = 1
        Me.MenuItemReporteCCSS.Text = "C.C.S.S."
        '
        'MenuItemReporteINS
        '
        Me.MenuItemReporteINS.Index = 2
        Me.MenuItemReporteINS.Text = "I.N.S."
        '
        'MenuItemReporteAdelantos
        '
        Me.MenuItemReporteAdelantos.Index = 3
        Me.MenuItemReporteAdelantos.Text = "Adelantos"
        '
        'MenuItemReportePagoAguinaldos
        '
        Me.MenuItemReportePagoAguinaldos.Index = 4
        Me.MenuItemReportePagoAguinaldos.Text = "Pago Aguinaldos"
        '
        'MenuItemReporteAccionPersonal
        '
        Me.MenuItemReporteAccionPersonal.Index = 5
        Me.MenuItemReporteAccionPersonal.Text = "Acción Personal"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        Me.MenuItem20.Text = "Salir"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 150
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
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
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton7, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton3, Me.ToolBarButton6, Me.ToolBarButton8, Me.ToolBarButton9, Me.ToolBarButton10})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(728, 58)
        Me.ToolBar1.TabIndex = 16
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 9
        Me.ToolBarButton1.Text = "Deducciones"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 12
        Me.ToolBarButton2.Text = "Aumentos"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 10
        Me.ToolBarButton7.Text = "Departamentos"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 13
        Me.ToolBarButton4.Text = "Estados"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 18
        Me.ToolBarButton5.Text = "Empleados"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 11
        Me.ToolBarButton3.Text = "Parametros"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 20
        Me.ToolBarButton6.Text = "Acciones"
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.ImageIndex = 19
        Me.ToolBarButton8.Text = "Adelantos"
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 0
        Me.ToolBarButton9.Text = "Comprobantes"
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.ImageIndex = 8
        Me.ToolBarButton10.Text = "Liquidación"
        '
        'MenuPlanilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(728, 454)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "MenuPlanilla"
        Me.Text = "Menu Planilla"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CargarForm(ByRef Form As Form)
        Utilidades.Seguridad.RSM(Form.Name, Form.Text)
        Try
            Form.MdiParent = Me
            Form.StartPosition = FormStartPosition.CenterScreen
            Form.Left = (Screen.PrimaryScreen.WorkingArea.Width - Form.Width) \ 2
            Form.Top = (Screen.PrimaryScreen.WorkingArea.Height - Form.Height) \ 2

            Form.Show()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDeducciones.Click
        CargarForm(New Deducciones(Usuario))
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDepartamentos.Click
        CargarForm(New Departamento(Usuario))
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemEstadosdelEmpleado.Click
        CargarForm(New frmEstadoEmpleado(Usuario))
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemEmpleados.Click
        CargarForm(New FrmEmpleado(Usuario))
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemParametrosRenta.Click
        CargarForm(New ImpuestoRenta)
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAdelantosPrestamos.Click
        CargarForm(New frmAdelantos(Usuario))
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAccionPersonal.Click
        CargarForm(New AccionPersonal(Usuario))
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAcciones.Click
        CargarForm(New Accion(Usuario))
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemComprobantePagos.Click
        Dim frm1 As New frmControlTiempo2(Usuario)
        frm1.Show()
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Me.Close()
        'CargarForm(New HorasTrabajadas(Usuario))
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteCCSS.Click
        CargarForm(New Reportes(1))
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteINS.Click
        CargarForm(New Reportes(2))
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteAdelantos.Click
        Dim Imprimir As New Adelantos
        Dim visor As New frmVisorReportes
        visor.rptViewer.ReportSource = Imprimir
        Planilla.CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Imprimir)
        visor.Show()
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReportePagoAguinaldos.Click
        CargarForm(New Reportes(3))
    End Sub


    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemLiquidacionLaboral.Click
        CargarForm(New LiquidacionLaboral(Usuario))
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteAccionPersonal.Click
        CargarForm(New ReportesAccion)
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteVacaciones.Click
        CargarForm(New ReportesVacaciones)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Text = Microsoft.VisualBasic.Mid("SISTEMAS ESTRUCTURALES - MODULO: PLANILLA - HOTEL ARENAL MANOA   ", 1, Contador)
        Contador = Contador + 1
        If Contador = Microsoft.VisualBasic.Len("SISTEMAS ESTRUCTURALES - MODULO: PLANILLA - HOTEL ARENAL MANOA    ") Then Contador = 1
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New Frmusuario)
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New FrmConfiguración)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Menu_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim imagen As New Drawing.Bitmap(Me.PictureBox1.Image, Me.Width, Me.Height)
        Me.BackgroundImage = imagen

    End Sub

    Private Sub MenuItem15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAumentos.Click
        CargarForm(New frmAumentos)
    End Sub

    Private Sub MenuPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EnEspera.Caption = "Habilitando accesos a módulos autorisados..."
        EnEspera.Text = "Acceso a Sistema."
        EnEspera.Show()
        'If Environment.GetCommandLineArgs(1).ToString.ToUpper <> "SETTING" Then
        MenuItemDeducciones.Enabled = VerificandoAcceso_a_Modulos(New Deducciones(Usuario), Usuario.Cedula)


        MenuItemAumentos.Enabled = VerificandoAcceso_a_Modulos(New frmAumentos, Usuario.Cedula)


        MenuItemDepartamentos.Enabled = VerificandoAcceso_a_Modulos(New Departamento(Usuario), Usuario.Cedula)
        MenuItemEstadosdelEmpleado.Enabled = VerificandoAcceso_a_Modulos(New frmEstadoEmpleado(Usuario), Usuario.Cedula)
        MenuItemEmpleados.Enabled = VerificandoAcceso_a_Modulos(New FrmEmpleado(Usuario), Usuario.Cedula)
        MenuItemParametrosRenta.Enabled = VerificandoAcceso_a_Modulos(New ImpuestoRenta, Usuario.Cedula)
        MenuItemAcciones.Enabled = VerificandoAcceso_a_Modulos(New Accion(Usuario), Usuario.Cedula)

        MenuItemAdelantosPrestamos.Enabled = VerificandoAcceso_a_Modulos(New frmAdelantos(Usuario), Usuario.Cedula)


        MenuItemAccionPersonal.Enabled = VerificandoAcceso_a_Modulos(New AccionPersonal(Usuario), Usuario.Cedula)
        MenuItemComprobantePagos.Enabled = VerificandoAcceso_a_Modulos(New frmControlTiempo2(Usuario), Usuario.Cedula)
        MenuItemLiquidacionLaboral.Enabled = VerificandoAcceso_a_Modulos(New LiquidacionLaboral(Usuario), Usuario.Cedula)

        MenuItemReporteVacaciones.Enabled = VerificandoAcceso_a_Modulos(New ReportesVacaciones, Usuario.Cedula)
        MenuItemReporteCCSS.Enabled = VerificandoAcceso_a_Modulos(New Reportes(1), Usuario.Cedula)
        MenuItemReporteINS.Enabled = VerificandoAcceso_a_Modulos(New Reportes(2), Usuario.Cedula)
        MenuItem5.Enabled = VerificandoAcceso_a_Modulos(New frmModificaPlanilla(Usuario), Usuario.Cedula)
        MenuItemReportePagoAguinaldos.Enabled = VerificandoAcceso_a_Modulos(New Reportes(3), Usuario.Cedula)
        MenuItemReporteAccionPersonal.Enabled = VerificandoAcceso_a_Modulos(New ReportesAccion, Usuario.Cedula)

        MenuItem20.Enabled = VerificandoAcceso_a_Modulos(New HorasTrabajadas(Usuario), Usuario.Cedula)
        'End If
        EnEspera.Close()
        '
        If MenuItemDeducciones.Enabled = False Then
            ToolBarButton1.Enabled = False
        End If

        If MenuItemAumentos.Enabled = False Then
            ToolBarButton2.Enabled = False
        End If

        If MenuItemDepartamentos.Enabled = False Then
            ToolBarButton7.Enabled = False
        End If

        If MenuItemEstadosdelEmpleado.Enabled = False Then
            ToolBarButton4.Enabled = False
        End If

        If MenuItemEmpleados.Enabled = False Then
            ToolBarButton5.Enabled = False
        End If

        If MenuItemParametrosRenta.Enabled = False Then
            ToolBarButton3.Enabled = False
        End If

        If MenuItemAcciones.Enabled = False Then
            ToolBarButton6.Enabled = False
        End If

        If MenuItemAdelantosPrestamos.Enabled = False Then
            ToolBarButton8.Enabled = False
        End If

        If MenuItemComprobantePagos.Enabled = False Then
            ToolBarButton9.Enabled = False
        End If

        If MenuItemLiquidacionLaboral.Enabled = False Then
            ToolBarButton10.Enabled = False
        End If
        '
    End Sub

#Region "ToolBar"

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : CargarForm(New Deducciones(Usuario))

            Case 2 : CargarForm(New frmAumentos)

            Case 3 : CargarForm(New Departamento(Usuario))

            Case 4 : CargarForm(New frmEstadoEmpleado(Usuario))

            Case 5 : CargarForm(New FrmEmpleado(Usuario))

            Case 6 : CargarForm(New ImpuestoRenta)

            Case 7 : CargarForm(New Accion(Usuario))

            Case 8 : CargarForm(New frmAdelantos(Usuario))

            Case 9
                Dim frm2 As New frmControlTiempo2(Usuario)
                frm2.Show()
                'Dim frm As New frmControl3
                'frm.Show()

            Case 10 : CargarForm(New LiquidacionLaboral(Usuario))
        End Select

    End Sub
#End Region

    Private Sub MenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        CargarForm(New ConfiguracionHorasOrdinarias)
    End Sub

    Private Sub MenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        CargarForm(New frmModificaPlanilla(Usuario))
    End Sub
End Class
