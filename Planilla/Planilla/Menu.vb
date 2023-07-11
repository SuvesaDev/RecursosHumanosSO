Imports System.data.SqlClient
Imports Utilidades.Seguridad

Public Class MenuPlanilla
    Inherits System.Windows.Forms.Form
    Public Shared Control As Integer
    Dim Contador As Integer
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
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
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem_Prestamos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPlanilla))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItemDeducciones = New System.Windows.Forms.MenuItem()
        Me.MenuItemAumentos = New System.Windows.Forms.MenuItem()
        Me.MenuItemDepartamentos = New System.Windows.Forms.MenuItem()
        Me.MenuItemEstadosdelEmpleado = New System.Windows.Forms.MenuItem()
        Me.MenuItemEmpleados = New System.Windows.Forms.MenuItem()
        Me.MenuItemParametrosRenta = New System.Windows.Forms.MenuItem()
        Me.MenuItemAcciones = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItemAdelantosPrestamos = New System.Windows.Forms.MenuItem()
        Me.MenuItemAccionPersonal = New System.Windows.Forms.MenuItem()
        Me.MenuItemComprobantePagos = New System.Windows.Forms.MenuItem()
        Me.MenuItemLiquidacionLaboral = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteVacaciones = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteCCSS = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteINS = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteAdelantos = New System.Windows.Forms.MenuItem()
        Me.MenuItem_Prestamos = New System.Windows.Forms.MenuItem()
        Me.MenuItemReportePagoAguinaldos = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteAccionPersonal = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem7})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemDeducciones, Me.MenuItemAumentos, Me.MenuItemDepartamentos, Me.MenuItemEstadosdelEmpleado, Me.MenuItemEmpleados, Me.MenuItemParametrosRenta, Me.MenuItemAcciones, Me.MenuItem4, Me.MenuItem16})
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
        Me.MenuItemEstadosdelEmpleado.Visible = False
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
        Me.MenuItem4.Text = "Horas Ordinarias "
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 8
        Me.MenuItem16.Text = "Nacionalidad"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemAdelantosPrestamos, Me.MenuItemAccionPersonal, Me.MenuItemComprobantePagos, Me.MenuItemLiquidacionLaboral, Me.MenuItem5, Me.MenuItem6, Me.MenuItem17, Me.MenuItem20})
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
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "Pago Planilla Automática Banco"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 6
        Me.MenuItem17.Text = "Pago Automático Aguinaldos"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 7
        Me.MenuItem20.Text = "Aguinaldo"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemReporteVacaciones, Me.MenuItemReporteCCSS, Me.MenuItemReporteINS, Me.MenuItemReporteAdelantos, Me.MenuItem_Prestamos, Me.MenuItemReportePagoAguinaldos, Me.MenuItemReporteAccionPersonal, Me.MenuItem10, Me.MenuItem11, Me.MenuItem13, Me.MenuItem14, Me.MenuItem12, Me.MenuItem15, Me.MenuItem18})
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
        'MenuItem_Prestamos
        '
        Me.MenuItem_Prestamos.Index = 4
        Me.MenuItem_Prestamos.Text = "Prestamos"
        '
        'MenuItemReportePagoAguinaldos
        '
        Me.MenuItemReportePagoAguinaldos.Index = 5
        Me.MenuItemReportePagoAguinaldos.Text = "Pago Aguinaldos"
        Me.MenuItemReportePagoAguinaldos.Visible = False
        '
        'MenuItemReporteAccionPersonal
        '
        Me.MenuItemReporteAccionPersonal.Index = 6
        Me.MenuItemReporteAccionPersonal.Text = "Acción Personal"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 7
        Me.MenuItem10.Text = "Saldos Prestamos/Adelantos"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 8
        Me.MenuItem11.Text = "Empleados"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 9
        Me.MenuItem13.Text = "Certificación de Ingresos"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 10
        Me.MenuItem14.Text = "Ingresos por Empleado"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 11
        Me.MenuItem12.Text = "Claves de Empleado"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 12
        Me.MenuItem15.Text = " Marcas Por Empleado"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 13
        Me.MenuItem18.Text = "Control de Fonda"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 3
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem9, Me.MenuItem19})
        Me.MenuItem7.Text = "Interfaz"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.Text = "Respaldar BD"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.Text = "Salir"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 2
        Me.MenuItem19.Text = "Ver. 05/06/2023"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 150
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Planilla.My.Resources.Resources.wallpaper2you_290966
        Me.PictureBox1.Location = New System.Drawing.Point(0, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "005-analysis.png")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "003-debt.png")
        Me.ImageList1.Images.SetKeyName(9, "010-cost.png")
        Me.ImageList1.Images.SetKeyName(10, "002-skills.png")
        Me.ImageList1.Images.SetKeyName(11, "008-coupon.png")
        Me.ImageList1.Images.SetKeyName(12, "profit.png")
        Me.ImageList1.Images.SetKeyName(13, "003-price-tag.png")
        Me.ImageList1.Images.SetKeyName(14, "")
        Me.ImageList1.Images.SetKeyName(15, "")
        Me.ImageList1.Images.SetKeyName(16, "")
        Me.ImageList1.Images.SetKeyName(17, "")
        Me.ImageList1.Images.SetKeyName(18, "004-worker.png")
        Me.ImageList1.Images.SetKeyName(19, "009-payment.png")
        Me.ImageList1.Images.SetKeyName(20, "006-summer.png")
        Me.ImageList1.Images.SetKeyName(21, "010-cost.png")
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.ToolBarButton7, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton3, Me.ToolBarButton6, Me.ToolBarButton8, Me.ToolBarButton9, Me.ToolBarButton10})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(1170, 58)
        Me.ToolBar1.TabIndex = 16
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 9
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "Deducciones"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 12
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Text = "Aumentos"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 10
        Me.ToolBarButton7.Name = "ToolBarButton7"
        Me.ToolBarButton7.Text = "Departamentos"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 13
        Me.ToolBarButton4.Name = "ToolBarButton4"
        Me.ToolBarButton4.Text = "Estados"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 18
        Me.ToolBarButton5.Name = "ToolBarButton5"
        Me.ToolBarButton5.Text = "Empleados"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 11
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Text = "Parametros"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 20
        Me.ToolBarButton6.Name = "ToolBarButton6"
        Me.ToolBarButton6.Text = "Acciones"
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.ImageIndex = 19
        Me.ToolBarButton8.Name = "ToolBarButton8"
        Me.ToolBarButton8.Text = "Adelantos"
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 0
        Me.ToolBarButton9.Name = "ToolBarButton9"
        Me.ToolBarButton9.Text = "Comprobantes"
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.ImageIndex = 8
        Me.ToolBarButton10.Name = "ToolBarButton10"
        Me.ToolBarButton10.Text = "Liquidación"
        '
        'MenuPlanilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1170, 454)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "MenuPlanilla"
        Me.Text = "Menu Planilla"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub MenuPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EnEspera.Caption = "Habilitando accesos a módulos autorizados..."
        EnEspera.Text = "Acceso a Sistema."
        EnEspera.Show()
        EnEspera.Caption = "Validando Acceso a Planilla..."
        Me.Hide()

        EnEspera.Caption = "Módulos de Mantenimientos..."
        Application.DoEvents()
        MenuItem16.Enabled = VerificandoAcceso_a_Modulos("FrmNacionalidad", "Administrador de Nacionalidad", Usuario.Cedula, "Planilla")
        MenuItemDeducciones.Enabled = VerificandoAcceso_a_Modulos("Deducciones", "Deducciones", Usuario.Cedula, "Planilla")
        MenuItemAumentos.Enabled = VerificandoAcceso_a_Modulos("frmAumentos", "Aumentos", Usuario.Cedula, "Planilla")
        MenuItemDepartamentos.Enabled = VerificandoAcceso_a_Modulos("Departamento", "Departamentos", Usuario.Cedula, "Planilla")
        MenuItemEstadosdelEmpleado.Enabled = VerificandoAcceso_a_Modulos("frmEstadoEmpleado", "Estados de Empleados", Usuario.Cedula, "Planilla")
        MenuItemEmpleados.Enabled = VerificandoAcceso_a_Modulos("FrmEmpleado", "Empleado", Usuario.Cedula, "Planilla")
        MenuItemParametrosRenta.Enabled = VerificandoAcceso_a_Modulos("ImpuestoRenta", "Parametros Renta", Usuario.Cedula, "Planilla")
        MenuItemAcciones.Enabled = VerificandoAcceso_a_Modulos("Accion", "Acciones", Usuario.Cedula, "Planilla")
        MenuItem4.Enabled = VerificandoAcceso_a_Modulos("ConfiguracionHorasOrdinarias", "Configuracion Horas Ordinarias", Usuario.Cedula, "Planilla")
        EnEspera.Caption = "Módulos de Transaccciones..."
        Application.DoEvents()
        MenuItemAdelantosPrestamos.Enabled = VerificandoAcceso_a_Modulos("frmAdelantos", "Adelantos", Usuario.Cedula, "Planilla")
        MenuItemAccionPersonal.Enabled = VerificandoAcceso_a_Modulos("AccionPersonal", "Acciones de Personal", Usuario.Cedula, "Planilla")
        MenuItemComprobantePagos.Enabled = VerificandoAcceso_a_Modulos("frmControlTiempo2", "Comprobantes de Pago", Usuario.Cedula, "Planilla")
        MenuItemLiquidacionLaboral.Enabled = VerificandoAcceso_a_Modulos("LiquidacionLaboral", "Liquidación Laboral", Usuario.Cedula, "Planilla")
        MenuItem5.Enabled = VerificandoAcceso_a_Modulos("frmModificaPlanilla", "Modificar Planillas", Usuario.Cedula, "Planilla")
        MenuItem6.Enabled = VerificandoAcceso_a_Modulos("frmPagoAutomaticoBN", "Pagos Automaticos BN", Usuario.Cedula, "Planilla")

        EnEspera.Caption = "Módulos de Reportes..."
        Application.DoEvents()
        MenuItemReporteVacaciones.Enabled = VerificandoAcceso_a_Modulos("ReportesVacaciones", "Reportes de Vacaciones", Usuario.Cedula, "Planilla")
        MenuItemReporteCCSS.Enabled = VerificandoAcceso_a_Modulos("Reportes", "Reportes CCSS", Usuario.Cedula, "Planilla")
        MenuItemReporteINS.Enabled = VerificandoAcceso_a_Modulos("Reportes", "Reportes INS", Usuario.Cedula, "Planilla")
        MenuItemReporteAdelantos.Enabled = VerificandoAcceso_a_Modulos("Adelantos.rpt", "Reportes de Adelantos", Usuario.Cedula, "Planilla")
        MenuItem_Prestamos.Enabled = VerificandoAcceso_a_Modulos("FrmHistoricoPrestamo", "Historico de Prestamos", Usuario.Cedula, "Planilla")
        MenuItemReportePagoAguinaldos.Enabled = VerificandoAcceso_a_Modulos("Reportes", "Reporte Pago de Aguinaldos", Usuario.Cedula, "Planilla")
        MenuItemReporteAccionPersonal.Enabled = VerificandoAcceso_a_Modulos("ReportesAccion", "Reportes de Acciones", Usuario.Cedula, "Planilla")
        MenuItem10.Enabled = VerificandoAcceso_a_Modulos("RepSaldosAdelantos.rpt", "Saldos Prestamos/Adelantos", Usuario.Cedula, "Planilla")
        MenuItem11.Enabled = VerificandoAcceso_a_Modulos("FrmReporteEmpleado", "Reportes de Empleados", Usuario.Cedula, "Planilla")
        MenuItem13.Enabled = VerificandoAcceso_a_Modulos("FrmCertificacion", "Certificación de Ingresos", Usuario.Cedula, "Planilla")
        MenuItem14.Enabled = VerificandoAcceso_a_Modulos("FrmIngresosEmpleados", "Ingresos por Empleados", Usuario.Cedula, "Planilla")

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

        If MenuItemAccionPersonal.Enabled = False Then
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

        EnEspera.Close()
        Me.Show()
        '
    End Sub
