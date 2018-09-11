Public Class Stackop
    Dim st As Stack
    Dim oj As Object
    Dim n As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Stackop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Visible = False
        Label2.Visible = False
        TextBox2.Visible = False
        Label3.Visible = False
        TextBox3.Visible = False
        Me.RadioButton1.Checked = False
        Me.RadioButton2.Checked = False
        Me.RadioButton3.Checked = False
        Me.RadioButton4.Checked = False
        Me.RadioButton5.Checked = False
        Me.RadioButton6.Checked = False


    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            If st.Count >= n Then
                MsgBox("stack is full")
            Else
                TextBox2.Visible = True
                Label2.Visible = True
                Label2.Text = "Enter the element value"
                If TextBox2.Text = "" Then
                    MsgBox("enter the element")
                    RadioButton1.Checked = False
                Else
                    oj = TextBox2.Text
                    st.Push(oj)
                    TextBox2.Text = ""
                    Label2.Visible = False
                    TextBox2.Visible = False
                    MsgBox("Element is pushed")
                    RadioButton1.Checked = False
                End If
            End If
        Else
            'TextBox2.Visible = False
            'Label2.Visible = False

        End If
        

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("enter the size")
        Else
            n = Val(TextBox1.Text)
            st = New Stack(n)
            TextBox1.Text = ""
            TextBox1.Visible = False
            Button3.Visible = True
            Label1.Visible = False

        End If
        

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            If st.Count < 1 Then
                MsgBox("stack is empty")
                RadioButton2.Checked = False

            Else
                TextBox2.Text = st.Pop
                TextBox2.Visible = True
                Label2.Text = "poped element is"
                Label2.Visible = True
                'RadioButton2.Checked = False

            End If
        Else
            TextBox2.Text = ""
            TextBox2.Visible = False
            Label2.Visible = False

        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged

        If RadioButton6.Checked = True Then
            If st.Count < 1 Then
                MsgBox("stack is empty")
            Else
                Dim i As Integer
                ListBox1.Visible = True
                ListBox1.Items.Clear()
                For i = 0 To st.Count - 1
                    ListBox1.Text = ListBox1.Items.Add(st(i))
                Next
            End If
        Else
            RadioButton6.Checked = False
            ListBox1.Visible = False

        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            If st.Count < 1 Then
                MsgBox("stack is empty")
                RadioButton3.Checked = False

            Else
                TextBox2.Text = st.Peek
                TextBox2.Visible = True
                Label2.Visible = True
                Label2.Text = "Top of the element is"
                'RadioButton3.Checked = False

            End If
        Else
            'TextBox.Text = ""
            TextBox2.Text = ""
            TextBox2.Visible = False
            Label2.Visible = False

        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            If st.Count < 1 Then
                MsgBox("stack is empty")
                RadioButton4.Checked = False

            Else

                TextBox2.Visible = True
                Label2.Visible = True
                'TextBox3.Visible = True
                Label2.Text = "enter the element value"
                'Label3.Visible = True
                If TextBox2.Text = "" Then
                    MsgBox("enter the element")
                    RadioButton4.Checked = False
                Else

                    'Label2.Visible = True
                    TextBox3.Text = st.Contains(TextBox2.Text)
                    MsgBox("Result : " + TextBox3.Text)
                    RadioButton4.Checked = False
                    TextBox3.Visible = False
                    Label3.Visible = False
                    Label2.Visible = False
                    TextBox2.Visible = False
                    TextBox2.Text = ""

                End If

            End If
        Else
            
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            st.Clear()
        Else
            RadioButton6.Checked = False
        End If
    End Sub
End Class