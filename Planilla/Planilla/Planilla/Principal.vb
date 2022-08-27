'Imports Utilidades
Public Module Principal
    Public Usuario As Usuario_Logeado
    Public GetSettingConexion As String
    Public Login As New Frm_login("Planilla")
    Public ModeExecute As String
    ' Private Declare Function GetVolumeInformation Lib "kernel32" Alias "GetVolumeInformationA" (ByVal lpRootPathName As String, ByVal pVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer

    Sub Main()
        Login.ShowDialog()
        If Login.conectado Then
            Usuario = Login.Usuario
            If Environment.GetCommandLineArgs.Length > 1 Then ModeExecute = Environment.GetCommandLineArgs(1)
            Application.Run(New Planilla.MenuPlanilla(Login.Usuario))

        End If
    End Sub


    'Private Function LeadingZeros(ByRef ExpectedLen As Short, ByRef ActualLen As Short) As String
    '    LeadingZeros = New String("0", ExpectedLen - ActualLen)
    'End Function


    '    Public Sub VerificacionRegistrosSistema()  'JSA 20072006
    '        GetSettingConexion = GetSetting("SeePos", "SeePos", "Conexion")
    '        If GetSettingConexion = "" Then
    '            Dim FormConexion As New EnlaceServidor.FormConexion
    '            FormConexion.Left = (Screen.PrimaryScreen.WorkingArea.Width - FormConexion.Width) \ 2
    '            FormConexion.Top = (Screen.PrimaryScreen.WorkingArea.Height - FormConexion.Height) \ 2
    '            FormConexion.ShowDialog()
    '        End If
    '    End Sub
    '    Public Function EstadoSevidor_Enlace()  'JSA 20072006
    '        Dim Conexiones As New Conexion
    '        Dim ReintestoFallidos As Int16
    'Reintentos:
    '        Try
    '            '            Espera.Caption = "Establecer Conexión con el servidor..."
    '            ReintestoFallidos += 1
    '            Conexiones.Conectar()
    '            '          Espera.Caption = "Conexion establecida con [" & Conexiones.sQlconexion.DataSource & "]"
    '        Catch ex As Exception
    '            '           Espera.Caption = "Conexión NO establecida con el servidor..."
    '            If ReintestoFallidos < 3 Then
    '                If MsgBox("Conexión no estabecida con el Servidor..." & vbCrLf & "Desea intentar establecer conexion nuevamente...", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "") = MsgBoxResult.Yes Then GoTo Reintentos
    '            Else
    '                Dim FormConexion As New EnlaceServidor.FormConexion
    '                FormConexion.Left = (Screen.PrimaryScreen.WorkingArea.Width - FormConexion.Width) \ 2
    '                FormConexion.Top = (Screen.PrimaryScreen.WorkingArea.Height - FormConexion.Height) \ 2
    '                FormConexion.ShowDialog()
    '            End If

    '        End Try
    '    End Function

    '    Public Sub CambiarEstilo(ByVal tControl As Control)
    '        ' Cambiar el estilo del control...
    '        ' sólo si es uno de los indicados
    '        Select Case tControl.GetType.Name
    '            Case "Label"
    '                CType(tControl, Label).FlatStyle = FlatStyle.System
    '            Case "CheckBox"
    '                CType(tControl, CheckBox).FlatStyle = FlatStyle.System
    '            Case "RadioButton"
    '                CType(tControl, RadioButton).FlatStyle = FlatStyle.System
    '            Case "Button"
    '                ' Si el botón tiene asignada la propiedad Image     (11/Oct/02)
    '                ' no cambiarlo...
    '                Dim tButton As Button = CType(tControl, Button)
    '                If tButton.Image Is Nothing Then
    '                    tButton.FlatStyle = FlatStyle.System
    '                End If
    '            Case "GroupBox"
    '                CType(tControl, GroupBox).FlatStyle = FlatStyle.System
    '        End Select
    '        '
    '        ' Cambiar también los controles contenidos en cada control...
    '        If tControl.Controls.Count > 0 Then
    '            Dim tControl2 As Control
    '            '
    '            For Each tControl2 In tControl.Controls
    '                CambiarEstilo(tControl2)
    '            Next
    '        End If
    '    End Sub
End Module
