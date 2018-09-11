Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("please select one option")
        Else
            If RadioButton1.Checked = True Then
                Stackop.Show()
                Me.Hide()
            Else
                Me.Hide()
                Queueop.Show()
            End If
            
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = False
        RadioButton2.Checked = False

    End Sub
End Class
