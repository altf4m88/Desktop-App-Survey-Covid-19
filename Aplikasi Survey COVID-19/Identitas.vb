Public Class Identitas
    Dim thesql As String
    Dim jk As String

    Sub calldata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tabel_survey", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tabel_survey")
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


    Private Sub Identitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call konek()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        MainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong")

        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Pilih Jenis Kelamin")
        Else
            thesql = "insert into tabel_survey (Nama,Jenis_Kelamin,Umur) values('" & TextBox1.Text & "','" & jk & "','" & TextBox2.Text & "')"
            MsgBox("Success")
            Call run()
            Call calldata()
            Button3.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        jk = RadioButton1.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        jk = RadioButton2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Survey.Show()
        Me.Hide()
    End Sub
End Class