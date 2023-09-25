<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.DataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.b1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.c1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuCircleProgress1 = New Bunifu.UI.WinForms.BunifuCircleProgress()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowCustomTheming = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.b1, Me.b2, Me.b3, Me.b4, Me.b5, Me.b6, Me.b7, Me.b8, Me.b9})
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.Name = Nothing
        Me.DataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.DataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView1.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(12, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(945, 84)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        '
        'b1
        '
        Me.b1.HeaderText = "B13"
        Me.b1.Name = "b1"
        '
        'b2
        '
        Me.b2.HeaderText = "B14"
        Me.b2.Name = "b2"
        '
        'b3
        '
        Me.b3.HeaderText = "B15"
        Me.b3.Name = "b3"
        '
        'b4
        '
        Me.b4.HeaderText = "B16"
        Me.b4.Name = "b4"
        '
        'b5
        '
        Me.b5.HeaderText = "B17"
        Me.b5.Name = "b5"
        '
        'b6
        '
        Me.b6.HeaderText = "B18"
        Me.b6.Name = "b6"
        '
        'b7
        '
        Me.b7.HeaderText = "B19"
        Me.b7.Name = "b7"
        '
        'b8
        '
        Me.b8.HeaderText = "B20"
        Me.b8.Name = "b8"
        '
        'b9
        '
        Me.b9.HeaderText = "B21"
        Me.b9.Name = "b9"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowCustomTheming = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView2.ColumnHeadersHeight = 40
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c1, Me.c2, Me.c3, Me.c4, Me.c5, Me.c6, Me.c7, Me.c8, Me.c9})
        Me.DataGridView2.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DataGridView2.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView2.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.DataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView2.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView2.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView2.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView2.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView2.CurrentTheme.Name = Nothing
        Me.DataGridView2.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.DataGridView2.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView2.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView2.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.DataGridView2.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView2.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView2.HeaderBgColor = System.Drawing.Color.Empty
        Me.DataGridView2.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView2.Location = New System.Drawing.Point(12, 169)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView2.RowTemplate.Height = 40
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(945, 84)
        Me.DataGridView2.TabIndex = 1
        Me.DataGridView2.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        '
        'c1
        '
        Me.c1.HeaderText = "C13"
        Me.c1.Name = "c1"
        '
        'c2
        '
        Me.c2.HeaderText = "C14"
        Me.c2.Name = "c2"
        '
        'c3
        '
        Me.c3.HeaderText = "C15"
        Me.c3.Name = "c3"
        '
        'c4
        '
        Me.c4.HeaderText = "C16"
        Me.c4.Name = "c4"
        '
        'c5
        '
        Me.c5.HeaderText = "C17"
        Me.c5.Name = "c5"
        '
        'c6
        '
        Me.c6.HeaderText = "C18"
        Me.c6.Name = "c6"
        '
        'c7
        '
        Me.c7.HeaderText = "C19"
        Me.c7.Name = "c7"
        '
        'c8
        '
        Me.c8.HeaderText = "C20"
        Me.c8.Name = "c8"
        '
        'c9
        '
        Me.c9.HeaderText = "C21"
        Me.c9.Name = "c9"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuCircleProgress1
        '
        Me.BunifuCircleProgress1.Animated = False
        Me.BunifuCircleProgress1.AnimationInterval = 1
        Me.BunifuCircleProgress1.AnimationSpeed = 1
        Me.BunifuCircleProgress1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgress1.CircleMargin = 10
        Me.BunifuCircleProgress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCircleProgress1.ForeColor = System.Drawing.Color.Lime
        Me.BunifuCircleProgress1.IsPercentage = True
        Me.BunifuCircleProgress1.LineProgressThickness = 8
        Me.BunifuCircleProgress1.LineThickness = 5
        Me.BunifuCircleProgress1.Location = New System.Drawing.Point(349, 39)
        Me.BunifuCircleProgress1.Name = "BunifuCircleProgress1"
        Me.BunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.Silver
        Me.BunifuCircleProgress1.ProgressColor = System.Drawing.Color.Cyan
        Me.BunifuCircleProgress1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BunifuCircleProgress1.Size = New System.Drawing.Size(227, 227)
        Me.BunifuCircleProgress1.SubScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress1.SubScriptMargin = New System.Windows.Forms.Padding(5, -35, 0, 0)
        Me.BunifuCircleProgress1.SubScriptText = ""
        Me.BunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress1.SuperScriptMargin = New System.Windows.Forms.Padding(5, 50, 0, 0)
        Me.BunifuCircleProgress1.SuperScriptText = "%"
        Me.BunifuCircleProgress1.TabIndex = 16
        Me.BunifuCircleProgress1.Text = "BunifuCircleProgress1"
        Me.BunifuCircleProgress1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        '
        'Timer2
        '
        Me.Timer2.Interval = 150
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Image = Global.InterlockC.My.Resources.Resources.synchronize_48px
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(917, 6)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(40, 40)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 17
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Timer4
        '
        Me.Timer4.Interval = 3000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 271)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.BunifuCircleProgress1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents DataGridView2 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents c1 As DataGridViewTextBoxColumn
    Friend WithEvents c2 As DataGridViewTextBoxColumn
    Friend WithEvents c3 As DataGridViewTextBoxColumn
    Friend WithEvents c4 As DataGridViewTextBoxColumn
    Friend WithEvents c5 As DataGridViewTextBoxColumn
    Friend WithEvents c6 As DataGridViewTextBoxColumn
    Friend WithEvents c7 As DataGridViewTextBoxColumn
    Friend WithEvents c8 As DataGridViewTextBoxColumn
    Friend WithEvents c9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents b1 As DataGridViewTextBoxColumn
    Friend WithEvents b2 As DataGridViewTextBoxColumn
    Friend WithEvents b3 As DataGridViewTextBoxColumn
    Friend WithEvents b4 As DataGridViewTextBoxColumn
    Friend WithEvents b5 As DataGridViewTextBoxColumn
    Friend WithEvents b6 As DataGridViewTextBoxColumn
    Friend WithEvents b7 As DataGridViewTextBoxColumn
    Friend WithEvents b8 As DataGridViewTextBoxColumn
    Friend WithEvents b9 As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCircleProgress1 As Bunifu.UI.WinForms.BunifuCircleProgress
    Friend WithEvents Timer2 As Timer
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
End Class
