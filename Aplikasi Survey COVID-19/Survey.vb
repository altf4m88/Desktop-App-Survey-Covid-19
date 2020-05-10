Public Class Survey

    Dim Jum_Check As Integer
    Dim Total_Check As Integer
    Dim thesql As String
    Dim jk As String
    Dim index As Integer
    Dim risk As String


    Sub resetform()
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        CheckBox8.Enabled = False
        CheckBox9.Enabled = False
        CheckBox10.Enabled = False

        CheckBox1.Visible = True
        CheckBox2.Visible = True
        CheckBox3.Visible = True
        CheckBox4.Visible = True
        CheckBox5.Visible = True
        CheckBox6.Visible = True
        CheckBox7.Visible = True
        CheckBox8.Visible = True
        CheckBox9.Visible = True
        CheckBox10.Visible = True

        Label1.Text = "A. Potensi tertular di luar rumah"
        CheckBox1.Text = "1. Saya pergi keluar rumah"
        CheckBox2.Text = "2. Saya menggunakan transportasi umum"
        CheckBox3.Text = "3. Saya tidak menggunakan masker saat berkumpul dengan orang lain"
        CheckBox4.Text = "4. Saya berjabat tangan dengan orang lain"
        CheckBox8.Text = "5. Saya menyentuh benda/uang yang juga disentuh orang lain"
        CheckBox7.Text = "6. Saya tidak menjaga jarak minimal 1,5 meter dengan orang lain"
        CheckBox5.Text = "7. Saya makan diluar rumah ( warung / restaurant)"
        CheckBox6.Text = "8. Saya tidak membersihkan tangan dengan hand sanitizer"
        CheckBox9.Text = "9. Saya tidak minum air hangat dan cuci tangan ketika sampai tujuan"
        CheckBox10.Text = "10. Saya tinggal satu wilayah dengan  pasien yang tertular"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False

        index = 0
        Jum_Check = 0
        Total_Check = 0

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        RadioButton1.Checked = False
        RadioButton2.Checked = False

        Button1.Text = "Selanjutnya"
        GrupSurvey.Enabled = False
        GroupBox1.Enabled = True
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
        CheckBox5.Enabled = True
        CheckBox6.Enabled = True
        CheckBox7.Enabled = True
        CheckBox8.Enabled = True
        CheckBox9.Enabled = True
        CheckBox10.Enabled = True

        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Label7.Visible = False
    End Sub

    Sub resetsurvey()
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox5.Enabled = False
        CheckBox6.Enabled = False
        CheckBox7.Enabled = False
        CheckBox8.Enabled = False
        CheckBox9.Enabled = False
        CheckBox10.Enabled = False

        CheckBox1.Visible = True
        CheckBox2.Visible = True
        CheckBox3.Visible = True
        CheckBox4.Visible = True
        CheckBox5.Visible = True
        CheckBox6.Visible = True
        CheckBox7.Visible = True
        CheckBox8.Visible = True
        CheckBox9.Visible = True
        CheckBox10.Visible = True

        Label1.Text = "A. Potensi tertular di luar rumah"
        CheckBox1.Text = "1. Saya pergi keluar rumah"
        CheckBox2.Text = "2. Saya menggunakan transportasi umum"
        CheckBox3.Text = "3. Saya tidak menggunakan masker saat berkumpul dengan orang lain"
        CheckBox4.Text = "4. Saya berjabat tangan dengan orang lain"
        CheckBox8.Text = "5. Saya menyentuh benda/uang yang juga disentuh orang lain"
        CheckBox7.Text = "6. Saya tidak menjaga jarak minimal 1,5 meter dengan orang lain"
        CheckBox5.Text = "7. Saya makan diluar rumah ( warung / restaurant)"
        CheckBox6.Text = "8. Saya tidak membersihkan tangan dengan hand sanitizer"
        CheckBox9.Text = "9. Saya tidak minum air hangat dan cuci tangan ketika sampai tujuan"
        CheckBox10.Text = "10. Saya tinggal satu wilayah dengan  pasien yang tertular"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False

        index = 0
        Jum_Check = 0
        Total_Check = 0

        TextBox3.Text = 0
        Button1.Text = "Selanjutnya"
        GrupSurvey.Enabled = False
        GroupBox1.Enabled = True
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
        CheckBox5.Enabled = True
        CheckBox6.Enabled = True
        CheckBox7.Enabled = True
        CheckBox8.Enabled = True
        CheckBox9.Enabled = True
        CheckBox10.Enabled = True


        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Label7.Visible = False
    End Sub


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


    Private Sub SurveyPt1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call konek()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainMenu.Show()
        Call resetform()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Jum_Check += 1
            TextBox3.Text = Jum_Check
        ElseIf CheckBox1.Checked = False Then
            Jum_Check -= 1
            TextBox3.Text = Jum_Check
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Jum_Check += 1
            TextBox3.Text = Jum_Check
        ElseIf CheckBox2.Checked = False Then
            Jum_Check -= 1
            TextBox3.Text = Jum_Check
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Jum_Check += 1
            TextBox3.Text = Jum_Check
        ElseIf CheckBox3.Checked = False Then
            Jum_Check -= 1
            TextBox3.Text = Jum_Check
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Jum_Check += 1
            TextBox3.Text = Jum_Check
        ElseIf CheckBox4.Checked = False Then
            Jum_Check -= 1
            TextBox3.Text = Jum_Check
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            Jum_Check += 1
            TextBox3.Text = Jum_Check
        ElseIf CheckBox8.Checked = False Then
            Jum_Check -= 1
            TextBox3.Text = Jum_Check
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            Jum_Check += 1
            TextBox3.Text = Jum_Check
        ElseIf CheckBox7.Checked = False Then
            Jum_Check -= 1
            TextBox3.Text = Jum_Check
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Jum_Check += 1
            TextBox3.Text = Jum_Check
        ElseIf CheckBox5.Checked = False Then
            Jum_Check -= 1
            TextBox3.Text = Jum_Check
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            Jum_Check += 1
            TextBox3.Text = Jum_Check
        ElseIf CheckBox6.Checked = False Then
            Jum_Check -= 1
            TextBox3.Text = Jum_Check
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            Jum_Check += 1
            TextBox3.Text = Jum_Check
        ElseIf CheckBox9.Checked = False Then
            Jum_Check -= 1
            TextBox3.Text = Jum_Check
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            Jum_Check += 1
            TextBox3.Text = Jum_Check
        ElseIf CheckBox10.Checked = False Then
            Jum_Check -= 1
            TextBox3.Text = Jum_Check
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ask As MsgBoxResult = MsgBox("Apakah anda yakin?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            index += 1
            If index = 1 Then

                Total_Check += Jum_Check

                Label1.Text = "B. Potensi Tertular dalam rumah"
                CheckBox1.Text = "11. Saya tidak memasang hand sanitizer didepan pintu rumah"
                CheckBox2.Text = "12. Saya tidak mencuci tangan dengan sabun setelah tiba di rumah"
                CheckBox3.Text = "13. Saya tidak menyediakan tissue basah, masker atau sabun anti septic di rumah"
                CheckBox4.Text = "14. Saya tidak segera mandi keramas setelah saya tiba di rumah"
                CheckBox8.Text = "15. Saya tidak mensosialisasikan survey ini kepada anggota keluarga lainnya"
                CheckBox7.Text = "16. Saya tidak segera merendam baju & celana bekas pakai di luar rumah dengan sabun"


                CheckBox5.Enabled = False
                CheckBox6.Enabled = False
                CheckBox9.Enabled = False
                CheckBox10.Enabled = False
                CheckBox10.Visible = False
                CheckBox9.Visible = False
                CheckBox5.Visible = False
                CheckBox6.Visible = False
                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox8.Checked = False
                CheckBox7.Checked = False

                CheckBox1.Enabled = True
                CheckBox2.Enabled = True
                CheckBox3.Enabled = True
                CheckBox4.Enabled = True
                CheckBox8.Enabled = True
                CheckBox7.Enabled = True

                Jum_Check = Total_Check
                TextBox3.Text = Jum_Check
            ElseIf index = 2 Then
                Total_Check = Jum_Check

                Label1.Text = "C. Daya Tahan Tubuh (Imunitas)"
                CheckBox1.Text = "17. Saya dalam sehari tidak terkena cahaya matahari minimal 15 menit"
                CheckBox2.Text = "18. Saya tidak berolahraga minimal 30 menit setiap hari "
                CheckBox3.Text = "19. Saya kurang asupan Vitamin C dan E, serta kurang tidur"
                CheckBox4.Text = "20. Usia saya diatas 60 tahun"
                CheckBox8.Text = "21. Saya mengidap penyakit : jantung / diabetes / ISPA"

                CheckBox7.Visible = False
                CheckBox1.Checked = False
                CheckBox2.Checked = False
                CheckBox3.Checked = False
                CheckBox4.Checked = False
                CheckBox8.Checked = False

                CheckBox1.Enabled = True
                CheckBox2.Enabled = True
                CheckBox3.Enabled = True
                CheckBox4.Enabled = True
                CheckBox8.Enabled = True
                Button1.Text = "Selesai"
                Jum_Check = Total_Check
                TextBox3.Text = Jum_Check


            ElseIf index = 3 Then
                Total_Check = Jum_Check

                If Total_Check >= 15 Then
                    risk = "Risiko Tinggi"
                ElseIf Total_Check >= 8 Then
                    risk = "Risiko Sedang"
                Else
                    risk = "Risiko Rendah"
                End If

                thesql = "insert into tabel_survey (Nama,Jenis_Kelamin,Umur,Jumlah_Checklist,Risiko,NIK) values('" & TextBox1.Text & "','" & jk & "','" & TextBox2.Text & "','" & Total_Check & "','" & risk & "','" & TextBox4.Text & "')"
                Call run()
                MsgBox("Data Berhasil Tersimpan")
                Call calldata()
                Hasil.Show()
                Call resetform()
                Me.Hide()

            End If


            End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        jk = RadioButton1.Text
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        jk = RadioButton2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong")

        ElseIf IsNumeric(TextBox2.Text) = False Or IsNumeric(TextBox4.Text) = False Then
            MsgBox("NIK dan Umur harus angka")

        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Pilih Jenis Kelamin")
        Else
            GrupSurvey.Enabled = True
            Button1.Enabled = True
            GroupBox1.Enabled = False
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox4.BringToFront()
            Label7.Visible = True
            Label7.BringToFront()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call resetsurvey()
    End Sub
End Class