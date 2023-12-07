<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_keluarga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_keluarga))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel3.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1284, 40)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.MinimizeToolStripMenuItem})
        Me.ToolStripDropDownButton2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(94, 37)
        Me.ToolStripDropDownButton2.Text = "Nama User"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(26, 721)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 39)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Detail data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(46, 21)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(25, 13)
        Me.lbl_id.TabIndex = 5
        Me.lbl_id.Text = "NIK"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(480, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(3)
        Me.Button1.Size = New System.Drawing.Size(49, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 40)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1284, 732)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.BunifuGradientPanel3)
        Me.TabPage1.Controls.Add(Me.BunifuGradientPanel2)
        Me.TabPage1.Controls.Add(Me.BunifuGradientPanel1)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1276, 706)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(226, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 583)
        Me.Panel1.TabIndex = 39
        '
        'DataGridView1
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(880, 583)
        Me.DataGridView1.TabIndex = 10
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackColor = System.Drawing.Color.Gray
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.Controls.Add(Me.txt_cari)
        Me.BunifuGradientPanel3.Controls.Add(Me.Button1)
        Me.BunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.Silver
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.Gainsboro
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.Gray
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(226, 3)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(880, 117)
        Me.BunifuGradientPanel3.TabIndex = 38
        '
        'txt_cari
        '
        Me.txt_cari.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari.Location = New System.Drawing.Point(32, 40)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(450, 33)
        Me.txt_cari.TabIndex = 33
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.Button3)
        Me.BunifuGradientPanel2.Controls.Add(Me.lbl_id)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Black
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Black
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(1106, 3)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(167, 700)
        Me.BunifuGradientPanel2.TabIndex = 37
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(34, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 41)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Detail"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.Button17)
        Me.BunifuGradientPanel1.Controls.Add(Me.Button16)
        Me.BunifuGradientPanel1.Controls.Add(Me.Button7)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.PowderBlue
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(3, 3)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(223, 700)
        Me.BunifuGradientPanel1.TabIndex = 9
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.Transparent
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.ForeColor = System.Drawing.Color.White
        Me.Button17.Location = New System.Drawing.Point(0, 72)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(220, 60)
        Me.Button17.TabIndex = 42
        Me.Button17.Text = "Data Penduduk"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Transparent
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.White
        Me.Button16.Location = New System.Drawing.Point(0, 194)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(220, 60)
        Me.Button16.TabIndex = 41
        Me.Button16.Text = "Admin"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(0, 135)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(220, 60)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Data Keluarga"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(44, 441)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 32)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Detail data"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(5, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 23)
        Me.Panel2.TabIndex = 13
        '
        'data_keluarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 772)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "data_keluarga"
        Me.Text = "data_keluarga"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.BunifuGradientPanel3.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txt_cari As System.Windows.Forms.TextBox
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
