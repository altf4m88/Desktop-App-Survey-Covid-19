Public Class Hasil
    Dim jk As String
    Dim thesql As String

    Sub resetform()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Label5.Text = ""
        DS.Clear()
        DA.Fill(DS, "tabel_survey")
        DataGridView1.DataSource = DS.Tables("tabel_survey")
        DataGridView1.Enabled = True
    End Sub

    Sub calldata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tabel_survey", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tabel_survey")
        DataGridView1.DataSource = DS.Tables("tabel_survey")
        DataGridView1.Enabled = True
    End Sub

    Sub refreshtab()
        DS.Clear()
        DA.Fill(DS, "tabel_survey")
        DataGridView1.DataSource = DS.Tables("tabel_survey")
        DataGridView1.Enabled = True
    End Sub

    Sub run()
        Dim cmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = thesql
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub


    Private Sub Hasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call konek()
        Call calldata()
        Timer1.Enabled = True
        Me.CenterToScreen()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        GroupBox1.Enabled = True
        Update.Enabled = True
        Hapus.Enabled = True

    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        Call resetform()
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call refreshtab()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox3.Text = DataGridView1.Item(0, i).Value
        TextBox1.Text = DataGridView1.Item(1, i).Value
        If DataGridView1.Item(2, i).Value = "Laki - Laki" Then
            RadioButton1.Checked = True
        ElseIf DataGridView1.Item(2, i).Value = "Perempuan" Then
            RadioButton2.Checked = True
        End If
        TextBox2.Text = DataGridView1.Item(4, i).Value

        Label5.Text = DataGridView1.Item(5, i).Value
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles Hapus.Click
        thesql = "DELETE from tabel_survey where NIK='" & Val(TextBox3.Text) & "'"
        Call run()
        MsgBox("Data menghilang tanpa jejak")
        Call calldata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Label5.Text = ""
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        thesql = "UPDATE tabel_survey set Nama='" & TextBox1.Text & "',Umur='" & TextBox2.Text & "', Jenis_Kelamin='" & jk & "' where NIK='" & TextBox3.Text & "'"
        Call run()
        MsgBox("Data Berhasil Terubah")
        Call calldata()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        jk = "Laki - Laki"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        jk = "Perempuan"
    End Sub

End Class