#End Region

#Region "CargarForm"
    Private Sub CargarForm(ByRef Form As Form)
        Utilidades.Seguridad.RSM(Form.Name, Form.Text)
        Try
            Form.MdiParent = Me
            Form.StartPosition = FormStartPosition.CenterScreen
            'Form.Left = (Screen.PrimaryScreen.WorkingArea.Width - Form.Width) \ 2
            'Form.Top = (Screen.PrimaryScreen.WorkingArea.Height - Form.Height) \ 2

            Form.Show()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : CargarForm(New Deducciones(Usuario))

            Case 2 : CargarForm(New frmAumentos)

            Case 3 : CargarForm(New Departamento1)

            Case 4 : CargarForm(New frmEstadoEmpleado(Usuario))

            Case 5 : CargarForm(New FrmEmpleado(Usuario))

            Case 6 : CargarForm(New ImpuestoRenta)

            Case 7 : CargarForm(New AccionPersonal(Usuario))

            Case 8 : CargarForm(New frmAdelantos(Usuario))

            Case 9 : CargarForm(New frmControlTiempo2(Usuario))

            Case 10 : CargarForm(New LiquidacionLaboral(Usuario))
        End Select
    End Sub
#End Region

#Region "Click"
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDeducciones.Click
        CargarForm(New Deducciones(Usuario))
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDepartamentos.Click
        CargarForm(New Departamento1)
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

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteAccionPersonal.Click
        CargarForm(New ReportesAccion)
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteVacaciones.Click
        CargarForm(New ReportesVacaciones1)
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New Frmusuario)
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New FrmConfiguración)
    End Sub

    Private Sub Menu_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim imagen As New Drawing.Bitmap(Me.PictureBox1.Image, Me.Width, Me.Height)
        Me.BackgroundImage = imagen
    End Sub

    Private Sub MenuItem15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAumentos.Click
        CargarForm(New frmAumentos)
    End Sub

    Private Sub MenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        CargarForm(New ConfiguracionHorasOrdinarias(Usuario))
    End Sub

    Private Sub MenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        CargarForm(New frmModificaPlanilla(Usuario))
    End Sub

    Private Sub MenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        CargarForm(New frmPagoAutomaticoBN(Usuario))
    End Sub

    Private Sub MenuItem8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        ' CargarForm(New Utilidades.FrmRespaldo("Planilla"))
    End Sub

    Private Sub MenuItem9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Me.Close()
    End Sub

    Private Sub MenuItem10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Dim sqlconnection1 As New SqlConnection
        Dim Imprimir As New RepSaldosAdelantos
        Dim visor As New frmVisorReportes

        sqlconnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        visor.rptViewer.ReportSource = Imprimir
        Planilla.CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Imprimir)
        visor.Show()
    End Sub

    Private Sub MenuItem11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        CargarForm(New FrmReporteEmpleado)
    End Sub

    Private Sub MenuItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        CargarForm(New FrmCertificacion)
    End Sub

    Private Sub MenuItem14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        CargarForm(New FrmIngresosEmpleados)
    End Sub

    Private Sub MenuItem_Prestamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_Prestamos.Click
        CargarForm(New FrmHistoricoPrestamo)
    End Sub
