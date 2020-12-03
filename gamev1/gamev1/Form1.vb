Public Class Form1
    Dim r As New Random
    Sub randmove(p As PictureBox)
        Dim x As Integer
        Dim y As Integer
        x = r.Next(-21, 9)
        y = r.Next(-11, 9)
        Moveto(p, x, y)

    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.R
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX)
                Me.Refresh()

            Case Keys.Up
                Moveto(PictureBox1, 0, -9)

            Case Keys.Down
                Moveto(PictureBox1, 0, 9)
            Case Keys.Left
                Moveto(PictureBox1, -9, 0)
            Case Keys.Right
                Moveto(PictureBox1, 9, 0)
            Case Keys.C
                bullet.Location = PictureBox1.Location
                bullet.Visible = True
                Timer2.Enabled = True
                xoffset = 0.5
                yoffset = -0.5
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Moveto(enemy2, 0, 3)
        Move(PictureBox3win, 0, 6)
        randmove(enemy1)
    End Sub
    Shadows Sub Move(P As PictureBox, x As Integer, y As Integer)
        P.Location = New Point(P.Location.X + x, P.Location.Y + y)
        If Collision(P, "wall") Then
            MsgBox("game over")
        End If
        If Collision(P, "enemy") Then
            MsgBox("game over")
        End If
    End Sub
    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(PictureBox1.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > PictureBox1.Location.X Then
            x = -5
        Else
            x = 5
        End If
        Moveto(p, x, 0)
        If p.Location.Y < PictureBox1.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        Moveto(p, x, y)
    End Sub
    Function Collision(p As PictureBox, t As String)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If p.Bounds.IntersectsWith(obj.Bounds) And (obj.Name.ToUpper.Contains(t.ToUpper)) Then
                col = True
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub Moveto(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "wall") Then
            p.Location += New Point(distx, disty)
        End If
        Dim other As Object = Nothing
        If Collision(enemy2, "bullet") Then
            'Me.BackColor = Color.Green
            other.visible = False
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If

        If p.Name = "PictureBox1" And Collision(p, "WIN") Then
            Me.BackColor = Color.Green
            PictureBox3win.Visible = False
            Moveto(PictureBox3win, -1000, -50)
            Me.Visible = False
            PictureBox1.Visible = True

            Dim f As New Form2
            f.ShowDialog()
            Me.Visible = True
            Return
        Else
            Me.BackColor = Color.Black
        End If
        If p.Name = "bullet" And Collision(p, "enemy1") Then
            enemy1.Visible = False
            Moveto(enemy1, -1000, -50)
        End If
        If p.Name = "bullet" And Collision(p, "enemy2") Then
            enemy2.Visible = False
            Moveto(enemy2, -1000, -50)
        End If
        If p.Name = "enemy1" And Collision(p, "picturebox1") Then
            PictureBox1.Visible = False
            Moveto(PictureBox1, -1000, -50)


        End If
        If p.Name = "enemy2" And Collision(p, "picturebox1") Then
            PictureBox1.Visible = False
            Moveto(PictureBox1, -1000, -50)
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Moveto(bullet, 10, 0)
    End Sub
    Dim xoffset As Integer
    Dim yoffset As Integer

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Moveto(PictureBox1, 0 + xoffset, 0.5 + yoffset)
        If xoffset > 0 Then
            xoffset = xoffset - 0.5
        End If
        If yoffset < 0 Then
            yoffset = yoffset + 0.5
        End If
    End Sub

End Class
