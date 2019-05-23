Public Class Form1
    Dim xkiller As New List(Of String)
    Dim a, b, c, d, t As Integer
    Dim r As New Random
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub
    Function Random(ByRef length As Integer) As String
        Dim xxx As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim str As String = ""
        For i As Integer = 0 To length - 1
            Dim indx As Integer = r.Next(0, xxx.Length)
            str &= xxx(indx)
        Next
        Return str
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a As String = Random(4)
        Dim b As String = Random(4)
        Dim c As String = Random(4)
        Dim d As String = Random(4)
        Dim t As String = Random(4)
        If xkiller.Contains(a) And xkiller.Contains(b) And xkiller.Contains(c) And xkiller.Contains(d) And xkiller.Contains(t) Then
        End If
        ListBox1.Items.Add(a & "-" & b & "-" & c & "-" & d & "-" & t)
        Label1.Text = ListBox1.Items.Count
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub
    Private Sub SaveListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveListToolStripMenuItem.Click
     Dim SetSave As SaveFileDialog = New SaveFileDialog
        Dim i As Integer
        SetSave.FileName = "X-KILLER" + "    " + Label1.Text
        SetSave.Title = "Save SET.txt"
        SetSave.Filter = "SET.txt File (*.txt)|*.txt"
        If SetSave.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim s As New IO.StreamWriter(SetSave.FileName, True)
            For i = 0 To ListBox1.Items.Count - 1
                s.WriteLine(ListBox1.Items.Item(i))
            Next
            s.Close()
        End If
    End Sub
End Class
