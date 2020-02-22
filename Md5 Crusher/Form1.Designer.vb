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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(10, 39)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(165, 214)
        Me.ListBox1.TabIndex = 8
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem, Me.EkleToolStripMenuItem, Me.SilToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(136, 92)
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'EkleToolStripMenuItem
        '
        Me.EkleToolStripMenuItem.Name = "EkleToolStripMenuItem"
        Me.EkleToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.EkleToolStripMenuItem.Text = "Ekle"
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SilToolStripMenuItem.Text = "Sil"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.ToolStripMenuItem1.Text = "Tümünü Sil"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Şifre Listesi "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(147, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 21)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "..."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 23)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Md5"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Kır"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(92, 83)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Durdur"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(173, 83)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "İptal"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(252, 54)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "↓"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Denenen Şifre :"
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(252, 220)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "↑"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 220)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(237, 23)
        Me.TextBox2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Şifre"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 277)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(85, 16)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(29, 21)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "-"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(8, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Şifre : 0"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(116, 16)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(29, 21)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "+"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(191, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 277)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(10, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "0 sn"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(9, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 15)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(10, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "0/0"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 171)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(237, 20)
        Me.ProgressBar1.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(76, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Md5 Crusher"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(248, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "0%"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(333, 283)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 17)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Powered By DeadSound"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(487, 302)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Md5 Crusher"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EkleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DosyaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
