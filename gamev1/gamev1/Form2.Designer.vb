<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.enemy2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.bullet = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'enemy2
        '
        Me.enemy2.BackColor = System.Drawing.Color.Transparent
        Me.enemy2.Image = Global.gamev1.My.Resources.Resources.Untitled3
        Me.enemy2.Location = New System.Drawing.Point(323, 26)
        Me.enemy2.Name = "enemy2"
        Me.enemy2.Size = New System.Drawing.Size(151, 127)
        Me.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.enemy2.TabIndex = 0
        Me.enemy2.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.gamev1.My.Resources.Resources.Untitled
        Me.PictureBox2.Location = New System.Drawing.Point(68, 291)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'bullet
        '
        Me.bullet.BackColor = System.Drawing.Color.Transparent
        Me.bullet.Image = Global.gamev1.My.Resources.Resources.Untitled2
        Me.bullet.Location = New System.Drawing.Point(660, 231)
        Me.bullet.Name = "bullet"
        Me.bullet.Size = New System.Drawing.Size(32, 41)
        Me.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bullet.TabIndex = 2
        Me.bullet.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gamev1.My.Resources.Resources.download__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bullet)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.enemy2)
        Me.DoubleBuffered = True
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents bullet As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
