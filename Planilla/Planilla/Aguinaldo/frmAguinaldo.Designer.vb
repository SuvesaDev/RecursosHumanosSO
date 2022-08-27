<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAguinaldo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtAnnyo = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcularAguinaldos = New System.Windows.Forms.Button()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cEne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFeb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAbr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cJul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAgo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cOct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.txtAnnyo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAnnyo
        '
        Me.txtAnnyo.Location = New System.Drawing.Point(14, 28)
        Me.txtAnnyo.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.txtAnnyo.Minimum = New Decimal(New Integer() {2022, 0, 0, 0})
        Me.txtAnnyo.Name = "txtAnnyo"
        Me.txtAnnyo.Size = New System.Drawing.Size(92, 20)
        Me.txtAnnyo.TabIndex = 0
        Me.txtAnnyo.Value = New Decimal(New Integer() {2022, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Año"
        '
        'btnCalcularAguinaldos
        '
        Me.btnCalcularAguinaldos.Location = New System.Drawing.Point(112, 12)
        Me.btnCalcularAguinaldos.Name = "btnCalcularAguinaldos"
        Me.btnCalcularAguinaldos.Size = New System.Drawing.Size(137, 36)
        Me.btnCalcularAguinaldos.TabIndex = 2
        Me.btnCalcularAguinaldos.Text = "Calcular Aguinaldos"
        Me.btnCalcularAguinaldos.UseVisualStyleBackColor = True
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNombre, Me.cDic, Me.cEne, Me.cFeb, Me.cMar, Me.cAbr, Me.cMay, Me.cJun, Me.cJul, Me.cAgo, Me.cSep, Me.cOct, Me.cNov, Me.cTotal})
        Me.viewDatos.Location = New System.Drawing.Point(14, 54)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 30
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(915, 387)
        Me.viewDatos.TabIndex = 3
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(400, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(137, 36)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir Aguinados"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(255, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(137, 36)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar Aguinaldos"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'cNombre
        '
        Me.cNombre.HeaderText = "Empleado"
        Me.cNombre.Name = "cNombre"
        Me.cNombre.ReadOnly = True
        Me.cNombre.Width = 79
        '
        'cDic
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "N2"
        Me.cDic.DefaultCellStyle = DataGridViewCellStyle27
        Me.cDic.HeaderText = "Dic"
        Me.cDic.Name = "cDic"
        Me.cDic.Width = 48
        '
        'cEne
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Format = "N2"
        Me.cEne.DefaultCellStyle = DataGridViewCellStyle28
        Me.cEne.HeaderText = "Ene"
        Me.cEne.Name = "cEne"
        Me.cEne.Width = 51
        '
        'cFeb
        '
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle29.Format = "N2"
        Me.cFeb.DefaultCellStyle = DataGridViewCellStyle29
        Me.cFeb.HeaderText = "Feb"
        Me.cFeb.Name = "cFeb"
        Me.cFeb.Width = 50
        '
        'cMar
        '
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle30.Format = "N2"
        Me.cMar.DefaultCellStyle = DataGridViewCellStyle30
        Me.cMar.HeaderText = "Mar"
        Me.cMar.Name = "cMar"
        Me.cMar.Width = 50
        '
        'cAbr
        '
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle31.Format = "N2"
        Me.cAbr.DefaultCellStyle = DataGridViewCellStyle31
        Me.cAbr.HeaderText = "Abr"
        Me.cAbr.Name = "cAbr"
        Me.cAbr.Width = 48
        '
        'cMay
        '
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle32.Format = "N2"
        Me.cMay.DefaultCellStyle = DataGridViewCellStyle32
        Me.cMay.HeaderText = "May"
        Me.cMay.Name = "cMay"
        Me.cMay.Width = 52
        '
        'cJun
        '
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle33.Format = "N2"
        Me.cJun.DefaultCellStyle = DataGridViewCellStyle33
        Me.cJun.HeaderText = "Jun"
        Me.cJun.Name = "cJun"
        Me.cJun.Width = 49
        '
        'cJul
        '
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle34.Format = "N2"
        Me.cJul.DefaultCellStyle = DataGridViewCellStyle34
        Me.cJul.HeaderText = "Jul"
        Me.cJul.Name = "cJul"
        Me.cJul.Width = 45
        '
        'cAgo
        '
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle35.Format = "N2"
        Me.cAgo.DefaultCellStyle = DataGridViewCellStyle35
        Me.cAgo.HeaderText = "Ago"
        Me.cAgo.Name = "cAgo"
        Me.cAgo.Width = 51
        '
        'cSep
        '
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle36.Format = "N2"
        Me.cSep.DefaultCellStyle = DataGridViewCellStyle36
        Me.cSep.HeaderText = "Sep"
        Me.cSep.Name = "cSep"
        Me.cSep.Width = 51
        '
        'cOct
        '
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle37.Format = "N2"
        Me.cOct.DefaultCellStyle = DataGridViewCellStyle37
        Me.cOct.HeaderText = "Oct"
        Me.cOct.Name = "cOct"
        Me.cOct.Width = 49
        '
        'cNov
        '
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle38.Format = "N2"
        Me.cNov.DefaultCellStyle = DataGridViewCellStyle38
        Me.cNov.HeaderText = "Nov"
        Me.cNov.Name = "cNov"
        Me.cNov.Width = 52
        '
        'cTotal
        '
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle39.Format = "N2"
        Me.cTotal.DefaultCellStyle = DataGridViewCellStyle39
        Me.cTotal.HeaderText = "Total"
        Me.cTotal.Name = "cTotal"
        Me.cTotal.ReadOnly = True
        Me.cTotal.Width = 56
        '
        'frmAguinaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 453)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.viewDatos)
        Me.Controls.Add(Me.btnCalcularAguinaldos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnnyo)
        Me.Name = "frmAguinaldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aguinaldos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtAnnyo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAnnyo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalcularAguinaldos As System.Windows.Forms.Button
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents cNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cEne As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cFeb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAbr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cMay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cJul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cAgo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cOct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cNov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
