Public Class Queueop
    Dim q As Queue
    Dim n As Integer


    Private Sub Queueop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("enter the valid size")
        Else
            q = New Queue(Val(TextBox1.Text))
            n = TextBox1.Text

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox2.Text = "" Then
            MsgBox("enter the valiid element")
        Else
            If q.Count >= n Then
                MsgBox("queue is full")
                TextBox2.Text = ""
            Else
                q.Enqueue(TextBox2.Text)
                TextBox2.Text = ""
            End If

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If q.Count < 1 Then
            MsgBox("queue is Empty")
        Else
            TextBox2.Text = q.Dequeue
            Label2.Text = "removed element is :"
            'TextBox2.Enabled = False
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If q.Count < 1 Then
            MsgBox("queue is Empty")
        Else
            If TextBox2.Text = "" Then
                MsgBox("enter the valid element")
            Else
                Dim str As String
                str = q.Contains(TextBox2.Text)
                MsgBox("result : " + str)
                ' TextBox2.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        q.Clear()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ListBox1.Items.Clear()
        If q.Count < 1 Then
            MsgBox("queue is Empty")
        Else

            For i = 0 To q.Count - 1
                ListBox1.Items.Add(q(i))
            Next
        End If

    End Sub
End Class