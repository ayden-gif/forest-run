<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.enemy1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3win = New System.Windows.Forms.PictureBox()
        Me.enemy2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox5wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox7wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox6wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox8wall = New System.Windows.Forms.PictureBox()
        Me.bullet = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2wall = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2wall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'enemy1
        '
        Me.enemy1.BackColor = System.Drawing.Color.DimGray
        Me.enemy1.Image = CType(resources.GetObject("enemy1.Image"), System.Drawing.Image)
        Me.enemy1.Location = New System.Drawing.Point(402, 367)
        Me.enemy1.Name = "enemy1"
        Me.enemy1.Size = New System.Drawing.Size(65, 56)
        Me.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy1.TabIndex = 3
        Me.enemy1.TabStop = False
        '
        'PictureBox3win
        '
        Me.PictureBox3win.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3win.Image = CType(resources.GetObject("PictureBox3win.Image"), System.Drawing.Image)
        Me.PictureBox3win.Location = New System.Drawing.Point(668, 12)
        Me.PictureBox3win.Name = "PictureBox3win"
        Me.PictureBox3win.Size = New System.Drawing.Size(87, 80)
        Me.PictureBox3win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3win.TabIndex = 2
        Me.PictureBox3win.TabStop = False
        '
        'enemy2
        '
        Me.enemy2.BackColor = System.Drawing.Color.White
        Me.enemy2.Image = CType(resources.GetObject("enemy2.Image"), System.Drawing.Image)
        Me.enemy2.Location = New System.Drawing.Point(17, 51)
        Me.enemy2.Name = "enemy2"
        Me.enemy2.Size = New System.Drawing.Size(106, 87)
        Me.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy2.TabIndex = 1
        Me.enemy2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 320)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'wall
        '
        Me.wall.Location = New System.Drawing.Point(1, 429)
        Me.wall.Name = "wall"
        Me.wall.Size = New System.Drawing.Size(927, 64)
        Me.wall.TabIndex = 5
        Me.wall.TabStop = False
        '
        'PictureBox5wall
        '
        Me.PictureBox5wall.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox5wall.Name = "PictureBox5wall"
        Me.PictureBox5wall.Size = New System.Drawing.Size(10, 433)
        Me.PictureBox5wall.TabIndex = 6
        Me.PictureBox5wall.TabStop = False
        '
        'PictureBox7wall
        '
        Me.PictureBox7wall.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7wall.Location = New System.Drawing.Point(137, 206)
        Me.PictureBox7wall.Name = "PictureBox7wall"
        Me.PictureBox7wall.Size = New System.Drawing.Size(360, 31)
        Me.PictureBox7wall.TabIndex = 7
        Me.PictureBox7wall.TabStop = False
        '
        'PictureBox6wall
        '
        Me.PictureBox6wall.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6wall.Location = New System.Drawing.Point(491, 113)
        Me.PictureBox6wall.Name = "PictureBox6wall"
        Me.PictureBox6wall.Size = New System.Drawing.Size(85, 151)
        Me.PictureBox6wall.TabIndex = 8
        Me.PictureBox6wall.TabStop = False
        '
        'PictureBox8wall
        '
        Me.PictureBox8wall.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8wall.Location = New System.Drawing.Point(12, -1)
        Me.PictureBox8wall.Name = "PictureBox8wall"
        Me.PictureBox8wall.Size = New System.Drawing.Size(916, 10)
        Me.PictureBox8wall.TabIndex = 9
        Me.PictureBox8wall.TabStop = False
        '
        'bullet
        '
        Me.bullet.BackColor = System.Drawing.Color.Transparent
        Me.bullet.Image = CType(resources.GetObject("bullet.Image"), System.Drawing.Image)
        Me.bullet.Location = New System.Drawing.Point(160, 284)
        Me.bullet.Name = "bullet"
        Me.bullet.Size = New System.Drawing.Size(25, 35)
        Me.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bullet.TabIndex = 10
        Me.bullet.TabStop = False
        Me.bullet.Visible = False
        '
        'Timer2
        '
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'PictureBox2wall
        '
        Me.PictureBox2wall.Location = New System.Drawing.Point(908, 12)
        Me.PictureBox2wall.Name = "PictureBox2wall"
        Me.PictureBox2wall.Size = New System.Drawing.Size(20, 420)
        Me.PictureBox2wall.TabIndex = 11
        Me.PictureBox2wall.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(354, 51)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 12
        Me.ProgressBar1.Value = 98
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(298, 113)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(70, 40)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "get the ghost" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B = fire"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(921, 483)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox2wall)
        Me.Controls.Add(Me.bullet)
        Me.Controls.Add(Me.PictureBox8wall)
        Me.Controls.Add(Me.PictureBox6wall)
        Me.Controls.Add(Me.PictureBox7wall)
        Me.Controls.Add(Me.PictureBox5wall)
        Me.Controls.Add(Me.wall)
        Me.Controls.Add(Me.enemy1)
        Me.Controls.Add(Me.PictureBox3win)
        Me.Controls.Add(Me.enemy2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "forest hount"
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2wall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents PictureBox3win As PictureBox
    Friend WithEvents enemy1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents wall As PictureBox
    Friend WithEvents PictureBox5wall As PictureBox
    Friend WithEvents PictureBox7wall As PictureBox
    Friend WithEvents PictureBox6wall As PictureBox
    Friend WithEvents PictureBox8wall As PictureBox
    Friend WithEvents bullet As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox2wall As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TextBox1 As TextBox
End Class
