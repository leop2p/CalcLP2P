<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startup
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startup))
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.MenuItem_View = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Main = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_Info = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Sep = New System.Windows.Forms.RadioButton()
        Me.Multiple = New System.Windows.Forms.RadioButton()
        Me.Minus = New System.Windows.Forms.RadioButton()
        Me.Plus = New System.Windows.Forms.RadioButton()
        Me.Button_Compute = New System.Windows.Forms.Button()
        Me.Num2 = New System.Windows.Forms.NumericUpDown()
        Me.Num1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Summ = New System.Windows.Forms.TextBox()
        Me.MainMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Num2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(1339, 440)
        '
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.Color.Transparent
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_View, Me.MenuItem_Info})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(931, 24)
        Me.MainMenu.TabIndex = 17
        Me.MainMenu.Text = "Главное меню"
        '
        'MenuItem_View
        '
        Me.MenuItem_View.BackColor = System.Drawing.Color.Transparent
        Me.MenuItem_View.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_Main})
        Me.MenuItem_View.ForeColor = System.Drawing.Color.Black
        Me.MenuItem_View.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.MenuItem_View.Name = "MenuItem_View"
        Me.MenuItem_View.Size = New System.Drawing.Size(39, 20)
        Me.MenuItem_View.Text = "Вид"
        '
        'MenuItem_Main
        '
        Me.MenuItem_Main.BackColor = System.Drawing.Color.Transparent
        Me.MenuItem_Main.Checked = True
        Me.MenuItem_Main.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuItem_Main.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MenuItem_Main.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuItem_Main.Name = "MenuItem_Main"
        Me.MenuItem_Main.Size = New System.Drawing.Size(126, 22)
        Me.MenuItem_Main.Text = "Базовый"
        '
        'MenuItem_Info
        '
        Me.MenuItem_Info.BackColor = System.Drawing.Color.Transparent
        Me.MenuItem_Info.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_About})
        Me.MenuItem_Info.Name = "MenuItem_Info"
        Me.MenuItem_Info.Size = New System.Drawing.Size(93, 20)
        Me.MenuItem_Info.Text = "Информация"
        '
        'MenuItem_About
        '
        Me.MenuItem_About.BackColor = System.Drawing.Color.Transparent
        Me.MenuItem_About.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MenuItem_About.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuItem_About.Name = "MenuItem_About"
        Me.MenuItem_About.Size = New System.Drawing.Size(159, 22)
        Me.MenuItem_About.Text = "О программе..."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Sep)
        Me.GroupBox1.Controls.Add(Me.Multiple)
        Me.GroupBox1.Controls.Add(Me.Minus)
        Me.GroupBox1.Controls.Add(Me.Plus)
        Me.GroupBox1.Controls.Add(Me.Button_Compute)
        Me.GroupBox1.Controls.Add(Me.Num2)
        Me.GroupBox1.Controls.Add(Me.Num1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Summ)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(907, 100)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Базовые функции"
        '
        'Sep
        '
        Me.Sep.AutoSize = True
        Me.Sep.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Sep.FlatAppearance.BorderSize = 2
        Me.Sep.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Sep.Location = New System.Drawing.Point(234, 52)
        Me.Sep.Name = "Sep"
        Me.Sep.Size = New System.Drawing.Size(134, 23)
        Me.Sep.TabIndex = 16
        Me.Sep.TabStop = True
        Me.Sep.Text = "РАЗДЕЛИТЬ"
        Me.Sep.UseVisualStyleBackColor = True
        '
        'Multiple
        '
        Me.Multiple.AutoSize = True
        Me.Multiple.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Multiple.FlatAppearance.BorderSize = 2
        Me.Multiple.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Multiple.Location = New System.Drawing.Point(234, 26)
        Me.Multiple.Name = "Multiple"
        Me.Multiple.Size = New System.Drawing.Size(135, 23)
        Me.Multiple.TabIndex = 15
        Me.Multiple.TabStop = True
        Me.Multiple.Text = "УМНОЖИТЬ"
        Me.Multiple.UseVisualStyleBackColor = True
        '
        'Minus
        '
        Me.Minus.AutoSize = True
        Me.Minus.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Minus.FlatAppearance.BorderSize = 2
        Me.Minus.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Minus.Location = New System.Drawing.Point(92, 52)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(98, 23)
        Me.Minus.TabIndex = 14
        Me.Minus.TabStop = True
        Me.Minus.Text = "ОТНЯТЬ"
        Me.Minus.UseVisualStyleBackColor = True
        '
        'Plus
        '
        Me.Plus.AutoSize = True
        Me.Plus.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Plus.FlatAppearance.BorderSize = 2
        Me.Plus.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Plus.Location = New System.Drawing.Point(92, 26)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(136, 23)
        Me.Plus.TabIndex = 13
        Me.Plus.TabStop = True
        Me.Plus.Text = "ПРИБАВИТЬ"
        Me.Plus.UseVisualStyleBackColor = True
        '
        'Button_Compute
        '
        Me.Button_Compute.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button_Compute.Font = New System.Drawing.Font("Tondo", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button_Compute.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Compute.Location = New System.Drawing.Point(684, 30)
        Me.Button_Compute.Name = "Button_Compute"
        Me.Button_Compute.Size = New System.Drawing.Size(202, 42)
        Me.Button_Compute.TabIndex = 9
        Me.Button_Compute.Text = "ПОСЧИТАТЬ"
        Me.Button_Compute.UseVisualStyleBackColor = False
        '
        'Num2
        '
        Me.Num2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Num2.ForeColor = System.Drawing.SystemColors.Info
        Me.Num2.Location = New System.Drawing.Point(374, 30)
        Me.Num2.Maximum = New Decimal(New Integer() {1874919423, 2328306, 0, 0})
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(74, 40)
        Me.Num2.TabIndex = 11
        '
        'Num1
        '
        Me.Num1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Num1.ForeColor = System.Drawing.SystemColors.Info
        Me.Num1.Location = New System.Drawing.Point(12, 30)
        Me.Num1.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(74, 40)
        Me.Num1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(475, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "="
        '
        'Summ
        '
        Me.Summ.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Summ.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Summ.ForeColor = System.Drawing.SystemColors.Info
        Me.Summ.Location = New System.Drawing.Point(536, 31)
        Me.Summ.MaxLength = 10
        Me.Summ.Name = "Summ"
        Me.Summ.ReadOnly = True
        Me.Summ.Size = New System.Drawing.Size(94, 40)
        Me.Summ.TabIndex = 8
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(931, 221)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Startup"
        Me.Text = "Калькулятор LeoP2P"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Num2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents MenuItem_View As ToolStripMenuItem
    Friend WithEvents MenuItem_Main As ToolStripMenuItem
    Friend WithEvents MenuItem_Info As ToolStripMenuItem
    Friend WithEvents MenuItem_About As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Sep As RadioButton
    Friend WithEvents Multiple As RadioButton
    Friend WithEvents Minus As RadioButton
    Friend WithEvents Plus As RadioButton
    Friend WithEvents Button_Compute As Button
    Friend WithEvents Num2 As NumericUpDown
    Friend WithEvents Num1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Summ As TextBox
End Class
