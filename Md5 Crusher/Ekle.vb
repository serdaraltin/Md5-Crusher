Public Class Ekle

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.ListBox1.Items.Add(TextBox1.Text)
        Form1.Label9.Text = "Şifre : " + Form1.ListBox1.Items.Count.ToString
    End Sub
End Class