#End Region

#Region "Timer"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Text = Microsoft.VisualBasic.Mid("MODULO: PLANILLA - SUVESA COSTA RICA", 1, Contador)
        Contador = Contador + 1
        If Contador = Microsoft.VisualBasic.Len("MODULO: PLANILLA - SUVESA COSTA RICA") Then Contador = 1
    End Sub
#End Region

    Private Sub MenuItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        If GetSetting("SeeSOFT", "Planilla", "Marcador") = 1 Then
            CargarForm(New FrmPin)
        End If

    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        If GetSetting("SeeSOFT", "Planilla", "Marcador") = 1 Then
            CargarForm(New FrmMarcas1)
        End If

    End Sub

    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        CargarForm(New FrmNacionalidad)

    End Sub

    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        CargarForm(New PagoAguinaldos(Usuario))
    End Sub

    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Dim sqlconnection1 As New SqlConnection
        Dim Imprimir As New ControlFonda
        Dim visor As New frmVisorReportes

        sqlconnection1.ConnectionString = GetSetting("SeeSoft", "Planilla", "CONEXION")
        visor.rptViewer.ReportSource = Imprimir
        Planilla.CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Imprimir)
        visor.Show()
    End Sub

    Private Sub MenuItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click

    End Sub

    Private Sub MenuItem20_Click(sender As Object, e As EventArgs) Handles MenuItem20.Click
        Dim frm As New frmAguinaldo
        frm.ShowDialog()
    End Sub
End Class
