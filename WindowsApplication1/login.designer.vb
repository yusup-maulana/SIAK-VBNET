<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.login_nip_1 = New System.Windows.Forms.TextBox()
        Me.login_nama_1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.login_akses_1 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Aqua
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Red
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(398, 496)
        Me.BunifuGradientPanel1.TabIndex = 5
        '
        'login_nip_1
        '
        Me.login_nip_1.Location = New System.Drawing.Point(25, 440)
        Me.login_nip_1.Name = "login_nip_1"
        Me.login_nip_1.Size = New System.Drawing.Size(45, 20)
        Me.login_nip_1.TabIndex = 2
        Me.login_nip_1.Visible = False
        Me.login_nip_1.WordWrap = False
        '
        'login_nama_1
        '
        Me.login_nama_1.Location = New System.Drawing.Point(25, 466)
        Me.login_nama_1.Name = "login_nama_1"
        Me.login_nama_1.Size = New System.Drawing.Size(45, 20)
        Me.login_nama_1.TabIndex = 3
        Me.login_nama_1.Visible = False
        Me.login_nama_1.WordWrap = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(241, 417)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Copyright 2017 Yusup Maulana"
        '
        'login_akses_1
        '
        Me.login_akses_1.Location = New System.Drawing.Point(25, 414)
        Me.login_akses_1.Name = "login_akses_1"
        Me.login_akses_1.Size = New System.Drawing.Size(45, 20)
        Me.login_akses_1.TabIndex = 4
        Me.login_akses_1.Visible = False
        Me.login_akses_1.WordWrap = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(123, 225)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(436, 41)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(123, 300)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(436, 41)
        Me.TextBox2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Location = New System.Drawing.Point(293, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(99, 92)
        Me.Panel4.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(131, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(301, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(78, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(524, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sistem Informasi Administrasi Kependudukan Kecamatan Andir"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(123, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(436, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Masuk"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Button2)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.TextBox2)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.login_akses_1)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.login_nama_1)
        Me.Panel6.Controls.Add(Me.login_nip_1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(398, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(654, 496)
        Me.Panel6.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(623, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1052, 496)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents login_akses_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents login_nama_1 As System.Windows.Forms.TextBox
    Friend WithEvents login_nip_1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
