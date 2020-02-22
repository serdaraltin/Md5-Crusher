Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Public Class Form1
    Dim sıra As Integer = 0
    Dim md5 As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  MessageBox.Show("Md5 Crusher DeadSound tarafından kodlanmıştır" + Environment.NewLine + "Oluşabilecek hatalardan sorumlu değilim.")
        Label9.Text = "Şifre : " + ListBox1.Items.Count.ToString
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Ekle.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (ListBox1.Items.Count > 0) Then
            Dim silme As DialogResult
            silme = MessageBox.Show("Liste temizlensin mi ?", "Md5 Crusher", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (silme = DialogResult.Yes) Then
                ListBox1.Items.Clear()
            End If
        End If
        OpenFileDialog1.FileName = "Md5 Şifre Listesi"
        OpenFileDialog1.Title = "Dosya Seç"
        OpenFileDialog1.Filter = "Text Dosyaları|*.txt|Tüm Dosylar|*.*"
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            Dim oku As StreamReader
            oku = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)
            Dim sifre As String = oku.ReadLine
            While (sifre <> "")
                ListBox1.Items.Add(sifre)
                sifre = oku.ReadLine
            End While
        End If
        Label9.Text = "Şifre : " + ListBox1.Items.Count.ToString
    End Sub

    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        Try
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        Catch ex As Exception

        End Try
        Label9.Text = "Şifre : " + ListBox1.Items.Count.ToString
    End Sub

    Private Sub EkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EkleToolStripMenuItem.Click
        Ekle.ShowDialog()
    End Sub

    Private Sub DosyadanÇekToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button1.PerformClick()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = Clipboard.GetText
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (ListBox1.Items.Count > 0 And TextBox1.Text <> "" And Button2.Text = "Kır") Then

            ProgressBar1.Maximum = ListBox1.Items.Count
            ProgressBar1.Value = 0
            Label6.Text = "0%"
            Button3.Enabled = True
            TextBox1.Enabled = False
            Button2.Enabled = False
            Button5.Enabled = False
            Timer1.Enabled = True
            GroupBox1.Enabled = False
        End If
        If (Button2.Text = "Devam") Then
            Timer1.Enabled = True
            Button2.Enabled = False
            Button3.Enabled = True
        End If
     
    End Sub
    Public Function md5generator(ByRef sifre As String) As String
        Try
            Dim sifreleme As New System.Security.Cryptography.MD5CryptoServiceProvider
            Dim bytes As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(sifre)
            Dim hash As Byte() = sifreleme.ComputeHash(bytes)
            Dim kapasite As Integer = (hash.Length * 2 + (hash.Length / 8))
            Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder(kapasite)
            Dim I As Integer
            For I = 0 To hash.Length - 1
                sb.Append(BitConverter.ToString(hash, I, 1))
            Next
            Return sb.ToString().TrimEnd(New Char() {""})
        Catch ex As Exception
            Return "0"
        End Try
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim a As Integer = Convert.ToInt32((ProgressBar1.Maximum - ProgressBar1.Value) / 100)
        Label11.Text = a.ToString + " sn"
        Try
            md5 = md5generator(ListBox1.Items(sıra))
            md5 = md5.ToLower
            ListBox1.SelectedIndex = sıra
        Catch ex As Exception
        End Try
        If (sıra = ListBox1.Items.Count) Then
            Timer1.Enabled = False
            Label3.Text = "Denenen Şifre :"
            TextBox2.Text = ""
            Label6.Text = "0%"
            Label8.Text = "0/0"
            Label11.Text = "0 sn"
            Label10.Text = "..."
            Label10.ForeColor = Color.White
            ProgressBar1.Value = 0
            ListBox1.SelectedIndex = 0
            Button2.Enabled = True
            Button5.Enabled = True
            GroupBox1.Enabled = True
            Button6.Enabled = False
            TextBox1.Enabled = True
            MessageBox.Show("Malesef Şifre Kırılamadı!", "Md5 Crusher", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            sıra = 0
        End If
        If (TextBox1.Text = md5) Then
            Timer1.Enabled = False
            MessageBox.Show("Md5 Şifresi Kırıldı" + Environment.NewLine + "Md5 :" + md5 + Environment.NewLine + "Şifre :" + ListBox1.Items(sıra) + Environment.NewLine + "Süre : " + Convert.ToInt32((ProgressBar1.Maximum / 100) - a).ToString + " sn", "Md5 Crusher", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button2.Enabled = True
            Button5.Enabled = True
            GroupBox1.Enabled = True
            Button6.Enabled = True
            TextBox1.Enabled = True
            Label10.Text = md5
            Label10.Text = "..."
            Label10.ForeColor = Color.White
            TextBox2.Text = ""
            TextBox2.Text = ListBox1.Items(sıra)
            ProgressBar1.Value = 0
            Label6.Text = "0%"
            Label8.Text = "0/0"
            Label11.Text = "0 sn"
            Label3.Text = "Denenen Şifre :"
            sıra = 0
        Else
            Label10.ForeColor = Color.Red
            Label3.Text = "Denene Şifre : " + ListBox1.Items(sıra)
            Label10.Text = md5
            Label8.Text = sıra.ToString + "/" + ProgressBar1.Maximum.ToString
            ProgressBar1.Value = sıra
            Label6.Text = Convert.ToInt32(100 / (ProgressBar1.Maximum / ProgressBar1.Value)).ToString + "%"
            sıra += 1
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (Timer1.Enabled = True And ProgressBar1.Value <> 0) Then
            Timer1.Enabled = False
            Button2.Text = "Devam"
            Button3.Enabled = False
            Button2.Enabled = True
        End If
    
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        ListBox1.Items.Clear()
        Label9.Text = "Şifre : " + ListBox1.Items.Count.ToString
    End Sub

    Private Sub DosyaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DosyaToolStripMenuItem.Click
        Button1.PerformClick()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (Timer1.Enabled = True) Then
            Timer1.Enabled = False
            Button2.Enabled = True
            Button5.Enabled = True
            sıra = 0
            GroupBox1.Enabled = True
            Button6.Enabled = False
            TextBox1.Enabled = True
            ProgressBar1.Value = 0
            Label10.Text = "..."
            Label10.ForeColor = Color.White
            Label3.Text = "Denenen Şifre :"
            TextBox2.Text = ""
            Label6.Text = "0%"
            Label8.Text = "0/0"
            Label11.Text = "0 sn"
            ListBox1.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Clipboard.SetText(TextBox2.Text)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim salla As New Random
        Label12.ForeColor = Color.FromArgb((salla.Next(0, 255)), (salla.Next(0, 255)), (salla.Next(0, 255)))
    End Sub
End Class
